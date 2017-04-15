Public Class SetAlarm

    Private Sub AddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddButton.Click
        Try
            Dim i As Integer = CInt(FlowTextBox.Text)
        Catch
            MessageBox.Show(Me, "Enter proper temperature value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        FlowAlarmTable.Rows.Add(FlowTextBox.Text)
        FlowTextBox.Text = ""
    End Sub

    Private Sub RemoveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveButton.Click
        Dim row As DataGridViewRow
        Try
            row = FlowAlarmTable.Rows.Item(FlowAlarmTable.SelectedCells.Item(0).RowIndex)
        Catch
            MessageBox.Show(Me, "Row not selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
        FlowAlarmTable.Rows.Remove(row)
    End Sub

    Private Sub _KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FlowTextBox.KeyDown, AddButton.KeyDown, RemoveButton.KeyDown, FlowAlarmTable.KeyDown
        If e.KeyData = Keys.Enter And sender Is FlowTextBox Then
            AddButton.PerformClick()
        ElseIf e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class