Public Class PumpTimeForm

    Private Sub SetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetButton.Click
        Dim Interval As Integer = 0
        Try
            Interval = CInt(PumpTimeTextBox.Text) * 1000
            MainForm.PumpTimer.Interval = Interval
        Catch ex As Exception
            MessageBox.Show(Me, "Please enter valid time value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        Me.Close()
    End Sub

    Private Sub PumpTimeForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PumpTimeTextBox.Text = MainForm.PumpTimer.Interval / 1000
    End Sub

End Class