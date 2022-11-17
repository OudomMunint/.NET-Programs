'By pannha oudom munint
'C3313933
'Metric to Imperial converter

Imports System.Math


Public Class Form1

    'Closes the application

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clears all input and out put boxes

        txtMetric.Text = ""
        txtImperial.Text = ""
        txtConvertType.Text = ""
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        'Variables
        Dim L As String
        Dim length As Double
        Dim C As String
        Dim Celsius As Double
        'Reads from txtbox to determine which conversion to do, C or L
        C = CDbl(Val(txtMetric.Text))
        L = CDbl(Val(txtMetric.Text))

        If L > 0 Then

            'converts length from meter to feet
            length = L * 3.281
            txtImperial.Text = length
            txtConvertType.Text = "L"
        Else

            'Convert temperature from Celsius to Farenheit
            Celsius = celsiusToFarenheit(C)
            txtImperial.Text = Celsius
            txtConvertType.Text = "C"

        End If

        'Says "Work in progress" when conditions are not met
        If L < 0 Then
            Console.WriteLine("Work In progress")
        End If


    End Sub

    'Function to convert tempurature 
    Function celsiusToFarenheit(ByVal C As Double) As Double

        Return C * 1.8 + 32
    End Function

    'Function to convert Length
    Function Length(ByVal L As Double) As Double
        Return L * 3.281
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
