Public Class DatabaseConnection

    Dim TestString As String = ""

    Private Sub connbtn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles connbtn.KeyDown
        If e.KeyData = Keys.Enter Then connbtn.PerformClick()
    End Sub

    Private Sub connbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles connbtn.Click
        If servertxtbox.Text = "" Or usertxtbox.Text = "" Or passtxtbox.Text = "" Then
            MessageBox.Show(Me, "Please fill all entries", "Entry Check", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        TestString = "Database=" + MainForm.DatabaseName + ";Data Source=" + servertxtbox.Text + ";User Id=" + usertxtbox.Text + ";Password=" + passtxtbox.Text + ";Allow User Variables=True"
        MainForm.SQLconnection.ConnectionString = TestString.Substring(TestString.IndexOf(";") + 1)
        Try
            MainForm.SQLconnection.Open()
            MainForm.SQLConnection.Close()
            SaveFileConnectionString()
            Me.Close()
        Catch ex As Exception
            If ex.Message.Contains("Access denied") Then
                statuslbl.Visible = True
                statuslbl.Text = "Database Connection Failed"
                connbtn.Text = "Retry"
            End If
        End Try
    End Sub


    Private Sub SaveFileConnectionString()
        Dim FilePath As String = Application.StartupPath + "/SQLConnectionString.txt"
        Try
            If System.IO.File.Exists(FilePath) Then
                Dim FileWriter As New System.IO.StreamWriter(FilePath)
                FileWriter.Write(TestString)
                MainForm.SQLConnectionString = TestString
                MainForm.SQLInitConnectionString = MainForm.SQLConnectionString.Substring(MainForm.SQLConnectionString.IndexOf(";") + 1)
                'frmMain.DatabaseName = frmMain.SQLConnectionString.Substring(frmMain.SQLConnectionString.IndexOf("=") + 1)
                'frmMain.DatabaseName = frmMain.DatabaseName.Substring(0, frmMain.DatabaseName.IndexOf(";"))
                FileWriter.Close()
            Else
                MessageBox.Show(Me, "File SQLConnectionString.txt doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub ignorebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ignorebtn.Click
        Me.Close()
    End Sub

    Private Sub DatabaseConnection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        statuslbl.Visible = False
    End Sub

    Private Sub passtxtbox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles passtxtbox.KeyDown, usertxtbox.KeyDown, servertxtbox.KeyDown
        If e.KeyValue = Keys.Enter Then
            connbtn.PerformClick()
        End If
    End Sub

End Class