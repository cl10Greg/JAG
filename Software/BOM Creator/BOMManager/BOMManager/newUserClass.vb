Imports System.Text.RegularExpressions
Imports System.IO

Public Class newUserClass
    Private pUserName As String
    Private pUserPass As String
    Private pUserEmail As String
    Private pFilePath As String
    Private pDecKey As String
    Private pFileExists As Boolean
    Private pFileEmpty As Boolean


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

    Public Function checkAllData() As Boolean
        If pUserName = "" Or pUserPass = "" Or pUserEmail = "" Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function userAvailable() As Boolean

        Return True
    End Function

    Public Sub getFileInfo()
        If File.Exists(pFilePath) Then
            pFileExists = True
        Else
            pFileExists = False
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

    Public Sub writeEncyptedUser()
        Dim wrapper As New Simple3Des(pDecKey)
        Dim userString As String = LCase(pUserName) & "," & pUserPass & "," & pUserEmail
        Dim encText As String = wrapper.encryptData(userString)
        File.WriteAllText(pFilePath, encText & vbCrLf)
    End Sub

    Public Function userExist() As Boolean
        Dim userSet As New DataTable
        Dim userRow As DataRow

        userSet.Columns.Add("Username", GetType(String))
        userSet.Columns.Add("Password", GetType(String))
        userSet.Columns.Add("Email", GetType(String))

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
                userRow = userSet.NewRow
                userRow("Username") = splitContent(0)
                userRow("Password") = splitContent(1)
                userRow("Email") = splitContent(2)
                userSet.Rows.Add(userRow)
            End If
        Loop
        sr.Close()

        Dim foundRows() As DataRow
        Dim userSearch As String = "Username = '" & LCase(pUserName) & "'"
        foundRows = userSet.Select(userSearch)

        MsgBox("Pause")

        Return True
    End Function
End Class
