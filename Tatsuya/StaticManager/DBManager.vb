﻿Public Class DBManager

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
                record.Fields("販売元").Value = video.purchace_company
                record.Fields("購入日").Value = video.purchace_day
                record.Fields("価格").Value = video.pay
                record.Fields("年齢制限").Value = video.limited_age

            Case Type.loanout
                Dim loanout = CType(obj, Loanout)
                OpenDatabase("貸出管理")

        End Select

        Try
            record.Update()
        Catch ex As Exception
            MsgBox("データの保存に失敗しました")
        End Try

        CloseDatabese()
    End Sub

    Public Shared Sub Delete(id As String, type As Type)

        Select Case type
            Case Type.user
                Dim sql = "select * from 会員管理 where 会員番号 = '" & id & "'"
                OpenDatabase(sql)

        End Select

        Try
            record.Delete()
        Catch ex As Exception
            MsgBox("その番号は存在しません")
        End Try

        CloseDatabese()
    End Sub

    'そのIDが存在するか調べる
    Public Shared Function IsExitID(id As String, type As Type)

        Dim sql As String
        Select Case type
            Case Type.user
                sql = "select 会員番号 from 会員管理 where 会員番号 = '" & id & "'"


            Case Else
                IsExitID = False
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
            IsExitID = False
        Else
            IsExitID = True
        End If

        CloseDatabese()
    End Function

    Public Shared Function Fetch(id As String, type As Type)

        Dim obj = Nothing
        If Not IsExitID(id, type) Then
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
                    record.Fields("価格").Value,
                    record.Fields("年齢制限").Value
                )

            Case Type.loanout
                OpenDatabase("貸出管理")

        End Select

        CloseDatabese()
        Fetch = obj
    End Function

    Public Shared Function FetchVideo(id As String)
        FetchVideo = New Video(id, "工房大乱闘", "18禁", "ソフトウェア工房", New Date(2014, 10, 20), 10000)
    End Function
End Class
