<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ex8
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
        Me.displayBtn = New System.Windows.Forms.Button()
        Me.listBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'displayBtn
        '
        Me.displayBtn.Location = New System.Drawing.Point(47, 12)
        Me.displayBtn.Name = "displayBtn"
        Me.displayBtn.Size = New System.Drawing.Size(211, 36)
        Me.displayBtn.TabIndex = 3
        Me.displayBtn.Text = "Display Data"
        Me.displayBtn.UseVisualStyleBackColor = True
        '
        'listBox
        '
        Me.listBox.FormattingEnabled = True
        Me.listBox.Location = New System.Drawing.Point(47, 76)
        Me.listBox.Name = "listBox"
        Me.listBox.Size = New System.Drawing.Size(211, 303)
        Me.listBox.TabIndex = 4
        '
        'Ex8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 401)
        Me.Controls.Add(Me.listBox)
        Me.Controls.Add(Me.displayBtn)
        Me.Name = "Ex8"
        Me.Text = "Megacities"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents displayBtn As Button
    Friend WithEvents listBox As ListBox
End Class
