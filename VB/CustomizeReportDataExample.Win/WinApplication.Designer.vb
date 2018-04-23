Namespace CustomizeReportDataExample.Win
    Partial Public Class CustomizeReportDataExampleWindowsFormsApplication
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
            Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
            Me.reportsModuleV21 = New DevExpress.ExpressApp.ReportsV2.ReportsModuleV2()
            Me.scriptRecorderWindowsFormsModule1 = New DevExpress.ExpressApp.ScriptRecorder.Win.ScriptRecorderWindowsFormsModule()
            Me.scriptRecorderModuleBase1 = New DevExpress.ExpressApp.ScriptRecorder.ScriptRecorderModuleBase()
            Me.module3 = New CustomizeReportDataExample.Module.CustomizeReportDataExampleModule()
            Me.module4 = New CustomizeReportDataExample.Module.Win.CustomizeReportDataExampleWindowsFormsModule()
            Me.reportsWindowsFormsModuleV21 = New DevExpress.ExpressApp.ReportsV2.Win.ReportsWindowsFormsModuleV2()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' reportsModuleV21
            ' 
            Me.reportsModuleV21.EnableInplaceReports = True
            Me.reportsModuleV21.ReportDataType = GetType(CustomizeReportDataExample.Module.BusinessObjects.MyReportDataV2)
            ' 
            ' CustomizeReportDataExampleWindowsFormsApplication
            ' 
            Me.ApplicationName = "CustomizeReportDataExample"
            Me.Modules.Add(Me.module1)
            Me.Modules.Add(Me.module2)
            Me.Modules.Add(Me.reportsModuleV21)
            Me.Modules.Add(Me.module3)
            Me.Modules.Add(Me.module4)
            Me.Modules.Add(Me.scriptRecorderModuleBase1)
            Me.Modules.Add(Me.scriptRecorderWindowsFormsModule1)
            Me.Modules.Add(Me.reportsWindowsFormsModuleV21)
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
        Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
        Private module3 As CustomizeReportDataExample.Module.CustomizeReportDataExampleModule
        Private module4 As CustomizeReportDataExample.Module.Win.CustomizeReportDataExampleWindowsFormsModule
        Private reportsModuleV21 As DevExpress.ExpressApp.ReportsV2.ReportsModuleV2
        Private scriptRecorderWindowsFormsModule1 As DevExpress.ExpressApp.ScriptRecorder.Win.ScriptRecorderWindowsFormsModule
        Private scriptRecorderModuleBase1 As DevExpress.ExpressApp.ScriptRecorder.ScriptRecorderModuleBase
        Private reportsWindowsFormsModuleV21 As DevExpress.ExpressApp.ReportsV2.Win.ReportsWindowsFormsModuleV2
    End Class
End Namespace
