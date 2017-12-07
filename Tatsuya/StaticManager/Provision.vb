Public Class Provision

    Private Const CHECK_MESSAGE = "入力されていない項目があります"

    Private Shared Property identityState As String() = {
        "保険証",
        "免許証"
    }

    Public Shared Property loanoutDays As Loanout() = {
        New Loanout("1泊2日", 200, 1),
        New Loanout("2泊3日", 300, 2),
        New Loanout("6泊7日", 400, 6)
    }

    Public Shared Sub AddIdentityState(ByVal comboBox As ComboBox)

        Dim items = identityState
        For Each item In items
            comboBox.Items.Add(item)
        Next
    End Sub

    Public Shared Sub AddLoanoutDays(ByVal comboBox As ComboBox)

        For i = 0 To loanoutDays.GetLength(0) - 1
            comboBox.Items.Add(loanoutDays(i).days)
        Next
    End Sub

    '入力されていないか調べる
    Public Shared Function IsEmpty(items() As Object, Optional message As String = CHECK_MESSAGE)

        For Each item In items
            If item.Equals("") Or item.Equals(-1) Or item.Equals(False) Then
                MsgBox(message)
                IsEmpty = True
                Exit Function
            End If
        Next

        IsEmpty = False
    End Function

    '押されたキーが 0～9でない場合は、イベントをキャンセルする
    Public Shared Function OnlyNumeric(e As KeyPressEventArgs)
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            e.Handled = True
            OnlyNumeric = False
        End If

        OnlyNumeric = True
    End Function
End Class
