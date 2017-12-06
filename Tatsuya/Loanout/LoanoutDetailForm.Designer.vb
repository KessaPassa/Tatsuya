<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoanoutDetailForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UserAge = New System.Windows.Forms.Label()
        Me.UserName = New System.Windows.Forms.Label()
        Me.IdentityNuber = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SumPayLabel = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CountLabel = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UserAge)
        Me.GroupBox1.Controls.Add(Me.UserName)
        Me.GroupBox1.Controls.Add(Me.IdentityNuber)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 141)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "会員情報"
        '
        'UserAge
        '
        Me.UserAge.AutoSize = True
        Me.UserAge.Location = New System.Drawing.Point(110, 116)
        Me.UserAge.Name = "UserAge"
        Me.UserAge.Size = New System.Drawing.Size(15, 12)
        Me.UserAge.TabIndex = 7
        Me.UserAge.Text = "あ"
        '
        'UserName
        '
        Me.UserName.AutoSize = True
        Me.UserName.Location = New System.Drawing.Point(110, 75)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(15, 12)
        Me.UserName.TabIndex = 6
        Me.UserName.Text = "あ"
        '
        'IdentityNuber
        '
        Me.IdentityNuber.AutoSize = True
        Me.IdentityNuber.Location = New System.Drawing.Point(110, 35)
        Me.IdentityNuber.Name = "IdentityNuber"
        Me.IdentityNuber.Size = New System.Drawing.Size(15, 12)
        Me.IdentityNuber.TabIndex = 5
        Me.IdentityNuber.Text = "あ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "年齢"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "氏名"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "会員番号"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(280, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(381, 119)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(278, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 12)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "メッセージ"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label14, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label13, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SumPayLabel, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label16, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.CountLabel, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label15, 3, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(20, 186)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(641, 70)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(570, 2)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 32)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "料金"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(486, 2)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 32)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "返却日"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(402, 2)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 32)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "貸出日数"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(322, 2)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 32)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "貸出日"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(260, 2)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 32)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "年齢制限"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(82, 2)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(170, 32)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "タイトル"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 2)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 32)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ビデオID"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SumPayLabel
        '
        Me.SumPayLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SumPayLabel.AutoSize = True
        Me.SumPayLabel.Location = New System.Drawing.Point(570, 36)
        Me.SumPayLabel.Name = "SumPayLabel"
        Me.SumPayLabel.Size = New System.Drawing.Size(66, 32)
        Me.SumPayLabel.TabIndex = 10
        Me.SumPayLabel.Text = "0"
        Me.SumPayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(486, 36)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(76, 32)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "料金合計"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CountLabel
        '
        Me.CountLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CountLabel.AutoSize = True
        Me.CountLabel.Location = New System.Drawing.Point(402, 36)
        Me.CountLabel.Name = "CountLabel"
        Me.CountLabel.Size = New System.Drawing.Size(76, 32)
        Me.CountLabel.TabIndex = 8
        Me.CountLabel.Text = "0"
        Me.CountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(322, 36)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 32)
        Me.Label15.TabIndex = 7
        Me.Label15.Text = "貸出本数"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(586, 406)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 14
        Me.CancelButton.Text = "キャンセル"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(481, 406)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 13
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'LoanoutDetailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 441)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "LoanoutDetailForm"
        Me.Text = "貸出情報入力"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents UserAge As Label
    Friend WithEvents UserName As Label
    Friend WithEvents IdentityNuber As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents SumPayLabel As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents CountLabel As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents CancelButton As Button
    Friend WithEvents OKButton As Button
End Class
