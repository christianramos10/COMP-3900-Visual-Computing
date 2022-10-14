Public Class Account
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim balance, withdraw, newBalance As Double
        Dim output As String = ""

        balance = CDbl(TextBox1.Text)
        withdraw = CDbl(TextBox2.Text)

        If (withdraw > balance) Then
            output = "Withdrawal denied."
        Else
            newBalance = balance - withdraw
            output = "New balance is $" + newBalance.ToString()
        End If

        TextBox3.Text = output
    End Sub
End Class