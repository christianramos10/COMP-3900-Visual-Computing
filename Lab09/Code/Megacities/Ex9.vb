Imports System.Configuration
Imports System.Data.OleDb

Public Class Ex9
    Private Sub displayBtn_Click(sender As Object, e As EventArgs) Handles displayBtn.Click
        displayComments()
        displayCountries()
    End Sub

    Private Function displayComments()
        listBox.Items.Clear()
        listBox.Items.Add("Cities from Cities Table:")
    End Function

    Private Function displayCountries()
        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString
        Dim dt As New DataTable
        Using con As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("select name, pop2015 from Cities where pop2015>=20 order by pop2015 desc", con)
                con.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                dt.Load(reader)
                con.Close()
            End Using
        End Using
        Dim countriesArr = dt.AsEnumerable.Select(Function(r) r.Field(Of String)(0)).ToArray
        Dim populationArr = dt.AsEnumerable.Select(Function(r) r.Field(Of Double)(1)).ToArray
        For i As Integer = 0 To countriesArr.Length - 1
            listBox.Items.Add(countriesArr(i) & ", population: " & populationArr(i))
        Next
        listBox.Items.Add("")
    End Function
End Class