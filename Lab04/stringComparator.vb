Public Class stringComparator
    Dim ansi1, ansi2, result As String


    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        If (txtBox1.Text.Length() > 0 And txtBox2.Text.Length() > 0) Then
            ansi1 = CStr(Asc(txtBox1.Text))
            ansi2 = CStr(Asc(txtBox2.Text))
            result = txtBox1.Text + " = " + ansi1 + " and " + txtBox2.Text + " = " + ansi2
            txtBoxResult.Text = result
        End If
    End Sub
End Class