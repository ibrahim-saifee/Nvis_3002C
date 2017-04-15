Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Threading


Public Class Delete
    Dim SQLConnection As MySqlConnection
    Dim SQLCommand As MySqlCommand
    Dim SQLReader As MySqlDataReader

    Private Sub Delete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        datebox.Text = ""
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = MainForm.SQLConnectionString
    End Sub


    Dim DeleteThread As Thread
    Private Sub Delete()
        Try
            SQLConnection.Open()
            SQLCommand = New MySqlCommand("delete from " + MainForm.DatabaseName + " where date(datetime) like '" + DateTime.Parse(datebox.Text).ToString("yyyy-MM-dd") + "';", SQLConnection)
            SQLCommand.CommandTimeout = 0
            SQLReader = SQLCommand.ExecuteReader()
            SQLReader.Read()
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        SQLConnection.Close()
        Me.Close()
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        Try
            DateTime.Parse(datebox.Text)
        Catch ex As Exception
            MessageBox.Show(Me, "Please enter valid date", "Invalid Expression", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        If MessageBox.Show(Me, "Are you sure you want to delete the selected data", "Confirm Data Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            StatusLabel.Text = "Deleting data, please wait ..."
            DeleteThread = New Thread(AddressOf Delete)
            DeleteThread.IsBackground = True
            DeleteThread.Start()
        End If
    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton1.Click
        Try
            DeleteThread.Abort()
        Catch
        End Try
        Me.Close()
    End Sub

End Class