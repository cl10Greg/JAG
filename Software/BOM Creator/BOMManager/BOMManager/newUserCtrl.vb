Imports System.IO

Public Class newUserCtrl

    Private Sub createBtn_Click(sender As Object, e As EventArgs) Handles createBtn.Click
        Dim userObj As New userClass
        Dim userPath As String = "C:\Personal\JAG\Software\Users\userDB.usr"
        Dim userChoice

        userObj.userName = LCase(userTxt.Text)
        userObj.userPassword = passTxt.Text
        userObj.userEmail = emailTxt.Text
        userObj.userRole = roleCmb.Text
        userObj.userFile = userPath
        userObj.userKey = "checkEng00"

        'check if empty
        If userObj.checkNewUserData Then
            If userObj.checkEmail() Then
                'Check to see if user exist
                userObj.getFileInfo()

                'If file exists then check content
                'if it doesn't then create it
                If Not userObj.getFileExists Then
                    userChoice = MsgBox("File doesn't exist.  Do you wish to create it?", vbYesNo)
                    If userChoice = vbYes Then
                        File.Create(userObj.userFile).Dispose()
                    Else
                        MsgBox("File wasn't created.  User wasn't created.")
                        Exit Sub
                    End If
                End If

                'Empty is true
                If userObj.getFileContent Then
                    'Write the user to file
                    MsgBox("New user created")
                    userObj.writeNewUser()
                Else
                    'Read the file
                    'Check for user
                    If userObj.userExist() Then
                        MsgBox("User already exist.  Please try again")
                        userTxt.Focus()
                        Exit Sub
                    Else
                        'Create the new user and add to the bottom of the file
                        userObj.appendNewUser()
                        MsgBox("New user created")
                    End If
                End If

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

    End Sub

    Private Sub newUserCtrl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userTxt.Focus()
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        userTxt.Clear()
        passTxt.Clear()
        emailTxt.Clear()
        roleCmb.Text = ""
    End Sub
End Class
