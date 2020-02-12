Imports System.Math
Public Class Vypocet_koeficientu
    Dim první_rychlost As Decimal = 0
    Dim druhá_rychlost As Decimal = 0
    Dim první_vzdálenost As Decimal = 0
    Dim druhá_vzdálenost As Decimal = 0

    Dim hustota_vzduchu As Decimal = 0
    Dim hmotnost As Decimal = 1
    Dim průměr_střely As Decimal = 10
    Dim plocha As Decimal = 0
    Dim koeficient_odporu As Decimal = 1.1

    Dim koeficient_pro_zápis_G1 As Decimal = 0
    Dim G1 As Boolean = True
    Dim chyba As Boolean = False

    Dim koeficient_odporu_výpočet As Decimal = 0
    Dim rychlost As Double = 0
    Dim proměnný_koeficient_odporu As Decimal = 0

    Private Sub Button_Spočítej_Click(sender As Object, e As EventArgs) Handles Button_Spočítej.Click
        Button_Spočítej.Text = "Calculating"
        Button_Spočítej.Enabled = False
        Zavřít.Enabled = False
        chyba = False
        G1 = True
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
                G1 = False
                výpočet_koeficientu()
                If koeficient_odporu = 1.099 Then
                    label_balistický_koeficient_G7.Text = "Ballistic coefficient G7: " & koeficient_odporu & " +"
                Else
                    label_balistický_koeficient_G7.Text = "Ballistic coefficient G7: " & koeficient_odporu
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
                hustota_vzduchu = 1.218
            Else
                hustota_vzduchu = My.Settings.hustota_vzduchu
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
            koeficient_odporu = 1.1
            rychlost = první_rychlost
            Do Until rychlost <= druhá_rychlost
                dráha_x = 0
                rychlost = první_rychlost
                koeficient_odporu = koeficient_odporu - 0.001
                If G1 = True Then
                    koeficient_odporu_výpočet = 0.3 * (((hmotnost * 2.204627) / ((průměr_střely * 0.039370787) ^ 2)) / koeficient_odporu)
                Else
                    koeficient_odporu_výpočet = 0.12 * (((hmotnost * 2.204627) / ((průměr_střely * 0.039370787) ^ 2)) / koeficient_odporu)
                End If

                Do Until dráha_x >= (druhá_vzdálenost - první_vzdálenost)
                    proměnný_koeficient()
                    rychlost = rychlost - (((0.5 * proměnný_koeficient_odporu * hustota_vzduchu * plocha * rychlost ^ 2) / hmotnost) * interval)
                    dráha_x = dráha_x + (rychlost * interval)
                Loop
            Loop
        Catch ex As Exception
            label_balistický_koeficient_G1.Text = "Ballistic coefficient G1: 0"
            label_balistický_koeficient_G7.Text = "Ballistic coefficient G7: "
            MsgBox("An error occurred during the calculation, please check that all data is entered correctly.", MsgBoxStyle.Critical)
            chyba = True
        End Try
    End Sub
    Private Sub proměnný_koeficient()
        If G1 = True Then

            If rychlost <= 280 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 0.83
            ElseIf rychlost > 280 And rychlost <= 330 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.0
            ElseIf rychlost > 330 And rychlost <= 500 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 2.0
            ElseIf rychlost > 500 And rychlost <= 660 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 2.1
            ElseIf rychlost > 660 And rychlost <= 830 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.86
            ElseIf rychlost > 830 And rychlost <= 1000 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.73
            ElseIf rychlost > 1000 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.63
            End If

        Else

            If rychlost <= 325 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 0.9
            ElseIf rychlost > 325 And rychlost <= 500 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 3.08
            ElseIf rychlost > 500 And rychlost <= 660 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 2.71
            ElseIf rychlost > 660 And rychlost <= 830 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 2.43
            ElseIf rychlost > 830 And rychlost <= 1000 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 2.1
            ElseIf rychlost > 1000 Then
                proměnný_koeficient_odporu = koeficient_odporu_výpočet * 1.7
            End If

        End If
    End Sub
    Private Sub Výpočet_koeficientu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vyvolani_pameti()
        label_teplota_vzduchu.Text = "Air temperature: " & My.Settings.teplota_vzduchu
        label_nadmořská_výška.Text = "Height above sea: " & My.Settings.nadmořská_výška
    End Sub

    Private Sub Výpočet_koeficientu_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

        label_teplota_vzduchu.Text = "Air temperature: " & My.Settings.teplota_vzduchu
        label_nadmořská_výška.Text = "Height above sea: " & My.Settings.nadmořská_výška
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