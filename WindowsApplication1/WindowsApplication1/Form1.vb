Public Class Form123

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles gantiButton.Click
        If Me.BackColor = Color.Blue Then
            Me.BackColor = Color.Red
        ElseIf Me.BackColor = Color.Red Then
            Me.BackColor = Color.Blue
        End If
    End Sub
End Class
