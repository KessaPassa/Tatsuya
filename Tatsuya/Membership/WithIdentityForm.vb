Public Class WithIdentityForm

    Private Sub WithIdentityForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Provision.AddIdentityState(IdentityState)
    End Sub

    Public Sub Init()
        IdentityNumber.Text = ""
        IdentityState.SelectedIndex = -1
        UserName.Text = ""
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click

        Dim items() = {IdentityNumber.Text, IdentityState.SelectedIndex, UserName.Text}
        If Provision.IsEmpty(items) Then
            Exit Sub
        End If

        Dim id As String = IdentityNumber.Text
        Dim result As Boolean = DBManager.instance.users(0).IsShownWithdraw()
        If result Then
            MsgBox("退会処理を行いました", MsgBoxStyle.OkOnly, "退会完了")
            DBManager.instance.Delete(id, DBManager.Type.user)
            MainForm.Show()
            Hide()
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        WithdrawalForm.Show()
        Hide()
    End Sub

    Private Sub IdentityNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IdentityNumber.KeyPress
        If Provision.OnlyNumeric(e) = False Then
            Exit Sub
        End If
    End Sub
End Class