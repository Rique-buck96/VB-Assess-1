'Developer: Enrique Johannes Buck
'Date:  4/06/2014
Imports System.Data.SqlClient

Public Class OrderHistory
    Private Function Login(ByVal userName, ByVal passWord)
        Dim cm As New SqlCommand("SELECT ID FROM initLog WHERE uName='" & userName &
                                 "' AND pWord ='" & passWord & "'", _Cn)

        Dim isLoggedIn

        _Cn.Open()
        isLoggedin = cM.ExecuteScalar
        _Cn.Close()

        If isLoggedIn Then
            If _AccessLevel = "admin" Or _AccessLevel = "Customer" Then
                Return True
            End If
        End If

        Return False
    End Function

    Public Function ShowDates() As List(Of String)

        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then

            Dim cm As New SqlCommand("SELECT orderDate FROM OrderHist WHERE custID = " &
                                     "(SELECT ID FROM initLog WHERE uName ='" & _UserName &
                                     "' AND pWord = '" & _PassWord & "')", _Cn)
            Dim strDates As New List(Of String)

            _Cn.Open()
            Dim reader As SqlDataReader = cM.ExecuteReader

            Do While reader.Read
                strDates.Add(reader.GetValue(0))
            Loop

            _Cn.Close()

            Return strDates
        End If

        Return Nothing
    End Function

    Public Function ShowOrderID() As List(Of Integer)
        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("SELECT orderID FROM OrderHist WHERE custID = " &
                                     "(SELECT ID FROM initLog WHERE uName ='" & _UserName &
                                     "' AND pWord = '" & _PassWord & "')", _Cn)
            Dim strIDs As New List(Of Integer)

            _Cn.Open()

            Dim reader As SqlDataReader = cM.ExecuteReader

            Do While reader.Read
                strIDs.Add(reader.GetValue(0))
            Loop

            _Cn.Close()

            Return strIDs
        Else
            Return Nothing
        End If
    End Function

    Public Function ShowProductInfo(ByVal orderCount As Integer) As List(Of String)

        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("SELECT prodName, prodQuan, prodPrice FROM OrderCartHist WHERE orderID = " & orderCount, _Cn)
            Dim productInfo As New List(Of String)

            _Cn.Open()

            Dim reader As SqlDataReader = cm.ExecuteReader

            Do While reader.Read
                productInfo.Add(
                    reader.GetString(0) & "  [ " & reader.GetInt32(1) & " ]  " & FormatCurrency(reader.GetDecimal(2)))
            Loop

            _Cn.Close()

            Return productInfo

        End If

        Return Nothing
    End Function
End Class
