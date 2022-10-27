Public Class CarLoan
    Private Sub analyzeBtn_Click(sender As Object, e As EventArgs) Handles analyzeBtn.Click
        Dim loanAmount, interestRate, monthlyPayment, interestPaid As Double
        Dim duration As Integer
        Dim payment, totalInterest As String

        loanAmount = CDbl(loanAmountTextBox.Text)
        interestRate = (CDbl(interestRateTextBox.Text) / 100) / 12
        duration = CInt(durationTextBox.Text)

        monthlyPayment = Math.Round((loanAmount * interestRate) / (1 - 1 / (1 + interestRate) ^ (duration)), 2)
        interestPaid = Math.Round(duration * monthlyPayment - loanAmount, 2)

        payment = "$" + monthlyPayment.ToString()
        totalInterest = "$" + interestPaid.ToString()

        paymentsTextBox.Text = payment
        totalInterestTextBox.Text = totalInterest
    End Sub
End Class