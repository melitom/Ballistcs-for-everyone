Public Class Klíč

    Private Sub Klíč_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Hlavní_okno.Enabled = True
    End Sub

    Private Sub button_aktivovat_Click(sender As Object, e As EventArgs) Handles button_aktivovat.Click
        My.Settings.privitani_uzivatele = True
        My.Settings.Save()
        Me.Close()
    End Sub
End Class