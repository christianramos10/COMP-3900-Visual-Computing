Public Class CopyCenter
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tip As Double = 0
        Dim temp As Double = 0
        Dim input As String = ""

        tip = CDbl(TextBox1.Text)

        If (tip >= 1 And tip <= 100) Then
            tip = tip * 0.05

        ElseIf (tip > 100) Then
            temp = 100 * 0.05
            tip = ((tip - 100) * 0.03) + temp
        End If
        input = "$" + tip.ToString()
        TextBox2.Text = input
    End Sub
End Class