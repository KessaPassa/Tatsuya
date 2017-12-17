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
        New GenreData("21", "アクション(R)", "15"),
        New GenreData("22", "戦争(R)", "18"),
        New GenreData("23", "ホラー(R)", "18"),
        New GenreData("99", "その他")
    }


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

    Public Shared Function CreateLabel(name As String) As Label

        Dim label = New Label
        label.Text = name
        label.AutoSize = True
        label.Anchor = AnchorStyles.Bottom And AnchorStyles.Left And AnchorStyles.Right And AnchorStyles.Top
        label.TextAlign = ContentAlignment.MiddleCenter
        CreateLabel = label
    End Function

    Public Shared Function CreateDeletButton() As Button

        Dim button = New Button
        button.ForeColor = Color.DarkRed
        button.Margin = New Padding(0, 0, 0, 0)
        button.Size = New Size(44, 20)
        button.Text = "✖"

        CreateDeletButton = button
    End Function

    Public Shared Sub AddRow(ByVal table As TableLayoutPanel)

        Dim transform = table.Size
        transform.Height += 24
        table.Size = transform

        Dim insertRow = table.RowCount - 1
        Dim c As Control
        For Each c In table.Controls
            Dim pos As TableLayoutPanelCellPosition =
                table.GetPositionFromControl(c)
            table.SetCellPosition(c, pos)
            If table.RowCount <= pos.Row Then
                table.RowCount = pos.Row + 1
            End If
            If table.ColumnCount <= pos.Column Then
                table.ColumnCount = pos.Column + 1
            End If
        Next c

        '列を増やす
        table.RowCount += 1

        'コントロールを移動
        Dim y As Integer
        For y = table.RowCount - 1 To insertRow Step -1
            Dim x As Integer
            For x = 0 To table.ColumnCount - 1
                c = table.GetControlFromPosition(x, y)
                If Not (c Is Nothing) Then
                    table.SetCellPosition(
                        c, New TableLayoutPanelCellPosition(x, y + 1))
                End If
            Next x
        Next y

        'スタイルを挿入
        If table.RowStyles.Count > insertRow Then
            table.RowStyles.Insert(
                insertRow, New RowStyle(SizeType.AutoSize))
        End If
    End Sub

    Public Shared Sub Delete(sender As Object, ByVal table As TableLayoutPanel)

        sender.Visible = False
        Dim control As Control = Nothing
        Dim row
        For row = 0 To table.RowCount - 1
            control = table.GetControlFromPosition(table.ColumnCount - 1, row)
            If Not (control Is Nothing) Then
                If control.Visible = False Then
                    Exit For
                End If
            End If
        Next
        sender.Visible = True
        If control Is Nothing Then
            Exit Sub
        End If

        'コントロールを削除
        For x = 0 To table.ColumnCount
            Dim column = table.GetControlFromPosition(x, row)
            table.Controls.Remove(column)
        Next

        'コントロールを移動
        Dim y As Integer
        For y = row + 1 To table.RowCount - 1
            For x = 0 To table.ColumnCount - 1
                control = table.GetControlFromPosition(x, y)
                If Not (control Is Nothing) Then
                    table.SetCellPosition(
                        control, New TableLayoutPanelCellPosition(x, y - 1))
                End If
            Next x
        Next y

        '列を減らす
        If table.RowCount > 0 Then
            table.RowCount -= 1
        End If
        'スタイルを削除
        If table.RowStyles.Count > row Then
            table.RowStyles.RemoveAt(row)
        End If

        Dim transform = table.Size
        transform.Height -= 24
        table.Size = transform
    End Sub
End Class
