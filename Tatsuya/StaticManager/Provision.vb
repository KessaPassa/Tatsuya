Imports Microsoft.VisualBasic

Public Class Provision

    Private Const EMPTY_MESSAGE = "入力されていない項目があります"
    Private Const COUNT_MESSAGE = "文字数が足りない項目があります"

    Private Shared ReadOnly Property identityState As String() = {
        "保険証",
        "免許証"
    }

    Public Shared ReadOnly Property GetLendDays As LendData() = {
        New LendData("当日", 0, 200),
        New LendData("2泊3日", 2, 300),
        New LendData("6泊7日", 6, 400)
    }

    Public Shared ReadOnly Property GetGenre As GenreData() = {
        New GenreData("01", "アクション"),
        New GenreData("02", "アニメ"),
        New GenreData("03", "SF"),
        New GenreData("04", "戦争"),
        New GenreData("05", "テレビドラマ"),
        New GenreData("06", "名作"),
        New GenreData("07", "ラブロマンス"),
        New GenreData("08", "ラブストーリー"),
        New GenreData("09", "ホラー"),
        New GenreData("21", "アクション(R)", "15禁"),
        New GenreData("22", "戦争(R)", "18禁"),
        New GenreData("23", "ホラー(R)", "18禁"),
        New GenreData("99", "その他")
    }

    Public Shared Function SearchGenre(code As String) As GenreData
        If code.Length = 2 Then
            For Each item In GetGenre
                If code = item.code Then
                    SearchGenre = item
                End If
            Next
        End If
    End Function

    Public Shared Sub AddIdentityState(ByVal comboBox As ComboBox)

        Dim items = identityState
        For Each item In items
            comboBox.Items.Add(item)
        Next
    End Sub

    Public Shared Sub AddLoanoutDays(ByVal comboBox As ComboBox)

        For i = 0 To GetLendDays.GetLength(0) - 1
            comboBox.Items.Add(GetLendDays(i).days)
        Next
    End Sub

    Public Shared Sub InitObject(ByVal items() As Object)

        For Each item In items
            Select Case True
                Case TypeOf item Is Label
                    CType(item, Label).Text = ""

                Case TypeOf item Is ComboBox
                    CType(item, ComboBox).SelectedIndex = -1

                Case TypeOf item Is ComboBox
                    CType(item, CheckBox).Checked = False

                Case Else
                    Exit Select
            End Select
        Next
    End Sub

    '入力されていないか調べる
    Public Shared Function IsEmpty(items() As Object, Optional message As String = EMPTY_MESSAGE) As Boolean

        For Each item In items
            If IsNothing(item) Then
                MsgBox(message)
                IsEmpty = True
                Exit Function
            End If
            If item.Equals("") Or item.Equals(-1) Or item.Equals(False) Then
                MsgBox(message)
                IsEmpty = True
                Exit Function
            End If
        Next

        IsEmpty = False
    End Function

    '指定した長さより短いか長いか調べる
    Public Shared Function IsCount(items() As Object, count As Integer, Optional message As String = COUNT_MESSAGE) As Boolean

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
    Public Shared Function OnlyNumeric(e As KeyPressEventArgs) As Boolean
        If e.KeyChar < "0"c OrElse "9"c < e.KeyChar Then
            e.Handled = True
            OnlyNumeric = False
        End If

        OnlyNumeric = True
    End Function

    Public Shared Function CreateDeletButton() As DataGridViewButtonCell
        Dim button = New DataGridViewButtonCell
        button.Value = "✖"

        CreateDeletButton = button
    End Function
End Class
