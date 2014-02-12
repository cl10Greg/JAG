Imports System.IO

Public Class newUserCtrl

    Private Sub createBtn_Click(sender As Object, e As EventArgs) Handles createBtn.Click
        Dim userObj As New newUserClass
        Dim userPath As String = "C:\Personal\JAG\Software\Users\userDB.usr"

        userObj.userName = LCase(userTxt.Text)
        userObj.userPassword = passTxt.Text
        userObj.userEmail = emailTxt.Text
        userObj.userFile = userPath
        userObj.userKey = "checkEng00"

        'check if empty
        If userObj.checkAllData Then
            If userObj.checkEmail() Then
                'Check to see if user exist
                userObj.getFileInfo()

                'If file exists then check content
                'if it doesn't then create it
                If Not userObj.getFileExists Then
                    File.Create(userObj.userFile)
                Else
                    'Empty is true
                    If userObj.getFileContent Then
                        'Write the user to file
                        userObj.writeEncyptedUser()
                    Else
                        'Read the file
                        'Check for user
                        userObj.userExist()

                    End If
                End If
                

                'If the content is empty then just write to it
                'if it's not, check content
                'Read file

                'Check if empty
                'Decrypt
                'Store
            Else
                MsgBox("Email is not the correct format.  Please try again")
                emailTxt.Clear()
                emailTxt.Focus()
                Exit Sub
            End If
        Else
            MsgBox("Missing information.  Please try again", MsgBoxStyle.Critical, "Missing information")
            Exit Sub
        End If

        'Check email


    End Sub

    Private Sub newUserCtrl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userTxt.Focus()
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        userTxt.Clear()
        passTxt.Clear()
        emailTxt.Clear()
    End Sub
End Class
