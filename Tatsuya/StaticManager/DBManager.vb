Public Class DBManager

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
    Private Property record As Recordset

    Public Property users As User()
    Public Property videos As Video()
    Public Property loanouts As Loanout()

    Sub New()
        engine = CreateObject("DAO.DBEngine.120")
        database = engine.OpenDatabase("../../Database/TatsuyaDatabase.accdb")
    End Sub

    Sub OpenUsers()
        record = database.OpenRecordset("会員管理")
    End Sub

    Sub OpenVideos()
        record = database.OpenRecordset("ビデオ管理")
    End Sub

    Sub OpenLoanouts()
        record = database.OpenRecordset("貸出管理")
    End Sub

    Sub CloseDatabese()
        record.Clone()
        database.Close()
    End Sub


    Public Function FetchUser(id As String)
        FetchUser = New User(id, "ほげ", "男", New Date(1996, 11, 25), Date.Today, "090-1111-1111", "222-0001", "神奈川県厚木市下荻野", "1111", "保険証")
    End Function

    Public Function FetchVideo(id As String)
        FetchVideo = New Video(id, "工房大乱闘", "18禁", "ソフトウェア工房", New Date(2014, 10, 20))
    End Function

    Public Shared Sub Delete()
        'id = ""
        'name = ""
        'identityNumber = ""
        'identityState = ""
        'jender = ""
        'birthday = ""
        'tel = ""
        'addressNumber = ""
        'addressContent = ""
    End Sub
End Class
