Public Class SettingsForm

    Dim ComponentValues As String = ""

    Private Sub WriteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WriteButton.Click
        If MainForm.IsLinkFound = False Then
            MessageBox.Show(Me, "No link found, check if your hardware is connected to LAN", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If CheckEntries() = False Then
            MessageBox.Show(Me, "Please Fill Proper Entries", "Invalid Expression", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        'If MainForm.StartToolStripMenuItem2.Text = "S&tart" Then
        '    Try
        '        Ethernet.Connect()
        '    Catch
        '        MessageBox.Show(Me, "Host not responding", Ethernet.IP, MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Exit Sub
        '    End Try
        'End If
        Dim StringToSend As String = "-"
        StringToSend += GetSymbol(TypeChannel1.SelectedIndex)
        StringToSend += GetSymbol(TypeChannel2.SelectedIndex)
        StringToSend += GetSymbol(TypeChannel3.SelectedIndex)
        StringToSend += GetSymbol(TypeChannel4.SelectedIndex)
        StringToSend += GetSymbol(TypeChannel5.SelectedIndex)
        StringToSend += GetSymbol(TypeChannel6.SelectedIndex)
        StringToSend += GetSymbol(TypeChannel7.SelectedIndex)
        StringToSend += GetSymbol(TypeChannel8.SelectedIndex)
        StringToSend += ComponentValues
        Ethernet.Send(StringToSend)
        'If MainForm.StartToolStripMenuItem2.Text = "S&tart" Then
        '    Ethernet.Disconnect()
        'End If
        Me.Close()
    End Sub


    Private Function CheckEntries() As Boolean
        If TypeChannel1.SelectedIndex < 0 Then Return False
        If TypeChannel2.SelectedIndex < 0 Then Return False
        If TypeChannel3.SelectedIndex < 0 Then Return False
        If TypeChannel4.SelectedIndex < 0 Then Return False
        If TypeChannel5.SelectedIndex < 0 Then Return False
        If TypeChannel6.SelectedIndex < 0 Then Return False
        If TypeChannel7.SelectedIndex < 0 Then Return False
        If TypeChannel8.SelectedIndex < 0 Then Return False
        Try
            ComponentValues = CInt(RTDResistanceTextBox.Text).ToString("0000")
            ComponentValues += CInt(ADCResistanceTextBox.Text).ToString("0000")
            ComponentValues += CDbl(RTDSupplyTextBox.Text).ToString("0.0").Replace(".", "")
            ComponentValues += CInt(MaxRTDTemperatureTextBox.Text).ToString("0000")
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function


    Private Function GetSymbol(ByVal Index As Integer) As String
        If Index = 0 Then Return "$"
        If Index = 1 Then Return "^"
        If Index = 2 Then Return "J"
        If Index = 3 Then Return "K"
        If Index = 4 Then Return "R"
        If Index = 5 Then Return "B"
        If Index = 6 Then Return "N"
        If Index = 7 Then Return "V" 'milli volts
        Return ""
    End Function

    Private Function GetIndex(ByVal Symbol As String) As Integer
        If Symbol = "$" Then Return 0
        If Symbol = "^" Then Return 1
        If Symbol = "J" Then Return 2
        If Symbol = "K" Then Return 3
        If Symbol = "R" Then Return 4
        If Symbol = "B" Then Return 5
        If Symbol = "N" Then Return 6
        If Symbol = "V" Then Return 7
        Return 7
    End Function

    Private Sub SettingsForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        EthRecTimer.Enabled = False
        Ethernet.Disconnect()
    End Sub

    Private Sub SettingsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If MainForm.IsLinkFound = False Then
            MessageBox.Show(Me, "No link found, check if your hardware is connected to LAN", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If MainForm.StartToolStripMenuItem2.Text = "S&tart" Then
            Try
                Ethernet.Connect()
                EthRecTimer.Enabled = True
            Catch
                MessageBox.Show(Me, "Host not responding", Ethernet.IP, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
        End If
    End Sub

    Dim ReceivedString As String
    Private Sub EthRecTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EthRecTimer.Tick
        If Ethernet.IsDataReady = True Then
            ReceivedString += Ethernet.ReceivedString
            Dim index = ReceivedString.IndexOf("-")
            If index < 0 Then
                ReceivedString = ""
                Exit Sub
            End If
            ReceivedString = ReceivedString.Substring(index)
            If ReceivedString.Length >= 23 Then
                TypeChannel1.SelectedIndex = GetIndex(ReceivedString.Substring(1, 1))
                TypeChannel2.SelectedIndex = GetIndex(ReceivedString.Substring(2, 1))
                TypeChannel3.SelectedIndex = GetIndex(ReceivedString.Substring(3, 1))
                TypeChannel4.SelectedIndex = GetIndex(ReceivedString.Substring(4, 1))
                TypeChannel5.SelectedIndex = GetIndex(ReceivedString.Substring(5, 1))
                TypeChannel6.SelectedIndex = GetIndex(ReceivedString.Substring(6, 1))
                TypeChannel7.SelectedIndex = GetIndex(ReceivedString.Substring(7, 1))
                TypeChannel8.SelectedIndex = GetIndex(ReceivedString.Substring(8, 1))
                RTDResistanceTextBox.Text = ReceivedString.Substring(9, 4)
                ADCResistanceTextBox.Text = ReceivedString.Substring(13, 4)
                RTDSupplyTextBox.Text = ReceivedString.Substring(17, 2)
                MaxRTDTemperatureTextBox.Text = ReceivedString.Substring(19, 4)
                ReceivedString = ""
                Ethernet.IsDataReady = False
            End If
        End If
    End Sub

    Private Sub ReadButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReadButton.Click
        If MainForm.IsLinkFound = False Then
            MessageBox.Show(Me, "No link found, check if your hardware is connected to LAN", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Ethernet.Send("?")
    End Sub

End Class