Public Class SetAlarm

    Private Sub FlowAddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowAddButton.Click
        Try
            Dim i As Integer = CInt(FlowTextBox.Text)
        Catch
            MessageBox.Show(Me, "Enter proper Flow value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        FlowAlarmTable.Rows.Add(FlowTextBox.Text)
        FlowTextBox.Text = ""
    End Sub

    Private Sub FlowRemoveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowRemoveButton.Click
        Dim row As DataGridViewRow
        Try
            row = FlowAlarmTable.Rows.Item(FlowAlarmTable.SelectedCells.Item(0).RowIndex)
        Catch
            MessageBox.Show(Me, "Row not selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
        FlowAlarmTable.Rows.Remove(row)
    End Sub

    Private Sub Flow_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FlowTextBox.KeyDown, FlowAddButton.KeyDown, FlowRemoveButton.KeyDown, FlowAlarmTable.KeyDown
        If e.KeyData = Keys.Enter And sender Is FlowTextBox Then
            FlowAddButton.PerformClick()
        ElseIf e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub LevelAddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LevelAddButton.Click
        Try
            Dim i As Integer = CInt(LevelTextBox.Text)
        Catch
            MessageBox.Show(Me, "Enter proper Level value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        LevelAlarmTable.Rows.Add(LevelTextBox.Text)
        LevelTextBox.Text = ""
    End Sub

    Private Sub LevelRemoveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LevelRemoveButton.Click
        Dim row As DataGridViewRow
        Try
            row = LevelAlarmTable.Rows.Item(LevelAlarmTable.SelectedCells.Item(0).RowIndex)
        Catch
            MessageBox.Show(Me, "Row not selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
        LevelAlarmTable.Rows.Remove(row)
    End Sub

    Private Sub Level_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LevelTextBox.KeyDown, LevelAddButton.KeyDown, LevelRemoveButton.KeyDown, LevelAlarmTable.KeyDown
        If e.KeyData = Keys.Enter And sender Is LevelTextBox Then
            LevelAddButton.PerformClick()
        ElseIf e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class