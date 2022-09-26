Public Class Ex36

    Dim prefix, phrase, output As String
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        prefix = "Fore"
        phrase = "warned is Forearmed."
        output = prefix + phrase

        textBox.Text = output
        textBox.ForeColor = Color.Red
    End Sub
End Class