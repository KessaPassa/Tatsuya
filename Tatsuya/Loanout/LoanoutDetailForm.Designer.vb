<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoanoutDetailForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UserAge = New System.Windows.Forms.Label()
        Me.UserName = New System.Windows.Forms.Label()
        Me.IdentityNuber = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MessageBox = New System.Windows.Forms.GroupBox()
        Me.MessageLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CountLabel = New System.Windows.Forms.Label()
        Me.SumCount = New System.Windows.Forms.Label()
        Me.PayLabel = New System.Windows.Forms.Label()
        Me.SumPay = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.MessageBox.SuspendLayout()
        Me.TableLayoutPanel.SuspendLayout()
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
        'MessageBox
        '
        Me.MessageBox.Controls.Add(Me.MessageLabel)
        Me.MessageBox.ForeColor = System.Drawing.Color.DarkRed
        Me.MessageBox.Location = New System.Drawing.Point(280, 42)
        Me.MessageBox.Name = "MessageBox"
        Me.MessageBox.Size = New System.Drawing.Size(381, 119)
        Me.MessageBox.TabIndex = 8
        Me.MessageBox.TabStop = False
        '
        'MessageLabel
        '
        Me.MessageLabel.AutoSize = True
        Me.MessageLabel.Location = New System.Drawing.Point(6, 13)
        Me.MessageLabel.Name = "MessageLabel"
        Me.MessageLabel.Size = New System.Drawing.Size(0, 12)
        Me.MessageLabel.TabIndex = 0
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
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel.AutoSize = True
        Me.TableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel.ColumnCount = 8
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.80851!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.19149!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel.Controls.Add(Me.Label14, 6, 0)
        Me.TableLayoutPanel.Controls.Add(Me.Label13, 5, 0)
        Me.TableLayoutPanel.Controls.Add(Me.Label12, 4, 0)
        Me.TableLayoutPanel.Controls.Add(Me.Label11, 3, 0)
        Me.TableLayoutPanel.Controls.Add(Me.Label10, 2, 0)
        Me.TableLayoutPanel.Controls.Add(Me.Label9, 1, 0)
        Me.TableLayoutPanel.Controls.Add(Me.Label8, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.Label5, 7, 0)
        Me.TableLayoutPanel.Controls.Add(Me.CountLabel, 3, 1)
        Me.TableLayoutPanel.Controls.Add(Me.SumCount, 4, 1)
        Me.TableLayoutPanel.Controls.Add(Me.PayLabel, 5, 1)
        Me.TableLayoutPanel.Controls.Add(Me.SumPay, 6, 1)
        Me.TableLayoutPanel.Location = New System.Drawing.Point(20, 186)
        Me.TableLayoutPanel.MaximumSize = New System.Drawing.Size(0, 192)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 2
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(641, 72)
        Me.TableLayoutPanel.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(523, 2)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 33)
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
        Me.Label13.Location = New System.Drawing.Point(442, 2)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 33)
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
        Me.Label12.Location = New System.Drawing.Point(376, 2)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 33)
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
        Me.Label11.Location = New System.Drawing.Point(290, 2)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 33)
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
        Me.Label10.Location = New System.Drawing.Point(228, 2)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 33)
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
        Me.Label9.Location = New System.Drawing.Point(65, 2)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 33)
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
        Me.Label8.Size = New System.Drawing.Size(52, 33)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ビデオID"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(582, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 33)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "削除"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CountLabel
        '
        Me.CountLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CountLabel.AutoSize = True
        Me.CountLabel.Location = New System.Drawing.Point(290, 37)
        Me.CountLabel.Name = "CountLabel"
        Me.CountLabel.Size = New System.Drawing.Size(78, 33)
        Me.CountLabel.TabIndex = 7
        Me.CountLabel.Text = "貸出本数"
        Me.CountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SumCount
        '
        Me.SumCount.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SumCount.AutoSize = True
        Me.SumCount.Location = New System.Drawing.Point(376, 37)
        Me.SumCount.Name = "SumCount"
        Me.SumCount.Size = New System.Drawing.Size(58, 33)
        Me.SumCount.TabIndex = 8
        Me.SumCount.Text = "0"
        Me.SumCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PayLabel
        '
        Me.PayLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PayLabel.AutoSize = True
        Me.PayLabel.Location = New System.Drawing.Point(442, 37)
        Me.PayLabel.Name = "PayLabel"
        Me.PayLabel.Size = New System.Drawing.Size(73, 33)
        Me.PayLabel.TabIndex = 9
        Me.PayLabel.Text = "料金合計"
        Me.PayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SumPay
        '
        Me.SumPay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SumPay.AutoSize = True
        Me.SumPay.Location = New System.Drawing.Point(523, 37)
        Me.SumPay.Name = "SumPay"
        Me.SumPay.Size = New System.Drawing.Size(51, 33)
        Me.SumPay.TabIndex = 10
        Me.SumPay.Text = "0"
        Me.SumPay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(586, 406)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 14
        Me.CancelButton.Text = "キャンセル"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'LoanoutDetailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 441)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.MessageBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "LoanoutDetailForm"
        Me.Text = "貸出情報入力"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MessageBox.ResumeLayout(False)
        Me.MessageBox.PerformLayout()
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel.PerformLayout()
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
    Friend WithEvents MessageBox As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TableLayoutPanel As TableLayoutPanel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents SumPay As Label
    Friend WithEvents PayLabel As Label
    Friend WithEvents SumCount As Label
    Friend WithEvents CountLabel As Label
    Friend WithEvents MessageLabel As Label
    Friend WithEvents OKButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents Label5 As Label
End Class
