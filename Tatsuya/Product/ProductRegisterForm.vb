Public Class ProductRegisterForm

    Private Sub ProductRegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each item In Provision.GetGenre
            GenreComboBox.Items.Add(item.genre)
        Next

        For count = 1 To 99
            CountComboBox.Items.Add(count)
        Next

        Dim nowYear As Integer = Date.Now.ToString("yyyy")
        For i = 2000 To nowYear
            Year.Items.Add(i)
        Next

        For i = 1 To 12
            Month.Items.Add(i)
        Next
    End Sub

    Public Overloads Sub Show()
        MyBase.Show()
        Year.Text = Date.Today.Year
        Month.Text = Date.Today.Month
        Day.Text = Date.Today.Day
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As KeyPressEventArgs)
        If Provision.OnlyNumeric(e) = False Then
            Exit Sub
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click

        Dim items = {
            TitleBox.Text, GenreComboBox.SelectedItem, CountComboBox.SelectedItem,
            Year.SelectedItem, Month.SelectedItem, Day.SelectedItem
        }
        If Provision.IsEmpty(items) Then
            Exit Sub
        End If

        Dim code As String = "00"
        Dim genreData = Provision.GetGenre
        For i = 0 To genreData.GetLength(0) - 1
            If GenreComboBox.SelectedItem = genreData(i).genre Then
                code = genreData(i).code
            End If
        Next
        Dim id As String = code & "01" & String.Format("{0:D2}", CountComboBox.SelectedItem)

        Dim row = GridView.Rows.Count - 1
        GridView.Rows.Add()
        GridView(0, row).Value = id
        GridView(1, row).Value = GenreComboBox.Text
        GridView(2, row).Value = TitleBox.Text
        GridView(3, row).Value = CountComboBox.Text
        GridView(4, row).Value = New Date(Year.SelectedItem, Month.SelectedItem, Day.SelectedItem).ToString("yyy/MM/dd")
        GridView(5, row) = Provision.CreateDeletButton

        TitleBox.Text = ""
        CountComboBox.SelectedIndex = -1
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        If Table.RowCount > 1 Then
            MsgBox("新規タイトルを登録しました", MsgBoxStyle.OkOnly, "商品登録終了")
            MainForm.Show()
            Close()
        Else
            MsgBox("登録する商品が入力されていません")
        End If

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        MainForm.Show()
        Close()
    End Sub

    Private Sub YearComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Year.SelectedIndexChanged

        If CType(Year.SelectedItem, Integer) Mod 4 = 0 & Month.SelectedItem = 2 Then
            For i = 1 To 29
                Day.Items.Add(i)
            Next
        Else
            For i = 1 To 28
                Day.Items.Add(i)
            Next
        End If
    End Sub

    Private Sub MonthComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Month.SelectedIndexChanged

        Select Case Month.SelectedItem
            Case 2
                If CType(Year.SelectedItem, Integer) Mod 4 = 0 Then
                    For i = 1 To 29
                        Day.Items.Add(i)
                    Next
                Else
                    For i = 1 To 28
                        Day.Items.Add(i)
                    Next
                End If

            Case 4, 6, 9, 11
                For i = 1 To 30
                    Day.Items.Add(i)
                Next

            Case 1, 3, 5, 7, 8, 10, 12
                For i = 1 To 31
                    Day.Items.Add(i)
                Next
        End Select
    End Sub

    Private Sub Delete(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles GridView.CellContentClick
        Dim dgv As DataGridView = CType(sender, DataGridView)
        If GridView.CurrentCell.ColumnIndex = 5 Then
            GridView.Rows.RemoveAt(GridView.CurrentCell.RowIndex)
        End If
    End Sub
End Class