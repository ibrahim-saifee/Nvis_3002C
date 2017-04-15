<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StopWatch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StopWatch))
        Me.seclbl = New System.Windows.Forms.Label()
        Me.minlbl = New System.Windows.Forms.Label()
        Me.hourlbl = New System.Windows.Forms.Label()
        Me.freetimer = New System.Windows.Forms.Timer(Me.components)
        Me.laptimetable = New System.Windows.Forms.DataGridView()
        Me.laptime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dotslblhrs = New System.Windows.Forms.Label()
        Me.timepanel = New System.Windows.Forms.Panel()
        Me.hrsdigi = New Owf.Controls.DigitalDisplayControl()
        Me.msecdigi = New Owf.Controls.DigitalDisplayControl()
        Me.mindigi = New Owf.Controls.DigitalDisplayControl()
        Me.secdigi = New Owf.Controls.DigitalDisplayControl()
        Me.dotslblmin = New System.Windows.Forms.Label()
        Me.dotslblsec = New System.Windows.Forms.Label()
        Me.dottimer = New System.Windows.Forms.Timer(Me.components)
        Me.startbtn = New System.Windows.Forms.Button()
        Me.rstbtn = New System.Windows.Forms.Button()
        Me.capturebtn = New System.Windows.Forms.Button()
        CType(Me.laptimetable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.timepanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'seclbl
        '
        Me.seclbl.AutoSize = True
        Me.seclbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seclbl.ForeColor = System.Drawing.Color.Red
        Me.seclbl.Location = New System.Drawing.Point(188, 83)
        Me.seclbl.Name = "seclbl"
        Me.seclbl.Size = New System.Drawing.Size(79, 20)
        Me.seclbl.TabIndex = 28
        Me.seclbl.Text = "Seconds"
        '
        'minlbl
        '
        Me.minlbl.AutoSize = True
        Me.minlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minlbl.ForeColor = System.Drawing.Color.Red
        Me.minlbl.Location = New System.Drawing.Point(101, 83)
        Me.minlbl.Name = "minlbl"
        Me.minlbl.Size = New System.Drawing.Size(72, 20)
        Me.minlbl.TabIndex = 27
        Me.minlbl.Text = "Minutes"
        '
        'hourlbl
        '
        Me.hourlbl.AutoSize = True
        Me.hourlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hourlbl.ForeColor = System.Drawing.Color.Red
        Me.hourlbl.Location = New System.Drawing.Point(16, 83)
        Me.hourlbl.Name = "hourlbl"
        Me.hourlbl.Size = New System.Drawing.Size(57, 20)
        Me.hourlbl.TabIndex = 26
        Me.hourlbl.Text = "Hours"
        '
        'freetimer
        '
        '
        'laptimetable
        '
        Me.laptimetable.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.laptimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.laptimetable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.laptime})
        Me.laptimetable.Location = New System.Drawing.Point(211, 127)
        Me.laptimetable.Name = "laptimetable"
        Me.laptimetable.RowHeadersVisible = False
        Me.laptimetable.Size = New System.Drawing.Size(171, 153)
        Me.laptimetable.TabIndex = 58
        '
        'laptime
        '
        Me.laptime.HeaderText = "Lap Time (HH:mm:ss:__)"
        Me.laptime.Name = "laptime"
        Me.laptime.ReadOnly = True
        Me.laptime.Width = 165
        '
        'dotslblhrs
        '
        Me.dotslblhrs.AutoSize = True
        Me.dotslblhrs.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dotslblhrs.ForeColor = System.Drawing.Color.Red
        Me.dotslblhrs.Location = New System.Drawing.Point(67, 9)
        Me.dotslblhrs.Name = "dotslblhrs"
        Me.dotslblhrs.Size = New System.Drawing.Size(53, 76)
        Me.dotslblhrs.TabIndex = 23
        Me.dotslblhrs.Text = ":"
        '
        'timepanel
        '
        Me.timepanel.BackColor = System.Drawing.Color.Black
        Me.timepanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.timepanel.Controls.Add(Me.seclbl)
        Me.timepanel.Controls.Add(Me.minlbl)
        Me.timepanel.Controls.Add(Me.hourlbl)
        Me.timepanel.Controls.Add(Me.hrsdigi)
        Me.timepanel.Controls.Add(Me.msecdigi)
        Me.timepanel.Controls.Add(Me.mindigi)
        Me.timepanel.Controls.Add(Me.secdigi)
        Me.timepanel.Controls.Add(Me.dotslblhrs)
        Me.timepanel.Controls.Add(Me.dotslblmin)
        Me.timepanel.Controls.Add(Me.dotslblsec)
        Me.timepanel.Location = New System.Drawing.Point(12, 12)
        Me.timepanel.Name = "timepanel"
        Me.timepanel.Size = New System.Drawing.Size(370, 109)
        Me.timepanel.TabIndex = 57
        '
        'hrsdigi
        '
        Me.hrsdigi.BackColor = System.Drawing.Color.Transparent
        Me.hrsdigi.DigitColor = System.Drawing.Color.Red
        Me.hrsdigi.DigitText = "00"
        Me.hrsdigi.Location = New System.Drawing.Point(8, 1)
        Me.hrsdigi.Margin = New System.Windows.Forms.Padding(4)
        Me.hrsdigi.MaximumSize = New System.Drawing.Size(72, 99)
        Me.hrsdigi.Name = "hrsdigi"
        Me.hrsdigi.Size = New System.Drawing.Size(72, 99)
        Me.hrsdigi.TabIndex = 18
        '
        'msecdigi
        '
        Me.msecdigi.BackColor = System.Drawing.Color.Transparent
        Me.msecdigi.DigitColor = System.Drawing.Color.Red
        Me.msecdigi.DigitText = "00"
        Me.msecdigi.Location = New System.Drawing.Point(288, 2)
        Me.msecdigi.Margin = New System.Windows.Forms.Padding(0)
        Me.msecdigi.MaximumSize = New System.Drawing.Size(72, 99)
        Me.msecdigi.Name = "msecdigi"
        Me.msecdigi.Size = New System.Drawing.Size(72, 99)
        Me.msecdigi.TabIndex = 21
        '
        'mindigi
        '
        Me.mindigi.BackColor = System.Drawing.Color.Transparent
        Me.mindigi.DigitColor = System.Drawing.Color.Red
        Me.mindigi.DigitText = "00"
        Me.mindigi.Location = New System.Drawing.Point(100, 1)
        Me.mindigi.Margin = New System.Windows.Forms.Padding(0)
        Me.mindigi.MaximumSize = New System.Drawing.Size(72, 99)
        Me.mindigi.Name = "mindigi"
        Me.mindigi.Size = New System.Drawing.Size(72, 99)
        Me.mindigi.TabIndex = 19
        '
        'secdigi
        '
        Me.secdigi.BackColor = System.Drawing.Color.Transparent
        Me.secdigi.DigitColor = System.Drawing.Color.Red
        Me.secdigi.DigitText = "00"
        Me.secdigi.Location = New System.Drawing.Point(193, 1)
        Me.secdigi.Margin = New System.Windows.Forms.Padding(4)
        Me.secdigi.MaximumSize = New System.Drawing.Size(72, 99)
        Me.secdigi.Name = "secdigi"
        Me.secdigi.Size = New System.Drawing.Size(72, 99)
        Me.secdigi.TabIndex = 20
        '
        'dotslblmin
        '
        Me.dotslblmin.AutoSize = True
        Me.dotslblmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dotslblmin.ForeColor = System.Drawing.Color.Red
        Me.dotslblmin.Location = New System.Drawing.Point(159, 9)
        Me.dotslblmin.Name = "dotslblmin"
        Me.dotslblmin.Size = New System.Drawing.Size(53, 76)
        Me.dotslblmin.TabIndex = 24
        Me.dotslblmin.Text = ":"
        '
        'dotslblsec
        '
        Me.dotslblsec.AutoSize = True
        Me.dotslblsec.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dotslblsec.ForeColor = System.Drawing.Color.Red
        Me.dotslblsec.Location = New System.Drawing.Point(253, 9)
        Me.dotslblsec.Name = "dotslblsec"
        Me.dotslblsec.Size = New System.Drawing.Size(53, 76)
        Me.dotslblsec.TabIndex = 25
        Me.dotslblsec.Text = ":"
        '
        'dottimer
        '
        '
        'startbtn
        '
        Me.startbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startbtn.Location = New System.Drawing.Point(22, 147)
        Me.startbtn.Name = "startbtn"
        Me.startbtn.Size = New System.Drawing.Size(75, 36)
        Me.startbtn.TabIndex = 59
        Me.startbtn.Text = "Start"
        Me.startbtn.UseVisualStyleBackColor = True
        '
        'rstbtn
        '
        Me.rstbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rstbtn.Location = New System.Drawing.Point(119, 147)
        Me.rstbtn.Name = "rstbtn"
        Me.rstbtn.Size = New System.Drawing.Size(75, 36)
        Me.rstbtn.TabIndex = 60
        Me.rstbtn.Text = "Reset"
        Me.rstbtn.UseVisualStyleBackColor = True
        '
        'capturebtn
        '
        Me.capturebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.capturebtn.Location = New System.Drawing.Point(22, 202)
        Me.capturebtn.Name = "capturebtn"
        Me.capturebtn.Size = New System.Drawing.Size(172, 36)
        Me.capturebtn.TabIndex = 61
        Me.capturebtn.Text = "Capture"
        Me.capturebtn.UseVisualStyleBackColor = True
        '
        'StopWatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(392, 288)
        Me.Controls.Add(Me.capturebtn)
        Me.Controls.Add(Me.rstbtn)
        Me.Controls.Add(Me.startbtn)
        Me.Controls.Add(Me.laptimetable)
        Me.Controls.Add(Me.timepanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "StopWatch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stop Watch"
        CType(Me.laptimetable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.timepanel.ResumeLayout(False)
        Me.timepanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents seclbl As System.Windows.Forms.Label
    Friend WithEvents minlbl As System.Windows.Forms.Label
    Friend WithEvents hourlbl As System.Windows.Forms.Label
    Friend WithEvents freetimer As System.Windows.Forms.Timer
    Friend WithEvents laptimetable As System.Windows.Forms.DataGridView
    Friend WithEvents dotslblhrs As System.Windows.Forms.Label
    Friend WithEvents timepanel As System.Windows.Forms.Panel
    Friend WithEvents hrsdigi As Owf.Controls.DigitalDisplayControl
    Friend WithEvents msecdigi As Owf.Controls.DigitalDisplayControl
    Friend WithEvents mindigi As Owf.Controls.DigitalDisplayControl
    Friend WithEvents secdigi As Owf.Controls.DigitalDisplayControl
    Friend WithEvents dotslblmin As System.Windows.Forms.Label
    Friend WithEvents dotslblsec As System.Windows.Forms.Label
    Friend WithEvents dottimer As System.Windows.Forms.Timer
    Friend WithEvents startbtn As System.Windows.Forms.Button
    Friend WithEvents rstbtn As System.Windows.Forms.Button
    Friend WithEvents capturebtn As System.Windows.Forms.Button
    Friend WithEvents laptime As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
