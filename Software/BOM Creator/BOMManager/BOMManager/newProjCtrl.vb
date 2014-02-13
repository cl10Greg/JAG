Public Class newProjCtrl

    Private Sub pathBtn_Click(sender As Object, e As EventArgs) Handles pathBtn.Click
        'Do file path
        SaveFileDialog1.FileName = nameTxt.Text
        SaveFileDialog1.ShowDialog()
        locationTxt.Text = SaveFileDialog1.FileName
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        nameTxt.Clear()
        desTxt.Clear()
        qtyTxt.Clear()
        locationTxt.Clear()
        fullTxt.Clear()
        readTxt.Clear()
    End Sub

    Private Sub createBtn_Click(sender As Object, e As EventArgs) Handles createBtn.Click
        Dim ProjObj As New projectClass
        Dim d As DateTime = Now

        ProjObj.ProjName = nameTxt.Text & ".bfg"
        ProjObj.BomName = nameTxt.Text & ".bom"
        ProjObj.ProjDes = desTxt.Text
        ProjObj.ProjQty = qtyTxt.Text
        ProjObj.ProjLoc = locationTxt.Text
        ProjObj.ProjOwner = MainFrm.getUser.userName
        ProjObj.ProjWriters = fullTxt.Text
        ProjObj.ProjReaders = readTxt.Text
        ProjObj.createDate = d.ToShortDateString
        ProjObj.revDate = d.ToShortDateString
        ProjObj.revNum = "1"

        If ProjObj.checkContent() Then
            'Create file
            ProjObj.createFiles()
            'Write Project Information
            ProjObj.writeProjectInfo()
        Else
            'Exit
            Exit Sub
        End If

        'Send the project object to the main form
        MainFrm.storeProject(ProjObj)
    End Sub
End Class
