Public Class MembershopRegistration

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
        Tel1.Text = ""
        YearComboBox.Items.Clear()
        MonthComboBox.Items.Clear()
        DayComboBox.Items.Clear()
        AddressNumber.Text = ""
        AddressContent.Text = ""

        Provision.AddIdentityState(IdentityState)
        Dim nowYear As Integer = Date.Now.ToString("yyyy")
        For i = 1900 To nowYear
            YearComboBox.Items.Add(i)
        Next

        For i = 1 To 12
            MonthComboBox.Items.Add(i)
        Next

    End Sub

    '登録ボタンを押したとき
    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click

        Dim jender As String = ""
        If Man.Checked = True Then
            jender = "男"
        ElseIf Woman.Checked = True Then
            jender = "女"
        End If

        '入力チェック
        Dim items = {IdentityNumber.Text, IdentityState.SelectedIndex, UserName.Text,
            jender, Tel1.Text, YearComboBox.SelectedIndex, MonthComboBox.SelectedIndex,
            DayComboBox.SelectedIndex, AddressNumber.Text, AddressContent.Text
        }
        If Provision.IsEmpty(items) Then
            Exit Sub
        End If

        Dim birthday As String = YearComboBox.SelectedItem.ToString + "年" + MonthComboBox.SelectedItem.ToString + "月" + DayComboBox.SelectedItem.ToString + "日"

        '同一のIDが生成されないようにする
        Dim seed As Integer = Environment.TickCount
        Dim randomId As String
        Do
            seed += 1
            Dim r As Random = New Random(seed)
            Dim random As Integer = r.Next(100000)
            randomId = String.Format("{0:D6}", random)
        Loop Until DBManager.IsExitID(randomId, DBManager.Type.user)


        Dim user = New User(
            randomId, UserName.Text, jender,
            New Date(YearComboBox.SelectedItem.ToString, MonthComboBox.SelectedItem.ToString, DayComboBox.SelectedItem.ToString),
            Date.Today, Tel1.Text + "-" + Tel2.Text + "-" + Tel3.Text, AddressNumber.Text,
            AddressContent.Text, IdentityNumber.Text, IdentityState.SelectedItem
        )

        'メッセージボックス表示
        Dim message As String =
            "登録日: " & user.registerday & Environment.NewLine &
            "----" & Environment.NewLine &
            "身分証明書: " & user.identity_number & Environment.NewLine &
            "身分証種別: " & user.identity_state & Environment.NewLine &
            "氏名: " & user.name & Environment.NewLine &
            "性別: " & jender & Environment.NewLine &
            "生年月日: " & birthday & Environment.NewLine &
            "電話番号: " & user.tel & Environment.NewLine &
            "郵便番号: " & user.address_number & Environment.NewLine &
            "住所: " & user.address_content & Environment.NewLine &
            "----" & Environment.NewLine &
            "以上の情報で登録してよろしいですか？"
        Dim result As DialogResult = MessageBox.Show(message, "登録内容確認", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then

            DBManager.Save(user, DBManager.Type.user)
            MsgBox("あなたの会員番号は「" + user.id + "」です" + Environment.NewLine + "OKボタンで最初の画面へ戻ります", MsgBoxStyle.OkOnly, "会員登録完了")
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

    '数字のみ。ハイフンも要れない
    Private Sub KeyPressManager(sender As Object, e As KeyPressEventArgs) Handles AddressNumber.KeyPress, IdentityNumber.KeyPress, Tel1.KeyPress, Tel2.KeyPress, Tel3.KeyPress
        If Provision.OnlyNumeric(e) = False Then
            Exit Sub
        End If
    End Sub
End Class