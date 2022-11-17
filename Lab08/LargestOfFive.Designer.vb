<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LargestOfFive
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
        Me.txtboxResult = New System.Windows.Forms.TextBox()
        Me.getLargBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbox5 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtbox4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtboxResult
        '
        Me.txtboxResult.Location = New System.Drawing.Point(166, 299)
        Me.txtboxResult.Name = "txtboxResult"
        Me.txtboxResult.ReadOnly = True
        Me.txtboxResult.Size = New System.Drawing.Size(138, 23)
        Me.txtboxResult.TabIndex = 23
        '
        'getLargBtn
        '
        Me.getLargBtn.Location = New System.Drawing.Point(166, 237)
        Me.getLargBtn.Name = "getLargBtn"
        Me.getLargBtn.Size = New System.Drawing.Size(138, 36)
        Me.getLargBtn.TabIndex = 22
        Me.getLargBtn.Text = "Get Largest"
        Me.getLargBtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(115, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 22)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "5th Number:"
        '
        'txtbox5
        '
        Me.txtbox5.Location = New System.Drawing.Point(231, 185)
        Me.txtbox5.Name = "txtbox5"
        Me.txtbox5.Size = New System.Drawing.Size(100, 23)
        Me.txtbox5.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(115, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 22)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "4th Number:"
        '
        'txtbox4
        '
        Me.txtbox4.Location = New System.Drawing.Point(231, 147)
        Me.txtbox4.Name = "txtbox4"
        Me.txtbox4.Size = New System.Drawing.Size(100, 23)
        Me.txtbox4.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(115, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 22)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "3rd Number:"
        '
        'txtbox3
        '
        Me.txtbox3.Location = New System.Drawing.Point(231, 109)
        Me.txtbox3.Name = "txtbox3"
        Me.txtbox3.Size = New System.Drawing.Size(100, 23)
        Me.txtbox3.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(115, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 22)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "2nd Number:"
        '
        'txtbox2
        '
        Me.txtbox2.Location = New System.Drawing.Point(231, 73)
        Me.txtbox2.Name = "txtbox2"
        Me.txtbox2.Size = New System.Drawing.Size(100, 23)
        Me.txtbox2.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(115, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 22)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "1st Number:"
        '
        'txtbox1
        '
        Me.txtbox1.Location = New System.Drawing.Point(231, 37)
        Me.txtbox1.Name = "txtbox1"
        Me.txtbox1.Size = New System.Drawing.Size(100, 23)
        Me.txtbox1.TabIndex = 12
        '
        'LargestOfFive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 366)
        Me.Controls.Add(Me.txtboxResult)
        Me.Controls.Add(Me.getLargBtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtbox5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtbox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtbox1)
        Me.Name = "LargestOfFive"
        Me.Text = "LargestOfFive"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtboxResult As TextBox
    Friend WithEvents getLargBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtbox5 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtbox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtbox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbox1 As TextBox
End Class
