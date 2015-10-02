Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.BackColor = Color.Chocolate Then
            Me.BackColor = Color.Aquamarine
        ElseIf Me.BackColor = Color.Aquamarine Then
            Me.BackColor = Color.Chocolate
        End If
    End Sub
End Class
