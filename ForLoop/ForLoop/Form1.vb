Public Class Form1
    ' Event handler for button click
    Private Sub btnShowNumbers_Click(sender As Object, e As EventArgs) Handles btnShowNumbers.Click
        ' Clear previous content
        lblNumbers.Text = ""

        ' For loop to display numbers from 1 to 10
        For i As Integer = 1 To 10
            lblNumbers.Text &= i.ToString() & " "  ' Append each number to the label with a space
        Next
    End Sub
End Class
