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




    'Public Shared Property data = New Dictionary(Of String, String) From {
    '    {"id", ""},
    '    {"name", ""},
    '    {"identityNubber", ""},
    '    {"identityContent", ""},
    '    {"jender", ""},
    '    {"birthday", ""},
    '    {"tel", ""},
    '    {"addressNumber", ""},
    '    {"addressContent", ""}
    '}
End Class
