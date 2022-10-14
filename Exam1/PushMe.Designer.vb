<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PushMe
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
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btn_Refresh = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(70, 63)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(148, 66)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "Push Me"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(250, 63)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(148, 66)
        Me.btn2.TabIndex = 1
        Me.btn2.Text = "Push Me"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(70, 158)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(148, 66)
        Me.btn3.TabIndex = 2
        Me.btn3.Text = "Push Me"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(250, 158)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(148, 66)
        Me.btn4.TabIndex = 3
        Me.btn4.Text = "Push Me"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'btn_Refresh
        '
        Me.btn_Refresh.Location = New System.Drawing.Point(1, 1)
        Me.btn_Refresh.Name = "btn_Refresh"
        Me.btn_Refresh.Size = New System.Drawing.Size(70, 35)
        Me.btn_Refresh.TabIndex = 4
        Me.btn_Refresh.Text = "Refresh"
        Me.btn_Refresh.UseVisualStyleBackColor = True
        '
        'PushMe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 282)
        Me.Controls.Add(Me.btn_Refresh)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Name = "PushMe"
        Me.Text = "PushMe"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn_Refresh As Button
End Class
