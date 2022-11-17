Public Class AverageOfFiveNumbers
    Private Sub getAveBtn_Click(sender As Object, e As EventArgs) Handles getAveBtn.Click

        Dim num1, num2, num3, num4, num5 As Integer
        Dim ave As Double

        num1 = txtbox1.Text
        num2 = txtbox2.Text
        num3 = txtbox3.Text
        num4 = txtbox4.Text
        num5 = txtbox5.Text


        ave = ((num1 + num2 + num3 + num4 + num5) / 5)

        txtboxResult.Text = "The average is: " + ave.ToString


    End Sub
End Class