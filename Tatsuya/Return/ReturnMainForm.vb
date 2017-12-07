Public Class ReturnMainForm

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click

        Dim items = {VideoId.Text}
        If Provision.IsEmpty(items) Then
            Exit Sub
        End If

        ReturnDetailForm.Init()
        ReturnDetailForm.Show()
        Hide()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        MainForm.Show()
        Hide()
    End Sub

    Private Sub VideoId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VideoId.KeyPress
        If Provision.OnlyNumeric(e) = False Then
            Exit Sub
        End If
    End Sub
End Class