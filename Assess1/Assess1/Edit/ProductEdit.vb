Namespace Edit
    Public Class ProductEdit

        ''' <summary>
        '''     Saves product information to the database.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click

            Dim okay = EvaluateProductString()

            'If we are adding a new product, the database will add the product fields to a new item.
            If okay Then
                If EmployeeForm.IsAdding Then
                    EmployeeForm.SalesClass.AddProduct(ProductNameTextBox.Text, _
                                                       DescriptionTextBox.Text, _
                                                       PriceTextBox.Text, _
                                                       QuantityTextBox.Text)
                    EmployeeForm.UpdateProductGrid()
                Else
                    'If we're overwriting product information, keep the product index constant.
                    If IsNumeric(QuantityTextBox.Text) And IsNumeric(PriceTextBox.Text) Then
                        EmployeeForm.SalesClass.EditProductName(EmployeeForm.ProductIndex, ProductNameTextBox.Text)
                        EmployeeForm.SalesClass.EditProductDescription(EmployeeForm.ProductIndex, DescriptionTextBox.Text)
                        EmployeeForm.SalesClass.EditProductPrice(EmployeeForm.ProductIndex, PriceTextBox.Text)
                        EmployeeForm.SalesClass.EditProductQuantity(EmployeeForm.ProductIndex, QuantityTextBox.Text)

                        EmployeeForm.UpdateProductGrid()
                    Else
                        Return
                    End If
                End If
                ClearProductProperties()
                CloseEditProduct()
                EmployeeForm.IsAdding = False
            End If
        End Sub

        
        ''' <summary>
        '''     Evaluates if all fields follow their datatypes and have information assigned to each individual field.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function EvaluateProductString() As Boolean

            If Not ProductNameTextBox.Text = "" And
                Not PriceTextBox.Text = "" And
                Not QuantityTextBox.Text = "" And
                Not DescriptionTextBox.Text = "" Then
                If IsNumeric(PriceTextBox.Text) And IsNumeric(QuantityTextBox.Text) Then
                    Return True
                Else
                    MessageBox.Show("Price and quantity must be numeric.")
                End If
            End If

            MessageBox.Show("All fields must be filled.")
            Return False
        End Function

        
        ''' <summary>
        '''     Clears all product fields.
        ''' </summary>
        ''' <remarks></remarks>
        Private Sub ClearProductProperties()
            ProductNameTextBox.Clear()
            DescriptionTextBox.Clear()
            QuantityTextBox.Clear()
            PriceTextBox.Clear()
        End Sub
    End Class
End Namespace