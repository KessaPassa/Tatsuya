Public Class MainForm

    Dim timer As Timer = New Timer

    Private Sub LendButton_Click(sender As Object, e As EventArgs) Handles LendButton.Click
        LoanoutMainForm.Init()
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

'Private Sub hoge()
'    Dim A = 100
'    Dim B = 100
'    Dim C = 100
'    Dim score As Integer = 0
'    Dim counter As Integer() = {0, 0, 0}
'    Dim seed As Integer = Environment.TickCount

'    For turn = 0 To 1000

'        For i = 0 To 10
'            seed += 1
'            Dim r = New Random(seed)
'            Dim dice As Integer = r.Next(6) + 1
'            Debug.Print(dice)

'            Select Case dice
'                Case 1, 2
'                    score = A \ 2 \ 2
'                    B += score
'                    C += score
'                    A -= score * 2

'                Case 3
'                    If B >= 50 Then
'                        score = 50 \ 2
'                    Else
'                        score = B \ 2
'                    End If
'                    A += score
'                    C += score
'                    B -= score * 2

'                Case 4, 5, 6
'                    If dice Mod 2 = 0 Then
'                        score = A
'                        A = C
'                        C = score
'                    Else
'                        score = B
'                        B = C
'                        C = score
'                    End If

'                Case Else
'                    MsgBox("不明")

'            End Select
'            score = 0
'        Next

'        Dim all() As Integer = {A, B, C}
'        Dim winner As Integer = -1
'        For j = 0 To all.Length - 1
'            If all.Max().Equals(all(j)) Then
'                winner = j
'            End If
'        Next
'        Debug.Print("勝者は" & winner)
'        counter(winner) += 1

'    Next

'    Dim result As String = ""
'    For Each item In counter
'        result += item.ToString() & ", "
'    Next
'    MsgBox(result)
'End Sub
