<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class companyProfit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(119, 47)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(170, 34)
        Me.btn.TabIndex = 0
        Me.btn.Text = "See Profits"
        Me.btn.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(119, 117)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(170, 94)
        Me.ListBox1.TabIndex = 1
        '
        'companyProfit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 312)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btn)
        Me.Name = "companyProfit"
        Me.Text = "Company's Profit"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn As Button
    Friend WithEvents ListBox1 As ListBox
End Class
