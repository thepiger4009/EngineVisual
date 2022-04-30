<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.mainMenuBG = New System.Windows.Forms.PictureBox()
        Me.vnOUT = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.settingsButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.exitGame = New System.Windows.Forms.Button()
        CType(Me.mainMenuBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainMenuBG
        '
        Me.mainMenuBG.Image = Global.EngineVisual.My.Resources.Resources.black
        Me.mainMenuBG.InitialImage = Global.EngineVisual.My.Resources.Resources.black
        Me.mainMenuBG.Location = New System.Drawing.Point(-3, -4)
        Me.mainMenuBG.Name = "mainMenuBG"
        Me.mainMenuBG.Size = New System.Drawing.Size(630, 448)
        Me.mainMenuBG.TabIndex = 1
        Me.mainMenuBG.TabStop = False
        '
        'vnOUT
        '
        Me.vnOUT.AutoSize = True
        Me.vnOUT.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.vnOUT.Font = New System.Drawing.Font("Unispace", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.vnOUT.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.vnOUT.Location = New System.Drawing.Point(238, 125)
        Me.vnOUT.Name = "vnOUT"
        Me.vnOUT.Size = New System.Drawing.Size(178, 23)
        Me.vnOUT.TabIndex = 2
        Me.vnOUT.Text = "Version Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("SimSun-ExtB", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(194, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "EngineVisual"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(211, 220)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(205, 41)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "New Game"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(211, 267)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(205, 41)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Load Game"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'settingsButton
        '
        Me.settingsButton.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.settingsButton.Location = New System.Drawing.Point(211, 314)
        Me.settingsButton.Name = "settingsButton"
        Me.settingsButton.Size = New System.Drawing.Size(205, 47)
        Me.settingsButton.TabIndex = 6
        Me.settingsButton.Text = "Settings"
        Me.settingsButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Unispace", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(194, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(226, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "thepiger4009 @2022"
        '
        'exitGame
        '
        Me.exitGame.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.exitGame.Location = New System.Drawing.Point(211, 367)
        Me.exitGame.Name = "exitGame"
        Me.exitGame.Size = New System.Drawing.Size(205, 47)
        Me.exitGame.TabIndex = 8
        Me.exitGame.Text = "Exit"
        Me.exitGame.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.exitGame)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.settingsButton)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.vnOUT)
        Me.Controls.Add(Me.mainMenuBG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "EngineVisual"
        CType(Me.mainMenuBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainMenuBG As PictureBox
    Friend WithEvents vnOUT As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents settingsButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents exitGame As Button
End Class
