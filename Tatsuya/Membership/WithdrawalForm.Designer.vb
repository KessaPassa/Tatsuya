<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WithdrawalForm
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
        Me.WithMembershopButton = New System.Windows.Forms.Button()
        Me.WitClosentityButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "解約方法を選択して下さい"
        '
        'WithMembershopButton
        '
        Me.WithMembershopButton.Location = New System.Drawing.Point(21, 117)
        Me.WithMembershopButton.Name = "WithMembershopButton"
        Me.WithMembershopButton.Size = New System.Drawing.Size(111, 51)
        Me.WithMembershopButton.TabIndex = 1
        Me.WithMembershopButton.Text = "会員証で解約"
        Me.WithMembershopButton.UseVisualStyleBackColor = True
        '
        'WitClosentityButton
        '
        Me.WitClosentityButton.Location = New System.Drawing.Point(147, 117)
        Me.WitClosentityButton.Name = "WitClosentityButton"
        Me.WitClosentityButton.Size = New System.Drawing.Size(111, 51)
        Me.WitClosentityButton.TabIndex = 2
        Me.WitClosentityButton.Text = "身分証で解約"
        Me.WitClosentityButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(183, 226)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 3
        Me.CancelButton.Text = "キャンセル"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'WithdrawalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.WitClosentityButton)
        Me.Controls.Add(Me.WithMembershopButton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "WithdrawalForm"
        Me.Text = "会員退会"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents WithMembershopButton As Button
    Friend WithEvents WitClosentityButton As Button
    Friend WithEvents CancelButton As Button
End Class
