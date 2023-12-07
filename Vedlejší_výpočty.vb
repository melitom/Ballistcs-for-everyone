Imports System.Math
Public Class Vedlejší_výpočty
    Dim původní_úsťová_rychlost As Decimal = 0
    Dim výsledná_úsťová_rychlost As Double = 0
    Dim délka_původní_hlavně As Decimal = 0
    Dim délka_nové_hlavně As Decimal = 0
    Dim hmotnost_střely As Decimal = 0
    Dim hmotnost_prachové_slože As Decimal = 0
    Dim délka_náboje As Decimal = 0
    Dim délka_nábojnice As Decimal = 0
    Dim objem_nábojnice As Double = 0
    Dim průměr_střely As Decimal = 0
    Dim délka_střely As Decimal = 0

    Dim rychlost_cíle As Decimal = 0
    Dim doba_pohybu_střely As Decimal = 0
    Dim úhel_pohybu_cíle As Decimal = 0
    Dim vzdálenost_cíle As Decimal = 0

    Dim chyba As Boolean = False

    Private Sub Vedlejší_výpočty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        vyvolani_pameti()
        combobox_doba_pohybu_střely.Text = "sec"
        combobox_úhel_pohybu_cíle.Text = "deg"

        If Hlavní_okno.Textbox_Počáteční_rychlost.Text <> Nothing And textbox_původní_úsťová_rychlost.Text = Nothing Then
            textbox_původní_úsťová_rychlost.Text = Hlavní_okno.Textbox_Počáteční_rychlost.Text
            combobox_původní_úsťová_rychlost.Text = Hlavní_okno.combobox_počáteční_rychlost.Text
        End If

        If My.Settings.doba_pohybu <> 0 And textbox_doba_pohybu_střely.Text = "" Then
            textbox_doba_pohybu_střely.Text = My.Settings.doba_pohybu
        End If

        If Hlavní_okno.Textbox_Vzdálenost_cíle.Text <> Nothing And textbox_vzdálenost_cíle.Text = Nothing Then
            textbox_vzdálenost_cíle.Text = Hlavní_okno.Textbox_Vzdálenost_cíle.Text
            combobox_vzdálenost_cíle.Text = Hlavní_okno.combobox_vzdálenost_cíle.Text
        End If

        textbox_úhel_pohybu_cíle.Text = "90"

    End Sub

    Private Sub Vedlejší_výpočty_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        vyvolani_pameti()

        If Me.Visible = True Then
            If Hlavní_okno.Textbox_Počáteční_rychlost.Text <> Nothing And textbox_původní_úsťová_rychlost.Text = Nothing Then
                textbox_původní_úsťová_rychlost.Text = Hlavní_okno.Textbox_Počáteční_rychlost.Text
                combobox_původní_úsťová_rychlost.Text = Hlavní_okno.combobox_počáteční_rychlost.Text
            End If

            If My.Settings.doba_pohybu <> 0 And textbox_doba_pohybu_střely.Text = "" Then
                textbox_doba_pohybu_střely.Text = My.Settings.doba_pohybu
            End If

            If Hlavní_okno.Textbox_Vzdálenost_cíle.Text <> Nothing And textbox_vzdálenost_cíle.Text = Nothing Then
                textbox_vzdálenost_cíle.Text = Hlavní_okno.Textbox_Vzdálenost_cíle.Text
                combobox_vzdálenost_cíle.Text = Hlavní_okno.combobox_vzdálenost_cíle.Text
            End If
        End If
    End Sub

    Private Sub Vedlejší_výpočty_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ulozeni_pameti()
    End Sub
    Private Sub výpočet_předsazení()
        Dim reálná_rychlost_cíle As Double = 0
        Dim předsazení_v_metrech As Double = 0
        Dim předsazení_v_úhlových_jednotkách As Double = 0

        reálná_rychlost_cíle = rychlost_cíle * Sin(úhel_pohybu_cíle * 0.0174532925)
        předsazení_v_metrech = reálná_rychlost_cíle * doba_pohybu_střely

        'radiány
        předsazení_v_úhlových_jednotkách = Atan(předsazení_v_metrech / vzdálenost_cíle)

        'zápis výsledků
        If předsazení_v_metrech > 1 Then

            If Hlavní_okno.Checkbox_Jednotky_MRAD.Checked = True Then
                label_předsazení_cíle.Text = "Target lead: " & Round(Val(předsazení_v_metrech), 1) & " m" & "  (" & Round(Val(předsazení_v_úhlových_jednotkách * 1000), 1) & " MRAD)"
            ElseIf Hlavní_okno.Checkbox_jednotky_MOA.Checked = True Then
                label_předsazení_cíle.Text = "Target lead: " & Round(Val(předsazení_v_metrech), 1) & " m" & "  (" & Round(Val(předsazení_v_úhlových_jednotkách * 3437.74677), 1) & " MOA)"
            Else
                label_předsazení_cíle.Text = "Target lead: " & Round(Val(předsazení_v_metrech), 1) & " m"
            End If
        Else
            If Hlavní_okno.Checkbox_Jednotky_MRAD.Checked = True Then
                label_předsazení_cíle.Text = "Target lead: " & Round(Val(předsazení_v_metrech * 100), 0) & " cm" & "  (" & Round(Val(předsazení_v_úhlových_jednotkách * 1000), 1) & " MRAD)"
            ElseIf Hlavní_okno.Checkbox_jednotky_MOA.Checked = True Then
                label_předsazení_cíle.Text = "Target lead: " & Round(Val(předsazení_v_metrech * 100), 0) & " cm" & "  (" & Round(Val(předsazení_v_úhlových_jednotkách * 3437.74677), 1) & " MOA)"
            Else
                label_předsazení_cíle.Text = "Target lead: " & Round(Val(předsazení_v_metrech * 100), 0) & " cm"
            End If
        End If


    End Sub
    Private Sub zápis_proměnných_předsazení()

        Dim chyba_rychlost_cíle As Boolean = False
        Dim chyba_doba_pohybu As Boolean = False
        Dim chyba_úhel_pohybu_cíle As Boolean = False
        Dim chyba_vzdálenost_cíle As Boolean = False

        textbox_rychlost_cíle.Text = textbox_rychlost_cíle.Text.Replace(".", ",")
        textbox_doba_pohybu_střely.Text = textbox_doba_pohybu_střely.Text.Replace(".", ",")
        textbox_úhel_pohybu_cíle.Text = textbox_úhel_pohybu_cíle.Text.Replace(".", ",")
        textbox_vzdálenost_cíle.Text = textbox_vzdálenost_cíle.Text.Replace(".", ",")

        Try

            If combobox_rychlost_cíle.Text = "km/h" Then
                rychlost_cíle = textbox_rychlost_cíle.Text / 3.6
            ElseIf combobox_rychlost_cíle.Text = "mph" Then
                rychlost_cíle = textbox_rychlost_cíle.Text * 0.44704
            ElseIf combobox_rychlost_cíle.Text = "m/s" Then
                rychlost_cíle = textbox_rychlost_cíle.Text
            ElseIf combobox_rychlost_cíle.Text = "fps" Then
                rychlost_cíle = textbox_rychlost_cíle.Text * 0.3048
            End If

            If rychlost_cíle > 100 Or rychlost_cíle < 0 Then
                chyba = True
                chyba_rychlost_cíle = True
            End If
        Catch ex As Exception
            chyba = True
            chyba_rychlost_cíle = True
        End Try

        Try
            If combobox_vzdálenost_cíle.Text = "m" Then
                vzdálenost_cíle = textbox_vzdálenost_cíle.Text
            ElseIf combobox_vzdálenost_cíle.Text = "ft" Then
                vzdálenost_cíle = textbox_vzdálenost_cíle.Text * 0.3048
            Else
                vzdálenost_cíle = textbox_vzdálenost_cíle.Text * 0.9144
            End If

            If vzdálenost_cíle <= 0 Then
                chyba = True
                chyba_vzdálenost_cíle = True
            End If
        Catch ex As Exception
            chyba = True
            chyba_vzdálenost_cíle = True
        End Try

        Try
            doba_pohybu_střely = textbox_doba_pohybu_střely.Text

            If doba_pohybu_střely <= 0 Then
                chyba = True
                chyba_doba_pohybu = True
            End If
        Catch ex As Exception
            chyba = True
            chyba_doba_pohybu = True
        End Try

        Try
            úhel_pohybu_cíle = textbox_úhel_pohybu_cíle.Text

            If úhel_pohybu_cíle > 90 Or úhel_pohybu_cíle < 0 Then
                chyba = True
                chyba_úhel_pohybu_cíle = True
            End If
        Catch ex As Exception
            chyba = True
            chyba_úhel_pohybu_cíle = True
        End Try

        If chyba_rychlost_cíle = True Then
            MsgBox("Wrong or missing data about target speed." & vbNewLine & "Tip: The target speed cannot be less than zero or greater than 100 m/s = 223mph = 360 km/h = 328fps.", MsgBoxStyle.Exclamation)
        ElseIf chyba_doba_pohybu = True Then
            MsgBox("Wrong or missing data about bullet time of flight." & vbNewLine & "Tip: The bullet time of flight cannot be less than or equal to zero.", MsgBoxStyle.Exclamation)
        ElseIf chyba_úhel_pohybu_cíle = True Then
            MsgBox("Wrong or missing data about angle of target movement." & vbNewLine & "Tip: The angle of target movement cannot be less than zero, or greater than 90 degrees.", MsgBoxStyle.Exclamation)
        ElseIf chyba_vzdálenost_cíle = True Then
            MsgBox("Wrong or missing data about target distance." & vbNewLine & "Tip: The target distance cannot be less than or equal to zero.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub výpočet_aproximace_úsťové_rychlosti()
        'POWLEY 3
        'VŠECHNY VELIČINY JSOU V IMPERIÁLNÍM SYSTÉMU !!!

        Dim reálná_délka_původní_hlavně As Decimal = 0
        Dim reálná_délka_nové_hlavně As Decimal = 0

        Dim objem_původní_hlavně As Double = 0
        Dim objem_nové_hlavně As Double = 0

        Dim expanzní_poměr_původní_hlavně As Double = 0
        Dim expanzní_poměr_nové_hlavně As Double = 0

        Dim čitatel As Double = 0
        Dim jmenovatel As Double = 0


        If radiobutton_puška.Checked = True Then
            reálná_délka_původní_hlavně = délka_původní_hlavně - délka_náboje + délka_střely
            reálná_délka_nové_hlavně = délka_nové_hlavně - délka_náboje + délka_střely

        ElseIf radiobutton_revolver.Checked = True Then
            reálná_délka_původní_hlavně = délka_původní_hlavně + 0.1 + (délka_náboje - (délka_nábojnice - 0.2))
            reálná_délka_nové_hlavně = délka_nové_hlavně + 0.1 + (délka_náboje - (délka_nábojnice - 0.2))

        Else
            reálná_délka_původní_hlavně = délka_původní_hlavně - (délka_náboje - (délka_nábojnice - 0.2))
            reálná_délka_nové_hlavně = délka_nové_hlavně - (délka_náboje - (délka_nábojnice - 0.2))
        End If


        objem_původní_hlavně = PI * ((průměr_střely * 0.5) ^ 2) * reálná_délka_původní_hlavně
        objem_nové_hlavně = PI * ((průměr_střely * 0.5) ^ 2) * reálná_délka_nové_hlavně

        expanzní_poměr_původní_hlavně = (objem_nábojnice + objem_původní_hlavně) / objem_nábojnice
        expanzní_poměr_nové_hlavně = (objem_nábojnice + objem_nové_hlavně) / objem_nábojnice

        čitatel = 1 - (1 / (expanzní_poměr_nové_hlavně ^ 0.25))
        jmenovatel = 1 - (1 / (expanzní_poměr_původní_hlavně ^ 0.25))

        výsledná_úsťová_rychlost = původní_úsťová_rychlost * ((čitatel / jmenovatel) ^ 0.5)


        'zápis výsledku
        If Hlavní_okno.checkbox_metricke_jednotky.Checked = True Then
            label_úsťová_rychlost.Text = "Muzzle velocity: " & Round(Val(výsledná_úsťová_rychlost * 0.3048), 0) & " m/s"
        Else
            label_úsťová_rychlost.Text = "Muzzle velocity: " & Round(Val(výsledná_úsťová_rychlost), 0) & " fps"
        End If

    End Sub

    Private Sub zápis_proměnných_aproximace_úsťové_rychlosti()
        'Všechny jednotky budou převedeny a uloženy v IMPERIÁLNÍ SOUSTAVĚ (hmotnost v grainech, délka v palcích)

        Dim chyba_původní_úsťová_rychlost As Boolean = False
        Dim chyba_délka_původní_hlavně As Boolean = False
        Dim chyba_délka_nové_hlavně As Boolean = False
        Dim chyba_délka_náboje As Boolean = False
        Dim chyba_délka_nábojnice As Boolean = False
        Dim chyba_průměr_střely As Boolean = False
        Dim chyba_délka_střely As Boolean = False
        Dim chyba_objem_nábojnice As Boolean = False

        chyba = False

        Try
            textbox_původní_úsťová_rychlost.Text = textbox_původní_úsťová_rychlost.Text.Replace(".", ",")
            textbox_délka_původní_hlavně.Text = textbox_délka_původní_hlavně.Text.Replace(".", ",")
            textbox_délka_nové_hlavně.Text = textbox_délka_nové_hlavně.Text.Replace(".", ",")
            textbox_délka_náboje.Text = textbox_délka_náboje.Text.Replace(".", ",")
            textbox_délka_nábojnice.Text = textbox_délka_nábojnice.Text.Replace(".", ",")
            textbox_průměr_střely.Text = textbox_průměr_střely.Text.Replace(".", ",")
            textbox_délka_střely.Text = textbox_délka_střely.Text.Replace(".", ",")
        Catch ex As Exception
        End Try

        'úsťová rychlost
        Try
            If combobox_původní_úsťová_rychlost.Text = "fps" Then
                původní_úsťová_rychlost = textbox_původní_úsťová_rychlost.Text
            Else
                původní_úsťová_rychlost = textbox_původní_úsťová_rychlost.Text / 0.3048
            End If

            If původní_úsťová_rychlost > 4921 Or původní_úsťová_rychlost <= 0 Then
                chyba = True
                chyba_původní_úsťová_rychlost = True
            End If
        Catch ex As Exception
            chyba = True
            chyba_původní_úsťová_rychlost = True
        End Try

        'délka náboje
        Try
            If combobox_délka_náboje.Text = "mm" Then
                délka_náboje = textbox_délka_náboje.Text / 25.4
            Else
                délka_náboje = textbox_délka_náboje.Text
            End If

            If délka_náboje <= 0 Then
                chyba = True
                chyba_délka_náboje = True
            End If
        Catch ex As Exception
            chyba = True
            chyba_délka_náboje = True
        End Try

        'průměr střely
        Try
            If combobox_průměr_střely.Text = "mm" Then
                průměr_střely = textbox_průměr_střely.Text / 25.4
            Else
                průměr_střely = textbox_průměr_střely.Text
            End If

            If průměr_střely <= 0 Then
                chyba = True
                chyba_průměr_střely = True
            End If
        Catch ex As Exception
            chyba = True
            chyba_průměr_střely = True
        End Try

        'délka nábojnice
        Try
            If combobox_délka_nábojnice.Text = "mm" Then
                délka_nábojnice = textbox_délka_nábojnice.Text / 25.4
            Else
                délka_nábojnice = textbox_délka_nábojnice.Text
            End If

            If délka_nábojnice <= 0 Then
                chyba = True
                chyba_délka_nábojnice = True
            End If
        Catch ex As Exception
            chyba = True
            chyba_délka_nábojnice = True
        End Try

        'výpočet objemu nábojnice
        Try
            objem_nábojnice = PI * ((průměr_střely * 0.5) ^ 2) * délka_nábojnice * 0.85

            If objem_nábojnice <= 0 Then
                chyba = True
                chyba_objem_nábojnice = True
            End If
        Catch ex As Exception
            chyba = True
            chyba_objem_nábojnice = True
        End Try


        If radiobutton_puška.Checked = True Then

            Try
                If combobox_délka_původní_hlavně.Text = "cm" Then
                    délka_původní_hlavně = textbox_délka_původní_hlavně.Text / 2.54
                ElseIf combobox_délka_původní_hlavně.Text = "mm" Then
                    délka_původní_hlavně = textbox_délka_původní_hlavně.Text / 25.4
                Else
                    délka_původní_hlavně = textbox_délka_původní_hlavně.Text
                End If

                If délka_původní_hlavně > 60 Or délka_původní_hlavně <= 0 Then
                    chyba = True
                    chyba_délka_původní_hlavně = True
                End If
            Catch ex As Exception
                chyba = True
                chyba_délka_původní_hlavně = True
            End Try

            Try
                If combobox_délka_nové_hlavně.Text = "cm" Then
                    délka_nové_hlavně = textbox_délka_nové_hlavně.Text / 2.54
                ElseIf combobox_délka_nové_hlavně.Text = "mm" Then
                    délka_nové_hlavně = textbox_délka_nové_hlavně.Text / 25.4
                Else
                    délka_nové_hlavně = textbox_délka_nové_hlavně.Text
                End If

                If délka_nové_hlavně > 60 Or délka_nové_hlavně <= 0 Then
                    chyba = True
                    chyba_délka_nové_hlavně = True
                End If
            Catch ex As Exception
                chyba = True
                chyba_délka_nové_hlavně = True
            End Try

            Try
                If combobox_délka_střely.Text = "mm" Then
                    délka_střely = textbox_délka_střely.Text / 25.4
                Else
                    délka_střely = textbox_délka_střely.Text
                End If

                If délka_střely <= 0 Then
                    chyba = True
                    chyba_délka_střely = True
                End If
            Catch ex As Exception
                chyba = True
                chyba_délka_střely = True
            End Try

        Else

            Try
                If combobox_délka_původní_hlavně.Text = "cm" Then
                    délka_původní_hlavně = textbox_délka_původní_hlavně.Text / 2.54
                ElseIf combobox_délka_původní_hlavně.Text = "mm" Then
                    délka_původní_hlavně = textbox_délka_původní_hlavně.Text / 25.4
                Else
                    délka_původní_hlavně = textbox_délka_původní_hlavně.Text
                End If

                If délka_původní_hlavně > 18 Or délka_původní_hlavně <= 0 Then
                    chyba = True
                    chyba_délka_původní_hlavně = True
                End If
            Catch ex As Exception
                chyba = True
                chyba_délka_původní_hlavně = True
            End Try

            Try
                If combobox_délka_nové_hlavně.Text = "cm" Then
                    délka_nové_hlavně = textbox_délka_nové_hlavně.Text / 2.54
                ElseIf combobox_délka_nové_hlavně.Text = "mm" Then
                    délka_nové_hlavně = textbox_délka_nové_hlavně.Text / 25.4
                Else
                    délka_nové_hlavně = textbox_délka_nové_hlavně.Text
                End If

                If délka_nové_hlavně > 18 Or délka_nové_hlavně <= 0 Then
                    chyba = True
                    chyba_délka_nové_hlavně = True
                End If
            Catch ex As Exception
                chyba = True
                chyba_délka_nové_hlavně = True
            End Try
        End If

        If chyba_původní_úsťová_rychlost = True Then
            MsgBox("Wrnog or missing data about muzzle velocity." & vbNewLine & "Tip: The muzzle velocity cannot be less than or equal to zero.", MsgBoxStyle.Exclamation)
        ElseIf chyba_délka_původní_hlavně = True Then
            MsgBox("Wrong or missing data about original barrel length." & vbNewLine & "Tip: The maximum possible length of the pistol barrel is set to 45 cm = 450 mm = 18 in." & vbNewLine & "Tip: The maximum possible length of the rifle barrel is set to 152 cm = 1520 mm = 60 in." & vbNewLine & "Tip: The original barrel length cannot be less than or equal to zero.", MsgBoxStyle.Exclamation)
        ElseIf chyba_délka_nové_hlavně = True Then
            MsgBox("Wrong or missing data about new barrel length." & vbNewLine & "Tip: The maximum possible length of the pistol barrel is set to 45 cm = 450 mm = 18 in." & vbNewLine & "Tip: The maximum possible length of the rifle barrel is set to 152 cm = 1520 mm = 60 in." & vbNewLine & "Tip: The new barrel length cannot be less than or equal to zero.", MsgBoxStyle.Exclamation)
        ElseIf chyba_délka_náboje = True Then
            MsgBox("Wrong or missing data about cartridge length." & vbNewLine & "Tip: The cartridge length cannot be less than or equal to zero.", MsgBoxStyle.Exclamation)
        ElseIf chyba_délka_nábojnice = True Then
            MsgBox("Wrong or missing data about cartridge case length." & vbNewLine & "Tip: The cartridge case length cannot be less than or equal to zero.", MsgBoxStyle.Exclamation)
        ElseIf průměr_střely = True Then
            MsgBox("Wrong or missing data about bullet diamater." & vbNewLine & "Tip: The bullet diameter cannot be less than or equal to zero.", MsgBoxStyle.Exclamation)
        ElseIf chyba_délka_střely = True Then
            MsgBox("Wrong or missing data about bullet length." & vbNewLine & "Tip: The bullet length cannot be less than or equal to zero.", MsgBoxStyle.Exclamation)
        ElseIf chyba_objem_nábojnice = True Then
            MsgBox("Error in cartridge case volume calculation, please check that all cartridge and cartridge case dimensions are entered correctly, according to real measurements.", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub radiobutton_puška_CheckedChanged(sender As Object, e As EventArgs) Handles radiobutton_puška.CheckedChanged

        If radiobutton_puška.Checked = True Then
            textbox_délka_střely.Enabled = True
            combobox_délka_střely.Enabled = True
        Else
            textbox_délka_střely.Text = Nothing
            textbox_délka_střely.Enabled = False
            combobox_délka_střely.Enabled = False
        End If
    End Sub


    Private Sub radiobutton_pistole_CheckedChanged(sender As Object, e As EventArgs) Handles radiobutton_pistole.CheckedChanged
        If radiobutton_pistole.Checked = True Then
            textbox_délka_střely.Text = Nothing
            textbox_délka_střely.Enabled = False
            combobox_délka_střely.Enabled = False
        Else
            textbox_délka_střely.Enabled = True
            combobox_délka_střely.Enabled = True
        End If
    End Sub

    Private Sub radiobutton_revolver_CheckedChanged(sender As Object, e As EventArgs) Handles radiobutton_revolver.CheckedChanged
        If radiobutton_revolver.Checked = True Then
            textbox_délka_střely.Text = Nothing
            textbox_délka_střely.Enabled = False
            combobox_délka_střely.Enabled = False
        Else
            textbox_délka_střely.Enabled = True
            combobox_délka_střely.Enabled = True
        End If
    End Sub

    Private Sub button_zavřit_Click(sender As Object, e As EventArgs) Handles button_zavřít.Click
        ulozeni_pameti()
        Hlavní_okno.Enabled = True
        Me.Hide()
    End Sub

    Private Sub button_spočítej_Click(sender As Object, e As EventArgs) Handles button_spočítej.Click
        If checkbox_spocitat_aproximaci.Checked = True Then
            zápis_proměnných_aproximace_úsťové_rychlosti()
            If chyba = False Then
                výpočet_aproximace_úsťové_rychlosti()
            End If
        End If

        chyba = False

        If checkbox_spocitat_predsazeni.Checked = True Then
            zápis_proměnných_předsazení()
            If chyba = False Then
                výpočet_předsazení()
            End If
        End If
    End Sub

    Private Sub vyvolani_pameti()
        If My.Settings.pamet_vedlejsi_vypocty_combobox_puvodni_ustova_rychlost = Nothing Then
            combobox_původní_úsťová_rychlost.Text = "m/s"
            combobox_délka_původní_hlavně.Text = "cm"
            combobox_délka_nové_hlavně.Text = "cm"
            combobox_délka_náboje.Text = "mm"
            combobox_délka_nábojnice.Text = "mm"
            combobox_průměr_střely.Text = "mm"
            combobox_délka_střely.Text = "mm"

            combobox_rychlost_cíle.Text = "km/h"
            combobox_vzdálenost_cíle.Text = "m"

            radiobutton_pistole.Checked = True

            checkbox_spocitat_aproximaci.Checked = True
            checkbox_spocitat_predsazeni.Checked = True

        Else
            combobox_rychlost_cíle.Text = My.Settings.pamet_vedlejsi_vypocty_combobox_rychlost_cile
            combobox_vzdálenost_cíle.Text = My.Settings.pamet_vedlejsi_vypocty_combobox_vzdálenost_cíle
            combobox_původní_úsťová_rychlost.Text = My.Settings.pamet_vedlejsi_vypocty_combobox_puvodni_ustova_rychlost
            combobox_délka_původní_hlavně.Text = My.Settings.pamet_vedlejsi_vypocty_combobox_delka_puvodni_hlavne
            combobox_délka_nové_hlavně.Text = My.Settings.pamet_vedlejsi_vypocty_combobox_delka_nove_hlavne
            combobox_délka_náboje.Text = My.Settings.pamet_vedlejsi_vypocty_combobox_delka_naboje
            combobox_délka_nábojnice.Text = My.Settings.pamet_vedlejsi_vypocty_combobox_delka_nabojnice
            combobox_průměr_střely.Text = My.Settings.pamet_vedlejsi_vypocty_combobox_prumer_strely
            combobox_délka_střely.Text = My.Settings.pamet_vedlejsi_vypocty_combobox_delka_strely

            checkbox_spocitat_aproximaci.Checked = My.Settings.pamet_vedlejsi_vypocty_checkbox_spocitat_aproximaci
            checkbox_spocitat_predsazeni.Checked = My.Settings.pamet_vedlejsi_vypocty_checkbox_spocitat_predsazeni

            If checkbox_spocitat_aproximaci.Checked = False Then
                GroupBox1.Enabled = False
            End If
            If checkbox_spocitat_predsazeni.Checked = False Then
                GroupBox3.Enabled = False
            End If
            If checkbox_spocitat_aproximaci.Checked = False And checkbox_spocitat_predsazeni.Checked = False Then
                button_spočítej.Enabled = False
            End If

            If My.Settings.pamet_vedlejsi_vypocty_radiobutton_puska_pistole_revolver = "puška" Then
                radiobutton_puška.Checked = True
            ElseIf My.Settings.pamet_vedlejsi_vypocty_radiobutton_puska_pistole_revolver = "pistole" Then
                radiobutton_pistole.Checked = True
            Else
                radiobutton_revolver.Checked = True
            End If

        End If
    End Sub
    Private Sub ulozeni_pameti()
        My.Settings.pamet_vedlejsi_vypocty_combobox_puvodni_ustova_rychlost = combobox_původní_úsťová_rychlost.Text
        My.Settings.pamet_vedlejsi_vypocty_combobox_delka_puvodni_hlavne = combobox_délka_původní_hlavně.Text
        My.Settings.pamet_vedlejsi_vypocty_combobox_delka_nove_hlavne = combobox_délka_nové_hlavně.Text
        My.Settings.pamet_vedlejsi_vypocty_combobox_delka_naboje = combobox_délka_náboje.Text
        My.Settings.pamet_vedlejsi_vypocty_combobox_delka_nabojnice = combobox_délka_nábojnice.Text
        My.Settings.pamet_vedlejsi_vypocty_combobox_prumer_strely = combobox_průměr_střely.Text
        My.Settings.pamet_vedlejsi_vypocty_combobox_delka_strely = combobox_délka_střely.Text
        My.Settings.pamet_vedlejsi_vypocty_combobox_rychlost_cile = combobox_rychlost_cíle.Text
        My.Settings.pamet_vedlejsi_vypocty_combobox_vzdálenost_cíle = combobox_vzdálenost_cíle.Text

        My.Settings.pamet_vedlejsi_vypocty_checkbox_spocitat_predsazeni = checkbox_spocitat_predsazeni.Checked
        My.Settings.pamet_vedlejsi_vypocty_checkbox_spocitat_aproximaci = checkbox_spocitat_aproximaci.Checked

        If radiobutton_puška.Checked = True Then
            My.Settings.pamet_vedlejsi_vypocty_radiobutton_puska_pistole_revolver = "puška"
        ElseIf radiobutton_pistole.Checked = True Then
            My.Settings.pamet_vedlejsi_vypocty_radiobutton_puska_pistole_revolver = "pistole"
        Else
            My.Settings.pamet_vedlejsi_vypocty_radiobutton_puska_pistole_revolver = "revolver"
        End If

        My.Settings.Save()

    End Sub

    Private Sub checkbox_spocitat_aproximaci_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_spocitat_aproximaci.CheckedChanged
        If checkbox_spocitat_aproximaci.Checked = True Then
            button_spočítej.Enabled = True
            GroupBox1.Enabled = True
        Else
            GroupBox1.Enabled = False
            If checkbox_spocitat_predsazeni.Checked = False Then
                button_spočítej.Enabled = False
            End If
        End If
    End Sub

    Private Sub checkbox_spocitat_predsazeni_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_spocitat_predsazeni.CheckedChanged
        If checkbox_spocitat_predsazeni.Checked = True Then
            button_spočítej.Enabled = True
            GroupBox3.Enabled = True
        Else
            GroupBox3.Enabled = False
            If checkbox_spocitat_aproximaci.Checked = False Then
                button_spočítej.Enabled = False
            End If
        End If
    End Sub
End Class