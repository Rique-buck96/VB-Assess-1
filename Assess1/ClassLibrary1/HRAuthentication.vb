Imports System.Data.SqlClient
Public Class HRAuthentication

    ''' <summary>
    ''' Handles HR level authentication.
    ''' </summary>
    ''' <param name="userName"></param>
    ''' <param name="passWord"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Login(ByVal userName As String, ByVal passWord As String) As Boolean

        Dim cm As New SqlCommand("SELECT uName FROM initLog WHERE uName ='" & userName & _
                                 "' AND pWord ='" & passWord & "'", _Cn)
        Dim isLoggedIn As String

        _Cn.Open()
        isLoggedIn = cm.ExecuteScalar
        _Cn.Close()

        If Not isLoggedIn = "" Then
            If _AccessLevel = "Admin" Or _AccessLevel = "HR" Then
                Return True
            End If
        Else
            Return False
        End If

        Return False
    End Function

    ''' <summary>
    ''' Returns the employees from the Conteso Database, to be displayed in a list.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ShowEmployees() As DataSet

        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then

            Dim dA As New SqlDataAdapter("SELECT empID ,FirstName AS [FIRST NAME] ," & _
                                         "LastName AS [LAST NAME] ," & _
                                         "DATEDIFF(yy,DOB,GETDATE()) AS AGE ," & _
                                         "Salary AS [SALARY] FROM dbo.Employees", _Cn)
            Dim dS As New DataSet

            dA.Fill(dS, "Employees")            '   Fill a dataSet of employees to show in the DatGrid 

            Return dS

        Else
            Return Nothing
        End If
    End Function
#Region "Get Set Methods"

    ''' <summary>
    ''' Gets the ID field from the Employees table.
    ''' </summary>
    ''' <param name="index"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetEmployeeID(ByVal index As Integer) As Integer

        Dim logged As Boolean = Login(_UserName, _PassWord)

        If logged Then
            Dim cm As New SqlCommand("SELECT empID FROM Employees WHERE empID = " & index, _Cn)
            Dim id As Integer
            _Cn.Open()
            id = cm.ExecuteScalar
            _Cn.Close()

            Return id
        End If
        Return -1
    End Function

    ''' <summary>
    ''' Gets the Employee's first name from the employees table.
    ''' </summary>
    ''' <param name="index"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetFirstName(ByVal index As Integer) As String

        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cm As New SqlCommand("SELECT FirstName FROM Employees WHERE empID = " & index, _Cn)
            Dim firstName As String

            _Cn.Open()
            firstName = cm.ExecuteScalar
            _Cn.Close()

            Return firstName
        Else
            Return ""
        End If

    End Function

    ''' <summary>
    ''' Gets the Employee's last name from the employees table.
    ''' </summary>
    ''' <param name="index"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetLastName(ByVal index As Integer) As String
        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then

            Dim cm As New SqlCommand("SELECT LastName FROM Employees WHERE empID = " & index, _Cn)
            Dim lastName As String

            _Cn.Open()
            lastName = cm.ExecuteScalar
            _Cn.Close()

            Return lastName
        Else
            Return ""
        End If
    End Function

    ''' <summary>
    ''' Gets the Employee's date of birth from the employees table.
    ''' </summary>
    ''' <param name="index"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetDOB(ByVal index As Integer) As DateTime
        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then

            Dim cM As New SqlCommand("SELECT DOB FROM Employees WHERE empID = " & index, _Cn)
            Dim dOb As DateTime

            _Cn.Open()
            dOb = cM.ExecuteScalar
            _Cn.Close()

            Return dOb
        End If

        Return Nothing
    End Function

    ''' <summary>
    ''' Gets the Employee's salary from the employees table.
    ''' </summary>
    ''' <param name="index"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetSalary(ByVal index As Integer) As Decimal

        Dim isLoggedIn = login(_userName, _password)

        If isLoggedIn Then
            Dim cm As New SqlCommand("SELECT Salary FROM Employees WHERE empID = " & index, _Cn)
            Dim salary As Decimal

            _Cn.Open()
            salary = cM.ExecuteScalar
            _Cn.Close()

            Return salary
        End If
        Return 0.0
    End Function

    ''' <summary>
    ''' Sets the Employee's first name.
    ''' </summary>
    ''' <param name="name"></param>
    ''' <param name="index"></param>
    ''' <remarks></remarks>
    Public Sub SetFirstName(ByVal name As String, ByVal index As Integer)

        Dim isLoggedIn = Login(_UserName, _PassWord)

        If (isLoggedIn) Then

            Dim cM As New SqlCommand("UPDATE Employees SET FirstName = '" & name & "' WHERE empID = " & index, _Cn)

            _Cn.Open()
            cM.ExecuteReader()
            _Cn.Close()

        End If
    End Sub

    ''' <summary>
    ''' Sets the Employees last name.
    ''' </summary>
    ''' <param name="name"></param>
    ''' <param name="index"></param>
    ''' <remarks></remarks>
    Public Sub SetLastName(ByVal name As String, ByVal index As Integer)
        Dim isLoggedIn = Login(_UserName, _PassWord)

        If (isLoggedIn) Then
            Dim cM As New SqlCommand("UPDATE Employees SET LastName = '" & name & "' WHERE empID = " & index, _Cn)

            _Cn.Open()
            cM.ExecuteReader()
            _Cn.Close()
        End If
    End Sub

    ''' <summary>
    ''' Sets the Employees date of birth.
    ''' </summary>
    ''' <param name="dOb"></param>
    ''' <param name="index"></param>
    ''' <remarks></remarks>
    Public Sub SetDOB(ByVal dOb As String, ByVal index As Integer)
        Dim isLoggedIn = Login(_UserName, _PassWord)

        If (isLoggedIn) Then
            Dim cM As New SqlCommand("UPDATE Employees SET DOB = CONVERT(DATETIME,'" & dOb & _
                                     "', 103) WHERE empID = " & index, _Cn)

            _Cn.Open()
            cM.ExecuteReader()
            _Cn.Close()
        End If
    End Sub

    ''' <summary>
    ''' Sets the Employees salary.
    ''' </summary>
    ''' <param name="sal"></param>
    ''' <param name="index"></param>
    ''' <remarks></remarks>
    Public Sub SetSalary(ByVal sal As Decimal, ByVal index As Integer)
        Dim isLoggedIn = Login(_UserName, _PassWord)

        If (isLoggedIn) Then
            Dim cm As New SqlCommand("UPDATE Employees SET Salary = " & sal & " WHERE empID = " & index, _Cn)

            _Cn.Open()
            cM.ExecuteReader()
            _Cn.Close()
        End If
    End Sub
#End Region

    ''' <summary>
    ''' Adds New users, with an employee access level.
    ''' </summary>
    ''' <param name="userName"></param>
    ''' <param name="passWord"></param>
    ''' <param name="firstNAme"></param>
    ''' <param name="lastName"></param>
    ''' <param name="dOb"></param>
    ''' <param name="salary"></param>
    ''' <param name="accessLevel"></param>
    ''' <remarks></remarks>
    Public Sub AddUserEmployee(ByVal userName As String, _
                              ByVal passWord As String, _
                              ByVal firstNAme As String, _
                              ByVal lastName As String, _
                              ByVal dOb As String, _
                              ByVal salary As Integer, _
                              ByVal accessLevel As String)

        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cM As New SqlCommand("INSERT INTO initLog VALUES('" & userName & "','" & passWord & "','" & accessLevel & _
                                     "', (SELECT MAX(ID) FROM initLog) + 1)", _Cn)

            _Cn.Open()
            cM.ExecuteReader()
            _Cn.Close()

            Dim index As Integer

            cM = New SqlCommand("SELECT MAX(ID) FROM initLog", _Cn)

            _Cn.Open()
            index = cM.ExecuteScalar
            _Cn.Close()

            AddEmployee(firstNAme, lastName, dOb, salary, index)

        End If

    End Sub

    ''' <summary>
    ''' Adds the new users with employee access level as Employees, to the Conteso database.
    ''' </summary>
    ''' <param name="firstName"></param>
    ''' <param name="lastName"></param>
    ''' <param name="dOb"></param>
    ''' <param name="salary"></param>
    ''' <param name="fKey"></param>
    ''' <remarks></remarks>
    Private Sub AddEmployee(ByVal firstName As String, _
                       ByVal lastName As String, _
                       ByVal dOb As String, _
                       ByVal salary As Integer, _
                       ByVal fKey As Integer)

        Dim isLoggedIn = Login(_UserName, _PassWord)

        If isLoggedIn Then
            Dim cM As New SqlCommand("INSERT INTO Employees VALUES( (SELECT MAX(empID) FROM Employees) + 1, '" _
                                               & firstName & "', '" & lastName & "', CONVERT(DATETIME,'" & dOb & _
                                               "', 103), " & fKey & ", " & salary & ")", _Cn)


            _Cn.Open()
            cM.ExecuteReader()
            _Cn.Close()
        End If

    End Sub

    ''' <summary>
    ''' Checks the username, and matches it with a unique username from the database.
    ''' </summary>
    ''' <param name="userName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CheckUserName(ByVal userName As String) As Integer

        Dim index As Integer

        Dim cM As New SqlCommand("SELECT ID FROM initLog WHERE uName = '" & userName & "'", _Cn)
        _Cn.Open()
        index = cM.ExecuteScalar
        _Cn.Close()

        Return index
    End Function

End Class
