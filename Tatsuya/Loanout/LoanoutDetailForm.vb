Public Class LoanoutDetailForm

    Dim newTextBox As TextBox
    Dim newLabel As Label
    Dim newComboBox As ComboBox
    Dim newButton As Button

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
        newButton = DeleteButton
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

                AddTable()
            End If
        End If
    End Sub

    Private Sub LoanoutDays_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LoanoutDays.SelectedIndexChanged

        Dim text = LoanoutDays.SelectedItem
        Dim loanout = Provision.loanoutDays
        For i = 0 To loanout.GetLength(0) - 1
            If text = loanout(i).days Then
                ReturnDays.Text = DateTime.Today + New TimeSpan(loanout(i).limit, 0, 0, 0)
            End If
        Next
    End Sub

    Private Sub AddTable()
        Dim transform = TableLayoutPanel.Size
        transform.Height += 24
        TableLayoutPanel.Size = transform
        TableLayoutPanel.RowCount += 1


    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

        sender.Visible = False
        Dim table = TableLayoutPanel
        Dim child As Control = Nothing
        Dim row
        For row = 0 To table.RowCount - 1
            child = table.GetControlFromPosition(7, row)
            If Not (child Is Nothing) Then
                If child.Visible = False Then
                    Exit For
                End If
            End If
        Next
        sender.Visible = True
        If child Is Nothing Then
            Exit Sub
        End If

        For x = 0 To table.ColumnCount
            Dim column = table.GetControlFromPosition(x, row)
            TableLayoutPanel.Controls.Remove(column)
        Next
    End Sub
End Class