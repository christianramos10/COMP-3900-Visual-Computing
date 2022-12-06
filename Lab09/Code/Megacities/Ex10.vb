Imports System.Configuration
Imports System.Data.OleDb

Public Class Ex10

    Private Sub displayBtn_Click(sender As Object, e As EventArgs) Handles displayBtn.Click
        megacitiesDataGridView.DataSource = GetMegacities()
    End Sub

    Private Function GetMegacities() As DataTable
        Dim megacitiesTable As New DataTable

        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString
        Using con As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT name, pop2010 FROM cities where pop2010>=13 and pop2010<=19 order by name", con)
                con.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                megacitiesTable.Load(reader)
            End Using
        End Using
        Return megacitiesTable
    End Function
End Class