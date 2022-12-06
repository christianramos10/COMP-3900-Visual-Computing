Public Class Depreciation
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim carPrice As Double = 20000
        For i As Integer = 1 To 5
            carPrice = carPrice - (carPrice * 0.15)
            ListBox1.Items.Add("Year " & i & " $" & Math.Round(carPrice, 2))
        Next
    End Sub
End Class