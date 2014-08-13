<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerForm
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
        Me.lblProducts = New System.Windows.Forms.Label()
        Me.lstProducts = New System.Windows.Forms.ListBox()
        Me.btnHist = New System.Windows.Forms.Button()
        Me.pnlButtons = New System.Windows.Forms.Panel()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.pnlDetails = New System.Windows.Forms.Panel()
        Me.lblQuan = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.txtQuan = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.pnlButtons.SuspendLayout()
        Me.pnlDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblProducts
        '
        Me.lblProducts.AutoSize = True
        Me.lblProducts.Location = New System.Drawing.Point(-168, 17)
        Me.lblProducts.Name = "lblProducts"
        Me.lblProducts.Size = New System.Drawing.Size(66, 13)
        Me.lblProducts.TabIndex = 14
        Me.lblProducts.Text = "our products"
        '
        'lstProducts
        '
        Me.lstProducts.FormattingEnabled = True
        Me.lstProducts.Location = New System.Drawing.Point(-169, 36)
        Me.lstProducts.Name = "lstProducts"
        Me.lstProducts.Size = New System.Drawing.Size(120, 277)
        Me.lstProducts.TabIndex = 13
        '
        'btnHist
        '
        Me.btnHist.Location = New System.Drawing.Point(404, 292)
        Me.btnHist.Name = "btnHist"
        Me.btnHist.Size = New System.Drawing.Size(122, 23)
        Me.btnHist.TabIndex = 20
        Me.btnHist.Text = "Order History"
        Me.btnHist.UseVisualStyleBackColor = True
        '
        'pnlButtons
        '
        Me.pnlButtons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlButtons.Controls.Add(Me.txtNum)
        Me.pnlButtons.Controls.Add(Me.btnCheckout)
        Me.pnlButtons.Controls.Add(Me.btnOrder)
        Me.pnlButtons.Location = New System.Drawing.Point(404, 259)
        Me.pnlButtons.Name = "pnlButtons"
        Me.pnlButtons.Size = New System.Drawing.Size(204, 29)
        Me.pnlButtons.TabIndex = 19
        Me.pnlButtons.Visible = False
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(4, 5)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(36, 20)
        Me.txtNum.TabIndex = 1
        Me.txtNum.Text = "1"
        Me.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnCheckout
        '
        Me.btnCheckout.Location = New System.Drawing.Point(127, 3)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(75, 23)
        Me.btnCheckout.TabIndex = 0
        Me.btnCheckout.Text = "Checkout"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'btnOrder
        '
        Me.btnOrder.Location = New System.Drawing.Point(46, 3)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnOrder.TabIndex = 0
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'pnlDetails
        '
        Me.pnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDetails.Controls.Add(Me.lblQuan)
        Me.pnlDetails.Controls.Add(Me.lblPrice)
        Me.pnlDetails.Controls.Add(Me.lblDesc)
        Me.pnlDetails.Controls.Add(Me.txtQuan)
        Me.pnlDetails.Controls.Add(Me.txtPrice)
        Me.pnlDetails.Controls.Add(Me.txtDesc)
        Me.pnlDetails.Location = New System.Drawing.Point(149, 36)
        Me.pnlDetails.Name = "pnlDetails"
        Me.pnlDetails.Size = New System.Drawing.Size(462, 141)
        Me.pnlDetails.TabIndex = 18
        Me.pnlDetails.Visible = False
        '
        'lblQuan
        '
        Me.lblQuan.AutoSize = True
        Me.lblQuan.Location = New System.Drawing.Point(415, 93)
        Me.lblQuan.Name = "lblQuan"
        Me.lblQuan.Size = New System.Drawing.Size(44, 13)
        Me.lblQuan.TabIndex = 1
        Me.lblQuan.Text = "quantity"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(429, 48)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(30, 13)
        Me.lblPrice.TabIndex = 1
        Me.lblPrice.Text = "price"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Location = New System.Drawing.Point(401, 4)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(58, 13)
        Me.lblDesc.TabIndex = 1
        Me.lblDesc.Text = "description"
        '
        'txtQuan
        '
        Me.txtQuan.Location = New System.Drawing.Point(368, 109)
        Me.txtQuan.Name = "txtQuan"
        Me.txtQuan.ReadOnly = True
        Me.txtQuan.Size = New System.Drawing.Size(91, 20)
        Me.txtQuan.TabIndex = 0
        Me.txtQuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(368, 64)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(91, 20)
        Me.txtPrice.TabIndex = 0
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(3, 20)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.ReadOnly = True
        Me.txtDesc.Size = New System.Drawing.Size(456, 20)
        Me.txtDesc.TabIndex = 0
        Me.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "our products"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(22, 36)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 277)
        Me.ListBox1.TabIndex = 16
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(533, 292)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(75, 23)
        Me.btnLogOut.TabIndex = 15
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'CustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 332)
        Me.Controls.Add(Me.btnHist)
        Me.Controls.Add(Me.pnlButtons)
        Me.Controls.Add(Me.pnlDetails)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.lblProducts)
        Me.Controls.Add(Me.lstProducts)
        Me.Name = "CustomerForm"
        Me.Text = "CheckoutForm"
        Me.pnlButtons.ResumeLayout(False)
        Me.pnlButtons.PerformLayout()
        Me.pnlDetails.ResumeLayout(False)
        Me.pnlDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblProducts As System.Windows.Forms.Label
    Friend WithEvents lstProducts As System.Windows.Forms.ListBox
    Friend WithEvents btnHist As System.Windows.Forms.Button
    Friend WithEvents pnlButtons As System.Windows.Forms.Panel
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents btnCheckout As System.Windows.Forms.Button
    Friend WithEvents btnOrder As System.Windows.Forms.Button
    Friend WithEvents pnlDetails As System.Windows.Forms.Panel
    Friend WithEvents lblQuan As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents txtQuan As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
End Class
