Public Class Loanout
    Property days As String
    Property pay As Integer
    Property limit As Integer

    Sub New(days As String, pay As Integer, limit As Integer)
        Me.days = days
        Me.pay = pay
        Me.limit = limit
    End Sub
End Class

Public Class Video
    Property id As String
    Property title As String
    Property limitedAge As String

    Sub New(id As String, title As String, imitedAge As String)
        Me.id = id
        Me.title = title
        Me.limitedAge = limitedAge
    End Sub
End Class