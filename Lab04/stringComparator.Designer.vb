<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class stringComparator
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBox1 = New System.Windows.Forms.TextBox()
        Me.txtBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnResult = New System.Windows.Forms.Button()
        Me.txtBoxResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(143, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Comparator:"
        '
        'txtBox1
        '
        Me.txtBox1.Location = New System.Drawing.Point(41, 99)
        Me.txtBox1.Name = "txtBox1"
        Me.txtBox1.Size = New System.Drawing.Size(100, 23)
        Me.txtBox1.TabIndex = 1
        '
        'txtBox2
        '
        Me.txtBox2.Location = New System.Drawing.Point(258, 99)
        Me.txtBox2.Name = "txtBox2"
        Me.txtBox2.Size = New System.Drawing.Size(100, 23)
        Me.txtBox2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(41, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "String 1:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(258, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "String 2:"
        '
        'btnResult
        '
        Me.btnResult.Location = New System.Drawing.Point(143, 147)
        Me.btnResult.Name = "btnResult"
        Me.btnResult.Size = New System.Drawing.Size(116, 37)
        Me.btnResult.TabIndex = 5
        Me.btnResult.Text = "Result"
        Me.btnResult.UseVisualStyleBackColor = True
        '
        'txtBoxResult
        '
        Me.txtBoxResult.Location = New System.Drawing.Point(41, 207)
        Me.txtBoxResult.Name = "txtBoxResult"
        Me.txtBoxResult.ReadOnly = True
        Me.txtBoxResult.Size = New System.Drawing.Size(317, 23)
        Me.txtBoxResult.TabIndex = 6
        '
        'stringComparator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 260)
        Me.Controls.Add(Me.txtBoxResult)
        Me.Controls.Add(Me.btnResult)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBox2)
        Me.Controls.Add(Me.txtBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "stringComparator"
        Me.Text = "stringComparator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBox1 As TextBox
    Friend WithEvents txtBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnResult As Button
    Friend WithEvents txtBoxResult As TextBox
End Class
