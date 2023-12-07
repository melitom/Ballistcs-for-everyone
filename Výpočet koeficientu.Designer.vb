<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vypocet_koeficientu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vypocet_koeficientu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textbox_první_rychlost = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.combobox_prvni_vzdalenost = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textbox_první_vzdálenost = New System.Windows.Forms.TextBox()
        Me.combobox_první_rychlost = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.combobox_druha_vzdalenost = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.textbox_druhá_vzdálenost = New System.Windows.Forms.TextBox()
        Me.combobox_druhá_rychlost = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.textbox_druhá_rychlost = New System.Windows.Forms.TextBox()
        Me.Button_Spočítej = New System.Windows.Forms.Button()
        Me.Zavřít = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.label_balistický_koeficient_JSBE = New System.Windows.Forms.Label()
        Me.label_balistický_koeficient_G7 = New System.Windows.Forms.Label()
        Me.label_balistický_koeficient_G1 = New System.Windows.Forms.Label()
        Me.label_nadmořská_výška = New System.Windows.Forms.Label()
        Me.label_teplota_vzduchu = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Velocity"
        '
        'textbox_první_rychlost
        '
        Me.textbox_první_rychlost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_první_rychlost.Location = New System.Drawing.Point(9, 43)
        Me.textbox_první_rychlost.Name = "textbox_první_rychlost"
        Me.textbox_první_rychlost.Size = New System.Drawing.Size(106, 24)
        Me.textbox_první_rychlost.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.combobox_prvni_vzdalenost)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.textbox_první_vzdálenost)
        Me.GroupBox1.Controls.Add(Me.combobox_první_rychlost)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.textbox_první_rychlost)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(208, 135)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "First measurement"
        '
        'combobox_prvni_vzdalenost
        '
        Me.combobox_prvni_vzdalenost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_prvni_vzdalenost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_prvni_vzdalenost.FormattingEnabled = True
        Me.combobox_prvni_vzdalenost.Items.AddRange(New Object() {"m", "ft", "yd"})
        Me.combobox_prvni_vzdalenost.Location = New System.Drawing.Point(121, 95)
        Me.combobox_prvni_vzdalenost.Name = "combobox_prvni_vzdalenost"
        Me.combobox_prvni_vzdalenost.Size = New System.Drawing.Size(65, 24)
        Me.combobox_prvni_vzdalenost.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Chronograph distance"
        '
        'textbox_první_vzdálenost
        '
        Me.textbox_první_vzdálenost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_první_vzdálenost.Location = New System.Drawing.Point(9, 95)
        Me.textbox_první_vzdálenost.Name = "textbox_první_vzdálenost"
        Me.textbox_první_vzdálenost.Size = New System.Drawing.Size(106, 24)
        Me.textbox_první_vzdálenost.TabIndex = 12
        '
        'combobox_první_rychlost
        '
        Me.combobox_první_rychlost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_první_rychlost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_první_rychlost.FormattingEnabled = True
        Me.combobox_první_rychlost.Items.AddRange(New Object() {"m/s", "fps"})
        Me.combobox_první_rychlost.Location = New System.Drawing.Point(121, 43)
        Me.combobox_první_rychlost.Name = "combobox_první_rychlost"
        Me.combobox_první_rychlost.Size = New System.Drawing.Size(65, 24)
        Me.combobox_první_rychlost.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.combobox_druha_vzdalenost)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.textbox_druhá_vzdálenost)
        Me.GroupBox2.Controls.Add(Me.combobox_druhá_rychlost)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.textbox_druhá_rychlost)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(227, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(208, 135)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Second measurement"
        '
        'combobox_druha_vzdalenost
        '
        Me.combobox_druha_vzdalenost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_druha_vzdalenost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_druha_vzdalenost.FormattingEnabled = True
        Me.combobox_druha_vzdalenost.Items.AddRange(New Object() {"m", "ft", "yd"})
        Me.combobox_druha_vzdalenost.Location = New System.Drawing.Point(121, 95)
        Me.combobox_druha_vzdalenost.Name = "combobox_druha_vzdalenost"
        Me.combobox_druha_vzdalenost.Size = New System.Drawing.Size(65, 24)
        Me.combobox_druha_vzdalenost.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Chronograph distance"
        '
        'textbox_druhá_vzdálenost
        '
        Me.textbox_druhá_vzdálenost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_druhá_vzdálenost.Location = New System.Drawing.Point(9, 95)
        Me.textbox_druhá_vzdálenost.Name = "textbox_druhá_vzdálenost"
        Me.textbox_druhá_vzdálenost.Size = New System.Drawing.Size(106, 24)
        Me.textbox_druhá_vzdálenost.TabIndex = 12
        '
        'combobox_druhá_rychlost
        '
        Me.combobox_druhá_rychlost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_druhá_rychlost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_druhá_rychlost.FormattingEnabled = True
        Me.combobox_druhá_rychlost.Items.AddRange(New Object() {"m/s", "fps"})
        Me.combobox_druhá_rychlost.Location = New System.Drawing.Point(121, 43)
        Me.combobox_druhá_rychlost.Name = "combobox_druhá_rychlost"
        Me.combobox_druhá_rychlost.Size = New System.Drawing.Size(65, 24)
        Me.combobox_druhá_rychlost.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Velocity"
        '
        'textbox_druhá_rychlost
        '
        Me.textbox_druhá_rychlost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_druhá_rychlost.Location = New System.Drawing.Point(9, 43)
        Me.textbox_druhá_rychlost.Name = "textbox_druhá_rychlost"
        Me.textbox_druhá_rychlost.Size = New System.Drawing.Size(106, 24)
        Me.textbox_druhá_rychlost.TabIndex = 5
        '
        'Button_Spočítej
        '
        Me.Button_Spočítej.BackColor = System.Drawing.SystemColors.Window
        Me.Button_Spočítej.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Spočítej.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button_Spočítej.Location = New System.Drawing.Point(12, 338)
        Me.Button_Spočítej.Name = "Button_Spočítej"
        Me.Button_Spočítej.Size = New System.Drawing.Size(208, 55)
        Me.Button_Spočítej.TabIndex = 22
        Me.Button_Spočítej.Text = "Calculate"
        Me.Button_Spočítej.UseVisualStyleBackColor = False
        '
        'Zavřít
        '
        Me.Zavřít.BackColor = System.Drawing.SystemColors.Window
        Me.Zavřít.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Zavřít.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Zavřít.Location = New System.Drawing.Point(227, 338)
        Me.Zavřít.Name = "Zavřít"
        Me.Zavřít.Size = New System.Drawing.Size(208, 55)
        Me.Zavřít.TabIndex = 23
        Me.Zavřít.Text = "Close"
        Me.Zavřít.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.label_balistický_koeficient_JSBE)
        Me.GroupBox4.Controls.Add(Me.label_balistický_koeficient_G7)
        Me.GroupBox4.Controls.Add(Me.label_balistický_koeficient_G1)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 212)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(423, 119)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Calculation result"
        '
        'label_balistický_koeficient_JSBE
        '
        Me.label_balistický_koeficient_JSBE.AutoSize = True
        Me.label_balistický_koeficient_JSBE.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_balistický_koeficient_JSBE.Location = New System.Drawing.Point(6, 83)
        Me.label_balistický_koeficient_JSBE.Name = "label_balistický_koeficient_JSBE"
        Me.label_balistický_koeficient_JSBE.Size = New System.Drawing.Size(236, 25)
        Me.label_balistický_koeficient_JSBE.TabIndex = 29
        Me.label_balistický_koeficient_JSBE.Text = "Ballistic coefficient JSBE: "
        '
        'label_balistický_koeficient_G7
        '
        Me.label_balistický_koeficient_G7.AutoSize = True
        Me.label_balistický_koeficient_G7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_balistický_koeficient_G7.Location = New System.Drawing.Point(6, 52)
        Me.label_balistický_koeficient_G7.Name = "label_balistický_koeficient_G7"
        Me.label_balistický_koeficient_G7.Size = New System.Drawing.Size(211, 25)
        Me.label_balistický_koeficient_G7.TabIndex = 26
        Me.label_balistický_koeficient_G7.Text = "Ballistic coefficient G7: "
        '
        'label_balistický_koeficient_G1
        '
        Me.label_balistický_koeficient_G1.AutoSize = True
        Me.label_balistický_koeficient_G1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_balistický_koeficient_G1.Location = New System.Drawing.Point(6, 21)
        Me.label_balistický_koeficient_G1.Name = "label_balistický_koeficient_G1"
        Me.label_balistický_koeficient_G1.Size = New System.Drawing.Size(211, 25)
        Me.label_balistický_koeficient_G1.TabIndex = 25
        Me.label_balistický_koeficient_G1.Text = "Ballistic coefficient G1: "
        '
        'label_nadmořská_výška
        '
        Me.label_nadmořská_výška.AutoSize = True
        Me.label_nadmořská_výška.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_nadmořská_výška.Location = New System.Drawing.Point(12, 183)
        Me.label_nadmořská_výška.Name = "label_nadmořská_výška"
        Me.label_nadmořská_výška.Size = New System.Drawing.Size(75, 17)
        Me.label_nadmořská_výška.TabIndex = 27
        Me.label_nadmořská_výška.Text = "Elevation"
        '
        'label_teplota_vzduchu
        '
        Me.label_teplota_vzduchu.AutoSize = True
        Me.label_teplota_vzduchu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.label_teplota_vzduchu.Location = New System.Drawing.Point(12, 157)
        Me.label_teplota_vzduchu.Name = "label_teplota_vzduchu"
        Me.label_teplota_vzduchu.Size = New System.Drawing.Size(121, 17)
        Me.label_teplota_vzduchu.TabIndex = 26
        Me.label_teplota_vzduchu.Text = "Air temperature"
        '
        'Vypocet_koeficientu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(447, 402)
        Me.ControlBox = False
        Me.Controls.Add(Me.label_nadmořská_výška)
        Me.Controls.Add(Me.label_teplota_vzduchu)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Zavřít)
        Me.Controls.Add(Me.Button_Spočítej)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(463, 441)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(463, 441)
        Me.Name = "Vypocet_koeficientu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculations of ballistic coefficients"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents textbox_první_rychlost As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents combobox_první_rychlost As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents textbox_první_vzdálenost As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents textbox_druhá_vzdálenost As TextBox
    Friend WithEvents combobox_druhá_rychlost As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents textbox_druhá_rychlost As TextBox
    Friend WithEvents Button_Spočítej As Button
    Friend WithEvents Zavřít As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents label_balistický_koeficient_G1 As Label
    Friend WithEvents label_balistický_koeficient_G7 As Label
    Friend WithEvents label_nadmořská_výška As Label
    Friend WithEvents label_teplota_vzduchu As Label
    Friend WithEvents combobox_prvni_vzdalenost As ComboBox
    Friend WithEvents combobox_druha_vzdalenost As ComboBox
    Friend WithEvents label_balistický_koeficient_JSBE As Label
End Class
