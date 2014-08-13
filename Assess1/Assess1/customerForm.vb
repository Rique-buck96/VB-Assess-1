Public Class CustomerForm
    Dim CustClass As New ContesoLibrary.CustomerAuthentication


    Private Sub CustFrm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

        CloseLoginForm()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click

        LogOutAsCustomer()
    End Sub

    Private Sub CustFrm_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim intMax As Integer = CustClass.GetProductCount()

        For i As Integer = 1 To intMax

            Dim strName As String = CustClass.GetProductName(i)                '   Get product details from server

            lstProducts.Items.Add(strName)

        Next
    End Sub

    Private Sub lstProducts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstProducts.SelectedIndexChanged

        pnlDetails.Visible = True
        pnlButtons.Visible = True

        Dim strName As String = lstProducts.SelectedItem

        txtDesc.Text = CustClass.GetProductDescription(strName)
        txtPrice.Text = FormatCurrency(CustClass.GetProductPrice(strName))                '   Show product details of selected list box item 
        txtQuan.Text = CustClass.GetProductQuantity(strName)
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click

        If IsNumeric(txtNum.Text) Then

            txtNum.Text = txtNum.Text \ 1
            Dim idx As Integer = lstProducts.SelectedIndex + 1
            Dim pName As String = lstProducts.SelectedItem

            Dim txtMessage As String = CustClass.OrderProduct(idx, txtNum.Text, txtPrice.Text, pName)          '   Process the order


            lstProducts.Items.Clear()

            Dim intMax As Integer = CustClass.GetProductCount()

            For i As Integer = 1 To intMax

                Dim strName As String = CustClass.GetProductName(i)

                lstProducts.Items.Add(strName)

            Next

            MsgBox(txtMessage)

        End If
    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click

        OpenCheckout()
    End Sub

    Private Sub btnHist_Click(sender As Object, e As EventArgs) Handles btnHist.Click

        OpenOrderHistory()
    End Sub
End Class