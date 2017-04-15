Public Class ControlSettingsForm

    
    'Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles openloopradio.CheckedChanged, closeloopradio.CheckedChanged
    '    If openloopradio.Checked = True Then
    '        ONOFFPIDgroup.Enabled = False
    '    ElseIf closeloopradio.Checked = True Then
    '        ONOFFPIDgroup.Enabled = True
    '        onoffradio.Checked = True
    '    End If
    'End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles piradio.CheckedChanged, pidradio.CheckedChanged, pradio.CheckedChanged
        If pradio.Checked = True Then
            KpTrackBar.Visible = True
            TiTrackBar.Visible = False
            TdTrackBar.Visible = False
        ElseIf piradio.Checked = True Then
            KpTrackBar.Visible = True
            TiTrackBar.Visible = True
            TdTrackBar.Visible = False
        ElseIf pidradio.Checked = True Then
            KpTrackBar.Visible = True
            TiTrackBar.Visible = True
            TdTrackBar.Visible = True
        End If
    End Sub



    Private Sub trackbar_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles KpTrackBar.VisibleChanged, TiTrackBar.VisibleChanged, TdTrackBar.VisibleChanged
        kplbl.Visible = Kptrackbar.Visible
        tilbl.Visible = titrackbar.Visible
        tdlbl.Visible = tdtrackbar.Visible
        KpTextBox.Visible = Kptrackbar.Visible
        TiTextBox.Visible = titrackbar.Visible
        TdTextBox.Visible = tdtrackbar.Visible
    End Sub


    Private Sub Kptrackbar__ValueChanged(ByVal Sender As Object, ByVal ValeurTrackBar As Integer) Handles KpTrackBar._ValueChanged, TiTrackBar._ValueChanged, TdTrackBar._ValueChanged
        'MainForm.ProportionalConstant = FormatNumber(KpTrackBar._Valeur / 100, 3)
        'MainForm.IntegralConstant = FormatNumber((KpTrackBar._Valeur / TiTrackBar._Valeur) / 100, 3)
        'MainForm.DerivativeConstant = FormatNumber((KpTrackBar._Valeur * TdTrackBar._Valeur), 3)
        KpTextBox.Text = Kptrackbar._Valeur.ToString("000")
        TiTextBox.Text = titrackbar._Valeur.ToString("000")
        TdTextBox.Text = tdtrackbar._Valeur.ToString("000")
    End Sub


    Private Sub hysterisisupdn_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'MainForm.Hysterisis = hysterisisupdn.Value
    End Sub


    Private Sub KpTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles KpTextBox.KeyDown
        If e.KeyData = Keys.Enter Then
            Dim value As Integer
            Try
                value = CInt(KpTextBox.Text)
            Catch
                MessageBox.Show(Me, "Please enter proper value", "Invalid Expression", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            If value >= 0 And value <= 100 Then
                Kptrackbar._Valeur = value
            End If
        End If
    End Sub

    Private Sub TdTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TdTextBox.KeyDown
        If e.KeyData = Keys.Enter Then
            Dim value As Integer
            Try
                value = CInt(TdTextBox.Text)
            Catch
                MessageBox.Show(Me, "Please enter proper value", "Invalid Expression", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            If value >= 0 And value <= 120 Then
                tdtrackbar._Valeur = value
            End If
        End If
    End Sub

    Private Sub TiTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TiTextBox.KeyDown
        If e.KeyData = Keys.Enter Then
            Dim value As Integer
            Try
                value = CInt(TiTextBox.Text)
            Catch
                MessageBox.Show(Me, "Please enter proper value", "Invalid Expression", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            If value >= 0 And value <= 120 Then
                titrackbar._Valeur = value
            End If
        End If
    End Sub

    Private Sub SetButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SetButton.Click
        MainForm.ProportionalConstant = FormatNumber(KpTrackBar._Valeur / 100, 3)
        MainForm.IntegralConstant = FormatNumber((KpTrackBar._Valeur / TiTrackBar._Valeur) / 100, 3)
        MainForm.DerivativeConstant = FormatNumber((KpTrackBar._Valeur * TdTrackBar._Valeur), 3)
        Me.Close()
    End Sub

    Private Sub ControlSettingsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'pradio.Checked = True
    End Sub
End Class