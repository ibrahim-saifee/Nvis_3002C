<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Delete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Delete))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.delbtn = New System.Windows.Forms.Button()
        Me.datebox = New System.Windows.Forms.MaskedTextBox()
        Me.CancelButton1 = New System.Windows.Forms.Button()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowDeleteCheckBox = New System.Windows.Forms.CheckBox()
        Me.LevelDeleteCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select Date"
        '
        'DeleteButton
        '
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(191, 88)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(83, 30)
        Me.DeleteButton.TabIndex = 4
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'delbtn
        '
        Me.delbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delbtn.Location = New System.Drawing.Point(257, 16)
        Me.delbtn.Name = "delbtn"
        Me.delbtn.Size = New System.Drawing.Size(83, 30)
        Me.delbtn.TabIndex = 4
        Me.delbtn.Text = "Delete"
        Me.delbtn.UseVisualStyleBackColor = True
        '
        'datebox
        '
        Me.datebox.Location = New System.Drawing.Point(99, 90)
        Me.datebox.Mask = "00/00/0000"
        Me.datebox.Name = "datebox"
        Me.datebox.Size = New System.Drawing.Size(76, 20)
        Me.datebox.TabIndex = 5
        '
        'CancelButton1
        '
        Me.CancelButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton1.Location = New System.Drawing.Point(191, 124)
        Me.CancelButton1.Name = "CancelButton1"
        Me.CancelButton1.Size = New System.Drawing.Size(83, 32)
        Me.CancelButton1.TabIndex = 6
        Me.CancelButton1.Text = "Cancel"
        Me.CancelButton1.UseVisualStyleBackColor = True
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.Location = New System.Drawing.Point(6, 147)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(13, 13)
        Me.StatusLabel.TabIndex = 7
        Me.StatusLabel.Text = "  "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(99, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "(dd/mm/yyyy)"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.StatusLabel)
        Me.Panel1.Controls.Add(Me.LevelDeleteCheckBox)
        Me.Panel1.Controls.Add(Me.FlowDeleteCheckBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.DeleteButton)
        Me.Panel1.Controls.Add(Me.datebox)
        Me.Panel1.Controls.Add(Me.CancelButton1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(286, 168)
        Me.Panel1.TabIndex = 89
        '
        'FlowDeleteCheckBox
        '
        Me.FlowDeleteCheckBox.AutoSize = True
        Me.FlowDeleteCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowDeleteCheckBox.Location = New System.Drawing.Point(84, 15)
        Me.FlowDeleteCheckBox.Name = "FlowDeleteCheckBox"
        Me.FlowDeleteCheckBox.Size = New System.Drawing.Size(129, 19)
        Me.FlowDeleteCheckBox.TabIndex = 89
        Me.FlowDeleteCheckBox.Text = "Water Flow data"
        Me.FlowDeleteCheckBox.UseVisualStyleBackColor = True
        '
        'LevelDeleteCheckBox
        '
        Me.LevelDeleteCheckBox.AutoSize = True
        Me.LevelDeleteCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LevelDeleteCheckBox.Location = New System.Drawing.Point(84, 40)
        Me.LevelDeleteCheckBox.Name = "LevelDeleteCheckBox"
        Me.LevelDeleteCheckBox.Size = New System.Drawing.Size(133, 19)
        Me.LevelDeleteCheckBox.TabIndex = 90
        Me.LevelDeleteCheckBox.Text = "Water Level data"
        Me.LevelDeleteCheckBox.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Delete :"
        '
        'Delete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(314, 192)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Delete"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Delete"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents delbtn As System.Windows.Forms.Button
    Friend WithEvents datebox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents CancelButton1 As System.Windows.Forms.Button
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LevelDeleteCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents FlowDeleteCheckBox As System.Windows.Forms.CheckBox
End Class
