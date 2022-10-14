Public Class PushMe
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        btn1.Visible = False
        btn2.Visible = True
        btn3.Visible = True
        btn4.Visible = True
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        btn2.Visible = False
        btn1.Visible = True
        btn3.Visible = True
        btn4.Visible = True
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        btn3.Visible = False
        btn2.Visible = True
        btn1.Visible = True
        btn4.Visible = True
    End Sub


    Private Sub btn_Refresh_Click(sender As Object, e As EventArgs) Handles btn_Refresh.Click
        btn1.Visible = True
        btn2.Visible = True
        btn3.Visible = True
        btn4.Visible = True
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        btn4.Visible = False
        btn2.Visible = True
        btn3.Visible = True
        btn1.Visible = True
    End Sub
End Class