<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMarks
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
        Me.lblAssessmentName = New System.Windows.Forms.Label()
        Me.lblMaxMark = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblMark = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.txtAssessmentName = New System.Windows.Forms.TextBox()
        Me.txtMaxMarks = New System.Windows.Forms.TextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtMarks = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblAssessmentName
        '
        Me.lblAssessmentName.AutoSize = True
        Me.lblAssessmentName.Location = New System.Drawing.Point(43, 26)
        Me.lblAssessmentName.Name = "lblAssessmentName"
        Me.lblAssessmentName.Size = New System.Drawing.Size(92, 13)
        Me.lblAssessmentName.TabIndex = 0
        Me.lblAssessmentName.Text = "Assessment name"
        '
        'lblMaxMark
        '
        Me.lblMaxMark.AutoSize = True
        Me.lblMaxMark.Location = New System.Drawing.Point(43, 80)
        Me.lblMaxMark.Name = "lblMaxMark"
        Me.lblMaxMark.Size = New System.Drawing.Size(82, 13)
        Me.lblMaxMark.TabIndex = 1
        Me.lblMaxMark.Text = "Maximum marks"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(43, 138)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(41, 13)
        Me.lblWeight.TabIndex = 2
        Me.lblWeight.Text = "Weight"
        '
        'lblMark
        '
        Me.lblMark.AutoSize = True
        Me.lblMark.Location = New System.Drawing.Point(43, 202)
        Me.lblMark.Name = "lblMark"
        Me.lblMark.Size = New System.Drawing.Size(75, 13)
        Me.lblMark.TabIndex = 3
        Me.lblMark.Text = "Mark obtained"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(46, 278)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(246, 278)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(46, 368)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(246, 368)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.Location = New System.Drawing.Point(453, 26)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(221, 381)
        Me.lstOutput.TabIndex = 8
        '
        'txtAssessmentName
        '
        Me.txtAssessmentName.Location = New System.Drawing.Point(246, 19)
        Me.txtAssessmentName.Name = "txtAssessmentName"
        Me.txtAssessmentName.Size = New System.Drawing.Size(100, 20)
        Me.txtAssessmentName.TabIndex = 9
        '
        'txtMaxMarks
        '
        Me.txtMaxMarks.Location = New System.Drawing.Point(246, 73)
        Me.txtMaxMarks.Name = "txtMaxMarks"
        Me.txtMaxMarks.Size = New System.Drawing.Size(100, 20)
        Me.txtMaxMarks.TabIndex = 10
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(246, 131)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtWeight.TabIndex = 11
        '
        'txtMarks
        '
        Me.txtMarks.Location = New System.Drawing.Point(246, 195)
        Me.txtMarks.Name = "txtMarks"
        Me.txtMarks.Size = New System.Drawing.Size(100, 20)
        Me.txtMarks.TabIndex = 12
        '
        'frmMarks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtMarks)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.txtMaxMarks)
        Me.Controls.Add(Me.txtAssessmentName)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblMark)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblMaxMark)
        Me.Controls.Add(Me.lblAssessmentName)
        Me.Name = "frmMarks"
        Me.Text = "Course Assessment "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAssessmentName As Label
    Friend WithEvents lblMaxMark As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblMark As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents txtAssessmentName As TextBox
    Friend WithEvents txtMaxMarks As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtMarks As TextBox
End Class
