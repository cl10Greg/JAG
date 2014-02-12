Imports System.Text

Public Class loginClass
    Private pUserName As String
    Private pUserPass As String

    Public Property userName() As String
        Get
            Return pUserName
        End Get
        Set(value As String)
            pUserName = value
        End Set
    End Property

    Public Property userPass() As String
        Get
            Return pUserPass
        End Get
        Set(value As String)
            pUserPass = value
        End Set
    End Property

    Public Function checkData() As Boolean
        If pUserName = "" Or pUserPass = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function randomPass() As String
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 12
            Dim idx As Int16 = r.Next(0, s.Length())
            sb.Append(s.Substring(idx, 1))
        Next

        Return sb.ToString
    End Function
End Class
