Public Class Nápověda
    Private Sub Button_Spočítej_Click(sender As Object, e As EventArgs) Handles Button_Spočítej.Click
        Hlavní_okno.Enabled = True
        Me.Close()
    End Sub

    Private Sub Nápověda_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Hlavní_okno.Enabled = True
    End Sub
End Class