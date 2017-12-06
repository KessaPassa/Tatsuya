Public Class WithdrawalForm

    Private Sub WithMembershopButton_Click(sender As Object, e As EventArgs) Handles WithMembershopButton.Click
        WithMembershipForm.Show()
        Hide()
    End Sub

    Private Sub WithIdentityButton_Click(sender As Object, e As EventArgs) Handles WithIdentityButton.Click
        WithIdentityForm.Show()
        Hide()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        MainForm.Show()
        Hide()
    End Sub
End Class