Public Class EvenNumbers
    Private Sub convertBtn_Click(sender As Object, e As EventArgs) Handles convertBtn.Click
        For i As Integer = 2 To 100 Step 2
            ListBox1.Items.Add("Even Number: " + i.ToString)
        Next
    End Sub
End Class