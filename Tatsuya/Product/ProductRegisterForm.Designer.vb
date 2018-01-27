<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductRegisterForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TitleBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GenreComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Day = New System.Windows.Forms.ComboBox()
        Me.Month = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Year = New System.Windows.Forms.ComboBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Table = New System.Windows.Forms.TableLayoutPanel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CountComboBox = New System.Windows.Forms.ComboBox()
        Me.GridView = New System.Windows.Forms.DataGridView()
        Me.CellVideoID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cell_Genre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cell_Title = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cell_Count = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cell_Arrival = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cell_Delete = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table.SuspendLayout()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 12)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "タイトル"
        '
        'TitleBox
        '
        Me.TitleBox.Location = New System.Drawing.Point(90, 38)
        Me.TitleBox.MaxLength = 100
        Me.TitleBox.Name = "TitleBox"
        Me.TitleBox.Size = New System.Drawing.Size(375, 19)
        Me.TitleBox.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 12)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "ジャンル"
        '
        'GenreComboBox
        '
        Me.GenreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenreComboBox.FormattingEnabled = True
        Me.GenreComboBox.Location = New System.Drawing.Point(90, 88)
        Me.GenreComboBox.Name = "GenreComboBox"
        Me.GenreComboBox.Size = New System.Drawing.Size(103, 20)
        Me.GenreComboBox.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(209, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "本数"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 12)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "入荷日"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(299, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 12)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "日"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(229, 139)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(17, 12)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "月"
        '
        'Day
        '
        Me.Day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Day.FormattingEnabled = True
        Me.Day.Location = New System.Drawing.Point(252, 135)
        Me.Day.Name = "Day"
        Me.Day.Size = New System.Drawing.Size(41, 20)
        Me.Day.TabIndex = 23
        '
        'Month
        '
        Me.Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Month.FormattingEnabled = True
        Me.Month.Location = New System.Drawing.Point(182, 135)
        Me.Month.Name = "Month"
        Me.Month.Size = New System.Drawing.Size(41, 20)
        Me.Month.TabIndex = 22
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(159, 139)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(17, 12)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "年"
        '
        'Year
        '
        Me.Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Year.FormattingEnabled = True
        Me.Year.Location = New System.Drawing.Point(91, 135)
        Me.Year.Name = "Year"
        Me.Year.Size = New System.Drawing.Size(62, 20)
        Me.Year.TabIndex = 20
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(474, 133)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 25
        Me.AddButton.Text = "追加"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(474, 387)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 27
        Me.CancelButton.Text = "キャンセル"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(369, 387)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 26
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(299, 91)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(17, 12)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "本"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(63, 1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 22)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "ジャンル"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(126, 1)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(221, 22)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "タイトル"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(354, 1)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 22)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "本数"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(397, 1)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 22)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "入荷日"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(483, 1)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 22)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "削除"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Table
        '
        Me.Table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Table.ColumnCount = 6
        Me.Table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.96748!))
        Me.Table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.03252!))
        Me.Table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 227.0!))
        Me.Table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.Table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.Table.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.Table.Controls.Add(Me.Label14, 5, 0)
        Me.Table.Controls.Add(Me.Label16, 0, 0)
        Me.Table.Controls.Add(Me.Label11, 3, 0)
        Me.Table.Controls.Add(Me.Label9, 1, 0)
        Me.Table.Controls.Add(Me.Label5, 4, 0)
        Me.Table.Controls.Add(Me.Label10, 2, 0)
        Me.Table.Location = New System.Drawing.Point(12, 191)
        Me.Table.Name = "Table"
        Me.Table.RowCount = 1
        Me.Table.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Table.Size = New System.Drawing.Size(537, 24)
        Me.Table.TabIndex = 29
        '
        'Label16
        '
        Me.Label16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(4, 1)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 22)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "ビデオID"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CountComboBox
        '
        Me.CountComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CountComboBox.FormattingEnabled = True
        Me.CountComboBox.Location = New System.Drawing.Point(252, 88)
        Me.CountComboBox.Name = "CountComboBox"
        Me.CountComboBox.Size = New System.Drawing.Size(41, 20)
        Me.CountComboBox.TabIndex = 30
        '
        'GridView
        '
        Me.GridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CellVideoID, Me.Cell_Genre, Me.Cell_Title, Me.Cell_Count, Me.Cell_Arrival, Me.Cell_Delete})
        Me.GridView.Location = New System.Drawing.Point(12, 236)
        Me.GridView.Name = "GridView"
        Me.GridView.ReadOnly = True
        Me.GridView.RowTemplate.Height = 21
        Me.GridView.Size = New System.Drawing.Size(537, 150)
        Me.GridView.TabIndex = 31
        '
        'CellVideoID
        '
        Me.CellVideoID.HeaderText = "ビデオID"
        Me.CellVideoID.Name = "CellVideoID"
        Me.CellVideoID.ReadOnly = True
        Me.CellVideoID.Width = 65
        '
        'Cell_Genre
        '
        Me.Cell_Genre.HeaderText = "ジャンル"
        Me.Cell_Genre.Name = "Cell_Genre"
        Me.Cell_Genre.ReadOnly = True
        Me.Cell_Genre.Width = 60
        '
        'Cell_Title
        '
        Me.Cell_Title.HeaderText = "タイトル"
        Me.Cell_Title.Name = "Cell_Title"
        Me.Cell_Title.ReadOnly = True
        Me.Cell_Title.Width = 220
        '
        'Cell_Count
        '
        Me.Cell_Count.HeaderText = "本数"
        Me.Cell_Count.Name = "Cell_Count"
        Me.Cell_Count.ReadOnly = True
        Me.Cell_Count.Width = 35
        '
        'Cell_Arrival
        '
        Me.Cell_Arrival.HeaderText = "入荷日"
        Me.Cell_Arrival.Name = "Cell_Arrival"
        Me.Cell_Arrival.ReadOnly = True
        Me.Cell_Arrival.Width = 80
        '
        'Cell_Delete
        '
        Me.Cell_Delete.HeaderText = "削除"
        Me.Cell_Delete.Name = "Cell_Delete"
        Me.Cell_Delete.ReadOnly = True
        Me.Cell_Delete.Width = 30
        '
        'ProductRegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 441)
        Me.Controls.Add(Me.GridView)
        Me.Controls.Add(Me.CountComboBox)
        Me.Controls.Add(Me.Table)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Day)
        Me.Controls.Add(Me.Month)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Year)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GenreComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TitleBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ProductRegisterForm"
        Me.Text = "商品登録"
        Me.Table.ResumeLayout(False)
        Me.Table.PerformLayout()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TitleBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GenreComboBox As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Day As ComboBox
    Friend WithEvents Month As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Year As ComboBox
    Friend WithEvents AddButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents OKButton As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Table As TableLayoutPanel
    Friend WithEvents Label16 As Label
    Friend WithEvents CountComboBox As ComboBox
    Friend WithEvents GridView As DataGridView
    Friend WithEvents CellVideoID As DataGridViewTextBoxColumn
    Friend WithEvents Cell_Genre As DataGridViewTextBoxColumn
    Friend WithEvents Cell_Title As DataGridViewTextBoxColumn
    Friend WithEvents Cell_Count As DataGridViewTextBoxColumn
    Friend WithEvents Cell_Arrival As DataGridViewTextBoxColumn
    Friend WithEvents Cell_Delete As DataGridViewTextBoxColumn
End Class
