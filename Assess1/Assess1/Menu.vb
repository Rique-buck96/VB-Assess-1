Public Class Menu

    ''' <summary>
    ''' Opens the customer form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CustomerButton_Click(sender As Object, e As EventArgs) Handles CustomerButton.Click
        LogInAsCustomer()
    End Sub

    ''' <summary>
    ''' Opens the Employee form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SalesButton_Click(sender As Object, e As EventArgs) Handles SalesButton.Click
        LoginAsSales()
    End Sub

    ''' <summary>
    ''' Opens the HR form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub HRButton_Click(sender As Object, e As EventArgs) Handles HRButton.Click
        LoginAsHR()
    End Sub

    ''' <summary>
    ''' Logs a user out.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        CloseLoginForm()
    End Sub
End Class