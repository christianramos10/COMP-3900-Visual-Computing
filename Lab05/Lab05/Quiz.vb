Public Class Quiz
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (TextBox1.Text = "Willard Scott") Then
            TextBox2.Text = "Correct"
        Else
            TextBox2.Text = "Nice Try"
        End If
    End Sub
End Class