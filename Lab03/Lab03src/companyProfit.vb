Public Class companyProfit

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Dim revenue, costs, profit As Double
        revenue = 98456
        costs = 45000
        profit = revenue - costs

        Dim text As String
        text = "The company's total profit is: "
        ListBox1.Items.Add(text)
        ListBox1.Items.Add(profit)
    End Sub
End Class
