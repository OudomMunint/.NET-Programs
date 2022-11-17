<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGroceries
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblGroceries = New System.Windows.Forms.Label()
        Me.lblArticle = New System.Windows.Forms.Label()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.txtArticle = New System.Windows.Forms.TextBox()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ltbGroceries = New System.Windows.Forms.ListBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblGroceries
        '
        Me.lblGroceries.AutoSize = True
        Me.lblGroceries.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGroceries.Location = New System.Drawing.Point(220, 19)
        Me.lblGroceries.Name = "lblGroceries"
        Me.lblGroceries.Size = New System.Drawing.Size(71, 15)
        Me.lblGroceries.TabIndex = 0
        Me.lblGroceries.Text = "My Groceries"
        '
        'lblArticle
        '
        Me.lblArticle.AutoSize = True
        Me.lblArticle.Location = New System.Drawing.Point(56, 68)
        Me.lblArticle.Name = "lblArticle"
        Me.lblArticle.Size = New System.Drawing.Size(36, 13)
        Me.lblArticle.TabIndex = 1
        Me.lblArticle.Text = "Article"
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(56, 115)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(34, 13)
        Me.lblValue.TabIndex = 2
        Me.lblValue.Text = "Value"
        '
        'txtArticle
        '
        Me.txtArticle.Location = New System.Drawing.Point(132, 68)
        Me.txtArticle.Name = "txtArticle"
        Me.txtArticle.Size = New System.Drawing.Size(302, 20)
        Me.txtArticle.TabIndex = 3
        '
        'txtValue
        '
        Me.txtValue.Location = New System.Drawing.Point(132, 115)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(122, 20)
        Me.txtValue.TabIndex = 4
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(359, 115)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add Item"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(59, 355)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(359, 355)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'ltbGroceries
        '
        Me.ltbGroceries.FormattingEnabled = True
        Me.ltbGroceries.Location = New System.Drawing.Point(59, 156)
        Me.ltbGroceries.Name = "ltbGroceries"
        Me.ltbGroceries.Size = New System.Drawing.Size(375, 160)
        Me.ltbGroceries.TabIndex = 8
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lblTotal.Location = New System.Drawing.Point(184, 332)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(117, 15)
        Me.lblTotal.TabIndex = 9
        Me.lblTotal.Text = " TOTAL ($) GST Inc. "
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(187, 357)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(114, 20)
        Me.txtTotal.TabIndex = 10
        '
        'frmGroceries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.ltbGroceries)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.txtArticle)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.lblArticle)
        Me.Controls.Add(Me.lblGroceries)
        Me.Name = "frmGroceries"
        Me.Text = "Groceries list"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGroceries As Label
    Friend WithEvents lblArticle As Label
    Friend WithEvents lblValue As Label
    Friend WithEvents txtArticle As TextBox
    Friend WithEvents txtValue As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ltbGroceries As ListBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As TextBox
End Class
