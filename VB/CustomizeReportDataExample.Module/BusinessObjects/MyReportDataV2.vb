Imports System.Linq
Imports System.Text
Imports DevExpress.Xpo

Namespace CustomizeReportDataExample.Module.BusinessObjects
    Public Class MyReportDataV2
        Inherits DevExpress.Persistent.BaseImpl.ReportDataV2

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
'INSTANT VB NOTE: The variable category was renamed since Visual Basic does not allow variables and other class members to have the same name:
        Private _category As String
        Public Property Category() As String
            Get
                Return _category
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Category", _category, value)
            End Set
        End Property
    End Class
End Namespace
