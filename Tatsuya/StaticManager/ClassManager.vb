Public Class User
    Property id As String
    Property name As String
    Property jender As String
    Property birthday As Date
    Property registerday As Date
    Property tel As String
    Property address_number As String
    Property address_content As String
    Property identity_number As String
    Property identity_state As String

    Sub New(id As String, name As String, jender As String, birthday As Date, registerday As Date, tel As String,
            address_number As String, address_content As String, identity_number As String, identity_state As String)

        Me.id = id
        Me.name = name
        Me.jender = jender
        Me.birthday = birthday
        Me.registerday = registerday
        Me.tel = tel
        Me.address_number = address_number
        Me.address_content = address_content
        Me.identity_number = identity_number
        Me.identity_state = identity_state
    End Sub

    Public Function NowAge()
        NowAge = Int((Date.Today - birthday).TotalDays / 365)
    End Function

    '退会処理のメッセージを表示し、YesかNoかを返す
    Public Function IsShownWithdraw() As Boolean
        'メッセージボックス表示
        Dim message As String =
            "会員番号: " & id & Environment.NewLine &
            "----" & Environment.NewLine &
            "身分証明書: " & identity_number & Environment.NewLine &
            "身分証種別: " & identity_state & Environment.NewLine &
            "氏名: " & name & Environment.NewLine &
            "性別: " & jender & Environment.NewLine &
            "生年月日: " & birthday & Environment.NewLine &
            "電話番号: " & tel & Environment.NewLine &
            "郵便番号: " & address_number & Environment.NewLine &
            "住所: " & address_content & Environment.NewLine &
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

Public Class Video
    Property id As String
    Property title As String
    Property purchace_company As String
    Property purchace_day As Date
    Property pay As Integer

    Sub New(id As String, title As String, purchace_company As String, purchace_day As Date, pay As Integer)

        Me.id = id
        Me.title = title
        Me.purchace_company = purchace_company
        Me.purchace_day = purchace_day
        Me.pay = pay
    End Sub
End Class

Public Class Loanout
    Property user_id As String
    Property video_id As String
    Property that_date As Date
    Property days As Integer

    Sub New(user_id As String, video_id As String, that_date As Date, days As Integer)

        Me.user_id = user_id
        Me.video_id = video_id
        Me.that_date = that_date
        Me.days = days
    End Sub

    Function ConvertUser() As User

        Dim user As User = DBManager.Fetch(user_id, DBManager.Type.user)
        ConvertUser = user
    End Function
End Class

Public Class LendData
    Property days As String
    Property limit As String
    Property pay As Integer

    Sub New(days As String, limit As String, pay As Integer)

        Me.days = days
        Me.limit = limit
        Me.pay = pay
    End Sub
End Class

Public Class GenreData
    Property code As String
    Property genre As String
    Property limited_age As String

    Sub New(code As String, genre As String, Optional limited_age As String = "なし")

        Me.code = code
        Me.genre = genre
        Me.limited_age = limited_age
    End Sub
End Class