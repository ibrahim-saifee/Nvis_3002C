Public Class SetAlarm

    Private Sub LevelAddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LevelAddButton.Click
        Try
            Dim i As Integer = CInt(LevelTextBox.Text)
        Catch
            MessageBox.Show(Me, "Enter proper level value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub LevelTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LevelTextBox.KeyDown, LevelAddButton.KeyDown, LevelRemoveButton.KeyDown, LevelAlarmTable.KeyDown
        If e.KeyData = Keys.Enter And sender Is LevelTextBox Then
            LevelAddButton.PerformClick()
        ElseIf e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub


    Private Sub TemperatureAddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TemperatureAddButton.Click
        Try
            Dim i As Integer = CInt(TemperatureTextBox.Text)
        Catch
            MessageBox.Show(Me, "Enter proper temperature value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        TemperatureAlarmTable.Rows.Add(TemperatureTextBox.Text)
        TemperatureTextBox.Text = ""
    End Sub

    Private Sub TemperatureRemoveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TemperatureRemoveButton.Click
        Dim row As DataGridViewRow
        Try
            row = TemperatureAlarmTable.Rows.Item(TemperatureAlarmTable.SelectedCells.Item(0).RowIndex)
        Catch
            MessageBox.Show(Me, "Row not selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
        TemperatureAlarmTable.Rows.Remove(row)
    End Sub

    Private Sub TemperatureTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TemperatureTextBox.KeyDown, TemperatureAddButton.KeyDown, TemperatureRemoveButton.KeyDown, TemperatureAlarmTable.KeyDown
        If e.KeyData = Keys.Enter And sender Is TemperatureTextBox Then
            TemperatureAddButton.PerformClick()
        ElseIf e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub



    Private Sub PressureAddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PressureAddButton.Click
        Try
            Dim i As Integer = CInt(PressureTextBox.Text)
        Catch
            MessageBox.Show(Me, "Enter proper pressure value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        PressureAlarmTable.Rows.Add(PressureTextBox.Text)
        PressureTextBox.Text = ""
    End Sub

    Private Sub PressureRemoveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PressureRemoveButton.Click
        Dim row As DataGridViewRow
        Try
            row = PressureAlarmTable.Rows.Item(PressureAlarmTable.SelectedCells.Item(0).RowIndex)
        Catch
            MessageBox.Show(Me, "Row not selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End Try
        PressureAlarmTable.Rows.Remove(row)
    End Sub

    Private Sub PressureTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles PressureTextBox.KeyDown, PressureAddButton.KeyDown, PressureRemoveButton.KeyDown, PressureAlarmTable.KeyDown
        If e.KeyData = Keys.Enter And sender Is PressureTextBox Then
            PressureAddButton.PerformClick()
        ElseIf e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub


    Private Sub FlowAddButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlowAddButton.Click
        Try
            Dim i As Integer = CInt(FLowTextBox.Text)
        Catch
            MessageBox.Show(Me, "Enter proper flow value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        FlowAlarmTable.Rows.Add(FLowTextBox.Text)
        FLowTextBox.Text = ""
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

    Private Sub FlowTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FLowTextBox.KeyDown, FlowAddButton.KeyDown, FlowRemoveButton.KeyDown, FlowAlarmTable.KeyDown
        If e.KeyData = Keys.Enter And sender Is FLowTextBox Then
            FlowAddButton.PerformClick()
        ElseIf e.KeyData = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class