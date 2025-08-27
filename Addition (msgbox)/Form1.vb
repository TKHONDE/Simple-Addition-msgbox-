Public Class Form1
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtfirstnum.Clear()
        txtsecondnum.Clear()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnresult_Click(sender As Object, e As EventArgs) Handles btnresult.Click
        Dim num1 As Double = txtfirstnum.Text
        Dim num2 As Double = txtsecondnum.Text
        Dim result As Double = num1 + num2
        If result = result Then
            MsgBox(result)
        Else
            MsgBox("Invalid Input")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AcceptButton = btnresult
    End Sub
End Class
