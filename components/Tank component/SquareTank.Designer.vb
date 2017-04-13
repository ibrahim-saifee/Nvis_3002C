<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SquareTank
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SquareTank))
        Me.WaterLevelRectangle1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.SetPointMark = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.TankLine1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.TankLine3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.TankLine2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.TankRectangle = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.WaterLevelRectangle2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LevelSensor = New System.Windows.Forms.PictureBox()
        CType(Me.LevelSensor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WaterLevelRectangle1
        '
        Me.WaterLevelRectangle1.BorderColor = System.Drawing.Color.Transparent
        Me.WaterLevelRectangle1.FillColor = System.Drawing.Color.MediumBlue
        Me.WaterLevelRectangle1.FillGradientColor = System.Drawing.Color.Transparent
        Me.WaterLevelRectangle1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal
        Me.WaterLevelRectangle1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.WaterLevelRectangle1.Location = New System.Drawing.Point(658, 34)
        Me.WaterLevelRectangle1.Name = "WaterLevelRectangle1"
        Me.WaterLevelRectangle1.SelectionColor = System.Drawing.Color.Transparent
        Me.WaterLevelRectangle1.Size = New System.Drawing.Size(196, 83)
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.SetPointMark, Me.TankLine1, Me.TankLine3, Me.TankLine2, Me.TankRectangle, Me.WaterLevelRectangle2, Me.WaterLevelRectangle1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1299, 462)
        Me.ShapeContainer1.TabIndex = 45
        Me.ShapeContainer1.TabStop = False
        '
        'SetPointMark
        '
        Me.SetPointMark.BorderColor = System.Drawing.Color.Blue
        Me.SetPointMark.BorderWidth = 5
        Me.SetPointMark.Name = "SetPointMark"
        Me.SetPointMark.SelectionColor = System.Drawing.Color.Transparent
        Me.SetPointMark.X1 = 916
        Me.SetPointMark.X2 = 931
        Me.SetPointMark.Y1 = 284
        Me.SetPointMark.Y2 = 284
        '
        'TankLine1
        '
        Me.TankLine1.BorderColor = System.Drawing.Color.DimGray
        Me.TankLine1.BorderWidth = 10
        Me.TankLine1.Name = "TankLine1"
        Me.TankLine1.SelectionColor = System.Drawing.Color.Transparent
        Me.TankLine1.X1 = 961
        Me.TankLine1.X2 = 1036
        Me.TankLine1.Y1 = 221
        Me.TankLine1.Y2 = 244
        '
        'TankLine3
        '
        Me.TankLine3.BorderColor = System.Drawing.Color.DimGray
        Me.TankLine3.BorderWidth = 10
        Me.TankLine3.Name = "TankLine3"
        Me.TankLine3.SelectionColor = System.Drawing.Color.Transparent
        Me.TankLine3.X1 = 1020
        Me.TankLine3.X2 = 1095
        Me.TankLine3.Y1 = 173
        Me.TankLine3.Y2 = 196
        '
        'TankLine2
        '
        Me.TankLine2.BorderColor = System.Drawing.Color.DimGray
        Me.TankLine2.BorderWidth = 10
        Me.TankLine2.Name = "TankLine2"
        Me.TankLine2.SelectionColor = System.Drawing.Color.Transparent
        Me.TankLine2.X1 = 943
        Me.TankLine2.X2 = 1018
        Me.TankLine2.Y1 = 180
        Me.TankLine2.Y2 = 203
        '
        'TankRectangle
        '
        Me.TankRectangle.BorderWidth = 7
        Me.TankRectangle.CornerRadius = 13
        Me.TankRectangle.Location = New System.Drawing.Point(745, 150)
        Me.TankRectangle.Name = "TankRectangle"
        Me.TankRectangle.SelectionColor = System.Drawing.Color.Transparent
        Me.TankRectangle.Size = New System.Drawing.Size(155, 71)
        Me.TankRectangle.Visible = False
        '
        'WaterLevelRectangle2
        '
        Me.WaterLevelRectangle2.BorderColor = System.Drawing.Color.Transparent
        Me.WaterLevelRectangle2.FillColor = System.Drawing.Color.Transparent
        Me.WaterLevelRectangle2.FillGradientColor = System.Drawing.Color.MediumBlue
        Me.WaterLevelRectangle2.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Horizontal
        Me.WaterLevelRectangle2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.WaterLevelRectangle2.Location = New System.Drawing.Point(871, 34)
        Me.WaterLevelRectangle2.Name = "WaterLevelRectangle2"
        Me.WaterLevelRectangle2.SelectionColor = System.Drawing.Color.Transparent
        Me.WaterLevelRectangle2.Size = New System.Drawing.Size(196, 83)
        '
        'LevelSensor
        '
        Me.LevelSensor.BackgroundImage = CType(resources.GetObject("LevelSensor.BackgroundImage"), System.Drawing.Image)
        Me.LevelSensor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LevelSensor.Location = New System.Drawing.Point(691, 257)
        Me.LevelSensor.Name = "LevelSensor"
        Me.LevelSensor.Size = New System.Drawing.Size(35, 189)
        Me.LevelSensor.TabIndex = 46
        Me.LevelSensor.TabStop = False
        '
        'SquareTank
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Controls.Add(Me.LevelSensor)
        Me.DoubleBuffered = True
        Me.Name = "SquareTank"
        Me.Size = New System.Drawing.Size(1299, 462)
        CType(Me.LevelSensor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents WaterLevelRectangle1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents WaterLevelRectangle2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents LevelSensor As System.Windows.Forms.PictureBox
    Friend WithEvents TankRectangle As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents TankLine1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents TankLine3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents TankLine2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents SetPointMark As Microsoft.VisualBasic.PowerPacks.LineShape

End Class
