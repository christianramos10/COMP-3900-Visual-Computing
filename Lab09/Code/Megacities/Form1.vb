Imports System.Data.OleDb
Imports System.Configuration
Imports System.Data
Public Class Form1

    Private Sub displayBtn_Click(sender As Object, e As EventArgs) Handles displayBtn.Click
        megacitiesDataGridView.DataSource = GetMegacities()
    End Sub

    Private Function GetMegacities() As DataTable
        Dim megacitiesTable As New DataTable

        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString
        Using con As New OleDbConnection(connString)
            Using cmd As New OleDbCommand("SELECT name, country, (((pop2015-pop2010)/pop2010)*100) FROM cities", con)
                con.Open()
                Dim reader As OleDbDataReader = cmd.ExecuteReader()
                megacitiesTable.Load(reader)
            End Using
        End Using
        Return megacitiesTable
    End Function
End Class
