<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextAlignment
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
        Me.txtBox = New System.Windows.Forms.TextBox()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnCenter = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtBox
        '
        Me.txtBox.Location = New System.Drawing.Point(64, 31)
        Me.txtBox.Name = "txtBox"
        Me.txtBox.ReadOnly = True
        Me.txtBox.Size = New System.Drawing.Size(203, 23)
        Me.txtBox.TabIndex = 0
        Me.txtBox.Text = "This is a text box."
        '
        'btnLeft
        '
        Me.btnLeft.Location = New System.Drawing.Point(64, 81)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(203, 37)
        Me.btnLeft.TabIndex = 1
        Me.btnLeft.Text = "Left Justify"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnCenter
        '
        Me.btnCenter.Location = New System.Drawing.Point(64, 135)
        Me.btnCenter.Name = "btnCenter"
        Me.btnCenter.Size = New System.Drawing.Size(203, 37)
        Me.btnCenter.TabIndex = 2
        Me.btnCenter.Text = "Center"
        Me.btnCenter.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(64, 191)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(203, 37)
        Me.btnRight.TabIndex = 3
        Me.btnRight.Text = "Right Justify"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'TextAlignment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 293)
        Me.Controls.Add(Me.btnRight)
        Me.Controls.Add(Me.btnCenter)
        Me.Controls.Add(Me.btnLeft)
        Me.Controls.Add(Me.txtBox)
        Me.Name = "TextAlignment"
        Me.Text = "TextAlignment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBox As TextBox
    Friend WithEvents btnLeft As Button
    Friend WithEvents btnCenter As Button
    Friend WithEvents btnRight As Button
End Class
