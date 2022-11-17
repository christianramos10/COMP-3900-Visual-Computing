Public Class LargestOfFive
    Private Sub getLargBtn_Click(sender As Object, e As EventArgs) Handles getLargBtn.Click
        Dim num(5) As Integer
        Dim largest As Integer

        num(0) = txtbox1.Text
        num(1) = txtbox2.Text
        num(2) = txtbox3.Text
        num(3) = txtbox4.Text
        num(4) = txtbox5.Text

        largest = num(0)

        For i As Integer = 1 To 4
            If num(i) > largest Then
                largest = num(i)
            End If
        Next

        txtboxResult.Text = "The largest is: " + largest.ToString
    End Sub
End Class