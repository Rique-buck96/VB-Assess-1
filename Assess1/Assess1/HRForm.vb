'   Developer: Enrique Johannes Buck
'   Date: 7/17/2014
'   This form allows users with an 'Admin' access level to view current employees and edit their information.
'   The user can also add new employees, and give them an access level.

Public Class HRForm
    Private ReadOnly _hr As New ContesoLibrary.HRAuthentication

    ''' <summary>
    ''' Shows the employee data in the datagrid.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnShowEmployee_Click(sender As Object, e As EventArgs) Handles btnShowEmployee.Click
        Dim ds = _hr.ShowEmployees()

        employeeInfo.DataSource = ds
        employeeInfo.DataMember = "Employees"

        btnShowEmployee.Visible = False
        btnEditAddPanel.Visible = True
    End Sub

    ''' <summary>
    ''' Hides and presents certain controls.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnEditAddPanel.Visible = False
        txtEditID.Visible = True
        IDd.Visible = True
    End Sub

    ''' <summary>
    ''' Shows employee information, as soon as the employee's id has been entered.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub txtEditID_TextChanged(sender As Object, e As EventArgs) Handles txtEditID.TextChanged
        If Not IsNumeric(txtEditID.Text) Then
            Return
        End If

        If txtEditID.TextLength < 7 Then
            Dim index As Double = txtEditID.Text

            txtID.Text = _hr.GetEmployeeID(index)
            txtFirst.Text = _hr.GetFirstName(index)
            txtLast.Text = _hr.GetLastName(index)
            txtDOB.Text = _hr.GetDOB(index)
            txtSal.Text = _hr.GetSalary(index)
        End If
    End Sub

    ''' <summary>
    ''' Saves and updates employee information.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        editAddPanel.Visible = False
        btnEditAddPanel.Visible = True

        txtEditID.Clear()
        txtEditID.Visible = False
        IDd.Visible = False

        Dim sal As Decimal = FormatNumber(txtSal.Text)
        Dim myDate As DateTime


        If Not IsDate(txtDOB.Text) Then
            Return
        Else
            myDate = FormatDateTime(txtDOB.Text)

        End If

        _hr.SetFirstName(txtFirst.Text, txtID.Text)
        _hr.SetLastName(txtLast.Text, txtID.Text)
        _hr.SetDOB(myDate, txtID.Text)
        _hr.SetSalary(sal, txtID.Text)

        clearFields()

        Dim ds = _hr.ShowEmployees()

        employeeInfo.DataSource = ds
        employeeInfo.DataMember = "Employees"
    End Sub

    ''' <summary>
    ''' Clears text fields.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ClearFields()
        txtID.Clear()
        txtFirst.Clear()
        txtLast.Clear()
        txtDOB.Clear()
        txtSal.Clear()
    End Sub

    ''' <summary>
    '''  Hides and presents controls.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        editAddPanel.Visible = False
        btnEditAddPanel.Visible = True

        txtEditID.Clear()
        txtEditID.Visible = False
        IDd.Visible = False
        clearFields()
    End Sub

    ''' <summary>
    ''' Hides and presents certain controls.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnEditAddPanel.Visible = False
        addPanel.Visible = True
    End Sub

    ''' <summary>
    ''' Saves new employees to the database.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAddSave_Click(sender As Object, e As EventArgs) Handles btnAddSave.Click

        Dim salary As Integer = txtAddSal.Text
        Dim dateRegistered As Date
        Dim uniqueID As Integer = _hr.CheckUserName(txtAddUserName.Text)
        Dim ds = _hr.ShowEmployees()

        If uniqueID > 0 Then
            txtAddUserName.Focus()
            MsgBox("Username is already taken")
            Return
        End If

        If Not IsDate(txtAddDate.Text) Then
            txtAddDate.Focus()
            MsgBox("Date is not correct format.")
            Return
        Else
            dateRegistered = txtAddDate.Text
        End If

        If lstAccess.SelectedIndex > -1 Then
            If IsNumeric(salary) Then
                _hr.AddUserEmployee(txtAddUserName.Text _
                                    , txtAddPass.Text _
                                    , txtAddFirst.Text _
                                    , txtAddLast.Text _
                                    , dateRegistered _
                                    , salary _
                                    , lstAccess.SelectedItem)
            End If
        End If


        addPanel.Visible = False
        btnEditAddPanel.Visible = True

        ClearAddFields()

        employeeInfo.DataSource = ds
        employeeInfo.DataMember = "Employees"
    End Sub

    ''' <summary>
    ''' Hides and presents certain controls, when the employee registration session has been cancelled.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnAddCancel_Click(sender As Object, e As EventArgs) Handles btnAddCancel.Click
        addPanel.Visible = False
        btnEditAddPanel.Visible = True

        ClearAddFields()
    End Sub

    ''' <summary>
    ''' Clears Employee registration text fields.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ClearAddFields()
        txtAddDate.Clear()
        txtAddFirst.Clear()
        txtAddLast.Clear()
        txtAddPass.Clear()
        txtAddSal.Clear()
        txtAddUserName.Clear()
    End Sub

    ''' <summary>
    ''' Logs out from the current account.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        LogoutAsHR()
    End Sub

    ''' <summary>
    ''' Closes the login form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub hrForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        CloseLoginForm()
    End Sub
End Class