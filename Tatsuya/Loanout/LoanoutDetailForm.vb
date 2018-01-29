Public Class LoanoutDetailForm

    Public Enum ColumnName
        video
        title
        limitedAge
        nowDay
        loanoutDay
        returnDay
        pay
        delete
    End Enum

    Dim age As Integer

    Public Overloads Sub Show(user As User)

        IdentityNuber.Text = user.id
        UserName.Text = user.name
        Dim split() As String = user.birthday.ToString("yyy/MM/dd").Split("/")
        age = user.NowAge()
        UserAge.Text = age & "歳"

        AddRow()
        MyBase.Show()
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click

        '注意メッセージがないなら完了
        If MessageLabel.Text = "" Then
            MsgBox("貸し出し処理完了しました")
            MainForm.Show()
            Close()
        Else
            MsgBox("貸出できません" & Environment.NewLine & "メッセージの欄を見てください")
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        LoanoutMainForm.Show()
        Close()
    End Sub

    Private Sub VideoNumber_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Provision.OnlyNumeric(e) = False Then
            Exit Sub
        End If
    End Sub

    Private Sub VideoNumber_KeyUp(sender As Object, e As KeyEventArgs)

        Dim videoId As String = sender.Text
        If videoId.Length = 4 Then
            Dim video As Video = DBManager.Fetch(videoId, DBManager.Type.video)
            If video Is Nothing Then
                sender.Text = ""
                Exit Sub
            End If

            Cell(ColumnName.title).Text = video.title
            Dim genre As GenreData = Provision.SearchGenre(Cell(ColumnName.video).Text.Substring(0, 2))
            Cell(ColumnName.limitedAge).Text = genre.limited_age
            Cell(ColumnName.limitedAge).ForeColor = Color.Red

            If Cell(ColumnName.limitedAge).Text = "18禁" Then
                If age < 18 Then
                    MessageLabel.Text = "18歳未満なのでダメです！"
                End If

            ElseIf Cell(ColumnName.limitedAge).Text = "15禁" Then
                If age < 15 Then
                    MessageLabel.Text = "15歳未満なのでダメです！"
                End If

            Else
                Cell(ColumnName.limitedAge).ForeColor = Color.Black
            End If

            sender.Enabled = False
            CounterText()
            AddRow()
        End If
    End Sub

    Private Sub CounterText()
        Dim sum = 0
        Dim videoColumn = ColumnName.video
        For i = 1 To TableLayoutPanel.RowCount - 2
            Dim videoBox = CType(TableLayoutPanel.GetControlFromPosition(CType(videoColumn, Integer), i), TextBox)
            If videoBox.Enabled = False Then
                sum += 1
            End If
        Next

        Dim countColumn = ColumnName.loanoutDay
        Cell(countColumn, TableLayoutPanel.RowCount - 1).Text = sum
    End Sub

    Private Sub LoanoutDay_SelectedIndexChanged(sender As Object, e As EventArgs)

        Dim text = Cell(ColumnName.loanoutDay).SelectedItem
        Dim lendData = Provision.GetLendDays
        For i = 0 To lendData.GetLength(0) - 1
            If text = lendData(i).days Then
                Cell(ColumnName.returnDay).Text = DateTime.Today + New TimeSpan(lendData(i).limit, 0, 0, 0)
                Cell(ColumnName.pay).Text = lendData(i).pay
            End If
        Next

        Dim sum = 0
        Dim column As ColumnName = ColumnName.pay
        For i = 1 To TableLayoutPanel.RowCount - 2
            Dim payLabel = CType(TableLayoutPanel.GetControlFromPosition(CType(column, Integer), i), Label)
            sum += CType(payLabel.Text, Integer)
        Next
        Cell(column, TableLayoutPanel.RowCount - 1).Text = sum
    End Sub

    Private Function Cell(columnName As ColumnName, Optional row As Integer = -1) As Object
        Dim column = CType(columnName, Integer)
        If row = -1 Then
            Cell = TableLayoutPanel.GetControlFromPosition(column, TableLayoutPanel.RowCount - 2)
        Else
            Cell = TableLayoutPanel.GetControlFromPosition(column, row)
        End If
    End Function

    Private Sub AddRow()

        Dim transform = TableLayoutPanel.Size
        transform.Height += 24
        TableLayoutPanel.Size = transform

        Dim insertRow = TableLayoutPanel.RowCount - 1
        Dim c As Control
        For Each c In TableLayoutPanel.Controls
            Dim pos As TableLayoutPanelCellPosition =
                TableLayoutPanel.GetPositionFromControl(c)
            TableLayoutPanel.SetCellPosition(c, pos)
            If TableLayoutPanel.RowCount <= pos.Row Then
                TableLayoutPanel.RowCount = pos.Row + 1
            End If
            If TableLayoutPanel.ColumnCount <= pos.Column Then
                TableLayoutPanel.ColumnCount = pos.Column + 1
            End If
        Next c

        '列を増やす
        TableLayoutPanel.RowCount += 1

        'コントロールを移動
        Dim y As Integer
        For y = TableLayoutPanel.RowCount - 1 To insertRow Step -1
            Dim x As Integer
            For x = 0 To TableLayoutPanel.ColumnCount - 1
                c = TableLayoutPanel.GetControlFromPosition(x, y)
                If Not (c Is Nothing) Then
                    TableLayoutPanel.SetCellPosition(
                        c, New TableLayoutPanelCellPosition(x, y + 1))
                End If
            Next x
        Next y

        'スタイルを挿入
        If TableLayoutPanel.RowStyles.Count > insertRow Then
            TableLayoutPanel.RowStyles.Insert(
                insertRow, New RowStyle(SizeType.AutoSize))
        End If

        Dim textBox = CreateTextBox()
        AddHandler textBox.KeyPress, AddressOf VideoNumber_KeyPress
        AddHandler textBox.KeyUp, AddressOf VideoNumber_KeyUp
        CreateObjectToTable(textBox, insertRow, 0)

        Dim title = CreateLabel("")
        CreateObjectToTable(title, insertRow, 1)

        Dim limitedAge = CreateLabel("")
        CreateObjectToTable(limitedAge, insertRow, 2)

        Dim nowTime = CreateLabel(Date.Today.ToString("yyy/MM/dd"))
        CreateObjectToTable(nowTime, insertRow, 3)

        Dim newComboBox = New ComboBox
        Provision.AddLoanoutDays(newComboBox)
        AddHandler newComboBox.SelectedIndexChanged, AddressOf LoanoutDay_SelectedIndexChanged
        CreateObjectToTable(newComboBox, insertRow, 4)

        Dim loanoutDay = CreateLabel("")
        CreateObjectToTable(loanoutDay, insertRow, 5)

        Dim pay = CreateLabel("")
        CreateObjectToTable(pay, insertRow, 6)

        Dim button = CreateDeletButton()
        AddHandler button.Click, AddressOf Delete
        CreateObjectToTable(button, insertRow, 7)
    End Sub

    Private Sub CreateObjectToTable(obj, insertRow, insertColumn)
        If TableLayoutPanel.GetControlFromPosition(
        insertColumn, insertRow) Is Nothing Then
            TableLayoutPanel.Controls.Add(obj, insertColumn, insertRow)
        End If
    End Sub

    Public Shared Function CreateTextBox() As TextBox

        Dim textBox = New TextBox
        textBox.MaxLength = 4
        'textBox.AutoSize = True
        textBox.Anchor = AnchorStyles.Bottom And AnchorStyles.Left And AnchorStyles.Right And AnchorStyles.Top
        textBox.TextAlign = HorizontalAlignment.Center
        CreateTextBox = textBox
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

    Private Sub Delete(sender As Object, e As EventArgs)
        DeleteRow(sender, TableLayoutPanel)
    End Sub

    Public Shared Sub DeleteRow(sender As Object, ByVal table As TableLayoutPanel)

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