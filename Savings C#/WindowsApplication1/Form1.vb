Option Explicit On
Public Class frmSavings
    Dim Deposit As Double
    Dim Interest As Double
    Dim Months As Integer
    Dim Final As Double
    Const vbKeyDecPt = 46

    Sub Months(ByRef M As Integer, ByVal I As Double, ByVal D As Double, ByVal F As Double)
        M = Math.Log(F * I / D + 1) / Math.Log(1 + I)
    End Sub

    Private Sub cmdCalculate_Click(sender As Object, e As EventArgs) Handles cmdCalculate.Click
        Dim IntRate As Double
        Dim IntNew As Double
        Dim Fcn As Double, FcnD As Double
        'Read	values	from	text	boxes	
        Deposit = CDbl(Val(txtDeposit.Text))
        IntRate = CDbl(Val(txtInterest.Text)) / 1200
        Months = CInt(Val(txtMonths.Text))
        Final = CDbl(Val(txtFinal.Text))
        'Determine which box is blank
        'Compute that missing value and put in text box
        If txtDeposit.Text = "" Then
            'Deposit missing
            Deposit = Final / (((1 + IntRate) ^ Months - 1) / IntRate)
            txtDeposit.Text = Format(Deposit, "#####0.00")
        ElseIf txtInterest.Text = "" Then
            'Interest missing - requires loop
            IntNew = (Final / (0.5 * Months * Deposit) - 1) / Months
            Do
                IntRate = IntNew
                Fcn = (1 + IntRate) ^ Months - Final * IntRate / Deposit - 1
                FcnD = Months * (1 + IntRate) ^ (Months - 1) - Final / Deposit
                IntNew = IntRate - Fcn / FcnD
            Loop Until Math.Abs(IntNew - IntRate) < 0.00001 / 12
            Interest = IntNew * 1200
            txtInterest.Text = Format(Interest, "##0.00")
        ElseIf txtMonths.Text = "" Then
            'Months missing
            Months = Months(Months, IntRate, Deposit, Final)
            txtMonths.Text = Format(Months, "###.0")
        ElseIf txtFinal.Text = "" Then
            'Final value missing
            Final = Deposit * ((1 + IntRate) ^ Months - 1) / IntRate
            txtFinal.Text = Format(Final, "#####0.00")
        End If
    End Sub

    Private Sub txtInterest_KeyPress(sender As Object, e As KeyPressEventArgs) Handles _
        txtDeposit.KeyPress, txtInterest.KeyPress, txtMonths.KeyPress
        'Only allow number keys, decimal point, or backspace      'Or KeyAscii = vbKeyDecPt Or KeyAscii = 8

        If (e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = "." Or e.KeyChar = Chr(8) Then
            Exit Sub
        Else
            e.KeyChar = "0"
            Beep()
        End If

    End Sub
    Private Function calculateFinal(ByVal Deposit As Double, ByVal intRate As Double, ByVal Months As Integer) As Double
        Final = (Deposit * ((1 + intRate) ^ Months - 1) / intRate)
        Return Final
    End Function
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDeposit.Text = ""
        txtInterest.Text = ""
        txtMonths.Text = ""
        txtFinal.Text = ""
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtFinal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFinal.KeyPress
        If (e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = "vbKeyDecPt" Or e.KeyChar = "vbKeyBack" Then
            Exit Sub

        Else
            e.KeyChar = ""
            Beep()
        End If
    End Sub


End Class