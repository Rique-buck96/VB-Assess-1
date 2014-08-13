<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.employeeInfo = New System.Windows.Forms.DataGridView()
        Me.btnShowEmployee = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.addPanel = New System.Windows.Forms.Panel()
        Me.btnAddCancel = New System.Windows.Forms.Button()
        Me.lstAccess = New System.Windows.Forms.ComboBox()
        Me.btnAddSave = New System.Windows.Forms.Button()
        Me.txtAddFirst = New System.Windows.Forms.TextBox()
        Me.txtAddLast = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblPAss = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAddUserName = New System.Windows.Forms.TextBox()
        Me.txtAddPass = New System.Windows.Forms.TextBox()
        Me.txtAddSal = New System.Windows.Forms.TextBox()
        Me.lblAccess = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAddDate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.editAddPanel = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.txtDOB = New System.Windows.Forms.TextBox()
        Me.lblSal = New System.Windows.Forms.Label()
        Me.txtSal = New System.Windows.Forms.TextBox()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnEditAddPanel = New System.Windows.Forms.Panel()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.IDd = New System.Windows.Forms.Label()
        Me.txtEditID = New System.Windows.Forms.TextBox()
        CType(Me.employeeInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.addPanel.SuspendLayout()
        Me.editAddPanel.SuspendLayout()
        Me.btnEditAddPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'employeeInfo
        '
        Me.employeeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.employeeInfo.Location = New System.Drawing.Point(12, 12)
        Me.employeeInfo.Name = "employeeInfo"
        Me.employeeInfo.Size = New System.Drawing.Size(605, 150)
        Me.employeeInfo.TabIndex = 0
        '
        'btnShowEmployee
        '
        Me.btnShowEmployee.Location = New System.Drawing.Point(12, 177)
        Me.btnShowEmployee.Name = "btnShowEmployee"
        Me.btnShowEmployee.Size = New System.Drawing.Size(102, 23)
        Me.btnShowEmployee.TabIndex = 1
        Me.btnShowEmployee.Text = "Show Employees"
        Me.btnShowEmployee.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(12, 467)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 2
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'addPanel
        '
        Me.addPanel.Controls.Add(Me.Label5)
        Me.addPanel.Controls.Add(Me.btnAddCancel)
        Me.addPanel.Controls.Add(Me.lstAccess)
        Me.addPanel.Controls.Add(Me.btnAddSave)
        Me.addPanel.Controls.Add(Me.txtAddFirst)
        Me.addPanel.Controls.Add(Me.txtAddLast)
        Me.addPanel.Controls.Add(Me.Label1)
        Me.addPanel.Controls.Add(Me.lblUser)
        Me.addPanel.Controls.Add(Me.lblPAss)
        Me.addPanel.Controls.Add(Me.Label4)
        Me.addPanel.Controls.Add(Me.txtAddUserName)
        Me.addPanel.Controls.Add(Me.txtAddPass)
        Me.addPanel.Controls.Add(Me.txtAddSal)
        Me.addPanel.Controls.Add(Me.lblAccess)
        Me.addPanel.Controls.Add(Me.Label2)
        Me.addPanel.Controls.Add(Me.Label3)
        Me.addPanel.Controls.Add(Me.txtAddDate)
        Me.addPanel.Location = New System.Drawing.Point(137, 168)
        Me.addPanel.Name = "addPanel"
        Me.addPanel.Size = New System.Drawing.Size(213, 322)
        Me.addPanel.TabIndex = 11
        Me.addPanel.Visible = False
        '
        'btnAddCancel
        '
        Me.btnAddCancel.Location = New System.Drawing.Point(120, 296)
        Me.btnAddCancel.Name = "btnAddCancel"
        Me.btnAddCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnAddCancel.TabIndex = 7
        Me.btnAddCancel.Text = "cancel"
        Me.btnAddCancel.UseVisualStyleBackColor = True
        '
        'lstAccess
        '
        Me.lstAccess.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lstAccess.FormattingEnabled = True
        Me.lstAccess.Items.AddRange(New Object() {"Sales", "HR", "admin"})
        Me.lstAccess.Location = New System.Drawing.Point(74, 269)
        Me.lstAccess.Name = "lstAccess"
        Me.lstAccess.Size = New System.Drawing.Size(121, 21)
        Me.lstAccess.TabIndex = 6
        '
        'btnAddSave
        '
        Me.btnAddSave.Location = New System.Drawing.Point(2, 296)
        Me.btnAddSave.Name = "btnAddSave"
        Me.btnAddSave.Size = New System.Drawing.Size(112, 23)
        Me.btnAddSave.TabIndex = 7
        Me.btnAddSave.Text = "save"
        Me.btnAddSave.UseVisualStyleBackColor = True
        '
        'txtAddFirst
        '
        Me.txtAddFirst.Location = New System.Drawing.Point(95, 112)
        Me.txtAddFirst.Name = "txtAddFirst"
        Me.txtAddFirst.Size = New System.Drawing.Size(100, 20)
        Me.txtAddFirst.TabIndex = 4
        '
        'txtAddLast
        '
        Me.txtAddLast.Location = New System.Drawing.Point(95, 147)
        Me.txtAddLast.Name = "txtAddLast"
        Me.txtAddLast.Size = New System.Drawing.Size(100, 20)
        Me.txtAddLast.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 186)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Date Of Birth"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(32, 48)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(55, 13)
        Me.lblUser.TabIndex = 5
        Me.lblUser.Text = "Username"
        '
        'lblPAss
        '
        Me.lblPAss.AutoSize = True
        Me.lblPAss.Location = New System.Drawing.Point(32, 79)
        Me.lblPAss.Name = "lblPAss"
        Me.lblPAss.Size = New System.Drawing.Size(53, 13)
        Me.lblPAss.TabIndex = 5
        Me.lblPAss.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "First Name"
        '
        'txtAddUserName
        '
        Me.txtAddUserName.Location = New System.Drawing.Point(95, 47)
        Me.txtAddUserName.Name = "txtAddUserName"
        Me.txtAddUserName.Size = New System.Drawing.Size(100, 20)
        Me.txtAddUserName.TabIndex = 4
        '
        'txtAddPass
        '
        Me.txtAddPass.Location = New System.Drawing.Point(95, 76)
        Me.txtAddPass.Name = "txtAddPass"
        Me.txtAddPass.Size = New System.Drawing.Size(100, 20)
        Me.txtAddPass.TabIndex = 4
        '
        'txtAddSal
        '
        Me.txtAddSal.Location = New System.Drawing.Point(95, 219)
        Me.txtAddSal.Name = "txtAddSal"
        Me.txtAddSal.Size = New System.Drawing.Size(100, 20)
        Me.txtAddSal.TabIndex = 4
        '
        'lblAccess
        '
        Me.lblAccess.AutoSize = True
        Me.lblAccess.Location = New System.Drawing.Point(32, 272)
        Me.lblAccess.Name = "lblAccess"
        Me.lblAccess.Size = New System.Drawing.Size(71, 13)
        Me.lblAccess.TabIndex = 5
        Me.lblAccess.Text = "Access Level"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Salary"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Last Name"
        '
        'txtAddDate
        '
        Me.txtAddDate.Location = New System.Drawing.Point(95, 183)
        Me.txtAddDate.Name = "txtAddDate"
        Me.txtAddDate.Size = New System.Drawing.Size(100, 20)
        Me.txtAddDate.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe WP SemiLight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Add Employee"
        '
        'editAddPanel
        '
        Me.editAddPanel.Controls.Add(Me.Label6)
        Me.editAddPanel.Controls.Add(Me.btnCancel)
        Me.editAddPanel.Controls.Add(Me.btnSave)
        Me.editAddPanel.Controls.Add(Me.txtID)
        Me.editAddPanel.Controls.Add(Me.lblFirst)
        Me.editAddPanel.Controls.Add(Me.txtFirst)
        Me.editAddPanel.Controls.Add(Me.lblLast)
        Me.editAddPanel.Controls.Add(Me.txtDOB)
        Me.editAddPanel.Controls.Add(Me.lblSal)
        Me.editAddPanel.Controls.Add(Me.txtSal)
        Me.editAddPanel.Controls.Add(Me.lblDOB)
        Me.editAddPanel.Controls.Add(Me.txtLast)
        Me.editAddPanel.Controls.Add(Me.lblID)
        Me.editAddPanel.Location = New System.Drawing.Point(356, 233)
        Me.editAddPanel.Name = "editAddPanel"
        Me.editAddPanel.Size = New System.Drawing.Size(199, 257)
        Me.editAddPanel.TabIndex = 12
        Me.editAddPanel.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(120, 233)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(2, 233)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(112, 23)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(96, 41)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 4
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Location = New System.Drawing.Point(33, 80)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(57, 13)
        Me.lblFirst.TabIndex = 5
        Me.lblFirst.Text = "First Name"
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(96, 77)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(100, 20)
        Me.txtFirst.TabIndex = 4
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.Location = New System.Drawing.Point(33, 116)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(58, 13)
        Me.lblLast.TabIndex = 5
        Me.lblLast.Text = "Last Name"
        '
        'txtDOB
        '
        Me.txtDOB.Location = New System.Drawing.Point(96, 150)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(100, 20)
        Me.txtDOB.TabIndex = 4
        '
        'lblSal
        '
        Me.lblSal.AutoSize = True
        Me.lblSal.Location = New System.Drawing.Point(54, 189)
        Me.lblSal.Name = "lblSal"
        Me.lblSal.Size = New System.Drawing.Size(36, 13)
        Me.lblSal.TabIndex = 5
        Me.lblSal.Text = "Salary"
        '
        'txtSal
        '
        Me.txtSal.Location = New System.Drawing.Point(96, 186)
        Me.txtSal.Name = "txtSal"
        Me.txtSal.Size = New System.Drawing.Size(100, 20)
        Me.txtSal.TabIndex = 4
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(23, 153)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(68, 13)
        Me.lblDOB.TabIndex = 5
        Me.lblDOB.Text = "Date Of Birth"
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(96, 113)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(100, 20)
        Me.txtLast.TabIndex = 4
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(23, 44)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(67, 13)
        Me.lblID.TabIndex = 5
        Me.lblID.Text = "Employee ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe WP SemiLight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 25)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Edit Employee"
        '
        'btnEditAddPanel
        '
        Me.btnEditAddPanel.Controls.Add(Me.btnEdit)
        Me.btnEditAddPanel.Controls.Add(Me.btnAdd)
        Me.btnEditAddPanel.Location = New System.Drawing.Point(12, 207)
        Me.btnEditAddPanel.Name = "btnEditAddPanel"
        Me.btnEditAddPanel.Size = New System.Drawing.Size(108, 60)
        Me.btnEditAddPanel.TabIndex = 13
        Me.btnEditAddPanel.Visible = False
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(3, 3)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(101, 23)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "Edit Employee"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(3, 32)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(101, 23)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add Employee"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'IDd
        '
        Me.IDd.AutoSize = True
        Me.IDd.Location = New System.Drawing.Point(355, 191)
        Me.IDd.Name = "IDd"
        Me.IDd.Size = New System.Drawing.Size(18, 13)
        Me.IDd.TabIndex = 15
        Me.IDd.Text = "ID"
        Me.IDd.Visible = False
        '
        'txtEditID
        '
        Me.txtEditID.Location = New System.Drawing.Point(356, 207)
        Me.txtEditID.Name = "txtEditID"
        Me.txtEditID.Size = New System.Drawing.Size(88, 20)
        Me.txtEditID.TabIndex = 14
        Me.txtEditID.Visible = False
        '
        'HRForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 499)
        Me.Controls.Add(Me.IDd)
        Me.Controls.Add(Me.txtEditID)
        Me.Controls.Add(Me.btnEditAddPanel)
        Me.Controls.Add(Me.editAddPanel)
        Me.Controls.Add(Me.addPanel)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnShowEmployee)
        Me.Controls.Add(Me.employeeInfo)
        Me.Name = "HRForm"
        Me.Text = "HRForm"
        CType(Me.employeeInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.addPanel.ResumeLayout(False)
        Me.addPanel.PerformLayout()
        Me.editAddPanel.ResumeLayout(False)
        Me.editAddPanel.PerformLayout()
        Me.btnEditAddPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents employeeInfo As System.Windows.Forms.DataGridView
    Friend WithEvents btnShowEmployee As System.Windows.Forms.Button
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents addPanel As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnAddCancel As System.Windows.Forms.Button
    Friend WithEvents lstAccess As System.Windows.Forms.ComboBox
    Friend WithEvents btnAddSave As System.Windows.Forms.Button
    Friend WithEvents txtAddFirst As System.Windows.Forms.TextBox
    Friend WithEvents txtAddLast As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblPAss As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAddUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddPass As System.Windows.Forms.TextBox
    Friend WithEvents txtAddSal As System.Windows.Forms.TextBox
    Friend WithEvents lblAccess As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAddDate As System.Windows.Forms.TextBox
    Friend WithEvents editAddPanel As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents txtFirst As System.Windows.Forms.TextBox
    Friend WithEvents lblLast As System.Windows.Forms.Label
    Friend WithEvents txtDOB As System.Windows.Forms.TextBox
    Friend WithEvents lblSal As System.Windows.Forms.Label
    Friend WithEvents txtSal As System.Windows.Forms.TextBox
    Friend WithEvents lblDOB As System.Windows.Forms.Label
    Friend WithEvents txtLast As System.Windows.Forms.TextBox
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents btnEditAddPanel As System.Windows.Forms.Panel
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents IDd As System.Windows.Forms.Label
    Friend WithEvents txtEditID As System.Windows.Forms.TextBox
End Class
