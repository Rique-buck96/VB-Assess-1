<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckOutForm
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
        Me.OrderList = New System.Windows.Forms.ListBox()
        Me.PriceList = New System.Windows.Forms.ListBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ConfirmButton = New System.Windows.Forms.Button()
        Me.GoBackButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OrderList
        '
        Me.OrderList.FormattingEnabled = True
        Me.OrderList.Location = New System.Drawing.Point(12, 12)
        Me.OrderList.Name = "OrderList"
        Me.OrderList.Size = New System.Drawing.Size(198, 147)
        Me.OrderList.TabIndex = 0
        '
        'PriceList
        '
        Me.PriceList.FormattingEnabled = True
        Me.PriceList.Location = New System.Drawing.Point(226, 64)
        Me.PriceList.Name = "PriceList"
        Me.PriceList.Size = New System.Drawing.Size(120, 95)
        Me.PriceList.TabIndex = 1
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(12, 190)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalTextBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Total"
        '
        'ConfirmButton
        '
        Me.ConfirmButton.Location = New System.Drawing.Point(12, 217)
        Me.ConfirmButton.Name = "ConfirmButton"
        Me.ConfirmButton.Size = New System.Drawing.Size(75, 23)
        Me.ConfirmButton.TabIndex = 4
        Me.ConfirmButton.Text = "Confirm"
        Me.ConfirmButton.UseVisualStyleBackColor = True
        '
        'GoBackButton
        '
        Me.GoBackButton.Location = New System.Drawing.Point(288, 217)
        Me.GoBackButton.Name = "GoBackButton"
        Me.GoBackButton.Size = New System.Drawing.Size(75, 23)
        Me.GoBackButton.TabIndex = 5
        Me.GoBackButton.Text = "Shop"
        Me.GoBackButton.UseVisualStyleBackColor = True
        '
        'CustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 255)
        Me.Controls.Add(Me.GoBackButton)
        Me.Controls.Add(Me.ConfirmButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.PriceList)
        Me.Controls.Add(Me.OrderList)
        Me.Name = "CustomerForm"
        Me.Text = "CustomerForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OrderList As System.Windows.Forms.ListBox
    Friend WithEvents PriceList As System.Windows.Forms.ListBox
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ConfirmButton As System.Windows.Forms.Button
    Friend WithEvents GoBackButton As System.Windows.Forms.Button
End Class
