Public Class One__Two__Three
    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        txtBox1.TextAlign = HorizontalAlignment.Left
        txtBox2.TextAlign = HorizontalAlignment.Left
        txtBox3.TextAlign = HorizontalAlignment.Left
    End Sub

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        txtBox1.TextAlign = HorizontalAlignment.Right
        txtBox2.TextAlign = HorizontalAlignment.Right
        txtBox3.TextAlign = HorizontalAlignment.Right
    End Sub

    Private Sub txtBox1_Enter(sender As Object, e As EventArgs) Handles txtBox1.Enter
        txtBox1.ForeColor = Color.Red
    End Sub

    Private Sub txtBox1_Leave(sender As Object, e As EventArgs) Handles txtBox1.Leave
        txtBox1.ForeColor = Color.Black
    End Sub

    Private Sub txtBox2_Enter(sender As Object, e As EventArgs) Handles txtBox2.Enter
        txtBox2.ForeColor = Color.Red
    End Sub

    Private Sub txtBox2_Leave(sender As Object, e As EventArgs) Handles txtBox2.Leave
        txtBox2.ForeColor = Color.Black
    End Sub

    Private Sub txtBox3_Enter(sender As Object, e As EventArgs) Handles txtBox3.Enter
        txtBox3.ForeColor = Color.Red
    End Sub

    Private Sub txtBox3_Leave(sender As Object, e As EventArgs) Handles txtBox3.Leave
        txtBox3.ForeColor = Color.Black
    End Sub
End Class