Imports ContesoLibrary
Public Class CheckOutForm

    Private ReadOnly _customerCheckout As New Checkout

    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        _customerCheckout.ConfirmOrder()
        ExitCheckout()
    End Sub

    Private Sub CustomerForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ExitCheckout()
    End Sub

    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim names As List(Of String) = _customerCheckout.GetProductName()
        Dim prices As List(Of Decimal) = _customerCheckout.GetProductSumTotal()
        Dim totalPrice As Decimal = 0.0

        For i As Integer = 0 To names.Count - 1
            OrderList.Items.Add(names(i))
            PriceList.Items.Add(FormatCurrency(prices(i)))
            totalPrice += prices(i)
        Next

        TotalTextBox.Text = FormatCurrency(totalPrice)
    End Sub


    Private Sub GoBackButton_Click(sender As Object, e As EventArgs) Handles GoBackButton.Click
        ExitCheckout()
    End Sub

    Private Sub PriceList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PriceList.SelectedIndexChanged
        Dim index As Integer = PriceList.SelectedIndex
        OrderList.SelectedIndex = index
    End Sub

    Private Sub OrderList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OrderList.SelectedIndexChanged
        Dim index As Integer = OrderList.SelectedIndex
        PriceList.SelectedIndex = index
    End Sub
End Class