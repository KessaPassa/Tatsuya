Public Class Provision

    Private Const _CHECK_MESSAGE = "入力されていない項目があります"
    Public Shared ReadOnly Property CHECK_MESSAGE As String
        Get
            Return _CHECK_MESSAGE
        End Get
    End Property

    Public Shared Sub AddItem(ByVal comboBox As ComboBox)
        Dim items() As String = {
             "保険証",
            "免許証"
        }

        For Each item In items
            comboBox.Items.Add(item)
        Next
    End Sub

    '入力されていないか調べる
    Public Shared Function IsEmpty(items() As Object, Optional message As String = _CHECK_MESSAGE)
        For Each item In items
            If item.Equals("") Or item.Equals(-1) Or item.Equals(False) Then
                MsgBox(message)
                IsEmpty = True
                Exit Function
            End If
        Next

        IsEmpty = False
    End Function


End Class
