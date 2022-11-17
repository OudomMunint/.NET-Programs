'By pannha oudom munint
'FCOM 101
'c3313933


Public Class FrmMarks


    'Structue that will store an assessment informatiom
    Structure Assessment
        Dim aName As String          'Name of the assessment
        Dim maxMark As Double        'maximum marks that can be obtained
        Dim aWeight As Double        'weight of the assessment
        Dim aMark As Double          'Marks obtained 
        Dim wMark As Double          'calculate the mark obtained and the weight
    End Structure

    Dim total As Double = 0
    Dim i As Integer = 0

    Dim Assess(9) As Assessment


    Private Sub FrmMarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    'Clear button and empties all information

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAssessmentName.Text = ""
        txtMaxMarks.Text = ""
        txtWeight.Text = ""
        txtMarks.Text = ""
        lstOutput.Items.Clear()

        total = 0
        For counter As Integer = 0 To i
            assess(counter).aName = ""
            assess(counter).maxMark = 0
            assess(counter).aWeight = 0
            assess(counter).aMark = 0
            assess(counter).wMark = 0
        Next counter
        i = 0
    End Sub

    'Add information into array and output
    Dim Display As String

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        assess(i).aName = txtAssessmentName.Text
        assess(i).maxMark = CDbl(Val(txtMaxMarks.Text))
        assess(i).aWeight = CDbl(Val(txtWeight.Text))
        assess(i).aMark = CDbl(Val(txtMarks.Text))

        assess(i).wMark = assess(i).aMark / assess(i).maxMark * assess(i).aWeight
        total = total + assess(i).wMark
        Display = Display & assess(i).aName & " " & assess(i).aMark * "/" & assess(i).maxMark & assess(i).aWeight & " " & assess(i).wMark
        lstOutput.Items.Add(Display)
        i = i + 1
        If i = 10 Then
            btnAdd.Enabled = False
        End If
    End Sub

    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim current As Double = 0

        For counter As Integer = 0 To i - 1
            current += assess(i).aWeight
        Next
        current = total / current

        lstOutput.Items.Add("current Mark" & current & "     " & "Total Mark" & total)
    End Sub
End Class
