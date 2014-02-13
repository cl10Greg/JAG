<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginCtrl
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
        Me.userTxt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.passTxt = New System.Windows.Forms.TextBox()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.newBtn = New System.Windows.Forms.Button()
        Me.forgotBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username:"
        '
        'userTxt
        '
        Me.userTxt.Location = New System.Drawing.Point(67, 8)
        Me.userTxt.Name = "userTxt"
        Me.userTxt.Size = New System.Drawing.Size(142, 20)
        Me.userTxt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password:"
        '
        'passTxt
        '
        Me.passTxt.Location = New System.Drawing.Point(67, 39)
        Me.passTxt.Name = "passTxt"
        Me.passTxt.Size = New System.Drawing.Size(142, 20)
        Me.passTxt.TabIndex = 3
        Me.passTxt.UseSystemPasswordChar = True
        '
        'loginBtn
        '
        Me.loginBtn.Location = New System.Drawing.Point(67, 65)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(75, 23)
        Me.loginBtn.TabIndex = 4
        Me.loginBtn.Text = "Login"
        Me.loginBtn.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Location = New System.Drawing.Point(148, 94)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(75, 23)
        Me.clearBtn.TabIndex = 5
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'newBtn
        '
        Me.newBtn.Location = New System.Drawing.Point(67, 94)
        Me.newBtn.Name = "newBtn"
        Me.newBtn.Size = New System.Drawing.Size(75, 23)
        Me.newBtn.TabIndex = 6
        Me.newBtn.Text = "New User"
        Me.newBtn.UseVisualStyleBackColor = True
        '
        'forgotBtn
        '
        Me.forgotBtn.Location = New System.Drawing.Point(148, 65)
        Me.forgotBtn.Name = "forgotBtn"
        Me.forgotBtn.Size = New System.Drawing.Size(110, 23)
        Me.forgotBtn.TabIndex = 7
        Me.forgotBtn.Text = "Forgot password?"
        Me.forgotBtn.UseVisualStyleBackColor = True
        '
        'loginCtrl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.forgotBtn)
        Me.Controls.Add(Me.newBtn)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.passTxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.userTxt)
        Me.Controls.Add(Me.Label1)
        Me.Name = "loginCtrl"
        Me.Size = New System.Drawing.Size(281, 129)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents userTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents passTxt As System.Windows.Forms.TextBox
    Friend WithEvents loginBtn As System.Windows.Forms.Button
    Friend WithEvents clearBtn As System.Windows.Forms.Button
    Friend WithEvents newBtn As System.Windows.Forms.Button
    Friend WithEvents forgotBtn As System.Windows.Forms.Button

End Class
