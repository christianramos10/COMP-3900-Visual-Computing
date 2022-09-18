Public Class TextAlignment

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        txtBox.TextAlign = HorizontalAlignment.Left

    End Sub

    Private Sub btnCenter_Click(sender As Object, e As EventArgs) Handles btnCenter.Click
        txtBox.TextAlign = HorizontalAlignment.Center

    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        txtBox.TextAlign = HorizontalAlignment.Right

    End Sub
End Class