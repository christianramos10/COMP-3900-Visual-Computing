<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _05
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
        Me.btnPush = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPush
        '
        Me.btnPush.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnPush.Location = New System.Drawing.Point(149, 74)
        Me.btnPush.Name = "btnPush"
        Me.btnPush.Size = New System.Drawing.Size(247, 112)
        Me.btnPush.TabIndex = 0
        Me.btnPush.Text = "PUSH"
        Me.btnPush.UseVisualStyleBackColor = False
        '
        '_05
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 314)
        Me.Controls.Add(Me.btnPush)
        Me.Name = "_05"
        Me.Text = "_05"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPush As Button
End Class
