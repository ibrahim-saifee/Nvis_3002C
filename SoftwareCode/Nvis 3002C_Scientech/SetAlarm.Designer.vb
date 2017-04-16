<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetAlarm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetAlarm))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FlowTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FlowAlarmTable = New System.Windows.Forms.DataGridView()
        Me.FlowColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowRemoveButton = New System.Windows.Forms.Button()
        Me.FlowAddButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LevelTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LevelAlarmTable = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LevelRemoveButton = New System.Windows.Forms.Button()
        Me.LevelAddButton = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.FlowAlarmTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.LevelAlarmTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.FlowTextBox)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.FlowAlarmTable)
        Me.Panel2.Controls.Add(Me.FlowRemoveButton)
        Me.Panel2.Controls.Add(Me.FlowAddButton)
        Me.Panel2.Location = New System.Drawing.Point(12, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(260, 248)
        Me.Panel2.TabIndex = 89
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(162, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 15)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Flow (Ltr/min)"
        '
        'FlowTextBox
        '
        Me.FlowTextBox.Location = New System.Drawing.Point(173, 97)
        Me.FlowTextBox.Mask = "000"
        Me.FlowTextBox.Name = "FlowTextBox"
        Me.FlowTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.FlowTextBox.Size = New System.Drawing.Size(76, 20)
        Me.FlowTextBox.TabIndex = 5
        Me.FlowTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 15)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Set Alarm at different Flow values"
        '
        'FlowAlarmTable
        '
        Me.FlowAlarmTable.AllowUserToAddRows = False
        Me.FlowAlarmTable.AllowUserToDeleteRows = False
        Me.FlowAlarmTable.AllowUserToResizeColumns = False
        Me.FlowAlarmTable.AllowUserToResizeRows = False
        Me.FlowAlarmTable.BackgroundColor = System.Drawing.Color.White
        Me.FlowAlarmTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.FlowAlarmTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FlowColumn})
        Me.FlowAlarmTable.Location = New System.Drawing.Point(14, 36)
        Me.FlowAlarmTable.Name = "FlowAlarmTable"
        Me.FlowAlarmTable.Size = New System.Drawing.Size(146, 197)
        Me.FlowAlarmTable.TabIndex = 7
        '
        'FlowColumn
        '
        Me.FlowColumn.HeaderText = "Flow"
        Me.FlowColumn.Name = "FlowColumn"
        '
        'FlowRemoveButton
        '
        Me.FlowRemoveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowRemoveButton.Location = New System.Drawing.Point(173, 178)
        Me.FlowRemoveButton.Name = "FlowRemoveButton"
        Me.FlowRemoveButton.Size = New System.Drawing.Size(76, 31)
        Me.FlowRemoveButton.TabIndex = 8
        Me.FlowRemoveButton.Text = "Remove"
        Me.FlowRemoveButton.UseVisualStyleBackColor = True
        '
        'FlowAddButton
        '
        Me.FlowAddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowAddButton.Location = New System.Drawing.Point(173, 132)
        Me.FlowAddButton.Name = "FlowAddButton"
        Me.FlowAddButton.Size = New System.Drawing.Size(76, 31)
        Me.FlowAddButton.TabIndex = 6
        Me.FlowAddButton.Text = "Add"
        Me.FlowAddButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LevelTextBox)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.LevelAlarmTable)
        Me.Panel1.Controls.Add(Me.LevelRemoveButton)
        Me.Panel1.Controls.Add(Me.LevelAddButton)
        Me.Panel1.Location = New System.Drawing.Point(278, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(260, 248)
        Me.Panel1.TabIndex = 92
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(182, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "Level (%)"
        '
        'LevelTextBox
        '
        Me.LevelTextBox.Location = New System.Drawing.Point(173, 97)
        Me.LevelTextBox.Mask = "000"
        Me.LevelTextBox.Name = "LevelTextBox"
        Me.LevelTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.LevelTextBox.Size = New System.Drawing.Size(76, 20)
        Me.LevelTextBox.TabIndex = 5
        Me.LevelTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(225, 15)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Set Alarm at different Level values"
        '
        'LevelAlarmTable
        '
        Me.LevelAlarmTable.AllowUserToAddRows = False
        Me.LevelAlarmTable.AllowUserToDeleteRows = False
        Me.LevelAlarmTable.AllowUserToResizeColumns = False
        Me.LevelAlarmTable.AllowUserToResizeRows = False
        Me.LevelAlarmTable.BackgroundColor = System.Drawing.Color.White
        Me.LevelAlarmTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.LevelAlarmTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.LevelAlarmTable.Location = New System.Drawing.Point(14, 36)
        Me.LevelAlarmTable.Name = "LevelAlarmTable"
        Me.LevelAlarmTable.Size = New System.Drawing.Size(146, 197)
        Me.LevelAlarmTable.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Level"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'LevelRemoveButton
        '
        Me.LevelRemoveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LevelRemoveButton.Location = New System.Drawing.Point(173, 178)
        Me.LevelRemoveButton.Name = "LevelRemoveButton"
        Me.LevelRemoveButton.Size = New System.Drawing.Size(76, 31)
        Me.LevelRemoveButton.TabIndex = 8
        Me.LevelRemoveButton.Text = "Remove"
        Me.LevelRemoveButton.UseVisualStyleBackColor = True
        '
        'LevelAddButton
        '
        Me.LevelAddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LevelAddButton.Location = New System.Drawing.Point(173, 132)
        Me.LevelAddButton.Name = "LevelAddButton"
        Me.LevelAddButton.Size = New System.Drawing.Size(76, 31)
        Me.LevelAddButton.TabIndex = 6
        Me.LevelAddButton.Text = "Add"
        Me.LevelAddButton.UseVisualStyleBackColor = True
        '
        'SetAlarm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(550, 258)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SetAlarm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Alarm Settings"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.FlowAlarmTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LevelAlarmTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FlowAlarmTable As System.Windows.Forms.DataGridView
    Friend WithEvents FlowRemoveButton As System.Windows.Forms.Button
    Friend WithEvents FlowAddButton As System.Windows.Forms.Button
    Friend WithEvents FlowTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FlowColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LevelTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LevelAlarmTable As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LevelRemoveButton As System.Windows.Forms.Button
    Friend WithEvents LevelAddButton As System.Windows.Forms.Button
End Class
