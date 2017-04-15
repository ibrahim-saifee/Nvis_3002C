<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class search
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(search))
        Me.TemperatureTable = New System.Windows.Forms.DataGridView()
        Me.dt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.temp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.resolutionbox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.totxtbox = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fromtxtbox = New System.Windows.Forms.MaskedTextBox()
        Me.TemperatureGraph = New ZedGraph.ZedGraphControl()
        Me.tblbtn = New System.Windows.Forms.Button()
        Me.clrbtn = New System.Windows.Forms.Button()
        Me.searchbtn = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.temperature = New System.Windows.Forms.TabPage()
        Me.WaitPanel = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TerminateButton = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.level = New System.Windows.Forms.TabPage()
        Me.LevelTable = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LevelGraph = New ZedGraph.ZedGraphControl()
        Me.pressure = New System.Windows.Forms.TabPage()
        Me.pressuretable = New System.Windows.Forms.DataGridView()
        Me.pressuregraph = New ZedGraph.ZedGraphControl()
        Me.flow = New System.Windows.Forms.TabPage()
        Me.fromdatebox = New System.Windows.Forms.MaskedTextBox()
        Me.todatebox = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.flowtable = New System.Windows.Forms.DataGridView()
        Me.flowgraph = New ZedGraph.ZedGraphControl()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TemperatureTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.temperature.SuspendLayout()
        Me.WaitPanel.SuspendLayout()
        Me.level.SuspendLayout()
        CType(Me.LevelTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pressure.SuspendLayout()
        CType(Me.pressuretable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flow.SuspendLayout()
        CType(Me.flowtable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TemperatureTable
        '
        Me.TemperatureTable.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.TemperatureTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TemperatureTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dt, Me.tm, Me.sp, Me.temp})
        Me.TemperatureTable.Location = New System.Drawing.Point(0, 0)
        Me.TemperatureTable.Name = "TemperatureTable"
        Me.TemperatureTable.Size = New System.Drawing.Size(606, 436)
        Me.TemperatureTable.TabIndex = 82
        Me.TemperatureTable.Visible = False
        '
        'dt
        '
        Me.dt.HeaderText = "Date"
        Me.dt.Name = "dt"
        Me.dt.Width = 140
        '
        'tm
        '
        Me.tm.HeaderText = "Time"
        Me.tm.Name = "tm"
        Me.tm.Width = 140
        '
        'sp
        '
        Me.sp.HeaderText = "Set Point"
        Me.sp.Name = "sp"
        Me.sp.Width = 140
        '
        'temp
        '
        Me.temp.HeaderText = "Temperature"
        Me.temp.Name = "temp"
        Me.temp.Width = 140
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(469, 475)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 15)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "To :"
        '
        'resolutionbox
        '
        Me.resolutionbox.FormattingEnabled = True
        Me.resolutionbox.Location = New System.Drawing.Point(506, 474)
        Me.resolutionbox.Name = "resolutionbox"
        Me.resolutionbox.Size = New System.Drawing.Size(104, 21)
        Me.resolutionbox.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(247, 478)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "To :"
        '
        'totxtbox
        '
        Me.totxtbox.Location = New System.Drawing.Point(284, 477)
        Me.totxtbox.Mask = "00:00:00"
        Me.totxtbox.Name = "totxtbox"
        Me.totxtbox.Size = New System.Drawing.Size(51, 20)
        Me.totxtbox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 477)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "From :"
        '
        'fromtxtbox
        '
        Me.fromtxtbox.Location = New System.Drawing.Point(54, 476)
        Me.fromtxtbox.Mask = "00:00:00"
        Me.fromtxtbox.Name = "fromtxtbox"
        Me.fromtxtbox.Size = New System.Drawing.Size(51, 20)
        Me.fromtxtbox.TabIndex = 1
        '
        'TemperatureGraph
        '
        Me.TemperatureGraph.IsAntiAlias = True
        Me.TemperatureGraph.IsZoomOnMouseCenter = True
        Me.TemperatureGraph.Location = New System.Drawing.Point(0, 0)
        Me.TemperatureGraph.Name = "TemperatureGraph"
        Me.TemperatureGraph.ScrollGrace = 0.0R
        Me.TemperatureGraph.ScrollMaxX = 0.0R
        Me.TemperatureGraph.ScrollMaxY = 0.0R
        Me.TemperatureGraph.ScrollMaxY2 = 0.0R
        Me.TemperatureGraph.ScrollMinX = 0.0R
        Me.TemperatureGraph.ScrollMinY = 0.0R
        Me.TemperatureGraph.ScrollMinY2 = 0.0R
        Me.TemperatureGraph.Size = New System.Drawing.Size(606, 439)
        Me.TemperatureGraph.TabIndex = 73
        '
        'tblbtn
        '
        Me.tblbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tblbtn.Location = New System.Drawing.Point(522, 524)
        Me.tblbtn.Name = "tblbtn"
        Me.tblbtn.Size = New System.Drawing.Size(86, 33)
        Me.tblbtn.TabIndex = 83
        Me.tblbtn.Text = "Table"
        Me.tblbtn.UseVisualStyleBackColor = True
        '
        'clrbtn
        '
        Me.clrbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clrbtn.Location = New System.Drawing.Point(414, 524)
        Me.clrbtn.Name = "clrbtn"
        Me.clrbtn.Size = New System.Drawing.Size(86, 33)
        Me.clrbtn.TabIndex = 84
        Me.clrbtn.Text = "Clear"
        Me.clrbtn.UseVisualStyleBackColor = True
        '
        'searchbtn
        '
        Me.searchbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchbtn.Location = New System.Drawing.Point(303, 524)
        Me.searchbtn.Name = "searchbtn"
        Me.searchbtn.Size = New System.Drawing.Size(86, 33)
        Me.searchbtn.TabIndex = 85
        Me.searchbtn.Text = "Search"
        Me.searchbtn.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.temperature)
        Me.TabControl1.Controls.Add(Me.level)
        Me.TabControl1.Controls.Add(Me.pressure)
        Me.TabControl1.Controls.Add(Me.flow)
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(614, 465)
        Me.TabControl1.TabIndex = 86
        '
        'temperature
        '
        Me.temperature.Controls.Add(Me.WaitPanel)
        Me.temperature.Controls.Add(Me.TemperatureTable)
        Me.temperature.Controls.Add(Me.TemperatureGraph)
        Me.temperature.Location = New System.Drawing.Point(4, 22)
        Me.temperature.Name = "temperature"
        Me.temperature.Padding = New System.Windows.Forms.Padding(3)
        Me.temperature.Size = New System.Drawing.Size(606, 439)
        Me.temperature.TabIndex = 0
        Me.temperature.Text = "Temperature"
        Me.temperature.UseVisualStyleBackColor = True
        '
        'WaitPanel
        '
        Me.WaitPanel.Controls.Add(Me.Label8)
        Me.WaitPanel.Controls.Add(Me.TerminateButton)
        Me.WaitPanel.Controls.Add(Me.ProgressBar1)
        Me.WaitPanel.Location = New System.Drawing.Point(90, 171)
        Me.WaitPanel.Name = "WaitPanel"
        Me.WaitPanel.Size = New System.Drawing.Size(427, 75)
        Me.WaitPanel.TabIndex = 83
        Me.WaitPanel.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(17, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(188, 15)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Loading data, please wait ..."
        '
        'TerminateButton
        '
        Me.TerminateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TerminateButton.Location = New System.Drawing.Point(328, 41)
        Me.TerminateButton.Name = "TerminateButton"
        Me.TerminateButton.Size = New System.Drawing.Size(85, 25)
        Me.TerminateButton.TabIndex = 1
        Me.TerminateButton.Text = "Terminate"
        Me.TerminateButton.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(11, 14)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(402, 20)
        Me.ProgressBar1.TabIndex = 0
        '
        'level
        '
        Me.level.Controls.Add(Me.LevelTable)
        Me.level.Controls.Add(Me.LevelGraph)
        Me.level.Location = New System.Drawing.Point(4, 22)
        Me.level.Name = "level"
        Me.level.Padding = New System.Windows.Forms.Padding(3)
        Me.level.Size = New System.Drawing.Size(606, 439)
        Me.level.TabIndex = 1
        Me.level.Text = "Level"
        Me.level.UseVisualStyleBackColor = True
        '
        'LevelTable
        '
        Me.LevelTable.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.LevelTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LevelTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.LevelTable.Location = New System.Drawing.Point(0, 0)
        Me.LevelTable.Name = "LevelTable"
        Me.LevelTable.Size = New System.Drawing.Size(606, 439)
        Me.LevelTable.TabIndex = 84
        Me.LevelTable.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 140
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Time"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 140
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Set Point"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 140
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Level"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 140
        '
        'LevelGraph
        '
        Me.LevelGraph.IsAntiAlias = True
        Me.LevelGraph.IsZoomOnMouseCenter = True
        Me.LevelGraph.Location = New System.Drawing.Point(0, 0)
        Me.LevelGraph.Name = "LevelGraph"
        Me.LevelGraph.ScrollGrace = 0.0R
        Me.LevelGraph.ScrollMaxX = 0.0R
        Me.LevelGraph.ScrollMaxY = 0.0R
        Me.LevelGraph.ScrollMaxY2 = 0.0R
        Me.LevelGraph.ScrollMinX = 0.0R
        Me.LevelGraph.ScrollMinY = 0.0R
        Me.LevelGraph.ScrollMinY2 = 0.0R
        Me.LevelGraph.Size = New System.Drawing.Size(606, 439)
        Me.LevelGraph.TabIndex = 83
        '
        'pressure
        '
        Me.pressure.Controls.Add(Me.pressuretable)
        Me.pressure.Controls.Add(Me.pressuregraph)
        Me.pressure.Location = New System.Drawing.Point(4, 22)
        Me.pressure.Name = "pressure"
        Me.pressure.Size = New System.Drawing.Size(606, 439)
        Me.pressure.TabIndex = 2
        Me.pressure.Text = "Pressure"
        Me.pressure.UseVisualStyleBackColor = True
        '
        'pressuretable
        '
        Me.pressuretable.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.pressuretable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.pressuretable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.pressuretable.Location = New System.Drawing.Point(5, 3)
        Me.pressuretable.Name = "pressuretable"
        Me.pressuretable.Size = New System.Drawing.Size(605, 433)
        Me.pressuretable.TabIndex = 85
        Me.pressuretable.Visible = False
        '
        'pressuregraph
        '
        Me.pressuregraph.IsAntiAlias = True
        Me.pressuregraph.IsZoomOnMouseCenter = True
        Me.pressuregraph.Location = New System.Drawing.Point(2, 3)
        Me.pressuregraph.Name = "pressuregraph"
        Me.pressuregraph.ScrollGrace = 0.0R
        Me.pressuregraph.ScrollMaxX = 0.0R
        Me.pressuregraph.ScrollMaxY = 0.0R
        Me.pressuregraph.ScrollMaxY2 = 0.0R
        Me.pressuregraph.ScrollMinX = 0.0R
        Me.pressuregraph.ScrollMinY = 0.0R
        Me.pressuregraph.ScrollMinY2 = 0.0R
        Me.pressuregraph.Size = New System.Drawing.Size(601, 436)
        Me.pressuregraph.TabIndex = 86
        '
        'flow
        '
        Me.flow.Controls.Add(Me.flowtable)
        Me.flow.Controls.Add(Me.flowgraph)
        Me.flow.Location = New System.Drawing.Point(4, 22)
        Me.flow.Name = "flow"
        Me.flow.Size = New System.Drawing.Size(606, 439)
        Me.flow.TabIndex = 3
        Me.flow.Text = "Flow"
        Me.flow.UseVisualStyleBackColor = True
        '
        'fromdatebox
        '
        Me.fromdatebox.Location = New System.Drawing.Point(121, 476)
        Me.fromdatebox.Mask = "00/00/0000"
        Me.fromdatebox.Name = "fromdatebox"
        Me.fromdatebox.Size = New System.Drawing.Size(73, 20)
        Me.fromdatebox.TabIndex = 2
        '
        'todatebox
        '
        Me.todatebox.Location = New System.Drawing.Point(353, 476)
        Me.todatebox.Mask = "00/00/0000"
        Me.todatebox.Name = "todatebox"
        Me.todatebox.Size = New System.Drawing.Size(73, 20)
        Me.todatebox.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(121, 502)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "(dd/mm/yyyy)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 502)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "HH:mm:ss"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(281, 502)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "HH:mm:ss"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(351, 502)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "(dd/mm/yyyy)"
        '
        'flowtable
        '
        Me.flowtable.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.flowtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.flowtable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.flowtable.Location = New System.Drawing.Point(3, 3)
        Me.flowtable.Name = "flowtable"
        Me.flowtable.Size = New System.Drawing.Size(603, 431)
        Me.flowtable.TabIndex = 87
        Me.flowtable.Visible = False
        '
        'flowgraph
        '
        Me.flowgraph.IsAntiAlias = True
        Me.flowgraph.IsZoomOnMouseCenter = True
        Me.flowgraph.Location = New System.Drawing.Point(3, 1)
        Me.flowgraph.Name = "flowgraph"
        Me.flowgraph.ScrollGrace = 0.0R
        Me.flowgraph.ScrollMaxX = 0.0R
        Me.flowgraph.ScrollMaxY = 0.0R
        Me.flowgraph.ScrollMaxY2 = 0.0R
        Me.flowgraph.ScrollMinX = 0.0R
        Me.flowgraph.ScrollMinY = 0.0R
        Me.flowgraph.ScrollMinY2 = 0.0R
        Me.flowgraph.Size = New System.Drawing.Size(601, 436)
        Me.flowgraph.TabIndex = 88
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 140
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Time"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 140
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Pressure"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 140
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 140
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "Time"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 140
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Flow"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 140
        '
        'search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(620, 566)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.todatebox)
        Me.Controls.Add(Me.fromdatebox)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.searchbtn)
        Me.Controls.Add(Me.clrbtn)
        Me.Controls.Add(Me.tblbtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.resolutionbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.totxtbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fromtxtbox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "search"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search"
        CType(Me.TemperatureTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.temperature.ResumeLayout(False)
        Me.WaitPanel.ResumeLayout(False)
        Me.WaitPanel.PerformLayout()
        Me.level.ResumeLayout(False)
        CType(Me.LevelTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pressure.ResumeLayout(False)
        CType(Me.pressuretable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flow.ResumeLayout(False)
        CType(Me.flowtable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TemperatureTable As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents resolutionbox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents totxtbox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fromtxtbox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TemperatureGraph As ZedGraph.ZedGraphControl
    Friend WithEvents tblbtn As System.Windows.Forms.Button
    Friend WithEvents clrbtn As System.Windows.Forms.Button
    Friend WithEvents searchbtn As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents temperature As System.Windows.Forms.TabPage
    Friend WithEvents level As System.Windows.Forms.TabPage
    Friend WithEvents LevelTable As System.Windows.Forms.DataGridView
    Friend WithEvents LevelGraph As ZedGraph.ZedGraphControl
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fromdatebox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents todatebox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents WaitPanel As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TerminateButton As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents dt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents temp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pressure As System.Windows.Forms.TabPage
    Friend WithEvents pressuretable As System.Windows.Forms.DataGridView
    Friend WithEvents pressuregraph As ZedGraph.ZedGraphControl
    Friend WithEvents flow As System.Windows.Forms.TabPage
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents flowtable As System.Windows.Forms.DataGridView
    Friend WithEvents flowgraph As ZedGraph.ZedGraphControl
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
