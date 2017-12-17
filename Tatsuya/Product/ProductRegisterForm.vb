Public Class ProductRegisterForm
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If Provision.OnlyNumeric(e) = False Then
            Exit Sub
        End If
    End Sub
End Class