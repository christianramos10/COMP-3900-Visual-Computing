Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class Microland
    Dim con As New SqlConnection("Data Source=DESKTOP-ETTN470;Initial Catalog=Microland;User ID=admin;Password=12345")
    Dim cmd As New SqlCommand()
    Dim adapter As New SqlDataAdapter()
    Dim dt As New DataTable()
    Dim dr As SqlDataReader
    Public Sub Microland_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub outOfStockBtn_Click(sender As Object, e As EventArgs) Handles outOfStockBtn.Click
        con.Open()

        Dim str1 As String = "Here are the items that are out of inventory or must be reordered."
        Dim str2 As String = "The numbers shown give the minimum reorder quantity required."

        Dim query As String = "select * from Inventory where quantity <= 5"
        cmd.Connection = con
        cmd.CommandText = query
        dr = cmd.ExecuteReader()

        ListBox1.Items.Add(str1)
        ListBox1.Items.Add(" ")
        ListBox1.Items.Add(str2)
        ListBox1.Items.Add(" ")

        Dim displayStr As String

        While (dr.Read())
            displayStr = dr("itemID") + " "

            Select Case dr("itemID")
                Case "SW101"
                    displayStr += Str(2) + " "
                Case "SW109"
                    displayStr += Str(0) + " "
                Case "SW934"
                    displayStr += Str(5) + " "
                Case "HW913"
                    displayStr += Str(5) + " "
                Case "PL208"
                    displayStr += Str(2) + " "
                Case Else
                    displayStr += Str(3) + " "
            End Select

            displayStr += dr("itemDescription")
            ListBox1.Items.Add(displayStr)
            displayStr = ""
        End While

        con.Close()

    End Sub

    Private Sub billBtn_Click(sender As Object, e As EventArgs) Handles billBtn.Click
        con.Open()
        cmd.Connection = con

        ' Select distinct ids from orders
        Dim query As String = "select distinct custID from Orders"
        cmd.CommandText = query
        dr = cmd.ExecuteReader

        ' Save each customer ids
        Dim ordersCustID As String = ""
        While (dr.Read())
            ordersCustID += Str(dr("custID")) + " "
        End While
        dr.Close()

        Dim custIdArr() As String
        custIdArr = ordersCustID.Split(" ")

        'Iterate by customer
        For Each cust As String In custIdArr
            If Not (cust = " " Or cust = "") Then
                'Get customer's information
                query = "select * from Customers where custID = '" + cust + "'"
                cmd.CommandText = query
                dr = cmd.ExecuteReader

                While (dr.Read())
                    ListBox1.Items.Add(dr("custName"))
                    ListBox1.Items.Add(dr("street"))
                    ListBox1.Items.Add(dr("city"))
                End While
                dr.Close()

                'Get number of orders from customer
                query = "select quantity from Orders where custID = '" + cust + "' order by itemID"
                cmd.CommandText = query
                dr = cmd.ExecuteReader
                Dim numOrders As Integer = 0
                While (dr.Read())
                    numOrders = numOrders + 1
                End While
                dr.Close()

                'Initialize arrays
                Dim itemLineQuantity(numOrders) As String
                Dim itemLineDesc As String
                Dim itemLinePrice As String

                'Add customer's item quantity
                query = "select quantity from Orders where custID = '" + cust + "' order by itemID"
                cmd.CommandText = query
                dr = cmd.ExecuteReader
                Dim index As Integer = 0
                While (dr.Read())
                    itemLineQuantity(index) = Str(dr("quantity"))
                    index = index + 1
                End While
                dr.Close()

                ListBox1.Items.Add(itemLineQuantity(0))


                'Add quantity, description and price to arrays, then print accordingly
                'Add quantity, description and price to arrays, then print accordingly



















                'Get item's information
                query = "select itemID from Orders where custID = '" + cust + "' order by itemID"
                cmd.CommandText = query
                dr = cmd.ExecuteReader
                Dim items As String = ""
                While (dr.Read())
                    items += dr("itemID") + " "
                End While
                dr.Close()

                Dim itemArr() As String
                Dim itemDescLine As String = ""
                Dim itemPriceLine As String = ""
                itemArr = items.Split(" ")

                For Each item As String In itemArr
                    query = "select * from Inventory where itemID = '" + item + "'"
                    cmd.CommandText = query
                    dr = cmd.ExecuteReader
                    While (dr.Read())
                        itemDescLine += dr("itemDescription") + " "
                        itemPriceLine += Str(dr("price")) + " "
                    End While
                    dr.Close()
                Next

                dr.Close()










            End If
        Next
        con.Close()
    End Sub


End Class