Public Class priceReduction
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim price, markdown As Double
        Dim discountPercent As Integer
        Dim text As String


        price = 19.95

        discountPercent = 30

        markdown = (discountPercent / 100) * price

        price = price - markdown

        text = "The item's price is:"

        ListBox1.Items.Add(text)
        ListBox1.Items.Add(Math.Round(price, 2))



    End Sub
End Class