Public Class LifetimeEarnings
    Private Sub computeBtn_Click(sender As Object, e As EventArgs) Handles computeBtn.Click
        resultTxtBox.Text = ""
        Dim name As String = nameTxtBox.Text
        Dim age As Integer = ageTxtBox.Text
        Dim salary As Double = salaryTxtBox.Text

        For i As Integer = age To 64
            salary += salary * 0.05
            age += 1
        Next

        resultTxtBox.Text = name & " will earn about $" & Math.Round(salary, 2)
    End Sub
End Class