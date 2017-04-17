
Imports System
Imports ZedGraph
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Threading
Imports System.Threading.Thread
Imports Nvis3002APanel.Nvis3002APanel


Public Class MainForm

    'Public Shared TemperatureProcess As String

    Dim IsHardPumpX2Pressed As Boolean = False
    Dim IsHardSolValX3Pressed As Boolean = False
    Dim IsHardCompressorX4Pressed As Boolean = False

    Dim PumpY0 As String = "0"
    Dim SolenoidValveY1 As String = "0"
    Dim CompressorY2 As String = "0"
    Dim VisualIndicatorY3 = "0"
    Dim BuzzerY4 = "0"

    Dim ControlValveDAC0 As Integer

    Dim IsStartPressed = False
    'Dim IsHardEmergency = False

    Dim FlowLineItem, FlowSetPointLineItem As LineItem
    Dim FlowPointPair, FlowSetPointPointPair As New PointPairList

    Dim LevelLineItem, LevelSetPointLineItem As LineItem
    Dim LevelPointPair, LevelSetPointPointPair As New PointPairList

    'Dim RTDTemperatureSPLineItem, TTemperatureSPLineItem As LineItem
    'Dim RTDTemperatureSPPointPair, TTemperatureSPPointPair As New PointPairList

    Public SQLConnection As MySqlConnection
    Public SQLReader As MySqlDataReader
    Dim SQLCommand As MySqlCommand
    Public Shared SQLConnectionString, SQLInitConnectionString, DatabaseName As String
    Public Shared FlowTableName As String = "Flow_1v0"
    Public Shared LevelTableName As String = "Level_1v0"

    Public FlowProportionalConstant As Double = 30 / 100
    Public FlowDerivativeConstant As Double = 30 / 50 * 1
    Public FlowIntegralConstant As Double = 30 * 80 / 1

    Public LevelProportionalConstant As Double = 30 / 100
    Public LevelDerivativeConstant As Double = 30 / 50 * 1
    Public LevelIntegralConstant As Double = 30 * 80 / 1

    Public FlowValue As Integer
    Public LevelValue As Integer

    Dim Logging As Boolean = False

    Dim LinkCheckThread As Thread

    Private Sub Switch_Start()
        IsStartPressed = True
        Switch_VisualIndicator(True)
        SelectorPanel.Enabled = False
        SetAlarmToolStripMenuItem.Enabled = False
        SettingsToolStripMenuItem.Enabled = False
        DataScanTimer.Enabled = True
        If CurrentProcess = PIDProcesses.FlowProcess Then
            Switch_Pump(True)
            PumpTimer.Enabled = True
            LevelPIDTimer.Enabled = False
        ElseIf CurrentProcess = PIDProcesses.LevelProcess Then
            PumpTimer.Enabled = False
            LevelStates = 0
            LevelPIDTimer.Interval = 1
            LevelPIDTimer.Enabled = True
        End If
    End Sub

    Private Sub Switch_Stop()
        Switch_Buzzer(False)
        AllOFF()
    End Sub

    Private Sub Switch_Buzzer(ByVal state As Boolean)
        If state = True Then
            BuzzerY4 = "1"
            BuzzerArc.Animate = True
        Else
            BuzzerY4 = "0"
            BuzzerArc.Animate = False
            BuzzerArc.Progress = 0
        End If
    End Sub

    Private Sub Switch_VisualIndicator(ByVal state As Boolean)
        If state = True Then
            VisualIndicatorY3 = "1"
            VisualIndicatorLed.BackgroundImage = My.Resources.blue_led_on1
        Else
            VisualIndicatorY3 = "0"
            VisualIndicatorLed.BackgroundImage = My.Resources.blue_led_off
        End If
    End Sub

    Private Sub Switch_Compressor(ByVal state As Boolean)
        If state = True Then
            CompressorY2 = "1"
            CompressorLed.BackgroundImage = My.Resources.green_led_on
        Else
            CompressorY2 = "0"
            CompressorLed.BackgroundImage = My.Resources.green_led_off
        End If
    End Sub

    Private Sub Switch_Pump(ByVal state As Boolean)
        If state = True Then
            PumpY0 = "1"
            PumpLed.BackgroundImage = My.Resources.red_led_on
            WaterFlowSystem1.Fill = True
        Else
            PumpY0 = "0"
            PumpLed.BackgroundImage = My.Resources.red_led_off
            WaterFlowSystem1.Fill = False
        End If
    End Sub

    Private Sub Switch_SolenoidValve(ByVal state As Boolean)
        If state = True Then
            SolenoidValveY1 = "1"
            SolValLed.BackgroundImage = My.Resources.red_led_on
            WaterFlowSystem1.Drain = True
        Else
            SolenoidValveY1 = "0"
            SolValLed.BackgroundImage = My.Resources.red_led_off
            WaterFlowSystem1.Drain = False
        End If
    End Sub

    Private Sub Open_ControlValve(ByVal Opening As Integer)
        ' Valve opening         0 to 100 %
        ' Current for opening   4 to 20 mA
        ' Volts for 4-20 mA     0 to 2 V
        ' DAC for 0-2 V         0 to 102

        ' Here valve opening 0 to 100 % (4 to 20 mA) is scaled to DAC 0 to 102 (0 to 2V)
        If Opening > 100 Then Exit Sub
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
            Else
                Ethernet.Send("A00000000000000000")
                Switch_Stop()
                Ethernet.Disconnect()
                StartToolStripMenuItem2.Text = "S&tart"
                StartToolStripMenuItem2.Image = My.Resources.play
                EthernetSendTimer.Enabled = False
                EthernetRecTimer.Enabled = False
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
        Switch_Start()
    End Sub
    Private Sub StartButton_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles StartButton.MouseUp
        StartButton.BackgroundImage = My.Resources.Buttons_green_off
    End Sub


    Private Sub StopButton_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles StopButton.MouseDown
        StopButton.BackgroundImage = My.Resources.Buttons_red_on
        Switch_Stop()
    End Sub
    Private Sub StopButton_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles StopButton.MouseUp
        StopButton.BackgroundImage = My.Resources.Buttons_red_off
    End Sub


    Private Sub CompressorButton_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CompressorButton.MouseDown
        If (IsStartPressed = False) Then Exit Sub
        If CompressorY2 = "1" Then
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
        If PumpY0 = "1" Then
            Switch_Pump(False)
        Else
            Switch_Pump(True)
        End If
        PumpButton.BackgroundImage = My.Resources.Buttons_yellow_on
    End Sub
    Private Sub PumpButton_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PumpButton.MouseUp
        PumpButton.BackgroundImage = My.Resources.Buttons_yellow_off
    End Sub

    Private Sub SolValButton_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SolValButton.MouseDown
        If (IsStartPressed = False) Then Exit Sub
        If SolenoidValveY1 = "1" Then
            Switch_SolenoidValve(False)
        Else
            Switch_SolenoidValve(True)
        End If
        PumpButton.BackgroundImage = My.Resources.Buttons_yellow_on
    End Sub
    Private Sub SolValButton_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SolValButton.MouseUp
        SolValButton.BackgroundImage = My.Resources.Buttons_yellow_off
    End Sub

    Private Sub AllOFF()
        Switch_Compressor(False)
        PumpTimer.Enabled = False
        Switch_Pump(False)
        Open_ControlValve(0)
        Switch_VisualIndicator(False)
        IsStartPressed = False
        DataScanTimer.Enabled = False
        SetAlarmToolStripMenuItem.Enabled = True
        SettingsToolStripMenuItem.Enabled = True
        SelectorPanel.Enabled = True
        FlowPanel.BackColor = Color.Transparent
        LevelPanel.BackColor = Color.Transparent
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
            MessageBox.Show(Me, "Hardware found", "Nvis 3002C", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf StringCollector.StartsWith("A") And StringCollector.Length >= 29 Then
            DigitalInput(StringCollector.Substring(17, 8))
            DAQTemperatureLabel.Text = "DAQ Temperature: " + ((CDbl(StringCollector.Substring(26, 4)) * 3.3 / 1023) * 100).ToString("00") + "°C"

            '------------------------ Display Readings -----------------------------------------'
            If StringCollector.Substring(25, 1) = "0" Then
                'PressureCurrentLabel.Text = ((CDbl(StringCollector.Substring(1, 8)) * 5) / 16777215).ToString("00.0000")
                'CurrentPressureValue = CDbl(PressureCurrentLabel.Text)
                Dim FlowCurrent As Double
                FlowCurrent = (CDbl(StringCollector.Substring(1, 8)) * 5) / 16777215
                FlowCurrent = FormatNumber(FlowCurrent * 1000 / 120, 1) ' Covert ADC voltage to current (mA) having 120E resistance
                WaterFlowSystem1.FlowCurrentValue = FlowCurrent
                FlowCurrentLabel.Text = FlowCurrent.ToString("00.0")
                FlowValue = CInt((FlowCurrent - 4) * 1000 / 16) ' Scaling of 4mA to 20mA with 0 (Ltr/Hr) to 1000 (Ltr/Min)
                'WaterFlowSystem1.FlowValuevalue = FlowValue
                FlowDigi.DigitText = FlowValue
            ElseIf StringCollector.Substring(25, 1) = "1" Then
                Dim LevelCurrent As Double
                LevelCurrent = (CDbl(StringCollector.Substring(1, 8)) * 5) / 16777215
                LevelCurrent = FormatNumber(LevelCurrent * 1000 / 120, 1) ' Covert ADC voltage to current (mA) having 120E resistance
                LevelValue = (LevelCurrent - 4) * 100 / 16 ' Scaling 4ma to 20mA to 0% to 100% water level
                If WaterFlowSystem1.WaterLevel <> LevelValue Then
                    WaterFlowSystem1.WaterLevel = LevelValue
                End If
                'LevelDigi.DigitText = CInt(CurrentLevel)
            End If

            StringCollector = ""
            If IsStartPressed = False Then Exit Sub

            '------------------------ Check if process is open loop or close loop (auto/manual) -----------------------------------------'
            If IsAutoSelected = True Then
                If CurrentProcess = PIDProcesses.FlowProcess Then
                    Flow_P_PI_PID_Operation()
                ElseIf CurrentProcess = PIDProcesses.LevelProcess Then
                    'Level_P_PI_PID_Operation()
                    Open_ControlValve(0)
                End If
            End If

            ElseIf StringCollector.Length > 30 Then
                StringCollector = ""
            End If
    End Sub


    Dim PTerm, ITerm, DTerm, PreviousError As Double
    Private Sub Flow_P_PI_PID_Operation()
        Dim ProcessError As Integer = FlowSPUpDown.Value - FlowValue

        '------------------ Check for P PI PID Process -----------------------------------------'
        If ControlSettingsForm.pradio.Checked Then
            '------------------ P Process -----------------------------------------'
            PTerm = FlowProportionalConstant * ProcessError
            ITerm = 0
            DTerm = 0
        ElseIf ControlSettingsForm.piradio.Checked Then
            '------------------ PI Process -----------------------------------------'
            PTerm = FlowProportionalConstant * ProcessError
            ITerm += FlowIntegralConstant * ProcessError * 1
            DTerm = 0
        ElseIf ControlSettingsForm.pidradio.Checked Then
            '------------------ PID Process -----------------------------------------'
            PTerm = FlowProportionalConstant * ProcessError
            ITerm += FlowIntegralConstant * ProcessError * 1
            DTerm = FlowDerivativeConstant * (ProcessError - PreviousError)  '0
        End If
        '---------------- Check for overflow of integral due to summing --------------------'
        If ITerm < -5 Then ITerm = -5
        If ITerm > 5 Then ITerm = 5

        Dim CalculatedValveOpening As Integer = (PTerm + ITerm + DTerm)

        ' Mean point of opening of control valve is 50%
        ' So CalculatedValveOpening is subtracted (or added) to remove error
        ' Its like distracting opening negative to error to achieve zero error.
        ' Subtracting CalculatedValveOpening from 50% because with increase in valve opening will decrease in flow value
        ' If valve opening will increase flow then CalculatedValveOpening will be added to 50%.
        CalculatedValveOpening = 50 - CalculatedValveOpening
        If CalculatedValveOpening < 0 Then CalculatedValveOpening = 0
        If CalculatedValveOpening > 100 Then CalculatedValveOpening = 100
        PreviousError = ProcessError

        Open_ControlValve(CalculatedValveOpening)
    End Sub

    Private Sub Level_P_PI_PID_Operation()
        Dim ProcessError As Integer = LevelSPUpDown.Value - LevelValue

        '------------------ P Process -----------------------------------------'
        If ControlSettingsForm.pradio.Checked = True Then
            PTerm = LevelProportionalConstant * ProcessError * 1000
            ITerm = 0
            DTerm = 0

            '------------------ PI Process -----------------------------------------'
        ElseIf ControlSettingsForm.piradio.Checked = True Then
            PTerm = LevelProportionalConstant * ProcessError * 1000
            ITerm += LevelIntegralConstant * ProcessError * 10
            DTerm = 0

            '------------------ PID Process -----------------------------------------'
        ElseIf ControlSettingsForm.pidradio.Checked = True Then
            PTerm = LevelProportionalConstant * ProcessError * 1000
            ITerm += LevelIntegralConstant * ProcessError * 10
            DTerm = LevelDerivativeConstant * (ProcessError - PreviousError) / 10
            PreviousError = ProcessError
        End If
        LevelONTime = PTerm + ITerm + DTerm

        If ProcessError < -2 Then
            Switch_Pump(False)
            Switch_SolenoidValve(True)
            If ProcessError < -20 Then
                LevelONTime = 4999
                LevelOFFTime = 1
            Else
                LevelONTime = 2500
                LevelOFFTime = 2500
            End If
        ElseIf ProcessError > 2 Then
            If LevelONTime > 4000 Then
                LevelONTime = 4999
            ElseIf LevelONTime < 1000 Then
                LevelONTime = 1
            End If
            LevelOFFTime = 5000 - LevelONTime
            Switch_Pump(True)
            Switch_SolenoidValve(False)
        End If
        LevelPIDTimer.Interval = LevelONTime
        LevelStates = 1
    End Sub
    Dim LevelONTime, LevelOFFTime As Integer
    Dim LevelStates As Integer = 0
    Private Sub LevelPIDTimer_Tick(sender As Object, e As EventArgs) Handles LevelPIDTimer.Tick
        LevelPIDTimer.Enabled = False
        If LevelStates = 0 Then
            Level_P_PI_PID_Operation()
            LevelPIDTimer.Enabled = True
        ElseIf LevelStates = 1 Then
            If LevelOFFTime > 500 Then
                Switch_Pump(False)
                Switch_SolenoidValve(False)
                LevelPIDTimer.Interval = LevelOFFTime
            End If
            LevelStates = 2
            LevelPIDTimer.Enabled = True
        ElseIf LevelStates = 2 Then
            LevelStates = 0
            LevelPIDTimer.Interval = 1
            LevelPIDTimer.Enabled = True
        End If
    End Sub

    Enum PIDProcesses As Integer
        FlowProcess
        LevelProcess
    End Enum
    Public Shared CurrentProcess As PIDProcesses = PIDProcesses.FlowProcess
    Private Sub SelectorPanel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SelectorPanel.Click, LevelSelectionImage.Click, FlowSelectionImage.Click
        If CurrentProcess = PIDProcesses.FlowProcess Then
            LevelSelectionImage.Visible = True
            FlowSelectionImage.Visible = False
            LevelContainerPanel.Visible = True
            FlowContainerPanel.Visible = False
            CurrentProcess = PIDProcesses.LevelProcess
        ElseIf CurrentProcess = PIDProcesses.LevelProcess Then
            LevelSelectionImage.Visible = False
            FlowSelectionImage.Visible = True
            LevelContainerPanel.Visible = False
            FlowContainerPanel.Visible = True
            CurrentProcess = PIDProcesses.FlowProcess
        End If
    End Sub

    Private Sub DataScanTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataScanTimer.Tick
        If IsStartPressed = False Then Exit Sub
        AlarmCheck()
        Dim CurrentDateTime As DateTime = DateTime.Now
        FlowGraph.RestoreScale(FlowGraph.GraphPane)
        With FlowGraph.GraphPane.XAxis
            .Type = AxisType.Date
            .Scale.Format = "HH:mm:ss"
            .Scale.MajorUnit = DateUnit.Hour
            .Scale.MinorUnit = DateUnit.Second
            .Scale.MinorStep = 1
        End With
        FlowSetPointLineItem.AddPoint(CurrentDateTime.ToOADate(), FlowSPUpDown.Value)
        FlowLineItem.AddPoint(CurrentDateTime.ToOADate(), FlowValue)
        FlowGraph.AxisChange()
        FlowGraph.Refresh()

        LevelGraph.RestoreScale(LevelGraph.GraphPane)
        With LevelGraph.GraphPane.XAxis
            .Type = AxisType.Date
            .Scale.Format = "HH:mm:ss"
            .Scale.MajorUnit = DateUnit.Hour
            .Scale.MinorUnit = DateUnit.Second
            .Scale.MinorStep = 1
        End With
        LevelSetPointLineItem.AddPoint(CurrentDateTime.ToOADate(), LevelSPUpDown.Value)
        LevelLineItem.AddPoint(CurrentDateTime.ToOADate(), LevelValue)
        LevelGraph.AxisChange()
        LevelGraph.Refresh()

        If Logging = False Then Exit Sub
        Dim dt As String = ""
        dt = DateTime.Now().ToString("yyyy-MM-dd HH:mm:ss")
        SQLConnection.ConnectionString = SQLConnectionString
        Try
            SQLConnection.Open()
            SQLCommand = New MySqlCommand("insert into " + FlowTableName + "(datetime,SetPoint,FlowValue) values('" + dt + "'," + FlowSPUpDown.Value.ToString + "," + FlowValue.ToString + ");", SQLConnection)
            SQLCommand.ExecuteReader()
            SQLConnection.Close()
        Catch ex As Exception
            LoggingToolStripMenuItem.Text = "Stop &Logging"
            LoggingToolStripMenuItem_Click(Nothing, Nothing)
            MessageBox.Show(Me, "Can't insert data to database, check if you have entered correct database password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            SQLConnection.Close()
        End Try

        Try
            SQLConnection.Open()
            SQLCommand = New MySqlCommand("insert into " + LevelTableName + "(datetime,SetPoint,LevelValue) values('" + dt + "'," + LevelSPUpDown.Value.ToString + "," + LevelValue.ToString + ");", SQLConnection)
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
            Switch_Start()
        End If

        If DI.Substring(1, 1) = "0" Then
            Switch_Stop()
        End If

        If IsStartPressed = False Then Exit Sub

        If DI.Substring(2, 1) = "1" And IsHardPumpX2Pressed = False Then
            IsHardPumpX2Pressed = True
            If PumpY0 = "1" Then
                Switch_Pump(False)
            Else
                Switch_Pump(True)
            End If
        ElseIf DI.Substring(2, 1) = "0" Then
            IsHardPumpX2Pressed = False
        End If

        If DI.Substring(3, 1) = "1" And IsHardSolValX3Pressed = False Then
            IsHardSolValX3Pressed = True
            If SolenoidValveY1 = "1" Then
                Switch_SolenoidValve(False)
            Else
                Switch_SolenoidValve(True)
            End If
        ElseIf DI.Substring(3, 1) = "0" Then
            IsHardSolValX3Pressed = False
        End If

        If DI.Substring(4, 1) = "1" And IsHardCompressorX4Pressed = False Then
            IsHardCompressorX4Pressed = True
            If CompressorY2 = "1" Then
                Switch_Compressor(False)
            Else
                Switch_Compressor(True)
            End If
        ElseIf DI.Substring(4, 1) = "0" Then
            IsHardCompressorX4Pressed = False
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
        Open_ControlValve(0)
        LoadIPFile()

        Dim FlowGraphPane As GraphPane = FlowGraph.GraphPane

        FlowSetPointLineItem = FlowGraphPane.AddCurve("Set Point", FlowSetPointPointPair, Color.Blue, SymbolType.None)
        GraphSettings(FlowGraph, FlowGraphPane, FlowSetPointLineItem, "Set Point (Ltr/min)", 500)

        FlowLineItem = FlowGraphPane.AddCurve("Flow", FlowPointPair, Color.Red, SymbolType.None)
        GraphSettings(FlowGraph, FlowGraphPane, FlowLineItem, "Flow (Ltr/min)", 500)

        Dim LevelGraphPane As GraphPane = LevelGraph.GraphPane

        LevelSetPointLineItem = LevelGraphPane.AddCurve("Set Point", LevelSetPointPointPair, Color.Blue, SymbolType.None)
        GraphSettings(LevelGraph, LevelGraphPane, LevelSetPointLineItem, "Set Point (%)", 100)

        LevelLineItem = LevelGraphPane.AddCurve("Level", LevelPointPair, Color.Red, SymbolType.None)
        GraphSettings(LevelGraph, LevelGraphPane, LevelLineItem, "Level (%)", 100)

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
        LevelSPUpDown.Value = 200
        WaterFlowSystem1.WaterLevel = 50
        PumpTimer.Interval = 60000

        SelectorPanel_Click(Nothing, Nothing)
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
            SQLCommand = New MySqlCommand("Create table " + DatabaseName + "." + FlowTableName + "(datetime datetime,SetPoint integer,FlowValue integer);", SQLConnection)
            SQLCommand.ExecuteReader()
            SQLConnection.Close()
        Catch
        Finally
            SQLConnection.Close()
        End Try
        Try
            SQLConnection.Open()
            SQLCommand = New MySqlCommand("Create table " + DatabaseName + "." + LevelTableName + "(datetime datetime,SetPoint integer,LevelValue integer);", SQLConnection)
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
                Ethernet.Send("A" + ChannelNumber.ToString("0") + PumpY0 + SolenoidValveY1 + CompressorY2 + VisualIndicatorY3 + BuzzerY4 + "000" + ControlValveDAC0.ToString("0000") + "0000")
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
        mypane.Title.Text = yTitle + " vs Time"
        mypane.XAxis.Title.Text = "Time"
        mypane.YAxis.Title.Text = yTitle
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

    Private Sub GraphClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowGraphClearButton.Click
        FlowSetPointLineItem.Clear()
        FlowLineItem.Clear()
        FlowGraph.Refresh()
    End Sub

    Private Sub LevelGraphClearButton_Click(sender As Object, e As EventArgs) Handles LevelGraphClearButton.Click
        LevelSetPointLineItem.Clear()
        LevelLineItem.Clear()
        LevelGraph.Refresh()
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


    Private Sub AlarmCheck()
        Dim IsFlowAlarmValueAchieved As Boolean = False
        If SetAlarm.FlowAlarmTable.Rows.Count <= 0 Then Exit Sub
        Dim i As Integer
        For i = 0 To SetAlarm.FlowAlarmTable.Rows.Count - 1
            If (FlowValue = CInt(SetAlarm.FlowAlarmTable.Item(0, i).Value)) Then
                IsFlowAlarmValueAchieved = True
            End If
        Next
        If IsFlowAlarmValueAchieved = True Then
            FlowPanel.BackColor = Color.CornflowerBlue
        Else
            FlowPanel.BackColor = Color.Transparent
        End If

        Dim IsLevelAlarmValueAchieved As Boolean = False
        If SetAlarm.LevelAlarmTable.Rows.Count <= 0 Then Exit Sub
        For i = 0 To SetAlarm.LevelAlarmTable.Rows.Count - 1
            If (LevelValue = CInt(SetAlarm.LevelAlarmTable.Item(0, i).Value)) Then
                IsLevelAlarmValueAchieved = True
            End If
        Next
        If IsLevelAlarmValueAchieved = True Then
            LevelPanel.BackColor = Color.CornflowerBlue
        Else
            LevelPanel.BackColor = Color.Transparent
        End If

        If IsLevelAlarmValueAchieved = True Or IsFlowAlarmValueAchieved = True Then
            Switch_Buzzer(True)
        Else
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

    Private Sub LevelSPUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LevelSPUpDown.ValueChanged
        LevelSPDigi.DigitText = LevelSPUpDown.Value.ToString("00")
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
        Switch_Stop()
    End Sub

    Private Sub PumpTimeIntervalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PumpTimeIntervalToolStripMenuItem.Click
        PumpTimeForm.ShowDialog()
    End Sub

    Private Sub SensorInputSettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SensorInputSettingsToolStripMenuItem.Click
        SettingsForm.ShowDialog()
    End Sub

End Class