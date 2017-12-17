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

        Provision.AddRow(Table)
        Dim code As String = "00"
        Dim genreData = Provision.GetGenre
        For i = 0 To genreData.GetLength(0) - 1
            If GenreComboBox.SelectedItem = genreData(i).genre Then
                code = genreData(i).code
            End If
        Next
        Dim id As String = code & "01" & String.Format("{0:D2}", CountComboBox.SelectedItem)
        Dim videoNumber = Provision.CreateLabel(id)
        Dim genre = Provision.CreateLabel(GenreComboBox.SelectedItem)
        Dim title = Provision.CreateLabel(TitleBox.Text)
        Dim count = Provision.CreateLabel(CountComboBox.SelectedItem)
        Dim arrivalDate = Provision.CreateLabel(New Date(Year.SelectedItem, Month.SelectedItem, Day.SelectedItem).ToString("yyy/MM/dd"))
        Dim button = Provision.CreateDeletButton
        AddHandler button.Click, AddressOf Delete

        Dim objects = {videoNumber, genre, title, count, arrivalDate, button}
        For i = 0 To Table.ColumnCount - 1
            Table.Controls.Add(objects(i), i, Table.RowCount)
        Next
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click


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

    Private Sub Delete(sender As Object, e As EventArgs)
        Provision.Delete(sender, Table)
    End Sub
End Class