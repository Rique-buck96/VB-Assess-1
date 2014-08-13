' Developer:    Enrique Johannes Buck
' Date:         13/05/2014
Imports System.Data.SqlClient

'Checkout class, that a client can use to buy our products, from our database.
Public Class Checkout

    'Login function for customers and admins.
    Private Function Login(ByVal userName As String, ByVal passWord As String) As Boolean
        Dim cm As New SqlCommand("SELECT ID FROM Login WHERE userName='" & userName & _
                                 "'AND passWord ='" & passWord & "'", _Cn)

        Dim isLoggedIn

        _Cn.Open()
        isLoggedIn = cm.ExecuteScalar
        _Cn.Close()

        If isLoggedIn Then
            If _AccessLevel = "admin" Or _AccessLevel = "Customer" Then
                Return True
            End If
        End If

        Return False
    End Function

    'Function that calculates how many orders from each client has been requested.
    Public Function CalculateOrderNumber() As Integer
        Dim isLoggedIn = Login(_userName, _passWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("SELECT COUNT (custId) FROM products WHERE custID = (SELECT ID FROM customers WHERE userName='" & _userName & _
                                     "' AND passWord ='" & _passWord & "')", _Cn)
            Dim sum As Integer

            _Cn.Open()
            sum = cm.ExecuteScalar
            _Cn.Close()

            Return sum
        Else
            Return -1
        End If
    End Function

    'Function that calls the Product name. 
    Public Function GetProductName() As List(Of String)
        Dim isLoggedIn = Login(_userName, _passWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("SELECT ProductName FROM shoppingCart WHERE custId = (SELECT ID FROM Login WHERE userName = '" & _userName & _
                                     "' AND passWord = '" & _passWord & "')", _Cn)
            Dim strName As New List(Of String)
            _Cn.Open()
            Dim reader As SqlDataReader = cm.ExecuteReader

            Do While reader.Read
                strName.Add(reader.GetString(0))
            Loop
            _Cn.Close()
            Return strName
        End If
        Return Nothing
    End Function

    'Function that calculates the quantity and the price of the product, and returns the price of all of their orders.
    Public Function GetProductSumTotal() As List(Of Decimal)

        Dim isLoggedIn = Login(_userName, _passWord)

        If isLoggedIn Then

            Dim cm As New SqlCommand("SELECT productPrice * productQuantity FROM shoppingCart WHERE custID = (SELECT ID FROM Login WHERE userName ='" & _userName & _
                                     "' AND passWord = '" & _passWord & "')", _Cn)
            Dim priceList As New List(Of Decimal)

            _Cn.Open()
            Dim reader As SqlDataReader = cm.ExecuteReader

            Do While reader.Read
                priceList.Add(reader.GetDecimal(0))
            Loop

            _Cn.Close()
            Return priceList
        End If
        Return Nothing
    End Function

    'Confirm that everything the client has ordered is now finalised. 
    Public Sub ConfirmOrder()

        Dim isLoggedIn = Login(_userName, _passWord)

        If isLoggedIn Then

            Dim cm As New SqlCommand("INSERT INTO orderList VALUES((SELECT MAX (orderID) FROM orderList) + 1, (SELECT ID FROM Login WHERE userName ='" & _userName & _
                                     "' AND passWord = '" & _passWord & "'), GETDATE()", _Cn)

            _Cn.Open()
            cm.ExecuteNonQuery()
            _Cn.Close()

            cm = New SqlCommand("UPDATE ShoppingCartList SET orderID = (SELECT MAX(orderID) FROM orderHist) WHERE orderID is NULL", _Cn)

            _Cn.Open()
            cm.ExecuteNonQuery()
            _Cn.Close()

            cm = New SqlCommand("DELETE FROM ShoppingCart WHERE custID = (SELECT ID FROM Login WHERE userName = '" & _userName & "' AND passWord = '" & _passWord & "');", _Cn)

            _Cn.Open()
            cm.ExecuteNonQuery()
            _Cn.Close()

        End If
    End Sub
End Class
