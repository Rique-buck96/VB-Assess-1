Imports ContesoLibrary

Public Class EmployeeForm
    Public SalesClass As New EmployeeAuthentication
    Public IsAdding = False
    Public ProductIndex = 0
    Public CustomerIndex = 0


    ''' <summary>
    '''     Makes the Product panel visible, for the user to edit, search or add products.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ProductButton_Click(sender As Object, e As EventArgs) Handles ProductButton.Click

        ProductButton.Visible = False
        CustomerButton.Visible = True

        ProductsLabel.Visible = True

        ProductPropertyPanel.Visible = True
        ProductIDPanel.Visible = True

        ProductIDTextBox.Clear()

        CustomerPropertyPanel.Visible = False
        CustomerIDPanel.Visible = False

        Dim tDS = SalesClass.ShowProducts()

        ProductCustomerData.DataSource = tDS
        ProductCustomerData.DataMember = "Products"
    End Sub

    
    ''' <summary>
    '''     Makes the Customer panel visible, for the user to edit, search or add customer information.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CustomerButton_Click(sender As Object, e As EventArgs) Handles CustomerButton.Click

        CustomerButton.Visible = False
        ProductButton.Visible = True

        CustomerPropertyPanel.Visible = True
        CustomerIDPanel.Visible = True

        CustomersLabel.Visible = True

        CustomerIDTextBox.Clear()

        ProductPropertyPanel.Visible = False
        ProductIDPanel.Visible = False

        Dim tDS = SalesClass.ShowCustomers()

        ProductCustomerData.DataSource = tDS
        ProductCustomerData.DataMember = "Customers"
    End Sub

    
    ''' <summary>
    '''     Closes the EmployeeForm and goes back to the menu.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        LogoutAsSales()
    End Sub

#Region "Edit and Adding"

    
    ''' <summary>
    '''     Opens the LoginForm when this form is closed.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub EmployeeForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        CloseLoginForm()
    End Sub

    
    ''' <summary>
    '''     Opens the ProductEdit form, to edit products.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ProductEditButton_Click(sender As Object, e As EventArgs) Handles ProductEditButton.Click
        OpenEditProduct()
        IsAdding = False
    End Sub

    
    ''' <summary>
    '''     Opens the ProductEdit form, to add products.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ProductAddButton_Click(sender As Object, e As EventArgs) Handles ProductAddButton.Click
        OpenEditProduct()
        IsAdding = True
    End Sub

    
    ''' <summary>
    '''     Opens the CustomerEdit form, to edit customer information.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CustomerEditButton_Click(sender As Object, e As EventArgs) Handles CustomerEditButton.Click
        OpenEditCustomer()
        IsAdding = False
    End Sub

    
    ''' <summary>
    '''     Opens the CustomerEdit form, to add customer information.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub AddCustomerButton_Click(sender As Object, e As EventArgs) Handles AddCustomerButton.Click
        OpenEditCustomer()
        IsAdding = True
    End Sub

#End Region

    
    ''' <summary>
    '''     Updates the product information, in the DataGrid.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub UpdateProductGrid()

        Dim tDS = SalesClass.ShowProducts()

        ProductCustomerData.DataSource = tDS
        ProductCustomerData.DataMember = "Products"
    End Sub

    
    ''' <summary>
    '''     Updates customer information, in the DataGrid.
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub UpdateCustomerGrid()

        Dim tDS = SalesClass.ShowCustomers()

        ProductCustomerData.DataSource = tDS
        ProductCustomerData.DataMember = "Customers"
    End Sub

    
    ''' <summary>
    '''     Allows the product index string to be used everywhere.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ProductIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles ProductIDTextBox.TextChanged
        ProductIndex = ProductIDTextBox.Text
    End Sub

    
    ''' <summary>
    '''     Allows the customer index string to be used everywhere.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CustomerIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles CustomerIDTextBox.TextChanged
        CustomerIndex = CustomerIDTextBox.Text
    End Sub
End Class