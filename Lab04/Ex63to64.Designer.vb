<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ex63to64
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
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textBox
        '
        Me.textBox.Location = New System.Drawing.Point(12, 39)
        Me.textBox.Name = "textBox"
        Me.textBox.Size = New System.Drawing.Size(427, 23)
        Me.textBox.TabIndex = 0
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(12, 99)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(427, 23)
        Me.textBox2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(445, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button Ex 63"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(445, 92)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(178, 35)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button Ex 63"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Ex63to64
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 165)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox)
        Me.Name = "Ex63to64"
        Me.Text = "Ex63to64"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textBox As TextBox
    Friend WithEvents textBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
