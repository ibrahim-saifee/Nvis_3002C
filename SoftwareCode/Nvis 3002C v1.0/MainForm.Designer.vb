<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.EthernetSendTimer = New System.Windows.Forms.Timer(Me.components)
        Me.EthernetRecTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.EmergencyButton = New System.Windows.Forms.PictureBox()
        Me.EmergencyLabel = New System.Windows.Forms.Label()
        Me.StartButton = New System.Windows.Forms.PictureBox()
        Me.HeaterButton = New System.Windows.Forms.PictureBox()
        Me.StopButton = New System.Windows.Forms.PictureBox()
        Me.PumpButton = New System.Windows.Forms.PictureBox()
        Me.StirrerButton = New System.Windows.Forms.PictureBox()
        Me.SolValvButton = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BuzzerLabel = New System.Windows.Forms.Label()
        Me.PumpLed = New System.Windows.Forms.PictureBox()
        Me.SolValvLed = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.StirrerLed = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.HeaterLed = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.VisualIndicatorLed = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.BuzzerArc = New Arc.Arc()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.liveview = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.DAQTemperatureLabel = New System.Windows.Forms.Label()
        Me.LevelPanel = New System.Windows.Forms.Panel()
        Me.LevelDigi = New Owf.Controls.DigitalDisplayControl()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.LevelSPDigi = New Owf.Controls.DigitalDisplayControl()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LevelSPUpDown = New System.Windows.Forms.NumericUpDown()
        Me.lvllbl = New System.Windows.Forms.Label()
        Me.Nvis3002APanel1 = New Nvis3002APanel.Nvis3002APanel()
        Me.temperature = New System.Windows.Forms.TabPage()
        Me.TemperatureClearButton = New System.Windows.Forms.Button()
        Me.TemperatureGraph = New ZedGraph.ZedGraphControl()
        Me.level = New System.Windows.Forms.TabPage()
        Me.LevelClearButton = New System.Windows.Forms.Button()
        Me.LevelGraph = New ZedGraph.ZedGraphControl()
        Me.pressure = New System.Windows.Forms.TabPage()
        Me.PressureClearButton = New System.Windows.Forms.Button()
        Me.PressurePanel = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.PressureDigi = New Owf.Controls.DigitalDisplayControl()
        Me.PressureCurrentLabel = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.PressureGraph = New ZedGraph.ZedGraphControl()
        Me.flowmeter = New System.Windows.Forms.TabPage()
        Me.FlowClearButton = New System.Windows.Forms.Button()
        Me.FlowPanel = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.FlowMeterDigi = New Owf.Controls.DigitalDisplayControl()
        Me.FlowMeterCurrentLabel = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.FLowMeterGraph = New ZedGraph.ZedGraphControl()
        Me.DataScanTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.SelectIPToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoggingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TemperaturePIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LevelPIDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopWatchToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeIPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetAlarmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HeaterTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LevelTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BuzzerTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LinkLabel = New System.Windows.Forms.Label()
        Me.LinkLedPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.SelectIPToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoggingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TemperatureTransmitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LevelTransmitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopWatchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectIPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        CType(Me.EmergencyButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaterButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StopButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PumpButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StirrerButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SolValvButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PumpLed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SolValvLed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StirrerLed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HeaterLed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisualIndicatorLed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.liveview.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.LevelPanel.SuspendLayout()
        CType(Me.LevelSPUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.temperature.SuspendLayout()
        Me.level.SuspendLayout()
        Me.pressure.SuspendLayout()
        Me.PressurePanel.SuspendLayout()
        Me.flowmeter.SuspendLayout()
        Me.FlowPanel.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        CType(Me.LinkLedPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(65, 296)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 15)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Visual Indicator"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(69, 226)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 15)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Solenoid Valve"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(96, 157)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 15)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Stirrer"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(93, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 15)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Heater"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(93, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 15)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Pump"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(93, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 15)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Solenoid Valve"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(34, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 15)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Stirrer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(123, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 15)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Heater"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 15)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Pump"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Start"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 15)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Stop"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Teal
        Me.Label12.Location = New System.Drawing.Point(3, 105)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(724, 31)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Nvis 3002B Multi Function Process Control Training System"
        '
        'EthernetSendTimer
        '
        '
        'EthernetRecTimer
        '
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.EmergencyButton)
        Me.Panel1.Controls.Add(Me.EmergencyLabel)
        Me.Panel1.Controls.Add(Me.StartButton)
        Me.Panel1.Controls.Add(Me.HeaterButton)
        Me.Panel1.Controls.Add(Me.StopButton)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PumpButton)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.StirrerButton)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.SolValvButton)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(738, 182)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(198, 432)
        Me.Panel1.TabIndex = 58
        '
        'EmergencyButton
        '
        Me.EmergencyButton.BackColor = System.Drawing.Color.Transparent
        Me.EmergencyButton.BackgroundImage = Global.Nvis_3002C.My.Resources.Resources.Emergency_Button_off
        Me.EmergencyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EmergencyButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EmergencyButton.Location = New System.Drawing.Point(82, 359)
        Me.EmergencyButton.Name = "EmergencyButton"
        Me.EmergencyButton.Size = New System.Drawing.Size(61, 62)
        Me.EmergencyButton.TabIndex = 42
        Me.EmergencyButton.TabStop = False
        '
        'EmergencyLabel
        '
        Me.EmergencyLabel.AutoSize = True
        Me.EmergencyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmergencyLabel.ForeColor = System.Drawing.Color.Black
        Me.EmergencyLabel.Location = New System.Drawing.Point(58, 341)
        Me.EmergencyLabel.Name = "EmergencyLabel"
        Me.EmergencyLabel.Size = New System.Drawing.Size(111, 15)
        Me.EmergencyLabel.TabIndex = 41
        Me.EmergencyLabel.Text = "Emergency Stop"
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.Color.Transparent
        Me.StartButton.BackgroundImage = Global.Nvis_3002C.My.Resources.Resources.Buttons_green_off
        Me.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StartButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StartButton.Location = New System.Drawing.Point(32, 49)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(50, 50)
        Me.StartButton.TabIndex = 30
        Me.StartButton.TabStop = False
        '
        'HeaterButton
        '
        Me.HeaterButton.BackColor = System.Drawing.Color.Transparent
        Me.HeaterButton.BackgroundImage = Global.Nvis_3002C.My.Resources.Resources.Buttons_yellow_off
        Me.HeaterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HeaterButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HeaterButton.Location = New System.Drawing.Point(121, 154)
        Me.HeaterButton.Name = "HeaterButton"
        Me.HeaterButton.Size = New System.Drawing.Size(50, 50)
        Me.HeaterButton.TabIndex = 28
        Me.HeaterButton.TabStop = False
        '
        'StopButton
        '
        Me.StopButton.BackColor = System.Drawing.Color.Transparent
        Me.StopButton.BackgroundImage = Global.Nvis_3002C.My.Resources.Resources.Buttons_red_off
        Me.StopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StopButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StopButton.Location = New System.Drawing.Point(121, 49)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(50, 50)
        Me.StopButton.TabIndex = 29
        Me.StopButton.TabStop = False
        '
        'PumpButton
        '
        Me.PumpButton.BackColor = System.Drawing.Color.Transparent
        Me.PumpButton.BackgroundImage = Global.Nvis_3002C.My.Resources.Resources.Buttons_yellow_off
        Me.PumpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PumpButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PumpButton.Location = New System.Drawing.Point(32, 154)
        Me.PumpButton.Name = "PumpButton"
        Me.PumpButton.Size = New System.Drawing.Size(50, 50)
        Me.PumpButton.TabIndex = 34
        Me.PumpButton.TabStop = False
        '
        'StirrerButton
        '
        Me.StirrerButton.BackColor = System.Drawing.Color.Transparent
        Me.StirrerButton.BackgroundImage = Global.Nvis_3002C.My.Resources.Resources.Buttons_yellow_off
        Me.StirrerButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StirrerButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StirrerButton.Location = New System.Drawing.Point(32, 263)
        Me.StirrerButton.Name = "StirrerButton"
        Me.StirrerButton.Size = New System.Drawing.Size(50, 50)
        Me.StirrerButton.TabIndex = 36
        Me.StirrerButton.TabStop = False
        '
        'SolValvButton
        '
        Me.SolValvButton.BackColor = System.Drawing.Color.Transparent
        Me.SolValvButton.BackgroundImage = Global.Nvis_3002C.My.Resources.Resources.Buttons_yellow_off
        Me.SolValvButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SolValvButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SolValvButton.Location = New System.Drawing.Point(123, 263)
        Me.SolValvButton.Name = "SolValvButton"
        Me.SolValvButton.Size = New System.Drawing.Size(50, 50)
        Me.SolValvButton.TabIndex = 38
        Me.SolValvButton.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.BuzzerLabel)
        Me.Panel2.Controls.Add(Me.PumpLed)
        Me.Panel2.Controls.Add(Me.SolValvLed)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Controls.Add(Me.StirrerLed)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.HeaterLed)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.VisualIndicatorLed)
        Me.Panel2.Controls.Add(Me.PictureBox7)
        Me.Panel2.Controls.Add(Me.BuzzerArc)
        Me.Panel2.Location = New System.Drawing.Point(942, 182)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(179, 432)
        Me.Panel2.TabIndex = 59
        '
        'BuzzerLabel
        '
        Me.BuzzerLabel.AutoSize = True
        Me.BuzzerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuzzerLabel.Location = New System.Drawing.Point(7, 389)
        Me.BuzzerLabel.Name = "BuzzerLabel"
        Me.BuzzerLabel.Size = New System.Drawing.Size(51, 15)
        Me.BuzzerLabel.TabIndex = 56
        Me.BuzzerLabel.Text = "Buzzer"
        '
        'PumpLed
        '
        Me.PumpLed.BackColor = System.Drawing.Color.Transparent
        Me.PumpLed.BackgroundImage = Global.Nvis_3002C.My.Resources.Resources.blue_led_off
        Me.PumpLed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PumpLed.Location = New System.Drawing.Point(96, 30)
        Me.PumpLed.Name = "PumpLed"
        Me.PumpLed.Size = New System.Drawing.Size(40, 40)
        Me.PumpLed.TabIndex = 41
        Me.PumpLed.TabStop = False
        '
        'SolValvLed
        '
        Me.SolValvLed.BackColor = System.Drawing.Color.Transparent
        Me.SolValvLed.BackgroundImage = Global.Nvis_3002C.My.Resources.Resources.yellow_led_off
        Me.SolValvLed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SolValvLed.Location = New System.Drawing.Point(96, 241)
        Me.SolValvLed.Name = "SolValvLed"
        Me.SolValvLed.Size = New System.Drawing.Size(40, 40)
        Me.SolValvLed.TabIndex = 40
        Me.SolValvLed.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = Global.Nvis_3002C.My.Resources.Resources.VisualIndicatorSymbol
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(3, 314)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(59, 40)
        Me.PictureBox5.TabIndex = 54
        Me.PictureBox5.TabStop = False
        '
        'StirrerLed
        '
        Me.StirrerLed.BackColor = System.Drawing.Color.Transparent
        Me.StirrerLed.BackgroundImage = Global.Nvis_3002C.My.Resources.Resources.green_led_off
        Me.StirrerLed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StirrerLed.Location = New System.Drawing.Point(96, 170)
        Me.StirrerLed.Name = "StirrerLed"
        Me.StirrerLed.Size = New System.Drawing.Size(40, 40)
        Me.StirrerLed.TabIndex = 42
        Me.StirrerLed.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = Global.Nvis_3002C.My.Resources.Resources.SolenoidalSymbol
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(3, 235)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(59, 46)
        Me.PictureBox4.TabIndex = 53
        Me.PictureBox4.TabStop = False
        '
        'HeaterLed
        '
        Me.HeaterLed.BackColor = System.Drawing.Color.Transparent
        Me.HeaterLed.BackgroundImage = Global.Nvis_3002C.My.Resources.Resources.yellow_led_off
        Me.HeaterLed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.HeaterLed.Location = New System.Drawing.Point(96, 99)
        Me.HeaterLed.Name = "HeaterLed"
        Me.HeaterLed.Size = New System.Drawing.Size(40, 40)
        Me.HeaterLed.TabIndex = 43
        Me.HeaterLed.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.Nvis_3002C.My.Resources.Resources.StirrerSymbol
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(3, 170)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(68, 40)
        Me.PictureBox3.TabIndex = 52
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.Nvis_3002C.My.Resources.Resources.HeaterSymbol
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(12, 94)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 45)
        Me.PictureBox2.TabIndex = 51
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Nvis_3002C.My.Resources.Resources.PumpSymbol
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(22, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 40)
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'VisualIndicatorLed
        '
        Me.VisualIndicatorLed.BackColor = System.Drawing.Color.Transparent
        Me.VisualIndicatorLed.BackgroundImage = Global.Nvis_3002C.My.Resources.Resources.blue_led_off
        Me.VisualIndicatorLed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.VisualIndicatorLed.Location = New System.Drawing.Point(96, 314)
        Me.VisualIndicatorLed.Name = "VisualIndicatorLed"
        Me.VisualIndicatorLed.Size = New System.Drawing.Size(40, 40)
        Me.VisualIndicatorLed.TabIndex = 48
        Me.VisualIndicatorLed.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.BackgroundImage = Global.Nvis_3002C.My.Resources.Resources.BuzzerSymbol1
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox7.Location = New System.Drawing.Point(61, 371)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(49, 50)
        Me.PictureBox7.TabIndex = 55
        Me.PictureBox7.TabStop = False
        '
        'BuzzerArc
        '
        Me.BuzzerArc.Angle = 40
        Me.BuzzerArc.Animate = False
        Me.BuzzerArc.BackColor = System.Drawing.Color.Transparent
        Me.BuzzerArc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BuzzerArc.Distance = 10
        Me.BuzzerArc.Location = New System.Drawing.Point(59, 346)
        Me.BuzzerArc.Name = "BuzzerArc"
        Me.BuzzerArc.Progress = 2
        Me.BuzzerArc.Radius = 50
        Me.BuzzerArc.Rotation = -20
        Me.BuzzerArc.Size = New System.Drawing.Size(105, 105)
        Me.BuzzerArc.TabIndex = 57
        Me.BuzzerArc.Time = 200
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Teal
        Me.Label13.Location = New System.Drawing.Point(799, 172)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 20)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "Controls"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Teal
        Me.Label14.Location = New System.Drawing.Point(991, 171)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 20)
        Me.Label14.TabIndex = 61
        Me.Label14.Text = "Actuators"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.liveview)
        Me.TabControl1.Controls.Add(Me.temperature)
        Me.TabControl1.Controls.Add(Me.level)
        Me.TabControl1.Controls.Add(Me.pressure)
        Me.TabControl1.Controls.Add(Me.flowmeter)
        Me.TabControl1.Location = New System.Drawing.Point(9, 165)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(723, 449)
        Me.TabControl1.TabIndex = 63
        '
        'liveview
        '
        Me.liveview.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.liveview.Controls.Add(Me.Panel5)
        Me.liveview.Controls.Add(Me.LevelPanel)
        Me.liveview.Controls.Add(Me.Nvis3002APanel1)
        Me.liveview.Location = New System.Drawing.Point(4, 22)
        Me.liveview.Name = "liveview"
        Me.liveview.Padding = New System.Windows.Forms.Padding(3)
        Me.liveview.Size = New System.Drawing.Size(715, 423)
        Me.liveview.TabIndex = 0
        Me.liveview.Text = "Live View"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.DAQTemperatureLabel)
        Me.Panel5.Location = New System.Drawing.Point(520, 167)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(183, 37)
        Me.Panel5.TabIndex = 14
        '
        'DAQTemperatureLabel
        '
        Me.DAQTemperatureLabel.AutoSize = True
        Me.DAQTemperatureLabel.BackColor = System.Drawing.Color.Transparent
        Me.DAQTemperatureLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DAQTemperatureLabel.ForeColor = System.Drawing.Color.Red
        Me.DAQTemperatureLabel.Location = New System.Drawing.Point(3, 12)
        Me.DAQTemperatureLabel.Name = "DAQTemperatureLabel"
        Me.DAQTemperatureLabel.Size = New System.Drawing.Size(133, 15)
        Me.DAQTemperatureLabel.TabIndex = 4
        Me.DAQTemperatureLabel.Text = "DAQ Temperature : "
        Me.DAQTemperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LevelPanel
        '
        Me.LevelPanel.BackColor = System.Drawing.Color.Transparent
        Me.LevelPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LevelPanel.Controls.Add(Me.LevelDigi)
        Me.LevelPanel.Controls.Add(Me.Label19)
        Me.LevelPanel.Controls.Add(Me.LevelSPDigi)
        Me.LevelPanel.Controls.Add(Me.Label15)
        Me.LevelPanel.Controls.Add(Me.Label16)
        Me.LevelPanel.Controls.Add(Me.LevelSPUpDown)
        Me.LevelPanel.Controls.Add(Me.lvllbl)
        Me.LevelPanel.Location = New System.Drawing.Point(386, 25)
        Me.LevelPanel.Name = "LevelPanel"
        Me.LevelPanel.Size = New System.Drawing.Size(317, 69)
        Me.LevelPanel.TabIndex = 12
        '
        'LevelDigi
        '
        Me.LevelDigi.BackColor = System.Drawing.Color.Transparent
        Me.LevelDigi.DigitColor = System.Drawing.Color.Blue
        Me.LevelDigi.DigitText = "00"
        Me.LevelDigi.Location = New System.Drawing.Point(93, 7)
        Me.LevelDigi.Name = "LevelDigi"
        Me.LevelDigi.Size = New System.Drawing.Size(49, 31)
        Me.LevelDigi.TabIndex = 16
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Blue
        Me.Label19.Location = New System.Drawing.Point(7, 10)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(85, 30)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "Current" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Liquid Level"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LevelSPDigi
        '
        Me.LevelSPDigi.BackColor = System.Drawing.Color.Transparent
        Me.LevelSPDigi.DigitColor = System.Drawing.Color.Blue
        Me.LevelSPDigi.DigitText = "00"
        Me.LevelSPDigi.Location = New System.Drawing.Point(235, 8)
        Me.LevelSPDigi.Name = "LevelSPDigi"
        Me.LevelSPDigi.Size = New System.Drawing.Size(49, 31)
        Me.LevelSPDigi.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(3, 49)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 13)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Sensor Output (mA)"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(152, 9)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(85, 30)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Liquid Level" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Set Point"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LevelSPUpDown
        '
        Me.LevelSPUpDown.Location = New System.Drawing.Point(290, 13)
        Me.LevelSPUpDown.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.LevelSPUpDown.Name = "LevelSPUpDown"
        Me.LevelSPUpDown.Size = New System.Drawing.Size(18, 20)
        Me.LevelSPUpDown.TabIndex = 10
        '
        'lvllbl
        '
        Me.lvllbl.AutoSize = True
        Me.lvllbl.ForeColor = System.Drawing.Color.Blue
        Me.lvllbl.Location = New System.Drawing.Point(108, 49)
        Me.lvllbl.Name = "lvllbl"
        Me.lvllbl.Size = New System.Drawing.Size(34, 13)
        Me.lvllbl.TabIndex = 3
        Me.lvllbl.Text = "00.00"
        '
        'Nvis3002APanel1
        '
        Me.Nvis3002APanel1.BackColor = System.Drawing.Color.Transparent
        Me.Nvis3002APanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Nvis3002APanel1.ControlValveOpening = 0
        Me.Nvis3002APanel1.Drain = False
        Me.Nvis3002APanel1.Fill = False
        Me.Nvis3002APanel1.FlowCurrentValue = 0.0R
        Me.Nvis3002APanel1.FlowMaxValue = 1000
        Me.Nvis3002APanel1.FlowMinValue = 200
        Me.Nvis3002APanel1.FlowTime = 20
        Me.Nvis3002APanel1.LevelCurrent = "0"
        Me.Nvis3002APanel1.LevelSetPoint = 80
        Me.Nvis3002APanel1.LevelUnit = "%"
        Me.Nvis3002APanel1.Location = New System.Drawing.Point(7, 6)
        Me.Nvis3002APanel1.Name = "Nvis3002APanel1"
        Me.Nvis3002APanel1.OverFlow = False
        Me.Nvis3002APanel1.OverFlowAt = 90
        Me.Nvis3002APanel1.Size = New System.Drawing.Size(865, 475)
        Me.Nvis3002APanel1.StepSize = 5
        Me.Nvis3002APanel1.TabIndex = 1
        Me.Nvis3002APanel1.TankLevel = 0
        Me.Nvis3002APanel1.TankRange = 100
        '
        'temperature
        '
        Me.temperature.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.temperature.Controls.Add(Me.TemperatureClearButton)
        Me.temperature.Controls.Add(Me.TemperatureGraph)
        Me.temperature.Location = New System.Drawing.Point(4, 22)
        Me.temperature.Name = "temperature"
        Me.temperature.Padding = New System.Windows.Forms.Padding(3)
        Me.temperature.Size = New System.Drawing.Size(715, 423)
        Me.temperature.TabIndex = 1
        Me.temperature.Text = "Temperature"
        '
        'TemperatureClearButton
        '
        Me.TemperatureClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TemperatureClearButton.Location = New System.Drawing.Point(637, 370)
        Me.TemperatureClearButton.Name = "TemperatureClearButton"
        Me.TemperatureClearButton.Size = New System.Drawing.Size(75, 23)
        Me.TemperatureClearButton.TabIndex = 1
        Me.TemperatureClearButton.Text = "Clear"
        Me.TemperatureClearButton.UseVisualStyleBackColor = True
        '
        'TemperatureGraph
        '
        Me.TemperatureGraph.Location = New System.Drawing.Point(0, 0)
        Me.TemperatureGraph.Name = "TemperatureGraph"
        Me.TemperatureGraph.ScrollGrace = 0.0R
        Me.TemperatureGraph.ScrollMaxX = 0.0R
        Me.TemperatureGraph.ScrollMaxY = 0.0R
        Me.TemperatureGraph.ScrollMaxY2 = 0.0R
        Me.TemperatureGraph.ScrollMinX = 0.0R
        Me.TemperatureGraph.ScrollMinY = 0.0R
        Me.TemperatureGraph.ScrollMinY2 = 0.0R
        Me.TemperatureGraph.Size = New System.Drawing.Size(715, 420)
        Me.TemperatureGraph.TabIndex = 0
        '
        'level
        '
        Me.level.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.level.Controls.Add(Me.LevelClearButton)
        Me.level.Controls.Add(Me.LevelGraph)
        Me.level.Location = New System.Drawing.Point(4, 22)
        Me.level.Name = "level"
        Me.level.Size = New System.Drawing.Size(715, 423)
        Me.level.TabIndex = 2
        Me.level.Text = "Level"
        '
        'LevelClearButton
        '
        Me.LevelClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LevelClearButton.Location = New System.Drawing.Point(637, 371)
        Me.LevelClearButton.Name = "LevelClearButton"
        Me.LevelClearButton.Size = New System.Drawing.Size(75, 23)
        Me.LevelClearButton.TabIndex = 43
        Me.LevelClearButton.Text = "Clear"
        Me.LevelClearButton.UseVisualStyleBackColor = True
        '
        'LevelGraph
        '
        Me.LevelGraph.Location = New System.Drawing.Point(0, 1)
        Me.LevelGraph.Name = "LevelGraph"
        Me.LevelGraph.ScrollGrace = 0.0R
        Me.LevelGraph.ScrollMaxX = 0.0R
        Me.LevelGraph.ScrollMaxY = 0.0R
        Me.LevelGraph.ScrollMaxY2 = 0.0R
        Me.LevelGraph.ScrollMinX = 0.0R
        Me.LevelGraph.ScrollMinY = 0.0R
        Me.LevelGraph.ScrollMinY2 = 0.0R
        Me.LevelGraph.Size = New System.Drawing.Size(715, 420)
        Me.LevelGraph.TabIndex = 1
        '
        'pressure
        '
        Me.pressure.Controls.Add(Me.PressureClearButton)
        Me.pressure.Controls.Add(Me.PressurePanel)
        Me.pressure.Controls.Add(Me.PressureGraph)
        Me.pressure.Location = New System.Drawing.Point(4, 22)
        Me.pressure.Name = "pressure"
        Me.pressure.Size = New System.Drawing.Size(715, 423)
        Me.pressure.TabIndex = 3
        Me.pressure.Text = "Pressure"
        Me.pressure.UseVisualStyleBackColor = True
        '
        'PressureClearButton
        '
        Me.PressureClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressureClearButton.Location = New System.Drawing.Point(615, 368)
        Me.PressureClearButton.Name = "PressureClearButton"
        Me.PressureClearButton.Size = New System.Drawing.Size(75, 23)
        Me.PressureClearButton.TabIndex = 44
        Me.PressureClearButton.Text = "Clear"
        Me.PressureClearButton.UseVisualStyleBackColor = True
        '
        'PressurePanel
        '
        Me.PressurePanel.Controls.Add(Me.Label21)
        Me.PressurePanel.Controls.Add(Me.PressureDigi)
        Me.PressurePanel.Controls.Add(Me.PressureCurrentLabel)
        Me.PressurePanel.Controls.Add(Me.Label22)
        Me.PressurePanel.Location = New System.Drawing.Point(5, 9)
        Me.PressurePanel.Name = "PressurePanel"
        Me.PressurePanel.Size = New System.Drawing.Size(143, 58)
        Me.PressurePanel.TabIndex = 24
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(12, 4)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 30)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "Current" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pressure"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PressureDigi
        '
        Me.PressureDigi.BackColor = System.Drawing.Color.Transparent
        Me.PressureDigi.DigitColor = System.Drawing.Color.Red
        Me.PressureDigi.DigitText = "00"
        Me.PressureDigi.Location = New System.Drawing.Point(82, 3)
        Me.PressureDigi.Name = "PressureDigi"
        Me.PressureDigi.Size = New System.Drawing.Size(49, 31)
        Me.PressureDigi.TabIndex = 21
        '
        'PressureCurrentLabel
        '
        Me.PressureCurrentLabel.AutoSize = True
        Me.PressureCurrentLabel.ForeColor = System.Drawing.Color.Red
        Me.PressureCurrentLabel.Location = New System.Drawing.Point(107, 42)
        Me.PressureCurrentLabel.Name = "PressureCurrentLabel"
        Me.PressureCurrentLabel.Size = New System.Drawing.Size(34, 13)
        Me.PressureCurrentLabel.TabIndex = 19
        Me.PressureCurrentLabel.Text = "00.00"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(1, 42)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(99, 13)
        Me.Label22.TabIndex = 20
        Me.Label22.Text = "Sensor Output (mA)"
        '
        'PressureGraph
        '
        Me.PressureGraph.Location = New System.Drawing.Point(5, 73)
        Me.PressureGraph.Name = "PressureGraph"
        Me.PressureGraph.ScrollGrace = 0.0R
        Me.PressureGraph.ScrollMaxX = 0.0R
        Me.PressureGraph.ScrollMaxY = 0.0R
        Me.PressureGraph.ScrollMaxY2 = 0.0R
        Me.PressureGraph.ScrollMinX = 0.0R
        Me.PressureGraph.ScrollMinY = 0.0R
        Me.PressureGraph.ScrollMinY2 = 0.0R
        Me.PressureGraph.Size = New System.Drawing.Size(706, 347)
        Me.PressureGraph.TabIndex = 23
        '
        'flowmeter
        '
        Me.flowmeter.Controls.Add(Me.FlowClearButton)
        Me.flowmeter.Controls.Add(Me.FlowPanel)
        Me.flowmeter.Controls.Add(Me.FLowMeterGraph)
        Me.flowmeter.Location = New System.Drawing.Point(4, 22)
        Me.flowmeter.Name = "flowmeter"
        Me.flowmeter.Size = New System.Drawing.Size(715, 423)
        Me.flowmeter.TabIndex = 4
        Me.flowmeter.Text = "Flow Meter"
        Me.flowmeter.UseVisualStyleBackColor = True
        '
        'FlowClearButton
        '
        Me.FlowClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowClearButton.Location = New System.Drawing.Point(618, 368)
        Me.FlowClearButton.Name = "FlowClearButton"
        Me.FlowClearButton.Size = New System.Drawing.Size(75, 23)
        Me.FlowClearButton.TabIndex = 44
        Me.FlowClearButton.Text = "Clear"
        Me.FlowClearButton.UseVisualStyleBackColor = True
        '
        'FlowPanel
        '
        Me.FlowPanel.Controls.Add(Me.Label23)
        Me.FlowPanel.Controls.Add(Me.FlowMeterDigi)
        Me.FlowPanel.Controls.Add(Me.FlowMeterCurrentLabel)
        Me.FlowPanel.Controls.Add(Me.Label24)
        Me.FlowPanel.Location = New System.Drawing.Point(3, 3)
        Me.FlowPanel.Name = "FlowPanel"
        Me.FlowPanel.Size = New System.Drawing.Size(146, 57)
        Me.FlowPanel.TabIndex = 29
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(13, 4)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 30)
        Me.Label23.TabIndex = 27
        Me.Label23.Text = "Current" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pressure"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowMeterDigi
        '
        Me.FlowMeterDigi.BackColor = System.Drawing.Color.Transparent
        Me.FlowMeterDigi.DigitColor = System.Drawing.Color.Red
        Me.FlowMeterDigi.DigitText = "00"
        Me.FlowMeterDigi.Location = New System.Drawing.Point(85, 3)
        Me.FlowMeterDigi.Name = "FlowMeterDigi"
        Me.FlowMeterDigi.Size = New System.Drawing.Size(49, 31)
        Me.FlowMeterDigi.TabIndex = 26
        '
        'FlowMeterCurrentLabel
        '
        Me.FlowMeterCurrentLabel.AutoSize = True
        Me.FlowMeterCurrentLabel.ForeColor = System.Drawing.Color.Red
        Me.FlowMeterCurrentLabel.Location = New System.Drawing.Point(108, 42)
        Me.FlowMeterCurrentLabel.Name = "FlowMeterCurrentLabel"
        Me.FlowMeterCurrentLabel.Size = New System.Drawing.Size(34, 13)
        Me.FlowMeterCurrentLabel.TabIndex = 24
        Me.FlowMeterCurrentLabel.Text = "00.00"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.Red
        Me.Label24.Location = New System.Drawing.Point(2, 42)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(99, 13)
        Me.Label24.TabIndex = 25
        Me.Label24.Text = "Sensor Output (mA)"
        '
        'FLowMeterGraph
        '
        Me.FLowMeterGraph.Location = New System.Drawing.Point(3, 64)
        Me.FLowMeterGraph.Name = "FLowMeterGraph"
        Me.FLowMeterGraph.ScrollGrace = 0.0R
        Me.FLowMeterGraph.ScrollMaxX = 0.0R
        Me.FLowMeterGraph.ScrollMaxY = 0.0R
        Me.FLowMeterGraph.ScrollMaxY2 = 0.0R
        Me.FLowMeterGraph.ScrollMinX = 0.0R
        Me.FLowMeterGraph.ScrollMinY = 0.0R
        Me.FLowMeterGraph.ScrollMinY2 = 0.0R
        Me.FLowMeterGraph.Size = New System.Drawing.Size(709, 356)
        Me.FLowMeterGraph.TabIndex = 28
        '
        'DataScanTimer
        '
        Me.DataScanTimer.Interval = 1000
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectIPToolStripMenuItem2, Me.StartToolStripMenuItem2, Me.LoggingToolStripMenuItem1, Me.SearchToolStripMenuItem1, Me.DeleteToolStripMenuItem1, Me.SettingsToolStripMenuItem1, Me.StopWatchToolStripMenuItem1, Me.ChangeIPToolStripMenuItem, Me.SetAlarmToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1129, 25)
        Me.MenuStrip.TabIndex = 64
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'SelectIPToolStripMenuItem2
        '
        Me.SelectIPToolStripMenuItem2.Image = Global.Nvis_3002C.My.Resources.Resources.Ethernet
        Me.SelectIPToolStripMenuItem2.Name = "SelectIPToolStripMenuItem2"
        Me.SelectIPToolStripMenuItem2.Size = New System.Drawing.Size(84, 21)
        Me.SelectIPToolStripMenuItem2.Text = "Select &IP"
        '
        'StartToolStripMenuItem2
        '
        Me.StartToolStripMenuItem2.Image = Global.Nvis_3002C.My.Resources.Resources.play
        Me.StartToolStripMenuItem2.Name = "StartToolStripMenuItem2"
        Me.StartToolStripMenuItem2.Size = New System.Drawing.Size(63, 21)
        Me.StartToolStripMenuItem2.Text = "S&tart"
        '
        'LoggingToolStripMenuItem1
        '
        Me.LoggingToolStripMenuItem1.Image = Global.Nvis_3002C.My.Resources.Resources.log_start
        Me.LoggingToolStripMenuItem1.Name = "LoggingToolStripMenuItem1"
        Me.LoggingToolStripMenuItem1.Size = New System.Drawing.Size(115, 21)
        Me.LoggingToolStripMenuItem1.Text = "Start &Logging"
        '
        'SearchToolStripMenuItem1
        '
        Me.SearchToolStripMenuItem1.Image = Global.Nvis_3002C.My.Resources.Resources.search
        Me.SearchToolStripMenuItem1.Name = "SearchToolStripMenuItem1"
        Me.SearchToolStripMenuItem1.Size = New System.Drawing.Size(75, 21)
        Me.SearchToolStripMenuItem1.Text = "S&earch"
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Image = Global.Nvis_3002C.My.Resources.Resources.delete
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(73, 21)
        Me.DeleteToolStripMenuItem1.Text = "&Delete"
        '
        'SettingsToolStripMenuItem1
        '
        Me.SettingsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TemperaturePIDToolStripMenuItem, Me.LevelPIDToolStripMenuItem})
        Me.SettingsToolStripMenuItem1.Image = Global.Nvis_3002C.My.Resources.Resources.config
        Me.SettingsToolStripMenuItem1.Name = "SettingsToolStripMenuItem1"
        Me.SettingsToolStripMenuItem1.Size = New System.Drawing.Size(82, 21)
        Me.SettingsToolStripMenuItem1.Text = "&Settings"
        '
        'TemperaturePIDToolStripMenuItem
        '
        Me.TemperaturePIDToolStripMenuItem.Name = "TemperaturePIDToolStripMenuItem"
        Me.TemperaturePIDToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.TemperaturePIDToolStripMenuItem.Text = "&Temperature PID"
        '
        'LevelPIDToolStripMenuItem
        '
        Me.LevelPIDToolStripMenuItem.Name = "LevelPIDToolStripMenuItem"
        Me.LevelPIDToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.LevelPIDToolStripMenuItem.Text = "&Level PID"
        '
        'StopWatchToolStripMenuItem1
        '
        Me.StopWatchToolStripMenuItem1.Image = Global.Nvis_3002C.My.Resources.Resources.stopwatch
        Me.StopWatchToolStripMenuItem1.Name = "StopWatchToolStripMenuItem1"
        Me.StopWatchToolStripMenuItem1.Size = New System.Drawing.Size(103, 21)
        Me.StopWatchToolStripMenuItem1.Text = "Stop &Watch"
        '
        'ChangeIPToolStripMenuItem
        '
        Me.ChangeIPToolStripMenuItem.Image = CType(resources.GetObject("ChangeIPToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChangeIPToolStripMenuItem.Name = "ChangeIPToolStripMenuItem"
        Me.ChangeIPToolStripMenuItem.Size = New System.Drawing.Size(138, 21)
        Me.ChangeIPToolStripMenuItem.Text = "&Configure DAQ IP"
        '
        'SetAlarmToolStripMenuItem
        '
        Me.SetAlarmToolStripMenuItem.Image = CType(resources.GetObject("SetAlarmToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SetAlarmToolStripMenuItem.Name = "SetAlarmToolStripMenuItem"
        Me.SetAlarmToolStripMenuItem.Size = New System.Drawing.Size(92, 21)
        Me.SetAlarmToolStripMenuItem.Text = "Set A&larm"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.AboutToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(74, 21)
        Me.AboutToolStripMenuItem.Text = "&About Us"
        '
        'HeaterTimer
        '
        '
        'LevelTimer
        '
        '
        'BuzzerTimer
        '
        '
        'LinkLabel
        '
        Me.LinkLabel.AutoSize = True
        Me.LinkLabel.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel.ForeColor = System.Drawing.Color.Teal
        Me.LinkLabel.Location = New System.Drawing.Point(897, 132)
        Me.LinkLabel.Name = "LinkLabel"
        Me.LinkLabel.Size = New System.Drawing.Size(214, 19)
        Me.LinkLabel.TabIndex = 65
        Me.LinkLabel.Text = "Ethernet Link ___.___.___.___"
        '
        'LinkLedPictureBox
        '
        Me.LinkLedPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.LinkLedPictureBox.BackgroundImage = Global.Nvis_3002C.My.Resources.Resources.green_led_off
        Me.LinkLedPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LinkLedPictureBox.Location = New System.Drawing.Point(877, 133)
        Me.LinkLedPictureBox.Name = "LinkLedPictureBox"
        Me.LinkLedPictureBox.Size = New System.Drawing.Size(17, 17)
        Me.LinkLedPictureBox.TabIndex = 58
        Me.LinkLedPictureBox.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Location = New System.Drawing.Point(-1, 27)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(1136, 132)
        Me.PictureBox6.TabIndex = 55
        Me.PictureBox6.TabStop = False
        '
        'SelectIPToolStripMenuItem1
        '
        Me.SelectIPToolStripMenuItem1.Image = Global.Nvis_3002C.My.Resources.Resources.Ethernet
        Me.SelectIPToolStripMenuItem1.Name = "SelectIPToolStripMenuItem1"
        Me.SelectIPToolStripMenuItem1.Size = New System.Drawing.Size(77, 20)
        Me.SelectIPToolStripMenuItem1.Text = "&Select IP"
        '
        'StartToolStripMenuItem1
        '
        Me.StartToolStripMenuItem1.Image = Global.Nvis_3002C.My.Resources.Resources.play
        Me.StartToolStripMenuItem1.Name = "StartToolStripMenuItem1"
        Me.StartToolStripMenuItem1.Size = New System.Drawing.Size(59, 20)
        Me.StartToolStripMenuItem1.Text = "S&tart"
        '
        'LoggingToolStripMenuItem
        '
        Me.LoggingToolStripMenuItem.Image = Global.Nvis_3002C.My.Resources.Resources.log_start
        Me.LoggingToolStripMenuItem.Name = "LoggingToolStripMenuItem"
        Me.LoggingToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.LoggingToolStripMenuItem.Text = "Start &Logging"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Image = Global.Nvis_3002C.My.Resources.Resources.search
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.SearchToolStripMenuItem.Text = "Sea&rch"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = CType(resources.GetObject("DeleteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(600, 600)
        Me.DeleteToolStripMenuItem.Text = "&Delete"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TemperatureTransmitterToolStripMenuItem, Me.LevelTransmitterToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Image = CType(resources.GetObject("SettingsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.SettingsToolStripMenuItem.Text = "S&ettings"
        '
        'TemperatureTransmitterToolStripMenuItem
        '
        Me.TemperatureTransmitterToolStripMenuItem.Name = "TemperatureTransmitterToolStripMenuItem"
        Me.TemperatureTransmitterToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.TemperatureTransmitterToolStripMenuItem.Text = "&Temperature Transmitter"
        '
        'LevelTransmitterToolStripMenuItem
        '
        Me.LevelTransmitterToolStripMenuItem.Name = "LevelTransmitterToolStripMenuItem"
        Me.LevelTransmitterToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.LevelTransmitterToolStripMenuItem.Text = "&Level Transmitter"
        '
        'StopWatchToolStripMenuItem
        '
        Me.StopWatchToolStripMenuItem.Image = Global.Nvis_3002C.My.Resources.Resources.stopwatch
        Me.StopWatchToolStripMenuItem.Name = "StopWatchToolStripMenuItem"
        Me.StopWatchToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.StopWatchToolStripMenuItem.Text = "Stop &Watch"
        '
        'SelectIPToolStripMenuItem
        '
        Me.SelectIPToolStripMenuItem.Image = Global.Nvis_3002C.My.Resources.Resources.Ethernet
        Me.SelectIPToolStripMenuItem.Name = "SelectIPToolStripMenuItem"
        Me.SelectIPToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.SelectIPToolStripMenuItem.Text = "&Select IP"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Image = Global.Nvis_3002C.My.Resources.Resources.play
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.StartToolStripMenuItem.Text = "S&tart"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1129, 617)
        Me.Controls.Add(Me.LinkLabel)
        Me.Controls.Add(Me.LinkLedPictureBox)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nvis 3002B v1.0"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.EmergencyButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaterButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StopButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PumpButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StirrerButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SolValvButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PumpLed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SolValvLed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StirrerLed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HeaterLed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisualIndicatorLed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.liveview.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.LevelPanel.ResumeLayout(False)
        Me.LevelPanel.PerformLayout()
        CType(Me.LevelSPUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.temperature.ResumeLayout(False)
        Me.level.ResumeLayout(False)
        Me.pressure.ResumeLayout(False)
        Me.PressurePanel.ResumeLayout(False)
        Me.PressurePanel.PerformLayout()
        Me.flowmeter.ResumeLayout(False)
        Me.FlowPanel.ResumeLayout(False)
        Me.FlowPanel.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.LinkLedPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents VisualIndicatorLed As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents HeaterLed As System.Windows.Forms.PictureBox
    Friend WithEvents StirrerLed As System.Windows.Forms.PictureBox
    Friend WithEvents PumpLed As System.Windows.Forms.PictureBox
    Friend WithEvents SolValvLed As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SolValvButton As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents StirrerButton As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PumpButton As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StartButton As System.Windows.Forms.PictureBox
    Friend WithEvents StopButton As System.Windows.Forms.PictureBox
    Friend WithEvents HeaterButton As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SelectIPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EthernetSendTimer As System.Windows.Forms.Timer
    Friend WithEvents StartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EthernetRecTimer As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents EmergencyLabel As System.Windows.Forms.Label
    Friend WithEvents EmergencyButton As System.Windows.Forms.PictureBox
    Friend WithEvents SelectIPToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TemperatureTransmitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LevelTransmitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopWatchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents liveview As System.Windows.Forms.TabPage
    Friend WithEvents temperature As System.Windows.Forms.TabPage
    Friend WithEvents level As System.Windows.Forms.TabPage
    Friend WithEvents TemperatureGraph As ZedGraph.ZedGraphControl
    Friend WithEvents LevelGraph As ZedGraph.ZedGraphControl
    Friend WithEvents LoggingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lvllbl As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LevelSPDigi As Owf.Controls.DigitalDisplayControl
    Friend WithEvents LevelSPUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents LevelPanel As System.Windows.Forms.Panel
    Friend WithEvents DataScanTimer As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents SelectIPToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoggingToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TemperaturePIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LevelPIDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopWatchToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents TemperatureClearButton As System.Windows.Forms.Button
    Friend WithEvents LevelClearButton As System.Windows.Forms.Button
    Friend WithEvents DAQTemperatureLabel As System.Windows.Forms.Label
    Friend WithEvents HeaterTimer As System.Windows.Forms.Timer
    Friend WithEvents LevelTimer As System.Windows.Forms.Timer
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LevelDigi As Owf.Controls.DigitalDisplayControl
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents BuzzerTimer As System.Windows.Forms.Timer
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents BuzzerLabel As System.Windows.Forms.Label
    Friend WithEvents BuzzerArc As Arc.Arc
    Friend WithEvents ChangeIPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Nvis3002APanel1 As Nvis3002APanel.Nvis3002APanel
    Friend WithEvents LinkLedPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel As System.Windows.Forms.Label
    Friend WithEvents SetAlarmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pressure As System.Windows.Forms.TabPage
    Friend WithEvents PressureDigi As Owf.Controls.DigitalDisplayControl
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents PressureCurrentLabel As System.Windows.Forms.Label
    Friend WithEvents flowmeter As System.Windows.Forms.TabPage
    Friend WithEvents PressureGraph As ZedGraph.ZedGraphControl
    Friend WithEvents FlowMeterDigi As Owf.Controls.DigitalDisplayControl
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents FlowMeterCurrentLabel As System.Windows.Forms.Label
    Friend WithEvents FLowMeterGraph As ZedGraph.ZedGraphControl
    Friend WithEvents PressurePanel As System.Windows.Forms.Panel
    Friend WithEvents FlowPanel As System.Windows.Forms.Panel
    Friend WithEvents PressureClearButton As System.Windows.Forms.Button
    Friend WithEvents FlowClearButton As System.Windows.Forms.Button

End Class
