Public Class WithdrawalForm

    Private Sub WithMembershopButton_Click(sender As Object, e As EventArgs) Handles WithMembershopButton.Click
        WithMembershipForm.Show()
        Close()
    End Sub

    Private Sub WitClosentityButton_Click(sender As Object, e As EventArgs) Handles WitClosentityButton.Click
        WitClosentityForm.Show()
        Close()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        MainForm.Show()
        Close()
    End Sub
End Class