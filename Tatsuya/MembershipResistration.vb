Public Class MembershopRegistration

    Dim jender As String = ""

    ' Activatedイベント・ハンドラ
    Private Sub MembershopRegistration_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Activated
        NowDateTextBox.Text = Date.Now.ToString("yyyy/MM/dd (ddd)")
    End Sub

    'Show
    Public Sub Init()
        IdentityNumber.Text = ""
        IdentityState.Items.Clear()
        UserName.Text = ""
        Man.Checked = False
        Woman.Checked = False
        TelNumber.Text = ""
        YearComboBox.Items.Clear()
        MonthComboBox.Items.Clear()
        DayComboBox.Items.Clear()
        AddressNumber.Text = ""
        AddressContent.Text = ""

        Provision.AddItem(IdentityState)
        Dim nowYear As Integer = Date.Now.ToString("yyyy")
        For i = 1900 To nowYear
            YearComboBox.Items.Add(i)
        Next

        For i = 1 To 12
            MonthComboBox.Items.Add(i)
        Next

    End Sub

    '内部データベースに保存
    Private Sub SaveData(id As String, birthday As String)
        DBManager.id = id
        DBManager.name = UserName.Text
        DBManager.identityNumber = IdentityNumber.Text
        DBManager.identityState = IdentityState.SelectedItem
        DBManager.jender = jender
        DBManager.tel = TelNumber.Text
        DBManager.birthday = birthday
        DBManager.addressNumber = AddressNumber.Text
        DBManager.addressContent = AddressContent.Text
    End Sub

    '登録ボタンを押したとき
    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click

        If Man.Checked = True Then
            jender = "男"
        ElseIf Woman.Checked = True Then
            jender = "女"
        End If

        '入力チェック
        Dim items = {IdentityNumber.Text, IdentityState.SelectedIndex, UserName.Text, 
            jender, TelNumber.Text, YearComboBox.SelectedIndex, MonthComboBox.SelectedIndex,
            DayComboBox.SelectedIndex, AddressNumber.Text, AddressContent.Text
        }
        If Provision.IsEmpty(items) Then
            MsgBox("入力されていない項目があります")
            Exit Sub
        End If

        Dim birthday As String = YearComboBox.SelectedItem.ToString + "年" + MonthComboBox.SelectedItem.ToString + "月" + DayComboBox.SelectedItem.ToString + "日"

        'メッセージボックス表示
        Dim message As String =
            "登録日: " & NowDateTextBox.Text & Environment.NewLine &
            "----" & Environment.NewLine &
            "身分証明書: " & IdentityNumber.Text & Environment.NewLine &
            "身分証種別: " & IdentityState.SelectedItem & Environment.NewLine &
            "氏名: " & UserName.Text & Environment.NewLine &
            "性別: " & jender & Environment.NewLine &
            "生年月日: " & birthday & Environment.NewLine &
            "電話番号: " & TelNumber.Text & Environment.NewLine &
            "郵便番号: " & AddressNumber.Text & Environment.NewLine &
            "住所: " & AddressContent.Text & Environment.NewLine &
            "----" & Environment.NewLine &
            "以上の情報で登録してよろしいですか？"
        Dim result As DialogResult = MessageBox.Show(message, "登録内容確認", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Dim r As Random = New Random()
            Dim random As Integer = r.Next(100000)
            Dim randomId As String = String.Format("{0:D6}", random)
            SaveData(randomId, birthday)
            MsgBox("あなたの会員番号は「" + randomId + "」です" + Environment.NewLine + "OKボタンで最初の画面へ戻ります", MsgBoxStyle.OkOnly, "会員登録完了")
            MainForm.Show()
            Hide()
        End If
    End Sub

    'キャンセルボタンを押したとき
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        MembershipForm.Show()
        Me.Hide()
    End Sub

    Private Sub YearComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles YearComboBox.SelectedIndexChanged
        DayComboBox.Items.Clear()
        DayComboBox.SelectedText = ""

        If CType(YearComboBox.SelectedItem, Integer) Mod 4 = 0 & MonthComboBox.SelectedItem = 2 Then
            For i = 1 To 29
                DayComboBox.Items.Add(i)
            Next
        Else
            For i = 1 To 28
                DayComboBox.Items.Add(i)
            Next
        End If
    End Sub

    Private Sub MonthComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MonthComboBox.SelectedIndexChanged
        DayComboBox.Items.Clear()

        Select Case MonthComboBox.SelectedItem
            Case 2
                If CType(YearComboBox.SelectedItem, Integer) Mod 4 = 0 Then
                    For i = 1 To 29
                        DayComboBox.Items.Add(i)
                    Next
                Else
                    For i = 1 To 28
                        DayComboBox.Items.Add(i)
                    Next
                End If


            Case 4, 6, 9, 11
                For i = 1 To 30
                    DayComboBox.Items.Add(i)
                Next

            Case 1, 3, 5, 7, 8, 10, 12
                For i = 1 To 31
                    DayComboBox.Items.Add(i)
                Next


        End Select
    End Sub

    Private Sub TelNumber_TextChanged(sender As Object, e As EventArgs) Handles TelNumber.TextChanged
        TelNumber.Text = NotificationMsg(sender.Text)
    End Sub

    Private Sub AddressNumber_TextChanged(sender As Object, e As EventArgs) Handles AddressNumber.TextChanged
        AddressNumber.Text = NotificationMsg(sender.Text)
    End Sub

    'ハイフンは要れない
    Private Function NotificationMsg(text As String)
        If text.Contains("-") Then
            MsgBox("ハイフンは除いてください")
            text = text.Trim("-")
        End If

        NotificationMsg = text
    End Function


End Class