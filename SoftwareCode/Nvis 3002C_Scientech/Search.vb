Imports ZedGraph
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Threading


Public Class search

    Dim SQLConnection As MySqlConnection
    Dim SQLCommand As MySqlCommand
    Dim SQLReader As MySqlDataReader

    Dim SetPointPointPairList, FlowPointPairList As New PointPairList
    Dim SetPointLineItem, FlowLineItem As LineItem

    Dim sameday As Boolean = False

    Private Sub search_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            SearchThread.Abort()
        Catch
        End Try
    End Sub

    Private Sub search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = MainForm.SQLConnectionString
        fromdatebox.Text = ""
        todatebox.Text = ""
        resolutionbox.Items.Clear()
        GraphInitialisation()
        resolutionbox.Items.Add("Data / Second")
        resolutionbox.Items.Add("Data / Minute")
        resolutionbox.Items.Add("Data / Hour")
        resolutionbox.Items.Add("Data / Day")
        resolutionbox.SelectedIndex = 0
    End Sub


    Private Sub GraphInitialisation()
        Dim ZedGraphPane As GraphPane = FlowGraph.GraphPane
        SetPointLineItem = ZedGraphPane.AddCurve("Set Point", SetPointPointPairList, Color.Blue, SymbolType.None)
        FlowLineItem = ZedGraphPane.AddCurve("FLow (Ltr/min)", FlowPointPairList, Color.Red, SymbolType.None)

        ZedGraphPane.Title.FontSpec.FontColor = Color.Black
        ZedGraphPane.Legend.Position = ZedGraph.LegendPos.Bottom
        ZedGraphPane.Legend.FontSpec.Size = 16
        ZedGraphPane.Legend.FontSpec.IsBold = True
        ZedGraphPane.Title.Text = "Flow vs Time"
        ZedGraphPane.XAxis.Title.Text = "Time"
        ZedGraphPane.YAxis.Title.Text = "Flow (Ltr/min)"

        With ZedGraphPane
            .XAxis.Title.Text = "Time"
            .XAxis.Type = AxisType.Date
            .XAxis.Scale.Format = "HH:mm:ss"
            .XAxis.Scale.MajorUnit = DateUnit.Hour
            .XAxis.Scale.MinorUnit = DateUnit.Second
            .XAxis.Scale.MinorStep = 1
            .XAxis.Scale.FontSpec.IsBold = True
            .XAxis.Scale.FontSpec.Size = 14
            .Title.FontSpec.Size = 18
            .Title.FontSpec.IsBold = True
        End With

        SetPointLineItem.Line.IsSmooth = True
        SetPointLineItem.Line.Width = 2.0

        FlowLineItem.Line.IsSmooth = True
        FlowLineItem.Line.Width = 2.0

        FlowGraph.IsAutoScrollRange = False
        FlowGraph.IsShowHScrollBar = False
        FlowGraph.IsSynchronizeXAxes = True
        FlowGraph.IsSynchronizeYAxes = True
        FlowGraph.IsAntiAlias = True
        FlowGraph.Refresh()
        FlowGraph.AxisChange()
    End Sub


    Private Sub TerminateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TerminateButton.Click
        SearchThread.Abort()
        WaitPanel.Visible = False
    End Sub

    Private Sub searchbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchbtn.Click
        Try
            DateTime.Parse(todatebox.Text)
            DateTime.Parse(fromdatebox.Text)
            If fromtxtbox.Text <> "  :  :" Then DateTime.Parse(fromtxtbox.Text)
            If totxtbox.Text <> "  :  :" Then DateTime.Parse(totxtbox.Text)
        Catch ex As Exception
            MessageBox.Show(Me, "Enter valid date", "Invalid Expression", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        clrbtn_Click(Nothing, Nothing)
        ProgressBar1.Style = ProgressBarStyle.Marquee
        ProgressBar1.MarqueeAnimationSpeed = 30
        WaitPanel.Visible = True
        SearchThread = New Thread(AddressOf Search)
        SearchThread.IsBackground = True
        SearchThread.Start()
    End Sub

    Dim SearchThread As Thread
    Private Sub Search()
        CheckForIllegalCrossThreadCalls = False
        Try
            SQLConnection.Open()
            SQLCommand = New MySqlCommand(GetQuery(), SQLConnection)
            SQLCommand.CommandTimeout = 0
            SQLReader = SQLCommand.ExecuteReader()
            While SQLReader.Read
                If Me.InvokeRequired Then Me.Invoke(New UpdateUIDelegate(AddressOf UpdateUI))
            End While
        Catch ex As Exception
            MessageBox.Show(Me, "Error in reading data from database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        FlowGraph.AxisChange()
        FlowGraph.RestoreScale(FlowGraph.GraphPane)
        If sameday = True Then
            FlowGraph.GraphPane.XAxis.Scale.Format = "HH:mm:ss"
        Else
            FlowGraph.GraphPane.XAxis.Scale.Format = "dd-MM-yyyy HH:mm:ss"
        End If
        FlowGraph.Refresh()
        SQLConnection.Close()
        WaitPanel.Visible = False
    End Sub

    Private Delegate Sub UpdateUIDelegate()
    Private Sub UpdateUI()
        Dim dt As DateTime
        If sameday = True Then
            dt = DateTime.Parse(SQLReader.GetDateTime(0).ToString("HH:mm:ss"))
        Else
            dt = DateTime.Parse(SQLReader.GetDateTime(0).ToString("yyyy-MM-dd HH:mm:ss"))
        End If
        SetPointPointPairList.Add(dt.ToOADate(), CDbl(SQLReader.GetString(1)))
        FlowPointPairList.Add(dt.ToOADate(), CDbl(SQLReader.GetString(2)))
        FlowTable.Rows.Add(DateTime.Parse(SQLReader.GetString(0)).ToString("dd/MM/yyyy"), DateTime.Parse(SQLReader.GetString(0)).ToString("HH:mm:ss"), SQLReader.GetString(1), SQLReader.GetString(2))
    End Sub


    Private Function GetQuery() As String
        Dim ToTime, FromTime, Todate, FromDate As String
        Dim resolution As String = ""
        If totxtbox.Text = "  :  :" Then
            ToTime = " 23:59:59"
        Else
            ToTime = " " + totxtbox.Text
        End If
        If fromtxtbox.Text = "  :  :" Then
            FromTime = " 00:00:00"
        Else
            FromTime = " " + fromtxtbox.Text
        End If

        FromDate = DateTime.Parse(fromdatebox.Text).ToString("yyyy-MM-dd")
        Todate = DateTime.Parse(todatebox.Text).ToString("yyyy-MM-dd")

        If resolutionbox.SelectedIndex = 0 Then
            resolution = ";"
        ElseIf resolutionbox.SelectedIndex = 1 Then
            resolution = " group by date(datetime), hour(datetime), minute(datetime)"
        ElseIf resolutionbox.SelectedIndex = 2 Then
            resolution = " group by date(datetime), hour(datetime)"
        ElseIf resolutionbox.SelectedIndex = 3 Then
            resolution = " group by date(datetime);"
        End If

        Dim SQLQuery As String = ""
        SQLQuery = "select * from " + MainForm.DatabaseName + " where datetime>='" + FromDate + FromTime + "' and datetime<='" + Todate + ToTime + "'" + resolution

        Dim newtodate, newfromdate As String
        newtodate = Todate.Substring(8, 2) + " " + MonthName(Todate.Substring(5, 2)) + " " + Todate.Substring(0, 4)
        newfromdate = FromDate.Substring(8, 2) + " " + MonthName(FromDate.Substring(5, 2)) + " " + FromDate.Substring(0, 4)
        If Todate = FromDate Then
            FlowGraph.GraphPane.XAxis.Scale.Format = "HH:mm:ss"
            FlowGraph.GraphPane.Title.Text = newtodate
            sameday = True
        Else
            FlowGraph.GraphPane.XAxis.Scale.Format = "dd/MM/yyyy HH:mm:ss"
            FlowGraph.GraphPane.Title.Text = newfromdate + " to " + newtodate
            sameday = False
        End If

        Return SQLQuery
    End Function


    Private Sub clrbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clrbtn.Click
        'setpointZedPointPairList.Clear()
        'tempZedPointPairList.Clear()
        SetPointLineItem.Clear()
        FlowLineItem.Clear()
        FlowGraph.Refresh()
        FlowTable.Rows.Clear()
    End Sub

    Private Sub tblbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblbtn.Click
        If tblbtn.Text = "Graph" Then
            FlowGraph.Visible = True
            FlowTable.Visible = False
            tblbtn.Text = "Table"
        ElseIf tblbtn.Text = "Table" Then
            FlowGraph.Visible = False
            FlowTable.Visible = True
            tblbtn.Text = "Graph"
        End If
    End Sub

End Class