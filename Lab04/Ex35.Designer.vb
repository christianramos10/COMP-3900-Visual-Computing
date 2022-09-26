<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ex35
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
        Me.textBox = New System.Windows.Forms.TextBox()
        Me.btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textBox
        '
        Me.textBox.Location = New System.Drawing.Point(12, 35)
        Me.textBox.Name = "textBox"
        Me.textBox.Size = New System.Drawing.Size(400, 23)
        Me.textBox.TabIndex = 0
        '
        'btn
        '
        Me.btn.Location = New System.Drawing.Point(109, 80)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(201, 49)
        Me.btn.TabIndex = 1
        Me.btn.Text = "Generate"
        Me.btn.UseVisualStyleBackColor = True
        '
        'Ex35
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 304)
        Me.Controls.Add(Me.btn)
        Me.Controls.Add(Me.textBox)
        Me.Name = "Ex35"
        Me.Text = "Copyright Statement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textBox As TextBox
    Friend WithEvents btn As Button
End Class
