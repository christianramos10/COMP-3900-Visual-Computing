<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RentalCost
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.customerBillBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.itemTextBox = New System.Windows.Forms.TextBox()
        Me.durationTextBox = New System.Windows.Forms.TextBox()
        Me.rentalRatesBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Items.AddRange(New Object() {"Price of Equipment" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Half-Day" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Full-Day" & Global.Microsoft.VisualBasic.ChrW(9), "1. Rug Cleaner" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "$16.00" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "$24.00" & Global.Microsoft.VisualBasic.ChrW(9), "2. Lawn Mower" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "$12.00" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "$18.00" & Global.Microsoft.VisualBasic.ChrW(9), "3. Paint sprayer" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "$20.00" & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "$30.00"})
        Me.ListBox1.Location = New System.Drawing.Point(301, 15)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(387, 94)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 15
        Me.ListBox2.Location = New System.Drawing.Point(301, 131)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(387, 169)
        Me.ListBox2.TabIndex = 1
        '
        'customerBillBtn
        '
        Me.customerBillBtn.Location = New System.Drawing.Point(37, 226)
        Me.customerBillBtn.Name = "customerBillBtn"
        Me.customerBillBtn.Size = New System.Drawing.Size(185, 46)
        Me.customerBillBtn.TabIndex = 2
        Me.customerBillBtn.Text = "Display Customer Bill"
        Me.customerBillBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select an item (1, 2, or 3):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Select a duration (H or F):"
        '
        'itemTextBox
        '
        Me.itemTextBox.Location = New System.Drawing.Point(180, 128)
        Me.itemTextBox.Name = "itemTextBox"
        Me.itemTextBox.Size = New System.Drawing.Size(61, 23)
        Me.itemTextBox.TabIndex = 5
        '
        'durationTextBox
        '
        Me.durationTextBox.Location = New System.Drawing.Point(180, 182)
        Me.durationTextBox.Name = "durationTextBox"
        Me.durationTextBox.Size = New System.Drawing.Size(61, 23)
        Me.durationTextBox.TabIndex = 6
        '
        'rentalRatesBtn
        '
        Me.rentalRatesBtn.Location = New System.Drawing.Point(37, 33)
        Me.rentalRatesBtn.Name = "rentalRatesBtn"
        Me.rentalRatesBtn.Size = New System.Drawing.Size(185, 46)
        Me.rentalRatesBtn.TabIndex = 7
        Me.rentalRatesBtn.Text = "Display Rental Rates"
        Me.rentalRatesBtn.UseVisualStyleBackColor = True
        '
        'RentalCost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 312)
        Me.Controls.Add(Me.rentalRatesBtn)
        Me.Controls.Add(Me.durationTextBox)
        Me.Controls.Add(Me.itemTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.customerBillBtn)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "RentalCost"
        Me.Text = "RentalCost"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents customerBillBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents itemTextBox As TextBox
    Friend WithEvents durationTextBox As TextBox
    Friend WithEvents rentalRatesBtn As Button
End Class
