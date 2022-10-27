Public Class Menu

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        burgersGroupBox.Visible = False
        friesGroupBox.Visible = False
        drinksGroupBox.Visible = False
    End Sub

    Private Sub burgersCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles burgersCheckBox.CheckedChanged
        If burgersCheckBox.Checked Then
            burgersGroupBox.Visible = True
        Else
            burgersGroupBox.Visible = False
        End If
    End Sub

    Private Sub friesCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles friesCheckBox.CheckedChanged
        If friesCheckBox.Checked Then
            friesGroupBox.Visible = True
        Else
            friesGroupBox.Visible = False
        End If
    End Sub

    Private Sub drinksCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles drinksCheckBox.CheckedChanged
        If drinksCheckBox.Checked Then
            drinksGroupBox.Visible = True
        Else
            drinksGroupBox.Visible = False
        End If
    End Sub

    Private Sub computeBtn_Click(sender As Object, e As EventArgs) Handles computeBtn.Click
        Dim price As Double
        price = 0
        totalBox.Text = ""


        If burgersCheckBox.Checked Then
            If regularBtn.Checked Then
                price = price + 4.19
            ElseIf (wCheeseBtn.Checked Or wBaconBtn.Checked) Then
                price = price + 4.79
            ElseIf wBaconAndCheeseBtn.Checked Then
                price = price + 5.39
            End If
        End If
        If friesCheckBox.Checked Then
            If smallBtn.Checked Then
                price = price + 2.39
            ElseIf (mediumBtn.Checked) Then
                price = price + 3.09
            ElseIf largeBtn.Checked Then
                price = price + 4.99
            End If
        End If
        If drinksCheckBox.Checked Then
            If sodaBtn.Checked Then
                price = price + 1.69
            ElseIf (waterBtn.Checked) Then
                price = price + 1.49
            End If
        End If

        totalBox.Text = "$" + price.ToString
    End Sub

End Class