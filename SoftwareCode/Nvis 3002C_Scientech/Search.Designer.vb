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
        Me.WaitPanel.SuspendLayout()
        CType(Me.FlowTable, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.WaitPanel.Location = New System.Drawing.Point(109, 219)
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
        Me.FlowTable.Size = New System.Drawing.Size(616, 459)
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
        Me.FlowGraph.Size = New System.Drawing.Size(616, 459)
        Me.FlowGraph.TabIndex = 91
        '
        'search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(620, 566)
        Me.Controls.Add(Me.WaitPanel)
        Me.Controls.Add(Me.FlowTable)
        Me.Controls.Add(Me.FlowGraph)
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
End Class
