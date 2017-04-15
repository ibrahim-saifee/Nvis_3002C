Public Class TTSettings


    Private Sub CloseLoopRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseLoopRadio.CheckedChanged, OpenLoopRadio.CheckedChanged
        If OpenLoopRadio.Checked Then
            CloseLoopRadio.Checked = False
            OnOffPIDGroup.Enabled = False
        ElseIf CloseLoopRadio.Checked Then
            OpenLoopRadio.Checked = False
            OnOffPIDGroup.Enabled = True
        End If
    End Sub

    Private Sub PIDRadio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PIDRadio.CheckedChanged, OnOffRadio.CheckedChanged
        If OnOffRadio.Checked Then
            PIDRadio.Checked = False
            PPIPIDGroup.Enabled = False
            HysterisisUpDn.Enabled = True
        ElseIf PIDRadio.Checked Then
            OnOffRadio.Checked = False
            PPIPIDGroup.Enabled = True
            HysterisisUpDn.Enabled = False
        End If
    End Sub

    Private Sub PRadio_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PRadio.CheckedChanged, PIRadio.CheckedChanged, PIDRadio1.CheckedChanged
        If PRadio.Checked Then
            KpTrackBar.Enabled = True
            TiTrackBar.Enabled = False
            TdTrackBar.Enabled = False
        ElseIf PIRadio.Checked Then
            KpTrackBar.Enabled = True
            TiTrackBar.Enabled = True
            TdTrackBar.Enabled = False
        ElseIf PIDRadio1.Checked Then
            KpTrackBar.Enabled = True
            TiTrackBar.Enabled = True
            TdTrackBar.Enabled = True
        End If
    End Sub


    Private Sub OnOffPIDGroup_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OnOffPIDGroup.EnabledChanged
        If OnOffPIDGroup.Enabled = True Then
            PIDRadio_CheckedChanged(Nothing, Nothing)
        Else
            PPIPIDGroup.Enabled = False
            HysterisisUpDn.Enabled = False
        End If
    End Sub

    Private Sub PPIPIDGroup_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PPIPIDGroup.EnabledChanged
        If PPIPIDGroup.Enabled = True Then
            PRadio_CheckedChanged(Nothing, Nothing)
        Else
            KpTrackBar.Enabled = False
            TiTrackBar.Enabled = False
            TdTrackBar.Enabled = False
        End If
    End Sub

    Private Sub KpTrackBar_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles KpTrackBar.EnabledChanged, TiTrackBar.EnabledChanged, TdTrackBar.EnabledChanged
        KpLabel.Enabled = KpTrackBar.Enabled
        TiLabel.Enabled = TiTrackBar.Enabled
        TdLabel.Enabled = TdTrackBar.Enabled
        If KpTrackBar.Enabled = True Then
            KpTrackBar._CouleurA = Color.Teal
            KpTrackBar._CouleurDe = Color.Teal
        Else
            KpTrackBar._CouleurA = Color.Silver
            KpTrackBar._CouleurDe = Color.Silver
        End If
        If TiTrackBar.Enabled = True Then
            TiTrackBar._CouleurA = Color.Teal
            TiTrackBar._CouleurDe = Color.Teal
        Else
            TiTrackBar._CouleurA = Color.Silver
            TiTrackBar._CouleurDe = Color.Silver
        End If
        If TdTrackBar.Enabled = True Then
            TdTrackBar._CouleurA = Color.Teal
            TdTrackBar._CouleurDe = Color.Teal
        Else
            TdTrackBar._CouleurA = Color.Silver
            TdTrackBar._CouleurDe = Color.Silver
        End If
    End Sub

    Private Sub HysterisisUpDn_EnabledChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HysterisisUpDn.EnabledChanged
        HysterisisLabel.Enabled = HysterisisUpDn.Enabled
    End Sub


    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        MainForm.TTHysterisis = HysterisisUpDn.Value
        MainForm.TTProportionalConstant = KpTrackBar._Valeur / 100
        MainForm.TTIntegralConstant = (KpTrackBar._Valeur / TiTrackBar._Valeur) '* 5
        MainForm.TTDerivativeConstant = (KpTrackBar._Valeur * TdTrackBar._Valeur) ' / 5
        If OnOffRadio.Checked = True Then MainForm.HeaterTimer.Interval = 1000 Else MainForm.HeaterTimer.Interval = 5000
        Me.Close()
    End Sub
End Class