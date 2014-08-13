Namespace Edit
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ProductEdit
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
            Me.ProductNameTextBox = New System.Windows.Forms.TextBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.PriceTextBox = New System.Windows.Forms.TextBox()
            Me.QuantityTextBox = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.SaveButton = New System.Windows.Forms.Button()
            Me.CancelButton = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'ProductNameTextBox
            '
            Me.ProductNameTextBox.Location = New System.Drawing.Point(12, 39)
            Me.ProductNameTextBox.Name = "ProductNameTextBox"
            Me.ProductNameTextBox.Size = New System.Drawing.Size(100, 20)
            Me.ProductNameTextBox.TabIndex = 0
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(9, 23)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(35, 13)
            Me.Label1.TabIndex = 1
            Me.Label1.Text = "Name"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(9, 80)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(31, 13)
            Me.Label2.TabIndex = 2
            Me.Label2.Text = "Price"
            '
            'PriceTextBox
            '
            Me.PriceTextBox.Location = New System.Drawing.Point(12, 96)
            Me.PriceTextBox.Name = "PriceTextBox"
            Me.PriceTextBox.Size = New System.Drawing.Size(100, 20)
            Me.PriceTextBox.TabIndex = 3
            '
            'QuantityTextBox
            '
            Me.QuantityTextBox.Location = New System.Drawing.Point(159, 95)
            Me.QuantityTextBox.Name = "QuantityTextBox"
            Me.QuantityTextBox.Size = New System.Drawing.Size(100, 20)
            Me.QuantityTextBox.TabIndex = 4
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(156, 79)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(46, 13)
            Me.Label3.TabIndex = 5
            Me.Label3.Text = "Quantity"
            '
            'DescriptionTextBox
            '
            Me.DescriptionTextBox.Location = New System.Drawing.Point(12, 150)
            Me.DescriptionTextBox.Name = "DescriptionTextBox"
            Me.DescriptionTextBox.Size = New System.Drawing.Size(244, 20)
            Me.DescriptionTextBox.TabIndex = 6
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(9, 134)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(60, 13)
            Me.Label4.TabIndex = 7
            Me.Label4.Text = "Description"
            '
            'SaveButton
            '
            Me.SaveButton.Location = New System.Drawing.Point(12, 226)
            Me.SaveButton.Name = "SaveButton"
            Me.SaveButton.Size = New System.Drawing.Size(75, 23)
            Me.SaveButton.TabIndex = 8
            Me.SaveButton.Text = "Save"
            Me.SaveButton.UseVisualStyleBackColor = True
            '
            'CancelButton
            '
            Me.CancelButton.Location = New System.Drawing.Point(184, 226)
            Me.CancelButton.Name = "CancelButton"
            Me.CancelButton.Size = New System.Drawing.Size(75, 23)
            Me.CancelButton.TabIndex = 9
            Me.CancelButton.Text = "Cancel"
            Me.CancelButton.UseVisualStyleBackColor = True
            '
            'ProductEdit
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(289, 261)
            Me.Controls.Add(Me.CancelButton)
            Me.Controls.Add(Me.SaveButton)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.DescriptionTextBox)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.QuantityTextBox)
            Me.Controls.Add(Me.PriceTextBox)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.ProductNameTextBox)
            Me.Name = "ProductEdit"
            Me.Text = "Add a Product"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents ProductNameTextBox As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
        Friend WithEvents QuantityTextBox As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents SaveButton As System.Windows.Forms.Button
        Friend WithEvents CancelButton As System.Windows.Forms.Button
    End Class
End Namespace