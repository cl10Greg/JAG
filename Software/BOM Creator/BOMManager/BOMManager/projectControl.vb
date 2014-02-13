Public Class projectControl

    Private Sub projectControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub populateProject(tempObj As projectClass)

        'Populate all
        nameTxt.Text = tempObj.ProjName
        desTxt.Text = tempObj.ProjDes
        qtyTxt.Text = tempObj.ProjQty
        ownerTxt.Text = tempObj.ProjOwner
        rwTxt.Text = tempObj.ProjWriters
        readTxt.Text = tempObj.ProjReaders
        createTxt.Text = tempObj.createDate
        revDateTxt.Text = tempObj.revDate
        revNumTxt.Text = tempObj.revNum
    End Sub

    Public Sub checkCredentials(tempObj As userClass)
        'Check to see what the user is allowed to do with the BOM
        If LCase(tempObj.userName).Equals(LCase(ownerTxt.Text)) Then
            'Write access is default, everything is enabled
        Else
            Call readAccess()
        End If
        'If the username is the owner, enable all
        'If the username isn't on the writer, disable all

    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        'Rewrite the project file to the new conent, if anything changed

    End Sub

    Private Sub readAccess()
        nameTxt.Enabled = False
        desTxt.Enabled = False
        qtyTxt.Enabled = False
        ownerTxt.Enabled = False
        rwTxt.Enabled = False
        readTxt.Enabled = False
        createTxt.Enabled = False
        revDateTxt.Enabled = False
        revNumTxt.Enabled = False
        updateBtn.Enabled = False
    End Sub
End Class
