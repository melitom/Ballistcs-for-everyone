<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Hlavní_okno
    Inherits System.Windows.Forms.Form

    'Formulář přepisuje metodu Dispose, aby vyčistil seznam součástí.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hlavní_okno))
        Me.Button_Spočítej = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Textbox_Počáteční_rychlost = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.combobox_počáteční_rychlost = New System.Windows.Forms.ComboBox()
        Me.combobox_hmotnost_střely = New System.Windows.Forms.ComboBox()
        Me.Combobox_výběr_koeficientů = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Textbox_Koeficient_odporu = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Textbox_hmotnost = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.combobox_vzdálenost_mířidel = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Textbox_Vzdálenost_mířidel = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.checkbox_imperialni_jednotky = New System.Windows.Forms.CheckBox()
        Me.checkbox_metricke_jednotky = New System.Windows.Forms.CheckBox()
        Me.checkbox_použít_úhel_nástřelu_z_předchozího_výpočtu = New System.Windows.Forms.CheckBox()
        Me.Checkbox_18_MOA = New System.Windows.Forms.CheckBox()
        Me.Checkbox_14_MOA = New System.Windows.Forms.CheckBox()
        Me.Checkbox_Spočítat_pouze_nástřelnou_trajektorii = New System.Windows.Forms.CheckBox()
        Me.Checkbox_Střelba_s_puškohledem = New System.Windows.Forms.CheckBox()
        Me.Checkbox_Zbraň_je_nastřelená = New System.Windows.Forms.CheckBox()
        Me.Checkbox_Jednotky_MRAD = New System.Windows.Forms.CheckBox()
        Me.Checkbox_jednotky_MOA = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Textbox_Nástřelná_vzdálenost = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Textbox_Poloha_zásahu_v_nástřelu = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.combobox_poloha_zásahu = New System.Windows.Forms.ComboBox()
        Me.combobox_nástřelná_vzdálenost = New System.Windows.Forms.ComboBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.combobox_vzdálenost_cíle = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Textbox_Vzdálenost_cíle = New System.Windows.Forms.TextBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.label_korekce_klikáním = New System.Windows.Forms.Label()
        Me.label_korekce_přenášenim = New System.Windows.Forms.Label()
        Me.label_doba_pohybu = New System.Windows.Forms.Label()
        Me.label_rychlost_v_cíli = New System.Windows.Forms.Label()
        Me.label_počáteční_energie = New System.Windows.Forms.Label()
        Me.label_energie_v_cíli = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Menustrip = New System.Windows.Forms.MenuStrip()
        Me.VlastnostiAtmosféryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeznamStřelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VýpočetKoeficientuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportTabulkyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UložitPředvobyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DerivaceStřelyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PřevodyJednotekToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecondaryCalculationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VýpočetDostřeluToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NápovědaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OProgramuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.label_korekce_větru_přenášením = New System.Windows.Forms.Label()
        Me.label_korekce_větru_klikáním = New System.Windows.Forms.Label()
        Me.label_načtená_střela = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.combobox_úhel_výstřelu = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textbox_uhel_sklonu = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.Menustrip.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_Spočítej
        '
        Me.Button_Spočítej.BackColor = System.Drawing.SystemColors.Window
        Me.Button_Spočítej.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Spočítej.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button_Spočítej.Location = New System.Drawing.Point(6, 523)
        Me.Button_Spočítej.Name = "Button_Spočítej"
        Me.Button_Spočítej.Size = New System.Drawing.Size(417, 85)
        Me.Button_Spočítej.TabIndex = 0
        Me.Button_Spočítej.Text = "Calculate"
        Me.Button_Spočítej.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Muzzle velocity"
        '
        'Textbox_Počáteční_rychlost
        '
        Me.Textbox_Počáteční_rychlost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Textbox_Počáteční_rychlost.Location = New System.Drawing.Point(9, 42)
        Me.Textbox_Počáteční_rychlost.Name = "Textbox_Počáteční_rychlost"
        Me.Textbox_Počáteční_rychlost.Size = New System.Drawing.Size(107, 24)
        Me.Textbox_Počáteční_rychlost.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.combobox_počáteční_rychlost)
        Me.GroupBox1.Controls.Add(Me.combobox_hmotnost_střely)
        Me.GroupBox1.Controls.Add(Me.Combobox_výběr_koeficientů)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Textbox_Koeficient_odporu)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Textbox_hmotnost)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Textbox_Počáteční_rychlost)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(202, 185)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bullet data"
        '
        'combobox_počáteční_rychlost
        '
        Me.combobox_počáteční_rychlost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_počáteční_rychlost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_počáteční_rychlost.FormattingEnabled = True
        Me.combobox_počáteční_rychlost.Items.AddRange(New Object() {"m/s", "fps"})
        Me.combobox_počáteční_rychlost.Location = New System.Drawing.Point(122, 42)
        Me.combobox_počáteční_rychlost.Name = "combobox_počáteční_rychlost"
        Me.combobox_počáteční_rychlost.Size = New System.Drawing.Size(65, 24)
        Me.combobox_počáteční_rychlost.TabIndex = 9
        '
        'combobox_hmotnost_střely
        '
        Me.combobox_hmotnost_střely.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_hmotnost_střely.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_hmotnost_střely.FormattingEnabled = True
        Me.combobox_hmotnost_střely.Items.AddRange(New Object() {"g", "grs"})
        Me.combobox_hmotnost_střely.Location = New System.Drawing.Point(122, 94)
        Me.combobox_hmotnost_střely.Name = "combobox_hmotnost_střely"
        Me.combobox_hmotnost_střely.Size = New System.Drawing.Size(65, 24)
        Me.combobox_hmotnost_střely.TabIndex = 8
        '
        'Combobox_výběr_koeficientů
        '
        Me.Combobox_výběr_koeficientů.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combobox_výběr_koeficientů.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Combobox_výběr_koeficientů.FormattingEnabled = True
        Me.Combobox_výběr_koeficientů.Items.AddRange(New Object() {"G1", "G7", "JSBE"})
        Me.Combobox_výběr_koeficientů.Location = New System.Drawing.Point(122, 146)
        Me.Combobox_výběr_koeficientů.Name = "Combobox_výběr_koeficientů"
        Me.Combobox_výběr_koeficientů.Size = New System.Drawing.Size(65, 24)
        Me.Combobox_výběr_koeficientů.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ballistic coefficient"
        '
        'Textbox_Koeficient_odporu
        '
        Me.Textbox_Koeficient_odporu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Textbox_Koeficient_odporu.Location = New System.Drawing.Point(9, 146)
        Me.Textbox_Koeficient_odporu.Name = "Textbox_Koeficient_odporu"
        Me.Textbox_Koeficient_odporu.Size = New System.Drawing.Size(107, 24)
        Me.Textbox_Koeficient_odporu.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Bullet weight"
        '
        'Textbox_hmotnost
        '
        Me.Textbox_hmotnost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Textbox_hmotnost.Location = New System.Drawing.Point(9, 94)
        Me.Textbox_hmotnost.Name = "Textbox_hmotnost"
        Me.Textbox_hmotnost.Size = New System.Drawing.Size(107, 24)
        Me.Textbox_hmotnost.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.combobox_vzdálenost_mířidel)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Textbox_Vzdálenost_mířidel)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 313)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(202, 82)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sights data"
        '
        'combobox_vzdálenost_mířidel
        '
        Me.combobox_vzdálenost_mířidel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_vzdálenost_mířidel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_vzdálenost_mířidel.FormattingEnabled = True
        Me.combobox_vzdálenost_mířidel.Items.AddRange(New Object() {"mm", "in"})
        Me.combobox_vzdálenost_mířidel.Location = New System.Drawing.Point(122, 43)
        Me.combobox_vzdálenost_mířidel.Name = "combobox_vzdálenost_mířidel"
        Me.combobox_vzdálenost_mířidel.Size = New System.Drawing.Size(65, 24)
        Me.combobox_vzdálenost_mířidel.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Sight height"
        '
        'Textbox_Vzdálenost_mířidel
        '
        Me.Textbox_Vzdálenost_mířidel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Textbox_Vzdálenost_mířidel.Location = New System.Drawing.Point(9, 43)
        Me.Textbox_Vzdálenost_mířidel.Name = "Textbox_Vzdálenost_mířidel"
        Me.Textbox_Vzdálenost_mířidel.Size = New System.Drawing.Size(107, 24)
        Me.Textbox_Vzdálenost_mířidel.TabIndex = 7
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBox3.Controls.Add(Me.checkbox_imperialni_jednotky)
        Me.GroupBox3.Controls.Add(Me.checkbox_metricke_jednotky)
        Me.GroupBox3.Controls.Add(Me.checkbox_použít_úhel_nástřelu_z_předchozího_výpočtu)
        Me.GroupBox3.Controls.Add(Me.Checkbox_18_MOA)
        Me.GroupBox3.Controls.Add(Me.Checkbox_14_MOA)
        Me.GroupBox3.Controls.Add(Me.Checkbox_Spočítat_pouze_nástřelnou_trajektorii)
        Me.GroupBox3.Controls.Add(Me.Checkbox_Střelba_s_puškohledem)
        Me.GroupBox3.Controls.Add(Me.Checkbox_Zbraň_je_nastřelená)
        Me.GroupBox3.Controls.Add(Me.Checkbox_Jednotky_MRAD)
        Me.GroupBox3.Controls.Add(Me.Checkbox_jednotky_MOA)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(220, 33)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(202, 289)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Calculation settings"
        '
        'checkbox_imperialni_jednotky
        '
        Me.checkbox_imperialni_jednotky.AutoSize = True
        Me.checkbox_imperialni_jednotky.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_imperialni_jednotky.Location = New System.Drawing.Point(100, 253)
        Me.checkbox_imperialni_jednotky.Name = "checkbox_imperialni_jednotky"
        Me.checkbox_imperialni_jednotky.Size = New System.Drawing.Size(84, 21)
        Me.checkbox_imperialni_jednotky.TabIndex = 20
        Me.checkbox_imperialni_jednotky.Text = "Imperial"
        Me.checkbox_imperialni_jednotky.UseVisualStyleBackColor = True
        '
        'checkbox_metricke_jednotky
        '
        Me.checkbox_metricke_jednotky.AutoSize = True
        Me.checkbox_metricke_jednotky.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_metricke_jednotky.Location = New System.Drawing.Point(17, 253)
        Me.checkbox_metricke_jednotky.Name = "checkbox_metricke_jednotky"
        Me.checkbox_metricke_jednotky.Size = New System.Drawing.Size(71, 21)
        Me.checkbox_metricke_jednotky.TabIndex = 19
        Me.checkbox_metricke_jednotky.Text = "Metric"
        Me.checkbox_metricke_jednotky.UseVisualStyleBackColor = True
        '
        'checkbox_použít_úhel_nástřelu_z_předchozího_výpočtu
        '
        Me.checkbox_použít_úhel_nástřelu_z_předchozího_výpočtu.AutoSize = True
        Me.checkbox_použít_úhel_nástřelu_z_předchozího_výpočtu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_použít_úhel_nástřelu_z_předchozího_výpočtu.Location = New System.Drawing.Point(19, 203)
        Me.checkbox_použít_úhel_nástřelu_z_předchozího_výpočtu.Name = "checkbox_použít_úhel_nástřelu_z_předchozího_výpočtu"
        Me.checkbox_použít_úhel_nástřelu_z_předchozího_výpočtu.Size = New System.Drawing.Size(176, 38)
        Me.checkbox_použít_úhel_nástřelu_z_předchozího_výpočtu.TabIndex = 17
        Me.checkbox_použít_úhel_nástřelu_z_předchozího_výpočtu.Text = "Use sight settings from " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the previous calculation"
        Me.checkbox_použít_úhel_nástřelu_z_předchozího_výpočtu.UseVisualStyleBackColor = True
        '
        'Checkbox_18_MOA
        '
        Me.Checkbox_18_MOA.AutoSize = True
        Me.Checkbox_18_MOA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Checkbox_18_MOA.Location = New System.Drawing.Point(89, 77)
        Me.Checkbox_18_MOA.Name = "Checkbox_18_MOA"
        Me.Checkbox_18_MOA.Size = New System.Drawing.Size(47, 21)
        Me.Checkbox_18_MOA.TabIndex = 16
        Me.Checkbox_18_MOA.Text = "1/8"
        Me.Checkbox_18_MOA.UseVisualStyleBackColor = True
        '
        'Checkbox_14_MOA
        '
        Me.Checkbox_14_MOA.AutoSize = True
        Me.Checkbox_14_MOA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Checkbox_14_MOA.Location = New System.Drawing.Point(36, 77)
        Me.Checkbox_14_MOA.Name = "Checkbox_14_MOA"
        Me.Checkbox_14_MOA.Size = New System.Drawing.Size(47, 21)
        Me.Checkbox_14_MOA.TabIndex = 15
        Me.Checkbox_14_MOA.Text = "1/4"
        Me.Checkbox_14_MOA.UseVisualStyleBackColor = True
        '
        'Checkbox_Spočítat_pouze_nástřelnou_trajektorii
        '
        Me.Checkbox_Spočítat_pouze_nástřelnou_trajektorii.AutoSize = True
        Me.Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Location = New System.Drawing.Point(19, 163)
        Me.Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Name = "Checkbox_Spočítat_pouze_nástřelnou_trajektorii"
        Me.Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Size = New System.Drawing.Size(172, 38)
        Me.Checkbox_Spočítat_pouze_nástřelnou_trajektorii.TabIndex = 8
        Me.Checkbox_Spočítat_pouze_nástřelnou_trajektorii.Text = "Calculate only sighting " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "trajectory"
        Me.Checkbox_Spočítat_pouze_nástřelnou_trajektorii.UseVisualStyleBackColor = True
        '
        'Checkbox_Střelba_s_puškohledem
        '
        Me.Checkbox_Střelba_s_puškohledem.AutoSize = True
        Me.Checkbox_Střelba_s_puškohledem.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Checkbox_Střelba_s_puškohledem.Location = New System.Drawing.Point(6, 25)
        Me.Checkbox_Střelba_s_puškohledem.Name = "Checkbox_Střelba_s_puškohledem"
        Me.Checkbox_Střelba_s_puškohledem.Size = New System.Drawing.Size(144, 21)
        Me.Checkbox_Střelba_s_puškohledem.TabIndex = 14
        Me.Checkbox_Střelba_s_puškohledem.Text = "Scope equipped"
        Me.Checkbox_Střelba_s_puškohledem.UseVisualStyleBackColor = True
        '
        'Checkbox_Zbraň_je_nastřelená
        '
        Me.Checkbox_Zbraň_je_nastřelená.AutoSize = True
        Me.Checkbox_Zbraň_je_nastřelená.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Checkbox_Zbraň_je_nastřelená.Location = New System.Drawing.Point(6, 138)
        Me.Checkbox_Zbraň_je_nastřelená.Name = "Checkbox_Zbraň_je_nastřelená"
        Me.Checkbox_Zbraň_je_nastřelená.Size = New System.Drawing.Size(157, 21)
        Me.Checkbox_Zbraň_je_nastřelená.TabIndex = 7
        Me.Checkbox_Zbraň_je_nastřelená.Text = "Firearm is sighted"
        Me.Checkbox_Zbraň_je_nastřelená.UseVisualStyleBackColor = True
        '
        'Checkbox_Jednotky_MRAD
        '
        Me.Checkbox_Jednotky_MRAD.AutoSize = True
        Me.Checkbox_Jednotky_MRAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Checkbox_Jednotky_MRAD.Location = New System.Drawing.Point(21, 105)
        Me.Checkbox_Jednotky_MRAD.Name = "Checkbox_Jednotky_MRAD"
        Me.Checkbox_Jednotky_MRAD.Size = New System.Drawing.Size(145, 21)
        Me.Checkbox_Jednotky_MRAD.TabIndex = 11
        Me.Checkbox_Jednotky_MRAD.Text = "Units MRAD (1/10)"
        Me.Checkbox_Jednotky_MRAD.UseVisualStyleBackColor = True
        '
        'Checkbox_jednotky_MOA
        '
        Me.Checkbox_jednotky_MOA.AutoSize = True
        Me.Checkbox_jednotky_MOA.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Checkbox_jednotky_MOA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Checkbox_jednotky_MOA.Location = New System.Drawing.Point(21, 52)
        Me.Checkbox_jednotky_MOA.Name = "Checkbox_jednotky_MOA"
        Me.Checkbox_jednotky_MOA.Size = New System.Drawing.Size(94, 21)
        Me.Checkbox_jednotky_MOA.TabIndex = 9
        Me.Checkbox_jednotky_MOA.Text = "Units MOA"
        Me.Checkbox_jednotky_MOA.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Sighting distance"
        '
        'Textbox_Nástřelná_vzdálenost
        '
        Me.Textbox_Nástřelná_vzdálenost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Textbox_Nástřelná_vzdálenost.Location = New System.Drawing.Point(7, 45)
        Me.Textbox_Nástřelná_vzdálenost.Name = "Textbox_Nástřelná_vzdálenost"
        Me.Textbox_Nástřelná_vzdálenost.Size = New System.Drawing.Size(109, 24)
        Me.Textbox_Nástřelná_vzdálenost.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 34)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Point of impact at sighting " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "distance"
        '
        'Textbox_Poloha_zásahu_v_nástřelu
        '
        Me.Textbox_Poloha_zásahu_v_nástřelu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Textbox_Poloha_zásahu_v_nástřelu.Location = New System.Drawing.Point(7, 116)
        Me.Textbox_Poloha_zásahu_v_nástřelu.Name = "Textbox_Poloha_zásahu_v_nástřelu"
        Me.Textbox_Poloha_zásahu_v_nástřelu.Size = New System.Drawing.Size(109, 24)
        Me.Textbox_Poloha_zásahu_v_nástřelu.TabIndex = 8
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.combobox_poloha_zásahu)
        Me.GroupBox4.Controls.Add(Me.combobox_nástřelná_vzdálenost)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Textbox_Nástřelná_vzdálenost)
        Me.GroupBox4.Controls.Add(Me.Textbox_Poloha_zásahu_v_nástřelu)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(221, 328)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(202, 154)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Firearm is sighted"
        '
        'combobox_poloha_zásahu
        '
        Me.combobox_poloha_zásahu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_poloha_zásahu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_poloha_zásahu.FormattingEnabled = True
        Me.combobox_poloha_zásahu.Items.AddRange(New Object() {"cm", "in"})
        Me.combobox_poloha_zásahu.Location = New System.Drawing.Point(122, 116)
        Me.combobox_poloha_zásahu.Name = "combobox_poloha_zásahu"
        Me.combobox_poloha_zásahu.Size = New System.Drawing.Size(65, 24)
        Me.combobox_poloha_zásahu.TabIndex = 10
        '
        'combobox_nástřelná_vzdálenost
        '
        Me.combobox_nástřelná_vzdálenost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_nástřelná_vzdálenost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_nástřelná_vzdálenost.FormattingEnabled = True
        Me.combobox_nástřelná_vzdálenost.Items.AddRange(New Object() {"m", "yd", "ft"})
        Me.combobox_nástřelná_vzdálenost.Location = New System.Drawing.Point(122, 45)
        Me.combobox_nástřelná_vzdálenost.Name = "combobox_nástřelná_vzdálenost"
        Me.combobox_nástřelná_vzdálenost.Size = New System.Drawing.Size(65, 24)
        Me.combobox_nástřelná_vzdálenost.TabIndex = 9
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.combobox_vzdálenost_cíle)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.Textbox_Vzdálenost_cíle)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(12, 224)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(202, 83)
        Me.GroupBox6.TabIndex = 13
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Target distance"
        '
        'combobox_vzdálenost_cíle
        '
        Me.combobox_vzdálenost_cíle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_vzdálenost_cíle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_vzdálenost_cíle.FormattingEnabled = True
        Me.combobox_vzdálenost_cíle.Items.AddRange(New Object() {"m", "yd", "ft"})
        Me.combobox_vzdálenost_cíle.Location = New System.Drawing.Point(122, 44)
        Me.combobox_vzdálenost_cíle.Name = "combobox_vzdálenost_cíle"
        Me.combobox_vzdálenost_cíle.Size = New System.Drawing.Size(65, 24)
        Me.combobox_vzdálenost_cíle.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 17)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Target distance"
        '
        'Textbox_Vzdálenost_cíle
        '
        Me.Textbox_Vzdálenost_cíle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Textbox_Vzdálenost_cíle.Location = New System.Drawing.Point(9, 44)
        Me.Textbox_Vzdálenost_cíle.Name = "Textbox_Vzdálenost_cíle"
        Me.Textbox_Vzdálenost_cíle.Size = New System.Drawing.Size(107, 24)
        Me.Textbox_Vzdálenost_cíle.TabIndex = 12
        '
        'Chart1
        '
        Me.Chart1.Location = New System.Drawing.Point(429, 210)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Size = New System.Drawing.Size(893, 441)
        Me.Chart1.TabIndex = 14
        Me.Chart1.Text = "Chart1"
        '
        'label_korekce_klikáním
        '
        Me.label_korekce_klikáním.AutoSize = True
        Me.label_korekce_klikáním.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_korekce_klikáním.Location = New System.Drawing.Point(5, 51)
        Me.label_korekce_klikáním.Name = "label_korekce_klikáním"
        Me.label_korekce_klikáním.Size = New System.Drawing.Size(202, 25)
        Me.label_korekce_klikáním.TabIndex = 16
        Me.label_korekce_klikáním.Text = "Scope compensation:"
        '
        'label_korekce_přenášenim
        '
        Me.label_korekce_přenášenim.AutoSize = True
        Me.label_korekce_přenášenim.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_korekce_přenášenim.Location = New System.Drawing.Point(5, 20)
        Me.label_korekce_přenášenim.Name = "label_korekce_přenášenim"
        Me.label_korekce_přenášenim.Size = New System.Drawing.Size(190, 25)
        Me.label_korekce_přenášenim.TabIndex = 17
        Me.label_korekce_přenášenim.Text = "Sight compensation:"
        '
        'label_doba_pohybu
        '
        Me.label_doba_pohybu.AutoSize = True
        Me.label_doba_pohybu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_doba_pohybu.Location = New System.Drawing.Point(7, 133)
        Me.label_doba_pohybu.Name = "label_doba_pohybu"
        Me.label_doba_pohybu.Size = New System.Drawing.Size(128, 25)
        Me.label_doba_pohybu.TabIndex = 18
        Me.label_doba_pohybu.Text = "Time of flight:"
        '
        'label_rychlost_v_cíli
        '
        Me.label_rychlost_v_cíli.AutoSize = True
        Me.label_rychlost_v_cíli.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_rychlost_v_cíli.Location = New System.Drawing.Point(7, 98)
        Me.label_rychlost_v_cíli.Name = "label_rychlost_v_cíli"
        Me.label_rychlost_v_cíli.Size = New System.Drawing.Size(167, 25)
        Me.label_rychlost_v_cíli.TabIndex = 19
        Me.label_rychlost_v_cíli.Text = "Velocity at target: "
        '
        'label_počáteční_energie
        '
        Me.label_počáteční_energie.AutoSize = True
        Me.label_počáteční_energie.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_počáteční_energie.Location = New System.Drawing.Point(7, 28)
        Me.label_počáteční_energie.Name = "label_počáteční_energie"
        Me.label_počáteční_energie.Size = New System.Drawing.Size(146, 25)
        Me.label_počáteční_energie.TabIndex = 20
        Me.label_počáteční_energie.Text = "Muzzle energy:"
        '
        'label_energie_v_cíli
        '
        Me.label_energie_v_cíli.AutoSize = True
        Me.label_energie_v_cíli.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_energie_v_cíli.Location = New System.Drawing.Point(7, 63)
        Me.label_energie_v_cíli.Name = "label_energie_v_cíli"
        Me.label_energie_v_cíli.Size = New System.Drawing.Size(160, 25)
        Me.label_energie_v_cíli.TabIndex = 21
        Me.label_energie_v_cíli.Text = "Energy at target: "
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.label_rychlost_v_cíli)
        Me.GroupBox7.Controls.Add(Me.label_doba_pohybu)
        Me.GroupBox7.Controls.Add(Me.label_energie_v_cíli)
        Me.GroupBox7.Controls.Add(Me.label_počáteční_energie)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(897, 33)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(425, 171)
        Me.GroupBox7.TabIndex = 22
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Other calculated data"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.label_korekce_přenášenim)
        Me.GroupBox8.Controls.Add(Me.label_korekce_klikáním)
        Me.GroupBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(429, 33)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(462, 85)
        Me.GroupBox8.TabIndex = 23
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Bullet drop compensation"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 616)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(353, 34)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Version: 3.2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Author: Tomáš Melichar (www.ballistics4everyone.com)"
        '
        'Menustrip
        '
        Me.Menustrip.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Menustrip.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.Menustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VlastnostiAtmosféryToolStripMenuItem, Me.SeznamStřelToolStripMenuItem, Me.VýpočetKoeficientuToolStripMenuItem, Me.ExportTabulkyToolStripMenuItem, Me.UložitPředvobyToolStripMenuItem, Me.DerivaceStřelyToolStripMenuItem, Me.PřevodyJednotekToolStripMenuItem, Me.SecondaryCalculationsToolStripMenuItem, Me.VýpočetDostřeluToolStripMenuItem, Me.NápovědaToolStripMenuItem, Me.OProgramuToolStripMenuItem})
        Me.Menustrip.Location = New System.Drawing.Point(0, 0)
        Me.Menustrip.Name = "Menustrip"
        Me.Menustrip.Size = New System.Drawing.Size(1334, 27)
        Me.Menustrip.TabIndex = 25
        Me.Menustrip.Text = "Menu"
        '
        'VlastnostiAtmosféryToolStripMenuItem
        '
        Me.VlastnostiAtmosféryToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.VlastnostiAtmosféryToolStripMenuItem.Name = "VlastnostiAtmosféryToolStripMenuItem"
        Me.VlastnostiAtmosféryToolStripMenuItem.Size = New System.Drawing.Size(159, 23)
        Me.VlastnostiAtmosféryToolStripMenuItem.Text = "Atmosphere and Wind"
        '
        'SeznamStřelToolStripMenuItem
        '
        Me.SeznamStřelToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.SeznamStřelToolStripMenuItem.Name = "SeznamStřelToolStripMenuItem"
        Me.SeznamStřelToolStripMenuItem.Size = New System.Drawing.Size(102, 23)
        Me.SeznamStřelToolStripMenuItem.Text = "List of bullets"
        '
        'VýpočetKoeficientuToolStripMenuItem
        '
        Me.VýpočetKoeficientuToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.VýpočetKoeficientuToolStripMenuItem.Name = "VýpočetKoeficientuToolStripMenuItem"
        Me.VýpočetKoeficientuToolStripMenuItem.Size = New System.Drawing.Size(159, 23)
        Me.VýpočetKoeficientuToolStripMenuItem.Text = "Coefficient calculations"
        '
        'ExportTabulkyToolStripMenuItem
        '
        Me.ExportTabulkyToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ExportTabulkyToolStripMenuItem.Name = "ExportTabulkyToolStripMenuItem"
        Me.ExportTabulkyToolStripMenuItem.Size = New System.Drawing.Size(94, 23)
        Me.ExportTabulkyToolStripMenuItem.Text = "Export table"
        '
        'UložitPředvobyToolStripMenuItem
        '
        Me.UložitPředvobyToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.UložitPředvobyToolStripMenuItem.Name = "UložitPředvobyToolStripMenuItem"
        Me.UložitPředvobyToolStripMenuItem.Size = New System.Drawing.Size(65, 23)
        Me.UložitPředvobyToolStripMenuItem.Text = "Presets"
        '
        'DerivaceStřelyToolStripMenuItem
        '
        Me.DerivaceStřelyToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DerivaceStřelyToolStripMenuItem.Name = "DerivaceStřelyToolStripMenuItem"
        Me.DerivaceStřelyToolStripMenuItem.Size = New System.Drawing.Size(131, 23)
        Me.DerivaceStřelyToolStripMenuItem.Text = "Bullet stabilization"
        '
        'PřevodyJednotekToolStripMenuItem
        '
        Me.PřevodyJednotekToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.PřevodyJednotekToolStripMenuItem.Name = "PřevodyJednotekToolStripMenuItem"
        Me.PřevodyJednotekToolStripMenuItem.Size = New System.Drawing.Size(123, 23)
        Me.PřevodyJednotekToolStripMenuItem.Text = "Unit conversions"
        '
        'SecondaryCalculationsToolStripMenuItem
        '
        Me.SecondaryCalculationsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.SecondaryCalculationsToolStripMenuItem.Name = "SecondaryCalculationsToolStripMenuItem"
        Me.SecondaryCalculationsToolStripMenuItem.Size = New System.Drawing.Size(158, 23)
        Me.SecondaryCalculationsToolStripMenuItem.Text = "Secondary calculations"
        '
        'VýpočetDostřeluToolStripMenuItem
        '
        Me.VýpočetDostřeluToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.VýpočetDostřeluToolStripMenuItem.Name = "VýpočetDostřeluToolStripMenuItem"
        Me.VýpočetDostřeluToolStripMenuItem.Size = New System.Drawing.Size(195, 23)
        Me.VýpočetDostřeluToolStripMenuItem.Text = "Maximum range calculations"
        '
        'NápovědaToolStripMenuItem
        '
        Me.NápovědaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.NápovědaToolStripMenuItem.Name = "NápovědaToolStripMenuItem"
        Me.NápovědaToolStripMenuItem.Size = New System.Drawing.Size(49, 23)
        Me.NápovědaToolStripMenuItem.Text = "Help"
        '
        'OProgramuToolStripMenuItem
        '
        Me.OProgramuToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.OProgramuToolStripMenuItem.Name = "OProgramuToolStripMenuItem"
        Me.OProgramuToolStripMenuItem.Size = New System.Drawing.Size(59, 23)
        Me.OProgramuToolStripMenuItem.Text = "About"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.label_korekce_větru_přenášením)
        Me.GroupBox5.Controls.Add(Me.label_korekce_větru_klikáním)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(429, 124)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(462, 80)
        Me.GroupBox5.TabIndex = 26
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Windage, Spin Drift, Coriolis effect compensation"
        '
        'label_korekce_větru_přenášením
        '
        Me.label_korekce_větru_přenášením.AutoSize = True
        Me.label_korekce_větru_přenášením.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_korekce_větru_přenášením.Location = New System.Drawing.Point(6, 20)
        Me.label_korekce_větru_přenášením.Name = "label_korekce_větru_přenášením"
        Me.label_korekce_větru_přenášením.Size = New System.Drawing.Size(181, 24)
        Me.label_korekce_větru_přenášením.TabIndex = 17
        Me.label_korekce_větru_přenášením.Text = "Sight compensation:"
        '
        'label_korekce_větru_klikáním
        '
        Me.label_korekce_větru_klikáním.AutoSize = True
        Me.label_korekce_větru_klikáním.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_korekce_větru_klikáním.Location = New System.Drawing.Point(6, 48)
        Me.label_korekce_větru_klikáním.Name = "label_korekce_větru_klikáním"
        Me.label_korekce_větru_klikáním.Size = New System.Drawing.Size(194, 24)
        Me.label_korekce_větru_klikáním.TabIndex = 16
        Me.label_korekce_větru_klikáním.Text = "Scope compensation:"
        '
        'label_načtená_střela
        '
        Me.label_načtená_střela.AutoSize = True
        Me.label_načtená_střela.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_načtená_střela.Location = New System.Drawing.Point(8, 496)
        Me.label_načtená_střela.Name = "label_načtená_střela"
        Me.label_načtená_střela.Size = New System.Drawing.Size(66, 24)
        Me.label_načtená_střela.TabIndex = 27
        Me.label_načtená_střela.Text = "Bullet: "
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.combobox_úhel_výstřelu)
        Me.GroupBox9.Controls.Add(Me.Label4)
        Me.GroupBox9.Controls.Add(Me.textbox_uhel_sklonu)
        Me.GroupBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(11, 401)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(202, 81)
        Me.GroupBox9.TabIndex = 28
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Shooting up / downhill"
        '
        'combobox_úhel_výstřelu
        '
        Me.combobox_úhel_výstřelu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_úhel_výstřelu.Enabled = False
        Me.combobox_úhel_výstřelu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_úhel_výstřelu.FormattingEnabled = True
        Me.combobox_úhel_výstřelu.Items.AddRange(New Object() {"°", "deg"})
        Me.combobox_úhel_výstřelu.Location = New System.Drawing.Point(123, 43)
        Me.combobox_úhel_výstřelu.Name = "combobox_úhel_výstřelu"
        Me.combobox_úhel_výstřelu.Size = New System.Drawing.Size(65, 24)
        Me.combobox_úhel_výstřelu.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Angle of shot"
        '
        'textbox_uhel_sklonu
        '
        Me.textbox_uhel_sklonu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_uhel_sklonu.Location = New System.Drawing.Point(10, 43)
        Me.textbox_uhel_sklonu.Name = "textbox_uhel_sklonu"
        Me.textbox_uhel_sklonu.Size = New System.Drawing.Size(107, 24)
        Me.textbox_uhel_sklonu.TabIndex = 7
        '
        'Hlavní_okno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1334, 661)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.label_načtená_střela)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button_Spočítej)
        Me.Controls.Add(Me.Menustrip)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.Menustrip
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1350, 700)
        Me.MinimumSize = New System.Drawing.Size(1350, 700)
        Me.Name = "Hlavní_okno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ballistics for everyone 3.2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.Menustrip.ResumeLayout(False)
        Me.Menustrip.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Spočítej As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Textbox_Počáteční_rychlost As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Textbox_Koeficient_odporu As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Textbox_hmotnost As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Textbox_Vzdálenost_mířidel As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Textbox_Poloha_zásahu_v_nástřelu As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Textbox_Nástřelná_vzdálenost As TextBox
    Friend WithEvents Checkbox_Spočítat_pouze_nástřelnou_trajektorii As CheckBox
    Friend WithEvents Checkbox_Zbraň_je_nastřelená As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Checkbox_jednotky_MOA As CheckBox
    Friend WithEvents Checkbox_Jednotky_MRAD As CheckBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Textbox_Vzdálenost_cíle As TextBox
    Friend WithEvents Checkbox_Střelba_s_puškohledem As CheckBox
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents label_korekce_klikáním As Label
    Friend WithEvents label_korekce_přenášenim As Label
    Friend WithEvents label_doba_pohybu As Label
    Friend WithEvents label_rychlost_v_cíli As Label
    Friend WithEvents label_počáteční_energie As Label
    Friend WithEvents label_energie_v_cíli As Label
    Friend WithEvents Checkbox_18_MOA As CheckBox
    Friend WithEvents Checkbox_14_MOA As CheckBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Combobox_výběr_koeficientů As ComboBox
    Friend WithEvents combobox_hmotnost_střely As ComboBox
    Friend WithEvents combobox_počáteční_rychlost As ComboBox
    Friend WithEvents Menustrip As MenuStrip
    Friend WithEvents VýpočetKoeficientuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OProgramuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VlastnostiAtmosféryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NápovědaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents label_korekce_větru_přenášením As Label
    Friend WithEvents label_korekce_větru_klikáním As Label
    Friend WithEvents SeznamStřelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents label_načtená_střela As Label
    Friend WithEvents checkbox_použít_úhel_nástřelu_z_předchozího_výpočtu As CheckBox
    Friend WithEvents PřevodyJednotekToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportTabulkyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UložitPředvobyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DerivaceStřelyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents textbox_uhel_sklonu As TextBox
    Friend WithEvents combobox_vzdálenost_mířidel As ComboBox
    Friend WithEvents combobox_poloha_zásahu As ComboBox
    Friend WithEvents combobox_nástřelná_vzdálenost As ComboBox
    Friend WithEvents combobox_vzdálenost_cíle As ComboBox
    Friend WithEvents combobox_úhel_výstřelu As ComboBox
    Friend WithEvents checkbox_imperialni_jednotky As CheckBox
    Friend WithEvents checkbox_metricke_jednotky As CheckBox
    Friend WithEvents VýpočetDostřeluToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SecondaryCalculationsToolStripMenuItem As ToolStripMenuItem
End Class
