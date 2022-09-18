<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColorfulText
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
        Me.lblBack = New System.Windows.Forms.Label()
        Me.btnBackRed = New System.Windows.Forms.Button()
        Me.btnBackBlue = New System.Windows.Forms.Button()
        Me.txtBox = New System.Windows.Forms.TextBox()
        Me.btnForeYellow = New System.Windows.Forms.Button()
        Me.btnForeWhite = New System.Windows.Forms.Button()
        Me.lblFore = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblBack.Location = New System.Drawing.Point(12, 35)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(83, 19)
        Me.lblBack.TabIndex = 0
        Me.lblBack.Text = "Background"
        '
        'btnBackRed
        '
        Me.btnBackRed.Location = New System.Drawing.Point(121, 30)
        Me.btnBackRed.Name = "btnBackRed"
        Me.btnBackRed.Size = New System.Drawing.Size(89, 30)
        Me.btnBackRed.TabIndex = 1
        Me.btnBackRed.Text = "Red"
        Me.btnBackRed.UseVisualStyleBackColor = True
        '
        'btnBackBlue
        '
        Me.btnBackBlue.Location = New System.Drawing.Point(235, 30)
        Me.btnBackBlue.Name = "btnBackBlue"
        Me.btnBackBlue.Size = New System.Drawing.Size(89, 30)
        Me.btnBackBlue.TabIndex = 2
        Me.btnBackBlue.Text = "Blue"
        Me.btnBackBlue.UseVisualStyleBackColor = True
        '
        'txtBox
        '
        Me.txtBox.Location = New System.Drawing.Point(12, 80)
        Me.txtBox.Name = "txtBox"
        Me.txtBox.Size = New System.Drawing.Size(312, 23)
        Me.txtBox.TabIndex = 3
        Me.txtBox.Text = "Beautiful Day"
        Me.txtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnForeYellow
        '
        Me.btnForeYellow.Location = New System.Drawing.Point(235, 128)
        Me.btnForeYellow.Name = "btnForeYellow"
        Me.btnForeYellow.Size = New System.Drawing.Size(89, 30)
        Me.btnForeYellow.TabIndex = 6
        Me.btnForeYellow.Text = "Yellow"
        Me.btnForeYellow.UseVisualStyleBackColor = True
        '
        'btnForeWhite
        '
        Me.btnForeWhite.Location = New System.Drawing.Point(121, 128)
        Me.btnForeWhite.Name = "btnForeWhite"
        Me.btnForeWhite.Size = New System.Drawing.Size(89, 30)
        Me.btnForeWhite.TabIndex = 5
        Me.btnForeWhite.Text = "White"
        Me.btnForeWhite.UseVisualStyleBackColor = True
        '
        'lblFore
        '
        Me.lblFore.AutoSize = True
        Me.lblFore.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblFore.Location = New System.Drawing.Point(12, 133)
        Me.lblFore.Name = "lblFore"
        Me.lblFore.Size = New System.Drawing.Size(80, 19)
        Me.lblFore.TabIndex = 4
        Me.lblFore.Text = "Foreground"
        '
        'ColorfulText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 204)
        Me.Controls.Add(Me.btnForeYellow)
        Me.Controls.Add(Me.btnForeWhite)
        Me.Controls.Add(Me.lblFore)
        Me.Controls.Add(Me.txtBox)
        Me.Controls.Add(Me.btnBackBlue)
        Me.Controls.Add(Me.btnBackRed)
        Me.Controls.Add(Me.lblBack)
        Me.Name = "ColorfulText"
        Me.Text = "ColorfulText"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBack As Label
    Friend WithEvents btnBackRed As Button
    Friend WithEvents btnBackBlue As Button
    Friend WithEvents txtBox As TextBox
    Friend WithEvents btnForeYellow As Button
    Friend WithEvents btnForeWhite As Button
    Friend WithEvents lblFore As Label
End Class
