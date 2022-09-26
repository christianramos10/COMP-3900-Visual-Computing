<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ex66
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
        Me.pledgeTextbox = New System.Windows.Forms.TextBox()
        Me.milesTextBox = New System.Windows.Forms.TextBox()
        Me.btn = New System.Windows.Forms.Button()
        Me.textBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(74, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mile Pledge:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(74, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Miles walked:"
        '
        'pledgeTextbox
        '
        Me.pledgeTextbox.Location = New System.Drawing.Point(174, 27)
        Me.pledgeTextbox.Name = "pledgeTextbox"
        Me.pledgeTextbox.Size = New System.Drawing.Size(106, 23)
        Me.pledgeTextbox.TabIndex = 2
        '
        'milesTextBox
        '
        Me.milesTextBox.Location = New System.Drawing.Point(183, 77)
        Me.milesTextBox.Name = "milesTextBox"
        Me.milesTextBox.Size = New System.Drawing.Size(106, 23)
        Me.milesTextBox.TabIndex = 3
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(96, 128)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(167, 35)
        Me.btn.TabIndex = 4
        Me.btn.Text = "Generate Pay"
        Me.btn.UseVisualStyleBackColor = True
        '
        'textBox
        '
        Me.textBox.Location = New System.Drawing.Point(36, 198)
        Me.textBox.Name = "textBox"
        Me.textBox.ReadOnly = True
        Me.textBox.Size = New System.Drawing.Size(292, 23)
        Me.textBox.TabIndex = 5
        '
        'Ex66
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 308)
        Me.Controls.Add(Me.textBox)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.milesTextBox)
        Me.Controls.Add(Me.pledgeTextbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Ex66"
        Me.Text = "Walk-A-Thon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pledgeTextbox As TextBox
    Friend WithEvents milesTextBox As TextBox
    Friend WithEvents btn As Button
    Friend WithEvents textBox As TextBox
End Class
