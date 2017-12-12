Public Class DBManager

    Public Enum Type
        user
        video
        loanout
    End Enum

    'Public Shared Property id As String
    'Public Shared Property name As String
    'Public Shared Property identityNumber As String
    'Public Shared Property identityState As String
    'Public Shared Property jender As String
    'Public Shared Property birthday As String
    'Public Shared Property tel As String
    'Public Shared Property addressNumber As String
    'Public Shared Property addressContent As String


    Public Shared Property instance As DBManager = New DBManager()
    Private Property engine As DBEngine
    Private Property database As Database
    Public Property record As Recordset

    Public Property users As User()
    Public Property videos As Video()
    Public Property loanouts As Loanout()

    Sub New()
        engine = New DBEngine
        database = engine.OpenDatabase("..\..\..\Database\TatsuyaDatabase.mdb")
    End Sub

    Sub OpenDatabase(type As Type)

        Select Case type
            Case Type.user
                record = database.OpenRecordset("会員管理")

            Case Type.video
                record = database.OpenRecordset("ビデオ管理")

            Case Type.loanout
                record = database.OpenRecordset("貸出管理")
        End Select
    End Sub

    Sub CloseDatabese()
        record.Clone()
        database.Close()
    End Sub

    Sub Save(obj As Object, type As Type)

        OpenDatabase(type)
        Select Case type
            Case Type.user
                Dim user = CType(obj, User)
                record.AddNew()
                record.Fields("会員番号").Value = user.id
                record.Fields("氏名").Value = user.name
                record.Fields("性別").Value = user.jender
                record.Fields("生年月日").Value = user.birthday
                record.Fields("入会日").Value = user.registerday
                record.Fields("電話番号").Value = user.tel
                record.Fields("郵便番号").Value = user.address_number
                record.Fields("住所").Value = user.address_content
                record.Fields("身分証明書種別").Value = user.identity_state
                record.Fields("身分証明書番号").Value = user.identity_number

            Case Type.video
                Dim video = CType(obj, Video)
                record.Fields("ビデオ番号").Value = video.id
                record.Fields("タイトル").Value = video.title
                record.Fields("販売元").Value = video.purchace_company
                record.Fields("購入日").Value = video.purchace_day
                record.Fields("価格").Value = video.pay
                record.Fields("年齢制限").Value = video.limited_age

            Case Type.loanout
                Dim loanout = CType(obj, Loanout)

        End Select
        record.Update()
        CloseDatabese()
    End Sub

    Public Function FetchUser(id As String)
        FetchUser = New User(id, "ほげ", "男", New Date(1996, 11, 25), Date.Today, "090-1111-1111", "222-0001", "神奈川県厚木市下荻野", "1111", "I")
    End Function

    Public Function FetchVideo(id As String)
        FetchVideo = New Video(id, "工房大乱闘", "18禁", "ソフトウェア工房", New Date(2014, 10, 20), 10000)
    End Function

    Public Shared Sub Delete()

    End Sub
End Class
