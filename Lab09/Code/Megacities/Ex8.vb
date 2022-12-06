Imports System.Configuration
Imports System.Data.OleDb

Public Class Ex8
    Private Sub displayBtn_Click(sender As Object, e As EventArgs) Handles displayBtn.Click
        displayComments()
        displayCountries()
    End Sub

    Private Function displayComments()
        listBox.Items.Clear()
        listBox.Items.Add("Countries from Countries Table:")
    End Function

    Private Function displayCountries()
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString
        Dim dt As New DataTable
        Using con As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("select name from Countries", con)
                con.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                dt.Load(reader)
                con.Close()

            End Using
        End Using
        Dim countriesArr = dt.AsEnumerable.Select(Function(r) r.Field(Of String)(0)).ToArray

        For Each str As String In countriesArr
            listBox.Items.Add(str)
        Next
        listBox.Items.Add("")
    End Function

    Private Sub listBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBox.SelectedIndexChanged
        Dim ctr As String = listBox.SelectedItem.ToString

        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString
        Dim dt As New DataTable
        Using con As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("select name from Cities where country = '" & ctr & "'", con)
                con.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                dt.Load(reader)
                con.Close()
            End Using
        End Using

        Dim citiesArr = dt.AsEnumerable.Select(Function(r) r.Field(Of String)(0)).ToArray

        Dim cities As String = ""
        For Each str As String In citiesArr
            cities += str & " "
        Next
        listBox.Items.Add("")
        MessageBox.Show("Cities: " & cities)




    End Sub




End Class