Public Class Average
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim score1, score2, score3, average As Double
        Dim output As String = ""

        score1 = CDbl(TextBox1.Text)
        score2 = CDbl(TextBox3.Text)
        score3 = CDbl(TextBox4.Text)

        If (score1 <= score2 And score1 <= score3) Then
            average = ((score2 + score3) / 2)

        ElseIf (score2 <= score1 And score2 <= score3) Then
            average = ((score1 + score3) / 2)
        Else
            average = ((score1 + score2) / 2)

        End If

        TextBox2.Text = average.ToString()
    End Sub
End Class