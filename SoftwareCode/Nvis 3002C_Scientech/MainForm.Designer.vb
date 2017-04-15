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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.EthernetSendTimer = New System.Windows.Forms.Timer(Me.components)
        Me.EthernetRecTimer = New System.Windows.Forms.Timer(Me.components)
        Me.DataScanTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.SelectIPToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoggingToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopWatchToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeIPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetAlarmToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcessControlSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SensorInputSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PumpTimeIntervalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinkLabel = New System.Windows.Forms.Label()
        Me.LinkLedPictureBox = New System.Windows.Forms.PictureBox()
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
        Me.FlowPanel = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.FlowCurrentLabel = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.FlowDigi = New Owf.Controls.DigitalDisplayControl()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.FlowSPUpDown = New System.Windows.Forms.NumericUpDown()
        Me.FlowSPDigi = New Owf.Controls.DigitalDisplayControl()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CompressorButton = New System.Windows.Forms.PictureBox()
        Me.CompressorLed = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.BuzzerLabel = New System.Windows.Forms.Label()
        Me.BuzzerArc = New Arc.Arc()
        Me.PumpLed = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.VisualIndicatorLed = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PumpButton = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StartButton = New System.Windows.Forms.PictureBox()
        Me.StopButton = New System.Windows.Forms.PictureBox()
        Me.DAQTemperatureLabel = New System.Windows.Forms.Label()
        Me.FlowGraph = New ZedGraph.ZedGraphControl()
        Me.FlowGraphClearButton = New System.Windows.Forms.Button()
        Me.SwitchPanel = New System.Windows.Forms.Panel()
        Me.ManualImage = New System.Windows.Forms.PictureBox()
        Me.AutoImage = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.LiveTab = New System.Windows.Forms.TabPage()
        Me.WaterFlowSystem1 = New Nvis3002APanel.Nvis3002APanel()
        Me.FlowTab = New System.Windows.Forms.TabPage()
        Me.LevelTab = New System.Windows.Forms.TabPage()
        Me.LevelGraphClearButton = New System.Windows.Forms.Button()
        Me.LevelGraph = New ZedGraph.ZedGraphControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.mATextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.mATrackBar = New MPCD.TrackBar()
        Me.mADigi = New Owf.Controls.DigitalDisplayControl()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PumpTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.SolValButton = New System.Windows.Forms.PictureBox()
        Me.SolValLed = New System.Windows.Forms.PictureBox()
        Me.FlowContainerPanel = New System.Windows.Forms.Panel()
        Me.LevelContainerPanel = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LevelSPDigi = New Owf.Controls.DigitalDisplayControl()
        Me.LevelSPUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LevelCurrentLabel = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LevelDigi = New Owf.Controls.DigitalDisplayControl()
        Me.MenuStrip.SuspendLayout()
        CType(Me.LinkLedPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowPanel.SuspendLayout()
        CType(Me.FlowSPUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.CompressorButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompressorLed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PumpLed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisualIndicatorLed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PumpButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StartButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StopButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SwitchPanel.SuspendLayout()
        CType(Me.ManualImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutoImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.LiveTab.SuspendLayout()
        Me.FlowTab.SuspendLayout()
        Me.LevelTab.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.SolValButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SolValLed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowContainerPanel.SuspendLayout()
        Me.LevelContainerPanel.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.LevelSPUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Teal
        Me.Label12.Location = New System.Drawing.Point(13, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(330, 25)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Flow and Level Process Control"
        '
        'EthernetSendTimer
        '
        '
        'EthernetRecTimer
        '
        '
        'DataScanTimer
        '
        Me.DataScanTimer.Interval = 1000
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectIPToolStripMenuItem2, Me.StartToolStripMenuItem2, Me.LoggingToolStripMenuItem1, Me.SearchToolStripMenuItem1, Me.DeleteToolStripMenuItem1, Me.StopWatchToolStripMenuItem1, Me.ChangeIPToolStripMenuItem, Me.SetAlarmToolStripMenuItem, Me.SettingsMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1011, 25)
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
        'SettingsMenu
        '
        Me.SettingsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProcessControlSettingsToolStripMenuItem, Me.SensorInputSettingsToolStripMenuItem, Me.PumpTimeIntervalToolStripMenuItem})
        Me.SettingsMenu.Image = CType(resources.GetObject("SettingsMenu.Image"), System.Drawing.Image)
        Me.SettingsMenu.Name = "SettingsMenu"
        Me.SettingsMenu.Size = New System.Drawing.Size(82, 21)
        Me.SettingsMenu.Text = "&Settings"
        '
        'ProcessControlSettingsToolStripMenuItem
        '
        Me.ProcessControlSettingsToolStripMenuItem.Name = "ProcessControlSettingsToolStripMenuItem"
        Me.ProcessControlSettingsToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.ProcessControlSettingsToolStripMenuItem.Text = "&Process Control Settings"
        '
        'SensorInputSettingsToolStripMenuItem
        '
        Me.SensorInputSettingsToolStripMenuItem.Name = "SensorInputSettingsToolStripMenuItem"
        Me.SensorInputSettingsToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.SensorInputSettingsToolStripMenuItem.Text = "&Sensor Input Settings"
        '
        'PumpTimeIntervalToolStripMenuItem
        '
        Me.PumpTimeIntervalToolStripMenuItem.Name = "PumpTimeIntervalToolStripMenuItem"
        Me.PumpTimeIntervalToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.PumpTimeIntervalToolStripMenuItem.Text = "Pump Time &Interval"
        '
        'LinkLabel
        '
        Me.LinkLabel.AutoSize = True
        Me.LinkLabel.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel.ForeColor = System.Drawing.Color.Black
        Me.LinkLabel.Location = New System.Drawing.Point(34, 7)
        Me.LinkLabel.Name = "LinkLabel"
        Me.LinkLabel.Size = New System.Drawing.Size(104, 34)
        Me.LinkLabel.TabIndex = 65
        Me.LinkLabel.Text = "Ethernet Link" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "___.___.___.___"
        '
        'LinkLedPictureBox
        '
        Me.LinkLedPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.LinkLedPictureBox.BackgroundImage = Global.Nvis_3002C.My.Resources.Resources.green_led_off
        Me.LinkLedPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LinkLedPictureBox.Location = New System.Drawing.Point(13, 7)
        Me.LinkLedPictureBox.Name = "LinkLedPictureBox"
        Me.LinkLedPictureBox.Size = New System.Drawing.Size(15, 15)
        Me.LinkLedPictureBox.TabIndex = 58
        Me.LinkLedPictureBox.TabStop = False
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
        'FlowPanel
        '
        Me.FlowPanel.BackColor = System.Drawing.Color.Transparent
        Me.FlowPanel.Controls.Add(Me.Label20)
        Me.FlowPanel.Controls.Add(Me.FlowCurrentLabel)
        Me.FlowPanel.Controls.Add(Me.Label18)
        Me.FlowPanel.Controls.Add(Me.FlowDigi)
        Me.FlowPanel.Location = New System.Drawing.Point(4, 57)
        Me.FlowPanel.Name = "FlowPanel"
        Me.FlowPanel.Size = New System.Drawing.Size(168, 57)
        Me.FlowPanel.TabIndex = 87
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label20.Location = New System.Drawing.Point(35, 10)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(37, 15)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = "Flow"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowCurrentLabel
        '
        Me.FlowCurrentLabel.AutoSize = True
        Me.FlowCurrentLabel.ForeColor = System.Drawing.Color.DarkGreen
        Me.FlowCurrentLabel.Location = New System.Drawing.Point(123, 36)
        Me.FlowCurrentLabel.Name = "FlowCurrentLabel"
        Me.FlowCurrentLabel.Size = New System.Drawing.Size(34, 13)
        Me.FlowCurrentLabel.TabIndex = 2
        Me.FlowCurrentLabel.Text = "00.00"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label18.Location = New System.Drawing.Point(17, 36)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(99, 13)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Sensor Output (mA)"
        '
        'FlowDigi
        '
        Me.FlowDigi.BackColor = System.Drawing.Color.Transparent
        Me.FlowDigi.DigitColor = System.Drawing.Color.DarkGreen
        Me.FlowDigi.DigitText = "0000"
        Me.FlowDigi.Location = New System.Drawing.Point(74, 2)
        Me.FlowDigi.Name = "FlowDigi"
        Me.FlowDigi.Size = New System.Drawing.Size(67, 31)
        Me.FlowDigi.TabIndex = 17
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.DarkGreen
        Me.Label17.Location = New System.Drawing.Point(3, 7)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(69, 30)
        Me.Label17.TabIndex = 78
        Me.Label17.Text = "Flow" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Set Point"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowSPUpDown
        '
        Me.FlowSPUpDown.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.FlowSPUpDown.Location = New System.Drawing.Point(145, 12)
        Me.FlowSPUpDown.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.FlowSPUpDown.Minimum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.FlowSPUpDown.Name = "FlowSPUpDown"
        Me.FlowSPUpDown.Size = New System.Drawing.Size(18, 20)
        Me.FlowSPUpDown.TabIndex = 79
        Me.FlowSPUpDown.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'FlowSPDigi
        '
        Me.FlowSPDigi.BackColor = System.Drawing.Color.Transparent
        Me.FlowSPDigi.DigitColor = System.Drawing.Color.DarkGreen
        Me.FlowSPDigi.DigitText = "0000"
        Me.FlowSPDigi.Location = New System.Drawing.Point(70, 6)
        Me.FlowSPDigi.Name = "FlowSPDigi"
        Me.FlowSPDigi.Size = New System.Drawing.Size(69, 31)
        Me.FlowSPDigi.TabIndex = 77
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.CompressorButton)
        Me.Panel3.Controls.Add(Me.CompressorLed)
        Me.Panel3.Location = New System.Drawing.Point(599, 151)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(128, 71)
        Me.Panel3.TabIndex = 84
        '
        'CompressorButton
        '
        Me.CompressorButton.BackColor = System.Drawing.Color.Transparent
        Me.CompressorButton.BackgroundImage = Global.Nvis_3002C.My.Resources.Resources.Buttons_yellow_off
        Me.CompressorButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CompressorButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CompressorButton.Location = New System.Drawing.Point(8, 13)
        Me.CompressorButton.Name = "CompressorButton"
        Me.CompressorButton.Size = New System.Drawing.Size(50, 50)
        Me.CompressorButton.TabIndex = 28
        Me.CompressorButton.TabStop = False
        '
        'CompressorLed
        '
        Me.CompressorLed.BackColor = System.Drawing.Color.Transparent
        Me.CompressorLed.BackgroundImage = Global.Nvis_3002C.My.Resources.Resources.green_led_off
        Me.CompressorLed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CompressorLed.Location = New System.Drawing.Point(68, 13)
        Me.CompressorLed.Name = "CompressorLed"
        Me.CompressorLed.Size = New System.Drawing.Size(50, 50)
        Me.CompressorLed.TabIndex = 43
        Me.CompressorLed.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox7.Location = New System.Drawing.Point(210, 13)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(38, 50)
        Me.PictureBox7.TabIndex = 69
        Me.PictureBox7.TabStop = False
        '
        'BuzzerLabel
        '
        Me.BuzzerLabel.AutoSize = True
        Me.BuzzerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuzzerLabel.ForeColor = System.Drawing.Color.Black
        Me.BuzzerLabel.Location = New System.Drawing.Point(217, 143)
        Me.BuzzerLabel.Name = "BuzzerLabel"
        Me.BuzzerLabel.Size = New System.Drawing.Size(51, 15)
        Me.BuzzerLabel.TabIndex = 70
        Me.BuzzerLabel.Text = "Buzzer"
        '
        'BuzzerArc
        '
        Me.BuzzerArc.Angle = 40
        Me.BuzzerArc.Animate = False
        Me.BuzzerArc.BackColor = System.Drawing.Color.Transparent
        Me.BuzzerArc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BuzzerArc.Distance = 10
        Me.BuzzerArc.Location = New System.Drawing.Point(196, -12)
        Me.BuzzerArc.Name = "BuzzerArc"
        Me.BuzzerArc.Progress = 0
        Me.BuzzerArc.Radius = 50
        Me.BuzzerArc.Rotation = -20
        Me.BuzzerArc.Size = New System.Drawing.Size(105, 105)
        Me.BuzzerArc.TabIndex = 71
        Me.BuzzerArc.Time = 200
        '
        'PumpLed
        '
        Me.PumpLed.BackColor = System.Drawing.Color.Transparent
        Me.PumpLed.BackgroundImage = Global.Nvis_3002C.My.Resources.Resources.red_led_off
        Me.PumpLed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PumpLed.Location = New System.Drawing.Point(65, 13)
        Me.PumpLed.Name = "PumpLed"
        Me.PumpLed.Size = New System.Drawing.Size(50, 50)
        Me.PumpLed.TabIndex = 42
        Me.PumpLed.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(502, 143)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 15)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Pump"
        '
        'VisualIndicatorLed
        '
        Me.VisualIndicatorLed.BackColor = System.Drawing.Color.Transparent
        Me.VisualIndicatorLed.BackgroundImage = Global.Nvis_3002C.My.Resources.Resources.blue_led_off
        Me.VisualIndicatorLed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.VisualIndicatorLed.Location = New System.Drawing.Point(143, 15)
        Me.VisualIndicatorLed.Name = "VisualIndicatorLed"
        Me.VisualIndicatorLed.Size = New System.Drawing.Size(50, 50)
        Me.VisualIndicatorLed.TabIndex = 48
        Me.VisualIndicatorLed.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(153, 143)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 15)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Visual"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PumpButton)
        Me.Panel2.Controls.Add(Me.PumpLed)
        Me.Panel2.Location = New System.Drawing.Point(461, 151)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(124, 71)
        Me.Panel2.TabIndex = 83
        '
        'PumpButton
        '
        Me.PumpButton.BackColor = System.Drawing.Color.Transparent
        Me.PumpButton.BackgroundImage = Global.Nvis_3002C.My.Resources.Resources.Buttons_yellow_off
        Me.PumpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PumpButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PumpButton.Location = New System.Drawing.Point(6, 13)
        Me.PumpButton.Name = "PumpButton"
        Me.PumpButton.Size = New System.Drawing.Size(50, 50)
        Me.PumpButton.TabIndex = 36
        Me.PumpButton.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(24, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Start"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(621, 143)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "Compressor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(90, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 15)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Stop"
        '
        'StartButton
        '
        Me.StartButton.BackColor = System.Drawing.Color.Transparent
        Me.StartButton.BackgroundImage = Global.Nvis_3002C.My.Resources.Resources.Buttons_green_off
        Me.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StartButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StartButton.Location = New System.Drawing.Point(11, 13)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(50, 50)
        Me.StartButton.TabIndex = 30
        Me.StartButton.TabStop = False
        '
        'StopButton
        '
        Me.StopButton.BackColor = System.Drawing.Color.Transparent
        Me.StopButton.BackgroundImage = Global.Nvis_3002C.My.Resources.Resources.Buttons_red_off
        Me.StopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StopButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StopButton.Location = New System.Drawing.Point(78, 15)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(50, 50)
        Me.StopButton.TabIndex = 29
        Me.StopButton.TabStop = False
        '
        'DAQTemperatureLabel
        '
        Me.DAQTemperatureLabel.AutoSize = True
        Me.DAQTemperatureLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DAQTemperatureLabel.ForeColor = System.Drawing.Color.Red
        Me.DAQTemperatureLabel.Location = New System.Drawing.Point(4, 51)
        Me.DAQTemperatureLabel.Name = "DAQTemperatureLabel"
        Me.DAQTemperatureLabel.Size = New System.Drawing.Size(152, 15)
        Me.DAQTemperatureLabel.TabIndex = 81
        Me.DAQTemperatureLabel.Text = "DAQ Temperature: 0°C"
        Me.DAQTemperatureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowGraph
        '
        Me.FlowGraph.Location = New System.Drawing.Point(5, 5)
        Me.FlowGraph.Name = "FlowGraph"
        Me.FlowGraph.ScrollGrace = 0.0R
        Me.FlowGraph.ScrollMaxX = 0.0R
        Me.FlowGraph.ScrollMaxY = 0.0R
        Me.FlowGraph.ScrollMaxY2 = 0.0R
        Me.FlowGraph.ScrollMinX = 0.0R
        Me.FlowGraph.ScrollMinY = 0.0R
        Me.FlowGraph.ScrollMinY2 = 0.0R
        Me.FlowGraph.Size = New System.Drawing.Size(760, 396)
        Me.FlowGraph.TabIndex = 88
        '
        'FlowGraphClearButton
        '
        Me.FlowGraphClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowGraphClearButton.Location = New System.Drawing.Point(667, 348)
        Me.FlowGraphClearButton.Name = "FlowGraphClearButton"
        Me.FlowGraphClearButton.Size = New System.Drawing.Size(75, 23)
        Me.FlowGraphClearButton.TabIndex = 89
        Me.FlowGraphClearButton.Text = "Clear"
        Me.FlowGraphClearButton.UseVisualStyleBackColor = True
        '
        'SwitchPanel
        '
        Me.SwitchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SwitchPanel.Controls.Add(Me.ManualImage)
        Me.SwitchPanel.Controls.Add(Me.AutoImage)
        Me.SwitchPanel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SwitchPanel.Location = New System.Drawing.Point(743, 151)
        Me.SwitchPanel.Name = "SwitchPanel"
        Me.SwitchPanel.Size = New System.Drawing.Size(79, 71)
        Me.SwitchPanel.TabIndex = 90
        '
        'ManualImage
        '
        Me.ManualImage.Image = CType(resources.GetObject("ManualImage.Image"), System.Drawing.Image)
        Me.ManualImage.Location = New System.Drawing.Point(13, 14)
        Me.ManualImage.Name = "ManualImage"
        Me.ManualImage.Size = New System.Drawing.Size(54, 50)
        Me.ManualImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ManualImage.TabIndex = 1
        Me.ManualImage.TabStop = False
        '
        'AutoImage
        '
        Me.AutoImage.Image = CType(resources.GetObject("AutoImage.Image"), System.Drawing.Image)
        Me.AutoImage.Location = New System.Drawing.Point(7, 15)
        Me.AutoImage.Name = "AutoImage"
        Me.AutoImage.Size = New System.Drawing.Size(54, 50)
        Me.AutoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AutoImage.TabIndex = 0
        Me.AutoImage.TabStop = False
        Me.AutoImage.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(734, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 15)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Auto / Manual"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.LiveTab)
        Me.TabControl1.Controls.Add(Me.FlowTab)
        Me.TabControl1.Controls.Add(Me.LevelTab)
        Me.TabControl1.Location = New System.Drawing.Point(7, 233)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(781, 431)
        Me.TabControl1.TabIndex = 93
        '
        'LiveTab
        '
        Me.LiveTab.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.LiveTab.Controls.Add(Me.WaterFlowSystem1)
        Me.LiveTab.Location = New System.Drawing.Point(4, 22)
        Me.LiveTab.Name = "LiveTab"
        Me.LiveTab.Padding = New System.Windows.Forms.Padding(3)
        Me.LiveTab.Size = New System.Drawing.Size(773, 405)
        Me.LiveTab.TabIndex = 0
        Me.LiveTab.Text = "Live"
        '
        'WaterFlowSystem1
        '
        Me.WaterFlowSystem1.BackColor = System.Drawing.Color.Transparent
        Me.WaterFlowSystem1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WaterFlowSystem1.ControlValveOpening = 0
        Me.WaterFlowSystem1.Drain = False
        Me.WaterFlowSystem1.Fill = False
        Me.WaterFlowSystem1.FlowCurrentValue = 4.0R
        Me.WaterFlowSystem1.FlowMaxValue = 1000
        Me.WaterFlowSystem1.FlowMinValue = 0
        Me.WaterFlowSystem1.FlowTime = 20
        Me.WaterFlowSystem1.LevelCurrent = 4.0R
        Me.WaterFlowSystem1.LevelSetPoint = 0
        Me.WaterFlowSystem1.Location = New System.Drawing.Point(-3, -16)
        Me.WaterFlowSystem1.Name = "WaterFlowSystem1"
        Me.WaterFlowSystem1.OverFlow = False
        Me.WaterFlowSystem1.OverFlowAt = 90
        Me.WaterFlowSystem1.Size = New System.Drawing.Size(770, 420)
        Me.WaterFlowSystem1.StepSize = 5
        Me.WaterFlowSystem1.TabIndex = 0
        Me.WaterFlowSystem1.TankRange = 100
        Me.WaterFlowSystem1.WaterLevel = 0
        '
        'FlowTab
        '
        Me.FlowTab.Controls.Add(Me.FlowGraphClearButton)
        Me.FlowTab.Controls.Add(Me.FlowGraph)
        Me.FlowTab.Location = New System.Drawing.Point(4, 22)
        Me.FlowTab.Name = "FlowTab"
        Me.FlowTab.Padding = New System.Windows.Forms.Padding(3)
        Me.FlowTab.Size = New System.Drawing.Size(773, 405)
        Me.FlowTab.TabIndex = 1
        Me.FlowTab.Text = "Flow"
        Me.FlowTab.UseVisualStyleBackColor = True
        '
        'LevelTab
        '
        Me.LevelTab.BackColor = System.Drawing.Color.White
        Me.LevelTab.Controls.Add(Me.LevelGraphClearButton)
        Me.LevelTab.Controls.Add(Me.LevelGraph)
        Me.LevelTab.Location = New System.Drawing.Point(4, 22)
        Me.LevelTab.Name = "LevelTab"
        Me.LevelTab.Size = New System.Drawing.Size(773, 405)
        Me.LevelTab.TabIndex = 2
        Me.LevelTab.Text = "Level"
        '
        'LevelGraphClearButton
        '
        Me.LevelGraphClearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LevelGraphClearButton.Location = New System.Drawing.Point(667, 348)
        Me.LevelGraphClearButton.Name = "LevelGraphClearButton"
        Me.LevelGraphClearButton.Size = New System.Drawing.Size(75, 23)
        Me.LevelGraphClearButton.TabIndex = 90
        Me.LevelGraphClearButton.Text = "Clear"
        Me.LevelGraphClearButton.UseVisualStyleBackColor = True
        '
        'LevelGraph
        '
        Me.LevelGraph.Location = New System.Drawing.Point(5, 5)
        Me.LevelGraph.Name = "LevelGraph"
        Me.LevelGraph.ScrollGrace = 0.0R
        Me.LevelGraph.ScrollMaxX = 0.0R
        Me.LevelGraph.ScrollMaxY = 0.0R
        Me.LevelGraph.ScrollMaxY2 = 0.0R
        Me.LevelGraph.ScrollMinX = 0.0R
        Me.LevelGraph.ScrollMinY = 0.0R
        Me.LevelGraph.ScrollMinY2 = 0.0R
        Me.LevelGraph.Size = New System.Drawing.Size(760, 396)
        Me.LevelGraph.TabIndex = 89
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox7)
        Me.Panel1.Controls.Add(Me.VisualIndicatorLed)
        Me.Panel1.Controls.Add(Me.StopButton)
        Me.Panel1.Controls.Add(Me.StartButton)
        Me.Panel1.Controls.Add(Me.BuzzerArc)
        Me.Panel1.Location = New System.Drawing.Point(7, 151)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(314, 71)
        Me.Panel1.TabIndex = 94
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.LinkLabel)
        Me.Panel4.Controls.Add(Me.LinkLedPictureBox)
        Me.Panel4.Controls.Add(Me.DAQTemperatureLabel)
        Me.Panel4.Location = New System.Drawing.Point(836, 151)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(169, 71)
        Me.Panel4.TabIndex = 95
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.FlowSPDigi)
        Me.Panel5.Controls.Add(Me.FlowSPUpDown)
        Me.Panel5.Location = New System.Drawing.Point(4, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(168, 48)
        Me.Panel5.TabIndex = 96
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.mATextBox)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Location = New System.Drawing.Point(809, 249)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(176, 150)
        Me.Panel6.TabIndex = 97
        '
        'mATextBox
        '
        Me.mATextBox.Location = New System.Drawing.Point(119, 120)
        Me.mATextBox.Mask = "00.0"
        Me.mATextBox.Name = "mATextBox"
        Me.mATextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.mATextBox.Size = New System.Drawing.Size(41, 20)
        Me.mATextBox.TabIndex = 100
        Me.mATextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 15)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Set Current (mA)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.Controls.Add(Me.mATrackBar)
        Me.Panel7.Controls.Add(Me.mADigi)
        Me.Panel7.Controls.Add(Me.Label7)
        Me.Panel7.Location = New System.Drawing.Point(9, 20)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(157, 94)
        Me.Panel7.TabIndex = 99
        '
        'mATrackBar
        '
        Me.mATrackBar._CouleurA = System.Drawing.Color.Red
        Me.mATrackBar._CouleurCurseur = System.Drawing.Color.White
        Me.mATrackBar._CouleurDe = System.Drawing.Color.Red
        Me.mATrackBar._Curseur = MPCD.TrackBar.TypeCurseur.Losange
        Me.mATrackBar._Epaisseur = 15
        Me.mATrackBar._Maximum = 409
        Me.mATrackBar._Minimum = 0
        Me.mATrackBar._ModeleCouleur = MPCD.TrackBar.MyColor.PasDeModele
        Me.mATrackBar._PasDeGraduation = 1
        Me.mATrackBar._Style = MPCD.TrackBar.MyStyle.Graduation
        Me.mATrackBar._Valeur = 3
        Me.mATrackBar.BackColor = System.Drawing.Color.Black
        Me.mATrackBar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mATrackBar.ForeColor = System.Drawing.Color.White
        Me.mATrackBar.Location = New System.Drawing.Point(6, 63)
        Me.mATrackBar.Margin = New System.Windows.Forms.Padding(0)
        Me.mATrackBar.Name = "mATrackBar"
        Me.mATrackBar.Size = New System.Drawing.Size(145, 25)
        Me.mATrackBar.TabIndex = 133
        Me.mATrackBar.Text = "TrackBar1"
        '
        'mADigi
        '
        Me.mADigi.BackColor = System.Drawing.Color.Transparent
        Me.mADigi.DigitColor = System.Drawing.Color.Red
        Me.mADigi.DigitText = "04.0"
        Me.mADigi.Location = New System.Drawing.Point(29, 10)
        Me.mADigi.Name = "mADigi"
        Me.mADigi.Size = New System.Drawing.Size(65, 53)
        Me.mADigi.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(102, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 15)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "mA"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(851, 239)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 15)
        Me.Label8.TabIndex = 98
        Me.Label8.Text = "Control Valve"
        '
        'PumpTimer
        '
        '
        'PictureBox6
        '
        Me.PictureBox6.BackgroundImage = CType(resources.GetObject("PictureBox6.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Location = New System.Drawing.Point(-79, 28)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(1091, 112)
        Me.PictureBox6.TabIndex = 99
        Me.PictureBox6.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(340, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 15)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Solenoid Valve"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Transparent
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.SolValButton)
        Me.Panel8.Controls.Add(Me.SolValLed)
        Me.Panel8.Location = New System.Drawing.Point(329, 150)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(124, 71)
        Me.Panel8.TabIndex = 101
        '
        'SolValButton
        '
        Me.SolValButton.BackColor = System.Drawing.Color.Transparent
        Me.SolValButton.BackgroundImage = Global.Nvis_3002C.My.Resources.Resources.Buttons_yellow_off
        Me.SolValButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SolValButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SolValButton.Location = New System.Drawing.Point(6, 13)
        Me.SolValButton.Name = "SolValButton"
        Me.SolValButton.Size = New System.Drawing.Size(50, 50)
        Me.SolValButton.TabIndex = 36
        Me.SolValButton.TabStop = False
        '
        'SolValLed
        '
        Me.SolValLed.BackColor = System.Drawing.Color.Transparent
        Me.SolValLed.BackgroundImage = Global.Nvis_3002C.My.Resources.Resources.orange_led_off
        Me.SolValLed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SolValLed.Location = New System.Drawing.Point(65, 13)
        Me.SolValLed.Name = "SolValLed"
        Me.SolValLed.Size = New System.Drawing.Size(50, 50)
        Me.SolValLed.TabIndex = 42
        Me.SolValLed.TabStop = False
        '
        'FlowContainerPanel
        '
        Me.FlowContainerPanel.Controls.Add(Me.Panel5)
        Me.FlowContainerPanel.Controls.Add(Me.FlowPanel)
        Me.FlowContainerPanel.Location = New System.Drawing.Point(805, 405)
        Me.FlowContainerPanel.Name = "FlowContainerPanel"
        Me.FlowContainerPanel.Size = New System.Drawing.Size(180, 120)
        Me.FlowContainerPanel.TabIndex = 102
        '
        'LevelContainerPanel
        '
        Me.LevelContainerPanel.Controls.Add(Me.Panel10)
        Me.LevelContainerPanel.Controls.Add(Me.Panel11)
        Me.LevelContainerPanel.Location = New System.Drawing.Point(805, 537)
        Me.LevelContainerPanel.Name = "LevelContainerPanel"
        Me.LevelContainerPanel.Size = New System.Drawing.Size(180, 120)
        Me.LevelContainerPanel.TabIndex = 103
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Label10)
        Me.Panel10.Controls.Add(Me.LevelSPDigi)
        Me.Panel10.Controls.Add(Me.LevelSPUpDown)
        Me.Panel10.Location = New System.Drawing.Point(4, 3)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(168, 48)
        Me.Panel10.TabIndex = 96
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(8, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(65, 30)
        Me.Label10.TabIndex = 78
        Me.Label10.Text = "Level" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Set Point"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LevelSPDigi
        '
        Me.LevelSPDigi.BackColor = System.Drawing.Color.Transparent
        Me.LevelSPDigi.DigitColor = System.Drawing.Color.Blue
        Me.LevelSPDigi.DigitText = "000"
        Me.LevelSPDigi.Location = New System.Drawing.Point(70, 6)
        Me.LevelSPDigi.Name = "LevelSPDigi"
        Me.LevelSPDigi.Size = New System.Drawing.Size(69, 31)
        Me.LevelSPDigi.TabIndex = 77
        '
        'LevelSPUpDown
        '
        Me.LevelSPUpDown.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.LevelSPUpDown.Location = New System.Drawing.Point(145, 12)
        Me.LevelSPUpDown.Maximum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.LevelSPUpDown.Minimum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.LevelSPUpDown.Name = "LevelSPUpDown"
        Me.LevelSPUpDown.Size = New System.Drawing.Size(18, 20)
        Me.LevelSPUpDown.TabIndex = 79
        Me.LevelSPUpDown.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.Transparent
        Me.Panel11.Controls.Add(Me.Label13)
        Me.Panel11.Controls.Add(Me.LevelCurrentLabel)
        Me.Panel11.Controls.Add(Me.Label15)
        Me.Panel11.Controls.Add(Me.LevelDigi)
        Me.Panel11.Location = New System.Drawing.Point(4, 57)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(168, 57)
        Me.Panel11.TabIndex = 87
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(28, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 15)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Level"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LevelCurrentLabel
        '
        Me.LevelCurrentLabel.AutoSize = True
        Me.LevelCurrentLabel.ForeColor = System.Drawing.Color.Blue
        Me.LevelCurrentLabel.Location = New System.Drawing.Point(123, 36)
        Me.LevelCurrentLabel.Name = "LevelCurrentLabel"
        Me.LevelCurrentLabel.Size = New System.Drawing.Size(34, 13)
        Me.LevelCurrentLabel.TabIndex = 2
        Me.LevelCurrentLabel.Text = "00.00"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(17, 36)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(99, 13)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Sensor Output (mA)"
        '
        'LevelDigi
        '
        Me.LevelDigi.BackColor = System.Drawing.Color.Transparent
        Me.LevelDigi.DigitColor = System.Drawing.Color.Blue
        Me.LevelDigi.DigitText = "000"
        Me.LevelDigi.Location = New System.Drawing.Point(72, 2)
        Me.LevelDigi.Name = "LevelDigi"
        Me.LevelDigi.Size = New System.Drawing.Size(67, 31)
        Me.LevelDigi.TabIndex = 17
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1011, 669)
        Me.Controls.Add(Me.LevelContainerPanel)
        Me.Controls.Add(Me.FlowContainerPanel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BuzzerLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.SwitchPanel)
        Me.Controls.Add(Me.MenuStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nvis 3002C v1.0"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.LinkLedPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowPanel.ResumeLayout(False)
        Me.FlowPanel.PerformLayout()
        CType(Me.FlowSPUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.CompressorButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompressorLed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PumpLed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisualIndicatorLed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PumpButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StartButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StopButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SwitchPanel.ResumeLayout(False)
        CType(Me.ManualImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutoImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.LiveTab.ResumeLayout(False)
        Me.FlowTab.ResumeLayout(False)
        Me.LevelTab.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        CType(Me.SolValButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SolValLed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowContainerPanel.ResumeLayout(False)
        Me.LevelContainerPanel.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        CType(Me.LevelSPUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SelectIPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EthernetSendTimer As System.Windows.Forms.Timer
    Friend WithEvents StartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EthernetRecTimer As System.Windows.Forms.Timer
    Friend WithEvents SelectIPToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TemperatureTransmitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LevelTransmitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopWatchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoggingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataScanTimer As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents SelectIPToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoggingToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopWatchToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangeIPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LinkLedPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents LinkLabel As System.Windows.Forms.Label
    Friend WithEvents SetAlarmToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FlowPanel As System.Windows.Forms.Panel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents FlowCurrentLabel As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents FlowDigi As Owf.Controls.DigitalDisplayControl
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents FlowSPUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents FlowSPDigi As Owf.Controls.DigitalDisplayControl
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents CompressorLed As System.Windows.Forms.PictureBox
    Friend WithEvents PumpLed As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents VisualIndicatorLed As System.Windows.Forms.PictureBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PumpButton As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StartButton As System.Windows.Forms.PictureBox
    Friend WithEvents StopButton As System.Windows.Forms.PictureBox
    Friend WithEvents CompressorButton As System.Windows.Forms.PictureBox
    Friend WithEvents DAQTemperatureLabel As System.Windows.Forms.Label
    Friend WithEvents FlowGraph As ZedGraph.ZedGraphControl
    Friend WithEvents FlowGraphClearButton As System.Windows.Forms.Button
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents BuzzerLabel As System.Windows.Forms.Label
    Friend WithEvents BuzzerArc As Arc.Arc
    Friend WithEvents SwitchPanel As System.Windows.Forms.Panel
    Friend WithEvents ManualImage As System.Windows.Forms.PictureBox
    Friend WithEvents AutoImage As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SettingsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcessControlSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents LiveTab As System.Windows.Forms.TabPage
    Friend WithEvents FlowTab As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents mADigi As Owf.Controls.DigitalDisplayControl
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents mATrackBar As MPCD.TrackBar
    Friend WithEvents mATextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PumpTimer As System.Windows.Forms.Timer
    Friend WithEvents SensorInputSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PumpTimeIntervalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents WaterFlowSystem1 As Nvis3002APanel.Nvis3002APanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents SolValButton As System.Windows.Forms.PictureBox
    Friend WithEvents SolValLed As System.Windows.Forms.PictureBox
    Friend WithEvents LevelTab As System.Windows.Forms.TabPage
    Friend WithEvents LevelGraph As ZedGraph.ZedGraphControl
    Friend WithEvents LevelGraphClearButton As System.Windows.Forms.Button
    Friend WithEvents FlowContainerPanel As System.Windows.Forms.Panel
    Friend WithEvents LevelContainerPanel As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LevelSPDigi As Owf.Controls.DigitalDisplayControl
    Friend WithEvents LevelSPUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LevelCurrentLabel As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LevelDigi As Owf.Controls.DigitalDisplayControl

End Class
