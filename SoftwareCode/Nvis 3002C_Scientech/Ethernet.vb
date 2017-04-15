Imports System.Net
Imports System.Net.Sockets
Imports System.Threading


Public Class Ethernet

    Public Shared IP As String = ""
    Public Shared Port As Integer = 8000
    Public Shared IsIPAccepted As Boolean = False
    Public Shared ReceivedString As String = ""

    Dim Client As Socket
    Dim ClientListenerThread As Thread

    Public Shared IsDataReady As Boolean = False

    Private Sub Ethernet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        iptxtbox.Text = IP
    End Sub


    Private Sub SaveIPFile()
        Dim FilePath As String = Application.StartupPath + "/IP.txt"
        Try
            If System.IO.File.Exists(FilePath) Then
                Dim FileWriter As New System.IO.StreamWriter(FilePath)
                FileWriter.Write(IP)
                FileWriter.Close()
            Else
                MessageBox.Show(Me, "File IP.txt doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Try
            iptxtbox.Text = iptxtbox.Text.Replace(" ", "")
            IPAddress.Parse(iptxtbox.Text)
            IP = iptxtbox.Text
            IsIPAccepted = True
            SaveIPFile()
            Me.Close()
        Catch
            MessageBox.Show(Me, "Please enter valid IP", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CnclButton.Click
        IsIPAccepted = False
        Me.Close()
    End Sub


    Public Sub Connect()
        If (Client Is Nothing) Then
            Client = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
            Dim IPEndPt As IPEndPoint = New IPEndPoint(IPAddress.Parse(IP), Port)
            Client.Connect(IPEndPt)
            ClientListenerThread = New Thread(AddressOf Listener)
            ClientListenerThread.Start()
        End If
    End Sub


    Private Sub Listener()
        Try
            Dim ReceivedBytes(1024) As Byte
            While True
                Dim ReceivedBytesCount As Integer = Client.Receive(ReceivedBytes)
                ReceivedString = System.Text.ASCIIEncoding.ASCII.GetString(ReceivedBytes, 0, ReceivedBytesCount)
                IsDataReady = True
            End While
        Catch
            'MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub Send(ByVal ToSendString As String)
        If (Client Is Nothing) Then Exit Sub
        Dim ToSendBytes() As Byte = System.Text.ASCIIEncoding.ASCII.GetBytes(ToSendString)
        Try
            Client.Send(ToSendBytes)
        Catch ex As Exception
            Client = Nothing
            'MessageBox.Show(Me, "Can't connect to hardware, check if it is connected to LAN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub Disconnect()
        Try
            If (Not Client Is Nothing) Then
                Client.Close()
                Client = Nothing
                ClientListenerThread.Abort()
            End If
        Catch ex As Exception
            'MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Function IsConnected() As Boolean
        If Client Is Nothing Then
            Return False
        Else
            Return True
        End If
    End Function

End Class