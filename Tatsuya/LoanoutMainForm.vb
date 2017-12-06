Public Class LoanoutMainForm

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        LoanoutDetailForm.Show()
        Hide()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        MainForm.Show()
        Hide()
    End Sub
End Class