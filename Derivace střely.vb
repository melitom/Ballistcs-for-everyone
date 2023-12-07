Public Class Derivace_střely

    'Veškerá data budou v angloamerických jednotkách a hmotnost je vždy v grainech

    Dim ustova_rychlost As Decimal = 0
    Dim hmotnost_strely As Decimal = 0
    Dim stoupani_drazek As Decimal = 0
    Dim delka_strely As Decimal = 0
    Dim prumer_strely As Decimal = 0

    Dim koeficient_Sg As Double = 0
    Dim derivace_v_metrech As Double = 0
    Dim coriolisuv_efekt_v_metrech_vyskovy As Double = 0
    Dim coriolisuv_efekt_v_metrech_stranovy As Double = 0
    Dim chyba As Boolean = False

    Private Sub Derivace_střely_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        vyvolani_pameti()
        combobox_zeměpisná_šířka.Text = "deg"
        label_koeficient_Sg.Visible = False
        groupbox_coriolisuv_efekt.Enabled = False
        groupbox_derivace.Enabled = False


        If My.Settings.hustota_vzduchu = 0 Then
            My.Settings.hustota_vzduchu = 1.168
            My.Settings.teplota_vzduchu = "15 °C"
            My.Settings.nadmořská_výška = "400 m"
        End If

        label_teplota_vzduchu.Text = "Air temperature: " & My.Settings.teplota_vzduchu
        label_nadmořská_výška.Text = "Elevation: " & My.Settings.nadmořská_výška

        If Hlavní_okno.Textbox_Počáteční_rychlost.Text <> Nothing Then
            Textbox_Počáteční_rychlost.Text = Hlavní_okno.Textbox_Počáteční_rychlost.Text
            Textbox_hmotnost.Text = Hlavní_okno.Textbox_hmotnost.Text
            combobox_počáteční_rychlost.Text = Hlavní_okno.combobox_počáteční_rychlost.Text
            combobox_hmotnost_střely.Text = Hlavní_okno.combobox_hmotnost_střely.Text
        End If

        radiobutton_N.Checked = True

        If My.Settings.tisk_povolen = True Then
            checkbox_spocitat_coriolisuv_efekt.Enabled = True
            checkbox_spocitat_derivaci.Enabled = True
        Else
            checkbox_spocitat_coriolisuv_efekt.Enabled = False
            checkbox_spocitat_derivaci.Enabled = False
        End If

        If checkbox_spocitat_derivaci.Enabled = True Or checkbox_spocitat_coriolisuv_efekt.Enabled = True Then
            checkbox_nacist_odchylky.Enabled = True
        Else
            checkbox_nacist_odchylky.Enabled = False
        End If

    End Sub

    Private Sub Derivace_střely_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

        label_teplota_vzduchu.Text = "Air temperature: " & My.Settings.teplota_vzduchu
        label_nadmořská_výška.Text = "Elevation: " & My.Settings.nadmořská_výška


        If My.Settings.tisk_povolen = True Then
            checkbox_spocitat_coriolisuv_efekt.Enabled = True
            checkbox_spocitat_derivaci.Enabled = True
        Else
            checkbox_spocitat_coriolisuv_efekt.Enabled = False
            checkbox_spocitat_derivaci.Enabled = False
        End If

        If checkbox_spocitat_derivaci.Enabled = True Or checkbox_spocitat_coriolisuv_efekt.Enabled = True Then
            checkbox_nacist_odchylky.Enabled = True
        Else
            checkbox_nacist_odchylky.Enabled = False
        End If

        If Textbox_Počáteční_rychlost.Text = Nothing Then
            Textbox_Počáteční_rychlost.Text = Hlavní_okno.Textbox_Počáteční_rychlost.Text
            Textbox_hmotnost.Text = Hlavní_okno.Textbox_hmotnost.Text
            combobox_počáteční_rychlost.Text = Hlavní_okno.combobox_počáteční_rychlost.Text
            combobox_hmotnost_střely.Text = Hlavní_okno.combobox_hmotnost_střely.Text
        End If
    End Sub

    Private Sub Button_zavřít_Click(sender As Object, e As EventArgs) Handles button_zavřít.Click
        ulozeni_pameti()
        Hlavní_okno.Enabled = True
        Me.Hide()
    End Sub

    Private Sub button_spočítej_stabilizaci_Click(sender As Object, e As EventArgs) Handles button_spočítej_stabilizaci.Click

        vynulovat()

        zápis_proměnných_stabilizace()
        If chyba = False Then
            label_koeficient_Sg.Visible = True
            vypocet_stabilizace_střely()
        End If

        If checkbox_spocitat_derivaci.Checked = True And chyba = False Then
            vypocet_a_zapis_derivace()
            zapis_vysledku()
        End If

        If checkbox_spocitat_coriolisuv_efekt.Checked = True And chyba = False Then
            vypocet_a_zapis_coriolisova_efektu()
            zapis_vysledku()
        End If

        ulozeni_pameti()

        'MsgBox("Derivace: " & derivace_v_metrech & vbNewLine & "Coriolis vyska: " & coriolisuv_efekt_v_metrech_vyskovy & vbNewLine & "Coriolis strana: " & coriolisuv_efekt_v_metrech_stranovy)
    End Sub

    Private Sub zapis_vysledku()

        Dim stranová_korekce_klikani As Double = 0
        Dim stranová_korekce_prenaseni As Double = 0
        Dim výšková_korekce_klikani As Double = 0
        Dim výšková_korekce_prenaseni As Double = 0
        Dim vzdálenost_cíle As Decimal = 0

        If Hlavní_okno.combobox_vzdálenost_cíle.Text = "m" Then
            vzdálenost_cíle = Hlavní_okno.Textbox_Vzdálenost_cíle.Text
        ElseIf Hlavní_okno.combobox_vzdálenost_cíle.Text = "ft" Then
            vzdálenost_cíle = Hlavní_okno.Textbox_Vzdálenost_cíle.Text * 0.3048
        Else
            vzdálenost_cíle = Hlavní_okno.Textbox_Vzdálenost_cíle.Text * 0.9144
        End If

        stranová_korekce_klikani = Math.Atan((coriolisuv_efekt_v_metrech_stranovy + derivace_v_metrech) / vzdálenost_cíle) * (180 / Math.PI)
        stranová_korekce_prenaseni = (coriolisuv_efekt_v_metrech_stranovy + derivace_v_metrech) * 100

        výšková_korekce_klikani = Math.Atan(coriolisuv_efekt_v_metrech_vyskovy / vzdálenost_cíle) * (180 / Math.PI)
        výšková_korekce_prenaseni = coriolisuv_efekt_v_metrech_vyskovy * 100

        If checkbox_nacist_odchylky.Checked = True Then
            My.Settings.korekce_stranova_derivace_coriolis = coriolisuv_efekt_v_metrech_stranovy + derivace_v_metrech
            My.Settings.korekce_vyskova_coriolis = coriolisuv_efekt_v_metrech_vyskovy
        Else
            My.Settings.korekce_stranova_derivace_coriolis = 0
            My.Settings.korekce_vyskova_coriolis = 0
        End If


        If Hlavní_okno.checkbox_metricke_jednotky.Checked = True Then
            If stranová_korekce_klikani < 0 Then
                If Hlavní_okno.Checkbox_14_MOA.Checked = True Then
                    label_korekce_klikáním_stranová.Text = "Scope compensation: " & Math.Round(Val((stranová_korekce_klikani * (-1)) * 60), 2) & " MOA" & " (" & Math.Round(Val(((stranová_korekce_klikani * (-1)) * 60) * 4), 0) & " clicks) right"
                ElseIf Hlavní_okno.Checkbox_18_MOA.Checked = True Then
                    label_korekce_klikáním_stranová.Text = "Scope compensation: " & Math.Round(Val((stranová_korekce_klikani * (-1)) * 60), 2) & " MOA" & " (" & Math.Round(Val(((stranová_korekce_klikani * (-1)) * 60) * 8), 0) & " clicks) right"
                ElseIf Hlavní_okno.Checkbox_Jednotky_MRAD.Checked = True Then
                    label_korekce_klikáním_stranová.Text = "Scope compensation: " & Math.Round(Val((((stranová_korekce_klikani * (-1)) / (180 / Math.PI))) * 1000), 2) & " MRAD" & " (" & Math.Round(Val(((stranová_korekce_klikani * (-1)) / (180 / Math.PI)) * 1000), 2) * 10 & " clicks) right"
                End If

                label_korekce_prenasenim_stranová.Text = "Sight compensation: " & Math.Round(Val(stranová_korekce_prenaseni * (-1)), 1) & " cm right"

            ElseIf stranová_korekce_klikani > 0 Then

                If Hlavní_okno.Checkbox_14_MOA.Checked = True Then
                    label_korekce_klikáním_stranová.Text = "Scope compensation: " & Math.Round(Val(stranová_korekce_klikani * 60), 2) & " MOA" & " (" & Math.Round(Val((stranová_korekce_klikani * 60) * 4), 0) & " clicks) left"
                ElseIf Hlavní_okno.Checkbox_18_MOA.Checked = True Then
                    label_korekce_klikáním_stranová.Text = "Scope compensation: " & Math.Round(Val(stranová_korekce_klikani * 60), 2) & " MOA" & " (" & Math.Round(Val((stranová_korekce_klikani * 60) * 8), 0) & " clicks) left"
                ElseIf Hlavní_okno.Checkbox_Jednotky_MRAD.Checked = True Then
                    label_korekce_klikáním_stranová.Text = "Scope compensation: " & Math.Round(Val(((stranová_korekce_klikani / (180 / Math.PI))) * 1000), 2) & " MRAD" & " (" & Math.Round(Val((stranová_korekce_klikani / (180 / Math.PI)) * 1000), 2) * 10 & " clicks) left"
                End If

                label_korekce_prenasenim_stranová.Text = "Sight compensation: " & Math.Round(Val(stranová_korekce_prenaseni), 1) & " cm left"

            Else
                label_korekce_prenasenim_stranová.Text = "Sight compensation: "
                label_korekce_klikáním_stranová.Text = "Scope compensation: "
            End If

            'Výšková korekce
            If výšková_korekce_klikani <> 0 Or výšková_korekce_klikani <> Nothing Then

                If Hlavní_okno.Checkbox_14_MOA.Checked = True Then
                    label_korekce_klikáním_výšková.Text = "Scope compensation: " & Math.Round(Val((výšková_korekce_klikani * (-1)) * 60), 2) & " MOA" & " (" & Math.Round(Val(((výšková_korekce_klikani * (-1)) * 60) * 4), 0) & " clicks)"
                ElseIf Hlavní_okno.Checkbox_18_MOA.Checked = True Then
                    label_korekce_klikáním_výšková.Text = "Scope compensation: " & Math.Round(Val((výšková_korekce_klikani * (-1)) * 60), 2) & " MOA" & " (" & Math.Round(Val(((výšková_korekce_klikani * (-1)) * 60) * 8), 0) & " clicks)"
                ElseIf Hlavní_okno.Checkbox_Jednotky_MRAD.Checked = True Then
                    label_korekce_klikáním_výšková.Text = "Scope compensation: " & Math.Round(Val((((výšková_korekce_klikani * (-1)) / (180 / Math.PI))) * 1000), 2) & " MRAD" & " (" & Math.Round(Val(((výšková_korekce_klikani * (-1)) / (180 / Math.PI)) * 1000), 2) * 10 & " clicks)"
                End If
                label_korekce_přenášením_výšková.Text = "Sight compensation: " & Math.Round(Val(výšková_korekce_prenaseni * (-1)), 1) & " cm"

            Else
                label_korekce_přenášením_výšková.Text = "Sight compensation: "
                label_korekce_klikáním_výšková.Text = "Scope compensation: "
            End If

        Else

            If stranová_korekce_klikani < 0 Then
                If Hlavní_okno.Checkbox_14_MOA.Checked = True Then
                    label_korekce_klikáním_stranová.Text = "Scope compensation: " & Math.Round(Val((stranová_korekce_klikani * (-1)) * 60), 2) & " MOA" & " (" & Math.Round(Val(((stranová_korekce_klikani * (-1)) * 60) * 4), 0) & " clicks) right"
                ElseIf Hlavní_okno.Checkbox_18_MOA.Checked = True Then
                    label_korekce_klikáním_stranová.Text = "Scope compensation: " & Math.Round(Val((stranová_korekce_klikani * (-1)) * 60), 2) & " MOA" & " (" & Math.Round(Val(((stranová_korekce_klikani * (-1)) * 60) * 8), 0) & " clicks) right"
                ElseIf Hlavní_okno.Checkbox_Jednotky_MRAD.Checked = True Then
                    label_korekce_klikáním_stranová.Text = "Scope compensation: " & Math.Round(Val((((stranová_korekce_klikani * (-1)) / (180 / Math.PI))) * 1000), 2) & " MRAD" & " (" & Math.Round(Val(((stranová_korekce_klikani * (-1)) / (180 / Math.PI)) * 1000), 2) * 10 & " clicks) right"
                End If

                label_korekce_prenasenim_stranová.Text = "Sight compensation: " & Math.Round(Val((stranová_korekce_prenaseni * (-1)) / 2.54), 1) & " in right"

            ElseIf stranová_korekce_klikani > 0 Then

                If Hlavní_okno.Checkbox_14_MOA.Checked = True Then
                    label_korekce_klikáním_stranová.Text = "Scope compensation: " & Math.Round(Val(stranová_korekce_klikani * 60), 2) & " MOA" & " (" & Math.Round(Val((stranová_korekce_klikani * 60) * 4), 0) & " clicks) left"
                ElseIf Hlavní_okno.Checkbox_18_MOA.Checked = True Then
                    label_korekce_klikáním_stranová.Text = "Scope compensation: " & Math.Round(Val(stranová_korekce_klikani * 60), 2) & " MOA" & " (" & Math.Round(Val((stranová_korekce_klikani * 60) * 8), 0) & " clicks) left"
                ElseIf Hlavní_okno.Checkbox_Jednotky_MRAD.Checked = True Then
                    label_korekce_klikáním_stranová.Text = "Scope compensation: " & Math.Round(Val(((stranová_korekce_klikani / (180 / Math.PI))) * 1000), 2) & " MRAD" & " (" & Math.Round(Val((stranová_korekce_klikani / (180 / Math.PI)) * 1000), 2) * 10 & " clicks) left"
                End If

                label_korekce_prenasenim_stranová.Text = "Sight compensation: " & Math.Round(Val(stranová_korekce_prenaseni / 2.54), 1) & " in left"

            Else
                label_korekce_prenasenim_stranová.Text = "Sight compensation: "
                label_korekce_klikáním_stranová.Text = "Scope compensation: "
            End If

            If výšková_korekce_klikani <> 0 Or výšková_korekce_klikani <> Nothing Then

                If Hlavní_okno.Checkbox_14_MOA.Checked = True Then
                    label_korekce_klikáním_výšková.Text = "Scope compensation: " & Math.Round(Val((výšková_korekce_klikani * (-1)) * 60), 2) & " MOA" & " (" & Math.Round(Val(((výšková_korekce_klikani * (-1)) * 60) * 4), 0) & " clicks)"
                ElseIf Hlavní_okno.Checkbox_18_MOA.Checked = True Then
                    label_korekce_klikáním_výšková.Text = "Scope compensation: " & Math.Round(Val((výšková_korekce_klikani * (-1)) * 60), 2) & " MOA" & " (" & Math.Round(Val(((výšková_korekce_klikani * (-1)) * 60) * 8), 0) & " clicks)"
                ElseIf Hlavní_okno.Checkbox_Jednotky_MRAD.Checked = True Then
                    label_korekce_klikáním_výšková.Text = "Scope compensation: " & Math.Round(Val((((výšková_korekce_klikani * (-1)) / (180 / Math.PI))) * 1000), 2) & " MRAD" & " (" & Math.Round(Val(((výšková_korekce_klikani * (-1)) / (180 / Math.PI)) * 1000), 2) * 10 & " clicks)"
                End If
                label_korekce_přenášením_výšková.Text = "Sight compensation: " & Math.Round(Val((výšková_korekce_prenaseni * (-1)) / 2.54), 1) & " in"

            Else
                label_korekce_přenášením_výšková.Text = "Sight compensation: "
                label_korekce_klikáním_výšková.Text = "Scope compensation: "
            End If
        End If

    End Sub

    Private Sub vypocet_a_zapis_coriolisova_efektu()

        'Zaporna hodnota u vyky znamena POKLES strely
        'Zaporna hodnota u stranove odchylky znamena odchylku strely smerem DOLEVA

        Dim uhel_alfa As Decimal = 0
        Dim sin_uhel_alfa As Decimal = 0
        Dim omega As Double = 0.00007272
        Dim ustova_rychlost_coriolis As Decimal = ustova_rychlost * 0.3048
        Dim doba_pohybu_coriolis As Decimal = My.Settings.doba_pohybu

        Dim slozka_rychlosti As Decimal = 0

        If textbox_zemepisna_sirka.Text = "40 (USA)" Then
            uhel_alfa = 40
        Else
            Try
                textbox_zemepisna_sirka.Text = textbox_zemepisna_sirka.Text.Replace(".", ",")
                uhel_alfa = textbox_zemepisna_sirka.Text
                If uhel_alfa > 90 Or uhel_alfa < 0 Then
                    chyba = True
                    MsgBox("Wrong or missing data about latitude." & vbNewLine & "Tip: Latitude cannot be greater than 90 degrees or less than 0 degrees.", MsgBoxStyle.Exclamation)
                End If
            Catch ex As Exception
                chyba = True
                MsgBox("Wrong or missing data about latitude." & vbNewLine & "Tip: Latitude cannot be greater than 90 degrees or less than 0 degrees.", MsgBoxStyle.Exclamation)
            End Try
        End If

        If chyba = False Then

            sin_uhel_alfa = Math.Sin(uhel_alfa / (180 / Math.PI))
            slozka_rychlosti = 0.70710678 * ustova_rychlost_coriolis

            If radiobutton_N.Checked = True Or radiobutton_S.Checked = True Then
                coriolisuv_efekt_v_metrech_stranovy = 0.5 * (2 * ustova_rychlost_coriolis * omega * sin_uhel_alfa) * (doba_pohybu_coriolis ^ 2)
            ElseIf radiobutton_NE.Checked = True Or radiobutton_SE.Checked = True Then
                coriolisuv_efekt_v_metrech_vyskovy = 0.5 * (2 * slozka_rychlosti * omega) * (doba_pohybu_coriolis ^ 2)
                coriolisuv_efekt_v_metrech_stranovy = 0.5 * (2 * slozka_rychlosti * omega * sin_uhel_alfa) * (doba_pohybu_coriolis ^ 2)
            ElseIf radiobutton_NW.Checked = True Or radiobutton_SW.Checked = True Then
                coriolisuv_efekt_v_metrech_vyskovy = (0.5 * (2 * slozka_rychlosti * omega) * (doba_pohybu_coriolis ^ 2)) * (-1)
                coriolisuv_efekt_v_metrech_stranovy = 0.5 * (2 * slozka_rychlosti * omega * sin_uhel_alfa) * (doba_pohybu_coriolis ^ 2)
            ElseIf radiobutton_E.Checked = True Then
                coriolisuv_efekt_v_metrech_vyskovy = 0.5 * (2 * ustova_rychlost_coriolis * omega) * (doba_pohybu_coriolis ^ 2)
            ElseIf radiobutton_W.Checked = True Then
                coriolisuv_efekt_v_metrech_vyskovy = (0.5 * (2 * ustova_rychlost_coriolis * omega) * (doba_pohybu_coriolis ^ 2)) * (-1)
            End If

            If combobox_polokoule.Text = "Southern" Then
                coriolisuv_efekt_v_metrech_stranovy = coriolisuv_efekt_v_metrech_stranovy * (-1)
            End If


        End If

    End Sub

    Private Sub vypocet_a_zapis_derivace()

        'Zaporna hodnota derivace znamena odchylku smerem DOLEVA

        Dim doba_pohybu As Decimal = My.Settings.doba_pohybu


        derivace_v_metrech = (1.25 * (koeficient_Sg + 1.2) * (doba_pohybu ^ 1.83)) * 0.0254

        If combobox_smer_drazek.Text = "Left-turn" Then
            derivace_v_metrech = derivace_v_metrech * (-1)
        End If

    End Sub

    Private Sub zápis_proměnných_stabilizace()

        'Veškerá data budou v angloamerických jednotkách a hmotnost je vždy v grainech

        Dim chyba_ustova_rychlost As Boolean = False
        Dim chyba_hmotnost_strely As Boolean = False
        Dim chyba_stoupani_drazek As Boolean = False
        Dim chyba_delka_strely As Boolean = False
        Dim chyba_prumer_strely As Boolean = False

        chyba = False

        Textbox_Počáteční_rychlost.Text = Textbox_Počáteční_rychlost.Text.Replace(".", ",")
        Textbox_hmotnost.Text = Textbox_hmotnost.Text.Replace(".", ",")
        textbox_stoupání_drážek.Text = textbox_stoupání_drážek.Text.Replace(".", ",")
        textbox_délka_střely.Text = textbox_délka_střely.Text.Replace(".", ",")
        textbox_průměr_střely.Text = textbox_průměr_střely.Text.Replace(".", ",")

        Try
            If combobox_počáteční_rychlost.Text = "m/s" Then
                ustova_rychlost = Textbox_Počáteční_rychlost.Text / 0.3048
            Else
                ustova_rychlost = Textbox_Počáteční_rychlost.Text
            End If
        Catch ex As Exception
            chyba_ustova_rychlost = True
            chyba = True
        End Try

        Try
            If combobox_hmotnost_střely.Text = "g" Then
                hmotnost_strely = Textbox_hmotnost.Text / 0.06479891
            Else
                hmotnost_strely = Textbox_hmotnost.Text
            End If
        Catch ex As Exception
            chyba_hmotnost_strely = True
            chyba = True
        End Try

        Try
            If combobox_stoupání_drážek.Text = "mm" Then
                stoupani_drazek = textbox_stoupání_drážek.Text * 0.0393700787
            Else
                stoupani_drazek = textbox_stoupání_drážek.Text
            End If
        Catch ex As Exception
            chyba_stoupani_drazek = True
            chyba = True
        End Try

        Try
            If combobox_délka_střely.Text = "mm" Then
                delka_strely = textbox_délka_střely.Text * 0.0393700787
            Else
                delka_strely = textbox_délka_střely.Text
            End If
        Catch ex As Exception
            chyba_delka_strely = True
            chyba = True
        End Try

        Try
            If combobox_průměr_střely.Text = "mm" Then
                prumer_strely = textbox_průměr_střely.Text * 0.0393700787
            Else
                prumer_strely = textbox_průměr_střely.Text
            End If
        Catch ex As Exception
            chyba_prumer_strely = True
            chyba = True
        End Try

        If chyba = False Then

            If Textbox_Počáteční_rychlost.Text = Nothing Then
                chyba = True
                chyba_ustova_rychlost = True
            Else
                If Textbox_Počáteční_rychlost.Text = 0 Or ustova_rychlost > 4921 Or ustova_rychlost < 0 Then
                    chyba = True
                    chyba_ustova_rychlost = True
                End If
            End If

            If Textbox_hmotnost.Text = Nothing Then
                chyba = True
                chyba_hmotnost_strely = True
            Else
                If Textbox_hmotnost.Text = 0 Or Textbox_hmotnost.Text < 0 Then
                    chyba = True
                    chyba_hmotnost_strely = True
                End If
            End If

            If textbox_stoupání_drážek.Text = Nothing Then
                chyba = True
                chyba_stoupani_drazek = True
            Else
                If textbox_stoupání_drážek.Text = 0 Or textbox_stoupání_drážek.Text < 0 Then
                    chyba = True
                    chyba_stoupani_drazek = True
                End If
            End If

            If textbox_délka_střely.Text = Nothing Then
                chyba = True
                chyba_delka_strely = True
            Else
                If textbox_délka_střely.Text = 0 Or textbox_délka_střely.Text < 0 Then
                    chyba = True
                    chyba_delka_strely = True
                End If
            End If

            If textbox_průměr_střely.Text = Nothing Then
                chyba = True
                chyba_prumer_strely = True
            Else
                If textbox_průměr_střely.Text = 0 Or textbox_průměr_střely.Text < 0 Then
                    chyba = True
                    chyba_prumer_strely = True
                End If
            End If
        End If


        If chyba_ustova_rychlost = True Then
            MsgBox("Wrong or missing data about muzzle velocity." & vbNewLine & "Tip: The maximum possible value of the muzzle velocity is limited to 1500 m/s = 4921 fps." & vbNewLine & "Tip: The muzzle velocity cannot be less than or equal to zero.", MsgBoxStyle.Exclamation)
        ElseIf chyba_hmotnost_strely = True Then
            MsgBox("Wrong or missing data about bullet weight." & vbNewLine & "Tip: The bullet weight cannot be less than or equal to zero.", MsgBoxStyle.Exclamation)
        ElseIf chyba_stoupani_drazek = True Then
            MsgBox("Wron or missing data about rifling twist." & vbNewLine & "Tip: The rifling twist cannot be less than or equal to zero.", MsgBoxStyle.Exclamation)
        ElseIf chyba_delka_strely = True Then
            MsgBox("Wrong or missing data about bullet lenght." & vbNewLine & "Tip: The bullet lenght cannot be less than or equal to zero.", MsgBoxStyle.Exclamation)
        ElseIf chyba_prumer_strely = True Then
            MsgBox("Wrong or missing data about bullet diameter." & vbNewLine & "Tip: The bullet diameter cannot be less than or equal to zero.", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub vypocet_stabilizace_střely()
        Dim čitatel As Double = 0
        Dim jmenovatel As Double = 0

        Dim pomer_rychlosti As Double = 0
        Dim pomer_hustot As Double = 0


        pomer_rychlosti = (ustova_rychlost / 2800) ^ (1 / 3)
        pomer_hustot = 1.22495 / My.Settings.hustota_vzduchu

        čitatel = 30 * hmotnost_strely * pomer_rychlosti * pomer_hustot

        jmenovatel = (stoupani_drazek ^ 2) * delka_strely * (1 + ((delka_strely / prumer_strely) ^ 2))

        koeficient_Sg = čitatel / jmenovatel

        label_koeficient_Sg.Text = Math.Round(Val(koeficient_Sg), 2)

        If koeficient_Sg <= 1.2 Or koeficient_Sg >= 3.5 Then
            label_koeficient_Sg.ForeColor = Color.Red
        ElseIf koeficient_Sg > 1.2 And koeficient_Sg <= 1.4 Or koeficient_Sg > 2.5 And koeficient_Sg < 3.5 Then
            label_koeficient_Sg.ForeColor = Color.Yellow
        Else
            label_koeficient_Sg.ForeColor = Color.Black
        End If
    End Sub

    Private Sub vynulovat()

        koeficient_Sg = 0
        derivace_v_metrech = 0
        coriolisuv_efekt_v_metrech_vyskovy = 0
        coriolisuv_efekt_v_metrech_stranovy = 0
        label_korekce_klikáním_stranová.Text = "Scope compensation: "
        label_korekce_prenasenim_stranová.Text = "Sight compensation: "
        label_korekce_přenášením_výšková.Text = "Sight compensation: "
        label_korekce_klikáním_výšková.Text = "Scope compensation: "
        chyba = False
        My.Settings.korekce_stranova_derivace_coriolis = 0

    End Sub

    Private Sub checkbox_spocitat_derivaci_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_spocitat_derivaci.CheckedChanged
        If checkbox_spocitat_derivaci.Checked = True Then
            groupbox_derivace.Enabled = True
            label_vzdálenost_cíle.Text = "Target distance: " & Hlavní_okno.Textbox_Vzdálenost_cíle.Text & " " & Hlavní_okno.combobox_vzdálenost_cíle.Text
        Else
            label_vzdálenost_cíle.Text = "Target distance: "
            groupbox_derivace.Enabled = False
        End If
    End Sub

    Private Sub checkbox_spocitat_coriolisuv_efekt_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_spocitat_coriolisuv_efekt.CheckedChanged
        If checkbox_spocitat_coriolisuv_efekt.Checked = True Then
            groupbox_coriolisuv_efekt.Enabled = True
            button_spočítej_stabilizaci.Enabled = True
        Else
            groupbox_coriolisuv_efekt.Enabled = False
        End If
    End Sub

    Private Sub radiobutton_N_CheckedChanged(sender As Object, e As EventArgs) Handles radiobutton_N.CheckedChanged
        If radiobutton_N.Checked = True Then
            radiobutton_NE.Checked = False
            radiobutton_E.Checked = False
            radiobutton_SE.Checked = False
            radiobutton_S.Checked = False
            radiobutton_SW.Checked = False
            radiobutton_W.Checked = False
            radiobutton_NW.Checked = False
        End If
    End Sub

    Private Sub radiobutton_NE_CheckedChanged(sender As Object, e As EventArgs) Handles radiobutton_NE.CheckedChanged
        If radiobutton_NE.Checked = True Then
            radiobutton_N.Checked = False
            radiobutton_E.Checked = False
            radiobutton_SE.Checked = False
            radiobutton_S.Checked = False
            radiobutton_SW.Checked = False
            radiobutton_W.Checked = False
            radiobutton_NW.Checked = False
        End If
    End Sub

    Private Sub radiobutton_E_CheckedChanged(sender As Object, e As EventArgs) Handles radiobutton_E.CheckedChanged
        If radiobutton_E.Checked = True Then
            radiobutton_NE.Checked = False
            radiobutton_N.Checked = False
            radiobutton_SE.Checked = False
            radiobutton_S.Checked = False
            radiobutton_SW.Checked = False
            radiobutton_W.Checked = False
            radiobutton_NW.Checked = False
            textbox_zemepisna_sirka.Enabled = False
        Else
            textbox_zemepisna_sirka.Enabled = True
        End If
    End Sub

    Private Sub radiobutton_SE_CheckedChanged(sender As Object, e As EventArgs) Handles radiobutton_SE.CheckedChanged
        If radiobutton_SE.Checked = True Then
            radiobutton_NE.Checked = False
            radiobutton_E.Checked = False
            radiobutton_N.Checked = False
            radiobutton_S.Checked = False
            radiobutton_SW.Checked = False
            radiobutton_W.Checked = False
            radiobutton_NW.Checked = False
        End If
    End Sub

    Private Sub radiobutton_S_CheckedChanged(sender As Object, e As EventArgs) Handles radiobutton_S.CheckedChanged
        If radiobutton_S.Checked = True Then
            radiobutton_NE.Checked = False
            radiobutton_E.Checked = False
            radiobutton_SE.Checked = False
            radiobutton_N.Checked = False
            radiobutton_SW.Checked = False
            radiobutton_W.Checked = False
            radiobutton_NW.Checked = False
        End If
    End Sub

    Private Sub radiobutton_SW_CheckedChanged(sender As Object, e As EventArgs) Handles radiobutton_SW.CheckedChanged
        If radiobutton_SW.Checked = True Then
            radiobutton_NE.Checked = False
            radiobutton_E.Checked = False
            radiobutton_SE.Checked = False
            radiobutton_S.Checked = False
            radiobutton_N.Checked = False
            radiobutton_W.Checked = False
            radiobutton_NW.Checked = False
        End If
    End Sub

    Private Sub radiobutton_W_CheckedChanged(sender As Object, e As EventArgs) Handles radiobutton_W.CheckedChanged
        If radiobutton_W.Checked = True Then
            radiobutton_NE.Checked = False
            radiobutton_E.Checked = False
            radiobutton_SE.Checked = False
            radiobutton_S.Checked = False
            radiobutton_SW.Checked = False
            radiobutton_S.Checked = False
            radiobutton_NW.Checked = False
            textbox_zemepisna_sirka.Enabled = False
        Else
            textbox_zemepisna_sirka.Enabled = True
        End If
    End Sub

    Private Sub radiobutton_NW_CheckedChanged(sender As Object, e As EventArgs) Handles radiobutton_NW.CheckedChanged
        If radiobutton_NW.Checked = True Then
            radiobutton_NE.Checked = False
            radiobutton_E.Checked = False
            radiobutton_SE.Checked = False
            radiobutton_S.Checked = False
            radiobutton_SW.Checked = False
            radiobutton_W.Checked = False
            radiobutton_N.Checked = False
        End If
    End Sub

    Private Sub checkbox_nacist_stranovou_odchylku_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_nacist_odchylky.CheckedChanged
        If checkbox_nacist_odchylky.Checked = True Then
            My.Settings.korekce_stranova_derivace_coriolis = coriolisuv_efekt_v_metrech_stranovy + derivace_v_metrech
            My.Settings.korekce_vyskova_coriolis = coriolisuv_efekt_v_metrech_vyskovy
        Else
            My.Settings.korekce_stranova_derivace_coriolis = 0
            My.Settings.korekce_vyskova_coriolis = 0
        End If
    End Sub

    Private Sub Derivace_střely_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Hlavní_okno.Enabled = True
        ulozeni_pameti()
    End Sub

    Private Sub ulozeni_pameti()
        My.Settings.pamet_derivace_strely_combobox_pocatecni_rychlost = combobox_počáteční_rychlost.Text
        My.Settings.pamet_derivace_strely_combobox_hmotnost_strely = combobox_hmotnost_střely.Text
        My.Settings.pamet_derivace_strely_combobox_stoupani_drazek = combobox_stoupání_drážek.Text
        My.Settings.pamet_derivace_strely_combobox_delka_strely = combobox_délka_střely.Text
        My.Settings.pamet_derivace_strely_combobox_prumer_strely = combobox_průměr_střely.Text
        My.Settings.pamet_derivace_strely_combobox_polokoule = combobox_polokoule.Text
        My.Settings.pamet_derivace_strely_textbox_zemepisna_sirka = textbox_zemepisna_sirka.Text
        My.Settings.pamet_derivace_strely_combobox_smer_drazek = combobox_smer_drazek.Text
        My.Settings.Save()
    End Sub
    Private Sub vyvolani_pameti()
        If My.Settings.pamet_derivace_strely_combobox_pocatecni_rychlost <> Nothing Then
            combobox_počáteční_rychlost.Text = My.Settings.pamet_derivace_strely_combobox_pocatecni_rychlost
            combobox_hmotnost_střely.Text = My.Settings.pamet_derivace_strely_combobox_hmotnost_strely
            combobox_stoupání_drážek.Text = My.Settings.pamet_derivace_strely_combobox_stoupani_drazek
            combobox_délka_střely.Text = My.Settings.pamet_derivace_strely_combobox_delka_strely
            combobox_průměr_střely.Text = My.Settings.pamet_derivace_strely_combobox_prumer_strely
            combobox_polokoule.Text = My.Settings.pamet_derivace_strely_combobox_polokoule
            textbox_zemepisna_sirka.Text = My.Settings.pamet_derivace_strely_textbox_zemepisna_sirka
            combobox_smer_drazek.Text = My.Settings.pamet_derivace_strely_combobox_smer_drazek
        Else
            combobox_počáteční_rychlost.Text = "m/s"
            combobox_hmotnost_střely.Text = "grs"
            combobox_stoupání_drážek.Text = "mm"
            combobox_délka_střely.Text = "mm"
            combobox_průměr_střely.Text = "mm"
            combobox_polokoule.Text = "Northern"
            textbox_zemepisna_sirka.Text = "40 (USA)"
            combobox_smer_drazek.Text = "Right-turn"
        End If
    End Sub
End Class