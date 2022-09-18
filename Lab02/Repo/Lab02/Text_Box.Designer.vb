<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Text_Box
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
        Me.btnDisable = New System.Windows.Forms.Button()
        Me.btnEnable = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtBox
        '
        Me.txtBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBox.Location = New System.Drawing.Point(12, 51)
        Me.txtBox.Name = "txtBox"
        Me.txtBox.Size = New System.Drawing.Size(355, 29)
        Me.txtBox.TabIndex = 0
        '
        'btnDisable
        '
        Me.btnDisable.Location = New System.Drawing.Point(12, 110)
        Me.btnDisable.Name = "btnDisable"
        Me.btnDisable.Size = New System.Drawing.Size(355, 30)
        Me.btnDisable.TabIndex = 1
        Me.btnDisable.Text = "Disable Text Box"
        Me.btnDisable.UseVisualStyleBackColor = True
        '
        'btnEnable
        '
        Me.btnEnable.Location = New System.Drawing.Point(12, 159)
        Me.btnEnable.Name = "btnEnable"
        Me.btnEnable.Size = New System.Drawing.Size(355, 30)
        Me.btnEnable.TabIndex = 2
        Me.btnEnable.Text = "Enable Text Box"
        Me.btnEnable.UseVisualStyleBackColor = True
        '
        'Text_Box
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 262)
        Me.Controls.Add(Me.btnEnable)
        Me.Controls.Add(Me.btnDisable)
        Me.Controls.Add(Me.txtBox)
        Me.Name = "Text_Box"
        Me.Text = "Text Box"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBox As TextBox
    Friend WithEvents btnDisable As Button
    Friend WithEvents btnEnable As Button
End Class
