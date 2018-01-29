Public Class WitClosentityForm

    Private Sub WitClosentityForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Provision.AddIdentityState(IdentityState)
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click

        Dim items() = {IdentityNumber.Text, IdentityState.SelectedIndex, UserName.Text}
        If Provision.IsEmpty(items) Then
            Exit Sub
        End If

        Dim user As User = DBManager.FetchIdentity(IdentityNumber.Text, IdentityState.SelectedItem, UserName.Text)
        If user Is Nothing Then
            Exit Sub
        End If

        Dim result As Boolean = user.IsShownWithdraw()
        If result Then
            MsgBox("退会処理を行いました", MsgBoxStyle.OkOnly, "退会完了")
            DBManager.Delete(user.id, DBManager.Type.user)
            MainForm.Show()
            Close()
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        WithdrawalForm.Show()
        Close()
    End Sub

    Private Sub IdentityNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IdentityNumber.KeyPress
        If Provision.OnlyNumeric(e) = False Then
            Exit Sub
        End If
    End Sub
End Class