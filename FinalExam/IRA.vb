Public Class IRA
    Private Sub calculateBtn_Click(sender As Object, e As EventArgs) Handles calculateBtn.Click
        Dim deposit1, deposit2, postBalance1, postBalance2 As Double
        postBalance1 = 0
        postBalance2 = 0
        deposit1 = 15 * 5000
        deposit2 = 33 * 5000

        amount1TxtBox.Text = "$" & Math.Round(deposit1, 2)
        amount2TxtBox.Text = "$" & Math.Round(deposit2, 2)

        For i As Integer = 1 To 15
            postBalance1 = (postBalance1 * 1.04) + 5000
        Next

        postBalance1 = postBalance1 * (1.04) ^ 33

        For i As Integer = 1 To 33
            postBalance2 = (postBalance2 * 1.04) + 5000
        Next

        postAmount1TxtBox.Text = "$" & Math.Round(postBalance1, 2)
        postAmount2TxtBox.Text = "$" & Math.Round(postBalance2, 2)


    End Sub
End Class