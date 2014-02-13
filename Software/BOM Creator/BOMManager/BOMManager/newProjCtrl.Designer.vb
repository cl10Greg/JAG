<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newProjCtrl
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
        Me.locationTxt = New System.Windows.Forms.TextBox()
        Me.pathBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.fullTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.readTxt = New System.Windows.Forms.TextBox()
        Me.createBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BOM Name"
        '
        'nameTxt
        '
        Me.nameTxt.Location = New System.Drawing.Point(6, 25)
        Me.nameTxt.Name = "nameTxt"
        Me.nameTxt.Size = New System.Drawing.Size(226, 20)
        Me.nameTxt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Description:"
        '
        'desTxt
        '
        Me.desTxt.Location = New System.Drawing.Point(6, 64)
        Me.desTxt.Multiline = True
        Me.desTxt.Name = "desTxt"
        Me.desTxt.Size = New System.Drawing.Size(226, 58)
        Me.desTxt.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Annual QTY:"
        '
        'qtyTxt
        '
        Me.qtyTxt.Location = New System.Drawing.Point(6, 141)
        Me.qtyTxt.Name = "qtyTxt"
        Me.qtyTxt.Size = New System.Drawing.Size(100, 20)
        Me.qtyTxt.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Save Location:"
        '
        'locationTxt
        '
        Me.locationTxt.Location = New System.Drawing.Point(6, 180)
        Me.locationTxt.Name = "locationTxt"
        Me.locationTxt.Size = New System.Drawing.Size(204, 20)
        Me.locationTxt.TabIndex = 7
        '
        'pathBtn
        '
        Me.pathBtn.Location = New System.Drawing.Point(216, 180)
        Me.pathBtn.Name = "pathBtn"
        Me.pathBtn.Size = New System.Drawing.Size(30, 23)
        Me.pathBtn.TabIndex = 8
        Me.pathBtn.Text = "..."
        Me.pathBtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(194, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Full Access Users (put usernames or all)"
        '
        'fullTxt
        '
        Me.fullTxt.Location = New System.Drawing.Point(6, 219)
        Me.fullTxt.Name = "fullTxt"
        Me.fullTxt.Size = New System.Drawing.Size(226, 20)
        Me.fullTxt.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Read Only Access"
        '
        'readTxt
        '
        Me.readTxt.Location = New System.Drawing.Point(6, 258)
        Me.readTxt.Name = "readTxt"
        Me.readTxt.Size = New System.Drawing.Size(226, 20)
        Me.readTxt.TabIndex = 12
        '
        'createBtn
        '
        Me.createBtn.Location = New System.Drawing.Point(7, 284)
        Me.createBtn.Name = "createBtn"
        Me.createBtn.Size = New System.Drawing.Size(75, 23)
        Me.createBtn.TabIndex = 13
        Me.createBtn.Text = "Create"
        Me.createBtn.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Location = New System.Drawing.Point(122, 284)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(75, 23)
        Me.clearBtn.TabIndex = 14
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "bfg"
        Me.SaveFileDialog1.Filter = "(*.bfg)|*.bfg"
        '
        'newProjCtrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.createBtn)
        Me.Controls.Add(Me.readTxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.fullTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.pathBtn)
        Me.Controls.Add(Me.locationTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.qtyTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.desTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nameTxt)
        Me.Controls.Add(Me.Label1)
        Me.Name = "newProjCtrl"
        Me.Size = New System.Drawing.Size(250, 312)
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
    Friend WithEvents locationTxt As System.Windows.Forms.TextBox
    Friend WithEvents pathBtn As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents fullTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents readTxt As System.Windows.Forms.TextBox
    Friend WithEvents createBtn As System.Windows.Forms.Button
    Friend WithEvents clearBtn As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog

End Class
