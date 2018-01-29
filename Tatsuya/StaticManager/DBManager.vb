Public Class DBManager

    Public Enum Type
        user
        video
        loanout
    End Enum

    'Public Shared Property instance As DBManager = New DBManager()
    Private Shared Property engine = New DBEngine
    Private Shared Property database As Database
    Private Shared Property record As Recordset

    Private Shared Sub OpenDatabase(sql As String)
        database = engine.OpenDatabase("..\..\..\Database\TatsuyaDatabase.mdb")
        record = database.OpenRecordset(sql)
    End Sub

    Private Shared Sub CloseDatabese()
        record.Clone()
        database.Close()
    End Sub

    Public Shared Sub Save(obj As Object, type As Type)

        Select Case type
            Case Type.user
                Dim user = CType(obj, User)
                OpenDatabase("会員管理")
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
                OpenDatabase("ビデオ管理")
                record.AddNew()
                record.Fields("ビデオ番号").Value = video.id
                record.Fields("タイトル").Value = video.title
                record.Fields("販売元").Value = video.company
                record.Fields("購入日").Value = video.purchace_day
                record.Fields("価格").Value = video.pay

            Case Type.loanout
                Dim loanout = CType(obj, Loanout)
                OpenDatabase("貸出管理")
                record.AddNew()
                record.Fields("会員番号").Value = loanout.user_id
                record.Fields("ビデオ番号").Value = loanout.video_id
                record.Fields("貸出日").Value = loanout.that_date
                record.Fields("貸出日数").Value = loanout.days

        End Select

        Try
            record.Update()
        Catch ex As Exception
            MsgBox("データの保存に失敗しました")
            Application.Exit()
        End Try

        CloseDatabese()
    End Sub

    Public Shared Sub SaveVideos(videos As List(Of Video))
        OpenDatabase("ビデオ管理")

        For Each video In videos
            Dim genre = video.id.Substring(0, 2)
            Dim count = video.id.Substring(2, 2)

            record.AddNew()
            For i = 0 To 100
                Dim isTapled = False
                Dim id = String.Format("{0:D2}", i)
                id = genre & i & count
                record.Fields("ビデオ番号").Value = id
                record.Fields("タイトル").Value = video.title
                record.Fields("販売元").Value = video.company
                record.Fields("購入日").Value = video.purchace_day
                record.Fields("価格").Value = video.pay
                Try
                    record.Update()
                Catch ex As Exception
                    isTapled = True
                End Try

                If Not isTapled Then
                    Exit For
                ElseIf i = 100 Then
                    MsgBox("データの保存に失敗しました")
                    Application.Exit()
                End If
            Next
        Next

        CloseDatabese()
    End Sub

    Public Shared Sub Delete(id As String, type As Type)

        Dim sql As String
        Select Case type
            Case Type.user
                sql = "select * from 会員管理 where 会員番号 = '" & id & "'"

            Case Else
                Exit Sub
        End Select

        OpenDatabase(sql)
        Try
            record.Delete()
        Catch ex As Exception
            MsgBox("削除に失敗しました")
            Application.Exit()
        End Try

        CloseDatabese()
    End Sub

    'そのIDが存在するか調べる
    Public Shared Function IsExitId(id As String, type As Type) As Boolean

        Dim sql As String
        Select Case type
            Case Type.user
                sql = "select 会員番号 from 会員管理 where 会員番号 = '" & id & "'"

            Case Type.video
                sql = "select ビデオ番号 from ビデオ管理 where ビデオ番号 = '" & id & "'"

            Case Type.loanout
                sql = "select 会員番号 from 貸出管理 where 会員番号 = '" & id & "'"

            Case Else
                IsExitId = False
                Exit Function
        End Select

        OpenDatabase(sql)
        Try
            'IDが存在すると何故かエラー吐くので
            record.FindFirst(id)
        Catch ex As Exception
            '何もしない
        End Try

        If record.NoMatch Then
            IsExitId = False
        Else
            IsExitId = True
        End If

        CloseDatabese()
    End Function

    Public Shared Function Fetch(id As String, type As Type) As Object

        Dim obj = Nothing
        If Not IsExitId(id, type) Then
            MsgBox("その番号は存在しません")
            Fetch = obj
            Exit Function
        End If

        Select Case type
            Case Type.user
                Dim sql = "select * from 会員管理 where 会員番号 = '" & id & "'"
                OpenDatabase(sql)
                obj = New User(
                    record.Fields("会員番号").Value,
                    record.Fields("氏名").Value,
                    record.Fields("性別").Value,
                    record.Fields("生年月日").Value,
                    record.Fields("入会日").Value,
                    record.Fields("電話番号").Value,
                    record.Fields("郵便番号").Value,
                    record.Fields("住所").Value,
                    record.Fields("身分証明書種別").Value,
                    record.Fields("身分証明書番号").Value
                )

            Case Type.video
                Dim sql = "select * from ビデオ管理 where ビデオ番号 = '" & id & "'"
                OpenDatabase(sql)
                obj = New Video(
                    record.Fields("ビデオ番号").Value,
                    record.Fields("タイトル").Value,
                    record.Fields("販売元").Value,
                    record.Fields("購入日").Value,
                    record.Fields("価格").Value
)

            Case Type.loanout
                Dim sql = "select * from 貸出管理 where 会員番号 = '" & id & "'"
                OpenDatabase(sql)
                obj = New Loanout(
                    record.Fields("会員番号").Value,
                    record.Fields("ビデオ番号").Value,
                    record.Fields("貸出日").Value,
                    record.Fields("貸出日数").Value
                )
        End Select

        CloseDatabese()
        Fetch = obj
    End Function

    Public Shared Function FetchIdentity(identity As String, state As String, name As String) As User
        Dim sql = "select * from 会員管理 where 身分証明書番号 = '" & identity & "' and 身分証明書種別 = '" & state & "' and 氏名 = '" & name & "'"
        OpenDatabase(sql)
        Dim obj = Nothing
        Try
            obj = New User(
            record.Fields("会員番号").Value,
            record.Fields("氏名").Value,
            record.Fields("性別").Value,
            record.Fields("生年月日").Value,
            record.Fields("入会日").Value,
            record.Fields("電話番号").Value,
            record.Fields("郵便番号").Value,
            record.Fields("住所").Value,
            record.Fields("身分証明書種別").Value,
            record.Fields("身分証明書番号").Value
        )
        Catch ex As Exception
            MsgBox("その番号は存在しません")
            FetchIdentity = obj
        End Try

        CloseDatabese()
        FetchIdentity = obj
    End Function

    Public Shared Function GetLastNumber() As Integer
        Dim sql = "select 会員番号 from 会員管理"
        OpenDatabase(sql)
        record.MoveLast()
        Dim last = record.Fields("会員番号").Value
        CloseDatabese()
        GetLastNumber = CInt(last) + 1
    End Function
End Class
