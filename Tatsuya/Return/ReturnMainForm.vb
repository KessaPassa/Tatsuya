Public Class ReturnMainForm

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click

        Dim id = VideoId.Text
        If Provision.IsEmpty({id}) Then
            Exit Sub
        End If

        If Not Provision.IsCount({id}, 6) Then
            Exit Sub
        End If

        Dim loanout As Loanout = DBManager.Fetch(id, DBManager.Type.loanout)
        If loanout Is Nothing Then
            VideoId.Text = ""
            Exit Sub
        End If

        ReturnDetailForm.Show(loanout)
        Close()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        MainForm.Show()
        Close()
    End Sub

    Private Sub VideoId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VideoId.KeyPress
        If Provision.OnlyNumeric(e) = False Then
            Exit Sub
        End If
    End Sub
End Class