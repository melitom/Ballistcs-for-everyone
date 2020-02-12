<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vypocet_dostrelu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vypocet_dostrelu))
        Me.Button_Zavřít = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textbox_prumer_telesa = New System.Windows.Forms.TextBox()
        Me.combobox_prumer_telesa = New System.Windows.Forms.ComboBox()
        Me.combobox_počáteční_rychlost = New System.Windows.Forms.ComboBox()
        Me.combobox_hmotnost_střely = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Textbox_hmotnost = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Textbox_Počáteční_rychlost = New System.Windows.Forms.TextBox()
        Me.combobox_výběr_koeficientů = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Textbox_Koeficient_odporu = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.checkbox_střepiny = New System.Windows.Forms.CheckBox()
        Me.checkbox_koule_broky = New System.Windows.Forms.CheckBox()
        Me.button_spocitej = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.checkbox_maximalni_dostrel = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textbox_uhel_vrhu = New System.Windows.Forms.TextBox()
        Me.combobox_uhel_vrhu = New System.Windows.Forms.ComboBox()
        Me.label_nadmořská_výška = New System.Windows.Forms.Label()
        Me.label_teplota_vzduchu = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.label_dopadova_energie = New System.Windows.Forms.Label()
        Me.label_pocatecni_energie = New System.Windows.Forms.Label()
        Me.label_doba_pohybu = New System.Windows.Forms.Label()
        Me.label_dopadova_rychlost = New System.Windows.Forms.Label()
        Me.label_dostrel = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button_Zavřít
        '
        Me.Button_Zavřít.BackColor = System.Drawing.SystemColors.Window
        Me.Button_Zavřít.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Zavřít.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button_Zavřít.Location = New System.Drawing.Point(515, 502)
        Me.Button_Zavřít.Name = "Button_Zavřít"
        Me.Button_Zavřít.Size = New System.Drawing.Size(497, 60)
        Me.Button_Zavřít.TabIndex = 3
        Me.Button_Zavřít.Text = "Close"
        Me.Button_Zavřít.UseVisualStyleBackColor = False
        '
        'Chart1
        '
        Me.Chart1.Location = New System.Drawing.Point(220, 136)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Size = New System.Drawing.Size(792, 360)
        Me.Chart1.TabIndex = 14
        Me.Chart1.Text = "Chart1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.textbox_prumer_telesa)
        Me.GroupBox1.Controls.Add(Me.combobox_prumer_telesa)
        Me.GroupBox1.Controls.Add(Me.combobox_počáteční_rychlost)
        Me.GroupBox1.Controls.Add(Me.combobox_hmotnost_střely)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Textbox_hmotnost)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Textbox_Počáteční_rychlost)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(202, 183)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Basic data"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Bullet diameter"
        '
        'textbox_prumer_telesa
        '
        Me.textbox_prumer_telesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_prumer_telesa.Location = New System.Drawing.Point(9, 146)
        Me.textbox_prumer_telesa.Name = "textbox_prumer_telesa"
        Me.textbox_prumer_telesa.Size = New System.Drawing.Size(107, 24)
        Me.textbox_prumer_telesa.TabIndex = 12
        '
        'combobox_prumer_telesa
        '
        Me.combobox_prumer_telesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_prumer_telesa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_prumer_telesa.FormattingEnabled = True
        Me.combobox_prumer_telesa.Items.AddRange(New Object() {"mm", "in"})
        Me.combobox_prumer_telesa.Location = New System.Drawing.Point(122, 146)
        Me.combobox_prumer_telesa.Name = "combobox_prumer_telesa"
        Me.combobox_prumer_telesa.Size = New System.Drawing.Size(65, 24)
        Me.combobox_prumer_telesa.TabIndex = 13
        '
        'combobox_počáteční_rychlost
        '
        Me.combobox_počáteční_rychlost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_počáteční_rychlost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_počáteční_rychlost.FormattingEnabled = True
        Me.combobox_počáteční_rychlost.Items.AddRange(New Object() {"m/s", "fps", "km/h", "mph"})
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
        Me.combobox_hmotnost_střely.Items.AddRange(New Object() {"g", "grs", "lb", "kg"})
        Me.combobox_hmotnost_střely.Location = New System.Drawing.Point(122, 94)
        Me.combobox_hmotnost_střely.Name = "combobox_hmotnost_střely"
        Me.combobox_hmotnost_střely.Size = New System.Drawing.Size(65, 24)
        Me.combobox_hmotnost_střely.TabIndex = 8
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
        'combobox_výběr_koeficientů
        '
        Me.combobox_výběr_koeficientů.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_výběr_koeficientů.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_výběr_koeficientů.FormattingEnabled = True
        Me.combobox_výběr_koeficientů.Items.AddRange(New Object() {"G1", "G7"})
        Me.combobox_výběr_koeficientů.Location = New System.Drawing.Point(122, 44)
        Me.combobox_výběr_koeficientů.Name = "combobox_výběr_koeficientů"
        Me.combobox_výběr_koeficientů.Size = New System.Drawing.Size(65, 24)
        Me.combobox_výběr_koeficientů.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Ballistic coefficient"
        '
        'Textbox_Koeficient_odporu
        '
        Me.Textbox_Koeficient_odporu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Textbox_Koeficient_odporu.Location = New System.Drawing.Point(9, 44)
        Me.Textbox_Koeficient_odporu.Name = "Textbox_Koeficient_odporu"
        Me.Textbox_Koeficient_odporu.Size = New System.Drawing.Size(107, 24)
        Me.Textbox_Koeficient_odporu.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.checkbox_střepiny)
        Me.GroupBox2.Controls.Add(Me.checkbox_koule_broky)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Textbox_Koeficient_odporu)
        Me.GroupBox2.Controls.Add(Me.combobox_výběr_koeficientů)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 201)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(202, 123)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Drag coefficient"
        '
        'checkbox_střepiny
        '
        Me.checkbox_střepiny.AutoSize = True
        Me.checkbox_střepiny.Location = New System.Drawing.Point(9, 96)
        Me.checkbox_střepiny.Name = "checkbox_střepiny"
        Me.checkbox_střepiny.Size = New System.Drawing.Size(94, 21)
        Me.checkbox_střepiny.TabIndex = 9
        Me.checkbox_střepiny.Text = "Fragments"
        Me.checkbox_střepiny.UseVisualStyleBackColor = True
        '
        'checkbox_koule_broky
        '
        Me.checkbox_koule_broky.AutoSize = True
        Me.checkbox_koule_broky.Location = New System.Drawing.Point(9, 74)
        Me.checkbox_koule_broky.Name = "checkbox_koule_broky"
        Me.checkbox_koule_broky.Size = New System.Drawing.Size(92, 21)
        Me.checkbox_koule_broky.TabIndex = 8
        Me.checkbox_koule_broky.Text = "Balls, shot"
        Me.checkbox_koule_broky.UseVisualStyleBackColor = True
        '
        'button_spocitej
        '
        Me.button_spocitej.BackColor = System.Drawing.SystemColors.Window
        Me.button_spocitej.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_spocitej.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.button_spocitej.Location = New System.Drawing.Point(12, 502)
        Me.button_spocitej.Name = "button_spocitej"
        Me.button_spocitej.Size = New System.Drawing.Size(497, 60)
        Me.button_spocitej.TabIndex = 17
        Me.button_spocitej.Text = "Calculate"
        Me.button_spocitej.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.checkbox_maximalni_dostrel)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.textbox_uhel_vrhu)
        Me.GroupBox3.Controls.Add(Me.combobox_uhel_vrhu)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 330)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(202, 103)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Angle settings"
        '
        'checkbox_maximalni_dostrel
        '
        Me.checkbox_maximalni_dostrel.AutoSize = True
        Me.checkbox_maximalni_dostrel.Location = New System.Drawing.Point(9, 74)
        Me.checkbox_maximalni_dostrel.Name = "checkbox_maximalni_dostrel"
        Me.checkbox_maximalni_dostrel.Size = New System.Drawing.Size(126, 21)
        Me.checkbox_maximalni_dostrel.TabIndex = 13
        Me.checkbox_maximalni_dostrel.Text = "Maximum range"
        Me.checkbox_maximalni_dostrel.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Angle of shot"
        '
        'textbox_uhel_vrhu
        '
        Me.textbox_uhel_vrhu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_uhel_vrhu.Location = New System.Drawing.Point(9, 44)
        Me.textbox_uhel_vrhu.Name = "textbox_uhel_vrhu"
        Me.textbox_uhel_vrhu.Size = New System.Drawing.Size(107, 24)
        Me.textbox_uhel_vrhu.TabIndex = 11
        '
        'combobox_uhel_vrhu
        '
        Me.combobox_uhel_vrhu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_uhel_vrhu.Enabled = False
        Me.combobox_uhel_vrhu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_uhel_vrhu.FormattingEnabled = True
        Me.combobox_uhel_vrhu.Items.AddRange(New Object() {"deg"})
        Me.combobox_uhel_vrhu.Location = New System.Drawing.Point(122, 44)
        Me.combobox_uhel_vrhu.Name = "combobox_uhel_vrhu"
        Me.combobox_uhel_vrhu.Size = New System.Drawing.Size(65, 24)
        Me.combobox_uhel_vrhu.TabIndex = 12
        '
        'label_nadmořská_výška
        '
        Me.label_nadmořská_výška.AutoSize = True
        Me.label_nadmořská_výška.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_nadmořská_výška.Location = New System.Drawing.Point(12, 471)
        Me.label_nadmořská_výška.Name = "label_nadmořská_výška"
        Me.label_nadmořská_výška.Size = New System.Drawing.Size(135, 17)
        Me.label_nadmořská_výška.TabIndex = 29
        Me.label_nadmořská_výška.Text = "Height above sea"
        '
        'label_teplota_vzduchu
        '
        Me.label_teplota_vzduchu.AutoSize = True
        Me.label_teplota_vzduchu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_teplota_vzduchu.Location = New System.Drawing.Point(12, 445)
        Me.label_teplota_vzduchu.Name = "label_teplota_vzduchu"
        Me.label_teplota_vzduchu.Size = New System.Drawing.Size(121, 17)
        Me.label_teplota_vzduchu.TabIndex = 28
        Me.label_teplota_vzduchu.Text = "Air temperature"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.label_dopadova_energie)
        Me.GroupBox4.Controls.Add(Me.label_pocatecni_energie)
        Me.GroupBox4.Controls.Add(Me.label_doba_pohybu)
        Me.GroupBox4.Controls.Add(Me.label_dopadova_rychlost)
        Me.GroupBox4.Controls.Add(Me.label_dostrel)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(220, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(792, 118)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Calculated data"
        '
        'label_dopadova_energie
        '
        Me.label_dopadova_energie.AutoSize = True
        Me.label_dopadova_energie.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_dopadova_energie.Location = New System.Drawing.Point(386, 54)
        Me.label_dopadova_energie.Name = "label_dopadova_energie"
        Me.label_dopadova_energie.Size = New System.Drawing.Size(134, 24)
        Me.label_dopadova_energie.TabIndex = 22
        Me.label_dopadova_energie.Text = "Impact energy:"
        '
        'label_pocatecni_energie
        '
        Me.label_pocatecni_energie.AutoSize = True
        Me.label_pocatecni_energie.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_pocatecni_energie.Location = New System.Drawing.Point(386, 22)
        Me.label_pocatecni_energie.Name = "label_pocatecni_energie"
        Me.label_pocatecni_energie.Size = New System.Drawing.Size(139, 24)
        Me.label_pocatecni_energie.TabIndex = 21
        Me.label_pocatecni_energie.Text = "Muzzle energy:"
        '
        'label_doba_pohybu
        '
        Me.label_doba_pohybu.AutoSize = True
        Me.label_doba_pohybu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_doba_pohybu.Location = New System.Drawing.Point(6, 54)
        Me.label_doba_pohybu.Name = "label_doba_pohybu"
        Me.label_doba_pohybu.Size = New System.Drawing.Size(121, 24)
        Me.label_doba_pohybu.TabIndex = 20
        Me.label_doba_pohybu.Text = "Time of flight:"
        '
        'label_dopadova_rychlost
        '
        Me.label_dopadova_rychlost.AutoSize = True
        Me.label_dopadova_rychlost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_dopadova_rychlost.Location = New System.Drawing.Point(6, 86)
        Me.label_dopadova_rychlost.Name = "label_dopadova_rychlost"
        Me.label_dopadova_rychlost.Size = New System.Drawing.Size(137, 24)
        Me.label_dopadova_rychlost.TabIndex = 19
        Me.label_dopadova_rychlost.Text = "Impact velocity:"
        '
        'label_dostrel
        '
        Me.label_dostrel.AutoSize = True
        Me.label_dostrel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_dostrel.Location = New System.Drawing.Point(6, 22)
        Me.label_dostrel.Name = "label_dostrel"
        Me.label_dostrel.Size = New System.Drawing.Size(152, 24)
        Me.label_dostrel.TabIndex = 18
        Me.label_dostrel.Text = "Maximum range:"
        '
        'Vypocet_dostrelu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1024, 571)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.label_nadmořská_výška)
        Me.Controls.Add(Me.label_teplota_vzduchu)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.button_spocitej)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Button_Zavřít)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1040, 610)
        Me.MinimumSize = New System.Drawing.Size(1040, 610)
        Me.Name = "Vypocet_dostrelu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maximum range calculations"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Zavřít As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents combobox_počáteční_rychlost As ComboBox
    Friend WithEvents combobox_hmotnost_střely As ComboBox
    Friend WithEvents combobox_výběr_koeficientů As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Textbox_Koeficient_odporu As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Textbox_hmotnost As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Textbox_Počáteční_rychlost As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents checkbox_střepiny As CheckBox
    Friend WithEvents checkbox_koule_broky As CheckBox
    Friend WithEvents button_spocitej As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents textbox_prumer_telesa As TextBox
    Friend WithEvents combobox_prumer_telesa As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents textbox_uhel_vrhu As TextBox
    Friend WithEvents combobox_uhel_vrhu As ComboBox
    Friend WithEvents checkbox_maximalni_dostrel As CheckBox
    Friend WithEvents label_nadmořská_výška As Label
    Friend WithEvents label_teplota_vzduchu As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents label_doba_pohybu As Label
    Friend WithEvents label_dopadova_rychlost As Label
    Friend WithEvents label_dostrel As Label
    Friend WithEvents label_dopadova_energie As Label
    Friend WithEvents label_pocatecni_energie As Label
End Class
