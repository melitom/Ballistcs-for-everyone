Imports System.Math
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class Export_tabulky
    Dim rychlost As Double = 0
    Dim počáteční_rychlost As Decimal = 0
    Dim úhel_výstřelu As Double = 0
    Dim vzdálenost_cíle As Double = 0
    Dim koeficient_odporu As Double = 0
    Dim proměnný_koeficient_odporu As Decimal = 0
    Dim hustota_vzduchu As Decimal = 0
    Dim hmotnost As Decimal = 0
    Dim průměr_střely As Decimal = 10
    Dim plocha As Double = 0
    Dim vzdálenost_osy_miridel_od_hlavne As Decimal = 0

    Dim doba_pohybu As Decimal = 0

    Dim g As Decimal = 9.823
    Dim odporova_slozka_g As Decimal = 0
    Dim uhel_sklonu As Decimal = 0

    Dim pojistka_výstřelu_interval_času As Decimal = 0
    Dim pojistka_výstřelu_zaokrouhleni As Integer = 0
    Dim pojistka_výstřelu_interval_úhlu As Decimal = 0

    Dim prvni_vzdalenost As Decimal = 0
    Dim druha_vzdalenost As Decimal = 0
    Dim interval_vzdalenosti As Decimal = 0

    Dim vzdalenost_cile_pro_zapis_tabulky As Decimal = 0
    Dim rychlost_pro_zapis_tabulky As Decimal = 0

    Dim chyba As Boolean = False

    Dim rychlost_vetru_celni_zadni As Decimal = 0

    Private Sub Export_tabulky_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        combobox_prvni_vzdalenost.Enabled = False
        combobox_prvni_vzdalenost.Text = combobox_interval_vzdalenosti.Text
        DataGridView1.ReadOnly = True
        DataGridView1.Enabled = True
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.DefaultCellStyle.SelectionBackColor = DataGridView1.DefaultCellStyle.BackColor
        DataGridView1.DefaultCellStyle.SelectionForeColor = DataGridView1.DefaultCellStyle.ForeColor
        nastaveni_tabulky()
        vyvolani_pameti()
        nastavnei_labelu()
        button_exportivat_do_pdf.Enabled = False

    End Sub
    Private Sub zápis_proměnných()
        If My.Settings.hustota_vzduchu = 0 Then
            hustota_vzduchu = 1.218
        Else
            hustota_vzduchu = My.Settings.hustota_vzduchu
        End If

        If My.Settings.rychlost_vetru_celni_zadni_pro_vypocet <> 0 Then
            rychlost_vetru_celni_zadni = My.Settings.rychlost_vetru_celni_zadni_pro_vypocet
        Else
            rychlost_vetru_celni_zadni = 0
        End If

        If Hlavní_okno.combobox_počáteční_rychlost.Text = "m/s" Then
            počáteční_rychlost = Hlavní_okno.Textbox_Počáteční_rychlost.Text
        ElseIf Hlavní_okno.combobox_počáteční_rychlost.Text = "fps" Then
            počáteční_rychlost = Hlavní_okno.Textbox_Počáteční_rychlost.Text * 0.3048
        End If

        plocha = ((průměr_střely ^ 2 * PI) / 4) / 1000000

        If Hlavní_okno.combobox_hmotnost_střely.Text = "g" Then
            hmotnost = Hlavní_okno.Textbox_hmotnost.Text / 1000
        ElseIf Hlavní_okno.combobox_hmotnost_střely.Text = "grs" Then
            hmotnost = (Hlavní_okno.Textbox_hmotnost.Text * 0.06479891) / 1000
        End If

        If Hlavní_okno.Combobox_výběr_koeficientů.Text = "G1" Then
            koeficient_odporu = 0.3 * (((hmotnost * 2.204627) / ((průměr_střely * 0.039370787) ^ 2)) / Hlavní_okno.Textbox_Koeficient_odporu.Text)
        ElseIf Hlavní_okno.Combobox_výběr_koeficientů.Text = "G7" Then
            koeficient_odporu = 0.12 * (((hmotnost * 2.204627) / ((průměr_střely * 0.039370787) ^ 2)) / Hlavní_okno.Textbox_Koeficient_odporu.Text)
        End If

        textbox_prvni_vzdalenost.Text = textbox_prvni_vzdalenost.Text.Replace(".", ",")
        textbox_prvni_vzdalenost.Text = Round(Val(textbox_prvni_vzdalenost.Text), 0)

        vzdalenost_cile_pro_zapis_tabulky = textbox_prvni_vzdalenost.Text

        If Hlavní_okno.combobox_vzdálenost_mířidel.Text = "mm" Then
            vzdálenost_osy_miridel_od_hlavne = Hlavní_okno.Textbox_Vzdálenost_mířidel.Text / 1000
        Else
            vzdálenost_osy_miridel_od_hlavne = Hlavní_okno.Textbox_Vzdálenost_mířidel.Text * 0.0254
        End If


        uhel_sklonu = Hlavní_okno.textbox_uhel_sklonu.Text

        g = 9.823 * Cos(uhel_sklonu * (PI / 180))
        odporova_slozka_g = 9.823 * Sin(uhel_sklonu * (PI / 180))

    End Sub

    Private Sub nastaveni_tabulky()
        DataGridView1.Font = New Drawing.Font("Arial", 10, FontStyle.Bold)

        Dim vzdalenost As New DataGridViewTextBoxColumn
        vzdalenost.DataPropertyName = "Sloupec_vzdalenost"
        vzdalenost.HeaderText = "Distance" & " [" & combobox_interval_vzdalenosti.Text & "]"
        vzdalenost.Name = "Vzdalenost"
        vzdalenost.Width = 130
        vzdalenost.SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView1.Columns.Add(vzdalenost)

        Dim elevace As New DataGridViewTextBoxColumn
        elevace.DataPropertyName = "uhel"
        If Hlavní_okno.Checkbox_Jednotky_MRAD.Checked = True Then
            elevace.HeaderText = "Elevation [MRAD]"
        ElseIf Hlavní_okno.Checkbox_jednotky_MOA.Checked = True Then
            elevace.HeaderText = "Elevation [MOA]"
        Else
            If Hlavní_okno.checkbox_metricke_jednotky.Checked = True Then
                elevace.HeaderText = "Elevation [cm]"
            Else
                elevace.HeaderText = "Elevation [in]"
            End If

        End If
        elevace.Name = "elevace"
        elevace.Width = 130
        elevace.SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView1.Columns.Add(elevace)

        Dim vitr As New DataGridViewTextBoxColumn
        vitr.DataPropertyName = "vitr"
        If Hlavní_okno.Checkbox_Jednotky_MRAD.Checked = True Then
            vitr.HeaderText = "Wind [MRAD]"
        ElseIf Hlavní_okno.Checkbox_jednotky_MOA.Checked = True Then
            vitr.HeaderText = "Wind [MOA]"
        Else
            If Hlavní_okno.checkbox_metricke_jednotky.Checked = True Then
                vitr.HeaderText = "Wind [cm]"
            Else
                vitr.HeaderText = "Wind [in]"
            End If
        End If
        vitr.Name = "vitr"
        vitr.Width = 130
        vitr.SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView1.Columns.Add(vitr)

        Dim rychlost_strely As New DataGridViewTextBoxColumn
        rychlost_strely.DataPropertyName = "rychlost_strely"
        If Hlavní_okno.checkbox_metricke_jednotky.Checked = True Then
            rychlost_strely.HeaderText = "Velocity" & " [m/s]"
        Else
            rychlost_strely.HeaderText = "Velocity" & " [fps]"
        End If
        rychlost_strely.Name = "rychlost_strely"
        rychlost_strely.Width = 130
        rychlost_strely.SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView1.Columns.Add(rychlost_strely)

        Dim doba_pohybu As New DataGridViewTextBoxColumn
        doba_pohybu.DataPropertyName = "doba_pohybu"
        doba_pohybu.HeaderText = "Time of flight [sec]"
        doba_pohybu.Name = "doba_pohybu"
        doba_pohybu.Width = 130
        doba_pohybu.SortMode = DataGridViewColumnSortMode.NotSortable
        DataGridView1.Columns.Add(doba_pohybu)
    End Sub
    Private Sub nastavnei_labelu()

        label_pocatecni_rychlost.Text = "Muzzle velocity: " & Hlavní_okno.Textbox_Počáteční_rychlost.Text & " " & Hlavní_okno.combobox_počáteční_rychlost.Text
        label_hmotnost_strely.Text = "Bullet weight: " & Hlavní_okno.Textbox_hmotnost.Text & " " & Hlavní_okno.combobox_hmotnost_střely.Text
        label_balisticky_koeficient.Text = "Ballistic coefficient: " & Hlavní_okno.Textbox_Koeficient_odporu.Text & " " & Hlavní_okno.Combobox_výběr_koeficientů.Text

        If Hlavní_okno.Checkbox_Zbraň_je_nastřelená.Checked = True Then
            label_nastrelna_vzdalenost.Text = "Sighting distance: " & Hlavní_okno.Textbox_Nástřelná_vzdálenost.Text & " " & Hlavní_okno.combobox_nástřelná_vzdálenost.Text
            label_poloha_zasahu_v_nastrelne_vzdalenosti.Text = "Point of impact at sighting distance: " & Hlavní_okno.Textbox_Poloha_zásahu_v_nástřelu.Text & " " & Hlavní_okno.combobox_poloha_zásahu.Text
        Else
            label_nastrelna_vzdalenost.Text = "Sighting distance: - "
            label_poloha_zasahu_v_nastrelne_vzdalenosti.Text = "Point of impact at sighting distance: - "
        End If

        label_vzdalenost_osy_miridel_od_hlavne.Text = "Sights height: " & Hlavní_okno.Textbox_Vzdálenost_mířidel.Text & " " & Hlavní_okno.combobox_vzdálenost_mířidel.Text

        If My.Settings.rychlost_a_smer_vetru_pro_export <> Nothing Then
            label_rychlost_vetru.Text = "Wind speed: " & My.Settings.rychlost_a_smer_vetru_pro_export
        Else
            label_rychlost_vetru.Text = "Wind speed: - "
        End If

        label_teplota_vzduchu.Text = "Air temperature: " & My.Settings.teplota_vzduchu
        label_nadmorska_vyska.Text = "Height above sea: " & My.Settings.nadmořská_výška

        If Hlavní_okno.Checkbox_Jednotky_MRAD.Checked = True Then
            label_uhlove_jednotky.Text = "Angle units: MRAD (1/10 MRAD)"
        ElseIf Hlavní_okno.Checkbox_jednotky_MOA.Checked = True Then
            If Hlavní_okno.Checkbox_14_MOA.Checked = True Then
                label_uhlove_jednotky.Text = "Angle units: MOA (1/4 MOA)"
            ElseIf Hlavní_okno.Checkbox_18_MOA.Checked = True Then
                label_uhlove_jednotky.Text = "Angle units: MOA (1/8 MOA)"
            Else
                label_uhlove_jednotky.Text = "Angle units: MOA"
            End If
        Else
            label_uhlove_jednotky.Text = "Angle units: Sights correction"
        End If

        If My.Settings.smer_vetru_pro_export = 45 Then
            label_smer_vetru_od_osy_pohybu.Text = "Direction of the wind: 45 degrees"
        ElseIf My.Settings.smer_vetru_pro_export = 90 Then
            label_smer_vetru_od_osy_pohybu.Text = "Direction of the wind: 90 degrees"
        ElseIf My.Settings.smer_vetru_pro_export = 180 Then
            label_smer_vetru_od_osy_pohybu.Text = "Direction of the wind: 180 degrees"
        Else
            label_smer_vetru_od_osy_pohybu.Text = "Direction of the wind: 0 degrees"
        End If

        label_uhel_sklonu.Text = "Angle of shot: " & Hlavní_okno.textbox_uhel_sklonu.Text & " degrees"

        label_nactena_strela.Text = Hlavní_okno.label_načtená_střela.Text

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

            Do Until 0 = Round(Val(nástřelná_dráha_y), pojistka_výstřelu_zaokrouhleni)
                čas_t = 0
                úhel_výstřelu = úhel_výstřelu + pojistka_výstřelu_interval_úhlu
                sin_uhlu = Sin(úhel_výstřelu / (180 / PI))
                cos_uhlu = Cos(úhel_výstřelu / (180 / PI))
                rychlost = počáteční_rychlost
                rychlost_y = rychlost * sin_uhlu
                rychlost_x = rychlost * cos_uhlu
                dráha_y = 0 - vzdálenost_osy_miridel_od_hlavne
                dráha_x = 0
                Do Until dráha_x >= vzdálenost_cíle
                    čas_t = čas_t + pojistka_výstřelu_interval_času
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
            doba_pohybu = čas_t
        Catch ex As Exception
            MsgBox("An error occurred during the calculation, please check that all data is entered correctly.", MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub Button_Zavřít_Click(sender As Object, e As EventArgs) Handles Button_Zavřít.Click
        Hlavní_okno.Enabled = True
        Close()
    End Sub

    Private Sub proměnný_koeficient()
        If Hlavní_okno.Combobox_výběr_koeficientů.Text = "G1" Then
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
        ElseIf Hlavní_okno.Combobox_výběr_koeficientů.Text = "G7" Then
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
        If vzdálenost_cíle <= 30 Then
            pojistka_výstřelu_interval_času = 0.0005
            pojistka_výstřelu_interval_úhlu = 0.0002
            pojistka_výstřelu_zaokrouhleni = 3
        ElseIf vzdálenost_cíle > 30 And vzdálenost_cíle <= 50 Then
            pojistka_výstřelu_interval_času = 0.001
            pojistka_výstřelu_interval_úhlu = 0.0003
            pojistka_výstřelu_zaokrouhleni = 3
        ElseIf vzdálenost_cíle > 50 And vzdálenost_cíle <= 100 Then
            pojistka_výstřelu_interval_času = 0.0015
            pojistka_výstřelu_interval_úhlu = 0.0005
            pojistka_výstřelu_zaokrouhleni = 2
        ElseIf vzdálenost_cíle > 100 And vzdálenost_cíle <= 400 Then
            pojistka_výstřelu_interval_času = 0.002
            pojistka_výstřelu_interval_úhlu = 0.0006
            pojistka_výstřelu_zaokrouhleni = 2
        ElseIf vzdálenost_cíle > 400 And vzdálenost_cíle <= 1000 Then
            pojistka_výstřelu_interval_času = 0.0035
            pojistka_výstřelu_interval_úhlu = 0.001
            pojistka_výstřelu_zaokrouhleni = 1
        ElseIf vzdálenost_cíle > 1000 And vzdálenost_cíle <= 2000 Then
            pojistka_výstřelu_interval_času = 0.005
            pojistka_výstřelu_interval_úhlu = 0.001
            pojistka_výstřelu_zaokrouhleni = 1
        ElseIf vzdálenost_cíle > 2000 Then
            pojistka_výstřelu_interval_času = 0.008
            pojistka_výstřelu_interval_úhlu = 0.001
            pojistka_výstřelu_zaokrouhleni = 0
        End If
    End Sub

    Private Sub button_vytvořit_tabulku_Click(sender As Object, e As EventArgs) Handles button_vytvořit_tabulku.Click

        chyba = False
        vynulovat()

        DataGridView1.Rows.Clear()
        button_exportivat_do_pdf.Enabled = False
        button_vytvořit_tabulku.Text = "Calculation in progress"
        button_vytvořit_tabulku.Enabled = False
        Try
            textbox_prvni_vzdalenost.Text = textbox_prvni_vzdalenost.Text.Replace(".", ",")

            If combobox_prvni_vzdalenost.Text = "m" Then
                prvni_vzdalenost = textbox_prvni_vzdalenost.Text
            ElseIf combobox_prvni_vzdalenost.Text = "ft" Then
                prvni_vzdalenost = textbox_prvni_vzdalenost.Text * 0.3048
            Else
                prvni_vzdalenost = textbox_prvni_vzdalenost.Text * 0.9144
            End If

            If Hlavní_okno.combobox_vzdálenost_cíle.Text = "m" Then
                druha_vzdalenost = Hlavní_okno.Textbox_Vzdálenost_cíle.Text
            ElseIf Hlavní_okno.combobox_vzdálenost_cíle.Text = "ft" Then
                druha_vzdalenost = Hlavní_okno.Textbox_Vzdálenost_cíle.Text * 0.3048
            Else
                druha_vzdalenost = Hlavní_okno.Textbox_Vzdálenost_cíle.Text * 0.9144
            End If

            If combobox_interval_vzdalenosti.Text = "m" Then
                interval_vzdalenosti = DomainUpDown1.Text
            ElseIf combobox_interval_vzdalenosti.Text = "ft" Then
                interval_vzdalenosti = DomainUpDown1.Text * 0.3048
            Else
                interval_vzdalenosti = DomainUpDown1.Text * 0.9144
            End If

            If prvni_vzdalenost >= druha_vzdalenost Then
                chyba = True
            ElseIf interval_vzdalenosti >= (druha_vzdalenost - prvni_vzdalenost) Then
                chyba = True
            ElseIf (druha_vzdalenost - prvni_vzdalenost) / interval_vzdalenosti > 50 Then
                chyba = True
            End If

        Catch ex As Exception
            chyba = True
        End Try

        If chyba = False Then
            zápis_proměnných()

            Dim dráha_střely_ve_větru As Double = 0
            Dim korekce_větru As Double = 0
            Dim korekce_elevace As Decimal = 0
            Dim pocet_kliků_elevace As Integer = 0
            Dim pocet_kliků_vítr As Integer = 0

            If vzdálenost_cíle = 0 Then
                vzdálenost_cíle = prvni_vzdalenost + interval_vzdalenosti
            Else
                vzdálenost_cíle = prvni_vzdalenost
            End If


            Do Until Round(Val(vzdálenost_cíle), 0) >= Round(Val(druha_vzdalenost + interval_vzdalenosti), 0)

                pojistka_výpočtů()
                výpočet_úhlu_pro_vzdálenost_cíle()
                vzdálenost_cíle = vzdálenost_cíle + interval_vzdalenosti
                vzdalenost_cile_pro_zapis_tabulky = vzdalenost_cile_pro_zapis_tabulky + DomainUpDown1.Text


                If label_rychlost_vetru.Text <> "Wind speed: - " Then
                    If My.Settings.rychlost_bočního_větru < 0 Then
                        dráha_střely_ve_větru = My.Settings.rychlost_bočního_větru * (doba_pohybu - (vzdálenost_cíle / počáteční_rychlost)) * (-1)
                    Else
                        dráha_střely_ve_větru = My.Settings.rychlost_bočního_větru * (doba_pohybu - (vzdálenost_cíle / počáteční_rychlost))
                    End If

                    korekce_větru = Atan(dráha_střely_ve_větru / vzdálenost_cíle) * (180 / PI)


                    If label_uhlove_jednotky.Text = "Angle units: MOA (1/4 MOA)" Or label_uhlove_jednotky.Text = "Angle units: MOA (1/8 MOA)" Then
                        korekce_větru = Round(Val((korekce_větru) * 60), 1)
                        If label_uhlove_jednotky.Text = "Angle units: MOA (1/4 MOA)" Then
                            pocet_kliků_vítr = korekce_větru * 4
                        ElseIf label_uhlove_jednotky.Text = "Angle units: MOA (1/8 MOA)" Then
                            pocet_kliků_vítr = korekce_větru * 8
                        Else
                            pocet_kliků_vítr = 0
                        End If
                    ElseIf label_uhlove_jednotky.Text = "Angle units: MRAD (1/10 MRAD)" Then
                        korekce_větru = Round(Val(((korekce_větru / (180 / PI))) * 1000), 1)
                        pocet_kliků_vítr = korekce_větru * 10
                    Else
                        If Hlavní_okno.checkbox_metricke_jednotky.Checked = True Then
                            korekce_větru = Round(Val(dráha_střely_ve_větru) * 100, 0)
                        Else
                            korekce_větru = Round(Val(dráha_střely_ve_větru) * 39.37, 0)
                        End If
                    End If

                Else
                    korekce_větru = Nothing
                End If

                If label_uhlove_jednotky.Text = "Angle units: MOA (1/4 MOA)" Or label_uhlove_jednotky.Text = "Angle units: MOA (1/8 MOA)" Then
                    korekce_elevace = Round(Val((úhel_výstřelu - My.Settings.uhel_nastrelu) * 60), 1)
                    If label_uhlove_jednotky.Text = "Angle units: MOA (1/4 MOA)" Then
                        pocet_kliků_elevace = korekce_elevace * 4
                    ElseIf label_uhlove_jednotky.Text = "Angle units: MOA (1/8 MOA)" Then
                        pocet_kliků_elevace = korekce_elevace * 8
                    Else
                        pocet_kliků_elevace = 0
                    End If
                ElseIf label_uhlove_jednotky.Text = "Angle units: MRAD (1/10 MRAD)" Then
                    korekce_elevace = Round(Val(((úhel_výstřelu - My.Settings.uhel_nastrelu) / (180 / PI)) * 1000), 1)
                    pocet_kliků_elevace = korekce_elevace * 10
                Else
                    If Hlavní_okno.checkbox_metricke_jednotky.Checked = True Then
                        korekce_elevace = Round(Val(Tan((úhel_výstřelu - My.Settings.uhel_nastrelu) / (180 / PI)) * vzdálenost_cíle) * 100, 0)
                    Else
                        korekce_elevace = Round(Val(Tan((úhel_výstřelu - My.Settings.uhel_nastrelu) / (180 / PI)) * vzdálenost_cíle) * 39.37, 0)
                    End If
                End If


                If Hlavní_okno.checkbox_metricke_jednotky.Checked = True Then
                    rychlost_pro_zapis_tabulky = rychlost
                Else
                    rychlost_pro_zapis_tabulky = rychlost / 0.3048
                End If

                If Hlavní_okno.Checkbox_Střelba_s_puškohledem.Checked = False Then
                    Dim row As String() = New String() {vzdalenost_cile_pro_zapis_tabulky, korekce_elevace, korekce_větru, Round(Val(rychlost_pro_zapis_tabulky), 0), Round(Val(doba_pohybu), 3)}
                    DataGridView1.Rows.Add(row)
                Else
                    Dim row As String() = New String() {vzdalenost_cile_pro_zapis_tabulky, korekce_elevace & "  (" & pocet_kliků_elevace & ")", korekce_větru & "  (" & pocet_kliků_vítr & ")", Round(Val(rychlost_pro_zapis_tabulky), 0), Round(Val(doba_pohybu), 3)}
                    DataGridView1.Rows.Add(row)
                End If
            Loop

        Else
            MsgBox("Please check that all data are entered correctly." & vbNewLine & "Tip: The distance difference value cannot be less than or equal to zero." & vbNewLine & "Tip: The distance interval value cannot be greater than the distance difference value." & vbNewLine & "Tip: The number of rows in the table cannot be greater than 50, choose a larger interval.", MsgBoxStyle.Exclamation)
        End If
        button_vytvořit_tabulku.Enabled = True
        button_vytvořit_tabulku.Text = "Create a table"
        button_exportivat_do_pdf.Enabled = True
        button_exportivat_do_pdf.Enabled = True

        ulozeni_pameti()
    End Sub
    Private Sub vynulovat()
        rychlost = Nothing
        počáteční_rychlost = Nothing
        úhel_výstřelu = Nothing
        vzdálenost_cíle = Nothing
        koeficient_odporu = Nothing
        proměnný_koeficient_odporu = Nothing
        hustota_vzduchu = Nothing
        hmotnost = Nothing
        průměr_střely = 10
        plocha = Nothing
        vzdálenost_osy_miridel_od_hlavne = Nothing

        doba_pohybu = Nothing

        pojistka_výstřelu_interval_času = Nothing
        pojistka_výstřelu_zaokrouhleni = Nothing
        pojistka_výstřelu_interval_úhlu = Nothing

        prvni_vzdalenost = Nothing
        druha_vzdalenost = Nothing
        interval_vzdalenosti = Nothing
    End Sub

    Private Sub button_exportivat_do_pdf_Click(sender As Object, e As EventArgs) Handles button_exportivat_do_pdf.Click
        Try
            Dim nazev_dokumentu As String = "Ballistics for everyone 2.5"
            Dim lokace_dokumentu As String = ""

            Dim mezera As String = "    |    "


            SaveFileDialog1.FileName = ""

            SaveFileDialog1.Filter = "PDF (*.pdf)|*.pdf"
            SaveFileDialog1.Title = "Ballistics for everyone"

            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                lokace_dokumentu = SaveFileDialog1.FileName
                Dim Paragraph As New Paragraph
                Dim PdfFile As New Document(PageSize.A4, 40, 40, 40, 20)
                PdfFile.AddTitle(nazev_dokumentu)
                Dim write As PdfWriter = PdfWriter.GetInstance(PdfFile, New FileStream(lokace_dokumentu, FileMode.Create))
                PdfFile.Open()

                Dim pTitle As New Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 18, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
                Dim pTable As New Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK)

                Paragraph = New Paragraph(New Chunk(nazev_dokumentu, pTitle))
                Paragraph.Alignment = Element.ALIGN_CENTER
                Paragraph.SpacingAfter = 7.0F

                PdfFile.Add(Paragraph)

                ' zapis labelu
                Paragraph.Alignment = Element.ALIGN_MIDDLE
                Paragraph.SpacingAfter = 4.0F
                Paragraph = New Paragraph(label_pocatecni_rychlost.Text & mezera & label_teplota_vzduchu.Text, pTable)
                PdfFile.Add(Paragraph)
                Paragraph = New Paragraph(label_hmotnost_strely.Text & mezera & label_nadmorska_vyska.Text, pTable)
                PdfFile.Add(Paragraph)
                Paragraph = New Paragraph(label_balisticky_koeficient.Text & mezera & label_rychlost_vetru.Text, pTable)
                PdfFile.Add(Paragraph)
                Paragraph = New Paragraph(label_vzdalenost_osy_miridel_od_hlavne.Text & mezera & label_smer_vetru_od_osy_pohybu.Text, pTable)
                PdfFile.Add(Paragraph)
                Paragraph = New Paragraph(label_nastrelna_vzdalenost.Text & mezera & label_uhlove_jednotky.Text, pTable)
                PdfFile.Add(Paragraph)
                Paragraph = New Paragraph(label_poloha_zasahu_v_nastrelne_vzdalenosti.Text & mezera & label_uhel_sklonu.Text, pTable)
                PdfFile.Add(Paragraph)
                Paragraph = New Paragraph(label_nactena_strela.Text, pTable)
                PdfFile.Add(Paragraph)
                Paragraph = New Paragraph(vbNewLine, pTable)
                PdfFile.Add(Paragraph)


                Dim PdfTable As New PdfPTable(DataGridView1.Columns.Count)

                PdfTable.TotalWidth = 500.0F
                PdfTable.LockedWidth = True

                Dim widhts(0 To DataGridView1.Columns.Count - 1) As Single
                For i As Integer = 0 To DataGridView1.Columns.Count - 1
                    widhts(i) = 1.0F
                Next

                PdfTable.SetWidths(widhts)
                PdfTable.HorizontalAlignment = 0
                PdfTable.SpacingBefore = 5.0F

                Dim pdfcell As PdfPCell = New PdfPCell

                For i As Integer = 0 To DataGridView1.Columns.Count - 1
                    pdfcell = New PdfPCell(New Phrase(New Chunk(DataGridView1.Columns(i).HeaderText, pTable)))
                    pdfcell.HorizontalAlignment = PdfPCell.ALIGN_CENTER
                    PdfTable.AddCell(pdfcell)
                Next

                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    For j As Integer = 0 To DataGridView1.Columns.Count - 1
                        pdfcell = New PdfPCell(New Phrase(DataGridView1(j, i).Value.ToString(), pTable))
                        PdfTable.HorizontalAlignment = PdfPCell.ALIGN_MIDDLE
                        PdfTable.AddCell(pdfcell)
                    Next
                Next

                PdfFile.Add(PdfTable)
                PdfFile.Close()


                MsgBox("Table was successfully exported.", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox("You cannot overwrite opened file.", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub Export_tabulky_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Hlavní_okno.Enabled = True
        ulozeni_pameti()
    End Sub

    Private Sub combobox_interval_vzdalenosti_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_interval_vzdalenosti.SelectedIndexChanged
        DataGridView1.Columns.Clear()
        nastaveni_tabulky()
        combobox_prvni_vzdalenost.Text = combobox_interval_vzdalenosti.Text
    End Sub

    Private Sub ulozeni_pameti()
        My.Settings.pamet_export_tabulky_combobox_interval_vzdalenosti = combobox_interval_vzdalenosti.Text
        My.Settings.pamet_export_tabulky_textbox_interval_vzdalenosti = DomainUpDown1.SelectedIndex
        My.Settings.Save()
    End Sub

    Private Sub vyvolani_pameti()
        If My.Settings.pamet_export_tabulky_combobox_interval_vzdalenosti <> Nothing Then
            combobox_interval_vzdalenosti.Text = My.Settings.pamet_export_tabulky_combobox_interval_vzdalenosti
            DomainUpDown1.SelectedItem = DomainUpDown1.Items(My.Settings.pamet_export_tabulky_textbox_interval_vzdalenosti)
        Else
            combobox_interval_vzdalenosti.Text = "m"
            DomainUpDown1.SelectedItem = DomainUpDown1.Items(4)
        End If
    End Sub

End Class