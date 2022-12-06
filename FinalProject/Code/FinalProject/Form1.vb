Imports System.Data
Imports System.Configuration
Imports System.Data.OleDb
Public Class Form1
    ' Declare global variables
    Structure OutOfStock
        Dim itemNumber As String
        Dim description As String
        Dim startQty As Integer
        Dim numOrdered As Integer
        Dim endQty As Integer
    End Structure
    Dim outOfStockArray() As OutOfStock
    Structure Customer
        Dim customerID As Integer
        Dim name As String
        Dim street As String
        Dim city As String
    End Structure
    Dim customerArray() As Customer
    Structure Order
        Dim customerID As Integer
        Dim qtyOrdered As Integer
        Dim description As String
        Dim pricePerItem As Double
        Dim totalPrice As Double
    End Structure
    Dim orderArray() As Order
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstOutput.Items.Clear()
    End Sub

    Private Sub btnStock_Click(sender As Object, e As EventArgs) Handles btnStock.Click
        DisplayStockIntroComments()
        CreateStockArr()
    End Sub

    Private Sub btnBills_Click(sender As Object, e As EventArgs) Handles btnBills.Click

    End Sub

    Private Function DisplayStockIntroComments()
        ' Display the first few lines of comments when the "Out of Stock" button is pressed
        lstOutput.Items.Clear()
        lstOutput.Items.Add("Here are the items that are out of")
        lstOutput.Items.Add("inventory or must be reordered.")
        lstOutput.Items.Add("")
        lstOutput.Items.Add("The numbers shown give the")
        lstOutput.Items.Add("minimum reorder quantity required.")
        lstOutput.Items.Add("")
    End Function

    Private Function CreateStockArr()
        Dim stockTable As New DataTable

        Dim connString As String = ConfigurationManager.ConnectionStrings("dbx").ConnectionString

        Dim query As String = "Select * from Inventory Where quantity <= 0"

        Using con As New OleDbConnection(connString)
            Using cmd As New OleDbCommand(query, con)
                con.Open()
                Try
                    Dim reader As OleDbDataReader = cmd.ExecuteReader()
                    stockTable.Load(reader)
                    DataGridView1.DataSource = stockTable

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using

        End Using
    End Function
End Class
