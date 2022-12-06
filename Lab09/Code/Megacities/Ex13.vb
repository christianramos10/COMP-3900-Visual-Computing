Imports System.Configuration
Imports System.Data.OleDb

Public Class Ex13
    Private Sub displayBtn_Click(sender As Object, e As EventArgs) Handles displayBtn.Click
        displayComments()
        displayCities()
    End Sub

    Private Function displayComments()
        listBox.Items.Clear()
        listBox.Items.Add("Cities from Cities Table:")
    End Function

    Private Function displayCities()
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString
        Dim dt As New DataTable
        Using con As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("select name from Cities", con)
                con.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                dt.Load(reader)
                con.Close()

            End Using
        End Using
        Dim citiesArr = dt.AsEnumerable.Select(Function(r) r.Field(Of String)(0)).ToArray

        For Each str As String In citiesArr
            listBox.Items.Add(str)
        Next
        listBox.Items.Add("")
    End Function

    Private Sub listBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBox.SelectedIndexChanged
        Dim city As String = listBox.SelectedItem.ToString

        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString
        Dim dt As New DataTable
        Using con As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("select pop2010 from Cities where name = '" & city & "'", con)
                con.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                dt.Load(reader)
                con.Close()
            End Using
        End Using

        Dim popArr = dt.AsEnumerable.Select(Function(r) r.Field(Of Double)(0)).ToArray

        Dim cities As String = ""
        For Each str As String In popArr
            cities += str & " "
        Next
        listBox.Items.Add("")
        MessageBox.Show("Population: " & cities)
    End Sub

End Class