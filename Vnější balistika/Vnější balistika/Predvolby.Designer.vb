<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Predvolby
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Predvolby))
        Me.button_zavřít = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.textbox_název_střely = New System.Windows.Forms.TextBox()
        Me.textbox_název_převolby = New System.Windows.Forms.TextBox()
        Me.button_načíst = New System.Windows.Forms.Button()
        Me.button_uložit = New System.Windows.Forms.Button()
        Me.button_smazat = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'button_zavřít
        '
        Me.button_zavřít.BackColor = System.Drawing.SystemColors.Window
        Me.button_zavřít.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_zavřít.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.button_zavřít.Location = New System.Drawing.Point(11, 481)
        Me.button_zavřít.Name = "button_zavřít"
        Me.button_zavřít.Size = New System.Drawing.Size(604, 60)
        Me.button_zavřít.TabIndex = 21
        Me.button_zavřít.Text = "Close"
        Me.button_zavřít.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 158)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(604, 248)
        Me.ListView1.TabIndex = 22
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.textbox_název_střely)
        Me.GroupBox1.Controls.Add(Me.textbox_název_převolby)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(297, 135)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Save preset"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Bullet name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 17)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Preset name"
        '
        'textbox_název_střely
        '
        Me.textbox_název_střely.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_název_střely.Location = New System.Drawing.Point(9, 98)
        Me.textbox_název_střely.Name = "textbox_název_střely"
        Me.textbox_název_střely.Size = New System.Drawing.Size(265, 24)
        Me.textbox_název_střely.TabIndex = 25
        '
        'textbox_název_převolby
        '
        Me.textbox_název_převolby.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.textbox_název_převolby.Location = New System.Drawing.Point(9, 45)
        Me.textbox_název_převolby.Name = "textbox_název_převolby"
        Me.textbox_název_převolby.Size = New System.Drawing.Size(265, 24)
        Me.textbox_název_převolby.TabIndex = 24
        '
        'button_načíst
        '
        Me.button_načíst.BackColor = System.Drawing.SystemColors.Window
        Me.button_načíst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_načíst.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.button_načíst.Location = New System.Drawing.Point(11, 415)
        Me.button_načíst.Name = "button_načíst"
        Me.button_načíst.Size = New System.Drawing.Size(604, 60)
        Me.button_načíst.TabIndex = 24
        Me.button_načíst.Text = "Load preset"
        Me.button_načíst.UseVisualStyleBackColor = False
        '
        'button_uložit
        '
        Me.button_uložit.BackColor = System.Drawing.SystemColors.Window
        Me.button_uložit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_uložit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.button_uložit.Location = New System.Drawing.Point(315, 21)
        Me.button_uložit.Name = "button_uložit"
        Me.button_uložit.Size = New System.Drawing.Size(301, 60)
        Me.button_uložit.TabIndex = 25
        Me.button_uložit.Text = "Save"
        Me.button_uložit.UseVisualStyleBackColor = False
        '
        'button_smazat
        '
        Me.button_smazat.BackColor = System.Drawing.SystemColors.Window
        Me.button_smazat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.button_smazat.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.button_smazat.Location = New System.Drawing.Point(315, 87)
        Me.button_smazat.Name = "button_smazat"
        Me.button_smazat.Size = New System.Drawing.Size(301, 60)
        Me.button_smazat.TabIndex = 26
        Me.button_smazat.Text = "Delete"
        Me.button_smazat.UseVisualStyleBackColor = False
        '
        'Predvolby
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(627, 552)
        Me.ControlBox = False
        Me.Controls.Add(Me.button_smazat)
        Me.Controls.Add(Me.button_uložit)
        Me.Controls.Add(Me.button_načíst)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.button_zavřít)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(643, 591)
        Me.MinimumSize = New System.Drawing.Size(643, 591)
        Me.Name = "Predvolby"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Presets"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents button_zavřít As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents textbox_název_střely As TextBox
    Friend WithEvents textbox_název_převolby As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents button_načíst As Button
    Friend WithEvents button_uložit As Button
    Friend WithEvents button_smazat As Button
End Class
