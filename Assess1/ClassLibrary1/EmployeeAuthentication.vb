' Developer:    Enrique Johannes Buck
' Date:         13/05/2014

Imports System.Data.SqlClient
Imports System.Security.Cryptography

''' <summary>
''' Employee class, that handles employee-level authentication.
''' </summary>
''' <remarks></remarks>
Public Class EmployeeAuthentication

    ''' <summary>
    ''' Handles Employee-level authentication.
    ''' </summary>
    ''' <param name="userName"></param>
    ''' <param name="passWord"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Login(ByVal userName As String, ByVal passWord As String) As Boolean

        Dim cm As New SqlCommand("SELECT userName FROM Login WHERE userName = '" & userName & _
                                 "' AND passWord = '" & passWord & "'", _Cn)
        Dim isLoggedIn As String = ""

        _Cn.Open()
        cm.ExecuteScalar()
        _Cn.Close()

        If Not isLoggedIn = "" And (_AccessLevel = "Sales" And _AccessLevel = "Admin") Then
            Return True
        Else
            Return False
        End If

    End Function

    ''' <summary>
    ''' Function that collects product data and displays it to the client.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ShowProducts() As DataSet

        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim da As New SqlDataAdapter("SELECT productName AS NAME, productDesc AS DESCRIPTION, productQuantity AS QUANTITY," & _
                                                   "productPrice AS PRICE, productQuantity * productPrice AS [TOTAL PRICE] FROM Products ORDER BY propductName", _Cn)
            Dim ds As New DataSet

            da.Fill(ds, "Products")

            Return ds
        End If
        Return Nothing
    End Function

    ''' <summary>
    ''' Function that collects customer data and displays it to the client.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ShowCustomers() As DataSet

        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim da As New SqlDataAdapter("SELECT customers.firstName AS [FIRST NAME], customers.lastName AS [LAST NAME]," & _
                                         "customers.StreetAddress AS [STREET ADDRESS], customers.PostCode AS [POST CODE], " & _
                                         "address.state AS [STATE] FROM customers LEFT JOIN Address ON customers.PostCode = Address.PostCode", _Cn)
            Dim ds As New DataSet

            da.Fill(ds, "Customers")

            Return ds
        End If
        Return Nothing
    End Function

#Region "Product Get Set Methods"

    ''' <summary>
    ''' Function that gets the product name and displays it to the client, if it has been chosen by the client.
    ''' </summary>
    ''' <param name="index"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetProductName(ByVal index As Integer) As String

        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("SELECT prouductName FROM Products WHERE ID = " & index, _Cn)
            Dim productName As String

            _Cn.Open()
            productName = cm.ExecuteScalar
            _Cn.Close()

            If Not productName = "" Then
                Return productName
            Else
                Return "No product has been chosen."
            End If
        End If
        Return "No product has been chosen."
    End Function

    ''' <summary>
    ''' Function that gets the product description and displays it to the client, if it has been chosen by the client.
    ''' </summary>
    ''' <param name="index"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetProductDescription(ByVal index As Integer) As String

        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("SELECT productDescription FROM Products WHERE ID = " & index, _Cn)
            Dim productDescription As String

            _Cn.Open()
            productDescription = cm.ExecuteScalar
            _Cn.Close()

            Return productDescription
        End If
        Return ""
    End Function

    ''' <summary>
    ''' Function that gets the product quantity and displays it to the client, if it has been chosen by the client.
    ''' </summary>
    ''' <param name="index"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetProductQuantity(ByVal index As Integer) As Integer

        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("SELECT productQuantity FROM Products WHERE ID = " & index, _Cn)
            Dim quantity As Integer

            _Cn.Open()
            quantity = cm.ExecuteScalar
            _Cn.Close()

            Return quantity
        End If
        Return 0
    End Function

    ''' <summary>
    ''' Function that gets the product price and displays it to the client, if it has been chosen by the client.
    ''' </summary>
    ''' <param name="index"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetProductPrice(ByVal index As Integer) As Decimal

        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("SELECT productPrice FROM Products WHERE ID = " & index, _Cn)
            Dim price As Decimal

            _Cn.Open()
            price = cm.ExecuteScalar
            _Cn.Close()

            Return price
        End If
        Return 0.0
    End Function

#End Region

#Region "Customer Get Set Methods"

    Public Function GetCustomerFirstName(ByVal index As Integer) As String

        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("SELECT firstName FROM customers WHERE custID = " & index, _Cn)
            Dim firstName = ""

            _Cn.Open()
            firstName = cm.ExecuteScalar()
            _Cn.Close()

            If Not firstName = "" Then
                Return firstName
            End If
        End If

        Return "No Customer"
    End Function

    Public Function GetCustomerLastName(ByVal index As Integer) As String

        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("SELECT lastName FROM customers WHERE custID = " & index, _Cn)
            Dim lastName = ""

            _Cn.Open()
            lastName = cm.ExecuteScalar()
            _Cn.Close()

            If Not lastName = "" Then
                Return lastName
            End If
        End If

        Return ""
    End Function

    Public Function GetStreetAddress(ByVal index As Integer) As String

        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("SELECT StreetAddress FROM customers WHERE custID = " & index, _Cn)
            Dim street = ""

            _Cn.Open()
            street = cm.ExecuteScalar()
            _Cn.Close()

            Return street
        End If

        Return ""

    End Function

    Public Function GetPostCode(ByVal index As Integer) As Integer
        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("SELECT PostCode FROM customers WHERE custID = " & index, _Cn)
            Dim postcode = 0

            _Cn.Open()
            postcode = cm.ExecuteScalar()
            _Cn.Close()

            Return postcode
        End If

        Return 0
    End Function

    Public Function GetState(ByVal index As Integer) As String
        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("SELECT State FROM Address WHERE PostCode = " & _
                                     "(SELECT PostCode FROM Customers WHERE custID =" & index & ")", _Cn)
            Dim state = ""

            _Cn.Open()
            state = cm.ExecuteScalar()
            _Cn.Close()

            Return state
        End If

        Return ""
    End Function

#End Region

#Region "Product Edit Methods"

    Public Sub EditProductName(ByVal index As Integer, ByVal productName As String)

        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("UPDATE products SET productName = '" & productName & _
                                     "' WHERE ID = '" & index, _Cn)

            _Cn.Open()
            cm.ExecuteScalar()
            _Cn.Close()

        End If
    End Sub

    Public Sub EditProductDescription(ByVal index As Integer, ByVal productDescription As String)
        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("UPDATE products SET productDescription = '" & productDescription & _
                                             "WHERE ID =" & index, _Cn)

            _Cn.Open()
            cm.ExecuteScalar()
            _Cn.Close()
        End If
    End Sub

    Public Sub EditProductQuantity(ByVal index As Integer, ByVal productQuantity As Integer)

        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("UPDATE products SET productQuantity = " & productQuantity & _
                                     "WHERE ID = " & index, _Cn)

            _Cn.Open()
            cm.ExecuteScalar()
            _Cn.Close()

        End If
    End Sub

    Public Sub EditProductPrice(ByVal index As Integer, ByVal productPrice As Decimal)
        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("UPDATE products SET productPrice = " & productPrice & _
                                     "WHERE ID = " & index, _Cn)

            _Cn.Open()
            cm.ExecuteScalar()
            _Cn.Close()

        End If
    End Sub
#End Region

#Region "Customer Edit Methods"

    Public Sub EditFirstName(ByVal index As Integer, ByVal name As String)
        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("UPDATE customers SET firstName = '" & name & _
                                     "' WHERE custID = " & index, _Cn)

            _Cn.Open()
            cm.ExecuteScalar()
            _Cn.Close()

        End If
    End Sub

    Public Sub EditLastName(ByVal index As Integer, ByVal name As String)
        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("UPDATE customers SET lastName = '" & name & _
                                     "' WHERE custID = '" & index, _Cn)

            _Cn.Open()
            cm.ExecuteScalar()
            _Cn.Close()

        End If
    End Sub

    Public Sub EditStreet(ByVal index As Integer, ByVal street As String)
        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("UPDATE customers SET streetAddress = '" & street & _
                                     "' WHERE custID = " & index, _Cn)

            _Cn.Open()
            cm.ExecuteScalar()
            _Cn.Close()

        End If
    End Sub

    Public Sub EditStatePostCode(ByVal index As Integer, ByVal postcode As Integer,
                                 ByVal state As String)
        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim checkedPostCode = CheckPostCode(postcode)

            If checkedPostCode Then
                UpdatePostCode(postcode, index)
            Else
                AddStatePostCode(postcode, state)
                UpdatePostCode(postcode, index)
            End If
        End If
    End Sub

    Private Sub UpdatePostCode(ByVal postcode As Integer, ByVal index As Integer)
        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("UPDATE Customers SET PostCode = " & postcode & _
                                     " WHERE custID = " & index, _Cn)

            _Cn.Open()
            cm.ExecuteScalar()
            _Cn.Close()

        End If
    End Sub

    Public Function CheckPostCode(ByVal postcode As Integer) As Boolean
        Dim cm As New SqlCommand("SELECT PostCode FROM Address WHERE PostCode = " & postcode, _Cn)
        Dim checker = 0

        _Cn.Open()
        checker = cm.ExecuteScalar
        _Cn.Close()

        If checker > 0 Then
            Return True
        End If

        Return False
    End Function

    Public Function CheckState(ByVal postcode As Integer, ByVal state As String) As Boolean
        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("SELECT State FROM Address WHERE PostCode = " & postcode, _Cn)
            Dim checker = ""

            _Cn.Open()
            checker = cm.ExecuteScalar
            _Cn.Close()

            If checker = state Then
                Return True
            End If
        End If

        Return False
    End Function

    Public Sub AddStatePostCode(ByVal postcode As Integer, ByVal state As String)
        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("INSERT INTO Address VALUES (" & postcode & ", '" & state & _
                                     "')", _Cn)

            _Cn.Open()
            cm.ExecuteReader()
            _Cn.Close()

        End If
    End Sub
#End Region

#Region "Database Adding Methods"

    Public Sub AddProduct(ByVal productName As String, _
                          ByVal productDescription As String, _
                          ByVal productPrice As Decimal, _
                          ByVal productQuantity As Integer)

        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("INSERT INTO Products VALUES ((SELECT MAX(ID) FROM Products) + 1, '" _
                                     & productName & "', '" & productDescription & "', " & productQuantity & _
                                     "," & productPrice & ")", _Cn)

            _Cn.Open()
            cm.ExecuteReader()
            _Cn.Close()

        End If
    End Sub

    Public Sub AddCustomer(ByVal firstName As String, _
                           ByVal lastName As String, _
                           ByVal street As String, _
                           ByVal postcode As Integer, _
                           ByVal state As String, _
                           ByVal userName As String, _
                           ByVal password As String)

        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim checkedPostCode = CheckPostCode(postcode)

            If Not checkedPostCode Then
                AddStatePostCode(postcode, state)
            End If

            Dim cm As New SqlCommand("INSERT INTO initLog VALUES ('" & userName & "','" & password & _
                                     "','Customer', (SELECT MAX(ID) FROM initLog) + 1)", _Cn)

            _Cn.Open()
            cm.ExecuteReader()
            _Cn.Close()

            Dim index = -1

            cm = New SqlCommand("SELECT MAX(ID) FROM initLog", _Cn)

            _Cn.Open()
            index = cm.ExecuteScalar
            _Cn.Close()

            cm = New SqlCommand("INSERT INTO Customers VALUES ((SELECT MAX(custID) FROM Customers) + 1, '" _
                                & firstName & "','" & lastName & "','" & street & "'," & postcode & ", " & index & _
                                ")", _Cn)

            _Cn.Open()
            cm.ExecuteReader()
            _Cn.Close()

        End If
    End Sub
#End Region

    Public Function CheckCustomerUser(ByVal userName As String) As Boolean
        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("SELECT userName FROM initLog WHERE userName = '" & userName & "'", _Cn)
            Dim userLoggedIn = ""

            _Cn.Open()
            userLoggedIn = cm.ExecuteScalar
            _Cn.Close()

            If Not userLoggedIn = "" Then
                Return True
            Else
                Return False
            End If
        End If

        Return False
    End Function

    Public Function CheckCustomerID(ByVal index As Integer) As Boolean
        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("SELECT custID FROM customers WHERE custID = " & index, _Cn)
            Dim id = 0

            _Cn.Open()
            id = cm.ExecuteScalar
            _Cn.Close()

            If id > 0 Then
                Return True
            End If
        End If
        Return False
    End Function

    Public Function CheckProductID(ByVal index As Integer) As Boolean
        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("SELECT ID FROM products WHERE ID = " & index, _Cn)
            Dim id = 0

            _Cn.Open()
            id = cm.ExecuteScalar
            _Cn.Close()

            If id > 0 Then
                Return True
            End If
        End If
        Return False
    End Function
End Class
