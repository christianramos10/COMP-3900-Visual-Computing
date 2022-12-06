<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LifetimeEarnings
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
        Me.resultTxtBox = New System.Windows.Forms.TextBox()
        Me.computeBtn = New System.Windows.Forms.Button()
        Me.salaryTxtBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ageTxtBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nameTxtBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'resultTxtBox
        '
        Me.resultTxtBox.Location = New System.Drawing.Point(107, 235)
        Me.resultTxtBox.Name = "resultTxtBox"
        Me.resultTxtBox.ReadOnly = True
        Me.resultTxtBox.Size = New System.Drawing.Size(298, 23)
        Me.resultTxtBox.TabIndex = 15
        '
        'computeBtn
        '
        Me.computeBtn.Location = New System.Drawing.Point(107, 161)
        Me.computeBtn.Name = "computeBtn"
        Me.computeBtn.Size = New System.Drawing.Size(298, 48)
        Me.computeBtn.TabIndex = 14
        Me.computeBtn.Text = "Compute Earnings"
        Me.computeBtn.UseVisualStyleBackColor = True
        '
        'salaryTxtBox
        '
        Me.salaryTxtBox.Location = New System.Drawing.Point(257, 109)
        Me.salaryTxtBox.Name = "salaryTxtBox"
        Me.salaryTxtBox.Size = New System.Drawing.Size(100, 23)
        Me.salaryTxtBox.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(151, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Starting Salary:"
        '
        'ageTxtBox
        '
        Me.ageTxtBox.Location = New System.Drawing.Point(382, 54)
        Me.ageTxtBox.Name = "ageTxtBox"
        Me.ageTxtBox.Size = New System.Drawing.Size(46, 23)
        Me.ageTxtBox.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(339, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Age:"
        '
        'nameTxtBox
        '
        Me.nameTxtBox.Location = New System.Drawing.Point(133, 54)
        Me.nameTxtBox.Name = "nameTxtBox"
        Me.nameTxtBox.Size = New System.Drawing.Size(100, 23)
        Me.nameTxtBox.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(78, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Name:"
        '
        'LifetimeEarnings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 312)
        Me.Controls.Add(Me.resultTxtBox)
        Me.Controls.Add(Me.computeBtn)
        Me.Controls.Add(Me.salaryTxtBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ageTxtBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nameTxtBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LifetimeEarnings"
        Me.Text = "LifetimeEarnings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents resultTxtBox As TextBox
    Friend WithEvents computeBtn As Button
    Friend WithEvents salaryTxtBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ageTxtBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents nameTxtBox As TextBox
    Friend WithEvents Label1 As Label
End Class
