Public Class Ex35

    Dim publisher, output As String

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        publisher = "Prentice Hall, Inc."

        output = "(c) " + publisher

        textBox.Text = output
        textBox.ForeColor = Color.Red
    End Sub
End Class