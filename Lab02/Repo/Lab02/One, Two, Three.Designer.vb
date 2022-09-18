<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class One__Two__Three
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
        Me.txtBox3 = New System.Windows.Forms.TextBox()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtBox1
        '
        Me.txtBox1.Location = New System.Drawing.Point(74, 28)
        Me.txtBox1.Name = "txtBox1"
        Me.txtBox1.Size = New System.Drawing.Size(184, 23)
        Me.txtBox1.TabIndex = 0
        Me.txtBox1.Text = "One"
        '
        'txtBox2
        '
        Me.txtBox2.Location = New System.Drawing.Point(74, 76)
        Me.txtBox2.Name = "txtBox2"
        Me.txtBox2.Size = New System.Drawing.Size(184, 23)
        Me.txtBox2.TabIndex = 1
        Me.txtBox2.Text = "Two"
        '
        'txtBox3
        '
        Me.txtBox3.Location = New System.Drawing.Point(74, 125)
        Me.txtBox3.Name = "txtBox3"
        Me.txtBox3.Size = New System.Drawing.Size(184, 23)
        Me.txtBox3.TabIndex = 2
        Me.txtBox3.Text = "Three"
        '
        'btnLeft
        '
        Me.btnLeft.Location = New System.Drawing.Point(35, 171)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(115, 38)
        Me.btnLeft.TabIndex = 3
        Me.btnLeft.Text = "Left"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(193, 171)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(115, 38)
        Me.btnRight.TabIndex = 4
        Me.btnRight.Text = "Right"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'One__Two__Three
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 240)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.txtBox3)
        Me.Controls.Add(Me.txtBox2)
        Me.Controls.Add(Me.txtBox1)
        Me.Name = "One__Two__Three"
        Me.Text = "One, Two, Three"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBox1 As TextBox
    Friend WithEvents txtBox2 As TextBox
    Friend WithEvents txtBox3 As TextBox
    Friend WithEvents btnLeft As Button
    Friend WithEvents btnRight As Button
End Class
