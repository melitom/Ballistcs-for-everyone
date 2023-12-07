Public Class Seznam_střel
    Dim hmotnost_střely As Decimal = 0
    Dim balistický_koeficient_G1 As Decimal = 0
    Dim balistický_koeficient_G7 As Decimal = 0
    Dim balistický_koeficient_JSBE As Decimal = 0

    Dim i As Integer = 0

    Dim chyba As Boolean = False

    Private Sub Seznam_střel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.Clear()
        ListView1.FullRowSelect = True
        ListView1.Sorting = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub button_zavřít_Click(sender As Object, e As EventArgs) Handles button_zavřít.Click
        Hlavní_okno.Enabled = True
        Hide()
    End Sub
    Private Sub button_načíst_střelu_Click(sender As Object, e As EventArgs) Handles button_načíst_střelu.Click
        chyba = False
        Try
            If checkbox_SB_Pistole.Checked = True Then
                label_hmotnost_střely.Text = "Bullet weight: " & ListView1.SelectedItems(0).SubItems(2).Text & " g"
                label_balistický_koeficient.Text = "Ballistic coefficient G1: " & ListView1.SelectedItems(0).SubItems(3).Text
                label_střela.Text = "Bullet name: " & ListView1.SelectedItems(0).SubItems(0).Text
                label_typ_střely.Text = "Bullet type: " & ListView1.SelectedItems(0).SubItems(1).Text
                hmotnost_střely = ListView1.SelectedItems(0).SubItems(2).Text
                balistický_koeficient_G1 = ListView1.SelectedItems(0).SubItems(3).Text

                Hlavní_okno.label_načtená_střela.Show()
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & ListView1.SelectedItems(0).SubItems(0).Text & " (" & ListView1.SelectedItems(0).SubItems(1).Text & ")"

            ElseIf checkbox_LOS.Checked = True Then
                label_hmotnost_střely.Text = "Bullet weight: " & ListView1.SelectedItems(0).SubItems(2).Text & " grs"
                label_balistický_koeficient.Text = "Ballistic coefficient G1: " & ListView1.SelectedItems(0).SubItems(3).Text
                label_střela.Text = "Bullet name: " & ListView1.SelectedItems(0).SubItems(0).Text
                label_typ_střely.Text = "Bullet type: " & ListView1.SelectedItems(0).SubItems(1).Text
                hmotnost_střely = ListView1.SelectedItems(0).SubItems(2).Text
                balistický_koeficient_G1 = ListView1.SelectedItems(0).SubItems(3).Text

                Hlavní_okno.label_načtená_střela.Show()
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & ListView1.SelectedItems(0).SubItems(0).Text & " (" & ListView1.SelectedItems(0).SubItems(1).Text & ")"

            ElseIf checkbox_LEE.Checked = True Then
                label_hmotnost_střely.Text = "Bullet weight: " & ListView1.SelectedItems(0).SubItems(2).Text & " grs"
                label_balistický_koeficient.Text = "Ballistic coefficient G1: " & ListView1.SelectedItems(0).SubItems(3).Text
                label_střela.Text = "Bullet name: " & ListView1.SelectedItems(0).SubItems(0).Text
                label_typ_střely.Text = "Bullet type: " & ListView1.SelectedItems(0).SubItems(1).Text
                hmotnost_střely = ListView1.SelectedItems(0).SubItems(2).Text
                balistický_koeficient_G1 = ListView1.SelectedItems(0).SubItems(3).Text

                Hlavní_okno.label_načtená_střela.Show()
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & ListView1.SelectedItems(0).SubItems(0).Text & " (" & ListView1.SelectedItems(0).SubItems(1).Text & ")"

            ElseIf checkbox_TNX_Pistole.Checked = True Then

                label_hmotnost_střely.Text = "Bullet weight: " & ListView1.SelectedItems(0).SubItems(2).Text & " grs"
                label_balistický_koeficient.Text = "Ballistic coefficient G1: " & ListView1.SelectedItems(0).SubItems(3).Text
                label_střela.Text = "Bullet name: " & ListView1.SelectedItems(0).SubItems(0).Text
                label_typ_střely.Text = "Bullet type: " & ListView1.SelectedItems(0).SubItems(1).Text
                hmotnost_střely = ListView1.SelectedItems(0).SubItems(2).Text
                balistický_koeficient_G1 = ListView1.SelectedItems(0).SubItems(3).Text

                Hlavní_okno.label_načtená_střela.Show()
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & ListView1.SelectedItems(0).SubItems(0).Text & " (" & ListView1.SelectedItems(0).SubItems(1).Text & ")"

            ElseIf checkbox_SB_Puška.Checked = True Then
                label_hmotnost_střely.Text = "Bullet weight: " & ListView1.SelectedItems(0).SubItems(2).Text & " g"
                label_balistický_koeficient.Text = "Ballistic coefficient G1: " & ListView1.SelectedItems(0).SubItems(3).Text
                label_střela.Text = "Bullet code: " & ListView1.SelectedItems(0).SubItems(0).Text
                label_typ_střely.Text = "Bullet type: " & ListView1.SelectedItems(0).SubItems(1).Text
                hmotnost_střely = ListView1.SelectedItems(0).SubItems(2).Text
                balistický_koeficient_G1 = ListView1.SelectedItems(0).SubItems(3).Text

                Hlavní_okno.label_načtená_střela.Show()
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & ListView1.SelectedItems(0).SubItems(0).Text & " (" & ListView1.SelectedItems(0).SubItems(1).Text & ")"

            ElseIf checkbox_L.Checked = True Then
                label_hmotnost_střely.Text = "Bullet weight: " & ListView1.SelectedItems(0).SubItems(2).Text & " grs"
                label_balistický_koeficient.Text = "Ballistic coefficient G7: " & ListView1.SelectedItems(0).SubItems(3).Text
                label_střela.Text = "Bullet code: " & ListView1.SelectedItems(0).SubItems(0).Text
                label_typ_střely.Text = "Bullet type: " & ListView1.SelectedItems(0).SubItems(1).Text
                hmotnost_střely = ListView1.SelectedItems(0).SubItems(2).Text
                balistický_koeficient_G7 = ListView1.SelectedItems(0).SubItems(3).Text

                Hlavní_okno.label_načtená_střela.Show()
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & ListView1.SelectedItems(0).SubItems(0).Text & " (" & ListView1.SelectedItems(0).SubItems(1).Text & ")"

            ElseIf checkbox_Hornady.Checked = True Then
                label_hmotnost_střely.Text = "Bullet weight: " & ListView1.SelectedItems(0).SubItems(2).Text & " grs"
                label_balistický_koeficient.Text = "Ballistic coefficient G1: " & ListView1.SelectedItems(0).SubItems(3).Text
                label_střela.Text = "Bullet code and caliber: " & ListView1.SelectedItems(0).SubItems(0).Text
                label_typ_střely.Text = "Bullet type: " & ListView1.SelectedItems(0).SubItems(1).Text
                hmotnost_střely = ListView1.SelectedItems(0).SubItems(2).Text
                balistický_koeficient_G1 = ListView1.SelectedItems(0).SubItems(3).Text

                Hlavní_okno.label_načtená_střela.Show()
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & ListView1.SelectedItems(0).SubItems(0).Text & " (" & ListView1.SelectedItems(0).SubItems(1).Text & ")"

            ElseIf checkbox_Sierra.Checked = True Then
                label_hmotnost_střely.Text = "Bullet weight: " & ListView1.SelectedItems(0).SubItems(2).Text & " grs"
                label_balistický_koeficient.Text = "Ballistic coefficient G1: " & ListView1.SelectedItems(0).SubItems(3).Text
                label_střela.Text = "Bullet name and caliber: " & ListView1.SelectedItems(0).SubItems(0).Text
                label_typ_střely.Text = "Bullet type: " & ListView1.SelectedItems(0).SubItems(1).Text
                hmotnost_střely = ListView1.SelectedItems(0).SubItems(2).Text
                balistický_koeficient_G1 = ListView1.SelectedItems(0).SubItems(3).Text

                Hlavní_okno.label_načtená_střela.Show()
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & ListView1.SelectedItems(0).SubItems(0).Text & " (" & ListView1.SelectedItems(0).SubItems(1).Text & ")"

            ElseIf checkbox_Berger.Checked = True Then
                label_hmotnost_střely.Text = "Bullet weight: " & ListView1.SelectedItems(0).SubItems(2).Text & " grs"
                label_balistický_koeficient.Text = "Ballistic coefficient G7: " & ListView1.SelectedItems(0).SubItems(3).Text
                label_střela.Text = "Bullet name and caliber: " & ListView1.SelectedItems(0).SubItems(0).Text
                label_typ_střely.Text = "Bullet type: " & ListView1.SelectedItems(0).SubItems(1).Text
                hmotnost_střely = ListView1.SelectedItems(0).SubItems(2).Text
                balistický_koeficient_G7 = ListView1.SelectedItems(0).SubItems(3).Text

                Hlavní_okno.label_načtená_střela.Show()
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & ListView1.SelectedItems(0).SubItems(0).Text & " (" & ListView1.SelectedItems(0).SubItems(1).Text & ")"

            ElseIf checkbox_TNX_Puška.Checked = True Then
                label_hmotnost_střely.Text = "Bullet weight: " & ListView1.SelectedItems(0).SubItems(2).Text & " grs"
                label_balistický_koeficient.Text = "Ballistic coefficient G1: " & ListView1.SelectedItems(0).SubItems(3).Text
                label_střela.Text = "Bullet name: " & ListView1.SelectedItems(0).SubItems(0).Text
                label_typ_střely.Text = "Bullet type: " & ListView1.SelectedItems(0).SubItems(1).Text
                hmotnost_střely = ListView1.SelectedItems(0).SubItems(2).Text
                balistický_koeficient_G1 = ListView1.SelectedItems(0).SubItems(3).Text

                Hlavní_okno.label_načtená_střela.Show()
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & ListView1.SelectedItems(0).SubItems(0).Text & " (" & ListView1.SelectedItems(0).SubItems(1).Text & ")"

            ElseIf checkbox_N.Checked = True Then
                label_hmotnost_střely.Text = "Bullet weight: " & ListView1.SelectedItems(0).SubItems(2).Text & " grs"
                label_balistický_koeficient.Text = "Ballistic coefficient G1: " & ListView1.SelectedItems(0).SubItems(3).Text
                label_střela.Text = "Bullet name and caliber: " & ListView1.SelectedItems(0).SubItems(0).Text
                label_typ_střely.Text = "Bullet type: " & ListView1.SelectedItems(0).SubItems(1).Text
                hmotnost_střely = ListView1.SelectedItems(0).SubItems(2).Text
                balistický_koeficient_G1 = ListView1.SelectedItems(0).SubItems(3).Text

                Hlavní_okno.label_načtená_střela.Show()
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & ListView1.SelectedItems(0).SubItems(0).Text & " (" & ListView1.SelectedItems(0).SubItems(1).Text & ")"

            ElseIf checkbox_FOX.Checked = True Then
                label_hmotnost_střely.Text = "Bullet weight: " & ListView1.SelectedItems(0).SubItems(2).Text & " grs"
                label_balistický_koeficient.Text = "Ballistic coefficient G1: " & ListView1.SelectedItems(0).SubItems(3).Text
                label_střela.Text = "Bullet caliber: " & ListView1.SelectedItems(0).SubItems(0).Text
                label_typ_střely.Text = "Bullet type: " & ListView1.SelectedItems(0).SubItems(1).Text
                hmotnost_střely = ListView1.SelectedItems(0).SubItems(2).Text
                balistický_koeficient_G1 = ListView1.SelectedItems(0).SubItems(3).Text

                Hlavní_okno.label_načtená_střela.Show()
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & ListView1.SelectedItems(0).SubItems(0).Text & " (" & ListView1.SelectedItems(0).SubItems(1).Text & ")"

            ElseIf checkbox_federal_puška.Checked = True Then
                label_hmotnost_střely.Text = "Bullet weight: " & ListView1.SelectedItems(0).SubItems(2).Text & " grs"
                label_balistický_koeficient.Text = "Ballistic coefficient G1: " & ListView1.SelectedItems(0).SubItems(3).Text
                label_střela.Text = "Bullet caliber: " & ListView1.SelectedItems(0).SubItems(0).Text
                label_typ_střely.Text = "Bullet type: " & ListView1.SelectedItems(0).SubItems(1).Text
                hmotnost_střely = ListView1.SelectedItems(0).SubItems(2).Text
                balistický_koeficient_G1 = ListView1.SelectedItems(0).SubItems(3).Text

                Hlavní_okno.label_načtená_střela.Show()
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & ListView1.SelectedItems(0).SubItems(0).Text & " (" & ListView1.SelectedItems(0).SubItems(1).Text & ")"

            ElseIf checkbox_RWS_puškové.Checked = True Then
                label_hmotnost_střely.Text = "Bullet weight: " & ListView1.SelectedItems(0).SubItems(2).Text & " g"
                label_balistický_koeficient.Text = "Ballistic coefficient G7: " & ListView1.SelectedItems(0).SubItems(3).Text
                label_střela.Text = "Bullet caliber: " & ListView1.SelectedItems(0).SubItems(0).Text
                label_typ_střely.Text = "Bullet type: " & ListView1.SelectedItems(0).SubItems(1).Text
                hmotnost_střely = ListView1.SelectedItems(0).SubItems(2).Text
                balistický_koeficient_G7 = ListView1.SelectedItems(0).SubItems(3).Text

                Hlavní_okno.label_načtená_střela.Show()
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & ListView1.SelectedItems(0).SubItems(0).Text & " (" & ListView1.SelectedItems(0).SubItems(1).Text & ")"

            ElseIf checkbox_diabolky.Checked = True Then
                label_hmotnost_střely.Text = "Bullet weight: " & ListView1.SelectedItems(0).SubItems(2).Text & " g"
                label_balistický_koeficient.Text = "Ballistic coefficient JSBE: " & ListView1.SelectedItems(0).SubItems(3).Text
                label_střela.Text = "Bullet caliber and name: " & ListView1.SelectedItems(0).SubItems(0).Text
                label_typ_střely.Text = "Bullet manufacturer: " & ListView1.SelectedItems(0).SubItems(1).Text
                hmotnost_střely = ListView1.SelectedItems(0).SubItems(2).Text
                balistický_koeficient_JSBE = ListView1.SelectedItems(0).SubItems(3).Text

                Hlavní_okno.label_načtená_střela.Show()
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & ListView1.SelectedItems(0).SubItems(0).Text & " (" & ListView1.SelectedItems(0).SubItems(1).Text & ")"

            ElseIf checkbox_SB_malorážka.Checked = True Then
                label_hmotnost_střely.Text = "Bullet weight: " & ListView1.SelectedItems(0).SubItems(2).Text & " g"
                label_balistický_koeficient.Text = "Ballistic coefficient G1: " & ListView1.SelectedItems(0).SubItems(3).Text
                label_střela.Text = "Bullet name: " & ListView1.SelectedItems(0).SubItems(0).Text
                label_typ_střely.Text = "Bullet type: " & ListView1.SelectedItems(0).SubItems(1).Text
                hmotnost_střely = ListView1.SelectedItems(0).SubItems(2).Text
                balistický_koeficient_G1 = ListView1.SelectedItems(0).SubItems(3).Text

                Hlavní_okno.label_načtená_střela.Show()
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & ListView1.SelectedItems(0).SubItems(0).Text & " (" & ListView1.SelectedItems(0).SubItems(1).Text & ")"

            ElseIf checkbox_RWS_malorazka.Checked = True Then
                label_hmotnost_střely.Text = "Bullet weight: " & ListView1.SelectedItems(0).SubItems(2).Text & " g"
                label_balistický_koeficient.Text = "Ballistic coefficient G1: " & ListView1.SelectedItems(0).SubItems(3).Text
                label_střela.Text = "Bullet name: " & ListView1.SelectedItems(0).SubItems(0).Text
                label_typ_střely.Text = "Bullet type: " & ListView1.SelectedItems(0).SubItems(1).Text
                hmotnost_střely = ListView1.SelectedItems(0).SubItems(2).Text
                balistický_koeficient_G1 = ListView1.SelectedItems(0).SubItems(3).Text

                Hlavní_okno.label_načtená_střela.Show()
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & ListView1.SelectedItems(0).SubItems(0).Text & " (" & ListView1.SelectedItems(0).SubItems(1).Text & ")"

            ElseIf checkbox_SK_malorážka.Checked = True Then
                label_hmotnost_střely.Text = "Bullet weight: " & ListView1.SelectedItems(0).SubItems(2).Text & " g"
                label_balistický_koeficient.Text = "Ballistic coefficient G1: " & ListView1.SelectedItems(0).SubItems(3).Text
                label_střela.Text = "Bullet name: " & ListView1.SelectedItems(0).SubItems(0).Text
                label_typ_střely.Text = "Bullet type: " & ListView1.SelectedItems(0).SubItems(1).Text
                hmotnost_střely = ListView1.SelectedItems(0).SubItems(2).Text
                balistický_koeficient_G1 = ListView1.SelectedItems(0).SubItems(3).Text

                Hlavní_okno.label_načtená_střela.Show()
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & ListView1.SelectedItems(0).SubItems(0).Text & " (" & ListView1.SelectedItems(0).SubItems(1).Text & ")"

            ElseIf checkbox_CCI.Checked = True Then
                label_hmotnost_střely.Text = "Bullet weight: " & ListView1.SelectedItems(0).SubItems(2).Text & " grs"
                label_balistický_koeficient.Text = "Ballistic coefficient G1: " & ListView1.SelectedItems(0).SubItems(3).Text
                label_střela.Text = "Bullet name: " & ListView1.SelectedItems(0).SubItems(0).Text
                label_typ_střely.Text = "Bullet type: " & ListView1.SelectedItems(0).SubItems(1).Text
                hmotnost_střely = ListView1.SelectedItems(0).SubItems(2).Text
                balistický_koeficient_G1 = ListView1.SelectedItems(0).SubItems(3).Text

                Hlavní_okno.label_načtená_střela.Show()
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & ListView1.SelectedItems(0).SubItems(0).Text & " (" & ListView1.SelectedItems(0).SubItems(1).Text & ")"

            ElseIf checkbox_federal_pistole.Checked = True Then
                label_hmotnost_střely.Text = "Bullet weight: " & ListView1.SelectedItems(0).SubItems(2).Text & " grs"
                label_balistický_koeficient.Text = "Ballistic coefficient G1: " & ListView1.SelectedItems(0).SubItems(3).Text
                label_střela.Text = "Bullet name and caliber: " & ListView1.SelectedItems(0).SubItems(0).Text
                label_typ_střely.Text = "Bullet type: " & ListView1.SelectedItems(0).SubItems(1).Text
                hmotnost_střely = ListView1.SelectedItems(0).SubItems(2).Text
                balistický_koeficient_G1 = ListView1.SelectedItems(0).SubItems(3).Text

                Hlavní_okno.label_načtená_střela.Show()
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & ListView1.SelectedItems(0).SubItems(0).Text & " (" & ListView1.SelectedItems(0).SubItems(1).Text & ")"

            ElseIf checkbox_federal_malorážka.Checked = True Then

                label_hmotnost_střely.Text = "Bullet weight: " & ListView1.SelectedItems(0).SubItems(2).Text & " grs"
                label_balistický_koeficient.Text = "Ballistic coefficient G1: " & ListView1.SelectedItems(0).SubItems(3).Text
                label_střela.Text = "Bullet name and caliber: " & ListView1.SelectedItems(0).SubItems(0).Text
                label_typ_střely.Text = "Bullet type: " & ListView1.SelectedItems(0).SubItems(1).Text
                hmotnost_střely = ListView1.SelectedItems(0).SubItems(2).Text
                balistický_koeficient_G1 = ListView1.SelectedItems(0).SubItems(3).Text

                Hlavní_okno.label_načtená_střela.Show()
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & ListView1.SelectedItems(0).SubItems(0).Text & " (" & ListView1.SelectedItems(0).SubItems(1).Text & ")"

            ElseIf checkbox_H_pistole.Checked = True Then

                label_hmotnost_střely.Text = "Bullet weight: " & ListView1.SelectedItems(0).SubItems(2).Text & " grs"
                label_balistický_koeficient.Text = "Ballistic coefficient G1: " & ListView1.SelectedItems(0).SubItems(3).Text
                label_střela.Text = "Bullet code and caliber: " & ListView1.SelectedItems(0).SubItems(0).Text
                label_typ_střely.Text = "Bullet type: " & ListView1.SelectedItems(0).SubItems(1).Text
                hmotnost_střely = ListView1.SelectedItems(0).SubItems(2).Text
                balistický_koeficient_G1 = ListView1.SelectedItems(0).SubItems(3).Text

                Hlavní_okno.label_načtená_střela.Show()
                Hlavní_okno.label_načtená_střela.Text = "Bullet: " & ListView1.SelectedItems(0).SubItems(0).Text & " (" & ListView1.SelectedItems(0).SubItems(1).Text & ")"

            Else
                chyba = True
            End If

            If hmotnost_střely <> 0 Then
                If checkbox_SB_Puška.Checked = True Then
                    Hlavní_okno.Textbox_hmotnost.Text = hmotnost_střely
                    Hlavní_okno.Textbox_Koeficient_odporu.Text = balistický_koeficient_G1
                    Hlavní_okno.Combobox_výběr_koeficientů.Text = "G1"
                    Hlavní_okno.combobox_hmotnost_střely.Text = "g"
                ElseIf checkbox_L.Checked = True Then
                    Hlavní_okno.Textbox_hmotnost.Text = hmotnost_střely
                    Hlavní_okno.Textbox_Koeficient_odporu.Text = balistický_koeficient_G7
                    Hlavní_okno.Combobox_výběr_koeficientů.Text = "G7"
                    Hlavní_okno.combobox_hmotnost_střely.Text = "grs"
                ElseIf checkbox_Hornady.Checked = True Then
                    Hlavní_okno.Textbox_hmotnost.Text = hmotnost_střely
                    Hlavní_okno.Textbox_Koeficient_odporu.Text = balistický_koeficient_G1
                    Hlavní_okno.Combobox_výběr_koeficientů.Text = "G1"
                    Hlavní_okno.combobox_hmotnost_střely.Text = "grs"
                ElseIf checkbox_Sierra.Checked = True Then
                    Hlavní_okno.Textbox_hmotnost.Text = hmotnost_střely
                    Hlavní_okno.Textbox_Koeficient_odporu.Text = balistický_koeficient_G1
                    Hlavní_okno.Combobox_výběr_koeficientů.Text = "G1"
                    Hlavní_okno.combobox_hmotnost_střely.Text = "grs"
                ElseIf checkbox_Berger.Checked = True Then
                    Hlavní_okno.Textbox_hmotnost.Text = hmotnost_střely
                    Hlavní_okno.Textbox_Koeficient_odporu.Text = balistický_koeficient_G7
                    Hlavní_okno.Combobox_výběr_koeficientů.Text = "G7"
                    Hlavní_okno.combobox_hmotnost_střely.Text = "grs"
                ElseIf checkbox_TNX_Puška.Checked = True Then
                    Hlavní_okno.Textbox_hmotnost.Text = hmotnost_střely
                    Hlavní_okno.Textbox_Koeficient_odporu.Text = balistický_koeficient_G1
                    Hlavní_okno.Combobox_výběr_koeficientů.Text = "G1"
                    Hlavní_okno.combobox_hmotnost_střely.Text = "grs"
                ElseIf checkbox_N.Checked = True Then
                    Hlavní_okno.Textbox_hmotnost.Text = hmotnost_střely
                    Hlavní_okno.Textbox_Koeficient_odporu.Text = balistický_koeficient_G1
                    Hlavní_okno.Combobox_výběr_koeficientů.Text = "G1"
                    Hlavní_okno.combobox_hmotnost_střely.Text = "grs"
                ElseIf checkbox_FOX.Checked = True Then
                    Hlavní_okno.Textbox_hmotnost.Text = hmotnost_střely
                    Hlavní_okno.Textbox_Koeficient_odporu.Text = balistický_koeficient_G1
                    Hlavní_okno.Combobox_výběr_koeficientů.Text = "G1"
                    Hlavní_okno.combobox_hmotnost_střely.Text = "grs"
                ElseIf checkbox_SB_Pistole.Checked = True Then
                    Hlavní_okno.Textbox_hmotnost.Text = hmotnost_střely
                    Hlavní_okno.Textbox_Koeficient_odporu.Text = balistický_koeficient_G1
                    Hlavní_okno.Combobox_výběr_koeficientů.Text = "G1"
                    Hlavní_okno.combobox_hmotnost_střely.Text = "g"
                ElseIf checkbox_LOS.Checked = True Then
                    Hlavní_okno.Textbox_hmotnost.Text = hmotnost_střely
                    Hlavní_okno.Textbox_Koeficient_odporu.Text = balistický_koeficient_G1
                    Hlavní_okno.Combobox_výběr_koeficientů.Text = "G1"
                    Hlavní_okno.combobox_hmotnost_střely.Text = "grs"
                ElseIf checkbox_LEE.Checked = True Then
                    Hlavní_okno.Textbox_hmotnost.Text = hmotnost_střely
                    Hlavní_okno.Textbox_Koeficient_odporu.Text = balistický_koeficient_G1
                    Hlavní_okno.Combobox_výběr_koeficientů.Text = "G1"
                    Hlavní_okno.combobox_hmotnost_střely.Text = "grs"
                ElseIf checkbox_TNX_Pistole.Checked = True Then
                    Hlavní_okno.Textbox_hmotnost.Text = hmotnost_střely
                    Hlavní_okno.Textbox_Koeficient_odporu.Text = balistický_koeficient_G1
                    Hlavní_okno.Combobox_výběr_koeficientů.Text = "G1"
                    Hlavní_okno.combobox_hmotnost_střely.Text = "grs"
                ElseIf checkbox_federal_puška.Checked = True Then
                    Hlavní_okno.Textbox_hmotnost.Text = hmotnost_střely
                    Hlavní_okno.Textbox_Koeficient_odporu.Text = balistický_koeficient_G1
                    Hlavní_okno.Combobox_výběr_koeficientů.Text = "G1"
                    Hlavní_okno.combobox_hmotnost_střely.Text = "grs"
                ElseIf checkbox_RWS_puškové.Checked = True Then
                    Hlavní_okno.Textbox_hmotnost.Text = hmotnost_střely
                    Hlavní_okno.Textbox_Koeficient_odporu.Text = balistický_koeficient_G7
                    Hlavní_okno.Combobox_výběr_koeficientů.Text = "G7"
                    Hlavní_okno.combobox_hmotnost_střely.Text = "g"
                ElseIf checkbox_diabolky.Checked = True Then
                    Hlavní_okno.Textbox_hmotnost.Text = hmotnost_střely
                    Hlavní_okno.Textbox_Koeficient_odporu.Text = balistický_koeficient_JSBE
                    Hlavní_okno.Combobox_výběr_koeficientů.Text = "JSBE"
                    Hlavní_okno.combobox_hmotnost_střely.Text = "g"
                ElseIf checkbox_SB_malorážka.Checked = True Then
                    Hlavní_okno.Textbox_hmotnost.Text = hmotnost_střely
                    Hlavní_okno.Textbox_Koeficient_odporu.Text = balistický_koeficient_G1
                    Hlavní_okno.Combobox_výběr_koeficientů.Text = "G1"
                    Hlavní_okno.combobox_hmotnost_střely.Text = "g"
                ElseIf checkbox_RWS_malorazka.Checked = True Then
                    Hlavní_okno.Textbox_hmotnost.Text = hmotnost_střely
                    Hlavní_okno.Textbox_Koeficient_odporu.Text = balistický_koeficient_G1
                    Hlavní_okno.Combobox_výběr_koeficientů.Text = "G1"
                    Hlavní_okno.combobox_hmotnost_střely.Text = "g"
                ElseIf checkbox_SK_malorážka.Checked = True Then
                    Hlavní_okno.Textbox_hmotnost.Text = hmotnost_střely
                    Hlavní_okno.Textbox_Koeficient_odporu.Text = balistický_koeficient_G1
                    Hlavní_okno.Combobox_výběr_koeficientů.Text = "G1"
                    Hlavní_okno.combobox_hmotnost_střely.Text = "g"
                ElseIf checkbox_CCI.Checked = True Then
                    Hlavní_okno.Textbox_hmotnost.Text = hmotnost_střely
                    Hlavní_okno.Textbox_Koeficient_odporu.Text = balistický_koeficient_G1
                    Hlavní_okno.Combobox_výběr_koeficientů.Text = "G1"
                    Hlavní_okno.combobox_hmotnost_střely.Text = "grs"
                ElseIf checkbox_federal_pistole.Checked = True Then
                    Hlavní_okno.Textbox_hmotnost.Text = hmotnost_střely
                    Hlavní_okno.Textbox_Koeficient_odporu.Text = balistický_koeficient_G1
                    Hlavní_okno.Combobox_výběr_koeficientů.Text = "G1"
                    Hlavní_okno.combobox_hmotnost_střely.Text = "grs"
                ElseIf checkbox_federal_malorážka.Checked = True Then
                    Hlavní_okno.Textbox_hmotnost.Text = hmotnost_střely
                    Hlavní_okno.Textbox_Koeficient_odporu.Text = balistický_koeficient_G1
                    Hlavní_okno.Combobox_výběr_koeficientů.Text = "G1"
                    Hlavní_okno.combobox_hmotnost_střely.Text = "grs"
                ElseIf checkbox_H_pistole.Checked = True Then
                    Hlavní_okno.Textbox_hmotnost.Text = hmotnost_střely
                    Hlavní_okno.Textbox_Koeficient_odporu.Text = balistický_koeficient_G1
                    Hlavní_okno.Combobox_výběr_koeficientů.Text = "G1"
                    Hlavní_okno.combobox_hmotnost_střely.Text = "grs"
                End If
            Else
                chyba = True
            End If
        Catch ex As Exception
            chyba = True
        End Try
        If chyba = True Then
            MsgBox("Select the bullet, which you want to load." & vbNewLine & "Tip: You can select a bullet by clicking on any of its parameters or on the line in which it is located.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub checkbox_SB_Puška_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_SB_Puška.CheckedChanged
        If checkbox_SB_Puška.Checked = True Then
            checkbox_SB_Puška.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold, FontStyle.Regular, FontStyle.Regular)
            i = 1
            operace_checkbox()
            puškové_střely_SB()
        Else
            checkbox_SB_Puška.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Regular, FontStyle.Regular, FontStyle.Regular)
            ListView1.Clear()
        End If
    End Sub

    Private Sub checkbox_L_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_L.CheckedChanged
        If checkbox_L.Checked = True Then
            checkbox_L.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold, FontStyle.Regular, FontStyle.Regular)
            i = 3
            operace_checkbox()
            puškové_střely_L()
        Else
            checkbox_L.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Regular, FontStyle.Regular, FontStyle.Regular)
            ListView1.Clear()
        End If

    End Sub

    Private Sub checkbox_Hornady_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_Hornady.CheckedChanged
        If checkbox_Hornady.Checked = True Then
            checkbox_Hornady.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold, FontStyle.Regular, FontStyle.Regular)
            i = 2
            operace_checkbox()
            puškové_střely_H()
        Else
            checkbox_Hornady.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Regular, FontStyle.Regular, FontStyle.Regular)
            ListView1.Clear()
        End If
    End Sub

    Private Sub checkbox_Sierra_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_Sierra.CheckedChanged
        If checkbox_Sierra.Checked = True Then
            checkbox_Sierra.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold, FontStyle.Regular, FontStyle.Regular)
            i = 4
            operace_checkbox()
            puškové_střely_S()
        Else
            checkbox_Sierra.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Regular, FontStyle.Regular, FontStyle.Regular)
            ListView1.Clear()
        End If
    End Sub

    Private Sub checkbox_Berger_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_Berger.CheckedChanged
        If checkbox_Berger.Checked = True Then
            checkbox_Berger.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold, FontStyle.Regular, FontStyle.Regular)
            i = 5
            operace_checkbox()
            puškové_střely_B()
        Else
            checkbox_Berger.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Regular, FontStyle.Regular, FontStyle.Regular)
            ListView1.Clear()
        End If
    End Sub

    Private Sub checkbox_TNX_Puška_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_TNX_Puška.CheckedChanged
        If checkbox_TNX_Puška.Checked = True Then
            checkbox_TNX_Puška.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold, FontStyle.Regular, FontStyle.Regular)
            i = 10
            operace_checkbox()
            puškové_střely_TNX()
        Else
            checkbox_TNX_Puška.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Regular, FontStyle.Regular, FontStyle.Regular)
            ListView1.Clear()
        End If
    End Sub

    Private Sub checkbox_N_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_N.CheckedChanged
        If checkbox_N.Checked = True Then
            checkbox_N.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold, FontStyle.Regular, FontStyle.Regular)
            i = 6
            operace_checkbox()
            puškové_střely_N()
        Else
            checkbox_N.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Regular, FontStyle.Regular, FontStyle.Regular)
            ListView1.Clear()
        End If
    End Sub

    Private Sub checkbox_federal_puška_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_federal_puška.CheckedChanged
        If checkbox_federal_puška.Checked = True Then
            checkbox_federal_puška.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold, FontStyle.Regular, FontStyle.Regular)
            i = 7
            operace_checkbox()
            puškové_střely_federal()
        Else
            checkbox_federal_puška.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Regular, FontStyle.Regular, FontStyle.Regular)
            ListView1.Clear()
        End If
    End Sub

    Private Sub checkbox_FOX_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_FOX.CheckedChanged
        If checkbox_FOX.Checked = True Then
            checkbox_FOX.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold, FontStyle.Regular, FontStyle.Regular)
            i = 8
            operace_checkbox()
            puškové_střely_FOX()
        Else
            checkbox_FOX.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Regular, FontStyle.Regular, FontStyle.Regular)
            ListView1.Clear()
        End If
    End Sub

    Private Sub checkbox_SB_Pistole_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_SB_Pistole.CheckedChanged
        If checkbox_SB_Pistole.Checked = True Then
            checkbox_SB_Pistole.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold, FontStyle.Regular, FontStyle.Regular)
            i = 16
            operace_checkbox()
            pistolové_střely_SB()
        Else
            checkbox_SB_Pistole.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Regular, FontStyle.Regular, FontStyle.Regular)
            ListView1.Clear()
        End If
    End Sub

    Private Sub checkbox_LEE_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_LEE.CheckedChanged
        If checkbox_LEE.Checked = True Then
            checkbox_LEE.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold, FontStyle.Regular, FontStyle.Regular)
            i = 18
            operace_checkbox()
            pistolové_střely_LEE()
        Else
            checkbox_LEE.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Regular, FontStyle.Regular, FontStyle.Regular)
            ListView1.Clear()
        End If
    End Sub

    Private Sub checkbox_LOS_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_LOS.CheckedChanged
        If checkbox_LOS.Checked = True Then
            checkbox_LOS.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold, FontStyle.Regular, FontStyle.Regular)
            i = 19
            operace_checkbox()
            pistolové_střely_LOS()
        Else
            checkbox_LOS.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Regular, FontStyle.Regular, FontStyle.Regular)
            ListView1.Clear()
        End If

    End Sub

    Private Sub checkbox_TNX_Pistole_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_TNX_Pistole.CheckedChanged
        If checkbox_TNX_Pistole.Checked = True Then
            checkbox_TNX_Pistole.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold, FontStyle.Regular, FontStyle.Regular)
            i = 20
            operace_checkbox()
            pistolové_střely_TNX()
        Else
            checkbox_TNX_Pistole.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Regular, FontStyle.Regular, FontStyle.Regular)
            ListView1.Clear()
        End If
    End Sub

    Private Sub checkbox_diabolky_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_diabolky.CheckedChanged
        If checkbox_diabolky.Checked = True Then
            checkbox_diabolky.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold, FontStyle.Regular, FontStyle.Regular)
            i = 11
            operace_checkbox()
            diabolky()

        Else
            checkbox_diabolky.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Regular, FontStyle.Regular, FontStyle.Regular)
            ListView1.Clear()
        End If
    End Sub

    Private Sub checkbox_federal_malorážka_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_federal_malorážka.CheckedChanged
        If checkbox_federal_malorážka.Checked = True Then
            checkbox_federal_malorážka.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold, FontStyle.Regular, FontStyle.Regular)
            i = 13
            operace_checkbox()
            malorážkové_střely_federal()
        Else
            checkbox_federal_malorážka.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Regular, FontStyle.Regular, FontStyle.Regular)
            ListView1.Clear()
        End If
    End Sub
    Private Sub checkbox_SB_malorážka_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_SB_malorážka.CheckedChanged
        If checkbox_SB_malorážka.Checked = True Then
            checkbox_SB_malorážka.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold, FontStyle.Regular, FontStyle.Regular)
            i = 12
            operace_checkbox()
            malorážkové_střely_SB()
        Else
            checkbox_SB_malorážka.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Regular, FontStyle.Regular, FontStyle.Regular)
            ListView1.Clear()
        End If
    End Sub
    Private Sub checkbox_CCI_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_CCI.CheckedChanged
        If checkbox_CCI.Checked = True Then
            checkbox_CCI.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold, FontStyle.Regular, FontStyle.Regular)
            i = 14
            operace_checkbox()
            malorážkové_střely_CCI()
        Else
            checkbox_CCI.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Regular, FontStyle.Regular, FontStyle.Regular)
            ListView1.Clear()
        End If
    End Sub
    Private Sub checkbox_RWS_malorazka_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_RWS_malorazka.CheckedChanged
        If checkbox_RWS_malorazka.Checked = True Then
            checkbox_RWS_malorazka.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold, FontStyle.Regular, FontStyle.Regular)
            i = 15
            operace_checkbox()
            malorážkové_střely_RWS()

        Else
            checkbox_RWS_malorazka.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Regular, FontStyle.Regular, FontStyle.Regular)
            ListView1.Clear()
        End If
    End Sub
    Private Sub checkbox_RWS_puškové_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_RWS_puškové.CheckedChanged
        If checkbox_RWS_puškové.Checked = True Then
            checkbox_RWS_puškové.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold, FontStyle.Regular, FontStyle.Regular)
            i = 9
            operace_checkbox()
            puškové_střely_RWS()
        Else
            checkbox_RWS_puškové.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Regular, FontStyle.Regular, FontStyle.Regular)
            ListView1.Clear()
        End If
    End Sub
    Private Sub checkbox_federal_pistole_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_federal_pistole.CheckedChanged
        If checkbox_federal_pistole.Checked = True Then
            checkbox_federal_pistole.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold, FontStyle.Regular, FontStyle.Regular)
            i = 17
            operace_checkbox()
            pistolové_střely_federal()
        Else
            checkbox_federal_pistole.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Regular, FontStyle.Regular, FontStyle.Regular)
            ListView1.Clear()
        End If
    End Sub
    Private Sub checkbox_SK_malorážka_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_SK_malorážka.CheckedChanged
        If checkbox_SK_malorážka.Checked = True Then
            checkbox_SK_malorážka.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold, FontStyle.Regular, FontStyle.Regular)
            i = 21
            operace_checkbox()
            malorážkové_střely_SK()
        Else
            checkbox_SK_malorážka.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Regular, FontStyle.Regular, FontStyle.Regular)
            ListView1.Clear()
        End If
    End Sub
    Private Sub checkbox_H_pistole_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_H_pistole.CheckedChanged
        If checkbox_H_pistole.Checked = True Then
            checkbox_H_pistole.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Bold, FontStyle.Regular, FontStyle.Regular)
            i = 22
            operace_checkbox()
            pistolové_střely_Hornady()
        Else
            checkbox_H_pistole.Font = New Font("Microsoft Sans Serif", 16, FontStyle.Regular, FontStyle.Regular, FontStyle.Regular)
            ListView1.Clear()
        End If
    End Sub

    Private Sub pistolové_střely_Hornady()

        Dim x As Integer = 0

        ListView1.Columns.Add(0).Width = 237
        ListView1.Columns.Add(1).Width = 237
        ListView1.Columns.Add(2).Width = 237
        ListView1.Columns.Add(3).Width = 237

        ListView1.Columns(0).Text = "Bullet code and caliber"
        ListView1.Columns(1).Text = "Bullet type"
        ListView1.Columns(2).Text = "Bullet weight [grs]"
        ListView1.Columns(3).Text = "Ballistic coefficient G1"

        ListView1.Items.Add("35527B (9 mm)")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("100")
        ListView1.Items(x).SubItems.Add("0,158")
        x = x + 1

        ListView1.Items.Add("35557 (9 mm)")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("115")
        ListView1.Items(x).SubItems.Add("0,140")
        x = x + 1

        ListView1.Items.Add("355771 (9 mm)")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("124")
        ListView1.Items(x).SubItems.Add("0,145")
        x = x + 1

        ListView1.Items.Add("35597B (9 mm)")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("147")
        ListView1.Items(x).SubItems.Add("0,212")
        x = x + 1

        ListView1.Items.Add("40047 (10 mm)")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,188")
        x = x + 1

        ListView1.Items.Add("45177 (.45 inch)")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("230")
        ListView1.Items(x).SubItems.Add("0,184")
        x = x + 1

        ListView1.Items.Add("355281 (9 mm)")
        ListView1.Items(x).SubItems.Add("HAP")
        ListView1.Items(x).SubItems.Add("115")
        ListView1.Items(x).SubItems.Add("0,129")
        x = x + 1

        ListView1.Items.Add("355721 (9 mm)")
        ListView1.Items(x).SubItems.Add("HAP")
        ListView1.Items(x).SubItems.Add("125")
        ListView1.Items(x).SubItems.Add("0,158")
        x = x + 1

        ListView1.Items.Add("400421 (10 mm)")
        ListView1.Items(x).SubItems.Add("HAP")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,164")
        x = x + 1

        ListView1.Items.Add("40061B (10 mm)")
        ListView1.Items(x).SubItems.Add("HAP")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,199")
        x = x + 1

        ListView1.Items.Add("45105B (.45 inch)")
        ListView1.Items(x).SubItems.Add("HAP")
        ListView1.Items(x).SubItems.Add("185")
        ListView1.Items(x).SubItems.Add("0,139")
        x = x + 1

        ListView1.Items.Add("45159B (.45 inch)")
        ListView1.Items(x).SubItems.Add("HAP")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,151")
        x = x + 1

        ListView1.Items.Add("451611 (.45 inch)")
        ListView1.Items(x).SubItems.Add("HAP")
        ListView1.Items(x).SubItems.Add("230")
        ListView1.Items(x).SubItems.Add("0,188")
        x = x + 1

        ListView1.Items.Add("10208 (.38 inch)")
        ListView1.Items(x).SubItems.Add("Lead Bullets")
        ListView1.Items(x).SubItems.Add("148")
        ListView1.Items(x).SubItems.Add("0,047")
        x = x + 1

        ListView1.Items.Add("10408 (.38 inch)")
        ListView1.Items(x).SubItems.Add("Lead Bullets")
        ListView1.Items(x).SubItems.Add("158")
        ListView1.Items(x).SubItems.Add("0,135")
        x = x + 1

        ListView1.Items.Add("10428 (.38 inch)")
        ListView1.Items(x).SubItems.Add("Lead Bullets")
        ListView1.Items(x).SubItems.Add("158")
        ListView1.Items(x).SubItems.Add("0,139")
        x = x + 1

        ListView1.Items.Add("10508 (.38 inch)")
        ListView1.Items(x).SubItems.Add("Lead Bullets")
        ListView1.Items(x).SubItems.Add("158")
        ListView1.Items(x).SubItems.Add("0,159")
        x = x + 1

        ListView1.Items.Add("10458 (.45 inch)")
        ListView1.Items(x).SubItems.Add("Lead Bullets")
        ListView1.Items(x).SubItems.Add("255")
        ListView1.Items(x).SubItems.Add("0,117")
        x = x + 1

        ListView1.Items.Add("35745 (.38 inch)")
        ListView1.Items(x).SubItems.Add("FTX")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,160")
        x = x + 1

        ListView1.Items.Add("44105 (.44 inch)")
        ListView1.Items(x).SubItems.Add("FTX")
        ListView1.Items(x).SubItems.Add("225")
        ListView1.Items(x).SubItems.Add("0,150")
        x = x + 1

        ListView1.Items.Add("45215 (.45 inch)")
        ListView1.Items(x).SubItems.Add("FTX")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,145")
        x = x + 1

        ListView1.Items.Add("45218 (.45 inch)")
        ListView1.Items(x).SubItems.Add("FTX")
        ListView1.Items(x).SubItems.Add("225")
        ListView1.Items(x).SubItems.Add("0,145")
        x = x + 1

        ListView1.Items.Add("50102 (.50 inch)")
        ListView1.Items(x).SubItems.Add("FTX")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,200")
        x = x + 1

        ListView1.Items.Add("45220 (.45 inch)")
        ListView1.Items(x).SubItems.Add("XTP Mag")
        ListView1.Items(x).SubItems.Add("240")
        ListView1.Items(x).SubItems.Add("0,160")
        x = x + 1

        ListView1.Items.Add("45235 (.45 inch)")
        ListView1.Items(x).SubItems.Add("XTP Mag")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,200")
        x = x + 1

        ListView1.Items.Add("50100 (.50 inch)")
        ListView1.Items(x).SubItems.Add("XTP Mag")
        ListView1.Items(x).SubItems.Add("350")
        ListView1.Items(x).SubItems.Add("0,145")
        x = x + 1

        ListView1.Items.Add("31000 (.30 inch)")
        ListView1.Items(x).SubItems.Add("XTP")
        ListView1.Items(x).SubItems.Add("90")
        ListView1.Items(x).SubItems.Add("0,115")
        x = x + 1

        ListView1.Items.Add("32050 (.32 inch)")
        ListView1.Items(x).SubItems.Add("XTP")
        ListView1.Items(x).SubItems.Add("85")
        ListView1.Items(x).SubItems.Add("0,145")
        x = x + 1

        ListView1.Items.Add("32070 (.32 inch)")
        ListView1.Items(x).SubItems.Add("XTP")
        ListView1.Items(x).SubItems.Add("100")
        ListView1.Items(x).SubItems.Add("0,170")
        x = x + 1

        ListView1.Items.Add("35500 (9 mm)")
        ListView1.Items(x).SubItems.Add("XTP")
        ListView1.Items(x).SubItems.Add("90")
        ListView1.Items(x).SubItems.Add("0,099")
        x = x + 1

        ListView1.Items.Add("35540 (9 mm)")
        ListView1.Items(x).SubItems.Add("XTP")
        ListView1.Items(x).SubItems.Add("115")
        ListView1.Items(x).SubItems.Add("0,129")
        x = x + 1

        ListView1.Items.Add("35571 (9 mm)")
        ListView1.Items(x).SubItems.Add("XTP")
        ListView1.Items(x).SubItems.Add("124")
        ListView1.Items(x).SubItems.Add("0,165")
        x = x + 1

        ListView1.Items.Add("35580 (9 mm)")
        ListView1.Items(x).SubItems.Add("XTP")
        ListView1.Items(x).SubItems.Add("147")
        ListView1.Items(x).SubItems.Add("0,212")
        x = x + 1

        ListView1.Items.Add("35700 (.38 inch)")
        ListView1.Items(x).SubItems.Add("XTP")
        ListView1.Items(x).SubItems.Add("110")
        ListView1.Items(x).SubItems.Add("0,131")
        x = x + 1

        ListView1.Items.Add("35730 (.38 inch)")
        ListView1.Items(x).SubItems.Add("XTP")
        ListView1.Items(x).SubItems.Add("125")
        ListView1.Items(x).SubItems.Add("0,148")
        x = x + 1

        ListView1.Items.Add("35710 (.38 inch)")
        ListView1.Items(x).SubItems.Add("XTP")
        ListView1.Items(x).SubItems.Add("125")
        ListView1.Items(x).SubItems.Add("0,151")
        x = x + 1

        ListView1.Items.Add("35740 (.38 inch)")
        ListView1.Items(x).SubItems.Add("XTP")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,169")
        x = x + 1

        ListView1.Items.Add("35750 (.38 inch)")
        ListView1.Items(x).SubItems.Add("XTP")
        ListView1.Items(x).SubItems.Add("158")
        ListView1.Items(x).SubItems.Add("0,206")
        x = x + 1

        ListView1.Items.Add("35780 (.38 inch)")
        ListView1.Items(x).SubItems.Add("XTP")
        ListView1.Items(x).SubItems.Add("158")
        ListView1.Items(x).SubItems.Add("0,199")
        x = x + 1

        ListView1.Items.Add("35711 (.38 inch)")
        ListView1.Items(x).SubItems.Add("XTP")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,230")
        x = x + 1

        ListView1.Items.Add("40000 (10 mm)")
        ListView1.Items(x).SubItems.Add("XTP")
        ListView1.Items(x).SubItems.Add("155")
        ListView1.Items(x).SubItems.Add("0,137")
        x = x + 1

        ListView1.Items.Add("40040 (10 mm)")
        ListView1.Items(x).SubItems.Add("XTP")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,164")
        x = x + 1

        ListView1.Items.Add("40060 (10 mm)")
        ListView1.Items(x).SubItems.Add("XTP")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,199")
        x = x + 1

        ListView1.Items.Add("41000 (.41 inch)")
        ListView1.Items(x).SubItems.Add("XTP")
        ListView1.Items(x).SubItems.Add("210")
        ListView1.Items(x).SubItems.Add("0,182")
        x = x + 1

        ListView1.Items.Add("44050 (.44 inch)")
        ListView1.Items(x).SubItems.Add("XTP")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,138")
        x = x + 1

        ListView1.Items.Add("44100 (.44 inch)")
        ListView1.Items(x).SubItems.Add("XTP")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,170")
        x = x + 1

        ListView1.Items.Add("44200 (.44 inch)")
        ListView1.Items(x).SubItems.Add("XTP")
        ListView1.Items(x).SubItems.Add("240")
        ListView1.Items(x).SubItems.Add("0,205")
        x = x + 1

        ListView1.Items.Add("44280 (.44 inch)")
        ListView1.Items(x).SubItems.Add("XTP")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,245")
        x = x + 1

        ListView1.Items.Add("45100 (.45 inch)")
        ListView1.Items(x).SubItems.Add("XTP")
        ListView1.Items(x).SubItems.Add("185")
        ListView1.Items(x).SubItems.Add("0,139")
        x = x + 1

        ListView1.Items.Add("45140 (.45 inch)")
        ListView1.Items(x).SubItems.Add("XTP")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,151")
        x = x + 1

        ListView1.Items.Add("45160 (.45 inch)")
        ListView1.Items(x).SubItems.Add("XTP")
        ListView1.Items(x).SubItems.Add("230")
        ListView1.Items(x).SubItems.Add("0,188")
        x = x + 1

        ListView1.Items.Add("45200 (.45 inch)")
        ListView1.Items(x).SubItems.Add("XTP")
        ListView1.Items(x).SubItems.Add("250")
        ListView1.Items(x).SubItems.Add("0,146")
        x = x + 1

        ListView1.Items.Add("45230 (.45 inch)")
        ListView1.Items(x).SubItems.Add("XTP")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,180")
        x = x + 1

        ListView1.Items.Add("50101 (.50 inch)")
        ListView1.Items(x).SubItems.Add("XTP")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,120")
        x = x + 1

    End Sub
    Private Sub malorážkové_střely_federal()

        Dim x As Integer = 0

        ListView1.Columns.Add(0).Width = 237
        ListView1.Columns.Add(1).Width = 237
        ListView1.Columns.Add(2).Width = 237
        ListView1.Columns.Add(3).Width = 237

        ListView1.Columns(0).Text = "Bullet name and caliber"
        ListView1.Columns(1).Text = "Bullet type"
        ListView1.Columns(2).Text = "Bullet weight [grs]"
        ListView1.Columns(3).Text = "Ballistic coefficient G1"

        ListView1.Items.Add("V-Shok 17 HMR")
        ListView1.Items(x).SubItems.Add("V-Max")
        ListView1.Items(x).SubItems.Add("17")
        ListView1.Items(x).SubItems.Add("0,125")
        x = x + 1

        ListView1.Items.Add("V-Shok 17 HMR")
        ListView1.Items(x).SubItems.Add("Speer TNT HP")
        ListView1.Items(x).SubItems.Add("17")
        ListView1.Items(x).SubItems.Add("0,110")
        x = x + 1

        ListView1.Items.Add("V-Shok 22 WMR")
        ListView1.Items(x).SubItems.Add("Speer TNT HP")
        ListView1.Items(x).SubItems.Add("30")
        ListView1.Items(x).SubItems.Add("0,090")
        x = x + 1

        ListView1.Items.Add("Rimfire Suppressor 22 LR")
        ListView1.Items(x).SubItems.Add("LPRN")
        ListView1.Items(x).SubItems.Add("45")
        ListView1.Items(x).SubItems.Add("0,130")
        x = x + 1

        ListView1.Items.Add("Rimfire 22 LR")
        ListView1.Items(x).SubItems.Add("JHP")
        ListView1.Items(x).SubItems.Add("38")
        ListView1.Items(x).SubItems.Add("0,131")
        x = x + 1

        ListView1.Items.Add("Rimfire 22 LR")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,139")
        x = x + 1

        ListView1.Items.Add("Rimfire 17 WSM")
        ListView1.Items(x).SubItems.Add("Tipped Varmint")
        ListView1.Items(x).SubItems.Add("20")
        ListView1.Items(x).SubItems.Add("0,188")
        x = x + 1

        ListView1.Items.Add("Champion Rimfire 22 LR")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,138")
        x = x + 1

        ListView1.Items.Add("Champion Rimfire 22 LR")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("36")
        ListView1.Items(x).SubItems.Add("0,125")
        x = x + 1

        ListView1.Items.Add("Champion Rimfire 22 WMR")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,111")
        x = x + 1

        ListView1.Items.Add("BYOB 22 LR")
        ListView1.Items(x).SubItems.Add("CPHP")
        ListView1.Items(x).SubItems.Add("36")
        ListView1.Items(x).SubItems.Add("0,125")
        x = x + 1

        ListView1.Items.Add("BYOB 22 WMR")
        ListView1.Items(x).SubItems.Add("JHP")
        ListView1.Items(x).SubItems.Add("50")
        ListView1.Items(x).SubItems.Add("0,158")
        x = x + 1

        ListView1.Items.Add("BYOB 17 HMR")
        ListView1.Items(x).SubItems.Add("JHP")
        ListView1.Items(x).SubItems.Add("17")
        ListView1.Items(x).SubItems.Add("0,110")
        x = x + 1

        ListView1.Items.Add("Field Packs 22 LR")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,138")
        x = x + 1

        ListView1.Items.Add("Field Packs 22 LR")
        ListView1.Items(x).SubItems.Add("CPHP")
        ListView1.Items(x).SubItems.Add("38")
        ListView1.Items(x).SubItems.Add("0,131")
        x = x + 1

        ListView1.Items.Add("Game-Shok 22 LR")
        ListView1.Items(x).SubItems.Add("CPHP")
        ListView1.Items(x).SubItems.Add("31")
        ListView1.Items(x).SubItems.Add("0,107")
        x = x + 1

        ListView1.Items.Add("Game-Shok 22 WMR")
        ListView1.Items(x).SubItems.Add("JHP")
        ListView1.Items(x).SubItems.Add("50")
        ListView1.Items(x).SubItems.Add("0,158")
        x = x + 1

        ListView1.Items.Add("Game-Shok 22 LR")
        ListView1.Items(x).SubItems.Add("JHP")
        ListView1.Items(x).SubItems.Add("38")
        ListView1.Items(x).SubItems.Add("0,131")
        x = x + 1

        ListView1.Items.Add("Game-Shok 22 LR")
        ListView1.Items(x).SubItems.Add("CPRN")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,139")
        x = x + 1

        ListView1.Items.Add("Hunter Match 22 LR")
        ListView1.Items(x).SubItems.Add("HP")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,130")
        x = x + 1

        ListView1.Items.Add("Gold Medal Rimfire 22 LR")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,138")
        x = x + 1

    End Sub
    Private Sub pistolové_střely_federal()

        Dim x As Integer = 0

        ListView1.Columns.Add(0).Width = 237
        ListView1.Columns.Add(1).Width = 237
        ListView1.Columns.Add(2).Width = 237
        ListView1.Columns.Add(3).Width = 237

        ListView1.Columns(0).Text = "Bullet name and caliber"
        ListView1.Columns(1).Text = "Bullet type"
        ListView1.Columns(2).Text = "Bullet weight [grs]"
        ListView1.Columns(3).Text = "Ballistic coefficient G1"

        ListView1.Items.Add("Syntech 40 SW")
        ListView1.Items(x).SubItems.Add("FN")
        ListView1.Items(x).SubItems.Add("165")
        ListView1.Items(x).SubItems.Add("0,150")
        x = x + 1

        ListView1.Items.Add("Syntech 45 Auto")
        ListView1.Items(x).SubItems.Add("FN")
        ListView1.Items(x).SubItems.Add("230")
        ListView1.Items(x).SubItems.Add("0,190")
        x = x + 1

        ListView1.Items.Add("Hydra-Shok 9 mm")
        ListView1.Items(x).SubItems.Add("JHP")
        ListView1.Items(x).SubItems.Add("124")
        ListView1.Items(x).SubItems.Add("0,150")
        x = x + 1

        ListView1.Items.Add("Hydra-Shok 9 mm")
        ListView1.Items(x).SubItems.Add("JHP")
        ListView1.Items(x).SubItems.Add("147")
        ListView1.Items(x).SubItems.Add("0,200")
        x = x + 1

        ListView1.Items.Add("Hydra-Shok .357")
        ListView1.Items(x).SubItems.Add("JHP")
        ListView1.Items(x).SubItems.Add("129")
        ListView1.Items(x).SubItems.Add("0,170")
        x = x + 1

        ListView1.Items.Add("Hydra-Shok .357")
        ListView1.Items(x).SubItems.Add("JHP")
        ListView1.Items(x).SubItems.Add("158")
        ListView1.Items(x).SubItems.Add("0,200")
        x = x + 1

        ListView1.Items.Add("Hydra-Shok 10 mm")
        ListView1.Items(x).SubItems.Add("JHP")
        ListView1.Items(x).SubItems.Add("165")
        ListView1.Items(x).SubItems.Add("0,150")
        x = x + 1

        ListView1.Items.Add("Hydra-Shok 10 mm")
        ListView1.Items(x).SubItems.Add("JHP")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,170")
        x = x + 1

        ListView1.Items.Add("Hydra-Shok 45 Auto")
        ListView1.Items(x).SubItems.Add("JHP")
        ListView1.Items(x).SubItems.Add("185")
        ListView1.Items(x).SubItems.Add("0,150")
        x = x + 1

        ListView1.Items.Add("Hydra-Shok 45 Auto")
        ListView1.Items(x).SubItems.Add("JHP")
        ListView1.Items(x).SubItems.Add("230")
        ListView1.Items(x).SubItems.Add("0,190")
        x = x + 1

    End Sub
    Private Sub malorážkové_střely_CCI()

        Dim x As Integer = 0

        ListView1.Columns.Add(0).Width = 237
        ListView1.Columns.Add(1).Width = 237
        ListView1.Columns.Add(2).Width = 237
        ListView1.Columns.Add(3).Width = 237

        ListView1.Columns(0).Text = "Bullet name"
        ListView1.Columns(1).Text = "Bullet type"
        ListView1.Columns(2).Text = "Bullet weight [grs]"
        ListView1.Columns(3).Text = "Ballistic coefficient G1"

        ListView1.Items.Add("Standard velocity")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,112")
        x = x + 1

        ListView1.Items.Add("Maxi-Mag")
        ListView1.Items(x).SubItems.Add("TMJ")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,120")
        x = x + 1

        ListView1.Items.Add("SRG")
        ListView1.Items(x).SubItems.Add("Green HP")
        ListView1.Items(x).SubItems.Add("21")
        ListView1.Items(x).SubItems.Add("0,048")
        x = x + 1

        ListView1.Items.Add("Long HV")
        ListView1.Items(x).SubItems.Add("CPRN")
        ListView1.Items(x).SubItems.Add("29")
        ListView1.Items(x).SubItems.Add("0,079")
        x = x + 1

        ListView1.Items.Add("Mini-Mag HV")
        ListView1.Items(x).SubItems.Add("CPRN")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,127")
        x = x + 1

        ListView1.Items.Add("Short HV")
        ListView1.Items(x).SubItems.Add("CPRN")
        ListView1.Items(x).SubItems.Add("29")
        ListView1.Items(x).SubItems.Add("0,076")
        x = x + 1

        ListView1.Items.Add("Quiet-22")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,149")
        x = x + 1

        ListView1.Items.Add("AR Tactical")
        ListView1.Items(x).SubItems.Add("CPRN")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,112")
        x = x + 1

        ListView1.Items.Add("Clean-22 HV")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,127")
        x = x + 1

        ListView1.Items.Add("Clean-22 Subsonic")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,112")
        x = x + 1

        ListView1.Items.Add("17 HMR VNT")
        ListView1.Items(x).SubItems.Add("VNT")
        ListView1.Items(x).SubItems.Add("17")
        ListView1.Items(x).SubItems.Add("0,125")
        x = x + 1

        ListView1.Items.Add("22 WMR VNT(968CC)")
        ListView1.Items(x).SubItems.Add("VNT")
        ListView1.Items(x).SubItems.Add("30")
        ListView1.Items(x).SubItems.Add("0,081")
        x = x + 1

        ListView1.Items.Add("22 WMR VNT(969CC)")
        ListView1.Items(x).SubItems.Add("VNT")
        ListView1.Items(x).SubItems.Add("30")
        ListView1.Items(x).SubItems.Add("0,115")
        x = x + 1

        ListView1.Items.Add("Clean-22 Pink")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,127")
        x = x + 1

        ListView1.Items.Add("Green Tag")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,112")
        x = x + 1

        ListView1.Items.Add("Pistol Match")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,112")
        x = x + 1

        ListView1.Items.Add("Select")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,112")
        x = x + 1

        ListView1.Items.Add("Short Target")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("29")
        ListView1.Items(x).SubItems.Add("0,094")
        x = x + 1

    End Sub
    Private Sub malorážkové_střely_SK()

        Dim x As Integer = 0

        ListView1.Columns.Add(0).Width = 237
        ListView1.Columns.Add(1).Width = 237
        ListView1.Columns.Add(2).Width = 237
        ListView1.Columns.Add(3).Width = 237

        ListView1.Columns(0).Text = "Bullet name"
        ListView1.Columns(1).Text = "Bullet type"
        ListView1.Columns(2).Text = "Bullet weight [g]"
        ListView1.Columns(3).Text = "Ballistic coefficient G1"

        ListView1.Items.Add("Long Range Match")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("2,59")
        ListView1.Items(x).SubItems.Add("0,136")
        x = x + 1

        ListView1.Items.Add("Flatnose Match")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("2,59")
        ListView1.Items(x).SubItems.Add("0,113")
        x = x + 1

        ListView1.Items.Add("Flatnose Basic")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("2,59")
        ListView1.Items(x).SubItems.Add("0,113")
        x = x + 1

        ListView1.Items.Add("Rifle Match")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("2,59")
        ListView1.Items(x).SubItems.Add("0,145")
        x = x + 1

        ListView1.Items.Add("Pistol Match")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("2,59")
        ListView1.Items(x).SubItems.Add("0,126")
        x = x + 1

        ListView1.Items.Add("Pistol Match Special")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("2,59")
        ListView1.Items(x).SubItems.Add("0,131")
        x = x + 1

        ListView1.Items.Add("Biathlon Sport")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("2,59")
        ListView1.Items(x).SubItems.Add("0,151")
        x = x + 1

        ListView1.Items.Add("Standard Plus")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("2,59")
        ListView1.Items(x).SubItems.Add("0,145")
        x = x + 1

        ListView1.Items.Add("Magazine")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("2,59")
        ListView1.Items(x).SubItems.Add("0,145")
        x = x + 1

    End Sub
    Private Sub malorážkové_střely_RWS()

        Dim x As Integer = 0

        ListView1.Columns.Add(0).Width = 237
        ListView1.Columns.Add(1).Width = 237
        ListView1.Columns.Add(2).Width = 237
        ListView1.Columns.Add(3).Width = 237

        ListView1.Columns(0).Text = "Bullet name"
        ListView1.Columns(1).Text = "Bullet type"
        ListView1.Columns(2).Text = "Bullet weight [g]"
        ListView1.Columns(3).Text = "Ballistic coefficient G1"

        ListView1.Items.Add("R 100")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("2,6")
        ListView1.Items(x).SubItems.Add("0,102")
        x = x + 1

        ListView1.Items.Add("R 50")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("2,6")
        ListView1.Items(x).SubItems.Add("0,100")
        x = x + 1

        ListView1.Items.Add("Special Match")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("2,6")
        ListView1.Items(x).SubItems.Add("0,100")
        x = x + 1

        ListView1.Items.Add("Rifle Match S")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("2,6")
        ListView1.Items(x).SubItems.Add("0,102")
        x = x + 1

        ListView1.Items.Add("Rifle Match")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("2,6")
        ListView1.Items(x).SubItems.Add("0,100")
        x = x + 1

        ListView1.Items.Add("Pistol Match")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("2,6")
        ListView1.Items(x).SubItems.Add("0,128")
        x = x + 1

        ListView1.Items.Add("Pistol Match SR")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("2,6")
        ListView1.Items(x).SubItems.Add("0,133")
        x = x + 1

        ListView1.Items.Add("Semi Auto")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("2,6")
        ListView1.Items(x).SubItems.Add("0,104")
        x = x + 1

        ListView1.Items.Add("Club")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("2,6")
        ListView1.Items(x).SubItems.Add("0,098")
        x = x + 1

        ListView1.Items.Add("Target Rifle")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("2,6")
        ListView1.Items(x).SubItems.Add("0,100")
        x = x + 1

        ListView1.Items.Add("Target Pistol")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("2,6")
        ListView1.Items(x).SubItems.Add("0,111")
        x = x + 1

        ListView1.Items.Add("Z Lang")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("2,6")
        ListView1.Items(x).SubItems.Add("0,120")
        x = x + 1

        ListView1.Items.Add("Subsonic HP")
        ListView1.Items(x).SubItems.Add("LHP")
        ListView1.Items(x).SubItems.Add("2,6")
        ListView1.Items(x).SubItems.Add("0,108")
        x = x + 1

        ListView1.Items.Add("High Velocity")
        ListView1.Items(x).SubItems.Add("CPRN")
        ListView1.Items(x).SubItems.Add("2,6")
        ListView1.Items(x).SubItems.Add("0,104")
        x = x + 1

        ListView1.Items.Add("High Velocity HP")
        ListView1.Items(x).SubItems.Add("CPHP")
        ListView1.Items(x).SubItems.Add("2,6")
        ListView1.Items(x).SubItems.Add("0,104")
        x = x + 1

    End Sub
    Private Sub diabolky()

        Dim x As Integer = 0

        ListView1.Columns.Add(0).Width = 237
        ListView1.Columns.Add(1).Width = 237
        ListView1.Columns.Add(2).Width = 237
        ListView1.Columns.Add(3).Width = 237

        ListView1.Columns(0).Text = "Bullet caliber and name"
        ListView1.Columns(1).Text = "Bullet manufacturer"
        ListView1.Columns(2).Text = "Bullet weight [g]"
        ListView1.Columns(3).Text = "Ballistic coefficient JSBE"

        ListView1.Items.Add(".177 Exact Lead Free")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("0,440")
        ListView1.Items(x).SubItems.Add("0,027")
        x = x + 1

        ListView1.Items.Add(".177 Exact RS")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("0,475")
        ListView1.Items(x).SubItems.Add("0,033")
        x = x + 1

        ListView1.Items.Add(".177 Exact Express")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("0,510")
        ListView1.Items(x).SubItems.Add("0,037")
        x = x + 1

        ListView1.Items.Add(".177 Exact ")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("0,547")
        ListView1.Items(x).SubItems.Add("0,031")
        x = x + 1

        ListView1.Items.Add(".177 Exact Shorts")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("0,547")
        ListView1.Items(x).SubItems.Add("0,031")
        x = x + 1

        ListView1.Items.Add(".177 Exact Heavy")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("0,670")
        ListView1.Items(x).SubItems.Add("0,050")
        x = x + 1

        ListView1.Items.Add(".177 Exact Monster")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("0,870")
        ListView1.Items(x).SubItems.Add("0,063")
        x = x + 1

        ListView1.Items.Add(".177 Exact Monster Redesigned")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("0,870")
        ListView1.Items(x).SubItems.Add("0,065")
        x = x + 1

        ListView1.Items.Add(".177 Exact Beast")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("1,055")
        ListView1.Items(x).SubItems.Add("0,076")
        x = x + 1

        ListView1.Items.Add(".20 Exact")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("0,890")
        ListView1.Items(x).SubItems.Add("0,084")
        x = x + 1

        ListView1.Items.Add(".20 Exact Heavy ")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("1,030")
        ListView1.Items(x).SubItems.Add("0,104")
        x = x + 1

        ListView1.Items.Add(".22 Exact Jumbo Lead Free")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("0,760")
        ListView1.Items(x).SubItems.Add("0,051")
        x = x + 1

        ListView1.Items.Add(".22 Exact Jumbo Express")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("0,930")
        ListView1.Items(x).SubItems.Add("0,089")
        x = x + 1

        ListView1.Items.Add(".22 Exact Jumbo")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("1,030")
        ListView1.Items(x).SubItems.Add("0,067")
        x = x + 1

        ListView1.Items.Add(".22 Exact Jumbo Heavy")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("1,175")
        ListView1.Items(x).SubItems.Add("0,081")
        x = x + 1

        ListView1.Items.Add(".22 Exact Jumbo Monster ")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("1,645")
        ListView1.Items(x).SubItems.Add("0,112")
        x = x + 1

        ListView1.Items.Add(".22 Exact Jumbo M Redesigned")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("1,645")
        ListView1.Items(x).SubItems.Add("0,119")
        x = x + 1

        ListView1.Items.Add(".22 Exact Jumbo Beast")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("2,200")
        ListView1.Items(x).SubItems.Add("0,101")
        x = x + 1

        ListView1.Items.Add(".25 Exact King Lead Free")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("1,070")
        ListView1.Items(x).SubItems.Add("0,053")
        x = x + 1

        ListView1.Items.Add(".25 Exact King")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("1,645")
        ListView1.Items(x).SubItems.Add("0,077")
        x = x + 1

        ListView1.Items.Add(".25 Exact King Heavy")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("2,200")
        ListView1.Items(x).SubItems.Add("0,138")
        x = x + 1

        ListView1.Items.Add(".25 Exact King Heavy MK II")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("2,200")
        ListView1.Items(x).SubItems.Add("0,110")
        x = x + 1

        ListView1.Items.Add(".30 Exact Lead Free")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("2,120")
        ListView1.Items(x).SubItems.Add("0,060")
        x = x + 1

        ListView1.Items.Add(".30 Exact ")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("2,900")
        ListView1.Items(x).SubItems.Add("0,088")
        x = x + 1

        ListView1.Items.Add(".30 Exact ")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("3,250")
        ListView1.Items(x).SubItems.Add("0,100")
        x = x + 1

        ListView1.Items.Add(".35 Exact ")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("5,250")
        ListView1.Items(x).SubItems.Add("0,084")
        x = x + 1

        ListView1.Items.Add(".177 Match Lead Free")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("0,35")
        ListView1.Items(x).SubItems.Add("0,014")
        x = x + 1

        ListView1.Items.Add(".177 Match")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("0,475")
        ListView1.Items(x).SubItems.Add("0,018")
        x = x + 1

        ListView1.Items.Add(".177 Match")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("0,500")
        ListView1.Items(x).SubItems.Add("0,018")
        x = x + 1

        ListView1.Items.Add(".177 Match")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("0,520")
        ListView1.Items(x).SubItems.Add("0,023")
        x = x + 1

        ListView1.Items.Add(".177 Match S100")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("0,535")
        ListView1.Items(x).SubItems.Add("0,023")
        x = x + 1

        ListView1.Items.Add(".22 Match Jumbo")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("1,030")
        ListView1.Items(x).SubItems.Add("0,025")
        x = x + 1

        ListView1.Items.Add(".177 Straton")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("0,535")
        ListView1.Items(x).SubItems.Add("0,026")
        x = x + 1

        ListView1.Items.Add(".22 Straton Jumbo ")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("1,030")
        ListView1.Items(x).SubItems.Add("0,035")
        x = x + 1

        ListView1.Items.Add(".22 Straton Jumbo Monster ")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("1,645")
        ListView1.Items(x).SubItems.Add("0,059")
        x = x + 1

        ListView1.Items.Add(".177 Hades")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("0,670")
        ListView1.Items(x).SubItems.Add("0,060")
        x = x + 1

        ListView1.Items.Add(".22 Hades")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("1,030")
        ListView1.Items(x).SubItems.Add("0,053")
        x = x + 1

        ListView1.Items.Add(".30 Hades")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("2,900")
        ListView1.Items(x).SubItems.Add("0,076")
        x = x + 1

        ListView1.Items.Add(".35 Hades")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("5,000")
        ListView1.Items(x).SubItems.Add("0,090")
        x = x + 1

        ListView1.Items.Add(".177 Ultra Shock Heavy")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("0,670")
        ListView1.Items(x).SubItems.Add("0,022")
        x = x + 1

        ListView1.Items.Add(".22 Ultra Shock Jumbo")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("1,645")
        ListView1.Items(x).SubItems.Add("0,059")
        x = x + 1

        ListView1.Items.Add(".177 Predator Polymag")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("0,520")
        ListView1.Items(x).SubItems.Add("0,029")
        x = x + 1

        ListView1.Items.Add(".177 Predator Metalmag")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("0,520")
        ListView1.Items(x).SubItems.Add("0,029")
        x = x + 1

        ListView1.Items.Add(".177 Predator Polymag Shorts")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("0,520")
        ListView1.Items(x).SubItems.Add("0,039")
        x = x + 1

        ListView1.Items.Add(".20 Predator Polymag")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("0,900")
        ListView1.Items(x).SubItems.Add("0,060")
        x = x + 1

        ListView1.Items.Add(".22 Predator Polymag")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("1,030")
        ListView1.Items(x).SubItems.Add("0,064")
        x = x + 1

        ListView1.Items.Add(".22 Predator Polymag Shorts")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("1,030")
        ListView1.Items(x).SubItems.Add("0,064")
        x = x + 1

        ListView1.Items.Add(".22 Predator Metalmag")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("1,030")
        ListView1.Items(x).SubItems.Add("0,064")
        x = x + 1

        ListView1.Items.Add(".25 Predator Polymag")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("1,645")
        ListView1.Items(x).SubItems.Add("0,054")
        x = x + 1

        ListView1.Items.Add(".30 Predator Polymag")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("2,900")
        ListView1.Items(x).SubItems.Add("0,060")
        x = x + 1

        ListView1.Items.Add(".35 Predator Polymag")
        ListView1.Items(x).SubItems.Add("JSB")
        ListView1.Items(x).SubItems.Add("5,250")
        ListView1.Items(x).SubItems.Add("0,087")
        x = x + 1

    End Sub
    Private Sub puškové_střely_RWS()

        Dim x As Integer = 0

        ListView1.Columns.Add(0).Width = 237
        ListView1.Columns.Add(1).Width = 237
        ListView1.Columns.Add(2).Width = 237
        ListView1.Columns.Add(3).Width = 237

        ListView1.Columns(0).Text = "Bullet caliber"
        ListView1.Columns(1).Text = "Bullet type"
        ListView1.Columns(2).Text = "Bullet weight [g]"
        ListView1.Columns(3).Text = "Ballistic coefficient G7"

        ListView1.Items.Add("223 Rem")
        ListView1.Items(x).SubItems.Add("BTHP")
        ListView1.Items(x).SubItems.Add("3,36")
        ListView1.Items(x).SubItems.Add("0,105")
        x = x + 1

        ListView1.Items.Add("223 Rem")
        ListView1.Items(x).SubItems.Add("BTHP")
        ListView1.Items(x).SubItems.Add("5,0")
        ListView1.Items(x).SubItems.Add("0,225")
        x = x + 1

        ListView1.Items.Add("308 Win")
        ListView1.Items(x).SubItems.Add("BTHP")
        ListView1.Items(x).SubItems.Add("10,0")
        ListView1.Items(x).SubItems.Add("0,208")
        x = x + 1

        ListView1.Items.Add("308 Win")
        ListView1.Items(x).SubItems.Add("BTHP")
        ListView1.Items(x).SubItems.Add("10,9")
        ListView1.Items(x).SubItems.Add("0,228")
        x = x + 1

        ListView1.Items.Add("308 Win")
        ListView1.Items(x).SubItems.Add("BTHP")
        ListView1.Items(x).SubItems.Add("12,3")
        ListView1.Items(x).SubItems.Add("0,270")
        x = x + 1

        ListView1.Items.Add("300 Win Mag.")
        ListView1.Items(x).SubItems.Add("BTHP")
        ListView1.Items(x).SubItems.Add("11,3")
        ListView1.Items(x).SubItems.Add("0,254")
        x = x + 1

        ListView1.Items.Add("300 Win Mag.")
        ListView1.Items(x).SubItems.Add("BTHP")
        ListView1.Items(x).SubItems.Add("12,3")
        ListView1.Items(x).SubItems.Add("0,269")
        x = x + 1

        ListView1.Items.Add("338 Lapua Mag.")
        ListView1.Items(x).SubItems.Add("BTHP")
        ListView1.Items(x).SubItems.Add("19,4")
        ListView1.Items(x).SubItems.Add("0,360")
        x = x + 1

        ListView1.Items.Add("6,5 Creedmoor")
        ListView1.Items(x).SubItems.Add("BTHP")
        ListView1.Items(x).SubItems.Add("8,4")
        ListView1.Items(x).SubItems.Add("0,281")
        x = x + 1

        ListView1.Items.Add("6,5x55 SE")
        ListView1.Items(x).SubItems.Add("BTHP")
        ListView1.Items(x).SubItems.Add("8,4")
        ListView1.Items(x).SubItems.Add("0,284")
        x = x + 1

    End Sub

    Private Sub puškové_střely_federal()

        Dim x As Integer = 0

        ListView1.Columns.Add(0).Width = 237
        ListView1.Columns.Add(1).Width = 237
        ListView1.Columns.Add(2).Width = 237
        ListView1.Columns.Add(3).Width = 237

        ListView1.Columns(0).Text = "Bullet caliber"
        ListView1.Columns(1).Text = "Bullet type"
        ListView1.Columns(2).Text = "Bullet weight [grs]"
        ListView1.Columns(3).Text = "Ballistic coefficient G1"

        ListView1.Items.Add(".277")
        ListView1.Items(x).SubItems.Add("Edge TLR")
        ListView1.Items(x).SubItems.Add("136")
        ListView1.Items(x).SubItems.Add("0,508")
        x = x + 1

        ListView1.Items.Add(".284")
        ListView1.Items(x).SubItems.Add("Edge TLR")
        ListView1.Items(x).SubItems.Add("155")
        ListView1.Items(x).SubItems.Add("0,610")
        x = x + 1

        ListView1.Items.Add(".308")
        ListView1.Items(x).SubItems.Add("Edge TLR")
        ListView1.Items(x).SubItems.Add("175")
        ListView1.Items(x).SubItems.Add("0,536")
        x = x + 1

        ListView1.Items.Add(".308")
        ListView1.Items(x).SubItems.Add("Edge TLR")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,625")
        x = x + 1

        ListView1.Items.Add(".264")
        ListView1.Items(x).SubItems.Add("Fusion")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,497")
        x = x + 1

        ListView1.Items.Add(".277")
        ListView1.Items(x).SubItems.Add("Fusion")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,367")
        x = x + 1

        ListView1.Items.Add(".277")
        ListView1.Items(x).SubItems.Add("Fusion")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,413")
        x = x + 1

        ListView1.Items.Add(".284")
        ListView1.Items(x).SubItems.Add("Fusion")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,416")
        x = x + 1

        ListView1.Items.Add(".284")
        ListView1.Items(x).SubItems.Add("Fusion")
        ListView1.Items(x).SubItems.Add("160")
        ListView1.Items(x).SubItems.Add("0,455")
        x = x + 1

        ListView1.Items.Add(".284")
        ListView1.Items(x).SubItems.Add("Fusion")
        ListView1.Items(x).SubItems.Add("175")
        ListView1.Items(x).SubItems.Add("0,537")
        x = x + 1

        ListView1.Items.Add(".308")
        ListView1.Items(x).SubItems.Add("Fusion")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,387")
        x = x + 1

        ListView1.Items.Add(".308")
        ListView1.Items(x).SubItems.Add("Fusion")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,483")
        x = x + 1

        ListView1.Items.Add(".338")
        ListView1.Items(x).SubItems.Add("Fusion")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,461")
        x = x + 1

        ListView1.Items.Add(".338")
        ListView1.Items(x).SubItems.Add("Fusion")
        ListView1.Items(x).SubItems.Add("225")
        ListView1.Items(x).SubItems.Add("0,491")
        x = x + 1

        ListView1.Items.Add(".277")
        ListView1.Items(x).SubItems.Add("Trophy Bonded Tip")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,440")
        x = x + 1

        ListView1.Items.Add(".277")
        ListView1.Items(x).SubItems.Add("Trophy Bonded Tip")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,455")
        x = x + 1

        ListView1.Items.Add(".284")
        ListView1.Items(x).SubItems.Add("Trophy Bonded Tip")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,430")
        x = x + 1

        ListView1.Items.Add(".284")
        ListView1.Items(x).SubItems.Add("Trophy Bonded Tip")
        ListView1.Items(x).SubItems.Add("160")
        ListView1.Items(x).SubItems.Add("0,520")
        x = x + 1

        ListView1.Items.Add(".308")
        ListView1.Items(x).SubItems.Add("Trophy Bonded Tip")
        ListView1.Items(x).SubItems.Add("165")
        ListView1.Items(x).SubItems.Add("0,450")
        x = x + 1

        ListView1.Items.Add(".308")
        ListView1.Items(x).SubItems.Add("Trophy Bonded Tip")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,500")
        x = x + 1

        ListView1.Items.Add(".474")
        ListView1.Items(x).SubItems.Add("Sledgehammer Solid")
        ListView1.Items(x).SubItems.Add("500")
        ListView1.Items(x).SubItems.Add("0,280")
        x = x + 1

        ListView1.Items.Add(".375")
        ListView1.Items(x).SubItems.Add("Sledgehammer Solid")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,253")
        x = x + 1

        ListView1.Items.Add(".375")
        ListView1.Items(x).SubItems.Add("Bear Claw")
        ListView1.Items(x).SubItems.Add("250")
        ListView1.Items(x).SubItems.Add("0,340")
        x = x + 1

        ListView1.Items.Add(".375")
        ListView1.Items(x).SubItems.Add("Bear Claw")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,342")
        x = x + 1

        ListView1.Items.Add(".416")
        ListView1.Items(x).SubItems.Add("Bear Claw")
        ListView1.Items(x).SubItems.Add("400")
        ListView1.Items(x).SubItems.Add("0,737")
        x = x + 1

        ListView1.Items.Add(".474")
        ListView1.Items(x).SubItems.Add("Bear Claw")
        ListView1.Items(x).SubItems.Add("500")
        ListView1.Items(x).SubItems.Add("0,299")
        x = x + 1

    End Sub
    Private Sub puškové_střely_FOX()

        Dim x As Integer = 0

        ListView1.Columns.Add(0).Width = 237
        ListView1.Columns.Add(1).Width = 237
        ListView1.Columns.Add(2).Width = 237
        ListView1.Columns.Add(3).Width = 237

        ListView1.Columns(0).Text = "Bullet caliber"
        ListView1.Columns(1).Text = "Bullet type"
        ListView1.Columns(2).Text = "Bullet weight [grs]"
        ListView1.Columns(3).Text = "Ballistic coefficient G1"

        ListView1.Items.Add(".222 Rem")
        ListView1.Items(x).SubItems.Add("Fox Classic hunter")
        ListView1.Items(x).SubItems.Add("45")
        ListView1.Items(x).SubItems.Add("0,164")
        x = x + 1

        ListView1.Items.Add(".223 Rem")
        ListView1.Items(x).SubItems.Add("Fox Classic hunter")
        ListView1.Items(x).SubItems.Add("55")
        ListView1.Items(x).SubItems.Add("0,184")
        x = x + 1

        ListView1.Items.Add(".223 Rem")
        ListView1.Items(x).SubItems.Add("Fox Classic hunter")
        ListView1.Items(x).SubItems.Add("50")
        ListView1.Items(x).SubItems.Add("0,174")
        x = x + 1

        ListView1.Items.Add("243 win")
        ListView1.Items(x).SubItems.Add("Fox Classic hunter")
        ListView1.Items(x).SubItems.Add("80")
        ListView1.Items(x).SubItems.Add("0,290")
        x = x + 1

        ListView1.Items.Add("6,5 mm")
        ListView1.Items(x).SubItems.Add("Fox Classic hunter")
        ListView1.Items(x).SubItems.Add("100")
        ListView1.Items(x).SubItems.Add("0,296")
        x = x + 1

        ListView1.Items.Add("6,5 mm")
        ListView1.Items(x).SubItems.Add("Fox Classic hunter")
        ListView1.Items(x).SubItems.Add("123")
        ListView1.Items(x).SubItems.Add("0,389")
        x = x + 1

        ListView1.Items.Add("270 win")
        ListView1.Items(x).SubItems.Add("Fox Classic hunter")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,334")
        x = x + 1

        ListView1.Items.Add("7 mm")
        ListView1.Items(x).SubItems.Add("Fox Classic hunter")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,339")
        x = x + 1

        ListView1.Items.Add("30-06 Spring.")
        ListView1.Items(x).SubItems.Add("Fox Classic hunter")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,320")
        x = x + 1

        ListView1.Items.Add("30-06 Spring.")
        ListView1.Items(x).SubItems.Add("Fox Classic hunter")
        ListView1.Items(x).SubItems.Add("165")
        ListView1.Items(x).SubItems.Add("0,365")
        x = x + 1

        ListView1.Items.Add("30-06 Spring.")
        ListView1.Items(x).SubItems.Add("Fox Classic hunter")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,408")
        x = x + 1

        ListView1.Items.Add("308 win")
        ListView1.Items(x).SubItems.Add("Fox Classic hunter")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,258")
        x = x + 1

        ListView1.Items.Add("308 win")
        ListView1.Items(x).SubItems.Add("Fox Classic hunter")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,323")
        x = x + 1

        ListView1.Items.Add("308 win")
        ListView1.Items(x).SubItems.Add("Fox Classic hunter")
        ListView1.Items(x).SubItems.Add("165")
        ListView1.Items(x).SubItems.Add("0,359")
        x = x + 1

        ListView1.Items.Add("8 mm")
        ListView1.Items(x).SubItems.Add("Fox Classic hunter")
        ListView1.Items(x).SubItems.Add("160")
        ListView1.Items(x).SubItems.Add("0,303")
        x = x + 1

        ListView1.Items.Add("9,3 mm")
        ListView1.Items(x).SubItems.Add("Fox Classic hunter")
        ListView1.Items(x).SubItems.Add("220")
        ListView1.Items(x).SubItems.Add("0,304")
        x = x + 1

    End Sub

    Private Sub pistolové_střely_LOS()

        Dim x As Integer = 0

        ListView1.Columns.Add(0).Width = 237
        ListView1.Columns.Add(1).Width = 237
        ListView1.Columns.Add(2).Width = 237
        ListView1.Columns.Add(3).Width = 237

        ListView1.Columns(0).Text = "Bullet name"
        ListView1.Columns(1).Text = "Bullet type"
        ListView1.Columns(2).Text = "Bullet weight [grs]"
        ListView1.Columns(3).Text = "Ballistic coefficient G1"

        ListView1.Items.Add("123 HP (9 mm)")
        ListView1.Items(x).SubItems.Add("HP")
        ListView1.Items(x).SubItems.Add("123")
        ListView1.Items(x).SubItems.Add("0,083")
        x = x + 1

        ListView1.Items.Add("145 HP (9 mm)")
        ListView1.Items(x).SubItems.Add("HP")
        ListView1.Items(x).SubItems.Add("145")
        ListView1.Items(x).SubItems.Add("0,101")
        x = x + 1

        ListView1.Items.Add("180 HP (.38 Special)")
        ListView1.Items(x).SubItems.Add("HP")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,125")
        x = x + 1

        ListView1.Items.Add("148 WC (.38 Special)")
        ListView1.Items(x).SubItems.Add("WC")
        ListView1.Items(x).SubItems.Add("148")
        ListView1.Items(x).SubItems.Add("0,052")
        x = x + 1

        ListView1.Items.Add("158 RNFP (.38 Special)")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("158")
        ListView1.Items(x).SubItems.Add("0,120")
        x = x + 1

    End Sub
    Private Sub puškové_střely_N()

        Dim x As Integer = 0

        ListView1.Columns.Add(0).Width = 237
        ListView1.Columns.Add(1).Width = 237
        ListView1.Columns.Add(2).Width = 237
        ListView1.Columns.Add(3).Width = 237

        ListView1.Columns(0).Text = "Bullet name and caliber"
        ListView1.Columns(1).Text = "Bullet type"
        ListView1.Columns(2).Text = "Bullet weight [grs]"
        ListView1.Columns(3).Text = "Ballistic coefficient G1"

        ListView1.Items.Add("AccuBond 6 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("90")
        ListView1.Items(x).SubItems.Add("0,376")
        x = x + 1

        ListView1.Items.Add("AccuBond .25 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("110")
        ListView1.Items(x).SubItems.Add("0,418")
        x = x + 1

        ListView1.Items.Add("AccuBond 6,5 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,488")
        x = x + 1

        ListView1.Items.Add("AccuBond 6,5 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,509")
        x = x + 1

        ListView1.Items.Add("AccuBond 6,8 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("100")
        ListView1.Items(x).SubItems.Add("0,323")
        x = x + 1

        ListView1.Items.Add("AccuBond 6,8 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("110")
        ListView1.Items(x).SubItems.Add("0,370")
        x = x + 1

        ListView1.Items.Add("AccuBond .270 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,435")
        x = x + 1

        ListView1.Items.Add("AccuBond .270 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,496")
        x = x + 1

        ListView1.Items.Add("AccuBond 7 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,485")
        x = x + 1

        ListView1.Items.Add("AccuBond 7 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("160")
        ListView1.Items(x).SubItems.Add("0,531")
        x = x + 1

        ListView1.Items.Add("AccuBond .30 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("125")
        ListView1.Items(x).SubItems.Add("0,366")
        x = x + 1

        ListView1.Items.Add("AccuBond .30 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,435")
        x = x + 1

        ListView1.Items.Add("AccuBond .30 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("165")
        ListView1.Items(x).SubItems.Add("0,475")
        x = x + 1

        ListView1.Items.Add("AccuBond .30 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,507")
        x = x + 1

        ListView1.Items.Add("AccuBond .30 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,588")
        x = x + 1

        ListView1.Items.Add("AccuBond 8 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,450")
        x = x + 1

        ListView1.Items.Add("AccuBond .338 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,372")
        x = x + 1

        ListView1.Items.Add("AccuBond .338 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,414")
        x = x + 1

        ListView1.Items.Add("AccuBond .338 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("225")
        ListView1.Items(x).SubItems.Add("0,550")
        x = x + 1

        ListView1.Items.Add("AccuBond .338 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("250")
        ListView1.Items(x).SubItems.Add("0,575")
        x = x + 1

        ListView1.Items.Add("AccuBond .338 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,720")
        x = x + 1

        ListView1.Items.Add("AccuBond Whelen .35 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,356")
        x = x + 1

        ListView1.Items.Add("AccuBond .35 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("225")
        ListView1.Items(x).SubItems.Add("0,421")
        x = x + 1

        ListView1.Items.Add("AccuBond 9,3 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("250")
        ListView1.Items(x).SubItems.Add("0,494")
        x = x + 1

        ListView1.Items.Add("AccuBond .375 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("260")
        ListView1.Items(x).SubItems.Add("0,473")
        x = x + 1

        ListView1.Items.Add("AccuBond .375 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,485")
        x = x + 1

        ListView1.Items.Add("AccuBond LR 6,5 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("129")
        ListView1.Items(x).SubItems.Add("0,561")
        x = x + 1

        ListView1.Items.Add("AccuBond LR 6,5 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("142")
        ListView1.Items(x).SubItems.Add("0,719")
        x = x + 1

        ListView1.Items.Add("AccuBond LR .270 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,625")
        x = x + 1

        ListView1.Items.Add("AccuBond LR 7 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,611")
        x = x + 1

        ListView1.Items.Add("AccuBond LR 7 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("168")
        ListView1.Items(x).SubItems.Add("0,652")
        x = x + 1

        ListView1.Items.Add("AccuBond LR 7 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("175")
        ListView1.Items(x).SubItems.Add("0,672")
        x = x + 1

        ListView1.Items.Add("AccuBond LR .30 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("190")
        ListView1.Items(x).SubItems.Add("0,640")
        x = x + 1

        ListView1.Items.Add("AccuBond LR .30 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("210")
        ListView1.Items(x).SubItems.Add("0,730")
        x = x + 1

        ListView1.Items.Add("Ballistic Tip 6 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("90")
        ListView1.Items(x).SubItems.Add("0,365")
        x = x + 1

        ListView1.Items.Add("Ballistic Tip 6 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("95")
        ListView1.Items(x).SubItems.Add("0,379")
        x = x + 1

        ListView1.Items.Add("Ballistic Tip .25 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("100")
        ListView1.Items(x).SubItems.Add("0,393")
        x = x + 1

        ListView1.Items.Add("Ballistic Tip .25 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("115")
        ListView1.Items(x).SubItems.Add("0,453")
        x = x + 1

        ListView1.Items.Add("Ballistic Tip 6,5 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("100")
        ListView1.Items(x).SubItems.Add("0,350")
        x = x + 1

        ListView1.Items.Add("Ballistic Tip 6,5 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("120")
        ListView1.Items(x).SubItems.Add("0,458")
        x = x + 1

        ListView1.Items.Add("Ballistic Tip 6,5 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,509")
        x = x + 1

        ListView1.Items.Add("Ballistic Tip .270 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,433")
        x = x + 1

        ListView1.Items.Add("Ballistic Tip .270 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,456")
        x = x + 1

        ListView1.Items.Add("Ballistic Tip .270 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,496")
        x = x + 1

        ListView1.Items.Add("Ballistic Tip 7 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("120")
        ListView1.Items(x).SubItems.Add("0,417")
        x = x + 1

        ListView1.Items.Add("Ballistic Tip 7 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,485")
        x = x + 1

        ListView1.Items.Add("Ballistic Tip 7 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,493")
        x = x + 1

        ListView1.Items.Add("Ballistic Tip .30 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("125")
        ListView1.Items(x).SubItems.Add("0,366")
        x = x + 1

        ListView1.Items.Add("Ballistic Tip .30 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,435")
        x = x + 1

        ListView1.Items.Add("Ballistic Tip .30 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("165")
        ListView1.Items(x).SubItems.Add("0,475")
        x = x + 1

        ListView1.Items.Add("Ballistic Tip .30 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("168")
        ListView1.Items(x).SubItems.Add("0,490")
        x = x + 1

        ListView1.Items.Add("Ballistic Tip .30 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,507")
        x = x + 1

        ListView1.Items.Add("Ballistic Tip 8 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,394")
        x = x + 1

        ListView1.Items.Add("Ballistic Tip .458 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,250")
        x = x + 1

        ListView1.Items.Add("Ballistic Tip Varmint .204 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("32")
        ListView1.Items(x).SubItems.Add("0,206")
        x = x + 1

        ListView1.Items.Add("Ballistic Tip Varmint .204 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,239")
        x = x + 1

        ListView1.Items.Add("Ballistic Tip Varmint .22 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,221")
        x = x + 1

        ListView1.Items.Add("Ballistic Tip Varmint .22 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("50")
        ListView1.Items(x).SubItems.Add("0,238")
        x = x + 1

        ListView1.Items.Add("Ballistic Tip Varmint .22 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("55")
        ListView1.Items(x).SubItems.Add("0,267")
        x = x + 1

        ListView1.Items.Add("Ballistic Tip Varmint .22 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("60")
        ListView1.Items(x).SubItems.Add("0,270")
        x = x + 1

        ListView1.Items.Add("Ballistic Tip Varmint 6 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("55")
        ListView1.Items(x).SubItems.Add("0,276")
        x = x + 1

        ListView1.Items.Add("Ballistic Tip Varmint 6 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("70")
        ListView1.Items(x).SubItems.Add("0,310")
        x = x + 1

        ListView1.Items.Add("Ballistic Tip Varmint 6 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("80")
        ListView1.Items(x).SubItems.Add("0,329")
        x = x + 1

        ListView1.Items.Add("Ballistic Tip Varmint .25 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("85")
        ListView1.Items(x).SubItems.Add("0,329")
        x = x + 1

        ListView1.Items.Add("Bonded Solid Base .22 inch")
        ListView1.Items(x).SubItems.Add("PP")
        ListView1.Items(x).SubItems.Add("64")
        ListView1.Items(x).SubItems.Add("0,231")
        x = x + 1

        ListView1.Items.Add("Bonded Solid Base 6,8 mm")
        ListView1.Items(x).SubItems.Add("PP")
        ListView1.Items(x).SubItems.Add("90")
        ListView1.Items(x).SubItems.Add("0,227")
        x = x + 1

        ListView1.Items.Add("Bonded Solid Base .30 inch")
        ListView1.Items(x).SubItems.Add("PP")
        ListView1.Items(x).SubItems.Add("168")
        ListView1.Items(x).SubItems.Add("0,350")
        x = x + 1

        ListView1.Items.Add("BTLF .204 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("32")
        ListView1.Items(x).SubItems.Add("0,228")
        x = x + 1

        ListView1.Items.Add("BTLF .22 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("35")
        ListView1.Items(x).SubItems.Add("0,201")
        x = x + 1

        ListView1.Items.Add("BTLF .22 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,220")
        x = x + 1

        ListView1.Items.Add("BTLF .22 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("50")
        ListView1.Items(x).SubItems.Add("0,251")
        x = x + 1

        ListView1.Items.Add("BTLF 6 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("55")
        ListView1.Items(x).SubItems.Add("0,288")
        x = x + 1

        ListView1.Items.Add("BTMZ .50 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,250")
        x = x + 1

        ListView1.Items.Add("CTBST 6 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("95")
        ListView1.Items(x).SubItems.Add("0,379")
        x = x + 1

        ListView1.Items.Add("CTBST .25 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("115")
        ListView1.Items(x).SubItems.Add("0,453")
        x = x + 1

        ListView1.Items.Add("CTBST .270 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,433")
        x = x + 1

        ListView1.Items.Add("CTBST .270 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,496")
        x = x + 1

        ListView1.Items.Add("CTBST 7 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,485")
        x = x + 1

        ListView1.Items.Add("CTBST 7 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,493")
        x = x + 1

        ListView1.Items.Add("CTBST .30 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,435")
        x = x + 1

        ListView1.Items.Add("CTBST .30 inch")
        ListView1.Items(x).SubItems.Add("RN")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,232")
        x = x + 1

        ListView1.Items.Add("CTBST .30 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("168")
        ListView1.Items(x).SubItems.Add("0,490")
        x = x + 1

        ListView1.Items.Add("CTBST .30 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,507")
        x = x + 1

        ListView1.Items.Add("CTBST .338 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,414")
        x = x + 1

        ListView1.Items.Add("CTBST .45 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,191")
        x = x + 1

        ListView1.Items.Add("CTBSTV .22 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("50")
        ListView1.Items(x).SubItems.Add("0,238")
        x = x + 1

        ListView1.Items.Add("CTBSTV .22 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("55")
        ListView1.Items(x).SubItems.Add("0,267")
        x = x + 1

        ListView1.Items.Add("CTBSTV 6 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("55")
        ListView1.Items(x).SubItems.Add("0,276")
        x = x + 1

        ListView1.Items.Add("Custom Competition .22 inch")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("52")
        ListView1.Items(x).SubItems.Add("0,220")
        x = x + 1

        ListView1.Items.Add("Custom Competition .22 inch")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("69")
        ListView1.Items(x).SubItems.Add("0,305")
        x = x + 1

        ListView1.Items.Add("Custom Competition .22 inch")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("77")
        ListView1.Items(x).SubItems.Add("0,340")
        x = x + 1

        ListView1.Items.Add("Custom Competition .22 inch")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("80")
        ListView1.Items(x).SubItems.Add("0,415")
        x = x + 1

        ListView1.Items.Add("Custom Competition 6 mm")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("105")
        ListView1.Items(x).SubItems.Add("0,517")
        x = x + 1

        ListView1.Items.Add("Custom Competition 6 mm")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("107")
        ListView1.Items(x).SubItems.Add("0,525")
        x = x + 1

        ListView1.Items.Add("Custom Competition 6,5 mm")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("123")
        ListView1.Items(x).SubItems.Add("0,510")
        x = x + 1

        ListView1.Items.Add("Custom Competition 6,5 mm")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,529")
        x = x + 1

        ListView1.Items.Add("Custom Competition 6,8 mm")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("115")
        ListView1.Items(x).SubItems.Add("0,375")
        x = x + 1

        ListView1.Items.Add("Custom Competition 7 mm")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("168")
        ListView1.Items(x).SubItems.Add("0,520")
        x = x + 1

        ListView1.Items.Add("Custom Competition .30 inch")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,396")
        x = x + 1

        ListView1.Items.Add("Custom Competition .30 inch")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("155")
        ListView1.Items(x).SubItems.Add("0,450")
        x = x + 1

        ListView1.Items.Add("Custom Competition .30 inch")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("168")
        ListView1.Items(x).SubItems.Add("0,462")
        x = x + 1

        ListView1.Items.Add("Custom Competition .30 inch")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("175")
        ListView1.Items(x).SubItems.Add("0,505")
        x = x + 1

        ListView1.Items.Add("Custom Competition .30 inch")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("190")
        ListView1.Items(x).SubItems.Add("0,530")
        x = x + 1

        ListView1.Items.Add("Custom Competition .30 inch")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("220")
        ListView1.Items(x).SubItems.Add("0,690")
        x = x + 1

        ListView1.Items.Add("Custom Competition 8 mm")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,520")
        x = x + 1

        ListView1.Items.Add("Custom Competition .338 inch")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,800")
        x = x + 1

        ListView1.Items.Add("Custom Competition .45 inch")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("185")
        ListView1.Items(x).SubItems.Add("0,142")
        x = x + 1

        ListView1.Items.Add("E-Tip .22 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("55")
        ListView1.Items(x).SubItems.Add("0,305")
        x = x + 1

        ListView1.Items.Add("E-Tip 6 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("90")
        ListView1.Items(x).SubItems.Add("0,403")
        x = x + 1

        ListView1.Items.Add("E-Tip .25 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("100")
        ListView1.Items(x).SubItems.Add("0,409")
        x = x + 1

        ListView1.Items.Add("E-Tip 6,5 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("120")
        ListView1.Items(x).SubItems.Add("0,497")
        x = x + 1

        ListView1.Items.Add("E-Tip 6,8 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("85")
        ListView1.Items(x).SubItems.Add("0,273")
        x = x + 1

        ListView1.Items.Add("E-Tip .270 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,459")
        x = x + 1

        ListView1.Items.Add("E-Tip 7 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,489")
        x = x + 1

        ListView1.Items.Add("E-Tip 7 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,498")
        x = x + 1

        ListView1.Items.Add("E-Tip .30 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,469")
        x = x + 1

        ListView1.Items.Add("E-Tip .30/30 inch")
        ListView1.Items(x).SubItems.Add("RN")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,469")
        x = x + 1

        ListView1.Items.Add("E-Tip .30 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("168")
        ListView1.Items(x).SubItems.Add("0,503")
        x = x + 1

        ListView1.Items.Add("E-Tip .30 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,523")
        x = x + 1

        ListView1.Items.Add("E-Tip 8 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,427")
        x = x + 1

        ListView1.Items.Add("E-Tip .338 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,425")
        x = x + 1

        ListView1.Items.Add("E-Tip .338 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("225")
        ListView1.Items(x).SubItems.Add("0,611")
        x = x + 1

        ListView1.Items.Add("Partition .22 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("60")
        ListView1.Items(x).SubItems.Add("0,228")
        x = x + 1

        ListView1.Items.Add("Partition 6 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("85")
        ListView1.Items(x).SubItems.Add("0,315")
        x = x + 1

        ListView1.Items.Add("Partition 6 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("95")
        ListView1.Items(x).SubItems.Add("0,365")
        x = x + 1

        ListView1.Items.Add("Partition 6 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("100")
        ListView1.Items(x).SubItems.Add("0,384")
        x = x + 1

        ListView1.Items.Add("Partition .25 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("100")
        ListView1.Items(x).SubItems.Add("0,377")
        x = x + 1

        ListView1.Items.Add("Partition .25 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("115")
        ListView1.Items(x).SubItems.Add("0,389")
        x = x + 1

        ListView1.Items.Add("Partition .25 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("120")
        ListView1.Items(x).SubItems.Add("0,391")
        x = x + 1

        ListView1.Items.Add("Partition 6,5 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("100")
        ListView1.Items(x).SubItems.Add("0,326")
        x = x + 1

        ListView1.Items.Add("Partition 6,5 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("125")
        ListView1.Items(x).SubItems.Add("0,449")
        x = x + 1

        ListView1.Items.Add("Partition 6,5 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,490")
        x = x + 1

        ListView1.Items.Add("Partition .270 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,416")
        x = x + 1

        ListView1.Items.Add("Partition .270 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,432")
        x = x + 1

        ListView1.Items.Add("Partition .270 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,465")
        x = x + 1

        ListView1.Items.Add("Partition .270 inch")
        ListView1.Items(x).SubItems.Add("SS")
        ListView1.Items(x).SubItems.Add("160")
        ListView1.Items(x).SubItems.Add("0,434")
        x = x + 1

        ListView1.Items.Add("Partition 7 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,434")
        x = x + 1

        ListView1.Items.Add("Partition 7 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,456")
        x = x + 1

        ListView1.Items.Add("Partition 7 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("160")
        ListView1.Items(x).SubItems.Add("0,475")
        x = x + 1

        ListView1.Items.Add("Partition 7 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("175")
        ListView1.Items(x).SubItems.Add("0,519")
        x = x + 1

        ListView1.Items.Add("Partition .30 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,387")
        x = x + 1

        ListView1.Items.Add("Partition .30 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("165")
        ListView1.Items(x).SubItems.Add("0,410")
        x = x + 1

        ListView1.Items.Add("Partition .30 inch")
        ListView1.Items(x).SubItems.Add("RN")
        ListView1.Items(x).SubItems.Add("170")
        ListView1.Items(x).SubItems.Add("0,252")
        x = x + 1

        ListView1.Items.Add("Partition .30 inch")
        ListView1.Items(x).SubItems.Add("PP")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,361")
        x = x + 1

        ListView1.Items.Add("Partition .30 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,474")
        x = x + 1

        ListView1.Items.Add("Partition .30 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,481")
        x = x + 1

        ListView1.Items.Add("Partition .30 inch")
        ListView1.Items(x).SubItems.Add("SS")
        ListView1.Items(x).SubItems.Add("220")
        ListView1.Items(x).SubItems.Add("0,351")
        x = x + 1

        ListView1.Items.Add("Partition 8 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,426")
        x = x + 1

        ListView1.Items.Add("Partition .338 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("210")
        ListView1.Items(x).SubItems.Add("0,400")
        x = x + 1

        ListView1.Items.Add("Partition .338 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("225")
        ListView1.Items(x).SubItems.Add("0,454")
        x = x + 1

        ListView1.Items.Add("Partition .338 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("250")
        ListView1.Items(x).SubItems.Add("0,473")
        x = x + 1

        ListView1.Items.Add("Partition .35 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("225")
        ListView1.Items(x).SubItems.Add("0,430")
        x = x + 1

        ListView1.Items.Add("Partition .35 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("250")
        ListView1.Items(x).SubItems.Add("0,446")
        x = x + 1

        ListView1.Items.Add("Partition 9,3 mm")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("286")
        ListView1.Items(x).SubItems.Add("0,482")
        x = x + 1

        ListView1.Items.Add("Partition .375 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("260")
        ListView1.Items(x).SubItems.Add("0,314")
        x = x + 1

        ListView1.Items.Add("Partition .375 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,398")
        x = x + 1

        ListView1.Items.Add("Partition .416 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("400")
        ListView1.Items(x).SubItems.Add("0,390")
        x = x + 1

        ListView1.Items.Add("Partition .458 inch")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("500")
        ListView1.Items(x).SubItems.Add("0,341")
        x = x + 1

        ListView1.Items.Add("RDF .22 inch")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("70")
        ListView1.Items(x).SubItems.Add("0,416")
        x = x + 1

        ListView1.Items.Add("RDF 6 mm")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("100")
        ListView1.Items(x).SubItems.Add("0,571")
        x = x + 1

        ListView1.Items.Add("RDF .30 inch")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("175")
        ListView1.Items(x).SubItems.Add("0,536")
        x = x + 1

        ListView1.Items.Add("Solid 9,3 mm")
        ListView1.Items(x).SubItems.Add("FN")
        ListView1.Items(x).SubItems.Add("286")
        ListView1.Items(x).SubItems.Add("0,350")
        x = x + 1

        ListView1.Items.Add("Solid .375 inch")
        ListView1.Items(x).SubItems.Add("FN")
        ListView1.Items(x).SubItems.Add("260")
        ListView1.Items(x).SubItems.Add("0,254")
        x = x + 1

        ListView1.Items.Add("Solid .375 inch")
        ListView1.Items(x).SubItems.Add("FN")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,300")
        x = x + 1

        ListView1.Items.Add("Solid .416 inch")
        ListView1.Items(x).SubItems.Add("FN")
        ListView1.Items(x).SubItems.Add("400")
        ListView1.Items(x).SubItems.Add("0,289")
        x = x + 1

        ListView1.Items.Add("Solid .458 inch")
        ListView1.Items(x).SubItems.Add("FN")
        ListView1.Items(x).SubItems.Add("500")
        ListView1.Items(x).SubItems.Add("0,246")
        x = x + 1

        ListView1.Items.Add("Solid .475 inch")
        ListView1.Items(x).SubItems.Add("FN")
        ListView1.Items(x).SubItems.Add("500")
        ListView1.Items(x).SubItems.Add("0,237")
        x = x + 1

        ListView1.Items.Add("Varmageddon .17 inch")
        ListView1.Items(x).SubItems.Add("FBHP")
        ListView1.Items(x).SubItems.Add("20")
        ListView1.Items(x).SubItems.Add("0,119")
        x = x + 1

        ListView1.Items.Add("Varmageddon .17 inch")
        ListView1.Items(x).SubItems.Add("FB Tipped")
        ListView1.Items(x).SubItems.Add("20")
        ListView1.Items(x).SubItems.Add("0,183")
        x = x + 1

        ListView1.Items.Add("Varmageddon .20 inch")
        ListView1.Items(x).SubItems.Add("FBHP")
        ListView1.Items(x).SubItems.Add("32")
        ListView1.Items(x).SubItems.Add("0,131")
        x = x + 1

        ListView1.Items.Add("Varmageddon .20 inch")
        ListView1.Items(x).SubItems.Add("FB Tipped")
        ListView1.Items(x).SubItems.Add("32")
        ListView1.Items(x).SubItems.Add("0,204")
        x = x + 1

        ListView1.Items.Add("Varmageddon .22 inch")
        ListView1.Items(x).SubItems.Add("FB Tipped")
        ListView1.Items(x).SubItems.Add("35")
        ListView1.Items(x).SubItems.Add("0,120")
        x = x + 1

        ListView1.Items.Add("Varmageddon .22 inch")
        ListView1.Items(x).SubItems.Add("FBHP")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,158")
        x = x + 1

        ListView1.Items.Add("Varmageddon .22 inch")
        ListView1.Items(x).SubItems.Add("FB Tipped")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,211")
        x = x + 1

        ListView1.Items.Add("Varmageddon .22 inch")
        ListView1.Items(x).SubItems.Add("FBHP")
        ListView1.Items(x).SubItems.Add("55")
        ListView1.Items(x).SubItems.Add("0,210")
        x = x + 1

        ListView1.Items.Add("Varmageddon .22 inch")
        ListView1.Items(x).SubItems.Add("FB Tipped")
        ListView1.Items(x).SubItems.Add("55")
        ListView1.Items(x).SubItems.Add("0,255")
        x = x + 1

        ListView1.Items.Add("Varmageddon .22 inch")
        ListView1.Items(x).SubItems.Add("FBHP")
        ListView1.Items(x).SubItems.Add("62")
        ListView1.Items(x).SubItems.Add("0,251")
        x = x + 1

        ListView1.Items.Add("Varmageddon 6 mm")
        ListView1.Items(x).SubItems.Add("FBHP")
        ListView1.Items(x).SubItems.Add("55")
        ListView1.Items(x).SubItems.Add("0,192")
        x = x + 1

        ListView1.Items.Add("Varmageddon 6 mm")
        ListView1.Items(x).SubItems.Add("FB Tipped")
        ListView1.Items(x).SubItems.Add("55")
        ListView1.Items(x).SubItems.Add("0,252")
        x = x + 1

        ListView1.Items.Add("Varmageddon 6 mm")
        ListView1.Items(x).SubItems.Add("FB Tipped")
        ListView1.Items(x).SubItems.Add("70")
        ListView1.Items(x).SubItems.Add("0,305")
        x = x + 1

        ListView1.Items.Add("Varmageddon .30 inch")
        ListView1.Items(x).SubItems.Add("FB Tipped")
        ListView1.Items(x).SubItems.Add("110")
        ListView1.Items(x).SubItems.Add("0,293")
        x = x + 1

    End Sub
    Private Sub puškové_střely_TNX()

        Dim x As Integer = 0

        ListView1.Columns.Add(0).Width = 237
        ListView1.Columns.Add(1).Width = 237
        ListView1.Columns.Add(2).Width = 237
        ListView1.Columns.Add(3).Width = 237

        ListView1.Columns(0).Text = "Bullet name"
        ListView1.Columns(1).Text = "Bullet type"
        ListView1.Columns(2).Text = "Bullet weight [grs]"
        ListView1.Columns(3).Text = "Ballistic coefficient G1"

        ListView1.Items.Add("25-20")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("85")
        ListView1.Items(x).SubItems.Add("0,194")
        x = x + 1

        ListView1.Items.Add("25-35")
        ListView1.Items(x).SubItems.Add("FPGC")
        ListView1.Items(x).SubItems.Add("117")
        ListView1.Items(x).SubItems.Add("0,235")
        x = x + 1

        ListView1.Items.Add("30-30")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("170")
        ListView1.Items(x).SubItems.Add("0,251")
        x = x + 1

        ListView1.Items.Add("32-40")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("170")
        ListView1.Items(x).SubItems.Add("0,220")
        x = x + 1

        ListView1.Items.Add("38-40")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,168")
        x = x + 1

        ListView1.Items.Add("38-40 BPC")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,175")
        x = x + 1

        ListView1.Items.Add("38-55")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("245")
        ListView1.Items(x).SubItems.Add("0,236")
        x = x + 1

        ListView1.Items.Add("38-55 Game")
        ListView1.Items(x).SubItems.Add("RNFPGC")
        ListView1.Items(x).SubItems.Add("260")
        ListView1.Items(x).SubItems.Add("0,240")
        x = x + 1

        ListView1.Items.Add("38-56")
        ListView1.Items(x).SubItems.Add("RNFPGC")
        ListView1.Items(x).SubItems.Add("260")
        ListView1.Items(x).SubItems.Add("0,248")
        x = x + 1

        ListView1.Items.Add("38-56 BPC")
        ListView1.Items(x).SubItems.Add("RNFPGC")
        ListView1.Items(x).SubItems.Add("260")
        ListView1.Items(x).SubItems.Add("0,268")
        x = x + 1

        ListView1.Items.Add("40-60 Win")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("260")
        ListView1.Items(x).SubItems.Add("0,240")
        x = x + 1

        ListView1.Items.Add("40-60 Win BPC")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("260")
        ListView1.Items(x).SubItems.Add("0,240")
        x = x + 1

        ListView1.Items.Add("40-65 Win Lever")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("260")
        ListView1.Items(x).SubItems.Add("0,209")
        x = x + 1

        ListView1.Items.Add("45-60 Win")
        ListView1.Items(x).SubItems.Add("FP")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,175")
        x = x + 1

        ListView1.Items.Add("45-60 Win BPC")
        ListView1.Items(x).SubItems.Add("FP")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,180")
        x = x + 1

        ListView1.Items.Add("45-70 Lever")
        ListView1.Items(x).SubItems.Add("FP")
        ListView1.Items(x).SubItems.Add("405")
        ListView1.Items(x).SubItems.Add("0,269")
        x = x + 1

        ListView1.Items.Add("45-70 Lever BPC")
        ListView1.Items(x).SubItems.Add("FP")
        ListView1.Items(x).SubItems.Add("405")
        ListView1.Items(x).SubItems.Add("0,207")
        x = x + 1

        ListView1.Items.Add("45-70 SS")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("405")
        ListView1.Items(x).SubItems.Add("0,326")
        x = x + 1

        ListView1.Items.Add("45-70 SS BPC")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("405")
        ListView1.Items(x).SubItems.Add("0,299")
        x = x + 1

        ListView1.Items.Add("45-70 Government")
        ListView1.Items(x).SubItems.Add("FP")
        ListView1.Items(x).SubItems.Add("500")
        ListView1.Items(x).SubItems.Add("0,306")
        x = x + 1

        ListView1.Items.Add("45-70 Government BPC")
        ListView1.Items(x).SubItems.Add("FP")
        ListView1.Items(x).SubItems.Add("500")
        ListView1.Items(x).SubItems.Add("0,277")
        x = x + 1

        ListView1.Items.Add("45-75 Win")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("350")
        ListView1.Items(x).SubItems.Add("0,215")
        x = x + 1

        ListView1.Items.Add("45-75 Win BPC")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("350")
        ListView1.Items(x).SubItems.Add("0,230")
        x = x + 1

        ListView1.Items.Add("45-90 Win Lever")
        ListView1.Items(x).SubItems.Add("FP")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,184")
        x = x + 1

        ListView1.Items.Add("45-90 Win Lever BPC")
        ListView1.Items(x).SubItems.Add("FP")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,167")
        x = x + 1

        ListView1.Items.Add("45-90 Win SS")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("405")
        ListView1.Items(x).SubItems.Add("0,387")
        x = x + 1

        ListView1.Items.Add("45-90 Win SS Game")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("405")
        ListView1.Items(x).SubItems.Add("0,256")
        x = x + 1

        ListView1.Items.Add("45-90 Win SS BPC")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("405")
        ListView1.Items(x).SubItems.Add("0,260")
        x = x + 1

        ListView1.Items.Add("45-90 Win SS BPC G")
        ListView1.Items(x).SubItems.Add("HBSFP")
        ListView1.Items(x).SubItems.Add("480")
        ListView1.Items(x).SubItems.Add("0,553")
        x = x + 1

        ListView1.Items.Add("45-110 Sharps")
        ListView1.Items(x).SubItems.Add("FBSFP")
        ListView1.Items(x).SubItems.Add("535")
        ListView1.Items(x).SubItems.Add("0,630")
        x = x + 1

        ListView1.Items.Add("45-120 SS")
        ListView1.Items(x).SubItems.Add("FBSFP")
        ListView1.Items(x).SubItems.Add("535")
        ListView1.Items(x).SubItems.Add("0,569")
        x = x + 1

        ListView1.Items.Add("45-120 SS BPC")
        ListView1.Items(x).SubItems.Add("FBSFP")
        ListView1.Items(x).SubItems.Add("535")
        ListView1.Items(x).SubItems.Add("0,583")
        x = x + 1

        ListView1.Items.Add("50-70")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("500")
        ListView1.Items(x).SubItems.Add("0,279")
        x = x + 1

        ListView1.Items.Add("50-70 BPC")
        ListView1.Items(x).SubItems.Add("RNPF")
        ListView1.Items(x).SubItems.Add("500")
        ListView1.Items(x).SubItems.Add("0,332")
        x = x + 1

        ListView1.Items.Add("50-90")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("500")
        ListView1.Items(x).SubItems.Add("0,266")
        x = x + 1

        ListView1.Items.Add("50-95 Win")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("350")
        ListView1.Items(x).SubItems.Add("0,180")
        x = x + 1

        ListView1.Items.Add("50-95 Win BPC")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("350")
        ListView1.Items(x).SubItems.Add("0,173")
        x = x + 1

        ListView1.Items.Add("56-50 Spencer")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("350")
        ListView1.Items(x).SubItems.Add("0,183")
        x = x + 1

        ListView1.Items.Add("56-50 Spencer BPC")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("350")
        ListView1.Items(x).SubItems.Add("0,176")
        x = x + 1

        ListView1.Items.Add("577-450 MH BPC")
        ListView1.Items(x).SubItems.Add("HBSFP")
        ListView1.Items(x).SubItems.Add("480")
        ListView1.Items(x).SubItems.Add("0,537")
        x = x + 1

        ListView1.Items.Add("577 Snider BPC")
        ListView1.Items(x).SubItems.Add("HBHP")
        ListView1.Items(x).SubItems.Add("480")
        ListView1.Items(x).SubItems.Add("0,181")
        x = x + 1

    End Sub
    Private Sub pistolové_střely_TNX()

        Dim x As Integer = 0

        ListView1.Columns.Add(0).Width = 237
        ListView1.Columns.Add(1).Width = 237
        ListView1.Columns.Add(2).Width = 237
        ListView1.Columns.Add(3).Width = 237

        ListView1.Columns(0).Text = "Bullet name"
        ListView1.Columns(1).Text = "Bullet type"
        ListView1.Columns(2).Text = "Bullet weight [grs]"
        ListView1.Columns(3).Text = "Ballistic coefficient G1"

        ListView1.Items.Add("32 HR Mag")
        ListView1.Items(x).SubItems.Add("RN")
        ListView1.Items(x).SubItems.Add("78")
        ListView1.Items(x).SubItems.Add("0,052")
        x = x + 1

        ListView1.Items.Add("32 HR Mag")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("115")
        ListView1.Items(x).SubItems.Add("0,229")
        x = x + 1

        ListView1.Items.Add("32 HR Mag BPC")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("115")
        ListView1.Items(x).SubItems.Add("0,249")
        x = x + 1

        ListView1.Items.Add("32 SW")
        ListView1.Items(x).SubItems.Add("RN")
        ListView1.Items(x).SubItems.Add("78")
        ListView1.Items(x).SubItems.Add("0,216")
        x = x + 1

        ListView1.Items.Add("32 SW Long")
        ListView1.Items(x).SubItems.Add("RN")
        ListView1.Items(x).SubItems.Add("78")
        ListView1.Items(x).SubItems.Add("0,264")
        x = x + 1

        ListView1.Items.Add("32 SW Long BPC")
        ListView1.Items(x).SubItems.Add("RN")
        ListView1.Items(x).SubItems.Add("78")
        ListView1.Items(x).SubItems.Add("0,251")
        x = x + 1

        ListView1.Items.Add("32-20")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("115")
        ListView1.Items(x).SubItems.Add("0,213")
        x = x + 1

        ListView1.Items.Add("32-20 BPC")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("115")
        ListView1.Items(x).SubItems.Add("0,213")
        x = x + 1

        ListView1.Items.Add("357 Mag")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,149")
        x = x + 1

        ListView1.Items.Add("357 Mag BPC")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,191")
        x = x + 1

        ListView1.Items.Add("357 Mag")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("158")
        ListView1.Items(x).SubItems.Add("0,207")
        x = x + 1

        ListView1.Items.Add("357 Mag BPC")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("158")
        ListView1.Items(x).SubItems.Add("0,165")
        x = x + 1

        ListView1.Items.Add("38 Long Colt")
        ListView1.Items(x).SubItems.Add("HBFP")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,260")
        x = x + 1

        ListView1.Items.Add("38 Long Colt BPC")
        ListView1.Items(x).SubItems.Add("HBFP")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,248")
        x = x + 1

        ListView1.Items.Add("38 Special")
        ListView1.Items(x).SubItems.Add("TFB")
        ListView1.Items(x).SubItems.Add("105")
        ListView1.Items(x).SubItems.Add("0,163")
        x = x + 1

        ListView1.Items.Add("38 Special")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,199")
        x = x + 1

        ListView1.Items.Add("38 Special BPC")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,208")
        x = x + 1

        ListView1.Items.Add("38 Special")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("158")
        ListView1.Items(x).SubItems.Add("0,110")
        x = x + 1

        ListView1.Items.Add("38 SW")
        ListView1.Items(x).SubItems.Add("HBFP")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,220")
        x = x + 1

        ListView1.Items.Add("41 Long Colt")
        ListView1.Items(x).SubItems.Add("HBFP")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,252")
        x = x + 1

        ListView1.Items.Add("44 Colt BPC")
        ListView1.Items(x).SubItems.Add("HBFP")
        ListView1.Items(x).SubItems.Add("165")
        ListView1.Items(x).SubItems.Add("0,144")
        x = x + 1

        ListView1.Items.Add("44 Colt")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,217")
        x = x + 1

        ListView1.Items.Add("44 Colt BPC")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,196")
        x = x + 1

        ListView1.Items.Add("44 Mag Low Recoil")
        ListView1.Items(x).SubItems.Add("JFP")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,212")
        x = x + 1

        ListView1.Items.Add("44 Mag")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,212")
        x = x + 1

        ListView1.Items.Add("44 Mag BPC")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,224")
        x = x + 1

        ListView1.Items.Add("44 Russian")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,226")
        x = x + 1

        ListView1.Items.Add("44 Russian BPC")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,207")
        x = x + 1

        ListView1.Items.Add("44 Special")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,457")
        x = x + 1

        ListView1.Items.Add("44-40")
        ListView1.Items(x).SubItems.Add("HBFP")
        ListView1.Items(x).SubItems.Add("165")
        ListView1.Items(x).SubItems.Add("0,149")
        x = x + 1

        ListView1.Items.Add("44-40 BPC")
        ListView1.Items(x).SubItems.Add("HBFP")
        ListView1.Items(x).SubItems.Add("165")
        ListView1.Items(x).SubItems.Add("0,129")
        x = x + 1

        ListView1.Items.Add("44-40")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,167")
        x = x + 1

        ListView1.Items.Add("44-40 BPC")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,146")
        x = x + 1

        ListView1.Items.Add("45 Special BPC")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,207")
        x = x + 1

        ListView1.Items.Add("45 Colt")
        ListView1.Items(x).SubItems.Add("HBFP")
        ListView1.Items(x).SubItems.Add("165")
        ListView1.Items(x).SubItems.Add("0,161")
        x = x + 1

        ListView1.Items.Add("45 Colt BPC")
        ListView1.Items(x).SubItems.Add("HBFP")
        ListView1.Items(x).SubItems.Add("165")
        ListView1.Items(x).SubItems.Add("0,137")
        x = x + 1

        ListView1.Items.Add("45 Colt")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,171")
        x = x + 1

        ListView1.Items.Add("45 Colt")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("250")
        ListView1.Items(x).SubItems.Add("0,195")
        x = x + 1

        ListView1.Items.Add("45 Colt BPC")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("250")
        ListView1.Items(x).SubItems.Add("0,195")
        x = x + 1

        ListView1.Items.Add("45 Schofield")
        ListView1.Items(x).SubItems.Add("HBFP")
        ListView1.Items(x).SubItems.Add("165")
        ListView1.Items(x).SubItems.Add("0,147")
        x = x + 1

        ListView1.Items.Add("45 Schofield")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,213")
        x = x + 1

        ListView1.Items.Add("45 Schofield BPC")
        ListView1.Items(x).SubItems.Add("RNFP")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,153")
        x = x + 1

    End Sub
    Private Sub pistolové_střely_LEE()

        Dim x As Integer = 0

        ListView1.Columns.Add(0).Width = 237
        ListView1.Columns.Add(1).Width = 237
        ListView1.Columns.Add(2).Width = 237
        ListView1.Columns.Add(3).Width = 237

        ListView1.Columns(0).Text = "Bullet name"
        ListView1.Columns(1).Text = "Bullet type"
        ListView1.Columns(2).Text = "Bullet weight [grs]"
        ListView1.Columns(3).Text = "Ballistic coefficient G1"

        ListView1.Items.Add("32 SW Long")
        ListView1.Items(x).SubItems.Add("RN")
        ListView1.Items(x).SubItems.Add("93")
        ListView1.Items(x).SubItems.Add("0,125")
        x = x + 1

        ListView1.Items.Add("32 SW Long")
        ListView1.Items(x).SubItems.Add("RN")
        ListView1.Items(x).SubItems.Add("100")
        ListView1.Items(x).SubItems.Add("0,174")
        x = x + 1

        ListView1.Items.Add("32 SW Long")
        ListView1.Items(x).SubItems.Add("SWC")
        ListView1.Items(x).SubItems.Add("90")
        ListView1.Items(x).SubItems.Add("0,100")
        x = x + 1

        ListView1.Items.Add("38 Special/357 Mag")
        ListView1.Items(x).SubItems.Add("SWC")
        ListView1.Items(x).SubItems.Add("105")
        ListView1.Items(x).SubItems.Add("0,106")
        x = x + 1

        ListView1.Items.Add("38 Special/357 Mag")
        ListView1.Items(x).SubItems.Add("RN")
        ListView1.Items(x).SubItems.Add("125")
        ListView1.Items(x).SubItems.Add("0,116")
        x = x + 1

        ListView1.Items.Add("38 Special/357 Mag")
        ListView1.Items(x).SubItems.Add("SWC")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,142")
        x = x + 1

        ListView1.Items.Add("38 Special/357 Mag")
        ListView1.Items(x).SubItems.Add("WC")
        ListView1.Items(x).SubItems.Add("148")
        ListView1.Items(x).SubItems.Add("0,072")
        x = x + 1

        ListView1.Items.Add("38 Special/357 Mag")
        ListView1.Items(x).SubItems.Add("RN")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,131")
        x = x + 1

        ListView1.Items.Add("38 Special/357 Mag")
        ListView1.Items(x).SubItems.Add("SWC")
        ListView1.Items(x).SubItems.Add("158")
        ListView1.Items(x).SubItems.Add("0,117")
        x = x + 1

        ListView1.Items.Add("38 Special/357 Mag")
        ListView1.Items(x).SubItems.Add("RN")
        ListView1.Items(x).SubItems.Add("158")
        ListView1.Items(x).SubItems.Add("0,207")
        x = x + 1

        ListView1.Items.Add("38 Special/357 Mag")
        ListView1.Items(x).SubItems.Add("RF")
        ListView1.Items(x).SubItems.Add("158")
        ListView1.Items(x).SubItems.Add("0,160")
        x = x + 1

        ListView1.Items.Add("9 mm Luger")
        ListView1.Items(x).SubItems.Add("RF")
        ListView1.Items(x).SubItems.Add("95")
        ListView1.Items(x).SubItems.Add("0,107")
        x = x + 1

        ListView1.Items.Add("9 mm Luger")
        ListView1.Items(x).SubItems.Add("RN")
        ListView1.Items(x).SubItems.Add("102")
        ListView1.Items(x).SubItems.Add("0,105")
        x = x + 1

        ListView1.Items.Add("9 mm Luger")
        ListView1.Items(x).SubItems.Add("TC")
        ListView1.Items(x).SubItems.Add("120")
        ListView1.Items(x).SubItems.Add("0,123")
        x = x + 1

        ListView1.Items.Add("9 mm Luger")
        ListView1.Items(x).SubItems.Add("RN")
        ListView1.Items(x).SubItems.Add("124")
        ListView1.Items(x).SubItems.Add("0,164")
        x = x + 1

        ListView1.Items.Add("9 mm Luger")
        ListView1.Items(x).SubItems.Add("TC")
        ListView1.Items(x).SubItems.Add("124")
        ListView1.Items(x).SubItems.Add("0,127")
        x = x + 1

        ListView1.Items.Add("9 mm Luger")
        ListView1.Items(x).SubItems.Add("RN")
        ListView1.Items(x).SubItems.Add("125")
        ListView1.Items(x).SubItems.Add("0,166")
        x = x + 1

        ListView1.Items.Add("9 mm Makarov")
        ListView1.Items(x).SubItems.Add("RN")
        ListView1.Items(x).SubItems.Add("95")
        ListView1.Items(x).SubItems.Add("0,093")
        x = x + 1

        ListView1.Items.Add("40 SW/10 mm Auto")
        ListView1.Items(x).SubItems.Add("SWC")
        ListView1.Items(x).SubItems.Add("145")
        ListView1.Items(x).SubItems.Add("0,117")
        x = x + 1

        ListView1.Items.Add("40 SW/10 mm Auto")
        ListView1.Items(x).SubItems.Add("SWC")
        ListView1.Items(x).SubItems.Add("175")
        ListView1.Items(x).SubItems.Add("0,141")
        x = x + 1

        ListView1.Items.Add("40 SW/10 mm Auto")
        ListView1.Items(x).SubItems.Add("TC")
        ListView1.Items(x).SubItems.Add("175")
        ListView1.Items(x).SubItems.Add("0,141")
        x = x + 1

        ListView1.Items.Add("41 Magnum")
        ListView1.Items(x).SubItems.Add("SWC")
        ListView1.Items(x).SubItems.Add("195")
        ListView1.Items(x).SubItems.Add("0,110")
        x = x + 1

        ListView1.Items.Add("41 Magnum")
        ListView1.Items(x).SubItems.Add("SWC")
        ListView1.Items(x).SubItems.Add("210")
        ListView1.Items(x).SubItems.Add("0,119")
        x = x + 1

        ListView1.Items.Add("44 Special/44 Mag")
        ListView1.Items(x).SubItems.Add("SWC")
        ListView1.Items(x).SubItems.Add("214")
        ListView1.Items(x).SubItems.Add("0,111")
        x = x + 1

        ListView1.Items.Add("44 Special/44 Mag")
        ListView1.Items(x).SubItems.Add("SWC")
        ListView1.Items(x).SubItems.Add("240")
        ListView1.Items(x).SubItems.Add("0,124")
        x = x + 1

        ListView1.Items.Add("44 Special/44 Mag")
        ListView1.Items(x).SubItems.Add("RF")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,124")
        x = x + 1

        ListView1.Items.Add("44 Special/44 Mag")
        ListView1.Items(x).SubItems.Add("RN")
        ListView1.Items(x).SubItems.Add("240")
        ListView1.Items(x).SubItems.Add("0,196")
        x = x + 1

        ListView1.Items.Add("44 Special/44 Mag")
        ListView1.Items(x).SubItems.Add("SWC")
        ListView1.Items(x).SubItems.Add("240")
        ListView1.Items(x).SubItems.Add("0,169")
        x = x + 1

        ListView1.Items.Add("44 Special/44 Mag")
        ListView1.Items(x).SubItems.Add("RF")
        ListView1.Items(x).SubItems.Add("310")
        ListView1.Items(x).SubItems.Add("0,218")
        x = x + 1

        ListView1.Items.Add("45 ACP")
        ListView1.Items(x).SubItems.Add("RF")
        ListView1.Items(x).SubItems.Add("160")
        ListView1.Items(x).SubItems.Add("0,090")
        x = x + 1

        ListView1.Items.Add("45 ACP")
        ListView1.Items(x).SubItems.Add("SWC")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,127")
        x = x + 1

        ListView1.Items.Add("45 ACP")
        ListView1.Items(x).SubItems.Add("RF")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,140")
        x = x + 1

        ListView1.Items.Add("45 ACP")
        ListView1.Items(x).SubItems.Add("RN")
        ListView1.Items(x).SubItems.Add("228")
        ListView1.Items(x).SubItems.Add("0,145")
        x = x + 1

        ListView1.Items.Add("45 ACP")
        ListView1.Items(x).SubItems.Add("RN")
        ListView1.Items(x).SubItems.Add("230")
        ListView1.Items(x).SubItems.Add("0,189")
        x = x + 1

        ListView1.Items.Add("45 ACP")
        ListView1.Items(x).SubItems.Add("TC")
        ListView1.Items(x).SubItems.Add("230")
        ListView1.Items(x).SubItems.Add("0,146")
        x = x + 1

        ListView1.Items.Add("45 ACP")
        ListView1.Items(x).SubItems.Add("SWC")
        ListView1.Items(x).SubItems.Add("252")
        ListView1.Items(x).SubItems.Add("0,136")
        x = x + 1

        ListView1.Items.Add("45 ACP")
        ListView1.Items(x).SubItems.Add("RF")
        ListView1.Items(x).SubItems.Add("255")
        ListView1.Items(x).SubItems.Add("0,210")
        x = x + 1

        ListView1.Items.Add("45 ACP")
        ListView1.Items(x).SubItems.Add("RF")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,233")
        x = x + 1

        ListView1.Items.Add("480 Ruger")
        ListView1.Items(x).SubItems.Add("RF")
        ListView1.Items(x).SubItems.Add("325")
        ListView1.Items(x).SubItems.Add("0,256")
        x = x + 1

        ListView1.Items.Add("480 Ruger")
        ListView1.Items(x).SubItems.Add("RF")
        ListView1.Items(x).SubItems.Add("400")
        ListView1.Items(x).SubItems.Add("0,271")
        x = x + 1

        ListView1.Items.Add("500 SW")
        ListView1.Items(x).SubItems.Add("RF")
        ListView1.Items(x).SubItems.Add("440")
        ListView1.Items(x).SubItems.Add("0,296")
        x = x + 1

    End Sub
    Private Sub malorážkové_střely_SB()

        Dim x As Integer = 0

        ListView1.Columns.Add(0).Width = 237
        ListView1.Columns.Add(1).Width = 237
        ListView1.Columns.Add(2).Width = 237
        ListView1.Columns.Add(3).Width = 237

        ListView1.Columns(0).Text = "Bullet name"
        ListView1.Columns(1).Text = "Bullet type"
        ListView1.Columns(2).Text = "Bullet weight [g]"
        ListView1.Columns(3).Text = "Ballistic coefficient G1"


        ListView1.Items.Add("SB .22 LR - HV")
        ListView1.Items(x).SubItems.Add("LRN Poměděná")
        ListView1.Items(x).SubItems.Add("2,33")
        ListView1.Items(x).SubItems.Add("0,121")
        x = x + 1

        ListView1.Items.Add("SB .22 LR - CLUB")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("2,56")
        ListView1.Items(x).SubItems.Add("0,110")
        x = x + 1

        ListView1.Items.Add("SB .22 LR - HV HP")
        ListView1.Items(x).SubItems.Add("LHP")
        ListView1.Items(x).SubItems.Add("2,45")
        ListView1.Items(x).SubItems.Add("0,125")
        x = x + 1

        ListView1.Items.Add("SB .22 LR SUBSONIC HP")
        ListView1.Items(x).SubItems.Add("LHP")
        ListView1.Items(x).SubItems.Add("2,56")
        ListView1.Items(x).SubItems.Add("0,110")
        x = x + 1

        ListView1.Items.Add("SB .22 LR SUBSONIC")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("2,56")
        ListView1.Items(x).SubItems.Add("0,110")
        x = x + 1

        ListView1.Items.Add("SB .22 LR STANDARD")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("2,56")
        ListView1.Items(x).SubItems.Add("0,110")
        x = x + 1

        ListView1.Items.Add("SB .22 SHORT")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("1,80")
        ListView1.Items(x).SubItems.Add("0,060")
        x = x + 1

    End Sub
    Private Sub puškové_střely_SB()

        Dim x As Integer = 0

        ListView1.Columns.Add(0).Width = 237
        ListView1.Columns.Add(1).Width = 237
        ListView1.Columns.Add(2).Width = 237
        ListView1.Columns.Add(3).Width = 237

        ListView1.Columns(0).Text = "Bullet code"
        ListView1.Columns(1).Text = "Bullet type"
        ListView1.Columns(2).Text = "Bullet weight [g]"
        ListView1.Columns(3).Text = "Ballistic coefficient G1"

        ListView1.Items.Add("1410")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("3,36")
        ListView1.Items(x).SubItems.Add("0,209")
        x = x + 1

        ListView1.Items.Add("2886")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("3,36")
        ListView1.Items(x).SubItems.Add("0,234")
        x = x + 1

        ListView1.Items.Add("2887")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("4,50")
        ListView1.Items(x).SubItems.Add("0,325")
        x = x + 1

        ListView1.Items.Add("2888")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("5,00")
        ListView1.Items(x).SubItems.Add("0,370")
        x = x + 1

        ListView1.Items.Add("2890")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("9,20")
        ListView1.Items(x).SubItems.Add("0,522")
        x = x + 1

        ListView1.Items.Add("1815")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("7,50")
        ListView1.Items(x).SubItems.Add("0,295")
        x = x + 1

        ListView1.Items.Add("2880")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("10,90")
        ListView1.Items(x).SubItems.Add("0,445")
        x = x + 1

        ListView1.Items.Add("2882")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("11,35")
        ListView1.Items(x).SubItems.Add("0,459")
        x = x + 1

        ListView1.Items.Add("2881")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("11,70")
        ListView1.Items(x).SubItems.Add("0,473")
        x = x + 1

        ListView1.Items.Add("2210")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("12,30")
        ListView1.Items(x).SubItems.Add("0,512")
        x = x + 1

        ListView1.Items.Add("2240")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("14,30")
        ListView1.Items(x).SubItems.Add("0,591")
        x = x + 1

        ListView1.Items.Add("2894")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("11,30")
        ListView1.Items(x).SubItems.Add("0,460")
        x = x + 1

        ListView1.Items.Add("2650")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("16,20")
        ListView1.Items(x).SubItems.Add("0,611")
        x = x + 1

        ListView1.Items.Add("9300")
        ListView1.Items(x).SubItems.Add("HPBT")
        ListView1.Items(x).SubItems.Add("19,40")
        ListView1.Items(x).SubItems.Add("0,730")
        x = x + 1

        ListView1.Items.Add("2981")
        ListView1.Items(x).SubItems.Add("HPC")
        ListView1.Items(x).SubItems.Add("10,20")
        ListView1.Items(x).SubItems.Add("0,583")
        x = x + 1

        ListView1.Items.Add("2983")
        ListView1.Items(x).SubItems.Add("HPC")
        ListView1.Items(x).SubItems.Add("11,70")
        ListView1.Items(x).SubItems.Add("0,528")
        x = x + 1

        ListView1.Items.Add("2986")
        ListView1.Items(x).SubItems.Add("HPC")
        ListView1.Items(x).SubItems.Add("12,70")
        ListView1.Items(x).SubItems.Add("0,534")
        x = x + 1

        ListView1.Items.Add("2901")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("2,90")
        ListView1.Items(x).SubItems.Add("0,129")
        x = x + 1

        ListView1.Items.Add("2902")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("3,24")
        ListView1.Items(x).SubItems.Add("0,218")
        x = x + 1

        ListView1.Items.Add("2903")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("3,60")
        ListView1.Items(x).SubItems.Add("0,244")
        x = x + 1

        ListView1.Items.Add("2904")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("4,60")
        ListView1.Items(x).SubItems.Add("0,284")
        x = x + 1

        ListView1.Items.Add("2430")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("5,20")
        ListView1.Items(x).SubItems.Add("0,249")
        x = x + 1

        ListView1.Items.Add("2956")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("8,00")
        ListView1.Items(x).SubItems.Add("0,386")
        x = x + 1

        ListView1.Items.Add("2905")
        ListView1.Items(x).SubItems.Add("FMJBT")
        ListView1.Items(x).SubItems.Add("9,10")
        ListView1.Items(x).SubItems.Add("0,475")
        x = x + 1

        ListView1.Items.Add("2340")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("7,10")
        ListView1.Items(x).SubItems.Add("0,285")
        x = x + 1

        ListView1.Items.Add("2955")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("9,10")
        ListView1.Items(x).SubItems.Add("0,410")
        x = x + 1

        ListView1.Items.Add("2947")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("11,30")
        ListView1.Items(x).SubItems.Add("0,485")
        x = x + 1

        ListView1.Items.Add("2909")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("11,70")
        ListView1.Items(x).SubItems.Add("0,489")
        x = x + 1

        ListView1.Items.Add("2960")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("7,10")
        ListView1.Items(x).SubItems.Add("0,141")
        x = x + 1

        ListView1.Items.Add("2950")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("13,00")
        ListView1.Items(x).SubItems.Add("0,487")
        x = x + 1

        ListView1.Items.Add("2958")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("8,00")
        ListView1.Items(x).SubItems.Add("0,338")
        x = x + 1

        ListView1.Items.Add("2908")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("9,55")
        ListView1.Items(x).SubItems.Add("0,385")
        x = x + 1

        ListView1.Items.Add("2957")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("11,70")
        ListView1.Items(x).SubItems.Add("0,476")
        x = x + 1

        ListView1.Items.Add("2954")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("9,70")
        ListView1.Items(x).SubItems.Add("0,391")
        x = x + 1

        ListView1.Items.Add("2907")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("8,00")
        ListView1.Items(x).SubItems.Add("0,253")
        x = x + 1

        ListView1.Items.Add("2910")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("12,70")
        ListView1.Items(x).SubItems.Add("0,490")
        x = x + 1

        ListView1.Items.Add("2946")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("15,00")
        ListView1.Items(x).SubItems.Add("0,356")
        x = x + 1

        ListView1.Items.Add("2865")
        ListView1.Items(x).SubItems.Add("FMJ-ZINC")
        ListView1.Items(x).SubItems.Add("2,6")
        ListView1.Items(x).SubItems.Add("0,161")
        x = x + 1

        ListView1.Items.Add("2911")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("2,9")
        ListView1.Items(x).SubItems.Add("0,126")
        x = x + 1

        ListView1.Items.Add("2913")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("3,24")
        ListView1.Items(x).SubItems.Add("0,160")
        x = x + 1

        ListView1.Items.Add("2914")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("3,60")
        ListView1.Items(x).SubItems.Add("0,192")
        x = x + 1

        ListView1.Items.Add("2915")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("4,60")
        ListView1.Items(x).SubItems.Add("0,246")
        x = x + 1

        ListView1.Items.Add("2921")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("6,50")
        ListView1.Items(x).SubItems.Add("0,302")
        x = x + 1

        ListView1.Items.Add("2925")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("7,60")
        ListView1.Items(x).SubItems.Add("0,190")
        x = x + 1

        ListView1.Items.Add("2923")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("8,50")
        ListView1.Items(x).SubItems.Add("0,372")
        x = x + 1

        ListView1.Items.Add("2928")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("9,10")
        ListView1.Items(x).SubItems.Add("0,402")
        x = x + 1

        ListView1.Items.Add("2926")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("10,10")
        ListView1.Items(x).SubItems.Add("0,433")
        x = x + 1

        ListView1.Items.Add("2929")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("8,40")
        ListView1.Items(x).SubItems.Add("0,205")
        x = x + 1

        ListView1.Items.Add("2927")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("9,70")
        ListView1.Items(x).SubItems.Add("0,243")
        x = x + 1

        ListView1.Items.Add("2931")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("9,10")
        ListView1.Items(x).SubItems.Add("0,209")
        x = x + 1

        ListView1.Items.Add("2939")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("9,70")
        ListView1.Items(x).SubItems.Add("0,292")
        x = x + 1

        ListView1.Items.Add("2940")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("11,70")
        ListView1.Items(x).SubItems.Add("0,284")
        x = x + 1

        ListView1.Items.Add("2959")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("7,10")
        ListView1.Items(x).SubItems.Add("0,144")
        x = x + 1

        ListView1.Items.Add("2934")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("9,70")
        ListView1.Items(x).SubItems.Add("0,210")
        x = x + 1

        ListView1.Items.Add("2937")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("11,70")
        ListView1.Items(x).SubItems.Add("0,269")
        x = x + 1

        ListView1.Items.Add("2943")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("8,00")
        ListView1.Items(x).SubItems.Add("0,206")
        x = x + 1

        ListView1.Items.Add("2941")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("12,70")
        ListView1.Items(x).SubItems.Add("0,200")
        x = x + 1

        ListView1.Items.Add("2952")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("18,50")
        ListView1.Items(x).SubItems.Add("0,268")
        x = x + 1

        ListView1.Items.Add("2951")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("12,50")
        ListView1.Items(x).SubItems.Add("0,181")
        x = x + 1

        ListView1.Items.Add("2948")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("26,20")
        ListView1.Items(x).SubItems.Add("0,315")
        x = x + 1

        ListView1.Items.Add("2932")
        ListView1.Items(x).SubItems.Add("SPCE")
        ListView1.Items(x).SubItems.Add("11,20")
        ListView1.Items(x).SubItems.Add("0,355")
        x = x + 1

        ListView1.Items.Add("2936")
        ListView1.Items(x).SubItems.Add("SPCE")
        ListView1.Items(x).SubItems.Add("9,70")
        ListView1.Items(x).SubItems.Add("0,276")
        x = x + 1

        ListView1.Items.Add("2935")
        ListView1.Items(x).SubItems.Add("SPCE")
        ListView1.Items(x).SubItems.Add("11,70")
        ListView1.Items(x).SubItems.Add("0,333")
        x = x + 1

        ListView1.Items.Add("2945")
        ListView1.Items(x).SubItems.Add("SPCE")
        ListView1.Items(x).SubItems.Add("12,70")
        ListView1.Items(x).SubItems.Add("0,310")
        x = x + 1

        ListView1.Items.Add("2966")
        ListView1.Items(x).SubItems.Add("XRG")
        ListView1.Items(x).SubItems.Add("8,40")
        ListView1.Items(x).SubItems.Add("0,218")
        x = x + 1

        ListView1.Items.Add("2967")
        ListView1.Items(x).SubItems.Add("XRG")
        ListView1.Items(x).SubItems.Add("8,40")
        ListView1.Items(x).SubItems.Add("0,208")
        x = x + 1

        ListView1.Items.Add("2968")
        ListView1.Items(x).SubItems.Add("XRG")
        ListView1.Items(x).SubItems.Add("10,20")
        ListView1.Items(x).SubItems.Add("0,242")
        x = x + 1

        ListView1.Items.Add("2970")
        ListView1.Items(x).SubItems.Add("XRG")
        ListView1.Items(x).SubItems.Add("11,70")
        ListView1.Items(x).SubItems.Add("0,269")
        x = x + 1

        ListView1.Items.Add("2977")
        ListView1.Items(x).SubItems.Add("XRG")
        ListView1.Items(x).SubItems.Add("12,70")
        ListView1.Items(x).SubItems.Add("0,265")
        x = x + 1

        ListView1.Items.Add("2979")
        ListView1.Items(x).SubItems.Add("XRG")
        ListView1.Items(x).SubItems.Add("16,20")
        ListView1.Items(x).SubItems.Add("0,326")
        x = x + 1

        ListView1.Items.Add("2965")
        ListView1.Items(x).SubItems.Add("TXRG")
        ListView1.Items(x).SubItems.Add("7,80")
        ListView1.Items(x).SubItems.Add("0,396")
        x = x + 1

        ListView1.Items.Add("2992")
        ListView1.Items(x).SubItems.Add("TXRG")
        ListView1.Items(x).SubItems.Add("8,40")
        ListView1.Items(x).SubItems.Add("0,419")
        x = x + 1

        ListView1.Items.Add("2969")
        ListView1.Items(x).SubItems.Add("TXRG")
        ListView1.Items(x).SubItems.Add("9,70")
        ListView1.Items(x).SubItems.Add("0,429")
        x = x + 1

        ListView1.Items.Add("2973")
        ListView1.Items(x).SubItems.Add("TXRG")
        ListView1.Items(x).SubItems.Add("7,10")
        ListView1.Items(x).SubItems.Add("0,259")
        x = x + 1

        ListView1.Items.Add("2971")
        ListView1.Items(x).SubItems.Add("TXRG")
        ListView1.Items(x).SubItems.Add("10,70")
        ListView1.Items(x).SubItems.Add("0,381")
        x = x + 1

        ListView1.Items.Add("2972")
        ListView1.Items(x).SubItems.Add("TXRG")
        ListView1.Items(x).SubItems.Add("11,70")
        ListView1.Items(x).SubItems.Add("0,422")
        x = x + 1

        ListView1.Items.Add("2976")
        ListView1.Items(x).SubItems.Add("TXRG")
        ListView1.Items(x).SubItems.Add("11,70")
        ListView1.Items(x).SubItems.Add("0,383")
        x = x + 1

        ListView1.Items.Add("2991")
        ListView1.Items(x).SubItems.Add("TXRG")
        ListView1.Items(x).SubItems.Add("16,20")
        ListView1.Items(x).SubItems.Add("0,410")
        x = x + 1

        ListView1.Items.Add("9315")
        ListView1.Items(x).SubItems.Add("EDGE")
        ListView1.Items(x).SubItems.Add("7,80")
        ListView1.Items(x).SubItems.Add("0,332")
        x = x + 1

        ListView1.Items.Add("9318")
        ListView1.Items(x).SubItems.Add("EDGE")
        ListView1.Items(x).SubItems.Add("10,70")
        ListView1.Items(x).SubItems.Add("0,341")
        x = x + 1

        ListView1.Items.Add("9319")
        ListView1.Items(x).SubItems.Add("EDGE")
        ListView1.Items(x).SubItems.Add("11,70")
        ListView1.Items(x).SubItems.Add("0,361")
        x = x + 1

    End Sub
    Private Sub pistolové_střely_SB()

        Dim x As Integer = 0

        ListView1.Columns.Add(0).Width = 237
        ListView1.Columns.Add(1).Width = 237
        ListView1.Columns.Add(2).Width = 237
        ListView1.Columns.Add(3).Width = 237

        ListView1.Columns(0).Text = "Bullet name"
        ListView1.Columns(1).Text = "Bullet type"
        ListView1.Columns(2).Text = "Bullet weight [g]"
        ListView1.Columns(3).Text = "Ballistic coefficient G1"

        ListView1.Items.Add("6,35 Browning")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("3,30")
        ListView1.Items(x).SubItems.Add("0,082")
        x = x + 1

        ListView1.Items.Add("7,62 x 25 Tokarev")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("5,50")
        ListView1.Items(x).SubItems.Add("0,119")
        x = x + 1

        ListView1.Items.Add("7,65 Browning")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("4,75")
        ListView1.Items(x).SubItems.Add("0,135")
        x = x + 1

        ListView1.Items.Add(".32 SW Long")
        ListView1.Items(x).SubItems.Add("WC")
        ListView1.Items(x).SubItems.Add("6,50")
        ListView1.Items(x).SubItems.Add("0,049")
        x = x + 1

        ListView1.Items.Add(".32 SW Long")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("6,50")
        ListView1.Items(x).SubItems.Add("0,279")
        x = x + 1

        ListView1.Items.Add("9 mm Browning Court")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("6,00")
        ListView1.Items(x).SubItems.Add("0,134")
        x = x + 1

        ListView1.Items.Add("9 mm Luger (Nontox)")
        ListView1.Items(x).SubItems.Add("TFMJ")
        ListView1.Items(x).SubItems.Add("7,50")
        ListView1.Items(x).SubItems.Add("0,106")
        x = x + 1

        ListView1.Items.Add("9 mm Luger, 9 x 21")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("7,50")
        ListView1.Items(x).SubItems.Add("0,246")
        x = x + 1

        ListView1.Items.Add("9 mm Luger, 9 x 21")
        ListView1.Items(x).SubItems.Add("TFMJ")
        ListView1.Items(x).SubItems.Add("8,00")
        ListView1.Items(x).SubItems.Add("0,124")
        x = x + 1

        ListView1.Items.Add("9 mm Luger, 9 x 21")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("8,00")
        ListView1.Items(x).SubItems.Add("0,123")
        x = x + 1

        ListView1.Items.Add("9 mm Luger")
        ListView1.Items(x).SubItems.Add("JHP")
        ListView1.Items(x).SubItems.Add("7,50")
        ListView1.Items(x).SubItems.Add("0,094")
        x = x + 1

        ListView1.Items.Add("9 mm Luger")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("6,50")
        ListView1.Items(x).SubItems.Add("0,103")
        x = x + 1

        ListView1.Items.Add("9 mm Luger, 9 x 21")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("8,00")
        ListView1.Items(x).SubItems.Add("0,126")
        x = x + 1

        ListView1.Items.Add("9 mm Luger subsonic")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("9,00")
        ListView1.Items(x).SubItems.Add("0,184")
        x = x + 1

        ListView1.Items.Add("9 mm Makarov")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("6,10")
        ListView1.Items(x).SubItems.Add("0,122")
        x = x + 1

        ListView1.Items.Add(".38 Special")
        ListView1.Items(x).SubItems.Add("TFMJ")
        ListView1.Items(x).SubItems.Add("10,25")
        ListView1.Items(x).SubItems.Add("0,065")
        x = x + 1

        ListView1.Items.Add(".38 Special")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("10,25")
        ListView1.Items(x).SubItems.Add("0,058")
        x = x + 1

        ListView1.Items.Add(".38 Special")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("10,25")
        ListView1.Items(x).SubItems.Add("0,058")
        x = x + 1

        ListView1.Items.Add(".38 Special")
        ListView1.Items(x).SubItems.Add("LRN")
        ListView1.Items(x).SubItems.Add("10,25")
        ListView1.Items(x).SubItems.Add("0,205")
        x = x + 1

        ListView1.Items.Add(".38 Special")
        ListView1.Items(x).SubItems.Add("WC")
        ListView1.Items(x).SubItems.Add("9,60")
        ListView1.Items(x).SubItems.Add("0,130")
        x = x + 1

        ListView1.Items.Add(".357 Magnum")
        ListView1.Items(x).SubItems.Add("TFMJ")
        ListView1.Items(x).SubItems.Add("10,25")
        ListView1.Items(x).SubItems.Add("0,163")
        x = x + 1

        ListView1.Items.Add(".357 Magnum")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("10,25")
        ListView1.Items(x).SubItems.Add("0,163")
        x = x + 1

        ListView1.Items.Add(".357 Magnum")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("10,25")
        ListView1.Items(x).SubItems.Add("0,162")
        x = x + 1

        ListView1.Items.Add(".40 SW")
        ListView1.Items(x).SubItems.Add("TFMJ")
        ListView1.Items(x).SubItems.Add("11,70")
        ListView1.Items(x).SubItems.Add("0,157")
        x = x + 1

        ListView1.Items.Add(".40 SW")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("11,70")
        ListView1.Items(x).SubItems.Add("0,157")
        x = x + 1

        ListView1.Items.Add(".44 Rem. Mag.")
        ListView1.Items(x).SubItems.Add("SP")
        ListView1.Items(x).SubItems.Add("15,55")
        ListView1.Items(x).SubItems.Add("0,205")
        x = x + 1

        ListView1.Items.Add(".45 Auto")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("14,90")
        ListView1.Items(x).SubItems.Add("0,116")
        x = x + 1

    End Sub
    Private Sub puškové_střely_B()

        Dim x As Integer = 0

        ListView1.Columns.Add(0).Width = 237
        ListView1.Columns.Add(1).Width = 237
        ListView1.Columns.Add(2).Width = 237
        ListView1.Columns.Add(3).Width = 237

        ListView1.Columns(0).Text = "Bullet name and caliber"
        ListView1.Columns(1).Text = "Bullet type"
        ListView1.Columns(2).Text = "Bullet weight [grs]"
        ListView1.Columns(3).Text = "Ballistic coefficient G7"

        ListView1.Items.Add("Target .22 inch")
        ListView1.Items(x).SubItems.Add("Long Range Hybrid")
        ListView1.Items(x).SubItems.Add("85,5")
        ListView1.Items(x).SubItems.Add("0,268")
        x = x + 1

        ListView1.Items.Add("Target .22 inch")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("70")
        ListView1.Items(x).SubItems.Add("0,191")
        x = x + 1

        ListView1.Items.Add("Target .22 inch")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("80")
        ListView1.Items(x).SubItems.Add("0,233")
        x = x + 1

        ListView1.Items.Add("Target .22 inch")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("75")
        ListView1.Items(x).SubItems.Add("0,216")
        x = x + 1

        ListView1.Items.Add("Target .22 inch")
        ListView1.Items(x).SubItems.Add("BT")
        ListView1.Items(x).SubItems.Add("73")
        ListView1.Items(x).SubItems.Add("0,178")
        x = x + 1

        ListView1.Items.Add("Target .22 inch")
        ListView1.Items(x).SubItems.Add("BT")
        ListView1.Items(x).SubItems.Add("82")
        ListView1.Items(x).SubItems.Add("0,225")
        x = x + 1

        ListView1.Items.Add("Target .22 inch")
        ListView1.Items(x).SubItems.Add("Fullbore")
        ListView1.Items(x).SubItems.Add("81")
        ListView1.Items(x).SubItems.Add("0,226")
        x = x + 1

        ListView1.Items.Add("Target 22 inch")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("90")
        ListView1.Items(x).SubItems.Add("0,274")
        x = x + 1

        ListView1.Items.Add("Target 6 mm")
        ListView1.Items(x).SubItems.Add("BT")
        ListView1.Items(x).SubItems.Add("65")
        ListView1.Items(x).SubItems.Add("0,144")
        x = x + 1

        ListView1.Items.Add("Target 6 mm")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("95")
        ListView1.Items(x).SubItems.Add("0,240")
        x = x + 1

        ListView1.Items.Add("Target 6 mm")
        ListView1.Items(x).SubItems.Add("BT")
        ListView1.Items(x).SubItems.Add("90")
        ListView1.Items(x).SubItems.Add("0,210")
        x = x + 1

        ListView1.Items.Add("Target 6 mm")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("115")
        ListView1.Items(x).SubItems.Add("0,289")
        x = x + 1

        ListView1.Items.Add("Target 6 mm")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("105")
        ListView1.Items(x).SubItems.Add("0,265")
        x = x + 1

        ListView1.Items.Add("Target 6 mm")
        ListView1.Items(x).SubItems.Add("BT")
        ListView1.Items(x).SubItems.Add("105")
        ListView1.Items(x).SubItems.Add("0,253")
        x = x + 1

        ListView1.Items.Add("Target 6 mm")
        ListView1.Items(x).SubItems.Add("BT")
        ListView1.Items(x).SubItems.Add("108")
        ListView1.Items(x).SubItems.Add("0,268")
        x = x + 1

        ListView1.Items.Add("Target 6 mm")
        ListView1.Items(x).SubItems.Add("Hybrid")
        ListView1.Items(x).SubItems.Add("105")
        ListView1.Items(x).SubItems.Add("0,275")
        x = x + 1

        ListView1.Items.Add("Target 6 mm")
        ListView1.Items(x).SubItems.Add("Long Range Hybrid")
        ListView1.Items(x).SubItems.Add("109")
        ListView1.Items(x).SubItems.Add("0,292")
        x = x + 1

        ListView1.Items.Add("Target 6,5 mm")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,304")
        x = x + 1

        ListView1.Items.Add("Target 6,5 mm")
        ListView1.Items(x).SubItems.Add("BT")
        ListView1.Items(x).SubItems.Add("120")
        ListView1.Items(x).SubItems.Add("0,240")
        x = x + 1

        ListView1.Items.Add("Target 6,5 mm")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,288")
        x = x + 1

        ListView1.Items.Add("Target 6,5 mm")
        ListView1.Items(x).SubItems.Add("BT")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,304")
        x = x + 1

        ListView1.Items.Add("Target 6,5 mm")
        ListView1.Items(x).SubItems.Add("Hybrid")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,311")
        x = x + 1

        ListView1.Items.Add("Target 6,5 mm")
        ListView1.Items(x).SubItems.Add("Long Range Hybrid")
        ListView1.Items(x).SubItems.Add("144")
        ListView1.Items(x).SubItems.Add("0,336")
        x = x + 1

        ListView1.Items.Add("Target 7 mm")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("168")
        ListView1.Items(x).SubItems.Add("0,322")
        x = x + 1

        ListView1.Items.Add("Target 7 mm")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,350")
        x = x + 1

        ListView1.Items.Add("Target 7 mm")
        ListView1.Items(x).SubItems.Add("Hybrid")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,349")
        x = x + 1

        ListView1.Items.Add("Target 7 mm")
        ListView1.Items(x).SubItems.Add("F-Open Hybrid")
        ListView1.Items(x).SubItems.Add("184")
        ListView1.Items(x).SubItems.Add("0,356")
        x = x + 1

        ListView1.Items.Add("Target .30 inch")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("168")
        ListView1.Items(x).SubItems.Add("0,260")
        x = x + 1

        ListView1.Items.Add("Target .30 inch")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("175")
        ListView1.Items(x).SubItems.Add("0,262")
        x = x + 1

        ListView1.Items.Add("Target .30 inch")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("185")
        ListView1.Items(x).SubItems.Add("0,278")
        x = x + 1

        ListView1.Items.Add("Target .30 inch")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("210")
        ListView1.Items(x).SubItems.Add("0,318")
        x = x + 1

        ListView1.Items.Add("Target .30 inch")
        ListView1.Items(x).SubItems.Add("Fullbore")
        ListView1.Items(x).SubItems.Add("156")
        ListView1.Items(x).SubItems.Add("0,242")
        x = x + 1

        ListView1.Items.Add("Target .30 inch")
        ListView1.Items(x).SubItems.Add("Hybrid")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,328")
        x = x + 1

        ListView1.Items.Add("Target .30 inch")
        ListView1.Items(x).SubItems.Add("BT")
        ListView1.Items(x).SubItems.Add("210")
        ListView1.Items(x).SubItems.Add("0,320")
        x = x + 1

        ListView1.Items.Add("Target.30 inch")
        ListView1.Items(x).SubItems.Add("Juggernaut")
        ListView1.Items(x).SubItems.Add("185")
        ListView1.Items(x).SubItems.Add("0,284")
        x = x + 1

        ListView1.Items.Add("Target .30 inch")
        ListView1.Items(x).SubItems.Add("BT")
        ListView1.Items(x).SubItems.Add("175")
        ListView1.Items(x).SubItems.Add("0,262")
        x = x + 1

        ListView1.Items.Add("Target .30 inch")
        ListView1.Items(x).SubItems.Add("Hybrid")
        ListView1.Items(x).SubItems.Add("185")
        ListView1.Items(x).SubItems.Add("0,295")
        x = x + 1

        ListView1.Items.Add("Target .30 inch")
        ListView1.Items(x).SubItems.Add("Hybrid")
        ListView1.Items(x).SubItems.Add("168")
        ListView1.Items(x).SubItems.Add("0,264")
        x = x + 1

        ListView1.Items.Add("Target .30 inch")
        ListView1.Items(x).SubItems.Add("Hybrid")
        ListView1.Items(x).SubItems.Add("155")
        ListView1.Items(x).SubItems.Add("0,245")
        x = x + 1

        ListView1.Items.Add("Target .30 inch")
        ListView1.Items(x).SubItems.Add("Hybrid")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,316")
        x = x + 1

        ListView1.Items.Add("Target .30 inch")
        ListView1.Items(x).SubItems.Add("Hybrid")
        ListView1.Items(x).SubItems.Add("215")
        ListView1.Items(x).SubItems.Add("0,354")
        x = x + 1

        ListView1.Items.Add("Target .30 inch")
        ListView1.Items(x).SubItems.Add("Hybrid")
        ListView1.Items(x).SubItems.Add("230")
        ListView1.Items(x).SubItems.Add("0,368")
        x = x + 1

        ListView1.Items.Add("Target .375 inch")
        ListView1.Items(x).SubItems.Add("ELR Match")
        ListView1.Items(x).SubItems.Add("379")
        ListView1.Items(x).SubItems.Add("0,487")
        x = x + 1

        ListView1.Items.Add("Target .375 inch")
        ListView1.Items(x).SubItems.Add("ELR Match")
        ListView1.Items(x).SubItems.Add("407")
        ListView1.Items(x).SubItems.Add("0,523")
        x = x + 1

        ListView1.Items.Add("Hunting 6 mm")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("87")
        ListView1.Items(x).SubItems.Add("0,219")
        x = x + 1

        ListView1.Items.Add("Hunting 6 mm")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("105")
        ListView1.Items(x).SubItems.Add("0,278")
        x = x + 1

        ListView1.Items.Add("Hunting 6 mm")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("95")
        ListView1.Items(x).SubItems.Add("0,239")
        x = x + 1

        ListView1.Items.Add("Hunting .25 inch")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("115")
        ListView1.Items(x).SubItems.Add("0,247")
        x = x + 1

        ListView1.Items.Add("Hunting 6 mm")
        ListView1.Items(x).SubItems.Add("Classic Hunter")
        ListView1.Items(x).SubItems.Add("95")
        ListView1.Items(x).SubItems.Add("0,223")
        x = x + 1

        ListView1.Items.Add("Hunting 6 mm")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("115")
        ListView1.Items(x).SubItems.Add("0,291")
        x = x + 1

        ListView1.Items.Add("Hunting 6,5 mm")
        ListView1.Items(x).SubItems.Add("Elite Hunter")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,310")
        x = x + 1

        ListView1.Items.Add("Hunting 6,5 mm")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,307")
        x = x + 1

        ListView1.Items.Add("Hunting 6,5 mm")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,288")
        x = x + 1

        ListView1.Items.Add("Hunting 6,5 mm")
        ListView1.Items(x).SubItems.Add("Elite Hunter")
        ListView1.Items(x).SubItems.Add("156")
        ListView1.Items(x).SubItems.Add("0,347")
        x = x + 1

        ListView1.Items.Add("Hunting .270 inch")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,258")
        x = x + 1

        ListView1.Items.Add("Hunting .270 inch")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,236")
        x = x + 1

        ListView1.Items.Add("Hunting 6,5 mm")
        ListView1.Items(x).SubItems.Add("Classic Hunter")
        ListView1.Items(x).SubItems.Add("135")
        ListView1.Items(x).SubItems.Add("0,303")
        x = x + 1

        ListView1.Items.Add("Hunting .270 inch")
        ListView1.Items(x).SubItems.Add("Classic Hunter")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,271")
        x = x + 1

        ListView1.Items.Add("Hunting .270 inch")
        ListView1.Items(x).SubItems.Add("Classic Hunter")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,251")
        x = x + 1

        ListView1.Items.Add("Hunting .270 inch")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,265")
        x = x + 1

        ListView1.Items.Add("Hunting 7 mm")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("168")
        ListView1.Items(x).SubItems.Add("0,316")
        x = x + 1

        ListView1.Items.Add("Hunting .270 inch")
        ListView1.Items(x).SubItems.Add("EOL Elite Hunter")
        ListView1.Items(x).SubItems.Add("170")
        ListView1.Items(x).SubItems.Add("0,339")
        x = x + 1

        ListView1.Items.Add("Hunting 7 mm")
        ListView1.Items(x).SubItems.Add("EOL Elite Hunter")
        ListView1.Items(x).SubItems.Add("195")
        ListView1.Items(x).SubItems.Add("0,387")
        x = x + 1

        ListView1.Items.Add("Hunting 7 mm")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,256")
        x = x + 1

        ListView1.Items.Add("Hunting 7 mm")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,345")
        x = x + 1

        ListView1.Items.Add("Hunting 7 mm")
        ListView1.Items(x).SubItems.Add("Classic Hunter")
        ListView1.Items(x).SubItems.Add("168")
        ListView1.Items(x).SubItems.Add("0,290")
        x = x + 1

        ListView1.Items.Add("Hunting 7 mm")
        ListView1.Items(x).SubItems.Add("Elite Hunter")
        ListView1.Items(x).SubItems.Add("175")
        ListView1.Items(x).SubItems.Add("0,336")
        x = x + 1

        ListView1.Items.Add("Hunting .30 inch")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("155")
        ListView1.Items(x).SubItems.Add("0,238")
        x = x + 1

        ListView1.Items.Add("Hunting 7 mm")
        ListView1.Items(x).SubItems.Add("Classic Hunter")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,258")
        x = x + 1

        ListView1.Items.Add("Hunting .30 inch")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("190")
        ListView1.Items(x).SubItems.Add("0,290")
        x = x + 1

        ListView1.Items.Add("Hunting .30 inch")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("175")
        ListView1.Items(x).SubItems.Add("0,265")
        x = x + 1

        ListView1.Items.Add("Hunting .30 inch")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("168")
        ListView1.Items(x).SubItems.Add("0,255")
        x = x + 1

        ListView1.Items.Add("Hunting .30 inch")
        ListView1.Items(x).SubItems.Add("VLD")
        ListView1.Items(x).SubItems.Add("210")
        ListView1.Items(x).SubItems.Add("0,320")
        x = x + 1

        ListView1.Items.Add("Hunting .30 inch")
        ListView1.Items(x).SubItems.Add("Classic Hunter")
        ListView1.Items(x).SubItems.Add("185")
        ListView1.Items(x).SubItems.Add("0,273")
        x = x + 1

        ListView1.Items.Add("Hunting .30 inch")
        ListView1.Items(x).SubItems.Add("Classic Hunter")
        ListView1.Items(x).SubItems.Add("168")
        ListView1.Items(x).SubItems.Add("0,251")
        x = x + 1

        ListView1.Items.Add("Hunting .338 inch")
        ListView1.Items(x).SubItems.Add("Elite Hunter")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,417")
        x = x + 1

        ListView1.Items.Add("Hunting .338 inch")
        ListView1.Items(x).SubItems.Add("Elite Hunter")
        ListView1.Items(x).SubItems.Add("250")
        ListView1.Items(x).SubItems.Add("0,351")
        x = x + 1

        ListView1.Items.Add("Hunting .30 inch")
        ListView1.Items(x).SubItems.Add("Grain Elite Hunter")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,279")
        x = x + 1

        ListView1.Items.Add("Hunting 6,5 mm")
        ListView1.Items(x).SubItems.Add("EOL Elite Hunter")
        ListView1.Items(x).SubItems.Add("156")
        ListView1.Items(x).SubItems.Add("0,347")
        x = x + 1

        ListView1.Items.Add("Varmint 6 mm")
        ListView1.Items(x).SubItems.Add("High BC FB")
        ListView1.Items(x).SubItems.Add("88")
        ListView1.Items(x).SubItems.Add("0,184")
        x = x + 1

        ListView1.Items.Add("Varmint .17 inch")
        ListView1.Items(x).SubItems.Add("FB")
        ListView1.Items(x).SubItems.Add("25")
        ListView1.Items(x).SubItems.Add("0,075")
        x = x + 1

        ListView1.Items.Add("Varmint .20 inch")
        ListView1.Items(x).SubItems.Add("FB")
        ListView1.Items(x).SubItems.Add("35")
        ListView1.Items(x).SubItems.Add("0,087")
        x = x + 1

        ListView1.Items.Add("Varmint .20 inch")
        ListView1.Items(x).SubItems.Add("BT")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,116")
        x = x + 1

        ListView1.Items.Add("Varmint .20 inch")
        ListView1.Items(x).SubItems.Add("FB")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,074")
        x = x + 1

        ListView1.Items.Add("Varmint .20 inch")
        ListView1.Items(x).SubItems.Add("Long Range BT")
        ListView1.Items(x).SubItems.Add("55")
        ListView1.Items(x).SubItems.Add("0,182")
        x = x + 1

        ListView1.Items.Add("Varmint .22 inch")
        ListView1.Items(x).SubItems.Add("FB")
        ListView1.Items(x).SubItems.Add("52")
        ListView1.Items(x).SubItems.Add("0,097")
        x = x + 1

        ListView1.Items.Add("Varmint .22 inch")
        ListView1.Items(x).SubItems.Add("FB")
        ListView1.Items(x).SubItems.Add("55")
        ListView1.Items(x).SubItems.Add("0,101")
        x = x + 1

        ListView1.Items.Add("Varmint .22 inch")
        ListView1.Items(x).SubItems.Add("FB")
        ListView1.Items(x).SubItems.Add("60")
        ListView1.Items(x).SubItems.Add("0,139")
        x = x + 1

        ListView1.Items.Add("Varmint 6 mm")
        ListView1.Items(x).SubItems.Add("High BC FB")
        ListView1.Items(x).SubItems.Add("69")
        ListView1.Items(x).SubItems.Add("0,140")
        x = x + 1

        ListView1.Items.Add("Varmint .22 inch")
        ListView1.Items(x).SubItems.Add("FB")
        ListView1.Items(x).SubItems.Add("64")
        ListView1.Items(x).SubItems.Add("0,138")
        x = x + 1

        ListView1.Items.Add("Varmint 6 mm")
        ListView1.Items(x).SubItems.Add("FB")
        ListView1.Items(x).SubItems.Add("80")
        ListView1.Items(x).SubItems.Add("0,145")
        x = x + 1

        ListView1.Items.Add("Varmint 6 mm")
        ListView1.Items(x).SubItems.Add("High BC FB")
        ListView1.Items(x).SubItems.Add("88")
        ListView1.Items(x).SubItems.Add("0,184")
        x = x + 1

        ListView1.Items.Add("Tactical .30 inch")
        ListView1.Items(x).SubItems.Add("OTM")
        ListView1.Items(x).SubItems.Add("175")
        ListView1.Items(x).SubItems.Add("0,263")
        x = x + 1

        ListView1.Items.Add("Tactical 6,5 mm")
        ListView1.Items(x).SubItems.Add("AR Hybrid OTM")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,287")
        x = x + 1

        ListView1.Items.Add("Tactical .22 inch")
        ListView1.Items(x).SubItems.Add("OTM")
        ListView1.Items(x).SubItems.Add("77")
        ListView1.Items(x).SubItems.Add("0,192")
        x = x + 1

        ListView1.Items.Add("Tactical .30 inch")
        ListView1.Items(x).SubItems.Add("Hybrid OTM")
        ListView1.Items(x).SubItems.Add("230")
        ListView1.Items(x).SubItems.Add("0,364")
        x = x + 1

        ListView1.Items.Add("Tactical .30 inch")
        ListView1.Items(x).SubItems.Add("Juggernaut OTM")
        ListView1.Items(x).SubItems.Add("185")
        ListView1.Items(x).SubItems.Add("0,283")
        x = x + 1

        ListView1.Items.Add("Tactical .338 inch")
        ListView1.Items(x).SubItems.Add("Hybrid OTM")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,421")
        x = x + 1

        ListView1.Items.Add("Tactical .338 inch")
        ListView1.Items(x).SubItems.Add("Hybrid OTM")
        ListView1.Items(x).SubItems.Add("250")
        ListView1.Items(x).SubItems.Add("0,349")
        x = x + 1

    End Sub
    Private Sub puškové_střely_L()

        Dim x As Integer = 0

        ListView1.Columns.Add(0).Width = 237
        ListView1.Columns.Add(1).Width = 237
        ListView1.Columns.Add(2).Width = 237
        ListView1.Columns.Add(3).Width = 237

        ListView1.Columns(0).Text = "Bullet code"
        ListView1.Columns(1).Text = "Bullet type"
        ListView1.Columns(2).Text = "Bullet weight [grs]"
        ListView1.Columns(3).Text = "Ballistic coefficient G7"

        ListView1.Items.Add("GB541")
        ListView1.Items(x).SubItems.Add("Scenar")
        ListView1.Items(x).SubItems.Add("69")
        ListView1.Items(x).SubItems.Add("0,171")
        x = x + 1

        ListView1.Items.Add("GB527")
        ListView1.Items(x).SubItems.Add("Scenar")
        ListView1.Items(x).SubItems.Add("77")
        ListView1.Items(x).SubItems.Add("0,193")
        x = x + 1

        ListView1.Items.Add("GB493")
        ListView1.Items(x).SubItems.Add("Scenar")
        ListView1.Items(x).SubItems.Add("90")
        ListView1.Items(x).SubItems.Add("0,216")
        x = x + 1

        ListView1.Items.Add("GB478")
        ListView1.Items(x).SubItems.Add("Scenar")
        ListView1.Items(x).SubItems.Add("105")
        ListView1.Items(x).SubItems.Add("0,236")
        x = x + 1

        ListView1.Items.Add("GB504")
        ListView1.Items(x).SubItems.Add("Scenar")
        ListView1.Items(x).SubItems.Add("100")
        ListView1.Items(x).SubItems.Add("0,212")
        x = x + 1

        ListView1.Items.Add("GB464")
        ListView1.Items(x).SubItems.Add("Scenar")
        ListView1.Items(x).SubItems.Add("108")
        ListView1.Items(x).SubItems.Add("0,231")
        x = x + 1

        ListView1.Items.Add("GB489")
        ListView1.Items(x).SubItems.Add("Scenar")
        ListView1.Items(x).SubItems.Add("123")
        ListView1.Items(x).SubItems.Add("0,263")
        x = x + 1

        ListView1.Items.Add("GB458")
        ListView1.Items(x).SubItems.Add("Scenar")
        ListView1.Items(x).SubItems.Add("139")
        ListView1.Items(x).SubItems.Add("0,290")
        x = x + 1

        ListView1.Items.Add("GB491")
        ListView1.Items(x).SubItems.Add("Scenar")
        ListView1.Items(x).SubItems.Add("155")
        ListView1.Items(x).SubItems.Add("0,230")
        x = x + 1

        ListView1.Items.Add("GB422")
        ListView1.Items(x).SubItems.Add("Scenar")
        ListView1.Items(x).SubItems.Add("167")
        ListView1.Items(x).SubItems.Add("0,223")
        x = x + 1

        ListView1.Items.Add("GB432")
        ListView1.Items(x).SubItems.Add("Scenar")
        ListView1.Items(x).SubItems.Add("185")
        ListView1.Items(x).SubItems.Add("0,242")
        x = x + 1

        ListView1.Items.Add("GB488")
        ListView1.Items(x).SubItems.Add("Scenar")
        ListView1.Items(x).SubItems.Add("250")
        ListView1.Items(x).SubItems.Add("0,322")
        x = x + 1

        ListView1.Items.Add("GB528")
        ListView1.Items(x).SubItems.Add("Scenar")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,368")
        x = x + 1

        ListView1.Items.Add("GB544")
        ListView1.Items(x).SubItems.Add("Scenar-L")
        ListView1.Items(x).SubItems.Add("69")
        ListView1.Items(x).SubItems.Add("0,171")
        x = x + 1

        ListView1.Items.Add("GB545")
        ListView1.Items(x).SubItems.Add("Scenar-L")
        ListView1.Items(x).SubItems.Add("77")
        ListView1.Items(x).SubItems.Add("0,193")
        x = x + 1

        ListView1.Items.Add("GB543")
        ListView1.Items(x).SubItems.Add("Scenar-L")
        ListView1.Items(x).SubItems.Add("90")
        ListView1.Items(x).SubItems.Add("0,216")
        x = x + 1

        ListView1.Items.Add("GB542")
        ListView1.Items(x).SubItems.Add("Scenar-L")
        ListView1.Items(x).SubItems.Add("105")
        ListView1.Items(x).SubItems.Add("0,236")
        x = x + 1

        ListView1.Items.Add("GB547")
        ListView1.Items(x).SubItems.Add("Scenar-L")
        ListView1.Items(x).SubItems.Add("120")
        ListView1.Items(x).SubItems.Add("0,246")
        x = x + 1

        ListView1.Items.Add("GB546")
        ListView1.Items(x).SubItems.Add("Scenar-L")
        ListView1.Items(x).SubItems.Add("136")
        ListView1.Items(x).SubItems.Add("0,274")
        x = x + 1

        ListView1.Items.Add("GB553")
        ListView1.Items(x).SubItems.Add("Scenar-L")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,260")
        x = x + 1

        ListView1.Items.Add("GB554")
        ListView1.Items(x).SubItems.Add("Scenar-L")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,332")
        x = x + 1

        ListView1.Items.Add("GB552")
        ListView1.Items(x).SubItems.Add("Scenar-L")
        ListView1.Items(x).SubItems.Add("155")
        ListView1.Items(x).SubItems.Add("0,230")
        x = x + 1

        ListView1.Items.Add("GB550")
        ListView1.Items(x).SubItems.Add("Scenar-L")
        ListView1.Items(x).SubItems.Add("175")
        ListView1.Items(x).SubItems.Add("0,247")
        x = x + 1

        ListView1.Items.Add("GB551")
        ListView1.Items(x).SubItems.Add("Scenar-L")
        ListView1.Items(x).SubItems.Add("220")
        ListView1.Items(x).SubItems.Add("0,324")
        x = x + 1

        ListView1.Items.Add("B466")
        ListView1.Items(x).SubItems.Add("Lock Base")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,217")
        x = x + 1

        ListView1.Items.Add("B476")
        ListView1.Items(x).SubItems.Add("Lock Base")
        ListView1.Items(x).SubItems.Add("170")
        ListView1.Items(x).SubItems.Add("0,249")
        x = x + 1

        ListView1.Items.Add("B408")
        ListView1.Items(x).SubItems.Add("Lock Base")
        ListView1.Items(x).SubItems.Add("250")
        ListView1.Items(x).SubItems.Add("0,310")
        x = x + 1

        ListView1.Items.Add("D46")
        ListView1.Items(x).SubItems.Add("D46")
        ListView1.Items(x).SubItems.Add("185")
        ListView1.Items(x).SubItems.Add("0,254")
        x = x + 1

        ListView1.Items.Add("B416")
        ListView1.Items(x).SubItems.Add("Subsonic")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,235")
        x = x + 1

        ListView1.Items.Add("D166")
        ListView1.Items(x).SubItems.Add("D166")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,224")
        x = x + 1

        ListView1.Items.Add("BNS")
        ListView1.Items(x).SubItems.Add("Bullex-N")
        ListView1.Items(x).SubItems.Add("750")
        ListView1.Items(x).SubItems.Add("0,468")
        x = x + 1

        ListView1.Items.Add("BNS")
        ListView1.Items(x).SubItems.Add("Bullex-N")
        ListView1.Items(x).SubItems.Add("800")
        ListView1.Items(x).SubItems.Add("0,476")
        x = x + 1

    End Sub
    Private Sub puškové_střely_H()

        Dim x As Integer = 0

        ListView1.Columns.Add(0).Width = 237
        ListView1.Columns.Add(1).Width = 237
        ListView1.Columns.Add(2).Width = 237
        ListView1.Columns.Add(3).Width = 237

        ListView1.Columns(0).Text = "Bullet code and caliber"
        ListView1.Columns(1).Text = "Bullet type"
        ListView1.Columns(2).Text = "Bullet weight [grs]"
        ListView1.Columns(3).Text = "Ballistic coefficient G1"

        ListView1.Items.Add("30730 (.30 inch)")
        ListView1.Items(x).SubItems.Add("SUB-X")
        ListView1.Items(x).SubItems.Add("190")
        ListView1.Items(x).SubItems.Add("0,437")
        x = x + 1

        ListView1.Items.Add("2249 (.22 inch)")
        ListView1.Items(x).SubItems.Add("Match")
        ListView1.Items(x).SubItems.Add("52")
        ListView1.Items(x).SubItems.Add("0,229")
        x = x + 1

        ListView1.Items.Add("2250 (.22 inch)")
        ListView1.Items(x).SubItems.Add("Match")
        ListView1.Items(x).SubItems.Add("53")
        ListView1.Items(x).SubItems.Add("0,218")
        x = x + 1

        ListView1.Items.Add("2278 (.22 inch)")
        ListView1.Items(x).SubItems.Add("Match")
        ListView1.Items(x).SubItems.Add("68")
        ListView1.Items(x).SubItems.Add("0,355")
        x = x + 1

        ListView1.Items.Add("2279 (.22 inch)")
        ListView1.Items(x).SubItems.Add("Match")
        ListView1.Items(x).SubItems.Add("75")
        ListView1.Items(x).SubItems.Add("0,395")
        x = x + 1

        ListView1.Items.Add("2458 (6 mm)")
        ListView1.Items(x).SubItems.Add("Match")
        ListView1.Items(x).SubItems.Add("105")
        ListView1.Items(x).SubItems.Add("0,530")
        x = x + 1

        ListView1.Items.Add("26335 (6,5 mm)")
        ListView1.Items(x).SubItems.Add("Match")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,580")
        x = x + 1

        ListView1.Items.Add("27200 (.270 inch)")
        ListView1.Items(x).SubItems.Add("Match")
        ListView1.Items(x).SubItems.Add("110")
        ListView1.Items(x).SubItems.Add("0,360")
        x = x + 1

        ListView1.Items.Add("3039 (.30 inch)")
        ListView1.Items(x).SubItems.Add("Match")
        ListView1.Items(x).SubItems.Add("155")
        ListView1.Items(x).SubItems.Add("0,405")
        x = x + 1

        ListView1.Items.Add("30501 (.30 inch)")
        ListView1.Items(x).SubItems.Add("Match")
        ListView1.Items(x).SubItems.Add("168")
        ListView1.Items(x).SubItems.Add("0,450")
        x = x + 1

        ListView1.Items.Add("30715 (.30 inch)")
        ListView1.Items(x).SubItems.Add("Match")
        ListView1.Items(x).SubItems.Add("178")
        ListView1.Items(x).SubItems.Add("0,530")
        x = x + 1

        ListView1.Items.Add("30733 (.30 inch)")
        ListView1.Items(x).SubItems.Add("Match")
        ListView1.Items(x).SubItems.Add("208")
        ListView1.Items(x).SubItems.Add("0,620")
        x = x + 1

        ListView1.Items.Add("22491 (.22 inch)")
        ListView1.Items(x).SubItems.Add("ELD Match")
        ListView1.Items(x).SubItems.Add("52")
        ListView1.Items(x).SubItems.Add("0,247")
        x = x + 1

        ListView1.Items.Add("22774 (.22 inch)")
        ListView1.Items(x).SubItems.Add("ELD Match")
        ListView1.Items(x).SubItems.Add("73")
        ListView1.Items(x).SubItems.Add("0,398")
        x = x + 1

        ListView1.Items.Add("22791 (.22 inch)")
        ListView1.Items(x).SubItems.Add("ELD Match")
        ListView1.Items(x).SubItems.Add("75")
        ListView1.Items(x).SubItems.Add("0,467")
        x = x + 1

        ListView1.Items.Add("22831 (.22 inch)")
        ListView1.Items(x).SubItems.Add("ELD Match")
        ListView1.Items(x).SubItems.Add("80")
        ListView1.Items(x).SubItems.Add("0,485")
        x = x + 1

        ListView1.Items.Add("22834 (.22 inch)")
        ListView1.Items(x).SubItems.Add("ELD Match")
        ListView1.Items(x).SubItems.Add("88")
        ListView1.Items(x).SubItems.Add("0,545")
        x = x + 1

        ListView1.Items.Add("24561 (6 mm)")
        ListView1.Items(x).SubItems.Add("ELD Match")
        ListView1.Items(x).SubItems.Add("108")
        ListView1.Items(x).SubItems.Add("0,536")
        x = x + 1

        ListView1.Items.Add("26100 (6,5 mm)")
        ListView1.Items(x).SubItems.Add("ELD Match")
        ListView1.Items(x).SubItems.Add("100")
        ListView1.Items(x).SubItems.Add("0,385")
        x = x + 1

        ListView1.Items.Add("26175 (6,5 mm)")
        ListView1.Items(x).SubItems.Add("ELD Match")
        ListView1.Items(x).SubItems.Add("120")
        ListView1.Items(x).SubItems.Add("0,486")
        x = x + 1

        ListView1.Items.Add("26176 (6,5 mm)")
        ListView1.Items(x).SubItems.Add("ELD Match")
        ListView1.Items(x).SubItems.Add("123")
        ListView1.Items(x).SubItems.Add("0,506")
        x = x + 1

        ListView1.Items.Add("26177 (6,5 mm)")
        ListView1.Items(x).SubItems.Add("ELD Match")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,554")
        x = x + 1

        ListView1.Items.Add("26331 (6,5 mm)")
        ListView1.Items(x).SubItems.Add("ELD Match")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,646")
        x = x + 1

        ListView1.Items.Add("26333 (6,5 mm)")
        ListView1.Items(x).SubItems.Add("ELD Match")
        ListView1.Items(x).SubItems.Add("147")
        ListView1.Items(x).SubItems.Add("0,697")
        x = x + 1

        ListView1.Items.Add("28403 (7 mm)")
        ListView1.Items(x).SubItems.Add("ELD Match")
        ListView1.Items(x).SubItems.Add("162")
        ListView1.Items(x).SubItems.Add("0,670")
        x = x + 1

        ListView1.Items.Add("28503 (7 mm)")
        ListView1.Items(x).SubItems.Add("ELD Match")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,796")
        x = x + 1

        ListView1.Items.Add("30313 (.30 inch)")
        ListView1.Items(x).SubItems.Add("ELD Match")
        ListView1.Items(x).SubItems.Add("155")
        ListView1.Items(x).SubItems.Add("0,461")
        x = x + 1

        ListView1.Items.Add("30506 (.30 inch)")
        ListView1.Items(x).SubItems.Add("ELD Match")
        ListView1.Items(x).SubItems.Add("168")
        ListView1.Items(x).SubItems.Add("0,523")
        x = x + 1

        ListView1.Items.Add("30713 (.30 inch)")
        ListView1.Items(x).SubItems.Add("ELD Match")
        ListView1.Items(x).SubItems.Add("178")
        ListView1.Items(x).SubItems.Add("0,547")
        x = x + 1

        ListView1.Items.Add("30951 (.30 inch)")
        ListView1.Items(x).SubItems.Add("ELD Match")
        ListView1.Items(x).SubItems.Add("195")
        ListView1.Items(x).SubItems.Add("0,584")
        x = x + 1

        ListView1.Items.Add("30731 (.30 inch) ")
        ListView1.Items(x).SubItems.Add("ELD Match")
        ListView1.Items(x).SubItems.Add("208")
        ListView1.Items(x).SubItems.Add("0,690")
        x = x + 1

        ListView1.Items.Add("30904 (.30 inch)")
        ListView1.Items(x).SubItems.Add("ELD Match")
        ListView1.Items(x).SubItems.Add("225")
        ListView1.Items(x).SubItems.Add("0,777")
        x = x + 1

        ListView1.Items.Add("3381 (.338 inch)")
        ListView1.Items(x).SubItems.Add("ELD Match")
        ListView1.Items(x).SubItems.Add("285")
        ListView1.Items(x).SubItems.Add("0,829")
        x = x + 1

        ListView1.Items.Add("2267 (.22 inch)")
        ListView1.Items(x).SubItems.Add("Traditional")
        ListView1.Items(x).SubItems.Add("55")
        ListView1.Items(x).SubItems.Add("0,243")
        x = x + 1

        ListView1.Items.Add("22671 (.22 inch)")
        ListView1.Items(x).SubItems.Add("Traditional")
        ListView1.Items(x).SubItems.Add("55")
        ListView1.Items(x).SubItems.Add("0,243")
        x = x + 1

        ListView1.Items.Add("2263B (.22 inch)")
        ListView1.Items(x).SubItems.Add("Traditional")
        ListView1.Items(x).SubItems.Add("55")
        ListView1.Items(x).SubItems.Add("0,254")
        x = x + 1

        ListView1.Items.Add("22672 (.22 inch)")
        ListView1.Items(x).SubItems.Add("Traditional")
        ListView1.Items(x).SubItems.Add("55")
        ListView1.Items(x).SubItems.Add("0,243")
        x = x + 1

        ListView1.Items.Add("22760B (.22 inch)")
        ListView1.Items(x).SubItems.Add("Traditional")
        ListView1.Items(x).SubItems.Add("62")
        ListView1.Items(x).SubItems.Add("0,274")
        x = x + 1

        ListView1.Items.Add("2510 (.25 inch)")
        ListView1.Items(x).SubItems.Add("Traditional")
        ListView1.Items(x).SubItems.Add("60")
        ListView1.Items(x).SubItems.Add("0,101")
        x = x + 1

        ListView1.Items.Add("3015 (.30 inch)")
        ListView1.Items(x).SubItems.Add("Traditional")
        ListView1.Items(x).SubItems.Add("110")
        ListView1.Items(x).SubItems.Add("0,150")
        x = x + 1

        ListView1.Items.Add("3017 (.30 inch)")
        ListView1.Items(x).SubItems.Add("Traditional")
        ListView1.Items(x).SubItems.Add("110")
        ListView1.Items(x).SubItems.Add("0,178")
        x = x + 1

        ListView1.Items.Add("3017B (.30 inch)")
        ListView1.Items(x).SubItems.Add("Traditional")
        ListView1.Items(x).SubItems.Add("110")
        ListView1.Items(x).SubItems.Add("0,178")
        x = x + 1

        ListView1.Items.Add("30192 (.30 inch)")
        ListView1.Items(x).SubItems.Add("Traditional")
        ListView1.Items(x).SubItems.Add("125")
        ListView1.Items(x).SubItems.Add("0,320")
        x = x + 1

        ListView1.Items.Add("3037 (.30 inch)")
        ListView1.Items(x).SubItems.Add("Traditional")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,398")
        x = x + 1

        ListView1.Items.Add("30371 (.30 inch)")
        ListView1.Items(x).SubItems.Add("Traditional")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,398")
        x = x + 1

        ListView1.Items.Add("3147B (7,62 mm)")
        ListView1.Items(x).SubItems.Add("Traditional")
        ListView1.Items(x).SubItems.Add("123")
        ListView1.Items(x).SubItems.Add("0,266")
        x = x + 1

        ListView1.Items.Add("3131 (.303 inch)")
        ListView1.Items(x).SubItems.Add("Traditional")
        ListView1.Items(x).SubItems.Add("174")
        ListView1.Items(x).SubItems.Add("0,470")
        x = x + 1

        ListView1.Items.Add("30502 (.30 inch)")
        ListView1.Items(x).SubItems.Add("A-MAX")
        ListView1.Items(x).SubItems.Add("168")
        ListView1.Items(x).SubItems.Add("0,475")
        x = x + 1

        ListView1.Items.Add("5165 (.50 inch)")
        ListView1.Items(x).SubItems.Add("A-MAX")
        ListView1.Items(x).SubItems.Add("750")
        ListView1.Items(x).SubItems.Add("1,050")
        x = x + 1

        ListView1.Items.Add("37214 (.375 inch)")
        ListView1.Items(x).SubItems.Add("DGX Bonded")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,275")
        x = x + 1

        ListView1.Items.Add("41044 (.400 inch)")
        ListView1.Items(x).SubItems.Add("DGX Bonded")
        ListView1.Items(x).SubItems.Add("400")
        ListView1.Items(x).SubItems.Add("0,325")
        x = x + 1

        ListView1.Items.Add("41694 (.416 inch)")
        ListView1.Items(x).SubItems.Add("DGX Bonded")
        ListView1.Items(x).SubItems.Add("400")
        ListView1.Items(x).SubItems.Add("0,319")
        x = x + 1

        ListView1.Items.Add("42404 (.423 inch)")
        ListView1.Items(x).SubItems.Add("DGX Bonded")
        ListView1.Items(x).SubItems.Add("400")
        ListView1.Items(x).SubItems.Add("0,315")
        x = x + 1

        ListView1.Items.Add("45034 (.45 inch)")
        ListView1.Items(x).SubItems.Add("DGX Bonded")
        ListView1.Items(x).SubItems.Add("480")
        ListView1.Items(x).SubItems.Add("0,285")
        x = x + 1

        ListView1.Items.Add("45054 (.45 inch)")
        ListView1.Items(x).SubItems.Add("DGX Bonded")
        ListView1.Items(x).SubItems.Add("500")
        ListView1.Items(x).SubItems.Add("0,295")
        x = x + 1

        ListView1.Items.Add("47474 (.470 inch)")
        ListView1.Items(x).SubItems.Add("DGX Bonded")
        ListView1.Items(x).SubItems.Add("500")
        ListView1.Items(x).SubItems.Add("0,290")
        x = x + 1

        ListView1.Items.Add("5050 (.505 inch)")
        ListView1.Items(x).SubItems.Add("DGX Bonded")
        ListView1.Items(x).SubItems.Add("525")
        ListView1.Items(x).SubItems.Add("0,270")
        x = x + 1

        ListView1.Items.Add("51504 (.50 inch)")
        ListView1.Items(x).SubItems.Add("DGX Bonded")
        ListView1.Items(x).SubItems.Add("570")
        ListView1.Items(x).SubItems.Add("0,295")
        x = x + 1

        ListView1.Items.Add("30196 (.30 inch)")
        ListView1.Items(x).SubItems.Add("FMJ")
        ListView1.Items(x).SubItems.Add("125")
        ListView1.Items(x).SubItems.Add("0,250")
        x = x + 1

        ListView1.Items.Add("24539 (6 mm)")
        ListView1.Items(x).SubItems.Add("InterBond")
        ListView1.Items(x).SubItems.Add("85")
        ListView1.Items(x).SubItems.Add("0,395")
        x = x + 1

        ListView1.Items.Add("25419 (.25 inch)")
        ListView1.Items(x).SubItems.Add("InterBond")
        ListView1.Items(x).SubItems.Add("110")
        ListView1.Items(x).SubItems.Add("0,390")
        x = x + 1

        ListView1.Items.Add("26209 (6,5 mm)")
        ListView1.Items(x).SubItems.Add("InterBond")
        ListView1.Items(x).SubItems.Add("129")
        ListView1.Items(x).SubItems.Add("0,485")
        x = x + 1

        ListView1.Items.Add("27309 (.270 inch)")
        ListView1.Items(x).SubItems.Add("InterBond")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,460")
        x = x + 1

        ListView1.Items.Add("27409 (.270 inch)")
        ListView1.Items(x).SubItems.Add("InterBond")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,525")
        x = x + 1

        ListView1.Items.Add("28209 (7 mm)")
        ListView1.Items(x).SubItems.Add("InterBond")
        ListView1.Items(x).SubItems.Add("139")
        ListView1.Items(x).SubItems.Add("0,486")
        x = x + 1

        ListView1.Items.Add("28309 (7 mm)")
        ListView1.Items(x).SubItems.Add("InterBond")
        ListView1.Items(x).SubItems.Add("154")
        ListView1.Items(x).SubItems.Add("0,525")
        x = x + 1

        ListView1.Items.Add("30309 (.30 inch)")
        ListView1.Items(x).SubItems.Add("InterBond")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,415")
        x = x + 1

        ListView1.Items.Add("30459 (.30 inch)")
        ListView1.Items(x).SubItems.Add("InterBond")
        ListView1.Items(x).SubItems.Add("165")
        ListView1.Items(x).SubItems.Add("0,415")
        x = x + 1

        ListView1.Items.Add("30709 (.30 inch)")
        ListView1.Items(x).SubItems.Add("InterBond")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,480")
        x = x + 1

        ListView1.Items.Add("33209 (.338 inch)")
        ListView1.Items(x).SubItems.Add("InterBond")
        ListView1.Items(x).SubItems.Add("225")
        ListView1.Items(x).SubItems.Add("0,515")
        x = x + 1

        ListView1.Items.Add("30310 (.30 inch)")
        ListView1.Items(x).SubItems.Add("MonoFlex")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,277")
        x = x + 1

        ListView1.Items.Add("45010 (.45 inch)")
        ListView1.Items(x).SubItems.Add("MonoFlex")
        ListView1.Items(x).SubItems.Add("250")
        ListView1.Items(x).SubItems.Add("0,175")
        x = x + 1

        ListView1.Items.Add("2286 (.22 inch)")
        ListView1.Items(x).SubItems.Add("A-TIP Match")
        ListView1.Items(x).SubItems.Add("90")
        ListView1.Items(x).SubItems.Add("0,585")
        x = x + 1

        ListView1.Items.Add("24531 (6 mm)")
        ListView1.Items(x).SubItems.Add("A-TIP Match")
        ListView1.Items(x).SubItems.Add("110")
        ListView1.Items(x).SubItems.Add("0,604")
        x = x + 1

        ListView1.Items.Add("26179 (6,5 mm)")
        ListView1.Items(x).SubItems.Add("A-TIP Match")
        ListView1.Items(x).SubItems.Add("135")
        ListView1.Items(x).SubItems.Add("0,637")
        x = x + 1

        ListView1.Items.Add("2638 (6,5 mm)")
        ListView1.Items(x).SubItems.Add("A-TIP Match")
        ListView1.Items(x).SubItems.Add("153")
        ListView1.Items(x).SubItems.Add("0,704")
        x = x + 1

        ListView1.Items.Add("30717 (.30 inch)")
        ListView1.Items(x).SubItems.Add("A-TIP Match")
        ListView1.Items(x).SubItems.Add("176")
        ListView1.Items(x).SubItems.Add("0,564")
        x = x + 1

        ListView1.Items.Add("3091 (.30 inch)")
        ListView1.Items(x).SubItems.Add("A-TIP Match")
        ListView1.Items(x).SubItems.Add("230")
        ListView1.Items(x).SubItems.Add("0,823")
        x = x + 1

        ListView1.Items.Add("3092 (.30 inch)")
        ListView1.Items(x).SubItems.Add("A-TIP Match")
        ListView1.Items(x).SubItems.Add("250")
        ListView1.Items(x).SubItems.Add("0,878")
        x = x + 1

        ListView1.Items.Add("33389 (.338 inch)")
        ListView1.Items(x).SubItems.Add("A-TIP Match")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,863")
        x = x + 1

        ListView1.Items.Add("3729 (.375 inch)")
        ListView1.Items(x).SubItems.Add("A-TIP Match")
        ListView1.Items(x).SubItems.Add("390")
        ListView1.Items(x).SubItems.Add("0,987")
        x = x + 1

        ListView1.Items.Add("41697 (.416 inch)")
        ListView1.Items(x).SubItems.Add("A-TIP Match")
        ListView1.Items(x).SubItems.Add("500")
        ListView1.Items(x).SubItems.Add("0,976")
        x = x + 1

        ListView1.Items.Add("2441 (6 mm)")
        ListView1.Items(x).SubItems.Add("ELD-X")
        ListView1.Items(x).SubItems.Add("90")
        ListView1.Items(x).SubItems.Add("0,409")
        x = x + 1

        ListView1.Items.Add("24550 (6 mm)")
        ListView1.Items(x).SubItems.Add("ELD-X")
        ListView1.Items(x).SubItems.Add("103")
        ListView1.Items(x).SubItems.Add("0,512")
        x = x + 1

        ListView1.Items.Add("25418 (.25 inch)")
        ListView1.Items(x).SubItems.Add("ELD-X")
        ListView1.Items(x).SubItems.Add("110")
        ListView1.Items(x).SubItems.Add("0,465")
        x = x + 1

        ListView1.Items.Add("2635 (6,5 mm)")
        ListView1.Items(x).SubItems.Add("ELD-X")
        ListView1.Items(x).SubItems.Add("143")
        ListView1.Items(x).SubItems.Add("0,625")
        x = x + 1

        ListView1.Items.Add("27356 (.270 inch)")
        ListView1.Items(x).SubItems.Add("ELD-X")
        ListView1.Items(x).SubItems.Add("145")
        ListView1.Items(x).SubItems.Add("0,536")
        x = x + 1

        ListView1.Items.Add("2826 (7 mm)")
        ListView1.Items(x).SubItems.Add("ELD-X")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,574")
        x = x + 1

        ListView1.Items.Add("2840 (7 mm)")
        ListView1.Items(x).SubItems.Add("ELD-X")
        ListView1.Items(x).SubItems.Add("162")
        ListView1.Items(x).SubItems.Add("0,630")
        x = x + 1

        ListView1.Items.Add("2841 (7 mm)")
        ListView1.Items(x).SubItems.Add("ELD-X")
        ListView1.Items(x).SubItems.Add("175")
        ListView1.Items(x).SubItems.Add("0,689")
        x = x + 1

        ListView1.Items.Add("3074 (.30 inch)")
        ListView1.Items(x).SubItems.Add("ELD-X")
        ListView1.Items(x).SubItems.Add("178")
        ListView1.Items(x).SubItems.Add("0,552")
        x = x + 1

        ListView1.Items.Add("3076 (.30 inch)")
        ListView1.Items(x).SubItems.Add("ELD-X")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,597")
        x = x + 1

        ListView1.Items.Add("3077 (.30 inch)")
        ListView1.Items(x).SubItems.Add("ELD-X")
        ListView1.Items(x).SubItems.Add("212")
        ListView1.Items(x).SubItems.Add("0,673")
        x = x + 1

        ListView1.Items.Add("3078 (.30 inch)")
        ListView1.Items(x).SubItems.Add("ELD-X")
        ListView1.Items(x).SubItems.Add("220")
        ListView1.Items(x).SubItems.Add("0,650")
        x = x + 1

        ListView1.Items.Add("33210 (.338 inch)")
        ListView1.Items(x).SubItems.Add("ELD-X")
        ListView1.Items(x).SubItems.Add("230")
        ListView1.Items(x).SubItems.Add("0,616")
        x = x + 1

        ListView1.Items.Add("33371 (.338 inch)")
        ListView1.Items(x).SubItems.Add("ELD-X")
        ListView1.Items(x).SubItems.Add("270")
        ListView1.Items(x).SubItems.Add("0,757")
        x = x + 1

        ListView1.Items.Add("2542 (.25 inch)")
        ListView1.Items(x).SubItems.Add("FTX")
        ListView1.Items(x).SubItems.Add("110")
        ListView1.Items(x).SubItems.Add("0,340")
        x = x + 1

        ListView1.Items.Add("2812 (7 mm)")
        ListView1.Items(x).SubItems.Add("FTX")
        ListView1.Items(x).SubItems.Add("120")
        ListView1.Items(x).SubItems.Add("0,320")
        x = x + 1

        ListView1.Items.Add("3027 (.30 inch)")
        ListView1.Items(x).SubItems.Add("FTX")
        ListView1.Items(x).SubItems.Add("135")
        ListView1.Items(x).SubItems.Add("0,274")
        x = x + 1

        ListView1.Items.Add("30395 (.30 inch)")
        ListView1.Items(x).SubItems.Add("FTX")
        ListView1.Items(x).SubItems.Add("160")
        ListView1.Items(x).SubItems.Add("0,330")
        x = x + 1

        ListView1.Items.Add("30396 (.30 inch)")
        ListView1.Items(x).SubItems.Add("FTX")
        ListView1.Items(x).SubItems.Add("160")
        ListView1.Items(x).SubItems.Add("0,395")
        x = x + 1

        ListView1.Items.Add("32005 (.32 inch)")
        ListView1.Items(x).SubItems.Add("FTX")
        ListView1.Items(x).SubItems.Add("165")
        ListView1.Items(x).SubItems.Add("0,310")
        x = x + 1

        ListView1.Items.Add("33104 (.338 inch)")
        ListView1.Items(x).SubItems.Add("FTX")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,430")
        x = x + 1

        ListView1.Items.Add("3502 (.35 inch)")
        ListView1.Items(x).SubItems.Add("FTX")
        ListView1.Items(x).SubItems.Add("165")
        ListView1.Items(x).SubItems.Add("0,250")
        x = x + 1

        ListView1.Items.Add("3415 (.348 inch)")
        ListView1.Items(x).SubItems.Add("FTX")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,320")
        x = x + 1

        ListView1.Items.Add("35105 (.35 inch)")
        ListView1.Items(x).SubItems.Add("FTX")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,300")
        x = x + 1

        ListView1.Items.Add("4305 (.44 inch)")
        ListView1.Items(x).SubItems.Add("FTX")
        ListView1.Items(x).SubItems.Add("265")
        ListView1.Items(x).SubItems.Add("0,225")
        x = x + 1

        ListView1.Items.Add("45201 (.45 inch)")
        ListView1.Items(x).SubItems.Add("FTX")
        ListView1.Items(x).SubItems.Add("250")
        ListView1.Items(x).SubItems.Add("0,210")
        x = x + 1

        ListView1.Items.Add("45105 (.45 inch)")
        ListView1.Items(x).SubItems.Add("FTX")
        ListView1.Items(x).SubItems.Add("325")
        ListView1.Items(x).SubItems.Add("0,230")
        x = x + 1

        ListView1.Items.Add("2453 (6 mm)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("100")
        ListView1.Items(x).SubItems.Add("0,405")
        x = x + 1

        ListView1.Items.Add("2552 (.25 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("117")
        ListView1.Items(x).SubItems.Add("0,391")
        x = x + 1

        ListView1.Items.Add("2550 (.25 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("117")
        ListView1.Items(x).SubItems.Add("0,243")
        x = x + 1

        ListView1.Items.Add("2620 (6,5 mm)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("129")
        ListView1.Items(x).SubItems.Add("0,445")
        x = x + 1

        ListView1.Items.Add("2630 (6,5 mm)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,465")
        x = x + 1

        ListView1.Items.Add("2640 (6,5 mm)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("160")
        ListView1.Items(x).SubItems.Add("0,283")
        x = x + 1

        ListView1.Items.Add("2730 (.270 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,409")
        x = x + 1

        ListView1.Items.Add("2735 (.270 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,486")
        x = x + 1

        ListView1.Items.Add("2740 (.270 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,462")
        x = x + 1

        ListView1.Items.Add("2825 (7 mm)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("139")
        ListView1.Items(x).SubItems.Add("0,453")
        x = x + 1

        ListView1.Items.Add("2820 (7 mm)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("139")
        ListView1.Items(x).SubItems.Add("0,392")
        x = x + 1

        ListView1.Items.Add("2830 (7 mm)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("154")
        ListView1.Items(x).SubItems.Add("0,433")
        x = x + 1

        ListView1.Items.Add("2845 (7 mm)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("162")
        ListView1.Items(x).SubItems.Add("0,514")
        x = x + 1

        ListView1.Items.Add("2850 (7 mm)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("175")
        ListView1.Items(x).SubItems.Add("0,462")
        x = x + 1

        ListView1.Items.Add("3033 (.30 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,349")
        x = x + 1

        ListView1.Items.Add("3035 (.30 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("156")
        ListView1.Items(x).SubItems.Add("0,186")
        x = x + 1

        ListView1.Items.Add("3031 (.30 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,338")
        x = x + 1

        ListView1.Items.Add("3040 (.30 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("165")
        ListView1.Items(x).SubItems.Add("0,387")
        x = x + 1

        ListView1.Items.Add("3045 (.30 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("165")
        ListView1.Items(x).SubItems.Add("0,435")
        x = x + 1

        ListView1.Items.Add("3060 (.30 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("170")
        ListView1.Items(x).SubItems.Add("0,189")
        x = x + 1

        ListView1.Items.Add("3072 (.30 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,452")
        x = x + 1

        ListView1.Items.Add("3075 (.30 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,241")
        x = x + 1

        ListView1.Items.Add("3070 (.30 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,425")
        x = x + 1

        ListView1.Items.Add("3090 (.30 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("220")
        ListView1.Items(x).SubItems.Add("0,300")
        x = x + 1

        ListView1.Items.Add("3140 (7,62 mm)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("123")
        ListView1.Items(x).SubItems.Add("0,252")
        x = x + 1

        ListView1.Items.Add("3120 (.303 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,361")
        x = x + 1

        ListView1.Items.Add("3130 (.303 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("174")
        ListView1.Items(x).SubItems.Add("0,262")
        x = x + 1

        ListView1.Items.Add("3210 (.32 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("170")
        ListView1.Items(x).SubItems.Add("0,249")
        x = x + 1

        ListView1.Items.Add("3232 (8 mm)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,290")
        x = x + 1

        ListView1.Items.Add("3235 (8 mm)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("170")
        ListView1.Items(x).SubItems.Add("0,217")
        x = x + 1

        ListView1.Items.Add("3236 (8 mm)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("195")
        ListView1.Items(x).SubItems.Add("0,410")
        x = x + 1

        ListView1.Items.Add("3320 (.338 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("225")
        ListView1.Items(x).SubItems.Add("0,397")
        x = x + 1

        ListView1.Items.Add("3330 (.338 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("250")
        ListView1.Items(x).SubItems.Add("0,291")
        x = x + 1

        ListView1.Items.Add("3335 (.338 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("250")
        ListView1.Items(x).SubItems.Add("0,431")
        x = x + 1

        ListView1.Items.Add("3410 (.348 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,246")
        x = x + 1

        ListView1.Items.Add("3501 (.35 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("170")
        ListView1.Items(x).SubItems.Add("0,215")
        x = x + 1

        ListView1.Items.Add("3515 (.35 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,195")
        x = x + 1

        ListView1.Items.Add("3510 (.35 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,282")
        x = x + 1

        ListView1.Items.Add("3520 (.35 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("250")
        ListView1.Items(x).SubItems.Add("0,375")
        x = x + 1

        ListView1.Items.Add("3560 (9,3 mm)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("286")
        ListView1.Items(x).SubItems.Add("0,400")
        x = x + 1

        ListView1.Items.Add("3711 (.375 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("270")
        ListView1.Items(x).SubItems.Add("0,380")
        x = x + 1

        ListView1.Items.Add("41051 (.405 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,250")
        x = x + 1

        ListView1.Items.Add("45204 (.45 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("245")
        ListView1.Items(x).SubItems.Add("0,165")
        x = x + 1

        ListView1.Items.Add("4300 (.44 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("265")
        ListView1.Items(x).SubItems.Add("0,189")
        x = x + 1

        ListView1.Items.Add("4500 (.45 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,197")
        x = x + 1

        ListView1.Items.Add("4502 (.45 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("350")
        ListView1.Items(x).SubItems.Add("0,189")
        x = x + 1

        ListView1.Items.Add("4503 (.45 inch)")
        ListView1.Items(x).SubItems.Add("InterLock")
        ListView1.Items(x).SubItems.Add("350")
        ListView1.Items(x).SubItems.Add("0,195")
        x = x + 1

        ListView1.Items.Add("22000 (.20 inch)")
        ListView1.Items(x).SubItems.Add("NTX")
        ListView1.Items(x).SubItems.Add("24")
        ListView1.Items(x).SubItems.Add("0,170")
        x = x + 1

        ListView1.Items.Add("22240 (.22 inch)")
        ListView1.Items(x).SubItems.Add("NTX")
        ListView1.Items(x).SubItems.Add("35")
        ListView1.Items(x).SubItems.Add("0,177")
        x = x + 1

        ListView1.Items.Add("21710 (.17 inch)")
        ListView1.Items(x).SubItems.Add("V-MAX")
        ListView1.Items(x).SubItems.Add("20")
        ListView1.Items(x).SubItems.Add("0,185")
        x = x + 1

        ListView1.Items.Add("17105 (.17 inch)")
        ListView1.Items(x).SubItems.Add("V-MAX")
        ListView1.Items(x).SubItems.Add("25")
        ListView1.Items(x).SubItems.Add("0,230")
        x = x + 1

        ListView1.Items.Add("22004 (.20 inch)")
        ListView1.Items(x).SubItems.Add("V-MAX")
        ListView1.Items(x).SubItems.Add("32")
        ListView1.Items(x).SubItems.Add("0,210")
        x = x + 1

        ListView1.Items.Add("22006 (.20 inch)")
        ListView1.Items(x).SubItems.Add("V-MAX")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,275")
        x = x + 1

        ListView1.Items.Add("22606 (.20 inch)")
        ListView1.Items(x).SubItems.Add("V-MAX")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,275")
        x = x + 1

        ListView1.Items.Add("2207 (.2215 inch)")
        ListView1.Items(x).SubItems.Add("V-MAX")
        ListView1.Items(x).SubItems.Add("60")
        ListView1.Items(x).SubItems.Add("0,285")
        x = x + 1

        ListView1.Items.Add("22252 (.22 inch)")
        ListView1.Items(x).SubItems.Add("V-MAX")
        ListView1.Items(x).SubItems.Add("35")
        ListView1.Items(x).SubItems.Add("0,109")
        x = x + 1

        ListView1.Items.Add("22241 (.22 inch)")
        ListView1.Items(x).SubItems.Add("V-MAX")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,200")
        x = x + 1

        ListView1.Items.Add("22416 (.22 inch)")
        ListView1.Items(x).SubItems.Add("V-MAX")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,200")
        x = x + 1

        ListView1.Items.Add("22261 (.22 inch)")
        ListView1.Items(x).SubItems.Add("V-MAX")
        ListView1.Items(x).SubItems.Add("50")
        ListView1.Items(x).SubItems.Add("0,242")
        x = x + 1

        ListView1.Items.Add("22616 (.22 inch)")
        ListView1.Items(x).SubItems.Add("V-MAX")
        ListView1.Items(x).SubItems.Add("50")
        ListView1.Items(x).SubItems.Add("0,242")
        x = x + 1

        ListView1.Items.Add("22265 (.22 inch)")
        ListView1.Items(x).SubItems.Add("V-MAX")
        ListView1.Items(x).SubItems.Add("53")
        ListView1.Items(x).SubItems.Add("0,290")
        x = x + 1

        ListView1.Items.Add("22272 (.22 inch)")
        ListView1.Items(x).SubItems.Add("V-MAX")
        ListView1.Items(x).SubItems.Add("55")
        ListView1.Items(x).SubItems.Add("0,255")
        x = x + 1

        ListView1.Items.Add("22281 (.22 inch)")
        ListView1.Items(x).SubItems.Add("V-MAX")
        ListView1.Items(x).SubItems.Add("60")
        ListView1.Items(x).SubItems.Add("0,265")
        x = x + 1

        ListView1.Items.Add("22411 (6 mm)")
        ListView1.Items(x).SubItems.Add("V-MAX")
        ListView1.Items(x).SubItems.Add("58")
        ListView1.Items(x).SubItems.Add("0,250")
        x = x + 1

        ListView1.Items.Add("22415 (6 mm)")
        ListView1.Items(x).SubItems.Add("V-MAX")
        ListView1.Items(x).SubItems.Add("65")
        ListView1.Items(x).SubItems.Add("0,280")
        x = x + 1

        ListView1.Items.Add("22420 (6 mm)")
        ListView1.Items(x).SubItems.Add("V-MAX")
        ListView1.Items(x).SubItems.Add("75")
        ListView1.Items(x).SubItems.Add("0,330")
        x = x + 1

        ListView1.Items.Add("22440 (6 mm)")
        ListView1.Items(x).SubItems.Add("V-MAX")
        ListView1.Items(x).SubItems.Add("87")
        ListView1.Items(x).SubItems.Add("0,400")
        x = x + 1

        ListView1.Items.Add("22520 (.25 inch)")
        ListView1.Items(x).SubItems.Add("V-MAX")
        ListView1.Items(x).SubItems.Add("75")
        ListView1.Items(x).SubItems.Add("0,290")
        x = x + 1

        ListView1.Items.Add("22601 (6,5 mm)")
        ListView1.Items(x).SubItems.Add("V-MAX")
        ListView1.Items(x).SubItems.Add("95")
        ListView1.Items(x).SubItems.Add("0,365")
        x = x + 1

        ListView1.Items.Add("22721 (.270 inch)")
        ListView1.Items(x).SubItems.Add("V-MAX")
        ListView1.Items(x).SubItems.Add("110")
        ListView1.Items(x).SubItems.Add("0,370")
        x = x + 1

        ListView1.Items.Add("22810 (7 mm)")
        ListView1.Items(x).SubItems.Add("V-MAX")
        ListView1.Items(x).SubItems.Add("120")
        ListView1.Items(x).SubItems.Add("0,365")
        x = x + 1

        ListView1.Items.Add("23010 (.30 inch)")
        ListView1.Items(x).SubItems.Add("V-MAX")
        ListView1.Items(x).SubItems.Add("110")
        ListView1.Items(x).SubItems.Add("0,290")
        x = x + 1

        ListView1.Items.Add("3565 (9,3 mm)")
        ListView1.Items(x).SubItems.Add("DGS")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,280")
        x = x + 1

        ListView1.Items.Add("3727 (.375 inch)")
        ListView1.Items(x).SubItems.Add("DGS")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,275")
        x = x + 1

        ListView1.Items.Add("4103 (.400 inch)")
        ListView1.Items(x).SubItems.Add("DGS")
        ListView1.Items(x).SubItems.Add("400")
        ListView1.Items(x).SubItems.Add("0,325")
        x = x + 1

        ListView1.Items.Add("4167 (.416 inch)")
        ListView1.Items(x).SubItems.Add("DGS")
        ListView1.Items(x).SubItems.Add("400")
        ListView1.Items(x).SubItems.Add("0,319")
        x = x + 1

        ListView1.Items.Add("4241 (.423 inch)")
        ListView1.Items(x).SubItems.Add("DGS")
        ListView1.Items(x).SubItems.Add("400")
        ListView1.Items(x).SubItems.Add("0,315")
        x = x + 1

        ListView1.Items.Add("45033 (.45 inch)")
        ListView1.Items(x).SubItems.Add("DGS")
        ListView1.Items(x).SubItems.Add("480")
        ListView1.Items(x).SubItems.Add("0,285")
        x = x + 1

        ListView1.Items.Add("4507 (.45 inch)")
        ListView1.Items(x).SubItems.Add("DGS")
        ListView1.Items(x).SubItems.Add("500")
        ListView1.Items(x).SubItems.Add("0,295")
        x = x + 1

        ListView1.Items.Add("4748 (.470 inch)")
        ListView1.Items(x).SubItems.Add("DGS")
        ListView1.Items(x).SubItems.Add("500")
        ListView1.Items(x).SubItems.Add("0,290")
        x = x + 1

        ListView1.Items.Add("5051 (.505 inch)")
        ListView1.Items(x).SubItems.Add("DGS")
        ListView1.Items(x).SubItems.Add("525")
        ListView1.Items(x).SubItems.Add("0,270")
        x = x + 1

        ListView1.Items.Add("5155 (.50 inch)")
        ListView1.Items(x).SubItems.Add("DGS")
        ListView1.Items(x).SubItems.Add("570")
        ListView1.Items(x).SubItems.Add("0,295")
        x = x + 1

        ListView1.Items.Add("22273 (.22 inch)")
        ListView1.Items(x).SubItems.Add("GMX")
        ListView1.Items(x).SubItems.Add("55")
        ListView1.Items(x).SubItems.Add("0,245")
        x = x + 1

        ListView1.Items.Add("2281 (.22 inch)")
        ListView1.Items(x).SubItems.Add("GMX")
        ListView1.Items(x).SubItems.Add("70")
        ListView1.Items(x).SubItems.Add("0,350")
        x = x + 1

        ListView1.Items.Add("2444 (6 mm)")
        ListView1.Items(x).SubItems.Add("GMX")
        ListView1.Items(x).SubItems.Add("90")
        ListView1.Items(x).SubItems.Add("0,422")
        x = x + 1

        ListView1.Items.Add("24370 (6 mm)")
        ListView1.Items(x).SubItems.Add("GMX")
        ListView1.Items(x).SubItems.Add("80")
        ListView1.Items(x).SubItems.Add("0,300")
        x = x + 1

        ListView1.Items.Add("25410 (.25 inch)")
        ListView1.Items(x).SubItems.Add("GMX")
        ListView1.Items(x).SubItems.Add("90")
        ListView1.Items(x).SubItems.Add("0,290")
        x = x + 1

        ListView1.Items.Add("26336 (6,5 mm)")
        ListView1.Items(x).SubItems.Add("GMX")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,350")
        x = x + 1

        ListView1.Items.Add("26110 (6,5 mm)")
        ListView1.Items(x).SubItems.Add("GMX")
        ListView1.Items(x).SubItems.Add("120")
        ListView1.Items(x).SubItems.Add("0,450")
        x = x + 1

        ListView1.Items.Add("27190 (.270 inch)")
        ListView1.Items(x).SubItems.Add("GMX")
        ListView1.Items(x).SubItems.Add("100")
        ListView1.Items(x).SubItems.Add("0,274")
        x = x + 1

        ListView1.Items.Add("27370 (.270 inch)")
        ListView1.Items(x).SubItems.Add("GMX")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,460")
        x = x + 1

        ListView1.Items.Add("28270 (7 mm)")
        ListView1.Items(x).SubItems.Add("GMX")
        ListView1.Items(x).SubItems.Add("139")
        ListView1.Items(x).SubItems.Add("0,486")
        x = x + 1

        ListView1.Items.Add("2828 (7 mm)")
        ListView1.Items(x).SubItems.Add("GMX")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,464")
        x = x + 1

        ListView1.Items.Add("30191 (.30 inch)")
        ListView1.Items(x).SubItems.Add("GMX")
        ListView1.Items(x).SubItems.Add("110")
        ListView1.Items(x).SubItems.Add("0,305")
        x = x + 1

        ListView1.Items.Add("30190 (.30 inch)")
        ListView1.Items(x).SubItems.Add("GMX")
        ListView1.Items(x).SubItems.Add("125")
        ListView1.Items(x).SubItems.Add("0,295")
        x = x + 1

        ListView1.Items.Add("30370 (.30 inch)")
        ListView1.Items(x).SubItems.Add("GMX")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,415")
        x = x + 1

        ListView1.Items.Add("30470 (.30 inch)")
        ListView1.Items(x).SubItems.Add("GMX")
        ListView1.Items(x).SubItems.Add("165")
        ListView1.Items(x).SubItems.Add("0,447")
        x = x + 1

        ListView1.Items.Add("30193 (.30 inch)")
        ListView1.Items(x).SubItems.Add("GMX")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,485")
        x = x + 1

        ListView1.Items.Add("3234 (8 mm)")
        ListView1.Items(x).SubItems.Add("GMX")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,420")
        x = x + 1

        ListView1.Items.Add("33201 (.338 inch)")
        ListView1.Items(x).SubItems.Add("GMX")
        ListView1.Items(x).SubItems.Add("225")
        ListView1.Items(x).SubItems.Add("0,470")
        x = x + 1

        ListView1.Items.Add("33270 (.338 inch)")
        ListView1.Items(x).SubItems.Add("GMX")
        ListView1.Items(x).SubItems.Add("185")
        ListView1.Items(x).SubItems.Add("0,420")
        x = x + 1

        ListView1.Items.Add("3562 (9,3 mm)")
        ListView1.Items(x).SubItems.Add("GMX")
        ListView1.Items(x).SubItems.Add("250")
        ListView1.Items(x).SubItems.Add("0,360")
        x = x + 1

        ListView1.Items.Add("3708 (.375 inch)")
        ListView1.Items(x).SubItems.Add("GMX")
        ListView1.Items(x).SubItems.Add("250")
        ListView1.Items(x).SubItems.Add("0,430")
        x = x + 1

        ListView1.Items.Add("24532 (6 mm)")
        ListView1.Items(x).SubItems.Add("SST")
        ListView1.Items(x).SubItems.Add("95")
        ListView1.Items(x).SubItems.Add("0,355")
        x = x + 1

        ListView1.Items.Add("25522 (.25 inch)")
        ListView1.Items(x).SubItems.Add("SST")
        ListView1.Items(x).SubItems.Add("117")
        ListView1.Items(x).SubItems.Add("0,390")
        x = x + 1

        ListView1.Items.Add("26173 (6,5 mm)")
        ListView1.Items(x).SubItems.Add("SST")
        ListView1.Items(x).SubItems.Add("123")
        ListView1.Items(x).SubItems.Add("0,510")
        x = x + 1

        ListView1.Items.Add("26202 (6,5 mm)")
        ListView1.Items(x).SubItems.Add("SST")
        ListView1.Items(x).SubItems.Add("129")
        ListView1.Items(x).SubItems.Add("0,485")
        x = x + 1

        ListView1.Items.Add("26302 (6,5 mm)")
        ListView1.Items(x).SubItems.Add("SST")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,520")
        x = x + 1

        ListView1.Items.Add("2716 (.270 inch)")
        ListView1.Items(x).SubItems.Add("SST")
        ListView1.Items(x).SubItems.Add("120")
        ListView1.Items(x).SubItems.Add("0,400")
        x = x + 1

        ListView1.Items.Add("27302 (.270 inch)")
        ListView1.Items(x).SubItems.Add("SST")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,460")
        x = x + 1

        ListView1.Items.Add("27352 (.270 inch)")
        ListView1.Items(x).SubItems.Add("SST")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,495")
        x = x + 1

        ListView1.Items.Add("27402 (.270 inch)")
        ListView1.Items(x).SubItems.Add("SST")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,525")
        x = x + 1

        ListView1.Items.Add("28202 (7 mm)")
        ListView1.Items(x).SubItems.Add("SST")
        ListView1.Items(x).SubItems.Add("139")
        ListView1.Items(x).SubItems.Add("0,486")
        x = x + 1

        ListView1.Items.Add("28302 (7 mm)")
        ListView1.Items(x).SubItems.Add("SST")
        ListView1.Items(x).SubItems.Add("154")
        ListView1.Items(x).SubItems.Add("0,525")
        x = x + 1

        ListView1.Items.Add("28452 (7 mm)")
        ListView1.Items(x).SubItems.Add("SST")
        ListView1.Items(x).SubItems.Add("162")
        ListView1.Items(x).SubItems.Add("0,550")
        x = x + 1

        ListView1.Items.Add("3019 (.30 inch)")
        ListView1.Items(x).SubItems.Add("SST")
        ListView1.Items(x).SubItems.Add("125")
        ListView1.Items(x).SubItems.Add("0,305")
        x = x + 1

        ListView1.Items.Add("30302 (.30 inch)")
        ListView1.Items(x).SubItems.Add("SST")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,415")
        x = x + 1

        ListView1.Items.Add("30303 (.30 inch)")
        ListView1.Items(x).SubItems.Add("SST")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,370")
        x = x + 1

        ListView1.Items.Add("30452 (.30 inch)")
        ListView1.Items(x).SubItems.Add("SST")
        ListView1.Items(x).SubItems.Add("165")
        ListView1.Items(x).SubItems.Add("0,447")
        x = x + 1

        ListView1.Items.Add("30702 (.30 inch)")
        ListView1.Items(x).SubItems.Add("SST")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,480")
        x = x + 1

        ListView1.Items.Add("3142 (7,62 mm)")
        ListView1.Items(x).SubItems.Add("SST")
        ListView1.Items(x).SubItems.Add("123")
        ListView1.Items(x).SubItems.Add("0,295")
        x = x + 1

        ListView1.Items.Add("3233 (8 mm)")
        ListView1.Items(x).SubItems.Add("SST")
        ListView1.Items(x).SubItems.Add("170")
        ListView1.Items(x).SubItems.Add("0,445")
        x = x + 1

        ListView1.Items.Add("33102 (.338 inch)")
        ListView1.Items(x).SubItems.Add("SST")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,455")
        x = x + 1

        ListView1.Items.Add("33202 (.338 inch)")
        ListView1.Items(x).SubItems.Add("SST")
        ListView1.Items(x).SubItems.Add("225")
        ListView1.Items(x).SubItems.Add("0,515")
        x = x + 1

        ListView1.Items.Add("2230 (.22 inch)")
        ListView1.Items(x).SubItems.Add("Varmint")
        ListView1.Items(x).SubItems.Add("45")
        ListView1.Items(x).SubItems.Add("0,202")
        x = x + 1

        ListView1.Items.Add("2229 (.22 inch)")
        ListView1.Items(x).SubItems.Add("Varmint")
        ListView1.Items(x).SubItems.Add("45")
        ListView1.Items(x).SubItems.Add("0,108")
        x = x + 1

        ListView1.Items.Add("2245 (.22 inch)")
        ListView1.Items(x).SubItems.Add("Varmint")
        ListView1.Items(x).SubItems.Add("50")
        ListView1.Items(x).SubItems.Add("0,214")
        x = x + 1

        ListView1.Items.Add("2240 (.22 inch)")
        ListView1.Items(x).SubItems.Add("Varmint")
        ListView1.Items(x).SubItems.Add("50")
        ListView1.Items(x).SubItems.Add("0,214")
        x = x + 1

        ListView1.Items.Add("2266 (.22 inch)")
        ListView1.Items(x).SubItems.Add("Varmint")
        ListView1.Items(x).SubItems.Add("55")
        ListView1.Items(x).SubItems.Add("0,235")
        x = x + 1

        ListView1.Items.Add("2275 (.22 inch)")
        ListView1.Items(x).SubItems.Add("Varmint")
        ListView1.Items(x).SubItems.Add("60")
        ListView1.Items(x).SubItems.Add("0,271")
        x = x + 1

        ListView1.Items.Add("2270 (.22 inch)")
        ListView1.Items(x).SubItems.Add("Varmint")
        ListView1.Items(x).SubItems.Add("60")
        ListView1.Items(x).SubItems.Add("0,264")
        x = x + 1

        ListView1.Items.Add("2442 (6 mm)")
        ListView1.Items(x).SubItems.Add("Varmint")
        ListView1.Items(x).SubItems.Add("87")
        ListView1.Items(x).SubItems.Add("0,376")
        x = x + 1

        ListView1.Items.Add("2440 (6 mm)")
        ListView1.Items(x).SubItems.Add("Varmint")
        ListView1.Items(x).SubItems.Add("87")
        ListView1.Items(x).SubItems.Add("0,327")
        x = x + 1

        ListView1.Items.Add("3005 (.30 inch)")
        ListView1.Items(x).SubItems.Add("Varmint")
        ListView1.Items(x).SubItems.Add("100")
        ListView1.Items(x).SubItems.Add("0,152")
        x = x + 1

        ListView1.Items.Add("3010 (.30 inch)")
        ListView1.Items(x).SubItems.Add("Varmint")
        ListView1.Items(x).SubItems.Add("110")
        ListView1.Items(x).SubItems.Add("0,256")
        x = x + 1

        ListView1.Items.Add("3020 (.30 inch)")
        ListView1.Items(x).SubItems.Add("Varmint")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,295")
        x = x + 1

        ListView1.Items.Add("22402 (.22 inch)")
        ListView1.Items(x).SubItems.Add("CX")
        ListView1.Items(x).SubItems.Add("50")
        ListView1.Items(x).SubItems.Add("0,164")
        x = x + 1

        ListView1.Items.Add("243704 (6 mm)")
        ListView1.Items(x).SubItems.Add("CX")
        ListView1.Items(x).SubItems.Add("80")
        ListView1.Items(x).SubItems.Add("0,273")
        x = x + 1

        ListView1.Items.Add("24444 (6 mm)")
        ListView1.Items(x).SubItems.Add("CX")
        ListView1.Items(x).SubItems.Add("90")
        ListView1.Items(x).SubItems.Add("0,418")
        x = x + 1

        ListView1.Items.Add("254104 (.25 inch)")
        ListView1.Items(x).SubItems.Add("CX")
        ListView1.Items(x).SubItems.Add("90")
        ListView1.Items(x).SubItems.Add("0,273")
        x = x + 1

        ListView1.Items.Add("261104 (6,5 mm)")
        ListView1.Items(x).SubItems.Add("CX")
        ListView1.Items(x).SubItems.Add("120")
        ListView1.Items(x).SubItems.Add("0,428")
        x = x + 1

        ListView1.Items.Add("26178 (6,5 mm)")
        ListView1.Items(x).SubItems.Add("CX")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,489")
        x = x + 1

        ListView1.Items.Add("271904 (.270 inch)")
        ListView1.Items(x).SubItems.Add("CX")
        ListView1.Items(x).SubItems.Add("100")
        ListView1.Items(x).SubItems.Add("0,262")
        x = x + 1

        ListView1.Items.Add("273704 (.270 inch)")
        ListView1.Items(x).SubItems.Add("CX")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,403")
        x = x + 1

        ListView1.Items.Add("282704 (7 mm)")
        ListView1.Items(x).SubItems.Add("CX")
        ListView1.Items(x).SubItems.Add("139")
        ListView1.Items(x).SubItems.Add("0,429")
        x = x + 1

        ListView1.Items.Add("28284 (7 mm)")
        ListView1.Items(x).SubItems.Add("CX")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,455")
        x = x + 1

        ListView1.Items.Add("2837 (7 mm)")
        ListView1.Items(x).SubItems.Add("CX")
        ListView1.Items(x).SubItems.Add("160")
        ListView1.Items(x).SubItems.Add("0,596")
        x = x + 1

        ListView1.Items.Add("301914 (.30 inch)")
        ListView1.Items(x).SubItems.Add("CX")
        ListView1.Items(x).SubItems.Add("110")
        ListView1.Items(x).SubItems.Add("0,312")
        x = x + 1

        ListView1.Items.Add("303704 (.30 inch)")
        ListView1.Items(x).SubItems.Add("CX")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,418")
        x = x + 1

        ListView1.Items.Add("304704 (.30 inch)")
        ListView1.Items(x).SubItems.Add("CX")
        ListView1.Items(x).SubItems.Add("165")
        ListView1.Items(x).SubItems.Add("0,440")
        x = x + 1

        ListView1.Items.Add("301934 (.30 inch)")
        ListView1.Items(x).SubItems.Add("CX")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,469")
        x = x + 1

        ListView1.Items.Add("30738 (.30 inch)")
        ListView1.Items(x).SubItems.Add("CX")
        ListView1.Items(x).SubItems.Add("190")
        ListView1.Items(x).SubItems.Add("0,575")
        x = x + 1

        ListView1.Items.Add("332704 (.338 inch)")
        ListView1.Items(x).SubItems.Add("CX")
        ListView1.Items(x).SubItems.Add("185")
        ListView1.Items(x).SubItems.Add("0,407")
        x = x + 1

        ListView1.Items.Add("332014 (.338 inch)")
        ListView1.Items(x).SubItems.Add("CX")
        ListView1.Items(x).SubItems.Add("225")
        ListView1.Items(x).SubItems.Add("0,490")
        x = x + 1

        ListView1.Items.Add("37084 (.375 inch)")
        ListView1.Items(x).SubItems.Add("CX")
        ListView1.Items(x).SubItems.Add("250")
        ListView1.Items(x).SubItems.Add("0,403")
        x = x + 1

        ListView1.Items.Add("30718 (.30 inch)")
        ListView1.Items(x).SubItems.Add("SUB-X")
        ListView1.Items(x).SubItems.Add("175")
        ListView1.Items(x).SubItems.Add("0,300")
        x = x + 1

        ListView1.Items.Add("30730 (.30 inch)")
        ListView1.Items(x).SubItems.Add("SUB-X")
        ListView1.Items(x).SubItems.Add("190")
        ListView1.Items(x).SubItems.Add("0,437")
        x = x + 1

        ListView1.Items.Add("3503 (.35 inch)")
        ListView1.Items(x).SubItems.Add("SUB-X")
        ListView1.Items(x).SubItems.Add("250")
        ListView1.Items(x).SubItems.Add("0,265")
        x = x + 1

        ListView1.Items.Add("45031 (.45 inch)")
        ListView1.Items(x).SubItems.Add("SUB-X")
        ListView1.Items(x).SubItems.Add("395")
        ListView1.Items(x).SubItems.Add("0,300")
        x = x + 1

        ListView1.Items.Add("45052 (.45 inch)")
        ListView1.Items(x).SubItems.Add("SUB-X")
        ListView1.Items(x).SubItems.Add("410")
        ListView1.Items(x).SubItems.Add("0,285")
        x = x + 1
    End Sub

    Private Sub puškové_střely_S()

        Dim x As Integer = 0

        ListView1.Columns.Add(0).Width = 237
        ListView1.Columns.Add(1).Width = 237
        ListView1.Columns.Add(2).Width = 237
        ListView1.Columns.Add(3).Width = 237

        ListView1.Columns(0).Text = "Bullet name and caliber"
        ListView1.Columns(1).Text = "Bullet type"
        ListView1.Columns(2).Text = "Bullet weight [grs]"
        ListView1.Columns(3).Text = "Ballistic coefficient G1"

        ListView1.Items.Add(".22 inch HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("52")
        ListView1.Items(x).SubItems.Add("0,220")
        x = x + 1

        ListView1.Items.Add(".22 inch HP")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("53")
        ListView1.Items(x).SubItems.Add("0,218")
        x = x + 1

        ListView1.Items.Add(".22 inch TMK")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("60")
        ListView1.Items(x).SubItems.Add("0,293")
        x = x + 1

        ListView1.Items.Add(".22 inch HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("69")
        ListView1.Items(x).SubItems.Add("0,308")
        x = x + 1

        ListView1.Items.Add(".22 inch TMK")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("69")
        ListView1.Items(x).SubItems.Add("0,345")
        x = x + 1

        ListView1.Items.Add(".22 inch TMK")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("77")
        ListView1.Items(x).SubItems.Add("0,403")
        x = x + 1

        ListView1.Items.Add(".22 inch HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("77")
        ListView1.Items(x).SubItems.Add("0,360")
        x = x + 1

        ListView1.Items.Add(".22 inch HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("80")
        ListView1.Items(x).SubItems.Add("0,445")
        x = x + 1

        ListView1.Items.Add(".22 inch HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("90")
        ListView1.Items(x).SubItems.Add("0,531")
        x = x + 1

        ListView1.Items.Add(".22 inch HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("95")
        ListView1.Items(x).SubItems.Add("0,554")
        x = x + 1

        ListView1.Items.Add("6 mm HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("70")
        ListView1.Items(x).SubItems.Add("0,262")
        x = x + 1

        ListView1.Items.Add("6 mm HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("95")
        ListView1.Items(x).SubItems.Add("0,467")
        x = x + 1

        ListView1.Items.Add(".243 TMK ")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("95")
        ListView1.Items(x).SubItems.Add("0,483")
        x = x + 1

        ListView1.Items.Add("6 mm HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("107")
        ListView1.Items(x).SubItems.Add("0,534")
        x = x + 1

        ListView1.Items.Add("6 mm HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("110")
        ListView1.Items(x).SubItems.Add("0,601")
        x = x + 1

        ListView1.Items.Add(".25 inch HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("100")
        ListView1.Items(x).SubItems.Add("0,382")
        x = x + 1

        ListView1.Items.Add("6,5 mm HP")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("100")
        ListView1.Items(x).SubItems.Add("0,341")
        x = x + 1

        ListView1.Items.Add("6,5 mm HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("107")
        ListView1.Items(x).SubItems.Add("0,407")
        x = x + 1

        ListView1.Items.Add("6,5 mm TMK")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("107")
        ListView1.Items(x).SubItems.Add("0,438")
        x = x + 1

        ListView1.Items.Add("6,5 mm HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("120")
        ListView1.Items(x).SubItems.Add("0,413")
        x = x + 1

        ListView1.Items.Add("6,5 mm HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("123")
        ListView1.Items(x).SubItems.Add("0,464")
        x = x + 1

        ListView1.Items.Add(".264 inch TMK")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,516")
        x = x + 1

        ListView1.Items.Add("6,5 mm HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,527")
        x = x + 1

        ListView1.Items.Add("6,5 mm HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("142")
        ListView1.Items(x).SubItems.Add("0,606")
        x = x + 1

        ListView1.Items.Add("6,5 mm HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("144")
        ListView1.Items(x).SubItems.Add("0,542")
        x = x + 1

        ListView1.Items.Add("6,5 mm HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,673")
        x = x + 1

        ListView1.Items.Add(".270 inch HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("115")
        ListView1.Items(x).SubItems.Add("0,303")
        x = x + 1

        ListView1.Items.Add(".270 inch HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("135")
        ListView1.Items(x).SubItems.Add("0,450")
        x = x + 1

        ListView1.Items.Add("7 mm HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,438")
        x = x + 1

        ListView1.Items.Add(".284 inch TMK")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("160")
        ListView1.Items(x).SubItems.Add("0,600")
        x = x + 1

        ListView1.Items.Add("7 mm HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("168")
        ListView1.Items(x).SubItems.Add("0,489")
        x = x + 1

        ListView1.Items.Add("7 mm HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("175")
        ListView1.Items(x).SubItems.Add("0,556")
        x = x + 1

        ListView1.Items.Add("7 mm HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,640")
        x = x + 1

        ListView1.Items.Add("7 mm HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("183")
        ListView1.Items(x).SubItems.Add("0,703")
        x = x + 1

        ListView1.Items.Add("7 mm HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("197")
        ListView1.Items(x).SubItems.Add("0,752")
        x = x + 1

        ListView1.Items.Add(".30 inch HP")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("125")
        ListView1.Items(x).SubItems.Add("0,332")
        x = x + 1

        ListView1.Items.Add(".30 inch TMK")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("125")
        ListView1.Items(x).SubItems.Add("0,338")
        x = x + 1

        ListView1.Items.Add(".30 inch HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,390")
        x = x + 1

        ListView1.Items.Add(".30 inch HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("155")
        ListView1.Items(x).SubItems.Add("0,437")
        x = x + 1

        ListView1.Items.Add(".30 inch PALMA")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("155")
        ListView1.Items(x).SubItems.Add("0,446")
        x = x + 1

        ListView1.Items.Add(".30 inch TMK")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("155")
        ListView1.Items(x).SubItems.Add("0,476")
        x = x + 1

        ListView1.Items.Add(".30 inch TMK")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("168")
        ListView1.Items(x).SubItems.Add("0,512")
        x = x + 1

        ListView1.Items.Add(".30 inch HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("168")
        ListView1.Items(x).SubItems.Add("0,435")
        x = x + 1

        ListView1.Items.Add(".30 inch HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("175")
        ListView1.Items(x).SubItems.Add("0,495")
        x = x + 1

        ListView1.Items.Add(".30 inch TMK")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("175")
        ListView1.Items(x).SubItems.Add("0,523")
        x = x + 1

        ListView1.Items.Add(".30 inch HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("190")
        ListView1.Items(x).SubItems.Add("0,524")
        x = x + 1

        ListView1.Items.Add(".30 inch TMK")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("195")
        ListView1.Items(x).SubItems.Add("0,588")
        x = x + 1

        ListView1.Items.Add(".30 inch HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,690")
        x = x + 1

        ListView1.Items.Add("7,62 mm HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,562")
        x = x + 1

        ListView1.Items.Add(".30 inch HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("210")
        ListView1.Items(x).SubItems.Add("0,637")
        x = x + 1

        ListView1.Items.Add(".30 inch HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("220")
        ListView1.Items(x).SubItems.Add("0,620")
        x = x + 1

        ListView1.Items.Add(".30 inch HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("230")
        ListView1.Items(x).SubItems.Add("0,773")
        x = x + 1

        ListView1.Items.Add(".303 inch HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("174")
        ListView1.Items(x).SubItems.Add("0,491")
        x = x + 1

        ListView1.Items.Add("8 mm HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,496")
        x = x + 1

        ListView1.Items.Add(".338 inch HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("250")
        ListView1.Items(x).SubItems.Add("0,585")
        x = x + 1

        ListView1.Items.Add(".338 inch HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,759")
        x = x + 1

        ListView1.Items.Add(".375 inch HPBT")
        ListView1.Items(x).SubItems.Add("MatchKing")
        ListView1.Items(x).SubItems.Add("350")
        ListView1.Items(x).SubItems.Add("0,770")
        x = x + 1

        ListView1.Items.Add(".20 inch")
        ListView1.Items(x).SubItems.Add("Blitzking")
        ListView1.Items(x).SubItems.Add("32")
        ListView1.Items(x).SubItems.Add("0,202")
        x = x + 1

        ListView1.Items.Add(".20 inch")
        ListView1.Items(x).SubItems.Add("Blitzking")
        ListView1.Items(x).SubItems.Add("39")
        ListView1.Items(x).SubItems.Add("0,252")
        x = x + 1

        ListView1.Items.Add(".22 inch")
        ListView1.Items(x).SubItems.Add("Blitzking")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,182")
        x = x + 1

        ListView1.Items.Add(".22 inch")
        ListView1.Items(x).SubItems.Add("Blitzking")
        ListView1.Items(x).SubItems.Add("50")
        ListView1.Items(x).SubItems.Add("0,230")
        x = x + 1

        ListView1.Items.Add(".22 inch")
        ListView1.Items(x).SubItems.Add("Blitzking")
        ListView1.Items(x).SubItems.Add("55")
        ListView1.Items(x).SubItems.Add("0,249")
        x = x + 1

        ListView1.Items.Add(".243 inch")
        ListView1.Items(x).SubItems.Add("Blitzking")
        ListView1.Items(x).SubItems.Add("55")
        ListView1.Items(x).SubItems.Add("0,213")
        x = x + 1

        ListView1.Items.Add(".243 inch")
        ListView1.Items(x).SubItems.Add("Blitzking")
        ListView1.Items(x).SubItems.Add("70")
        ListView1.Items(x).SubItems.Add("0,272")
        x = x + 1

        ListView1.Items.Add(".25 inch")
        ListView1.Items(x).SubItems.Add("Blitzking")
        ListView1.Items(x).SubItems.Add("70")
        ListView1.Items(x).SubItems.Add("0,246")
        x = x + 1

        ListView1.Items.Add(".25 inch")
        ListView1.Items(x).SubItems.Add("Blitzking")
        ListView1.Items(x).SubItems.Add("90")
        ListView1.Items(x).SubItems.Add("0,360")
        x = x + 1

        ListView1.Items.Add(".22 inch Hornet")
        ListView1.Items(x).SubItems.Add("Varminter")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,125")
        x = x + 1

        ListView1.Items.Add(".22 inch Hornet")
        ListView1.Items(x).SubItems.Add("Varminter")
        ListView1.Items(x).SubItems.Add("45")
        ListView1.Items(x).SubItems.Add("0,141")
        x = x + 1

        ListView1.Items.Add(".22 inch HP")
        ListView1.Items(x).SubItems.Add("Varminter")
        ListView1.Items(x).SubItems.Add("40")
        ListView1.Items(x).SubItems.Add("0,160")
        x = x + 1

        ListView1.Items.Add(".22 inch SPT")
        ListView1.Items(x).SubItems.Add("Varminter")
        ListView1.Items(x).SubItems.Add("45")
        ListView1.Items(x).SubItems.Add("0,196")
        x = x + 1

        ListView1.Items.Add(".22 inch Spitzer Blitz")
        ListView1.Items(x).SubItems.Add("Varminter")
        ListView1.Items(x).SubItems.Add("50")
        ListView1.Items(x).SubItems.Add("0,215")
        x = x + 1

        ListView1.Items.Add(".22 inch SPT")
        ListView1.Items(x).SubItems.Add("Varminter")
        ListView1.Items(x).SubItems.Add("50")
        ListView1.Items(x).SubItems.Add("0,215")
        x = x + 1

        ListView1.Items.Add(".22 inch Spitzer Blitz")
        ListView1.Items(x).SubItems.Add("Varminter")
        ListView1.Items(x).SubItems.Add("55")
        ListView1.Items(x).SubItems.Add("0,235")
        x = x + 1

        ListView1.Items.Add(".22 inch SPT")
        ListView1.Items(x).SubItems.Add("Varminter")
        ListView1.Items(x).SubItems.Add("55")
        ListView1.Items(x).SubItems.Add("0,235")
        x = x + 1

        ListView1.Items.Add(".22 inch HP")
        ListView1.Items(x).SubItems.Add("Varminter")
        ListView1.Items(x).SubItems.Add("60")
        ListView1.Items(x).SubItems.Add("0,244")
        x = x + 1

        ListView1.Items.Add(".22 inch SMP")
        ListView1.Items(x).SubItems.Add("Varminter")
        ListView1.Items(x).SubItems.Add("63")
        ListView1.Items(x).SubItems.Add("0,235")
        x = x + 1

        ListView1.Items.Add(".243 inch HP")
        ListView1.Items(x).SubItems.Add("Varminter")
        ListView1.Items(x).SubItems.Add("60")
        ListView1.Items(x).SubItems.Add("0,193")
        x = x + 1

        ListView1.Items.Add(".243 inch HP")
        ListView1.Items(x).SubItems.Add("Varminter")
        ListView1.Items(x).SubItems.Add("75")
        ListView1.Items(x).SubItems.Add("0,223")
        x = x + 1

        ListView1.Items.Add(".243 inch Blitz SBT")
        ListView1.Items(x).SubItems.Add("Varminter")
        ListView1.Items(x).SubItems.Add("80")
        ListView1.Items(x).SubItems.Add("0,308")
        x = x + 1

        ListView1.Items.Add(".243 inch SPT")
        ListView1.Items(x).SubItems.Add("Varminter")
        ListView1.Items(x).SubItems.Add("85")
        ListView1.Items(x).SubItems.Add("0,309")
        x = x + 1

        ListView1.Items.Add(".25 inch SPT")
        ListView1.Items(x).SubItems.Add("Varminter")
        ListView1.Items(x).SubItems.Add("87")
        ListView1.Items(x).SubItems.Add("0,284")
        x = x + 1

        ListView1.Items.Add("6,5 mm HP")
        ListView1.Items(x).SubItems.Add("Varminter")
        ListView1.Items(x).SubItems.Add("100")
        ListView1.Items(x).SubItems.Add("0,280")
        x = x + 1

        ListView1.Items.Add("7 mm HP")
        ListView1.Items(x).SubItems.Add("Varminter")
        ListView1.Items(x).SubItems.Add("100")
        ListView1.Items(x).SubItems.Add("0,228")
        x = x + 1

        ListView1.Items.Add(".30 inch HP")
        ListView1.Items(x).SubItems.Add("Varminter")
        ListView1.Items(x).SubItems.Add("110")
        ListView1.Items(x).SubItems.Add("0,196")
        x = x + 1

        ListView1.Items.Add(".30 inch HP")
        ListView1.Items(x).SubItems.Add("Varminter")
        ListView1.Items(x).SubItems.Add("135")
        ListView1.Items(x).SubItems.Add("0,291")
        x = x + 1

        ListView1.Items.Add(".22 inch FMJBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("55")
        ListView1.Items(x).SubItems.Add("0,251")
        x = x + 1

        ListView1.Items.Add(".22 inch HPBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("55")
        ListView1.Items(x).SubItems.Add("0,189")
        x = x + 1

        ListView1.Items.Add(".22 inch SBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("55")
        ListView1.Items(x).SubItems.Add("0,243")
        x = x + 1

        ListView1.Items.Add(".22 inch SBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("65")
        ListView1.Items(x).SubItems.Add("0,293")
        x = x + 1

        ListView1.Items.Add("6 mm HPBT ")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("85")
        ListView1.Items(x).SubItems.Add("0,301")
        x = x + 1

        ListView1.Items.Add("6 mm TGK")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("90")
        ListView1.Items(x).SubItems.Add("0,403")
        x = x + 1

        ListView1.Items.Add("6 mm SBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("100")
        ListView1.Items(x).SubItems.Add("0,408")
        x = x + 1

        ListView1.Items.Add(".25 inch HPBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("90")
        ListView1.Items(x).SubItems.Add("0,258")
        x = x + 1

        ListView1.Items.Add(".25 inch SBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("100")
        ListView1.Items(x).SubItems.Add("0,333")
        x = x + 1

        ListView1.Items.Add(".25 inch SBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("117")
        ListView1.Items(x).SubItems.Add("0,395")
        x = x + 1

        ListView1.Items.Add("6,5 mm HPBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,375")
        x = x + 1

        ListView1.Items.Add("6,5 mm SBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,488")
        x = x + 1

        ListView1.Items.Add(".270 inch SBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,411")
        x = x + 1

        ListView1.Items.Add(".270 inch TGK")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,412")
        x = x + 1

        ListView1.Items.Add(".270 inch SBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,439")
        x = x + 1

        ListView1.Items.Add(".270 inch HPBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,360")
        x = x + 1

        ListView1.Items.Add(".270 inch SBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,465")
        x = x + 1

        ListView1.Items.Add("7 mm SBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,419")
        x = x + 1

        ListView1.Items.Add("7 mm HPBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,388")
        x = x + 1

        ListView1.Items.Add("7 mm SBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,426")
        x = x + 1

        ListView1.Items.Add("7 mm HPBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("160")
        ListView1.Items(x).SubItems.Add("0,394")
        x = x + 1

        ListView1.Items.Add("7 mm SBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("160")
        ListView1.Items(x).SubItems.Add("0,464")
        x = x + 1

        ListView1.Items.Add("7 mm TGK")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("165")
        ListView1.Items(x).SubItems.Add("0,523")
        x = x + 1

        ListView1.Items.Add("7 mm SBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("175")
        ListView1.Items(x).SubItems.Add("0,544")
        x = x + 1

        ListView1.Items.Add(".30 inch FMJBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,397")
        x = x + 1

        ListView1.Items.Add(".30 inch SBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,369")
        x = x + 1

        ListView1.Items.Add(".30 inch HPBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("165")
        ListView1.Items(x).SubItems.Add("0,360")
        x = x + 1

        ListView1.Items.Add(".30 inch SBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("165")
        ListView1.Items(x).SubItems.Add("0,411")
        x = x + 1

        ListView1.Items.Add(".30 inch TGK")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("165")
        ListView1.Items(x).SubItems.Add("0,435")
        x = x + 1

        ListView1.Items.Add(".30 inch SBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,504")
        x = x + 1

        ListView1.Items.Add(".30 inch SBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,557")
        x = x + 1

        ListView1.Items.Add("8 mm SBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("220")
        ListView1.Items(x).SubItems.Add("0,513")
        x = x + 1

        ListView1.Items.Add(".338 inch SBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("215")
        ListView1.Items(x).SubItems.Add("0,473")
        x = x + 1

        ListView1.Items.Add(".338 inch SBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("250")
        ListView1.Items(x).SubItems.Add("0,554")
        x = x + 1

        ListView1.Items.Add(".35 inch SBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("225")
        ListView1.Items(x).SubItems.Add("0,378")
        x = x + 1

        ListView1.Items.Add(".375 inch SBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("250")
        ListView1.Items(x).SubItems.Add("0,366")
        x = x + 1

        ListView1.Items.Add(".375 inch SBT")
        ListView1.Items(x).SubItems.Add("Gameking")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,471")
        x = x + 1

        ListView1.Items.Add("6 mm SPT")
        ListView1.Items(x).SubItems.Add("Pro-Hunter")
        ListView1.Items(x).SubItems.Add("100")
        ListView1.Items(x).SubItems.Add("0,358")
        x = x + 1

        ListView1.Items.Add("6,5 mm SPT")
        ListView1.Items(x).SubItems.Add("Pro-Hunter")
        ListView1.Items(x).SubItems.Add("120")
        ListView1.Items(x).SubItems.Add("0,377")
        x = x + 1

        ListView1.Items.Add(".270 inch SPT")
        ListView1.Items(x).SubItems.Add("Pro-Hunter")
        ListView1.Items(x).SubItems.Add("130")
        ListView1.Items(x).SubItems.Add("0,377")
        x = x + 1

        ListView1.Items.Add("7 mm SPT")
        ListView1.Items(x).SubItems.Add("Pro-Hunter")
        ListView1.Items(x).SubItems.Add("120")
        ListView1.Items(x).SubItems.Add("0,329")
        x = x + 1

        ListView1.Items.Add("7 mm SPT")
        ListView1.Items(x).SubItems.Add("Pro-Hunter")
        ListView1.Items(x).SubItems.Add("140")
        ListView1.Items(x).SubItems.Add("0,388")
        x = x + 1

        ListView1.Items.Add(".30 inch RN")
        ListView1.Items(x).SubItems.Add("Pro-Hunter")
        ListView1.Items(x).SubItems.Add("110")
        ListView1.Items(x).SubItems.Add("0,162")
        x = x + 1

        ListView1.Items.Add(".30 inch HP/FN")
        ListView1.Items(x).SubItems.Add("Pro-Hunter")
        ListView1.Items(x).SubItems.Add("125")
        ListView1.Items(x).SubItems.Add("0,153")
        x = x + 1

        ListView1.Items.Add(".30 inch SPT")
        ListView1.Items(x).SubItems.Add("Pro-Hunter")
        ListView1.Items(x).SubItems.Add("125")
        ListView1.Items(x).SubItems.Add("0,274")
        x = x + 1

        ListView1.Items.Add(".30 inch RN")
        ListView1.Items(x).SubItems.Add("Pro-Hunter")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,232")
        x = x + 1

        ListView1.Items.Add(".30 inch FN")
        ListView1.Items(x).SubItems.Add("Pro-Hunter")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,224")
        x = x + 1

        ListView1.Items.Add(".30 inch FN")
        ListView1.Items(x).SubItems.Add("Pro-Hunter")
        ListView1.Items(x).SubItems.Add("170")
        ListView1.Items(x).SubItems.Add("0,249")
        x = x + 1

        ListView1.Items.Add(".30 inch FN")
        ListView1.Items(x).SubItems.Add("Pro-Hunter")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,301")
        x = x + 1

        ListView1.Items.Add(".30 inch RN")
        ListView1.Items(x).SubItems.Add("Pro-Hunter")
        ListView1.Items(x).SubItems.Add("220")
        ListView1.Items(x).SubItems.Add("0,358")
        x = x + 1

        ListView1.Items.Add(".303 inch SPT")
        ListView1.Items(x).SubItems.Add("Pro-Hunter")
        ListView1.Items(x).SubItems.Add("125")
        ListView1.Items(x).SubItems.Add("0,282")
        x = x + 1

        ListView1.Items.Add(".303 inch SPT")
        ListView1.Items(x).SubItems.Add("Pro-Hunter")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,340")
        x = x + 1

        ListView1.Items.Add(".303 inch SPT")
        ListView1.Items(x).SubItems.Add("Pro-Hunter")
        ListView1.Items(x).SubItems.Add("180")
        ListView1.Items(x).SubItems.Add("0,408")
        x = x + 1

        ListView1.Items.Add("8 mm SPT")
        ListView1.Items(x).SubItems.Add("Pro-Hunter")
        ListView1.Items(x).SubItems.Add("150")
        ListView1.Items(x).SubItems.Add("0,326")
        x = x + 1

        ListView1.Items.Add("8 mm SPT")
        ListView1.Items(x).SubItems.Add("Pro-Hunter")
        ListView1.Items(x).SubItems.Add("175")
        ListView1.Items(x).SubItems.Add("0,376")
        x = x + 1

        ListView1.Items.Add(".338 inch SPT")
        ListView1.Items(x).SubItems.Add("Pro-Hunter")
        ListView1.Items(x).SubItems.Add("225")
        ListView1.Items(x).SubItems.Add("0,450")
        x = x + 1

        ListView1.Items.Add(".35 inch RN")
        ListView1.Items(x).SubItems.Add("Pro-Hunter")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,219")
        x = x + 1

        ListView1.Items.Add(".375 inch FN")
        ListView1.Items(x).SubItems.Add("Pro-Hunter")
        ListView1.Items(x).SubItems.Add("200")
        ListView1.Items(x).SubItems.Add("0,222")
        x = x + 1

        ListView1.Items.Add(".45 inch HP/FN")
        ListView1.Items(x).SubItems.Add("Pro-Hunter")
        ListView1.Items(x).SubItems.Add("300")
        ListView1.Items(x).SubItems.Add("0,178")
        x = x + 1
    End Sub

    Private Sub Seznam_střel_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Hlavní_okno.Enabled = True
    End Sub

    Private Sub operace_checkbox()
        If i = 1 Then

            checkbox_Hornady.Checked = False
            checkbox_L.Checked = False
            checkbox_Sierra.Checked = False
            checkbox_Berger.Checked = False
            checkbox_N.Checked = False
            checkbox_federal_puška.Checked = False
            checkbox_FOX.Checked = False
            checkbox_RWS_puškové.Checked = False
            checkbox_TNX_Puška.Checked = False
            checkbox_diabolky.Checked = False
            checkbox_SB_malorážka.Checked = False
            checkbox_federal_malorážka.Checked = False
            checkbox_CCI.Checked = False
            checkbox_RWS_malorazka.Checked = False
            checkbox_SB_Pistole.Checked = False
            checkbox_federal_pistole.Checked = False
            checkbox_LEE.Checked = False
            checkbox_LOS.Checked = False
            checkbox_TNX_Pistole.Checked = False
            checkbox_SK_malorážka.Checked = False
            checkbox_H_pistole.Checked = False

        ElseIf i = 2 Then

            checkbox_SB_Puška.Checked = False
            checkbox_L.Checked = False
            checkbox_Sierra.Checked = False
            checkbox_Berger.Checked = False
            checkbox_N.Checked = False
            checkbox_federal_puška.Checked = False
            checkbox_FOX.Checked = False
            checkbox_RWS_puškové.Checked = False
            checkbox_TNX_Puška.Checked = False
            checkbox_diabolky.Checked = False
            checkbox_SB_malorážka.Checked = False
            checkbox_federal_malorážka.Checked = False
            checkbox_CCI.Checked = False
            checkbox_RWS_malorazka.Checked = False
            checkbox_SB_Pistole.Checked = False
            checkbox_federal_pistole.Checked = False
            checkbox_LEE.Checked = False
            checkbox_LOS.Checked = False
            checkbox_TNX_Pistole.Checked = False
            checkbox_SK_malorážka.Checked = False
            checkbox_H_pistole.Checked = False

        ElseIf i = 3 Then

            checkbox_SB_Puška.Checked = False
            checkbox_Hornady.Checked = False
            checkbox_Sierra.Checked = False
            checkbox_Berger.Checked = False
            checkbox_N.Checked = False
            checkbox_federal_puška.Checked = False
            checkbox_FOX.Checked = False
            checkbox_RWS_puškové.Checked = False
            checkbox_TNX_Puška.Checked = False
            checkbox_diabolky.Checked = False
            checkbox_SB_malorážka.Checked = False
            checkbox_federal_malorážka.Checked = False
            checkbox_CCI.Checked = False
            checkbox_RWS_malorazka.Checked = False
            checkbox_SB_Pistole.Checked = False
            checkbox_federal_pistole.Checked = False
            checkbox_LEE.Checked = False
            checkbox_LOS.Checked = False
            checkbox_TNX_Pistole.Checked = False
            checkbox_SK_malorážka.Checked = False
            checkbox_H_pistole.Checked = False

        ElseIf i = 4 Then

            checkbox_SB_Puška.Checked = False
            checkbox_Hornady.Checked = False
            checkbox_L.Checked = False
            checkbox_Berger.Checked = False
            checkbox_N.Checked = False
            checkbox_federal_puška.Checked = False
            checkbox_FOX.Checked = False
            checkbox_RWS_puškové.Checked = False
            checkbox_TNX_Puška.Checked = False
            checkbox_diabolky.Checked = False
            checkbox_SB_malorážka.Checked = False
            checkbox_federal_malorážka.Checked = False
            checkbox_CCI.Checked = False
            checkbox_RWS_malorazka.Checked = False
            checkbox_SB_Pistole.Checked = False
            checkbox_federal_pistole.Checked = False
            checkbox_LEE.Checked = False
            checkbox_LOS.Checked = False
            checkbox_TNX_Pistole.Checked = False
            checkbox_SK_malorážka.Checked = False
            checkbox_H_pistole.Checked = False

        ElseIf i = 5 Then

            checkbox_SB_Puška.Checked = False
            checkbox_Hornady.Checked = False
            checkbox_L.Checked = False
            checkbox_Sierra.Checked = False
            checkbox_N.Checked = False
            checkbox_federal_puška.Checked = False
            checkbox_FOX.Checked = False
            checkbox_RWS_puškové.Checked = False
            checkbox_TNX_Puška.Checked = False
            checkbox_diabolky.Checked = False
            checkbox_SB_malorážka.Checked = False
            checkbox_federal_malorážka.Checked = False
            checkbox_CCI.Checked = False
            checkbox_RWS_malorazka.Checked = False
            checkbox_SB_Pistole.Checked = False
            checkbox_federal_pistole.Checked = False
            checkbox_LEE.Checked = False
            checkbox_LOS.Checked = False
            checkbox_TNX_Pistole.Checked = False
            checkbox_SK_malorážka.Checked = False
            checkbox_H_pistole.Checked = False

        ElseIf i = 6 Then

            checkbox_SB_Puška.Checked = False
            checkbox_Hornady.Checked = False
            checkbox_L.Checked = False
            checkbox_Sierra.Checked = False
            checkbox_Berger.Checked = False
            checkbox_federal_puška.Checked = False
            checkbox_FOX.Checked = False
            checkbox_RWS_puškové.Checked = False
            checkbox_TNX_Puška.Checked = False
            checkbox_diabolky.Checked = False
            checkbox_SB_malorážka.Checked = False
            checkbox_federal_malorážka.Checked = False
            checkbox_CCI.Checked = False
            checkbox_RWS_malorazka.Checked = False
            checkbox_SB_Pistole.Checked = False
            checkbox_federal_pistole.Checked = False
            checkbox_LEE.Checked = False
            checkbox_LOS.Checked = False
            checkbox_TNX_Pistole.Checked = False
            checkbox_SK_malorážka.Checked = False
            checkbox_H_pistole.Checked = False

        ElseIf i = 7 Then

            checkbox_SB_Puška.Checked = False
            checkbox_Hornady.Checked = False
            checkbox_L.Checked = False
            checkbox_Sierra.Checked = False
            checkbox_Berger.Checked = False
            checkbox_N.Checked = False
            checkbox_FOX.Checked = False
            checkbox_RWS_puškové.Checked = False
            checkbox_TNX_Puška.Checked = False
            checkbox_diabolky.Checked = False
            checkbox_SB_malorážka.Checked = False
            checkbox_federal_malorážka.Checked = False
            checkbox_CCI.Checked = False
            checkbox_RWS_malorazka.Checked = False
            checkbox_SB_Pistole.Checked = False
            checkbox_federal_pistole.Checked = False
            checkbox_LEE.Checked = False
            checkbox_LOS.Checked = False
            checkbox_TNX_Pistole.Checked = False
            checkbox_SK_malorážka.Checked = False
            checkbox_H_pistole.Checked = False

        ElseIf i = 8 Then

            checkbox_SB_Puška.Checked = False
            checkbox_Hornady.Checked = False
            checkbox_L.Checked = False
            checkbox_Sierra.Checked = False
            checkbox_Berger.Checked = False
            checkbox_N.Checked = False
            checkbox_federal_puška.Checked = False
            checkbox_RWS_puškové.Checked = False
            checkbox_TNX_Puška.Checked = False
            checkbox_diabolky.Checked = False
            checkbox_SB_malorážka.Checked = False
            checkbox_federal_malorážka.Checked = False
            checkbox_CCI.Checked = False
            checkbox_RWS_malorazka.Checked = False
            checkbox_SB_Pistole.Checked = False
            checkbox_federal_pistole.Checked = False
            checkbox_LEE.Checked = False
            checkbox_LOS.Checked = False
            checkbox_TNX_Pistole.Checked = False
            checkbox_SK_malorážka.Checked = False
            checkbox_H_pistole.Checked = False

        ElseIf i = 9 Then

            checkbox_SB_Puška.Checked = False
            checkbox_Hornady.Checked = False
            checkbox_L.Checked = False
            checkbox_Sierra.Checked = False
            checkbox_Berger.Checked = False
            checkbox_N.Checked = False
            checkbox_federal_puška.Checked = False
            checkbox_FOX.Checked = False
            checkbox_TNX_Puška.Checked = False
            checkbox_diabolky.Checked = False
            checkbox_SB_malorážka.Checked = False
            checkbox_federal_malorážka.Checked = False
            checkbox_CCI.Checked = False
            checkbox_RWS_malorazka.Checked = False
            checkbox_SB_Pistole.Checked = False
            checkbox_federal_pistole.Checked = False
            checkbox_LEE.Checked = False
            checkbox_LOS.Checked = False
            checkbox_TNX_Pistole.Checked = False
            checkbox_SK_malorážka.Checked = False
            checkbox_H_pistole.Checked = False

        ElseIf i = 10 Then

            checkbox_SB_Puška.Checked = False
            checkbox_Hornady.Checked = False
            checkbox_L.Checked = False
            checkbox_Sierra.Checked = False
            checkbox_Berger.Checked = False
            checkbox_N.Checked = False
            checkbox_federal_puška.Checked = False
            checkbox_FOX.Checked = False
            checkbox_RWS_puškové.Checked = False
            checkbox_diabolky.Checked = False
            checkbox_SB_malorážka.Checked = False
            checkbox_federal_malorážka.Checked = False
            checkbox_CCI.Checked = False
            checkbox_RWS_malorazka.Checked = False
            checkbox_SB_Pistole.Checked = False
            checkbox_federal_pistole.Checked = False
            checkbox_LEE.Checked = False
            checkbox_LOS.Checked = False
            checkbox_TNX_Pistole.Checked = False
            checkbox_SK_malorážka.Checked = False
            checkbox_H_pistole.Checked = False

        ElseIf i = 11 Then

            checkbox_SB_Puška.Checked = False
            checkbox_Hornady.Checked = False
            checkbox_L.Checked = False
            checkbox_Sierra.Checked = False
            checkbox_Berger.Checked = False
            checkbox_N.Checked = False
            checkbox_federal_puška.Checked = False
            checkbox_FOX.Checked = False
            checkbox_RWS_puškové.Checked = False
            checkbox_TNX_Puška.Checked = False
            checkbox_SB_malorážka.Checked = False
            checkbox_federal_malorážka.Checked = False
            checkbox_CCI.Checked = False
            checkbox_RWS_malorazka.Checked = False
            checkbox_SB_Pistole.Checked = False
            checkbox_federal_pistole.Checked = False
            checkbox_LEE.Checked = False
            checkbox_LOS.Checked = False
            checkbox_TNX_Pistole.Checked = False
            checkbox_SK_malorážka.Checked = False
            checkbox_H_pistole.Checked = False

        ElseIf i = 12 Then

            checkbox_SB_Puška.Checked = False
            checkbox_Hornady.Checked = False
            checkbox_L.Checked = False
            checkbox_Sierra.Checked = False
            checkbox_Berger.Checked = False
            checkbox_N.Checked = False
            checkbox_federal_puška.Checked = False
            checkbox_FOX.Checked = False
            checkbox_RWS_puškové.Checked = False
            checkbox_TNX_Puška.Checked = False
            checkbox_diabolky.Checked = False
            checkbox_federal_malorážka.Checked = False
            checkbox_CCI.Checked = False
            checkbox_RWS_malorazka.Checked = False
            checkbox_SB_Pistole.Checked = False
            checkbox_federal_pistole.Checked = False
            checkbox_LEE.Checked = False
            checkbox_LOS.Checked = False
            checkbox_TNX_Pistole.Checked = False
            checkbox_SK_malorážka.Checked = False
            checkbox_H_pistole.Checked = False

        ElseIf i = 13 Then

            checkbox_SB_Puška.Checked = False
            checkbox_Hornady.Checked = False
            checkbox_L.Checked = False
            checkbox_Sierra.Checked = False
            checkbox_Berger.Checked = False
            checkbox_N.Checked = False
            checkbox_federal_puška.Checked = False
            checkbox_FOX.Checked = False
            checkbox_RWS_puškové.Checked = False
            checkbox_TNX_Puška.Checked = False
            checkbox_diabolky.Checked = False
            checkbox_SB_malorážka.Checked = False
            checkbox_CCI.Checked = False
            checkbox_RWS_malorazka.Checked = False
            checkbox_SB_Pistole.Checked = False
            checkbox_federal_pistole.Checked = False
            checkbox_LEE.Checked = False
            checkbox_LOS.Checked = False
            checkbox_TNX_Pistole.Checked = False
            checkbox_SK_malorážka.Checked = False
            checkbox_H_pistole.Checked = False

        ElseIf i = 14 Then

            checkbox_SB_Puška.Checked = False
            checkbox_Hornady.Checked = False
            checkbox_L.Checked = False
            checkbox_Sierra.Checked = False
            checkbox_Berger.Checked = False
            checkbox_N.Checked = False
            checkbox_federal_puška.Checked = False
            checkbox_FOX.Checked = False
            checkbox_RWS_puškové.Checked = False
            checkbox_TNX_Puška.Checked = False
            checkbox_diabolky.Checked = False
            checkbox_SB_malorážka.Checked = False
            checkbox_federal_malorážka.Checked = False
            checkbox_RWS_malorazka.Checked = False
            checkbox_SB_Pistole.Checked = False
            checkbox_federal_pistole.Checked = False
            checkbox_LEE.Checked = False
            checkbox_LOS.Checked = False
            checkbox_TNX_Pistole.Checked = False
            checkbox_SK_malorážka.Checked = False
            checkbox_H_pistole.Checked = False

        ElseIf i = 15 Then

            checkbox_SB_Puška.Checked = False
            checkbox_Hornady.Checked = False
            checkbox_L.Checked = False
            checkbox_Sierra.Checked = False
            checkbox_Berger.Checked = False
            checkbox_N.Checked = False
            checkbox_federal_puška.Checked = False
            checkbox_FOX.Checked = False
            checkbox_RWS_puškové.Checked = False
            checkbox_TNX_Puška.Checked = False
            checkbox_diabolky.Checked = False
            checkbox_SB_malorážka.Checked = False
            checkbox_federal_malorážka.Checked = False
            checkbox_CCI.Checked = False
            checkbox_SB_Pistole.Checked = False
            checkbox_federal_pistole.Checked = False
            checkbox_LEE.Checked = False
            checkbox_LOS.Checked = False
            checkbox_TNX_Pistole.Checked = False
            checkbox_SK_malorážka.Checked = False
            checkbox_H_pistole.Checked = False

        ElseIf i = 16 Then

            checkbox_SB_Puška.Checked = False
            checkbox_Hornady.Checked = False
            checkbox_L.Checked = False
            checkbox_Sierra.Checked = False
            checkbox_Berger.Checked = False
            checkbox_N.Checked = False
            checkbox_federal_puška.Checked = False
            checkbox_FOX.Checked = False
            checkbox_RWS_puškové.Checked = False
            checkbox_TNX_Puška.Checked = False
            checkbox_diabolky.Checked = False
            checkbox_SB_malorážka.Checked = False
            checkbox_federal_malorážka.Checked = False
            checkbox_CCI.Checked = False
            checkbox_RWS_malorazka.Checked = False
            checkbox_federal_pistole.Checked = False
            checkbox_LEE.Checked = False
            checkbox_LOS.Checked = False
            checkbox_TNX_Pistole.Checked = False
            checkbox_SK_malorážka.Checked = False
            checkbox_H_pistole.Checked = False

        ElseIf i = 17 Then

            checkbox_SB_Puška.Checked = False
            checkbox_Hornady.Checked = False
            checkbox_L.Checked = False
            checkbox_Sierra.Checked = False
            checkbox_Berger.Checked = False
            checkbox_N.Checked = False
            checkbox_federal_puška.Checked = False
            checkbox_FOX.Checked = False
            checkbox_RWS_puškové.Checked = False
            checkbox_TNX_Puška.Checked = False
            checkbox_diabolky.Checked = False
            checkbox_SB_malorážka.Checked = False
            checkbox_federal_malorážka.Checked = False
            checkbox_CCI.Checked = False
            checkbox_RWS_malorazka.Checked = False
            checkbox_SB_Pistole.Checked = False
            checkbox_LEE.Checked = False
            checkbox_LOS.Checked = False
            checkbox_TNX_Pistole.Checked = False
            checkbox_SK_malorážka.Checked = False
            checkbox_H_pistole.Checked = False

        ElseIf i = 18 Then

            checkbox_SB_Puška.Checked = False
            checkbox_Hornady.Checked = False
            checkbox_L.Checked = False
            checkbox_Sierra.Checked = False
            checkbox_Berger.Checked = False
            checkbox_N.Checked = False
            checkbox_federal_puška.Checked = False
            checkbox_FOX.Checked = False
            checkbox_RWS_puškové.Checked = False
            checkbox_TNX_Puška.Checked = False
            checkbox_diabolky.Checked = False
            checkbox_SB_malorážka.Checked = False
            checkbox_federal_malorážka.Checked = False
            checkbox_CCI.Checked = False
            checkbox_RWS_malorazka.Checked = False
            checkbox_SB_Pistole.Checked = False
            checkbox_federal_pistole.Checked = False
            checkbox_LOS.Checked = False
            checkbox_TNX_Pistole.Checked = False
            checkbox_SK_malorážka.Checked = False
            checkbox_H_pistole.Checked = False

        ElseIf i = 19 Then

            checkbox_SB_Puška.Checked = False
            checkbox_Hornady.Checked = False
            checkbox_L.Checked = False
            checkbox_Sierra.Checked = False
            checkbox_Berger.Checked = False
            checkbox_N.Checked = False
            checkbox_federal_puška.Checked = False
            checkbox_FOX.Checked = False
            checkbox_RWS_puškové.Checked = False
            checkbox_TNX_Puška.Checked = False
            checkbox_diabolky.Checked = False
            checkbox_SB_malorážka.Checked = False
            checkbox_federal_malorážka.Checked = False
            checkbox_CCI.Checked = False
            checkbox_RWS_malorazka.Checked = False
            checkbox_SB_Pistole.Checked = False
            checkbox_federal_pistole.Checked = False
            checkbox_LEE.Checked = False
            checkbox_TNX_Pistole.Checked = False
            checkbox_SK_malorážka.Checked = False
            checkbox_H_pistole.Checked = False

        ElseIf i = 20 Then

            checkbox_SB_Puška.Checked = False
            checkbox_Hornady.Checked = False
            checkbox_L.Checked = False
            checkbox_Sierra.Checked = False
            checkbox_Berger.Checked = False
            checkbox_N.Checked = False
            checkbox_federal_puška.Checked = False
            checkbox_FOX.Checked = False
            checkbox_RWS_puškové.Checked = False
            checkbox_TNX_Puška.Checked = False
            checkbox_diabolky.Checked = False
            checkbox_SB_malorážka.Checked = False
            checkbox_federal_malorážka.Checked = False
            checkbox_CCI.Checked = False
            checkbox_RWS_malorazka.Checked = False
            checkbox_SB_Pistole.Checked = False
            checkbox_federal_pistole.Checked = False
            checkbox_LEE.Checked = False
            checkbox_LOS.Checked = False
            checkbox_SK_malorážka.Checked = False
            checkbox_H_pistole.Checked = False

        ElseIf i = 21 Then

            checkbox_SB_Puška.Checked = False
            checkbox_Hornady.Checked = False
            checkbox_L.Checked = False
            checkbox_Sierra.Checked = False
            checkbox_Berger.Checked = False
            checkbox_N.Checked = False
            checkbox_federal_puška.Checked = False
            checkbox_FOX.Checked = False
            checkbox_RWS_puškové.Checked = False
            checkbox_TNX_Puška.Checked = False
            checkbox_diabolky.Checked = False
            checkbox_SB_malorážka.Checked = False
            checkbox_federal_malorážka.Checked = False
            checkbox_CCI.Checked = False
            checkbox_RWS_malorazka.Checked = False
            checkbox_SB_Pistole.Checked = False
            checkbox_federal_pistole.Checked = False
            checkbox_LEE.Checked = False
            checkbox_LOS.Checked = False
            checkbox_TNX_Pistole.Checked = False
            checkbox_H_pistole.Checked = False

        ElseIf i = 22 Then

            checkbox_SB_Puška.Checked = False
            checkbox_Hornady.Checked = False
            checkbox_L.Checked = False
            checkbox_Sierra.Checked = False
            checkbox_Berger.Checked = False
            checkbox_N.Checked = False
            checkbox_federal_puška.Checked = False
            checkbox_FOX.Checked = False
            checkbox_RWS_puškové.Checked = False
            checkbox_TNX_Puška.Checked = False
            checkbox_diabolky.Checked = False
            checkbox_SB_malorážka.Checked = False
            checkbox_federal_malorážka.Checked = False
            checkbox_CCI.Checked = False
            checkbox_RWS_malorazka.Checked = False
            checkbox_SB_Pistole.Checked = False
            checkbox_federal_pistole.Checked = False
            checkbox_LEE.Checked = False
            checkbox_LOS.Checked = False
            checkbox_TNX_Pistole.Checked = False
            checkbox_SK_malorážka.Checked = False

        End If
    End Sub

End Class