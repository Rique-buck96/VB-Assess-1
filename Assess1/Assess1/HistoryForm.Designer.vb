<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoryForm
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
        Me.lstProducts = New System.Windows.Forms.ListBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lstOrderDates = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lstProducts
        '
        Me.lstProducts.FormattingEnabled = True
        Me.lstProducts.Location = New System.Drawing.Point(171, 12)
        Me.lstProducts.Name = "lstProducts"
        Me.lstProducts.Size = New System.Drawing.Size(207, 121)
        Me.lstProducts.TabIndex = 5
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(273, 176)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(105, 23)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back To Shop"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lstOrderDates
        '
        Me.lstOrderDates.FormattingEnabled = True
        Me.lstOrderDates.Location = New System.Drawing.Point(14, 13)
        Me.lstOrderDates.Name = "lstOrderDates"
        Me.lstOrderDates.Size = New System.Drawing.Size(151, 186)
        Me.lstOrderDates.TabIndex = 3
        '
        'HistoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 215)
        Me.Controls.Add(Me.lstProducts)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lstOrderDates)
        Me.Name = "HistoryForm"
        Me.Text = "HistoryForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstProducts As System.Windows.Forms.ListBox
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lstOrderDates As System.Windows.Forms.ListBox
End Class
