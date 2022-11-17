Public Class Interest
    Private Sub interestBtn_Click(sender As Object, e As EventArgs) Handles interestBtn.Click
        Dim simple, compound As Double

        simple = 1000 + 50
        compound = 1000 * 1.05

        For i As Integer = 1 To 9
            ListBox1.Items.Add(i & vbTab & FormatCurrency(simple.ToString) & vbTab & FormatCurrency(compound.ToString))
            simple = simple + (simple * 0.05)
            compound = compound * 1.05
        Next
    End Sub
End Class