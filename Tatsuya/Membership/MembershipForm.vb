Public Class MembershipForm


    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        MembershopRegistration.Show()
        Close()
    End Sub

    Private Sub WithDrawalButton_Click(sender As Object, e As EventArgs) Handles WithDrawalButton.Click
        WithdrawalForm.Show()
        Close()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        MainForm.Show()
        Close()
    End Sub
End Class