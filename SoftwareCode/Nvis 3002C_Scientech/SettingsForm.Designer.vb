<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingsForm))
        Me.TypeChannel1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TypeChannel8 = New System.Windows.Forms.ComboBox()
        Me.TypeChannel7 = New System.Windows.Forms.ComboBox()
        Me.TypeChannel6 = New System.Windows.Forms.ComboBox()
        Me.TypeChannel5 = New System.Windows.Forms.ComboBox()
        Me.TypeChannel4 = New System.Windows.Forms.ComboBox()
        Me.TypeChannel3 = New System.Windows.Forms.ComboBox()
        Me.TypeChannel2 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MaxRTDTemperatureTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.RTDSupplyTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ADCResistanceTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RTDResistanceTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.WriteButton = New System.Windows.Forms.Button()
        Me.EthRecTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ReadButton = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TypeChannel1
        '
        Me.TypeChannel1.FormattingEnabled = True
        Me.TypeChannel1.Items.AddRange(New Object() {"RTD", "Current (mA)", "J Type", "K Type", "R Type", "B Type", "N Type", "Analog (mV)"})
        Me.TypeChannel1.Location = New System.Drawing.Point(90, 22)
        Me.TypeChannel1.Name = "TypeChannel1"
        Me.TypeChannel1.Size = New System.Drawing.Size(95, 21)
        Me.TypeChannel1.TabIndex = 92
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Channel 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Channel 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Channel 3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "Channel 4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 131)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 15)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "Channel 5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 15)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "Channel 6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 15)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "Channel 8"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 15)
        Me.Label8.TabIndex = 105
        Me.Label8.Text = "Channel 7"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TypeChannel8)
        Me.Panel1.Controls.Add(Me.TypeChannel7)
        Me.Panel1.Controls.Add(Me.TypeChannel6)
        Me.Panel1.Controls.Add(Me.TypeChannel5)
        Me.Panel1.Controls.Add(Me.TypeChannel4)
        Me.Panel1.Controls.Add(Me.TypeChannel3)
        Me.Panel1.Controls.Add(Me.TypeChannel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TypeChannel1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(12, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(202, 241)
        Me.Panel1.TabIndex = 108
        '
        'TypeChannel8
        '
        Me.TypeChannel8.FormattingEnabled = True
        Me.TypeChannel8.Items.AddRange(New Object() {"RTD", "Current (mA)", "J Type", "K Type", "R Type", "B Type", "N Type", "Analog (mV)"})
        Me.TypeChannel8.Location = New System.Drawing.Point(90, 211)
        Me.TypeChannel8.Name = "TypeChannel8"
        Me.TypeChannel8.Size = New System.Drawing.Size(95, 21)
        Me.TypeChannel8.TabIndex = 114
        '
        'TypeChannel7
        '
        Me.TypeChannel7.FormattingEnabled = True
        Me.TypeChannel7.Items.AddRange(New Object() {"RTD", "Current (mA)", "J Type", "K Type", "R Type", "B Type", "N Type", "Analog (mV)"})
        Me.TypeChannel7.Location = New System.Drawing.Point(90, 184)
        Me.TypeChannel7.Name = "TypeChannel7"
        Me.TypeChannel7.Size = New System.Drawing.Size(95, 21)
        Me.TypeChannel7.TabIndex = 113
        '
        'TypeChannel6
        '
        Me.TypeChannel6.FormattingEnabled = True
        Me.TypeChannel6.Items.AddRange(New Object() {"RTD", "Current (mA)", "J Type", "K Type", "R Type", "B Type", "N Type", "Analog (mV)"})
        Me.TypeChannel6.Location = New System.Drawing.Point(90, 157)
        Me.TypeChannel6.Name = "TypeChannel6"
        Me.TypeChannel6.Size = New System.Drawing.Size(95, 21)
        Me.TypeChannel6.TabIndex = 112
        '
        'TypeChannel5
        '
        Me.TypeChannel5.FormattingEnabled = True
        Me.TypeChannel5.Items.AddRange(New Object() {"RTD", "Current (mA)", "J Type", "K Type", "R Type", "B Type", "N Type", "Analog (mV)"})
        Me.TypeChannel5.Location = New System.Drawing.Point(90, 130)
        Me.TypeChannel5.Name = "TypeChannel5"
        Me.TypeChannel5.Size = New System.Drawing.Size(95, 21)
        Me.TypeChannel5.TabIndex = 111
        '
        'TypeChannel4
        '
        Me.TypeChannel4.FormattingEnabled = True
        Me.TypeChannel4.Items.AddRange(New Object() {"RTD", "Current (mA)", "J Type", "K Type", "R Type", "B Type", "N Type", "Analog (mV)"})
        Me.TypeChannel4.Location = New System.Drawing.Point(90, 103)
        Me.TypeChannel4.Name = "TypeChannel4"
        Me.TypeChannel4.Size = New System.Drawing.Size(95, 21)
        Me.TypeChannel4.TabIndex = 110
        '
        'TypeChannel3
        '
        Me.TypeChannel3.FormattingEnabled = True
        Me.TypeChannel3.Items.AddRange(New Object() {"RTD", "Current (mA)", "J Type", "K Type", "R Type", "B Type", "N Type", "Analog (mV)"})
        Me.TypeChannel3.Location = New System.Drawing.Point(90, 76)
        Me.TypeChannel3.Name = "TypeChannel3"
        Me.TypeChannel3.Size = New System.Drawing.Size(95, 21)
        Me.TypeChannel3.TabIndex = 109
        '
        'TypeChannel2
        '
        Me.TypeChannel2.FormattingEnabled = True
        Me.TypeChannel2.Items.AddRange(New Object() {"RTD", "Current (mA)", "J Type", "K Type", "R Type", "B Type", "N Type", "Analog (mV)"})
        Me.TypeChannel2.Location = New System.Drawing.Point(90, 49)
        Me.TypeChannel2.Name = "TypeChannel2"
        Me.TypeChannel2.Size = New System.Drawing.Size(95, 21)
        Me.TypeChannel2.TabIndex = 108
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(63, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 15)
        Me.Label9.TabIndex = 108
        Me.Label9.Text = "Sensor Type"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.MaxRTDTemperatureTextBox)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.RTDSupplyTextBox)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.ADCResistanceTextBox)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.RTDResistanceTextBox)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(232, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(215, 241)
        Me.Panel2.TabIndex = 109
        '
        'MaxRTDTemperatureTextBox
        '
        Me.MaxRTDTemperatureTextBox.Location = New System.Drawing.Point(157, 185)
        Me.MaxRTDTemperatureTextBox.Mask = "0000"
        Me.MaxRTDTemperatureTextBox.Name = "MaxRTDTemperatureTextBox"
        Me.MaxRTDTemperatureTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.MaxRTDTemperatureTextBox.Size = New System.Drawing.Size(45, 20)
        Me.MaxRTDTemperatureTextBox.TabIndex = 117
        Me.MaxRTDTemperatureTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 175)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 30)
        Me.Label13.TabIndex = 116
        Me.Label13.Text = "Max. RTD" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Temperature (C)"
        '
        'RTDSupplyTextBox
        '
        Me.RTDSupplyTextBox.Location = New System.Drawing.Point(157, 135)
        Me.RTDSupplyTextBox.Mask = "0.0"
        Me.RTDSupplyTextBox.Name = "RTDSupplyTextBox"
        Me.RTDSupplyTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.RTDSupplyTextBox.Size = New System.Drawing.Size(45, 20)
        Me.RTDSupplyTextBox.TabIndex = 115
        Me.RTDSupplyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 136)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 15)
        Me.Label12.TabIndex = 114
        Me.Label12.Text = "RTD supply (V)"
        '
        'ADCResistanceTextBox
        '
        Me.ADCResistanceTextBox.Location = New System.Drawing.Point(157, 92)
        Me.ADCResistanceTextBox.Mask = "0000"
        Me.ADCResistanceTextBox.Name = "ADCResistanceTextBox"
        Me.ADCResistanceTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.ADCResistanceTextBox.Size = New System.Drawing.Size(45, 20)
        Me.ADCResistanceTextBox.TabIndex = 113
        Me.ADCResistanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 45)
        Me.Label11.TabIndex = 112
        Me.Label11.Text = "Resistance across" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ADC for current" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "measurement (ohms)"
        '
        'RTDResistanceTextBox
        '
        Me.RTDResistanceTextBox.Location = New System.Drawing.Point(157, 33)
        Me.RTDResistanceTextBox.Mask = "0000"
        Me.RTDResistanceTextBox.Name = "RTDResistanceTextBox"
        Me.RTDResistanceTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.RTDResistanceTextBox.Size = New System.Drawing.Size(45, 20)
        Me.RTDResistanceTextBox.TabIndex = 111
        Me.RTDResistanceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 30)
        Me.Label10.TabIndex = 110
        Me.Label10.Text = "RTD Reference" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Resistance (ohms)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(281, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(127, 15)
        Me.Label14.TabIndex = 110
        Me.Label14.Text = "Component Values"
        '
        'WriteButton
        '
        Me.WriteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WriteButton.Location = New System.Drawing.Point(372, 281)
        Me.WriteButton.Name = "WriteButton"
        Me.WriteButton.Size = New System.Drawing.Size(75, 29)
        Me.WriteButton.TabIndex = 112
        Me.WriteButton.Text = "Write"
        Me.WriteButton.UseVisualStyleBackColor = True
        '
        'EthRecTimer
        '
        '
        'ReadButton
        '
        Me.ReadButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReadButton.Location = New System.Drawing.Point(284, 281)
        Me.ReadButton.Name = "ReadButton"
        Me.ReadButton.Size = New System.Drawing.Size(75, 29)
        Me.ReadButton.TabIndex = 113
        Me.ReadButton.Text = "Read"
        Me.ReadButton.UseVisualStyleBackColor = True
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(454, 318)
        Me.Controls.Add(Me.ReadButton)
        Me.Controls.Add(Me.WriteButton)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SettingsForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Sensor Input Settings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TypeChannel1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents RTDResistanceTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ADCResistanceTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents RTDSupplyTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents MaxRTDTemperatureTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents WriteButton As System.Windows.Forms.Button
    Friend WithEvents TypeChannel2 As System.Windows.Forms.ComboBox
    Friend WithEvents TypeChannel8 As System.Windows.Forms.ComboBox
    Friend WithEvents TypeChannel7 As System.Windows.Forms.ComboBox
    Friend WithEvents TypeChannel6 As System.Windows.Forms.ComboBox
    Friend WithEvents TypeChannel5 As System.Windows.Forms.ComboBox
    Friend WithEvents TypeChannel4 As System.Windows.Forms.ComboBox
    Friend WithEvents TypeChannel3 As System.Windows.Forms.ComboBox
    Friend WithEvents EthRecTimer As System.Windows.Forms.Timer
    Friend WithEvents ReadButton As System.Windows.Forms.Button
End Class
