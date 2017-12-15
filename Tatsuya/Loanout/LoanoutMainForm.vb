Public Class LoanoutMainForm

    Public Sub Init()
        IdentityNumber.Text = ""
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click

        Dim id As String = IdentityNumber.Text
        If Provision.IsEmpty({id}) Then
            Exit Sub
        End If

        If Not Provision.IsCount({id}, 6) Then
            Exit Sub
        End If

        Dim user As User = DBManager.Fetch(id, DBManager.Type.user)
        If user Is Nothing Then
            IdentityNumber.Text = ""
            Exit Sub
        End If
        LoanoutDetailForm.Init(user)
        LoanoutDetailForm.Show()
        Hide()
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        MainForm.Show()
        Hide()
    End Sub

    Private Sub IdentityNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IdentityNumber.KeyPress
        If Provision.OnlyNumeric(e) = False Then
            Exit Sub
        End If
    End Sub
End Class