Public Class Form1
    'para sa computation
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        PerformOperation("+")
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        PerformOperation("-")
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        PerformOperation("*")
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        PerformOperation("/")
    End Sub

    Private Sub PerformOperation(operation As String)
        Try
            Dim value1 As Integer = Integer.Parse(txtValue1.Text)
            Dim isEstimate1 As Boolean = chkEstimate1.Checked
            Dim value2 As Integer = Integer.Parse(txtValue2.Text)
            Dim isEstimate2 As Boolean = chkEstimate2.Checked
            Dim num1 As New EstimatedInteger(value1, isEstimate1)
            Dim num2 As New EstimatedInteger(value2, isEstimate2)

            Dim result As EstimatedInteger = Nothing
            Select Case operation
                Case "+"
                    result = num1 + num2
                Case "-"
                    result = num1 - num2
                Case "*"
                    result = num1 * num2
                Case "/"
                    result = num1 / num2
            End Select

            lblResult.Text = "Result: " & result.ToString()

        Catch ex As Exception
            'baka masira, lalagay dito error result
            MessageBox.Show("Error: " & ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
