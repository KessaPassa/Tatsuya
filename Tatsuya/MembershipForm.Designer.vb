<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MembershipForm
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
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.WithDrawalButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RegisterButton
        '
        Me.RegisterButton.Location = New System.Drawing.Point(28, 69)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(226, 93)
        Me.RegisterButton.TabIndex = 0
        Me.RegisterButton.Text = "会員登録"
        Me.RegisterButton.UseVisualStyleBackColor = True
        '
        'WithDrawalButton
        '
        Me.WithDrawalButton.Location = New System.Drawing.Point(28, 194)
        Me.WithDrawalButton.Name = "WithDrawalButton"
        Me.WithDrawalButton.Size = New System.Drawing.Size(89, 39)
        Me.WithDrawalButton.TabIndex = 1
        Me.WithDrawalButton.Text = "会員退会"
        Me.WithDrawalButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(165, 194)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(89, 39)
        Me.CancelButton.TabIndex = 2
        Me.CancelButton.Text = "キャンセル"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'MembershipForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.WithDrawalButton)
        Me.Controls.Add(Me.RegisterButton)
        Me.Name = "MembershipForm"
        Me.Text = "会員管理メニュー"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RegisterButton As Button
    Friend WithEvents WithDrawalButton As Button
    Friend WithEvents CancelButton As Button
End Class
