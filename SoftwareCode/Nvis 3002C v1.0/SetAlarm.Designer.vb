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
        Me.LevelAlarmTable = New System.Windows.Forms.DataGridView()
        Me.levelvalue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LevelAddButton = New System.Windows.Forms.Button()
        Me.LevelRemoveButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LevelTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TemperatureTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TemperatureAlarmTable = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TemperatureRemoveButton = New System.Windows.Forms.Button()
        Me.TemperatureAddButton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FLowTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FlowAlarmTable = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FlowRemoveButton = New System.Windows.Forms.Button()
        Me.FlowAddButton = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PressureTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PressureAlarmTable = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PressureRemoveButton = New System.Windows.Forms.Button()
        Me.PressureAddButton = New System.Windows.Forms.Button()
        CType(Me.LevelAlarmTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TemperatureAlarmTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.FlowAlarmTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PressureAlarmTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LevelAlarmTable
        '
        Me.LevelAlarmTable.AllowUserToAddRows = False
        Me.LevelAlarmTable.AllowUserToDeleteRows = False
        Me.LevelAlarmTable.AllowUserToResizeColumns = False
        Me.LevelAlarmTable.AllowUserToResizeRows = False
        Me.LevelAlarmTable.BackgroundColor = System.Drawing.Color.White
        Me.LevelAlarmTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.LevelAlarmTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.levelvalue})
        Me.LevelAlarmTable.Location = New System.Drawing.Point(5, 38)
        Me.LevelAlarmTable.Name = "LevelAlarmTable"
        Me.LevelAlarmTable.Size = New System.Drawing.Size(146, 197)
        Me.LevelAlarmTable.TabIndex = 3
        '
        'levelvalue
        '
        Me.levelvalue.HeaderText = "Level"
        Me.levelvalue.Name = "levelvalue"
        '
        'LevelAddButton
        '
        Me.LevelAddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LevelAddButton.Location = New System.Drawing.Point(3, 281)
        Me.LevelAddButton.Name = "LevelAddButton"
        Me.LevelAddButton.Size = New System.Drawing.Size(48, 29)
        Me.LevelAddButton.TabIndex = 2
        Me.LevelAddButton.Text = "Add"
        Me.LevelAddButton.UseVisualStyleBackColor = True
        '
        'LevelRemoveButton
        '
        Me.LevelRemoveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LevelRemoveButton.Location = New System.Drawing.Point(73, 282)
        Me.LevelRemoveButton.Name = "LevelRemoveButton"
        Me.LevelRemoveButton.Size = New System.Drawing.Size(76, 29)
        Me.LevelRemoveButton.TabIndex = 4
        Me.LevelRemoveButton.Text = "Remove"
        Me.LevelRemoveButton.UseVisualStyleBackColor = True
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
        Me.Panel1.Location = New System.Drawing.Point(3, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(159, 322)
        Me.Panel1.TabIndex = 88
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 254)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Level (%)"
        '
        'LevelTextBox
        '
        Me.LevelTextBox.Location = New System.Drawing.Point(85, 253)
        Me.LevelTextBox.Mask = "000"
        Me.LevelTextBox.Name = "LevelTextBox"
        Me.LevelTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.LevelTextBox.Size = New System.Drawing.Size(41, 20)
        Me.LevelTextBox.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 20)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Set Level Alarm"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.TemperatureTextBox)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TemperatureAlarmTable)
        Me.Panel2.Controls.Add(Me.TemperatureRemoveButton)
        Me.Panel2.Controls.Add(Me.TemperatureAddButton)
        Me.Panel2.Location = New System.Drawing.Point(168, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(210, 322)
        Me.Panel2.TabIndex = 89
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 255)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 15)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Temperature (C)"
        '
        'TemperatureTextBox
        '
        Me.TemperatureTextBox.Location = New System.Drawing.Point(132, 253)
        Me.TemperatureTextBox.Mask = "000"
        Me.TemperatureTextBox.Name = "TemperatureTextBox"
        Me.TemperatureTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TemperatureTextBox.Size = New System.Drawing.Size(41, 20)
        Me.TemperatureTextBox.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 20)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "Set Temperature Alarm"
        '
        'TemperatureAlarmTable
        '
        Me.TemperatureAlarmTable.AllowUserToAddRows = False
        Me.TemperatureAlarmTable.AllowUserToDeleteRows = False
        Me.TemperatureAlarmTable.AllowUserToResizeColumns = False
        Me.TemperatureAlarmTable.AllowUserToResizeRows = False
        Me.TemperatureAlarmTable.BackgroundColor = System.Drawing.Color.White
        Me.TemperatureAlarmTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.TemperatureAlarmTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.TemperatureAlarmTable.Location = New System.Drawing.Point(31, 38)
        Me.TemperatureAlarmTable.Name = "TemperatureAlarmTable"
        Me.TemperatureAlarmTable.Size = New System.Drawing.Size(146, 197)
        Me.TemperatureAlarmTable.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Temperature"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'TemperatureRemoveButton
        '
        Me.TemperatureRemoveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TemperatureRemoveButton.Location = New System.Drawing.Point(97, 281)
        Me.TemperatureRemoveButton.Name = "TemperatureRemoveButton"
        Me.TemperatureRemoveButton.Size = New System.Drawing.Size(76, 31)
        Me.TemperatureRemoveButton.TabIndex = 8
        Me.TemperatureRemoveButton.Text = "Remove"
        Me.TemperatureRemoveButton.UseVisualStyleBackColor = True
        '
        'TemperatureAddButton
        '
        Me.TemperatureAddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TemperatureAddButton.Location = New System.Drawing.Point(27, 281)
        Me.TemperatureAddButton.Name = "TemperatureAddButton"
        Me.TemperatureAddButton.Size = New System.Drawing.Size(48, 31)
        Me.TemperatureAddButton.TabIndex = 6
        Me.TemperatureAddButton.Text = "Add"
        Me.TemperatureAddButton.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.FLowTextBox)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.FlowAlarmTable)
        Me.Panel3.Controls.Add(Me.FlowRemoveButton)
        Me.Panel3.Controls.Add(Me.FlowAddButton)
        Me.Panel3.Location = New System.Drawing.Point(563, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(195, 322)
        Me.Panel3.TabIndex = 92
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 15)
        Me.Label5.TabIndex = 91
        Me.Label5.Text = "Temperature (C)"
        '
        'FLowTextBox
        '
        Me.FLowTextBox.Location = New System.Drawing.Point(132, 253)
        Me.FLowTextBox.Mask = "000"
        Me.FLowTextBox.Name = "FLowTextBox"
        Me.FLowTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.FLowTextBox.Size = New System.Drawing.Size(41, 20)
        Me.FLowTextBox.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 20)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Set Flow Alarm"
        '
        'FlowAlarmTable
        '
        Me.FlowAlarmTable.AllowUserToAddRows = False
        Me.FlowAlarmTable.AllowUserToDeleteRows = False
        Me.FlowAlarmTable.AllowUserToResizeColumns = False
        Me.FlowAlarmTable.AllowUserToResizeRows = False
        Me.FlowAlarmTable.BackgroundColor = System.Drawing.Color.White
        Me.FlowAlarmTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.FlowAlarmTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.FlowAlarmTable.Location = New System.Drawing.Point(31, 38)
        Me.FlowAlarmTable.Name = "FlowAlarmTable"
        Me.FlowAlarmTable.Size = New System.Drawing.Size(146, 197)
        Me.FlowAlarmTable.TabIndex = 7
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Temperature"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'FlowRemoveButton
        '
        Me.FlowRemoveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowRemoveButton.Location = New System.Drawing.Point(97, 281)
        Me.FlowRemoveButton.Name = "FlowRemoveButton"
        Me.FlowRemoveButton.Size = New System.Drawing.Size(76, 31)
        Me.FlowRemoveButton.TabIndex = 8
        Me.FlowRemoveButton.Text = "Remove"
        Me.FlowRemoveButton.UseVisualStyleBackColor = True
        '
        'FlowAddButton
        '
        Me.FlowAddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowAddButton.Location = New System.Drawing.Point(27, 281)
        Me.FlowAddButton.Name = "FlowAddButton"
        Me.FlowAddButton.Size = New System.Drawing.Size(48, 31)
        Me.FlowAddButton.TabIndex = 6
        Me.FlowAddButton.Text = "Add"
        Me.FlowAddButton.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.PressureTextBox)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.PressureAlarmTable)
        Me.Panel4.Controls.Add(Me.PressureRemoveButton)
        Me.Panel4.Controls.Add(Me.PressureAddButton)
        Me.Panel4.Location = New System.Drawing.Point(383, 6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(174, 322)
        Me.Panel4.TabIndex = 91
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 15)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Level (%)"
        '
        'PressureTextBox
        '
        Me.PressureTextBox.Location = New System.Drawing.Point(85, 253)
        Me.PressureTextBox.Mask = "000"
        Me.PressureTextBox.Name = "PressureTextBox"
        Me.PressureTextBox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.PressureTextBox.Size = New System.Drawing.Size(41, 20)
        Me.PressureTextBox.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(164, 20)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "Set Pressure Alarm"
        '
        'PressureAlarmTable
        '
        Me.PressureAlarmTable.AllowUserToAddRows = False
        Me.PressureAlarmTable.AllowUserToDeleteRows = False
        Me.PressureAlarmTable.AllowUserToResizeColumns = False
        Me.PressureAlarmTable.AllowUserToResizeRows = False
        Me.PressureAlarmTable.BackgroundColor = System.Drawing.Color.White
        Me.PressureAlarmTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.PressureAlarmTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3})
        Me.PressureAlarmTable.Location = New System.Drawing.Point(11, 38)
        Me.PressureAlarmTable.Name = "PressureAlarmTable"
        Me.PressureAlarmTable.Size = New System.Drawing.Size(146, 197)
        Me.PressureAlarmTable.TabIndex = 3
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Level"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'PressureRemoveButton
        '
        Me.PressureRemoveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressureRemoveButton.Location = New System.Drawing.Point(73, 282)
        Me.PressureRemoveButton.Name = "PressureRemoveButton"
        Me.PressureRemoveButton.Size = New System.Drawing.Size(76, 29)
        Me.PressureRemoveButton.TabIndex = 4
        Me.PressureRemoveButton.Text = "Remove"
        Me.PressureRemoveButton.UseVisualStyleBackColor = True
        '
        'PressureAddButton
        '
        Me.PressureAddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressureAddButton.Location = New System.Drawing.Point(3, 281)
        Me.PressureAddButton.Name = "PressureAddButton"
        Me.PressureAddButton.Size = New System.Drawing.Size(48, 29)
        Me.PressureAddButton.TabIndex = 2
        Me.PressureAddButton.Text = "Add"
        Me.PressureAddButton.UseVisualStyleBackColor = True
        '
        'SetAlarm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(763, 331)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SetAlarm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SetAlarm"
        CType(Me.LevelAlarmTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TemperatureAlarmTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.FlowAlarmTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PressureAlarmTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LevelAlarmTable As System.Windows.Forms.DataGridView
    Friend WithEvents LevelAddButton As System.Windows.Forms.Button
    Friend WithEvents LevelRemoveButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TemperatureAlarmTable As System.Windows.Forms.DataGridView
    Friend WithEvents TemperatureRemoveButton As System.Windows.Forms.Button
    Friend WithEvents TemperatureAddButton As System.Windows.Forms.Button
    Friend WithEvents levelvalue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LevelTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents TemperatureTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents FLowTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents FlowAlarmTable As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FlowRemoveButton As System.Windows.Forms.Button
    Friend WithEvents FlowAddButton As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PressureTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PressureAlarmTable As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PressureRemoveButton As System.Windows.Forms.Button
    Friend WithEvents PressureAddButton As System.Windows.Forms.Button
End Class
