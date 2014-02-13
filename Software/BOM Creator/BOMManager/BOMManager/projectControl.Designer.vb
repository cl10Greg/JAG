<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class projectControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nameTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.desTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.qtyTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ownerTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rwTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.readTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.createTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.revDateTxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.revNumTxt = New System.Windows.Forms.TextBox()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Project Name:"
        '
        'nameTxt
        '
        Me.nameTxt.Location = New System.Drawing.Point(83, 7)
        Me.nameTxt.Name = "nameTxt"
        Me.nameTxt.Size = New System.Drawing.Size(164, 20)
        Me.nameTxt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Description:"
        '
        'desTxt
        '
        Me.desTxt.Location = New System.Drawing.Point(83, 33)
        Me.desTxt.Multiline = True
        Me.desTxt.Name = "desTxt"
        Me.desTxt.Size = New System.Drawing.Size(164, 73)
        Me.desTxt.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Annual Qty:"
        '
        'qtyTxt
        '
        Me.qtyTxt.Location = New System.Drawing.Point(83, 118)
        Me.qtyTxt.Name = "qtyTxt"
        Me.qtyTxt.Size = New System.Drawing.Size(164, 20)
        Me.qtyTxt.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(253, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Owner:"
        '
        'ownerTxt
        '
        Me.ownerTxt.Location = New System.Drawing.Point(321, 7)
        Me.ownerTxt.Name = "ownerTxt"
        Me.ownerTxt.Size = New System.Drawing.Size(100, 20)
        Me.ownerTxt.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(255, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "RW Users:"
        '
        'rwTxt
        '
        Me.rwTxt.Location = New System.Drawing.Point(321, 33)
        Me.rwTxt.Name = "rwTxt"
        Me.rwTxt.Size = New System.Drawing.Size(205, 20)
        Me.rwTxt.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(255, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Read Users:"
        '
        'readTxt
        '
        Me.readTxt.Location = New System.Drawing.Point(321, 59)
        Me.readTxt.Name = "readTxt"
        Me.readTxt.Size = New System.Drawing.Size(205, 20)
        Me.readTxt.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(538, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Creation Date:"
        '
        'createTxt
        '
        Me.createTxt.Location = New System.Drawing.Point(619, 7)
        Me.createTxt.Name = "createTxt"
        Me.createTxt.Size = New System.Drawing.Size(102, 20)
        Me.createTxt.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(538, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Revision Date:"
        '
        'revDateTxt
        '
        Me.revDateTxt.Location = New System.Drawing.Point(621, 33)
        Me.revDateTxt.Name = "revDateTxt"
        Me.revDateTxt.Size = New System.Drawing.Size(100, 20)
        Me.revDateTxt.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(538, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Revision #:"
        '
        'revNumTxt
        '
        Me.revNumTxt.Location = New System.Drawing.Point(621, 59)
        Me.revNumTxt.Name = "revNumTxt"
        Me.revNumTxt.Size = New System.Drawing.Size(100, 20)
        Me.revNumTxt.TabIndex = 17
        '
        'updateBtn
        '
        Me.updateBtn.Location = New System.Drawing.Point(321, 98)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(75, 23)
        Me.updateBtn.TabIndex = 18
        Me.updateBtn.Text = "Update"
        Me.updateBtn.UseVisualStyleBackColor = True
        '
        'projectControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.updateBtn)
        Me.Controls.Add(Me.revNumTxt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.revDateTxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.createTxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.readTxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.rwTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ownerTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.qtyTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.desTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nameTxt)
        Me.Controls.Add(Me.Label1)
        Me.Name = "projectControl"
        Me.Size = New System.Drawing.Size(937, 150)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nameTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents desTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents qtyTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ownerTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rwTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents readTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents createTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents revDateTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents revNumTxt As System.Windows.Forms.TextBox
    Friend WithEvents updateBtn As System.Windows.Forms.Button

End Class
