<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LapLabel = New System.Windows.Forms.Label()
        Me.LapCount = New System.Windows.Forms.Label()
        Me.Pos1 = New System.Windows.Forms.Label()
        Me.Pos2 = New System.Windows.Forms.Label()
        Me.Pos3 = New System.Windows.Forms.Label()
        Me.Pos4 = New System.Windows.Forms.Label()
        Me.Pos5 = New System.Windows.Forms.Label()
        Me.Pos6 = New System.Windows.Forms.Label()
        Me.Pos7 = New System.Windows.Forms.Label()
        Me.Pos8 = New System.Windows.Forms.Label()
        Me.Pos9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LapLabel
        '
        Me.LapLabel.AutoSize = True
        Me.LapLabel.BackColor = System.Drawing.Color.Transparent
        Me.LapLabel.ForeColor = System.Drawing.Color.White
        Me.LapLabel.Location = New System.Drawing.Point(4, 4)
        Me.LapLabel.Name = "LapLabel"
        Me.LapLabel.Size = New System.Drawing.Size(28, 13)
        Me.LapLabel.TabIndex = 0
        Me.LapLabel.Text = "Lap:"
        '
        'LapCount
        '
        Me.LapCount.AutoSize = True
        Me.LapCount.BackColor = System.Drawing.Color.Transparent
        Me.LapCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LapCount.ForeColor = System.Drawing.Color.White
        Me.LapCount.Location = New System.Drawing.Point(31, 5)
        Me.LapCount.Name = "LapCount"
        Me.LapCount.Size = New System.Drawing.Size(31, 15)
        Me.LapCount.TabIndex = 1
        Me.LapCount.Text = "999"
        '
        'Pos1
        '
        Me.Pos1.AutoSize = True
        Me.Pos1.BackColor = System.Drawing.Color.Transparent
        Me.Pos1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pos1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pos1.ForeColor = System.Drawing.SystemColors.Control
        Me.Pos1.Location = New System.Drawing.Point(3, 25)
        Me.Pos1.Name = "Pos1"
        Me.Pos1.Size = New System.Drawing.Size(54, 20)
        Me.Pos1.TabIndex = 3
        Me.Pos1.Text = "1 000"
        '
        'Pos2
        '
        Me.Pos2.AutoSize = True
        Me.Pos2.BackColor = System.Drawing.Color.Transparent
        Me.Pos2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pos2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pos2.ForeColor = System.Drawing.SystemColors.Control
        Me.Pos2.Location = New System.Drawing.Point(3, 45)
        Me.Pos2.Name = "Pos2"
        Me.Pos2.Size = New System.Drawing.Size(54, 20)
        Me.Pos2.TabIndex = 4
        Me.Pos2.Text = "2 000"
        '
        'Pos3
        '
        Me.Pos3.AutoSize = True
        Me.Pos3.BackColor = System.Drawing.Color.Transparent
        Me.Pos3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pos3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pos3.ForeColor = System.Drawing.SystemColors.Control
        Me.Pos3.Location = New System.Drawing.Point(3, 65)
        Me.Pos3.Name = "Pos3"
        Me.Pos3.Size = New System.Drawing.Size(54, 20)
        Me.Pos3.TabIndex = 5
        Me.Pos3.Text = "3 000"
        '
        'Pos4
        '
        Me.Pos4.AutoSize = True
        Me.Pos4.BackColor = System.Drawing.Color.Transparent
        Me.Pos4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pos4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pos4.ForeColor = System.Drawing.SystemColors.Control
        Me.Pos4.Location = New System.Drawing.Point(3, 85)
        Me.Pos4.Name = "Pos4"
        Me.Pos4.Size = New System.Drawing.Size(54, 20)
        Me.Pos4.TabIndex = 6
        Me.Pos4.Text = "4 000"
        '
        'Pos5
        '
        Me.Pos5.AutoSize = True
        Me.Pos5.BackColor = System.Drawing.Color.Transparent
        Me.Pos5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pos5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pos5.ForeColor = System.Drawing.SystemColors.Control
        Me.Pos5.Location = New System.Drawing.Point(4, 105)
        Me.Pos5.Name = "Pos5"
        Me.Pos5.Size = New System.Drawing.Size(54, 20)
        Me.Pos5.TabIndex = 7
        Me.Pos5.Text = "5 000"
        '
        'Pos6
        '
        Me.Pos6.AutoSize = True
        Me.Pos6.BackColor = System.Drawing.Color.Transparent
        Me.Pos6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pos6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pos6.ForeColor = System.Drawing.SystemColors.Control
        Me.Pos6.Location = New System.Drawing.Point(4, 126)
        Me.Pos6.Name = "Pos6"
        Me.Pos6.Size = New System.Drawing.Size(54, 20)
        Me.Pos6.TabIndex = 8
        Me.Pos6.Text = "6 000"
        '
        'Pos7
        '
        Me.Pos7.AutoSize = True
        Me.Pos7.BackColor = System.Drawing.Color.Transparent
        Me.Pos7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pos7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pos7.ForeColor = System.Drawing.SystemColors.Control
        Me.Pos7.Location = New System.Drawing.Point(3, 146)
        Me.Pos7.Name = "Pos7"
        Me.Pos7.Size = New System.Drawing.Size(54, 20)
        Me.Pos7.TabIndex = 9
        Me.Pos7.Text = "7 000"
        '
        'Pos8
        '
        Me.Pos8.AutoSize = True
        Me.Pos8.BackColor = System.Drawing.Color.Transparent
        Me.Pos8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pos8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pos8.ForeColor = System.Drawing.SystemColors.Control
        Me.Pos8.Location = New System.Drawing.Point(3, 166)
        Me.Pos8.Name = "Pos8"
        Me.Pos8.Size = New System.Drawing.Size(54, 20)
        Me.Pos8.TabIndex = 10
        Me.Pos8.Text = "8 000"
        '
        'Pos9
        '
        Me.Pos9.AutoSize = True
        Me.Pos9.BackColor = System.Drawing.Color.Transparent
        Me.Pos9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Pos9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pos9.ForeColor = System.Drawing.SystemColors.Control
        Me.Pos9.Location = New System.Drawing.Point(3, 186)
        Me.Pos9.Name = "Pos9"
        Me.Pos9.Size = New System.Drawing.Size(54, 20)
        Me.Pos9.TabIndex = 11
        Me.Pos9.Text = "9 000"
        '
        'PlayerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(256, 256)
        Me.ControlBox = False
        Me.Controls.Add(Me.Pos9)
        Me.Controls.Add(Me.Pos8)
        Me.Controls.Add(Me.Pos7)
        Me.Controls.Add(Me.Pos6)
        Me.Controls.Add(Me.Pos5)
        Me.Controls.Add(Me.Pos4)
        Me.Controls.Add(Me.Pos3)
        Me.Controls.Add(Me.Pos2)
        Me.Controls.Add(Me.Pos1)
        Me.Controls.Add(Me.LapCount)
        Me.Controls.Add(Me.LapLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PlayerForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Player"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LapLabel As Label
    Friend WithEvents LapCount As Label
    Friend WithEvents Pos1 As System.Windows.Forms.Label
    Friend WithEvents Pos2 As System.Windows.Forms.Label
    Friend WithEvents Pos3 As System.Windows.Forms.Label
    Friend WithEvents Pos4 As System.Windows.Forms.Label
    Friend WithEvents Pos5 As System.Windows.Forms.Label
    Friend WithEvents Pos6 As System.Windows.Forms.Label
    Friend WithEvents Pos7 As System.Windows.Forms.Label
    Friend WithEvents Pos8 As System.Windows.Forms.Label
    Friend WithEvents Pos9 As System.Windows.Forms.Label
End Class
