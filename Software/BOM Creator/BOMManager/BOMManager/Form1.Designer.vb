<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainFrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewBOMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadBOMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportBOMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintBOMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BOMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditAccessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.projectPanel = New System.Windows.Forms.Panel()
        Me.actionPanel = New System.Windows.Forms.Panel()
        Me.contentPanel = New System.Windows.Forms.Panel()
        Me.projectDiag = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.BOMToolStripMenuItem, Me.UsersToolStripMenuItem, Me.ProjectToolStripMenuItem, Me.AdminToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(990, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewBOMToolStripMenuItem, Me.SaveToolStripMenuItem, Me.LoadBOMToolStripMenuItem, Me.ExportBOMToolStripMenuItem, Me.PrintBOMToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewBOMToolStripMenuItem
        '
        Me.NewBOMToolStripMenuItem.Name = "NewBOMToolStripMenuItem"
        Me.NewBOMToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewBOMToolStripMenuItem.Text = "New"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'LoadBOMToolStripMenuItem
        '
        Me.LoadBOMToolStripMenuItem.Name = "LoadBOMToolStripMenuItem"
        Me.LoadBOMToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoadBOMToolStripMenuItem.Text = "Load"
        '
        'ExportBOMToolStripMenuItem
        '
        Me.ExportBOMToolStripMenuItem.Name = "ExportBOMToolStripMenuItem"
        Me.ExportBOMToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExportBOMToolStripMenuItem.Text = "Export"
        '
        'PrintBOMToolStripMenuItem
        '
        Me.PrintBOMToolStripMenuItem.Name = "PrintBOMToolStripMenuItem"
        Me.PrintBOMToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PrintBOMToolStripMenuItem.Text = "Print"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'BOMToolStripMenuItem
        '
        Me.BOMToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.BOMToolStripMenuItem.Name = "BOMToolStripMenuItem"
        Me.BOMToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.BOMToolStripMenuItem.Text = "BOM"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ProjectToolStripMenuItem
        '
        Me.ProjectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditProjectToolStripMenuItem, Me.EditAccessToolStripMenuItem})
        Me.ProjectToolStripMenuItem.Name = "ProjectToolStripMenuItem"
        Me.ProjectToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.ProjectToolStripMenuItem.Text = "Project"
        '
        'EditProjectToolStripMenuItem
        '
        Me.EditProjectToolStripMenuItem.Name = "EditProjectToolStripMenuItem"
        Me.EditProjectToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditProjectToolStripMenuItem.Text = "Edit project"
        '
        'EditAccessToolStripMenuItem
        '
        Me.EditAccessToolStripMenuItem.Name = "EditAccessToolStripMenuItem"
        Me.EditAccessToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditAccessToolStripMenuItem.Text = "Edit Access"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateUsersToolStripMenuItem, Me.ModifyUsersToolStripMenuItem, Me.ViewUsersToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'CreateUsersToolStripMenuItem
        '
        Me.CreateUsersToolStripMenuItem.Name = "CreateUsersToolStripMenuItem"
        Me.CreateUsersToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CreateUsersToolStripMenuItem.Text = "Create Users"
        '
        'ModifyUsersToolStripMenuItem
        '
        Me.ModifyUsersToolStripMenuItem.Name = "ModifyUsersToolStripMenuItem"
        Me.ModifyUsersToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ModifyUsersToolStripMenuItem.Text = "Modify Users"
        '
        'ViewUsersToolStripMenuItem
        '
        Me.ViewUsersToolStripMenuItem.Name = "ViewUsersToolStripMenuItem"
        Me.ViewUsersToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ViewUsersToolStripMenuItem.Text = "View Users"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'projectPanel
        '
        Me.projectPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.projectPanel.Location = New System.Drawing.Point(12, 27)
        Me.projectPanel.Name = "projectPanel"
        Me.projectPanel.Size = New System.Drawing.Size(199, 158)
        Me.projectPanel.TabIndex = 1
        '
        'actionPanel
        '
        Me.actionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actionPanel.Location = New System.Drawing.Point(12, 191)
        Me.actionPanel.Name = "actionPanel"
        Me.actionPanel.Size = New System.Drawing.Size(286, 100)
        Me.actionPanel.TabIndex = 2
        '
        'contentPanel
        '
        Me.contentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.contentPanel.Location = New System.Drawing.Point(304, 191)
        Me.contentPanel.Name = "contentPanel"
        Me.contentPanel.Size = New System.Drawing.Size(200, 100)
        Me.contentPanel.TabIndex = 3
        '
        'projectDiag
        '
        Me.projectDiag.DefaultExt = "bfg"
        Me.projectDiag.Filter = "(*.bfg)|*.bfg"
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 676)
        Me.Controls.Add(Me.contentPanel)
        Me.Controls.Add(Me.actionPanel)
        Me.Controls.Add(Me.projectPanel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainFrm"
        Me.Text = "BOM Manager"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewBOMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadBOMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportBOMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintBOMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BOMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditAccessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents projectPanel As System.Windows.Forms.Panel
    Friend WithEvents actionPanel As System.Windows.Forms.Panel
    Friend WithEvents contentPanel As System.Windows.Forms.Panel
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents projectDiag As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ViewUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
