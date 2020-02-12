<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Seznam_střel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Seznam_střel))
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.první = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.druhý = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.třetí = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.čtvrtý = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.checkbox_RWS_puškové = New System.Windows.Forms.CheckBox()
        Me.checkbox_federal_puška = New System.Windows.Forms.CheckBox()
        Me.checkbox_SB_Puška = New System.Windows.Forms.CheckBox()
        Me.checkbox_Hornady = New System.Windows.Forms.CheckBox()
        Me.checkbox_L = New System.Windows.Forms.CheckBox()
        Me.checkbox_Sierra = New System.Windows.Forms.CheckBox()
        Me.checkbox_Berger = New System.Windows.Forms.CheckBox()
        Me.checkbox_TNX_Puška = New System.Windows.Forms.CheckBox()
        Me.checkbox_N = New System.Windows.Forms.CheckBox()
        Me.checkbox_FOX = New System.Windows.Forms.CheckBox()
        Me.checkbox_diabolky = New System.Windows.Forms.CheckBox()
        Me.checkbox_federal_malorážka = New System.Windows.Forms.CheckBox()
        Me.checkbox_CCI = New System.Windows.Forms.CheckBox()
        Me.checkbox_SB_malorážka = New System.Windows.Forms.CheckBox()
        Me.checkbox_TNX_Pistole = New System.Windows.Forms.CheckBox()
        Me.checkbox_LEE = New System.Windows.Forms.CheckBox()
        Me.checkbox_LOS = New System.Windows.Forms.CheckBox()
        Me.checkbox_SB_Pistole = New System.Windows.Forms.CheckBox()
        Me.label_střela = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.label_balistický_koeficient = New System.Windows.Forms.Label()
        Me.label_hmotnost_střely = New System.Windows.Forms.Label()
        Me.label_typ_střely = New System.Windows.Forms.Label()
        Me.button_načíst_střelu = New System.Windows.Forms.Button()
        Me.button_zavřít = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.checkbox_federal_pistole = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.checkbox_SK_malorážka = New System.Windows.Forms.CheckBox()
        Me.checkbox_RWS_malorazka = New System.Windows.Forms.CheckBox()
        Me.checkbox_H_pistole = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.první, Me.druhý, Me.třetí, Me.čtvrtý})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 261)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(970, 356)
        Me.ListView1.TabIndex = 8
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'první
        '
        Me.první.Text = ""
        Me.první.Width = 220
        '
        'druhý
        '
        Me.druhý.Text = ""
        Me.druhý.Width = 220
        '
        'třetí
        '
        Me.třetí.Text = ""
        Me.třetí.Width = 220
        '
        'čtvrtý
        '
        Me.čtvrtý.Text = ""
        Me.čtvrtý.Width = 220
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.checkbox_RWS_puškové)
        Me.GroupBox1.Controls.Add(Me.checkbox_federal_puška)
        Me.GroupBox1.Controls.Add(Me.checkbox_SB_Puška)
        Me.GroupBox1.Controls.Add(Me.checkbox_Hornady)
        Me.GroupBox1.Controls.Add(Me.checkbox_L)
        Me.GroupBox1.Controls.Add(Me.checkbox_Sierra)
        Me.GroupBox1.Controls.Add(Me.checkbox_Berger)
        Me.GroupBox1.Controls.Add(Me.checkbox_TNX_Puška)
        Me.GroupBox1.Controls.Add(Me.checkbox_N)
        Me.GroupBox1.Controls.Add(Me.checkbox_FOX)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 177)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rifle"
        '
        'checkbox_RWS_puškové
        '
        Me.checkbox_RWS_puškové.AutoSize = True
        Me.checkbox_RWS_puškové.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_RWS_puškové.Location = New System.Drawing.Point(114, 74)
        Me.checkbox_RWS_puškové.Name = "checkbox_RWS_puškové"
        Me.checkbox_RWS_puškové.Size = New System.Drawing.Size(66, 24)
        Me.checkbox_RWS_puškové.TabIndex = 34
        Me.checkbox_RWS_puškové.Text = "RWS"
        Me.checkbox_RWS_puškové.UseVisualStyleBackColor = True
        '
        'checkbox_federal_puška
        '
        Me.checkbox_federal_puška.AutoSize = True
        Me.checkbox_federal_puška.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_federal_puška.Location = New System.Drawing.Point(10, 123)
        Me.checkbox_federal_puška.Name = "checkbox_federal_puška"
        Me.checkbox_federal_puška.Size = New System.Drawing.Size(82, 24)
        Me.checkbox_federal_puška.TabIndex = 33
        Me.checkbox_federal_puška.Text = "Federal"
        Me.checkbox_federal_puška.UseVisualStyleBackColor = True
        '
        'checkbox_SB_Puška
        '
        Me.checkbox_SB_Puška.AutoSize = True
        Me.checkbox_SB_Puška.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_SB_Puška.Location = New System.Drawing.Point(114, 24)
        Me.checkbox_SB_Puška.Name = "checkbox_SB_Puška"
        Me.checkbox_SB_Puška.Size = New System.Drawing.Size(50, 24)
        Me.checkbox_SB_Puška.TabIndex = 16
        Me.checkbox_SB_Puška.Text = "SB"
        Me.checkbox_SB_Puška.UseVisualStyleBackColor = True
        '
        'checkbox_Hornady
        '
        Me.checkbox_Hornady.AutoSize = True
        Me.checkbox_Hornady.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_Hornady.Location = New System.Drawing.Point(10, 24)
        Me.checkbox_Hornady.Name = "checkbox_Hornady"
        Me.checkbox_Hornady.Size = New System.Drawing.Size(88, 24)
        Me.checkbox_Hornady.TabIndex = 19
        Me.checkbox_Hornady.Text = "Hornady"
        Me.checkbox_Hornady.UseVisualStyleBackColor = True
        '
        'checkbox_L
        '
        Me.checkbox_L.AutoSize = True
        Me.checkbox_L.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_L.Location = New System.Drawing.Point(10, 49)
        Me.checkbox_L.Name = "checkbox_L"
        Me.checkbox_L.Size = New System.Drawing.Size(73, 24)
        Me.checkbox_L.TabIndex = 17
        Me.checkbox_L.Text = "Lapua"
        Me.checkbox_L.UseVisualStyleBackColor = True
        '
        'checkbox_Sierra
        '
        Me.checkbox_Sierra.AutoSize = True
        Me.checkbox_Sierra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_Sierra.Location = New System.Drawing.Point(10, 74)
        Me.checkbox_Sierra.Name = "checkbox_Sierra"
        Me.checkbox_Sierra.Size = New System.Drawing.Size(70, 24)
        Me.checkbox_Sierra.TabIndex = 20
        Me.checkbox_Sierra.Text = "Sierra"
        Me.checkbox_Sierra.UseVisualStyleBackColor = True
        '
        'checkbox_Berger
        '
        Me.checkbox_Berger.AutoSize = True
        Me.checkbox_Berger.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_Berger.Location = New System.Drawing.Point(10, 99)
        Me.checkbox_Berger.Name = "checkbox_Berger"
        Me.checkbox_Berger.Size = New System.Drawing.Size(76, 24)
        Me.checkbox_Berger.TabIndex = 24
        Me.checkbox_Berger.Text = "Berger"
        Me.checkbox_Berger.UseVisualStyleBackColor = True
        '
        'checkbox_TNX_Puška
        '
        Me.checkbox_TNX_Puška.AutoSize = True
        Me.checkbox_TNX_Puška.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_TNX_Puška.Location = New System.Drawing.Point(114, 99)
        Me.checkbox_TNX_Puška.Name = "checkbox_TNX_Puška"
        Me.checkbox_TNX_Puška.Size = New System.Drawing.Size(75, 24)
        Me.checkbox_TNX_Puška.TabIndex = 26
        Me.checkbox_TNX_Puška.Text = "TEN-X"
        Me.checkbox_TNX_Puška.UseVisualStyleBackColor = True
        '
        'checkbox_N
        '
        Me.checkbox_N.AutoSize = True
        Me.checkbox_N.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_N.Location = New System.Drawing.Point(10, 148)
        Me.checkbox_N.Name = "checkbox_N"
        Me.checkbox_N.Size = New System.Drawing.Size(73, 24)
        Me.checkbox_N.TabIndex = 27
        Me.checkbox_N.Text = "Nosler"
        Me.checkbox_N.UseVisualStyleBackColor = True
        '
        'checkbox_FOX
        '
        Me.checkbox_FOX.AutoSize = True
        Me.checkbox_FOX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_FOX.Location = New System.Drawing.Point(114, 49)
        Me.checkbox_FOX.Name = "checkbox_FOX"
        Me.checkbox_FOX.Size = New System.Drawing.Size(61, 24)
        Me.checkbox_FOX.TabIndex = 28
        Me.checkbox_FOX.Text = "FOX"
        Me.checkbox_FOX.UseVisualStyleBackColor = True
        '
        'checkbox_diabolky
        '
        Me.checkbox_diabolky.AutoSize = True
        Me.checkbox_diabolky.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_diabolky.Location = New System.Drawing.Point(10, 24)
        Me.checkbox_diabolky.Name = "checkbox_diabolky"
        Me.checkbox_diabolky.Size = New System.Drawing.Size(75, 24)
        Me.checkbox_diabolky.TabIndex = 32
        Me.checkbox_diabolky.Text = "Pellets"
        Me.checkbox_diabolky.UseVisualStyleBackColor = True
        '
        'checkbox_federal_malorážka
        '
        Me.checkbox_federal_malorážka.AutoSize = True
        Me.checkbox_federal_malorážka.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_federal_malorážka.Location = New System.Drawing.Point(10, 74)
        Me.checkbox_federal_malorážka.Name = "checkbox_federal_malorážka"
        Me.checkbox_federal_malorážka.Size = New System.Drawing.Size(82, 24)
        Me.checkbox_federal_malorážka.TabIndex = 31
        Me.checkbox_federal_malorážka.Text = "Federal"
        Me.checkbox_federal_malorážka.UseVisualStyleBackColor = True
        '
        'checkbox_CCI
        '
        Me.checkbox_CCI.AutoSize = True
        Me.checkbox_CCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_CCI.Location = New System.Drawing.Point(10, 99)
        Me.checkbox_CCI.Name = "checkbox_CCI"
        Me.checkbox_CCI.Size = New System.Drawing.Size(55, 24)
        Me.checkbox_CCI.TabIndex = 30
        Me.checkbox_CCI.Text = "CCI"
        Me.checkbox_CCI.UseVisualStyleBackColor = True
        '
        'checkbox_SB_malorážka
        '
        Me.checkbox_SB_malorážka.AutoSize = True
        Me.checkbox_SB_malorážka.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_SB_malorážka.Location = New System.Drawing.Point(10, 49)
        Me.checkbox_SB_malorážka.Name = "checkbox_SB_malorážka"
        Me.checkbox_SB_malorážka.Size = New System.Drawing.Size(50, 24)
        Me.checkbox_SB_malorážka.TabIndex = 29
        Me.checkbox_SB_malorážka.Text = "SB"
        Me.checkbox_SB_malorážka.UseVisualStyleBackColor = True
        '
        'checkbox_TNX_Pistole
        '
        Me.checkbox_TNX_Pistole.AutoSize = True
        Me.checkbox_TNX_Pistole.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_TNX_Pistole.Location = New System.Drawing.Point(10, 149)
        Me.checkbox_TNX_Pistole.Name = "checkbox_TNX_Pistole"
        Me.checkbox_TNX_Pistole.Size = New System.Drawing.Size(75, 24)
        Me.checkbox_TNX_Pistole.TabIndex = 25
        Me.checkbox_TNX_Pistole.Text = "TEN-X"
        Me.checkbox_TNX_Pistole.UseVisualStyleBackColor = True
        '
        'checkbox_LEE
        '
        Me.checkbox_LEE.AutoSize = True
        Me.checkbox_LEE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_LEE.Location = New System.Drawing.Point(10, 99)
        Me.checkbox_LEE.Name = "checkbox_LEE"
        Me.checkbox_LEE.Size = New System.Drawing.Size(59, 24)
        Me.checkbox_LEE.TabIndex = 23
        Me.checkbox_LEE.Text = "LEE"
        Me.checkbox_LEE.UseVisualStyleBackColor = True
        '
        'checkbox_LOS
        '
        Me.checkbox_LOS.AutoSize = True
        Me.checkbox_LOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_LOS.Location = New System.Drawing.Point(10, 124)
        Me.checkbox_LOS.Name = "checkbox_LOS"
        Me.checkbox_LOS.Size = New System.Drawing.Size(60, 24)
        Me.checkbox_LOS.TabIndex = 22
        Me.checkbox_LOS.Text = "LOS"
        Me.checkbox_LOS.UseVisualStyleBackColor = True
        '
        'checkbox_SB_Pistole
        '
        Me.checkbox_SB_Pistole.AutoSize = True
        Me.checkbox_SB_Pistole.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_SB_Pistole.Location = New System.Drawing.Point(10, 24)
        Me.checkbox_SB_Pistole.Name = "checkbox_SB_Pistole"
        Me.checkbox_SB_Pistole.Size = New System.Drawing.Size(50, 24)
        Me.checkbox_SB_Pistole.TabIndex = 21
        Me.checkbox_SB_Pistole.Text = "SB"
        Me.checkbox_SB_Pistole.UseVisualStyleBackColor = True
        '
        'label_střela
        '
        Me.label_střela.AutoSize = True
        Me.label_střela.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_střela.Location = New System.Drawing.Point(7, 29)
        Me.label_střela.Name = "label_střela"
        Me.label_střela.Size = New System.Drawing.Size(71, 25)
        Me.label_střela.TabIndex = 17
        Me.label_střela.Text = "Bullet: "
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.label_balistický_koeficient)
        Me.GroupBox2.Controls.Add(Me.label_hmotnost_střely)
        Me.GroupBox2.Controls.Add(Me.label_typ_střely)
        Me.GroupBox2.Controls.Add(Me.label_střela)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(500, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(482, 177)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Loaded bullet"
        '
        'label_balistický_koeficient
        '
        Me.label_balistický_koeficient.AutoSize = True
        Me.label_balistický_koeficient.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_balistický_koeficient.Location = New System.Drawing.Point(7, 135)
        Me.label_balistický_koeficient.Name = "label_balistický_koeficient"
        Me.label_balistický_koeficient.Size = New System.Drawing.Size(180, 25)
        Me.label_balistický_koeficient.TabIndex = 20
        Me.label_balistický_koeficient.Text = "Ballistic coefficient: "
        '
        'label_hmotnost_střely
        '
        Me.label_hmotnost_střely.AutoSize = True
        Me.label_hmotnost_střely.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_hmotnost_střely.Location = New System.Drawing.Point(7, 99)
        Me.label_hmotnost_střely.Name = "label_hmotnost_střely"
        Me.label_hmotnost_střely.Size = New System.Drawing.Size(132, 25)
        Me.label_hmotnost_střely.TabIndex = 19
        Me.label_hmotnost_střely.Text = "Bullet weight: "
        '
        'label_typ_střely
        '
        Me.label_typ_střely.AutoSize = True
        Me.label_typ_střely.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_typ_střely.Location = New System.Drawing.Point(7, 63)
        Me.label_typ_střely.Name = "label_typ_střely"
        Me.label_typ_střely.Size = New System.Drawing.Size(140, 25)
        Me.label_typ_střely.TabIndex = 18
        Me.label_typ_střely.Text = "Type of bullet: "
        '
        'button_načíst_střelu
        '
        Me.button_načíst_střelu.BackColor = System.Drawing.SystemColors.Window
        Me.button_načíst_střelu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_načíst_střelu.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.button_načíst_střelu.Location = New System.Drawing.Point(12, 195)
        Me.button_načíst_střelu.Name = "button_načíst_střelu"
        Me.button_načíst_střelu.Size = New System.Drawing.Size(482, 60)
        Me.button_načíst_střelu.TabIndex = 19
        Me.button_načíst_střelu.Text = "Load a bullet"
        Me.button_načíst_střelu.UseVisualStyleBackColor = False
        '
        'button_zavřít
        '
        Me.button_zavřít.BackColor = System.Drawing.SystemColors.Window
        Me.button_zavřít.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_zavřít.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.button_zavřít.Location = New System.Drawing.Point(500, 195)
        Me.button_zavřít.Name = "button_zavřít"
        Me.button_zavřít.Size = New System.Drawing.Size(482, 60)
        Me.button_zavřít.TabIndex = 20
        Me.button_zavřít.Text = "Close"
        Me.button_zavřít.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.checkbox_H_pistole)
        Me.GroupBox3.Controls.Add(Me.checkbox_federal_pistole)
        Me.GroupBox3.Controls.Add(Me.checkbox_SB_Pistole)
        Me.GroupBox3.Controls.Add(Me.checkbox_LEE)
        Me.GroupBox3.Controls.Add(Me.checkbox_LOS)
        Me.GroupBox3.Controls.Add(Me.checkbox_TNX_Pistole)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(361, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(133, 177)
        Me.GroupBox3.TabIndex = 33
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Handgun"
        '
        'checkbox_federal_pistole
        '
        Me.checkbox_federal_pistole.AutoSize = True
        Me.checkbox_federal_pistole.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_federal_pistole.Location = New System.Drawing.Point(10, 49)
        Me.checkbox_federal_pistole.Name = "checkbox_federal_pistole"
        Me.checkbox_federal_pistole.Size = New System.Drawing.Size(82, 24)
        Me.checkbox_federal_pistole.TabIndex = 32
        Me.checkbox_federal_pistole.Text = "Federal"
        Me.checkbox_federal_pistole.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.checkbox_SK_malorážka)
        Me.GroupBox4.Controls.Add(Me.checkbox_RWS_malorazka)
        Me.GroupBox4.Controls.Add(Me.checkbox_diabolky)
        Me.GroupBox4.Controls.Add(Me.checkbox_federal_malorážka)
        Me.GroupBox4.Controls.Add(Me.checkbox_SB_malorážka)
        Me.GroupBox4.Controls.Add(Me.checkbox_CCI)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(218, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(137, 177)
        Me.GroupBox4.TabIndex = 34
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Rimfire"
        '
        'checkbox_SK_malorážka
        '
        Me.checkbox_SK_malorážka.AutoSize = True
        Me.checkbox_SK_malorážka.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_SK_malorážka.Location = New System.Drawing.Point(10, 148)
        Me.checkbox_SK_malorážka.Name = "checkbox_SK_malorážka"
        Me.checkbox_SK_malorážka.Size = New System.Drawing.Size(49, 24)
        Me.checkbox_SK_malorážka.TabIndex = 34
        Me.checkbox_SK_malorážka.Text = "SK"
        Me.checkbox_SK_malorážka.UseVisualStyleBackColor = True
        '
        'checkbox_RWS_malorazka
        '
        Me.checkbox_RWS_malorazka.AutoSize = True
        Me.checkbox_RWS_malorazka.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_RWS_malorazka.Location = New System.Drawing.Point(10, 124)
        Me.checkbox_RWS_malorazka.Name = "checkbox_RWS_malorazka"
        Me.checkbox_RWS_malorazka.Size = New System.Drawing.Size(66, 24)
        Me.checkbox_RWS_malorazka.TabIndex = 33
        Me.checkbox_RWS_malorazka.Text = "RWS"
        Me.checkbox_RWS_malorazka.UseVisualStyleBackColor = True
        '
        'checkbox_H_pistole
        '
        Me.checkbox_H_pistole.AutoSize = True
        Me.checkbox_H_pistole.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_H_pistole.Location = New System.Drawing.Point(10, 74)
        Me.checkbox_H_pistole.Name = "checkbox_H_pistole"
        Me.checkbox_H_pistole.Size = New System.Drawing.Size(88, 24)
        Me.checkbox_H_pistole.TabIndex = 33
        Me.checkbox_H_pistole.Text = "Hornady"
        Me.checkbox_H_pistole.UseVisualStyleBackColor = True
        '
        'Seznam_střel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(994, 627)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.button_zavřít)
        Me.Controls.Add(Me.button_načíst_střelu)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1010, 666)
        Me.MinimumSize = New System.Drawing.Size(1010, 666)
        Me.Name = "Seznam_střel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List of bullets"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView1 As ListView
    Friend WithEvents první As ColumnHeader
    Friend WithEvents druhý As ColumnHeader
    Friend WithEvents třetí As ColumnHeader
    Friend WithEvents čtvrtý As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents checkbox_L As CheckBox
    Friend WithEvents checkbox_SB_Puška As CheckBox
    Friend WithEvents label_střela As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents label_typ_střely As Label
    Friend WithEvents label_balistický_koeficient As Label
    Friend WithEvents label_hmotnost_střely As Label
    Friend WithEvents button_načíst_střelu As Button
    Friend WithEvents button_zavřít As Button
    Friend WithEvents checkbox_Hornady As CheckBox
    Friend WithEvents checkbox_Sierra As CheckBox
    Friend WithEvents checkbox_LEE As CheckBox
    Friend WithEvents checkbox_LOS As CheckBox
    Friend WithEvents checkbox_SB_Pistole As CheckBox
    Friend WithEvents checkbox_Berger As CheckBox
    Friend WithEvents checkbox_TNX_Puška As CheckBox
    Friend WithEvents checkbox_TNX_Pistole As CheckBox
    Friend WithEvents checkbox_N As CheckBox
    Friend WithEvents checkbox_FOX As CheckBox
    Friend WithEvents checkbox_federal_puška As CheckBox
    Friend WithEvents checkbox_diabolky As CheckBox
    Friend WithEvents checkbox_federal_malorážka As CheckBox
    Friend WithEvents checkbox_CCI As CheckBox
    Friend WithEvents checkbox_SB_malorážka As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents checkbox_RWS_malorazka As CheckBox
    Friend WithEvents checkbox_RWS_puškové As CheckBox
    Friend WithEvents checkbox_federal_pistole As CheckBox
    Friend WithEvents checkbox_SK_malorážka As CheckBox
    Friend WithEvents checkbox_H_pistole As CheckBox
End Class
