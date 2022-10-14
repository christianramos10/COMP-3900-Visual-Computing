Public Class Tip
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tip As Double = 0
        Dim input As String = ""

        tip = CDbl(TextBox1.Text) * 0.15

        If (tip < 1) Then
            tip = 1
    
        End If
        input = "$" + tip.ToString()
        TextBox2.Text = input
    End Sub
End Class