<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Interest
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
        Me.interestBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Items.AddRange(New Object() {"               SIMPLE                   COMPOUND", "YEAR     INTEREST              INTEREST"})
        Me.ListBox1.Location = New System.Drawing.Point(86, 76)
        Me.ListBox1.MultiColumn = True
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(228, 364)
        Me.ListBox1.TabIndex = 3
        '
        'interestBtn
        '
        Me.interestBtn.Location = New System.Drawing.Point(143, 11)
        Me.interestBtn.Name = "interestBtn"
        Me.interestBtn.Size = New System.Drawing.Size(115, 43)
        Me.interestBtn.TabIndex = 2
        Me.interestBtn.Text = "Get Interest"
        Me.interestBtn.UseVisualStyleBackColor = True
        '
        'CompundInterest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 450)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.interestBtn)
        Me.Name = "CompundInterest"
        Me.Text = "CompundInterest"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents interestBtn As Button
End Class
