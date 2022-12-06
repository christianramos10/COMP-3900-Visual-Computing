<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IRA
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
        Me.calculateBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.amount1TxtBox = New System.Windows.Forms.TextBox()
        Me.amount2TxtBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.postAmount2TxtBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.postAmount1TxtBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'calculateBtn
        '
        Me.calculateBtn.Location = New System.Drawing.Point(152, 31)
        Me.calculateBtn.Name = "calculateBtn"
        Me.calculateBtn.Size = New System.Drawing.Size(244, 45)
        Me.calculateBtn.TabIndex = 0
        Me.calculateBtn.Text = "Calculate Amounts"
        Me.calculateBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(175, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "AMOUNTS DEPOSITED"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(82, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Earl:"
        '
        'amount1TxtBox
        '
        Me.amount1TxtBox.Location = New System.Drawing.Point(124, 151)
        Me.amount1TxtBox.Name = "amount1TxtBox"
        Me.amount1TxtBox.Size = New System.Drawing.Size(100, 23)
        Me.amount1TxtBox.TabIndex = 3
        '
        'amount2TxtBox
        '
        Me.amount2TxtBox.Location = New System.Drawing.Point(368, 151)
        Me.amount2TxtBox.Name = "amount2TxtBox"
        Me.amount2TxtBox.Size = New System.Drawing.Size(100, 23)
        Me.amount2TxtBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(317, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Larry:"
        '
        'postAmount2TxtBox
        '
        Me.postAmount2TxtBox.Location = New System.Drawing.Point(368, 243)
        Me.postAmount2TxtBox.Name = "postAmount2TxtBox"
        Me.postAmount2TxtBox.Size = New System.Drawing.Size(100, 23)
        Me.postAmount2TxtBox.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(317, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Larry:"
        '
        'postAmount1TxtBox
        '
        Me.postAmount1TxtBox.Location = New System.Drawing.Point(124, 243)
        Me.postAmount1TxtBox.Name = "postAmount1TxtBox"
        Me.postAmount1TxtBox.Size = New System.Drawing.Size(100, 23)
        Me.postAmount1TxtBox.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(82, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 19)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Earl:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(111, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(285, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "AMOUNTS IN IRA UPON RETIREMENT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'IRA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(537, 323)
        Me.Controls.Add(Me.postAmount2TxtBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.postAmount1TxtBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.amount2TxtBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.amount1TxtBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.calculateBtn)
        Me.Name = "IRA"
        Me.Text = "IRA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents calculateBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents amount1TxtBox As TextBox
    Friend WithEvents amount2TxtBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents postAmount2TxtBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents postAmount1TxtBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
