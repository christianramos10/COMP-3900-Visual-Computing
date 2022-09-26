Public Class Ex33

    Dim firstname, middleName, lastName, output As String
    Dim yearOfBirth As Integer
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        firstname = "Thomas"
        middleName = "Alva"
        lastName = "Edison"
        yearOfBirth = 1847

        output = firstname + " " + middleName + " " + lastName + ", " + yearOfBirth.ToString + "."

        textBox.Text = output
        textBox.ForeColor = Color.Red

    End Sub
End Class