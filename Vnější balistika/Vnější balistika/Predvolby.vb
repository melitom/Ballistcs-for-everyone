Public Class Predvolby
    Dim vzor As New System.Collections.Specialized.StringCollection

    Dim combobox_pocatecni_rychlost As String = Nothing

    Dim střelba_s_pevnými_mířidly As String = Nothing
    Dim střelba_s_puškohledem As String = Nothing
    Dim jednotky_moa As String = Nothing
    Dim ctvrt_moa As String = Nothing
    Dim osmina_moa As String = Nothing
    Dim jednotky_mrad As String = Nothing
    Dim zbraň_je_nastřelená As String = Nothing
    Dim spočítat_pouze_nástřelnou_trajektorii As String = Nothing

    Private Sub Predvolby_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Hlavní_okno.label_načtená_střela.Text <> "Bullet:" Then
            textbox_název_střely.Text = Replace(Hlavní_okno.label_načtená_střela.Text, "Bullet: ", Nothing)
        End If

        ListView1.FullRowSelect = True
        ListView1.GridLines = True

        ListView1.Columns.Add(0).Width = 300
        ListView1.Columns.Add(1).Width = 300

        ListView1.Columns(0).Text = "Preset name"
        ListView1.Columns(1).Text = "Bullet"


        obnoveni_listview()

        If My.Settings.tisk_povolen = True Then
            If Hlavní_okno.checkbox_použít_úhel_nástřelu_z_předchozího_výpočtu.Checked = True Then
                GroupBox1.Enabled = False
                button_uložit.Enabled = False
            Else
                GroupBox1.Enabled = True
                button_uložit.Enabled = True
            End If
        Else
            GroupBox1.Enabled = False
            button_uložit.Enabled = False
        End If

    End Sub
    Private Sub button_načíst_Click(sender As Object, e As EventArgs) Handles button_načíst.Click
        Try
            If My.Settings.uloziste_nazev_predvolby_1 = ListView1.SelectedItems(0).Text Then

                Hlavní_okno.Textbox_Počáteční_rychlost.Text = My.Settings.uloziste_ustova_rychlost_1
                Hlavní_okno.combobox_počáteční_rychlost.Text = My.Settings.uloziste_combobox_ustova_rychlost_1
                Hlavní_okno.Textbox_hmotnost.Text = My.Settings.uloziste_hmotnost_1
                Hlavní_okno.combobox_hmotnost_střely.Text = My.Settings.uloziste_combobox_hmotnost_1
                Hlavní_okno.Textbox_Koeficient_odporu.Text = My.Settings.uloziste_balistický_koeficient_1
                Hlavní_okno.Combobox_výběr_koeficientů.Text = My.Settings.uloziste_combobox_balistický_koeficient_1
                Hlavní_okno.Textbox_Vzdálenost_cíle.Text = My.Settings.uloziste_vzdálenost_cíle_1
                Hlavní_okno.combobox_vzdálenost_cíle.Text = My.Settings.uloziste_combobox_vzdalenost_cile_1
                Hlavní_okno.Textbox_Nástřelná_vzdálenost.Text = My.Settings.uloziste_nástřelná_vzdálenost_1
                Hlavní_okno.combobox_nástřelná_vzdálenost.Text = My.Settings.uloziste_combobox_nastrelna_vzdalenost_1
                Hlavní_okno.Textbox_Poloha_zásahu_v_nástřelu.Text = My.Settings.uloziste_poloha_zásahu_1
                Hlavní_okno.combobox_poloha_zásahu.Text = My.Settings.uloziste_combobox_poloha_zasahu_1
                Hlavní_okno.Textbox_Vzdálenost_mířidel.Text = My.Settings.uloziste_vzdálenost_miridel_1
                Hlavní_okno.combobox_vzdálenost_mířidel.Text = My.Settings.uloziste_combobox_vyska_miridel_1
                Hlavní_okno.textbox_uhel_sklonu.Text = My.Settings.uloziste_uhel_sklonu_1
                Hlavní_okno.Checkbox_Střelba_s_puškohledem.Checked = My.Settings.uloziste_strelba_s_puskohledem_1
                Hlavní_okno.Checkbox_jednotky_MOA.Checked = My.Settings.uloziste_jednotky_MOA_1
                Hlavní_okno.Checkbox_14_MOA.Checked = My.Settings.uloziste_14_MOA_1
                Hlavní_okno.Checkbox_18_MOA.Checked = My.Settings.uloziste_18_MOA_1
                Hlavní_okno.Checkbox_Jednotky_MRAD.Checked = My.Settings.uloziste_jednotky_MRAD_1
                Hlavní_okno.Checkbox_Zbraň_je_nastřelená.Checked = My.Settings.uloziste_zbran_je_nastrelena_1
                Hlavní_okno.Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Checked = My.Settings.uloziste_spocitej_pouze_nastrel_1
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & My.Settings.uloziste_nazev_strely_1

            ElseIf My.Settings.uloziste_nazev_predvolby_2 = ListView1.SelectedItems(0).Text Then

                Hlavní_okno.Textbox_Počáteční_rychlost.Text = My.Settings.uloziste_ustova_rychlost_2
                Hlavní_okno.combobox_počáteční_rychlost.Text = My.Settings.uloziste_combobox_ustova_rychlost_2
                Hlavní_okno.Textbox_hmotnost.Text = My.Settings.uloziste_hmotnost_2
                Hlavní_okno.combobox_hmotnost_střely.Text = My.Settings.uloziste_combobox_hmotnost_2
                Hlavní_okno.Textbox_Koeficient_odporu.Text = My.Settings.uloziste_balistický_koeficient_2
                Hlavní_okno.Combobox_výběr_koeficientů.Text = My.Settings.uloziste_combobox_balistický_koeficient_2
                Hlavní_okno.Textbox_Vzdálenost_cíle.Text = My.Settings.uloziste_vzdálenost_cíle_2
                Hlavní_okno.combobox_vzdálenost_cíle.Text = My.Settings.uloziste_combobox_vzdalenost_cile_2
                Hlavní_okno.Textbox_Nástřelná_vzdálenost.Text = My.Settings.uloziste_nástřelná_vzdálenost_2
                Hlavní_okno.combobox_nástřelná_vzdálenost.Text = My.Settings.uloziste_combobox_nastrelna_vzdalenost_2
                Hlavní_okno.Textbox_Poloha_zásahu_v_nástřelu.Text = My.Settings.uloziste_poloha_zásahu_2
                Hlavní_okno.combobox_poloha_zásahu.Text = My.Settings.uloziste_combobox_poloha_zasahu_2
                Hlavní_okno.Textbox_Vzdálenost_mířidel.Text = My.Settings.uloziste_vzdálenost_miridel_2
                Hlavní_okno.combobox_vzdálenost_mířidel.Text = My.Settings.uloziste_combobox_vyska_miridel_2
                Hlavní_okno.textbox_uhel_sklonu.Text = My.Settings.uloziste_uhel_sklonu_2
                Hlavní_okno.Checkbox_Střelba_s_puškohledem.Checked = My.Settings.uloziste_strelba_s_puskohledem_2
                Hlavní_okno.Checkbox_jednotky_MOA.Checked = My.Settings.uloziste_jednotky_MOA_2
                Hlavní_okno.Checkbox_14_MOA.Checked = My.Settings.uloziste_14_MOA_2
                Hlavní_okno.Checkbox_18_MOA.Checked = My.Settings.uloziste_18_MOA_2
                Hlavní_okno.Checkbox_Jednotky_MRAD.Checked = My.Settings.uloziste_jednotky_MRAD_2
                Hlavní_okno.Checkbox_Zbraň_je_nastřelená.Checked = My.Settings.uloziste_zbran_je_nastrelena_2
                Hlavní_okno.Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Checked = My.Settings.uloziste_spocitej_pouze_nastrel_2
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & My.Settings.uloziste_nazev_strely_2

            ElseIf My.Settings.uloziste_nazev_predvolby_3 = ListView1.SelectedItems(0).Text Then

                Hlavní_okno.Textbox_Počáteční_rychlost.Text = My.Settings.uloziste_ustova_rychlost_3
                Hlavní_okno.combobox_počáteční_rychlost.Text = My.Settings.uloziste_combobox_ustova_rychlost_3
                Hlavní_okno.Textbox_hmotnost.Text = My.Settings.uloziste_hmotnost_3
                Hlavní_okno.combobox_hmotnost_střely.Text = My.Settings.uloziste_combobox_hmotnost_3
                Hlavní_okno.Textbox_Koeficient_odporu.Text = My.Settings.uloziste_balistický_koeficient_3
                Hlavní_okno.Combobox_výběr_koeficientů.Text = My.Settings.uloziste_combobox_balistický_koeficient_3
                Hlavní_okno.Textbox_Vzdálenost_cíle.Text = My.Settings.uloziste_vzdálenost_cíle_3
                Hlavní_okno.combobox_vzdálenost_cíle.Text = My.Settings.uloziste_combobox_vzdalenost_cile_3
                Hlavní_okno.Textbox_Nástřelná_vzdálenost.Text = My.Settings.uloziste_nástřelná_vzdálenost_3
                Hlavní_okno.combobox_nástřelná_vzdálenost.Text = My.Settings.uloziste_combobox_nastrelna_vzdalenost_3
                Hlavní_okno.Textbox_Poloha_zásahu_v_nástřelu.Text = My.Settings.uloziste_poloha_zásahu_3
                Hlavní_okno.combobox_poloha_zásahu.Text = My.Settings.uloziste_combobox_poloha_zasahu_3
                Hlavní_okno.Textbox_Vzdálenost_mířidel.Text = My.Settings.uloziste_vzdálenost_miridel_3
                Hlavní_okno.combobox_vzdálenost_mířidel.Text = My.Settings.uloziste_combobox_vyska_miridel_3
                Hlavní_okno.textbox_uhel_sklonu.Text = My.Settings.uloziste_uhel_sklonu_3
                Hlavní_okno.Checkbox_Střelba_s_puškohledem.Checked = My.Settings.uloziste_strelba_s_puskohledem_3
                Hlavní_okno.Checkbox_jednotky_MOA.Checked = My.Settings.uloziste_jednotky_MOA_3
                Hlavní_okno.Checkbox_14_MOA.Checked = My.Settings.uloziste_14_MOA_3
                Hlavní_okno.Checkbox_18_MOA.Checked = My.Settings.uloziste_18_MOA_3
                Hlavní_okno.Checkbox_Jednotky_MRAD.Checked = My.Settings.uloziste_jednotky_MRAD_3
                Hlavní_okno.Checkbox_Zbraň_je_nastřelená.Checked = My.Settings.uloziste_zbran_je_nastrelena_3
                Hlavní_okno.Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Checked = My.Settings.uloziste_spocitej_pouze_nastrel_3
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & My.Settings.uloziste_nazev_strely_3


            ElseIf My.Settings.uloziste_nazev_predvolby_4 = ListView1.SelectedItems(0).Text Then

                Hlavní_okno.Textbox_Počáteční_rychlost.Text = My.Settings.uloziste_ustova_rychlost_4
                Hlavní_okno.combobox_počáteční_rychlost.Text = My.Settings.uloziste_combobox_ustova_rychlost_4
                Hlavní_okno.Textbox_hmotnost.Text = My.Settings.uloziste_hmotnost_4
                Hlavní_okno.combobox_hmotnost_střely.Text = My.Settings.uloziste_combobox_hmotnost_4
                Hlavní_okno.Textbox_Koeficient_odporu.Text = My.Settings.uloziste_balistický_koeficient_4
                Hlavní_okno.Combobox_výběr_koeficientů.Text = My.Settings.uloziste_combobox_balistický_koeficient_4
                Hlavní_okno.Textbox_Vzdálenost_cíle.Text = My.Settings.uloziste_vzdálenost_cíle_4
                Hlavní_okno.combobox_vzdálenost_cíle.Text = My.Settings.uloziste_combobox_vzdalenost_cile_4
                Hlavní_okno.Textbox_Nástřelná_vzdálenost.Text = My.Settings.uloziste_nástřelná_vzdálenost_4
                Hlavní_okno.combobox_nástřelná_vzdálenost.Text = My.Settings.uloziste_combobox_nastrelna_vzdalenost_4
                Hlavní_okno.Textbox_Poloha_zásahu_v_nástřelu.Text = My.Settings.uloziste_poloha_zásahu_4
                Hlavní_okno.combobox_poloha_zásahu.Text = My.Settings.uloziste_combobox_poloha_zasahu_4
                Hlavní_okno.Textbox_Vzdálenost_mířidel.Text = My.Settings.uloziste_vzdálenost_miridel_4
                Hlavní_okno.combobox_vzdálenost_mířidel.Text = My.Settings.uloziste_combobox_vyska_miridel_4
                Hlavní_okno.textbox_uhel_sklonu.Text = My.Settings.uloziste_uhel_sklonu_4
                Hlavní_okno.Checkbox_Střelba_s_puškohledem.Checked = My.Settings.uloziste_strelba_s_puskohledem_4
                Hlavní_okno.Checkbox_jednotky_MOA.Checked = My.Settings.uloziste_jednotky_MOA_4
                Hlavní_okno.Checkbox_14_MOA.Checked = My.Settings.uloziste_14_MOA_4
                Hlavní_okno.Checkbox_18_MOA.Checked = My.Settings.uloziste_18_MOA_4
                Hlavní_okno.Checkbox_Jednotky_MRAD.Checked = My.Settings.uloziste_jednotky_MRAD_4
                Hlavní_okno.Checkbox_Zbraň_je_nastřelená.Checked = My.Settings.uloziste_zbran_je_nastrelena_4
                Hlavní_okno.Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Checked = My.Settings.uloziste_spocitej_pouze_nastrel_4
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & My.Settings.uloziste_nazev_strely_4

            ElseIf My.Settings.uloziste_nazev_predvolby_5 = ListView1.SelectedItems(0).Text Then

                Hlavní_okno.Textbox_Počáteční_rychlost.Text = My.Settings.uloziste_ustova_rychlost_5
                Hlavní_okno.combobox_počáteční_rychlost.Text = My.Settings.uloziste_combobox_ustova_rychlost_5
                Hlavní_okno.Textbox_hmotnost.Text = My.Settings.uloziste_hmotnost_5
                Hlavní_okno.combobox_hmotnost_střely.Text = My.Settings.uloziste_combobox_hmotnost_5
                Hlavní_okno.Textbox_Koeficient_odporu.Text = My.Settings.uloziste_balistický_koeficient_5
                Hlavní_okno.Combobox_výběr_koeficientů.Text = My.Settings.uloziste_combobox_balistický_koeficient_5
                Hlavní_okno.Textbox_Vzdálenost_cíle.Text = My.Settings.uloziste_vzdálenost_cíle_5
                Hlavní_okno.combobox_vzdálenost_cíle.Text = My.Settings.uloziste_combobox_vzdalenost_cile_5
                Hlavní_okno.Textbox_Nástřelná_vzdálenost.Text = My.Settings.uloziste_nástřelná_vzdálenost_5
                Hlavní_okno.combobox_nástřelná_vzdálenost.Text = My.Settings.uloziste_combobox_nastrelna_vzdalenost_5
                Hlavní_okno.Textbox_Poloha_zásahu_v_nástřelu.Text = My.Settings.uloziste_poloha_zásahu_5
                Hlavní_okno.combobox_poloha_zásahu.Text = My.Settings.uloziste_combobox_poloha_zasahu_5
                Hlavní_okno.Textbox_Vzdálenost_mířidel.Text = My.Settings.uloziste_vzdálenost_miridel_5
                Hlavní_okno.combobox_vzdálenost_mířidel.Text = My.Settings.uloziste_combobox_vyska_miridel_5
                Hlavní_okno.textbox_uhel_sklonu.Text = My.Settings.uloziste_uhel_sklonu_5
                Hlavní_okno.Checkbox_Střelba_s_puškohledem.Checked = My.Settings.uloziste_strelba_s_puskohledem_5
                Hlavní_okno.Checkbox_jednotky_MOA.Checked = My.Settings.uloziste_jednotky_MOA_5
                Hlavní_okno.Checkbox_14_MOA.Checked = My.Settings.uloziste_14_MOA_5
                Hlavní_okno.Checkbox_18_MOA.Checked = My.Settings.uloziste_18_MOA_5
                Hlavní_okno.Checkbox_Jednotky_MRAD.Checked = My.Settings.uloziste_jednotky_MRAD_5
                Hlavní_okno.Checkbox_Zbraň_je_nastřelená.Checked = My.Settings.uloziste_zbran_je_nastrelena_5
                Hlavní_okno.Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Checked = My.Settings.uloziste_spocitej_pouze_nastrel_5
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & My.Settings.uloziste_nazev_strely_5

            ElseIf My.Settings.uloziste_nazev_predvolby_6 = ListView1.SelectedItems(0).Text Then

                Hlavní_okno.Textbox_Počáteční_rychlost.Text = My.Settings.uloziste_ustova_rychlost_6
                Hlavní_okno.combobox_počáteční_rychlost.Text = My.Settings.uloziste_combobox_ustova_rychlost_6
                Hlavní_okno.Textbox_hmotnost.Text = My.Settings.uloziste_hmotnost_6
                Hlavní_okno.combobox_hmotnost_střely.Text = My.Settings.uloziste_combobox_hmotnost_6
                Hlavní_okno.Textbox_Koeficient_odporu.Text = My.Settings.uloziste_balistický_koeficient_6
                Hlavní_okno.Combobox_výběr_koeficientů.Text = My.Settings.uloziste_combobox_balistický_koeficient_6
                Hlavní_okno.Textbox_Vzdálenost_cíle.Text = My.Settings.uloziste_vzdálenost_cíle_6
                Hlavní_okno.combobox_vzdálenost_cíle.Text = My.Settings.uloziste_combobox_vzdalenost_cile_6
                Hlavní_okno.Textbox_Nástřelná_vzdálenost.Text = My.Settings.uloziste_nástřelná_vzdálenost_6
                Hlavní_okno.combobox_nástřelná_vzdálenost.Text = My.Settings.uloziste_combobox_nastrelna_vzdalenost_6
                Hlavní_okno.Textbox_Poloha_zásahu_v_nástřelu.Text = My.Settings.uloziste_poloha_zásahu_6
                Hlavní_okno.combobox_poloha_zásahu.Text = My.Settings.uloziste_combobox_poloha_zasahu_6
                Hlavní_okno.Textbox_Vzdálenost_mířidel.Text = My.Settings.uloziste_vzdálenost_miridel_6
                Hlavní_okno.combobox_vzdálenost_mířidel.Text = My.Settings.uloziste_combobox_vyska_miridel_6
                Hlavní_okno.textbox_uhel_sklonu.Text = My.Settings.uloziste_uhel_sklonu_6
                Hlavní_okno.Checkbox_Střelba_s_puškohledem.Checked = My.Settings.uloziste_strelba_s_puskohledem_6
                Hlavní_okno.Checkbox_jednotky_MOA.Checked = My.Settings.uloziste_jednotky_MOA_6
                Hlavní_okno.Checkbox_14_MOA.Checked = My.Settings.uloziste_14_MOA_6
                Hlavní_okno.Checkbox_18_MOA.Checked = My.Settings.uloziste_18_MOA_6
                Hlavní_okno.Checkbox_Jednotky_MRAD.Checked = My.Settings.uloziste_jednotky_MRAD_6
                Hlavní_okno.Checkbox_Zbraň_je_nastřelená.Checked = My.Settings.uloziste_zbran_je_nastrelena_6
                Hlavní_okno.Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Checked = My.Settings.uloziste_spocitej_pouze_nastrel_6
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & My.Settings.uloziste_nazev_strely_6

            ElseIf My.Settings.uloziste_nazev_predvolby_7 = ListView1.SelectedItems(0).Text Then

                Hlavní_okno.Textbox_Počáteční_rychlost.Text = My.Settings.uloziste_ustova_rychlost_7
                Hlavní_okno.combobox_počáteční_rychlost.Text = My.Settings.uloziste_combobox_ustova_rychlost_7
                Hlavní_okno.Textbox_hmotnost.Text = My.Settings.uloziste_hmotnost_7
                Hlavní_okno.combobox_hmotnost_střely.Text = My.Settings.uloziste_combobox_hmotnost_7
                Hlavní_okno.Textbox_Koeficient_odporu.Text = My.Settings.uloziste_balistický_koeficient_7
                Hlavní_okno.Combobox_výběr_koeficientů.Text = My.Settings.uloziste_combobox_balistický_koeficient_7
                Hlavní_okno.Textbox_Vzdálenost_cíle.Text = My.Settings.uloziste_vzdálenost_cíle_7
                Hlavní_okno.combobox_vzdálenost_cíle.Text = My.Settings.uloziste_combobox_vzdalenost_cile_7
                Hlavní_okno.Textbox_Nástřelná_vzdálenost.Text = My.Settings.uloziste_nástřelná_vzdálenost_7
                Hlavní_okno.combobox_nástřelná_vzdálenost.Text = My.Settings.uloziste_combobox_nastrelna_vzdalenost_7
                Hlavní_okno.Textbox_Poloha_zásahu_v_nástřelu.Text = My.Settings.uloziste_poloha_zásahu_7
                Hlavní_okno.combobox_poloha_zásahu.Text = My.Settings.uloziste_combobox_poloha_zasahu_7
                Hlavní_okno.Textbox_Vzdálenost_mířidel.Text = My.Settings.uloziste_vzdálenost_miridel_7
                Hlavní_okno.combobox_vzdálenost_mířidel.Text = My.Settings.uloziste_combobox_vyska_miridel_7
                Hlavní_okno.textbox_uhel_sklonu.Text = My.Settings.uloziste_uhel_sklonu_7
                Hlavní_okno.Checkbox_Střelba_s_puškohledem.Checked = My.Settings.uloziste_strelba_s_puskohledem_7
                Hlavní_okno.Checkbox_jednotky_MOA.Checked = My.Settings.uloziste_jednotky_MOA_7
                Hlavní_okno.Checkbox_14_MOA.Checked = My.Settings.uloziste_14_MOA_7
                Hlavní_okno.Checkbox_18_MOA.Checked = My.Settings.uloziste_18_MOA_7
                Hlavní_okno.Checkbox_Jednotky_MRAD.Checked = My.Settings.uloziste_jednotky_MRAD_7
                Hlavní_okno.Checkbox_Zbraň_je_nastřelená.Checked = My.Settings.uloziste_zbran_je_nastrelena_7
                Hlavní_okno.Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Checked = My.Settings.uloziste_spocitej_pouze_nastrel_7
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & My.Settings.uloziste_nazev_strely_7

            ElseIf My.Settings.uloziste_nazev_predvolby_8 = ListView1.SelectedItems(0).Text Then

                Hlavní_okno.Textbox_Počáteční_rychlost.Text = My.Settings.uloziste_ustova_rychlost_8
                Hlavní_okno.combobox_počáteční_rychlost.Text = My.Settings.uloziste_combobox_ustova_rychlost_8
                Hlavní_okno.Textbox_hmotnost.Text = My.Settings.uloziste_hmotnost_8
                Hlavní_okno.combobox_hmotnost_střely.Text = My.Settings.uloziste_combobox_hmotnost_8
                Hlavní_okno.Textbox_Koeficient_odporu.Text = My.Settings.uloziste_balistický_koeficient_8
                Hlavní_okno.Combobox_výběr_koeficientů.Text = My.Settings.uloziste_combobox_balistický_koeficient_8
                Hlavní_okno.Textbox_Vzdálenost_cíle.Text = My.Settings.uloziste_vzdálenost_cíle_8
                Hlavní_okno.combobox_vzdálenost_cíle.Text = My.Settings.uloziste_combobox_vzdalenost_cile_8
                Hlavní_okno.Textbox_Nástřelná_vzdálenost.Text = My.Settings.uloziste_nástřelná_vzdálenost_8
                Hlavní_okno.combobox_nástřelná_vzdálenost.Text = My.Settings.uloziste_combobox_nastrelna_vzdalenost_8
                Hlavní_okno.Textbox_Poloha_zásahu_v_nástřelu.Text = My.Settings.uloziste_poloha_zásahu_8
                Hlavní_okno.combobox_poloha_zásahu.Text = My.Settings.uloziste_combobox_poloha_zasahu_8
                Hlavní_okno.Textbox_Vzdálenost_mířidel.Text = My.Settings.uloziste_vzdálenost_miridel_8
                Hlavní_okno.combobox_vzdálenost_mířidel.Text = My.Settings.uloziste_combobox_vyska_miridel_8
                Hlavní_okno.textbox_uhel_sklonu.Text = My.Settings.uloziste_uhel_sklonu_8
                Hlavní_okno.Checkbox_Střelba_s_puškohledem.Checked = My.Settings.uloziste_strelba_s_puskohledem_8
                Hlavní_okno.Checkbox_jednotky_MOA.Checked = My.Settings.uloziste_jednotky_MOA_8
                Hlavní_okno.Checkbox_14_MOA.Checked = My.Settings.uloziste_14_MOA_8
                Hlavní_okno.Checkbox_18_MOA.Checked = My.Settings.uloziste_18_MOA_8
                Hlavní_okno.Checkbox_Jednotky_MRAD.Checked = My.Settings.uloziste_jednotky_MRAD_8
                Hlavní_okno.Checkbox_Zbraň_je_nastřelená.Checked = My.Settings.uloziste_zbran_je_nastrelena_8
                Hlavní_okno.Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Checked = My.Settings.uloziste_spocitej_pouze_nastrel_8
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & My.Settings.uloziste_nazev_strely_8

            ElseIf My.Settings.uloziste_nazev_predvolby_9 = ListView1.SelectedItems(0).Text Then

                Hlavní_okno.Textbox_Počáteční_rychlost.Text = My.Settings.uloziste_ustova_rychlost_9
                Hlavní_okno.combobox_počáteční_rychlost.Text = My.Settings.uloziste_combobox_ustova_rychlost_9
                Hlavní_okno.Textbox_hmotnost.Text = My.Settings.uloziste_hmotnost_9
                Hlavní_okno.combobox_hmotnost_střely.Text = My.Settings.uloziste_combobox_hmotnost_9
                Hlavní_okno.Textbox_Koeficient_odporu.Text = My.Settings.uloziste_balistický_koeficient_9
                Hlavní_okno.Combobox_výběr_koeficientů.Text = My.Settings.uloziste_combobox_balistický_koeficient_9
                Hlavní_okno.Textbox_Vzdálenost_cíle.Text = My.Settings.uloziste_vzdálenost_cíle_9
                Hlavní_okno.combobox_vzdálenost_cíle.Text = My.Settings.uloziste_combobox_vzdalenost_cile_9
                Hlavní_okno.Textbox_Nástřelná_vzdálenost.Text = My.Settings.uloziste_nástřelná_vzdálenost_9
                Hlavní_okno.combobox_nástřelná_vzdálenost.Text = My.Settings.uloziste_combobox_nastrelna_vzdalenost_9
                Hlavní_okno.Textbox_Poloha_zásahu_v_nástřelu.Text = My.Settings.uloziste_poloha_zásahu_9
                Hlavní_okno.combobox_poloha_zásahu.Text = My.Settings.uloziste_combobox_poloha_zasahu_9
                Hlavní_okno.Textbox_Vzdálenost_mířidel.Text = My.Settings.uloziste_vzdálenost_miridel_9
                Hlavní_okno.combobox_vzdálenost_mířidel.Text = My.Settings.uloziste_combobox_vyska_miridel_9
                Hlavní_okno.textbox_uhel_sklonu.Text = My.Settings.uloziste_uhel_sklonu_9
                Hlavní_okno.Checkbox_Střelba_s_puškohledem.Checked = My.Settings.uloziste_strelba_s_puskohledem_9
                Hlavní_okno.Checkbox_jednotky_MOA.Checked = My.Settings.uloziste_jednotky_MOA_9
                Hlavní_okno.Checkbox_14_MOA.Checked = My.Settings.uloziste_14_MOA_9
                Hlavní_okno.Checkbox_18_MOA.Checked = My.Settings.uloziste_18_MOA_9
                Hlavní_okno.Checkbox_Jednotky_MRAD.Checked = My.Settings.uloziste_jednotky_MRAD_9
                Hlavní_okno.Checkbox_Zbraň_je_nastřelená.Checked = My.Settings.uloziste_zbran_je_nastrelena_9
                Hlavní_okno.Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Checked = My.Settings.uloziste_spocitej_pouze_nastrel_9
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & My.Settings.uloziste_nazev_strely_9

            ElseIf My.Settings.uloziste_nazev_predvolby_10 = ListView1.SelectedItems(0).Text Then

                Hlavní_okno.Textbox_Počáteční_rychlost.Text = My.Settings.uloziste_ustova_rychlost_10
                Hlavní_okno.combobox_počáteční_rychlost.Text = My.Settings.uloziste_combobox_ustova_rychlost_10
                Hlavní_okno.Textbox_hmotnost.Text = My.Settings.uloziste_hmotnost_10
                Hlavní_okno.combobox_hmotnost_střely.Text = My.Settings.uloziste_combobox_hmotnost_10
                Hlavní_okno.Textbox_Koeficient_odporu.Text = My.Settings.uloziste_balistický_koeficient_10
                Hlavní_okno.Combobox_výběr_koeficientů.Text = My.Settings.uloziste_combobox_balistický_koeficient_10
                Hlavní_okno.Textbox_Vzdálenost_cíle.Text = My.Settings.uloziste_vzdálenost_cíle_10
                Hlavní_okno.combobox_vzdálenost_cíle.Text = My.Settings.uloziste_combobox_vzdalenost_cile_10
                Hlavní_okno.Textbox_Nástřelná_vzdálenost.Text = My.Settings.uloziste_nástřelná_vzdálenost_10
                Hlavní_okno.combobox_nástřelná_vzdálenost.Text = My.Settings.uloziste_combobox_nastrelna_vzdalenost_10
                Hlavní_okno.Textbox_Poloha_zásahu_v_nástřelu.Text = My.Settings.uloziste_poloha_zásahu_10
                Hlavní_okno.combobox_poloha_zásahu.Text = My.Settings.uloziste_combobox_poloha_zasahu_10
                Hlavní_okno.Textbox_Vzdálenost_mířidel.Text = My.Settings.uloziste_vzdálenost_miridel_10
                Hlavní_okno.combobox_vzdálenost_mířidel.Text = My.Settings.uloziste_combobox_vyska_miridel_10
                Hlavní_okno.textbox_uhel_sklonu.Text = My.Settings.uloziste_uhel_sklonu_10
                Hlavní_okno.Checkbox_Střelba_s_puškohledem.Checked = My.Settings.uloziste_strelba_s_puskohledem_10
                Hlavní_okno.Checkbox_jednotky_MOA.Checked = My.Settings.uloziste_jednotky_MOA_10
                Hlavní_okno.Checkbox_14_MOA.Checked = My.Settings.uloziste_14_MOA_10
                Hlavní_okno.Checkbox_18_MOA.Checked = My.Settings.uloziste_18_MOA_10
                Hlavní_okno.Checkbox_Jednotky_MRAD.Checked = My.Settings.uloziste_jednotky_MRAD_10
                Hlavní_okno.Checkbox_Zbraň_je_nastřelená.Checked = My.Settings.uloziste_zbran_je_nastrelena_10
                Hlavní_okno.Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Checked = My.Settings.uloziste_spocitej_pouze_nastrel_10
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & My.Settings.uloziste_nazev_strely_10

            End If
        Catch ex As Exception
            MsgBox("Select the preset you want to load into the main calculation.", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub button_smazat_Click(sender As Object, e As EventArgs) Handles button_smazat.Click
        Try
            If My.Settings.uloziste_nazev_predvolby_1 = ListView1.SelectedItems(0).Text Then
                My.Settings.uloziste_ustova_rychlost_1 = Nothing
                My.Settings.uloziste_nazev_predvolby_1 = Nothing
            ElseIf My.Settings.uloziste_nazev_predvolby_2 = ListView1.SelectedItems(0).Text Then
                My.Settings.uloziste_ustova_rychlost_2 = Nothing
                My.Settings.uloziste_nazev_predvolby_2 = Nothing
            ElseIf My.Settings.uloziste_nazev_predvolby_3 = ListView1.SelectedItems(0).Text Then
                My.Settings.uloziste_ustova_rychlost_3 = Nothing
                My.Settings.uloziste_nazev_predvolby_3 = Nothing
            ElseIf My.Settings.uloziste_nazev_predvolby_4 = ListView1.SelectedItems(0).Text Then
                My.Settings.uloziste_ustova_rychlost_4 = Nothing
                My.Settings.uloziste_nazev_predvolby_4 = Nothing
            ElseIf My.Settings.uloziste_nazev_predvolby_5 = ListView1.SelectedItems(0).Text Then
                My.Settings.uloziste_ustova_rychlost_5 = Nothing
                My.Settings.uloziste_nazev_predvolby_5 = Nothing
            ElseIf My.Settings.uloziste_nazev_predvolby_6 = ListView1.SelectedItems(0).Text Then
                My.Settings.uloziste_ustova_rychlost_6 = Nothing
                My.Settings.uloziste_nazev_predvolby_6 = Nothing
            ElseIf My.Settings.uloziste_nazev_predvolby_7 = ListView1.SelectedItems(0).Text Then
                My.Settings.uloziste_ustova_rychlost_7 = Nothing
                My.Settings.uloziste_nazev_predvolby_7 = Nothing
            ElseIf My.Settings.uloziste_nazev_predvolby_8 = ListView1.SelectedItems(0).Text Then
                My.Settings.uloziste_ustova_rychlost_8 = Nothing
                My.Settings.uloziste_nazev_predvolby_8 = Nothing
            ElseIf My.Settings.uloziste_nazev_predvolby_9 = ListView1.SelectedItems(0).Text Then
                My.Settings.uloziste_ustova_rychlost_9 = Nothing
                My.Settings.uloziste_nazev_predvolby_9 = Nothing
            ElseIf My.Settings.uloziste_nazev_predvolby_10 = ListView1.SelectedItems(0).Text Then
                My.Settings.uloziste_ustova_rychlost_10 = Nothing
                My.Settings.uloziste_nazev_predvolby_10 = Nothing
            End If

            My.Settings.Save()
            obnoveni_listview()

        Catch ex As Exception
            MsgBox("Select the preset you want to delete.", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub button_zavřít_Click(sender As Object, e As EventArgs) Handles button_zavřít.Click
        Hlavní_okno.Enabled = True
        GroupBox1.Enabled = False
        button_uložit.Enabled = False
        My.Settings.Save()
        Close()
    End Sub

    Private Sub button_uložit_Click(sender As Object, e As EventArgs) Handles button_uložit.Click
        If textbox_název_střely.TextLength > 35 Or textbox_název_převolby.TextLength > 40 Or textbox_název_převolby.Text = Nothing Or textbox_název_střely.Text = Nothing Then
            MsgBox("Before saving the preset it is necessary to fill in the name of the preset and the name of the bullet." & vbNewLine & "Tip: The maximum length of a bullet name, including spaces, is 35 characters." & vbNewLine & "Tip: The maximum length of a preset name, including spaces, is 40 characters.", MsgBoxStyle.Exclamation)
        Else
            If textbox_název_převolby.Text = My.Settings.uloziste_nazev_predvolby_1 Then
                MsgBox("You cannot save two or more presets with the same name.", MsgBoxStyle.Exclamation)
            ElseIf textbox_název_převolby.Text = My.Settings.uloziste_nazev_predvolby_2 Then
                MsgBox("You cannot save two or more presets with the same name.", MsgBoxStyle.Exclamation)
            ElseIf textbox_název_převolby.Text = My.Settings.uloziste_nazev_predvolby_3 Then
                MsgBox("You cannot save two or more presets with the same name.", MsgBoxStyle.Exclamation)
            ElseIf textbox_název_převolby.Text = My.Settings.uloziste_nazev_predvolby_4 Then
                MsgBox("You cannot save two or more presets with the same name.", MsgBoxStyle.Exclamation)
            ElseIf textbox_název_převolby.Text = My.Settings.uloziste_nazev_predvolby_5 Then
                MsgBox("You cannot save two or more presets with the same name.", MsgBoxStyle.Exclamation)
            ElseIf textbox_název_převolby.Text = My.Settings.uloziste_nazev_predvolby_6 Then
                MsgBox("You cannot save two or more presets with the same name.", MsgBoxStyle.Exclamation)
            ElseIf textbox_název_převolby.Text = My.Settings.uloziste_nazev_predvolby_7 Then
                MsgBox("You cannot save two or more presets with the same name.", MsgBoxStyle.Exclamation)
            ElseIf textbox_název_převolby.Text = My.Settings.uloziste_nazev_predvolby_8 Then
                MsgBox("You cannot save two or more presets with the same name.", MsgBoxStyle.Exclamation)
            ElseIf textbox_název_převolby.Text = My.Settings.uloziste_nazev_predvolby_9 Then
                MsgBox("You cannot save two or more presets with the same name.", MsgBoxStyle.Exclamation)
            ElseIf textbox_název_převolby.Text = My.Settings.uloziste_nazev_predvolby_10 Then
                MsgBox("You cannot save two or more presets with the same name.", MsgBoxStyle.Exclamation)
            Else
                zápis_do_predvoleb()
                obnoveni_listview()
            End If
        End If
    End Sub
    Private Sub obnoveni_listview()
        ListView1.Items.Clear()
        Dim i As Integer = 0
        If My.Settings.uloziste_ustova_rychlost_1 <> Nothing Then
            ListView1.Items.Add(My.Settings.uloziste_nazev_predvolby_1)
            ListView1.Items(i).SubItems.Add(My.Settings.uloziste_nazev_strely_1)
            i = i + 1
        End If
        If My.Settings.uloziste_ustova_rychlost_2 <> Nothing Then
            ListView1.Items.Add(My.Settings.uloziste_nazev_predvolby_2)
            ListView1.Items(i).SubItems.Add(My.Settings.uloziste_nazev_strely_2)
            i = i + 1
        End If
        If My.Settings.uloziste_ustova_rychlost_3 <> Nothing Then
            ListView1.Items.Add(My.Settings.uloziste_nazev_predvolby_3)
            ListView1.Items(i).SubItems.Add(My.Settings.uloziste_nazev_strely_3)
            i = i + 1
        End If
        If My.Settings.uloziste_ustova_rychlost_4 <> Nothing Then
            ListView1.Items.Add(My.Settings.uloziste_nazev_predvolby_4)
            ListView1.Items(i).SubItems.Add(My.Settings.uloziste_nazev_strely_4)
            i = i + 1
        End If
        If My.Settings.uloziste_ustova_rychlost_5 <> Nothing Then
            ListView1.Items.Add(My.Settings.uloziste_nazev_predvolby_5)
            ListView1.Items(i).SubItems.Add(My.Settings.uloziste_nazev_strely_5)
            i = i + 1
        End If
        If My.Settings.uloziste_ustova_rychlost_6 <> Nothing Then
            ListView1.Items.Add(My.Settings.uloziste_nazev_predvolby_6)
            ListView1.Items(i).SubItems.Add(My.Settings.uloziste_nazev_strely_6)
            i = i + 1
        End If
        If My.Settings.uloziste_ustova_rychlost_7 <> Nothing Then
            ListView1.Items.Add(My.Settings.uloziste_nazev_predvolby_7)
            ListView1.Items(i).SubItems.Add(My.Settings.uloziste_nazev_strely_7)
            i = i + 1
        End If
        If My.Settings.uloziste_ustova_rychlost_8 <> Nothing Then
            ListView1.Items.Add(My.Settings.uloziste_nazev_predvolby_8)
            ListView1.Items(i).SubItems.Add(My.Settings.uloziste_nazev_strely_8)
            i = i + 1
        End If
        If My.Settings.uloziste_ustova_rychlost_9 <> Nothing Then
            ListView1.Items.Add(My.Settings.uloziste_nazev_predvolby_9)
            ListView1.Items(i).SubItems.Add(My.Settings.uloziste_nazev_strely_9)
            i = i + 1
        End If
        If My.Settings.uloziste_ustova_rychlost_10 <> Nothing Then
            ListView1.Items.Add(My.Settings.uloziste_nazev_predvolby_10)
            ListView1.Items(i).SubItems.Add(My.Settings.uloziste_nazev_strely_10)
        End If
    End Sub
    Private Sub zápis_do_predvoleb()
        'Vzor
        '==========================================================================
        vzor.Add("Úsťová rychlost") '0
        vzor.Add("Jednotka úsťové rychlosti") '1
        vzor.Add("Hmotnost střely") '2
        vzor.Add("Jednotka hmotnosti") '3
        vzor.Add("Balistický koeficient") '4
        vzor.Add("Jednotka balistickcého koeficientu") '5
        vzor.Add("Vzdálenost cíle") '6
        vzor.Add("Nástřelná vzdálenost") '7
        vzor.Add("Poloha zásahu v nástřelné vzdálenosti") '8
        vzor.Add("Vzdálenost osy mířidel od hlavně") '9
        '==========================================================================
        vzor.Add("Střelba s pevnými mířidly (ano/ne)") '10
        vzor.Add("Střelba s puškohledem (ano/ne)") '11
        vzor.Add("Jednotky MOA (ano/ne)") '12
        vzor.Add("1/4 MOA (ano/ne)") '13
        vzor.Add("1/8 MOA (ano/ne)") '14
        vzor.Add("Jednotky MRAD (ano/ne)") '15
        vzor.Add("Zbraň je nastřelená (ano/ne)") '16
        vzor.Add("Spočítat pouze nástřelnou trajektorii (ano/ne)") '17
        '==========================================================================
        vzor.Add("textbox_název_střely") '18
        vzor.Add("textbox_název_předvolby") '19
        '==========================================================================

        If My.Settings.uloziste_ustova_rychlost_1 = Nothing Then

            My.Settings.uloziste_ustova_rychlost_1 = Hlavní_okno.Textbox_Počáteční_rychlost.Text
            My.Settings.uloziste_combobox_ustova_rychlost_1 = Hlavní_okno.combobox_počáteční_rychlost.Text
            My.Settings.uloziste_hmotnost_1 = Hlavní_okno.Textbox_hmotnost.Text
            My.Settings.uloziste_combobox_hmotnost_1 = Hlavní_okno.combobox_hmotnost_střely.Text
            My.Settings.uloziste_balistický_koeficient_1 = Hlavní_okno.Textbox_Koeficient_odporu.Text
            My.Settings.uloziste_combobox_balistický_koeficient_1 = Hlavní_okno.Combobox_výběr_koeficientů.Text
            My.Settings.uloziste_vzdálenost_cíle_1 = Hlavní_okno.Textbox_Vzdálenost_cíle.Text
            My.Settings.uloziste_combobox_vzdalenost_cile_1 = Hlavní_okno.combobox_vzdálenost_cíle.Text
            My.Settings.uloziste_nástřelná_vzdálenost_1 = Hlavní_okno.Textbox_Nástřelná_vzdálenost.Text
            My.Settings.uloziste_combobox_nastrelna_vzdalenost_1 = Hlavní_okno.combobox_nástřelná_vzdálenost.Text
            My.Settings.uloziste_poloha_zásahu_1 = Hlavní_okno.Textbox_Poloha_zásahu_v_nástřelu.Text
            My.Settings.uloziste_combobox_poloha_zasahu_1 = Hlavní_okno.combobox_poloha_zásahu.Text
            My.Settings.uloziste_vzdálenost_miridel_1 = Hlavní_okno.Textbox_Vzdálenost_mířidel.Text
            My.Settings.uloziste_combobox_vyska_miridel_1 = Hlavní_okno.combobox_vzdálenost_mířidel.Text
            My.Settings.uloziste_uhel_sklonu_1 = Hlavní_okno.textbox_uhel_sklonu.Text
            My.Settings.uloziste_strelba_s_puskohledem_1 = Hlavní_okno.Checkbox_Střelba_s_puškohledem.Checked
            My.Settings.uloziste_jednotky_MOA_1 = Hlavní_okno.Checkbox_jednotky_MOA.Checked
            My.Settings.uloziste_14_MOA_1 = Hlavní_okno.Checkbox_14_MOA.Checked
            My.Settings.uloziste_18_MOA_1 = Hlavní_okno.Checkbox_18_MOA.Checked
            My.Settings.uloziste_jednotky_MRAD_1 = Hlavní_okno.Checkbox_Jednotky_MRAD.Checked
            My.Settings.uloziste_zbran_je_nastrelena_1 = Hlavní_okno.Checkbox_Zbraň_je_nastřelená.Checked
            My.Settings.uloziste_spocitej_pouze_nastrel_1 = Hlavní_okno.Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Checked
            My.Settings.uloziste_nazev_strely_1 = textbox_název_střely.Text
            My.Settings.uloziste_nazev_predvolby_1 = textbox_název_převolby.Text

        Else
            If My.Settings.uloziste_ustova_rychlost_2 = Nothing Then

                My.Settings.uloziste_ustova_rychlost_2 = Hlavní_okno.Textbox_Počáteční_rychlost.Text
                My.Settings.uloziste_combobox_ustova_rychlost_2 = Hlavní_okno.combobox_počáteční_rychlost.Text
                My.Settings.uloziste_hmotnost_2 = Hlavní_okno.Textbox_hmotnost.Text
                My.Settings.uloziste_combobox_hmotnost_2 = Hlavní_okno.combobox_hmotnost_střely.Text
                My.Settings.uloziste_balistický_koeficient_2 = Hlavní_okno.Textbox_Koeficient_odporu.Text
                My.Settings.uloziste_combobox_balistický_koeficient_2 = Hlavní_okno.Combobox_výběr_koeficientů.Text
                My.Settings.uloziste_vzdálenost_cíle_2 = Hlavní_okno.Textbox_Vzdálenost_cíle.Text
                My.Settings.uloziste_combobox_vzdalenost_cile_2 = Hlavní_okno.combobox_vzdálenost_cíle.Text
                My.Settings.uloziste_nástřelná_vzdálenost_2 = Hlavní_okno.Textbox_Nástřelná_vzdálenost.Text
                My.Settings.uloziste_combobox_nastrelna_vzdalenost_2 = Hlavní_okno.combobox_nástřelná_vzdálenost.Text
                My.Settings.uloziste_poloha_zásahu_2 = Hlavní_okno.Textbox_Poloha_zásahu_v_nástřelu.Text
                My.Settings.uloziste_combobox_poloha_zasahu_2 = Hlavní_okno.combobox_poloha_zásahu.Text
                My.Settings.uloziste_vzdálenost_miridel_2 = Hlavní_okno.Textbox_Vzdálenost_mířidel.Text
                My.Settings.uloziste_combobox_vyska_miridel_2 = Hlavní_okno.combobox_vzdálenost_mířidel.Text
                My.Settings.uloziste_uhel_sklonu_2 = Hlavní_okno.textbox_uhel_sklonu.Text
                My.Settings.uloziste_strelba_s_puskohledem_2 = Hlavní_okno.Checkbox_Střelba_s_puškohledem.Checked
                My.Settings.uloziste_jednotky_MOA_2 = Hlavní_okno.Checkbox_jednotky_MOA.Checked
                My.Settings.uloziste_14_MOA_2 = Hlavní_okno.Checkbox_14_MOA.Checked
                My.Settings.uloziste_18_MOA_2 = Hlavní_okno.Checkbox_18_MOA.Checked
                My.Settings.uloziste_jednotky_MRAD_2 = Hlavní_okno.Checkbox_Jednotky_MRAD.Checked
                My.Settings.uloziste_zbran_je_nastrelena_2 = Hlavní_okno.Checkbox_Zbraň_je_nastřelená.Checked
                My.Settings.uloziste_spocitej_pouze_nastrel_2 = Hlavní_okno.Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Checked
                My.Settings.uloziste_nazev_strely_2 = textbox_název_střely.Text
                My.Settings.uloziste_nazev_predvolby_2 = textbox_název_převolby.Text

            Else
                If My.Settings.uloziste_ustova_rychlost_3 = Nothing Then

                    My.Settings.uloziste_ustova_rychlost_3 = Hlavní_okno.Textbox_Počáteční_rychlost.Text
                    My.Settings.uloziste_combobox_ustova_rychlost_3 = Hlavní_okno.combobox_počáteční_rychlost.Text
                    My.Settings.uloziste_hmotnost_3 = Hlavní_okno.Textbox_hmotnost.Text
                    My.Settings.uloziste_combobox_hmotnost_3 = Hlavní_okno.combobox_hmotnost_střely.Text
                    My.Settings.uloziste_balistický_koeficient_3 = Hlavní_okno.Textbox_Koeficient_odporu.Text
                    My.Settings.uloziste_combobox_balistický_koeficient_3 = Hlavní_okno.Combobox_výběr_koeficientů.Text
                    My.Settings.uloziste_vzdálenost_cíle_3 = Hlavní_okno.Textbox_Vzdálenost_cíle.Text
                    My.Settings.uloziste_combobox_vzdalenost_cile_3 = Hlavní_okno.combobox_vzdálenost_cíle.Text
                    My.Settings.uloziste_nástřelná_vzdálenost_3 = Hlavní_okno.Textbox_Nástřelná_vzdálenost.Text
                    My.Settings.uloziste_combobox_nastrelna_vzdalenost_3 = Hlavní_okno.combobox_nástřelná_vzdálenost.Text
                    My.Settings.uloziste_poloha_zásahu_3 = Hlavní_okno.Textbox_Poloha_zásahu_v_nástřelu.Text
                    My.Settings.uloziste_combobox_poloha_zasahu_3 = Hlavní_okno.combobox_poloha_zásahu.Text
                    My.Settings.uloziste_vzdálenost_miridel_3 = Hlavní_okno.Textbox_Vzdálenost_mířidel.Text
                    My.Settings.uloziste_combobox_vyska_miridel_3 = Hlavní_okno.combobox_vzdálenost_mířidel.Text
                    My.Settings.uloziste_uhel_sklonu_3 = Hlavní_okno.textbox_uhel_sklonu.Text
                    My.Settings.uloziste_strelba_s_puskohledem_3 = Hlavní_okno.Checkbox_Střelba_s_puškohledem.Checked
                    My.Settings.uloziste_jednotky_MOA_3 = Hlavní_okno.Checkbox_jednotky_MOA.Checked
                    My.Settings.uloziste_14_MOA_3 = Hlavní_okno.Checkbox_14_MOA.Checked
                    My.Settings.uloziste_18_MOA_3 = Hlavní_okno.Checkbox_18_MOA.Checked
                    My.Settings.uloziste_jednotky_MRAD_3 = Hlavní_okno.Checkbox_Jednotky_MRAD.Checked
                    My.Settings.uloziste_zbran_je_nastrelena_3 = Hlavní_okno.Checkbox_Zbraň_je_nastřelená.Checked
                    My.Settings.uloziste_spocitej_pouze_nastrel_3 = Hlavní_okno.Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Checked
                    My.Settings.uloziste_nazev_strely_3 = textbox_název_střely.Text
                    My.Settings.uloziste_nazev_predvolby_3 = textbox_název_převolby.Text


                Else
                    If My.Settings.uloziste_ustova_rychlost_4 = Nothing Then

                        My.Settings.uloziste_ustova_rychlost_4 = Hlavní_okno.Textbox_Počáteční_rychlost.Text
                        My.Settings.uloziste_combobox_ustova_rychlost_4 = Hlavní_okno.combobox_počáteční_rychlost.Text
                        My.Settings.uloziste_hmotnost_4 = Hlavní_okno.Textbox_hmotnost.Text
                        My.Settings.uloziste_combobox_hmotnost_4 = Hlavní_okno.combobox_hmotnost_střely.Text
                        My.Settings.uloziste_balistický_koeficient_4 = Hlavní_okno.Textbox_Koeficient_odporu.Text
                        My.Settings.uloziste_combobox_balistický_koeficient_4 = Hlavní_okno.Combobox_výběr_koeficientů.Text
                        My.Settings.uloziste_vzdálenost_cíle_4 = Hlavní_okno.Textbox_Vzdálenost_cíle.Text
                        My.Settings.uloziste_combobox_vzdalenost_cile_4 = Hlavní_okno.combobox_vzdálenost_cíle.Text
                        My.Settings.uloziste_nástřelná_vzdálenost_4 = Hlavní_okno.Textbox_Nástřelná_vzdálenost.Text
                        My.Settings.uloziste_combobox_nastrelna_vzdalenost_4 = Hlavní_okno.combobox_nástřelná_vzdálenost.Text
                        My.Settings.uloziste_poloha_zásahu_4 = Hlavní_okno.Textbox_Poloha_zásahu_v_nástřelu.Text
                        My.Settings.uloziste_combobox_poloha_zasahu_4 = Hlavní_okno.combobox_poloha_zásahu.Text
                        My.Settings.uloziste_vzdálenost_miridel_4 = Hlavní_okno.Textbox_Vzdálenost_mířidel.Text
                        My.Settings.uloziste_combobox_vyska_miridel_4 = Hlavní_okno.combobox_vzdálenost_mířidel.Text
                        My.Settings.uloziste_uhel_sklonu_4 = Hlavní_okno.textbox_uhel_sklonu.Text
                        My.Settings.uloziste_strelba_s_puskohledem_4 = Hlavní_okno.Checkbox_Střelba_s_puškohledem.Checked
                        My.Settings.uloziste_jednotky_MOA_4 = Hlavní_okno.Checkbox_jednotky_MOA.Checked
                        My.Settings.uloziste_14_MOA_4 = Hlavní_okno.Checkbox_14_MOA.Checked
                        My.Settings.uloziste_18_MOA_4 = Hlavní_okno.Checkbox_18_MOA.Checked
                        My.Settings.uloziste_jednotky_MRAD_4 = Hlavní_okno.Checkbox_Jednotky_MRAD.Checked
                        My.Settings.uloziste_zbran_je_nastrelena_4 = Hlavní_okno.Checkbox_Zbraň_je_nastřelená.Checked
                        My.Settings.uloziste_spocitej_pouze_nastrel_4 = Hlavní_okno.Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Checked
                        My.Settings.uloziste_nazev_strely_4 = textbox_název_střely.Text
                        My.Settings.uloziste_nazev_predvolby_4 = textbox_název_převolby.Text

                    Else
                        If My.Settings.uloziste_ustova_rychlost_5 = Nothing Then

                            My.Settings.uloziste_ustova_rychlost_5 = Hlavní_okno.Textbox_Počáteční_rychlost.Text
                            My.Settings.uloziste_combobox_ustova_rychlost_5 = Hlavní_okno.combobox_počáteční_rychlost.Text
                            My.Settings.uloziste_hmotnost_5 = Hlavní_okno.Textbox_hmotnost.Text
                            My.Settings.uloziste_combobox_hmotnost_5 = Hlavní_okno.combobox_hmotnost_střely.Text
                            My.Settings.uloziste_balistický_koeficient_5 = Hlavní_okno.Textbox_Koeficient_odporu.Text
                            My.Settings.uloziste_combobox_balistický_koeficient_5 = Hlavní_okno.Combobox_výběr_koeficientů.Text
                            My.Settings.uloziste_vzdálenost_cíle_5 = Hlavní_okno.Textbox_Vzdálenost_cíle.Text
                            My.Settings.uloziste_combobox_vzdalenost_cile_5 = Hlavní_okno.combobox_vzdálenost_cíle.Text
                            My.Settings.uloziste_nástřelná_vzdálenost_5 = Hlavní_okno.Textbox_Nástřelná_vzdálenost.Text
                            My.Settings.uloziste_combobox_nastrelna_vzdalenost_5 = Hlavní_okno.combobox_nástřelná_vzdálenost.Text
                            My.Settings.uloziste_poloha_zásahu_5 = Hlavní_okno.Textbox_Poloha_zásahu_v_nástřelu.Text
                            My.Settings.uloziste_combobox_poloha_zasahu_5 = Hlavní_okno.combobox_poloha_zásahu.Text
                            My.Settings.uloziste_vzdálenost_miridel_5 = Hlavní_okno.Textbox_Vzdálenost_mířidel.Text
                            My.Settings.uloziste_combobox_vyska_miridel_5 = Hlavní_okno.combobox_vzdálenost_mířidel.Text
                            My.Settings.uloziste_uhel_sklonu_5 = Hlavní_okno.textbox_uhel_sklonu.Text
                            My.Settings.uloziste_strelba_s_puskohledem_5 = Hlavní_okno.Checkbox_Střelba_s_puškohledem.Checked
                            My.Settings.uloziste_jednotky_MOA_5 = Hlavní_okno.Checkbox_jednotky_MOA.Checked
                            My.Settings.uloziste_14_MOA_5 = Hlavní_okno.Checkbox_14_MOA.Checked
                            My.Settings.uloziste_18_MOA_5 = Hlavní_okno.Checkbox_18_MOA.Checked
                            My.Settings.uloziste_jednotky_MRAD_5 = Hlavní_okno.Checkbox_Jednotky_MRAD.Checked
                            My.Settings.uloziste_zbran_je_nastrelena_5 = Hlavní_okno.Checkbox_Zbraň_je_nastřelená.Checked
                            My.Settings.uloziste_spocitej_pouze_nastrel_5 = Hlavní_okno.Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Checked
                            My.Settings.uloziste_nazev_strely_5 = textbox_název_střely.Text
                            My.Settings.uloziste_nazev_predvolby_5 = textbox_název_převolby.Text

                        Else
                            If My.Settings.uloziste_ustova_rychlost_6 = Nothing Then

                                My.Settings.uloziste_ustova_rychlost_6 = Hlavní_okno.Textbox_Počáteční_rychlost.Text
                                My.Settings.uloziste_combobox_ustova_rychlost_6 = Hlavní_okno.combobox_počáteční_rychlost.Text
                                My.Settings.uloziste_hmotnost_6 = Hlavní_okno.Textbox_hmotnost.Text
                                My.Settings.uloziste_combobox_hmotnost_6 = Hlavní_okno.combobox_hmotnost_střely.Text
                                My.Settings.uloziste_balistický_koeficient_6 = Hlavní_okno.Textbox_Koeficient_odporu.Text
                                My.Settings.uloziste_combobox_balistický_koeficient_6 = Hlavní_okno.Combobox_výběr_koeficientů.Text
                                My.Settings.uloziste_vzdálenost_cíle_6 = Hlavní_okno.Textbox_Vzdálenost_cíle.Text
                                My.Settings.uloziste_combobox_vzdalenost_cile_6 = Hlavní_okno.combobox_vzdálenost_cíle.Text
                                My.Settings.uloziste_nástřelná_vzdálenost_6 = Hlavní_okno.Textbox_Nástřelná_vzdálenost.Text
                                My.Settings.uloziste_combobox_nastrelna_vzdalenost_6 = Hlavní_okno.combobox_nástřelná_vzdálenost.Text
                                My.Settings.uloziste_poloha_zásahu_6 = Hlavní_okno.Textbox_Poloha_zásahu_v_nástřelu.Text
                                My.Settings.uloziste_combobox_poloha_zasahu_6 = Hlavní_okno.combobox_poloha_zásahu.Text
                                My.Settings.uloziste_vzdálenost_miridel_6 = Hlavní_okno.Textbox_Vzdálenost_mířidel.Text
                                My.Settings.uloziste_combobox_vyska_miridel_6 = Hlavní_okno.combobox_vzdálenost_mířidel.Text
                                My.Settings.uloziste_uhel_sklonu_6 = Hlavní_okno.textbox_uhel_sklonu.Text
                                My.Settings.uloziste_strelba_s_puskohledem_6 = Hlavní_okno.Checkbox_Střelba_s_puškohledem.Checked
                                My.Settings.uloziste_jednotky_MOA_6 = Hlavní_okno.Checkbox_jednotky_MOA.Checked
                                My.Settings.uloziste_14_MOA_6 = Hlavní_okno.Checkbox_14_MOA.Checked
                                My.Settings.uloziste_18_MOA_6 = Hlavní_okno.Checkbox_18_MOA.Checked
                                My.Settings.uloziste_jednotky_MRAD_6 = Hlavní_okno.Checkbox_Jednotky_MRAD.Checked
                                My.Settings.uloziste_zbran_je_nastrelena_6 = Hlavní_okno.Checkbox_Zbraň_je_nastřelená.Checked
                                My.Settings.uloziste_spocitej_pouze_nastrel_6 = Hlavní_okno.Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Checked
                                My.Settings.uloziste_nazev_strely_6 = textbox_název_střely.Text
                                My.Settings.uloziste_nazev_predvolby_6 = textbox_název_převolby.Text

                            Else
                                If My.Settings.uloziste_ustova_rychlost_7 = Nothing Then

                                    My.Settings.uloziste_ustova_rychlost_7 = Hlavní_okno.Textbox_Počáteční_rychlost.Text
                                    My.Settings.uloziste_combobox_ustova_rychlost_7 = Hlavní_okno.combobox_počáteční_rychlost.Text
                                    My.Settings.uloziste_hmotnost_7 = Hlavní_okno.Textbox_hmotnost.Text
                                    My.Settings.uloziste_combobox_hmotnost_7 = Hlavní_okno.combobox_hmotnost_střely.Text
                                    My.Settings.uloziste_balistický_koeficient_7 = Hlavní_okno.Textbox_Koeficient_odporu.Text
                                    My.Settings.uloziste_combobox_balistický_koeficient_7 = Hlavní_okno.Combobox_výběr_koeficientů.Text
                                    My.Settings.uloziste_vzdálenost_cíle_7 = Hlavní_okno.Textbox_Vzdálenost_cíle.Text
                                    My.Settings.uloziste_combobox_vzdalenost_cile_7 = Hlavní_okno.combobox_vzdálenost_cíle.Text
                                    My.Settings.uloziste_nástřelná_vzdálenost_7 = Hlavní_okno.Textbox_Nástřelná_vzdálenost.Text
                                    My.Settings.uloziste_combobox_nastrelna_vzdalenost_7 = Hlavní_okno.combobox_nástřelná_vzdálenost.Text
                                    My.Settings.uloziste_poloha_zásahu_7 = Hlavní_okno.Textbox_Poloha_zásahu_v_nástřelu.Text
                                    My.Settings.uloziste_combobox_poloha_zasahu_7 = Hlavní_okno.combobox_poloha_zásahu.Text
                                    My.Settings.uloziste_vzdálenost_miridel_7 = Hlavní_okno.Textbox_Vzdálenost_mířidel.Text
                                    My.Settings.uloziste_combobox_vyska_miridel_7 = Hlavní_okno.combobox_vzdálenost_mířidel.Text
                                    My.Settings.uloziste_uhel_sklonu_7 = Hlavní_okno.textbox_uhel_sklonu.Text
                                    My.Settings.uloziste_strelba_s_puskohledem_7 = Hlavní_okno.Checkbox_Střelba_s_puškohledem.Checked
                                    My.Settings.uloziste_jednotky_MOA_7 = Hlavní_okno.Checkbox_jednotky_MOA.Checked
                                    My.Settings.uloziste_14_MOA_7 = Hlavní_okno.Checkbox_14_MOA.Checked
                                    My.Settings.uloziste_18_MOA_7 = Hlavní_okno.Checkbox_18_MOA.Checked
                                    My.Settings.uloziste_jednotky_MRAD_7 = Hlavní_okno.Checkbox_Jednotky_MRAD.Checked
                                    My.Settings.uloziste_zbran_je_nastrelena_7 = Hlavní_okno.Checkbox_Zbraň_je_nastřelená.Checked
                                    My.Settings.uloziste_spocitej_pouze_nastrel_7 = Hlavní_okno.Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Checked
                                    My.Settings.uloziste_nazev_strely_7 = textbox_název_střely.Text
                                    My.Settings.uloziste_nazev_predvolby_7 = textbox_název_převolby.Text

                                Else
                                    If My.Settings.uloziste_ustova_rychlost_8 = Nothing Then

                                        My.Settings.uloziste_ustova_rychlost_8 = Hlavní_okno.Textbox_Počáteční_rychlost.Text
                                        My.Settings.uloziste_combobox_ustova_rychlost_8 = Hlavní_okno.combobox_počáteční_rychlost.Text
                                        My.Settings.uloziste_hmotnost_8 = Hlavní_okno.Textbox_hmotnost.Text
                                        My.Settings.uloziste_combobox_hmotnost_8 = Hlavní_okno.combobox_hmotnost_střely.Text
                                        My.Settings.uloziste_balistický_koeficient_8 = Hlavní_okno.Textbox_Koeficient_odporu.Text
                                        My.Settings.uloziste_combobox_balistický_koeficient_8 = Hlavní_okno.Combobox_výběr_koeficientů.Text
                                        My.Settings.uloziste_vzdálenost_cíle_8 = Hlavní_okno.Textbox_Vzdálenost_cíle.Text
                                        My.Settings.uloziste_combobox_vzdalenost_cile_8 = Hlavní_okno.combobox_vzdálenost_cíle.Text
                                        My.Settings.uloziste_nástřelná_vzdálenost_8 = Hlavní_okno.Textbox_Nástřelná_vzdálenost.Text
                                        My.Settings.uloziste_combobox_nastrelna_vzdalenost_8 = Hlavní_okno.combobox_nástřelná_vzdálenost.Text
                                        My.Settings.uloziste_poloha_zásahu_8 = Hlavní_okno.Textbox_Poloha_zásahu_v_nástřelu.Text
                                        My.Settings.uloziste_combobox_poloha_zasahu_8 = Hlavní_okno.combobox_poloha_zásahu.Text
                                        My.Settings.uloziste_vzdálenost_miridel_8 = Hlavní_okno.Textbox_Vzdálenost_mířidel.Text
                                        My.Settings.uloziste_combobox_vyska_miridel_8 = Hlavní_okno.combobox_vzdálenost_mířidel.Text
                                        My.Settings.uloziste_uhel_sklonu_8 = Hlavní_okno.textbox_uhel_sklonu.Text
                                        My.Settings.uloziste_strelba_s_puskohledem_8 = Hlavní_okno.Checkbox_Střelba_s_puškohledem.Checked
                                        My.Settings.uloziste_jednotky_MOA_8 = Hlavní_okno.Checkbox_jednotky_MOA.Checked
                                        My.Settings.uloziste_14_MOA_8 = Hlavní_okno.Checkbox_14_MOA.Checked
                                        My.Settings.uloziste_18_MOA_8 = Hlavní_okno.Checkbox_18_MOA.Checked
                                        My.Settings.uloziste_jednotky_MRAD_8 = Hlavní_okno.Checkbox_Jednotky_MRAD.Checked
                                        My.Settings.uloziste_zbran_je_nastrelena_8 = Hlavní_okno.Checkbox_Zbraň_je_nastřelená.Checked
                                        My.Settings.uloziste_spocitej_pouze_nastrel_8 = Hlavní_okno.Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Checked
                                        My.Settings.uloziste_nazev_strely_8 = textbox_název_střely.Text
                                        My.Settings.uloziste_nazev_predvolby_8 = textbox_název_převolby.Text

                                    Else
                                        If My.Settings.uloziste_ustova_rychlost_9 = Nothing Then

                                            My.Settings.uloziste_ustova_rychlost_9 = Hlavní_okno.Textbox_Počáteční_rychlost.Text
                                            My.Settings.uloziste_combobox_ustova_rychlost_9 = Hlavní_okno.combobox_počáteční_rychlost.Text
                                            My.Settings.uloziste_hmotnost_9 = Hlavní_okno.Textbox_hmotnost.Text
                                            My.Settings.uloziste_combobox_hmotnost_9 = Hlavní_okno.combobox_hmotnost_střely.Text
                                            My.Settings.uloziste_balistický_koeficient_9 = Hlavní_okno.Textbox_Koeficient_odporu.Text
                                            My.Settings.uloziste_combobox_balistický_koeficient_9 = Hlavní_okno.Combobox_výběr_koeficientů.Text
                                            My.Settings.uloziste_vzdálenost_cíle_9 = Hlavní_okno.Textbox_Vzdálenost_cíle.Text
                                            My.Settings.uloziste_combobox_vzdalenost_cile_9 = Hlavní_okno.combobox_vzdálenost_cíle.Text
                                            My.Settings.uloziste_nástřelná_vzdálenost_9 = Hlavní_okno.Textbox_Nástřelná_vzdálenost.Text
                                            My.Settings.uloziste_combobox_nastrelna_vzdalenost_9 = Hlavní_okno.combobox_nástřelná_vzdálenost.Text
                                            My.Settings.uloziste_poloha_zásahu_9 = Hlavní_okno.Textbox_Poloha_zásahu_v_nástřelu.Text
                                            My.Settings.uloziste_combobox_poloha_zasahu_9 = Hlavní_okno.combobox_poloha_zásahu.Text
                                            My.Settings.uloziste_vzdálenost_miridel_9 = Hlavní_okno.Textbox_Vzdálenost_mířidel.Text
                                            My.Settings.uloziste_combobox_vyska_miridel_9 = Hlavní_okno.combobox_vzdálenost_mířidel.Text
                                            My.Settings.uloziste_uhel_sklonu_9 = Hlavní_okno.textbox_uhel_sklonu.Text
                                            My.Settings.uloziste_strelba_s_puskohledem_9 = Hlavní_okno.Checkbox_Střelba_s_puškohledem.Checked
                                            My.Settings.uloziste_jednotky_MOA_9 = Hlavní_okno.Checkbox_jednotky_MOA.Checked
                                            My.Settings.uloziste_14_MOA_9 = Hlavní_okno.Checkbox_14_MOA.Checked
                                            My.Settings.uloziste_18_MOA_9 = Hlavní_okno.Checkbox_18_MOA.Checked
                                            My.Settings.uloziste_jednotky_MRAD_9 = Hlavní_okno.Checkbox_Jednotky_MRAD.Checked
                                            My.Settings.uloziste_zbran_je_nastrelena_9 = Hlavní_okno.Checkbox_Zbraň_je_nastřelená.Checked
                                            My.Settings.uloziste_spocitej_pouze_nastrel_9 = Hlavní_okno.Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Checked
                                            My.Settings.uloziste_nazev_strely_9 = textbox_název_střely.Text
                                            My.Settings.uloziste_nazev_predvolby_9 = textbox_název_převolby.Text

                                        Else
                                            If My.Settings.uloziste_ustova_rychlost_10 = Nothing Then

                                                My.Settings.uloziste_ustova_rychlost_10 = Hlavní_okno.Textbox_Počáteční_rychlost.Text
                                                My.Settings.uloziste_combobox_ustova_rychlost_10 = Hlavní_okno.combobox_počáteční_rychlost.Text
                                                My.Settings.uloziste_hmotnost_10 = Hlavní_okno.Textbox_hmotnost.Text
                                                My.Settings.uloziste_combobox_hmotnost_10 = Hlavní_okno.combobox_hmotnost_střely.Text
                                                My.Settings.uloziste_balistický_koeficient_10 = Hlavní_okno.Textbox_Koeficient_odporu.Text
                                                My.Settings.uloziste_combobox_balistický_koeficient_10 = Hlavní_okno.Combobox_výběr_koeficientů.Text
                                                My.Settings.uloziste_vzdálenost_cíle_10 = Hlavní_okno.Textbox_Vzdálenost_cíle.Text
                                                My.Settings.uloziste_combobox_vzdalenost_cile_10 = Hlavní_okno.combobox_vzdálenost_cíle.Text
                                                My.Settings.uloziste_nástřelná_vzdálenost_10 = Hlavní_okno.Textbox_Nástřelná_vzdálenost.Text
                                                My.Settings.uloziste_combobox_nastrelna_vzdalenost_10 = Hlavní_okno.combobox_nástřelná_vzdálenost.Text
                                                My.Settings.uloziste_poloha_zásahu_10 = Hlavní_okno.Textbox_Poloha_zásahu_v_nástřelu.Text
                                                My.Settings.uloziste_combobox_poloha_zasahu_10 = Hlavní_okno.combobox_poloha_zásahu.Text
                                                My.Settings.uloziste_vzdálenost_miridel_10 = Hlavní_okno.Textbox_Vzdálenost_mířidel.Text
                                                My.Settings.uloziste_combobox_vyska_miridel_10 = Hlavní_okno.combobox_vzdálenost_mířidel.Text
                                                My.Settings.uloziste_uhel_sklonu_10 = Hlavní_okno.textbox_uhel_sklonu.Text
                                                My.Settings.uloziste_strelba_s_puskohledem_10 = Hlavní_okno.Checkbox_Střelba_s_puškohledem.Checked
                                                My.Settings.uloziste_jednotky_MOA_10 = Hlavní_okno.Checkbox_jednotky_MOA.Checked
                                                My.Settings.uloziste_14_MOA_10 = Hlavní_okno.Checkbox_14_MOA.Checked
                                                My.Settings.uloziste_18_MOA_10 = Hlavní_okno.Checkbox_18_MOA.Checked
                                                My.Settings.uloziste_jednotky_MRAD_10 = Hlavní_okno.Checkbox_Jednotky_MRAD.Checked
                                                My.Settings.uloziste_zbran_je_nastrelena_10 = Hlavní_okno.Checkbox_Zbraň_je_nastřelená.Checked
                                                My.Settings.uloziste_spocitej_pouze_nastrel_10 = Hlavní_okno.Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Checked
                                                My.Settings.uloziste_nazev_strely_10 = textbox_název_střely.Text
                                                My.Settings.uloziste_nazev_predvolby_10 = textbox_název_převolby.Text

                                            Else
                                                MsgBox("The preset list is full, one must be deleted to save a new preset.", MsgBoxStyle.Exclamation)
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
        My.Settings.Save()
    End Sub

    Private Sub Predvolby_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Hlavní_okno.Enabled = True
    End Sub
End Class