
Imports System
Imports ZedGraph
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Threading
Imports System.Threading.Thread
Imports Nvis3002APanel.Nvis3002APanel


Public Class MainForm

    'Public Shared TemperatureProcess As String

    Dim IsHardCompressorX3Pressed As Boolean = False
    Dim IsHardPumpX2Pressed As Boolean = False

    Dim VisualIndicatorY1 = "0"
    Dim PumpY2 As String = "0"
    Dim CompressorY3 As String = "0"
    Dim BuzzerY0 = "0"

    Dim ControlValveDAC0 As Integer

    Dim IsStartPressed = False
    'Dim IsHardEmergency = False

    Dim FlowLineItem, SetPointLineItem As LineItem
    Dim FlowPointPair, SetPointPointPair As New PointPairList
    'Dim RTDTemperatureSPLineItem, TTemperatureSPLineItem As LineItem
    'Dim RTDTemperatureSPPointPair, TTemperatureSPPointPair As New PointPairList

    Public SQLConnection As MySqlConnection
    Public SQLReader As MySqlDataReader
    Dim SQLCommand As MySqlCommand
    Public Shared SQLConnectionString, SQLInitConnectionString, DatabaseName As String

    Public ProportionalConstant As Double = 30 / 100
    Public DerivativeConstant As Double = 30 / 50 * 1
    Public IntegralConstant As Double = 30 * 80 / 1

    Public FlowValue As Double

    Dim Logging As Boolean = False

    Dim LinkCheckThread As Thread

    Private Sub Switch_Buzzer(ByVal state As Boolean)
        If state = True Then
            BuzzerY0 = "1"
            BuzzerArc.Animate = True
        Else
            BuzzerY0 = "0"
            BuzzerArc.Animate = False
            BuzzerArc.Progress = 0
        End If
    End Sub

    Private Sub Switch_VisualIndicator(ByVal state As Boolean)
        If state = True Then
            VisualIndicatorY1 = "1"
            VisualIndicatorLed.BackgroundImage = My.Resources.blue_led_on1
        Else
            VisualIndicatorY1 = "0"
            VisualIndicatorLed.BackgroundImage = My.Resources.blue_led_off
        End If
    End Sub

    Private Sub Switch_Compressor(ByVal state As Boolean)
        If state = True Then
            CompressorY3 = "1"
            CompressorLed.BackgroundImage = My.Resources.green_led_on
        Else
            CompressorY3 = "0"
            CompressorLed.BackgroundImage = My.Resources.green_led_off
        End If
    End Sub

    Private Sub Switch_Pump(ByVal state As Boolean)
        If state = True Then
            PumpY2 = "1"
            PumpLed.BackgroundImage = My.Resources.red_led_on
            WaterFlowSystem1.Fill = True
            PumpTimer.Enabled = True
        Else
            PumpY2 = "0"
            PumpLed.BackgroundImage = My.Resources.red_led_off
            WaterFlowSystem1.Fill = False
            PumpTimer.Enabled = False
        End If
    End Sub

    Private Sub Open_ControlValve(ByVal Opening As Integer)
        ' Valve opening         0 to 100 %
        ' Current for opening   4 to 20 mA
        ' Volts for 4-20 mA     0 to 2 V
        ' DAC for 0-2 V         0 to 102

        ' Here valve opening 0 to 100 % (4 to 20 mA) is scaled to DAC 0 to 102 (0 to 2V)
        If Opening < 25 Or Opening > 100 Then Exit Sub
        WaterFlowSystem1.ControlValveOpening = Opening
        'WaterFlowSystem1.ControlValveCurrent = Opening * 16 / 100 + 4
        ControlValveDAC0 = Opening * 409 / 100
        mATrackBar._Valeur = ControlValveDAC0
        'If Opening > 0 Then WaterFlowSystem1.OpenControlValve = True Else WaterFlowSystem1.OpenControlValve = False
    End Sub

    Private Sub StartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem2.Click
        Try
            If StartToolStripMenuItem2.Text = "S&tart" Then
                'If Ethernet.IsIPAccepted = False Then
                '    MessageBox.Show(Me, "First Select IP", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '    Exit Sub
                'End If
                If IsLinkFound = False Then
                    MessageBox.Show(Me, "No link found, check if your hardware is connected to LAN", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                Ethernet.Connect()
                Ethernet.Send("S")
                StartToolStripMenuItem2.Text = "S&top"
                StartToolStripMenuItem2.Image = My.Resources._stop
                EthernetSendTimer.Enabled = True
                EthernetRecTimer.Enabled = True
                DataScanTimer.Enabled = True
                'LinkLedTimer.Enabled = True
            Else
                Ethernet.Send("A00000000000000000")
                AllOFF()
                Ethernet.Disconnect()
                StartToolStripMenuItem2.Text = "S&tart"
                StartToolStripMenuItem2.Image = My.Resources.play
                EthernetSendTimer.Enabled = False
                EthernetRecTimer.Enabled = False
                DataScanTimer.Enabled = False
                'LinkLedTimer.Enabled = False
                'LinkLedPictureBox.BackgroundImage = My.Resources.green_led_off
                'IsLinkLedOn = False
            End If
        Catch ex As Exception
            Ethernet.Disconnect()
            EthernetSendTimer.Enabled = False
            EthernetRecTimer.Enabled = False
            MessageBox.Show(Me, "Can't connect with hardware, check if it is connected to LAN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub StartButton_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles StartButton.MouseDown
        If EthernetSendTimer.Enabled = False Then
            MessageBox.Show(Me, "First start the process, select the Start menu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        StartButton.BackgroundImage = My.Resources.Buttons_green_on
        IsStartPressed = True
        Switch_VisualIndicator(True)
        'LevelSPUpDown.Enabled = False
        'TemperatureSPUpDown.Enabled = False
        SetAlarmToolStripMenuItem.Enabled = False
        DataScanTimer.Enabled = True
        'PIDTimer.Enabled = True
    End Sub
    Private Sub StartButton_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles StartButton.MouseUp
        StartButton.BackgroundImage = My.Resources.Buttons_green_off
    End Sub


    Private Sub StopButton_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles StopButton.MouseDown
        StopButton.BackgroundImage = My.Resources.Buttons_red_on
        IsStartPressed = False
        Switch_Buzzer(False)
        AllOFF()
    End Sub
    Private Sub StopButton_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles StopButton.MouseUp
        StopButton.BackgroundImage = My.Resources.Buttons_red_off
    End Sub


    Private Sub CompressorButton_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CompressorButton.MouseDown
        If (IsStartPressed = False) Then Exit Sub
        If CompressorY3 = "1" Then
            Switch_Compressor(False)
        Else
            Switch_Compressor(True)
        End If
        CompressorButton.BackgroundImage = My.Resources.Buttons_yellow_on
    End Sub
    Private Sub CompressorButton_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CompressorButton.MouseUp
        CompressorButton.BackgroundImage = My.Resources.Buttons_yellow_off
    End Sub


    Private Sub PumpButton_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PumpButton.MouseDown
        If (IsStartPressed = False) Then Exit Sub
        If PumpY2 = "1" Then
            Switch_Pump(False)
        Else
            Switch_Pump(True)
        End If
        PumpButton.BackgroundImage = My.Resources.Buttons_yellow_on
    End Sub
    Private Sub PumpButton_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PumpButton.MouseUp
        PumpButton.BackgroundImage = My.Resources.Buttons_yellow_off
    End Sub


    Private Sub AllOFF()
        Switch_Compressor(False)
        Switch_Pump(False)
        Open_ControlValve(100)
        Switch_VisualIndicator(False)
        IsStartPressed = False
        DataScanTimer.Enabled = False
        'LevelSPUpDown.Enabled = True
        'TemperatureSPUpDown.Enabled = True
        SetAlarmToolStripMenuItem.Enabled = True
        'PIDTimer.Enabled = False
        FlowPanel.BackColor = Color.Transparent
    End Sub


    Private Sub EthernetRecTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EthernetRecTimer.Tick
        If Ethernet.IsDataReady = True Then
            EthernetDataReceived(Ethernet.ReceivedString)
            Ethernet.IsDataReady = False
        End If
    End Sub
    Dim IsHardwareFound As Boolean = False
    Dim StringCollector As String
    Private Sub EthernetDataReceived(ByVal ReceivedString As String)
        'Dim LevelSensorVoltage As Double
        'Dim TempSensorVoltage As Double
        StringCollector += ReceivedString
        'A03401229000236760100000000093A02936909000220350100000010096A03400630000213880100000000101
        If StringCollector.Contains("NV632C8") And IsHardwareFound = False Then
            StringCollector = ""
            IsHardwareFound = True
            MessageBox.Show(Me, "Hardware found", "Scientech 2474", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf StringCollector.StartsWith("A") And StringCollector.Length >= 29 Then
            DigitalInput(StringCollector.Substring(17, 8))
            DAQTemperatureLabel.Text = "DAQ Temperature: " + ((CDbl(StringCollector.Substring(26, 4)) * 3.3 / 1023) * 100).ToString("00") + "°C"

            '------------------------ Display Readings -----------------------------------------'
            If StringCollector.Substring(25, 1) = "0" Then
                'PressureCurrentLabel.Text = ((CDbl(StringCollector.Substring(1, 8)) * 5) / 16777215).ToString("00.0000")
                'CurrentPressureValue = CDbl(PressureCurrentLabel.Text)
                FlowValue = (CDbl(StringCollector.Substring(1, 8)) * 5) / 16777215
                FlowValue = FlowValue * 1000 / 120 ' Covert ADC voltage to current (mA) having 120E resistance
                WaterFlowSystem1.FlowCurrentValue = FlowValue
                FlowCurrentLabel.Text = FlowValue.ToString("0.0")
                FlowValue = FormatNumber((FlowValue - 4) * 2500 / 16, 1) ' Scaling of 4mA to 20mA with 0 (Ltr/Hr) to 100 (Ltr/Hr)
                'WaterFlowSystem1.FlowValuevalue = FlowValue
                FlowDigi.DigitText = CInt(FlowValue)
                'ElseIf StringCollector.Substring(25, 1) = "1" Then
            End If

            StringCollector = ""
            If IsStartPressed = False Or PumpTimer.Enabled = False Then Exit Sub

            '------------------------ Check if process is open loop or close loop (auto/manual) -----------------------------------------'
            If IsAutoSelected = True Then
                Pressure_P_PI_PID_Operation()
                '--------------------- Check if process is ON/OFF or P PI PID -----------------------------------------'
                'If ControlSettingsForm.onoffradio.Checked = True Then
                '    'If FlowValue < FlowSPUpDown.Value - Hysterisis Then
                '    '    Switch_Pump(True)
                '    '    Open_ControlValve(0)
                '    'ElseIf FlowValue > FlowSPUpDown.Value + Hysterisis Then
                '    '    Switch_Pump(False)
                '    '    Open_ControlValve(10)
                '    'Else
                '    '    Switch_Pump(False)
                '    '    'CompressorY3 = "0"
                '    '    'CompressorLed.BackgroundImage = My.Resources.green_led_off
                '    '    Open_ControlValve(0)
                '    'End If
                'Else
                '    '------------------- P PI PID Prcoess -------------------------------'
                '    Pressure_P_PI_PID_Operation()
                'End If
            End If

        ElseIf StringCollector.Length > 30 Then
            StringCollector = ""
        End If
    End Sub


    Dim PTerm, ITerm, DTerm, PreviousError As Double
    Private Sub Pressure_P_PI_PID_Operation()
        Dim ProcessError As Integer = FlowSPUpDown.Value - FlowValue

        '------------------ Check for P PI PID Process -----------------------------------------'
        If ControlSettingsForm.pradio.Checked Then
            '------------------ P Process -----------------------------------------'
            PTerm = ProportionalConstant * ProcessError
            ITerm = 0
            DTerm = 0
        ElseIf ControlSettingsForm.piradio.Checked Then
            '------------------ PI Process -----------------------------------------'
            PTerm = ProportionalConstant * ProcessError
            ITerm += IntegralConstant * ProcessError * 1
            DTerm = 0
        ElseIf ControlSettingsForm.pidradio.Checked Then
            '------------------ PID Process -----------------------------------------'
            PTerm = ProportionalConstant * ProcessError
            ITerm += IntegralConstant * ProcessError * 1
            DTerm = DerivativeConstant * (ProcessError - PreviousError)  '0
        End If
        '---------------- Check for overflow of integral due to summing --------------------'
        If ITerm < -5 Then ITerm = -5
        If ITerm > 5 Then ITerm = 5

        Dim CalculatedValveOpening As Integer = (PTerm + ITerm + DTerm)
        CalculatedValveOpening = 50 + CalculatedValveOpening
        If CalculatedValveOpening < 25 Then CalculatedValveOpening = 25
        If CalculatedValveOpening > 100 Then CalculatedValveOpening = 100
        PreviousError = ProcessError

        Open_ControlValve(CalculatedValveOpening)
    End Sub


    Private Sub DataScanTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataScanTimer.Tick
        If IsStartPressed = False Then Exit Sub

        FlowAlarmCheck()

        Dim CurrentDateTime As DateTime = DateTime.Now
        FlowGraph.RestoreScale(FlowGraph.GraphPane)
        With FlowGraph.GraphPane.XAxis
            .Type = AxisType.Date
            .Scale.Format = "HH:mm:ss"
            .Scale.MajorUnit = DateUnit.Hour
            .Scale.MinorUnit = DateUnit.Second
            .Scale.MinorStep = 1
        End With
        FlowGraph.RestoreScale(FlowGraph.GraphPane)
        With FlowGraph.GraphPane.XAxis
            .Type = AxisType.Date
            .Scale.Format = "HH:mm:ss"
            .Scale.MajorUnit = DateUnit.Hour
            .Scale.MinorUnit = DateUnit.Second
            .Scale.MinorStep = 1
        End With
        SetPointLineItem.AddPoint(CurrentDateTime.ToOADate(), FlowSPUpDown.Value)
        FlowLineItem.AddPoint(CurrentDateTime.ToOADate(), FlowValue)
        FlowGraph.AxisChange()
        FlowGraph.Refresh()

        If Logging = False Then Exit Sub
        Dim dt As String = ""
        dt = DateTime.Now().ToString("yyyy-MM-dd HH:mm:ss")
        SQLConnection.ConnectionString = SQLConnectionString
        Try
            SQLConnection.Open()
            SQLCommand = New MySqlCommand("insert into " + DatabaseName + "(datetime,SetPoint,FlowValue) values('" + dt + "'," + FlowSPUpDown.Value.ToString + "," + CInt(FlowValue).ToString + ");", SQLConnection)
            SQLCommand.ExecuteReader()
            SQLConnection.Close()
        Catch ex As Exception
            LoggingToolStripMenuItem.Text = "Stop &Logging"
            LoggingToolStripMenuItem_Click(Nothing, Nothing)
            MessageBox.Show(Me, "Can't insert data to database, check if you have entered correct database password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            SQLConnection.Close()
        End Try
    End Sub

    Private Sub DigitalInput(ByVal DI As String)
        If DI.Substring(0, 1) = "1" Then
            IsStartPressed = True
            'VisualIndicatorY4 = "1"
            Switch_VisualIndicator(True)
            'LevelSPUpDown.Enabled = False
            'TemperatureSPUpDown.Enabled = False
            SetAlarmToolStripMenuItem.Enabled = False
            DataScanTimer.Enabled = True
            'PIDTimer.Enabled = True
        End If

        If DI.Substring(1, 1) = "0" Then
            'IsEmergency = False
            Switch_Buzzer(False)
            AllOFF()
        End If

        If IsStartPressed = False Then Exit Sub

        If DI.Substring(2, 1) = "1" And IsHardPumpX2Pressed = False Then
            IsHardPumpX2Pressed = True
            If PumpY2 = "1" Then
                Switch_Pump(False)
            Else
                Switch_Pump(True)
            End If
        ElseIf DI.Substring(2, 1) = "0" Then
            IsHardPumpX2Pressed = False
        End If

        If DI.Substring(3, 1) = "1" And IsHardCompressorX3Pressed = False Then
            IsHardCompressorX3Pressed = True
            If CompressorY3 = "1" Then
                Switch_Compressor(False)
            Else
                Switch_Compressor(True)
            End If
        ElseIf DI.Substring(3, 1) = "0" Then
            IsHardCompressorX3Pressed = False
        End If




    End Sub


    Private Sub SelectIPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectIPToolStripMenuItem2.Click
        Ethernet.ShowDialog()
    End Sub

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Ethernet.Send("A00000000000000000")
        Threading.Thread.Sleep(100)
        Ethernet.Disconnect()
        LinkCheckThread.Abort()
    End Sub


    Private Sub LoadIPFile()
        Dim FilePath As String = Application.StartupPath + "\IP.txt"
        Try
            If System.IO.File.Exists(FilePath) Then
                Dim FileReader As New System.IO.StreamReader(FilePath)
                Ethernet.IP = FileReader.ReadLine()
                FileReader.Close()
            Else
                MessageBox.Show("File IP.txt doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Ethernet.IP = "192.168.0.190"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Open_ControlValve(100)
        LoadIPFile()

        Dim FlowGraphPane As GraphPane = FlowGraph.GraphPane

        SetPointLineItem = FlowGraphPane.AddCurve("Set Point", SetPointPointPair, Color.Blue, SymbolType.None)
        GraphSettings(FlowGraph, FlowGraphPane, SetPointLineItem, "Set Point (psi)", 100)

        FlowLineItem = FlowGraphPane.AddCurve("Flow", FlowPointPair, Color.Red, SymbolType.None)
        GraphSettings(FlowGraph, FlowGraphPane, FlowLineItem, "Flow (Ltr/min)", 100)

        SQLConnection = New MySqlConnection
        LoadFileConnectionString()
        TestDatabaseConnection()
        CreateDatabase()

        EthernetSendTimer.Interval = 200
        'EthernetSendTimer.Enabled = True
        EthernetRecTimer.Interval = 200
        'EthernetRecTimer.Enabled = True
        DataScanTimer.Interval = 1000
        'PIDTimer.Interval = 5000

        'LinkLedTimer.Interval = 500
        'LinkLedTimer.Enabled = True
        LinkCheckThread = New Thread(AddressOf PingIP)
        LinkCheckThread.Start()

        BuzzerArc.Animate = False
        BuzzerArc.Progress = 0
        BuzzerArc.Angle = 80
        BuzzerArc.Rotation = -40
        BuzzerArc.Distance = 10

        FlowSPUpDown.Value = 800

        PumpTimer.Interval = 60000
    End Sub


    Private Sub LoadFileConnectionString()
        Dim FilePath As String = Application.StartupPath + "\SQLConnectionString.txt"
        Try
            If System.IO.File.Exists(FilePath) Then
                Dim FileReader As New System.IO.StreamReader(FilePath)
                SQLConnectionString = FileReader.ReadLine()
                FileReader.Close()
                SQLInitConnectionString = SQLConnectionString.Substring(SQLConnectionString.IndexOf(";") + 1)
                DatabaseName = SQLConnectionString.Substring(SQLConnectionString.IndexOf("=") + 1)
                DatabaseName = DatabaseName.Substring(0, DatabaseName.IndexOf(";"))
            Else
                MessageBox.Show(Me, "File SQLConnectionString.txt doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub TestDatabaseConnection()
        SQLConnection.ConnectionString = SQLInitConnectionString
        Try
            SQLConnection.Open()
        Catch ex As Exception
            If ex.Message.Contains("Access denied") Then
                DatabaseConnection.ShowDialog()
            End If
        End Try
        SQLConnection.Close()
    End Sub

    Private Sub CreateDatabase()
        SQLConnection.ConnectionString = SQLInitConnectionString
        Try
            SQLConnection.Open()
            SQLCommand = New MySqlCommand("Create database " + DatabaseName, SQLConnection)
            SQLCommand.ExecuteReader()
            SQLConnection.Close()
        Catch
        Finally
            SQLConnection.Close()
        End Try
        Try
            SQLConnection.Open()
            SQLCommand = New MySqlCommand("Create table " + DatabaseName + "." + DatabaseName + "(datetime datetime,SetPoint integer,FlowValue integer);", SQLConnection)
            SQLCommand.ExecuteReader()
        Catch
        End Try
        SQLConnection.Close()
    End Sub


    Dim ChannelNumber As Integer = 0
    Private Sub EthernetSendTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EthernetSendTimer.Tick
        'If EthernetSendTimer.Enabled = False Then Exit Sub
        If IsLinkFound = False Then
            StartToolStripMenuItem1.Text = "S&top"
            StartToolStripMenuItem_Click(Nothing, Nothing)
            'StopButton_MouseDown(Nothing, Nothing)
            MessageBox.Show(Me, "Can't connect with hardware, check if it is connected to LAN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try
            If (Ethernet.IsConnected()) Then
                Ethernet.Send("A" + ChannelNumber.ToString("0") + BuzzerY0 + VisualIndicatorY1 + PumpY2 + CompressorY3 + "0000" + ControlValveDAC0.ToString("0000") + "0000")
                ' "A" + ChannelNumber +  Digital Output (8)+ DAC1.ToString("0000") + DAC2.ToString("0000")
                'ChannelNumber += 1
                'If ChannelNumber > 1 Then ChannelNumber = 0
            End If
        Catch ex As Exception
            StartToolStripMenuItem1.Text = "S&top"
            StartToolStripMenuItem_Click(Nothing, Nothing)
            'StopButton_MouseDown(Nothing, Nothing)
            MessageBox.Show(Me, "Can't connect with hardware, check if it is connected to LAN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub StopWatchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopWatchToolStripMenuItem1.Click
        StopWatch.Show()
    End Sub


    Public Sub GraphSettings(ByVal zed As ZedGraphControl, ByVal mypane As GraphPane, ByVal mycurve As LineItem, ByVal yTitle As String, ByVal range As Integer)
        mypane.Title.FontSpec.FontColor = Color.Black
        mypane.Legend.Position = ZedGraph.LegendPos.Bottom
        mypane.Legend.FontSpec.Size = 16
        mypane.Legend.FontSpec.IsBold = True
        mypane.Title.Text = "Flow vs Time"
        mypane.XAxis.Title.Text = "Time"
        mypane.YAxis.Title.Text = "Flow (Ltr/min)"
        set_scale(mypane, range)
        mycurve.Label.Text = yTitle
        mycurve.Line.Width = 2.0
        mycurve.Line.IsSmooth = False
        zed.IsAutoScrollRange = False
        zed.IsShowHScrollBar = True
        zed.IsSynchronizeXAxes = True
        zed.IsSynchronizeYAxes = True
        zed.Refresh()
        zed.AxisChange()
    End Sub
    Private Sub set_scale(ByVal grph As GraphPane, ByVal range As Integer)
        With grph
            .XAxis.Title.Text = "Time"
            .XAxis.Type = AxisType.Date
            .XAxis.Scale.Format = "HH:mm:ss"
            .XAxis.Scale.MajorUnit = DateUnit.Hour
            .XAxis.Scale.MinorUnit = DateUnit.Second
            .XAxis.Scale.MinorStep = 1
            .XAxis.Scale.FontSpec.IsBold = True
            .XAxis.Scale.FontSpec.Size = 14
            .YAxis.Scale.Min = -5
            .YAxis.Scale.Max = range
            .YAxis.Scale.MinorStep = 1
            .Title.FontSpec.Size = 18
            .Title.FontSpec.IsBold = True
            .YAxis.Scale.FontSpec.IsBold = True
            .YAxis.Scale.FontSpec.Size = 14
        End With
    End Sub


    Private Sub LoggingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoggingToolStripMenuItem1.Click
        If LoggingToolStripMenuItem1.Text = "Start &Logging" Then
            LoggingToolStripMenuItem1.Text = "Stop &Logging"
            LoggingToolStripMenuItem1.Image = My.Resources.log_close
            Logging = True
        ElseIf LoggingToolStripMenuItem1.Text = "Stop &Logging" Then
            LoggingToolStripMenuItem1.Text = "Start &Logging"
            LoggingToolStripMenuItem1.Image = My.Resources.log_start
            Logging = False
        End If
    End Sub

    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem1.Click
        search.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem1.Click
        Delete.ShowDialog()
    End Sub


    'Private Sub Panel3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles LevelPanel.MouseEnter, LevelSPDigi.MouseEnter, Label16.MouseEnter, LevelSPUpDown.MouseClick
    '    LevelPanel.BackColor = Color.CornflowerBlue
    '    TemperaturePanel.BackColor = Color.Transparent
    '    Panel5.BackColor = Color.Transparent
    'End Sub
    'Private Sub Panel3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles LevelPanel.MouseLeave
    '    LevelPanel.BackColor = Color.Transparent
    'End Sub

    'Private Sub Panel4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TemperaturePanel.MouseEnter, TemperatureSPDigi.MouseEnter, Label17.MouseEnter, TemperatureSPUpDown.MouseClick
    '    LevelPanel.BackColor = Color.Transparent
    '    TemperaturePanel.BackColor = Color.CornflowerBlue
    '    Panel5.BackColor = Color.Transparent
    'End Sub
    'Private Sub Panel4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TemperaturePanel.MouseLeave
    '    TemperaturePanel.BackColor = Color.Transparent
    'End Sub

    ''Private Sub DAQTemperatureLabel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel5.MouseEnter, DAQTemperatureLabel.MouseEnter
    ''    Panel3.BackColor = Color.Transparent
    ''    Panel4.BackColor = Color.Transparent
    ''    Panel5.BackColor = Color.CornflowerBlue
    ''End Sub
    ''Private Sub DAQTemperatureLabel_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel5.MouseLeave
    ''    Panel5.BackColor = Color.Transparent
    ''End Sub


    'Private Sub Panel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TemperaturePanel.Click, TemperatureSPDigi.Click, Label17.Click
    '    TabControl1.SelectedTab = temperature
    'End Sub


    'Private Sub Panel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LevelPanel.Click, LevelSPDigi.Click, Label16.Click
    '    TabControl1.SelectedTab = level
    'End Sub

    Private Sub GraphClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GraphClearButton.Click
        SetPointLineItem.Clear()
        FlowLineItem.Clear()
        FlowGraph.Refresh()
    End Sub


    Private Sub ChangeIPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeIPToolStripMenuItem.Click
        ShellExecute(0, "open", "http://" + Ethernet.IP + "/protect/config.htm", "", "", 3)
    End Sub
    Public Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer



    Delegate Sub InvokeDelegate()
    Public Shared IsLinkFound As Boolean = False
    Private Sub PingIP()
        Dim IsLinkLedOn As Boolean = False
        While True
            If Me.InvokeRequired Then
                Me.BeginInvoke(New InvokeDelegate(AddressOf LinkLabelUpdate))
            End If
            Try
                If (My.Computer.Network.Ping(Ethernet.IP)) Then
                    If IsLinkLedOn = True Then
                        IsLinkLedOn = False
                        LinkLedPictureBox.BackgroundImage = My.Resources.green_led_off
                    Else
                        IsLinkLedOn = True
                        LinkLedPictureBox.BackgroundImage = My.Resources.green_led_on
                    End If
                    IsLinkFound = True
                Else
                    IsLinkFound = False
                    IsLinkLedOn = False
                    LinkLedPictureBox.BackgroundImage = My.Resources.green_led_off
                End If
            Catch
                IsLinkFound = False
                IsLinkLedOn = False
                LinkLedPictureBox.BackgroundImage = My.Resources.green_led_off
            End Try
            Sleep(500)
        End While
    End Sub
    Private Sub LinkLabelUpdate()
        LinkLabel.Text = "Ethernet Link " + Environment.NewLine + Ethernet.IP
    End Sub

    Private Sub SetAlarmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetAlarmToolStripMenuItem.Click
        SetAlarm.ShowDialog()
    End Sub


    Private Sub FlowAlarmCheck()
        If SetAlarm.FlowAlarmTable.Rows.Count <= 0 Then Exit Sub
        Dim IsAlarmFlowValueAchieved As Boolean = False
        Dim i As Integer
        For i = 0 To SetAlarm.FlowAlarmTable.Rows.Count - 1
            If (CInt(FlowValue) = CInt(SetAlarm.FlowAlarmTable.Item(0, i).Value)) Then
                IsAlarmFlowValueAchieved = True
            End If
        Next
        If IsAlarmFlowValueAchieved = True Then
            Switch_Buzzer(True)
            FlowPanel.BackColor = Color.CornflowerBlue
        Else
            FlowPanel.BackColor = Color.Transparent
            Switch_Buzzer(False)
        End If
    End Sub


    Dim IsAutoSelected As Boolean = False
    Private Sub SwitchPanel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SwitchPanel.Click, AutoImage.Click, ManualImage.Click
        If IsAutoSelected = True Then
            ManualImage.Visible = True
            AutoImage.Visible = False
            IsAutoSelected = False
        Else
            ManualImage.Visible = False
            AutoImage.Visible = True
            IsAutoSelected = True
        End If
    End Sub

    Private Sub LinkLabel_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkLabel.DoubleClick
        Ethernet.ShowDialog()
    End Sub

    Private Sub FlowSPUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowSPUpDown.ValueChanged
        FlowSPDigi.DigitText = FlowSPUpDown.Value.ToString("00")
    End Sub

    Private Sub ProcessControlSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProcessControlSettingsToolStripMenuItem.Click
        ControlSettingsForm.ShowDialog()
    End Sub


    Private Sub mATrackBar__ValueChanged(ByVal Sender As Object, ByVal ValeurTrackBar As Integer) Handles mATrackBar._ValueChanged
        'Conversion from DAC 0 to 102 (0 to 2V) to 4 to 20 mA
        Dim ValveCurrent As Double = (ValeurTrackBar * 16 / 409 + 4)
        mADigi.DigitText = ValveCurrent.ToString("00.0")
        mATextBox.Text = mADigi.DigitText
        'Open_ControlValve(mATrackBar._Valeur * 100 / 409)
        Dim Opening As Integer = ValeurTrackBar * 100 / 409
        WaterFlowSystem1.ControlValveOpening = Opening
        'WaterFlowSystem1.ControlValveCurrent = ValveCurrent
        ControlValveDAC0 = ValeurTrackBar
        'If Opening > 0 Then WaterFlowSystem1.OpenControlValve = True Else WaterFlowSystem1.OpenControlValve = False
    End Sub

    Private Sub mATextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mATextBox.KeyDown
        Dim mAValue As Double
        If e.KeyData = Keys.Enter Then
            Try
                mAValue = CDbl(mATextBox.Text)
                If mAValue < 4 Or mAValue > 20 Then
                    MessageBox.Show(Me, "Value must be between 4 to 20 mA", "Range Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If
            Catch
                MessageBox.Show(Me, "Invalid Expression", "Enter valid value", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            mADigi.DigitText = mATextBox.Text
            'Conversion from 4 to 20 mA to DAC 0 to 102 (0 to 2V)
            Open_ControlValve((mAValue - 4) * 100 / 16)
        End If
    End Sub


    Private Sub PumpTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PumpTimer.Tick
        PumpTimer.Enabled = False
        Switch_Pump(False)
    End Sub

    Private Sub PumpTimeIntervalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PumpTimeIntervalToolStripMenuItem.Click
        PumpTimeForm.ShowDialog()
    End Sub

    Private Sub SensorInputSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SensorInputSettingsToolStripMenuItem.Click
        SettingsForm.ShowDialog()
    End Sub

End Class