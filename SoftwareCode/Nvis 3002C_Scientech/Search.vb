Imports ZedGraph
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Threading


Public Class search

    Dim SQLConnection As MySqlConnection
    Dim SQLCommand As MySqlCommand
    Dim SQLReader As MySqlDataReader

    Dim FlowSetPointPointPairList, FlowPointPairList As New PointPairList
    Dim FlowSetPointLineItem, FlowLineItem As LineItem

    Dim LevelSetPointPointPairList, LevelPointPairList As New PointPairList
    Dim LevelSetPointLineItem, LevelLineItem As LineItem

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

        FlowSetPointLineItem = FlowGraph.GraphPane.AddCurve("Set Point", FlowSetPointPointPairList, Color.Blue, SymbolType.None)
        FlowLineItem = FlowGraph.GraphPane.AddCurve("FLow (Ltr/min)", FlowPointPairList, Color.Red, SymbolType.None)
        GraphInitialisation(FlowGraph, "FLow (Ltr/min)", FlowLineItem, FlowSetPointLineItem)

        LevelSetPointLineItem = LevelGraph.GraphPane.AddCurve("Set Point", LevelSetPointPointPairList, Color.Blue, SymbolType.None)
        LevelLineItem = LevelGraph.GraphPane.AddCurve("Level (%)", LevelPointPairList, Color.Red, SymbolType.None)
        GraphInitialisation(LevelGraph, "Level (%)", LevelLineItem, LevelSetPointLineItem)

        resolutionbox.Items.Add("Data / Second")
        resolutionbox.Items.Add("Data / Minute")
        resolutionbox.Items.Add("Data / Hour")
        resolutionbox.Items.Add("Data / Day")
        resolutionbox.SelectedIndex = 0
    End Sub


    Private Sub GraphInitialisation(ByVal Graph As ZedGraphControl, ByVal yTitle As String, ByVal GraphLine As LineItem, ByVal GraphSetPointLine As LineItem)
        Dim ZedGraphPane As GraphPane = Graph.GraphPane
        ZedGraphPane.Title.FontSpec.FontColor = Color.Black
        ZedGraphPane.Legend.Position = ZedGraph.LegendPos.Bottom
        ZedGraphPane.Legend.FontSpec.Size = 16
        ZedGraphPane.Legend.FontSpec.IsBold = True
        ZedGraphPane.Title.Text = yTitle + " vs Time"
        ZedGraphPane.XAxis.Title.Text = "Time"
        ZedGraphPane.YAxis.Title.Text = yTitle

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

        GraphLine.Line.IsSmooth = True
        GraphLine.Line.Width = 2.0

        GraphSetPointLine.Line.IsSmooth = True
        GraphSetPointLine.Line.Width = 2.0

        Graph.IsAutoScrollRange = False
        Graph.IsShowHScrollBar = False
        Graph.IsSynchronizeXAxes = True
        Graph.IsSynchronizeYAxes = True
        Graph.IsAntiAlias = True
        Graph.Refresh()
        Graph.AxisChange()
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
        If FlowSearchCheckBox.Checked Then
            Try
                SQLConnection.Open()
                SQLCommand = New MySqlCommand(GetQuery(MainForm.FlowTableName), SQLConnection)
                SQLCommand.CommandTimeout = 0
                SQLReader = SQLCommand.ExecuteReader()
                While SQLReader.Read
                    If Me.InvokeRequired Then Me.Invoke(New UpdateUIDelegate(AddressOf UpdateFlowUI))
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
        End If

        If LevelSearchCheckBox.Checked Then
            Try
                SQLConnection.Open()
                SQLCommand = New MySqlCommand(GetQuery(MainForm.LevelTableName), SQLConnection)
                SQLCommand.CommandTimeout = 0
                SQLReader = SQLCommand.ExecuteReader()
                While SQLReader.Read
                    If Me.InvokeRequired Then Me.Invoke(New UpdateUIDelegate(AddressOf UpdateLevelUI))
                End While
            Catch ex As Exception
                MessageBox.Show(Me, "Error in reading data from database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            LevelGraph.AxisChange()
            LevelGraph.RestoreScale(LevelGraph.GraphPane)
            If sameday = True Then
                LevelGraph.GraphPane.XAxis.Scale.Format = "HH:mm:ss"
            Else
                LevelGraph.GraphPane.XAxis.Scale.Format = "dd-MM-yyyy HH:mm:ss"
            End If
            LevelGraph.Refresh()
            SQLConnection.Close()
        End If
        WaitPanel.Visible = False
    End Sub

    Private Delegate Sub UpdateUIDelegate()
    Private Sub UpdateFlowUI()
        Dim dt As DateTime
        If sameday = True Then
            dt = DateTime.Parse(SQLReader.GetDateTime(0).ToString("HH:mm:ss"))
        Else
            dt = DateTime.Parse(SQLReader.GetDateTime(0).ToString("yyyy-MM-dd HH:mm:ss"))
        End If
        FlowSetPointPointPairList.Add(dt.ToOADate(), CDbl(SQLReader.GetString(1)))
        FlowPointPairList.Add(dt.ToOADate(), CDbl(SQLReader.GetString(2)))
        FlowTable.Rows.Add(DateTime.Parse(SQLReader.GetString(0)).ToString("dd/MM/yyyy"), DateTime.Parse(SQLReader.GetString(0)).ToString("HH:mm:ss"), SQLReader.GetString(1), SQLReader.GetString(2))
    End Sub
    Private Sub UpdateLevelUI()
        Dim dt As DateTime
        If sameday = True Then
            dt = DateTime.Parse(SQLReader.GetDateTime(0).ToString("HH:mm:ss"))
        Else
            dt = DateTime.Parse(SQLReader.GetDateTime(0).ToString("yyyy-MM-dd HH:mm:ss"))
        End If
        LevelSetPointPointPairList.Add(dt.ToOADate(), CDbl(SQLReader.GetString(1)))
        LevelPointPairList.Add(dt.ToOADate(), CDbl(SQLReader.GetString(2)))
        LevelTable.Rows.Add(DateTime.Parse(SQLReader.GetString(0)).ToString("dd/MM/yyyy"), DateTime.Parse(SQLReader.GetString(0)).ToString("HH:mm:ss"), SQLReader.GetString(1), SQLReader.GetString(2))
    End Sub

    Private Function GetQuery(ByVal TableName As String) As String
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
        SQLQuery = "select * from " + TableName + " where datetime>='" + FromDate + FromTime + "' and datetime<='" + Todate + ToTime + "'" + resolution

        Dim newtodate, newfromdate As String
        newtodate = Todate.Substring(8, 2) + " " + MonthName(Todate.Substring(5, 2)) + " " + Todate.Substring(0, 4)
        newfromdate = FromDate.Substring(8, 2) + " " + MonthName(FromDate.Substring(5, 2)) + " " + FromDate.Substring(0, 4)
        If Todate = FromDate Then
            If FlowSearchCheckBox.Checked Then
                FlowGraph.GraphPane.XAxis.Scale.Format = "HH:mm:ss"
                FlowGraph.GraphPane.Title.Text = newtodate
            End If
            If LevelSearchCheckBox.Checked Then
                LevelGraph.GraphPane.XAxis.Scale.Format = "HH:mm:ss"
                LevelGraph.GraphPane.Title.Text = newtodate
            End If
            sameday = True
        Else
            If FlowSearchCheckBox.Checked Then
                FlowGraph.GraphPane.XAxis.Scale.Format = "dd/MM/yyyy HH:mm:ss"
                FlowGraph.GraphPane.Title.Text = newfromdate + " to " + newtodate
            End If
            If LevelSearchCheckBox.Checked Then
                LevelGraph.GraphPane.XAxis.Scale.Format = "dd/MM/yyyy HH:mm:ss"
                LevelGraph.GraphPane.Title.Text = newfromdate + " to " + newtodate
            End If
            sameday = False
            End If

            Return SQLQuery
    End Function


    Private Sub clrbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clrbtn.Click
        FlowSetPointLineItem.Clear()
        FlowLineItem.Clear()
        FlowGraph.Refresh()
        FlowTable.Rows.Clear()

        LevelSetPointLineItem.Clear()
        LevelLineItem.Clear()
        LevelGraph.Refresh()
        LevelTable.Rows.Clear()
    End Sub

    Private Sub tblbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tblbtn.Click
        If tblbtn.Text = "Graph" Then
            FlowGraph.Visible = True
            LevelGraph.Visible = True
            FlowTable.Visible = False
            LevelTable.Visible = False
            tblbtn.Text = "Table"
        ElseIf tblbtn.Text = "Table" Then
            FlowGraph.Visible = False
            LevelGraph.Visible = False
            FlowTable.Visible = True
            LevelTable.Visible = True
            tblbtn.Text = "Graph"
        End If
    End Sub

End Class