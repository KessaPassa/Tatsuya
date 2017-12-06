Public Class DBManager

    Public Shared Property id As String
    Public Shared Property name As String
    Public Shared Property identityNumber As String
    Public Shared Property identityState As String
    Public Shared Property jender As String
    Public Shared Property birthday As String
    Public Shared Property tel As String
    Public Shared Property addressNumber As String
    Public Shared Property addressContent As String

    Public Shared Sub Delete()
        id = ""
        name = ""
        identityNumber = ""
        identityState = ""
        jender = ""
        birthday = ""
        tel = ""
        addressNumber = ""
        addressContent = ""
    End Sub

    '退会処理のメッセージを表示し、YesかNoかを返す
    Public Shared Function IsShownWithdraw()
        'メッセージボックス表示
        Dim message As String =
            "会員番号: " & id & Environment.NewLine &
            "----" & Environment.NewLine &
            "身分証明書: " & identityNumber & Environment.NewLine &
            "身分証種別: " & identityState & Environment.NewLine &
            "氏名: " & name & Environment.NewLine &
            "性別: " & jender & Environment.NewLine &
            "生年月日: " & birthday & Environment.NewLine &
            "電話番号: " & tel & Environment.NewLine &
            "郵便番号: " & addressNumber & Environment.NewLine &
            "住所: " & addressContent & Environment.NewLine &
            "----" & Environment.NewLine &
            "以上の情報を解約してよろしいですか？"

        Dim result As DialogResult = MessageBox.Show(message, "会員情報確認", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            IsShownWithdraw = True
        Else
            IsShownWithdraw = False
        End If
    End Function
End Class
