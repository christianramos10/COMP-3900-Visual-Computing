Public Class Ex34
    Dim item, output As String
    Dim regularPrice, discount, total As Double
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        item = "Ketchup"
        regularPrice = 1.8
        discount = 0.27
        total = regularPrice - discount

        output = total.ToString + " is the sale price for " + item

        textBox.Text = output
        textBox.ForeColor = Color.Red

    End Sub
End Class