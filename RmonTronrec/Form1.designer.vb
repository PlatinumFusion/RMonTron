<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainSet
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PosY = New System.Windows.Forms.TextBox()
        Me.PosX = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ConnectionStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Exitbut = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dbgen = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ReconnectTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.FontButton = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.PosNTop = New System.Windows.Forms.CheckBox()
        Me.ResetLocButton = New System.Windows.Forms.Button()
        Me.SaveLocButton = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.LengthText = New System.Windows.Forms.NumericUpDown()
        Me.WidthText = New System.Windows.Forms.NumericUpDown()
        Me.GetLineBGW = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ScoreQual = New System.Windows.Forms.RadioButton()
        Me.ScoreRace = New System.Windows.Forms.RadioButton()
        Me.ScoreAuto = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.LengthText, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WidthText, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.ExitToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(577, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SettingsToolStripMenuItem.Text = "Play"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "H x W"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Pos."
        '
        'PosY
        '
        Me.PosY.Location = New System.Drawing.Point(92, 60)
        Me.PosY.MaxLength = 5
        Me.PosY.Name = "PosY"
        Me.PosY.Size = New System.Drawing.Size(47, 20)
        Me.PosY.TabIndex = 6
        Me.PosY.Text = "64"
        '
        'PosX
        '
        Me.PosX.Location = New System.Drawing.Point(40, 60)
        Me.PosX.MaxLength = 5
        Me.PosX.Name = "PosX"
        Me.PosX.Size = New System.Drawing.Size(46, 20)
        Me.PosX.TabIndex = 5
        Me.PosX.Text = "64"
        Me.PosX.WordWrap = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(116, 20)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Text = "50.56.75.58"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Connect"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(6, 17)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(293, 21)
        Me.TextBox2.TabIndex = 9
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectionStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 228)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(577, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ConnectionStatus
        '
        Me.ConnectionStatus.Name = "ConnectionStatus"
        Me.ConnectionStatus.Size = New System.Drawing.Size(75, 17)
        Me.ConnectionStatus.Text = "?Connected?"
        Me.ConnectionStatus.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 74)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Disconnect"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'Exitbut
        '
        Me.Exitbut.Location = New System.Drawing.Point(9, 196)
        Me.Exitbut.Name = "Exitbut"
        Me.Exitbut.Size = New System.Drawing.Size(49, 23)
        Me.Exitbut.TabIndex = 12
        Me.Exitbut.Text = "Exit"
        Me.Exitbut.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dbgen)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(145, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 61)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Debug"
        '
        'dbgen
        '
        Me.dbgen.AutoSize = True
        Me.dbgen.Location = New System.Drawing.Point(7, 42)
        Me.dbgen.Name = "dbgen"
        Me.dbgen.Size = New System.Drawing.Size(59, 17)
        Me.dbgen.TabIndex = 10
        Me.dbgen.Text = "Enable"
        Me.dbgen.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 86)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(129, 104)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "IP Address"
        '
        'ReconnectTimer
        '
        Me.ReconnectTimer.Interval = 50
        '
        'FontButton
        '
        Me.FontButton.Location = New System.Drawing.Point(6, 42)
        Me.FontButton.Name = "FontButton"
        Me.FontButton.Size = New System.Drawing.Size(40, 23)
        Me.FontButton.TabIndex = 15
        Me.FontButton.Text = "Font"
        Me.FontButton.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 71)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(63, 23)
        Me.Button3.TabIndex = 16
        Me.Button3.Text = "Text Color"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckBox2)
        Me.GroupBox3.Controls.Add(Me.CheckBox1)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.ResetLocButton)
        Me.GroupBox3.Controls.Add(Me.SaveLocButton)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Location = New System.Drawing.Point(138, 92)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(326, 127)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Player Style"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(6, 72)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(98, 17)
        Me.CheckBox2.TabIndex = 24
        Me.CheckBox2.Text = "Always On Top"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 55)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(99, 17)
        Me.CheckBox1.TabIndex = 23
        Me.CheckBox1.Text = "Start Fullscreen"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button6)
        Me.GroupBox5.Controls.Add(Me.Button5)
        Me.GroupBox5.Location = New System.Drawing.Point(238, 14)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(81, 107)
        Me.GroupBox5.TabIndex = 22
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Lap Counter"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(6, 70)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(63, 23)
        Me.Button6.TabIndex = 19
        Me.Button6.Text = "Text Color"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(6, 41)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(40, 23)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "Font"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.PosNTop)
        Me.GroupBox4.Controls.Add(Me.FontButton)
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Location = New System.Drawing.Point(122, 13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(109, 108)
        Me.GroupBox4.TabIndex = 21
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Positions"
        '
        'PosNTop
        '
        Me.PosNTop.AutoSize = True
        Me.PosNTop.Location = New System.Drawing.Point(6, 19)
        Me.PosNTop.Name = "PosNTop"
        Me.PosNTop.Size = New System.Drawing.Size(96, 17)
        Me.PosNTop.TabIndex = 18
        Me.PosNTop.Text = "Place # on top"
        Me.PosNTop.UseVisualStyleBackColor = True
        '
        'ResetLocButton
        '
        Me.ResetLocButton.Location = New System.Drawing.Point(53, 98)
        Me.ResetLocButton.Name = "ResetLocButton"
        Me.ResetLocButton.Size = New System.Drawing.Size(44, 23)
        Me.ResetLocButton.TabIndex = 20
        Me.ResetLocButton.Text = "Reset"
        Me.ResetLocButton.UseVisualStyleBackColor = True
        '
        'SaveLocButton
        '
        Me.SaveLocButton.Location = New System.Drawing.Point(7, 98)
        Me.SaveLocButton.Name = "SaveLocButton"
        Me.SaveLocButton.Size = New System.Drawing.Size(40, 23)
        Me.SaveLocButton.TabIndex = 19
        Me.SaveLocButton.Text = "Save"
        Me.SaveLocButton.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(7, 14)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 37)
        Me.Button4.TabIndex = 17
        Me.Button4.Text = "Backgound Color"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'LengthText
        '
        Me.LengthText.Location = New System.Drawing.Point(40, 27)
        Me.LengthText.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.LengthText.Minimum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.LengthText.Name = "LengthText"
        Me.LengthText.Size = New System.Drawing.Size(46, 20)
        Me.LengthText.TabIndex = 18
        Me.LengthText.Value = New Decimal(New Integer() {256, 0, 0, 0})
        '
        'WidthText
        '
        Me.WidthText.Location = New System.Drawing.Point(92, 27)
        Me.WidthText.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.WidthText.Minimum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.WidthText.Name = "WidthText"
        Me.WidthText.Size = New System.Drawing.Size(47, 20)
        Me.WidthText.TabIndex = 19
        Me.WidthText.Value = New Decimal(New Integer() {256, 0, 0, 0})
        '
        'GetLineBGW
        '
        Me.GetLineBGW.WorkerSupportsCancellation = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ScoreAuto)
        Me.GroupBox6.Controls.Add(Me.ScoreRace)
        Me.GroupBox6.Controls.Add(Me.ScoreQual)
        Me.GroupBox6.Location = New System.Drawing.Point(470, 27)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(97, 90)
        Me.GroupBox6.TabIndex = 20
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Score Type"
        '
        'ScoreQual
        '
        Me.ScoreQual.AutoSize = True
        Me.ScoreQual.Location = New System.Drawing.Point(6, 19)
        Me.ScoreQual.Name = "ScoreQual"
        Me.ScoreQual.Size = New System.Drawing.Size(83, 17)
        Me.ScoreQual.TabIndex = 0
        Me.ScoreQual.Text = "Qualify Time"
        Me.ScoreQual.UseVisualStyleBackColor = True
        '
        'ScoreRace
        '
        Me.ScoreRace.AutoSize = True
        Me.ScoreRace.Location = New System.Drawing.Point(6, 42)
        Me.ScoreRace.Name = "ScoreRace"
        Me.ScoreRace.Size = New System.Drawing.Size(51, 17)
        Me.ScoreRace.TabIndex = 1
        Me.ScoreRace.Text = "Race"
        Me.ScoreRace.UseVisualStyleBackColor = True
        '
        'ScoreAuto
        '
        Me.ScoreAuto.AutoSize = True
        Me.ScoreAuto.Checked = True
        Me.ScoreAuto.Location = New System.Drawing.Point(6, 65)
        Me.ScoreAuto.Name = "ScoreAuto"
        Me.ScoreAuto.Size = New System.Drawing.Size(47, 17)
        Me.ScoreAuto.TabIndex = 2
        Me.ScoreAuto.TabStop = True
        Me.ScoreAuto.Text = "Auto"
        Me.ScoreAuto.UseVisualStyleBackColor = True
        '
        'MainSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 250)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.WidthText)
        Me.Controls.Add(Me.LengthText)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Exitbut)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PosY)
        Me.Controls.Add(Me.PosX)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainSet"
        Me.Text = "rMonTron Setup 1.2 Beta"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.LengthText, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WidthText, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PosY As TextBox
    Friend WithEvents PosX As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ConnectionStatus As ToolStripStatusLabel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Exitbut As System.Windows.Forms.Button
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dbgen As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ReconnectTimer As System.Windows.Forms.Timer
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents FontButton As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents PosNTop As System.Windows.Forms.CheckBox
    Friend WithEvents SaveLocButton As System.Windows.Forms.Button
    Friend WithEvents ResetLocButton As System.Windows.Forms.Button
    Friend WithEvents LengthText As System.Windows.Forms.NumericUpDown
    Friend WithEvents WidthText As System.Windows.Forms.NumericUpDown
    Friend WithEvents GetLineBGW As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents ScoreAuto As RadioButton
    Friend WithEvents ScoreRace As RadioButton
    Friend WithEvents ScoreQual As RadioButton
End Class
