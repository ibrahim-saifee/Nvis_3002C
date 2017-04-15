Imports ZedGraph
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Threading


Public Class search

    Dim SQLConnection As MySqlConnection
    Dim SQLCommand As MySqlCommand
    Dim SQLReader As MySqlDataReader

    Dim tempsetpointPointPairList, tempPointPairList As New PointPairList
    Dim tempsetpointLineItem, tempLineItem As LineItem

    Dim levelsetpointPointPairList, levelPointPairList As New PointPairList
    Dim levelsetpointLineItem, levelLineItem As LineItem

    Dim pressurepointpairlist As New PointPairList
    Dim pressurelineitem As LineItem

    Dim flowpointpairlist As New PointPairList
    Dim flowlineitem As LineItem

    Dim sameday As Boolean = False


    Private Sub search_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SQLConnection = New MySqlConnection
        SQLConnection.ConnectionString = MainForm.SQLConnectionString
        fromdatebox.Text = ""
        todatebox.Text = ""
        resolutionbox.Items.Clear()
        TemperatureGraphInitialisation()
        LevelGraphInitialisation()
        PressureGraphInitialisation()
        FlowGraphInitialisation()
        resolutionbox.Items.Add("Data / Second")
        resolutionbox.Items.Add("Data / Minute")
        resolutionbox.Items.Add("Data / Hour")
        resolutionbox.Items.Add("Data / Day")
        resolutionbox.SelectedIndex = 0
    End Sub


    Private Sub TemperatureGraphInitialisation()
        Dim ZedGraphPane As GraphPane = TemperatureGraph.GraphPane
        tempLineItem = ZedGraphPane.AddCurve("Temperature", tempPointPairList, Color.Red, SymbolType.None)
        tempsetpointLineItem = ZedGraphPane.AddCurve("Set Point", tempsetpointPointPairList, Color.Blue, SymbolType.None)

        ZedGraphPane.Title.FontSpec.FontColor = Color.Black
        ZedGraphPane.Legend.Position = ZedGraph.LegendPos.Bottom
        ZedGraphPane.Legend.FontSpec.Size = 16
        ZedGraphPane.Legend.FontSpec.IsBold = True
        ZedGraphPane.Title.Text = "Temperature vs Time"
        ZedGraphPane.XAxis.Title.Text = "Time"
        ZedGraphPane.YAxis.Title.Text = "Temperature (C)"

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
        tempLineItem.Line.IsSmooth = True
        tempLineItem.Line.Width = 2.0
        tempsetpointLineItem.Line.IsSmooth = True
        tempsetpointLineItem.Line.Width = 2.0

        TemperatureGraph.IsAutoScrollRange = False
        TemperatureGraph.IsShowHScrollBar = False
        TemperatureGraph.IsSynchronizeXAxes = True
        TemperatureGraph.IsSynchronizeYAxes = True
        TemperatureGraph.IsAntiAlias = True
        TemperatureGraph.Refresh()
        TemperatureGraph.AxisChange()
    End Sub


    Private Sub LevelGraphInitialisation()
        Dim ZedGraphPane As GraphPane = LevelGraph.GraphPane
        levelLineItem = ZedGraphPane.AddCurve("Level", levelPointPairList, Color.Red, SymbolType.None)
        levelsetpointLineItem = ZedGraphPane.AddCurve("Set Point", levelsetpointPointPairList, Color.Blue, SymbolType.None)

        ZedGraphPane.Title.FontSpec.FontColor = Color.Black
        ZedGraphPane.Legend.Position = ZedGraph.LegendPos.Bottom
        ZedGraphPane.Legend.FontSpec.Size = 16
        ZedGraphPane.Legend.FontSpec.IsBold = True
        ZedGraphPane.Title.Text = "Level vs Time"
        ZedGraphPane.XAxis.Title.Text = "Time"
        ZedGraphPane.YAxis.Title.Text = "Level (%)"

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
        levelLineItem.Line.IsSmooth = True
        levelLineItem.Line.Width = 2.0
        levelsetpointLineItem.Line.IsSmooth = True
        levelsetpointLineItem.Line.Width = 2.0

        LevelGraph.IsAutoScrollRange = False
        LevelGraph.IsShowHScrollBar = False
        LevelGraph.IsSynchronizeXAxes = True
        LevelGraph.IsSynchronizeYAxes = True
        LevelGraph.IsAntiAlias = True
        LevelGraph.Refresh()
        LevelGraph.AxisChange()
    End Sub


    Private Sub PressureGraphInitialisation()
        Dim ZedGraphPane As GraphPane = pressuregraph.GraphPane
        pressurelineitem = ZedGraphPane.AddCurve("Pressure", pressurepointpairlist, Color.Red, SymbolType.None)

        ZedGraphPane.Title.FontSpec.FontColor = Color.Black
        ZedGraphPane.Legend.Position = ZedGraph.LegendPos.Bottom
        ZedGraphPane.Legend.FontSpec.Size = 16
        ZedGraphPane.Legend.FontSpec.IsBold = True
        ZedGraphPane.Title.Text = "Pressure vs Time"
        ZedGraphPane.XAxis.Title.Text = "Time"
        ZedGraphPane.YAxis.Title.Text = "Pressure (psi)"

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
        pressurelineitem.Line.IsSmooth = True
        pressurelineitem.Line.Width = 2.0

        pressuregraph.IsAutoScrollRange = False
        pressuregraph.IsShowHScrollBar = False
        pressuregraph.IsSynchronizeXAxes = True
        pressuregraph.IsSynchronizeYAxes = True
        pressuregraph.IsAntiAlias = True
        pressuregraph.Refresh()
        pressuregraph.AxisChange()
    End Sub


    Private Sub FlowGraphInitialisation()
        Dim ZedGraphPane As GraphPane = flowgraph.GraphPane
        flowlineitem = ZedGraphPane.AddCurve("Flow", flowpointpairlist, Color.Red, SymbolType.None)

        ZedGraphPane.Title.FontSpec.FontColor = Color.Black
        ZedGraphPane.Legend.Position = ZedGraph.LegendPos.Bottom
        ZedGraphPane.Legend.FontSpec.Size = 16
        ZedGraphPane.Legend.FontSpec.IsBold = True
        ZedGraphPane.Title.Text = "Flow vs Time"
        ZedGraphPane.XAxis.Title.Text = "Time"
        ZedGraphPane.YAxis.Title.Text = "Flow (Ltr / min)"

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
        flowlineitem.Line.IsSmooth = True
        flowlineitem.Line.Width = 2.0

        flowgraph.IsAutoScrollRange = False
        flowgraph.IsShowHScrollBar = False
        flowgraph.IsSynchronizeXAxes = True
        flowgraph.IsSynchronizeYAxes = True
        flowgraph.IsAntiAlias = True
        flowgraph.Refresh()
        flowgraph.AxisChange()
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
        TemperatureGraph.AxisChange()
        TemperatureGraph.RestoreScale(TemperatureGraph.GraphPane)
        LevelGraph.AxisChange()
        LevelGraph.RestoreScale(LevelGraph.GraphPane)
        pressuregraph.AxisChange()
        pressuregraph.RestoreScale(pressuregraph.GraphPane)
        flowgraph.AxisChange()
        flowgraph.RestoreScale(flowgraph.GraphPane)
        If sameday = True Then
            TemperatureGraph.GraphPane.XAxis.Scale.Format = "HH:mm:ss"
            LevelGraph.GraphPane.XAxis.Scale.Format = "HH:mm:ss"
            pressuregraph.GraphPane.XAxis.Scale.Format = "HH:mm:ss"
            flowgraph.GraphPane.XAxis.Scale.Format = "HH:mm:ss"
        Else
            TemperatureGraph.GraphPane.XAxis.Scale.Format = "dd-MM-yyyy HH:mm:ss"
            LevelGraph.GraphPane.XAxis.Scale.Format = "dd-MM-yyyy HH:mm:ss"
            pressuregraph.GraphPane.XAxis.Scale.Format = "dd-MM-yyyy HH:mm:ss"
            flowgraph.GraphPane.XAxis.Scale.Format = "dd-MM-yyyy HH:mm:ss"
        End If
        TemperatureGraph.Refresh()
        LevelGraph.Refresh()
        pressuregraph.Refresh()
        flowgraph.Refresh()
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
        tempPointPairList.Add(dt.ToOADate(), CDbl(SQLReader.GetString(2)))
        tempsetpointPointPairList.Add(dt.ToOADate(), CDbl(SQLReader.GetString(1)))
        TemperatureTable.Rows.Add(DateTime.Parse(SQLReader.GetString(0)).ToString("yyyy-MM-dd"), DateTime.Parse(SQLReader.GetString(0)).ToString("HH:mm:ss"), SQLReader.GetString(1), SQLReader.GetString(2))

        levelPointPairList.Add(dt.ToOADate(), CDbl(SQLReader.GetString(4)))
        levelsetpointPointPairList.Add(dt.ToOADate(), CDbl(SQLReader.GetString(3)))
        LevelTable.Rows.Add(DateTime.Parse(SQLReader.GetString(0)).ToString("yyyy-MM-dd"), DateTime.Parse(SQLReader.GetString(0)).ToString("HH:mm:ss"), SQLReader.GetString(3), SQLReader.GetString(4))

        pressurepointpairlist.Add(dt.ToOADate(), CDbl(SQLReader.GetString(5)))
        pressuretable.Rows.Add(DateTime.Parse(SQLReader.GetString(0)).ToString("yyyy-MM-dd"), DateTime.Parse(SQLReader.GetString(0)).ToString("HH:mm:ss"), SQLReader.GetString(5))

        flowpointpairlist.Add(dt.ToOADate(), CDbl(SQLReader.GetString(6)))
        flowtable.Rows.Add(DateTime.Parse(SQLReader.GetString(0)).ToString("yyyy-MM-dd"), DateTime.Parse(SQLReader.GetString(0)).ToString("HH:mm:ss"), SQLReader.GetString(6))
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
            resolution = " group by date(datetime) hour(datetime) minute(datetime);"
        ElseIf resolutionbox.SelectedIndex = 2 Then
            resolution = " group by date(datetime), hour(datetime);"
        ElseIf resolutionbox.SelectedIndex = 3 Then
            resolution = " group by date(datetime);"
        End If

        Dim SQLQuery As String = ""
        SQLQuery = "select * from " + MainForm.DatabaseName + " where datetime>='" + FromDate + FromTime + "' and datetime<='" + Todate + ToTime + "'" + resolution

        Dim newtodate, newfromdate As String
        newtodate = Todate.Substring(8, 2) + " " + MonthName(Todate.Substring(5, 2)) + " " + Todate.Substring(0, 4)
        newfromdate = FromDate.Substring(8, 2) + " " + MonthName(FromDate.Substring(5, 2)) + " " + FromDate.Substring(0, 4)
        If Todate = FromDate Then
            TemperatureGraph.GraphPane.XAxis.Scale.Format = "HH:mm:ss"
            TemperatureGraph.GraphPane.Title.Text = newtodate
            LevelGraph.GraphPane.XAxis.Scale.Format = "HH:mm:ss"
            LevelGraph.GraphPane.Title.Text = newtodate
            pressuregraph.GraphPane.XAxis.Scale.Format = "HH:mm:ss"
            pressuregraph.GraphPane.Title.Text = newtodate
            flowgraph.GraphPane.XAxis.Scale.Format = "HH:mm:ss"
            flowgraph.GraphPane.Title.Text = newtodate
            sameday = True
        Else
            TemperatureGraph.GraphPane.XAxis.Scale.Format = "dd/MM/yyyy HH:mm:ss"
            TemperatureGraph.GraphPane.Title.Text = newfromdate + " to " + newtodate
            LevelGraph.GraphPane.XAxis.Scale.Format = "dd/MM/yyyy HH:mm:ss"
            LevelGraph.GraphPane.Title.Text = newfromdate + " to " + newtodate
            pressuregraph.GraphPane.XAxis.Scale.Format = "dd/MM/yyyy HH:mm:ss"
            pressuregraph.GraphPane.Title.Text = newfromdate + " to " + newtodate
            flowgraph.GraphPane.XAxis.Scale.Format = "dd/MM/yyyy HH:mm:ss"
            flowgraph.GraphPane.Title.Text = newfromdate + " to " + newtodate
            sameday = False
        End If

        Return SQLQuery
    End Function


    Private Sub clrbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clrbtn.Click
        'setpointZedPointPairList.Clear()
        'tempZedPointPairList.Clear()
        tempLineItem.Clear()
        tempsetpointLineItem.Clear()
        TemperatureGraph.Refresh()
        TemperatureTable.Rows.Clear()
        levelLineItem.Clear()
        levelsetpointLineItem.Clear()
        LevelGraph.Refresh()
        LevelTable.Rows.Clear()
        pressurelineitem.Clear()
        pressuregraph.Refresh()
        pressuretable.Rows.Clear()
        flowlineitem.Clear()
        flowgraph.Refresh()
        flowtable.Rows.Clear()
    End Sub

    Private Sub tblbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblbtn.Click
        If tblbtn.Text = "Graph" Then
            TemperatureGraph.Visible = True
            TemperatureTable.Visible = False
            LevelGraph.Visible = True
            LevelTable.Visible = False
            pressuregraph.Visible = True
            pressuretable.Visible = False
            flowgraph.Visible = True
            flowtable.Visible = False
            tblbtn.Text = "Table"
        ElseIf tblbtn.Text = "Table" Then
            TemperatureGraph.Visible = False
            TemperatureTable.Visible = True
            LevelGraph.Visible = False
            LevelTable.Visible = True
            pressuregraph.Visible = False
            pressuretable.Visible = True
            flowgraph.Visible = False
            flowtable.Visible = True
            tblbtn.Text = "Graph"
        End If
    End Sub

End Class