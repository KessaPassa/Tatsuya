Public Class ReturnMainForm

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        ReturnDetailForm.Show()
        Hide()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        MainForm.Show()
        Hide()
    End Sub
End Class