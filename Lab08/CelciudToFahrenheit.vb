Public Class CelciudToFahrenheit

    Private Sub convertBtn_Click(sender As Object, e As EventArgs) Handles convertBtn.Click

        For i As Integer = 10 To 95 Step 5
            Dim F As Integer = (9 / 5 * i) + 32

            ListBox1.Items.Add("Celcius: " + i.ToString + " Farenheit: " + F.ToString)

        Next
    End Sub
End Class