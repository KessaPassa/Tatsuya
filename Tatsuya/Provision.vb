Public Class Provision

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
    Public Shared Function IsEmpty(items())
        For Each item In items
            If item.Equals("") Or item.Equals(-1) Or item.Equals(False) Then
                IsEmpty = True
                Exit Function
            End If
        Next

        IsEmpty = False
    End Function
End Class
