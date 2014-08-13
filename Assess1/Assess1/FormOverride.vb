Imports Assess1.Edit
Module FormOverride
    Private _isLoggedOut = False
    Private _accessLevel = ""

    ''' <summary>
    ''' Presents the ProductEdit form.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub OpenEditProduct()
        ProductEdit.Show()
    End Sub

    ''' <summary>
    ''' Closes the ProductEdit form.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CloseEditProduct()
        ProductEdit.Close()
    End Sub

    ''' <summary>
    ''' Opens the CustomerEdit form.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub OpenEditCustomer()
        CustomerEdit.Show()
    End Sub

    ''' <summary>
    ''' Closes the CustomerEdit form.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CloseEditCustomer()
        CustomerEdit.Close()
    End Sub
    ''' <summary>
    ''' Presents the Login form, if a HR-level employee has logged out.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub LogoutAsHR()
        _isLoggedOut = True
        HRForm.Close()

        If _accessLevel = "admin" Then
            Menu.Show()
            _isLoggedOut = False
        Else
            Login.Show()
        End If
    End Sub

    ''' <summary>
    ''' Presents the HR form, if employee is HR-level.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub LoginAsHR()
        If _accessLevel = "admin" Then
            Menu.Hide()
        Else
            Login.Hide()
        End If

        HRForm.Show()
        _isLoggedOut = False
    End Sub

    ''' <summary>
    ''' Closes Login Form once authenticated.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub CloseLoginForm()
        If Not _isLoggedOut Then
            Login.Close()
        End If
    End Sub

    ''' <summary>
    ''' Presents the Login form, if a sales-level employee has logged out.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub LogoutAsSales()
        _isLoggedOut = True
        EmployeeForm.Close()

        If _accessLevel = "admin" Then
            Menu.Show()
            _isLoggedOut = False
        Else
            Login.Show()
        End If
    End Sub

    ''' <summary>
    ''' Presents the Employee form, if a sales-level employee has logged in.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub LoginAsSales()
        If _accessLevel = "admin" Then
            Menu.Hide()
        Else
            Login.Hide()
        End If

        EmployeeForm.Show()
        _isLoggedOut = False
    End Sub

    ''' <summary>
    ''' Presents the Customer form, if a customer has authenticated.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub LogInAsCustomer()
        If _accessLevel = "admin" Then
            Menu.Hide()
        Else
            Login.Hide()
        End If
        CheckOutForm.Show()
        _isLoggedOut = False
    End Sub

    ''' <summary>
    ''' Presents the login form, if a customer has logged out.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub LogOutAsCustomer()
        _isLoggedOut = True
        CheckOutForm.Close()

        If _accessLevel = "admin" Then
            Menu.Show()
            _isLoggedOut = False
        Else
            Login.Show()
        End If

    End Sub

    ''' <summary>
    ''' Admin login.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub LoginAsAdmin()
        Login.Hide()
        Menu.Show()
        _isLoggedOut = False
    End Sub

    ''' <summary>
    ''' Admin logout function.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub LogoutAsAdmin()
        _isLoggedOut = True
        Menu.Close()
        Login.Show()
    End Sub

    ''' <summary>
    ''' Verifies the access level of an employee, and presents a form suited to their access level.
    ''' </summary>
    ''' <param name="accessLevel"></param>
    ''' <remarks></remarks>
    Public Sub AccessLevelVerification(ByVal accessLevel As String)

        Select Case (accessLevel)
            Case "HR"
                LoginAsHR()
            Case "Sales"
                LoginAsSales()
            Case "Customer"
                LogInAsCustomer()
            Case "admin"
                LoginAsAdmin()
        End Select
        _accessLevel = accessLevel
    End Sub

    ''' <summary>
    ''' Presents the Checkout form.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub OpenCheckout()
        CheckOutForm.Hide()
        customerForm.Show()
    End Sub

    ''' <summary>
    ''' Presents the Order History of a customer.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub OpenOrderHistory()
        customerForm.Close()
        HistoryForm.Show()
    End Sub

    ''' <summary>
    ''' If a customer has finished ordering, they will be presented the Customer form.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub EndCheckoutSession()
        customerForm.Close()
        CheckOutForm.Show()
    End Sub

    ''' <summary>
    ''' Presents the Customer form, if a customer wishes to exit the checkout form.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ExitCheckout()
        CheckOutForm.Show()
    End Sub

    ''' <summary>
    ''' Presents the Customer form, if a customer wishes to exit the order history form.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ExitHistory()
        CheckOutForm.Show()
    End Sub
End Module
