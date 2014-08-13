' Developer:    Enrique Johannes Buck
' Date:         16/3/2014
Imports System.Data.SqlClient

'Login class which handles how each user will be able to login to our database. 
Public Class LoginHandling
    Private ReadOnly _initCn As New SqlConnection("data source = (local)\ASSESS1; initial catalog =Conteso; UserID = trainee; password = guest1;")

    ''' <summary>
    ''' Proprietry login algorithm, which differentiates the access level given to each client.
    ''' </summary>
    ''' <param name="userName"></param>
    ''' <param name="password"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function LoginProcess(ByVal userName As String, ByVal password As String) As String

        Dim cm As New SqlCommand("SELECT accessLvl FROM Login WHERE Username = '" & userName & "' AND Password = '" & password & "';", _initCn)

        _initCn.Open()
        _AccessLevel = cm.ExecuteScalar
        _initCn.Close()

        Select Case _AccessLevel
            Case "Customer"
                _Cn = New SqlConnection("data source=(local)\ASSESS1; initial catalog=Conteso; UserID = userCustomer; password=guest;")
                _UserName = userName
                _PassWord = password
                Return _AccessLevel

            Case "HR"
                _Cn = New SqlConnection("data source=(local)\ASSESS1; initial catalog=Conteso; UserID = HR; password=guest;")
                _UserName = userName
                _PassWord = password
                Return _AccessLevel

            Case "Sales"
                _Cn = New SqlConnection("data source=(local)\ASSESS1; initial catalog=Conteso; UserID = Sales; password=guest;")
                _UserName = userName
                _PassWord = password
                Return _AccessLevel

            Case "Admin"
                _Cn = New SqlConnection("data source=(local)\ASSESS1; initial catalog=Conteso; UserID = admin; password=guest;")
                _UserName = userName
                _PassWord = password
                Return _AccessLevel

            Case Else
                Return Nothing

        End Select
    End Function
End Class
