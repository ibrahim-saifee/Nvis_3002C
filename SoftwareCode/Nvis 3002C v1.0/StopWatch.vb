Public Class StopWatch

    Dim hours, min, sec, milsec As Integer

    Private Sub StopWatch_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        dottimer.Stop()
        freetimer.Stop()
        startbtn.Text = "Start"
        rstbtn_Click(Nothing, Nothing)
    End Sub

    Private Sub dottimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dottimer.Tick
        If dotslblhrs.Visible = True Then
            dotslblhrs.Visible = False
            dotslblmin.Visible = False
            dotslblsec.Visible = False
        Else
            dotslblhrs.Visible = True
            dotslblmin.Visible = True
            dotslblsec.Visible = True
        End If
    End Sub


    Private Sub frmStopwatch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dottimer.Interval = 500
        freetimer.Interval = 10
    End Sub


    Private Sub startbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startbtn.Click
        If startbtn.Text = "Start" Then
            startbtn.Text = "Stop"
            dottimer.Start()
            freetimer.Start()
        ElseIf startbtn.Text = "Stop" Then
            startbtn.Text = "Start"
            dottimer.Stop()
            freetimer.Stop()
        End If
    End Sub

    Private Sub freetimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles freetimer.Tick
        milsec += 1
        If milsec >= 100 Then
            sec += 1
            milsec = 0
        End If
        If sec >= 60 Then
            min += 1
            sec = 0
        End If
        If min >= 60 Then
            hours += 1
            min = 0
        End If
        hrsdigi.DigitText = hours.ToString("00")
        mindigi.DigitText = min.ToString("00")
        secdigi.DigitText = sec.ToString("00")
        msecdigi.DigitText = milsec.ToString("00")
    End Sub

    Private Sub rstbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rstbtn.Click
        hours = 0
        min = 0
        sec = 0
        milsec = 0
        hrsdigi.DigitText = "00"
        mindigi.DigitText = "00"
        secdigi.DigitText = "00"
        msecdigi.DigitText = "00"
        laptimetable.Rows.Clear()
    End Sub

    Private Sub capturebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles capturebtn.Click
        laptimetable.Rows.Add(hours.ToString("00") + " : " + min.ToString("00") + " : " + sec.ToString("00") + " : " + milsec.ToString("00"))
    End Sub
End Class