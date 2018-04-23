Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.ReportsV2.Web
Imports CustomizeReportDataExample.Module.BusinessObjects

Namespace CustomizeReportDataExample.Module.Web
    Public Class ReportWizardModifyController
        Inherits ViewController

        Private reportServiceController As WebReportServiceController
        Public Sub New()
        End Sub
        Protected Overrides Sub OnActivated()
            MyBase.OnActivated()
            reportServiceController = Frame.GetController(Of WebReportServiceController)()
            AddHandler reportServiceController.NewReportWizardShowing, AddressOf reportServiceController_NewReportWizardShowing
        End Sub
        Protected Overrides Sub OnDeactivated()
            RemoveHandler reportServiceController.NewReportWizardShowing, AddressOf reportServiceController_NewReportWizardShowing
            reportServiceController = Nothing
            MyBase.OnDeactivated()
        End Sub
        Private Sub reportServiceController_NewReportWizardShowing(ByVal sender As Object, ByVal e As WebNewReportWizardShowingEventArgs)
            If Not e.ReportDataType.Equals(GetType(MyReportDataV2)) Then
                Return
            End If
            Dim newReportParamsObject As New CustomReportWizardParameters(e.WizardParameters.Report, e.WizardParameters.ReportDataType)
            newReportParamsObject.Category = "Default"
            e.WizardParameters = newReportParamsObject
        End Sub
    End Class
End Namespace
