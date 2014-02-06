<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class beadMakerFrm
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
        Me.origPic = New System.Windows.Forms.PictureBox()
        Me.convertPic = New System.Windows.Forms.PictureBox()
        Me.importBtn = New System.Windows.Forms.Button()
        Me.importDiag = New System.Windows.Forms.OpenFileDialog()
        Me.jobBtn = New System.Windows.Forms.Button()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.loadBtn = New System.Windows.Forms.Button()
        Me.rowsNmb = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.colsNmb = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.testBtn = New System.Windows.Forms.Button()
        CType(Me.origPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.convertPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rowsNmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.colsNmb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'origPic
        '
        Me.origPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.origPic.Location = New System.Drawing.Point(149, 136)
        Me.origPic.Name = "origPic"
        Me.origPic.Size = New System.Drawing.Size(236, 201)
        Me.origPic.TabIndex = 0
        Me.origPic.TabStop = False
        '
        'convertPic
        '
        Me.convertPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.convertPic.Location = New System.Drawing.Point(494, 136)
        Me.convertPic.Name = "convertPic"
        Me.convertPic.Size = New System.Drawing.Size(236, 201)
        Me.convertPic.TabIndex = 1
        Me.convertPic.TabStop = False
        '
        'importBtn
        '
        Me.importBtn.Location = New System.Drawing.Point(149, 358)
        Me.importBtn.Name = "importBtn"
        Me.importBtn.Size = New System.Drawing.Size(75, 23)
        Me.importBtn.TabIndex = 2
        Me.importBtn.Text = "Import image"
        Me.importBtn.UseVisualStyleBackColor = True
        '
        'importDiag
        '
        Me.importDiag.FileName = "importDiag"
        '
        'jobBtn
        '
        Me.jobBtn.Location = New System.Drawing.Point(494, 454)
        Me.jobBtn.Name = "jobBtn"
        Me.jobBtn.Size = New System.Drawing.Size(75, 23)
        Me.jobBtn.TabIndex = 3
        Me.jobBtn.Text = "Send Job"
        Me.jobBtn.UseVisualStyleBackColor = True
        '
        'saveBtn
        '
        Me.saveBtn.Location = New System.Drawing.Point(494, 425)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(75, 23)
        Me.saveBtn.TabIndex = 4
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'loadBtn
        '
        Me.loadBtn.Location = New System.Drawing.Point(244, 358)
        Me.loadBtn.Name = "loadBtn"
        Me.loadBtn.Size = New System.Drawing.Size(75, 23)
        Me.loadBtn.TabIndex = 5
        Me.loadBtn.Text = "Load"
        Me.loadBtn.UseVisualStyleBackColor = True
        '
        'rowsNmb
        '
        Me.rowsNmb.Location = New System.Drawing.Point(610, 361)
        Me.rowsNmb.Name = "rowsNmb"
        Me.rowsNmb.Size = New System.Drawing.Size(120, 20)
        Me.rowsNmb.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(491, 368)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Number of Rows"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(491, 394)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Number of Cols"
        '
        'colsNmb
        '
        Me.colsNmb.Location = New System.Drawing.Point(610, 387)
        Me.colsNmb.Name = "colsNmb"
        Me.colsNmb.Size = New System.Drawing.Size(120, 20)
        Me.colsNmb.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(748, 368)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(149, 519)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(75, 23)
        Me.exitBtn.TabIndex = 11
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'testBtn
        '
        Me.testBtn.Location = New System.Drawing.Point(41, 143)
        Me.testBtn.Name = "testBtn"
        Me.testBtn.Size = New System.Drawing.Size(75, 23)
        Me.testBtn.TabIndex = 12
        Me.testBtn.Text = "Test"
        Me.testBtn.UseVisualStyleBackColor = True
        '
        'beadMakerFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 579)
        Me.Controls.Add(Me.testBtn)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.colsNmb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rowsNmb)
        Me.Controls.Add(Me.loadBtn)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.jobBtn)
        Me.Controls.Add(Me.importBtn)
        Me.Controls.Add(Me.convertPic)
        Me.Controls.Add(Me.origPic)
        Me.Name = "beadMakerFrm"
        Me.Text = "Bead maker..."
        CType(Me.origPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.convertPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rowsNmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.colsNmb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents origPic As System.Windows.Forms.PictureBox
    Friend WithEvents convertPic As System.Windows.Forms.PictureBox
    Friend WithEvents importBtn As System.Windows.Forms.Button
    Friend WithEvents importDiag As System.Windows.Forms.OpenFileDialog
    Friend WithEvents jobBtn As System.Windows.Forms.Button
    Friend WithEvents saveBtn As System.Windows.Forms.Button
    Friend WithEvents loadBtn As System.Windows.Forms.Button
    Friend WithEvents rowsNmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents colsNmb As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents exitBtn As System.Windows.Forms.Button
    Friend WithEvents testBtn As System.Windows.Forms.Button

End Class
