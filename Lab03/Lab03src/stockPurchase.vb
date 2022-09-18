Public Class stockPurchase
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim costPerShare, amount As Double
        Dim numOfShares As Integer
        Dim text As String


        costPerShare = 25.625

        numOfShares = 400

        amount = costPerShare * numOfShares

        text = "The total amount is: "

        ListBox1.Items.Add(text)
        ListBox1.Items.Add(amount)

    End Sub
End Class