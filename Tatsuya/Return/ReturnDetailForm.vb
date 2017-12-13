Public Class ReturnDetailForm

    Sub Init(id As String)
        Dim video As Video = DBManager.Fetch(id, DBManager.Type.video)
        If video Is Nothing Then
            Exit Sub
        End If

        VideoIdGroupBox.Text = "ビデオID: " & id
        IdentityNumber.Text = video.id
        UserName.Text = "ほげ"
        ReturnDays.Text = DateTime.Today.ToString("yyy/MM/dd")
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click

        Dim message As String
        Dim diff = ReturnDays.Text - DateTime.Today.ToString("yyy/MM/dd")
        If diff < 0.0 Then
            '延滞
            message = "延滞"

        Else
            message =
            "返却処理を行います" & Environment.NewLine &
            "以下の内容でよろしいですか" & Environment.NewLine &
            "----" & Environment.NewLine &
            "ビデオID: " & "121212"
        End If

        Dim result As DialogResult = MessageBox.Show(message, "期限内返却", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            MainForm.Show()
            Hide()
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        ReturnMainForm.Show()
        Hide()
    End Sub
End Class