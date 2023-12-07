<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Derivace_střely
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Derivace_střely))
        Me.button_zavřít = New System.Windows.Forms.Button()
        Me.combobox_počáteční_rychlost = New System.Windows.Forms.ComboBox()
        Me.combobox_hmotnost_střely = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Textbox_hmotnost = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Textbox_Počáteční_rychlost = New System.Windows.Forms.TextBox()
        Me.groupbox_stabilizace_strely_rotaci = New System.Windows.Forms.GroupBox()
        Me.label_koeficient_Sg = New System.Windows.Forms.Label()
        Me.combobox_délka_střely = New System.Windows.Forms.ComboBox()
        Me.textbox_délka_střely = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label_6 = New System.Windows.Forms.Label()
        Me.label_nadmořská_výška = New System.Windows.Forms.Label()
        Me.label_teplota_vzduchu = New System.Windows.Forms.Label()
        Me.combobox_průměr_střely = New System.Windows.Forms.ComboBox()
        Me.textbox_průměr_střely = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.combobox_stoupání_drážek = New System.Windows.Forms.ComboBox()
        Me.textbox_stoupání_drážek = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.button_spočítej_stabilizaci = New System.Windows.Forms.Button()
        Me.groupbox_derivace = New System.Windows.Forms.GroupBox()
        Me.label_vzdálenost_cíle = New System.Windows.Forms.Label()
        Me.combobox_smer_drazek = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.groupbox_coriolisuv_efekt = New System.Windows.Forms.GroupBox()
        Me.combobox_zeměpisná_šířka = New System.Windows.Forms.ComboBox()
        Me.radiobutton_S = New System.Windows.Forms.RadioButton()
        Me.radiobutton_N = New System.Windows.Forms.RadioButton()
        Me.textbox_zemepisna_sirka = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.radiobutton_SW = New System.Windows.Forms.RadioButton()
        Me.radiobutton_SE = New System.Windows.Forms.RadioButton()
        Me.combobox_polokoule = New System.Windows.Forms.ComboBox()
        Me.radiobutton_NW = New System.Windows.Forms.RadioButton()
        Me.radiobutton_W = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.radiobutton_NE = New System.Windows.Forms.RadioButton()
        Me.radiobutton_E = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.label_korekce_klikáním_výšková = New System.Windows.Forms.Label()
        Me.label_korekce_přenášením_výšková = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.label_korekce_klikáním_stranová = New System.Windows.Forms.Label()
        Me.label_korekce_prenasenim_stranová = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.checkbox_nacist_odchylky = New System.Windows.Forms.CheckBox()
        Me.checkbox_spocitat_coriolisuv_efekt = New System.Windows.Forms.CheckBox()
        Me.checkbox_spocitat_derivaci = New System.Windows.Forms.CheckBox()
        Me.groupbox_stabilizace_strely_rotaci.SuspendLayout()
        Me.groupbox_derivace.SuspendLayout()
        Me.groupbox_coriolisuv_efekt.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'button_zavřít
        '
        Me.button_zavřít.BackColor = System.Drawing.SystemColors.Window
        Me.button_zavřít.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_zavřít.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.button_zavřít.Location = New System.Drawing.Point(487, 431)
        Me.button_zavřít.Name = "button_zavřít"
        Me.button_zavřít.Size = New System.Drawing.Size(469, 64)
        Me.button_zavřít.TabIndex = 2
        Me.button_zavřít.Text = "Close"
        Me.button_zavřít.UseVisualStyleBackColor = False
        '
        'combobox_počáteční_rychlost
        '
        Me.combobox_počáteční_rychlost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_počáteční_rychlost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_počáteční_rychlost.FormattingEnabled = True
        Me.combobox_počáteční_rychlost.Items.AddRange(New Object() {"m/s", "fps"})
        Me.combobox_počáteční_rychlost.Location = New System.Drawing.Point(156, 44)
        Me.combobox_počáteční_rychlost.Name = "combobox_počáteční_rychlost"
        Me.combobox_počáteční_rychlost.Size = New System.Drawing.Size(65, 24)
        Me.combobox_počáteční_rychlost.TabIndex = 15
        '
        'combobox_hmotnost_střely
        '
        Me.combobox_hmotnost_střely.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_hmotnost_střely.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_hmotnost_střely.FormattingEnabled = True
        Me.combobox_hmotnost_střely.Items.AddRange(New Object() {"g", "grs"})
        Me.combobox_hmotnost_střely.Location = New System.Drawing.Point(156, 100)
        Me.combobox_hmotnost_střely.Name = "combobox_hmotnost_střely"
        Me.combobox_hmotnost_střely.Size = New System.Drawing.Size(65, 24)
        Me.combobox_hmotnost_střely.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Bullet weight"
        '
        'Textbox_hmotnost
        '
        Me.Textbox_hmotnost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Textbox_hmotnost.Location = New System.Drawing.Point(14, 100)
        Me.Textbox_hmotnost.Name = "Textbox_hmotnost"
        Me.Textbox_hmotnost.Size = New System.Drawing.Size(136, 24)
        Me.Textbox_hmotnost.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Muzzle velocity"
        '
        'Textbox_Počáteční_rychlost
        '
        Me.Textbox_Počáteční_rychlost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Textbox_Počáteční_rychlost.Location = New System.Drawing.Point(14, 44)
        Me.Textbox_Počáteční_rychlost.Name = "Textbox_Počáteční_rychlost"
        Me.Textbox_Počáteční_rychlost.Size = New System.Drawing.Size(136, 24)
        Me.Textbox_Počáteční_rychlost.TabIndex = 11
        '
        'groupbox_stabilizace_strely_rotaci
        '
        Me.groupbox_stabilizace_strely_rotaci.Controls.Add(Me.label_koeficient_Sg)
        Me.groupbox_stabilizace_strely_rotaci.Controls.Add(Me.combobox_délka_střely)
        Me.groupbox_stabilizace_strely_rotaci.Controls.Add(Me.textbox_délka_střely)
        Me.groupbox_stabilizace_strely_rotaci.Controls.Add(Me.Label6)
        Me.groupbox_stabilizace_strely_rotaci.Controls.Add(Me.Label_6)
        Me.groupbox_stabilizace_strely_rotaci.Controls.Add(Me.label_nadmořská_výška)
        Me.groupbox_stabilizace_strely_rotaci.Controls.Add(Me.label_teplota_vzduchu)
        Me.groupbox_stabilizace_strely_rotaci.Controls.Add(Me.combobox_průměr_střely)
        Me.groupbox_stabilizace_strely_rotaci.Controls.Add(Me.textbox_průměr_střely)
        Me.groupbox_stabilizace_strely_rotaci.Controls.Add(Me.Label4)
        Me.groupbox_stabilizace_strely_rotaci.Controls.Add(Me.combobox_stoupání_drážek)
        Me.groupbox_stabilizace_strely_rotaci.Controls.Add(Me.textbox_stoupání_drážek)
        Me.groupbox_stabilizace_strely_rotaci.Controls.Add(Me.Label3)
        Me.groupbox_stabilizace_strely_rotaci.Controls.Add(Me.Label1)
        Me.groupbox_stabilizace_strely_rotaci.Controls.Add(Me.combobox_počáteční_rychlost)
        Me.groupbox_stabilizace_strely_rotaci.Controls.Add(Me.Textbox_Počáteční_rychlost)
        Me.groupbox_stabilizace_strely_rotaci.Controls.Add(Me.combobox_hmotnost_střely)
        Me.groupbox_stabilizace_strely_rotaci.Controls.Add(Me.Textbox_hmotnost)
        Me.groupbox_stabilizace_strely_rotaci.Controls.Add(Me.Label2)
        Me.groupbox_stabilizace_strely_rotaci.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.groupbox_stabilizace_strely_rotaci.Location = New System.Drawing.Point(12, 12)
        Me.groupbox_stabilizace_strely_rotaci.Name = "groupbox_stabilizace_strely_rotaci"
        Me.groupbox_stabilizace_strely_rotaci.Size = New System.Drawing.Size(511, 241)
        Me.groupbox_stabilizace_strely_rotaci.TabIndex = 16
        Me.groupbox_stabilizace_strely_rotaci.TabStop = False
        Me.groupbox_stabilizace_strely_rotaci.Text = "Bullet stabilization"
        '
        'label_koeficient_Sg
        '
        Me.label_koeficient_Sg.AutoSize = True
        Me.label_koeficient_Sg.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_koeficient_Sg.Location = New System.Drawing.Point(202, 196)
        Me.label_koeficient_Sg.Name = "label_koeficient_Sg"
        Me.label_koeficient_Sg.Size = New System.Drawing.Size(29, 31)
        Me.label_koeficient_Sg.TabIndex = 30
        Me.label_koeficient_Sg.Text = "0"
        '
        'combobox_délka_střely
        '
        Me.combobox_délka_střely.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_délka_střely.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_délka_střely.FormattingEnabled = True
        Me.combobox_délka_střely.Items.AddRange(New Object() {"mm", "in"})
        Me.combobox_délka_střely.Location = New System.Drawing.Point(406, 44)
        Me.combobox_délka_střely.Name = "combobox_délka_střely"
        Me.combobox_délka_střely.Size = New System.Drawing.Size(65, 24)
        Me.combobox_délka_střely.TabIndex = 29
        '
        'textbox_délka_střely
        '
        Me.textbox_délka_střely.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_délka_střely.Location = New System.Drawing.Point(264, 44)
        Me.textbox_délka_střely.Name = "textbox_délka_střely"
        Me.textbox_délka_střely.Size = New System.Drawing.Size(136, 24)
        Me.textbox_délka_střely.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.Location = New System.Drawing.Point(261, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 17)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Bullet length"
        '
        'Label_6
        '
        Me.Label_6.AutoSize = True
        Me.Label_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label_6.Location = New System.Drawing.Point(8, 196)
        Me.Label_6.Name = "Label_6"
        Me.Label_6.Size = New System.Drawing.Size(192, 31)
        Me.Label_6.TabIndex = 26
        Me.Label_6.Text = "Coefficient Sg:"
        '
        'label_nadmořská_výška
        '
        Me.label_nadmořská_výška.AutoSize = True
        Me.label_nadmořská_výška.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_nadmořská_výška.Location = New System.Drawing.Point(261, 160)
        Me.label_nadmořská_výška.Name = "label_nadmořská_výška"
        Me.label_nadmořská_výška.Size = New System.Drawing.Size(75, 17)
        Me.label_nadmořská_výška.TabIndex = 25
        Me.label_nadmořská_výška.Text = "Elevation"
        '
        'label_teplota_vzduchu
        '
        Me.label_teplota_vzduchu.AutoSize = True
        Me.label_teplota_vzduchu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_teplota_vzduchu.Location = New System.Drawing.Point(261, 132)
        Me.label_teplota_vzduchu.Name = "label_teplota_vzduchu"
        Me.label_teplota_vzduchu.Size = New System.Drawing.Size(121, 17)
        Me.label_teplota_vzduchu.TabIndex = 22
        Me.label_teplota_vzduchu.Text = "Air temperature"
        '
        'combobox_průměr_střely
        '
        Me.combobox_průměr_střely.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_průměr_střely.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_průměr_střely.FormattingEnabled = True
        Me.combobox_průměr_střely.Items.AddRange(New Object() {"mm", "in"})
        Me.combobox_průměr_střely.Location = New System.Drawing.Point(406, 100)
        Me.combobox_průměr_střely.Name = "combobox_průměr_střely"
        Me.combobox_průměr_střely.Size = New System.Drawing.Size(65, 24)
        Me.combobox_průměr_střely.TabIndex = 21
        '
        'textbox_průměr_střely
        '
        Me.textbox_průměr_střely.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_průměr_střely.Location = New System.Drawing.Point(264, 100)
        Me.textbox_průměr_střely.Name = "textbox_průměr_střely"
        Me.textbox_průměr_střely.Size = New System.Drawing.Size(136, 24)
        Me.textbox_průměr_střely.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(261, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Bullet diameter"
        '
        'combobox_stoupání_drážek
        '
        Me.combobox_stoupání_drážek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_stoupání_drážek.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_stoupání_drážek.FormattingEnabled = True
        Me.combobox_stoupání_drážek.Items.AddRange(New Object() {"mm", "in"})
        Me.combobox_stoupání_drážek.Location = New System.Drawing.Point(156, 154)
        Me.combobox_stoupání_drážek.Name = "combobox_stoupání_drážek"
        Me.combobox_stoupání_drážek.Size = New System.Drawing.Size(65, 24)
        Me.combobox_stoupání_drážek.TabIndex = 18
        '
        'textbox_stoupání_drážek
        '
        Me.textbox_stoupání_drážek.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_stoupání_drážek.Location = New System.Drawing.Point(14, 154)
        Me.textbox_stoupání_drážek.Name = "textbox_stoupání_drážek"
        Me.textbox_stoupání_drážek.Size = New System.Drawing.Size(136, 24)
        Me.textbox_stoupání_drážek.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Twist rate"
        '
        'button_spočítej_stabilizaci
        '
        Me.button_spočítej_stabilizaci.BackColor = System.Drawing.SystemColors.Window
        Me.button_spočítej_stabilizaci.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_spočítej_stabilizaci.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.button_spočítej_stabilizaci.Location = New System.Drawing.Point(12, 431)
        Me.button_spočítej_stabilizaci.Name = "button_spočítej_stabilizaci"
        Me.button_spočítej_stabilizaci.Size = New System.Drawing.Size(469, 64)
        Me.button_spočítej_stabilizaci.TabIndex = 17
        Me.button_spočítej_stabilizaci.Text = "Calculate"
        Me.button_spočítej_stabilizaci.UseVisualStyleBackColor = False
        '
        'groupbox_derivace
        '
        Me.groupbox_derivace.Controls.Add(Me.label_vzdálenost_cíle)
        Me.groupbox_derivace.Controls.Add(Me.combobox_smer_drazek)
        Me.groupbox_derivace.Controls.Add(Me.Label5)
        Me.groupbox_derivace.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.groupbox_derivace.Location = New System.Drawing.Point(529, 218)
        Me.groupbox_derivace.Name = "groupbox_derivace"
        Me.groupbox_derivace.Size = New System.Drawing.Size(427, 85)
        Me.groupbox_derivace.TabIndex = 17
        Me.groupbox_derivace.TabStop = False
        Me.groupbox_derivace.Text = "Spin drift"
        '
        'label_vzdálenost_cíle
        '
        Me.label_vzdálenost_cíle.AutoSize = True
        Me.label_vzdálenost_cíle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_vzdálenost_cíle.Location = New System.Drawing.Point(11, 55)
        Me.label_vzdálenost_cíle.Name = "label_vzdálenost_cíle"
        Me.label_vzdálenost_cíle.Size = New System.Drawing.Size(127, 17)
        Me.label_vzdálenost_cíle.TabIndex = 31
        Me.label_vzdálenost_cíle.Text = "Target distance:"
        '
        'combobox_smer_drazek
        '
        Me.combobox_smer_drazek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_smer_drazek.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_smer_drazek.FormattingEnabled = True
        Me.combobox_smer_drazek.Items.AddRange(New Object() {"Right-turn", "Left-turn"})
        Me.combobox_smer_drazek.Location = New System.Drawing.Point(126, 23)
        Me.combobox_smer_drazek.Name = "combobox_smer_drazek"
        Me.combobox_smer_drazek.Size = New System.Drawing.Size(118, 24)
        Me.combobox_smer_drazek.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 17)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Type od twist:"
        '
        'groupbox_coriolisuv_efekt
        '
        Me.groupbox_coriolisuv_efekt.Controls.Add(Me.combobox_zeměpisná_šířka)
        Me.groupbox_coriolisuv_efekt.Controls.Add(Me.radiobutton_S)
        Me.groupbox_coriolisuv_efekt.Controls.Add(Me.radiobutton_N)
        Me.groupbox_coriolisuv_efekt.Controls.Add(Me.textbox_zemepisna_sirka)
        Me.groupbox_coriolisuv_efekt.Controls.Add(Me.Label9)
        Me.groupbox_coriolisuv_efekt.Controls.Add(Me.Label8)
        Me.groupbox_coriolisuv_efekt.Controls.Add(Me.Label11)
        Me.groupbox_coriolisuv_efekt.Controls.Add(Me.radiobutton_SW)
        Me.groupbox_coriolisuv_efekt.Controls.Add(Me.radiobutton_SE)
        Me.groupbox_coriolisuv_efekt.Controls.Add(Me.combobox_polokoule)
        Me.groupbox_coriolisuv_efekt.Controls.Add(Me.radiobutton_NW)
        Me.groupbox_coriolisuv_efekt.Controls.Add(Me.radiobutton_W)
        Me.groupbox_coriolisuv_efekt.Controls.Add(Me.Label10)
        Me.groupbox_coriolisuv_efekt.Controls.Add(Me.radiobutton_NE)
        Me.groupbox_coriolisuv_efekt.Controls.Add(Me.radiobutton_E)
        Me.groupbox_coriolisuv_efekt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.groupbox_coriolisuv_efekt.Location = New System.Drawing.Point(529, 12)
        Me.groupbox_coriolisuv_efekt.Name = "groupbox_coriolisuv_efekt"
        Me.groupbox_coriolisuv_efekt.Size = New System.Drawing.Size(427, 200)
        Me.groupbox_coriolisuv_efekt.TabIndex = 18
        Me.groupbox_coriolisuv_efekt.TabStop = False
        Me.groupbox_coriolisuv_efekt.Text = "Coriolis effect"
        '
        'combobox_zeměpisná_šířka
        '
        Me.combobox_zeměpisná_šířka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_zeměpisná_šířka.Enabled = False
        Me.combobox_zeměpisná_šířka.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_zeměpisná_šířka.FormattingEnabled = True
        Me.combobox_zeměpisná_šířka.Items.AddRange(New Object() {"deg"})
        Me.combobox_zeměpisná_šířka.Location = New System.Drawing.Point(155, 163)
        Me.combobox_zeměpisná_šířka.Name = "combobox_zeměpisná_šířka"
        Me.combobox_zeměpisná_šířka.Size = New System.Drawing.Size(65, 24)
        Me.combobox_zeměpisná_šířka.TabIndex = 54
        '
        'radiobutton_S
        '
        Me.radiobutton_S.AutoSize = True
        Me.radiobutton_S.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.radiobutton_S.Location = New System.Drawing.Point(309, 166)
        Me.radiobutton_S.Name = "radiobutton_S"
        Me.radiobutton_S.Size = New System.Drawing.Size(35, 21)
        Me.radiobutton_S.TabIndex = 53
        Me.radiobutton_S.TabStop = True
        Me.radiobutton_S.Text = "S"
        Me.radiobutton_S.UseVisualStyleBackColor = True
        '
        'radiobutton_N
        '
        Me.radiobutton_N.AutoSize = True
        Me.radiobutton_N.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.radiobutton_N.Location = New System.Drawing.Point(309, 26)
        Me.radiobutton_N.Name = "radiobutton_N"
        Me.radiobutton_N.Size = New System.Drawing.Size(36, 21)
        Me.radiobutton_N.TabIndex = 52
        Me.radiobutton_N.TabStop = True
        Me.radiobutton_N.Text = "N"
        Me.radiobutton_N.UseVisualStyleBackColor = True
        '
        'textbox_zemepisna_sirka
        '
        Me.textbox_zemepisna_sirka.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_zemepisna_sirka.Location = New System.Drawing.Point(14, 163)
        Me.textbox_zemepisna_sirka.Name = "textbox_zemepisna_sirka"
        Me.textbox_zemepisna_sirka.Size = New System.Drawing.Size(135, 24)
        Me.textbox_zemepisna_sirka.TabIndex = 51
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(242, 54)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Shooting is guided in the direction:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(A black dot indicates the shooter's " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "posi" &
    "tion)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.Location = New System.Drawing.Point(296, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 63)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "•"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 143)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 17)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Latitude"
        '
        'radiobutton_SW
        '
        Me.radiobutton_SW.AutoSize = True
        Me.radiobutton_SW.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.radiobutton_SW.Location = New System.Drawing.Point(278, 135)
        Me.radiobutton_SW.Name = "radiobutton_SW"
        Me.radiobutton_SW.Size = New System.Drawing.Size(48, 21)
        Me.radiobutton_SW.TabIndex = 45
        Me.radiobutton_SW.TabStop = True
        Me.radiobutton_SW.Text = "SW"
        Me.radiobutton_SW.UseVisualStyleBackColor = True
        '
        'radiobutton_SE
        '
        Me.radiobutton_SE.AutoSize = True
        Me.radiobutton_SE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.radiobutton_SE.Location = New System.Drawing.Point(340, 135)
        Me.radiobutton_SE.Name = "radiobutton_SE"
        Me.radiobutton_SE.Size = New System.Drawing.Size(44, 21)
        Me.radiobutton_SE.TabIndex = 43
        Me.radiobutton_SE.TabStop = True
        Me.radiobutton_SE.Text = "SE"
        Me.radiobutton_SE.UseVisualStyleBackColor = True
        '
        'combobox_polokoule
        '
        Me.combobox_polokoule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_polokoule.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_polokoule.FormattingEnabled = True
        Me.combobox_polokoule.Items.AddRange(New Object() {"Northern", "Southern"})
        Me.combobox_polokoule.Location = New System.Drawing.Point(14, 110)
        Me.combobox_polokoule.Name = "combobox_polokoule"
        Me.combobox_polokoule.Size = New System.Drawing.Size(135, 24)
        Me.combobox_polokoule.TabIndex = 49
        '
        'radiobutton_NW
        '
        Me.radiobutton_NW.AutoSize = True
        Me.radiobutton_NW.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.radiobutton_NW.Location = New System.Drawing.Point(278, 57)
        Me.radiobutton_NW.Name = "radiobutton_NW"
        Me.radiobutton_NW.Size = New System.Drawing.Size(49, 21)
        Me.radiobutton_NW.TabIndex = 44
        Me.radiobutton_NW.TabStop = True
        Me.radiobutton_NW.Text = "NW"
        Me.radiobutton_NW.UseVisualStyleBackColor = True
        '
        'radiobutton_W
        '
        Me.radiobutton_W.AutoSize = True
        Me.radiobutton_W.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.radiobutton_W.Location = New System.Drawing.Point(247, 96)
        Me.radiobutton_W.Name = "radiobutton_W"
        Me.radiobutton_W.Size = New System.Drawing.Size(39, 21)
        Me.radiobutton_W.TabIndex = 41
        Me.radiobutton_W.TabStop = True
        Me.radiobutton_W.Text = "W"
        Me.radiobutton_W.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 89)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 17)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Hemisphere"
        '
        'radiobutton_NE
        '
        Me.radiobutton_NE.AutoSize = True
        Me.radiobutton_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.radiobutton_NE.Location = New System.Drawing.Point(340, 57)
        Me.radiobutton_NE.Name = "radiobutton_NE"
        Me.radiobutton_NE.Size = New System.Drawing.Size(45, 21)
        Me.radiobutton_NE.TabIndex = 40
        Me.radiobutton_NE.TabStop = True
        Me.radiobutton_NE.Text = "NE"
        Me.radiobutton_NE.UseVisualStyleBackColor = True
        '
        'radiobutton_E
        '
        Me.radiobutton_E.AutoSize = True
        Me.radiobutton_E.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.radiobutton_E.Location = New System.Drawing.Point(370, 96)
        Me.radiobutton_E.Name = "radiobutton_E"
        Me.radiobutton_E.Size = New System.Drawing.Size(35, 21)
        Me.radiobutton_E.TabIndex = 42
        Me.radiobutton_E.TabStop = True
        Me.radiobutton_E.Text = "E"
        Me.radiobutton_E.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.label_korekce_klikáním_výšková)
        Me.GroupBox5.Controls.Add(Me.label_korekce_přenášením_výšková)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(12, 347)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(511, 78)
        Me.GroupBox5.TabIndex = 39
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Vertical compensation"
        '
        'label_korekce_klikáním_výšková
        '
        Me.label_korekce_klikáním_výšková.AutoSize = True
        Me.label_korekce_klikáním_výšková.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_korekce_klikáním_výšková.Location = New System.Drawing.Point(6, 19)
        Me.label_korekce_klikáním_výšková.Name = "label_korekce_klikáním_výšková"
        Me.label_korekce_klikáním_výšková.Size = New System.Drawing.Size(182, 22)
        Me.label_korekce_klikáním_výšková.TabIndex = 37
        Me.label_korekce_klikáním_výšková.Text = "Scope compensation:"
        '
        'label_korekce_přenášením_výšková
        '
        Me.label_korekce_přenášením_výšková.AutoSize = True
        Me.label_korekce_přenášením_výšková.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_korekce_přenášením_výšková.Location = New System.Drawing.Point(6, 47)
        Me.label_korekce_přenášením_výšková.Name = "label_korekce_přenášením_výšková"
        Me.label_korekce_přenášením_výšková.Size = New System.Drawing.Size(172, 22)
        Me.label_korekce_přenášením_výšková.TabIndex = 36
        Me.label_korekce_přenášením_výšková.Text = "Sight compensation:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.label_korekce_klikáním_stranová)
        Me.GroupBox4.Controls.Add(Me.label_korekce_prenasenim_stranová)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 259)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(511, 82)
        Me.GroupBox4.TabIndex = 38
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Horizontal compensation"
        '
        'label_korekce_klikáním_stranová
        '
        Me.label_korekce_klikáním_stranová.AutoSize = True
        Me.label_korekce_klikáním_stranová.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_korekce_klikáním_stranová.Location = New System.Drawing.Point(6, 19)
        Me.label_korekce_klikáním_stranová.Name = "label_korekce_klikáním_stranová"
        Me.label_korekce_klikáním_stranová.Size = New System.Drawing.Size(182, 22)
        Me.label_korekce_klikáním_stranová.TabIndex = 35
        Me.label_korekce_klikáním_stranová.Text = "Scope compensation:"
        '
        'label_korekce_prenasenim_stranová
        '
        Me.label_korekce_prenasenim_stranová.AutoSize = True
        Me.label_korekce_prenasenim_stranová.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_korekce_prenasenim_stranová.Location = New System.Drawing.Point(6, 50)
        Me.label_korekce_prenasenim_stranová.Name = "label_korekce_prenasenim_stranová"
        Me.label_korekce_prenasenim_stranová.Size = New System.Drawing.Size(172, 22)
        Me.label_korekce_prenasenim_stranová.TabIndex = 34
        Me.label_korekce_prenasenim_stranová.Text = "Sight compensation:"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.checkbox_nacist_odchylky)
        Me.GroupBox7.Controls.Add(Me.checkbox_spocitat_coriolisuv_efekt)
        Me.GroupBox7.Controls.Add(Me.checkbox_spocitat_derivaci)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(529, 309)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(427, 116)
        Me.GroupBox7.TabIndex = 19
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Settings"
        '
        'checkbox_nacist_odchylky
        '
        Me.checkbox_nacist_odchylky.AutoSize = True
        Me.checkbox_nacist_odchylky.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_nacist_odchylky.Location = New System.Drawing.Point(6, 80)
        Me.checkbox_nacist_odchylky.Name = "checkbox_nacist_odchylky"
        Me.checkbox_nacist_odchylky.Size = New System.Drawing.Size(347, 26)
        Me.checkbox_nacist_odchylky.TabIndex = 3
        Me.checkbox_nacist_odchylky.Text = "Load compensations to main calculation"
        Me.checkbox_nacist_odchylky.UseVisualStyleBackColor = True
        '
        'checkbox_spocitat_coriolisuv_efekt
        '
        Me.checkbox_spocitat_coriolisuv_efekt.AutoSize = True
        Me.checkbox_spocitat_coriolisuv_efekt.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_spocitat_coriolisuv_efekt.Location = New System.Drawing.Point(6, 51)
        Me.checkbox_spocitat_coriolisuv_efekt.Name = "checkbox_spocitat_coriolisuv_efekt"
        Me.checkbox_spocitat_coriolisuv_efekt.Size = New System.Drawing.Size(218, 26)
        Me.checkbox_spocitat_coriolisuv_efekt.TabIndex = 2
        Me.checkbox_spocitat_coriolisuv_efekt.Text = "Calculate Coriolis effect"
        Me.checkbox_spocitat_coriolisuv_efekt.UseVisualStyleBackColor = True
        '
        'checkbox_spocitat_derivaci
        '
        Me.checkbox_spocitat_derivaci.AutoSize = True
        Me.checkbox_spocitat_derivaci.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_spocitat_derivaci.Location = New System.Drawing.Point(6, 22)
        Me.checkbox_spocitat_derivaci.Name = "checkbox_spocitat_derivaci"
        Me.checkbox_spocitat_derivaci.Size = New System.Drawing.Size(180, 26)
        Me.checkbox_spocitat_derivaci.TabIndex = 1
        Me.checkbox_spocitat_derivaci.Text = "Calculate Spin drift"
        Me.checkbox_spocitat_derivaci.UseVisualStyleBackColor = True
        '
        'Derivace_střely
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(967, 505)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.groupbox_coriolisuv_efekt)
        Me.Controls.Add(Me.groupbox_derivace)
        Me.Controls.Add(Me.groupbox_stabilizace_strely_rotaci)
        Me.Controls.Add(Me.button_zavřít)
        Me.Controls.Add(Me.button_spočítej_stabilizaci)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(983, 544)
        Me.MinimumSize = New System.Drawing.Size(983, 544)
        Me.Name = "Derivace_střely"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bullet stabilization, Spin drift and Coriolis effect"
        Me.groupbox_stabilizace_strely_rotaci.ResumeLayout(False)
        Me.groupbox_stabilizace_strely_rotaci.PerformLayout()
        Me.groupbox_derivace.ResumeLayout(False)
        Me.groupbox_derivace.PerformLayout()
        Me.groupbox_coriolisuv_efekt.ResumeLayout(False)
        Me.groupbox_coriolisuv_efekt.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents button_zavřít As Button
    Friend WithEvents combobox_počáteční_rychlost As ComboBox
    Friend WithEvents combobox_hmotnost_střely As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Textbox_hmotnost As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Textbox_Počáteční_rychlost As TextBox
    Friend WithEvents groupbox_stabilizace_strely_rotaci As GroupBox
    Friend WithEvents combobox_průměr_střely As ComboBox
    Friend WithEvents textbox_průměr_střely As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents combobox_stoupání_drážek As ComboBox
    Friend WithEvents textbox_stoupání_drážek As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents label_nadmořská_výška As Label
    Friend WithEvents label_teplota_vzduchu As Label
    Friend WithEvents button_spočítej_stabilizaci As Button
    Friend WithEvents Label_6 As Label
    Friend WithEvents combobox_délka_střely As ComboBox
    Friend WithEvents textbox_délka_střely As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents label_koeficient_Sg As Label
    Friend WithEvents groupbox_derivace As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents groupbox_coriolisuv_efekt As GroupBox
    Friend WithEvents combobox_smer_drazek As ComboBox
    Friend WithEvents label_vzdálenost_cíle As Label
    Friend WithEvents label_korekce_klikáním_stranová As Label
    Friend WithEvents label_korekce_prenasenim_stranová As Label
    Friend WithEvents label_korekce_přenášením_výšková As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents combobox_polokoule As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents radiobutton_SW As RadioButton
    Friend WithEvents radiobutton_SE As RadioButton
    Friend WithEvents radiobutton_NW As RadioButton
    Friend WithEvents radiobutton_W As RadioButton
    Friend WithEvents radiobutton_NE As RadioButton
    Friend WithEvents radiobutton_E As RadioButton
    Friend WithEvents textbox_zemepisna_sirka As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents radiobutton_S As RadioButton
    Friend WithEvents radiobutton_N As RadioButton
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents checkbox_spocitat_coriolisuv_efekt As CheckBox
    Friend WithEvents checkbox_spocitat_derivaci As CheckBox
    Friend WithEvents checkbox_nacist_odchylky As CheckBox
    Friend WithEvents combobox_zeměpisná_šířka As ComboBox
    Friend WithEvents label_korekce_klikáním_výšková As Label
End Class
