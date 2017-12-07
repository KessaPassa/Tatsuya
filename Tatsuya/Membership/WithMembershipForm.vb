Public Class WithMembershipForm

    Public Sub Init()
        IdentityNumber.Text = ""
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click

        Dim items = {IdentityNumber.Text}
        If Provision.IsEmpty(items) Then
            Exit Sub
        End If

        Dim id As String = IdentityNumber.Text
        Dim result As Boolean = DBManager.IsShownWithdraw()
        If result Then
            MsgBox("退会処理を行いました", MsgBoxStyle.OkOnly, "退会完了")
            DBManager.Delete()
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