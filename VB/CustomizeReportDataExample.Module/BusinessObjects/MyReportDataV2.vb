Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Xpo

Namespace CustomizeReportDataExample.Module.BusinessObjects
    Public Class MyReportDataV2
        Inherits DevExpress.Persistent.BaseImpl.ReportDataV2

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Private category_Renamed As String
        Public Property Category() As String
            Get
                Return category_Renamed
            End Get
            Set(ByVal value As String)
                SetPropertyValue("Category", category_Renamed, value)
            End Set
        End Property
    End Class
End Namespace
