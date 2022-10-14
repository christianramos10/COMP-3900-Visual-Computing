<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Instructions
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
        Me.txtBox1 = New System.Windows.Forms.TextBox()
        Me.txtBox2 = New System.Windows.Forms.TextBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtBox1
        '
        Me.txtBox1.Location = New System.Drawing.Point(22, 29)
        Me.txtBox1.Name = "txtBox1"
        Me.txtBox1.Size = New System.Drawing.Size(301, 23)
        Me.txtBox1.TabIndex = 0
        '
        'txtBox2
        '
        Me.txtBox2.Location = New System.Drawing.Point(22, 157)
        Me.txtBox2.Name = "txtBox2"
        Me.txtBox2.Size = New System.Drawing.Size(301, 23)
        Me.txtBox2.TabIndex = 1
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(22, 88)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(0, 15)
        Me.lbl.TabIndex = 2
        '
        'Instructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 255)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.txtBox2)
        Me.Controls.Add(Me.txtBox1)
        Me.Name = "Instructions"
        Me.Text = "Instructions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBox1 As TextBox
    Friend WithEvents txtBox2 As TextBox
    Friend WithEvents lbl As Label
End Class
