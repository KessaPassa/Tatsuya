Public Class LoanoutMainForm

    Public Sub Init()
        IdentityNumber.Text = ""
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click

        Dim items = {IdentityNumber.Text}
        If Provision.IsEmpty(items) Then
            Exit Sub
        End If

        LoanoutDetailForm.Init()
        LoanoutDetailForm.Show()
        Hide()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        MainForm.Show()
        Hide()
    End Sub

    Private Sub IdentityNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IdentityNumber.KeyPress
        If Provision.OnlyNumeric(e) = False Then
            Exit Sub
        End If
    End Sub
End Class