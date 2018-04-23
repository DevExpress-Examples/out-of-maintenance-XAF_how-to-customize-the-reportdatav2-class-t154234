Imports System.Linq
Imports System.Text
Imports DevExpress.ExpressApp.DC
Imports DevExpress.ExpressApp.ReportsV2
Imports DevExpress.ExpressApp.ReportsV2.Win
Imports DevExpress.XtraReports.UI
Imports CustomizeReportDataExample.Module.BusinessObjects


Namespace CustomizeReportDataExample.Module.Win
    <DomainComponent> _
    Public Class CustomReportWizardParameters
        Inherits NewReportWizardParameters

        Public Sub New(ByVal report As XtraReport, ByVal reportDataType As Type)
            MyBase.New(report, reportDataType)
        End Sub
        Public Property Category() As String
        Public Overrides Sub AssignData(ByVal reportData As IReportDataV2Writable)
            MyBase.AssignData(reportData)
            If TypeOf reportData Is MyReportDataV2 Then
                CType(reportData, MyReportDataV2).Category = Category
            End If
        End Sub
    End Class
End Namespace
