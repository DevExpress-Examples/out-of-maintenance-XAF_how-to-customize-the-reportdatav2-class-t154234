Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.ReportsV2.Win
Imports CustomizeReportDataExample.Module.BusinessObjects


Namespace CustomizeReportDataExample.Module.Win
    Public Class ReportWizardModifyController
        Inherits ViewController

        Private reportServiceController As WinReportServiceController
        Public Sub New()
        End Sub
        Protected Overrides Sub OnActivated()
            MyBase.OnActivated()
            reportServiceController = Frame.GetController(Of WinReportServiceController)()
            AddHandler reportServiceController.NewXafReportWizardShowing, AddressOf reportServiceController_NewXafReportWizardShowing
        End Sub
        Protected Overrides Sub OnDeactivated()
            RemoveHandler reportServiceController.NewXafReportWizardShowing, AddressOf reportServiceController_NewXafReportWizardShowing
            reportServiceController = Nothing
            MyBase.OnDeactivated()
        End Sub
        Private Sub reportServiceController_NewXafReportWizardShowing(ByVal sender As Object, ByVal e As NewXafReportWizardShowingEventArgs)
            If Not e.ReportDataType.Equals(GetType(MyReportDataV2)) Then
                Return
            End If
            Dim newReportParamsObject As New CustomReportWizardParameters(e.WizardParameters.Report, e.WizardParameters.ReportDataType)
            newReportParamsObject.Category = "Default"
            e.WizardParameters = newReportParamsObject
        End Sub
    End Class
End Namespace
