<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnSum = New System.Windows.Forms.Button()
        Me.btnSubtraction = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.txtBoxResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(368, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(368, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Second"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 139)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(66, 23)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(368, 139)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(66, 23)
        Me.TextBox2.TabIndex = 5
        '
        'btnSum
        '
        Me.btnSum.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSum.Location = New System.Drawing.Point(198, 25)
        Me.btnSum.Name = "btnSum"
        Me.btnSum.Size = New System.Drawing.Size(77, 55)
        Me.btnSum.TabIndex = 6
        Me.btnSum.Text = "+"
        Me.btnSum.UseVisualStyleBackColor = True
        '
        'btnSubtraction
        '
        Me.btnSubtraction.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSubtraction.Location = New System.Drawing.Point(198, 98)
        Me.btnSubtraction.Name = "btnSubtraction"
        Me.btnSubtraction.Size = New System.Drawing.Size(77, 55)
        Me.btnSubtraction.TabIndex = 7
        Me.btnSubtraction.Text = "-"
        Me.btnSubtraction.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Font = New System.Drawing.Font("Segoe UI", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMultiply.Location = New System.Drawing.Point(198, 168)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(77, 55)
        Me.btnMultiply.TabIndex = 8
        Me.btnMultiply.Text = "*"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'txtBoxResult
        '
        Me.txtBoxResult.Location = New System.Drawing.Point(151, 261)
        Me.txtBoxResult.Name = "txtBoxResult"
        Me.txtBoxResult.Size = New System.Drawing.Size(163, 23)
        Me.txtBoxResult.TabIndex = 9
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 362)
        Me.Controls.Add(Me.txtBoxResult)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnSubtraction)
        Me.Controls.Add(Me.btnSum)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Calculator"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnSum As Button
    Friend WithEvents btnSubtraction As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents txtBoxResult As TextBox
End Class
