Imports System.Math
Public Class Vlastnosti_Atmosféry
    Dim hustota_vzduchu As Decimal = 0
    Dim rychlost_větru As Decimal = 0
    Dim chyba As Boolean = False
    Dim nadmořská_výška As Decimal = 0
    Dim teplota As Decimal = 0
    Dim predni_zadni_vitr As Decimal = 0
    Dim rychlost_zvuku As Decimal = 0

    Private Sub Vlastnosti_Atmosféry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vyvolani_pameti()

        Textbox_Hustota_vzduchu.Enabled = False

        If checkbox_bezvětří.Checked = False Then
            textbox_rychlost_větru.Text = My.Settings.rychlost_vetru_decimal
        End If

        If My.Settings.hustota_vzduchu = 0 Then
            If combobox_teplota_vzduchu.Text = "°C" Then
                Textbox_Teplota.Text = "15"
            Else
                Textbox_Teplota.Text = "59"
            End If

            If combobox_nadmořská_výška.Text = "m" Then
                Textbox_Nadmořská_výška.Text = "400"
            ElseIf combobox_nadmořská_výška.Text = "ft" Then
                Textbox_Nadmořská_výška.Text = "1312"
            Else
                Textbox_Nadmořská_výška.Text = "437"
            End If

            If combobox_hustota_vzduchu.Text = "kg/m³" Then
                Textbox_Hustota_vzduchu.Text = "1,168"
            Else
                Textbox_Hustota_vzduchu.Text = "0,073"
            End If

            checkbox_bezvětří.Checked = True
        Else

            If combobox_hustota_vzduchu.Text = "kg/m³" Then
                Textbox_Hustota_vzduchu.Text = Round(Val(My.Settings.hustota_vzduchu), 3)
            Else
                Textbox_Hustota_vzduchu.Text = Round(Val(My.Settings.hustota_vzduchu * 0.0624279606), 4)
            End If

            Textbox_Nadmořská_výška.Text = My.Settings.nadmorska_vyska_decimal
            Textbox_Teplota.Text = My.Settings.teplota_vzduchu_decimal
        End If

    End Sub

    Private Sub Button_Spočítej_Click(sender As Object, e As EventArgs) Handles Button_Spočítej.Click
        Try
            chyba = False

            vynulovat()
            zápis_proměnných()
            výpočet_hustoty_atmosféry()

            If chyba = False Then

                výpočet_odporu_větru()

                My.Settings.hustota_vzduchu = hustota_vzduchu
                My.Settings.rychlost_zvuku = rychlost_zvuku
                My.Settings.nadmorska_vyska_decimal = Textbox_Nadmořská_výška.Text
                My.Settings.teplota_vzduchu_decimal = Textbox_Teplota.Text

                If combobox_teplota_vzduchu.Text = "°C" Then
                    My.Settings.teplota_vzduchu = Textbox_Teplota.Text & " °C"
                Else
                    My.Settings.teplota_vzduchu = Textbox_Teplota.Text & " °F"
                End If

                If combobox_nadmořská_výška.Text = "m" Then
                    My.Settings.nadmořská_výška = Textbox_Nadmořská_výška.Text & " m"
                ElseIf combobox_nadmořská_výška.Text = "ft" Then
                    My.Settings.nadmořská_výška = Textbox_Nadmořská_výška.Text & " ft"
                Else
                    My.Settings.nadmořská_výška = Textbox_Nadmořská_výška.Text & " yd"
                End If

                If checkbox_bezvětří.Checked = True Then
                    My.Settings.rychlost_bočního_větru = 0
                    My.Settings.smer_vetru_pro_export = 0
                    My.Settings.rychlost_a_smer_vetru_pro_export = Nothing
                    My.Settings.rychlost_vetru_celni_zadni_pro_vypocet = 0
                Else
                    My.Settings.rychlost_vetru_decimal = textbox_rychlost_větru.Text
                    My.Settings.rychlost_a_smer_vetru_pro_export = textbox_rychlost_větru.Text & " " & combobox_rychlost_větru.Text
                End If

                ulozeni_pameti()

                My.Settings.Save()
                Hlavní_okno.Enabled = True
                Hide()
            End If
        Catch ex As Exception
            MsgBox("An error occurred during the calculation, please check that all data is entered correctly.", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub zápis_proměnných()
        Try

            Textbox_Nadmořská_výška.Text = Textbox_Nadmořská_výška.Text.Replace(".", ",")
            Textbox_Teplota.Text = Textbox_Teplota.Text.Replace(".", ",")
            textbox_rychlost_větru.Text = textbox_rychlost_větru.Text.Replace(".", ",")

            Textbox_Nadmořská_výška.Text = Round(Val(Textbox_Nadmořská_výška.Text), 0)
            Textbox_Teplota.Text = Round(Val(Textbox_Teplota.Text), 0)
            textbox_rychlost_větru.Text = Round(Val(textbox_rychlost_větru.Text), 0)

            If checkbox_bezvětří.Checked = False Then
                If combobox_rychlost_větru.Text = "km/h" Then
                    rychlost_větru = textbox_rychlost_větru.Text / 3.6
                ElseIf combobox_rychlost_větru.Text = "m/s" Then
                    rychlost_větru = textbox_rychlost_větru.Text
                ElseIf combobox_rychlost_větru.Text = "mph" Then
                    rychlost_větru = textbox_rychlost_větru.Text * 0.44704
                ElseIf combobox_rychlost_větru.Text = "fps" Then
                    rychlost_větru = textbox_rychlost_větru.Text * 0.3048
                Else
                    chyba = True
                End If

                If rychlost_větru > 100 Or rychlost_větru < 0 Then
                    chyba = True
                    MsgBox("The wind speed cannot be less than 0 or greater than 100 m/s = 223mph = 360 km/h = 328fps.", MsgBoxStyle.Exclamation)
                End If

            End If

            If Checkbox_Standardní_atmosféra_ICAO.Checked = False Then
                Try
                    If combobox_teplota_vzduchu.Text = "°C" Then
                        teplota = Textbox_Teplota.Text
                    ElseIf combobox_teplota_vzduchu.Text = "°F" Then
                        teplota = (Textbox_Teplota.Text - 32) * (5 / 9)
                    Else
                        chyba = True
                    End If
                Catch ex As Exception
                    chyba = True
                    MsgBox("Wrong or missing data about air temperature.", MsgBoxStyle.Exclamation)
                End Try
                Try
                    If combobox_nadmořská_výška.Text = "m" Then
                        nadmořská_výška = Textbox_Nadmořská_výška.Text
                    ElseIf combobox_nadmořská_výška.Text = "ft" Then
                        nadmořská_výška = Textbox_Nadmořská_výška.Text * 0.3048
                    ElseIf combobox_nadmořská_výška.Text = "yd" Then
                        nadmořská_výška = Textbox_Nadmořská_výška.Text * 0.9144
                    Else
                        chyba = True
                    End If
                Catch ex As Exception
                    MsgBox("Wrong or missing data about elevation.", MsgBoxStyle.Exclamation)
                End Try
                If nadmořská_výška < 0 Or nadmořská_výška > 11000 Then
                    chyba = True
                    MsgBox("The elevation cannot be greater than 11000m = 12029yd = 36089ft, or less than 0.", MsgBoxStyle.Exclamation)
                End If

                If teplota < -100 Or teplota > 100 Then
                    chyba = True
                    MsgBox("The air temperature cannot be greater than 100 ° C = 212 ° F, or less than -100 ° C = -148 ° F.", MsgBoxStyle.Exclamation)
                End If
            End If
        Catch ex As Exception
            chyba = True
            MsgBox("An error occured during the data logging, please check that all data are entered correctly or if they are all filled in.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub výpočet_odporu_větru()

        If radiobutton_E.Checked = True Then
            My.Settings.smer_vetru_pro_export = 90
            My.Settings.rychlost_bočního_větru = rychlost_větru * (-1)
            My.Settings.rychlost_vetru_celni_zadni_pro_vypocet = 0
        ElseIf radiobutton_NE.Checked = True Then
            My.Settings.smer_vetru_pro_export = 45
            My.Settings.rychlost_bočního_větru = rychlost_větru * 0.7071 * (-1)
            My.Settings.rychlost_vetru_celni_zadni_pro_vypocet = rychlost_větru * 0.7071
        ElseIf radiobutton_NW.Checked = True Then
            My.Settings.smer_vetru_pro_export = 45
            My.Settings.rychlost_bočního_větru = rychlost_větru * 0.7071
            My.Settings.rychlost_vetru_celni_zadni_pro_vypocet = rychlost_větru * 0.7071
        ElseIf radiobutton_SE.Checked = True Then
            My.Settings.smer_vetru_pro_export = 45
            My.Settings.rychlost_bočního_větru = rychlost_větru * 0.7071 * (-1)
            My.Settings.rychlost_vetru_celni_zadni_pro_vypocet = rychlost_větru * 0.7071 * (-1)
        ElseIf radiobutton_SW.Checked = True Then
            My.Settings.smer_vetru_pro_export = 45
            My.Settings.rychlost_bočního_větru = rychlost_větru * 0.7071
            My.Settings.rychlost_vetru_celni_zadni_pro_vypocet = rychlost_větru * 0.7071 * (-1)
        ElseIf radiobutton_W.Checked = True Then
            My.Settings.smer_vetru_pro_export = 90
            My.Settings.rychlost_bočního_větru = rychlost_větru
            My.Settings.rychlost_vetru_celni_zadni_pro_vypocet = 0
        ElseIf radiobutton_N.Checked = True Then
            My.Settings.smer_vetru_pro_export = 0
            My.Settings.rychlost_vetru_celni_zadni_pro_vypocet = rychlost_větru
            My.Settings.rychlost_bočního_větru = 0
        ElseIf radiobutton_S.Checked = True Then
            My.Settings.smer_vetru_pro_export = 180
            My.Settings.rychlost_vetru_celni_zadni_pro_vypocet = rychlost_větru * (-1)
            My.Settings.rychlost_bočního_větru = 0
        End If


    End Sub

    Private Sub výpočet_hustoty_atmosféry()
        Try
            If Checkbox_Standardní_atmosféra_ICAO.Checked = False Then
                hustota_vzduchu = (101325 * (1 - (nadmořská_výška / 44331)) ^ 5.2577) / (287.05 * (273.15 + teplota))
                rychlost_zvuku = 331.3 + 0.606 * teplota
                If combobox_hustota_vzduchu.Text = "kg/m³" Then
                    Textbox_Hustota_vzduchu.Text = Round(Val(hustota_vzduchu), 3)
                Else
                    Textbox_Hustota_vzduchu.Text = Round(Val(hustota_vzduchu / 16.0184634), 4)
                End If
            Else
                rychlost_zvuku = 340.4
                hustota_vzduchu = 1.168
            End If
        Catch ex As Exception
            chyba = True
        End Try
    End Sub

    Private Sub Checkbox_Standardní_atmosféra_ICAO_CheckedChanged(sender As Object, e As EventArgs) Handles Checkbox_Standardní_atmosféra_ICAO.CheckedChanged
        If Checkbox_Standardní_atmosféra_ICAO.Checked = True Then


            combobox_hustota_vzduchu.Enabled = False
            If combobox_hustota_vzduchu.Text = "kg/m³" Then
                Textbox_Hustota_vzduchu.Text = "1,168"
            ElseIf combobox_hustota_vzduchu.Text = "lb/ft³" Then
                Textbox_Hustota_vzduchu.Text = "0,073"
            End If

            Textbox_Teplota.Enabled = False
            combobox_teplota_vzduchu.Enabled = False
            If combobox_teplota_vzduchu.Text = "°C" Then
                Textbox_Teplota.Text = "15"
            ElseIf combobox_teplota_vzduchu.Text = "°F" Then
                Textbox_Teplota.Text = "59"
            End If

            combobox_nadmořská_výška.Enabled = False
            Textbox_Nadmořská_výška.Enabled = False
            If combobox_nadmořská_výška.Text = "m" Then
                Textbox_Nadmořská_výška.Text = "400"
            ElseIf combobox_nadmořská_výška.Text = "ft" Then
                Textbox_Nadmořská_výška.Text = "1312"
            ElseIf combobox_nadmořská_výška.Text = "yd" Then
                Textbox_Nadmořská_výška.Text = "437"
            End If

        Else
            Textbox_Hustota_vzduchu.Text = Nothing
            Textbox_Teplota.Enabled = True
            Textbox_Teplota.Text = Nothing
            Textbox_Nadmořská_výška.Enabled = True
            Textbox_Nadmořská_výška.Text = Nothing

            combobox_hustota_vzduchu.Enabled = True
            combobox_nadmořská_výška.Enabled = True
            combobox_teplota_vzduchu.Enabled = True
        End If
    End Sub

    Private Sub checkbox_bezvětří_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_bezvětří.CheckedChanged
        If checkbox_bezvětří.Checked = True Then

            textbox_rychlost_větru.Text = Nothing
            textbox_rychlost_větru.Enabled = False
            combobox_rychlost_větru.Enabled = False

            radiobutton_E.Checked = False
            radiobutton_E.Enabled = False
            radiobutton_NE.Checked = False
            radiobutton_NE.Enabled = False
            radiobutton_NW.Checked = False
            radiobutton_NW.Enabled = False
            radiobutton_SE.Checked = False
            radiobutton_SE.Enabled = False
            radiobutton_SW.Checked = False
            radiobutton_SW.Enabled = False
            radiobutton_W.Checked = False
            radiobutton_W.Enabled = False
            radiobutton_N.Checked = False
            radiobutton_N.Enabled = False
            radiobutton_S.Checked = False
            radiobutton_S.Enabled = False
        Else

            textbox_rychlost_větru.Enabled = True
            combobox_rychlost_větru.Enabled = True

            radiobutton_E.Enabled = True
            radiobutton_NE.Enabled = True
            radiobutton_NW.Enabled = True
            radiobutton_SE.Enabled = True
            radiobutton_SW.Enabled = True
            radiobutton_W.Enabled = True
            radiobutton_N.Enabled = True
            radiobutton_S.Enabled = True

            radiobutton_E.Checked = True
        End If
    End Sub

    Private Sub vynulovat()
        hustota_vzduchu = 0
        rychlost_větru = 0
        rychlost_zvuku = 0
    End Sub

    Private Sub Vlastnosti_Atmosféry_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Hlavní_okno.Enabled = True
        ulozeni_pameti()
    End Sub

    Private Sub combobox_hustota_vzduchu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_hustota_vzduchu.SelectedIndexChanged
        If Textbox_Hustota_vzduchu.Text <> Nothing Then
            If combobox_hustota_vzduchu.Text = "kg/m³" Then
                Textbox_Hustota_vzduchu.Text = Round(Val(Textbox_Hustota_vzduchu.Text * 16.0184634), 3)
            Else
                Textbox_Hustota_vzduchu.Text = Round(Val(Textbox_Hustota_vzduchu.Text / 16.0184634), 4)
            End If
        End If
    End Sub

    Private Sub vyvolani_pameti()
        If My.Settings.pamet_vlastnosti_atmosfery_combobox_hustota_vzduchu <> Nothing Then
            combobox_hustota_vzduchu.Text = My.Settings.pamet_vlastnosti_atmosfery_combobox_hustota_vzduchu
            combobox_rychlost_větru.Text = My.Settings.pamet_vlastnosti_atmosfery_combobox_rychlost_vetru
            combobox_teplota_vzduchu.Text = My.Settings.pamet_vlastnosti_atmosfery_combobox_teplota_vzduchu
            combobox_nadmořská_výška.Text = My.Settings.pamet_vlastnosti_atmosfery_combobox_nadmorska_vyska
            checkbox_bezvětří.Checked = My.Settings.pamet_vlastnosti_atmosfery_chekcbox_bezvetri
            Checkbox_Standardní_atmosféra_ICAO.Checked = My.Settings.pamet_vlastnosti_atmosfery_chekcbox_standardni_atmosfera_ICAO

            radiobutton_NW.Checked = My.Settings.pamet_vlastnosti_atmosfery_checkbox_NW
            radiobutton_NE.Checked = My.Settings.pamet_vlastnosti_atmosfery_chekcbox_NE
            radiobutton_W.Checked = My.Settings.pamet_vlastnosti_atmosfery_chekcbox_W
            radiobutton_E.Checked = My.Settings.pamet_vlastnosti_atmosfery_chekcbox_E
            radiobutton_SW.Checked = My.Settings.pamet_vlastnosti_atmosfery_chekcbox_SW
            radiobutton_SE.Checked = My.Settings.pamet_vlastnosti_atmosfery_chekcbox_SE
            radiobutton_N.Checked = My.Settings.pamet_vlastnosti_atmosfery_chekcbox_N
            radiobutton_S.Checked = My.Settings.pamet_vlastnosti_atmosfery_chekcbox_S

        Else
            combobox_hustota_vzduchu.Text = "kg/m³"
            combobox_rychlost_větru.Text = "km/h"
            combobox_teplota_vzduchu.Text = "°C"
            combobox_nadmořská_výška.Text = "m"
            checkbox_bezvětří.Checked = True
            Checkbox_Standardní_atmosféra_ICAO.Checked = True
        End If
    End Sub

    Private Sub ulozeni_pameti()
        My.Settings.pamet_vlastnosti_atmosfery_combobox_hustota_vzduchu = combobox_hustota_vzduchu.Text
        My.Settings.pamet_vlastnosti_atmosfery_combobox_rychlost_vetru = combobox_rychlost_větru.Text
        My.Settings.pamet_vlastnosti_atmosfery_combobox_teplota_vzduchu = combobox_teplota_vzduchu.Text
        My.Settings.pamet_vlastnosti_atmosfery_combobox_nadmorska_vyska = combobox_nadmořská_výška.Text
        My.Settings.pamet_vlastnosti_atmosfery_chekcbox_bezvetri = checkbox_bezvětří.Checked
        My.Settings.pamet_vlastnosti_atmosfery_chekcbox_standardni_atmosfera_ICAO = Checkbox_Standardní_atmosféra_ICAO.Checked

        My.Settings.pamet_vlastnosti_atmosfery_checkbox_NW = radiobutton_NW.Checked
        My.Settings.pamet_vlastnosti_atmosfery_chekcbox_NE = radiobutton_NE.Checked
        My.Settings.pamet_vlastnosti_atmosfery_chekcbox_W = radiobutton_W.Checked
        My.Settings.pamet_vlastnosti_atmosfery_chekcbox_E = radiobutton_E.Checked
        My.Settings.pamet_vlastnosti_atmosfery_chekcbox_SW = radiobutton_SW.Checked
        My.Settings.pamet_vlastnosti_atmosfery_chekcbox_SE = radiobutton_SE.Checked
        My.Settings.pamet_vlastnosti_atmosfery_chekcbox_N = radiobutton_N.Checked
        My.Settings.pamet_vlastnosti_atmosfery_chekcbox_S = radiobutton_S.Checked

        My.Settings.Save()
    End Sub
End Class