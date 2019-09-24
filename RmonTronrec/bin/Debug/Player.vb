Imports System.ComponentModel

Public Class PlayerForm
    Dim drag As Boolean
    Dim dragPOS As Boolean
    Dim mousexPOS As Integer
    Dim mouseyPOS As Integer
    Dim mousex As Integer
    Dim mousey As Integer
    Public bordercolor As Color
    Private Sub PlayerForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MainSet.SettingsToolStripMenuItem.Text = "Stop"
    End Sub

    Private Sub PlayerForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MainSet.SettingsToolStripMenuItem.Text = "Play"
        MainSet.SavePoses()

    End Sub

    Private Sub PlayerForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.SendToBack()
        End If
    End Sub



    Private Sub PlayerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ''Set the Positions of the lables
        Try

            Dim posfrmsave As Array = My.Settings.PosLabelPos.Split(",")
            Dim index As Integer = 0
            For Each lbl As Label In {Me.Pos1, Me.Pos2, Me.Pos3, Me.Pos4, Me.Pos5, Me.Pos6, Me.Pos7, Me.Pos8, Me.Pos9}
                With lbl
                    lbl.Font = My.Settings.Font
                    lbl.Left = CInt(posfrmsave(index))

                    lbl.Top = CInt(posfrmsave(index + 1))

                    index = index + 2

                    'MsgBox(posfrmsave(index))
                    'postosave = postosave + CStr(lbl.Location.X) + "," + CStr(lbl.Location.Y) + ","


                    'lbl.Top = CInt(posfrmsave(index))
                    'lbl.Left = CInt(posfrmsave(index + 1))
                    'MsgBox(posfrmsave(index))
                    'postosave = postosave + CStr(lbl.Location.X) + "," + CStr(lbl.Location.Y) + ","

                End With
            Next
        Catch
        End Try

        ' cc

        Me.Width = MainSet.WidthText.Text
        Me.Height = MainSet.LengthText.Text
        Me.Top = MainSet.PosY.Text
        Me.Left = MainSet.PosX.Text
        Dim toolTip1 As New ToolTip()

        ' Set up the delays for the ToolTip.
        toolTip1.AutoPopDelay = 5000
        toolTip1.InitialDelay = 0
        toolTip1.ReshowDelay = 0
        ' Force the ToolTip text to be displayed whether or not the form is active.
        toolTip1.ShowAlways = True

        ' Set up the ToolTip text for the Button and Checkbox.
        toolTip1.SetToolTip(Me.Pos1, "POS 1")
        toolTip1.SetToolTip(Me.Pos2, "POS 2")
        toolTip1.SetToolTip(Me.Pos3, "POS 3")
        toolTip1.SetToolTip(Me.Pos4, "POS 4")
        toolTip1.SetToolTip(Me.Pos5, "POS 5")
        toolTip1.SetToolTip(Me.Pos6, "POS 6")
        toolTip1.SetToolTip(Me.Pos7, "POS 7")
        toolTip1.SetToolTip(Me.Pos8, "POS 8")
        toolTip1.SetToolTip(Me.Pos9, "POS 9")
        toolTip1.SetToolTip(Me.LapCount, "Lap Counter")
        toolTip1.SetToolTip(Me.LapLabel, "Lap Label")
    End Sub

    Private Sub PlayerForm_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick

    End Sub

    Private Sub PlayerForm_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Me.MouseDoubleClick
        If Me.TopMost = True Then
            Me.TopMost = False
        Else
            Me.TopMost = True
        End If
    End Sub



    Private Sub PlayerForm_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
        If e.Button = Windows.Forms.MouseButtons.Right Then
            For Each lbl As Label In {Me.Pos1, Me.Pos2, Me.Pos3, Me.Pos4, Me.Pos5, Me.Pos6, Me.Pos7, Me.Pos8, Me.Pos9, Me.LapCount, Me.LapLabel}
                With lbl

                    lbl.Visible = True
                End With
            Next
        End If
    End Sub

    Private Sub PlayerForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            MainSet.PosX.Text = Me.Top
            MainSet.PosY.Text = Me.Left
        End If
    End Sub

    Private Sub PlayerForm_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub




    Public Sub PlayerForm_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        'ControlPaint.DrawBorder(e.Graphics, Me.DisplayRectangle, Color.Blue, ButtonBorderStyle.Solid)

        ControlPaint.DrawBorder(e.Graphics, Me.DisplayRectangle, bordercolor, 5, ButtonBorderStyle.Solid, bordercolor, 5, ButtonBorderStyle.Solid, bordercolor, 5, ButtonBorderStyle.Solid, bordercolor, 5, ButtonBorderStyle.Solid)
    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs)

    End Sub

    Private Sub Pos1_MouseDown(sender As Object, e As EventArgs) Handles Pos1.MouseDown
        dragPOS = True
        mousexPOS = Windows.Forms.Cursor.Position.X - Pos1.Left
        mouseyPOS = Windows.Forms.Cursor.Position.Y - Pos1.Top
    End Sub

    Private Sub Pos1_MouseMove(sender As Object, e As MouseEventArgs) Handles Pos1.MouseMove
        If dragPOS Then
            Pos1.Top = Windows.Forms.Cursor.Position.Y - mouseyPOS
            Pos1.Left = Windows.Forms.Cursor.Position.X - mousexPOS
        End If
    End Sub

    Private Sub Pos1_MouseUp(sender As Object, e As MouseEventArgs) Handles Pos1.MouseUp
        dragPOS = False
    End Sub

    Private Sub Pos2_MouseDown(sender As Object, e As EventArgs) Handles Pos2.MouseDown
        dragPOS = True
        mousexPOS = Windows.Forms.Cursor.Position.X - Pos2.Left
        mouseyPOS = Windows.Forms.Cursor.Position.Y - Pos2.Top
    End Sub

    Private Sub Pos2_MouseMove(sender As Object, e As MouseEventArgs) Handles Pos2.MouseMove
        If dragPOS Then
            Pos2.Top = Windows.Forms.Cursor.Position.Y - mouseyPOS
            Pos2.Left = Windows.Forms.Cursor.Position.X - mousexPOS
        End If
    End Sub

    Private Sub Pos2_MouseUp(sender As Object, e As MouseEventArgs) Handles Pos2.MouseUp
        dragPOS = False
    End Sub

    Private Sub Pos3_MouseDown(sender As Object, e As EventArgs) Handles Pos3.MouseDown
        dragPOS = True
        mousexPOS = Windows.Forms.Cursor.Position.X - Pos3.Left
        mouseyPOS = Windows.Forms.Cursor.Position.Y - Pos3.Top
    End Sub

    Private Sub Pos3_MouseMove(sender As Object, e As MouseEventArgs) Handles Pos3.MouseMove
        If dragPOS Then
            Pos3.Top = Windows.Forms.Cursor.Position.Y - mouseyPOS
            Pos3.Left = Windows.Forms.Cursor.Position.X - mousexPOS
        End If
    End Sub

    Private Sub Pos3_MouseUp(sender As Object, e As MouseEventArgs) Handles Pos3.MouseUp
        dragPOS = False
    End Sub

    Private Sub Pos4_MouseDown(sender As Object, e As EventArgs) Handles Pos4.MouseDown
        dragPOS = True
        mousexPOS = Windows.Forms.Cursor.Position.X - Pos4.Left
        mouseyPOS = Windows.Forms.Cursor.Position.Y - Pos4.Top
    End Sub

    Private Sub Pos4_MouseMove(sender As Object, e As MouseEventArgs) Handles Pos4.MouseMove
        If dragPOS Then
            Pos4.Top = Windows.Forms.Cursor.Position.Y - mouseyPOS
            Pos4.Left = Windows.Forms.Cursor.Position.X - mousexPOS
        End If
    End Sub

    Private Sub Pos4_MouseUp(sender As Object, e As MouseEventArgs) Handles Pos4.MouseUp
        dragPOS = False
    End Sub

    Private Sub Pos5_MouseDown(sender As Object, e As EventArgs) Handles Pos5.MouseDown
        dragPOS = True
        mousexPOS = Windows.Forms.Cursor.Position.X - Pos5.Left
        mouseyPOS = Windows.Forms.Cursor.Position.Y - Pos5.Top
    End Sub

    Private Sub Pos5_MouseMove(sender As Object, e As MouseEventArgs) Handles Pos5.MouseMove
        If dragPOS Then
            Pos5.Top = Windows.Forms.Cursor.Position.Y - mouseyPOS
            Pos5.Left = Windows.Forms.Cursor.Position.X - mousexPOS
        End If
    End Sub

    Private Sub Pos5_MouseUp(sender As Object, e As MouseEventArgs) Handles Pos5.MouseUp
        dragPOS = False
    End Sub

    Private Sub Pos6_MouseDown(sender As Object, e As EventArgs) Handles Pos6.MouseDown
        dragPOS = True
        mousexPOS = Windows.Forms.Cursor.Position.X - Pos6.Left
        mouseyPOS = Windows.Forms.Cursor.Position.Y - Pos6.Top
    End Sub

    Private Sub Pos6_MouseMove(sender As Object, e As MouseEventArgs) Handles Pos6.MouseMove
        If dragPOS Then
            Pos6.Top = Windows.Forms.Cursor.Position.Y - mouseyPOS
            Pos6.Left = Windows.Forms.Cursor.Position.X - mousexPOS
        End If
    End Sub

    Private Sub Pos6_MouseUp(sender As Object, e As MouseEventArgs) Handles Pos6.MouseUp
        dragPOS = False
    End Sub

    Private Sub Pos7_MouseDown(sender As Object, e As EventArgs) Handles Pos7.MouseDown
        dragPOS = True
        mousexPOS = Windows.Forms.Cursor.Position.X - Pos7.Left
        mouseyPOS = Windows.Forms.Cursor.Position.Y - Pos7.Top
    End Sub

    Private Sub Pos7_MouseMove(sender As Object, e As MouseEventArgs) Handles Pos7.MouseMove
        If dragPOS Then
            Pos7.Top = Windows.Forms.Cursor.Position.Y - mouseyPOS
            Pos7.Left = Windows.Forms.Cursor.Position.X - mousexPOS
        End If
    End Sub

    Private Sub Pos7_MouseUp(sender As Object, e As MouseEventArgs) Handles Pos7.MouseUp
        dragPOS = False
    End Sub

    Private Sub Pos8_MouseDown(sender As Object, e As EventArgs) Handles Pos8.MouseDown
        dragPOS = True
        mousexPOS = Windows.Forms.Cursor.Position.X - Pos8.Left
        mouseyPOS = Windows.Forms.Cursor.Position.Y - Pos8.Top
    End Sub

    Private Sub Pos8_MouseMove(sender As Object, e As MouseEventArgs) Handles Pos8.MouseMove
        If dragPOS Then
            Pos8.Top = Windows.Forms.Cursor.Position.Y - mouseyPOS
            Pos8.Left = Windows.Forms.Cursor.Position.X - mousexPOS
        End If
    End Sub

    Private Sub Pos8_MouseUp(sender As Object, e As MouseEventArgs) Handles Pos8.MouseUp
        dragPOS = False
    End Sub

    Private Sub Pos9_MouseDown(sender As Object, e As EventArgs) Handles Pos9.MouseDown
        dragPOS = True
        mousexPOS = Windows.Forms.Cursor.Position.X - Pos9.Left
        mouseyPOS = Windows.Forms.Cursor.Position.Y - Pos9.Top
    End Sub

    Private Sub Pos9_MouseMove(sender As Object, e As MouseEventArgs) Handles Pos9.MouseMove
        If dragPOS Then
            Pos9.Top = Windows.Forms.Cursor.Position.Y - mouseyPOS
            Pos9.Left = Windows.Forms.Cursor.Position.X - mousexPOS
        End If
    End Sub

    Private Sub Pos9_MouseUp(sender As Object, e As MouseEventArgs) Handles Pos9.MouseUp
        dragPOS = False

    End Sub
    Private Sub LapCounter_MouseDown(sender As Object, e As EventArgs) Handles LapCount.MouseDown
        dragPOS = True
        mousexPOS = Windows.Forms.Cursor.Position.X - LapCount.Left
        mouseyPOS = Windows.Forms.Cursor.Position.Y - LapCount.Top
    End Sub

    Private Sub LapCounter_MouseMove(sender As Object, e As MouseEventArgs) Handles LapCount.MouseMove
        If dragPOS Then
            LapCount.Top = Windows.Forms.Cursor.Position.Y - mouseyPOS
            LapCount.Left = Windows.Forms.Cursor.Position.X - mousexPOS
        End If
    End Sub

    Private Sub LapCounter_MouseUp(sender As Object, e As MouseEventArgs) Handles LapCount.MouseUp
        dragPOS = False

    End Sub
    Private Sub LapLabel_MouseDown(sender As Object, e As EventArgs) Handles LapLabel.MouseDown
        dragPOS = True
        mousexPOS = Windows.Forms.Cursor.Position.X - LapLabel.Left
        mouseyPOS = Windows.Forms.Cursor.Position.Y - LapLabel.Top
    End Sub

    Private Sub LapLabel_MouseMove(sender As Object, e As MouseEventArgs) Handles LapLabel.MouseMove
        If dragPOS Then
            LapLabel.Top = Windows.Forms.Cursor.Position.Y - mouseyPOS
            LapLabel.Left = Windows.Forms.Cursor.Position.X - mousexPOS
        End If
    End Sub

    Private Sub LapLabel_MouseUp(sender As Object, e As MouseEventArgs) Handles LapLabel.MouseUp
        dragPOS = False

    End Sub

    Private Sub PosRclick(sender As Object, e As MouseEventArgs) Handles Pos1.MouseDown, Pos2.MouseDown, Pos3.MouseDown, Pos4.MouseDown, Pos5.MouseDown, Pos6.MouseDown, Pos7.MouseDown, Pos8.MouseDown, Pos9.MouseDown, LapCount.MouseDown, LapLabel.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then

            sender.Visible = False

            'MessageBox.Show("mouse right click")
        End If

    End Sub


End Class