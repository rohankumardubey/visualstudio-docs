'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.17348
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On



'''
<Microsoft.VisualStudio.Tools.Applications.Runtime.StartupObjectAttribute(1), _
 Global.System.Security.Permissions.PermissionSetAttribute(Global.System.Security.Permissions.SecurityAction.Demand, Name:="FullTrust")> _
Partial Public NotInheritable Class Sheet1
    Inherits Microsoft.Office.Tools.Excel.WorksheetBase

    Friend WithEvents dataChart As Microsoft.Office.Tools.Excel.Chart

    Friend WithEvents textFont As Microsoft.Office.Tools.Excel.NamedRange

    Friend WithEvents ChartOptions1 As My_Excel_Chart_ChartOptions

    Friend WithEvents applyBoldFont As Microsoft.Office.Tools.Excel.Controls.CheckBox

    Friend WithEvents applyItalicFont As Microsoft.Office.Tools.Excel.Controls.CheckBox

    Friend WithEvents applyUnderlineFont As Microsoft.Office.Tools.Excel.Controls.CheckBox

    Friend WithEvents displayText As Microsoft.Office.Tools.Excel.Controls.TextBox

    Friend WithEvents insertText As Microsoft.Office.Tools.Excel.Controls.Button

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Public Sub New(ByVal factory As Global.Microsoft.Office.Tools.Excel.Factory, ByVal serviceProvider As Global.System.IServiceProvider)
        MyBase.New(factory, serviceProvider, "Sheet1", "Sheet1")
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Protected Overrides Sub Initialize()
        MyBase.Initialize()
        Globals.Sheet1 = Me
        Global.System.Windows.Forms.Application.EnableVisualStyles()
        Me.InitializeCachedData()
        Me.InitializeControls()
        Me.InitializeComponents()
        Me.InitializeData()
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Protected Overrides Sub FinishInitialization()
        Me.OnStartup()
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Protected Overrides Sub InitializeDataBindings()
        Me.BeginInitialization()
        Me.BindToData()
        Me.EndInitialization()
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Private Sub InitializeCachedData()
        If (Me.DataHost Is Nothing) Then
            Return
        End If
        If Me.DataHost.IsCacheInitialized Then
            Me.DataHost.FillCachedData(Me)
        End If
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Private Sub InitializeData()
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Private Sub BindToData()
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Sub StartCaching(ByVal MemberName As String)
        Me.DataHost.StartCaching(Me, MemberName)
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Sub StopCaching(ByVal MemberName As String)
        Me.DataHost.StopCaching(Me, MemberName)
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Function IsCached(ByVal MemberName As String) As Boolean
        Return Me.DataHost.IsCached(Me, MemberName)
    End Function

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Private Sub BeginInitialization()
        Me.BeginInit()
        Me.dataChart.BeginInit()
        Me.textFont.BeginInit()
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Private Sub EndInitialization()
        Me.textFont.EndInit()
        Me.dataChart.EndInit()
        Me.EndInit()
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Private Sub InitializeControls()
        Me.dataChart = Globals.Factory.CreateChart(Nothing, Nothing, "Sheet1:Chart 1", "dataChart", Me)
        Me.textFont = Globals.Factory.CreateNamedRange(Nothing, Nothing, "NamedRange1", "textFont", Me)
        Me.ChartOptions1 = New My_Excel_Chart_ChartOptions(Globals.Factory, Me.ItemProvider, Me.HostContext, "1E04E273F1240014D701821219D547147C5841", "1E04E273F1240014D701821219D547147C5841", Me, "ChartOptions1")
        Me.applyBoldFont = New Microsoft.Office.Tools.Excel.Controls.CheckBox(Globals.Factory, Me.ItemProvider, Me.HostContext, "2708421192E98A24224291E82324857BC2B4B2", "2708421192E98A24224291E82324857BC2B4B2", Me, "applyBoldFont")
        Me.applyItalicFont = New Microsoft.Office.Tools.Excel.Controls.CheckBox(Globals.Factory, Me.ItemProvider, Me.HostContext, "3254A004B3F83E34D223BB6630D1E674985FD3", "3254A004B3F83E34D223BB6630D1E674985FD3", Me, "applyItalicFont")
        Me.applyUnderlineFont = New Microsoft.Office.Tools.Excel.Controls.CheckBox(Globals.Factory, Me.ItemProvider, Me.HostContext, "453A50D4C4B9EF4473C4AEC84684595644DC44", "453A50D4C4B9EF4473C4AEC84684595644DC44", Me, "applyUnderlineFont")
        Me.displayText = New Microsoft.Office.Tools.Excel.Controls.TextBox(Globals.Factory, Me.ItemProvider, Me.HostContext, "59A786D125163C54EB258351503D37C60BAB85", "59A786D125163C54EB258351503D37C60BAB85", Me, "displayText")
        Me.insertText = New Microsoft.Office.Tools.Excel.Controls.Button(Globals.Factory, Me.ItemProvider, Me.HostContext, "69BCCF5AA60A9364F25699BC65ED5047DF6F76", "69BCCF5AA60A9364F25699BC65ED5047DF6F76", Me, "insertText")
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Private Sub InitializeComponents()
        '
        'dataChart
        '
        Me.dataChart.DefaultDataSourceUpdateMode = System.Windows.Forms.DataSourceUpdateMode.Never
        '
        'ChartOptions1
        '
        Me.ChartOptions1.Name = "ChartOptions1"
        Me.ChartOptions1.Selection = Microsoft.Office.Interop.Excel.XlChartType.xlColumnClustered
        '
        'applyBoldFont
        '
        Me.applyBoldFont.Name = "applyBoldFont"
        Me.applyBoldFont.Text = "CheckBox1"
        '
        'applyItalicFont
        '
        Me.applyItalicFont.Name = "applyItalicFont"
        Me.applyItalicFont.Text = "CheckBox1"
        '
        'applyUnderlineFont
        '
        Me.applyUnderlineFont.Name = "applyUnderlineFont"
        Me.applyUnderlineFont.Text = "CheckBox1"
        '
        'displayText
        '
        Me.displayText.Name = "displayText"
        Me.displayText.Text = "TextBox1"
        '
        'insertText
        '
        Me.insertText.BackColor = System.Drawing.SystemColors.Control
        Me.insertText.ForeColor = System.Drawing.SystemColors.ControlText
        Me.insertText.Name = "insertText"
        Me.insertText.Text = "Button1"
        Me.insertText.UseVisualStyleBackColor = False
        '
        'Sheet1
        '
        Me.ChartOptions1.BindingContext = Me.BindingContext
        Me.applyBoldFont.BindingContext = Me.BindingContext
        Me.applyItalicFont.BindingContext = Me.BindingContext
        Me.applyUnderlineFont.BindingContext = Me.BindingContext
        Me.displayText.BindingContext = Me.BindingContext
        Me.insertText.BindingContext = Me.BindingContext
    End Sub

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Function NeedsFill(ByVal MemberName As String) As Boolean
        Return Me.DataHost.NeedsFill(Me, MemberName)
    End Function

    '''
    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0"), _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Never)> _
    Protected Overrides Sub OnShutdown()
        Me.textFont.Dispose()
        Me.dataChart.Dispose()
        MyBase.OnShutdown()
    End Sub
End Class

Partial Friend NotInheritable Class Globals

    Private Shared _Sheet1 As Sheet1

    Friend Shared Property Sheet1() As Sheet1
        Get
            Return _Sheet1
        End Get
        Set(value As Sheet1)
            If (_Sheet1 Is Nothing) Then
                _Sheet1 = value
            Else
                Throw New System.NotSupportedException()
            End If
        End Set
    End Property
End Class
