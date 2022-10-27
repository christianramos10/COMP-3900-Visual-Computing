<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarLoan
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.analyzeBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.loanAmountTextBox = New System.Windows.Forms.TextBox()
        Me.interestRateTextBox = New System.Windows.Forms.TextBox()
        Me.durationTextBox = New System.Windows.Forms.TextBox()
        Me.paymentsTextBox = New System.Windows.Forms.TextBox()
        Me.totalInterestTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Amount of loan:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(53, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Interest Rate: (such as 5.25)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Duration in months:"
        '
        'analyzeBtn
        '
        Me.analyzeBtn.Location = New System.Drawing.Point(34, 142)
        Me.analyzeBtn.Name = "analyzeBtn"
        Me.analyzeBtn.Size = New System.Drawing.Size(303, 36)
        Me.analyzeBtn.TabIndex = 3
        Me.analyzeBtn.Text = "Analyze"
        Me.analyzeBtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Monthly Payments:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(44, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Total interest paid:"
        '
        'loanAmountTextBox
        '
        Me.loanAmountTextBox.Location = New System.Drawing.Point(153, 6)
        Me.loanAmountTextBox.Name = "loanAmountTextBox"
        Me.loanAmountTextBox.Size = New System.Drawing.Size(100, 23)
        Me.loanAmountTextBox.TabIndex = 6
        '
        'interestRateTextBox
        '
        Me.interestRateTextBox.Location = New System.Drawing.Point(153, 48)
        Me.interestRateTextBox.Name = "interestRateTextBox"
        Me.interestRateTextBox.Size = New System.Drawing.Size(100, 23)
        Me.interestRateTextBox.TabIndex = 7
        '
        'durationTextBox
        '
        Me.durationTextBox.Location = New System.Drawing.Point(153, 99)
        Me.durationTextBox.Name = "durationTextBox"
        Me.durationTextBox.Size = New System.Drawing.Size(100, 23)
        Me.durationTextBox.TabIndex = 8
        '
        'paymentsTextBox
        '
        Me.paymentsTextBox.Location = New System.Drawing.Point(153, 201)
        Me.paymentsTextBox.Name = "paymentsTextBox"
        Me.paymentsTextBox.ReadOnly = True
        Me.paymentsTextBox.Size = New System.Drawing.Size(100, 23)
        Me.paymentsTextBox.TabIndex = 9
        '
        'totalInterestTextBox
        '
        Me.totalInterestTextBox.Location = New System.Drawing.Point(153, 240)
        Me.totalInterestTextBox.Name = "totalInterestTextBox"
        Me.totalInterestTextBox.ReadOnly = True
        Me.totalInterestTextBox.Size = New System.Drawing.Size(100, 23)
        Me.totalInterestTextBox.TabIndex = 10
        '
        'CarLoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 305)
        Me.Controls.Add(Me.totalInterestTextBox)
        Me.Controls.Add(Me.paymentsTextBox)
        Me.Controls.Add(Me.durationTextBox)
        Me.Controls.Add(Me.interestRateTextBox)
        Me.Controls.Add(Me.loanAmountTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.analyzeBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CarLoan"
        Me.Text = "Car Loan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents analyzeBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents loanAmountTextBox As TextBox
    Friend WithEvents interestRateTextBox As TextBox
    Friend WithEvents durationTextBox As TextBox
    Friend WithEvents paymentsTextBox As TextBox
    Friend WithEvents totalInterestTextBox As TextBox
End Class
