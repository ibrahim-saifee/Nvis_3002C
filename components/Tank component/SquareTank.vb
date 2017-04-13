Public Class SquareTank

    Dim max As Integer = 17
    Dim count As Integer = max

    Private Sub Stirrer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Heater = False
        Range = 100
        Level = 50
        Width = 200
        Height = 200
        count = 1
    End Sub

    'Private Sub Stirrer_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
    '    Dim p As Pen = New Pen(Color.Black, 2)
    '    Dim rect As Rectangle = New Rectangle(61, 2, 6, 86)
    '    e.Graphics.DrawRectangle(p, rect)
    'End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'For i = 1 To max
        Try
            Dim pb As PictureBox = CType(Controls("PictureBox" + count.ToString), PictureBox)
            Dim pb1 As PictureBox
            If count <> max Then
                pb1 = CType(Controls("PictureBox" + (count + 1).ToString), PictureBox)
            Else
                pb1 = CType(Controls("PictureBox" + "1"), PictureBox)
            End If
            'If i = count Then
            pb.Visible = True
            'Else
            pb1.Visible = False
            'End If
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "ERROR")
        End Try
        count -= 1
        If count < 1 Then count = max
    End Sub

    Dim RangeValue As Integer
    Property Range As Integer
        Get
            Return RangeValue
        End Get
        Set(ByVal value As Integer)
            If value > 0 Then
                RangeValue = value
                SetShapes()
            End If
        End Set
    End Property



    Dim LevelValue As Integer
    Property Level As Integer
        Get
            Return LevelValue
        End Get
        Set(ByVal value As Integer)
            If value >= 0 And value <= RangeValue Then
                LevelValue = value
                SetShapes()
            End If
        End Set
    End Property

    Dim SetPointValue As Integer
    Property SetPoint As Integer
        Get
            Return SetPointValue
        End Get
        Set(ByVal value As Integer)
            If (value >= 0 And value <= RangeValue) Then
                SetPointValue = value
                SetShapes()
            End If
        End Set
    End Property

    Private Sub SetShapes()
       
        TankRectangle.Top = 45
        TankRectangle.Left = 1
        TankRectangle.Height = Height - 48
        TankRectangle.Width = Width - 2

        TankLine1.X1 = TankRectangle.Left
        TankLine1.Y1 = TankRectangle.Top
        TankLine1.X2 = TankRectangle.Left
        TankLine1.Y2 = TankRectangle.Bottom

        TankLine2.X1 = TankRectangle.Left
        TankLine2.Y1 = TankRectangle.Bottom
        TankLine2.X2 = TankRectangle.Right
        TankLine2.Y2 = TankRectangle.Bottom

        TankLine3.X1 = TankRectangle.Right
        TankLine3.Y1 = TankRectangle.Bottom
        TankLine3.X2 = TankRectangle.Right
        TankLine3.Y2 = TankRectangle.Top

        WaterLevelRectangle1.Width = TankRectangle.Width - 2
        WaterLevelRectangle1.Height = LevelValue * TankRectangle.Height / RangeValue
        WaterLevelRectangle1.Left = TankRectangle.Left + 1
        WaterLevelRectangle1.Top = TankRectangle.Bottom - WaterLevelRectangle1.Height

        WaterLevelRectangle2.Width = WaterLevelRectangle1.Width
        WaterLevelRectangle2.Height = WaterLevelRectangle1.Height
        WaterLevelRectangle2.Left = WaterLevelRectangle1.Left
        WaterLevelRectangle2.Top = WaterLevelRectangle1.Top

        LevelSensor.Left = 5
        LevelSensor.Top = 1
        LevelSensor.Width = 35
        LevelSensor.Height = 185

        WaterLevelRectangle1.BringToFront()
        WaterLevelRectangle2.BringToFront()

        SetPointMark.X1 = 0
        SetPointMark.X2 = 10
        SetPointMark.Y1 = TankRectangle.Bottom - SetPoint * TankRectangle.Height / Range
        SetPointMark.Y2 = SetPointMark.Y1

        TankLine1.BringToFront()
        TankLine2.BringToFront()
        TankLine3.BringToFront()
        SetPointMark.BringToFront()
    End Sub

    Private Sub Nvis3002APanel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Range = 100
        Level = 50
    End Sub

    Private Sub Nvis3002APanel_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        SetShapes()
    End Sub

End Class

