Imports System
Imports ZedGraph
Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports Nvis3002APanel
Imports System.Threading
Imports System.Threading.Thread

Public Class MainForm

    'Dim SoftStartX0 As String = "0"
    'Dim SoftStopX1 As String = "0"
    'Dim SoftPumpX2 As String = "0"
    'Dim SoftHeaterX3 As String = "0"
    'Dim SoftStirrerX4 As String = "0"
    'Dim SoftSolValveX5 As String = "0"
    'Dim SoftEmergencyX6 As String = "0"

    'Dim HardStartX0 As String = "0"
    'Dim HardStopX1 As String = "0"
    'Dim HardPumpX2 As String = "0"
    'Dim HardHeaterX3 As String = "0"
    'Dim HardStirrerX4 As String = "0"
    'Dim HardSolValveX5 As String = "0"
    'Dim HardEmergencyX6 As String = "0"
    Public Shared TemperatureProcess As String
    Public Shared LevelProcess As String

    Dim IsHardPumpX2Pressed As Boolean = False
    Dim IsHardHeaterX3Pressed As Boolean = False
    Dim IsHardStirrerX4Pressed As Boolean = False
    Dim IsHardSolValveX5Pressed As Boolean = False

    Dim PumpY0 As String = "0"
    Dim HeaterY1 As String = "0"
    Dim StirrerY2 As String = "0"
    Dim SolValvY3 As String = "0"
    Dim VisualIndicatorY4 As String = "0"
    Dim BuzzerY5 As String = "0"

    Dim IsStartPressed = False
    Dim IsEmergency = False
    Dim IsSoftEmergency = False
    'Dim IsHardEmergency = False

    Dim TemperatureLineItem, LevelLineItem As LineItem
    Dim TemperatureSPLineItem, LevelSPLineItem As LineItem

    Dim TemperaturePointPair, LevelPointPair As New PointPairList
    Dim TemperatureSPPointPair, LevelSPPointPair As New PointPairList

    Dim PressurePointPair, FlowMeterPointPair As New PointPairList
    Dim PressureLineItem, FlowMeterLineItem As LineItem

    Public SQLConnection As MySqlConnection
    Public SQLReader As MySqlDataReader
    Dim SQLCommand As MySqlCommand
    Public Shared SQLConnectionString, SQLInitConnectionString, DatabaseName As String

    Public TTHysterisis As Integer
    Public TTProportionalConstant, TTDerivativeConstant, TTIntegralConstant As Double

    Public LTHysterisis As Integer
    Public LTProportionalConstant, LTDerivativeConstant, LTIntegralConstant As Double

    Public CurrentTemperature, CurrentLevel, CurrentPressure, CurrentFlow As Double

    Dim Logging As Boolean = False

    Dim HeaterONTime, HeaterOFFTime As Integer
    Dim LevelONTime, LevelOFFTime As Integer

    Dim LevelThresholdForHeater As Integer = 35

    Dim LinkCheckThread As Thread

    Private Sub Switch_Pump(ByVal State As Boolean)
        If State = True Then
            PumpY0 = "1"
            PumpLed.BackgroundImage = My.Resources.blue_led_on1
            Nvis3002APanel1.Fill = True
        Else
            PumpY0 = "0"
            PumpLed.BackgroundImage = My.Resources.blue_led_off
            Nvis3002APanel1.Fill = False
        End If
    End Sub

    Private Sub Switch_SolVal(ByVal State As Boolean)
        If State = True Then
            SolValvY3 = "1"
            SolValvLed.BackgroundImage = My.Resources.yellow_led_on
            Nvis3002APanel1.Drain = True
        Else
            SolValvY3 = "0"
            SolValvLed.BackgroundImage = My.Resources.yellow_led_off
            Nvis3002APanel1.Drain = False
        End If
    End Sub

    Private Sub Switch_VisualIndicator(ByVal State As Boolean)
        If State = True Then
            VisualIndicatorY4 = "1"
            VisualIndicatorLed.BackgroundImage = My.Resources.blue_led_on1
        Else
            VisualIndicatorY4 = "0"
            VisualIndicatorLed.BackgroundImage = My.Resources.blue_led_off
        End If
    End Sub

    Private Sub Switch_Buzzer(ByVal State As Boolean)
        If State = True Then
            BuzzerY5 = "1"
            BuzzerArc.Animate = True
            BuzzerTimer.Enabled = True
        Else
            BuzzerY5 = "0"
            BuzzerArc.Animate = False
            BuzzerArc.Progress = 0
            BuzzerTimer.Enabled = False
        End If
    End Sub

    Private Sub Switch_Emergency(ByVal State As Boolean)
        If State = True Then
            EmergencyLabel.ForeColor = Color.Red
            EmergencyButton.BackgroundImage = My.Resources.Emergency_Button_on
        Else
            EmergencyLabel.ForeColor = Color.Black
            EmergencyButton.BackgroundImage = My.Resources.Emergency_Button_off
        End If
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
        SettingsToolStripMenuItem1.Enabled = False
        SetAlarmToolStripMenuItem.Enabled = False
        DataScanTimer.Enabled = True
        'PIDTimer.Enabled = True
        HeaterTimer.Enabled = True
        LevelTimer.Enabled = True
    End Sub
    Private Sub StartButton_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles StartButton.MouseUp
        StartButton.BackgroundImage = My.Resources.Buttons_green_off
    End Sub

    Private Sub StopButton_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles StopButton.MouseDown
        StopButton.BackgroundImage = My.Resources.Buttons_red_on
        IsStartPressed = False
        IsEmergency = False
        IsSoftEmergency = False
        Switch_Buzzer(False)
        Switch_Emergency(False)
        AllOFF()
    End Sub
    Private Sub StopButton_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles StopButton.MouseUp
        StopButton.BackgroundImage = My.Resources.Buttons_red_off
    End Sub

    Private Sub PumpButton_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PumpButton.MouseDown
        If (IsEmergency = True Or IsStartPressed = False) Then Exit Sub
        If PumpY0 = "1" Then
            Switch_Pump(False)
        Else
            Switch_Pump(True)
        End If
        PumpButton.BackgroundImage = My.Resources.Buttons_yellow_on
    End Sub
    Private Sub PumpButton_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PumpButton.MouseUp
        PumpButton.BackgroundImage = My.Resources.Buttons_yellow_off
        'SoftPumpX2 = "0"
        'LedStatus()
    End Sub

    Private Sub HeaterButton_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles HeaterButton.MouseUp
        HeaterButton.BackgroundImage = My.Resources.Buttons_yellow_off
        'SoftHeaterX3 = "0"
        'LedStatus()
    End Sub

    Private Sub StirrerButton_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles StirrerButton.MouseDown
        If (IsEmergency = True Or IsStartPressed = False) Then Exit Sub
        If StirrerY2 = "1" Then
            Switch_Stirrer(False)
        Else
            Switch_Stirrer(True)
        End If
        StirrerButton.BackgroundImage = My.Resources.Buttons_yellow_on
    End Sub
    Private Sub StirrerButton_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles StirrerButton.MouseUp
        StirrerButton.BackgroundImage = My.Resources.Buttons_yellow_off
        'SoftStirrerX4 = "0"
        'LedStatus()
    End Sub

    Private Sub SolvalvButton_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SolValvButton.MouseDown
        If (IsEmergency = True Or IsStartPressed = False) Then Exit Sub
        If SolValvY3 = "1" Then
            Switch_SolVal(False)
        Else
            Switch_SolVal(True)
        End If
        SolValvButton.BackgroundImage = My.Resources.Buttons_yellow_on
    End Sub
    Private Sub SolvalvButton_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles SolValvButton.MouseUp
        SolValvButton.BackgroundImage = My.Resources.Buttons_yellow_off
        'SoftSolValveX5 = "0"
        'LedStatus()
    End Sub


    Private Sub AllOFF()
        Switch_Pump(False)
        Switch_SolVal(False)
        Switch_VisualIndicator(False)
        'Switch_Buzzer(False)
        IsStartPressed = False
        
        DataScanTimer.Enabled = False
        HeaterTimer.Enabled = False
        LevelTimer.Enabled = False
        'LevelSPUpDown.Enabled = True
        'TemperatureSPUpDown.Enabled = True
        SettingsToolStripMenuItem1.Enabled = True
        SetAlarmToolStripMenuItem.Enabled = True
        'PIDTimer.Enabled = False
        LevelPanel.BackColor = Color.Transparent
        TemperaturePanel.BackColor = Color.Transparent
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
        If StringCollector.Contains("NV632C8") And IsHardwareFound = False Then
            StringCollector = ""
            IsHardwareFound = True
            MessageBox.Show(Me, "Hardware found", "Nvis 3002B", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf StringCollector.StartsWith("A") And StringCollector.Length >= 29 Then
            DigitalInput(StringCollector.Substring(17, 8))
            DAQTemperatureLabel.Text = "DAQ Temperature : " + ((CDbl(StringCollector.Substring(26, 4)) * 3.3 / 1023) * 100).ToString("000") + "°C"
            'Dim abc As String = StringCollector.Substring(25, 1)
            If StringCollector.Substring(25, 1) = "0" Then
                'templbl.Text = ((CDbl(StringCollector.Substring(1, 8)) * 5) / 16777215).ToString("00.0000")
                CurrentTemperature = (CDbl(StringCollector.Substring(1, 8)) * 5) / 16777215
                'CurrentTemperature = CDbl(templbl.Text)
                CurrentTemperature = CurrentTemperature * 1000 / 120 ' Covert ADC voltage to current (mA) having 120E resistance
                templbl.Text = CurrentTemperature.ToString("00.00")
                If Nvis3002APanel1.TemperatureCurrent <> templbl.Text Then Nvis3002APanel1.TemperatureCurrent = templbl.Text
                CurrentTemperature = (CurrentTemperature - 4) * 100 / 16 ' Scaling of 4mA to 20mA with 0 (C) to 100 (C)
                TemperatureDigi.DigitText = CInt(CurrentTemperature)
                'TemperaturePIDOperation()
                ' TemperatureAlarmCheck()
            ElseIf StringCollector.Substring(25, 1) = "1" Then
                'lvllbl.Text = ((CDbl(StringCollector.Substring(1, 8)) * 5) / 16777215).ToString("00.0000") ' Get the voltage (V) at ADC
                CurrentLevel = (CDbl(StringCollector.Substring(1, 8)) * 5) / 16777215 ' Get the voltage (V) at ADC
                'CurrentLevel = CDbl(lvllbl.Text)
                CurrentLevel = CurrentLevel * 1000 / 120 ' Covert ADC voltage to current (mA) having 120E resistance
                lvllbl.Text = CurrentLevel.ToString("00.00")
                CurrentLevel = (CurrentLevel - 4) * 100 / 16 ' Scaling of 4mA to 20mA with 0% to 100 %
                If Nvis3002APanel1.TankLevel <> CInt(CurrentLevel) Then
                    Nvis3002APanel1.TankLevel = CurrentLevel
                    Nvis3002APanel1.LevelCurrent = lvllbl.Text
                End If
                LevelDigi.DigitText = CInt(CurrentLevel)
                If CurrentLevel < LevelThresholdForHeater Then
                    WarningLabel.Visible = True
                    HeaterY1 = "0"
                    HeaterLed.BackgroundImage = My.Resources.yellow_led_off
                    Nvis3002APanel1.Heater = False
                Else
                    WarningLabel.Visible = False
                End If
                'LevelPIDOperation()
                'LevelAlarmCheck()
            ElseIf StringCollector.Substring(25, 1) = "2" Then
                CurrentPressure = (CDbl(StringCollector.Substring(1, 8)) * 5) / 16777215 ' Get the voltage (V) at ADC
                CurrentPressure = CurrentPressure * 1000 / 120
                PressureCurrentLabel.Text = CurrentPressure.ToString("0.00")
                CurrentPressure = (CurrentPressure - 4) * 15 / 16
                PressureDigi.DigitText = CInt(CurrentPressure).ToString
            ElseIf StringCollector.Substring(25, 1) = "3" Then
                CurrentFlow = (CDbl(StringCollector.Substring(1, 8)) * 5) / 16777215 ' Get the voltage (V) at ADC
                CurrentFlow = CurrentFlow * 1000 / 120
                FlowMeterCurrentLabel.Text = CurrentFlow.ToString("0.00")
                FlowMeterDigi.DigitText = CInt(CurrentFlow)
            End If
            StringCollector = ""
        ElseIf StringCollector.Length > 30 Then
            StringCollector = ""
        End If
    End Sub

    'Private Sub PIDTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PIDTimer.Tick
    '    If IsStartPressed = False Then Exit Sub
    '    TemperaturePIDOperation()
    '    LevelPIDOperation()
    'End Sub

    Dim TemperatureIntegralTerm, TemperaturePreviousError As Double
    Private Sub TemperaturePIDOperation()
        '------------------ Close Loop -----------------------------------------'
        If TTSettings.CloseLoopRadio.Checked = True Then
            '------------------ ON OFF Process -----------------------------------------'
            If TTSettings.OnOffRadio.Checked = True Then
                If TemperatureSPUpDown.Value - CurrentTemperature > TTHysterisis Then
                    If CurrentLevel < LevelThresholdForHeater Then Exit Sub
                    Switch_Heater(True)
                Else
                    Switch_Heater(False)
                End If
            ElseIf TTSettings.PIDRadio.Checked = True Then
                Dim ProcessError As Integer = TemperatureSPUpDown.Value - CurrentTemperature
                '------------------ P Process -----------------------------------------'
                If TTSettings.PRadio.Checked = True Then
                    HeaterONTime = TTProportionalConstant * ProcessError * 1000

                    '------------------ PI Process -----------------------------------------'
                ElseIf TTSettings.PIRadio.Checked = True Then
                    TemperatureIntegralTerm += (ProcessError - TemperaturePreviousError) * 200
                    HeaterONTime = TTProportionalConstant * ProcessError * 1000 + TTIntegralConstant * TemperatureIntegralTerm
                    TemperaturePreviousError = ProcessError

                    '------------------ PID Process -----------------------------------------'
                ElseIf TTSettings.PIDRadio1.Checked = True Then
                    TemperatureIntegralTerm += (ProcessError - TemperaturePreviousError) * 200
                    HeaterONTime = TTProportionalConstant * ProcessError * 1000 + TTIntegralConstant * TemperatureIntegralTerm + TTDerivativeConstant * (ProcessError - TemperaturePreviousError) / 200
                    TemperaturePreviousError = ProcessError
                End If

                'TextBox1.Text = "[" + HeaterONTime.ToString + " , " + HeaterOFFTime.ToString + "]   " + TemperatureIntegralTerm.ToString
                'If HeaterONTime > 20000 Then
                '    TemperatureIntegralTerm = 0
                'ElseIf HeaterONTime < -20000 Then
                '    TemperatureIntegralTerm = 0
                'End If

                '--------------------- Timing adjustments to remove exceptions and heater ON/OFF flickering ----------------------------'
                If HeaterONTime > 4000 Then
                    HeaterONTime = 4999
                ElseIf HeaterONTime < 1000 Then
                    HeaterONTime = 1000
                    If ProcessError < -2 Then HeaterONTime = 1
                End If
                HeaterOFFTime = 5000 - HeaterONTime
                HeaterTimer.Interval = HeaterONTime
                'EthernetSendTimer.Enabled = False
                'EthernetRecTimer.Enabled = False
                If HeaterONTime > 500 And CurrentLevel >= LevelThresholdForHeater Then
                    Switch_Heater(True)
                End If
                HeaterStates = 1
            End If
        End If
    End Sub
    Dim HeaterStates As Integer = 0
    Private Sub HeaterTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HeaterTimer.Tick
        If IsStartPressed = False Then Exit Sub
        HeaterTimer.Enabled = False
        If HeaterStates = 0 Then
            TemperaturePIDOperation()
            HeaterTimer.Enabled = True
        ElseIf HeaterStates = 1 Then
            If HeaterOFFTime > 500 Then
                Switch_Heater(False)
            End If
            HeaterTimer.Interval = HeaterOFFTime
            HeaterTimer.Enabled = True
            HeaterStates = 2
        ElseIf HeaterStates = 2 Then
            HeaterStates = 0
            HeaterTimer.Interval = 1
            HeaterTimer.Enabled = True
        End If
    End Sub

    Dim LevelIntegralTerm, LevelPreviousError As Double
    Private Sub LevelPIDOperation()
        '------------------ Close Loop -----------------------------------------'
        If LTSettings.CloseLoopRadio.Checked = True Then
            '------------------ ON OFF Process -----------------------------------------'
            If LTSettings.OnOffRadio.Checked = True Then
                If CurrentLevel - LevelSPUpDown.Value > 2 Then
                    Switch_Pump(False)
                    Switch_SolVal(True)
                ElseIf LevelSPUpDown.Value - CurrentLevel > 2 Then
                    Switch_Pump(True)
                    Switch_SolVal(False)
                Else
                    Switch_Pump(False)
                    Switch_SolVal(False)
                End If
            ElseIf LTSettings.PIDRadio.Checked = True Then
                Dim ProcessError As Integer = LevelSPUpDown.Value - CurrentLevel
                '------------------ P Process -----------------------------------------'
                If LTSettings.PRadio.Checked = True Then
                    LevelONTime = LTProportionalConstant * ProcessError * 1000

                    '------------------ PI Process -----------------------------------------'
                ElseIf LTSettings.PIRadio.Checked = True Then
                    LevelIntegralTerm += ProcessError * 10
                    LevelONTime = LTProportionalConstant * ProcessError * 1000 + LTIntegralConstant * LevelIntegralTerm

                    '------------------ PID Process -----------------------------------------'
                ElseIf LTSettings.PIDRadio1.Checked = True Then
                    LevelIntegralTerm += ProcessError * 10
                    LevelONTime = LTProportionalConstant * ProcessError * 1000 + LTIntegralConstant * LevelIntegralTerm + LTDerivativeConstant * (ProcessError - LevelPreviousError) / 10
                    LevelPreviousError = ProcessError
                End If

                '--------------------- Timing adjustments to remove exceptions and heater ON/OFF flickering ----------------------------'
                If LevelONTime > 4000 Then
                    LevelONTime = 4000
                ElseIf LevelONTime < 1000 Then
                    LevelONTime = 1000
                End If
                If ProcessError > 20 Then
                    LevelONTime = 4999
                End If
                LevelOFFTime = 5000 - LevelONTime

                If CurrentLevel - LevelSPUpDown.Value > LTHysterisis Then
                    Switch_Pump(False)
                    Switch_SolVal(True)
                    If ProcessError < -20 Then
                        LevelONTime = 4999
                        LevelOFFTime = 1
                    Else
                        LevelONTime = 2500
                        LevelOFFTime = 2500
                    End If
                ElseIf LevelSPUpDown.Value - CurrentLevel > LTHysterisis Then
                    Switch_Pump(True)
                    Switch_SolVal(False)
                End If
                LevelTimer.Interval = LevelONTime
                LevelStates = 1
            End If
        End If
    End Sub
    Dim LevelStates As Integer = 0
    Private Sub LevelTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LevelTimer.Tick
        LevelTimer.Enabled = False
        If LevelStates = 0 Then
            LevelPIDOperation()
            LevelTimer.Enabled = True
        ElseIf LevelStates = 1 Then
            If LevelOFFTime > 500 Then
                Switch_Pump(False)
                Switch_SolVal(False)
                LevelTimer.Interval = LevelOFFTime
            End If
            LevelStates = 2
            LevelTimer.Enabled = True
        ElseIf LevelStates = 2 Then
            LevelStates = 0
            LevelTimer.Interval = 1
            LevelTimer.Enabled = True
        End If
    End Sub

    Private Sub DataScanTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataScanTimer.Tick
        If IsStartPressed = False Then Exit Sub

        If TemperatureAlarmCheck() = True Or LevelAlarmCheck() = True Or PressureAlarmCheck() = True Or FlowAlarmCheck() = True Then
            Switch_Buzzer(True)
        Else
            Switch_Buzzer(False)
        End If

        Dim CurrentDateTime As DateTime = DateTime.Now
        TemperatureGraph.RestoreScale(TemperatureGraph.GraphPane)
        With TemperatureGraph.GraphPane.XAxis
            .Type = AxisType.Date
            .Scale.Format = "HH:mm:ss"
            .Scale.MajorUnit = DateUnit.Hour
            .Scale.MinorUnit = DateUnit.Second
            .Scale.MinorStep = 1
        End With
        LevelGraph.RestoreScale(LevelGraph.GraphPane)
        With LevelGraph.GraphPane.XAxis
            .Type = AxisType.Date
            .Scale.Format = "HH:mm:ss"
            .Scale.MajorUnit = DateUnit.Hour
            .Scale.MinorUnit = DateUnit.Second
            .Scale.MinorStep = 1
        End With
        PressureGraph.RestoreScale(PressureGraph.GraphPane)
        With PressureGraph.GraphPane.XAxis
            .Type = AxisType.Date
            .Scale.Format = "HH:mm:ss"
            .Scale.MajorUnit = DateUnit.Hour
            .Scale.MinorUnit = DateUnit.Second
            .Scale.MinorStep = 1
        End With
        FLowMeterGraph.RestoreScale(FLowMeterGraph.GraphPane)
        With FLowMeterGraph.GraphPane.XAxis
            .Type = AxisType.Date
            .Scale.Format = "HH:mm:ss"
            .Scale.MajorUnit = DateUnit.Hour
            .Scale.MinorUnit = DateUnit.Second
            .Scale.MinorStep = 1
        End With
        TemperatureSPLineItem.AddPoint(CurrentDateTime.ToOADate(), TemperatureSPUpDown.Value)
        TemperatureLineItem.AddPoint(CurrentDateTime.ToOADate(), CurrentTemperature)
        LevelSPLineItem.AddPoint(CurrentDateTime.ToOADate, LevelSPUpDown.Value)
        LevelLineItem.AddPoint(CurrentDateTime.ToOADate, CurrentLevel)
        PressureLineItem.AddPoint(CurrentDateTime.ToOADate, CurrentPressure)
        FlowMeterLineItem.AddPoint(CurrentDateTime.ToOADate, CurrentFlow)
        PressureGraph.AxisChange()
        PressureGraph.Refresh()
        FLowMeterGraph.AxisChange()
        FLowMeterGraph.Refresh()
        TemperatureGraph.AxisChange()
        TemperatureGraph.Refresh()
        LevelGraph.AxisChange()
        LevelGraph.Refresh()

        If Logging = False Then Exit Sub
        Dim dt As String = ""
        dt = DateTime.Now().ToString("yyyy-MM-dd HH:mm:ss")
        SQLConnection.ConnectionString = SQLConnectionString
        Try
            SQLConnection.Open()
            SQLCommand = New MySqlCommand("insert into " + DatabaseName + "(datetime,TemperatureSetPoint,Temperature,LevelSetPoint,Level) values('" + dt + "'," + TemperatureSPUpDown.Value.ToString + "," + CInt(CurrentTemperature).ToString + "," + LevelSPUpDown.Value.ToString + "," + CInt(CurrentLevel).ToString + "," + CInt(CurrentPressure) + "," + CInt(CurrentFlow) + ");", SQLConnection)
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
            Switch_VisualIndicator(True)
            'LevelSPUpDown.Enabled = False
            'TemperatureSPUpDown.Enabled = False
            SettingsToolStripMenuItem1.Enabled = False
            SetAlarmToolStripMenuItem.Enabled = False
            DataScanTimer.Enabled = True
            HeaterTimer.Enabled = True
            LevelTimer.Enabled = True
            'PIDTimer.Enabled = True
        End If

        If DI.Substring(1, 1) = "0" Then
            IsEmergency = False
            IsSoftEmergency = False
            Switch_Emergency(False)
            Switch_Buzzer(False)
            AllOFF()
        End If

        If IsSoftEmergency = True Or IsStartPressed = False Then Exit Sub

        If DI.Substring(6, 1) = "1" Then
            IsEmergency = True
            Switch_Emergency(True)
            AllOFF()
            Switch_Buzzer(True)
            Exit Sub
            'Else
            'IsEmergency = False
            'EmergencyLabel.ForeColor = Color.Black
            'EmergencyButton.BackgroundImage = My.Resources.Emergency_Button_off
            'BuzzerY5 = "0"
            'BuzzerArc.Animate = False
            'BuzzerArc.Progress = 0
            'BuzzerTimer.Enabled = False
        End If

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

        If DI.Substring(3, 1) = "1" And IsHardHeaterX3Pressed = False Then
            IsHardHeaterX3Pressed = True
            If HeaterY1 = "1" Then
                Switch_Heater(False)
            Else
                If CurrentLevel < LevelThresholdForHeater Then Exit Sub
                Switch_Heater(True)
            End If
        ElseIf DI.Substring(3, 1) = "0" Then
            IsHardHeaterX3Pressed = False
        End If

        If DI.Substring(4, 1) = "1" And IsHardStirrerX4Pressed = False Then
            IsHardStirrerX4Pressed = True
            If StirrerY2 = "1" Then
                Switch_Stirrer(False)
            Else
                Switch_Stirrer(True)
            End If
        ElseIf DI.Substring(4, 1) = "0" Then
            IsHardStirrerX4Pressed = False
        End If

        If DI.Substring(5, 1) = "1" And IsHardSolValveX5Pressed = False Then
            IsHardSolValveX5Pressed = True
            If SolValvY3 = "1" Then
                Switch_SolVal(False)
            Else
                Switch_SolVal(True)
            End If
        ElseIf DI.Substring(5, 1) = "0" Then
            IsHardSolValveX5Pressed = False
        End If
    End Sub


    Private Sub EmergencyButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmergencyButton.Click
        'If IsStartPressed = False Then Exit Sub
        If IsEmergency = False Then
            IsEmergency = True
            IsSoftEmergency = True
            Switch_Emergency(True)
            AllOFF()
            Switch_Buzzer(True)
        Else
            IsEmergency = False
            IsSoftEmergency = False
            Switch_Emergency(False)
            Switch_Buzzer(False)
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
        LoadIPFile()

        Dim TemperatureGraphPane As GraphPane = TemperatureGraph.GraphPane
        TemperatureSPLineItem = TemperatureGraphPane.AddCurve("Set Point", TemperatureSPPointPair, Color.Green, SymbolType.None)
        GraphSettings(TemperatureGraph, TemperatureGraphPane, TemperatureSPLineItem, "Set Point (C)", 50)
        TemperatureLineItem = TemperatureGraphPane.AddCurve("Temperature", TemperaturePointPair, Color.Red, SymbolType.None)
        GraphSettings(TemperatureGraph, TemperatureGraphPane, TemperatureLineItem, "Temperature (C)", 50)


        Dim LevelGraphPane As GraphPane = LevelGraph.GraphPane
        LevelSPLineItem = LevelGraphPane.AddCurve("Set Point", LevelSPPointPair, Color.Green, SymbolType.None)
        GraphSettings(LevelGraph, LevelGraphPane, LevelSPLineItem, "Set Point (%)", 100)
        LevelLineItem = LevelGraphPane.AddCurve("Level", LevelPointPair, Color.Blue, SymbolType.None)
        GraphSettings(LevelGraph, LevelGraphPane, LevelLineItem, "Water Level (%)", 100)

        Dim PressureGraphPane As GraphPane = PressureGraph.GraphPane
        PressureLineItem = PressureGraphPane.AddCurve("Pressure", PressurePointPair, Color.Blue, SymbolType.None)
        GraphSettings(PressureGraph, PressureGraphPane, PressureLineItem, "Pressure (psi)", 100)

        Dim FlowMeterGraphPane As GraphPane = FLowMeterGraph.GraphPane
        FlowMeterLineItem = FlowMeterGraphPane.AddCurve("Water FLow", FlowMeterPointPair, Color.Blue, SymbolType.None)
        GraphSettings(FLowMeterGraph, FlowMeterGraphPane, FlowMeterLineItem, "Water FLow (Ltr / min)", 100)

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
        BuzzerTimer.Interval = 1000

        'LinkLedTimer.Interval = 500
        'LinkLedTimer.Enabled = True
        LinkCheckThread = New Thread(AddressOf PingIP)
        LinkCheckThread.Start()

        BuzzerArc.Animate = False
        BuzzerArc.Progress = 0
        BuzzerArc.Angle = 100
        BuzzerArc.Rotation = -50
        BuzzerArc.Distance = 12

        Nvis3002APanel1.OverFlowAt = 99

        TemperatureSPUpDown.Value = 30
        LevelSPUpDown.Value = 80

        LTSettings.PRadio.Checked = True
        LTSettings.OnOffRadio.Checked = True
        LTSettings.OpenLoopRadio.Checked = True

        TTSettings.PRadio.Checked = True
        TTSettings.OnOffRadio.Checked = True
        TTSettings.OpenLoopRadio.Checked = True

        Nvis3002APanel1.LevelUnit = "(mA)"
        Nvis3002APanel1.TemperatureUnit = "(mA)"
        Nvis3002APanel1.LevelCurrent = "00.00"
        Nvis3002APanel1.TemperatureCurrent = "00.00"

        Nvis3002APanel1.Width = 700
        Nvis3002APanel1.Height = 411
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
            SQLCommand = New MySqlCommand("Create table " + DatabaseName + "." + DatabaseName + "(datetime datetime,TemperatureSetPoint integer,Temperature integer,LevelSetPoint integer, Level integer, Pressure integer, Flow integer);", SQLConnection)
            SQLCommand.ExecuteReader()
        Catch
        End Try
        SQLConnection.Close()
    End Sub


    Dim ChannelNumber As Integer = 0
    Private Sub EthernetSendTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EthernetSendTimer.Tick
        If EthernetSendTimer.Enabled = False Then Exit Sub
        If IsLinkFound = False Then
            StartToolStripMenuItem1.Text = "S&top"
            StartToolStripMenuItem_Click(Nothing, Nothing)
            'StopButton_MouseDown(Nothing, Nothing)
            MessageBox.Show(Me, "Can't connect with hardware, check if it is connected to LAN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Try
            If (Ethernet.IsConnected()) Then
                Ethernet.Send("A" + ChannelNumber.ToString("0") + PumpY0 + HeaterY1 + StirrerY2 + SolValvY3 + VisualIndicatorY4 + BuzzerY5 + StirrerY2 + HeaterY1 + "00000000")
                ChannelNumber += 1
                If ChannelNumber > 3 Then ChannelNumber = 0
            End If
        Catch ex As Exception
            StartToolStripMenuItem1.Text = "S&top"
            StartToolStripMenuItem_Click(Nothing, Nothing)
            'StopButton_MouseDown(Nothing, Nothing)
            MessageBox.Show(Me, "Can't connect with hardware, check if it is connected to LAN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TemperatureTransmitterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TemperaturePIDToolStripMenuItem.Click
        TTSettings.ShowDialog()
    End Sub

    Private Sub LevelTransmitterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LevelPIDToolStripMenuItem.Click
        LTSettings.ShowDialog()
    End Sub

    Private Sub StopWatchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopWatchToolStripMenuItem1.Click
        StopWatch.ShowDialog()
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

    Private Sub LevelSPUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LevelSPUpDown.ValueChanged
        LevelSPDigi.DigitText = LevelSPUpDown.Value.ToString("00")
        Nvis3002APanel1.LevelSetPoint = LevelSPUpDown.Value
        LevelONTime = 0
        LevelOFFTime = 0
        LevelStates = 0
    End Sub

    Private Sub TemperatureSPUpDown_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TemperatureSPDigi.DigitText = TemperatureSPUpDown.Value.ToString("00")
        HeaterONTime = 0
        HeaterOFFTime = 0
        HeaterStates = 0
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

    Private Sub TemperatureClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TemperatureClearButton.Click
        TemperatureLineItem.Clear()
        TemperatureSPLineItem.Clear()
        TemperatureGraph.Refresh()
    End Sub

    Private Sub LevelClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LevelClearButton.Click
        LevelLineItem.Clear()
        LevelSPLineItem.Clear()
        LevelGraph.Refresh()
    End Sub

    Private Sub BuzzerTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuzzerTimer.Tick
        If IsEmergency = False Then Exit Sub
        If BuzzerY5 = "1" Then
            BuzzerY5 = "0"
        Else
            BuzzerY5 = "1"
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.ShowDialog()
    End Sub


    Private Sub ChangeIPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeIPToolStripMenuItem.Click
        ShellExecute(0, "open", "http://" + Ethernet.IP + "/protect/config.htm", "", "", 3)
    End Sub
    Public Declare Function ShellExecute Lib "shell32.dll" Alias "ShellExecuteA" (ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer



    Delegate Sub InvokeDelegate()
    Dim IsLinkFound As Boolean = False
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
        LinkLabel.Text = "Ethernet Link " + Ethernet.IP
    End Sub



    Private Sub SetAlarmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetAlarmToolStripMenuItem.Click
        SetAlarm.ShowDialog()
    End Sub



    Private Function TemperatureAlarmCheck() As Boolean
        If SetAlarm.TemperatureAlarmTable.Rows.Count <= 0 Then Return False
        Dim i As Integer
        For i = 0 To SetAlarm.TemperatureAlarmTable.Rows.Count - 1
            If (CInt(CurrentTemperature) = CInt(SetAlarm.TemperatureAlarmTable.Item(0, i).Value)) Then
                If BuzzerY5 = "1" Then
                    TemperaturePanel.BackColor = Color.CornflowerBlue
                Else
                    TemperaturePanel.BackColor = Color.Transparent
                End If
                Return True
            End If
        Next
        TemperaturePanel.BackColor = Color.Transparent
        Return False
    End Function


    Private Function LevelAlarmCheck() As Boolean
        If SetAlarm.LevelAlarmTable.Rows.Count <= 0 Then Return False
        Dim i As Integer
        For i = 0 To SetAlarm.LevelAlarmTable.Rows.Count - 1
            If (CInt(CurrentLevel) = CInt(SetAlarm.LevelAlarmTable.Item(0, i).Value)) Then
                If BuzzerY5 = "1" Then
                    LevelPanel.BackColor = Color.CornflowerBlue
                Else
                    LevelPanel.BackColor = Color.Transparent
                End If
                Return True
            End If
        Next
        LevelPanel.BackColor = Color.Transparent
        Return False
    End Function

    Private Function PressureAlarmCheck() As Boolean
        If SetAlarm.PressureAlarmTable.Rows.Count <= 0 Then Return False
        Dim i As Integer
        For i = 0 To SetAlarm.PressureAlarmTable.Rows.Count - 1
            If (CInt(CurrentPressure) = CInt(SetAlarm.PressureAlarmTable.Item(0, i).Value)) Then
                If BuzzerY5 = "1" Then
                    PressurePanel.BackColor = Color.CornflowerBlue
                Else
                    PressurePanel.BackColor = Color.Transparent
                End If
                Return True
            End If
        Next
        PressurePanel.BackColor = Color.Transparent
        Return False
    End Function

    Private Function FlowAlarmCheck() As Boolean
        If SetAlarm.FlowAlarmTable.Rows.Count <= 0 Then Return False
        Dim i As Integer
        For i = 0 To SetAlarm.FlowAlarmTable.Rows.Count - 1
            If (CInt(CurrentFlow) = CInt(SetAlarm.FlowAlarmTable.Item(0, i).Value)) Then
                If BuzzerY5 = "1" Then
                    flowPanel.BackColor = Color.CornflowerBlue
                Else
                    flowPanel.BackColor = Color.Transparent
                End If
                Return True
            End If
        Next
        flowPanel.BackColor = Color.Transparent
        Return False
    End Function

    Private Sub PressureClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PressureClearButton.Click
        PressureLineItem.Clear()
        PressureGraph.Refresh()
    End Sub

    Private Sub FlowClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowClearButton.Click
        FlowMeterLineItem.Clear()
        FLowMeterGraph.Refresh()
    End Sub

    Private Sub WarningLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class
