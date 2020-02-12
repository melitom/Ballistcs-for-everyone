<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Export_tabulky
    Inherits System.Windows.Forms.Form

    'Formulář přepisuje metodu Dispose, aby vyčistil seznam součástí.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Vyžadováno Návrhářem Windows Form
    Private components As System.ComponentModel.IContainer

    'POZNÁMKA: Následující procedura je vyžadována Návrhářem Windows Form
    'Může být upraveno pomocí Návrháře Windows Form.  
    'Neupravovat pomocí editoru kódu
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Export_tabulky))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button_Zavřít = New System.Windows.Forms.Button()
        Me.label_pocatecni_rychlost = New System.Windows.Forms.Label()
        Me.label_hmotnost_strely = New System.Windows.Forms.Label()
        Me.label_balisticky_koeficient = New System.Windows.Forms.Label()
        Me.label_nastrelna_vzdalenost = New System.Windows.Forms.Label()
        Me.label_poloha_zasahu_v_nastrelne_vzdalenosti = New System.Windows.Forms.Label()
        Me.label_vzdalenost_osy_miridel_od_hlavne = New System.Windows.Forms.Label()
        Me.label_teplota_vzduchu = New System.Windows.Forms.Label()
        Me.label_nadmorska_vyska = New System.Windows.Forms.Label()
        Me.label_rychlost_vetru = New System.Windows.Forms.Label()
        Me.label_uhlove_jednotky = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.combobox_interval_vzdalenosti = New System.Windows.Forms.ComboBox()
        Me.combobox_prvni_vzdalenost = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DomainUpDown1 = New System.Windows.Forms.DomainUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.textbox_prvni_vzdalenost = New System.Windows.Forms.TextBox()
        Me.label_nactena_strela = New System.Windows.Forms.Label()
        Me.button_vytvořit_tabulku = New System.Windows.Forms.Button()
        Me.button_exportivat_do_pdf = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.label_smer_vetru_od_osy_pohybu = New System.Windows.Forms.Label()
        Me.label_uhel_sklonu = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.Location = New System.Drawing.Point(18, 194)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(710, 255)
        Me.DataGridView1.TabIndex = 0
        '
        'Button_Zavřít
        '
        Me.Button_Zavřít.BackColor = System.Drawing.SystemColors.Window
        Me.Button_Zavřít.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Zavřít.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button_Zavřít.Location = New System.Drawing.Point(18, 590)
        Me.Button_Zavřít.Name = "Button_Zavřít"
        Me.Button_Zavřít.Size = New System.Drawing.Size(710, 58)
        Me.Button_Zavřít.TabIndex = 2
        Me.Button_Zavřít.Text = "Close"
        Me.Button_Zavřít.UseVisualStyleBackColor = False
        '
        'label_pocatecni_rychlost
        '
        Me.label_pocatecni_rychlost.AutoSize = True
        Me.label_pocatecni_rychlost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_pocatecni_rychlost.Location = New System.Drawing.Point(15, 9)
        Me.label_pocatecni_rychlost.Name = "label_pocatecni_rychlost"
        Me.label_pocatecni_rychlost.Size = New System.Drawing.Size(128, 17)
        Me.label_pocatecni_rychlost.TabIndex = 3
        Me.label_pocatecni_rychlost.Text = "Muzzle velocity: "
        '
        'label_hmotnost_strely
        '
        Me.label_hmotnost_strely.AutoSize = True
        Me.label_hmotnost_strely.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_hmotnost_strely.Location = New System.Drawing.Point(15, 36)
        Me.label_hmotnost_strely.Name = "label_hmotnost_strely"
        Me.label_hmotnost_strely.Size = New System.Drawing.Size(110, 17)
        Me.label_hmotnost_strely.TabIndex = 4
        Me.label_hmotnost_strely.Text = "Bullet weight: "
        '
        'label_balisticky_koeficient
        '
        Me.label_balisticky_koeficient.AutoSize = True
        Me.label_balisticky_koeficient.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_balisticky_koeficient.Location = New System.Drawing.Point(15, 63)
        Me.label_balisticky_koeficient.Name = "label_balisticky_koeficient"
        Me.label_balisticky_koeficient.Size = New System.Drawing.Size(154, 17)
        Me.label_balisticky_koeficient.TabIndex = 5
        Me.label_balisticky_koeficient.Text = "Ballistic coefficient: "
        '
        'label_nastrelna_vzdalenost
        '
        Me.label_nastrelna_vzdalenost.AutoSize = True
        Me.label_nastrelna_vzdalenost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_nastrelna_vzdalenost.Location = New System.Drawing.Point(15, 116)
        Me.label_nastrelna_vzdalenost.Name = "label_nastrelna_vzdalenost"
        Me.label_nastrelna_vzdalenost.Size = New System.Drawing.Size(138, 17)
        Me.label_nastrelna_vzdalenost.TabIndex = 6
        Me.label_nastrelna_vzdalenost.Text = "Sighting distance:"
        '
        'label_poloha_zasahu_v_nastrelne_vzdalenosti
        '
        Me.label_poloha_zasahu_v_nastrelne_vzdalenosti.AutoSize = True
        Me.label_poloha_zasahu_v_nastrelne_vzdalenosti.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_poloha_zasahu_v_nastrelne_vzdalenosti.Location = New System.Drawing.Point(15, 142)
        Me.label_poloha_zasahu_v_nastrelne_vzdalenosti.Name = "label_poloha_zasahu_v_nastrelne_vzdalenosti"
        Me.label_poloha_zasahu_v_nastrelne_vzdalenosti.Size = New System.Drawing.Size(273, 17)
        Me.label_poloha_zasahu_v_nastrelne_vzdalenosti.TabIndex = 7
        Me.label_poloha_zasahu_v_nastrelne_vzdalenosti.Text = "Point of impact at sighting distance: "
        '
        'label_vzdalenost_osy_miridel_od_hlavne
        '
        Me.label_vzdalenost_osy_miridel_od_hlavne.AutoSize = True
        Me.label_vzdalenost_osy_miridel_od_hlavne.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_vzdalenost_osy_miridel_od_hlavne.Location = New System.Drawing.Point(15, 90)
        Me.label_vzdalenost_osy_miridel_od_hlavne.Name = "label_vzdalenost_osy_miridel_od_hlavne"
        Me.label_vzdalenost_osy_miridel_od_hlavne.Size = New System.Drawing.Size(113, 17)
        Me.label_vzdalenost_osy_miridel_od_hlavne.TabIndex = 8
        Me.label_vzdalenost_osy_miridel_od_hlavne.Text = "Sights height: "
        '
        'label_teplota_vzduchu
        '
        Me.label_teplota_vzduchu.AutoSize = True
        Me.label_teplota_vzduchu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_teplota_vzduchu.Location = New System.Drawing.Point(418, 9)
        Me.label_teplota_vzduchu.Name = "label_teplota_vzduchu"
        Me.label_teplota_vzduchu.Size = New System.Drawing.Size(131, 17)
        Me.label_teplota_vzduchu.TabIndex = 9
        Me.label_teplota_vzduchu.Text = "Air temperature: "
        '
        'label_nadmorska_vyska
        '
        Me.label_nadmorska_vyska.AutoSize = True
        Me.label_nadmorska_vyska.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_nadmorska_vyska.Location = New System.Drawing.Point(418, 36)
        Me.label_nadmorska_vyska.Name = "label_nadmorska_vyska"
        Me.label_nadmorska_vyska.Size = New System.Drawing.Size(145, 17)
        Me.label_nadmorska_vyska.TabIndex = 10
        Me.label_nadmorska_vyska.Text = "Height above sea: "
        '
        'label_rychlost_vetru
        '
        Me.label_rychlost_vetru.AutoSize = True
        Me.label_rychlost_vetru.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_rychlost_vetru.Location = New System.Drawing.Point(418, 63)
        Me.label_rychlost_vetru.Name = "label_rychlost_vetru"
        Me.label_rychlost_vetru.Size = New System.Drawing.Size(98, 17)
        Me.label_rychlost_vetru.TabIndex = 11
        Me.label_rychlost_vetru.Text = "Wind speed:"
        '
        'label_uhlove_jednotky
        '
        Me.label_uhlove_jednotky.AutoSize = True
        Me.label_uhlove_jednotky.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_uhlove_jednotky.Location = New System.Drawing.Point(418, 116)
        Me.label_uhlove_jednotky.Name = "label_uhlove_jednotky"
        Me.label_uhlove_jednotky.Size = New System.Drawing.Size(94, 17)
        Me.label_uhlove_jednotky.TabIndex = 12
        Me.label_uhlove_jednotky.Text = "Angle units:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.combobox_interval_vzdalenosti)
        Me.GroupBox6.Controls.Add(Me.combobox_prvni_vzdalenost)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.DomainUpDown1)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.textbox_prvni_vzdalenost)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(18, 455)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(216, 129)
        Me.GroupBox6.TabIndex = 14
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Table settings"
        '
        'combobox_interval_vzdalenosti
        '
        Me.combobox_interval_vzdalenosti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_interval_vzdalenosti.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_interval_vzdalenosti.FormattingEnabled = True
        Me.combobox_interval_vzdalenosti.Items.AddRange(New Object() {"m", "yd", "ft"})
        Me.combobox_interval_vzdalenosti.Location = New System.Drawing.Point(123, 95)
        Me.combobox_interval_vzdalenosti.Name = "combobox_interval_vzdalenosti"
        Me.combobox_interval_vzdalenosti.Size = New System.Drawing.Size(65, 24)
        Me.combobox_interval_vzdalenosti.TabIndex = 18
        '
        'combobox_prvni_vzdalenost
        '
        Me.combobox_prvni_vzdalenost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_prvni_vzdalenost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_prvni_vzdalenost.FormattingEnabled = True
        Me.combobox_prvni_vzdalenost.Items.AddRange(New Object() {"m", "yd", "ft"})
        Me.combobox_prvni_vzdalenost.Location = New System.Drawing.Point(123, 41)
        Me.combobox_prvni_vzdalenost.Name = "combobox_prvni_vzdalenost"
        Me.combobox_prvni_vzdalenost.Size = New System.Drawing.Size(65, 24)
        Me.combobox_prvni_vzdalenost.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label13.Location = New System.Drawing.Point(7, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 17)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Distance interval"
        '
        'DomainUpDown1
        '
        Me.DomainUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.DomainUpDown1.Items.Add("1000")
        Me.DomainUpDown1.Items.Add("500")
        Me.DomainUpDown1.Items.Add("200")
        Me.DomainUpDown1.Items.Add("100")
        Me.DomainUpDown1.Items.Add("50")
        Me.DomainUpDown1.Items.Add("20")
        Me.DomainUpDown1.Items.Add("10")
        Me.DomainUpDown1.Items.Add("5")
        Me.DomainUpDown1.Location = New System.Drawing.Point(10, 95)
        Me.DomainUpDown1.Name = "DomainUpDown1"
        Me.DomainUpDown1.ReadOnly = True
        Me.DomainUpDown1.Size = New System.Drawing.Size(107, 24)
        Me.DomainUpDown1.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(97, 17)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "From distance"
        '
        'textbox_prvni_vzdalenost
        '
        Me.textbox_prvni_vzdalenost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_prvni_vzdalenost.Location = New System.Drawing.Point(10, 41)
        Me.textbox_prvni_vzdalenost.Name = "textbox_prvni_vzdalenost"
        Me.textbox_prvni_vzdalenost.Size = New System.Drawing.Size(107, 24)
        Me.textbox_prvni_vzdalenost.TabIndex = 12
        Me.textbox_prvni_vzdalenost.Text = "0"
        '
        'label_nactena_strela
        '
        Me.label_nactena_strela.AutoSize = True
        Me.label_nactena_strela.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_nactena_strela.Location = New System.Drawing.Point(15, 167)
        Me.label_nactena_strela.Name = "label_nactena_strela"
        Me.label_nactena_strela.Size = New System.Drawing.Size(54, 17)
        Me.label_nactena_strela.TabIndex = 18
        Me.label_nactena_strela.Text = "Bullet:"
        '
        'button_vytvořit_tabulku
        '
        Me.button_vytvořit_tabulku.BackColor = System.Drawing.SystemColors.Window
        Me.button_vytvořit_tabulku.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_vytvořit_tabulku.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.button_vytvořit_tabulku.Location = New System.Drawing.Point(240, 462)
        Me.button_vytvořit_tabulku.Name = "button_vytvořit_tabulku"
        Me.button_vytvořit_tabulku.Size = New System.Drawing.Size(488, 58)
        Me.button_vytvořit_tabulku.TabIndex = 19
        Me.button_vytvořit_tabulku.Text = "Create a table"
        Me.button_vytvořit_tabulku.UseVisualStyleBackColor = False
        '
        'button_exportivat_do_pdf
        '
        Me.button_exportivat_do_pdf.BackColor = System.Drawing.SystemColors.Window
        Me.button_exportivat_do_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_exportivat_do_pdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.button_exportivat_do_pdf.Location = New System.Drawing.Point(240, 526)
        Me.button_exportivat_do_pdf.Name = "button_exportivat_do_pdf"
        Me.button_exportivat_do_pdf.Size = New System.Drawing.Size(488, 58)
        Me.button_exportivat_do_pdf.TabIndex = 20
        Me.button_exportivat_do_pdf.Text = "Export to PDF"
        Me.button_exportivat_do_pdf.UseVisualStyleBackColor = False
        '
        'label_smer_vetru_od_osy_pohybu
        '
        Me.label_smer_vetru_od_osy_pohybu.AutoSize = True
        Me.label_smer_vetru_od_osy_pohybu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_smer_vetru_od_osy_pohybu.Location = New System.Drawing.Point(418, 90)
        Me.label_smer_vetru_od_osy_pohybu.Name = "label_smer_vetru_od_osy_pohybu"
        Me.label_smer_vetru_od_osy_pohybu.Size = New System.Drawing.Size(162, 17)
        Me.label_smer_vetru_od_osy_pohybu.TabIndex = 21
        Me.label_smer_vetru_od_osy_pohybu.Text = "Direction of the wind:"
        '
        'label_uhel_sklonu
        '
        Me.label_uhel_sklonu.AutoSize = True
        Me.label_uhel_sklonu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_uhel_sklonu.Location = New System.Drawing.Point(418, 142)
        Me.label_uhel_sklonu.Name = "label_uhel_sklonu"
        Me.label_uhel_sklonu.Size = New System.Drawing.Size(109, 17)
        Me.label_uhel_sklonu.TabIndex = 22
        Me.label_uhel_sklonu.Text = "Angle of shot:"
        '
        'Export_tabulky
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(744, 657)
        Me.ControlBox = False
        Me.Controls.Add(Me.label_uhel_sklonu)
        Me.Controls.Add(Me.label_smer_vetru_od_osy_pohybu)
        Me.Controls.Add(Me.button_exportivat_do_pdf)
        Me.Controls.Add(Me.button_vytvořit_tabulku)
        Me.Controls.Add(Me.label_nactena_strela)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.label_uhlove_jednotky)
        Me.Controls.Add(Me.label_rychlost_vetru)
        Me.Controls.Add(Me.Button_Zavřít)
        Me.Controls.Add(Me.label_nadmorska_vyska)
        Me.Controls.Add(Me.label_teplota_vzduchu)
        Me.Controls.Add(Me.label_vzdalenost_osy_miridel_od_hlavne)
        Me.Controls.Add(Me.label_poloha_zasahu_v_nastrelne_vzdalenosti)
        Me.Controls.Add(Me.label_nastrelna_vzdalenost)
        Me.Controls.Add(Me.label_balisticky_koeficient)
        Me.Controls.Add(Me.label_hmotnost_strely)
        Me.Controls.Add(Me.label_pocatecni_rychlost)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(760, 696)
        Me.MinimumSize = New System.Drawing.Size(760, 696)
        Me.Name = "Export_tabulky"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export table to PDF format"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button_Zavřít As Button
    Friend WithEvents label_pocatecni_rychlost As Label
    Friend WithEvents label_hmotnost_strely As Label
    Friend WithEvents label_balisticky_koeficient As Label
    Friend WithEvents label_nastrelna_vzdalenost As Label
    Friend WithEvents label_poloha_zasahu_v_nastrelne_vzdalenosti As Label
    Friend WithEvents label_vzdalenost_osy_miridel_od_hlavne As Label
    Friend WithEvents label_teplota_vzduchu As Label
    Friend WithEvents label_nadmorska_vyska As Label
    Friend WithEvents label_rychlost_vetru As Label
    Friend WithEvents label_uhlove_jednotky As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents textbox_prvni_vzdalenost As TextBox
    Friend WithEvents DomainUpDown1 As DomainUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents label_nactena_strela As Label
    Friend WithEvents button_vytvořit_tabulku As Button
    Friend WithEvents button_exportivat_do_pdf As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents label_smer_vetru_od_osy_pohybu As Label
    Friend WithEvents label_uhel_sklonu As Label
    Friend WithEvents combobox_interval_vzdalenosti As ComboBox
    Friend WithEvents combobox_prvni_vzdalenost As ComboBox
End Class
