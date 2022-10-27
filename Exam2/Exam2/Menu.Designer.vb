<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.burgersGroupBox = New System.Windows.Forms.GroupBox()
        Me.wBaconAndCheeseBtn = New System.Windows.Forms.RadioButton()
        Me.wBaconBtn = New System.Windows.Forms.RadioButton()
        Me.wCheeseBtn = New System.Windows.Forms.RadioButton()
        Me.regularBtn = New System.Windows.Forms.RadioButton()
        Me.friesGroupBox = New System.Windows.Forms.GroupBox()
        Me.largeBtn = New System.Windows.Forms.RadioButton()
        Me.mediumBtn = New System.Windows.Forms.RadioButton()
        Me.smallBtn = New System.Windows.Forms.RadioButton()
        Me.drinksGroupBox = New System.Windows.Forms.GroupBox()
        Me.waterBtn = New System.Windows.Forms.RadioButton()
        Me.sodaBtn = New System.Windows.Forms.RadioButton()
        Me.burgersCheckBox = New System.Windows.Forms.CheckBox()
        Me.friesCheckBox = New System.Windows.Forms.CheckBox()
        Me.drinksCheckBox = New System.Windows.Forms.CheckBox()
        Me.computeBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.totalBox = New System.Windows.Forms.TextBox()
        Me.burgersGroupBox.SuspendLayout()
        Me.friesGroupBox.SuspendLayout()
        Me.drinksGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'burgersGroupBox
        '
        Me.burgersGroupBox.Controls.Add(Me.wBaconAndCheeseBtn)
        Me.burgersGroupBox.Controls.Add(Me.wBaconBtn)
        Me.burgersGroupBox.Controls.Add(Me.wCheeseBtn)
        Me.burgersGroupBox.Controls.Add(Me.regularBtn)
        Me.burgersGroupBox.Location = New System.Drawing.Point(127, 35)
        Me.burgersGroupBox.Name = "burgersGroupBox"
        Me.burgersGroupBox.Size = New System.Drawing.Size(258, 122)
        Me.burgersGroupBox.TabIndex = 0
        Me.burgersGroupBox.TabStop = False
        Me.burgersGroupBox.Text = "Choices for Burgers"
        Me.burgersGroupBox.Visible = False
        '
        'wBaconAndCheeseBtn
        '
        Me.wBaconAndCheeseBtn.AutoSize = True
        Me.wBaconAndCheeseBtn.Location = New System.Drawing.Point(6, 97)
        Me.wBaconAndCheeseBtn.Name = "wBaconAndCheeseBtn"
        Me.wBaconAndCheeseBtn.Size = New System.Drawing.Size(175, 19)
        Me.wBaconAndCheeseBtn.TabIndex = 3
        Me.wBaconAndCheeseBtn.TabStop = True
        Me.wBaconAndCheeseBtn.Text = "w/ bacon and cheese ($5.39)"
        Me.wBaconAndCheeseBtn.UseVisualStyleBackColor = True
        '
        'wBaconBtn
        '
        Me.wBaconBtn.AutoSize = True
        Me.wBaconBtn.Location = New System.Drawing.Point(6, 72)
        Me.wBaconBtn.Name = "wBaconBtn"
        Me.wBaconBtn.Size = New System.Drawing.Size(113, 19)
        Me.wBaconBtn.TabIndex = 2
        Me.wBaconBtn.TabStop = True
        Me.wBaconBtn.Text = "w/ bacon ($4.79)"
        Me.wBaconBtn.UseVisualStyleBackColor = True
        '
        'wCheeseBtn
        '
        Me.wCheeseBtn.AutoSize = True
        Me.wCheeseBtn.Location = New System.Drawing.Point(6, 47)
        Me.wCheeseBtn.Name = "wCheeseBtn"
        Me.wCheeseBtn.Size = New System.Drawing.Size(116, 19)
        Me.wCheeseBtn.TabIndex = 1
        Me.wCheeseBtn.TabStop = True
        Me.wCheeseBtn.Text = "w/ cheese ($4.79)"
        Me.wCheeseBtn.UseVisualStyleBackColor = True
        '
        'regularBtn
        '
        Me.regularBtn.AutoSize = True
        Me.regularBtn.Location = New System.Drawing.Point(6, 22)
        Me.regularBtn.Name = "regularBtn"
        Me.regularBtn.Size = New System.Drawing.Size(103, 19)
        Me.regularBtn.TabIndex = 0
        Me.regularBtn.TabStop = True
        Me.regularBtn.Text = "Regular ($4.19)"
        Me.regularBtn.UseVisualStyleBackColor = True
        '
        'friesGroupBox
        '
        Me.friesGroupBox.Controls.Add(Me.largeBtn)
        Me.friesGroupBox.Controls.Add(Me.mediumBtn)
        Me.friesGroupBox.Controls.Add(Me.smallBtn)
        Me.friesGroupBox.Location = New System.Drawing.Point(127, 172)
        Me.friesGroupBox.Name = "friesGroupBox"
        Me.friesGroupBox.Size = New System.Drawing.Size(142, 96)
        Me.friesGroupBox.TabIndex = 4
        Me.friesGroupBox.TabStop = False
        Me.friesGroupBox.Text = "Choices for Fries"
        '
        'largeBtn
        '
        Me.largeBtn.AutoSize = True
        Me.largeBtn.Location = New System.Drawing.Point(6, 72)
        Me.largeBtn.Name = "largeBtn"
        Me.largeBtn.Size = New System.Drawing.Size(92, 19)
        Me.largeBtn.TabIndex = 2
        Me.largeBtn.TabStop = True
        Me.largeBtn.Text = "Large ($4.99)"
        Me.largeBtn.UseVisualStyleBackColor = True
        '
        'mediumBtn
        '
        Me.mediumBtn.AutoSize = True
        Me.mediumBtn.Location = New System.Drawing.Point(6, 47)
        Me.mediumBtn.Name = "mediumBtn"
        Me.mediumBtn.Size = New System.Drawing.Size(108, 19)
        Me.mediumBtn.TabIndex = 1
        Me.mediumBtn.TabStop = True
        Me.mediumBtn.Text = "Medium ($3.09)"
        Me.mediumBtn.UseVisualStyleBackColor = True
        '
        'smallBtn
        '
        Me.smallBtn.AutoSize = True
        Me.smallBtn.Location = New System.Drawing.Point(6, 22)
        Me.smallBtn.Name = "smallBtn"
        Me.smallBtn.Size = New System.Drawing.Size(92, 19)
        Me.smallBtn.TabIndex = 0
        Me.smallBtn.TabStop = True
        Me.smallBtn.Text = "Small ($2.39)"
        Me.smallBtn.UseVisualStyleBackColor = True
        '
        'drinksGroupBox
        '
        Me.drinksGroupBox.Controls.Add(Me.waterBtn)
        Me.drinksGroupBox.Controls.Add(Me.sodaBtn)
        Me.drinksGroupBox.Location = New System.Drawing.Point(127, 295)
        Me.drinksGroupBox.Name = "drinksGroupBox"
        Me.drinksGroupBox.Size = New System.Drawing.Size(149, 73)
        Me.drinksGroupBox.TabIndex = 5
        Me.drinksGroupBox.TabStop = False
        Me.drinksGroupBox.Text = "Choices for Drinks"
        '
        'waterBtn
        '
        Me.waterBtn.AutoSize = True
        Me.waterBtn.Location = New System.Drawing.Point(6, 47)
        Me.waterBtn.Name = "waterBtn"
        Me.waterBtn.Size = New System.Drawing.Size(135, 19)
        Me.waterBtn.TabIndex = 1
        Me.waterBtn.TabStop = True
        Me.waterBtn.Text = "Bottled Water ($1.49)"
        Me.waterBtn.UseVisualStyleBackColor = True
        '
        'sodaBtn
        '
        Me.sodaBtn.AutoSize = True
        Me.sodaBtn.Location = New System.Drawing.Point(6, 22)
        Me.sodaBtn.Name = "sodaBtn"
        Me.sodaBtn.Size = New System.Drawing.Size(89, 19)
        Me.sodaBtn.TabIndex = 0
        Me.sodaBtn.TabStop = True
        Me.sodaBtn.Text = "Soda ($1.69)"
        Me.sodaBtn.UseVisualStyleBackColor = True
        '
        'burgersCheckBox
        '
        Me.burgersCheckBox.AutoSize = True
        Me.burgersCheckBox.Location = New System.Drawing.Point(12, 83)
        Me.burgersCheckBox.Name = "burgersCheckBox"
        Me.burgersCheckBox.Size = New System.Drawing.Size(66, 19)
        Me.burgersCheckBox.TabIndex = 6
        Me.burgersCheckBox.Text = "Burgers"
        Me.burgersCheckBox.UseVisualStyleBackColor = True
        '
        'friesCheckBox
        '
        Me.friesCheckBox.AutoSize = True
        Me.friesCheckBox.Location = New System.Drawing.Point(12, 219)
        Me.friesCheckBox.Name = "friesCheckBox"
        Me.friesCheckBox.Size = New System.Drawing.Size(50, 19)
        Me.friesCheckBox.TabIndex = 7
        Me.friesCheckBox.Text = "Fries"
        Me.friesCheckBox.UseVisualStyleBackColor = True
        '
        'drinksCheckBox
        '
        Me.drinksCheckBox.AutoSize = True
        Me.drinksCheckBox.Location = New System.Drawing.Point(12, 318)
        Me.drinksCheckBox.Name = "drinksCheckBox"
        Me.drinksCheckBox.Size = New System.Drawing.Size(59, 19)
        Me.drinksCheckBox.TabIndex = 8
        Me.drinksCheckBox.Text = "Drinks"
        Me.drinksCheckBox.UseVisualStyleBackColor = True
        '
        'computeBtn
        '
        Me.computeBtn.Location = New System.Drawing.Point(414, 295)
        Me.computeBtn.Name = "computeBtn"
        Me.computeBtn.Size = New System.Drawing.Size(102, 52)
        Me.computeBtn.TabIndex = 9
        Me.computeBtn.Text = "Compute Cost of Meal"
        Me.computeBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(344, 362)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 15)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Cost of meal:"
        '
        'totalBox
        '
        Me.totalBox.Location = New System.Drawing.Point(427, 359)
        Me.totalBox.Name = "totalBox"
        Me.totalBox.Size = New System.Drawing.Size(100, 23)
        Me.totalBox.TabIndex = 11
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 407)
        Me.Controls.Add(Me.totalBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.computeBtn)
        Me.Controls.Add(Me.drinksCheckBox)
        Me.Controls.Add(Me.friesCheckBox)
        Me.Controls.Add(Me.burgersCheckBox)
        Me.Controls.Add(Me.drinksGroupBox)
        Me.Controls.Add(Me.friesGroupBox)
        Me.Controls.Add(Me.burgersGroupBox)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.burgersGroupBox.ResumeLayout(False)
        Me.burgersGroupBox.PerformLayout()
        Me.friesGroupBox.ResumeLayout(False)
        Me.friesGroupBox.PerformLayout()
        Me.drinksGroupBox.ResumeLayout(False)
        Me.drinksGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents burgersGroupBox As GroupBox
    Friend WithEvents regularBtn As RadioButton
    Friend WithEvents wCheeseBtn As RadioButton
    Friend WithEvents wBaconBtn As RadioButton
    Friend WithEvents wBaconAndCheeseBtn As RadioButton
    Friend WithEvents friesGroupBox As GroupBox
    Friend WithEvents largeBtn As RadioButton
    Friend WithEvents mediumBtn As RadioButton
    Friend WithEvents smallBtn As RadioButton
    Friend WithEvents drinksGroupBox As GroupBox
    Friend WithEvents waterBtn As RadioButton
    Friend WithEvents sodaBtn As RadioButton
    Friend WithEvents burgersCheckBox As CheckBox
    Friend WithEvents friesCheckBox As CheckBox
    Friend WithEvents drinksCheckBox As CheckBox
    Friend WithEvents computeBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents totalBox As TextBox
End Class
