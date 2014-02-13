Imports System.IO

Public Class projectClass
    Private pProjName As String
    Private pBomName As String
    Private pProjDes As String
    Private pProjQty As String
    Private pProjLocation As String
    Private pProjOwner As String
    Private pProjWrite As String
    Private pProjRead As String
    Private pProjCreateDate As String
    Private pProjRevDate As String
    Private pProjRevNum As String

    Public Property createDate() As String
        Get
            Return pProjCreateDate
        End Get
        Set(value As String)
            pProjCreateDate = value
        End Set
    End Property

    Public Property revDate() As String
        Get
            Return pProjRevDate
        End Get
        Set(value As String)
            pProjRevDate = value
        End Set
    End Property

    Public Property revNum() As String
        Get
            Return pProjRevNum
        End Get
        Set(value As String)
            pProjRevNum = value
        End Set
    End Property
    Public Property BomName() As String
        Get
            Return pBomName
        End Get
        Set(value As String)
            pBomName = value
        End Set
    End Property
    Public Property ProjName() As String
        Get
            Return pProjName
        End Get
        Set(value As String)
            pProjName = value
        End Set
    End Property

    Public Property ProjDes() As String
        Get
            Return pProjDes
        End Get
        Set(value As String)
            pProjDes = value
        End Set
    End Property

    Public Property ProjQty() As String
        Get
            Return pProjQty
        End Get
        Set(value As String)
            pProjQty = value
        End Set
    End Property

    Public Property ProjLoc() As String
        Get
            Return pProjLocation
        End Get
        Set(value As String)
            pProjLocation = value
        End Set
    End Property

    Public Property ProjOwner() As String
        Get
            Return pProjOwner
        End Get
        Set(value As String)
            pProjOwner = value
        End Set
    End Property

    Public Property ProjWriters() As String
        Get
            Return pProjWrite
        End Get
        Set(value As String)
            pProjWrite = value
        End Set
    End Property

    Public Property ProjReaders() As String
        Get
            Return pProjRead
        End Get
        Set(value As String)
            pProjRead = value
        End Set
    End Property

    Public Sub createFiles()
        Dim cutInt As Integer = pProjLocation.LastIndexOf("\")
        Dim dirPath As String = pProjLocation.Substring(0, cutInt + 1)
        Dim ovPrompt
        If File.Exists(dirPath & ProjName) Then
            ovPrompt = MsgBox("File already exists, do you want to overwrite it?", vbYesNo)
            If ovPrompt = vbYes Then
                File.Create(dirPath & pProjName).Dispose()
                File.Create(dirPath & pBomName).Dispose()
                MsgBox("Created")
            Else
                MsgBox("File Cancelled")
            End If
        Else
            File.Create(dirPath & pProjName).Dispose()
            File.Create(dirPath & pBomName).Dispose()
            MsgBox("Created")
        End If
    End Sub

    Public Function checkContent() As Boolean
        If pProjName = "" Or pProjDes = "" Or pProjLocation = "" Then
            MsgBox("Must have at least a name, description, and location")
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub writeProjectInfo()
        Dim cutInt As Integer = pProjLocation.LastIndexOf("\")
        Dim dirPath As String = pProjLocation.Substring(0, cutInt + 1)
        Dim projectContent = {pProjName, pProjDes, pProjQty, pProjOwner, pProjWrite, pProjRead, pProjCreateDate, pProjRevDate, pProjRevNum}
        Dim filePath As String = dirPath & pProjName

        Dim wrapper As New Simple3Des("checkEng00")
        Dim encItem As String

        Dim sw As StreamWriter
        sw = File.AppendText(filePath)

        For x = 0 To UBound(projectContent)
            encItem = wrapper.encryptData(projectContent(x))
            sw.WriteLine(encItem)
        Next
        sw.Flush()
        sw.Close()
    End Sub

    Public Sub getProjectInfo(tempFile As String)
        Dim tempContent As String
        Dim wrapper As New Simple3Des("checkEng00")
        Dim sr As New StreamReader(tempFile)
        Dim decText As String
        Dim lineCount As Integer

        pProjLocation = tempFile

        lineCount = 0
        Do
            tempContent = sr.ReadLine
            If IsNothing(tempContent) Then
                Exit Do
            Else
                decText = wrapper.decryptData(tempContent)
                Select Case lineCount
                    Case 0
                        pProjName = decText
                    Case 1
                        pProjDes = decText
                    Case 2
                        pProjQty = decText
                    Case 3
                        pProjOwner = decText
                    Case 4
                        pProjWrite = decText
                    Case 5
                        pProjRead = decText
                    Case 6
                        pProjCreateDate = decText
                    Case 7
                        pProjRevDate = decText
                    Case 8
                        pProjRevNum = decText
                End Select
                lineCount = lineCount + 1
            End If
        Loop

        sr.Close()

    End Sub
End Class
