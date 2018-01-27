Public Class ReturnDetailForm

    Public Overloads Sub Show(loanout As Loanout)
        VideoIdGroupBox.Text = "ビデオID: " & loanout.video_id
        IdentityNumber.Text = loanout.user_id
        UserName.Text = loanout.ConvertUser().name
        ReturnDays.Text = loanout.that_date
        MyBase.Show()
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click

        Dim title As String
        Dim message As String
        Dim diff = (CType(ReturnDays.Text, Date) - Date.Today).TotalDays
        If diff < 0.0 Then
            title = "延滞返却"
            message =
                "以下の内容を確認後、延滞料を徴収してください。" & Environment.NewLine &
                "----" & Environment.NewLine &
                "返却予定日" & ReturnDays.Text & Environment.NewLine &
                "延滞料: " & -CType(diff, Integer) * 300 & "円"
        Else
            title = "期限内返却"
            message =
                "返却処理を行います" & Environment.NewLine &
                "以下の内容でよろしいですか" & Environment.NewLine &
                "----" & Environment.NewLine &
                VideoIdGroupBox.Text
        End If

        Dim result As DialogResult = MessageBox.Show(message, title, MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            MsgBox("返却完了" & Environment.NewLine & "----" & Environment.NewLine & VideoIdGroupBox.Text, MsgBoxStyle.OkOnly, "返却処理終了")
            MainForm.Show()
            Close()
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        ReturnMainForm.Show()
        Close()
    End Sub
End Class