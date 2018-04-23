Imports System
Imports DevExpress.ExpressApp
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Web
Imports System.Collections.Generic
Imports DevExpress.ExpressApp.Xpo

Namespace CustomizeReportDataExample.Web
    ' For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/DevExpressExpressAppWebWebApplicationMembersTopicAll
    Partial Public Class CustomizeReportDataExampleAspNetApplication
        Inherits WebApplication

        Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
        Private module2 As DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule
        Private reportsModuleV21 As DevExpress.ExpressApp.ReportsV2.ReportsModuleV2
        Private reportsAspNetModuleV21 As DevExpress.ExpressApp.ReportsV2.Web.ReportsAspNetModuleV2
        Private module3 As CustomizeReportDataExample.Module.CustomizeReportDataExampleModule
        Private module4 As CustomizeReportDataExample.Module.Web.CustomizeReportDataExampleAspNetModule

        Public Sub New()
            InitializeComponent()
        End Sub
        Protected Overrides Sub CreateDefaultObjectSpaceProvider(ByVal args As CreateCustomObjectSpaceProviderEventArgs)
            args.ObjectSpaceProvider = New XPObjectSpaceProvider(args.ConnectionString, args.Connection)
        End Sub
        Private Sub CustomizeReportDataExampleAspNetApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
            e.Updater.Update()
            e.Handled = True
        End Sub
        Private Sub InitializeComponent()
            Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
            Me.module2 = New DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule()
            Me.reportsModuleV21 = New DevExpress.ExpressApp.ReportsV2.ReportsModuleV2()
            Me.module3 = New CustomizeReportDataExample.Module.CustomizeReportDataExampleModule()
            Me.module4 = New CustomizeReportDataExample.Module.Web.CustomizeReportDataExampleAspNetModule()
            Me.reportsAspNetModuleV21 = New DevExpress.ExpressApp.ReportsV2.Web.ReportsAspNetModuleV2()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' reportsModuleV21
            ' 
            Me.reportsModuleV21.EnableInplaceReports = True
            Me.reportsModuleV21.ReportDataType = GetType(CustomizeReportDataExample.Module.BusinessObjects.MyReportDataV2)
            ' 
            ' CustomizeReportDataExampleAspNetApplication
            ' 
            Me.ApplicationName = "CustomizeReportDataExample"
            Me.Modules.Add(Me.module1)
            Me.Modules.Add(Me.module2)
            Me.Modules.Add(Me.reportsModuleV21)
            Me.Modules.Add(Me.module3)
            Me.Modules.Add(Me.module4)
            Me.Modules.Add(Me.reportsAspNetModuleV21)
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
    End Class
End Namespace
