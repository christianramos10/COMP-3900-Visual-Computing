Public Class IdealWeight
    Private Sub weightBtn_Click(sender As Object, e As EventArgs) Handles weightBtn.Click

        If Not (lowerTxtBox.TextLength = 0 And upperTxtBox.TextLength = 0) Then
            Dim wWeight, mWeight As Double

            For i As Integer = CInt(lowerTxtBox.Text) To CInt(upperTxtBox.Text)
                wWeight = (i * 3.5) - 108
                mWeight = (i * 4) - 128

                ListBox1.Items.Add(i & vbTab & wWeight & vbTab & mWeight)

            Next

        Else
            MessageBox.Show("Please specify a lower and upper bound.")
        End If

    End Sub
End Class