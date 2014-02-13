Public Class loginCtrl

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        userTxt.Clear()
        passTxt.Clear()
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim activeObj As New userClass
        Dim userObj As New userClass
        Dim userPath As String = "C:\Personal\JAG\Software\Users\userDB.usr"

        userObj.userName = LCase(userTxt.Text)
        userObj.userPassword = passTxt.Text
        userObj.userFile = userPath
        userObj.userKey = "checkEng00"

        If userObj.checkLoginData Then
            'Check that file exist
            userObj.getFileInfo()
            If Not userObj.getFileExists Then
                MsgBox("Userdatabase not found")
            Else
                'Check to make sure the file isn't empty
                If userObj.getFileContent Then
                    MsgBox("No Users in database")
                Else
                    'Lookup the user
                    If userObj.userExist Then
                        'Grab user password
                        If userObj.passValid() Then
                            'Set the active user information
                            'Enable the correct tool bars
                            activeObj = userObj.setActiveUser
                            MsgBox("Welcome back " & activeObj.userName & ". Role = " & activeObj.userRole & ".")
                            'Send to the form for use
                            MainFrm.storeUser(activeObj)
                        Else
                            MsgBox("Password incorrect")
                            'Send password to email
                        End If
                    Else
                        MsgBox("User not found")
                    End If
                End If
            End If

            'Check that file is not empty
            'Read the userfile
            'Decrpyt the file into a datatable
            'Check the datatable for a username
            'Check the datatable for the password
        Else
            MsgBox("Missing data.  Please fill information and try again", MsgBoxStyle.Information, "Missing information")
            Exit Sub
        End If

    End Sub

    Private Sub newBtn_Click(sender As Object, e As EventArgs) Handles newBtn.Click
        Dim tempControl As New newUserCtrl
        'Call the create user form
        MainFrm.contentPanel.Controls.Clear()
        MainFrm.updatePanel(tempControl, MainFrm.contentPanel)
    End Sub

    
    Private Sub forgotBtn_Click(sender As Object, e As EventArgs) Handles forgotBtn.Click
        'Create a new random pass
        'Save to DB
        'Send to the users email

    End Sub
End Class
