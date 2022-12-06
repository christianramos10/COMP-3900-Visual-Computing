Imports System.Configuration
Imports System.Data.OleDb

Public Class Ex14
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
            Using cmd As New OleDbCommand("select name, country from Cities", con)
                con.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                dt.Load(reader)
                con.Close()

            End Using
        End Using
        Dim citiesArr = dt.AsEnumerable.Select(Function(r) r.Field(Of String)(0)).ToArray
        Dim countryArr = dt.AsEnumerable.Select(Function(r) r.Field(Of String)(1)).ToArray
        For i As Integer = 0 To citiesArr.Length - 1
            listBox.Items.Add(citiesArr(i) & "," & countryArr(i))
        Next
        listBox.Items.Add("")
    End Function

    Private Sub listBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBox.SelectedIndexChanged
        Dim sel As String = listBox.SelectedItem.ToString

        Dim countryArr As String() = sel.Split(New Char() {","c})
        Dim country As String = ""
        For Each part As String In countryArr
            country = part
        Next

        Dim query As String = "select currency from Countries where name = India"

        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString
        Dim dt As New DataTable
        Using con As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("select currency from Countries where name = '" & country & "'", con)
                con.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                dt.Load(reader)
                con.Close()
            End Using
        End Using

        Dim moneyUnit = dt.AsEnumerable.Select(Function(r) r.Field(Of String)(0)).ToArray


        Dim currency As String = moneyUnit.ElementAt(0)
        MessageBox.Show("Currency: " & currency.ToString)
    End Sub
End Class