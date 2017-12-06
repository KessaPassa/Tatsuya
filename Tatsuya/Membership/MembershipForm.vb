Public Class MembershipForm


    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        MembershopRegistration.Init()
        MembershopRegistration.Show()
        Hide()
    End Sub

    Private Sub WithDrawalButton_Click(sender As Object, e As EventArgs) Handles WithDrawalButton.Click
        WithdrawalForm.Show()
        Hide()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        MainForm.Show()
        Hide()
    End Sub
End Class