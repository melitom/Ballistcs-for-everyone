Imports System.Math
Public Class Hlavní_okno

    Dim počáteční_rychlost As Decimal = 0
    Dim hmotnost As Decimal = 0
    Dim koeficient_odporu As Decimal = 0
    Dim plocha As Decimal = 0
    Dim vzdálenost_osy_miridel_od_hlavne As Double = 0
    Dim průměr_střely As Decimal = 10

    Dim g As Decimal = 9.823
    Dim odporova_slozka_g As Decimal = 0
    Dim uhel_sklonu As Decimal = 0

    Dim vzdálenost_cíle As Decimal = 0

    Dim nástřelná_vzdálenost As Decimal = 0
    Dim poloha_zásahu_v_nástřelné_vzdálenosti As Double = 0

    Dim hustota_vzduchu As Decimal = 0

    Dim úhel_výstřelu As Decimal = 0
    Dim úhel_nástřelu As Decimal = 0
    Dim úhel_pro_graf As Decimal = 0
    Dim určení_úhlu As String = ""

    Dim čas_pohybu As Decimal = 0
    Dim cílová_rychlost As Decimal = 0

    Dim spočítat_pouze_nástřelnou_trajektorii As Boolean = True
    Dim chyba As Boolean = False
    Dim kontrola_dostřel As Boolean = False

    Dim pojistka_nástřelu_interval_času As Decimal = 0
    Dim pojistka_nástřelu_zaokrouhleni As Integer = 0
    Dim pojistka_nástřelu_interval_úhlu As Decimal = 0
    Dim pojistka_výstřelu_interval_času As Decimal = 0
    Dim pojistka_výstřelu_zaokrouhleni As Integer = 0
    Dim pojistka_výstřelu_interval_úhlu As Decimal = 0
    Dim pojistka_výpočtu_pro_garf_interval_času As Decimal = 0

    Dim rychlost As Double = 0
    Dim proměnný_koeficient_odporu As Decimal = 0

    Dim rychlost_bočního_větru As Double = 0
    Dim směr_bočního_větru As String = ""
    Dim rychlost_vetru_celni_zadni As Decimal = 0

    Dim úhel_nástřelu_předchozího_výpočtu As Decimal = 0


    Dim string_tisk_povolen As String = ""

    Dim tisk_povolen_ustova_rychlost As String = ""
    Dim tisk_povolen_combobox_ustova_rychlost As String = ""
    Dim tisk_povolen_hmotnost As String = ""
    Dim tisk_povolen_combobox_hmotnost As String = ""
    Dim tisk_povolen_balisticky_koeficient As String = ""
    Dim tisk_povolen_combobox_balisticky_koeficient As String = ""
    Dim tisk_povolen_vzdalenost_cile As String = ""
    Dim tisk_povolen_combobox_vzdalenost_cile As String = ""
    Dim tisk_povolen_vyska_miridel As String = ""
    Dim tisk_povolen_combobox_vyska_miridel As String = ""
    Dim tisk_povolen_uhel_sklonu As String = ""
    Dim tisk_povolen_nastrelna_vzdalenost As String = ""
    Dim tisk_povolen_combobox_nastrelna_vzdalenost As String = ""
    Dim tisk_povolen_poloha_zasahu As String = ""
    Dim tisk_povolen_combobox_poloha_zasahu As String = ""


    Private Sub Button_Spočítej_Click(sender As Object, e As EventArgs) Handles Button_Spočítej.Click

        My.Settings.tisk_povolen = False
        Button_Spočítej.Text = "Calculation in progress"
        Button_Spočítej.Enabled = False
        spočítat_pouze_nástřelnou_trajektorii = False
        chyba = False
        kontrola_dostřel = True
        vynulovat()
        zápis_proměnných()

        If chyba = False Then
            kontrola_dostřelu()
        End If
        If chyba = False And kontrola_dostřel = True Then

            pojistka_výpočtů()
            nastavení_grafu()

            If Checkbox_Zbraň_je_nastřelená.Checked = True Then

                If checkbox_použít_úhel_nástřelu_z_předchozího_výpočtu.Checked = True Then

                    úhel_nástřelu = úhel_nástřelu_předchozího_výpočtu

                    If Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Checked = True Then
                        spočítat_pouze_nástřelnou_trajektorii = True
                        úhel_pro_graf = úhel_nástřelu
                        výpočet_pro_graf()

                    Else

                        určení_úhlu = "úhel nástřelu"
                        úhel_pro_graf = úhel_nástřelu
                        výpočet_pro_graf()

                        výpočet_úhlu_pro_vzdálenost_cíle()
                        určení_úhlu = "úhel výstřelu"
                        úhel_pro_graf = úhel_výstřelu
                        výpočet_pro_graf()

                    End If

                Else
                    úhel_nástřelu_předchozího_výpočtu = 0
                    výpočet_úhlu_pro_nástřelnou_vzdálenost()

                    If Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Checked = True Then
                        spočítat_pouze_nástřelnou_trajektorii = True
                        úhel_pro_graf = úhel_nástřelu
                        výpočet_pro_graf()

                    Else

                        určení_úhlu = "úhel nástřelu"
                        úhel_pro_graf = úhel_nástřelu
                        výpočet_pro_graf()

                        výpočet_úhlu_pro_vzdálenost_cíle()
                        určení_úhlu = "úhel výstřelu"
                        úhel_pro_graf = úhel_výstřelu
                        výpočet_pro_graf()
                    End If

                End If

            Else
                checkbox_použít_úhel_nástřelu_z_předchozího_výpočtu.Enabled = False
                výpočet_úhlu_pro_vzdálenost_cíle()
                určení_úhlu = "úhel výstřelu"
                úhel_pro_graf = úhel_výstřelu
                výpočet_pro_graf()
            End If

            zápis_výsledků()
            ulozeni_pameti()
            string_tisk_povolen = "tlacitko_spocitej"
            tisk_povolen()

        Else
            If kontrola_dostřel = False Then
                MsgBox("Incorrectly entered parameters, the bullet cannot reach the required distance at a maximum shot angle of 4.5° = 80MRAD = 270MOA.", MsgBoxStyle.Critical)
            End If

        End If

        Button_Spočítej.Enabled = True
        Button_Spočítej.Text = "Calculate"

    End Sub
    Private Sub zápis_proměnných()
        Dim chyba_úsťová_rychlost As Boolean = False
        Dim chyba_hmotnost As Boolean = False
        Dim chyba_balistický_koeficient As Boolean = False
        Dim chyba_vzdálenost_cíle As Boolean = False
        Dim chyba_nástřelná_vzdálenost As Boolean = False
        Dim chyba_poloha_zásahu_v_nástřelu As Boolean = False
        Dim chyba_vzdálenost_osy_miridel As Boolean = False
        Dim chyba_uhel_sklonu As Boolean = False

        Dim chyba_zvoleni_jednotek_puskohledu As Boolean = False
        Dim chyba_zvoleni_kliku_v_MOA As Boolean = False

        Try

            Try
                Textbox_Počáteční_rychlost.Text = Textbox_Počáteční_rychlost.Text.Replace(".", ",")
                Textbox_hmotnost.Text = Textbox_hmotnost.Text.Replace(".", ",")
                Textbox_Koeficient_odporu.Text = Textbox_Koeficient_odporu.Text.Replace(".", ",")
                Textbox_Vzdálenost_cíle.Text = Textbox_Vzdálenost_cíle.Text.Replace(".", ",")
                Textbox_Vzdálenost_mířidel.Text = Textbox_Vzdálenost_mířidel.Text.Replace(".", ",")
                textbox_uhel_sklonu.Text = textbox_uhel_sklonu.Text.Replace(".", ",")
                Textbox_Nástřelná_vzdálenost.Text = Textbox_Nástřelná_vzdálenost.Text.Replace(".", ",")
                Textbox_Poloha_zásahu_v_nástřelu.Text = Textbox_Poloha_zásahu_v_nástřelu.Text.Replace(".", ",")
            Catch ex As Exception
                chyba = True
            End Try


            'Zápis atmosféry a větru
            If My.Settings.hustota_vzduchu = 0 Then
                hustota_vzduchu = 1.218
            Else
                hustota_vzduchu = My.Settings.hustota_vzduchu
            End If

            If My.Settings.rychlost_bočního_větru = Nothing And My.Settings.rychlost_vetru_celni_zadni_pro_vypocet = Nothing Then
                rychlost_bočního_větru = 0
                rychlost_vetru_celni_zadni = 0
            Else
                rychlost_bočního_větru = My.Settings.rychlost_bočního_větru
                rychlost_vetru_celni_zadni = My.Settings.rychlost_vetru_celni_zadni_pro_vypocet
            End If

            'Zápis a výpočet hmotnosti, koeficientu a rychlosti
            If combobox_počáteční_rychlost.Text = "m/s" Then
                Try
                    počáteční_rychlost = Textbox_Počáteční_rychlost.Text
                Catch ex As Exception
                    chyba_úsťová_rychlost = True
                End Try
            ElseIf combobox_počáteční_rychlost.Text = "fps" Then
                Try
                    počáteční_rychlost = Textbox_Počáteční_rychlost.Text * 0.3048
                Catch ex As Exception
                    chyba_úsťová_rychlost = True
                End Try
            Else
                chyba = True
            End If

            If combobox_hmotnost_střely.Text = "g" Then
                Try
                    hmotnost = Textbox_hmotnost.Text / 1000
                Catch ex As Exception
                    chyba_hmotnost = True
                End Try
            ElseIf combobox_hmotnost_střely.Text = "grs" Then
                Try
                    hmotnost = (Textbox_hmotnost.Text * 0.06479891) / 1000
                Catch ex As Exception
                    chyba_hmotnost = True
                End Try
            Else
                chyba = True
            End If

            Try
                If Combobox_výběr_koeficientů.Text = "G1" Then
                    koeficient_odporu = 0.3 * (((hmotnost * 2.204627) / ((průměr_střely * 0.039370787) ^ 2)) / Textbox_Koeficient_odporu.Text)
                ElseIf Combobox_výběr_koeficientů.Text = "G7" Then
                    koeficient_odporu = 0.12 * (((hmotnost * 2.204627) / ((průměr_střely * 0.039370787) ^ 2)) / Textbox_Koeficient_odporu.Text)
                Else
                    chyba = True
                End If
            Catch ex As Exception
                chyba_balistický_koeficient = True
            End Try

            plocha = ((průměr_střely ^ 2 * PI) / 4) / 1000000

            Try
                If combobox_vzdálenost_mířidel.Text = "mm" Then
                    vzdálenost_osy_miridel_od_hlavne = Textbox_Vzdálenost_mířidel.Text / 1000
                ElseIf combobox_vzdálenost_mířidel.Text = "in" Then
                    vzdálenost_osy_miridel_od_hlavne = (Textbox_Vzdálenost_mířidel.Text * 25.4) / 1000
                Else
                    chyba = True
                End If
            Catch ex As Exception
                chyba_vzdálenost_osy_miridel = True
            End Try

            Try
                Textbox_Vzdálenost_cíle.Text = Round(Val(Textbox_Vzdálenost_cíle.Text), 0)

                If combobox_vzdálenost_cíle.Text = "m" Then
                    vzdálenost_cíle = Textbox_Vzdálenost_cíle.Text
                ElseIf combobox_vzdálenost_cíle.Text = "ft" Then
                    vzdálenost_cíle = Textbox_Vzdálenost_cíle.Text * 0.3048
                ElseIf combobox_vzdálenost_cíle.Text = "yd" Then
                    vzdálenost_cíle = Textbox_Vzdálenost_cíle.Text * 0.9144
                Else
                    chyba = True
                End If
            Catch ex As Exception
                chyba_vzdálenost_cíle = True
            End Try

            ' Zápis úhlu sklonu a výpočet odporove slozky gravitacniho zrychleni
            Try
                If textbox_uhel_sklonu.Text = Nothing Then
                    textbox_uhel_sklonu.Text = 0
                End If

                uhel_sklonu = textbox_uhel_sklonu.Text

                g = 9.823 * Cos(uhel_sklonu * (PI / 180))
                odporova_slozka_g = 9.823 * Sin(uhel_sklonu * (PI / 180))

            Catch ex As Exception
                chyba_uhel_sklonu = True
            End Try

            If Checkbox_Zbraň_je_nastřelená.Checked = True And checkbox_použít_úhel_nástřelu_z_předchozího_výpočtu.Checked = False Then
                Try
                    Textbox_Nástřelná_vzdálenost.Text = Round(Val(Textbox_Nástřelná_vzdálenost.Text), 0)

                    If combobox_nástřelná_vzdálenost.Text = "m" Then
                        nástřelná_vzdálenost = Textbox_Nástřelná_vzdálenost.Text
                    ElseIf combobox_nástřelná_vzdálenost.Text = "ft" Then
                        nástřelná_vzdálenost = Round(Val(Textbox_Nástřelná_vzdálenost.Text * 0.3048), 0)
                    ElseIf combobox_nástřelná_vzdálenost.Text = "yd" Then
                        nástřelná_vzdálenost = Round(Val(Textbox_Nástřelná_vzdálenost.Text * 0.9144), 0)
                    Else
                        chyba = True
                    End If
                Catch ex As Exception
                    chyba_nástřelná_vzdálenost = True
                End Try

                Try
                    If combobox_poloha_zásahu.Text = "cm" Then
                        Textbox_Poloha_zásahu_v_nástřelu.Text = Round(Val(Textbox_Poloha_zásahu_v_nástřelu.Text), 0)
                        poloha_zásahu_v_nástřelné_vzdálenosti = Textbox_Poloha_zásahu_v_nástřelu.Text / 100
                    ElseIf combobox_poloha_zásahu.Text = "in" Then
                        Textbox_Poloha_zásahu_v_nástřelu.Text = Round(Val(Textbox_Poloha_zásahu_v_nástřelu.Text), 1)
                        poloha_zásahu_v_nástřelné_vzdálenosti = (Textbox_Poloha_zásahu_v_nástřelu.Text * 2.54) / 100
                    Else
                        chyba = True
                    End If
                Catch ex As Exception
                    chyba_poloha_zásahu_v_nástřelu = True
                End Try
            End If

            If Textbox_Vzdálenost_mířidel.Text = Nothing Or vzdálenost_osy_miridel_od_hlavne < 0 Or vzdálenost_osy_miridel_od_hlavne > 0.204 Then
                chyba_vzdálenost_osy_miridel = True
                chyba = True
            End If

            'Pojistka pro žádné, nulové a záporné hodnoty
            If Textbox_Počáteční_rychlost.Text = 0 Or počáteční_rychlost > 1500 Or počáteční_rychlost < 0 Then
                chyba = True
                chyba_úsťová_rychlost = True
            ElseIf Textbox_hmotnost.Text = 0 Or Textbox_hmotnost.Text < 0 Then
                chyba = True
                chyba_hmotnost = True
            ElseIf Textbox_Koeficient_odporu.Text = 0 Or Textbox_Koeficient_odporu.Text < 0 Then
                chyba = True
                chyba_balistický_koeficient = True
            ElseIf Textbox_Vzdálenost_cíle.Text = 0 Or Textbox_Vzdálenost_cíle.Text < 0 Then
                chyba = True
                chyba_vzdálenost_cíle = True
            ElseIf textbox_uhel_sklonu.Text < -89 Or textbox_uhel_sklonu.Text > 89 Then
                chyba = True
                chyba_uhel_sklonu = True
            ElseIf Checkbox_Zbraň_je_nastřelená.Checked = True And checkbox_použít_úhel_nástřelu_z_předchozího_výpočtu.Checked = False Then
                If Textbox_Nástřelná_vzdálenost.Text = 0 Or Textbox_Nástřelná_vzdálenost.Text < 10 Then
                    chyba = True
                    chyba_nástřelná_vzdálenost = True
                End If
            End If

            'Pojistka pro nevyplnění checkboxů
            If Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Checked = False Then
                If Checkbox_Střelba_s_puškohledem.Checked = True Then
                    If Checkbox_jednotky_MOA.Checked = False And Checkbox_Jednotky_MRAD.Checked = False Then
                        chyba = True
                        chyba_zvoleni_jednotek_puskohledu = True
                    ElseIf Checkbox_jednotky_MOA.Checked = True Then
                        If Checkbox_14_MOA.Checked = False And Checkbox_18_MOA.Checked = False Then
                            chyba = True
                            chyba_zvoleni_kliku_v_MOA = True
                        End If
                    End If
                End If
            End If

            If chyba_úsťová_rychlost = True Then
                MsgBox("Wrong or missing data about muzzle velocity." & vbNewLine & "Tip: The maximum possible value of the muzzle velocity is limited to 1500 m/s = 4921 fps." & vbNewLine & "Tip: The muzzle velocity cannot be less than or equal to zero.", MsgBoxStyle.Exclamation)
            ElseIf chyba_hmotnost = True Then
                MsgBox("Wrong or missing data about bullet weight." & vbNewLine & "Tip: The bullet weight cannot be less than or equal to zero.", MsgBoxStyle.Exclamation)
            ElseIf chyba_vzdálenost_osy_miridel = True Then
                MsgBox("Wrong or missing data about sights height." & vbNewLine & "Tip: The sights height can never be less than zero, or greater than 203 mm = 8 in.", MsgBoxStyle.Exclamation)
            ElseIf chyba_balistický_koeficient = True Then
                MsgBox("Wrong or missing data about ballistic coefficient." & vbNewLine & "Tip: The ballistic coefficient cannot be less than or equal to zero.", MsgBoxStyle.Exclamation)
            ElseIf chyba_vzdálenost_cíle = True Then
                MsgBox("Wrong or missing data about target distance." & vbNewLine & "Tip: The target distance cannot be less than or equal to zero.", MsgBoxStyle.Exclamation)
            ElseIf chyba_nástřelná_vzdálenost = True Then
                MsgBox("Wrong or missing data about sighting distance." & vbNewLine & "Tip: The sighting distance cannot be less than 10 m = 10,9 yd = 32 ft.", MsgBoxStyle.Exclamation)
            ElseIf chyba_uhel_sklonu = True Then
                MsgBox("Wrong or missing data about angle of shot." & vbNewLine & "Tip: The angle of shot cannot be greater than 89 degrees or less than -89 degrees.", MsgBoxStyle.Exclamation)
            ElseIf chyba_zvoleni_jednotek_puskohledu = True Then
                MsgBox("Please select the unit type on your riflescope in the Calculation settings window.", MsgBoxStyle.Exclamation)
            ElseIf chyba_zvoleni_kliku_v_MOA = True Then
                MsgBox("Please select in which parts of the MOA you can click on your riflescope in the Calculation settings window.", MsgBoxStyle.Exclamation)

                'Bezpečnostní omezení hodnoty polohy nástřelu v nástřelné vzdálenosti 
            ElseIf poloha_zásahu_v_nástřelné_vzdálenosti < 0 Then
                If Round(Val(Tan((Abs(poloha_zásahu_v_nástřelné_vzdálenosti) - vzdálenost_osy_miridel_od_hlavne) / nástřelná_vzdálenost)), 4) > 0.012 Then

                    chyba = True
                    If combobox_poloha_zásahu.Text = "cm" Then
                        MsgBox("For the current sights settings and sighting distance is the minimum point of impact limited to " & Round(Val(((0.012 * Abs(nástřelná_vzdálenost)) + vzdálenost_osy_miridel_od_hlavne) * (-100)), 0) & " cm.", MsgBoxStyle.Exclamation)
                    Else
                        MsgBox("For the current sights settings and sighting distance is the minimum point of impact limited to " & Round(Val(((0.012 * Abs(nástřelná_vzdálenost)) + vzdálenost_osy_miridel_od_hlavne) * (-39.37)), 0) & " in.", MsgBoxStyle.Exclamation)
                    End If

                End If
            ElseIf poloha_zásahu_v_nástřelné_vzdálenosti > 0 Then
                If Round(Val(Tan((vzdálenost_osy_miridel_od_hlavne + Abs(poloha_zásahu_v_nástřelné_vzdálenosti)) / nástřelná_vzdálenost)), 4) > 0.012 Then
                    chyba = True
                    If combobox_poloha_zásahu.Text = "cm" Then
                        MsgBox("For the current sights settings and sighting distance is the maximum point of impact limited to " & Round(Val(((0.012 * nástřelná_vzdálenost) - vzdálenost_osy_miridel_od_hlavne) * 100), 0) & " cm.", MsgBoxStyle.Exclamation)
                    Else
                        MsgBox("For the current sights settings and sighting distance is the maximum point of impact limited to " & Round(Val(((0.012 * nástřelná_vzdálenost) - vzdálenost_osy_miridel_od_hlavne) * 39.37), 0) & " in.", MsgBoxStyle.Exclamation)
                    End If
                End If
            End If


        Catch ex As Exception

            chyba = True

            If chyba_úsťová_rychlost = True Then
                MsgBox("Wrong or missing data about muzzle velocity.", MsgBoxStyle.Exclamation)
            ElseIf chyba_hmotnost = True Then
                MsgBox("Wrong or missing data about bullet weight.", MsgBoxStyle.Exclamation)
            ElseIf chyba_balistický_koeficient = True Then
                MsgBox("Wrong or missing data about ballistic coefficient.", MsgBoxStyle.Exclamation)
            ElseIf chyba_nástřelná_vzdálenost = True Then
                MsgBox("Wrong or missing data about sighting distance.", MsgBoxStyle.Exclamation)
            ElseIf chyba_poloha_zásahu_v_nástřelu = True Then
                MsgBox("Wrong or missing data about point of impact at sighting distance.", MsgBoxStyle.Exclamation)
            ElseIf chyba_vzdálenost_cíle = True Then
                MsgBox("Wrong or missing data about target distance.", MsgBoxStyle.Exclamation)
            ElseIf chyba_vzdálenost_osy_miridel = True Then
                MsgBox("Wrong or missing data about sights height.", MsgBoxStyle.Exclamation)
            ElseIf chyba_uhel_sklonu = True Then
                MsgBox("Wrong or missing data about angle of shot.", MsgBoxStyle.Exclamation)
            End If
        End Try
    End Sub
    Private Sub zápis_výsledků()
        Dim korekce_větru_klikáním As Double = 0
        Dim dráha_střely_ve_větru As Double = 0
        Dim korekce_elevace_prenasenim As Double = 0
        Dim korekce_elevace_klikanim As Double = 0


        If checkbox_metricke_jednotky.Checked = True Then
            label_rychlost_v_cíli.Text = "Velocity at target: " & Round(Val(cílová_rychlost), 0) & " m/s"
        Else
            label_rychlost_v_cíli.Text = "Velocity at target: " & Round(Val(cílová_rychlost / 0.3048), 0) & " fps"
        End If

        label_počáteční_energie.Text = "Muzzle energy: " & Round(Val(0.5 * hmotnost * počáteční_rychlost ^ 2), 1) & " J"
        label_energie_v_cíli.Text = "Energy at target: " & Round(Val(0.5 * hmotnost * cílová_rychlost ^ 2), 1) & " J"
        label_doba_pohybu.Text = "Time of flight: " & Round(Val(čas_pohybu), 3) & " sec"

        'Korekce větru
        If rychlost_bočního_větru <> 0 Or My.Settings.korekce_stranova_derivace_coriolis <> 0 Then

            dráha_střely_ve_větru = rychlost_bočního_větru * (čas_pohybu - (vzdálenost_cíle / počáteční_rychlost)) + My.Settings.korekce_stranova_derivace_coriolis

            If dráha_střely_ve_větru < 0 Then
                dráha_střely_ve_větru = dráha_střely_ve_větru * (-1)
                směr_bočního_větru = "Pravá"
            Else
                směr_bočního_větru = "Levá"
            End If

            korekce_větru_klikáním = Atan(dráha_střely_ve_větru / vzdálenost_cíle) * (180 / PI)

            If spočítat_pouze_nástřelnou_trajektorii = False Then

                If Checkbox_Střelba_s_puškohledem.Checked = False Then

                    If checkbox_metricke_jednotky.Checked = True Then
                        label_korekce_větru_přenášením.Text = "Sights correction: " & Round(Val(dráha_střely_ve_větru) * 100, 1) & " cm"
                    Else
                        label_korekce_větru_přenášením.Text = "Sights correction: " & Round(Val((dráha_střely_ve_větru) * 100) / 2.54, 1) & " in"
                    End If
                    label_korekce_větru_klikáním.Text = "Scope correction: " & "-"

                ElseIf Checkbox_Střelba_s_puškohledem.Checked = True Then

                    If checkbox_metricke_jednotky.Checked = True Then
                        label_korekce_větru_přenášením.Text = "Sights correction: " & Round(Val(dráha_střely_ve_větru) * 100, 1) & " cm"
                    Else
                        label_korekce_větru_přenášením.Text = "Sights correction: " & Round(Val((dráha_střely_ve_větru) * 100) / 2.54, 1) & " in"
                    End If

                    If Checkbox_jednotky_MOA.Checked = True Then
                        If Checkbox_14_MOA.Checked = True Then
                            If směr_bočního_větru = "Pravá" Then
                                label_korekce_větru_klikáním.Text = "Scope correction: " & Round(Val((korekce_větru_klikáním) * 60), 2) & " MOA" & " (" & Round(Val(((korekce_větru_klikáním) * 60) * 4), 0) & " clicks) left"
                            Else
                                label_korekce_větru_klikáním.Text = "Scope correction: " & Round(Val((korekce_větru_klikáním) * 60), 2) & " MOA" & " (" & Round(Val(((korekce_větru_klikáním) * 60) * 4), 0) & " clicks) right"
                            End If

                        ElseIf Checkbox_18_MOA.Checked = True Then
                            If směr_bočního_větru = "Pravá" Then
                                label_korekce_větru_klikáním.Text = "Scope correction: " & Round(Val((korekce_větru_klikáním) * 60), 2) & " MOA" & " (" & Round(Val(((korekce_větru_klikáním) * 60) * 8), 0) & " clicks) left"
                            Else
                                label_korekce_větru_klikáním.Text = "Scope correction: " & Round(Val((korekce_větru_klikáním) * 60), 2) & " MOA" & " (" & Round(Val(((korekce_větru_klikáním) * 60) * 8), 0) & " clicks) right"
                            End If
                        End If
                    ElseIf Checkbox_Jednotky_MRAD.Checked = True Then
                        If směr_bočního_větru = "Pravá" Then
                            label_korekce_větru_klikáním.Text = "Scope correction: " & Round(Val(((korekce_větru_klikáním / (180 / PI))) * 1000), 2) & " MRAD" & " (" & Round(Val(((korekce_větru_klikáním) / (180 / PI)) * 1000), 2) * 10 & " clicks) left"
                        Else
                            label_korekce_větru_klikáním.Text = "Scope correction: " & Round(Val(((korekce_větru_klikáním / (180 / PI))) * 1000), 2) & " MRAD" & " (" & Round(Val(((korekce_větru_klikáním) / (180 / PI)) * 1000), 2) * 10 & " clicks) right"
                        End If

                    End If
                End If
            End If
        Else
            If checkbox_metricke_jednotky.Checked = True Then
                label_korekce_větru_přenášením.Text = "Sights correction: 0 cm"
            Else
                label_korekce_větru_přenášením.Text = "Sights correction: 0 in"
            End If
            If Checkbox_jednotky_MOA.Checked = True Then
                label_korekce_větru_klikáním.Text = "Scope correction: 0 MOA"
            ElseIf Checkbox_Jednotky_MRAD.Checked = True Then
                label_korekce_větru_klikáním.Text = "Scope correction: 0 MRAD"
            Else
                label_korekce_větru_klikáním.Text = "Scope correction: -"
            End If

        End If

        'Korekce elevace
        If spočítat_pouze_nástřelnou_trajektorii = False Then

            korekce_elevace_prenasenim = (Tan((úhel_výstřelu - úhel_nástřelu) / (180 / PI)) * vzdálenost_cíle) + (My.Settings.korekce_vyskova_coriolis * (-1))

            korekce_elevace_klikanim = Atan(korekce_elevace_prenasenim / vzdálenost_cíle) * (180 / PI)

            If Checkbox_Střelba_s_puškohledem.Checked = False Then

                If checkbox_metricke_jednotky.Checked = True Then
                    label_korekce_přenášenim.Text = "Sights correction: " & Round(Val(korekce_elevace_prenasenim) * 100, 1) & " cm"
                Else
                    label_korekce_přenášenim.Text = "Sights correction: " & Round(Val(korekce_elevace_prenasenim) * 39.37, 1) & " in"
                End If

                label_korekce_klikáním.Text = "Scope correction: " & "-"

            ElseIf Checkbox_Střelba_s_puškohledem.Checked = True Then
                If checkbox_metricke_jednotky.Checked = True Then
                    label_korekce_přenášenim.Text = "Sights correction: " & Round(Val(korekce_elevace_prenasenim) * 100, 1) & " cm"
                Else
                    label_korekce_přenášenim.Text = "Sights correction: " & Round(Val(korekce_elevace_prenasenim) * 39.37, 1) & " in"
                End If
                If Checkbox_jednotky_MOA.Checked = True Then
                    If Checkbox_14_MOA.Checked = True Then
                        label_korekce_klikáním.Text = "Scope correction: " & Round(Val(korekce_elevace_klikanim * 60), 2) & " MOA" & " (" & Round(Val(((úhel_výstřelu - úhel_nástřelu) * 60) * 4), 0) & " clicks)"
                    ElseIf Checkbox_18_MOA.Checked = True Then
                        label_korekce_klikáním.Text = "Scope correction: " & Round(Val(korekce_elevace_klikanim * 60), 2) & " MOA" & " (" & Round(Val(((úhel_výstřelu - úhel_nástřelu) * 60) * 8), 0) & " clicks)"
                    End If
                ElseIf Checkbox_Jednotky_MRAD.Checked = True Then
                    label_korekce_klikáním.Text = "Scope correction: " & Round(Val((korekce_elevace_klikanim / (180 / PI)) * 1000), 2) & " MRAD" & " (" & Round(Val(((úhel_výstřelu - úhel_nástřelu) / (180 / PI)) * 1000), 2) * 10 & " clicks)"
                End If
            End If
        End If

        If checkbox_metricke_jednotky.Checked = True Then
            Chart1.ChartAreas("ChartArea1").AxisX.Maximum = Round(Val(vzdálenost_cíle / 10), 0) * 10
            Chart1.ChartAreas("ChartArea1").AxisX.Interval = Round(Val(vzdálenost_cíle / 10), 0)
        Else
            Chart1.ChartAreas("ChartArea1").AxisX.Maximum = Round(Val(vzdálenost_cíle / 9.144), 0) * 10
            Chart1.ChartAreas("ChartArea1").AxisX.Interval = Round(Val(vzdálenost_cíle / 9.144), 0)
        End If

        My.Settings.uhel_nastrelu = úhel_nástřelu
        My.Settings.tisk_povolen = True
        My.Settings.doba_pohybu = Round(Val(čas_pohybu), 3)

    End Sub
    Private Sub proměnný_koeficient()
        If Combobox_výběr_koeficientů.Text = "G1" Then
            If rychlost <= 280 Then
                proměnný_koeficient_odporu = koeficient_odporu * 0.83
            ElseIf rychlost > 280 And rychlost <= 330 Then
                proměnný_koeficient_odporu = koeficient_odporu * 1.0
            ElseIf rychlost > 330 And rychlost <= 500 Then
                proměnný_koeficient_odporu = koeficient_odporu * 2.0
            ElseIf rychlost > 500 And rychlost <= 660 Then
                proměnný_koeficient_odporu = koeficient_odporu * 2.1
            ElseIf rychlost > 660 And rychlost <= 830 Then
                proměnný_koeficient_odporu = koeficient_odporu * 1.86
            ElseIf rychlost > 830 And rychlost <= 1000 Then
                proměnný_koeficient_odporu = koeficient_odporu * 1.73
            ElseIf rychlost > 1000 Then
                proměnný_koeficient_odporu = koeficient_odporu * 1.63
            End If
        ElseIf Combobox_výběr_koeficientů.Text = "G7" Then
            If rychlost <= 325 Then
                proměnný_koeficient_odporu = koeficient_odporu * 0.9
            ElseIf rychlost > 325 And rychlost <= 500 Then
                proměnný_koeficient_odporu = koeficient_odporu * 3.08
            ElseIf rychlost > 500 And rychlost <= 660 Then
                proměnný_koeficient_odporu = koeficient_odporu * 2.71
            ElseIf rychlost > 660 And rychlost <= 830 Then
                proměnný_koeficient_odporu = koeficient_odporu * 2.43
            ElseIf rychlost > 830 And rychlost <= 1000 Then
                proměnný_koeficient_odporu = koeficient_odporu * 2.1
            ElseIf rychlost > 1000 Then
                proměnný_koeficient_odporu = koeficient_odporu * 1.7
            End If
        End If
    End Sub
    Private Sub pojistka_výpočtů()
        If nástřelná_vzdálenost <= 30 Then
            pojistka_nástřelu_interval_času = 0.0005
            pojistka_nástřelu_interval_úhlu = 0.0002
            pojistka_nástřelu_zaokrouhleni = 3
            pojistka_výpočtu_pro_garf_interval_času = 0.0005
        ElseIf nástřelná_vzdálenost > 30 And nástřelná_vzdálenost <= 50 Then
            pojistka_nástřelu_interval_času = 0.001
            pojistka_nástřelu_interval_úhlu = 0.0003
            pojistka_nástřelu_zaokrouhleni = 3
            pojistka_výpočtu_pro_garf_interval_času = 0.001
        ElseIf nástřelná_vzdálenost > 50 And nástřelná_vzdálenost <= 100 Then
            pojistka_nástřelu_interval_času = 0.0015
            pojistka_nástřelu_interval_úhlu = 0.0005
            pojistka_nástřelu_zaokrouhleni = 2
            pojistka_výpočtu_pro_garf_interval_času = 0.0015
        ElseIf nástřelná_vzdálenost > 100 And nástřelná_vzdálenost <= 400 Then
            pojistka_nástřelu_interval_času = 0.002
            pojistka_nástřelu_interval_úhlu = 0.0006
            pojistka_nástřelu_zaokrouhleni = 2
            pojistka_výpočtu_pro_garf_interval_času = 0.002
        ElseIf nástřelná_vzdálenost > 400 And nástřelná_vzdálenost <= 1000 Then
            pojistka_nástřelu_interval_času = 0.0035
            pojistka_nástřelu_interval_úhlu = 0.0008
            pojistka_nástřelu_zaokrouhleni = 1
            pojistka_výpočtu_pro_garf_interval_času = 0.0035
        ElseIf nástřelná_vzdálenost > 1000 And nástřelná_vzdálenost <= 2000 Then
            pojistka_nástřelu_interval_času = 0.005
            pojistka_nástřelu_interval_úhlu = 0.001
            pojistka_nástřelu_zaokrouhleni = 1
            pojistka_výpočtu_pro_garf_interval_času = 0.005
        ElseIf nástřelná_vzdálenost > 2000 Then
            pojistka_nástřelu_interval_času = 0.008
            pojistka_nástřelu_interval_úhlu = 0.01
            pojistka_nástřelu_zaokrouhleni = 0
            pojistka_výpočtu_pro_garf_interval_času = 0.008
        End If

        If vzdálenost_cíle <= 30 Then
            pojistka_výstřelu_interval_času = 0.0005
            pojistka_výstřelu_interval_úhlu = 0.0002
            pojistka_výstřelu_zaokrouhleni = 3
            pojistka_výpočtu_pro_garf_interval_času = 0.0005
        ElseIf vzdálenost_cíle > 30 And vzdálenost_cíle <= 50 Then
            pojistka_výstřelu_interval_času = 0.001
            pojistka_výstřelu_interval_úhlu = 0.0003
            pojistka_výstřelu_zaokrouhleni = 3
            pojistka_výpočtu_pro_garf_interval_času = 0.001
        ElseIf vzdálenost_cíle > 50 And vzdálenost_cíle <= 100 Then
            pojistka_výstřelu_interval_času = 0.0015
            pojistka_výstřelu_interval_úhlu = 0.0005
            pojistka_výstřelu_zaokrouhleni = 2
            pojistka_výpočtu_pro_garf_interval_času = 0.0015
        ElseIf vzdálenost_cíle > 100 And vzdálenost_cíle <= 400 Then
            pojistka_výstřelu_interval_času = 0.002
            pojistka_výstřelu_interval_úhlu = 0.0006
            pojistka_výstřelu_zaokrouhleni = 2
            pojistka_výpočtu_pro_garf_interval_času = 0.002
        ElseIf vzdálenost_cíle > 400 And vzdálenost_cíle <= 1000 Then
            pojistka_výstřelu_interval_času = 0.0035
            pojistka_výstřelu_interval_úhlu = 0.001
            pojistka_výstřelu_zaokrouhleni = 1
            pojistka_výpočtu_pro_garf_interval_času = 0.0035
        ElseIf vzdálenost_cíle > 1000 And vzdálenost_cíle <= 2000 Then
            pojistka_výstřelu_interval_času = 0.005
            pojistka_výstřelu_interval_úhlu = 0.001
            pojistka_výstřelu_zaokrouhleni = 1
            pojistka_výpočtu_pro_garf_interval_času = 0.005
        ElseIf vzdálenost_cíle > 2000 Then
            pojistka_výstřelu_interval_času = 0.008
            pojistka_výstřelu_interval_úhlu = 0.001
            pojistka_výstřelu_zaokrouhleni = 0
            pojistka_výpočtu_pro_garf_interval_času = 0.008
        End If
    End Sub

    Private Sub kontrola_dostřelu()
        Dim sin_uhlu As Double = 0
        Dim cos_uhlu As Double = 0
        Dim delta_rychlosti As Double = 0
        Dim poměr_rychlostí As Double = 0
        Dim rychlost_x As Double = 0
        Dim rychlost_y As Double = 0
        Dim dráha_x As Double = 0
        Dim dráha_y As Double = 0
        Dim interval_výpočtu As Decimal = 0.001
        Dim zkusebni_vzdalenost As Decimal = 0

        sin_uhlu = Sin(4.5 / (180 / PI))
        cos_uhlu = Cos(4.5 / (180 / PI))
        rychlost_x = počáteční_rychlost * cos_uhlu
        rychlost_y = počáteční_rychlost * sin_uhlu
        rychlost = počáteční_rychlost
        dráha_y = 0
        dráha_x = 0

        If vzdálenost_cíle < nástřelná_vzdálenost Then
            zkusebni_vzdalenost = nástřelná_vzdálenost
        Else
            zkusebni_vzdalenost = vzdálenost_cíle
        End If

        Do Until dráha_x > zkusebni_vzdalenost Or dráha_y < 0
            proměnný_koeficient()
            delta_rychlosti = (((0.5 * proměnný_koeficient_odporu * hustota_vzduchu * plocha * (rychlost + rychlost_vetru_celni_zadni) ^ 2) / hmotnost) + odporova_slozka_g) * interval_výpočtu
            poměr_rychlostí = delta_rychlosti / rychlost
            rychlost_x = rychlost_x - (poměr_rychlostí * rychlost_x)
            rychlost_y = rychlost_y - ((poměr_rychlostí * rychlost_y) + (g * interval_výpočtu))
            rychlost = ((rychlost_x ^ 2) + (rychlost_y ^ 2)) ^ 0.5
            dráha_y = dráha_y + (rychlost_y * interval_výpočtu)
            dráha_x = dráha_x + (rychlost_x * interval_výpočtu)
        Loop
        If dráha_x < zkusebni_vzdalenost Then
            kontrola_dostřel = False
        Else
            kontrola_dostřel = True
        End If
    End Sub
    Private Sub výpočet_úhlu_pro_vzdálenost_cíle()
        Try
            Dim nástřelná_dráha_y As Double = 0
            Dim sin_uhlu As Double = 0
            Dim cos_uhlu As Double = 0
            Dim delta_rychlosti As Double = 0
            Dim poměr_rychlostí As Double = 0
            Dim rychlost_x As Double = 0
            Dim rychlost_y As Double = 0
            Dim čas_t As Decimal = 0
            Dim dráha_x As Double = 0
            Dim dráha_y As Double = 0
            nástřelná_dráha_y = 1

            'Výpočet základního úhlu výstřelu pomocí šikmého vrhu bez odporu vzduchu
            úhel_výstřelu = Asin(vzdálenost_cíle / ((počáteční_rychlost ^ 2) / g)) * (180 / PI)
            úhel_výstřelu = (úhel_výstřelu / 2) - (pojistka_výstřelu_interval_úhlu * 3)

            Do Until 0 = Round(Val(nástřelná_dráha_y), pojistka_výstřelu_zaokrouhleni) And chyba = False
                úhel_výstřelu = úhel_výstřelu + pojistka_výstřelu_interval_úhlu
                sin_uhlu = Sin(úhel_výstřelu / (180 / PI))
                cos_uhlu = Cos(úhel_výstřelu / (180 / PI))
                rychlost = počáteční_rychlost
                rychlost_y = rychlost * sin_uhlu
                rychlost_x = rychlost * cos_uhlu
                dráha_y = 0 - vzdálenost_osy_miridel_od_hlavne
                dráha_x = 0
                Do Until dráha_x >= vzdálenost_cíle And chyba = False
                    proměnný_koeficient()
                    delta_rychlosti = (((0.5 * proměnný_koeficient_odporu * hustota_vzduchu * plocha * (rychlost + rychlost_vetru_celni_zadni) ^ 2) / hmotnost) + odporova_slozka_g) * pojistka_výstřelu_interval_času
                    poměr_rychlostí = delta_rychlosti / rychlost
                    rychlost_x = rychlost_x - (poměr_rychlostí * rychlost_x)
                    rychlost_y = rychlost_y - ((poměr_rychlostí * rychlost_y) + (g * pojistka_výstřelu_interval_času))
                    rychlost = ((rychlost_x ^ 2) + (rychlost_y ^ 2)) ^ 0.5

                    dráha_y = dráha_y + (rychlost_y * pojistka_výstřelu_interval_času)
                    dráha_x = dráha_x + (rychlost_x * pojistka_výstřelu_interval_času)

                Loop
                nástřelná_dráha_y = dráha_y
            Loop
        Catch ex As Exception
            If chyba = False Then
                MsgBox("An error occurred during the calculation, please check that all data is entered correctly.", MsgBoxStyle.Critical)
            End If
            chyba = True
        End Try
    End Sub

    Private Sub výpočet_pro_graf()
        Try
            Dim sin_uhlu As Double = 0
            Dim cos_uhlu As Double = 0
            Dim delta_rychlosti As Double = 0
            Dim poměr_rychlostí As Double = 0
            Dim rychlost_x As Double = 0
            Dim rychlost_y As Double = 0
            Dim čas_t As Decimal = 0
            Dim dráha_x As Double = 0
            Dim dráha_y As Double = 0
            sin_uhlu = Sin(úhel_pro_graf / (180 / PI))
            cos_uhlu = Cos(úhel_pro_graf / (180 / PI))
            rychlost_x = počáteční_rychlost * cos_uhlu
            rychlost_y = počáteční_rychlost * sin_uhlu
            rychlost = počáteční_rychlost
            dráha_y = 0 - vzdálenost_osy_miridel_od_hlavne
            Do Until dráha_x >= vzdálenost_cíle And chyba = False
                proměnný_koeficient()
                čas_t = čas_t + pojistka_výpočtu_pro_garf_interval_času
                delta_rychlosti = (((0.5 * proměnný_koeficient_odporu * hustota_vzduchu * plocha * (rychlost + rychlost_vetru_celni_zadni) ^ 2) / hmotnost) + odporova_slozka_g) * pojistka_výpočtu_pro_garf_interval_času
                poměr_rychlostí = delta_rychlosti / rychlost
                rychlost_x = rychlost_x - (poměr_rychlostí * rychlost_x)
                rychlost_y = rychlost_y - ((poměr_rychlostí * rychlost_y) + (g * pojistka_výpočtu_pro_garf_interval_času))
                rychlost = ((rychlost_x ^ 2) + (rychlost_y ^ 2)) ^ 0.5
                dráha_y = dráha_y + (rychlost_y * pojistka_výpočtu_pro_garf_interval_času)
                dráha_x = dráha_x + (rychlost_x * pojistka_výpočtu_pro_garf_interval_času)

                If checkbox_metricke_jednotky.Checked = True Then
                    If spočítat_pouze_nástřelnou_trajektorii = True Then
                        Chart1.Series("Trajektorie nástřelu").Points.AddXY(dráha_x, 100 * dráha_y)
                    Else
                        If určení_úhlu = "úhel výstřelu" Then
                            Chart1.Series("Trajektorie tělesa").Points.AddXY(dráha_x, 100 * dráha_y)
                        ElseIf určení_úhlu = "úhel nástřelu" Then
                            Chart1.Series("Trajektorie nástřelu").Points.AddXY(dráha_x, 100 * dráha_y)
                        End If
                    End If
                Else
                    If spočítat_pouze_nástřelnou_trajektorii = True Then
                        Chart1.Series("Trajektorie nástřelu").Points.AddXY(dráha_x / 0.9144, 39.37 * dráha_y)
                    Else
                        If určení_úhlu = "úhel výstřelu" Then
                            Chart1.Series("Trajektorie tělesa").Points.AddXY(dráha_x / 0.9144, 39.37 * dráha_y)
                        ElseIf určení_úhlu = "úhel nástřelu" Then
                            Chart1.Series("Trajektorie nástřelu").Points.AddXY(dráha_x / 0.9144, 39.37 * dráha_y)
                        End If
                    End If
                End If

            Loop
            cílová_rychlost = rychlost
            čas_pohybu = čas_t
        Catch ex As Exception
            If chyba = False Then
                MsgBox("An error occurred during the calculation, please check that all data is entered correctly.", MsgBoxStyle.Critical)
            End If
            chyba = True
        End Try
    End Sub
    Private Sub výpočet_úhlu_pro_nástřelnou_vzdálenost()
        Try
            Dim nástřelná_dráha_y As Double = 0
            Dim sin_uhlu As Double = 0
            Dim cos_uhlu As Double = 0
            Dim delta_rychlosti As Double = 0
            Dim poměr_rychlostí As Double = 0
            Dim rychlost_x As Double = 0
            Dim rychlost_y As Double = 0
            Dim čas_t As Decimal = 0
            Dim dráha_x As Double = 0
            Dim dráha_y As Double = 0

            'Pojistka, aby se nástřelná_dráha_y nerovnala dráha_y 
            nástřelná_dráha_y = (poloha_zásahu_v_nástřelné_vzdálenosti + 50) ^ 2

            'Výpočet nástřelného úhlu
            úhel_nástřelu = (Atan((poloha_zásahu_v_nástřelné_vzdálenosti + vzdálenost_osy_miridel_od_hlavne) / nástřelná_vzdálenost) * (180 / PI)) - 0.03

            Do Until Round(Val(poloha_zásahu_v_nástřelné_vzdálenosti), pojistka_nástřelu_zaokrouhleni) = Round(Val(nástřelná_dráha_y), pojistka_nástřelu_zaokrouhleni) And chyba = False
                úhel_nástřelu = úhel_nástřelu + pojistka_nástřelu_interval_úhlu
                sin_uhlu = Sin(úhel_nástřelu / (180 / PI))
                cos_uhlu = Cos(úhel_nástřelu / (180 / PI))
                rychlost = počáteční_rychlost
                rychlost_y = počáteční_rychlost * sin_uhlu
                rychlost_x = počáteční_rychlost * cos_uhlu
                dráha_y = 0 - vzdálenost_osy_miridel_od_hlavne
                dráha_x = 0
                Do Until dráha_x >= nástřelná_vzdálenost And chyba = False
                    proměnný_koeficient()
                    delta_rychlosti = (((0.5 * proměnný_koeficient_odporu * hustota_vzduchu * plocha * rychlost ^ 2) / hmotnost) + odporova_slozka_g) * pojistka_nástřelu_interval_času
                    poměr_rychlostí = delta_rychlosti / rychlost
                    rychlost_x = rychlost_x - (poměr_rychlostí * rychlost_x)
                    rychlost_y = rychlost_y - ((poměr_rychlostí * rychlost_y) + (g * pojistka_nástřelu_interval_času))
                    rychlost = ((rychlost_x ^ 2) + (rychlost_y ^ 2)) ^ 0.5

                    dráha_y = dráha_y + (rychlost_y * pojistka_nástřelu_interval_času)
                    dráha_x = dráha_x + (rychlost_x * pojistka_nástřelu_interval_času)
                Loop

                nástřelná_dráha_y = dráha_y
                'MsgBox(nástřelná_dráha_y & vbNewLine & poloha_zásahu_v_nástřelné_vzdálenosti)
            Loop
            úhel_nástřelu_předchozího_výpočtu = úhel_nástřelu
        Catch ex As Exception
            If chyba = False Then
                MsgBox("An error occurred during the calculation, please check that all data is entered correctly.", MsgBoxStyle.Critical)
            End If
            chyba = True
        End Try
    End Sub
    Private Sub nastavení_grafu()
        Chart1.ChartAreas.Add("ChartArea1")
        Chart1.Titles.Add("Bullet trajectory").Font = New System.Drawing.Font("Arial", 13.5, FontStyle.Bold)

        If checkbox_metricke_jednotky.Checked = True Then
            Chart1.ChartAreas("ChartArea1").AxisY.Title = "Height [cm]"
        Else
            Chart1.ChartAreas("ChartArea1").AxisY.Title = "Height [in]"
        End If
        Chart1.ChartAreas("ChartArea1").AxisY.TitleFont = New System.Drawing.Font("Arial", 12, FontStyle.Bold)

        If checkbox_metricke_jednotky.Checked = True Then
            Chart1.ChartAreas("ChartArea1").AxisX.Title = "Distance [m]"
        Else
            Chart1.ChartAreas("ChartArea1").AxisX.Title = "Distance [yd]"
        End If

        Chart1.ChartAreas("ChartArea1").AxisX.TitleFont = New System.Drawing.Font("Arial", 12, FontStyle.Bold)

        Chart1.ChartAreas("ChartArea1").AxisX.Minimum = 0

        Chart1.Series.Add("Trajektorie tělesa")
        Chart1.Series("Trajektorie tělesa").Color = Color.DarkGreen
        Chart1.Series("Trajektorie tělesa").IsVisibleInLegend = False
        Chart1.Series("Trajektorie tělesa").ChartType = DataVisualization.Charting.SeriesChartType.Line

        If checkbox_metricke_jednotky.Checked = True Then
            Chart1.Series("Trajektorie tělesa").Points.AddXY(0, (-vzdálenost_osy_miridel_od_hlavne) * 100)
        Else
            Chart1.Series("Trajektorie tělesa").Points.AddXY(0, ((-vzdálenost_osy_miridel_od_hlavne) * 100) / 2.54)
        End If

        Chart1.Series.Add("Osa mířidel")
        Chart1.Series("Osa mířidel").Color = Color.Red
        Chart1.Series("Osa mířidel").IsVisibleInLegend = False
        Chart1.Series("Osa mířidel").ChartType = DataVisualization.Charting.SeriesChartType.Line

        If checkbox_metricke_jednotky.Checked = True Then
            Chart1.Series("Osa mířidel").Points.AddXY(0, 0)
            Chart1.Series("Osa mířidel").Points.AddXY(vzdálenost_cíle, 0)
        Else
            Chart1.Series("Osa mířidel").Points.AddXY(0, 0)
            Chart1.Series("Osa mířidel").Points.AddXY(Round(Val(vzdálenost_cíle / 0.9144), 0), 0)
        End If

        Chart1.Series.Add("Trajektorie nástřelu")
        Chart1.Series("Trajektorie nástřelu").Color = Color.Blue
        Chart1.Series("Trajektorie nástřelu").IsVisibleInLegend = False
        Chart1.Series("Trajektorie nástřelu").ChartType = DataVisualization.Charting.SeriesChartType.Line

        If checkbox_metricke_jednotky.Checked = True Then
            Chart1.Series("Trajektorie nástřelu").Points.AddXY(0, (-vzdálenost_osy_miridel_od_hlavne) * 100)
        Else
            Chart1.Series("Trajektorie nástřelu").Points.AddXY(0, ((-vzdálenost_osy_miridel_od_hlavne) * 100) / 2.54)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.privitani_uzivatele = False Then
            Klíč.ShowDialog()
        End If

        If My.Settings.hustota_vzduchu = 0 Then
            My.Settings.hustota_vzduchu = 1.218
            My.Settings.teplota_vzduchu = "15 °C"
            My.Settings.nadmořská_výška = "400 m"
            My.Settings.nadmorska_vyska_decimal = 400
            My.Settings.teplota_vzduchu_decimal = 15
        End If

        My.Settings.tisk_povolen = False
        My.Settings.korekce_stranova_derivace_coriolis = 0
        My.Settings.korekce_vyskova_coriolis = 0

        nastaveni_checkboxů()
        vyvolani_pameti()
        textbox_uhel_sklonu.Text = "0"
        combobox_úhel_výstřelu.Text = "deg"
    End Sub
    Private Sub vynulovat()
        počáteční_rychlost = 0
        hmotnost = 0
        koeficient_odporu = 0
        plocha = 0
        vzdálenost_osy_miridel_od_hlavne = 0

        vzdálenost_cíle = 0

        nástřelná_vzdálenost = 0
        poloha_zásahu_v_nástřelné_vzdálenosti = 0

        hustota_vzduchu = 0

        úhel_výstřelu = 0
        úhel_nástřelu = 0

        Chart1.ChartAreas.Clear()
        Chart1.Series.Clear()
        Chart1.Titles.Clear()
        určení_úhlu = Nothing

        rychlost_bočního_větru = 0
        směr_bočního_větru = Nothing
    End Sub

    Private Sub nastaveni_checkboxů()
        Checkbox_jednotky_MOA.Enabled = False
        Checkbox_Jednotky_MRAD.Enabled = False
        Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Enabled = False
        Checkbox_14_MOA.Enabled = False
        Checkbox_18_MOA.Enabled = False
        checkbox_použít_úhel_nástřelu_z_předchozího_výpočtu.Checked = False
        checkbox_použít_úhel_nástřelu_z_předchozího_výpočtu.Enabled = False
    End Sub
    Private Sub Checkbox_Střelba_s_puškohledem_CheckedChanged(sender As Object, e As EventArgs) Handles Checkbox_Střelba_s_puškohledem.CheckedChanged
        If Checkbox_Střelba_s_puškohledem.Checked = True Then
            Checkbox_jednotky_MOA.Enabled = True
            Checkbox_Jednotky_MRAD.Enabled = True
        Else
            Checkbox_jednotky_MOA.Checked = False
            Checkbox_Jednotky_MRAD.Checked = False
            Checkbox_jednotky_MOA.Enabled = False
            Checkbox_Jednotky_MRAD.Enabled = False
        End If
    End Sub

    Private Sub Checkbox_Zbraň_je_nastřelená_CheckedChanged(sender As Object, e As EventArgs) Handles Checkbox_Zbraň_je_nastřelená.CheckedChanged
        If Checkbox_Zbraň_je_nastřelená.Checked = True Then
            Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Enabled = True
            checkbox_použít_úhel_nástřelu_z_předchozího_výpočtu.Enabled = True
            GroupBox4.Enabled = True
        Else
            GroupBox4.Enabled = False
            Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Enabled = False
            Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Checked = False
            checkbox_použít_úhel_nástřelu_z_předchozího_výpočtu.Checked = False
            checkbox_použít_úhel_nástřelu_z_předchozího_výpočtu.Enabled = False
        End If
    End Sub

    Private Sub Checkbox_jednotky_MOA_CheckedChanged(sender As Object, e As EventArgs) Handles Checkbox_jednotky_MOA.CheckedChanged
        If Checkbox_jednotky_MOA.Checked = True Then
            Checkbox_Jednotky_MRAD.Enabled = False
            Checkbox_14_MOA.Enabled = True
            Checkbox_18_MOA.Enabled = True
        Else
            Checkbox_Jednotky_MRAD.Enabled = True
            Checkbox_18_MOA.Checked = False
            Checkbox_14_MOA.Checked = False
            Checkbox_14_MOA.Enabled = False
            Checkbox_18_MOA.Enabled = False
        End If
    End Sub

    Private Sub Checkbox_Jednotky_MRAD_CheckedChanged(sender As Object, e As EventArgs) Handles Checkbox_Jednotky_MRAD.CheckedChanged
        If Checkbox_Jednotky_MRAD.Checked = True Then
            Checkbox_jednotky_MOA.Enabled = False
        Else
            Checkbox_jednotky_MOA.Enabled = True
        End If
    End Sub
    Private Sub Checkbox_14_MOA_CheckedChanged(sender As Object, e As EventArgs) Handles Checkbox_14_MOA.CheckedChanged
        If Checkbox_14_MOA.Checked = True Then
            Checkbox_18_MOA.Enabled = False
        Else
            Checkbox_18_MOA.Enabled = True
        End If
    End Sub

    Private Sub Checkbox_18_MOA_CheckedChanged(sender As Object, e As EventArgs) Handles Checkbox_18_MOA.CheckedChanged
        If Checkbox_18_MOA.Checked = True Then
            Checkbox_14_MOA.Enabled = False
        Else
            Checkbox_14_MOA.Enabled = True
        End If
    End Sub

    Private Sub Checkbox_Spočítat_pouze_nástřelnou_trajektorii_CheckedChanged(sender As Object, e As EventArgs) Handles Checkbox_Spočítat_pouze_nástřelnou_trajektorii.CheckedChanged
        If Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Checked = True Then
            label_korekce_přenášenim.Text = "Sights compensation: -"
            label_korekce_klikáním.Text = "Scope compensation: -"
            label_korekce_větru_klikáním.Text = "Scope compensation: -"
            label_korekce_větru_přenášením.Text = "Sights compensation: -"
            Checkbox_Střelba_s_puškohledem.Checked = False
            Checkbox_Střelba_s_puškohledem.Enabled = False

        Else
            label_korekce_přenášenim.Text = "Sights compensation: "
            label_korekce_klikáním.Text = "Scope compensation: "
            label_korekce_větru_klikáním.Text = "Scope compensation: "
            label_korekce_větru_přenášením.Text = "Sights compensation: "
            Checkbox_Střelba_s_puškohledem.Enabled = True
        End If
    End Sub

    Private Sub VlastnostiAtmosféryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VlastnostiAtmosféryToolStripMenuItem.Click
        Vlastnosti_Atmosféry.Show()
        Me.Enabled = False
    End Sub

    Private Sub VýpočetKoeficientuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VýpočetKoeficientuToolStripMenuItem.Click
        Vypocet_koeficientu.Show()
        Me.Enabled = False
    End Sub

    Private Sub NápovědaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NápovědaToolStripMenuItem.Click
        Nápověda.Show()
        Me.Enabled = False
    End Sub

    Private Sub OProgramuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OProgramuToolStripMenuItem.Click
        O_programu.Show()
        Me.Enabled = False
    End Sub

    Private Sub SeznamStřelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeznamStřelToolStripMenuItem.Click
        Seznam_střel.Show()
        Me.Enabled = False
    End Sub

    Private Sub Textbox_hmotnost_KeyDown(sender As Object, e As KeyEventArgs) Handles Textbox_hmotnost.KeyDown
        label_načtená_střela.Text = "Bullet: "
    End Sub

    Private Sub Textbox_Koeficient_odporu_KeyDown(sender As Object, e As KeyEventArgs) Handles Textbox_Koeficient_odporu.KeyDown
        label_načtená_střela.Text = "Bullet: "
    End Sub

    Private Sub combobox_hmotnost_střely_MouseClick(sender As Object, e As MouseEventArgs) Handles combobox_hmotnost_střely.MouseClick
        label_načtená_střela.Text = "Bullet: "
    End Sub

    Private Sub Combobox_výběr_koeficientů_MouseClick(sender As Object, e As MouseEventArgs) Handles Combobox_výběr_koeficientů.MouseClick
        label_načtená_střela.Text = "Bullet: "
    End Sub

    Private Sub checkbox_použít_úhel_nástřelu_z_předchozího_výpočtu_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_použít_úhel_nástřelu_z_předchozího_výpočtu.CheckedChanged
        If checkbox_použít_úhel_nástřelu_z_předchozího_výpočtu.Checked = True Then
            If úhel_nástřelu_předchozího_výpočtu = 0 Then
                MsgBox("In the previous calculation, the firing trajectory was not calculated.", MsgBoxStyle.Exclamation)
                checkbox_použít_úhel_nástřelu_z_předchozího_výpočtu.Checked = False
            Else
                GroupBox4.Enabled = False
            End If
        Else
            GroupBox4.Enabled = True
        End If
    End Sub

    Private Sub PřevodyJednotekToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PřevodyJednotekToolStripMenuItem.Click
        Převody_jednotek.Show()
        Me.Enabled = False
    End Sub

    Private Sub ExportTabulkyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportTabulkyToolStripMenuItem.Click

        If checkbox_použít_úhel_nástřelu_z_předchozího_výpočtu.Checked = False Then
            string_tisk_povolen = "kontrola_parametru"
            tisk_povolen()
        Else
            My.Settings.tisk_povolen = False
        End If

        If My.Settings.tisk_povolen = True Then
            Export_tabulky.Show()
            Me.Enabled = False
        Else
            MsgBox("It is necessary to calculate the ballistic trajectory before creating the table." & vbNewLine & "Tip: After successful calculation, you must not change the already entered parameters." & vbNewLine & "Tip: You cannot use the function: Use sights settings from the previous calculation before creating the table.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub UložitPředvobyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UložitPředvobyToolStripMenuItem.Click
        string_tisk_povolen = "kontrola_parametru"
        tisk_povolen()
        Me.Enabled = False
        Predvolby.Show()

    End Sub

    Private Sub DerivaceStřelyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DerivaceStřelyToolStripMenuItem.Click
        string_tisk_povolen = "kontrola_parametru"
        tisk_povolen()
        Me.Enabled = False
        Derivace_střely.Show()

    End Sub

    Private Sub checkbox_imperialni_jednotky_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_imperialni_jednotky.CheckedChanged
        If checkbox_metricke_jednotky.Checked = False Then
            checkbox_imperialni_jednotky.Checked = True
        Else
            checkbox_metricke_jednotky.Checked = False
        End If
    End Sub

    Private Sub checkbox_metricke_jednotky_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_metricke_jednotky.CheckedChanged
        If checkbox_imperialni_jednotky.Checked = False Then
            checkbox_metricke_jednotky.Checked = True
        Else
            checkbox_imperialni_jednotky.Checked = False
        End If
    End Sub

    Private Sub tisk_povolen()

        If string_tisk_povolen = "tlacitko_spocitej" Then
            tisk_povolen_ustova_rychlost = Textbox_Počáteční_rychlost.Text
            tisk_povolen_combobox_ustova_rychlost = combobox_počáteční_rychlost.Text
            tisk_povolen_hmotnost = Textbox_hmotnost.Text
            tisk_povolen_combobox_hmotnost = combobox_hmotnost_střely.Text
            tisk_povolen_balisticky_koeficient = Textbox_Koeficient_odporu.Text
            tisk_povolen_combobox_balisticky_koeficient = Combobox_výběr_koeficientů.Text
            tisk_povolen_vzdalenost_cile = Textbox_Vzdálenost_cíle.Text
            tisk_povolen_combobox_vzdalenost_cile = combobox_vzdálenost_cíle.Text
            tisk_povolen_vyska_miridel = Textbox_Vzdálenost_mířidel.Text
            tisk_povolen_combobox_vyska_miridel = combobox_vzdálenost_mířidel.Text
            tisk_povolen_uhel_sklonu = textbox_uhel_sklonu.Text
            tisk_povolen_nastrelna_vzdalenost = Textbox_Nástřelná_vzdálenost.Text
            tisk_povolen_combobox_nastrelna_vzdalenost = combobox_nástřelná_vzdálenost.Text
            tisk_povolen_poloha_zasahu = Textbox_Poloha_zásahu_v_nástřelu.Text
            tisk_povolen_combobox_poloha_zasahu = combobox_poloha_zásahu.Text

            My.Settings.tisk_povolen = False

        ElseIf string_tisk_povolen = "kontrola_parametru" Then
            Dim chyba_export As Boolean = False

            If tisk_povolen_ustova_rychlost <> Textbox_Počáteční_rychlost.Text Then
                chyba_export = True
            ElseIf tisk_povolen_combobox_ustova_rychlost <> combobox_počáteční_rychlost.Text Then
                chyba_export = True
            ElseIf tisk_povolen_hmotnost <> Textbox_hmotnost.Text Then
                chyba_export = True
            ElseIf tisk_povolen_combobox_hmotnost <> combobox_hmotnost_střely.Text Then
                chyba_export = True
            ElseIf tisk_povolen_balisticky_koeficient <> Textbox_Koeficient_odporu.Text Then
                chyba_export = True
            ElseIf tisk_povolen_combobox_balisticky_koeficient <> Combobox_výběr_koeficientů.Text Then
                chyba_export = True
            ElseIf tisk_povolen_vzdalenost_cile <> Textbox_Vzdálenost_cíle.Text Then
                chyba_export = True
            ElseIf tisk_povolen_combobox_vzdalenost_cile <> combobox_vzdálenost_cíle.Text Then
                chyba_export = True
            ElseIf tisk_povolen_vyska_miridel <> Textbox_Vzdálenost_mířidel.Text Then
                chyba_export = True
            ElseIf tisk_povolen_combobox_vyska_miridel <> combobox_vzdálenost_mířidel.Text Then
                chyba_export = True
            ElseIf tisk_povolen_uhel_sklonu <> textbox_uhel_sklonu.Text Then
                chyba_export = True
            ElseIf tisk_povolen_nastrelna_vzdalenost <> Textbox_Nástřelná_vzdálenost.Text Then
                chyba_export = True
            ElseIf tisk_povolen_combobox_nastrelna_vzdalenost <> combobox_nástřelná_vzdálenost.Text Then
                chyba_export = True
            ElseIf tisk_povolen_poloha_zasahu <> Textbox_Poloha_zásahu_v_nástřelu.Text Then
                chyba_export = True
            ElseIf tisk_povolen_combobox_poloha_zasahu <> combobox_poloha_zásahu.Text Then
                chyba_export = True
            End If

            If chyba_export = True Then
                My.Settings.tisk_povolen = False
            Else
                My.Settings.tisk_povolen = True
            End If
        End If
    End Sub

    Private Sub vyvolani_pameti()

        If My.Settings.pamet_hlavni_okno_combobox_ustova_rychlost <> Nothing Then

            combobox_počáteční_rychlost.Text = My.Settings.pamet_hlavni_okno_combobox_ustova_rychlost
            combobox_hmotnost_střely.Text = My.Settings.pamet_hlavni_okno_combobox_hmotnost_strely
            Combobox_výběr_koeficientů.Text = My.Settings.pamet_hlavni_okno_combobox_vyber_koeficientu
            combobox_vzdálenost_cíle.Text = My.Settings.pamet_hlavni_okno_combobox_vzdalenost_cile
            combobox_vzdálenost_mířidel.Text = My.Settings.pamet_hlavni_okno_combobox_vzdalenost_miridel
            combobox_nástřelná_vzdálenost.Text = My.Settings.pamet_hlavni_okno_combobox_nastrelna_vzdalenost
            combobox_poloha_zásahu.Text = My.Settings.pamet_hlavni_okno_combobox_poloha_zasahu

            checkbox_metricke_jednotky.Checked = My.Settings.pamet_hlavni_okno_checkbox_metricke_jednotky
            checkbox_imperialni_jednotky.Checked = My.Settings.pamet_hlavni_okno_checkbox_imperialni_jednotky
            Checkbox_Zbraň_je_nastřelená.Checked = My.Settings.pamet_hlavni_okno_checkbox_zbran_je_nastrelena
            Checkbox_Střelba_s_puškohledem.Checked = My.Settings.pamet_hlavni_okno_checkbox_strelba_z_puskohledem
            Checkbox_jednotky_MOA.Checked = My.Settings.pamet_hlavni_okno_checkbox_jednotky_moa
            Checkbox_14_MOA.Checked = My.Settings.pamet_hlavni_okno_checkbox_jednotky_moa_14
            Checkbox_18_MOA.Checked = My.Settings.pamet_hlavni_okno_checkbox_jednotky_moa_18
            Checkbox_Jednotky_MRAD.Checked = My.Settings.pamet_hlavni_okno_checkbox_jednotky_mrad

        Else

            combobox_počáteční_rychlost.Text = "m/s"
            combobox_hmotnost_střely.Text = "grs"
            Combobox_výběr_koeficientů.Text = "G1"
            combobox_vzdálenost_cíle.Text = "m"
            combobox_vzdálenost_mířidel.Text = "mm"
            combobox_nástřelná_vzdálenost.Text = "m"
            combobox_poloha_zásahu.Text = "cm"

            checkbox_metricke_jednotky.Checked = True
            Checkbox_Zbraň_je_nastřelená.Checked = True
            Checkbox_Střelba_s_puškohledem.Checked = False
        End If

    End Sub

    Private Sub ulozeni_pameti()

        My.Settings.pamet_hlavni_okno_combobox_ustova_rychlost = combobox_počáteční_rychlost.Text
        My.Settings.pamet_hlavni_okno_combobox_hmotnost_strely = combobox_hmotnost_střely.Text
        My.Settings.pamet_hlavni_okno_combobox_vyber_koeficientu = Combobox_výběr_koeficientů.Text
        My.Settings.pamet_hlavni_okno_combobox_vzdalenost_cile = combobox_vzdálenost_cíle.Text
        My.Settings.pamet_hlavni_okno_combobox_vzdalenost_miridel = combobox_vzdálenost_mířidel.Text
        My.Settings.pamet_hlavni_okno_combobox_nastrelna_vzdalenost = combobox_nástřelná_vzdálenost.Text
        My.Settings.pamet_hlavni_okno_combobox_poloha_zasahu = combobox_poloha_zásahu.Text

        My.Settings.pamet_hlavni_okno_checkbox_metricke_jednotky = checkbox_metricke_jednotky.Checked
        My.Settings.pamet_hlavni_okno_checkbox_imperialni_jednotky = checkbox_imperialni_jednotky.Checked
        My.Settings.pamet_hlavni_okno_checkbox_zbran_je_nastrelena = Checkbox_Zbraň_je_nastřelená.Checked
        My.Settings.pamet_hlavni_okno_checkbox_strelba_z_puskohledem = Checkbox_Střelba_s_puškohledem.Checked
        My.Settings.pamet_hlavni_okno_checkbox_jednotky_moa = Checkbox_jednotky_MOA.Checked
        My.Settings.pamet_hlavni_okno_checkbox_jednotky_moa_14 = Checkbox_14_MOA.Checked
        My.Settings.pamet_hlavni_okno_checkbox_jednotky_moa_18 = Checkbox_18_MOA.Checked
        My.Settings.pamet_hlavni_okno_checkbox_jednotky_mrad = Checkbox_Jednotky_MRAD.Checked

        My.Settings.Save()

    End Sub

    Private Sub VýpočetDostřeluToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VýpočetDostřeluToolStripMenuItem.Click
        Vypocet_dostrelu.Show()
        Me.Enabled = False
    End Sub

    Private Sub Hlavní_okno_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ulozeni_pameti()
    End Sub
End Class
