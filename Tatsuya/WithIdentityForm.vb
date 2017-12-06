Public Class WithIdentityForm

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        WithdrawalForm.Show()
        Hide()
    End Sub
End Class