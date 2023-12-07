<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vedlejší_výpočty
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vedlejší_výpočty))
        Me.button_zavřít = New System.Windows.Forms.Button()
        Me.combobox_vzdálenost_cíle = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.textbox_vzdálenost_cíle = New System.Windows.Forms.TextBox()
        Me.label_předsazení_cíle = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Střelec = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.combobox_úhel_pohybu_cíle = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.textbox_úhel_pohybu_cíle = New System.Windows.Forms.TextBox()
        Me.combobox_doba_pohybu_střely = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.textbox_rychlost_cíle = New System.Windows.Forms.TextBox()
        Me.textbox_doba_pohybu_střely = New System.Windows.Forms.TextBox()
        Me.combobox_rychlost_cíle = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.checkbox_spocitat_predsazeni = New System.Windows.Forms.CheckBox()
        Me.checkbox_spocitat_aproximaci = New System.Windows.Forms.CheckBox()
        Me.button_spočítej = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.label_úsťová_rychlost = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radiobutton_revolver = New System.Windows.Forms.RadioButton()
        Me.radiobutton_puška = New System.Windows.Forms.RadioButton()
        Me.radiobutton_pistole = New System.Windows.Forms.RadioButton()
        Me.groupbox_základní_údaje = New System.Windows.Forms.GroupBox()
        Me.combobox_délka_nové_hlavně = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.textbox_délka_nové_hlavně = New System.Windows.Forms.TextBox()
        Me.combobox_délka_původní_hlavně = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textbox_původní_úsťová_rychlost = New System.Windows.Forms.TextBox()
        Me.textbox_délka_původní_hlavně = New System.Windows.Forms.TextBox()
        Me.combobox_původní_úsťová_rychlost = New System.Windows.Forms.ComboBox()
        Me.groupbox_rozměry_náboje = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.combobox_délka_střely = New System.Windows.Forms.ComboBox()
        Me.textbox_délka_střely = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.combobox_délka_náboje = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.combobox_průměr_střely = New System.Windows.Forms.ComboBox()
        Me.textbox_průměr_střely = New System.Windows.Forms.TextBox()
        Me.textbox_délka_náboje = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.combobox_délka_nábojnice = New System.Windows.Forms.ComboBox()
        Me.textbox_délka_nábojnice = New System.Windows.Forms.TextBox()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.groupbox_základní_údaje.SuspendLayout()
        Me.groupbox_rozměry_náboje.SuspendLayout()
        Me.SuspendLayout()
        '
        'button_zavřít
        '
        Me.button_zavřít.BackColor = System.Drawing.SystemColors.Window
        Me.button_zavřít.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_zavřít.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.button_zavřít.Location = New System.Drawing.Point(525, 446)
        Me.button_zavřít.Name = "button_zavřít"
        Me.button_zavřít.Size = New System.Drawing.Size(507, 60)
        Me.button_zavřít.TabIndex = 50
        Me.button_zavřít.Text = "Close"
        Me.button_zavřít.UseVisualStyleBackColor = False
        '
        'combobox_vzdálenost_cíle
        '
        Me.combobox_vzdálenost_cíle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_vzdálenost_cíle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_vzdálenost_cíle.FormattingEnabled = True
        Me.combobox_vzdálenost_cíle.Items.AddRange(New Object() {"m", "yd", "ft"})
        Me.combobox_vzdálenost_cíle.Location = New System.Drawing.Point(152, 106)
        Me.combobox_vzdálenost_cíle.Name = "combobox_vzdálenost_cíle"
        Me.combobox_vzdálenost_cíle.Size = New System.Drawing.Size(65, 24)
        Me.combobox_vzdálenost_cíle.TabIndex = 64
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label24.Location = New System.Drawing.Point(13, 86)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(107, 17)
        Me.Label24.TabIndex = 62
        Me.Label24.Text = "Target distance"
        '
        'textbox_vzdálenost_cíle
        '
        Me.textbox_vzdálenost_cíle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_vzdálenost_cíle.Location = New System.Drawing.Point(16, 106)
        Me.textbox_vzdálenost_cíle.Name = "textbox_vzdálenost_cíle"
        Me.textbox_vzdálenost_cíle.Size = New System.Drawing.Size(130, 24)
        Me.textbox_vzdálenost_cíle.TabIndex = 63
        '
        'label_předsazení_cíle
        '
        Me.label_předsazení_cíle.AutoSize = True
        Me.label_předsazení_cíle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_předsazení_cíle.Location = New System.Drawing.Point(11, 267)
        Me.label_předsazení_cíle.Name = "label_předsazení_cíle"
        Me.label_předsazení_cíle.Size = New System.Drawing.Size(143, 29)
        Me.label_předsazení_cíle.TabIndex = 0
        Me.label_předsazení_cíle.Text = "Target lead:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label22.Location = New System.Drawing.Point(290, 71)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(33, 18)
        Me.Label22.TabIndex = 55
        Me.Label22.Text = "45°"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(413, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 18)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "45°"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label21.Location = New System.Drawing.Point(257, 118)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(33, 18)
        Me.Label21.TabIndex = 53
        Me.Label21.Text = "90°"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label20.Location = New System.Drawing.Point(281, 106)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(41, 39)
        Me.Label20.TabIndex = 52
        Me.Label20.Text = "◄"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label19.Location = New System.Drawing.Point(452, 118)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(33, 18)
        Me.Label19.TabIndex = 51
        Me.Label19.Text = "90°"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label18.Location = New System.Drawing.Point(340, 139)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 18)
        Me.Label18.TabIndex = 50
        Me.Label18.Text = "Target"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label17.Location = New System.Drawing.Point(414, 106)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 39)
        Me.Label17.TabIndex = 49
        Me.Label17.Text = "►"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label16.Location = New System.Drawing.Point(358, 39)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(24, 18)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "0°"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.combobox_vzdálenost_cíle)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.textbox_vzdálenost_cíle)
        Me.GroupBox3.Controls.Add(Me.label_předsazení_cíle)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Střelec)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.combobox_úhel_pohybu_cíle)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.textbox_úhel_pohybu_cíle)
        Me.GroupBox3.Controls.Add(Me.combobox_doba_pohybu_střely)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.textbox_rychlost_cíle)
        Me.GroupBox3.Controls.Add(Me.textbox_doba_pohybu_střely)
        Me.GroupBox3.Controls.Add(Me.combobox_rychlost_cíle)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(525, 11)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(507, 308)
        Me.GroupBox3.TabIndex = 51
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Moving target lead"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label15.Location = New System.Drawing.Point(353, 57)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(28, 26)
        Me.Label15.TabIndex = 47
        Me.Label15.Text = "▲"
        '
        'Střelec
        '
        Me.Střelec.AutoSize = True
        Me.Střelec.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Střelec.Location = New System.Drawing.Point(334, 225)
        Me.Střelec.Name = "Střelec"
        Me.Střelec.Size = New System.Drawing.Size(68, 18)
        Me.Střelec.TabIndex = 46
        Me.Střelec.Text = "Shooter"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label14.Location = New System.Drawing.Point(349, 106)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 39)
        Me.Label14.TabIndex = 45
        Me.Label14.Text = "●"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label10.Location = New System.Drawing.Point(349, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 39)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "●"
        '
        'combobox_úhel_pohybu_cíle
        '
        Me.combobox_úhel_pohybu_cíle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_úhel_pohybu_cíle.Enabled = False
        Me.combobox_úhel_pohybu_cíle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_úhel_pohybu_cíle.FormattingEnabled = True
        Me.combobox_úhel_pohybu_cíle.Items.AddRange(New Object() {"deg"})
        Me.combobox_úhel_pohybu_cíle.Location = New System.Drawing.Point(152, 218)
        Me.combobox_úhel_pohybu_cíle.Name = "combobox_úhel_pohybu_cíle"
        Me.combobox_úhel_pohybu_cíle.Size = New System.Drawing.Size(65, 24)
        Me.combobox_úhel_pohybu_cíle.TabIndex = 43
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 198)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(170, 17)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Angle of target movement"
        '
        'textbox_úhel_pohybu_cíle
        '
        Me.textbox_úhel_pohybu_cíle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_úhel_pohybu_cíle.Location = New System.Drawing.Point(16, 218)
        Me.textbox_úhel_pohybu_cíle.Name = "textbox_úhel_pohybu_cíle"
        Me.textbox_úhel_pohybu_cíle.Size = New System.Drawing.Size(130, 24)
        Me.textbox_úhel_pohybu_cíle.TabIndex = 42
        '
        'combobox_doba_pohybu_střely
        '
        Me.combobox_doba_pohybu_střely.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_doba_pohybu_střely.Enabled = False
        Me.combobox_doba_pohybu_střely.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_doba_pohybu_střely.FormattingEnabled = True
        Me.combobox_doba_pohybu_střely.Items.AddRange(New Object() {"sec"})
        Me.combobox_doba_pohybu_střely.Location = New System.Drawing.Point(152, 162)
        Me.combobox_doba_pohybu_střely.Name = "combobox_doba_pohybu_střely"
        Me.combobox_doba_pohybu_střely.Size = New System.Drawing.Size(65, 24)
        Me.combobox_doba_pohybu_střely.TabIndex = 40
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label12.Location = New System.Drawing.Point(13, 142)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(127, 17)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Time of bullet flight"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label13.Location = New System.Drawing.Point(13, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 17)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Target speed"
        '
        'textbox_rychlost_cíle
        '
        Me.textbox_rychlost_cíle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_rychlost_cíle.Location = New System.Drawing.Point(16, 50)
        Me.textbox_rychlost_cíle.Name = "textbox_rychlost_cíle"
        Me.textbox_rychlost_cíle.Size = New System.Drawing.Size(130, 24)
        Me.textbox_rychlost_cíle.TabIndex = 36
        '
        'textbox_doba_pohybu_střely
        '
        Me.textbox_doba_pohybu_střely.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_doba_pohybu_střely.Location = New System.Drawing.Point(16, 162)
        Me.textbox_doba_pohybu_střely.Name = "textbox_doba_pohybu_střely"
        Me.textbox_doba_pohybu_střely.Size = New System.Drawing.Size(130, 24)
        Me.textbox_doba_pohybu_střely.TabIndex = 39
        '
        'combobox_rychlost_cíle
        '
        Me.combobox_rychlost_cíle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_rychlost_cíle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_rychlost_cíle.FormattingEnabled = True
        Me.combobox_rychlost_cíle.Items.AddRange(New Object() {"km/h", "mph", "m/s", "fps"})
        Me.combobox_rychlost_cíle.Location = New System.Drawing.Point(152, 50)
        Me.combobox_rychlost_cíle.Name = "combobox_rychlost_cíle"
        Me.combobox_rychlost_cíle.Size = New System.Drawing.Size(65, 24)
        Me.combobox_rychlost_cíle.TabIndex = 37
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.checkbox_spocitat_predsazeni)
        Me.GroupBox4.Controls.Add(Me.checkbox_spocitat_aproximaci)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(525, 325)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(507, 87)
        Me.GroupBox4.TabIndex = 52
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Settings"
        '
        'checkbox_spocitat_predsazeni
        '
        Me.checkbox_spocitat_predsazeni.AutoSize = True
        Me.checkbox_spocitat_predsazeni.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_spocitat_predsazeni.Location = New System.Drawing.Point(11, 55)
        Me.checkbox_spocitat_predsazeni.Name = "checkbox_spocitat_predsazeni"
        Me.checkbox_spocitat_predsazeni.Size = New System.Drawing.Size(256, 26)
        Me.checkbox_spocitat_predsazeni.TabIndex = 3
        Me.checkbox_spocitat_predsazeni.Text = "Calculate moving target lead"
        Me.checkbox_spocitat_predsazeni.UseVisualStyleBackColor = True
        '
        'checkbox_spocitat_aproximaci
        '
        Me.checkbox_spocitat_aproximaci.AutoSize = True
        Me.checkbox_spocitat_aproximaci.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_spocitat_aproximaci.Location = New System.Drawing.Point(11, 23)
        Me.checkbox_spocitat_aproximaci.Name = "checkbox_spocitat_aproximaci"
        Me.checkbox_spocitat_aproximaci.Size = New System.Drawing.Size(345, 26)
        Me.checkbox_spocitat_aproximaci.TabIndex = 2
        Me.checkbox_spocitat_aproximaci.Text = "Calculate muzzle velocity approximation"
        Me.checkbox_spocitat_aproximaci.UseVisualStyleBackColor = True
        '
        'button_spočítej
        '
        Me.button_spočítej.BackColor = System.Drawing.SystemColors.Window
        Me.button_spočítej.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_spočítej.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.button_spočítej.Location = New System.Drawing.Point(12, 446)
        Me.button_spočítej.Name = "button_spočítej"
        Me.button_spočítej.Size = New System.Drawing.Size(507, 60)
        Me.button_spočítej.TabIndex = 49
        Me.button_spočítej.Text = "Calculate"
        Me.button_spočítej.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.label_úsťová_rychlost)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.groupbox_základní_údaje)
        Me.GroupBox1.Controls.Add(Me.groupbox_rozměry_náboje)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(507, 429)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Muzzle velocity approximation relative to the barrel length"
        '
        'label_úsťová_rychlost
        '
        Me.label_úsťová_rychlost.AutoSize = True
        Me.label_úsťová_rychlost.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_úsťová_rychlost.Location = New System.Drawing.Point(6, 391)
        Me.label_úsťová_rychlost.Name = "label_úsťová_rychlost"
        Me.label_úsťová_rychlost.Size = New System.Drawing.Size(186, 29)
        Me.label_úsťová_rychlost.TabIndex = 0
        Me.label_úsťová_rychlost.Text = "Muzzle velocity: "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radiobutton_revolver)
        Me.GroupBox2.Controls.Add(Me.radiobutton_puška)
        Me.GroupBox2.Controls.Add(Me.radiobutton_pistole)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(484, 63)
        Me.GroupBox2.TabIndex = 45
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Firearm details"
        '
        'radiobutton_revolver
        '
        Me.radiobutton_revolver.AutoSize = True
        Me.radiobutton_revolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.radiobutton_revolver.Location = New System.Drawing.Point(386, 26)
        Me.radiobutton_revolver.Name = "radiobutton_revolver"
        Me.radiobutton_revolver.Size = New System.Drawing.Size(84, 22)
        Me.radiobutton_revolver.TabIndex = 2
        Me.radiobutton_revolver.TabStop = True
        Me.radiobutton_revolver.Text = "Revolver"
        Me.radiobutton_revolver.UseVisualStyleBackColor = True
        '
        'radiobutton_puška
        '
        Me.radiobutton_puška.AutoSize = True
        Me.radiobutton_puška.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.radiobutton_puška.Location = New System.Drawing.Point(11, 26)
        Me.radiobutton_puška.Name = "radiobutton_puška"
        Me.radiobutton_puška.Size = New System.Drawing.Size(55, 22)
        Me.radiobutton_puška.TabIndex = 1
        Me.radiobutton_puška.TabStop = True
        Me.radiobutton_puška.Text = "Rifle"
        Me.radiobutton_puška.UseVisualStyleBackColor = True
        '
        'radiobutton_pistole
        '
        Me.radiobutton_pistole.AutoSize = True
        Me.radiobutton_pistole.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.radiobutton_pistole.Location = New System.Drawing.Point(200, 26)
        Me.radiobutton_pistole.Name = "radiobutton_pistole"
        Me.radiobutton_pistole.Size = New System.Drawing.Size(63, 22)
        Me.radiobutton_pistole.TabIndex = 0
        Me.radiobutton_pistole.TabStop = True
        Me.radiobutton_pistole.Text = "Pistol"
        Me.radiobutton_pistole.UseVisualStyleBackColor = True
        '
        'groupbox_základní_údaje
        '
        Me.groupbox_základní_údaje.Controls.Add(Me.combobox_délka_nové_hlavně)
        Me.groupbox_základní_údaje.Controls.Add(Me.Label6)
        Me.groupbox_základní_údaje.Controls.Add(Me.textbox_délka_nové_hlavně)
        Me.groupbox_základní_údaje.Controls.Add(Me.combobox_délka_původní_hlavně)
        Me.groupbox_základní_údaje.Controls.Add(Me.Label4)
        Me.groupbox_základní_údaje.Controls.Add(Me.Label1)
        Me.groupbox_základní_údaje.Controls.Add(Me.textbox_původní_úsťová_rychlost)
        Me.groupbox_základní_údaje.Controls.Add(Me.textbox_délka_původní_hlavně)
        Me.groupbox_základní_údaje.Controls.Add(Me.combobox_původní_úsťová_rychlost)
        Me.groupbox_základní_údaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.groupbox_základní_údaje.Location = New System.Drawing.Point(11, 95)
        Me.groupbox_základní_údaje.Name = "groupbox_základní_údaje"
        Me.groupbox_základní_údaje.Size = New System.Drawing.Size(484, 139)
        Me.groupbox_základní_údaje.TabIndex = 44
        Me.groupbox_základní_údaje.TabStop = False
        Me.groupbox_základní_údaje.Text = "Basic data"
        '
        'combobox_délka_nové_hlavně
        '
        Me.combobox_délka_nové_hlavně.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_délka_nové_hlavně.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_délka_nové_hlavně.FormattingEnabled = True
        Me.combobox_délka_nové_hlavně.Items.AddRange(New Object() {"cm", "mm", "in"})
        Me.combobox_délka_nové_hlavně.Location = New System.Drawing.Point(403, 100)
        Me.combobox_délka_nové_hlavně.Name = "combobox_délka_nové_hlavně"
        Me.combobox_délka_nové_hlavně.Size = New System.Drawing.Size(65, 24)
        Me.combobox_délka_nové_hlavně.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.Location = New System.Drawing.Point(264, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "New barrel length"
        '
        'textbox_délka_nové_hlavně
        '
        Me.textbox_délka_nové_hlavně.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_délka_nové_hlavně.Location = New System.Drawing.Point(267, 100)
        Me.textbox_délka_nové_hlavně.Name = "textbox_délka_nové_hlavně"
        Me.textbox_délka_nové_hlavně.Size = New System.Drawing.Size(130, 24)
        Me.textbox_délka_nové_hlavně.TabIndex = 20
        '
        'combobox_délka_původní_hlavně
        '
        Me.combobox_délka_původní_hlavně.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_délka_původní_hlavně.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_délka_původní_hlavně.FormattingEnabled = True
        Me.combobox_délka_původní_hlavně.Items.AddRange(New Object() {"cm", "mm", "in"})
        Me.combobox_délka_původní_hlavně.Location = New System.Drawing.Point(403, 44)
        Me.combobox_délka_původní_hlavně.Name = "combobox_délka_původní_hlavně"
        Me.combobox_délka_původní_hlavně.Size = New System.Drawing.Size(65, 24)
        Me.combobox_délka_původní_hlavně.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(264, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Original barrel length"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Muzzle velocity"
        '
        'textbox_původní_úsťová_rychlost
        '
        Me.textbox_původní_úsťová_rychlost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_původní_úsťová_rychlost.Location = New System.Drawing.Point(14, 44)
        Me.textbox_původní_úsťová_rychlost.Name = "textbox_původní_úsťová_rychlost"
        Me.textbox_původní_úsťová_rychlost.Size = New System.Drawing.Size(130, 24)
        Me.textbox_původní_úsťová_rychlost.TabIndex = 3
        '
        'textbox_délka_původní_hlavně
        '
        Me.textbox_délka_původní_hlavně.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_délka_původní_hlavně.Location = New System.Drawing.Point(267, 44)
        Me.textbox_délka_původní_hlavně.Name = "textbox_délka_původní_hlavně"
        Me.textbox_délka_původní_hlavně.Size = New System.Drawing.Size(130, 24)
        Me.textbox_délka_původní_hlavně.TabIndex = 17
        '
        'combobox_původní_úsťová_rychlost
        '
        Me.combobox_původní_úsťová_rychlost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_původní_úsťová_rychlost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_původní_úsťová_rychlost.FormattingEnabled = True
        Me.combobox_původní_úsťová_rychlost.Items.AddRange(New Object() {"m/s", "fps"})
        Me.combobox_původní_úsťová_rychlost.Location = New System.Drawing.Point(150, 44)
        Me.combobox_původní_úsťová_rychlost.Name = "combobox_původní_úsťová_rychlost"
        Me.combobox_původní_úsťová_rychlost.Size = New System.Drawing.Size(65, 24)
        Me.combobox_původní_úsťová_rychlost.TabIndex = 9
        '
        'groupbox_rozměry_náboje
        '
        Me.groupbox_rozměry_náboje.Controls.Add(Me.Label11)
        Me.groupbox_rozměry_náboje.Controls.Add(Me.combobox_délka_střely)
        Me.groupbox_rozměry_náboje.Controls.Add(Me.textbox_délka_střely)
        Me.groupbox_rozměry_náboje.Controls.Add(Me.Label8)
        Me.groupbox_rozměry_náboje.Controls.Add(Me.combobox_délka_náboje)
        Me.groupbox_rozměry_náboje.Controls.Add(Me.Label7)
        Me.groupbox_rozměry_náboje.Controls.Add(Me.combobox_průměr_střely)
        Me.groupbox_rozměry_náboje.Controls.Add(Me.textbox_průměr_střely)
        Me.groupbox_rozměry_náboje.Controls.Add(Me.textbox_délka_náboje)
        Me.groupbox_rozměry_náboje.Controls.Add(Me.Label3)
        Me.groupbox_rozměry_náboje.Controls.Add(Me.combobox_délka_nábojnice)
        Me.groupbox_rozměry_náboje.Controls.Add(Me.textbox_délka_nábojnice)
        Me.groupbox_rozměry_náboje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.groupbox_rozměry_náboje.Location = New System.Drawing.Point(11, 240)
        Me.groupbox_rozměry_náboje.Name = "groupbox_rozměry_náboje"
        Me.groupbox_rozměry_náboje.Size = New System.Drawing.Size(484, 140)
        Me.groupbox_rozměry_náboje.TabIndex = 25
        Me.groupbox_rozměry_náboje.TabStop = False
        Me.groupbox_rozměry_náboje.Text = "Cartridge dimensions"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label11.Location = New System.Drawing.Point(264, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 17)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Bullet length"
        '
        'combobox_délka_střely
        '
        Me.combobox_délka_střely.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_délka_střely.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_délka_střely.FormattingEnabled = True
        Me.combobox_délka_střely.Items.AddRange(New Object() {"mm", "in"})
        Me.combobox_délka_střely.Location = New System.Drawing.Point(403, 100)
        Me.combobox_délka_střely.Name = "combobox_délka_střely"
        Me.combobox_délka_střely.Size = New System.Drawing.Size(65, 24)
        Me.combobox_délka_střely.TabIndex = 38
        '
        'textbox_délka_střely
        '
        Me.textbox_délka_střely.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_délka_střely.Location = New System.Drawing.Point(267, 100)
        Me.textbox_délka_střely.Name = "textbox_délka_střely"
        Me.textbox_délka_střely.Size = New System.Drawing.Size(130, 24)
        Me.textbox_délka_střely.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 17)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Cartridge length"
        '
        'combobox_délka_náboje
        '
        Me.combobox_délka_náboje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_délka_náboje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_délka_náboje.FormattingEnabled = True
        Me.combobox_délka_náboje.Items.AddRange(New Object() {"mm", "in"})
        Me.combobox_délka_náboje.Location = New System.Drawing.Point(150, 44)
        Me.combobox_délka_náboje.Name = "combobox_délka_náboje"
        Me.combobox_délka_náboje.Size = New System.Drawing.Size(65, 24)
        Me.combobox_délka_náboje.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.Location = New System.Drawing.Point(264, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 17)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Bullet diameter"
        '
        'combobox_průměr_střely
        '
        Me.combobox_průměr_střely.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_průměr_střely.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_průměr_střely.FormattingEnabled = True
        Me.combobox_průměr_střely.Items.AddRange(New Object() {"mm", "in"})
        Me.combobox_průměr_střely.Location = New System.Drawing.Point(403, 44)
        Me.combobox_průměr_střely.Name = "combobox_průměr_střely"
        Me.combobox_průměr_střely.Size = New System.Drawing.Size(65, 24)
        Me.combobox_průměr_střely.TabIndex = 27
        '
        'textbox_průměr_střely
        '
        Me.textbox_průměr_střely.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_průměr_střely.Location = New System.Drawing.Point(267, 44)
        Me.textbox_průměr_střely.Name = "textbox_průměr_střely"
        Me.textbox_průměr_střely.Size = New System.Drawing.Size(130, 24)
        Me.textbox_průměr_střely.TabIndex = 26
        '
        'textbox_délka_náboje
        '
        Me.textbox_délka_náboje.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_délka_náboje.Location = New System.Drawing.Point(14, 44)
        Me.textbox_délka_náboje.Name = "textbox_délka_náboje"
        Me.textbox_délka_náboje.Size = New System.Drawing.Size(130, 24)
        Me.textbox_délka_náboje.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 17)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Cartridge case length"
        '
        'combobox_délka_nábojnice
        '
        Me.combobox_délka_nábojnice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_délka_nábojnice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_délka_nábojnice.FormattingEnabled = True
        Me.combobox_délka_nábojnice.Items.AddRange(New Object() {"mm", "in"})
        Me.combobox_délka_nábojnice.Location = New System.Drawing.Point(150, 100)
        Me.combobox_délka_nábojnice.Name = "combobox_délka_nábojnice"
        Me.combobox_délka_nábojnice.Size = New System.Drawing.Size(65, 24)
        Me.combobox_délka_nábojnice.TabIndex = 24
        '
        'textbox_délka_nábojnice
        '
        Me.textbox_délka_nábojnice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_délka_nábojnice.Location = New System.Drawing.Point(14, 100)
        Me.textbox_délka_nábojnice.Name = "textbox_délka_nábojnice"
        Me.textbox_délka_nábojnice.Size = New System.Drawing.Size(130, 24)
        Me.textbox_délka_nábojnice.TabIndex = 23
        '
        'Vedlejší_výpočty
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1044, 516)
        Me.ControlBox = False
        Me.Controls.Add(Me.button_zavřít)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.button_spočítej)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1060, 555)
        Me.MinimumSize = New System.Drawing.Size(1060, 555)
        Me.Name = "Vedlejší_výpočty"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Secondary calculations"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.groupbox_základní_údaje.ResumeLayout(False)
        Me.groupbox_základní_údaje.PerformLayout()
        Me.groupbox_rozměry_náboje.ResumeLayout(False)
        Me.groupbox_rozměry_náboje.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents button_zavřít As Button
    Friend WithEvents combobox_vzdálenost_cíle As ComboBox
    Friend WithEvents Label24 As Label
    Friend WithEvents textbox_vzdálenost_cíle As TextBox
    Friend WithEvents label_předsazení_cíle As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Střelec As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents combobox_úhel_pohybu_cíle As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents textbox_úhel_pohybu_cíle As TextBox
    Friend WithEvents combobox_doba_pohybu_střely As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents textbox_rychlost_cíle As TextBox
    Friend WithEvents textbox_doba_pohybu_střely As TextBox
    Friend WithEvents combobox_rychlost_cíle As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents checkbox_spocitat_predsazeni As CheckBox
    Friend WithEvents checkbox_spocitat_aproximaci As CheckBox
    Friend WithEvents button_spočítej As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents label_úsťová_rychlost As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radiobutton_revolver As RadioButton
    Friend WithEvents radiobutton_puška As RadioButton
    Friend WithEvents radiobutton_pistole As RadioButton
    Friend WithEvents groupbox_základní_údaje As GroupBox
    Friend WithEvents combobox_délka_nové_hlavně As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents textbox_délka_nové_hlavně As TextBox
    Friend WithEvents combobox_délka_původní_hlavně As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents textbox_původní_úsťová_rychlost As TextBox
    Friend WithEvents textbox_délka_původní_hlavně As TextBox
    Friend WithEvents combobox_původní_úsťová_rychlost As ComboBox
    Friend WithEvents groupbox_rozměry_náboje As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents combobox_délka_střely As ComboBox
    Friend WithEvents textbox_délka_střely As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents combobox_délka_náboje As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents combobox_průměr_střely As ComboBox
    Friend WithEvents textbox_průměr_střely As TextBox
    Friend WithEvents textbox_délka_náboje As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents combobox_délka_nábojnice As ComboBox
    Friend WithEvents textbox_délka_nábojnice As TextBox
End Class
