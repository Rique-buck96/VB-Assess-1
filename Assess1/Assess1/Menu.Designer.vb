<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomerButton = New System.Windows.Forms.Button()
        Me.SalesButton = New System.Windows.Forms.Button()
        Me.HRButton = New System.Windows.Forms.Button()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe WP Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome"
        '
        'CustomerButton
        '
        Me.CustomerButton.Location = New System.Drawing.Point(44, 55)
        Me.CustomerButton.Name = "CustomerButton"
        Me.CustomerButton.Size = New System.Drawing.Size(75, 23)
        Me.CustomerButton.TabIndex = 1
        Me.CustomerButton.Text = "Customer"
        Me.CustomerButton.UseVisualStyleBackColor = True
        '
        'SalesButton
        '
        Me.SalesButton.Location = New System.Drawing.Point(212, 55)
        Me.SalesButton.Name = "SalesButton"
        Me.SalesButton.Size = New System.Drawing.Size(75, 23)
        Me.SalesButton.TabIndex = 2
        Me.SalesButton.Text = "Sales"
        Me.SalesButton.UseVisualStyleBackColor = True
        '
        'HRButton
        '
        Me.HRButton.Location = New System.Drawing.Point(44, 103)
        Me.HRButton.Name = "HRButton"
        Me.HRButton.Size = New System.Drawing.Size(75, 23)
        Me.HRButton.TabIndex = 3
        Me.HRButton.Text = "HR"
        Me.HRButton.UseVisualStyleBackColor = True
        '
        'LogoutButton
        '
        Me.LogoutButton.Location = New System.Drawing.Point(212, 103)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(75, 23)
        Me.LogoutButton.TabIndex = 4
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 175)
        Me.Controls.Add(Me.LogoutButton)
        Me.Controls.Add(Me.HRButton)
        Me.Controls.Add(Me.SalesButton)
        Me.Controls.Add(Me.CustomerButton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CustomerButton As System.Windows.Forms.Button
    Friend WithEvents SalesButton As System.Windows.Forms.Button
    Friend WithEvents HRButton As System.Windows.Forms.Button
    Friend WithEvents LogoutButton As System.Windows.Forms.Button
End Class
