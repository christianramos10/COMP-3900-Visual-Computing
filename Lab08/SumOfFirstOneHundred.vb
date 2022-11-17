Public Class SumOfFirstOneHundred
    Private Sub convertBtn_Click(sender As Object, e As EventArgs) Handles convertBtn.Click
        Dim sum As Integer = 0
        For i As Integer = 1 To 100
            sum = sum + i
        Next
        ListBox1.Items.Add("The sum of the first 100 integers is: " + sum.ToString)

    End Sub
End Class