<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LTSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LTSettings))
        Me.PIRadio = New System.Windows.Forms.RadioButton()
        Me.HysterisisUpDn = New System.Windows.Forms.NumericUpDown()
        Me.HysterisisLabel = New System.Windows.Forms.Label()
        Me.OnOffRadio = New System.Windows.Forms.RadioButton()
        Me.PRadio = New System.Windows.Forms.RadioButton()
        Me.CloseLoopRadio = New System.Windows.Forms.RadioButton()
        Me.PIDRadio1 = New System.Windows.Forms.RadioButton()
        Me.OpenLoopRadio = New System.Windows.Forms.RadioButton()
        Me.KpTrackBar = New MPCD.TrackBar()
        Me.OnOffPIDGroup = New System.Windows.Forms.GroupBox()
        Me.PIDRadio = New System.Windows.Forms.RadioButton()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.TiLabel = New System.Windows.Forms.Label()
        Me.TdLabel = New System.Windows.Forms.Label()
        Me.KpLabel = New System.Windows.Forms.Label()
        Me.TdTrackBar = New MPCD.TrackBar()
        Me.TiTrackBar = New MPCD.TrackBar()
        Me.PPIPIDGroup = New System.Windows.Forms.GroupBox()
        CType(Me.HysterisisUpDn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OnOffPIDGroup.SuspendLayout()
        Me.PPIPIDGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'PIRadio
        '
        Me.PIRadio.AutoSize = True
        Me.PIRadio.ForeColor = System.Drawing.Color.Teal
        Me.PIRadio.Location = New System.Drawing.Point(61, 13)
        Me.PIRadio.Name = "PIRadio"
        Me.PIRadio.Size = New System.Drawing.Size(35, 17)
        Me.PIRadio.TabIndex = 72
        Me.PIRadio.TabStop = True
        Me.PIRadio.Text = "PI"
        Me.PIRadio.UseVisualStyleBackColor = True
        '
        'HysterisisUpDn
        '
        Me.HysterisisUpDn.Enabled = False
        Me.HysterisisUpDn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HysterisisUpDn.Location = New System.Drawing.Point(301, 122)
        Me.HysterisisUpDn.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.HysterisisUpDn.Minimum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.HysterisisUpDn.Name = "HysterisisUpDn"
        Me.HysterisisUpDn.Size = New System.Drawing.Size(56, 22)
        Me.HysterisisUpDn.TabIndex = 89
        Me.HysterisisUpDn.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'HysterisisLabel
        '
        Me.HysterisisLabel.AutoSize = True
        Me.HysterisisLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HysterisisLabel.ForeColor = System.Drawing.Color.Teal
        Me.HysterisisLabel.Location = New System.Drawing.Point(219, 122)
        Me.HysterisisLabel.Name = "HysterisisLabel"
        Me.HysterisisLabel.Size = New System.Drawing.Size(72, 16)
        Me.HysterisisLabel.TabIndex = 90
        Me.HysterisisLabel.Text = "Hysteresis"
        '
        'OnOffRadio
        '
        Me.OnOffRadio.AutoSize = True
        Me.OnOffRadio.ForeColor = System.Drawing.Color.Teal
        Me.OnOffRadio.Location = New System.Drawing.Point(13, 15)
        Me.OnOffRadio.Name = "OnOffRadio"
        Me.OnOffRadio.Size = New System.Drawing.Size(72, 17)
        Me.OnOffRadio.TabIndex = 68
        Me.OnOffRadio.TabStop = True
        Me.OnOffRadio.Text = "ON / OFF"
        Me.OnOffRadio.UseVisualStyleBackColor = True
        '
        'PRadio
        '
        Me.PRadio.AutoSize = True
        Me.PRadio.ForeColor = System.Drawing.Color.Teal
        Me.PRadio.Location = New System.Drawing.Point(13, 13)
        Me.PRadio.Name = "PRadio"
        Me.PRadio.Size = New System.Drawing.Size(32, 17)
        Me.PRadio.TabIndex = 70
        Me.PRadio.TabStop = True
        Me.PRadio.Text = "P"
        Me.PRadio.UseVisualStyleBackColor = True
        '
        'CloseLoopRadio
        '
        Me.CloseLoopRadio.AutoSize = True
        Me.CloseLoopRadio.ForeColor = System.Drawing.Color.Teal
        Me.CloseLoopRadio.Location = New System.Drawing.Point(106, 17)
        Me.CloseLoopRadio.Name = "CloseLoopRadio"
        Me.CloseLoopRadio.Size = New System.Drawing.Size(78, 17)
        Me.CloseLoopRadio.TabIndex = 88
        Me.CloseLoopRadio.TabStop = True
        Me.CloseLoopRadio.Text = "Close Loop"
        Me.CloseLoopRadio.UseVisualStyleBackColor = True
        '
        'PIDRadio1
        '
        Me.PIDRadio1.AutoSize = True
        Me.PIDRadio1.ForeColor = System.Drawing.Color.Teal
        Me.PIDRadio1.Location = New System.Drawing.Point(102, 13)
        Me.PIDRadio1.Name = "PIDRadio1"
        Me.PIDRadio1.Size = New System.Drawing.Size(43, 17)
        Me.PIDRadio1.TabIndex = 71
        Me.PIDRadio1.TabStop = True
        Me.PIDRadio1.Text = "PID"
        Me.PIDRadio1.UseVisualStyleBackColor = True
        '
        'OpenLoopRadio
        '
        Me.OpenLoopRadio.AutoSize = True
        Me.OpenLoopRadio.ForeColor = System.Drawing.Color.Teal
        Me.OpenLoopRadio.Location = New System.Drawing.Point(17, 17)
        Me.OpenLoopRadio.Name = "OpenLoopRadio"
        Me.OpenLoopRadio.Size = New System.Drawing.Size(78, 17)
        Me.OpenLoopRadio.TabIndex = 87
        Me.OpenLoopRadio.TabStop = True
        Me.OpenLoopRadio.Text = "Open Loop"
        Me.OpenLoopRadio.UseVisualStyleBackColor = True
        '
        'KpTrackBar
        '
        Me.KpTrackBar._CouleurA = System.Drawing.Color.Silver
        Me.KpTrackBar._CouleurCurseur = System.Drawing.Color.White
        Me.KpTrackBar._CouleurDe = System.Drawing.Color.Silver
        Me.KpTrackBar._Curseur = MPCD.TrackBar.TypeCurseur.Losange
        Me.KpTrackBar._Epaisseur = 15
        Me.KpTrackBar._Maximum = 100
        Me.KpTrackBar._Minimum = 0
        Me.KpTrackBar._ModeleCouleur = MPCD.TrackBar.MyColor.PasDeModele
        Me.KpTrackBar._PasDeGraduation = 1
        Me.KpTrackBar._Style = MPCD.TrackBar.MyStyle.Texte
        Me.KpTrackBar._Valeur = 30
        Me.KpTrackBar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KpTrackBar.Location = New System.Drawing.Point(289, 13)
        Me.KpTrackBar.Margin = New System.Windows.Forms.Padding(0)
        Me.KpTrackBar.Name = "KpTrackBar"
        Me.KpTrackBar.Size = New System.Drawing.Size(183, 25)
        Me.KpTrackBar.TabIndex = 79
        Me.KpTrackBar.Text = "TrackBar1"
        '
        'OnOffPIDGroup
        '
        Me.OnOffPIDGroup.Controls.Add(Me.OnOffRadio)
        Me.OnOffPIDGroup.Controls.Add(Me.PIDRadio)
        Me.OnOffPIDGroup.Location = New System.Drawing.Point(4, 34)
        Me.OnOffPIDGroup.Name = "OnOffPIDGroup"
        Me.OnOffPIDGroup.Size = New System.Drawing.Size(180, 43)
        Me.OnOffPIDGroup.TabIndex = 91
        Me.OnOffPIDGroup.TabStop = False
        '
        'PIDRadio
        '
        Me.PIDRadio.AutoSize = True
        Me.PIDRadio.ForeColor = System.Drawing.Color.Teal
        Me.PIDRadio.Location = New System.Drawing.Point(102, 15)
        Me.PIDRadio.Name = "PIDRadio"
        Me.PIDRadio.Size = New System.Drawing.Size(43, 17)
        Me.PIDRadio.TabIndex = 69
        Me.PIDRadio.TabStop = True
        Me.PIDRadio.Text = "PID"
        Me.PIDRadio.UseVisualStyleBackColor = True
        '
        'OKButton
        '
        Me.OKButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OKButton.Location = New System.Drawing.Point(364, 163)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(91, 31)
        Me.OKButton.TabIndex = 85
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'TiLabel
        '
        Me.TiLabel.AutoSize = True
        Me.TiLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TiLabel.ForeColor = System.Drawing.Color.Teal
        Me.TiLabel.Location = New System.Drawing.Point(198, 53)
        Me.TiLabel.Name = "TiLabel"
        Me.TiLabel.Size = New System.Drawing.Size(88, 16)
        Me.TiLabel.TabIndex = 84
        Me.TiLabel.Text = "Ti (0-120 sec)"
        '
        'TdLabel
        '
        Me.TdLabel.AutoSize = True
        Me.TdLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TdLabel.ForeColor = System.Drawing.Color.Teal
        Me.TdLabel.Location = New System.Drawing.Point(187, 87)
        Me.TdLabel.Name = "TdLabel"
        Me.TdLabel.Size = New System.Drawing.Size(99, 16)
        Me.TdLabel.TabIndex = 83
        Me.TdLabel.Text = "Td (0 - 120 sec)"
        '
        'KpLabel
        '
        Me.KpLabel.AutoSize = True
        Me.KpLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KpLabel.ForeColor = System.Drawing.Color.Teal
        Me.KpLabel.Location = New System.Drawing.Point(204, 18)
        Me.KpLabel.Name = "KpLabel"
        Me.KpLabel.Size = New System.Drawing.Size(88, 16)
        Me.KpLabel.TabIndex = 82
        Me.KpLabel.Text = "Kp (0 - 100 %)"
        '
        'TdTrackBar
        '
        Me.TdTrackBar._CouleurA = System.Drawing.Color.Silver
        Me.TdTrackBar._CouleurCurseur = System.Drawing.Color.White
        Me.TdTrackBar._CouleurDe = System.Drawing.Color.Silver
        Me.TdTrackBar._Curseur = MPCD.TrackBar.TypeCurseur.Losange
        Me.TdTrackBar._Epaisseur = 15
        Me.TdTrackBar._Maximum = 120
        Me.TdTrackBar._Minimum = 0
        Me.TdTrackBar._ModeleCouleur = MPCD.TrackBar.MyColor.PasDeModele
        Me.TdTrackBar._PasDeGraduation = 1
        Me.TdTrackBar._Style = MPCD.TrackBar.MyStyle.Texte
        Me.TdTrackBar._Valeur = 35
        Me.TdTrackBar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TdTrackBar.Location = New System.Drawing.Point(289, 84)
        Me.TdTrackBar.Margin = New System.Windows.Forms.Padding(0)
        Me.TdTrackBar.Name = "TdTrackBar"
        Me.TdTrackBar.Size = New System.Drawing.Size(183, 25)
        Me.TdTrackBar.TabIndex = 81
        Me.TdTrackBar.Text = "TrackBar1"
        '
        'TiTrackBar
        '
        Me.TiTrackBar._CouleurA = System.Drawing.Color.Silver
        Me.TiTrackBar._CouleurCurseur = System.Drawing.Color.White
        Me.TiTrackBar._CouleurDe = System.Drawing.Color.Silver
        Me.TiTrackBar._Curseur = MPCD.TrackBar.TypeCurseur.Losange
        Me.TiTrackBar._Epaisseur = 15
        Me.TiTrackBar._Maximum = 120
        Me.TiTrackBar._Minimum = 0
        Me.TiTrackBar._ModeleCouleur = MPCD.TrackBar.MyColor.PasDeModele
        Me.TiTrackBar._PasDeGraduation = 1
        Me.TiTrackBar._Style = MPCD.TrackBar.MyStyle.Texte
        Me.TiTrackBar._Valeur = 35
        Me.TiTrackBar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TiTrackBar.Location = New System.Drawing.Point(289, 49)
        Me.TiTrackBar.Margin = New System.Windows.Forms.Padding(0)
        Me.TiTrackBar.Name = "TiTrackBar"
        Me.TiTrackBar.Size = New System.Drawing.Size(183, 25)
        Me.TiTrackBar.TabIndex = 80
        Me.TiTrackBar.Text = "TrackBar1"
        '
        'PPIPIDGroup
        '
        Me.PPIPIDGroup.Controls.Add(Me.PIDRadio1)
        Me.PPIPIDGroup.Controls.Add(Me.PRadio)
        Me.PPIPIDGroup.Controls.Add(Me.PIRadio)
        Me.PPIPIDGroup.Location = New System.Drawing.Point(4, 79)
        Me.PPIPIDGroup.Name = "PPIPIDGroup"
        Me.PPIPIDGroup.Size = New System.Drawing.Size(180, 37)
        Me.PPIPIDGroup.TabIndex = 92
        Me.PPIPIDGroup.TabStop = False
        '
        'LTSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(476, 206)
        Me.Controls.Add(Me.HysterisisUpDn)
        Me.Controls.Add(Me.HysterisisLabel)
        Me.Controls.Add(Me.CloseLoopRadio)
        Me.Controls.Add(Me.OpenLoopRadio)
        Me.Controls.Add(Me.KpTrackBar)
        Me.Controls.Add(Me.OnOffPIDGroup)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.TiLabel)
        Me.Controls.Add(Me.TdLabel)
        Me.Controls.Add(Me.KpLabel)
        Me.Controls.Add(Me.TdTrackBar)
        Me.Controls.Add(Me.TiTrackBar)
        Me.Controls.Add(Me.PPIPIDGroup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LTSettings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Level Transmitter Settings"
        CType(Me.HysterisisUpDn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OnOffPIDGroup.ResumeLayout(False)
        Me.OnOffPIDGroup.PerformLayout()
        Me.PPIPIDGroup.ResumeLayout(False)
        Me.PPIPIDGroup.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PIRadio As System.Windows.Forms.RadioButton
    Friend WithEvents HysterisisUpDn As System.Windows.Forms.NumericUpDown
    Friend WithEvents HysterisisLabel As System.Windows.Forms.Label
    Friend WithEvents OnOffRadio As System.Windows.Forms.RadioButton
    Friend WithEvents PRadio As System.Windows.Forms.RadioButton
    Friend WithEvents CloseLoopRadio As System.Windows.Forms.RadioButton
    Friend WithEvents PIDRadio1 As System.Windows.Forms.RadioButton
    Friend WithEvents OpenLoopRadio As System.Windows.Forms.RadioButton
    Friend WithEvents KpTrackBar As MPCD.TrackBar
    Friend WithEvents OnOffPIDGroup As System.Windows.Forms.GroupBox
    Friend WithEvents PIDRadio As System.Windows.Forms.RadioButton
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents TiLabel As System.Windows.Forms.Label
    Friend WithEvents TdLabel As System.Windows.Forms.Label
    Friend WithEvents KpLabel As System.Windows.Forms.Label
    Friend WithEvents TdTrackBar As MPCD.TrackBar
    Friend WithEvents TiTrackBar As MPCD.TrackBar
    Friend WithEvents PPIPIDGroup As System.Windows.Forms.GroupBox
End Class
