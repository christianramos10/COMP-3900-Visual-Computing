<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EvenNumbers
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.convertBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(80, 77)
        Me.ListBox1.MultiColumn = True
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(228, 364)
        Me.ListBox1.TabIndex = 3
        '
        'convertBtn
        '
        Me.convertBtn.Location = New System.Drawing.Point(137, 12)
        Me.convertBtn.Name = "convertBtn"
        Me.convertBtn.Size = New System.Drawing.Size(115, 43)
        Me.convertBtn.TabIndex = 2
        Me.convertBtn.Text = "Convert"
        Me.convertBtn.UseVisualStyleBackColor = True
        '
        'EvenNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 450)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.convertBtn)
        Me.Name = "EvenNumbers"
        Me.Text = "EvenNumbers"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents convertBtn As Button
End Class
