Public Class RentalCost
    Private Sub RentalCost_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Visible = False
    End Sub

    Private Sub customerBillBtn_Click(sender As Object, e As EventArgs) Handles customerBillBtn.Click
        ListBox2.Items.Clear()

        Dim item As Integer
        Dim duration, equipment, rental As String
        Dim bill, eqbill As Double

        item = CInt(itemTextBox.Text)
        duration = durationTextBox.Text

        If item = 1 Then
            equipment = "Rug cleaner"
            If duration = "H" Then
                bill = 30 + 16
                eqbill = 16
                rental = "(Half Day Rental)"
            Else
                bill = 30 + 24
                eqbill = 24
                rental = "(Full Day Rental)"
            End If

        ElseIf item = 2 Then
            equipment = "Lawn mower"
            If duration = "H" Then
                bill = 30 + 12
                eqbill = 12
                rental = "(Half Day Rental)"
            Else
                bill = 30 + 18
                eqbill = 18
                rental = "(Full Day Rental)"
            End If

        ElseIf item = 3 Then
            equipment = "Paint sprayer"
            If duration = "H" Then
                bill = 30 + 20
                eqbill = 20
                rental = "(Half Day Rental)"
            Else
                bill = 30 + 30
                eqbill = 30
                rental = "(Full Day Rental)"
            End If
        End If



        ListBox2.Items.Add("Recipient from Eddie's Equipment Rental")
        ListBox2.Items.Add(" ")
        ListBox2.Items.Add(" ")
        ListBox2.Items.Add(equipment + " $" + eqbill.ToString + "  " + rental)
        ListBox2.Items.Add("Deposit: $30.00")
        ListBox2.Items.Add(" ")
        ListBox2.Items.Add(" ")
        ListBox2.Items.Add("Total: $" + bill.ToString)


    End Sub

    Private Sub rentalRatesBtn_Click(sender As Object, e As EventArgs) Handles rentalRatesBtn.Click
        ListBox1.Visible = True
    End Sub
End Class