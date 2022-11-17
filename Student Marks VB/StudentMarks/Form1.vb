'Pannha oudom munint
'c3313933

Option Explicit On
Imports System.Math 'To be able to use mathematical operations
Public Class frmGroceries

    'Variables declared here

    Dim Article As String
    Dim value As Double
    Dim total As Double
    Dim tax As Double
    Dim STotal As String

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clears every box

        txtTotal.Text = "0.00$"
        txtArticle.Text = ""
        txtValue.Text = ""
        ltbGroceries.Items.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Closes application

        Close()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'adds items into list box then displays total price with tax calculated at the total lable

        Article = txtArticle.Text
        value = txtValue.Text
        ltbGroceries.Items.Add(Article & value & "$")
        txtTotal.Text = value * 0.1 + value & "$"

    End Sub

End Class
