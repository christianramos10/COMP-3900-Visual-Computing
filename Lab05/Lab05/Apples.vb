Imports System.Formats.Asn1.AsnWriter

Public Class Apples
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim weight, payment, change As Double
        Dim output As String = ""

        weight = CDbl(TextBox1.Text)
        payment = CDbl(TextBox2.Text)

        If (payment < (weight * 2.5)) Then
            change = ((weight * 2.5) - payment)
            output = "I need $" + change.ToString() + " more."
        Else
            change = (payment - (weight * 2.5))
            output = "Your change is $" + change.ToString()
        End If

        TextBox3.Text = output
    End Sub
End Class