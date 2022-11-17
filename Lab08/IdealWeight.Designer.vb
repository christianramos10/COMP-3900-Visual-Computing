<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IdealWeight
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
        Me.weightBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lowerTxtBox = New System.Windows.Forms.TextBox()
        Me.upperTxtBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Items.AddRange(New Object() {"                 Weight            Weight", "Height     Women           Men"})
        Me.ListBox1.Location = New System.Drawing.Point(178, 33)
        Me.ListBox1.MultiColumn = True
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.ScrollAlwaysVisible = True
        Me.ListBox1.Size = New System.Drawing.Size(188, 439)
        Me.ListBox1.TabIndex = 5
        '
        'weightBtn
        '
        Me.weightBtn.Location = New System.Drawing.Point(29, 225)
        Me.weightBtn.Name = "weightBtn"
        Me.weightBtn.Size = New System.Drawing.Size(115, 43)
        Me.weightBtn.TabIndex = 4
        Me.weightBtn.Text = "Get Weight"
        Me.weightBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(29, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Lower Bound"
        '
        'lowerTxtBox
        '
        Me.lowerTxtBox.Location = New System.Drawing.Point(29, 102)
        Me.lowerTxtBox.Name = "lowerTxtBox"
        Me.lowerTxtBox.Size = New System.Drawing.Size(100, 23)
        Me.lowerTxtBox.TabIndex = 7
        '
        'upperTxtBox
        '
        Me.upperTxtBox.Location = New System.Drawing.Point(29, 177)
        Me.upperTxtBox.Name = "upperTxtBox"
        Me.upperTxtBox.Size = New System.Drawing.Size(100, 23)
        Me.upperTxtBox.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(29, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 22)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Upper Bound"
        '
        'IdealWeight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 501)
        Me.Controls.Add(Me.upperTxtBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lowerTxtBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.weightBtn)
        Me.Name = "IdealWeight"
        Me.Text = "IdealWeight"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents weightBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lowerTxtBox As TextBox
    Friend WithEvents upperTxtBox As TextBox
    Friend WithEvents Label2 As Label
End Class
