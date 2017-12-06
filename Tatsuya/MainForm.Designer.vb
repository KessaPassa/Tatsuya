<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.LendButton = New System.Windows.Forms.Button()
        Me.MemberButton = New System.Windows.Forms.Button()
        Me.ReturnButton = New System.Windows.Forms.Button()
        Me.ProductButton = New System.Windows.Forms.Button()
        Me.TimerLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LendButton
        '
        Me.LendButton.Location = New System.Drawing.Point(12, 53)
        Me.LendButton.Name = "LendButton"
        Me.LendButton.Size = New System.Drawing.Size(117, 62)
        Me.LendButton.TabIndex = 0
        Me.LendButton.Text = "貸出業務"
        Me.LendButton.UseVisualStyleBackColor = True
        '
        'MemberButton
        '
        Me.MemberButton.Location = New System.Drawing.Point(155, 53)
        Me.MemberButton.Name = "MemberButton"
        Me.MemberButton.Size = New System.Drawing.Size(117, 62)
        Me.MemberButton.TabIndex = 1
        Me.MemberButton.Text = "会員管理"
        Me.MemberButton.UseVisualStyleBackColor = True
        '
        'ReturnButton
        '
        Me.ReturnButton.Location = New System.Drawing.Point(12, 153)
        Me.ReturnButton.Name = "ReturnButton"
        Me.ReturnButton.Size = New System.Drawing.Size(117, 62)
        Me.ReturnButton.TabIndex = 2
        Me.ReturnButton.Text = "返却業務"
        Me.ReturnButton.UseVisualStyleBackColor = True
        '
        'ProductButton
        '
        Me.ProductButton.Location = New System.Drawing.Point(155, 153)
        Me.ProductButton.Name = "ProductButton"
        Me.ProductButton.Size = New System.Drawing.Size(117, 62)
        Me.ProductButton.TabIndex = 3
        Me.ProductButton.Text = "商品管理"
        Me.ProductButton.UseVisualStyleBackColor = True
        '
        'TimerLabel
        '
        Me.TimerLabel.AutoSize = True
        Me.TimerLabel.Location = New System.Drawing.Point(134, 229)
        Me.TimerLabel.Name = "TimerLabel"
        Me.TimerLabel.Size = New System.Drawing.Size(13, 12)
        Me.TimerLabel.TabIndex = 4
        Me.TimerLabel.Text = "　"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.TimerLabel)
        Me.Controls.Add(Me.ProductButton)
        Me.Controls.Add(Me.ReturnButton)
        Me.Controls.Add(Me.MemberButton)
        Me.Controls.Add(Me.LendButton)
        Me.Name = "MainForm"
        Me.Text = "ビデオレンタルシステム メインメニュー"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LendButton As Button
    Friend WithEvents MemberButton As Button
    Friend WithEvents ReturnButton As Button
    Friend WithEvents ProductButton As Button
    Friend WithEvents TimerLabel As Label
End Class
