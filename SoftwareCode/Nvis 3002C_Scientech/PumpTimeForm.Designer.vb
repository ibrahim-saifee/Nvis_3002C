<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PumpTimeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PumpTimeForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PumpTimeTextBox = New System.Windows.Forms.TextBox()
        Me.SetButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pump Time Interval (Sec)"
        '
        'PumpTimeTextBox
        '
        Me.PumpTimeTextBox.Location = New System.Drawing.Point(169, 24)
        Me.PumpTimeTextBox.Name = "PumpTimeTextBox"
        Me.PumpTimeTextBox.Size = New System.Drawing.Size(76, 20)
        Me.PumpTimeTextBox.TabIndex = 1
        '
        'SetButton
        '
        Me.SetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SetButton.Location = New System.Drawing.Point(180, 63)
        Me.SetButton.Name = "SetButton"
        Me.SetButton.Size = New System.Drawing.Size(64, 24)
        Me.SetButton.TabIndex = 2
        Me.SetButton.Text = "Set"
        Me.SetButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 40)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Set Pump ON time interval for Flow process experiment"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Note:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PumpTimeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(257, 149)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SetButton)
        Me.Controls.Add(Me.PumpTimeTextBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PumpTimeForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pump Time Interval"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PumpTimeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SetButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
