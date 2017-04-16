<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlSettingsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlSettingsForm))
        Me.SetButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.HeadingLabel = New System.Windows.Forms.Label()
        Me.TdTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.TiTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.KpTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.PPIPIDgroup = New System.Windows.Forms.Panel()
        Me.pradio = New System.Windows.Forms.RadioButton()
        Me.pidradio = New System.Windows.Forms.RadioButton()
        Me.piradio = New System.Windows.Forms.RadioButton()
        Me.tdlbl = New System.Windows.Forms.Label()
        Me.tilbl = New System.Windows.Forms.Label()
        Me.kplbl = New System.Windows.Forms.Label()
        Me.TdTrackBar = New MPCD.TrackBar()
        Me.TiTrackBar = New MPCD.TrackBar()
        Me.KpTrackBar = New MPCD.TrackBar()
        Me.Panel1.SuspendLayout()
        Me.PPIPIDgroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'SetButton
        '
        Me.SetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetButton.Location = New System.Drawing.Point(170, 186)
        Me.SetButton.Name = "SetButton"
        Me.SetButton.Size = New System.Drawing.Size(75, 29)
        Me.SetButton.TabIndex = 131
        Me.SetButton.Text = "Set"
        Me.SetButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.HeadingLabel)
        Me.Panel1.Controls.Add(Me.TdTextBox)
        Me.Panel1.Controls.Add(Me.TiTextBox)
        Me.Panel1.Controls.Add(Me.KpTextBox)
        Me.Panel1.Controls.Add(Me.PPIPIDgroup)
        Me.Panel1.Controls.Add(Me.tdlbl)
        Me.Panel1.Controls.Add(Me.tilbl)
        Me.Panel1.Controls.Add(Me.kplbl)
        Me.Panel1.Controls.Add(Me.TdTrackBar)
        Me.Panel1.Controls.Add(Me.TiTrackBar)
        Me.Panel1.Controls.Add(Me.KpTrackBar)
        Me.Panel1.Controls.Add(Me.SetButton)
        Me.Panel1.Location = New System.Drawing.Point(6, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(277, 230)
        Me.Panel1.TabIndex = 132
        '
        'HeadingLabel
        '
        Me.HeadingLabel.AutoSize = True
        Me.HeadingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeadingLabel.Location = New System.Drawing.Point(8, 8)
        Me.HeadingLabel.Name = "HeadingLabel"
        Me.HeadingLabel.Size = New System.Drawing.Size(187, 17)
        Me.HeadingLabel.TabIndex = 147
        Me.HeadingLabel.Text = "Process Control Settings"
        '
        'TdTextBox
        '
        Me.TdTextBox.Location = New System.Drawing.Point(210, 148)
        Me.TdTextBox.Mask = "000"
        Me.TdTextBox.Name = "TdTextBox"
        Me.TdTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TdTextBox.Size = New System.Drawing.Size(35, 20)
        Me.TdTextBox.TabIndex = 139
        '
        'TiTextBox
        '
        Me.TiTextBox.Location = New System.Drawing.Point(210, 116)
        Me.TiTextBox.Mask = "000"
        Me.TiTextBox.Name = "TiTextBox"
        Me.TiTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TiTextBox.Size = New System.Drawing.Size(35, 20)
        Me.TiTextBox.TabIndex = 138
        '
        'KpTextBox
        '
        Me.KpTextBox.Location = New System.Drawing.Point(210, 81)
        Me.KpTextBox.Mask = "000"
        Me.KpTextBox.Name = "KpTextBox"
        Me.KpTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.KpTextBox.Size = New System.Drawing.Size(35, 20)
        Me.KpTextBox.TabIndex = 137
        '
        'PPIPIDgroup
        '
        Me.PPIPIDgroup.BackColor = System.Drawing.Color.Transparent
        Me.PPIPIDgroup.Controls.Add(Me.pradio)
        Me.PPIPIDgroup.Controls.Add(Me.pidradio)
        Me.PPIPIDgroup.Controls.Add(Me.piradio)
        Me.PPIPIDgroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PPIPIDgroup.Location = New System.Drawing.Point(11, 39)
        Me.PPIPIDgroup.Name = "PPIPIDgroup"
        Me.PPIPIDgroup.Size = New System.Drawing.Size(196, 26)
        Me.PPIPIDgroup.TabIndex = 135
        '
        'pradio
        '
        Me.pradio.AutoSize = True
        Me.pradio.BackColor = System.Drawing.Color.Transparent
        Me.pradio.Checked = True
        Me.pradio.Location = New System.Drawing.Point(8, 3)
        Me.pradio.Name = "pradio"
        Me.pradio.Size = New System.Drawing.Size(35, 20)
        Me.pradio.TabIndex = 9
        Me.pradio.TabStop = True
        Me.pradio.Text = "P"
        Me.pradio.UseVisualStyleBackColor = False
        '
        'pidradio
        '
        Me.pidradio.AutoSize = True
        Me.pidradio.BackColor = System.Drawing.Color.Transparent
        Me.pidradio.Location = New System.Drawing.Point(105, 3)
        Me.pidradio.Name = "pidradio"
        Me.pidradio.Size = New System.Drawing.Size(48, 20)
        Me.pidradio.TabIndex = 11
        Me.pidradio.Text = "PID"
        Me.pidradio.UseVisualStyleBackColor = False
        '
        'piradio
        '
        Me.piradio.AutoSize = True
        Me.piradio.BackColor = System.Drawing.Color.Transparent
        Me.piradio.Location = New System.Drawing.Point(59, 3)
        Me.piradio.Name = "piradio"
        Me.piradio.Size = New System.Drawing.Size(38, 20)
        Me.piradio.TabIndex = 10
        Me.piradio.Text = "PI"
        Me.piradio.UseVisualStyleBackColor = False
        '
        'tdlbl
        '
        Me.tdlbl.AutoSize = True
        Me.tdlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tdlbl.Location = New System.Drawing.Point(0, 148)
        Me.tdlbl.Name = "tdlbl"
        Me.tdlbl.Size = New System.Drawing.Size(58, 16)
        Me.tdlbl.TabIndex = 143
        Me.tdlbl.Text = "Td (sec)"
        '
        'tilbl
        '
        Me.tilbl.AutoSize = True
        Me.tilbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tilbl.Location = New System.Drawing.Point(4, 117)
        Me.tilbl.Name = "tilbl"
        Me.tilbl.Size = New System.Drawing.Size(53, 16)
        Me.tilbl.TabIndex = 142
        Me.tilbl.Text = "Ti (sec)"
        '
        'kplbl
        '
        Me.kplbl.AutoSize = True
        Me.kplbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kplbl.Location = New System.Drawing.Point(10, 84)
        Me.kplbl.Name = "kplbl"
        Me.kplbl.Size = New System.Drawing.Size(47, 16)
        Me.kplbl.TabIndex = 141
        Me.kplbl.Text = "Kp (%)"
        '
        'TdTrackBar
        '
        Me.TdTrackBar._CouleurA = System.Drawing.Color.Teal
        Me.TdTrackBar._CouleurCurseur = System.Drawing.Color.WhiteSmoke
        Me.TdTrackBar._CouleurDe = System.Drawing.Color.Teal
        Me.TdTrackBar._Curseur = MPCD.TrackBar.TypeCurseur.Losange
        Me.TdTrackBar._Epaisseur = 15
        Me.TdTrackBar._Maximum = 120
        Me.TdTrackBar._Minimum = 0
        Me.TdTrackBar._ModeleCouleur = MPCD.TrackBar.MyColor.PasDeModele
        Me.TdTrackBar._PasDeGraduation = 1
        Me.TdTrackBar._Style = MPCD.TrackBar.MyStyle.Texte
        Me.TdTrackBar._Valeur = 80
        Me.TdTrackBar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TdTrackBar.Location = New System.Drawing.Point(55, 145)
        Me.TdTrackBar.Margin = New System.Windows.Forms.Padding(0)
        Me.TdTrackBar.Name = "TdTrackBar"
        Me.TdTrackBar.Size = New System.Drawing.Size(157, 25)
        Me.TdTrackBar.TabIndex = 146
        Me.TdTrackBar.Text = "TrackBar3"
        '
        'TiTrackBar
        '
        Me.TiTrackBar._CouleurA = System.Drawing.Color.Teal
        Me.TiTrackBar._CouleurCurseur = System.Drawing.Color.WhiteSmoke
        Me.TiTrackBar._CouleurDe = System.Drawing.Color.Teal
        Me.TiTrackBar._Curseur = MPCD.TrackBar.TypeCurseur.Losange
        Me.TiTrackBar._Epaisseur = 15
        Me.TiTrackBar._Maximum = 120
        Me.TiTrackBar._Minimum = 0
        Me.TiTrackBar._ModeleCouleur = MPCD.TrackBar.MyColor.PasDeModele
        Me.TiTrackBar._PasDeGraduation = 1
        Me.TiTrackBar._Style = MPCD.TrackBar.MyStyle.Texte
        Me.TiTrackBar._Valeur = 50
        Me.TiTrackBar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TiTrackBar.Location = New System.Drawing.Point(55, 113)
        Me.TiTrackBar.Margin = New System.Windows.Forms.Padding(0)
        Me.TiTrackBar.Name = "TiTrackBar"
        Me.TiTrackBar.Size = New System.Drawing.Size(156, 25)
        Me.TiTrackBar.TabIndex = 145
        Me.TiTrackBar.Text = "TrackBar2"
        '
        'KpTrackBar
        '
        Me.KpTrackBar._CouleurA = System.Drawing.Color.Teal
        Me.KpTrackBar._CouleurCurseur = System.Drawing.Color.WhiteSmoke
        Me.KpTrackBar._CouleurDe = System.Drawing.Color.Teal
        Me.KpTrackBar._Curseur = MPCD.TrackBar.TypeCurseur.Losange
        Me.KpTrackBar._Epaisseur = 15
        Me.KpTrackBar._Maximum = 100
        Me.KpTrackBar._Minimum = 0
        Me.KpTrackBar._ModeleCouleur = MPCD.TrackBar.MyColor.PasDeModele
        Me.KpTrackBar._PasDeGraduation = 1
        Me.KpTrackBar._Style = MPCD.TrackBar.MyStyle.Texte
        Me.KpTrackBar._Valeur = 30
        Me.KpTrackBar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KpTrackBar.Location = New System.Drawing.Point(55, 77)
        Me.KpTrackBar.Margin = New System.Windows.Forms.Padding(0)
        Me.KpTrackBar.Name = "KpTrackBar"
        Me.KpTrackBar.Size = New System.Drawing.Size(157, 25)
        Me.KpTrackBar.TabIndex = 132
        Me.KpTrackBar.Text = "TrackBar1"
        '
        'ControlSettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(289, 246)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ControlSettingsForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Process Control Settings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PPIPIDgroup.ResumeLayout(False)
        Me.PPIPIDgroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SetButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents HeadingLabel As System.Windows.Forms.Label
    Friend WithEvents TdTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TiTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents KpTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents PPIPIDgroup As System.Windows.Forms.Panel
    Friend WithEvents pradio As System.Windows.Forms.RadioButton
    Friend WithEvents pidradio As System.Windows.Forms.RadioButton
    Friend WithEvents piradio As System.Windows.Forms.RadioButton
    Friend WithEvents tdlbl As System.Windows.Forms.Label
    Friend WithEvents tilbl As System.Windows.Forms.Label
    Friend WithEvents kplbl As System.Windows.Forms.Label
    Friend WithEvents TdTrackBar As MPCD.TrackBar
    Friend WithEvents TiTrackBar As MPCD.TrackBar
    Friend WithEvents KpTrackBar As MPCD.TrackBar
End Class
