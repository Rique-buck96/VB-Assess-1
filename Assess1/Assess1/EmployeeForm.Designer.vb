<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeForm
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
        Me.ProductCustomerData = New System.Windows.Forms.DataGridView()
        Me.ProductButton = New System.Windows.Forms.Button()
        Me.CustomerButton = New System.Windows.Forms.Button()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.ProductPropertyPanel = New System.Windows.Forms.Panel()
        Me.ProductAddButton = New System.Windows.Forms.Button()
        Me.ProductEditButton = New System.Windows.Forms.Button()
        Me.ProductIDPanel = New System.Windows.Forms.Panel()
        Me.ProductIDLabel = New System.Windows.Forms.Label()
        Me.ProductIDTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerPropertyPanel = New System.Windows.Forms.Panel()
        Me.AddCustomerButton = New System.Windows.Forms.Button()
        Me.CustomerEditButton = New System.Windows.Forms.Button()
        Me.ProductsLabel = New System.Windows.Forms.Label()
        Me.CustomersLabel = New System.Windows.Forms.Label()
        Me.CustomerIDPanel = New System.Windows.Forms.Panel()
        Me.CustomerIDLabel = New System.Windows.Forms.Label()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        CType(Me.ProductCustomerData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductPropertyPanel.SuspendLayout()
        Me.ProductIDPanel.SuspendLayout()
        Me.CustomerPropertyPanel.SuspendLayout()
        Me.CustomerIDPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProductCustomerData
        '
        Me.ProductCustomerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductCustomerData.Location = New System.Drawing.Point(12, 12)
        Me.ProductCustomerData.Name = "ProductCustomerData"
        Me.ProductCustomerData.Size = New System.Drawing.Size(658, 237)
        Me.ProductCustomerData.TabIndex = 0
        '
        'ProductButton
        '
        Me.ProductButton.Location = New System.Drawing.Point(12, 284)
        Me.ProductButton.Name = "ProductButton"
        Me.ProductButton.Size = New System.Drawing.Size(94, 32)
        Me.ProductButton.TabIndex = 1
        Me.ProductButton.Text = "View Products"
        Me.ProductButton.UseVisualStyleBackColor = True
        '
        'CustomerButton
        '
        Me.CustomerButton.Location = New System.Drawing.Point(12, 322)
        Me.CustomerButton.Name = "CustomerButton"
        Me.CustomerButton.Size = New System.Drawing.Size(94, 31)
        Me.CustomerButton.TabIndex = 2
        Me.CustomerButton.Text = "View Customers"
        Me.CustomerButton.UseVisualStyleBackColor = True
        '
        'LogoutButton
        '
        Me.LogoutButton.Location = New System.Drawing.Point(13, 377)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(75, 23)
        Me.LogoutButton.TabIndex = 3
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'ProductPropertyPanel
        '
        Me.ProductPropertyPanel.Controls.Add(Me.ProductAddButton)
        Me.ProductPropertyPanel.Controls.Add(Me.ProductEditButton)
        Me.ProductPropertyPanel.Location = New System.Drawing.Point(165, 281)
        Me.ProductPropertyPanel.Name = "ProductPropertyPanel"
        Me.ProductPropertyPanel.Size = New System.Drawing.Size(189, 32)
        Me.ProductPropertyPanel.TabIndex = 4
        Me.ProductPropertyPanel.Visible = False
        '
        'ProductAddButton
        '
        Me.ProductAddButton.Location = New System.Drawing.Point(107, 3)
        Me.ProductAddButton.Name = "ProductAddButton"
        Me.ProductAddButton.Size = New System.Drawing.Size(75, 23)
        Me.ProductAddButton.TabIndex = 1
        Me.ProductAddButton.Text = "Add"
        Me.ProductAddButton.UseVisualStyleBackColor = True
        '
        'ProductEditButton
        '
        Me.ProductEditButton.Location = New System.Drawing.Point(3, 3)
        Me.ProductEditButton.Name = "ProductEditButton"
        Me.ProductEditButton.Size = New System.Drawing.Size(75, 23)
        Me.ProductEditButton.TabIndex = 0
        Me.ProductEditButton.Text = "Edit"
        Me.ProductEditButton.UseVisualStyleBackColor = True
        '
        'ProductIDPanel
        '
        Me.ProductIDPanel.Controls.Add(Me.ProductIDLabel)
        Me.ProductIDPanel.Controls.Add(Me.ProductIDTextBox)
        Me.ProductIDPanel.Location = New System.Drawing.Point(165, 314)
        Me.ProductIDPanel.Name = "ProductIDPanel"
        Me.ProductIDPanel.Size = New System.Drawing.Size(113, 45)
        Me.ProductIDPanel.TabIndex = 5
        Me.ProductIDPanel.Visible = False
        '
        'ProductIDLabel
        '
        Me.ProductIDLabel.AutoSize = True
        Me.ProductIDLabel.Location = New System.Drawing.Point(3, 2)
        Me.ProductIDLabel.Name = "ProductIDLabel"
        Me.ProductIDLabel.Size = New System.Drawing.Size(58, 13)
        Me.ProductIDLabel.TabIndex = 1
        Me.ProductIDLabel.Text = "Product ID"
        '
        'ProductIDTextBox
        '
        Me.ProductIDTextBox.Location = New System.Drawing.Point(0, 18)
        Me.ProductIDTextBox.Name = "ProductIDTextBox"
        Me.ProductIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ProductIDTextBox.TabIndex = 0
        '
        'CustomerPropertyPanel
        '
        Me.CustomerPropertyPanel.Controls.Add(Me.AddCustomerButton)
        Me.CustomerPropertyPanel.Controls.Add(Me.CustomerEditButton)
        Me.CustomerPropertyPanel.Location = New System.Drawing.Point(470, 281)
        Me.CustomerPropertyPanel.Name = "CustomerPropertyPanel"
        Me.CustomerPropertyPanel.Size = New System.Drawing.Size(200, 32)
        Me.CustomerPropertyPanel.TabIndex = 6
        Me.CustomerPropertyPanel.Visible = False
        '
        'AddCustomerButton
        '
        Me.AddCustomerButton.Location = New System.Drawing.Point(122, 3)
        Me.AddCustomerButton.Name = "AddCustomerButton"
        Me.AddCustomerButton.Size = New System.Drawing.Size(75, 23)
        Me.AddCustomerButton.TabIndex = 1
        Me.AddCustomerButton.Text = "Add"
        Me.AddCustomerButton.UseVisualStyleBackColor = True
        '
        'CustomerEditButton
        '
        Me.CustomerEditButton.Location = New System.Drawing.Point(3, 3)
        Me.CustomerEditButton.Name = "CustomerEditButton"
        Me.CustomerEditButton.Size = New System.Drawing.Size(75, 23)
        Me.CustomerEditButton.TabIndex = 0
        Me.CustomerEditButton.Text = "Edit Customer"
        Me.CustomerEditButton.UseVisualStyleBackColor = True
        '
        'ProductsLabel
        '
        Me.ProductsLabel.AutoSize = True
        Me.ProductsLabel.Font = New System.Drawing.Font("Segoe WP Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductsLabel.Location = New System.Drawing.Point(163, 256)
        Me.ProductsLabel.Name = "ProductsLabel"
        Me.ProductsLabel.Size = New System.Drawing.Size(87, 25)
        Me.ProductsLabel.TabIndex = 7
        Me.ProductsLabel.Text = "Products"
        Me.ProductsLabel.Visible = False
        '
        'CustomersLabel
        '
        Me.CustomersLabel.AutoSize = True
        Me.CustomersLabel.Font = New System.Drawing.Font("Segoe WP Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomersLabel.Location = New System.Drawing.Point(465, 256)
        Me.CustomersLabel.Name = "CustomersLabel"
        Me.CustomersLabel.Size = New System.Drawing.Size(103, 25)
        Me.CustomersLabel.TabIndex = 8
        Me.CustomersLabel.Text = "Customers"
        Me.CustomersLabel.Visible = False
        '
        'CustomerIDPanel
        '
        Me.CustomerIDPanel.Controls.Add(Me.CustomerIDLabel)
        Me.CustomerIDPanel.Controls.Add(Me.CustomerIDTextBox)
        Me.CustomerIDPanel.Location = New System.Drawing.Point(470, 314)
        Me.CustomerIDPanel.Name = "CustomerIDPanel"
        Me.CustomerIDPanel.Size = New System.Drawing.Size(113, 45)
        Me.CustomerIDPanel.TabIndex = 9
        Me.CustomerIDPanel.Visible = False
        '
        'CustomerIDLabel
        '
        Me.CustomerIDLabel.AutoSize = True
        Me.CustomerIDLabel.Location = New System.Drawing.Point(3, 4)
        Me.CustomerIDLabel.Name = "CustomerIDLabel"
        Me.CustomerIDLabel.Size = New System.Drawing.Size(65, 13)
        Me.CustomerIDLabel.TabIndex = 11
        Me.CustomerIDLabel.Text = "Customer ID"
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(3, 19)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustomerIDTextBox.TabIndex = 10
        '
        'EmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 412)
        Me.Controls.Add(Me.CustomerIDPanel)
        Me.Controls.Add(Me.CustomersLabel)
        Me.Controls.Add(Me.ProductsLabel)
        Me.Controls.Add(Me.CustomerPropertyPanel)
        Me.Controls.Add(Me.ProductIDPanel)
        Me.Controls.Add(Me.ProductPropertyPanel)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.CustomerButton)
        Me.Controls.Add(Me.ProductButton)
        Me.Controls.Add(Me.ProductCustomerData)
        Me.Name = "EmployeeForm"
        Me.Text = "Conteso Employee Form"
        CType(Me.ProductCustomerData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductPropertyPanel.ResumeLayout(False)
        Me.ProductIDPanel.ResumeLayout(False)
        Me.ProductIDPanel.PerformLayout()
        Me.CustomerPropertyPanel.ResumeLayout(False)
        Me.CustomerIDPanel.ResumeLayout(False)
        Me.CustomerIDPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProductCustomerData As System.Windows.Forms.DataGridView
    Friend WithEvents ProductButton As System.Windows.Forms.Button
    Friend WithEvents CustomerButton As System.Windows.Forms.Button
    Friend WithEvents LogoutButton As System.Windows.Forms.Button
    Friend WithEvents ProductPropertyPanel As System.Windows.Forms.Panel
    Friend WithEvents ProductEditButton As System.Windows.Forms.Button
    Friend WithEvents ProductAddButton As System.Windows.Forms.Button
    Friend WithEvents ProductIDPanel As System.Windows.Forms.Panel
    Friend WithEvents ProductIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProductIDLabel As System.Windows.Forms.Label
    Friend WithEvents CustomerPropertyPanel As System.Windows.Forms.Panel
    Friend WithEvents AddCustomerButton As System.Windows.Forms.Button
    Friend WithEvents CustomerEditButton As System.Windows.Forms.Button
    Friend WithEvents ProductsLabel As System.Windows.Forms.Label
    Friend WithEvents CustomersLabel As System.Windows.Forms.Label
    Friend WithEvents CustomerIDPanel As System.Windows.Forms.Panel
    Friend WithEvents CustomerIDLabel As System.Windows.Forms.Label
    Friend WithEvents CustomerIDTextBox As System.Windows.Forms.TextBox
End Class
