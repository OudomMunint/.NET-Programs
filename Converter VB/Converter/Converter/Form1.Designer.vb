<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblMetric = New System.Windows.Forms.Label()
        Me.lblImperial = New System.Windows.Forms.Label()
        Me.lblMeters = New System.Windows.Forms.Label()
        Me.lblFeet = New System.Windows.Forms.Label()
        Me.lblConvertType = New System.Windows.Forms.Label()
        Me.txtMetric = New System.Windows.Forms.TextBox()
        Me.txtConvertType = New System.Windows.Forms.TextBox()
        Me.txtImperial = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMetric
        '
        Me.lblMetric.AutoSize = True
        Me.lblMetric.Location = New System.Drawing.Point(80, 31)
        Me.lblMetric.Name = "lblMetric"
        Me.lblMetric.Size = New System.Drawing.Size(36, 13)
        Me.lblMetric.TabIndex = 0
        Me.lblMetric.Text = "Metric"
        '
        'lblImperial
        '
        Me.lblImperial.AutoSize = True
        Me.lblImperial.Location = New System.Drawing.Point(80, 104)
        Me.lblImperial.Name = "lblImperial"
        Me.lblImperial.Size = New System.Drawing.Size(43, 13)
        Me.lblImperial.TabIndex = 1
        Me.lblImperial.Text = "Imperial"
        '
        'lblMeters
        '
        Me.lblMeters.AutoSize = True
        Me.lblMeters.Location = New System.Drawing.Point(384, 31)
        Me.lblMeters.Name = "lblMeters"
        Me.lblMeters.Size = New System.Drawing.Size(39, 13)
        Me.lblMeters.TabIndex = 2
        Me.lblMeters.Text = "Meters"
        '
        'lblFeet
        '
        Me.lblFeet.AutoSize = True
        Me.lblFeet.Location = New System.Drawing.Point(384, 104)
        Me.lblFeet.Name = "lblFeet"
        Me.lblFeet.Size = New System.Drawing.Size(28, 13)
        Me.lblFeet.TabIndex = 3
        Me.lblFeet.Text = "Feet"
        '
        'lblConvertType
        '
        Me.lblConvertType.AutoSize = True
        Me.lblConvertType.Location = New System.Drawing.Point(154, 197)
        Me.lblConvertType.Name = "lblConvertType"
        Me.lblConvertType.Size = New System.Drawing.Size(87, 13)
        Me.lblConvertType.TabIndex = 4
        Me.lblConvertType.Text = "Conversion Type"
        '
        'txtMetric
        '
        Me.txtMetric.Location = New System.Drawing.Point(211, 24)
        Me.txtMetric.Name = "txtMetric"
        Me.txtMetric.Size = New System.Drawing.Size(100, 20)
        Me.txtMetric.TabIndex = 5
        '
        'txtConvertType
        '
        Me.txtConvertType.Location = New System.Drawing.Point(283, 190)
        Me.txtConvertType.Name = "txtConvertType"
        Me.txtConvertType.Size = New System.Drawing.Size(100, 20)
        Me.txtConvertType.TabIndex = 6
        '
        'txtImperial
        '
        Me.txtImperial.Location = New System.Drawing.Point(211, 97)
        Me.txtImperial.Name = "txtImperial"
        Me.txtImperial.Size = New System.Drawing.Size(100, 20)
        Me.txtImperial.TabIndex = 7
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(245, 262)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 8
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(83, 292)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(387, 292)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtImperial)
        Me.Controls.Add(Me.txtConvertType)
        Me.Controls.Add(Me.txtMetric)
        Me.Controls.Add(Me.lblConvertType)
        Me.Controls.Add(Me.lblFeet)
        Me.Controls.Add(Me.lblMeters)
        Me.Controls.Add(Me.lblImperial)
        Me.Controls.Add(Me.lblMetric)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMetric As Label
    Friend WithEvents lblImperial As Label
    Friend WithEvents lblMeters As Label
    Friend WithEvents lblFeet As Label
    Friend WithEvents lblConvertType As Label
    Friend WithEvents txtMetric As TextBox
    Friend WithEvents txtConvertType As TextBox
    Friend WithEvents txtImperial As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
