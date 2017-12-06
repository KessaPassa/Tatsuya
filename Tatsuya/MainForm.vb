Public Class MainForm

    Dim timer As Timer = New Timer

    Private Sub LendButton_Click(sender As Object, e As EventArgs) Handles LendButton.Click
        LoanoutMainForm.Show()
        Hide()
    End Sub

    Private Sub MemberButton_Click(sender As Object, e As EventArgs) Handles MemberButton.Click
        MembershipForm.Show()
        Hide()
    End Sub

    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        ReturnMainForm.Show()
        Hide()
    End Sub

    Private Sub ProductButton_Click(sender As Object, e As EventArgs) Handles ProductButton.Click

    End Sub

    Private Sub MainForm_Actived(sender As Object, e As EventArgs) Handles MyBase.Activated
        InitializeTimer()
    End Sub

    Private Sub InitializeTimer()
        AddHandler timer.Tick, New EventHandler(AddressOf RealTimeClock)
        timer.Interval = 1000
        timer.Enabled = True
    End Sub

    Private Sub RealTimeClock(sender As Object, e As EventArgs)
        TimerLabel.Text = DateTime.Now.ToString("yyyy/MM/dd (ddd) HH:mm:ss")
    End Sub
End Class
