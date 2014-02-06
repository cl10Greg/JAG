Public Class beadMakerFrm

    Private Sub importBtn_Click(sender As Object, e As EventArgs) Handles importBtn.Click
        Dim imgPath As String
        importDiag.Title = "Import File..."
        importDiag.InitialDirectory = "C:\"
        If importDiag.ShowDialog = Windows.Forms.DialogResult.OK Then
            'set path
            imgPath = importDiag.FileName
            origPic.ImageLocation = imgPath
            origPic.SizeMode = PictureBoxSizeMode.CenterImage
            MsgBox(origPic.Image.PhysicalDimension)
        Else
            MsgBox("Not a valid file")
            Exit Sub
        End If
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        End
    End Sub

    Private Sub testBtn_Click(sender As Object, e As EventArgs) Handles testBtn.Click
        Dim ep As System.Windows.Forms.TableLayoutCellPaintEventArgs

        Dim imageFile As Image = Image.FromFile("C:\Personal\Projects\Bead Maker\tempMushroom.jpg")

        Dim newGraphics As Graphics = Graphics.FromImage(imageFile)

        newGraphics.FillRectangle(New SolidBrush(Color.Black), 100, 50, 100, 100)

        ep.Graphics.DrawImage(imageFile, New PointF(0.0F, 0.0F))

        newGraphics.Dispose()

    End Sub
End Class
