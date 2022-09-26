<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ex65
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
        Me.endYearCostTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn = New System.Windows.Forms.Button()
        Me.textBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'endYearCostTextBox
        '
        Me.endYearCostTextBox.Location = New System.Drawing.Point(232, 25)
        Me.endYearCostTextBox.Name = "endYearCostTextBox"
        Me.endYearCostTextBox.Size = New System.Drawing.Size(139, 23)
        Me.endYearCostTextBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(118, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "End Year Cost:"
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(174, 84)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(133, 37)
        Me.btn.TabIndex = 2
        Me.btn.Text = "Get Increase %"
        Me.btn.UseVisualStyleBackColor = True
        '
        'textBox
        '
        Me.textBox.Location = New System.Drawing.Point(102, 160)
        Me.textBox.Name = "textBox"
        Me.textBox.ReadOnly = True
        Me.textBox.Size = New System.Drawing.Size(291, 23)
        Me.textBox.TabIndex = 3
        '
        'Ex65
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 305)
        Me.Controls.Add(Me.textBox)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.endYearCostTextBox)
        Me.Name = "Ex65"
        Me.Text = "Grocery Basket"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents endYearCostTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn As Button
    Friend WithEvents textBox As TextBox
End Class
