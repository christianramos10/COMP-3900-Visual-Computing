<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnBatman = New System.Windows.Forms.Button()
        Me.btnRobin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBatman
        '
        Me.btnBatman.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBatman.Location = New System.Drawing.Point(73, 12)
        Me.btnBatman.Name = "btnBatman"
        Me.btnBatman.Size = New System.Drawing.Size(268, 76)
        Me.btnBatman.TabIndex = 0
        Me.btnBatman.Text = "Batman"
        Me.btnBatman.UseVisualStyleBackColor = True
        '
        'btnRobin
        '
        Me.btnRobin.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnRobin.Location = New System.Drawing.Point(73, 115)
        Me.btnRobin.Name = "btnRobin"
        Me.btnRobin.Size = New System.Drawing.Size(268, 76)
        Me.btnRobin.TabIndex = 1
        Me.btnRobin.Text = "Robin"
        Me.btnRobin.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 261)
        Me.Controls.Add(Me.btnRobin)
        Me.Controls.Add(Me.btnBatman)
        Me.Name = "Form1"
        Me.Text = "Dyanmic Duo"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBatman As Button
    Friend WithEvents btnRobin As Button
End Class
