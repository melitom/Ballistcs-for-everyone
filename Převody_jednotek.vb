Imports System.Math
Public Class Převody_jednotek
    Dim chyba As Boolean = False
    Dim základní_jednotka_rychlost As Decimal = 0
    Dim základní_jednotka_hmotnost As Decimal = 0
    Dim základní_jednotka_délka As Decimal = 0
    Dim základní_jednotka_uhel As Decimal = 0
    Dim základní_jednotka_energie As Decimal = 0
    Dim zaokrouhleni As Integer = 0
    Private Sub button_zavřít_Click(sender As Object, e As EventArgs) Handles button_zavřít.Click
        ulozeni_pameti()
        Hlavní_okno.Enabled = True
        Me.Hide()
    End Sub

    Private Sub button_spočítej_Click(sender As Object, e As EventArgs) Handles button_spočítej.Click
        chyba = False
        kontrola_textboxů()
        If chyba = False Then
            výpočet()
            zápis_výsledků()
            ulozeni_pameti()
        End If
    End Sub
    Private Sub kontrola_textboxů()
        Dim zkušební_proměnná As Decimal = 0
        zaokrouhleni = combobox_zaokrouhleni.Text
        Try
            textbox_jednotky_rychlosti.Text = textbox_jednotky_rychlosti.Text.Replace(".", ",")
            textbox_jednotky_hmotnosti.Text = textbox_jednotky_hmotnosti.Text.Replace(".", ",")
            textbox_jednotky_délky.Text = textbox_jednotky_délky.Text.Replace(".", ",")
            textbox_jednotky_energie.Text = textbox_jednotky_energie.Text.Replace(".", ",")
            textbox_jednotky_uhel.Text = textbox_jednotky_uhel.Text.Replace(".", ",")

            If textbox_jednotky_rychlosti.Text = "" Then
                zkušební_proměnná = 0
                textbox_jednotky_rychlosti.Text = "0"
            End If
            zkušební_proměnná = textbox_jednotky_rychlosti.Text
            If zkušební_proměnná < 0 Then
                chyba = True
                MsgBox("The velocity cannot be less than zero.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("Wrong data about velocity.", MsgBoxStyle.Exclamation)
            chyba = True
        End Try

        Try
            If textbox_jednotky_hmotnosti.Text = "" Then
                zkušební_proměnná = 0
                textbox_jednotky_hmotnosti.Text = "0"
            End If
            zkušební_proměnná = textbox_jednotky_hmotnosti.Text
            If zkušební_proměnná < 0 Then
                chyba = True
                MsgBox("The weight cannot be less than zero.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("Wrong data about weight.", MsgBoxStyle.Exclamation)
            chyba = True
        End Try

        Try
            If textbox_jednotky_délky.Text = "" Then
                zkušební_proměnná = 0
                textbox_jednotky_délky.Text = "0"
            End If
            zkušební_proměnná = textbox_jednotky_délky.Text
            If zkušební_proměnná < 0 Then
                chyba = True
                MsgBox("The lenght cannot be less than zero.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("Wrong data about length.", MsgBoxStyle.Exclamation)
            chyba = True
        End Try

        Try
            If textbox_jednotky_uhel.Text = "" Then
                zkušební_proměnná = 0
                textbox_jednotky_uhel.Text = "0"
            End If
            zkušební_proměnná = textbox_jednotky_uhel.Text
            If zkušební_proměnná < 0 Then
                chyba = True
                MsgBox("The angle cannot be less than zero.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("Wrong data about angle.", MsgBoxStyle.Exclamation)
            chyba = True
        End Try

        Try
            If textbox_jednotky_energie.Text = "" Then
                zkušební_proměnná = 0
                textbox_jednotky_energie.Text = "0"
            End If
            zkušební_proměnná = textbox_jednotky_energie.Text
            If zkušební_proměnná < 0 Then
                chyba = True
                MsgBox("The energy cannot be less than zero.", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox("Wrong data about energy.", MsgBoxStyle.Exclamation)
            chyba = True
        End Try
    End Sub
    Private Sub výpočet()
        If combobox_jednotky_rychlosti.Text = "m/s" Then
            základní_jednotka_rychlost = textbox_jednotky_rychlosti.Text * 1
        ElseIf combobox_jednotky_rychlosti.Text = "fps" Then
            základní_jednotka_rychlost = textbox_jednotky_rychlosti.Text * 0.3048
        ElseIf combobox_jednotky_rychlosti.Text = "km/h" Then
            základní_jednotka_rychlost = textbox_jednotky_rychlosti.Text * 0.277777778
        ElseIf combobox_jednotky_rychlosti.Text = "mph" Then
            základní_jednotka_rychlost = textbox_jednotky_rychlosti.Text * 0.44704
        ElseIf combobox_jednotky_rychlosti.Text = "mach" Then
            základní_jednotka_rychlost = textbox_jednotky_rychlosti.Text * 340.3
        End If

        If combobox_jednotky_hmotnosti.Text = "g" Then
            základní_jednotka_hmotnost = textbox_jednotky_hmotnosti.Text * 0.001
        ElseIf combobox_jednotky_hmotnosti.Text = "grs" Then
            základní_jednotka_hmotnost = textbox_jednotky_hmotnosti.Text * 0.00006479891
        ElseIf combobox_jednotky_hmotnosti.Text = "kg" Then
            základní_jednotka_hmotnost = textbox_jednotky_hmotnosti.Text * 1
        ElseIf combobox_jednotky_hmotnosti.Text = "lb" Then
            základní_jednotka_hmotnost = textbox_jednotky_hmotnosti.Text * 0.45359237
        ElseIf combobox_jednotky_hmotnosti.Text = "oz" Then
            základní_jednotka_hmotnost = textbox_jednotky_hmotnosti.Text * 0.0283495231
        End If

        If combobox_jednotky_délky.Text = "mm" Then
            základní_jednotka_délka = textbox_jednotky_délky.Text * 0.001
        ElseIf combobox_jednotky_délky.Text = "in" Then
            základní_jednotka_délka = textbox_jednotky_délky.Text * 0.0254
        ElseIf combobox_jednotky_délky.Text = "m" Then
            základní_jednotka_délka = textbox_jednotky_délky.Text * 1
        ElseIf combobox_jednotky_délky.Text = "ft" Then
            základní_jednotka_délka = textbox_jednotky_délky.Text * 0.3048
        ElseIf combobox_jednotky_délky.Text = "yd" Then
            základní_jednotka_délka = textbox_jednotky_délky.Text * 0.9144
        ElseIf combobox_jednotky_délky.Text = "km" Then
            základní_jednotka_délka = textbox_jednotky_délky.Text * 1000
        ElseIf combobox_jednotky_délky.Text = "mile" Then
            základní_jednotka_délka = textbox_jednotky_délky.Text * 1609.344
        End If

        If combobox_jednotky_uhel.Text = "deg" Then
            základní_jednotka_uhel = textbox_jednotky_uhel.Text * 1
        ElseIf combobox_jednotky_uhel.Text = "MRAD" Then
            základní_jednotka_uhel = textbox_jednotky_uhel.Text * 0.057296
        ElseIf combobox_jednotky_uhel.Text = "MOA" Then
            základní_jednotka_uhel = textbox_jednotky_uhel.Text * (1 / 60)
        End If

        If combobox_jednotky_energie.Text = "J" Then
            základní_jednotka_energie = textbox_jednotky_energie.Text * 1
        ElseIf combobox_jednotky_energie.Text = "ft-lb" Then
            základní_jednotka_energie = textbox_jednotky_energie.Text * 1.35581795
        End If
    End Sub
    Private Sub zápis_výsledků()
        'Rychlost
        label_mps.Text = "Velocity: " & Round(Val(základní_jednotka_rychlost * 1), zaokrouhleni) & " m/s (meters per second)"
        label_fps.Text = "Velocity: " & Round(Val(základní_jednotka_rychlost * 3.2808398950131235), zaokrouhleni) & " fps (feet per second)"
        label_kmh.Text = "Velocity: " & Round(Val(základní_jednotka_rychlost * 3.6), zaokrouhleni) & " km/h (kilometers per hour)"
        label_mph.Text = "Velocity: " & Round(Val(základní_jednotka_rychlost * 2.2369362920544025), zaokrouhleni) & " mph (miles per hour)"
        label_mach.Text = "Velocity: " & Round(Val(základní_jednotka_rychlost * 0.0029385836027034967), zaokrouhleni) & " mach (speed of sound)"
        'Hmotnost
        label_g.Text = "Weight: " & Round(Val(základní_jednotka_hmotnost * 1000), zaokrouhleni) & " g (grams) "
        label_grs.Text = "Weight: " & Round(Val(základní_jednotka_hmotnost * 15432.35835294143), zaokrouhleni) & " grs (grains)"
        label_kg.Text = "Weight: " & Round(Val(základní_jednotka_hmotnost * 1), zaokrouhleni) & " kg (kilograms)"
        label_lb.Text = "Weight: " & Round(Val(základní_jednotka_hmotnost * 2.2046226218487757), zaokrouhleni) & " lb (pounds)"
        label_ounce.Text = "Weight: " & Round(Val(základní_jednotka_hmotnost * 35.273961980686721), zaokrouhleni) & " oz (ounces)"
        'Délka
        label_mm.Text = "Length: " & Round(Val(základní_jednotka_délka * 1000), zaokrouhleni) & " mm (millimeters)"
        label_inch.Text = "Length: " & Round(Val(základní_jednotka_délka * 39.370078740157481), zaokrouhleni) & " in (inches)"
        label_m.Text = "Length: " & Round(Val(základní_jednotka_délka * 1), zaokrouhleni) & " m (meters)"
        label_ft.Text = "Length: " & Round(Val(základní_jednotka_délka * 3.2808398950131235), zaokrouhleni) & " ft (feet)"
        label_yard.Text = "Length: " & Round(Val(základní_jednotka_délka * 1.0936132983377078), zaokrouhleni) & " yd (yards)"
        label_km.Text = "Length: " & Round(Val(základní_jednotka_délka * 0.001), zaokrouhleni) & " km (kilometers)"
        label_mile.Text = "Length: " & Round(Val(základní_jednotka_délka * 0.00062137119223733392), zaokrouhleni) & " mile (miles)"
        'Úhel
        label_stupne_uhlu.Text = "Angle: " & Round(Val(základní_jednotka_uhel), zaokrouhleni) & " deg (degrees)"
        label_MRAD.Text = "Angle: " & Round(Val(základní_jednotka_uhel / 0.057296), zaokrouhleni) & " MRAD (milliradians)"
        label_MOA.Text = "Angle: " & Round(Val(základní_jednotka_uhel * 60), zaokrouhleni) & " MOA (arcminutes)"
        'Energie
        label_energie_jouly.Text = "Energy: " & Round(Val(základní_jednotka_energie), zaokrouhleni) & " J (joules)"
        label_energie_foot_pounds.Text = "Energy: " & Round(Val(základní_jednotka_energie * 0.737562149), zaokrouhleni) & " ft-lb (foot pounds)"
    End Sub

    Private Sub Převody_jednotek_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vyvolani_pameti()
    End Sub

    Private Sub Převody_jednotek_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Hlavní_okno.Enabled = True
        ulozeni_pameti()
    End Sub

    Private Sub vyvolani_pameti()
        If My.Settings.pamet_prevody_jednotek_combobox_jednotky_rychlosti <> Nothing Then
            combobox_jednotky_rychlosti.Text = My.Settings.pamet_prevody_jednotek_combobox_jednotky_rychlosti
            combobox_jednotky_hmotnosti.Text = My.Settings.pamet_prevody_jednotek_combobox_jednotky_hmotnosti
            combobox_jednotky_délky.Text = My.Settings.pamet_prevody_jednotek_combobox_jednotky_délky
            combobox_jednotky_uhel.Text = My.Settings.pamet_prevody_jednotek_combobox_jednotky_uhlu
            combobox_jednotky_energie.Text = My.Settings.pamet_prevody_jednotek_combobox_jednotky_energie
            combobox_zaokrouhleni.Text = My.Settings.pamet_prevody_jednotek_combobox_zaokrouhleni
        Else
            combobox_jednotky_rychlosti.Text = "m/s"
            combobox_jednotky_hmotnosti.Text = "kg"
            combobox_jednotky_délky.Text = "m"
            combobox_jednotky_uhel.Text = "deg"
            combobox_jednotky_energie.Text = "J"
            combobox_zaokrouhleni.Text = "3"
        End If
    End Sub
    Private Sub ulozeni_pameti()
        My.Settings.pamet_prevody_jednotek_combobox_jednotky_rychlosti = combobox_jednotky_rychlosti.Text
        My.Settings.pamet_prevody_jednotek_combobox_jednotky_hmotnosti = combobox_jednotky_hmotnosti.Text
        My.Settings.pamet_prevody_jednotek_combobox_jednotky_délky = combobox_jednotky_délky.Text
        My.Settings.pamet_prevody_jednotek_combobox_jednotky_uhlu = combobox_jednotky_uhel.Text
        My.Settings.pamet_prevody_jednotek_combobox_jednotky_energie = combobox_jednotky_energie.Text
        My.Settings.pamet_prevody_jednotek_combobox_zaokrouhleni = combobox_zaokrouhleni.Text
        My.Settings.Save()
    End Sub
End Class