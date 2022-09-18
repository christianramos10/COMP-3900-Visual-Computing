Public Class companyBreakEven
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fixedCosts, pricePerUnit, costPerUnit, breakeven As Double
        Dim text As String

        fixedCosts = 5000

        pricePerUnit = 8

        costPerUnit = 6

        breakeven = fixedCosts / (pricePerUnit - costPerUnit)

        text = "The total items to manufacture in order to break even are: "
        ListBox1.Items.Add(text)
        ListBox1.Items.Add(breakeven)
    End Sub
End Class