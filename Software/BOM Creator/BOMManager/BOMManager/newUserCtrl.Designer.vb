<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newUserCtrl
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.userTxt = New System.Windows.Forms.TextBox()
        Me.passTxt = New System.Windows.Forms.TextBox()
        Me.emailTxt = New System.Windows.Forms.TextBox()
        Me.createBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email:"
        '
        'userTxt
        '
        Me.userTxt.Location = New System.Drawing.Point(76, 7)
        Me.userTxt.Name = "userTxt"
        Me.userTxt.Size = New System.Drawing.Size(162, 20)
        Me.userTxt.TabIndex = 3
        '
        'passTxt
        '
        Me.passTxt.Location = New System.Drawing.Point(76, 36)
        Me.passTxt.Name = "passTxt"
        Me.passTxt.Size = New System.Drawing.Size(162, 20)
        Me.passTxt.TabIndex = 4
        Me.passTxt.UseSystemPasswordChar = True
        '
        'emailTxt
        '
        Me.emailTxt.Location = New System.Drawing.Point(76, 65)
        Me.emailTxt.Name = "emailTxt"
        Me.emailTxt.Size = New System.Drawing.Size(162, 20)
        Me.emailTxt.TabIndex = 5
        '
        'createBtn
        '
        Me.createBtn.Location = New System.Drawing.Point(47, 91)
        Me.createBtn.Name = "createBtn"
        Me.createBtn.Size = New System.Drawing.Size(75, 23)
        Me.createBtn.TabIndex = 6
        Me.createBtn.Text = "Create User"
        Me.createBtn.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Location = New System.Drawing.Point(137, 91)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(75, 23)
        Me.clearBtn.TabIndex = 7
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'newUserCtrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.createBtn)
        Me.Controls.Add(Me.emailTxt)
        Me.Controls.Add(Me.passTxt)
        Me.Controls.Add(Me.userTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "newUserCtrl"
        Me.Size = New System.Drawing.Size(265, 128)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents userTxt As System.Windows.Forms.TextBox
    Friend WithEvents passTxt As System.Windows.Forms.TextBox
    Friend WithEvents emailTxt As System.Windows.Forms.TextBox
    Friend WithEvents createBtn As System.Windows.Forms.Button
    Friend WithEvents clearBtn As System.Windows.Forms.Button

End Class
