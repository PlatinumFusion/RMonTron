Imports System.ComponentModel
Imports System.Text
Imports System.Net
Imports System.Net.Sockets
Imports System
Imports System.IO
Imports System.Linq
Imports System.Threading
Imports Microsoft.VisualBasic
Imports System.Windows.Forms


Public Class MainSet
    Public stream As NetworkStream
    Public reader As StreamReader
    Public r() As String
    Public bordercolor As Color
    Public line As String = Nothing ' this in the in data from the telnet connection string
    Public ScoreModeQual = True 'To determine Race Mode or Score Mode 'Default is Qualify Mode
    Public RacePOS(10) As String
    Public QualPOS(10) As String
    Public Lapcount As String
    Public PassQualTime As String


    Public Sub New()
        For Each x In QualPOS
            x = ""
        Next
        For Each x In RacePOS
            x = ""
        Next
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click

        If SettingsToolStripMenuItem.Text = "Stop" Then
            PlayerForm.Close()
        ElseIf SettingsToolStripMenuItem.Text = "Play" Then
            PlayerForm.Show()
        End If
    End Sub

    Private Sub PosX_TextChanged(sender As Object, e As EventArgs) Handles PosX.TextChanged
        Try
            PlayerForm.Top = PosX.Text
        Catch
            PosX.Text = "0"
            ConnectionStatus.Text = "Please enter a number for posX"
        End Try
        'PlayerForm.Left = PosY.Text
    End Sub

    Private Sub PosY_TextChanged(sender As Object, e As EventArgs) Handles PosY.TextChanged
        Try
            PlayerForm.Top = PosX.Text
        Catch
            PosY.Text = "0"
            ConnectionStatus.Text = "Please enter a number for posX"
        End Try
        'PlayerForm.Left = PosY.Text
    End Sub

    Private Sub MainSet_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

    End Sub

    Private Sub MainSet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackgroundWorker1.WorkerSupportsCancellation = True
        BackgroundWorker1.WorkerReportsProgress = True
        AddHandler BackgroundWorker1.DoWork, AddressOf BackgroundWorker1_DoWork
        TextBox1.Text = My.Settings.IP
        PosX.Text = My.Settings.PosX
        PosY.Text = My.Settings.PosY
        LengthText.Text = My.Settings.PlayH
        WidthText.Text = My.Settings.PlayW

    End Sub

    Private Sub LengthText_LostFocus(sender As Object, e As EventArgs) Handles LengthText.LostFocus

        My.Settings.PlayH = CInt(LengthText.Text)


    End Sub

    Private Sub LengthText_TextChanged(sender As Object, e As EventArgs) Handles LengthText.TextChanged

        'PlayerForm.Width = CInt(WidthText.Text)
        'PlayerForm.Width = Integer.Parse(WidthText.Text)
        'PlayerForm.Height = LengthText.Text
        'PlayerForm.Width = 64
    End Sub

    Private Sub WidthText_LostFocus(sender As Object, e As EventArgs) Handles WidthText.LostFocus
        My.Settings.PlayW = CInt(WidthText.Text)
    End Sub

    Private Sub WidthText_TextChanged(sender As Object, e As EventArgs) Handles WidthText.TextChanged
        'PlayerForm.Width = CInt(WidthText.Text)
        'PlayerForm.Height = CInt(LengthText.Text)
    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        connect1()
        If Not BackgroundWorker1.IsBusy = True Then
            BackgroundWorker1.RunWorkerAsync()

        End If
        My.Settings.PosX = PosX.Text
        My.Settings.PosY = PosY.Text
        My.Settings.IP = TextBox1.Text
        My.Settings.Save()
    End Sub

    Private Sub MainSet_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles ConnectionStatus.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim threadOne As New System.Threading.Thread(AddressOf keepreading)
        'threadOne.Start()
        'Call New Action(AddressOf keepreading).BeginInvoke(Nothing, Nothing)
        BackgroundWorker1.CancelAsync()
        'keepreading()
        'reader.ReadLine()
    End Sub
    Public Sub connect1()
        ' Dim server As TcpClient
        'server = Nothing
        ConnectionStatus.Visible = True

        If Button1.Text = "Connect" Then
            Try

                ConnectionStatus.Text = "Connecting..."
                'Dim port As Int32 = 50200
                Dim port As Int32 = 50000
                Dim client As New TcpClient(TextBox1.Text, port)
                'Dim client As New TcpClient("172.16.1.107", port)
                'Dim localAddr As IPAddress = IPAddress.Parse("50.56.75.58")
                'server = New TcpClient(TextBox1.Text, port)

                stream = client.GetStream()
                reader = New StreamReader(stream)
                client.ReceiveTimeout = False
                Dim Data = New [Byte](256) {}
                Dim bytes As Int32 = 0
                Dim responseData As [String] = [String].Empty
                'server.Start()
                ConnectionStatus.Text = "Reachable \ Please Wait..."
                'Dim bytes(1024) As Byte
                'Dim data As String = Nothing
                'Dim responseData As [String] = [String].Empty
                'While Not SocketShutdown.Receive
                'If Not stream.DataAvailable Then
                'MessageBox.Show(bytes = stream.Read(Data, 0, Data.Length))
                'System.Threading.Thread.Sleep(1)
                'ElseIf stream.Read(Data, 0, Data.Length) > 0 Then
                'bytes = stream.Read(Data, 0, Data.Length)
                'While True
                ''bytes = stream.Read(Data, 0, Data.Length)
                'bytes = stream.Read(Data, 0, Data.Length)
                'Dim bytes As Int32 = stream.Read(Data, 0, Data.Length)
                ''responseData = System.Text.Encoding.ASCII.GetString(Data, 0, bytes)
                'While Not reader.ReadLine() Is Nothing
                If dbgen.Checked Then
                    TextBox2.Text = reader.ReadLine() + vbCrLf
                End If
                'TextBox2.Text = TextBox2.Text + reader.ReadLine()
                'TextBox2.Text = TextBox2.Text + reader.ReadLine()
                stream.Flush()

                'End While
                ''TextBox2.Text = TextBox2.Text + responseData


                'Else
                'End While
                'End While
                'End If

                'Console.WriteLine("Received: {0}", responseData)

                ' Enter the listening loop.
                'End While

                ' Shutdown and end connection

            Catch ex As SocketException
                'MessageBox.Show(ex.ToString)
                ConnectionStatus.Text = "Conncection Failed"
                'stream.Close()
            Finally
                'server.Stop()
                'stream.Close()
            End Try

            'Console.WriteLine(ControlChars.Cr + "Hit enter to continue....")
            'Console.Read()

            'Dim netstream As NetworkStream = client.GetStream()

            ' Dim bytes(client.ReceiveBufferSize) As Byte
            'Do Until Not netstream.
            'netstream.Read(bytes, 0, CInt(client.ReceiveBufferSize))

            'Dim datareturn As String = Encoding.ASCII.GetString(bytes)

            'Me.TextBox2.Text = Me.TextBox2.Text + datareturn

            'ConnectionStatus.Text = "Connected"
            'Button1.Text = "Disconnect"
            'Loop
            'End If

            'Catch ex As Exception
            'ConnectionStatus.Text = "NOT Reachable"

            'End Try
        Else

        End If



    End Sub
    Public Sub keepreading()

        Dim epoch = New DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)
        Dim millis = CLng((DateTime.UtcNow - epoch).TotalMilliseconds)


        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf keepreading))
        Else
            'TextBox2.Text = TextBox2.Text + reader.ReadLine() + vbCrLf
            'While True
            'Dim p As Integer = reader.Peek
            'MessageBox.Show(reader.Peek)
            'reader.ReadLine
            'reader.ReadLine()

            Try
                line = reader.ReadLine()
            Catch
            Finally

            End Try

            ''If NOT LINE IS NOTHING STARTS GHE
            If Not line Is Nothing Then
                Try

                    ReconnectTimer.Stop()
                    ReconnectTimer.Enabled = False
                    Dim timed As Long = 0

                    While line.Length > 0
                        Application.DoEvents()
                        ConnectionStatus.Text = "Connected"
                        Dim newline As String = Nothing 'Creates nothing for 'newline'
                        If PosNTop.Checked Then '        'Checks if the checkbox is checked
                            newline = vbCrLf '           If checked, move the POS number above the Car number
                        Else '                             
                            newline = Nothing '
                        End If

                        If BackgroundWorker1.CancellationPending Then
                            BackgroundWorker1.Dispose()
                            GetLineBGW.Dispose()
                            reader.Close()
                            stream.Close()
                            ConnectionStatus.Text = "Disconnected"
                            If dbgen.Checked Then
                                TextBox2.Clear()
                            End If
                            Exit While
                        End If

                        'If CLng((DateTime.UtcNow - epoch).TotalMilliseconds) - millis >= 20 Then
                        'millis = CLng((DateTime.UtcNow - epoch).TotalMilliseconds)
                        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''line = reader.ReadLine()
                        If Not GetLineBGW.IsBusy = True Then
                            GetLineBGW.RunWorkerAsync()

                        End If

                        Application.DoEvents()
                        'TextBox2.Text = line
                        ''' DIM r STARTS HERE
                        Dim r() As String = Split(line, ",")

                        If r(0) = "$G" Then
                                If r(1) = "1" Then
                                'PlayerForm.LapCount.Text = r(3)
                                Lapcount = r(3)
                                'PlayerForm.Pos1.Text = "1  " + newline + r(2).Substring(1, r(2).Length - 2)
                                RacePOS(0) = "1  " + newline + r(2).Substring(1, r(2).Length - 2)
                                End If
                                If r(1) = "2" Then
                                    'PlayerForm.Pos2.Text = "2  " + newline + r(2).Substring(1, r(2).Length - 2) 'IndexOf("\""")
                                    RacePOS(1) = "2  " + newline + r(2).Substring(1, r(2).Length - 2)
                                End If
                                If r(1) = "3" Then
                                    'PlayerForm.Pos3.Text = "3  " + newline + r(2).Substring(1, r(2).Length - 2)
                                    RacePOS(2) = "3  " + newline + r(2).Substring(1, r(2).Length - 2)
                                End If
                                If r(1) = "4" Then
                                    'PlayerForm.Pos4.Text = "4  " + newline + r(2).Substring(1, r(2).Length - 2)
                                    RacePOS(3) = "4  " + newline + r(2).Substring(1, r(2).Length - 2)
                                End If
                                If r(1) = "5" Then
                                    'PlayerForm.Pos5.Text = "5  " + newline + r(2).Substring(1, r(2).Length - 2)
                                    RacePOS(4) = "5  " + newline + r(2).Substring(1, r(2).Length - 2)
                                End If
                                If r(1) = "6" Then
                                    ' PlayerForm.Pos6.Text = "6  " + newline + r(2).Substring(1, r(2).Length - 2)
                                    RacePOS(5) = "6  " + newline + r(2).Substring(1, r(2).Length - 2)
                                End If
                                If r(1) = "7" Then
                                    'PlayerForm.Pos7.Text = "7  " + newline + r(2).Substring(1, r(2).Length - 2)
                                    RacePOS(6) = "7  " + newline + r(2).Substring(1, r(2).Length - 2)
                                End If
                                If r(1) = "8" Then
                                    'PlayerForm.Pos8.Text = "8  " + newline + r(2).Substring(1, r(2).Length - 2)
                                    RacePOS(7) = "8  " + newline + r(2).Substring(1, r(2).Length - 2)
                                End If
                                If r(1) = "9" Then
                                    'PlayerForm.Pos9.Text = "9  " + newline + r(2).Substring(1, r(2).Length - 2)
                                    RacePOS(8) = "9  " + newline + r(2).Substring(1, r(2).Length - 2)
                                End If
                                If r(1) = "10" Then
                                    'PlayerForm.Pos9.Text = "9  " + newline + r(2).Substring(1, r(2).Length - 2)
                                    RacePOS(9) = "10  " + newline + r(2).Substring(1, r(2).Length - 2)
                                End If
                            End If



                        If r(0) = "$H" Then
                            If r(1) = "1" Then
                                'PlayerForm.LapCount.Text = r(3)
                                'Lapcount = r(3)
                                'PlayerForm.Pos1.Text = "1  " + newline + r(2).Substring(1, r(2).Length - 2)
                                QualPOS(0) = "1  " + newline + r(2).Substring(1, r(2).Length - 2)
                            End If
                            If r(1) = "2" Then
                                'PlayerForm.Pos2.Text = "2  " + newline + r(2).Substring(1, r(2).Length - 2) 'IndexOf("\""")
                                QualPOS(1) = "2  " + newline + r(2).Substring(1, r(2).Length - 2)
                            End If
                            If r(1) = "3" Then
                                'PlayerForm.Pos3.Text = "3  " + newline + r(2).Substring(1, r(2).Length - 2)
                                QualPOS(2) = "3  " + newline + r(2).Substring(1, r(2).Length - 2)
                            End If
                            If r(1) = "4" Then
                                'PlayerForm.Pos4.Text = "4  " + newline + r(2).Substring(1, r(2).Length - 2)
                                QualPOS(3) = "4  " + newline + r(2).Substring(1, r(2).Length - 2)
                            End If
                            If r(1) = "5" Then
                                'PlayerForm.Pos5.Text = "5  " + newline + r(2).Substring(1, r(2).Length - 2)
                                QualPOS(4) = "5  " + newline + r(2).Substring(1, r(2).Length - 2)
                            End If
                            If r(1) = "6" Then
                                'PlayerForm.Pos6.Text = "6  " + newline + r(2).Substring(1, r(2).Length - 2)
                                QualPOS(5) = "6  " + newline + r(2).Substring(1, r(2).Length - 2)
                            End If
                            If r(1) = "7" Then
                                'PlayerForm.Pos7.Text = "7  " + newline + r(2).Substring(1, r(2).Length - 2)
                                QualPOS(6) = "7  " + newline + r(2).Substring(1, r(2).Length - 2)
                            End If
                            If r(1) = "8" Then
                                ' PlayerForm.Pos8.Text = "8  " + newline + r(2).Substring(1, r(2).Length - 2)
                                QualPOS(7) = "8  " + newline + r(2).Substring(1, r(2).Length - 2)
                            End If
                            If r(1) = "9" Then

                                'PlayerForm.Pos9.Text = "9  " + newline + r(2).Substring(1, r(2).Length - 2)
                                QualPOS(8) = "9  " + newline + r(2).Substring(1, r(2).Length - 2)
                            End If
                            If r(1) = "10" Then
                                'PlayerForm.Pos9.Text = "10  " + newline + r(2).Substring(1, r(2).Length - 2)
                                QualPOS(9) = "10  " + newline + r(2).Substring(1, r(2).Length - 2)
                            End If
                        End If

                        If r(0) = "$J" Then


                            Dim SplitPassQualTime() = Split(r(2).Substring(1, r(2).Length - 2), ":")
                            Dim Hr = SplitPassQualTime(0) 'Hour
                            Dim Min = SplitPassQualTime(1) 'Minutes
                            Dim Sec = SplitPassQualTime(2) ' Seconds
                            PassQualTime = SplitPassQualTime(2) 'Only passing Seconds to the PassQualTime

                        End If

                        If ScoreModeQual = False Then
                                PlayerForm.LapCount.Text = Lapcount
                                PlayerForm.Pos1.Text = RacePOS(0)
                                PlayerForm.Pos2.Text = RacePOS(1)
                                PlayerForm.Pos3.Text = RacePOS(2)
                                PlayerForm.Pos4.Text = RacePOS(3)
                                PlayerForm.Pos5.Text = RacePOS(4)
                                PlayerForm.Pos6.Text = RacePOS(5)
                                PlayerForm.Pos7.Text = RacePOS(6)
                                PlayerForm.Pos8.Text = RacePOS(7)
                            PlayerForm.Pos9.Text = RacePOS(8)
                            PlayerForm.LapLabel.Text = "Lap"
                        Else
                            PlayerForm.LapCount.Text = PassQualTime
                            PlayerForm.Pos1.Text = QualPOS(0)
                            PlayerForm.Pos2.Text = QualPOS(1)
                            PlayerForm.Pos3.Text = QualPOS(2)
                            PlayerForm.Pos4.Text = QualPOS(3)
                            PlayerForm.Pos5.Text = QualPOS(4)
                            PlayerForm.Pos6.Text = QualPOS(5)
                            PlayerForm.Pos7.Text = QualPOS(6)
                            PlayerForm.Pos8.Text = QualPOS(7)
                            PlayerForm.Pos9.Text = QualPOS(8)
                            PlayerForm.LapLabel.Text = "Time"
                        End If

                        If r(0) = "$F" Then

                                If r(5) = """Green """ Then
                                    If PlayerForm.bordercolor <> Color.Green Then
                                        PlayerForm.bordercolor = Color.Green
                                        'AddHandler PlayerForm.Paint, AddressOf PlayerForm.PlayerForm_Paint
                                        'Me.Controls.Add(PlayerForm)
                                        'ControlPaint.DrawBorder(e.Graphics, PlayerForm.DisplayRectangle, bordercolor, 5, ButtonBorderStyle.Solid, bordercolor, 5, ButtonBorderStyle.Solid, bordercolor, 5, ButtonBorderStyle.Solid, bordercolor, 5, ButtonBorderStyle.Solid)
                                        'PlayerForm.Paint()
                                        PlayerForm.Invalidate()
                                    End If

                                ElseIf r(5) = """Yellow""" Then
                                    If PlayerForm.bordercolor <> Color.Yellow Then
                                        PlayerForm.bordercolor = Color.Yellow
                                        'ControlPaint.DrawBorder(e.Graphics, PlayerForm.DisplayRectangle, bordercolor, 5, ButtonBorderStyle.Solid, bordercolor, 5, ButtonBorderStyle.Solid, bordercolor, 5, ButtonBorderStyle.Solid, bordercolor, 5, ButtonBorderStyle.Solid)
                                        PlayerForm.Invalidate()
                                    End If
                                ElseIf r(5) = """Red   """ Then
                                    If PlayerForm.bordercolor <> Color.Red Then
                                        PlayerForm.bordercolor = Color.Red
                                        'ControlPaint.DrawBorder(.Graphics, PlayerForm.DisplayRectangle, bordercolor, 5, ButtonBorderStyle.Solid, bordercolor, 5, ButtonBorderStyle.Solid, bordercolor, 5, ButtonBorderStyle.Solid, bordercolor, 5, ButtonBorderStyle.Solid)
                                        PlayerForm.Invalidate()
                                    End If
                                ElseIf r(5) = """      """ Then
                                    PlayerForm.bordercolor = Color.Black
                                    'ControlPaint.DrawBorder(.Graphics, PlayerForm.DisplayRectangle, bordercolor, 5, ButtonBorderStyle.Solid, bordercolor, 5, ButtonBorderStyle.Solid, bordercolor, 5, ButtonBorderStyle.Solid, bordercolor, 5, ButtonBorderStyle.Solid)
                                    PlayerForm.Invalidate()
                                Else
                                PlayerForm.bordercolor = Color.Black
                                PlayerForm.Invalidate()
                            End If
                                'Else : End If 'end if for millis


                            End If
                            If dbgen.Checked Then
                            TextBox2.Text = line
                        End If

                        stream.Flush()
                        'MessageBox.Show(reader.EndOfStream)
                        'TextBox2.Update()


                        'System.Threading.Thread.Sleep(100)


                    End While
                Catch e As Exception
                    ConnectionStatus.Text = "error"
                    Console.WriteLine(e)
                    BackgroundWorker1.Dispose()
                    GetLineBGW.Dispose()
                    GetLineBGW.CancelAsync()
                    reader.Close()
                    stream.Close()
                    ConnectionStatus.Text = "Disconnected with Error"
                    If dbgen.Checked Then
                        TextBox2.Clear()
                    End If
                    'MessageBox.Show(e.ToString)
                    ReconnectTimer.Enabled = True
                    ReconnectTimer.Start()

                End Try
            End If
            'If p >= 0 Then
            'Do 'reader.EndOfStream = True
            'If reader.Peek > 0 Then
            'line = reader.ReadLine()

            ''TextBox2.Text = TextBox2.Text + reader.ReadLine + vbCrLf
            ''stream.Flush()
            'MessageBox.Show(reader.EndOfStream)
            ''TextBox2.Update()
            'If line Is Nothing Then
            'Exit Do
            'End If
            'Loop
            'reader.ReadLine()
            'Else

            'End If

            'End While
            'End If
            'MessageBox.Show(reader.)
            'MessageBox.Show(p)
            'Loop
            'reader.Close()
            'End While
        End If

    End Sub




    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        keepreading()
    End Sub

    Private Sub Exitbut_Click(sender As Object, e As EventArgs) Handles Exitbut.Click
        BackgroundWorker1.CancelAsync()
        End
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub dbgen_CheckedChanged(sender As Object, e As EventArgs) Handles dbgen.CheckedChanged
        If Not dbgen.Checked Then
            TextBox2.Clear()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles ReconnectTimer.Tick
        connect1()
        If Not BackgroundWorker1.IsBusy = True Then
            BackgroundWorker1.RunWorkerAsync()

        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.Show()
    End Sub



    Private Sub FontButton_Click(sender As Object, e As EventArgs) Handles FontButton.Click
        If FontDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            'PlayerForm.Pos1.ForeColor = ColorDialog1.Color
            PlayerForm.Pos1.Font = FontDialog1.Font
            PlayerForm.Pos2.Font = FontDialog1.Font
            PlayerForm.Pos3.Font = FontDialog1.Font
            PlayerForm.Pos4.Font = FontDialog1.Font
            PlayerForm.Pos5.Font = FontDialog1.Font
            PlayerForm.Pos6.Font = FontDialog1.Font
            PlayerForm.Pos7.Font = FontDialog1.Font
            PlayerForm.Pos8.Font = FontDialog1.Font
            PlayerForm.Pos9.Font = FontDialog1.Font
        End If
        My.Settings.Font = FontDialog1.Font
        My.Settings.Save()
    End Sub



    Private Sub ResetLocButton_Click(sender As Object, e As EventArgs) Handles ResetLocButton.Click
        Dim rset As Integer = 0
        For Each lbl As Label In {PlayerForm.Pos1, PlayerForm.Pos2, PlayerForm.Pos3, PlayerForm.Pos4, PlayerForm.Pos5, PlayerForm.Pos6, PlayerForm.Pos7, PlayerForm.Pos8, PlayerForm.Pos9}
            With lbl
                lbl.Left = 3
                lbl.Top = 25 + rset
                rset = rset + 20
                lbl.Visible = True
            End With

        Next
    End Sub

    Private Sub SaveLocButton_Click(sender As Object, e As EventArgs) Handles SaveLocButton.Click
        SavePoses()

    End Sub
    Public Sub SavePoses()
        Dim postosave As String = Nothing
        For Each lbl As Label In {PlayerForm.Pos1, PlayerForm.Pos2, PlayerForm.Pos3, PlayerForm.Pos4, PlayerForm.Pos5, PlayerForm.Pos6, PlayerForm.Pos7, PlayerForm.Pos8, PlayerForm.Pos9}
            With lbl
                postosave = postosave + CStr(lbl.Location.X) + "," + CStr(lbl.Location.Y) + ","
            End With
        Next
        postosave = postosave + "END"
        My.Settings.PosLabelPos = postosave
        My.Settings.Save()
    End Sub


    Private Sub GetLineBGW_DoWork(sender As Object, e As DoWorkEventArgs) Handles GetLineBGW.DoWork
        If stream.CanRead Then
            Try
                line = reader.ReadLine()
            Catch
                GetLineBGW.CancelAsync()
            End Try
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            'PlayerForm.Pos1.ForeColor = ColorDialog1.Color
            PlayerForm.Pos1.ForeColor = ColorDialog1.Color
            PlayerForm.Pos2.ForeColor = ColorDialog1.Color
            PlayerForm.Pos3.ForeColor = ColorDialog1.Color
            PlayerForm.Pos4.ForeColor = ColorDialog1.Color
            PlayerForm.Pos5.ForeColor = ColorDialog1.Color
            PlayerForm.Pos6.ForeColor = ColorDialog1.Color
            PlayerForm.Pos7.ForeColor = ColorDialog1.Color
            PlayerForm.Pos8.ForeColor = ColorDialog1.Color
            PlayerForm.Pos9.ForeColor = ColorDialog1.Color
        End If
        My.Settings.FontColor = ColorDialog1.Color
        My.Settings.Save()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            'PlayerForm.Pos1.ForeColor = ColorDialog1.Color
            PlayerForm.BackColor = ColorDialog1.Color

        End If
        'My.Settings.FontColor = ColorDialog1.Color 'Save the Background
        My.Settings.Save()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If FontDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            'PlayerForm.Pos1.ForeColor = ColorDialog1.Color
            PlayerForm.LapLabel.Font = FontDialog1.Font
            PlayerForm.LapCount.Font = FontDialog1.Font

        End If
        'My.Settings.Font = FontDialog1.Font 'if you want to save
        'My.Settings.Save()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            'PlayerForm.Pos1.ForeColor = ColorDialog1.Color
            PlayerForm.LapLabel.ForeColor = ColorDialog1.Color
            PlayerForm.LapCount.ForeColor = ColorDialog1.Color

        End If
        'My.Settings.FontColor = ColorDialog1.Color ' if you want to save
        'My.Settings.Save()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            PlayerForm.WindowState = FormWindowState.Maximized
        Else
            PlayerForm.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            PlayerForm.TopMost = True
        Else
            PlayerForm.TopMost = False
        End If
    End Sub

    Private Sub ScoreQual_CheckedChanged(sender As Object, e As EventArgs) Handles ScoreQual.CheckedChanged
        If ScoreQual.Checked Then
            ScoreModeQual = True
        Else
            ScoreModeQual = False
        End If

    End Sub

    Private Sub ScoreRace_CheckedChanged(sender As Object, e As EventArgs) Handles ScoreRace.CheckedChanged
        If ScoreRace.Checked Then
            ScoreModeQual = False
        Else
            ScoreModeQual = True
        End If
    End Sub
End Class

