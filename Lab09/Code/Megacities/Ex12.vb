Imports System.Configuration
Imports System.Data.OleDb
Public Class Ex12
    Private Sub displayBtn_Click(sender As Object, e As EventArgs) Handles displayBtn.Click
        megacitiesDataGridView.DataSource = GetMegacities()
    End Sub

    Private Function GetMegacities() As DataTable
        Dim megacitiesTable As New DataTable

        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString
        Using con As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("select Cities.name, Cities.country, (Cities.pop2010/Countries.pop2010)*100 from Cities inner join Countries on Cities.country = Countries.name", con)
                con.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                megacitiesTable.Load(reader)
            End Using
        End Using
        Return megacitiesTable
    End Function
End Class