Public Class LoanoutDetailForm

    Public Sub Init()
        IdentityNuber.Text = DBManager.id
        UserName.Text = DBManager.name
        Dim split() As String = DBManager.birthday.Split("/")
        Dim birthday = New DateTime(split(0), split(1), split(2))
        UserAge.Text = Int((DateTime.Today - birthday).TotalDays / 365) & "歳"


    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        LoanoutMainForm.Init()
        LoanoutMainForm.Show()
        Hide()
    End Sub

    Private Sub LoanoutDetailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Provision.AddLoanoutDays(LoanoutDays)
    End Sub

    Private Sub VideoNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VideoNumber.KeyPress

        If Provision.OnlyNumeric(e) = False Then
            Exit Sub
        Else
            Dim videoId As String = sender.Text
            If videoId.Length = 6 Then
                Title.Text = DBManager.ConvertIdToString(videoId)
            End If
        End If


    End Sub
End Class