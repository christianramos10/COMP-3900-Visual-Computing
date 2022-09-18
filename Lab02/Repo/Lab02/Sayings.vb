Public Class Sayings
    Private Sub txtBoxLife_Enter(sender As Object, e As EventArgs) Handles txtBoxLife.Enter
        txtBox.Text = "I like life, it's something to do."
        txtBoxLife.BackColor = Color.Green
    End Sub

    Private Sub txtBoxLife_Leave(sender As Object, e As EventArgs) Handles txtBoxLife.Leave
        txtBox.Text = ""
        txtBoxLife.BackColor = Color.White
    End Sub

    Private Sub txtBoxFuture_Enter(sender As Object, e As EventArgs) Handles txtBoxFuture.Enter
        txtBox.Text = "The future isn't what it used to be."
        txtBoxFuture.BackColor = Color.Green
    End Sub

    Private Sub txtBoxFuture_Leave(sender As Object, e As EventArgs) Handles txtBoxFuture.Leave
        txtBox.Text = ""
        txtBoxFuture.BackColor = Color.White
    End Sub

    Private Sub txtBoxTruth_Enter(sender As Object, e As EventArgs) Handles txtBoxTruth.Enter
        txtBox.Text = "Tell the truth and run."
        txtBoxTruth.BackColor = Color.Green
    End Sub

    Private Sub txtBoxTruth_Leave(sender As Object, e As EventArgs) Handles txtBoxTruth.Leave
        txtBox.Text = ""
        txtBoxTruth.BackColor = Color.White
    End Sub
End Class