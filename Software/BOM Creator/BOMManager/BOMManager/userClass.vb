Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Text

Public Class userClass
    Private pUserName As String
    Private pUserPass As String
    Private pUserEmail As String
    Private pUserRole As String
    Private pFilePath As String
    Private pDecKey As String
    Private pFileExists As Boolean
    Private pFileEmpty As Boolean

    Public Function checkLoginData() As Boolean
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

    Public Property userName() As String
        Get
            Return pUserName
        End Get
        Set(value As String)
            pUserName = value
        End Set
    End Property

    Public Property userPassword() As String
        Get
            Return pUserPass
        End Get
        Set(value As String)
            pUserPass = value
        End Set
    End Property

    Public Property userEmail() As String
        Get
            Return pUserEmail
        End Get
        Set(value As String)
            pUserEmail = value
        End Set
    End Property

    Public Property userRole() As String
        Get
            Return pUserRole
        End Get
        Set(value As String)
            pUserRole = value
        End Set
    End Property

    Public Property userFile() As String
        Get
            Return pFilePath
        End Get
        Set(value As String)
            pFilePath = value
        End Set
    End Property

    Public Property userKey() As String
        Get
            Return pDecKey
        End Get
        Set(value As String)
            pDecKey = value
        End Set
    End Property

    Public Function checkNewUserData() As Boolean
        If pUserName = "" Or pUserPass = "" Or pUserEmail = "" Or pUserRole = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub getFileInfo()
        If File.Exists(pFilePath) Then
            pFileExists = True
        Else
            pFileExists = False
            pFileEmpty = True
            Exit Sub
        End If

        Dim tempContent As String
        Dim sr As New StreamReader(pFilePath)

        tempContent = sr.ReadToEnd
        sr.Close()

        If tempContent.Equals(String.Empty) Then
            pFileEmpty = True
        Else
            pFileEmpty = False
        End If
    End Sub

    Public Function getFileExists() As Boolean
        Return pFileExists
    End Function

    Public Function getFileContent() As Boolean
        Return pFileEmpty
    End Function

    Public Function checkEmail() As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailMatch As Match = Regex.Match(pUserEmail, pattern)
        If emailMatch.Success Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub writeNewUser()
        Dim wrapper As New Simple3Des(pDecKey)
        Dim userString As String = LCase(pUserName) & "," & pUserPass & "," & pUserEmail & "," & pUserRole
        Dim encText As String = wrapper.encryptData(userString)
        File.WriteAllText(pFilePath, encText & vbCrLf)
    End Sub

    Public Sub appendNewUser()
        Dim wrapper As New Simple3Des(pDecKey)
        Dim userString As String = LCase(pUserName) & "," & pUserPass & "," & pUserEmail & "," & pUserRole
        Dim encText As String = wrapper.encryptData(userString)
        File.AppendAllText(pFilePath, encText & vbCrLf)
    End Sub

    Public Function userExist() As Boolean
        Dim userTable As DataTable
        userTable = getUserTable()

        Dim foundRows() As DataRow
        Dim userSearch As String = "Username = '" & LCase(pUserName) & "'"
        foundRows = userTable.Select(userSearch)
        If foundRows.Length > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Function passValid() As Boolean
        Dim userTable As DataTable
        userTable = getUserTable()
        Dim foundRows() As DataRow
        Dim userSearch As String = "Username = '" & LCase(pUserName) & "'"

        foundRows = userTable.Select(userSearch)

        'Grab the password from the row
        If pUserPass.Equals(foundRows(0)("Password").ToString) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Function getUserTable() As DataTable
        Dim userSet As New DataTable
        Dim userRow As DataRow

        userSet.Columns.Add("Username", GetType(String))
        userSet.Columns.Add("Password", GetType(String))
        userSet.Columns.Add("Email", GetType(String))
        userSet.Columns.Add("Role", GetType(String))

        Dim tempContent As String
        Dim splitContent(3)
        Dim decText As String

        Dim wrapper As New Simple3Des(pDecKey)
        Dim sr As New StreamReader(pFilePath)
        Do
            tempContent = sr.ReadLine
            If IsNothing(tempContent) Then
                Exit Do
            Else
                decText = wrapper.decryptData(tempContent)
                userRow = userSet.NewRow()
                splitContent = Split(decText, ",")
                userRow("Username") = splitContent(0)
                userRow("Password") = splitContent(1)
                userRow("Email") = splitContent(2)
                userRow("Role") = splitContent(3)
                userSet.Rows.Add(userRow)
            End If
        Loop
        sr.Close()

        Return userSet
    End Function

    Public Function setActiveUser() As userClass
        Dim tempUser As New userClass

        Dim userTable As DataTable
        userTable = getUserTable()
        Dim foundRows() As DataRow
        Dim userSearch As String = "Username = '" & LCase(pUserName) & "'"

        foundRows = userTable.Select(userSearch)

        tempUser.userName = foundRows(0)("Username")
        tempUser.userPassword = foundRows(0)("Password")
        tempUser.userEmail = foundRows(0)("Email")
        tempUser.userRole = foundRows(0)("Role")

        Return tempUser
    End Function
End Class
