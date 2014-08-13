Namespace Edit
    Public Class CustomerEdit

        ''' <summary>
        '''     Saves Customer information to the database.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

            'If we are adding a customer, the database will add their information to a new item.
            If EvaluateUserUniqueness() Then
                If IsNumeric(PostCodeTextBox.Text) Then
                    If EmployeeForm.IsAdding Then
                        If EvaluateCustomerString() Then
                            EmployeeForm.SalesClass.AddCustomer(FirstNameTextBox.Text,
                                                                LastNameTextBox.Text,
                                                                StreetTextBox.Text,
                                                                PostCodeTextBox.Text,
                                                                StateTextBox.Text,
                                                                UsernameTextBox.Text,
                                                                PasswordTextBox.Text)
                            EmployeeForm.UpdateCustomerGrid()
                        End If
                    Else
                        'If we're overwriting an existing customer's information, keep the index constant.
                        EmployeeForm.SalesClass.EditFirstName(EmployeeForm.CustomerIndex, FirstNameTextBox.Text)
                        EmployeeForm.SalesClass.EditLastName(EmployeeForm.CustomerIndex, LastNameTextBox.Text)
                        EmployeeForm.SalesClass.EditStatePostCode(EmployeeForm.CustomerIndex,
                                                                  PostCodeTextBox.Text,
                                                                  StateTextBox.Text)
                        EmployeeForm.SalesClass.EditStreet(EmployeeForm.CustomerIndex, StreetTextBox.Text)

                        EmployeeForm.UpdateCustomerGrid()
                    End If
                End If
                ClearCustomerProperties()
                EmployeeForm.IsAdding = False
                CloseEditCustomer()
            End If
        End Sub


        ''' <summary>
        '''     Evaluates if all fields follow their datatypes and if they have information filled in.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function EvaluateCustomerString() As Boolean

            If Not FirstNameTextBox.Text = "" And
                Not LastNameTextBox.Text = "" And
                 Not PostCodeTextBox.Text = "" And
                 Not StateTextBox.Text = "" And
                 Not StreetTextBox.Text = "" Then
                Return True
            End If

            MessageBox.Show("All fields must be filled.")
            Return False
        End Function


        ''' <summary>
        '''     Evaluates if the pending user's credentials are unique.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function EvaluateUserUniqueness() As Boolean

            If Not UsernameTextBox.Text = "" And Not PasswordTextBox.Text = "" Then
                Dim isUser = EmployeeForm.SalesClass.CheckCustomerUser(UsernameTextBox.Text)

                If Not isUser Then
                    Return True
                Else
                    MessageBox.Show("Username is already taken. Please use a different username.")
                End If
            Else
                MessageBox.Show("Username and password must be filled.")
            End If
            Return False
        End Function


        ''' <summary>
        '''     Clears all fields.
        ''' </summary>
        ''' <remarks></remarks>
        Public Sub ClearCustomerProperties()
            FirstNameTextBox.Clear()
            LastNameTextBox.Clear()
            PostCodeTextBox.Clear()
            StateTextBox.Clear()
            StreetTextBox.Clear()
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
        End Sub
    End Class
End Namespace