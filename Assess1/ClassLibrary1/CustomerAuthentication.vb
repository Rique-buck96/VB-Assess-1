' Developer:    Enrique Johannes Buck
' Date:         13/05/2014


'Customer class, that handles customer-level authentication.
Imports System.Data.SqlClient

Public Class CustomerAuthentication
    'Base Login Algorithm for Customer authentication.
    Private Function Login(ByVal userName As String, ByVal passWord As String) As Boolean

        Dim cm As New SqlCommand("SELECT ID FROM Login WHERE userName='" & userName &
                                 "' AND passWord ='" & passWord & "'", _Cn)
        Dim isLoggedIn

        _Cn.Open()
        isLoggedIn = cm.ExecuteScalar
        _Cn.Close()

        If isLoggedIn Then
            If _AccessLevel = "Customer" Or _AccessLevel = "Admin" Then
                Return True
            End If
        End If

        Return False
    End Function

    'Function that compares the order to quantity ratio.
    Private Function CompareQuantity(ByVal index As Integer, ByVal ordering As Integer) As Boolean

        Dim cm As New SqlCommand("SELECT prodQuanttity FROM products WHERE ID = " & index, _Cn)
        Dim productQuantity As Integer

        _Cn.Open()
        productQuantity = cm.ExecuteScalar
        _Cn.Close()

        If ordering <= productQuantity Then
            Return True
        Else
            Return False
        End If
    End Function

    'Function that collects the user index.
    '    Private Function GetUserIndex(ByVal userName As String, ByVal passWord As String) As Integer
    '
    '        Dim isLoggedIn = Login(_UserName, _PassWord)
    '
    '        If isLoggedIn Then
    '            Dim cm As New SqlCommand("SELECT ID FROM Login WHERE userName = '" & userName & "' AND pWord = '" & passWord & "'", _Cn)
    '        End If
    '        Return 0
    '    End Function

    'Function that gets the number of products the client has ordered.
    Public Function GetProductCount() As Integer

        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("SELECT COUNT(ID) FROM products", _Cn)
            Dim sum As Integer

            _Cn.Open()
            sum = cm.ExecuteScalar
            _Cn.Close()

            Return sum
        Else
            Return -1
        End If
    End Function

    'Function that gets the name of the product the client has ordered.
    Public Function GetProductName(ByVal index As Integer) As String

        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("SELECT prodyctName FROM products WHERE ID = " & index, _Cn)
            Dim strName As String

            _Cn.Open()
            strName = cm.ExecuteScalar
            _Cn.Close()

            Return strName
        End If

        Return ""
    End Function

    'Function that gets the description of the product, that the user has ordered.
    Public Function GetProductDescription(ByVal name As String) As String

        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("SELECT productDescription FROM products WHERE productName = '" & name & "'", _Cn)
            Dim strDescription As String

            _Cn.Open()
            strDescription = cm.ExecuteScalar
            _Cn.Close()

            Return strDescription
        End If

        Return ""
    End Function

    'Function that gets the price of the product that the user has ordered.
    Public Function GetProductPrice(ByVal name As String) As Decimal

        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("SELECT productPrice FROM products WHERE productName = '" & name & "'", _Cn)
            Dim price As Decimal

            _Cn.Open()
            price = cm.ExecuteScalar
            _Cn.Close()

            Return price
        End If

        Return 0.0
    End Function

    'Function that gets the quantity of the product that the user has ordered.
    Public Function GetProductQuantity(ByVal name As String) As Integer

        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("SELECT productQuantity FROM products WHERE productName = '" & name & "'", _Cn)
            Dim quantity As Integer

            _Cn.Open()
            quantity = cm.ExecuteScalar
            _Cn.Close()

            Return quantity
        End If
        Return 0
    End Function

    'Function that handles the ordering of the product, the client is requesting.
    Public Function OrderProduct(ByVal index As Integer, ByVal ordering As Integer, ByVal price As Decimal,
                                 ByVal productName As String) As String

        Dim isLoggedIn = Login(_UserName, _PassWord)
        Dim fullyStocked As Boolean = compareQuantity(index, _AccessLevel)

        If isLoggedIn Then
            If ordering < 1 Then
                Return "Please, place a valid order. You haven't ordered anything!"
            ElseIf fullyStocked Then
                Return "No stock left for this item."
            Else

                Dim _
                    cm As _
                        New SqlCommand(
                            "INSERT INTO ShoppingCart Values((SELECT ID FROM Login WHERE userName = '" & _UserName &
                            "' AND pWord = '" & _PassWord & "'), '" & productName & "', " & ordering & ", " & price &
                            ")", _Cn)

                _Cn.Open()
                cm.ExecuteScalar()
                _Cn.Close()

                cm =
                    New SqlCommand(
                        "UPDATE products SET productQuantity = (SELECT productQuantity FROM products WHERE ID = " &
                        index &
                        ") - " & ordering & "WHERE ID = " & index, _Cn)

                _Cn.Open()
                cm.ExecuteScalar()
                _Cn.Close()

                Return "Order has been placed!"

            End If
        End If

        Return "Hmm, there's been an issue logging in!"
    End Function
End Class
