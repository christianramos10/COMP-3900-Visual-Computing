<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.megacitiesDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.megacitiesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'displayBtn
        '
        Me.displayBtn.Location = New System.Drawing.Point(125, 12)
        Me.displayBtn.Name = "displayBtn"
        Me.displayBtn.Size = New System.Drawing.Size(211, 36)
        Me.displayBtn.TabIndex = 0
        Me.displayBtn.Text = "Display Data"
        Me.displayBtn.UseVisualStyleBackColor = True
        '
        'megacitiesDataGridView
        '
        Me.megacitiesDataGridView.AllowUserToAddRows = False
        Me.megacitiesDataGridView.AllowUserToDeleteRows = False
        Me.megacitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.megacitiesDataGridView.Location = New System.Drawing.Point(12, 54)
        Me.megacitiesDataGridView.Name = "megacitiesDataGridView"
        Me.megacitiesDataGridView.ReadOnly = True
        Me.megacitiesDataGridView.Size = New System.Drawing.Size(415, 384)
        Me.megacitiesDataGridView.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 450)
        Me.Controls.Add(Me.megacitiesDataGridView)
        Me.Controls.Add(Me.displayBtn)
        Me.Name = "Form1"
        Me.Text = "Megacities"
        CType(Me.megacitiesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents displayBtn As Button
    Friend WithEvents megacitiesDataGridView As DataGridView
End Class
