<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReturnDetailForm
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
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.VideoIdGroupBox = New System.Windows.Forms.GroupBox()
        Me.ReturnDays = New System.Windows.Forms.Label()
        Me.UserName = New System.Windows.Forms.Label()
        Me.IdentityNumber = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.VideoIdGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(158, 226)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 18
        Me.CancelButton.Text = "キャンセル"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(53, 226)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 17
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'VideoIdGroupBox
        '
        Me.VideoIdGroupBox.Controls.Add(Me.ReturnDays)
        Me.VideoIdGroupBox.Controls.Add(Me.UserName)
        Me.VideoIdGroupBox.Controls.Add(Me.IdentityNumber)
        Me.VideoIdGroupBox.Controls.Add(Me.Label3)
        Me.VideoIdGroupBox.Controls.Add(Me.Label2)
        Me.VideoIdGroupBox.Controls.Add(Me.Label1)
        Me.VideoIdGroupBox.Location = New System.Drawing.Point(12, 30)
        Me.VideoIdGroupBox.Name = "VideoIdGroupBox"
        Me.VideoIdGroupBox.Size = New System.Drawing.Size(260, 169)
        Me.VideoIdGroupBox.TabIndex = 19
        Me.VideoIdGroupBox.TabStop = False
        Me.VideoIdGroupBox.Text = "ビデオID: "
        '
        'ReturnDays
        '
        Me.ReturnDays.AutoSize = True
        Me.ReturnDays.Location = New System.Drawing.Point(110, 116)
        Me.ReturnDays.Name = "ReturnDays"
        Me.ReturnDays.Size = New System.Drawing.Size(15, 12)
        Me.ReturnDays.TabIndex = 7
        Me.ReturnDays.Text = "あ"
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
        'IdentityNumber
        '
        Me.IdentityNumber.AutoSize = True
        Me.IdentityNumber.Location = New System.Drawing.Point(110, 35)
        Me.IdentityNumber.Name = "IdentityNumber"
        Me.IdentityNumber.Size = New System.Drawing.Size(15, 12)
        Me.IdentityNumber.TabIndex = 5
        Me.IdentityNumber.Text = "あ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "返却予定日"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(78, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 12)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "上記内容を確認してください"
        '
        'ReturnDetailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.VideoIdGroupBox)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.OKButton)
        Me.Name = "ReturnDetailForm"
        Me.Text = "ReturnDetailForm"
        Me.VideoIdGroupBox.ResumeLayout(False)
        Me.VideoIdGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CancelButton As Button
    Friend WithEvents OKButton As Button
    Friend WithEvents VideoIdGroupBox As GroupBox
    Friend WithEvents ReturnDays As Label
    Friend WithEvents UserName As Label
    Friend WithEvents IdentityNumber As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
End Class
