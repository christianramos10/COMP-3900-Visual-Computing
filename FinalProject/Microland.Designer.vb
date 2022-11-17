<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Microland
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.outOfStockBtn = New System.Windows.Forms.Button()
        Me.billBtn = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'outOfStockBtn
        '
        Me.outOfStockBtn.Location = New System.Drawing.Point(62, 12)
        Me.outOfStockBtn.Name = "outOfStockBtn"
        Me.outOfStockBtn.Size = New System.Drawing.Size(121, 53)
        Me.outOfStockBtn.TabIndex = 0
        Me.outOfStockBtn.Text = "Out of Sotck" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Items"
        Me.outOfStockBtn.UseVisualStyleBackColor = True
        '
        'billBtn
        '
        Me.billBtn.Location = New System.Drawing.Point(206, 12)
        Me.billBtn.Name = "billBtn"
        Me.billBtn.Size = New System.Drawing.Size(121, 53)
        Me.billBtn.TabIndex = 1
        Me.billBtn.Text = "Bill for Today's " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Orders"
        Me.billBtn.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Location = New System.Drawing.Point(12, 81)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(361, 304)
        Me.ListBox1.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(398, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(634, 350)
        Me.DataGridView1.TabIndex = 3
        '
        'Microland
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 397)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.billBtn)
        Me.Controls.Add(Me.outOfStockBtn)
        Me.Name = "Microland"
        Me.Text = "Microland"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents outOfStockBtn As Button
    Friend WithEvents billBtn As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
