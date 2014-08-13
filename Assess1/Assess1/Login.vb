Imports ContesoLibrary

Public Class Login

    ''' <summary>
    ''' Accepts a username and password from the user, and compares it with existing credentials on the database.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim authentication As New LoginHandling
        Dim strForm As String
        strForm = authentication.LoginProcess(txtUsername.Text, txtPWord.Text)

        If Not strForm = Nothing Then
            MessageBox.Show("Login session succesful.")
            txtUsername.Clear()
            txtPWord.Clear()

            AccessLevelVerification(strForm)
            Return
        Else
            MessageBox.Show("Login session unsuccesful, please try again.")
        End If

    End Sub
End Class
