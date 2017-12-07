Public Class LoanoutDetailForm

    Dim newTextBox As TextBox
    Dim newLabel As Label
    Dim newComboBox As ComboBox

    Public Sub Init()
        IdentityNuber.Text = DBManager.id
        UserName.Text = DBManager.name
        Dim split() As String = DBManager.birthday.Split("/")
        Dim birthday = New DateTime(split(0), split(1), split(2))
        UserAge.Text = Int((DateTime.Today - birthday).TotalDays / 365) & "歳"

        VideoNumber.Text = ""
        Title.Text = ""
        LimitedAge.Text = ""
        NowTime.Text = DateTime.Today.ToString("yyy/MM/dd")
        LoanoutDays.SelectedIndex = -1
        ReturnDays.Text = ""
        Pay.Text = ""

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

        newTextBox = VideoNumber
        newLabel = Title
        newComboBox = LoanoutDays
    End Sub

    Private Sub VideoNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VideoNumber.KeyPress

        If Provision.OnlyNumeric(e) = False Then
            Exit Sub
        Else
            Dim videoId As String = sender.Text
            If videoId.Length = 6 Then
                Dim video = New Video("123321", "工房大乱闘", "18禁")
                Title.Text = video.title
                LimitedAge.Text = video.limitedAge

                'TableLayoutPanel.RowCount += 1

            End If
        End If
    End Sub

    Private Sub LoanoutDays_SelectedIndexChanged(sender As Object, e As EventArgs)

        Dim text = LoanoutDays.SelectedItem
        Dim loanout = Provision.loanoutDays
        For i = 0 To loanout.GetLength(0)
            If text = loanout(i).days Then
                ReturnDays.Text = loanout(i).limit
            End If
        Next
    End Sub
End Class