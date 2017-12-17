<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MembershopRegistration
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IdentityNumber = New System.Windows.Forms.TextBox()
        Me.IdentityState = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Woman = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Man = New System.Windows.Forms.RadioButton()
        Me.UserName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Tel3 = New System.Windows.Forms.TextBox()
        Me.Tel2 = New System.Windows.Forms.TextBox()
        Me.Tel1 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Day = New System.Windows.Forms.ComboBox()
        Me.Month = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Year = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.AddressContent = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.AddressNumber = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.NowDateTextBox = New System.Windows.Forms.TextBox()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(81, 116)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(0, 19)
        Me.DateTimePicker1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "身分証番号"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IdentityNumber)
        Me.GroupBox1.Controls.Add(Me.IdentityState)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 100)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "身分証情報"
        '
        'IdentityNumber
        '
        Me.IdentityNumber.Location = New System.Drawing.Point(94, 32)
        Me.IdentityNumber.MaxLength = 20
        Me.IdentityNumber.Name = "IdentityNumber"
        Me.IdentityNumber.Size = New System.Drawing.Size(120, 19)
        Me.IdentityNumber.TabIndex = 1
        '
        'IdentityState
        '
        Me.IdentityState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdentityState.FormattingEnabled = True
        Me.IdentityState.Location = New System.Drawing.Point(94, 71)
        Me.IdentityState.Name = "IdentityState"
        Me.IdentityState.Size = New System.Drawing.Size(120, 20)
        Me.IdentityState.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "身分証種別"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Woman)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Man)
        Me.GroupBox2.Controls.Add(Me.UserName)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(280, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(240, 100)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "氏名・性別"
        '
        'Woman
        '
        Me.Woman.AutoSize = True
        Me.Woman.Location = New System.Drawing.Point(156, 73)
        Me.Woman.Name = "Woman"
        Me.Woman.Size = New System.Drawing.Size(35, 16)
        Me.Woman.TabIndex = 5
        Me.Woman.TabStop = True
        Me.Woman.Text = "女"
        Me.Woman.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "性別"
        '
        'Man
        '
        Me.Man.AutoSize = True
        Me.Man.Location = New System.Drawing.Point(78, 73)
        Me.Man.Name = "Man"
        Me.Man.Size = New System.Drawing.Size(35, 16)
        Me.Man.TabIndex = 4
        Me.Man.TabStop = True
        Me.Man.Text = "男"
        Me.Man.UseVisualStyleBackColor = True
        '
        'UserName
        '
        Me.UserName.Location = New System.Drawing.Point(52, 31)
        Me.UserName.MaxLength = 20
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(162, 19)
        Me.UserName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "氏名"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Tel3)
        Me.GroupBox3.Controls.Add(Me.Tel2)
        Me.GroupBox3.Controls.Add(Me.Tel1)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 140)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(240, 70)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "電話番号"
        '
        'Tel3
        '
        Me.Tel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tel3.Location = New System.Drawing.Point(177, 31)
        Me.Tel3.MaxLength = 4
        Me.Tel3.Name = "Tel3"
        Me.Tel3.Size = New System.Drawing.Size(51, 19)
        Me.Tel3.TabIndex = 8
        Me.Tel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tel2
        '
        Me.Tel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tel2.Location = New System.Drawing.Point(95, 31)
        Me.Tel2.MaxLength = 4
        Me.Tel2.Name = "Tel2"
        Me.Tel2.Size = New System.Drawing.Size(51, 19)
        Me.Tel2.TabIndex = 7
        Me.Tel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tel1
        '
        Me.Tel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tel1.Location = New System.Drawing.Point(12, 31)
        Me.Tel1.MaxLength = 3
        Me.Tel1.Name = "Tel1"
        Me.Tel1.Size = New System.Drawing.Size(51, 19)
        Me.Tel1.TabIndex = 6
        Me.Tel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("MS UI Gothic", 14.0!)
        Me.Label17.Location = New System.Drawing.Point(152, 31)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(19, 19)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "-"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("MS UI Gothic", 14.0!)
        Me.Label16.Location = New System.Drawing.Point(69, 31)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(19, 19)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "-"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(123, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 12)
        Me.Label10.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 12)
        Me.Label5.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Day)
        Me.GroupBox4.Controls.Add(Me.Month)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Year)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(280, 140)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(240, 70)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "生年月日"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(220, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 12)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "日"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(150, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 12)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "月"
        '
        'Day
        '
        Me.Day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Day.FormattingEnabled = True
        Me.Day.Location = New System.Drawing.Point(173, 30)
        Me.Day.Name = "Day"
        Me.Day.Size = New System.Drawing.Size(41, 20)
        Me.Day.TabIndex = 11
        '
        'Month
        '
        Me.Month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Month.FormattingEnabled = True
        Me.Month.Location = New System.Drawing.Point(103, 30)
        Me.Month.Name = "Month"
        Me.Month.Size = New System.Drawing.Size(41, 20)
        Me.Month.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(80, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 12)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "年"
        '
        'Year
        '
        Me.Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Year.FormattingEnabled = True
        Me.Year.Location = New System.Drawing.Point(12, 30)
        Me.Year.Name = "Year"
        Me.Year.Size = New System.Drawing.Size(62, 20)
        Me.Year.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 12)
        Me.Label6.TabIndex = 3
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.AddressContent)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.AddressNumber)
        Me.GroupBox5.Location = New System.Drawing.Point(20, 230)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(500, 100)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "住所"
        '
        'AddressContent
        '
        Me.AddressContent.Location = New System.Drawing.Point(94, 72)
        Me.AddressContent.MaxLength = 50
        Me.AddressContent.Name = "AddressContent"
        Me.AddressContent.Size = New System.Drawing.Size(380, 19)
        Me.AddressContent.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(234, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 12)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "*ハイフンなしで半角"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 12)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "住所"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 12)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "郵便番号"
        '
        'AddressNumber
        '
        Me.AddressNumber.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddressNumber.Location = New System.Drawing.Point(94, 31)
        Me.AddressNumber.MaxLength = 7
        Me.AddressNumber.Name = "AddressNumber"
        Me.AddressNumber.Size = New System.Drawing.Size(120, 19)
        Me.AddressNumber.TabIndex = 12
        Me.AddressNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.NowDateTextBox)
        Me.GroupBox6.Location = New System.Drawing.Point(20, 352)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(240, 70)
        Me.GroupBox6.TabIndex = 6
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "登録情報"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 34)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 12)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "登録日"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(10, 75)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(0, 12)
        Me.Label15.TabIndex = 3
        '
        'NowDateTextBox
        '
        Me.NowDateTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NowDateTextBox.Location = New System.Drawing.Point(94, 31)
        Me.NowDateTextBox.Name = "NowDateTextBox"
        Me.NowDateTextBox.ReadOnly = True
        Me.NowDateTextBox.Size = New System.Drawing.Size(120, 19)
        Me.NowDateTextBox.TabIndex = 1
        Me.NowDateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RegisterButton
        '
        Me.RegisterButton.Location = New System.Drawing.Point(332, 383)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(75, 39)
        Me.RegisterButton.TabIndex = 14
        Me.RegisterButton.Text = "登録"
        Me.RegisterButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(442, 383)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 39)
        Me.CancelButton.TabIndex = 15
        Me.CancelButton.Text = "キャンセル"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'MembershopRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 441)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.RegisterButton)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Name = "MembershopRegistration"
        Me.Text = "会員登録"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents IdentityState As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents UserName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Man As RadioButton
    Friend WithEvents Woman As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Day As ComboBox
    Friend WithEvents Month As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Year As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents AddressContent As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents AddressNumber As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents NowDateTextBox As TextBox
    Friend WithEvents RegisterButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents IdentityNumber As TextBox
    Friend WithEvents Tel3 As TextBox
    Friend WithEvents Tel2 As TextBox
    Friend WithEvents Tel1 As TextBox
End Class
