Public Class ReturnDetailForm

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        ReturnMainForm.Show()
        Hide()
    End Sub
End Class