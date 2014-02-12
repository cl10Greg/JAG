Public Class loginCtrl

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        userTxt.Clear()
        passTxt.Clear()
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim userObj As New loginClass

        userObj.userName = LCase(userTxt.Text)
        userObj.userPass = passTxt.Text

        If userObj.checkData Then
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
End Class
