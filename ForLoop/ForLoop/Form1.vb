Public Class Form1
    Private Sub btnShowNumbers_Click(sender As Object, e As EventArgs) Handles btnShowNumbers.Click
        lblNumbers.Text = ""

        For i As Integer = 1 To 10
            lblNumbers.Text &= i.ToString() & " "  ' Append each number to the label with a space
        Next
    End Sub
End Class
