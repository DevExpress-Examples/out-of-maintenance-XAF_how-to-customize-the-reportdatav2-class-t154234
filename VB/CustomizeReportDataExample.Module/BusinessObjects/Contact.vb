Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.Persistent.Base
Imports DevExpress.Persistent.BaseImpl
Imports DevExpress.Xpo

Namespace CustomizeReportDataExample.Module.BusinessObjects
    <DefaultClassOptions, ImageName("BO_Contact")> _
    Public Class Contact
        Inherits BaseObject

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Property Name() As String
        Public Property Email() As String
    End Class
End Namespace
