//<Snippet11>
using System;
using System.ComponentModel;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.SharePoint;

namespace Contoso.Examples.ProjectItemTypeWithProperty
{
    [Export(typeof(ISharePointProjectItemTypeProvider))]
    [SharePointProjectItemType("Contoso.ExampleProjectItemType")]
    [SharePointProjectItemIcon("ExampleProjectItemType.ProjectItemIcon.ico")]
    internal class ExampleProjectItemTypeWithProperty : ISharePointProjectItemTypeProvider
    {
        //<Snippet12>
        public void InitializeType(ISharePointProjectItemTypeDefinition projectItemTypeDefinition)
        {
            projectItemTypeDefinition.Name = "ExampleProjectItemType";
            projectItemTypeDefinition.SupportedDeploymentScopes =
                SupportedDeploymentScopes.Site | SupportedDeploymentScopes.Web;
            projectItemTypeDefinition.SupportedTrustLevels = SupportedTrustLevels.All;

            projectItemTypeDefinition.ProjectItemPropertiesRequested += 
                projectItemTypeDefinition_ProjectItemPropertiesRequested;
        }
        //</Snippet12>

        //<Snippet13>
        void projectItemTypeDefinition_ProjectItemPropertiesRequested(object sender, 
            SharePointProjectItemPropertiesRequestedEventArgs e)
        {
            CustomProperties property;

            // If the properties object already exists, get it from the project item's annotations.
            if (!e.ProjectItem.Annotations.TryGetValue(out property))
            {
                // Otherwise, create a new properties object and add it to the annotations.
                property = new CustomProperties(e.ProjectItem);
                e.ProjectItem.Annotations.Add(property);
            }

            e.PropertySources.Add(property);
        }
        //</Snippet13>
    }

    internal class CustomProperties
    {
        private ISharePointProjectItem projectItem;

        internal CustomProperties(ISharePointProjectItem projectItem)
        {
            this.projectItem = projectItem;
        }

        //<Snippet14>
        private const string PropertyId = "Contoso.ExampleProperty";
        private const string PropertyDefaultValue = "This is an example property.";

        [DisplayName("Example Property")]
        [DescriptionAttribute("This is an example property for project items.")]
        [DefaultValue(PropertyDefaultValue)]
        public string ExampleProperty
        {
            get
            {
                string propertyValue;

                // Get the current property value if it already exists; otherwise, return a default value.
                if (!projectItem.ExtensionData.TryGetValue(PropertyId, out propertyValue))
                {
                    propertyValue = PropertyDefaultValue;
                }
                return propertyValue;
            }
            set
            {
                if (value != PropertyDefaultValue)
                {
                    // Store the property value in the ExtensionData property of the project item. 
                    // Data in the ExtensionData property persists when the project is closed.
                    projectItem.ExtensionData[PropertyId] = value;
                }
                else
                {
                    // Do not save the default value.
                    projectItem.ExtensionData.Remove(PropertyId);
                }
            }
        }
        //</Snippet14>
    }
}
//</Snippet11>
