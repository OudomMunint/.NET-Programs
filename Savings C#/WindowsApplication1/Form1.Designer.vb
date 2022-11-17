<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSavings
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
        Me.cmdCalculate = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDeposit = New System.Windows.Forms.TextBox()
        Me.txtInterest = New System.Windows.Forms.TextBox()
        Me.txtMonths = New System.Windows.Forms.TextBox()
        Me.txtFinal = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdCalculate
        '
        Me.cmdCalculate.Location = New System.Drawing.Point(130, 132)
        Me.cmdCalculate.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdCalculate.Name = "cmdCalculate"
        Me.cmdCalculate.Size = New System.Drawing.Size(151, 28)
        Me.cmdCalculate.TabIndex = 0
        Me.cmdCalculate.Text = "&Calculate"
        Me.cmdCalculate.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(130, 219)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(151, 24)
        Me.cmdExit.TabIndex = 1
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Montly Deposit"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Yearly Interest"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 67)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Number fo months"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 93)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Final Balance"
        '
        'txtDeposit
        '
        Me.txtDeposit.Location = New System.Drawing.Point(118, 13)
        Me.txtDeposit.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDeposit.Name = "txtDeposit"
        Me.txtDeposit.Size = New System.Drawing.Size(164, 20)
        Me.txtDeposit.TabIndex = 6
        '
        'txtInterest
        '
        Me.txtInterest.Location = New System.Drawing.Point(118, 39)
        Me.txtInterest.Margin = New System.Windows.Forms.Padding(2)
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.Size = New System.Drawing.Size(164, 20)
        Me.txtInterest.TabIndex = 7
        '
        'txtMonths
        '
        Me.txtMonths.Location = New System.Drawing.Point(118, 63)
        Me.txtMonths.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMonths.Name = "txtMonths"
        Me.txtMonths.Size = New System.Drawing.Size(164, 20)
        Me.txtMonths.TabIndex = 8
        '
        'txtFinal
        '
        Me.txtFinal.Location = New System.Drawing.Point(118, 89)
        Me.txtFinal.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.Size = New System.Drawing.Size(164, 20)
        Me.txtFinal.TabIndex = 9
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(130, 177)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(152, 23)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear Boxes"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmSavings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 266)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtFinal)
        Me.Controls.Add(Me.txtMonths)
        Me.Controls.Add(Me.txtInterest)
        Me.Controls.Add(Me.txtDeposit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdCalculate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmSavings"
        Me.Text = "Savings Account"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCalculate As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDeposit As System.Windows.Forms.TextBox
    Friend WithEvents txtInterest As System.Windows.Forms.TextBox
    Friend WithEvents txtMonths As System.Windows.Forms.TextBox
    Friend WithEvents txtFinal As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As Button
End Class
