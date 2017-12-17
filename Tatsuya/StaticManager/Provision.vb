Imports Microsoft.VisualBasic

Public Class Provision

    Private Const EMPTY_MESSAGE = "入力されていない項目があります"
    Private Const COUNT_MESSAGE = "文字数が足りない項目があります"

    Private Shared Property identityState As String() = {
        "保険証",
        "免許証"
    }

    Public Shared Property LendDays As LendData() = {
        New LendData("1泊2日", 1, 200),
        New LendData("2泊3日", 2, 300),
        New LendData("6泊7日", 6, 400)
    }

    Public Shared Sub AddIdentityState(ByVal comboBox As ComboBox)

        Dim items = identityState
        For Each item In items
            comboBox.Items.Add(item)
        Next
    End Sub

    Public Shared Sub AddLoanoutDays(ByVal comboBox As ComboBox)

        For i = 0 To LendDays.GetLength(0) - 1
            comboBox.Items.Add(LendDays(i).days)
        Next
    End Sub

    '入力されていないか調べる
    Public Shared Function IsEmpty(items() As Object, Optional message As String = EMPTY_MESSAGE)

        For Each item In items
            If item.Equals("") Or item.Equals(-1) Or item.Equals(False) Then
                MsgBox(message)
                IsEmpty = True
                Exit Function
            End If
        Next

        IsEmpty = False
    End Function

    '指定した長さより短いか長いか調べる
    Public Shared Function IsCount(items() As Object, count As Integer, Optional message As String = COUNT_MESSAGE)

        For Each item In items
            If item.length < count Then
                MsgBox(message)
                IsCount = False
                Exit Function
            End If
        Next

        IsCount = True
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
