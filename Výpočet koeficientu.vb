Imports System.Math
Public Class Vypocet_koeficientu
    Dim první_rychlost As Decimal = 0
    Dim druhá_rychlost As Decimal = 0
    Dim první_vzdálenost As Decimal = 0
    Dim druhá_vzdálenost As Decimal = 0

    Dim hustota_vzduchu As Decimal = 0
    Dim rychlost_zvuku As Decimal = 0
    Dim rychlost_mach As Decimal = 0
    Dim hmotnost As Decimal = 1
    Dim průměr_střely As Decimal = 10
    Dim plocha As Decimal = 0
    Dim koeficient_odporu As Decimal = 1.1

    Dim koeficient_pro_zápis_G1 As Decimal = 0
    Dim funkce_odporu As String = "G1"
    Dim chyba As Boolean = False

    Dim koeficient_odporu_výpočet As Decimal = 0
    Dim rychlost As Double = 0
    Dim proměnný_koeficient_odporu As Decimal = 0

    Private Sub Button_Spočítej_Click(sender As Object, e As EventArgs) Handles Button_Spočítej.Click
        Button_Spočítej.Text = "Calculating"
        Button_Spočítej.Enabled = False
        Zavřít.Enabled = False
        chyba = False
        funkce_odporu = "G1"
        zápis_proměnných()
        If chyba = False Then
            výpočet_koeficientu()
            If koeficient_odporu = 1.099 Then
                label_balistický_koeficient_G1.Text = "Ballistic coefficient G1: " & koeficient_odporu & " +"
                koeficient_pro_zápis_G1 = koeficient_odporu
            Else
                label_balistický_koeficient_G1.Text = "Ballistic coefficient G1: " & koeficient_odporu
                koeficient_pro_zápis_G1 = koeficient_odporu
            End If
            If chyba = False Then
                funkce_odporu = "G7"
                výpočet_koeficientu()
                If koeficient_odporu = 1.099 Then
                    label_balistický_koeficient_G7.Text = "Ballistic coefficient G7: " & koeficient_odporu & " +"
                Else
                    label_balistický_koeficient_G7.Text = "Ballistic coefficient G7: " & koeficient_odporu
                End If
            End If
            If chyba = False Then
                funkce_odporu = "JSBE"
                výpočet_koeficientu()
                If koeficient_odporu = 1.099 Then
                    label_balistický_koeficient_JSBE.Text = "Ballistic coefficient JSBE: " & koeficient_odporu & " +"
                Else
                    label_balistický_koeficient_JSBE.Text = "Ballistic coefficient JSBE: " & koeficient_odporu
                End If
            End If
            ulozeni_pameti()
        Else
            Button_Spočítej.Enabled = True
        End If
        Button_Spočítej.Enabled = True
        Zavřít.Enabled = True
        Button_Spočítej.Text = "Calculate"
    End Sub
    Private Sub zápis_proměnných()

        Try

            textbox_první_rychlost.Text = textbox_první_rychlost.Text.Replace(".", ",")
            textbox_druhá_rychlost.Text = textbox_druhá_rychlost.Text.Replace(".", ",")
            textbox_první_vzdálenost.Text = textbox_první_vzdálenost.Text.Replace(".", ",")
            textbox_druhá_vzdálenost.Text = textbox_druhá_vzdálenost.Text.Replace(".", ",")

            If textbox_první_rychlost.Text = Nothing Or textbox_druhá_rychlost.Text = Nothing Then
                MsgBox("Wrong or missing data about velocities." & vbNewLine & "Tip: The maximum possible value of the velocity is limited to 1500 m/s = 4921 fps." & vbNewLine & "Tip: The velocity cannot be less than or equal to zero.", MsgBoxStyle.Exclamation)
                chyba = True
            ElseIf textbox_první_vzdálenost.Text = Nothing Or textbox_druhá_vzdálenost.Text = Nothing Then
                MsgBox("Wrong or missing data about distances." & vbNewLine & "Tip: The chronograph distances difference cannot be greater than 1000 m = 3280 ft = 1093 yd, less than or equal to zero." & vbNewLine & "Tip: The distance cannot be less than zero.", MsgBoxStyle.Exclamation)
                chyba = True
            End If

            If My.Settings.hustota_vzduchu = 0 Then
                hustota_vzduchu = 1.168
                rychlost_zvuku = 340.4
            Else
                hustota_vzduchu = My.Settings.hustota_vzduchu
                rychlost_zvuku = My.Settings.rychlost_zvuku
            End If

            If combobox_první_rychlost.Text = "m/s" Then
                první_rychlost = textbox_první_rychlost.Text
            ElseIf combobox_první_rychlost.Text = "fps" Then
                první_rychlost = textbox_první_rychlost.Text * 0.3048
            Else
                chyba = True
            End If

            If combobox_druhá_rychlost.Text = "m/s" Then
                druhá_rychlost = textbox_druhá_rychlost.Text
            ElseIf combobox_druhá_rychlost.Text = "fps" Then
                druhá_rychlost = textbox_druhá_rychlost.Text * 0.3048
            Else
                chyba = True
            End If

            If combobox_prvni_vzdalenost.Text = "m" Then
                první_vzdálenost = textbox_první_vzdálenost.Text
            ElseIf combobox_prvni_vzdalenost.Text = "ft" Then
                první_vzdálenost = textbox_první_vzdálenost.Text * 0.3048
            Else
                první_vzdálenost = textbox_první_vzdálenost.Text * 0.9144
            End If

            If combobox_druha_vzdalenost.Text = "m" Then
                druhá_vzdálenost = textbox_druhá_vzdálenost.Text
            ElseIf combobox_druha_vzdalenost.Text = "ft" Then
                druhá_vzdálenost = textbox_druhá_vzdálenost.Text * 0.3048
            Else
                druhá_vzdálenost = textbox_druhá_vzdálenost.Text * 0.9144
            End If
            plocha = ((průměr_střely ^ 2 * PI) / 4) / 1000000

            If první_rychlost <= druhá_rychlost Or první_rychlost > 1500 Or druhá_rychlost > 1500 Or první_rychlost <= 0 Or druhá_rychlost <= 0 Then
                MsgBox("Wrong or missing data about velocities." & vbNewLine & "Tip: The maximum possible value of the velocity is limited to 1500 m/s = 4921 fps." & vbNewLine & "Tip: The velocity cannot be less than or equal to zero.", MsgBoxStyle.Exclamation)
                chyba = True
            End If
            If první_vzdálenost >= druhá_vzdálenost Or první_vzdálenost < 0 Or druhá_vzdálenost <= 0 Or (druhá_vzdálenost - první_vzdálenost) > 1000 Then
                MsgBox("Wrong or missing data about distances." & vbNewLine & "Tip: The chronograph distances difference cannot be greater than 1000 m = 3280 ft = 1093 yd, less than or equal to zero." & vbNewLine & "Tip: The distance cannot be less than zero.", MsgBoxStyle.Exclamation)
                chyba = True
            End If
        Catch ex As Exception
            chyba = True
        End Try
    End Sub
    Private Sub výpočet_koeficientu()
        Try
            Dim dráha_x As Double = 0
            Dim interval As Decimal = 0.001
            Dim k1 As Double = 0
            Dim k2 As Double = 0
            Dim dv As Double = 0
            Dim dx As Double = 0
            koeficient_odporu = 1.1
            rychlost = první_rychlost
            Do Until rychlost <= druhá_rychlost
                dráha_x = 0
                rychlost = první_rychlost
                koeficient_odporu = koeficient_odporu - 0.001
                If funkce_odporu = "G1" Then
                    koeficient_odporu_výpočet = 0.3 * (((hmotnost * 2.204627) / ((průměr_střely * 0.039370787) ^ 2)) / koeficient_odporu)
                ElseIf funkce_odporu = "G7" Then
                    koeficient_odporu_výpočet = 0.12 * (((hmotnost * 2.204627) / ((průměr_střely * 0.039370787) ^ 2)) / koeficient_odporu)
                ElseIf funkce_odporu = "JSBE" Then
                    koeficient_odporu_výpočet = 0.3 * (((hmotnost * 2.204627) / ((průměr_střely * 0.039370787) ^ 2)) / koeficient_odporu)
                End If

                Do Until dráha_x >= (druhá_vzdálenost - první_vzdálenost)
                    proměnný_koeficient()

                    k1 = 0.5 * proměnný_koeficient_odporu * hustota_vzduchu * plocha * rychlost ^ 2 / hmotnost * interval
                    k2 = 0.5 * proměnný_koeficient_odporu * hustota_vzduchu * plocha * (rychlost - k1) ^ 2 / hmotnost * interval
                    dv = 0.5 * (k1 + k2)

                    k1 = rychlost * interval
                    k2 = (rychlost - k1) * interval
                    dx = 0.5 * (k1 + k2)

                    rychlost = rychlost - dv
                    dráha_x = dráha_x + dx
                Loop
            Loop
        Catch ex As Exception
            label_balistický_koeficient_G1.Text = "Ballistic coefficient G1: 0"
            label_balistický_koeficient_G7.Text = "Ballistic coefficient G7: "
            label_balistický_koeficient_G7.Text = "Ballistic coefficient JSBE: "
            MsgBox("An error occurred during the calculation, please check that all data is entered correctly.", MsgBoxStyle.Critical)
            chyba = True
        End Try
    End Sub
    Private Sub proměnný_koeficient()

        rychlost_mach = rychlost / rychlost_zvuku

        If funkce_odporu = "G1" Then

            If rychlost_mach >= 0 And rychlost_mach <= 0.3 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 0.8
            ElseIf rychlost_mach > 0.3 And rychlost_mach <= 0.5 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 0.71
            ElseIf rychlost_mach > 0.5 And rychlost_mach <= 0.7 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 0.69
            ElseIf rychlost_mach > 0.7 And rychlost_mach <= 0.8 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 0.79
            ElseIf rychlost_mach > 0.8 And rychlost_mach <= 0.85 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 0.91
            ElseIf rychlost_mach > 0.85 And rychlost_mach <= 0.9 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.05
            ElseIf rychlost_mach > 0.9 And rychlost_mach <= 0.95 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.25
            ElseIf rychlost_mach > 0.95 And rychlost_mach <= 1.0 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.48
            ElseIf rychlost_mach > 1.0 And rychlost_mach <= 1.05 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.71
            ElseIf rychlost_mach > 1.05 And rychlost_mach <= 1.1 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.88
            ElseIf rychlost_mach > 1.1 And rychlost_mach <= 1.2 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 2.05
            ElseIf rychlost_mach > 1.2 And rychlost_mach <= 1.8 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 2.18
            ElseIf rychlost_mach > 1.8 And rychlost_mach <= 2.2 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.98
            ElseIf rychlost_mach > 2.2 And rychlost_mach <= 2.6 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.83
            ElseIf rychlost_mach > 2.6 And rychlost_mach <= 3.0 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.74
            ElseIf rychlost_mach > 3 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.68
            End If


        ElseIf funkce_odporu = "G7" Then

            If rychlost_mach >= 0 And rychlost_mach <= 0.7 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 0.99
            ElseIf rychlost_mach > 0.7 And rychlost_mach <= 0.8 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.02
            ElseIf rychlost_mach > 0.8 And rychlost_mach <= 0.85 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.062
            ElseIf rychlost_mach > 0.85 And rychlost_mach <= 0.865 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.1142
            ElseIf rychlost_mach > 0.865 And rychlost_mach <= 0.88 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.1471
            ElseIf rychlost_mach > 0.88 And rychlost_mach <= 0.885 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.18
            ElseIf rychlost_mach > 0.885 And rychlost_mach <= 0.89 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.21
            ElseIf rychlost_mach > 0.89 And rychlost_mach <= 0.9 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.24
            ElseIf rychlost_mach > 0.9 And rychlost_mach <= 0.915 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.3017
            ElseIf rychlost_mach > 0.915 And rychlost_mach <= 0.93 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.4246
            ElseIf rychlost_mach > 0.93 And rychlost_mach <= 0.94 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.5475
            ElseIf rychlost_mach > 0.94 And rychlost_mach <= 0.95 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.8252
            ElseIf rychlost_mach > 0.95 And rychlost_mach <= 0.965 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.9645
            ElseIf rychlost_mach > 0.965 And rychlost_mach <= 0.98 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 2.1029
            ElseIf rychlost_mach > 0.98 And rychlost_mach <= 0.985 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 2.2851
            ElseIf rychlost_mach > 0.985 And rychlost_mach <= 0.99 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 2.4673
            ElseIf rychlost_mach > 0.99 And rychlost_mach <= 0.995 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 2.6495
            ElseIf rychlost_mach > 0.995 And rychlost_mach <= 1.0 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 2.8317
            ElseIf rychlost_mach > 1.0 And rychlost_mach <= 1.015 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 3.0446
            ElseIf rychlost_mach > 1.015 And rychlost_mach <= 1.03 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 3.2575
            ElseIf rychlost_mach > 1.03 And rychlost_mach <= 1.05 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 3.3575
            ElseIf rychlost_mach > 1.05 And rychlost_mach <= 1.1 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 3.3571
            ElseIf rychlost_mach > 1.1 And rychlost_mach <= 1.15 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 3.321
            ElseIf rychlost_mach > 1.15 And rychlost_mach <= 1.2 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 3.266
            ElseIf rychlost_mach > 1.2 And rychlost_mach <= 1.25 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 3.206
            ElseIf rychlost_mach > 1.25 And rychlost_mach <= 1.3 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 3.1425
            ElseIf rychlost_mach > 1.3 And rychlost_mach <= 1.35 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 3.0788
            ElseIf rychlost_mach > 1.35 And rychlost_mach <= 1.4 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 3.015
            ElseIf rychlost_mach > 1.4 And rychlost_mach <= 1.5 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 2.925
            ElseIf rychlost_mach > 1.5 And rychlost_mach <= 1.6 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 2.8145
            ElseIf rychlost_mach > 1.6 And rychlost_mach <= 1.7 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 2.718
            ElseIf rychlost_mach > 1.7 And rychlost_mach <= 1.8 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 2.636
            ElseIf rychlost_mach > 1.8 And rychlost_mach <= 1.9 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 2.566
            ElseIf rychlost_mach > 1.9 And rychlost_mach <= 2.0 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 2.509
            ElseIf rychlost_mach > 2.0 And rychlost_mach <= 2.15 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 2.446
            ElseIf rychlost_mach > 2.15 And rychlost_mach <= 2.3 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 2.3745
            ElseIf rychlost_mach > 2.3 And rychlost_mach <= 2.6 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 2.271
            ElseIf rychlost_mach > 2.6 And rychlost_mach <= 3.0 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 2.111
            ElseIf rychlost_mach > 3 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 2
            End If


        ElseIf funkce_odporu = "JSBE" Then

            If rychlost_mach >= 0 And rychlost_mach <= 0.3 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 0.99
            ElseIf rychlost_mach > 0.3 And rychlost_mach <= 0.4 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.04
            ElseIf rychlost_mach > 0.4 And rychlost_mach <= 0.55 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 0.75
            ElseIf rychlost_mach > 0.55 And rychlost_mach <= 0.6 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 0.97
            ElseIf rychlost_mach > 0.6 And rychlost_mach <= 0.65 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.2
            ElseIf rychlost_mach > 0.65 And rychlost_mach <= 0.7 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.43
            ElseIf rychlost_mach > 0.7 And rychlost_mach <= 0.75 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.66
            ElseIf rychlost_mach > 0.75 And rychlost_mach <= 0.8 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.88
            ElseIf rychlost_mach > 0.8 And rychlost_mach <= 0.85 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 2.11
            ElseIf rychlost_mach > 0.85 And rychlost_mach <= 0.9 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 2.32
            ElseIf rychlost_mach > 0.9 And rychlost_mach <= 0.95 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 2.54
            ElseIf rychlost_mach > 0.95 And rychlost_mach <= 1.0 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 2.75
            ElseIf rychlost_mach > 1.0 And rychlost_mach <= 1.1 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 3.02
            ElseIf rychlost_mach > 1.1 And rychlost_mach <= 1.2 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 3.32
            ElseIf rychlost_mach > 1.2 And rychlost_mach <= 1.4 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 3.5
            ElseIf rychlost_mach > 1.4 And rychlost_mach <= 2 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 3.62
            ElseIf rychlost_mach > 2 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 3.75
            End If

        Else
            MsgBox("An error occurred during the calculation, please check that all data is entered correctly.", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub Výpočet_koeficientu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vyvolani_pameti()
        label_teplota_vzduchu.Text = "Air temperature: " & My.Settings.teplota_vzduchu
        label_nadmořská_výška.Text = "Elevation: " & My.Settings.nadmořská_výška

        textbox_první_vzdálenost.Text = "0"
    End Sub

    Private Sub Výpočet_koeficientu_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

        label_teplota_vzduchu.Text = "Air temperature: " & My.Settings.teplota_vzduchu
        label_nadmořská_výška.Text = "Elevation: " & My.Settings.nadmořská_výška
    End Sub

    Private Sub Zavřít_Click(sender As Object, e As EventArgs) Handles Zavřít.Click
        ulozeni_pameti()
        Hlavní_okno.Enabled = True
        Hide()
    End Sub

    Private Sub Výpočet_koeficientu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Hlavní_okno.Enabled = True
        ulozeni_pameti()
    End Sub

    Private Sub ulozeni_pameti()
        My.Settings.pamet_vypocet_koeficientu_combobox_prvni_rychlost = combobox_první_rychlost.Text
        My.Settings.pamet_vypocet_koeficientu_combobox_druha_rychlost = combobox_druhá_rychlost.Text
        My.Settings.pamet_vypocet_koeficientu_combobox_prvni_vzdalenost = combobox_prvni_vzdalenost.Text
        My.Settings.pamet_vypocet_koeficientu_combobox_druha_vzdalenost = combobox_druha_vzdalenost.Text
        My.Settings.Save()
    End Sub

    Private Sub vyvolani_pameti()
        If My.Settings.pamet_vypocet_koeficientu_combobox_prvni_rychlost <> Nothing Then
            combobox_první_rychlost.Text = My.Settings.pamet_vypocet_koeficientu_combobox_prvni_rychlost
            combobox_druhá_rychlost.Text = My.Settings.pamet_vypocet_koeficientu_combobox_druha_rychlost
            combobox_prvni_vzdalenost.Text = My.Settings.pamet_vypocet_koeficientu_combobox_prvni_vzdalenost
            combobox_druha_vzdalenost.Text = My.Settings.pamet_vypocet_koeficientu_combobox_druha_vzdalenost
        Else
            combobox_první_rychlost.Text = "m/s"
            combobox_druhá_rychlost.Text = "m/s"
            combobox_prvni_vzdalenost.Text = "m"
            combobox_druha_vzdalenost.Text = "m"
        End If
    End Sub
End Class