Public Class ColorfulText
    Private Sub btnBackRed_Click(sender As Object, e As EventArgs) Handles btnBackRed.Click
        txtBox.BackColor = Color.Red
    End Sub

    Private Sub btnBackBlue_Click(sender As Object, e As EventArgs) Handles btnBackBlue.Click
        txtBox.BackColor = Color.Blue
    End Sub

    Private Sub btnForeWhite_Click(sender As Object, e As EventArgs) Handles btnForeWhite.Click
        txtBox.ForeColor = Color.White
    End Sub

    Private Sub btnForeYellow_Click(sender As Object, e As EventArgs) Handles btnForeYellow.Click
        txtBox.ForeColor = Color.Yellow
    End Sub
End Class