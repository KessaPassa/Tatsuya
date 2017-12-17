Public Class LoanoutDetailForm

    Dim age As Integer

    Public Sub Init(user As User)

        IdentityNuber.Text = user.id
        UserName.Text = user.name
        Dim split() As String = user.birthday.ToString("yyy/MM/dd").Split("/")
        age = user.NowAge()
        UserAge.Text = age & "歳"

        VideoNumber.Text = ""
        Title.Text = ""
        LimitedAge.Text = ""
        NowTime.Text = Date.Today.ToString("yyy/MM/dd")
        LoanoutDays.SelectedIndex = -1
        ReturnDays.Text = ""
        Pay.Text = ""
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click

        '注意メッセージがないなら完了
        If MessageLabel.Text = "" Then
            MsgBox("貸し出し処理完了しました")
            MainForm.Show()
            Hide()
        Else
            MsgBox("貸出できません" & Environment.NewLine & "メッセージの欄を見てください")
        End If
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
            If videoId.Length = 5 Then
                Dim video As Video = DBManager.FetchVideo("123456")
                Title.Text = video.title
                LimitedAge.Text = video.limited_age
                If LimitedAge.Text = "18禁" Then
                    LimitedAge.ForeColor = Color.Red
                    If age < 18 Then
                        MessageLabel.Text = "18歳未満なのでダメです！"
                    End If
                Else
                    LimitedAge.ForeColor = Color.Black
                End If
                sender.Enabled = False

                AddRow()
            End If
        End If
    End Sub

    Private Sub LoanoutDays_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LoanoutDays.SelectedIndexChanged

        Dim text = LoanoutDays.SelectedItem
        Dim lendData = Provision.LendDays
        For i = 0 To lendData.GetLength(0) - 1
            If text = lendData(i).days Then
                ReturnDays.Text = DateTime.Today + New TimeSpan(lendData(i).limit, 0, 0, 0)
                SumCount.Text = 1 'CType(SumCount.Text, Integer) + 1
                Pay.Text = lendData(i).pay
                SumPay.Text = Pay.Text 'CType(SumPay.Text, Integer) + Pay.Text
            End If
        Next
    End Sub

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

        CreateObjectToTable(New TextBox, insertRow, 0)
        Dim newComboBox = New ComboBox
        Provision.AddLoanoutDays(newComboBox)
        CreateObjectToTable(newComboBox, insertRow, 4)
        CreateObjectToTable(New Button, insertRow, 7)
        Dim row = {1, 2, 3, 5, 6}
        For Each i In row
            CreateObjectToTable(New Label, insertRow, i)
        Next

    End Sub

    Private Sub CreateObjectToTable(obj, insertRow, insertColumn)
        If TableLayoutPanel.GetControlFromPosition(
        insertColumn, insertRow) Is Nothing Then
            TableLayoutPanel.Controls.Add(obj, insertColumn, insertRow)
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click

        If TableLayoutPanel.ColumnCount <= 3 Then
            MsgBox("これ以上は削除できません")
            Exit Sub
        End If

        sender.Visible = False
        Dim table = TableLayoutPanel
        Dim control As Control = Nothing
        Dim row
        For row = 0 To table.RowCount - 1
            control = table.GetControlFromPosition(7, row)
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
            TableLayoutPanel.Controls.Remove(column)
        Next

        'コントロールを移動
        Dim y As Integer
        For y = row + 1 To table.RowCount - 1
            For x = 0 To table.ColumnCount - 1
                control = table.GetControlFromPosition(x, y)
                If Not (control Is Nothing) Then
                    TableLayoutPanel.SetCellPosition(
                        control, New TableLayoutPanelCellPosition(x, y - 1))
                End If
            Next x
        Next y

        '列を減らす
        If table.RowCount > 0 Then
            TableLayoutPanel.RowCount -= 1
        End If
        'スタイルを削除
        If table.RowStyles.Count > row Then
            TableLayoutPanel.RowStyles.RemoveAt(row)
        End If
    End Sub
End Class