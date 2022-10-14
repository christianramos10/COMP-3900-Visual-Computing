Public Class Instructions
    Private Sub txtBox1_Enter(sender As Object, e As EventArgs) Handles txtBox1.Enter
        lbl.Text = "Enter your full name."
    End Sub

    Private Sub txtBox1_Leave(sender As Object, e As EventArgs) Handles txtBox1.Leave
        lbl.Text = ""
    End Sub

    Private Sub txtBox2_Enter(sender As Object, e As EventArgs) Handles txtBox2.Enter
        lbl.Text = "Enter your phone number, including area code."
    End Sub

    Private Sub txtBox2_Leave(sender As Object, e As EventArgs) Handles txtBox2.Leave
        lbl.Text = ""
    End Sub
End Class