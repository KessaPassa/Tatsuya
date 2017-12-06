Public Class LoanoutDetailForm

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        LoanoutMainForm.Show()
        Hide()
    End Sub
End Class