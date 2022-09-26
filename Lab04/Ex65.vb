Public Class Ex65

    Dim begOfYearCost, endOfYearCost, percentIncrease As Double
    Dim output As String
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        If endYearCostTextBox.TextLength = 0 Then
            Call MsgBox("Please enter a end of year cost value")
        Else
            begOfYearCost = 200
            endOfYearCost = CDbl(endYearCostTextBox.Text)
            percentIncrease = ((endOfYearCost - begOfYearCost) / begOfYearCost) * 100

            output = "Year percent increase is " + percentIncrease.ToString + "%."
            textBox.Text = output
        End If

    End Sub
End Class