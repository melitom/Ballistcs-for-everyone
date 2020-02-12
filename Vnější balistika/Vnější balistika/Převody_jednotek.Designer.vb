<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Převody_jednotek
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Převody_jednotek))
        Me.button_zavřít = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.label_mach = New System.Windows.Forms.Label()
        Me.label_mph = New System.Windows.Forms.Label()
        Me.label_kmh = New System.Windows.Forms.Label()
        Me.label_fps = New System.Windows.Forms.Label()
        Me.label_mps = New System.Windows.Forms.Label()
        Me.combobox_jednotky_rychlosti = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.textbox_jednotky_rychlosti = New System.Windows.Forms.TextBox()
        Me.button_spočítej = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.label_ounce = New System.Windows.Forms.Label()
        Me.label_lb = New System.Windows.Forms.Label()
        Me.label_kg = New System.Windows.Forms.Label()
        Me.label_grs = New System.Windows.Forms.Label()
        Me.label_g = New System.Windows.Forms.Label()
        Me.combobox_jednotky_hmotnosti = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.textbox_jednotky_hmotnosti = New System.Windows.Forms.TextBox()
        Me.groupbox3 = New System.Windows.Forms.GroupBox()
        Me.label_mile = New System.Windows.Forms.Label()
        Me.label_km = New System.Windows.Forms.Label()
        Me.label_yard = New System.Windows.Forms.Label()
        Me.label_ft = New System.Windows.Forms.Label()
        Me.label_m = New System.Windows.Forms.Label()
        Me.label_inch = New System.Windows.Forms.Label()
        Me.label_mm = New System.Windows.Forms.Label()
        Me.combobox_jednotky_délky = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.textbox_jednotky_délky = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.combobox_zaokrouhleni = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.label_MOA = New System.Windows.Forms.Label()
        Me.label_MRAD = New System.Windows.Forms.Label()
        Me.label_stupne_uhlu = New System.Windows.Forms.Label()
        Me.combobox_jednotky_uhel = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.textbox_jednotky_uhel = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.label_energie_foot_pounds = New System.Windows.Forms.Label()
        Me.label_energie_jouly = New System.Windows.Forms.Label()
        Me.combobox_jednotky_energie = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.textbox_jednotky_energie = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.groupbox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'button_zavřít
        '
        Me.button_zavřít.BackColor = System.Drawing.SystemColors.Window
        Me.button_zavřít.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_zavřít.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.button_zavřít.Location = New System.Drawing.Point(502, 569)
        Me.button_zavřít.Name = "button_zavřít"
        Me.button_zavřít.Size = New System.Drawing.Size(484, 63)
        Me.button_zavřít.TabIndex = 21
        Me.button_zavřít.Text = "Close"
        Me.button_zavřít.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.label_mach)
        Me.GroupBox2.Controls.Add(Me.label_mph)
        Me.GroupBox2.Controls.Add(Me.label_kmh)
        Me.GroupBox2.Controls.Add(Me.label_fps)
        Me.GroupBox2.Controls.Add(Me.label_mps)
        Me.GroupBox2.Controls.Add(Me.combobox_jednotky_rychlosti)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.textbox_jednotky_rychlosti)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(484, 211)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Velocity units"
        '
        'label_mach
        '
        Me.label_mach.AutoSize = True
        Me.label_mach.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_mach.Location = New System.Drawing.Point(7, 183)
        Me.label_mach.Name = "label_mach"
        Me.label_mach.Size = New System.Drawing.Size(265, 18)
        Me.label_mach.TabIndex = 20
        Me.label_mach.Text = "Velocity: 0 mach (speed of sound)"
        '
        'label_mph
        '
        Me.label_mph.AutoSize = True
        Me.label_mph.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_mph.Location = New System.Drawing.Point(7, 158)
        Me.label_mph.Name = "label_mph"
        Me.label_mph.Size = New System.Drawing.Size(248, 18)
        Me.label_mph.TabIndex = 19
        Me.label_mph.Text = "Velocity: 0 mph (miles per hour)"
        '
        'label_kmh
        '
        Me.label_kmh.AutoSize = True
        Me.label_kmh.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_kmh.Location = New System.Drawing.Point(7, 133)
        Me.label_kmh.Name = "label_kmh"
        Me.label_kmh.Size = New System.Drawing.Size(292, 18)
        Me.label_kmh.TabIndex = 18
        Me.label_kmh.Text = "Velocity: 0 km/h (kilometers per hour)"
        '
        'label_fps
        '
        Me.label_fps.AutoSize = True
        Me.label_fps.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_fps.Location = New System.Drawing.Point(7, 108)
        Me.label_fps.Name = "label_fps"
        Me.label_fps.Size = New System.Drawing.Size(248, 18)
        Me.label_fps.TabIndex = 17
        Me.label_fps.Text = "Velocity: 0 fps (feet per second)"
        '
        'label_mps
        '
        Me.label_mps.AutoSize = True
        Me.label_mps.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_mps.Location = New System.Drawing.Point(7, 83)
        Me.label_mps.Name = "label_mps"
        Me.label_mps.Size = New System.Drawing.Size(277, 18)
        Me.label_mps.TabIndex = 16
        Me.label_mps.Text = "Velocity: 0 m/s (meters per second)"
        '
        'combobox_jednotky_rychlosti
        '
        Me.combobox_jednotky_rychlosti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_jednotky_rychlosti.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_jednotky_rychlosti.FormattingEnabled = True
        Me.combobox_jednotky_rychlosti.Items.AddRange(New Object() {"m/s", "fps", "km/h", "mph", "mach"})
        Me.combobox_jednotky_rychlosti.Location = New System.Drawing.Point(245, 48)
        Me.combobox_jednotky_rychlosti.Name = "combobox_jednotky_rychlosti"
        Me.combobox_jednotky_rychlosti.Size = New System.Drawing.Size(100, 26)
        Me.combobox_jednotky_rychlosti.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 18)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Velocity"
        '
        'textbox_jednotky_rychlosti
        '
        Me.textbox_jednotky_rychlosti.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_jednotky_rychlosti.Location = New System.Drawing.Point(9, 49)
        Me.textbox_jednotky_rychlosti.Name = "textbox_jednotky_rychlosti"
        Me.textbox_jednotky_rychlosti.Size = New System.Drawing.Size(230, 24)
        Me.textbox_jednotky_rychlosti.TabIndex = 14
        '
        'button_spočítej
        '
        Me.button_spočítej.BackColor = System.Drawing.SystemColors.Window
        Me.button_spočítej.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_spočítej.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.button_spočítej.Location = New System.Drawing.Point(12, 569)
        Me.button_spočítej.Name = "button_spočítej"
        Me.button_spočítej.Size = New System.Drawing.Size(484, 63)
        Me.button_spočítej.TabIndex = 25
        Me.button_spočítej.Text = "Calculate"
        Me.button_spočítej.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.label_ounce)
        Me.GroupBox1.Controls.Add(Me.label_lb)
        Me.GroupBox1.Controls.Add(Me.label_kg)
        Me.GroupBox1.Controls.Add(Me.label_grs)
        Me.GroupBox1.Controls.Add(Me.label_g)
        Me.GroupBox1.Controls.Add(Me.combobox_jednotky_hmotnosti)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.textbox_jednotky_hmotnosti)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(502, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(484, 211)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Weight units"
        '
        'label_ounce
        '
        Me.label_ounce.AutoSize = True
        Me.label_ounce.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_ounce.Location = New System.Drawing.Point(6, 182)
        Me.label_ounce.Name = "label_ounce"
        Me.label_ounce.Size = New System.Drawing.Size(166, 18)
        Me.label_ounce.TabIndex = 20
        Me.label_ounce.Text = "Weight: 0 oz (ounce)"
        '
        'label_lb
        '
        Me.label_lb.AutoSize = True
        Me.label_lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_lb.Location = New System.Drawing.Point(6, 157)
        Me.label_lb.Name = "label_lb"
        Me.label_lb.Size = New System.Drawing.Size(169, 18)
        Me.label_lb.TabIndex = 19
        Me.label_lb.Text = "Weight: 0 lb (pounds)"
        '
        'label_kg
        '
        Me.label_kg.AutoSize = True
        Me.label_kg.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_kg.Location = New System.Drawing.Point(6, 132)
        Me.label_kg.Name = "label_kg"
        Me.label_kg.Size = New System.Drawing.Size(193, 18)
        Me.label_kg.TabIndex = 18
        Me.label_kg.Text = "Weight: 0 kg (kilograms)"
        '
        'label_grs
        '
        Me.label_grs.AutoSize = True
        Me.label_grs.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_grs.Location = New System.Drawing.Point(6, 107)
        Me.label_grs.Name = "label_grs"
        Me.label_grs.Size = New System.Drawing.Size(171, 18)
        Me.label_grs.TabIndex = 17
        Me.label_grs.Text = "Weight: 0 grs (grains)"
        '
        'label_g
        '
        Me.label_g.AutoSize = True
        Me.label_g.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_g.Location = New System.Drawing.Point(6, 82)
        Me.label_g.Name = "label_g"
        Me.label_g.Size = New System.Drawing.Size(157, 18)
        Me.label_g.TabIndex = 16
        Me.label_g.Text = "Weight: 0 g (grams)"
        '
        'combobox_jednotky_hmotnosti
        '
        Me.combobox_jednotky_hmotnosti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_jednotky_hmotnosti.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_jednotky_hmotnosti.FormattingEnabled = True
        Me.combobox_jednotky_hmotnosti.Items.AddRange(New Object() {"g", "grs", "kg", "lb", "ounce"})
        Me.combobox_jednotky_hmotnosti.Location = New System.Drawing.Point(245, 47)
        Me.combobox_jednotky_hmotnosti.Name = "combobox_jednotky_hmotnosti"
        Me.combobox_jednotky_hmotnosti.Size = New System.Drawing.Size(100, 26)
        Me.combobox_jednotky_hmotnosti.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Weight"
        '
        'textbox_jednotky_hmotnosti
        '
        Me.textbox_jednotky_hmotnosti.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_jednotky_hmotnosti.Location = New System.Drawing.Point(9, 48)
        Me.textbox_jednotky_hmotnosti.Name = "textbox_jednotky_hmotnosti"
        Me.textbox_jednotky_hmotnosti.Size = New System.Drawing.Size(230, 24)
        Me.textbox_jednotky_hmotnosti.TabIndex = 14
        '
        'groupbox3
        '
        Me.groupbox3.Controls.Add(Me.label_mile)
        Me.groupbox3.Controls.Add(Me.label_km)
        Me.groupbox3.Controls.Add(Me.label_yard)
        Me.groupbox3.Controls.Add(Me.label_ft)
        Me.groupbox3.Controls.Add(Me.label_m)
        Me.groupbox3.Controls.Add(Me.label_inch)
        Me.groupbox3.Controls.Add(Me.label_mm)
        Me.groupbox3.Controls.Add(Me.combobox_jednotky_délky)
        Me.groupbox3.Controls.Add(Me.Label13)
        Me.groupbox3.Controls.Add(Me.textbox_jednotky_délky)
        Me.groupbox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.groupbox3.Location = New System.Drawing.Point(12, 229)
        Me.groupbox3.Name = "groupbox3"
        Me.groupbox3.Size = New System.Drawing.Size(484, 263)
        Me.groupbox3.TabIndex = 26
        Me.groupbox3.TabStop = False
        Me.groupbox3.Text = "Lenght units"
        '
        'label_mile
        '
        Me.label_mile.AutoSize = True
        Me.label_mile.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_mile.Location = New System.Drawing.Point(6, 234)
        Me.label_mile.Name = "label_mile"
        Me.label_mile.Size = New System.Drawing.Size(170, 18)
        Me.label_mile.TabIndex = 22
        Me.label_mile.Text = "Lenght: 0 mile (miles)"
        '
        'label_km
        '
        Me.label_km.AutoSize = True
        Me.label_km.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_km.Location = New System.Drawing.Point(6, 209)
        Me.label_km.Name = "label_km"
        Me.label_km.Size = New System.Drawing.Size(201, 18)
        Me.label_km.TabIndex = 21
        Me.label_km.Text = "Lenght: 0 km (kilometers)"
        '
        'label_yard
        '
        Me.label_yard.AutoSize = True
        Me.label_yard.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_yard.Location = New System.Drawing.Point(6, 184)
        Me.label_yard.Name = "label_yard"
        Me.label_yard.Size = New System.Drawing.Size(157, 18)
        Me.label_yard.TabIndex = 20
        Me.label_yard.Text = "Lenght: 0 yd (yards)"
        '
        'label_ft
        '
        Me.label_ft.AutoSize = True
        Me.label_ft.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_ft.Location = New System.Drawing.Point(6, 159)
        Me.label_ft.Name = "label_ft"
        Me.label_ft.Size = New System.Drawing.Size(137, 18)
        Me.label_ft.TabIndex = 19
        Me.label_ft.Text = "Lenght: 0 ft (feet)"
        '
        'label_m
        '
        Me.label_m.AutoSize = True
        Me.label_m.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_m.Location = New System.Drawing.Point(6, 134)
        Me.label_m.Name = "label_m"
        Me.label_m.Size = New System.Drawing.Size(165, 18)
        Me.label_m.TabIndex = 18
        Me.label_m.Text = "Lenght: 0 m (meters)"
        '
        'label_inch
        '
        Me.label_inch.AutoSize = True
        Me.label_inch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_inch.Location = New System.Drawing.Point(6, 108)
        Me.label_inch.Name = "label_inch"
        Me.label_inch.Size = New System.Drawing.Size(161, 18)
        Me.label_inch.TabIndex = 17
        Me.label_inch.Text = "Lenght: 0 in (inches)"
        '
        'label_mm
        '
        Me.label_mm.AutoSize = True
        Me.label_mm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_mm.Location = New System.Drawing.Point(6, 83)
        Me.label_mm.Name = "label_mm"
        Me.label_mm.Size = New System.Drawing.Size(205, 18)
        Me.label_mm.TabIndex = 16
        Me.label_mm.Text = "Lenght: 0 mm (milimeters)"
        '
        'combobox_jednotky_délky
        '
        Me.combobox_jednotky_délky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_jednotky_délky.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_jednotky_délky.FormattingEnabled = True
        Me.combobox_jednotky_délky.Items.AddRange(New Object() {"mm", "in", "m", "ft", "yd", "km", "mile"})
        Me.combobox_jednotky_délky.Location = New System.Drawing.Point(246, 48)
        Me.combobox_jednotky_délky.Name = "combobox_jednotky_délky"
        Me.combobox_jednotky_délky.Size = New System.Drawing.Size(100, 26)
        Me.combobox_jednotky_délky.TabIndex = 15
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 18)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Lenght"
        '
        'textbox_jednotky_délky
        '
        Me.textbox_jednotky_délky.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_jednotky_délky.Location = New System.Drawing.Point(10, 49)
        Me.textbox_jednotky_délky.Name = "textbox_jednotky_délky"
        Me.textbox_jednotky_délky.Size = New System.Drawing.Size(230, 24)
        Me.textbox_jednotky_délky.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Rounding to"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(199, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 20)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "decimal places"
        '
        'combobox_zaokrouhleni
        '
        Me.combobox_zaokrouhleni.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_zaokrouhleni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_zaokrouhleni.FormattingEnabled = True
        Me.combobox_zaokrouhleni.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.combobox_zaokrouhleni.Location = New System.Drawing.Point(124, 26)
        Me.combobox_zaokrouhleni.Name = "combobox_zaokrouhleni"
        Me.combobox_zaokrouhleni.Size = New System.Drawing.Size(68, 28)
        Me.combobox_zaokrouhleni.TabIndex = 29
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.combobox_zaokrouhleni)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 498)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(484, 65)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Settings"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.label_MOA)
        Me.GroupBox5.Controls.Add(Me.label_MRAD)
        Me.GroupBox5.Controls.Add(Me.label_stupne_uhlu)
        Me.GroupBox5.Controls.Add(Me.combobox_jednotky_uhel)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.textbox_jednotky_uhel)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(502, 229)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(484, 162)
        Me.GroupBox5.TabIndex = 31
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Angle units"
        '
        'label_MOA
        '
        Me.label_MOA.AutoSize = True
        Me.label_MOA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_MOA.Location = New System.Drawing.Point(6, 132)
        Me.label_MOA.Name = "label_MOA"
        Me.label_MOA.Size = New System.Drawing.Size(251, 18)
        Me.label_MOA.TabIndex = 18
        Me.label_MOA.Text = "Angle: 0 MOA (minutes of angle)"
        '
        'label_MRAD
        '
        Me.label_MRAD.AutoSize = True
        Me.label_MRAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_MRAD.Location = New System.Drawing.Point(6, 107)
        Me.label_MRAD.Name = "label_MRAD"
        Me.label_MRAD.Size = New System.Drawing.Size(219, 18)
        Me.label_MRAD.TabIndex = 17
        Me.label_MRAD.Text = "Angle: 0 MRAD (miliradians)"
        '
        'label_stupne_uhlu
        '
        Me.label_stupne_uhlu.AutoSize = True
        Me.label_stupne_uhlu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_stupne_uhlu.Location = New System.Drawing.Point(6, 82)
        Me.label_stupne_uhlu.Name = "label_stupne_uhlu"
        Me.label_stupne_uhlu.Size = New System.Drawing.Size(177, 18)
        Me.label_stupne_uhlu.TabIndex = 16
        Me.label_stupne_uhlu.Text = "Angle: 0 deg (degrees)"
        '
        'combobox_jednotky_uhel
        '
        Me.combobox_jednotky_uhel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_jednotky_uhel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_jednotky_uhel.FormattingEnabled = True
        Me.combobox_jednotky_uhel.Items.AddRange(New Object() {"deg", "MOA", "MRAD"})
        Me.combobox_jednotky_uhel.Location = New System.Drawing.Point(244, 47)
        Me.combobox_jednotky_uhel.Name = "combobox_jednotky_uhel"
        Me.combobox_jednotky_uhel.Size = New System.Drawing.Size(100, 26)
        Me.combobox_jednotky_uhel.TabIndex = 15
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 18)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Angle"
        '
        'textbox_jednotky_uhel
        '
        Me.textbox_jednotky_uhel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_jednotky_uhel.Location = New System.Drawing.Point(8, 48)
        Me.textbox_jednotky_uhel.Name = "textbox_jednotky_uhel"
        Me.textbox_jednotky_uhel.Size = New System.Drawing.Size(230, 24)
        Me.textbox_jednotky_uhel.TabIndex = 14
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.label_energie_foot_pounds)
        Me.GroupBox6.Controls.Add(Me.label_energie_jouly)
        Me.GroupBox6.Controls.Add(Me.combobox_jednotky_energie)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.textbox_jednotky_energie)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox6.Location = New System.Drawing.Point(502, 397)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(484, 139)
        Me.GroupBox6.TabIndex = 32
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Energy units"
        '
        'label_energie_foot_pounds
        '
        Me.label_energie_foot_pounds.AutoSize = True
        Me.label_energie_foot_pounds.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_energie_foot_pounds.Location = New System.Drawing.Point(6, 107)
        Me.label_energie_foot_pounds.Name = "label_energie_foot_pounds"
        Me.label_energie_foot_pounds.Size = New System.Drawing.Size(220, 18)
        Me.label_energie_foot_pounds.TabIndex = 17
        Me.label_energie_foot_pounds.Text = "Energy: 0 ft-lb (foot pounds)"
        '
        'label_energie_jouly
        '
        Me.label_energie_jouly.AutoSize = True
        Me.label_energie_jouly.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_energie_jouly.Location = New System.Drawing.Point(6, 82)
        Me.label_energie_jouly.Name = "label_energie_jouly"
        Me.label_energie_jouly.Size = New System.Drawing.Size(155, 18)
        Me.label_energie_jouly.TabIndex = 16
        Me.label_energie_jouly.Text = "Energy: 0 J (joules)"
        '
        'combobox_jednotky_energie
        '
        Me.combobox_jednotky_energie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_jednotky_energie.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_jednotky_energie.FormattingEnabled = True
        Me.combobox_jednotky_energie.Items.AddRange(New Object() {"J", "ft-lb"})
        Me.combobox_jednotky_energie.Location = New System.Drawing.Point(244, 47)
        Me.combobox_jednotky_energie.Name = "combobox_jednotky_energie"
        Me.combobox_jednotky_energie.Size = New System.Drawing.Size(100, 26)
        Me.combobox_jednotky_energie.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 18)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Energy"
        '
        'textbox_jednotky_energie
        '
        Me.textbox_jednotky_energie.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_jednotky_energie.Location = New System.Drawing.Point(8, 48)
        Me.textbox_jednotky_energie.Name = "textbox_jednotky_energie"
        Me.textbox_jednotky_energie.Size = New System.Drawing.Size(230, 24)
        Me.textbox_jednotky_energie.TabIndex = 14
        '
        'Převody_jednotek
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(997, 642)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.groupbox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.button_spočítej)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.button_zavřít)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1013, 681)
        Me.MinimumSize = New System.Drawing.Size(1013, 681)
        Me.Name = "Převody_jednotek"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unit conversions"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.groupbox3.ResumeLayout(False)
        Me.groupbox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents button_zavřít As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents textbox_jednotky_rychlosti As TextBox
    Friend WithEvents combobox_jednotky_rychlosti As ComboBox
    Friend WithEvents button_spočítej As Button
    Friend WithEvents label_mach As Label
    Friend WithEvents label_mph As Label
    Friend WithEvents label_kmh As Label
    Friend WithEvents label_fps As Label
    Friend WithEvents label_mps As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents label_ounce As Label
    Friend WithEvents label_lb As Label
    Friend WithEvents label_kg As Label
    Friend WithEvents label_grs As Label
    Friend WithEvents label_g As Label
    Friend WithEvents combobox_jednotky_hmotnosti As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents textbox_jednotky_hmotnosti As TextBox
    Friend WithEvents groupbox3 As GroupBox
    Friend WithEvents label_yard As Label
    Friend WithEvents label_ft As Label
    Friend WithEvents label_m As Label
    Friend WithEvents label_inch As Label
    Friend WithEvents label_mm As Label
    Friend WithEvents combobox_jednotky_délky As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents textbox_jednotky_délky As TextBox
    Friend WithEvents label_mile As Label
    Friend WithEvents label_km As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents combobox_zaokrouhleni As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents label_MOA As Label
    Friend WithEvents label_MRAD As Label
    Friend WithEvents label_stupne_uhlu As Label
    Friend WithEvents combobox_jednotky_uhel As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents textbox_jednotky_uhel As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents label_energie_foot_pounds As Label
    Friend WithEvents label_energie_jouly As Label
    Friend WithEvents combobox_jednotky_energie As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents textbox_jednotky_energie As TextBox
End Class
