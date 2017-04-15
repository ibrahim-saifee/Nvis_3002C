<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatabaseConnection
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatabaseConnection))
        Me.passtxtbox = New System.Windows.Forms.TextBox()
        Me.usertxtbox = New System.Windows.Forms.TextBox()
        Me.servertxtbox = New System.Windows.Forms.TextBox()
        Me.statuslbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.connbtn = New System.Windows.Forms.Button()
        Me.ignorebtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'passtxtbox
        '
        Me.passtxtbox.Location = New System.Drawing.Point(111, 121)
        Me.passtxtbox.Name = "passtxtbox"
        Me.passtxtbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passtxtbox.Size = New System.Drawing.Size(151, 20)
        Me.passtxtbox.TabIndex = 5
        '
        'usertxtbox
        '
        Me.usertxtbox.Location = New System.Drawing.Point(113, 69)
        Me.usertxtbox.Name = "usertxtbox"
        Me.usertxtbox.Size = New System.Drawing.Size(151, 20)
        Me.usertxtbox.TabIndex = 10
        Me.usertxtbox.Text = "root"
        '
        'servertxtbox
        '
        Me.servertxtbox.Location = New System.Drawing.Point(113, 12)
        Me.servertxtbox.Name = "servertxtbox"
        Me.servertxtbox.Size = New System.Drawing.Size(151, 20)
        Me.servertxtbox.TabIndex = 8
        Me.servertxtbox.Text = "localhost"
        '
        'statuslbl
        '
        Me.statuslbl.AutoSize = True
        Me.statuslbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statuslbl.Location = New System.Drawing.Point(2, 226)
        Me.statuslbl.Name = "statuslbl"
        Me.statuslbl.Size = New System.Drawing.Size(162, 15)
        Me.statuslbl.TabIndex = 9
        Me.statuslbl.Text = "Database Connection Failed"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "User Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Server Host"
        '
        'connbtn
        '
        Me.connbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.connbtn.Location = New System.Drawing.Point(40, 174)
        Me.connbtn.Name = "connbtn"
        Me.connbtn.Size = New System.Drawing.Size(86, 33)
        Me.connbtn.TabIndex = 11
        Me.connbtn.Text = "Connect"
        Me.connbtn.UseVisualStyleBackColor = True
        '
        'ignorebtn
        '
        Me.ignorebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ignorebtn.Location = New System.Drawing.Point(155, 174)
        Me.ignorebtn.Name = "ignorebtn"
        Me.ignorebtn.Size = New System.Drawing.Size(86, 33)
        Me.ignorebtn.TabIndex = 12
        Me.ignorebtn.Text = "Ignore"
        Me.ignorebtn.UseVisualStyleBackColor = True
        '
        'DatabaseConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(275, 259)
        Me.Controls.Add(Me.ignorebtn)
        Me.Controls.Add(Me.connbtn)
        Me.Controls.Add(Me.passtxtbox)
        Me.Controls.Add(Me.usertxtbox)
        Me.Controls.Add(Me.servertxtbox)
        Me.Controls.Add(Me.statuslbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DatabaseConnection"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DatabaseConnection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents passtxtbox As System.Windows.Forms.TextBox
    Friend WithEvents usertxtbox As System.Windows.Forms.TextBox
    Friend WithEvents servertxtbox As System.Windows.Forms.TextBox
    Friend WithEvents statuslbl As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents connbtn As System.Windows.Forms.Button
    Friend WithEvents ignorebtn As System.Windows.Forms.Button
End Class
