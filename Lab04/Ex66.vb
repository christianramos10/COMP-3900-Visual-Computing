Public Class Ex66

    Dim pledge, miles, total As Double
    Dim output As String
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        If pledgeTextbox.Text = "" Or milesTextBox.Text = "" Then
            Call MsgBox("Both fields required!")

        Else
            pledge = CDbl(pledgeTextbox.Text)
            miles = CDbl(milesTextBox.Text)
            total = pledge * miles

            output = "Amount is $" + total.ToString + " for $" + pledge.ToString + "/mile in " + miles.ToString + " miles."

            textBox.Text = output

        End If
    End Sub
End Class