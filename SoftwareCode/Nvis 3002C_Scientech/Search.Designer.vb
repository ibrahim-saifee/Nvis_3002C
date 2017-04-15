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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(search))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.resolutionbox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.totxtbox = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fromtxtbox = New System.Windows.Forms.MaskedTextBox()
        Me.tblbtn = New System.Windows.Forms.Button()
        Me.clrbtn = New System.Windows.Forms.Button()
        Me.searchbtn = New System.Windows.Forms.Button()
        Me.WaitPanel = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TerminateButton = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.fromdatebox = New System.Windows.Forms.MaskedTextBox()
        Me.todatebox = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FlowTable = New System.Windows.Forms.DataGridView()
        Me.dt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.flow = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowGraph = New ZedGraph.ZedGraphControl()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.FlowTab = New System.Windows.Forms.TabPage()
        Me.LevelTab = New System.Windows.Forms.TabPage()
        Me.LevelTable = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LevelGraph = New ZedGraph.ZedGraphControl()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LevelSearchCheckBox = New System.Windows.Forms.CheckBox()
        Me.FlowSearchCheckBox = New System.Windows.Forms.CheckBox()
        Me.WaitPanel.SuspendLayout()
        CType(Me.FlowTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.FlowTab.SuspendLayout()
        Me.LevelTab.SuspendLayout()
        CType(Me.LevelTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Label2.Location = New System.Drawing.Point(245, 478)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 15)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "To :"
        '
        'totxtbox
        '
        Me.totxtbox.Location = New System.Drawing.Point(282, 477)
        Me.totxtbox.Mask = "00:00:00"
        Me.totxtbox.Name = "totxtbox"
        Me.totxtbox.Size = New System.Drawing.Size(51, 20)
        Me.totxtbox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 477)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "From :"
        '
        'fromtxtbox
        '
        Me.fromtxtbox.Location = New System.Drawing.Point(62, 476)
        Me.fromtxtbox.Mask = "00:00:00"
        Me.fromtxtbox.Name = "fromtxtbox"
        Me.fromtxtbox.Size = New System.Drawing.Size(51, 20)
        Me.fromtxtbox.TabIndex = 1
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
        'WaitPanel
        '
        Me.WaitPanel.Controls.Add(Me.Label8)
        Me.WaitPanel.Controls.Add(Me.TerminateButton)
        Me.WaitPanel.Controls.Add(Me.ProgressBar1)
        Me.WaitPanel.Location = New System.Drawing.Point(99, 211)
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
        'fromdatebox
        '
        Me.fromdatebox.Location = New System.Drawing.Point(129, 476)
        Me.fromdatebox.Mask = "00/00/0000"
        Me.fromdatebox.Name = "fromdatebox"
        Me.fromdatebox.Size = New System.Drawing.Size(73, 20)
        Me.fromdatebox.TabIndex = 2
        '
        'todatebox
        '
        Me.todatebox.Location = New System.Drawing.Point(351, 476)
        Me.todatebox.Mask = "00/00/0000"
        Me.todatebox.Name = "todatebox"
        Me.todatebox.Size = New System.Drawing.Size(73, 20)
        Me.todatebox.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(129, 502)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "(dd/mm/yyyy)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(59, 502)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "HH:mm:ss"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(279, 502)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "HH:mm:ss"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(349, 502)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "(dd/mm/yyyy)"
        '
        'FlowTable
        '
        Me.FlowTable.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.FlowTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FlowTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dt, Me.tm, Me.sp, Me.flow})
        Me.FlowTable.Location = New System.Drawing.Point(2, 2)
        Me.FlowTable.Name = "FlowTable"
        Me.FlowTable.Size = New System.Drawing.Size(605, 430)
        Me.FlowTable.TabIndex = 92
        Me.FlowTable.Visible = False
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
        'flow
        '
        Me.flow.HeaderText = "Flow"
        Me.flow.Name = "flow"
        Me.flow.Width = 140
        '
        'FlowGraph
        '
        Me.FlowGraph.IsAntiAlias = True
        Me.FlowGraph.IsZoomOnMouseCenter = True
        Me.FlowGraph.Location = New System.Drawing.Point(2, 2)
        Me.FlowGraph.Name = "FlowGraph"
        Me.FlowGraph.ScrollGrace = 0.0R
        Me.FlowGraph.ScrollMaxX = 0.0R
        Me.FlowGraph.ScrollMaxY = 0.0R
        Me.FlowGraph.ScrollMaxY2 = 0.0R
        Me.FlowGraph.ScrollMinX = 0.0R
        Me.FlowGraph.ScrollMinY = 0.0R
        Me.FlowGraph.ScrollMinY2 = 0.0R
        Me.FlowGraph.Size = New System.Drawing.Size(605, 430)
        Me.FlowGraph.TabIndex = 91
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.FlowTab)
        Me.TabControl1.Controls.Add(Me.LevelTab)
        Me.TabControl1.Location = New System.Drawing.Point(2, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(617, 456)
        Me.TabControl1.TabIndex = 93
        '
        'FlowTab
        '
        Me.FlowTab.Controls.Add(Me.FlowTable)
        Me.FlowTab.Controls.Add(Me.FlowGraph)
        Me.FlowTab.Location = New System.Drawing.Point(4, 22)
        Me.FlowTab.Name = "FlowTab"
        Me.FlowTab.Padding = New System.Windows.Forms.Padding(3)
        Me.FlowTab.Size = New System.Drawing.Size(609, 430)
        Me.FlowTab.TabIndex = 0
        Me.FlowTab.Text = "Flow"
        Me.FlowTab.UseVisualStyleBackColor = True
        '
        'LevelTab
        '
        Me.LevelTab.Controls.Add(Me.LevelTable)
        Me.LevelTab.Controls.Add(Me.LevelGraph)
        Me.LevelTab.Location = New System.Drawing.Point(4, 22)
        Me.LevelTab.Name = "LevelTab"
        Me.LevelTab.Padding = New System.Windows.Forms.Padding(3)
        Me.LevelTab.Size = New System.Drawing.Size(609, 430)
        Me.LevelTab.TabIndex = 1
        Me.LevelTab.Text = "Level"
        Me.LevelTab.UseVisualStyleBackColor = True
        '
        'LevelTable
        '
        Me.LevelTable.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.LevelTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LevelTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.LevelTable.Location = New System.Drawing.Point(2, 2)
        Me.LevelTable.Name = "LevelTable"
        Me.LevelTable.Size = New System.Drawing.Size(605, 430)
        Me.LevelTable.TabIndex = 94
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
        Me.LevelGraph.Location = New System.Drawing.Point(2, 2)
        Me.LevelGraph.Name = "LevelGraph"
        Me.LevelGraph.ScrollGrace = 0.0R
        Me.LevelGraph.ScrollMaxX = 0.0R
        Me.LevelGraph.ScrollMaxY = 0.0R
        Me.LevelGraph.ScrollMaxY2 = 0.0R
        Me.LevelGraph.ScrollMinX = 0.0R
        Me.LevelGraph.ScrollMinY = 0.0R
        Me.LevelGraph.ScrollMinY2 = 0.0R
        Me.LevelGraph.Size = New System.Drawing.Size(605, 430)
        Me.LevelGraph.TabIndex = 93
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 539)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 15)
        Me.Label9.TabIndex = 96
        Me.Label9.Text = "Search :"
        '
        'LevelSearchCheckBox
        '
        Me.LevelSearchCheckBox.AutoSize = True
        Me.LevelSearchCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LevelSearchCheckBox.Location = New System.Drawing.Point(168, 541)
        Me.LevelSearchCheckBox.Name = "LevelSearchCheckBox"
        Me.LevelSearchCheckBox.Size = New System.Drawing.Size(92, 19)
        Me.LevelSearchCheckBox.TabIndex = 95
        Me.LevelSearchCheckBox.Text = "Level data"
        Me.LevelSearchCheckBox.UseVisualStyleBackColor = True
        '
        'FlowSearchCheckBox
        '
        Me.FlowSearchCheckBox.AutoSize = True
        Me.FlowSearchCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowSearchCheckBox.Location = New System.Drawing.Point(74, 540)
        Me.FlowSearchCheckBox.Name = "FlowSearchCheckBox"
        Me.FlowSearchCheckBox.Size = New System.Drawing.Size(88, 19)
        Me.FlowSearchCheckBox.TabIndex = 94
        Me.FlowSearchCheckBox.Text = "Flow data"
        Me.FlowSearchCheckBox.UseVisualStyleBackColor = True
        '
        'search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(620, 571)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LevelSearchCheckBox)
        Me.Controls.Add(Me.FlowSearchCheckBox)
        Me.Controls.Add(Me.WaitPanel)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.todatebox)
        Me.Controls.Add(Me.fromdatebox)
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
        Me.WaitPanel.ResumeLayout(False)
        Me.WaitPanel.PerformLayout()
        CType(Me.FlowTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.FlowTab.ResumeLayout(False)
        Me.LevelTab.ResumeLayout(False)
        CType(Me.LevelTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents resolutionbox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents totxtbox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fromtxtbox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tblbtn As System.Windows.Forms.Button
    Friend WithEvents clrbtn As System.Windows.Forms.Button
    Friend WithEvents searchbtn As System.Windows.Forms.Button
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
    Friend WithEvents FlowTable As System.Windows.Forms.DataGridView
    Friend WithEvents FlowGraph As ZedGraph.ZedGraphControl
    Friend WithEvents dt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tm As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents flow As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents FlowTab As System.Windows.Forms.TabPage
    Friend WithEvents LevelTab As System.Windows.Forms.TabPage
    Friend WithEvents LevelTable As System.Windows.Forms.DataGridView
    Friend WithEvents LevelGraph As ZedGraph.ZedGraphControl
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents LevelSearchCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FlowSearchCheckBox As System.Windows.Forms.CheckBox
End Class
