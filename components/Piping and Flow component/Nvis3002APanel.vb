Imports SquareTank
Imports SquareTankNoStirrer
Public Class Nvis3002APanel


#Region "GENERAL PROPERTIES"
    Property FlowTime As Integer
        Get
            Return OverflowTimer.Interval
        End Get
        Set(ByVal value As Integer)
            OverflowTimer.Interval = value
            FillTimer.Interval = value
            DrainTimer.Interval = value
            BigValveTimer.Interval = value
        End Set
    End Property

    Dim StepSizeValue As Integer


    Property StepSize As Integer
        Get
            Return StepSizeValue
        End Get
        Set(ByVal value As Integer)
            StepSizeValue = value
        End Set
    End Property

    Private Sub Nvis3002APanel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Width = 865
        Height = 475
        OverFlowAt = 90
        FlowMaxValue = 1000
        FlowMinValue = 0
        EmptyDrainPipes()
        EmptyFillingPipes()
        EmptyOverflowPipes()
        EmptyBigValvePipes()
        StepSize = 5
        FlowTime = 20
        LevelUnit = "%"
    End Sub
#End Region


#Region "TANK"
    Property TankLevel As Integer
        Get
            Return SquareTank1.Level
        End Get
        Set(ByVal value As Integer)
            SquareTank1.Level = value
            SquareTankNoStirrer1.Level = SquareTankNoStirrer1.Range - value - 20
            If value >= OverFlowAt Then
                OverFlow = True
            End If
        End Set
    End Property

    Property LevelCurrent As String
        Get
            Return LevelLabel.Text
        End Get
        Set(ByVal value As String)
            LevelLabel.Text = value
            LevelUnitLabel.Left = LevelLabel.Right
        End Set
    End Property

    Property TankRange As Integer
        Get
            Return SquareTank1.Range
        End Get
        Set(ByVal value As Integer)
            SquareTank1.Range = value
            SquareTankNoStirrer1.Range = value + 50
        End Set
    End Property

    Property LevelSetPoint As Integer
        Get
            Return SquareTank1.SetPoint
        End Get
        Set(ByVal value As Integer)
            SquareTank1.SetPoint = value
        End Set
    End Property

    Property LevelUnit As String
        Get
            Return LevelUnitLabel.Text
        End Get
        Set(ByVal value As String)
            LevelUnitLabel.Text = value
            LevelUnitLabel.Left = LevelLabel.Right
        End Set
    End Property

#End Region


#Region "OVERFLOW"
    Dim OverflowProgress, OverflowPipeIndex As Integer

    Private Sub SetOverflowShapes()
        OverflowWater1.Left = OverflowPipe1.Left
        OverflowWater1.Top = OverflowPipe1.Top + 3
        'OverflowWater1.Width = 1
        OverflowWater1.Height = OverflowPipe1.Height - 6

        OverflowWater2.Left = OverflowPipe2.Left + 3
        OverflowWater2.Top = OverflowPipe2.Top + 1
        OverflowWater2.Width = OverflowPipe2.Width - 6
        'OverflowWater3.Height = 1

        If OverflowPipeIndex = 0 Then
            OverflowWater1.Width = OverflowProgress
        ElseIf OverflowPipeIndex = 1 Then
            OverflowWater2.Height = OverflowProgress
        End If
    End Sub

    Dim OverFlowState As Boolean
    Property OverFlow As Boolean
        Get
            Return OverFlowState
        End Get
        Set(ByVal value As Boolean)
            OverFlowState = value
            OverflowTimer.Enabled = value
        End Set
    End Property

    Dim OverFlowAtValue As Integer
    Property OverFlowAt As Integer
        Get
            Return OverFlowAtValue
        End Get
        Set(ByVal value As Integer)
            If value > 0 And value < SquareTank1.Range Then OverFlowAtValue = value
        End Set
    End Property

    Public Sub EmptyOverflowPipes()
        OverFlow = False
        OverflowWater1.Width = 0
        OverflowWater2.Height = 0
        OverflowProgress = 0
        SetOverflowShapes()
    End Sub

    Private Sub OverflowTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OverflowTimer.Tick
        OverflowProgress += StepSizeValue
        If OverflowPipeIndex = 0 Then
            If OverflowProgress >= OverflowPipe1.Width Then
                OverflowProgress = 0
                OverflowPipeIndex = 1
            End If
        ElseIf OverflowPipeIndex = 1 Then
            If OverflowProgress >= OverflowPipe2.Height Then
                OverflowProgress = 0
                OverflowPipeIndex = 2
            End If
        ElseIf OverflowPipeIndex = 2 Then
            If SquareTank1.Level >= OverFlowAt Then
                'TankLevel -= 1
                'SquareTankNoStirrer1.Level += 1
            Else
                OverflowPipeIndex = 0
                OverFlow = False
                EmptyOverflowPipes()
                Exit Sub
            End If
        End If
        SetOverflowShapes()
    End Sub
#End Region


#Region "FILLING"
    Dim FillProgress, FillPipeIndex As Integer

    Private Sub SetFillShapes()
        FillWater1.Top = FillPipe1.Top + 3
        FillWater1.Height = FillPipe1.Height - 6

        FillWater2.Left = FillPipe2.Left + 3
        FillWater2.Width = FillPipe2.Width - 6

        FillWater3.Top = FillPipe3.Top + 3
        FillWater3.Height = FillPipe3.Height - 6

        FillWater4.Left = FillPipe4.Left + 3
        FillWater4.Width = FillPipe4.Width - 6

        If FillPipeIndex = 0 Then
            FillWater4.Height = FillProgress
            FillWater4.Top = FillPipe4.Bottom - 1 - FillProgress
        ElseIf FillPipeIndex = 1 Then
            FillWater3.Width = FillProgress
            FillWater3.Left = FillPipe3.Right - 1 - FillProgress
        ElseIf FillPipeIndex = 2 Then
            FillWater2.Height = FillProgress
            FillWater2.Top = FillPipe2.Bottom - 1 - FillProgress
        ElseIf FillPipeIndex = 3 Then
            FillWater1.Width = FillProgress
            FillWater1.Left = FillPipe1.Right - 1 - FillProgress
        End If
    End Sub

    Dim FillingState As Boolean
    Property Fill As Boolean
        Get
            Return FillingState
        End Get
        Set(ByVal value As Boolean)
            FillingState = value
            FillTimer.Enabled = value
            If value = True Then
                PumpLabel.ForeColor = Color.Red
            Else
                PumpLabel.ForeColor = Color.Black
                If FillPipeIndex = 4 Then EmptyFillingPipes()
            End If
        End Set
    End Property

    Public Sub EmptyFillingPipes()
        'Fill = False
        FillPipeIndex = 0
        FillWater1.Width = 0
        FillWater2.Height = 0
        FillWater3.Width = 0
        FillProgress = 0
        SetFillShapes()
    End Sub

    Private Sub FillingTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillTimer.Tick
        FillProgress += StepSizeValue
        If FillPipeIndex = 0 Then
            If FillProgress >= FillPipe4.Height Then
                FillProgress = 0
                FillPipeIndex = 1
            End If
        ElseIf FillPipeIndex = 1 Then
            If FillProgress >= FillPipe3.Width Then
                FillProgress = 0
                FillPipeIndex = 2
            End If
        ElseIf FillPipeIndex = 2 Then
            If FillProgress >= FillPipe2.Height Then
                FillProgress = 0
                FillPipeIndex = 3
            End If
        ElseIf FillPipeIndex = 3 Then
            If FillProgress >= FillPipe1.Width Then
                FillPipeIndex = 4
            End If
        ElseIf FillPipeIndex = 3 Then
            'TankLevel += 1
            'SquareTankNoStirrer1.Level -= 1
        End If
        SetFillShapes()
    End Sub
#End Region


#Region "DRAINING"
    Dim drainProgress, drainPipeIndex As Integer

    Private Sub SetDrainShapes()
        DrainWater1.Left = DrainPipe1.Left + 3
        DrainWater1.Top = DrainPipe1.Top
        DrainWater1.Width = DrainPipe1.Width - 6

        DrainWater2.Left = DrainPipe2.Left + 1
        DrainWater2.Top = DrainPipe2.Top + 3
        DrainWater2.Height = DrainPipe2.Height - 6

        If drainPipeIndex = 0 Then
            DrainWater1.Height = drainProgress
        ElseIf drainPipeIndex = 1 Then
            DrainWater2.Width = drainProgress
        End If
    End Sub

    Dim DrainState As Boolean
    Property Drain As Boolean
        Get
            Return DrainState
        End Get
        Set(ByVal value As Boolean)
            DrainState = value
            DrainTimer.Enabled = value
            If value = True Then
                ValveLabel.ForeColor = Color.Red
                ValvImage.SendToBack()
                DrainPipe2.SendToBack()
                FillPipe2.SendToBack()
            Else
                ValveLabel.ForeColor = Color.Black
                DrainPipe2.BringToFront()
                ValvImage.BringToFront()
                FillPipe2.SendToBack()
                PictureBox8.BringToFront()
                PictureBox10.BringToFront()
            End If
            Refresh()
        End Set
    End Property

    Public Sub EmptyDrainPipes()
        Drain = False
        DrainWater1.Height = 0
        DrainWater2.Width = 0
        drainProgress = 0
        SetDrainShapes()
    End Sub

    Private Sub DrainTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DrainTimer.Tick
        drainProgress += StepSizeValue
        If drainPipeIndex = 0 Then
            If drainProgress >= DrainPipe1.Height Then
                drainProgress = 0
                drainPipeIndex = 1
            End If
        ElseIf drainPipeIndex = 1 Then
            If drainProgress >= DrainPipe2.Width Then
                drainPipeIndex = 2
                drainProgress = 0
            End If
        ElseIf drainPipeIndex = 2 Then
            If TankLevel > 0 Then
                'TankLevel -= 1
                'SquareTankNoStirrer1.Level += 1
            Else
                drainPipeIndex = 0
                Drain = False
                DrainTimer.Enabled = False
                EmptyDrainPipes()
                Exit Sub
            End If
        End If
        SetDrainShapes()
    End Sub
#End Region


#Region "FLOW METER"
    Dim FlowMin As Integer
    Property FlowMinValue As Integer
        Get
            Return FlowMin
        End Get
        Set(value As Integer)
            If value < FlowMax Then FlowMin = value
        End Set
    End Property

    Dim FlowMax As Integer
    Property FlowMaxValue As Integer
        Get
            Return FlowMax
        End Get
        Set(value As Integer)
            If value > FlowMin Then FlowMax = value
        End Set
    End Property

    Dim FlowVal As Integer
    Private Property FlowValue As Integer
        Get
            Return FlowVal
        End Get
        Set(value As Integer)
            FlowDigi.DigitText = value.ToString("0000")
        End Set
    End Property

    Dim FlowCurrent As Double
    Property FlowCurrentValue As Double
        Get
            Return FlowCurrent
        End Get
        Set(value As Double)
            If value >= 4 And value <= 20 Then
                FlowCurrent = FormatNumber(value, 1)
                FlowSensorCurrentLabel.Text = "Current " + FlowCurrent.ToString("00.0") + " mA"
                FlowValue = FlowMin + ((FlowMax - FlowMin) * (value - 4) / 16)
            End If
        End Set
    End Property
#End Region

#Region "BIG VALVE"

    Dim ValveOpening As Integer
    Property ControlValveOpening As Integer
        Get
            Return ValveOpening
        End Get
        Set(value As Integer)
            If value >= 0 And value <= 100 Then
                ValveOpening = value
                ControlValveLabel.Text = "Control Valve" + Environment.NewLine + "(" + ValveOpening.ToString + "% open)"
                ControlValveCurrentLabel.Text = "Current " + (4 + ValveOpening * 16 / 100).ToString("00.0") + " mA"
                'If value > 0 Then BigValve = True Else BigValve = False
                BigValve = value > 0
            End If
        End Set
    End Property

    Dim BigValveProgress, BigValvePipeIndex As Integer

    Private Sub SetBigValveShapes()
        BigValveWater1.Left = BigValvePipe1.Left
        BigValveWater1.Top = BigValvePipe1.Top + 3
        'OverflowWater1.Width = 1
        BigValveWater1.Height = BigValvePipe1.Height - 6

        BigValveWater2.Left = BigValvePipe2.Left + 3
        BigValveWater2.Top = BigValvePipe2.Top + 1
        BigValveWater2.Width = BigValvePipe2.Width - 6
        'OverflowWater3.Height = 1

        If BigValvePipeIndex = 0 Then
            BigValveWater1.Width = BigValveProgress
        ElseIf BigValvePipeIndex = 1 Then
            BigValveWater2.Height = BigValveProgress
        End If
    End Sub

    Dim BigValveState As Boolean
    Private Property BigValve As Boolean
        Get
            Return BigValveState
        End Get
        Set(ByVal value As Boolean)
            BigValveState = value
            BigValveTimer.Enabled = value
            If value = True Then
                ControlValveLabel.ForeColor = Color.Red
            Else
                ControlValveLabel.ForeColor = Color.Black
                If BigValvePipeIndex = 2 Then EmptyBigValvePipes()
            End If
        End Set
    End Property

    Public Sub EmptyBigValvePipes()
        BigValvePipeIndex = 0
        BigValveWater1.Width = 0
        BigValveWater2.Height = 0
        BigValveProgress = 0
        SetBigValveShapes()
    End Sub

    Private Sub BigValveTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BigValveTimer.Tick
        BigValveProgress += StepSizeValue
        If BigValvePipeIndex = 0 Then
            If BigValveProgress >= BigValvePipe1.Width Then
                BigValveProgress = 0
                BigValvePipeIndex = 1
            End If
        ElseIf BigValvePipeIndex = 1 Then
            If BigValveProgress >= BigValvePipe2.Height Then
                BigValveProgress = 0
                BigValvePipeIndex = 2
            End If
        ElseIf BigValvePipeIndex = 2 Then
        End If
        SetBigValveShapes()
    End Sub
#End Region

   
    Private Sub PictureBox17_Click(sender As Object, e As EventArgs)
    End Sub
End Class



