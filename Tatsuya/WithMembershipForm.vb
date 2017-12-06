Public Class WithMembershipForm

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        Dim id As String = TextBox1.Text

        'メッセージボックス表示
        Dim message As String =
            "会員番号: " & DBManager.id & Environment.NewLine &
            "----" & Environment.NewLine &
            "身分証明書: " & DBManager.identityNumber & Environment.NewLine &
            "身分証種別: " & DBManager.identityState & Environment.NewLine &
            "氏名: " & DBManager.name & Environment.NewLine &
            "性別: " & DBManager.jender & Environment.NewLine &
            "生年月日: " & DBManager.birthday & Environment.NewLine &
            "電話番号: " & DBManager.tel & Environment.NewLine &
            "郵便番号: " & DBManager.addressNumber & Environment.NewLine &
            "住所: " & DBManager.addressContent & Environment.NewLine &
            "----" & Environment.NewLine &
            "以上の情報を解約してよろしいですか？"
        Dim result As DialogResult = MessageBox.Show(message, "会員情報確認", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
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