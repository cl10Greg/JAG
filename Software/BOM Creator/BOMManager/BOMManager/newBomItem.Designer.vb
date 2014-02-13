<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newBomItem
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
        Me.itemNumTxt = New System.Windows.Forms.TextBox()
        Me.getNextBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.typeCmb = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.generalTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.detailedTxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mfgTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.mfgNumTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.qtyTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.bufferTxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.totalQtyTxt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.supplierTxt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.supplierNumTxt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ppTxt = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.minTxt = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.amountTxt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.totalTxt = New System.Windows.Forms.TextBox()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item #:"
        '
        'itemNumTxt
        '
        Me.itemNumTxt.Location = New System.Drawing.Point(49, 6)
        Me.itemNumTxt.Name = "itemNumTxt"
        Me.itemNumTxt.Size = New System.Drawing.Size(100, 20)
        Me.itemNumTxt.TabIndex = 1
        '
        'getNextBtn
        '
        Me.getNextBtn.Location = New System.Drawing.Point(155, 4)
        Me.getNextBtn.Name = "getNextBtn"
        Me.getNextBtn.Size = New System.Drawing.Size(75, 23)
        Me.getNextBtn.TabIndex = 2
        Me.getNextBtn.Text = "Get Next"
        Me.getNextBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Component Type:"
        '
        'typeCmb
        '
        Me.typeCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.typeCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.typeCmb.FormattingEnabled = True
        Me.typeCmb.Items.AddRange(New Object() {"Amplifier", "Battery", "Bridge Rectifier", "Button", "Ceramic Capacitor", "Connector", "Diac", "Diode", "Electrolytic Capacitor", "Fuse", "Hardware", "Housing", "IC", "Inductor", "LED", "Mechanical", "Microcontroller", "Microphone", "Module", "NMOS Transistor", "NPN Transistor", "Oscillator", "Optoisolator", "Other", "Photosensor", "PMOS Transistor", "PNP Transistor", "Potentiometer", "Power Supply", "Regulator", "Relay", "Resistor", "Schottky Diode", "Speaker", "Switch", "Terminals", "Transformer", "Triac", "Zener Diode"})
        Me.typeCmb.Location = New System.Drawing.Point(101, 36)
        Me.typeCmb.Name = "typeCmb"
        Me.typeCmb.Size = New System.Drawing.Size(121, 21)
        Me.typeCmb.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "General Description:"
        '
        'generalTxt
        '
        Me.generalTxt.Location = New System.Drawing.Point(7, 86)
        Me.generalTxt.Multiline = True
        Me.generalTxt.Name = "generalTxt"
        Me.generalTxt.Size = New System.Drawing.Size(215, 71)
        Me.generalTxt.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(4, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Detailed Description:"
        '
        'detailedTxt
        '
        Me.detailedTxt.Location = New System.Drawing.Point(7, 176)
        Me.detailedTxt.Multiline = True
        Me.detailedTxt.Name = "detailedTxt"
        Me.detailedTxt.Size = New System.Drawing.Size(215, 71)
        Me.detailedTxt.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Manufacturer:"
        '
        'mfgTxt
        '
        Me.mfgTxt.Location = New System.Drawing.Point(7, 266)
        Me.mfgTxt.Name = "mfgTxt"
        Me.mfgTxt.Size = New System.Drawing.Size(215, 20)
        Me.mfgTxt.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 289)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Manufacturer #:"
        '
        'mfgNumTxt
        '
        Me.mfgNumTxt.Location = New System.Drawing.Point(7, 305)
        Me.mfgNumTxt.Name = "mfgNumTxt"
        Me.mfgNumTxt.Size = New System.Drawing.Size(215, 20)
        Me.mfgNumTxt.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 332)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Quantity"
        '
        'qtyTxt
        '
        Me.qtyTxt.Location = New System.Drawing.Point(55, 329)
        Me.qtyTxt.Name = "qtyTxt"
        Me.qtyTxt.Size = New System.Drawing.Size(100, 20)
        Me.qtyTxt.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 358)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Buffer:"
        '
        'bufferTxt
        '
        Me.bufferTxt.Location = New System.Drawing.Point(55, 355)
        Me.bufferTxt.Name = "bufferTxt"
        Me.bufferTxt.Size = New System.Drawing.Size(100, 20)
        Me.bufferTxt.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 384)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Total Quantity:"
        '
        'totalQtyTxt
        '
        Me.totalQtyTxt.Enabled = False
        Me.totalQtyTxt.Location = New System.Drawing.Point(86, 381)
        Me.totalQtyTxt.Name = "totalQtyTxt"
        Me.totalQtyTxt.Size = New System.Drawing.Size(100, 20)
        Me.totalQtyTxt.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(4, 412)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Supplier:"
        '
        'supplierTxt
        '
        Me.supplierTxt.Location = New System.Drawing.Point(7, 428)
        Me.supplierTxt.Name = "supplierTxt"
        Me.supplierTxt.Size = New System.Drawing.Size(215, 20)
        Me.supplierTxt.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(4, 451)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Supplier #:"
        '
        'supplierNumTxt
        '
        Me.supplierNumTxt.Location = New System.Drawing.Point(7, 467)
        Me.supplierNumTxt.Name = "supplierNumTxt"
        Me.supplierNumTxt.Size = New System.Drawing.Size(215, 20)
        Me.supplierNumTxt.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 496)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Piece Price:"
        '
        'ppTxt
        '
        Me.ppTxt.Location = New System.Drawing.Point(77, 493)
        Me.ppTxt.Name = "ppTxt"
        Me.ppTxt.Size = New System.Drawing.Size(100, 20)
        Me.ppTxt.TabIndex = 24
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 526)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(70, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Minimum Qty:"
        '
        'minTxt
        '
        Me.minTxt.Location = New System.Drawing.Point(77, 523)
        Me.minTxt.Name = "minTxt"
        Me.minTxt.Size = New System.Drawing.Size(100, 20)
        Me.minTxt.TabIndex = 26
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 555)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(75, 13)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Order Amount:"
        '
        'amountTxt
        '
        Me.amountTxt.Enabled = False
        Me.amountTxt.Location = New System.Drawing.Point(86, 552)
        Me.amountTxt.Name = "amountTxt"
        Me.amountTxt.Size = New System.Drawing.Size(100, 20)
        Me.amountTxt.TabIndex = 28
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 583)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 13)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Total Cost:"
        '
        'totalTxt
        '
        Me.totalTxt.Enabled = False
        Me.totalTxt.Location = New System.Drawing.Point(71, 580)
        Me.totalTxt.Name = "totalTxt"
        Me.totalTxt.Size = New System.Drawing.Size(100, 20)
        Me.totalTxt.TabIndex = 30
        '
        'addBtn
        '
        Me.addBtn.Location = New System.Drawing.Point(12, 606)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(75, 23)
        Me.addBtn.TabIndex = 31
        Me.addBtn.Text = "Add"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Location = New System.Drawing.Point(111, 606)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(75, 23)
        Me.clearBtn.TabIndex = 32
        Me.clearBtn.Text = "Clear"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'newBomItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.addBtn)
        Me.Controls.Add(Me.totalTxt)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.amountTxt)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.minTxt)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ppTxt)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.supplierNumTxt)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.supplierTxt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.totalQtyTxt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.bufferTxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.qtyTxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.mfgNumTxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.mfgTxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.detailedTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.generalTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.typeCmb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.getNextBtn)
        Me.Controls.Add(Me.itemNumTxt)
        Me.Controls.Add(Me.Label1)
        Me.Name = "newBomItem"
        Me.Size = New System.Drawing.Size(250, 648)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents itemNumTxt As System.Windows.Forms.TextBox
    Friend WithEvents getNextBtn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents typeCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents generalTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents detailedTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents mfgTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents mfgNumTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents qtyTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents bufferTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents totalQtyTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents supplierTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents supplierNumTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ppTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents minTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents amountTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents totalTxt As System.Windows.Forms.TextBox
    Friend WithEvents addBtn As System.Windows.Forms.Button
    Friend WithEvents clearBtn As System.Windows.Forms.Button

End Class
