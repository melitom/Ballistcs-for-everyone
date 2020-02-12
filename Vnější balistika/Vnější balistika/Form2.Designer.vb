<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vlastnosti_Atmosféry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vlastnosti_Atmosféry))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.combobox_hustota_vzduchu = New System.Windows.Forms.ComboBox()
        Me.combobox_nadmořská_výška = New System.Windows.Forms.ComboBox()
        Me.combobox_teplota_vzduchu = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Checkbox_Standardní_atmosféra_ICAO = New System.Windows.Forms.CheckBox()
        Me.Textbox_Nadmořská_výška = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Textbox_Teplota = New System.Windows.Forms.TextBox()
        Me.Textbox_Hustota_vzduchu = New System.Windows.Forms.TextBox()
        Me.Button_Spočítej = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radiobutton_S = New System.Windows.Forms.RadioButton()
        Me.radiobutton_N = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.radiobutton_SW = New System.Windows.Forms.RadioButton()
        Me.radiobutton_SE = New System.Windows.Forms.RadioButton()
        Me.radiobutton_NW = New System.Windows.Forms.RadioButton()
        Me.radiobutton_W = New System.Windows.Forms.RadioButton()
        Me.radiobutton_NE = New System.Windows.Forms.RadioButton()
        Me.radiobutton_E = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.checkbox_bezvětří = New System.Windows.Forms.CheckBox()
        Me.textbox_rychlost_větru = New System.Windows.Forms.TextBox()
        Me.combobox_rychlost_větru = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.combobox_hustota_vzduchu)
        Me.GroupBox5.Controls.Add(Me.combobox_nadmořská_výška)
        Me.GroupBox5.Controls.Add(Me.combobox_teplota_vzduchu)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Checkbox_Standardní_atmosféra_ICAO)
        Me.GroupBox5.Controls.Add(Me.Textbox_Nadmořská_výška)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Controls.Add(Me.Textbox_Teplota)
        Me.GroupBox5.Controls.Add(Me.Textbox_Hustota_vzduchu)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(202, 210)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Atmospheric conditions"
        '
        'combobox_hustota_vzduchu
        '
        Me.combobox_hustota_vzduchu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_hustota_vzduchu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_hustota_vzduchu.FormattingEnabled = True
        Me.combobox_hustota_vzduchu.Items.AddRange(New Object() {"kg/m³", "lb/ft³"})
        Me.combobox_hustota_vzduchu.Location = New System.Drawing.Point(120, 43)
        Me.combobox_hustota_vzduchu.Name = "combobox_hustota_vzduchu"
        Me.combobox_hustota_vzduchu.Size = New System.Drawing.Size(65, 24)
        Me.combobox_hustota_vzduchu.TabIndex = 27
        '
        'combobox_nadmořská_výška
        '
        Me.combobox_nadmořská_výška.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_nadmořská_výška.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_nadmořská_výška.FormattingEnabled = True
        Me.combobox_nadmořská_výška.Items.AddRange(New Object() {"m", "ft", "yd"})
        Me.combobox_nadmořská_výška.Location = New System.Drawing.Point(120, 172)
        Me.combobox_nadmořská_výška.Name = "combobox_nadmořská_výška"
        Me.combobox_nadmořská_výška.Size = New System.Drawing.Size(65, 24)
        Me.combobox_nadmořská_výška.TabIndex = 26
        '
        'combobox_teplota_vzduchu
        '
        Me.combobox_teplota_vzduchu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_teplota_vzduchu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_teplota_vzduchu.FormattingEnabled = True
        Me.combobox_teplota_vzduchu.Items.AddRange(New Object() {"°C", "°F"})
        Me.combobox_teplota_vzduchu.Location = New System.Drawing.Point(120, 121)
        Me.combobox_teplota_vzduchu.Name = "combobox_teplota_vzduchu"
        Me.combobox_teplota_vzduchu.Size = New System.Drawing.Size(65, 24)
        Me.combobox_teplota_vzduchu.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 101)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 17)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Air temperature"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 152)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 17)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Height above sea"
        '
        'Checkbox_Standardní_atmosféra_ICAO
        '
        Me.Checkbox_Standardní_atmosféra_ICAO.AutoSize = True
        Me.Checkbox_Standardní_atmosféra_ICAO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Checkbox_Standardní_atmosféra_ICAO.Location = New System.Drawing.Point(7, 73)
        Me.Checkbox_Standardní_atmosféra_ICAO.Name = "Checkbox_Standardní_atmosféra_ICAO"
        Me.Checkbox_Standardní_atmosféra_ICAO.Size = New System.Drawing.Size(191, 20)
        Me.Checkbox_Standardní_atmosféra_ICAO.TabIndex = 24
        Me.Checkbox_Standardní_atmosféra_ICAO.Text = "Standard atmosphere ICAO"
        Me.Checkbox_Standardní_atmosféra_ICAO.UseVisualStyleBackColor = True
        '
        'Textbox_Nadmořská_výška
        '
        Me.Textbox_Nadmořská_výška.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Textbox_Nadmořská_výška.Location = New System.Drawing.Point(7, 172)
        Me.Textbox_Nadmořská_výška.Name = "Textbox_Nadmořská_výška"
        Me.Textbox_Nadmořská_výška.Size = New System.Drawing.Size(107, 24)
        Me.Textbox_Nadmořská_výška.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Air density"
        '
        'Textbox_Teplota
        '
        Me.Textbox_Teplota.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Textbox_Teplota.Location = New System.Drawing.Point(7, 121)
        Me.Textbox_Teplota.Name = "Textbox_Teplota"
        Me.Textbox_Teplota.Size = New System.Drawing.Size(107, 24)
        Me.Textbox_Teplota.TabIndex = 12
        '
        'Textbox_Hustota_vzduchu
        '
        Me.Textbox_Hustota_vzduchu.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Textbox_Hustota_vzduchu.Location = New System.Drawing.Point(7, 43)
        Me.Textbox_Hustota_vzduchu.Name = "Textbox_Hustota_vzduchu"
        Me.Textbox_Hustota_vzduchu.Size = New System.Drawing.Size(107, 24)
        Me.Textbox_Hustota_vzduchu.TabIndex = 12
        '
        'Button_Spočítej
        '
        Me.Button_Spočítej.BackColor = System.Drawing.SystemColors.Window
        Me.Button_Spočítej.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button_Spočítej.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button_Spočítej.Location = New System.Drawing.Point(12, 228)
        Me.Button_Spočítej.Name = "Button_Spočítej"
        Me.Button_Spočítej.Size = New System.Drawing.Size(618, 57)
        Me.Button_Spočítej.TabIndex = 12
        Me.Button_Spočítej.Text = "Save and Close"
        Me.Button_Spočítej.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radiobutton_S)
        Me.GroupBox1.Controls.Add(Me.radiobutton_N)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.radiobutton_SW)
        Me.GroupBox1.Controls.Add(Me.radiobutton_SE)
        Me.GroupBox1.Controls.Add(Me.radiobutton_NW)
        Me.GroupBox1.Controls.Add(Me.radiobutton_W)
        Me.GroupBox1.Controls.Add(Me.radiobutton_NE)
        Me.GroupBox1.Controls.Add(Me.radiobutton_E)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(428, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(202, 210)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Wind direction"
        '
        'radiobutton_S
        '
        Me.radiobutton_S.AutoSize = True
        Me.radiobutton_S.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.radiobutton_S.Location = New System.Drawing.Point(83, 176)
        Me.radiobutton_S.Name = "radiobutton_S"
        Me.radiobutton_S.Size = New System.Drawing.Size(35, 21)
        Me.radiobutton_S.TabIndex = 62
        Me.radiobutton_S.TabStop = True
        Me.radiobutton_S.Text = "S"
        Me.radiobutton_S.UseVisualStyleBackColor = True
        '
        'radiobutton_N
        '
        Me.radiobutton_N.AutoSize = True
        Me.radiobutton_N.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.radiobutton_N.Location = New System.Drawing.Point(83, 28)
        Me.radiobutton_N.Name = "radiobutton_N"
        Me.radiobutton_N.Size = New System.Drawing.Size(36, 21)
        Me.radiobutton_N.TabIndex = 61
        Me.radiobutton_N.TabStop = True
        Me.radiobutton_N.Text = "N"
        Me.radiobutton_N.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 33.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.Location = New System.Drawing.Point(70, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 52)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "↑"
        '
        'radiobutton_SW
        '
        Me.radiobutton_SW.AutoSize = True
        Me.radiobutton_SW.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.radiobutton_SW.Location = New System.Drawing.Point(49, 142)
        Me.radiobutton_SW.Name = "radiobutton_SW"
        Me.radiobutton_SW.Size = New System.Drawing.Size(48, 21)
        Me.radiobutton_SW.TabIndex = 59
        Me.radiobutton_SW.TabStop = True
        Me.radiobutton_SW.Text = "SW"
        Me.radiobutton_SW.UseVisualStyleBackColor = True
        '
        'radiobutton_SE
        '
        Me.radiobutton_SE.AutoSize = True
        Me.radiobutton_SE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.radiobutton_SE.Location = New System.Drawing.Point(118, 142)
        Me.radiobutton_SE.Name = "radiobutton_SE"
        Me.radiobutton_SE.Size = New System.Drawing.Size(44, 21)
        Me.radiobutton_SE.TabIndex = 57
        Me.radiobutton_SE.TabStop = True
        Me.radiobutton_SE.Text = "SE"
        Me.radiobutton_SE.UseVisualStyleBackColor = True
        '
        'radiobutton_NW
        '
        Me.radiobutton_NW.AutoSize = True
        Me.radiobutton_NW.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.radiobutton_NW.Location = New System.Drawing.Point(49, 62)
        Me.radiobutton_NW.Name = "radiobutton_NW"
        Me.radiobutton_NW.Size = New System.Drawing.Size(49, 21)
        Me.radiobutton_NW.TabIndex = 58
        Me.radiobutton_NW.TabStop = True
        Me.radiobutton_NW.Text = "NW"
        Me.radiobutton_NW.UseVisualStyleBackColor = True
        '
        'radiobutton_W
        '
        Me.radiobutton_W.AutoSize = True
        Me.radiobutton_W.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.radiobutton_W.Location = New System.Drawing.Point(17, 102)
        Me.radiobutton_W.Name = "radiobutton_W"
        Me.radiobutton_W.Size = New System.Drawing.Size(39, 21)
        Me.radiobutton_W.TabIndex = 55
        Me.radiobutton_W.TabStop = True
        Me.radiobutton_W.Text = "W"
        Me.radiobutton_W.UseVisualStyleBackColor = True
        '
        'radiobutton_NE
        '
        Me.radiobutton_NE.AutoSize = True
        Me.radiobutton_NE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.radiobutton_NE.Location = New System.Drawing.Point(117, 62)
        Me.radiobutton_NE.Name = "radiobutton_NE"
        Me.radiobutton_NE.Size = New System.Drawing.Size(45, 21)
        Me.radiobutton_NE.TabIndex = 54
        Me.radiobutton_NE.TabStop = True
        Me.radiobutton_NE.Text = "NE"
        Me.radiobutton_NE.UseVisualStyleBackColor = True
        '
        'radiobutton_E
        '
        Me.radiobutton_E.AutoSize = True
        Me.radiobutton_E.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.radiobutton_E.Location = New System.Drawing.Point(148, 102)
        Me.radiobutton_E.Name = "radiobutton_E"
        Me.radiobutton_E.Size = New System.Drawing.Size(35, 21)
        Me.radiobutton_E.TabIndex = 56
        Me.radiobutton_E.TabStop = True
        Me.radiobutton_E.Text = "E"
        Me.radiobutton_E.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Wind speed"
        '
        'checkbox_bezvětří
        '
        Me.checkbox_bezvětří.AutoSize = True
        Me.checkbox_bezvětří.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.checkbox_bezvětří.Location = New System.Drawing.Point(9, 71)
        Me.checkbox_bezvětří.Name = "checkbox_bezvětří"
        Me.checkbox_bezvětří.Size = New System.Drawing.Size(85, 22)
        Me.checkbox_bezvětří.TabIndex = 22
        Me.checkbox_bezvětří.Text = "No Wind"
        Me.checkbox_bezvětří.UseVisualStyleBackColor = True
        '
        'textbox_rychlost_větru
        '
        Me.textbox_rychlost_větru.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_rychlost_větru.Location = New System.Drawing.Point(7, 41)
        Me.textbox_rychlost_větru.Name = "textbox_rychlost_větru"
        Me.textbox_rychlost_větru.Size = New System.Drawing.Size(107, 24)
        Me.textbox_rychlost_větru.TabIndex = 12
        '
        'combobox_rychlost_větru
        '
        Me.combobox_rychlost_větru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_rychlost_větru.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.combobox_rychlost_větru.FormattingEnabled = True
        Me.combobox_rychlost_větru.Items.AddRange(New Object() {"km/h", "mph", "m/s", "fps"})
        Me.combobox_rychlost_větru.Location = New System.Drawing.Point(120, 41)
        Me.combobox_rychlost_větru.Name = "combobox_rychlost_větru"
        Me.combobox_rychlost_větru.Size = New System.Drawing.Size(65, 24)
        Me.combobox_rychlost_větru.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.combobox_rychlost_větru)
        Me.GroupBox2.Controls.Add(Me.textbox_rychlost_větru)
        Me.GroupBox2.Controls.Add(Me.checkbox_bezvětří)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(220, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(202, 210)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Wind speed"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(195, 90)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Black arrow indicates the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "position and direction of " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "movement of the bullet." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "T" &
    "he wind direction is always " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "indicated towards the bullet."
        '
        'Vlastnosti_Atmosféry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(643, 295)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button_Spočítej)
        Me.Controls.Add(Me.GroupBox5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(659, 334)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(659, 334)
        Me.Name = "Vlastnosti_Atmosféry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Atmospheric and Wind conditions"
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Checkbox_Standardní_atmosféra_ICAO As CheckBox
    Friend WithEvents Textbox_Nadmořská_výška As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Textbox_Teplota As TextBox
    Friend WithEvents Textbox_Hustota_vzduchu As TextBox
    Friend WithEvents Button_Spočítej As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents textbox_rychlost_větru As TextBox
    Friend WithEvents combobox_rychlost_větru As ComboBox
    Friend WithEvents checkbox_bezvětří As CheckBox
    Friend WithEvents combobox_hustota_vzduchu As ComboBox
    Friend WithEvents combobox_nadmořská_výška As ComboBox
    Friend WithEvents combobox_teplota_vzduchu As ComboBox
    Friend WithEvents radiobutton_S As RadioButton
    Friend WithEvents radiobutton_N As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents radiobutton_SW As RadioButton
    Friend WithEvents radiobutton_SE As RadioButton
    Friend WithEvents radiobutton_NW As RadioButton
    Friend WithEvents radiobutton_W As RadioButton
    Friend WithEvents radiobutton_NE As RadioButton
    Friend WithEvents radiobutton_E As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
End Class
