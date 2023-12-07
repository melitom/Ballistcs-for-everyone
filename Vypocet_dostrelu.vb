Imports System.Math
Public Class Vypocet_dostrelu
    Dim rychlost As Double = 0
    Dim proměnný_koeficient_odporu As Decimal = 0
    Dim koeficient_odporu As Decimal = 0

    Dim ustova_rychlost As Decimal = 0
    Dim hmotnost_strely As Decimal = 0
    Dim obsah_prurezu As Double = 0
    Dim prumer As Decimal = 0
    Dim uhel_vrhu As Decimal = 0

    Dim g As Decimal = 9.823

    Dim maximalni_uhel_dostrelu As Integer = 0
    Dim hustota_vzduchu As Decimal = 0
    Dim rychlost_zvuku As Decimal = 0
    Dim rychlost_mach As Decimal = 0
    Dim chyba As Boolean = False
    Dim doba_pohybu As Decimal = 0

    Dim dostrel As Integer = 0
    Dim dopadova_rychlost As Integer = 0

    Private Sub Button_Zavřít_Click(sender As Object, e As EventArgs) Handles Button_Zavřít.Click
        ulozeni_pameti()
        Hlavní_okno.Enabled = True
        Me.Hide()
    End Sub

    Private Sub Vypocet_dostrelu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        vyvolani_pameti()
        If checkbox_koule_broky.Checked = False And checkbox_střepiny.Checked = False Then
            textbox_prumer_telesa.Enabled = False
            combobox_prumer_telesa.Enabled = False
        Else
            textbox_prumer_telesa.Enabled = True
            combobox_prumer_telesa.Enabled = True
        End If
        hustota_vzduchu = My.Settings.hustota_vzduchu
        rychlost_zvuku = My.Settings.rychlost_zvuku
        label_teplota_vzduchu.Text = "Air temperature: " & My.Settings.teplota_vzduchu
        label_nadmořská_výška.Text = "Elevation: " & My.Settings.nadmořská_výška
        combobox_uhel_vrhu.Text = "deg"

        If Hlavní_okno.Textbox_Počáteční_rychlost.Text <> Nothing Then
            Textbox_Počáteční_rychlost.Text = Hlavní_okno.Textbox_Počáteční_rychlost.Text
            Textbox_hmotnost.Text = Hlavní_okno.Textbox_hmotnost.Text
            Textbox_Koeficient_odporu.Text = Hlavní_okno.Textbox_Koeficient_odporu.Text
            combobox_počáteční_rychlost.Text = Hlavní_okno.combobox_počáteční_rychlost.Text
            combobox_hmotnost_střely.Text = Hlavní_okno.combobox_hmotnost_střely.Text
            combobox_výběr_koeficientů.Text = Hlavní_okno.Combobox_výběr_koeficientů.Text
        End If
    End Sub

    Private Sub Vypocet_dostrelu_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Hlavní_okno.Enabled = True
        ulozeni_pameti()
    End Sub

    Private Sub Vypocet_dostrelu_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

        label_teplota_vzduchu.Text = "Air temperature: " & My.Settings.teplota_vzduchu
        label_nadmořská_výška.Text = "Elevation: " & My.Settings.nadmořská_výška
        hustota_vzduchu = My.Settings.hustota_vzduchu
        rychlost_zvuku = My.Settings.rychlost_zvuku

        If Textbox_Počáteční_rychlost.Text = Nothing And Hlavní_okno.Textbox_Počáteční_rychlost.Text <> Nothing Then
            Textbox_Počáteční_rychlost.Text = Hlavní_okno.Textbox_Počáteční_rychlost.Text
            Textbox_hmotnost.Text = Hlavní_okno.Textbox_hmotnost.Text
            Textbox_Koeficient_odporu.Text = Hlavní_okno.Textbox_Koeficient_odporu.Text
            combobox_počáteční_rychlost.Text = Hlavní_okno.combobox_počáteční_rychlost.Text
            combobox_hmotnost_střely.Text = Hlavní_okno.combobox_hmotnost_střely.Text
            combobox_výběr_koeficientů.Text = Hlavní_okno.Combobox_výběr_koeficientů.Text
        End If
    End Sub

    Private Sub nastaveni_grafu()
        Try
            Chart1.ChartAreas.Clear()
            Chart1.Series.Clear()
            Chart1.Titles.Clear()
            Chart1.ChartAreas.Add("ChartArea1")
            Chart1.Titles.Add("Trajectory").Font = New System.Drawing.Font("Arial", 13.5, FontStyle.Bold)
            Chart1.Series.Add("Trajektorie tělesa")
            Chart1.Series("Trajektorie tělesa").Color = Color.Red
            Chart1.Series("Trajektorie tělesa").IsVisibleInLegend = False
            Chart1.Series("Trajektorie tělesa").ChartType = DataVisualization.Charting.SeriesChartType.Line
            If Hlavní_okno.checkbox_metricke_jednotky.Checked = True Then
                Chart1.ChartAreas("ChartArea1").AxisY.Title = "Height [m]"
                Chart1.ChartAreas("ChartArea1").AxisX.Title = "Distance [m]"
            Else
                Chart1.ChartAreas("ChartArea1").AxisY.Title = "Height [ft]"
                Chart1.ChartAreas("ChartArea1").AxisX.Title = "Distance [yd]"
            End If
            Chart1.ChartAreas("ChartArea1").AxisY.TitleFont = New System.Drawing.Font("Arial", 12, FontStyle.Bold)
            Chart1.ChartAreas("ChartArea1").AxisX.TitleFont = New System.Drawing.Font("Arial", 12, FontStyle.Bold)
            Chart1.ChartAreas("ChartArea1").AxisY.Minimum = 0
            Chart1.ChartAreas("ChartArea1").AxisX.Minimum = 0
            Chart1.Series("Trajektorie tělesa").Points.AddXY(0, 0)
        Catch ex As Exception
            If chyba = False Then
                MsgBox("An error occurred during the calculation, please check that all data is entered correctly.", MsgBoxStyle.Critical)
            End If
            chyba = True
        End Try
    End Sub
    Private Sub proměnný_koeficient()
        rychlost_mach = rychlost / rychlost_zvuku

        If combobox_výběr_koeficientů.Enabled = True Then
            If combobox_výběr_koeficientů.Text = "G1" Then

                If rychlost_mach >= 0 And rychlost_mach <= 0.3 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 0.8
                ElseIf rychlost_mach > 0.3 And rychlost_mach <= 0.5 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 0.71
                ElseIf rychlost_mach > 0.5 And rychlost_mach <= 0.7 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 0.69
                ElseIf rychlost_mach > 0.7 And rychlost_mach <= 0.8 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 0.79
                ElseIf rychlost_mach > 0.8 And rychlost_mach <= 0.85 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 0.91
                ElseIf rychlost_mach > 0.85 And rychlost_mach <= 0.9 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.05
                ElseIf rychlost_mach > 0.9 And rychlost_mach <= 0.95 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.25
                ElseIf rychlost_mach > 0.95 And rychlost_mach <= 1.0 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.48
                ElseIf rychlost_mach > 1.0 And rychlost_mach <= 1.05 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.71
                ElseIf rychlost_mach > 1.05 And rychlost_mach <= 1.1 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.88
                ElseIf rychlost_mach > 1.1 And rychlost_mach <= 1.2 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 2.05
                ElseIf rychlost_mach > 1.2 And rychlost_mach <= 1.8 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 2.18
                ElseIf rychlost_mach > 1.8 And rychlost_mach <= 2.2 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.98
                ElseIf rychlost_mach > 2.2 And rychlost_mach <= 2.6 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.83
                ElseIf rychlost_mach > 2.6 And rychlost_mach <= 3.0 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.74
                ElseIf rychlost_mach > 3 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.68
                End If


            ElseIf combobox_výběr_koeficientů.Text = "G7" Then

                If rychlost_mach >= 0 And rychlost_mach <= 0.7 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 0.99
                ElseIf rychlost_mach > 0.7 And rychlost_mach <= 0.8 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.02
                ElseIf rychlost_mach > 0.8 And rychlost_mach <= 0.85 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.062
                ElseIf rychlost_mach > 0.85 And rychlost_mach <= 0.865 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.1142
                ElseIf rychlost_mach > 0.865 And rychlost_mach <= 0.88 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.1471
                ElseIf rychlost_mach > 0.88 And rychlost_mach <= 0.885 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.18
                ElseIf rychlost_mach > 0.885 And rychlost_mach <= 0.89 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.21
                ElseIf rychlost_mach > 0.89 And rychlost_mach <= 0.9 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.24
                ElseIf rychlost_mach > 0.9 And rychlost_mach <= 0.915 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.3017
                ElseIf rychlost_mach > 0.915 And rychlost_mach <= 0.93 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.4246
                ElseIf rychlost_mach > 0.93 And rychlost_mach <= 0.94 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.5475
                ElseIf rychlost_mach > 0.94 And rychlost_mach <= 0.95 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.8252
                ElseIf rychlost_mach > 0.95 And rychlost_mach <= 0.965 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.9645
                ElseIf rychlost_mach > 0.965 And rychlost_mach <= 0.98 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 2.1029
                ElseIf rychlost_mach > 0.98 And rychlost_mach <= 0.985 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 2.2851
                ElseIf rychlost_mach > 0.985 And rychlost_mach <= 0.99 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 2.4673
                ElseIf rychlost_mach > 0.99 And rychlost_mach <= 0.995 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 2.6495
                ElseIf rychlost_mach > 0.995 And rychlost_mach <= 1.0 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 2.8317
                ElseIf rychlost_mach > 1.0 And rychlost_mach <= 1.015 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 3.0446
                ElseIf rychlost_mach > 1.015 And rychlost_mach <= 1.03 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 3.2575
                ElseIf rychlost_mach > 1.03 And rychlost_mach <= 1.05 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 3.3575
                ElseIf rychlost_mach > 1.05 And rychlost_mach <= 1.1 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 3.3571
                ElseIf rychlost_mach > 1.1 And rychlost_mach <= 1.15 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 3.321
                ElseIf rychlost_mach > 1.15 And rychlost_mach <= 1.2 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 3.266
                ElseIf rychlost_mach > 1.2 And rychlost_mach <= 1.25 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 3.206
                ElseIf rychlost_mach > 1.25 And rychlost_mach <= 1.3 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 3.1425
                ElseIf rychlost_mach > 1.3 And rychlost_mach <= 1.35 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 3.0788
                ElseIf rychlost_mach > 1.35 And rychlost_mach <= 1.4 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 3.015
                ElseIf rychlost_mach > 1.4 And rychlost_mach <= 1.5 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 2.925
                ElseIf rychlost_mach > 1.5 And rychlost_mach <= 1.6 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 2.8145
                ElseIf rychlost_mach > 1.6 And rychlost_mach <= 1.7 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 2.718
                ElseIf rychlost_mach > 1.7 And rychlost_mach <= 1.8 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 2.636
                ElseIf rychlost_mach > 1.8 And rychlost_mach <= 1.9 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 2.566
                ElseIf rychlost_mach > 1.9 And rychlost_mach <= 2.0 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 2.509
                ElseIf rychlost_mach > 2.0 And rychlost_mach <= 2.15 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 2.446
                ElseIf rychlost_mach > 2.15 And rychlost_mach <= 2.3 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 2.3745
                ElseIf rychlost_mach > 2.3 And rychlost_mach <= 2.6 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 2.271
                ElseIf rychlost_mach > 2.6 And rychlost_mach <= 3.0 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 2.111
                ElseIf rychlost_mach > 3 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 2
                End If


            ElseIf combobox_výběr_koeficientů.Text = "JSBE" Then

                If rychlost_mach >= 0 And rychlost_mach <= 0.3 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 0.99
                ElseIf rychlost_mach > 0.3 And rychlost_mach <= 0.4 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.04
                ElseIf rychlost_mach > 0.4 And rychlost_mach <= 0.55 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 0.75
                ElseIf rychlost_mach > 0.55 And rychlost_mach <= 0.6 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 0.97
                ElseIf rychlost_mach > 0.6 And rychlost_mach <= 0.65 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.2
                ElseIf rychlost_mach > 0.65 And rychlost_mach <= 0.7 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.43
                ElseIf rychlost_mach > 0.7 And rychlost_mach <= 0.75 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.66
                ElseIf rychlost_mach > 0.75 And rychlost_mach <= 0.8 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.88
                ElseIf rychlost_mach > 0.8 And rychlost_mach <= 0.85 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 2.11
                ElseIf rychlost_mach > 0.85 And rychlost_mach <= 0.9 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 2.32
                ElseIf rychlost_mach > 0.9 And rychlost_mach <= 0.95 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 2.54
                ElseIf rychlost_mach > 0.95 And rychlost_mach <= 1.0 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 2.75
                ElseIf rychlost_mach > 1.0 And rychlost_mach <= 1.1 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 3.02
                ElseIf rychlost_mach > 1.1 And rychlost_mach <= 1.2 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 3.32
                ElseIf rychlost_mach > 1.2 And rychlost_mach <= 1.4 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 3.5
                ElseIf rychlost_mach > 1.4 And rychlost_mach <= 2 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 3.62
                ElseIf rychlost_mach > 2 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 3.75
                End If

            End If

        Else
            If checkbox_koule_broky.Checked = True Then

                If rychlost_mach >= 0 And rychlost_mach <= 0.3 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.01
                ElseIf rychlost_mach > 0.3 And rychlost_mach < 0.5 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.04
                ElseIf rychlost_mach > 0.5 And rychlost_mach < 0.7 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.14
                ElseIf rychlost_mach > 0.7 And rychlost_mach < 0.9 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.41
                ElseIf rychlost_mach > 0.9 And rychlost_mach < 1.1 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.73
                ElseIf rychlost_mach > 1.1 And rychlost_mach < 1.3 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 2.01
                ElseIf rychlost_mach > 1.3 And rychlost_mach < 2.0 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 2.12
                ElseIf rychlost_mach > 2.0 And rychlost_mach < 3.0 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 2.09
                ElseIf rychlost_mach > 3.0 And rychlost_mach < 4.0 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 2.01
                ElseIf rychlost_mach > 4.0 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.95
                End If

            ElseIf checkbox_střepiny.Checked = True Then

                If rychlost_mach <= 0 And rychlost_mach <= 0.6 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1
                ElseIf rychlost_mach > 0.6 And rychlost_mach < 1.2 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 1.7
                ElseIf rychlost_mach > 1.2 Then
                    proměnný_koeficient_odporu = koeficient_odporu * 2.0
                End If

            End If
        End If
    End Sub

    Private Sub zápis_proměnných()
        Dim chyba_ustova_rychlost As Boolean = False
        Dim chyba_hmotnost As Boolean = False
        Dim chyba_prumer_telesa As Boolean = False
        Dim chyba_koeficient As Boolean = False
        Dim chyba_uhel As Boolean = False

        'Zápis a kontrola rychlosti
        Try

            Textbox_Počáteční_rychlost.Text = Textbox_Počáteční_rychlost.Text.Replace(".", ",")
            Textbox_hmotnost.Text = Textbox_hmotnost.Text.Replace(".", ",")
            textbox_prumer_telesa.Text = textbox_prumer_telesa.Text.Replace(".", ",")
            Textbox_Koeficient_odporu.Text = Textbox_Koeficient_odporu.Text.Replace(".", ",")
            textbox_uhel_vrhu.Text = textbox_uhel_vrhu.Text.Replace(".", ",")

            If combobox_počáteční_rychlost.Text = "m/s" Then
                ustova_rychlost = Textbox_Počáteční_rychlost.Text
            ElseIf combobox_počáteční_rychlost.Text = "fps" Then
                ustova_rychlost = Textbox_Počáteční_rychlost.Text * 0.3048
            ElseIf combobox_počáteční_rychlost.Text = "km/h" Then
                ustova_rychlost = Textbox_Počáteční_rychlost.Text / 3.6
            Else
                ustova_rychlost = Textbox_Počáteční_rychlost.Text / 2.23693629
            End If
            If ustova_rychlost <= 0 Or ustova_rychlost > 1500 Then
                chyba = True
                chyba_ustova_rychlost = True
            End If
        Catch ex As Exception
            If chyba = False Then
                chyba = True
                MsgBox("Wrong or missing data about muzzle velocity.", MsgBoxStyle.Exclamation)
            End If
        End Try

        'Zápis a kontrola hmotnosti
        Try
            If combobox_hmotnost_střely.Text = "g" Then
                hmotnost_strely = Textbox_hmotnost.Text / 1000
            ElseIf combobox_hmotnost_střely.Text = "grs" Then
                hmotnost_strely = Textbox_hmotnost.Text * 0.00006479891
            ElseIf combobox_hmotnost_střely.Text = "lb" Then
                hmotnost_strely = Textbox_hmotnost.Text * 0.45359237
            Else
                hmotnost_strely = Textbox_hmotnost.Text
            End If

            If hmotnost_strely <= 0 Then
                chyba = True
                chyba_hmotnost = True
            End If
        Catch ex As Exception
            If chyba = False Then
                chyba = True
                MsgBox("Wrong or missing data about bullet weight.", MsgBoxStyle.Exclamation)
            End If
        End Try

        'Zápis a kontrola průměru
        Try
            If textbox_prumer_telesa.Enabled = True Then
                If combobox_prumer_telesa.Text = "mm" Then
                    prumer = textbox_prumer_telesa.Text / 1000
                Else
                    prumer = textbox_prumer_telesa.Text * 0.0254
                End If

                obsah_prurezu = (PI * (prumer ^ 2)) / 4

                If prumer <= 0 Or obsah_prurezu <= 0 Then
                    chyba = True
                    chyba_prumer_telesa = True
                End If
            Else
                prumer = 0.01
                obsah_prurezu = (PI * (prumer ^ 2)) / 4
            End If
        Catch ex As Exception
            If chyba = False Then
                chyba = True
                MsgBox("Wrong or missing data about bullet diameter.", MsgBoxStyle.Exclamation)
            End If
        End Try

        'Zápis a kontrola koeficientu
        Try
            If checkbox_střepiny.Checked = True Or checkbox_koule_broky.Checked = True Then
                If checkbox_koule_broky.Checked = True Then
                    koeficient_odporu = 0.47
                ElseIf checkbox_střepiny.Checked = True Then
                    koeficient_odporu = 0.7
                End If
            Else
                If combobox_výběr_koeficientů.Text = "G1" Then
                    koeficient_odporu = 0.3 * (((hmotnost_strely * 2.204627) / (((prumer * 1000) * 0.039370787) ^ 2)) / Textbox_Koeficient_odporu.Text)
                ElseIf combobox_výběr_koeficientů.Text = "G7" Then
                    koeficient_odporu = 0.12 * (((hmotnost_strely * 2.204627) / (((prumer * 1000) * 0.039370787) ^ 2)) / Textbox_Koeficient_odporu.Text)
                ElseIf combobox_výběr_koeficientů.Text = "JSBE" Then
                    koeficient_odporu = 0.3 * (((hmotnost_strely * 2.204627) / (((prumer * 1000) * 0.039370787) ^ 2)) / Textbox_Koeficient_odporu.Text)
                End If
            End If

            If koeficient_odporu <= 0 Then
                chyba = True
                chyba_koeficient = True
            End If
        Catch ex As Exception
            If chyba = False Then
                chyba = True
                MsgBox("Wrong or missing data about ballistic coefficient.", MsgBoxStyle.Exclamation)
            End If
        End Try

        'Zápis a kontrola úhlu vrhu
        Try
            If checkbox_maximalni_dostrel.Checked = False Then
                uhel_vrhu = textbox_uhel_vrhu.Text
                If uhel_vrhu > 90 Or uhel_vrhu <= 0 Then
                    chyba = True
                    chyba_uhel = True
                End If
            End If
        Catch ex As Exception
            If chyba = False Then
                chyba = True
                MsgBox("Wrong or missing data about angle of shot.", MsgBoxStyle.Exclamation)
            End If
        End Try

        If chyba_ustova_rychlost = True Then
            MsgBox("Wrong or missing data about muzzle velocity." & vbNewLine & "Tip: The maximum possible value of the muzzle velocity is limited to 1500 m/s = 4921 fps = 5400 km/h = 3355 mph." & vbNewLine & "Tip: The muzzle velocity cannot be less than or equal to zero.", MsgBoxStyle.Exclamation)
        ElseIf chyba_hmotnost = True Then
            MsgBox("Wrong or missing data about bullet weight." & vbNewLine & "Tip: The bullet weight cannot be less than or equal to zero.", MsgBoxStyle.Exclamation)
        ElseIf chyba_prumer_telesa = True Then
            MsgBox("Wrong or missing data about bullet diameter." & vbNewLine & "Tip: The bullet diameter cannot be less than or equal to zero.", MsgBoxStyle.Exclamation)
        ElseIf chyba_koeficient = True Then
            MsgBox("Wrong or missing data about ballistic coefficient." & vbNewLine & "Tip: The ballistic coefficient cannot be less than or equal to zero.", MsgBoxStyle.Exclamation)
        ElseIf chyba_uhel = True Then
            MsgBox("Wrong or missing data about angle of shot." & vbNewLine & "Tip: The angle of shot can never be less than or equal to zero, and also greater than 90.", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub button_spocitej_Click(sender As Object, e As EventArgs) Handles button_spocitej.Click
        button_spocitej.Text = "Calculation in progress"
        button_spocitej.Enabled = False
        chyba = False
        zápis_proměnných()
        If chyba = False Then
            nastaveni_grafu()

            If checkbox_maximalni_dostrel.Checked = True Then
                výpočet_maximálního_dostřelu()
                uhel_vrhu = maximalni_uhel_dostrelu
                textbox_uhel_vrhu.Text = uhel_vrhu
                výpočet_trajektorie()
            Else
                výpočet_trajektorie()
            End If

            If dostrel <= 0 Or Round(Val(doba_pohybu), 1) = 0 Then
                chyba = True
                nastaveni_grafu()
                MsgBox("An error occurred during the calculation, please check that all data is entered correctly.", MsgBoxStyle.Critical)
            End If

            If chyba = False Then
                zapis_vysledku()
            End If
            ulozeni_pameti()
        End If

        button_spocitej.Enabled = True
        button_spocitej.Text = "Calculate"
    End Sub

    Private Sub výpočet_maximálního_dostřelu()
        Try
            Dim konec As Boolean = False
            Dim sin_uhlu As Double = 0
            Dim cos_uhlu As Double = 0
            Dim dv As Double = 0
            Dim dvx As Double = 0
            Dim dvy As Double = 0
            Dim dx As Double = 0
            Dim dy As Double = 0
            Dim k1 As Double = 0
            Dim k2 As Double = 0
            Dim rychlost_x As Double = 0
            Dim rychlost_y As Double = 0
            Dim dráha_x As Double = 0
            Dim dráha_y As Double = 0
            Dim max_draha_x As Decimal = 0
            Dim interval_max_dostřel As Decimal = 0.002
            Dim max_uhel_vypocet As Decimal = 0
            max_uhel_vypocet = 46

            Do Until maximalni_uhel_dostrelu > max_uhel_vypocet
                max_uhel_vypocet = max_uhel_vypocet - 1
                sin_uhlu = Sin(max_uhel_vypocet / (180 / PI))
                cos_uhlu = Cos(max_uhel_vypocet / (180 / PI))
                rychlost = ustova_rychlost
                rychlost_y = ustova_rychlost * sin_uhlu
                rychlost_x = ustova_rychlost * cos_uhlu
                dráha_y = 0
                dráha_x = 0

                Do Until dráha_y < 0
                    proměnný_koeficient()
                    doba_pohybu = doba_pohybu + interval_max_dostřel

                    k1 = 0.5 * proměnný_koeficient_odporu * hustota_vzduchu * obsah_prurezu * rychlost ^ 2 / hmotnost_strely * interval_max_dostřel
                    k2 = 0.5 * proměnný_koeficient_odporu * hustota_vzduchu * obsah_prurezu * (rychlost - k1) ^ 2 / hmotnost_strely * interval_max_dostřel
                    dv = 0.5 * (k1 + k2)

                    k1 = dv / rychlost * rychlost_x
                    k2 = dv / rychlost * (rychlost_x - k1)
                    dvx = 0.5 * (k1 + k2)

                    k1 = dv / rychlost * rychlost_y + g * interval_max_dostřel
                    k2 = dv / rychlost * (rychlost_y - k1) + g * interval_max_dostřel
                    dvy = 0.5 * (k1 + k2)

                    k1 = rychlost_x * interval_max_dostřel
                    k2 = (rychlost_x - dvx) * interval_max_dostřel
                    dx = 0.5 * (k1 + k2)

                    k1 = rychlost_y * interval_max_dostřel
                    k2 = (rychlost_y - dvy) * interval_max_dostřel
                    dy = 0.5 * (k1 + k2)

                    rychlost_x = rychlost_x - dvx
                    rychlost_y = rychlost_y - dvy
                    rychlost = Sqrt((rychlost_x ^ 2) + (rychlost_y ^ 2))
                    dráha_x = dráha_x + dx
                    dráha_y = dráha_y + dy
                Loop
                If dráha_x > max_draha_x Then
                    max_draha_x = dráha_x
                    maximalni_uhel_dostrelu = max_uhel_vypocet
                End If
            Loop
        Catch ex As Exception
            If chyba = False Then
                nastaveni_grafu()
                MsgBox("An error occurred during the calculation, please check that all data is entered correctly.", MsgBoxStyle.Critical)
            End If
            chyba = True
        End Try
    End Sub

    Private Sub výpočet_trajektorie()
        Try
            Dim rychlost_x As Double = 0
            Dim rychlost_y As Double = 0
            Dim sin_úhel As Double = 0
            Dim cos_úhel As Double = 0
            Dim interval As Double = 0.002
            Dim dv As Double = 0
            Dim dvx As Double = 0
            Dim dvy As Double = 0
            Dim dx As Double = 0
            Dim dy As Double = 0
            Dim k1 As Double = 0
            Dim k2 As Double = 0
            Dim draha_y As Double = 0
            Dim draha_x As Double = 0
            doba_pohybu = 0

            sin_úhel = Sin(uhel_vrhu / (180 / PI))
            cos_úhel = Cos(uhel_vrhu / (180 / PI))
            rychlost_x = ustova_rychlost * cos_úhel
            rychlost_y = ustova_rychlost * sin_úhel
            rychlost = ustova_rychlost

            Do Until draha_y < 0 Or chyba = True
                proměnný_koeficient()
                doba_pohybu = doba_pohybu + interval

                k1 = 0.5 * proměnný_koeficient_odporu * hustota_vzduchu * obsah_prurezu * rychlost ^ 2 / hmotnost_strely * interval
                k2 = 0.5 * proměnný_koeficient_odporu * hustota_vzduchu * obsah_prurezu * (rychlost - k1) ^ 2 / hmotnost_strely * interval
                dv = 0.5 * (k1 + k2)

                k1 = dv / rychlost * rychlost_x
                k2 = dv / rychlost * (rychlost_x - k1)
                dvx = 0.5 * (k1 + k2)

                k1 = dv / rychlost * rychlost_y + g * interval
                k2 = dv / rychlost * (rychlost_y - k1) + g * interval
                dvy = 0.5 * (k1 + k2)

                k1 = rychlost_x * interval
                k2 = (rychlost_x - dvx) * interval
                dx = 0.5 * (k1 + k2)

                k1 = rychlost_y * interval
                k2 = (rychlost_y - dvy) * interval
                dy = 0.5 * (k1 + k2)

                rychlost_x = rychlost_x - dvx
                rychlost_y = rychlost_y - dvy
                rychlost = Sqrt((rychlost_x ^ 2) + (rychlost_y ^ 2))
                draha_x = draha_x + dx
                draha_y = draha_y + dy

                dostrel = draha_x
                dopadova_rychlost = rychlost

                If Hlavní_okno.checkbox_metricke_jednotky.Checked = True Then
                    Chart1.Series("Trajektorie tělesa").Points.AddXY(draha_x, draha_y)
                Else
                    Chart1.Series("Trajektorie tělesa").Points.AddXY(draha_x / 0.9144, draha_y / 0.3048)
                End If
            Loop
        Catch ex As Exception
            If chyba = False Then
                nastaveni_grafu()
                MsgBox("An error occurred during the calculation, please check that all data is entered correctly.", MsgBoxStyle.Critical)
            End If
            chyba = True
        End Try
    End Sub

    Private Sub zapis_vysledku()
        Try

            If Hlavní_okno.checkbox_metricke_jednotky.Checked = True Then
                label_dostrel.Text = "Maximum range: " & dostrel & " m"
            Else
                label_dostrel.Text = "Maximum range: " & Round(Val(dostrel / 0.9144), 0) & " yd"
            End If

            If combobox_počáteční_rychlost.Text = "m/s" Then
                label_dopadova_rychlost.Text = "Impact velocity: " & Round(Val(dopadova_rychlost), 0) & " m/s"
            ElseIf combobox_počáteční_rychlost.Text = "fps" Then
                label_dopadova_rychlost.Text = "Impact velocity: " & Round(Val(dopadova_rychlost / 0.3048), 0) & " fps"
            ElseIf combobox_počáteční_rychlost.Text = "km/h" Then
                label_dopadova_rychlost.Text = "Impact velocity: " & Round(Val(dopadova_rychlost * 3.6), 0) & " km/h"
            Else
                label_dopadova_rychlost.Text = "Impact velocity: " & Round(Val(dopadova_rychlost * 2.23693629), 0) & " mph"
            End If

            label_doba_pohybu.Text = "Time of flight: " & Round(Val(doba_pohybu), 1) & " sec"
            label_pocatecni_energie.Text = "Muzzle energy: " & Round(Val(0.5 * hmotnost_strely * ustova_rychlost ^ 2), 1) & " J"
            label_dopadova_energie.Text = "Impact energy: " & Round(Val(0.5 * hmotnost_strely * dopadova_rychlost ^ 2), 1) & " J"


            Dim osa_x_metricka As Integer = Ceiling(dostrel / 100) * 100
            Dim osa_x_imperialni As Integer = Ceiling((dostrel / 0.9144) / 100) * 100

            If Hlavní_okno.checkbox_metricke_jednotky.Checked = True Then
                Chart1.ChartAreas("ChartArea1").AxisX.Maximum = osa_x_metricka
                Chart1.ChartAreas("ChartArea1").AxisX.Interval = osa_x_metricka / 10
            Else
                Chart1.ChartAreas("ChartArea1").AxisX.Maximum = osa_x_imperialni
                Chart1.ChartAreas("ChartArea1").AxisX.Interval = osa_x_imperialni / 10
            End If

        Catch ex As Exception
            If chyba = False Then
                nastaveni_grafu()
                MsgBox("An error occurred during the calculation, please check that all data is entered correctly.", MsgBoxStyle.Critical)
            End If
            chyba = True
        End Try
    End Sub

    Private Sub checkbox_maximalni_dostrel_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_maximalni_dostrel.CheckedChanged
        If checkbox_maximalni_dostrel.Checked = True Then
            textbox_uhel_vrhu.Text = Nothing
            combobox_uhel_vrhu.Enabled = False
            textbox_uhel_vrhu.Enabled = False
        Else
            combobox_uhel_vrhu.Enabled = True
            textbox_uhel_vrhu.Enabled = True
        End If
    End Sub

    Private Sub checkbox_koule_broky_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_koule_broky.CheckedChanged
        If checkbox_koule_broky.Checked = True Then
            Textbox_Koeficient_odporu.Text = Nothing
            checkbox_střepiny.Checked = False
            checkbox_střepiny.Enabled = False
            combobox_výběr_koeficientů.Enabled = False
            Textbox_Koeficient_odporu.Enabled = False
            combobox_prumer_telesa.Enabled = True
            textbox_prumer_telesa.Enabled = True
        Else
            checkbox_střepiny.Enabled = True
            combobox_výběr_koeficientů.Enabled = True
            Textbox_Koeficient_odporu.Enabled = True
            combobox_prumer_telesa.Enabled = False
            textbox_prumer_telesa.Enabled = False
        End If
    End Sub

    Private Sub checkbox_střepiny_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_střepiny.CheckedChanged
        If checkbox_střepiny.Checked = True Then
            Textbox_Koeficient_odporu.Text = Nothing
            checkbox_koule_broky.Checked = False
            checkbox_koule_broky.Enabled = False
            combobox_výběr_koeficientů.Enabled = False
            Textbox_Koeficient_odporu.Enabled = False
            combobox_prumer_telesa.Enabled = True
            textbox_prumer_telesa.Enabled = True
        Else
            checkbox_koule_broky.Enabled = True
            combobox_výběr_koeficientů.Enabled = True
            Textbox_Koeficient_odporu.Enabled = True
            combobox_prumer_telesa.Enabled = False
            textbox_prumer_telesa.Enabled = False
        End If
    End Sub
    Private Sub vynulovat()

    End Sub

    Private Sub ulozeni_pameti()
        My.Settings.pamet_vypocet_dostrelu_combobox_ustova_rychlost = combobox_počáteční_rychlost.Text
        My.Settings.pamet_vypocet_dostrelu_combobox_hmotnost = combobox_hmotnost_střely.Text
        My.Settings.pamet_vypocet_dostrelu_combobox_prumer_telesa = combobox_prumer_telesa.Text
        My.Settings.pamet_vypocet_dostrelu_combobox_vyber_koeficientu = combobox_výběr_koeficientů.Text
        My.Settings.pamet_vypocet_dostrelu_checkbox_koule_broky = checkbox_koule_broky.Checked
        My.Settings.pamet_vypocet_dostrelu_checkbox_strepiny = checkbox_střepiny.Checked
        My.Settings.pamet_vypocet_dostrelu_checkbox_maximalni_dostrel = checkbox_maximalni_dostrel.Checked
        My.Settings.Save()
    End Sub

    Private Sub vyvolani_pameti()
        If My.Settings.pamet_vypocet_dostrelu_combobox_ustova_rychlost <> Nothing Then
            combobox_počáteční_rychlost.Text = My.Settings.pamet_vypocet_dostrelu_combobox_ustova_rychlost
            combobox_hmotnost_střely.Text = My.Settings.pamet_vypocet_dostrelu_combobox_hmotnost
            combobox_prumer_telesa.Text = My.Settings.pamet_vypocet_dostrelu_combobox_prumer_telesa
            combobox_výběr_koeficientů.Text = My.Settings.pamet_vypocet_dostrelu_combobox_vyber_koeficientu
            checkbox_koule_broky.Checked = My.Settings.pamet_vypocet_dostrelu_checkbox_koule_broky
            checkbox_střepiny.Checked = My.Settings.pamet_vypocet_dostrelu_checkbox_strepiny
            checkbox_maximalni_dostrel.Checked = My.Settings.pamet_vypocet_dostrelu_checkbox_maximalni_dostrel
        Else
            combobox_počáteční_rychlost.Text = "m/s"
            combobox_hmotnost_střely.Text = "grs"
            combobox_prumer_telesa.Text = "mm"
            combobox_výběr_koeficientů.Text = "G1"
            checkbox_koule_broky.Checked = False
            checkbox_střepiny.Checked = False
            checkbox_maximalni_dostrel.Checked = True
        End If
    End Sub
End Class