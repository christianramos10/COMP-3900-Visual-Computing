<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sayings
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
        Me.txtBoxLife = New System.Windows.Forms.TextBox()
        Me.txtBoxFuture = New System.Windows.Forms.TextBox()
        Me.txtBoxTruth = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtBox
        '
        Me.txtBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtBox.Location = New System.Drawing.Point(12, 23)
        Me.txtBox.Name = "txtBox"
        Me.txtBox.Size = New System.Drawing.Size(407, 29)
        Me.txtBox.TabIndex = 0
        '
        'txtBoxLife
        '
        Me.txtBoxLife.Location = New System.Drawing.Point(12, 110)
        Me.txtBoxLife.Name = "txtBoxLife"
        Me.txtBoxLife.Size = New System.Drawing.Size(100, 23)
        Me.txtBoxLife.TabIndex = 1
        Me.txtBoxLife.Text = "Life"
        '
        'txtBoxFuture
        '
        Me.txtBoxFuture.Location = New System.Drawing.Point(165, 110)
        Me.txtBoxFuture.Name = "txtBoxFuture"
        Me.txtBoxFuture.Size = New System.Drawing.Size(100, 23)
        Me.txtBoxFuture.TabIndex = 2
        Me.txtBoxFuture.Text = "Future"
        '
        'txtBoxTruth
        '
        Me.txtBoxTruth.Location = New System.Drawing.Point(319, 110)
        Me.txtBoxTruth.Name = "txtBoxTruth"
        Me.txtBoxTruth.Size = New System.Drawing.Size(100, 23)
        Me.txtBoxTruth.TabIndex = 3
        Me.txtBoxTruth.Text = "Truth"
        '
        'Sayings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 218)
        Me.Controls.Add(Me.txtBoxTruth)
        Me.Controls.Add(Me.txtBoxFuture)
        Me.Controls.Add(Me.txtBoxLife)
        Me.Controls.Add(Me.txtBox)
        Me.Name = "Sayings"
        Me.Text = "Sayings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBox As TextBox
    Friend WithEvents txtBoxLife As TextBox
    Friend WithEvents txtBoxFuture As TextBox
    Friend WithEvents txtBoxTruth As TextBox
End Class
