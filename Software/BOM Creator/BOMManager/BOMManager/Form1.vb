Public Class MainFrm

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tempControl As New loginCtrl
        Call resizePanels()
        Call updatePanel(tempControl, contentPanel)
    End Sub

    Private Sub resizePanels()
        projectPanel.Width = Me.Width - 30 - projectPanel.Left
        actionPanel.Height = Me.Height - 30 - actionPanel.Top
        contentPanel.Height = Me.Height - 30 - contentPanel.Top
        contentPanel.Width = Me.Width - 30 - contentPanel.Left
    End Sub

    Public Sub updatePanel(tempControl As Control, tempPanel As Panel)
        tempPanel.Controls.Clear()
        tempPanel.Controls.Add(tempControl)
        tempControl.Location = getCenter(tempControl, tempPanel)
    End Sub

    Private Function getCenter(tempControl As Control, tempPanel As Panel) As Point
        Dim centerPanel As New Point((tempPanel.Width \ 2) - (tempControl.Width \ 2), (tempPanel.Height \ 2) - (tempControl.Height \ 2))
        Return centerPanel
    End Function

    Private Sub CreateUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateUsersToolStripMenuItem.Click
        'Check all data
        'Check to see if the user exist or email
        'If so error
        'if not then encrpyt the user
        'write to file

    End Sub
End Class
