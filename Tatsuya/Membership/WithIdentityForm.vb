Public Class WithIdentityForm

    Private Sub WithIdentityForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Provision.AddItem(IdentityState)
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
End Class