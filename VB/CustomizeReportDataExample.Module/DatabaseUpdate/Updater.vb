Imports System
Imports System.Linq
Imports DevExpress.ExpressApp
Imports DevExpress.Data.Filtering
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.Updating
Imports DevExpress.Xpo
Imports DevExpress.ExpressApp.Xpo
Imports DevExpress.Persistent.BaseImpl
Imports CustomizeReportDataExample.Module.BusinessObjects

Namespace CustomizeReportDataExample.Module.DatabaseUpdate
    ' For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppUpdatingModuleUpdatertopic
    Public Class Updater
        Inherits ModuleUpdater

        Public Sub New(ByVal objectSpace As IObjectSpace, ByVal currentDBVersion As Version)
            MyBase.New(objectSpace, currentDBVersion)
        End Sub
        Public Overrides Sub UpdateDatabaseAfterUpdateSchema()
            MyBase.UpdateDatabaseAfterUpdateSchema()
            If ObjectSpace.GetObjectsCount(GetType(Contact), Nothing) = 0 Then
                Dim mary As Contact = ObjectSpace.CreateObject(Of Contact)()
                mary.Name = "Mary"
                mary.Email = "mary@example.com"
                Dim john As Contact = ObjectSpace.CreateObject(Of Contact)()
                john.Name = "John"
                john.Email = "john@example.com"
            End If
            For Each reportData As MyReportDataV2 In ObjectSpace.GetObjects(Of MyReportDataV2)()
                If (reportData.IsPredefined) AndAlso String.IsNullOrEmpty(reportData.Category) Then
                    reportData.Category = "Predefined"
                End If
            Next reportData
        End Sub
        Public Overrides Sub UpdateDatabaseBeforeUpdateSchema()
            MyBase.UpdateDatabaseBeforeUpdateSchema()
            'if(CurrentDBVersion < new Version("1.1.0.0") && CurrentDBVersion > new Version("0.0.0.0")) {
            '    RenameColumn("DomainObject1Table", "OldColumnName", "NewColumnName");
            '}
        End Sub
    End Class
End Namespace
