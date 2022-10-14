Public Class Calculator
    Dim result As String
    Dim operation As Double
    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        operation = CDbl(TextBox1.Text) + CDbl(TextBox2.Text)
        result = TextBox1.Text + " " + btnSum.Text + " " + TextBox2.Text + " = " + operation.ToString
        txtBoxResult.Text = result
    End Sub

    Private Sub btnSubtraction_Click(sender As Object, e As EventArgs) Handles btnSubtraction.Click
        operation = CDbl(TextBox1.Text) - CDbl(TextBox2.Text)
        result = TextBox1.Text + " " + btnSubtraction.Text + " " + TextBox2.Text + " = " + operation.ToString
        txtBoxResult.Text = result
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        operation = CDbl(TextBox1.Text) * CDbl(TextBox2.Text)
        result = TextBox1.Text + " " + btnMultiply.Text + " " + TextBox2.Text + " = " + operation.ToString
        txtBoxResult.Text = result
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.Enter
        txtBoxResult.Text = ""
    End Sub

    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter
        txtBoxResult.Text = ""
    End Sub
End Class