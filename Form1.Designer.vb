<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.blackBackground = New System.Windows.Forms.PictureBox()
        Me.l7 = New System.Windows.Forms.Label()
        Me.l5 = New System.Windows.Forms.Label()
        Me.l6 = New System.Windows.Forms.Label()
        Me.l4 = New System.Windows.Forms.Label()
        Me.l3 = New System.Windows.Forms.Label()
        Me.l2 = New System.Windows.Forms.Label()
        Me.yesButton = New System.Windows.Forms.Button()
        Me.l1 = New System.Windows.Forms.Label()
        Me.noButton = New System.Windows.Forms.Button()
        CType(Me.blackBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'blackBackground
        '
        Me.blackBackground.Image = Global.EngineVisual.My.Resources.Resources.black
        Me.blackBackground.InitialImage = Global.EngineVisual.My.Resources.Resources.black
        Me.blackBackground.Location = New System.Drawing.Point(0, 0)
        Me.blackBackground.Name = "blackBackground"
        Me.blackBackground.Size = New System.Drawing.Size(640, 480)
        Me.blackBackground.TabIndex = 0
        Me.blackBackground.TabStop = False
        '
        'l7
        '
        Me.l7.AutoSize = True
        Me.l7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.l7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.l7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.l7.Location = New System.Drawing.Point(12, 21)
        Me.l7.Name = "l7"
        Me.l7.Size = New System.Drawing.Size(587, 25)
        Me.l7.TabIndex = 1
        Me.l7.Text = "This software is licensed under 'GNU General Public License v3.0'"
        '
        'l5
        '
        Me.l5.AutoSize = True
        Me.l5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.l5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.l5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.l5.Location = New System.Drawing.Point(33, 82)
        Me.l5.Name = "l5"
        Me.l5.Size = New System.Drawing.Size(552, 21)
        Me.l5.TabIndex = 2
        Me.l5.Text = "Commercial use, Distribution, Modification, Patent use, and Private use"
        '
        'l6
        '
        Me.l6.AutoSize = True
        Me.l6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.l6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.l6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.l6.Location = New System.Drawing.Point(151, 61)
        Me.l6.Name = "l6"
        Me.l6.Size = New System.Drawing.Size(312, 21)
        Me.l6.TabIndex = 3
        Me.l6.Text = "You are allowed to use EngineVisual for"
        '
        'l4
        '
        Me.l4.AutoSize = True
        Me.l4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.l4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.l4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.l4.Location = New System.Drawing.Point(151, 119)
        Me.l4.Name = "l4"
        Me.l4.Size = New System.Drawing.Size(321, 21)
        Me.l4.TabIndex = 4
        Me.l4.Text = "The conditions of using EngineVisual are"
        '
        'l3
        '
        Me.l3.AutoSize = True
        Me.l3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.l3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.l3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.l3.Location = New System.Drawing.Point(28, 140)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(584, 15)
        Me.l3.TabIndex = 5
        Me.l3.Text = "Disclosing source, License and copyright notice, Network use is distribution, Sam" &
    "e license, State changes"
        '
        'l2
        '
        Me.l2.AutoSize = True
        Me.l2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.l2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.l2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.l2.Location = New System.Drawing.Point(165, 176)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(298, 21)
        Me.l2.TabIndex = 6
        Me.l2.Text = "This software comes with no warranty"
        '
        'yesButton
        '
        Me.yesButton.Location = New System.Drawing.Point(197, 319)
        Me.yesButton.Name = "yesButton"
        Me.yesButton.Size = New System.Drawing.Size(75, 23)
        Me.yesButton.TabIndex = 7
        Me.yesButton.Text = "Yes"
        Me.yesButton.UseVisualStyleBackColor = True
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.l1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.l1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.l1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.l1.Location = New System.Drawing.Point(197, 295)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(215, 21)
        Me.l1.TabIndex = 8
        Me.l1.Text = "Do you accept this license?"
        '
        'noButton
        '
        Me.noButton.Location = New System.Drawing.Point(337, 319)
        Me.noButton.Name = "noButton"
        Me.noButton.Size = New System.Drawing.Size(75, 23)
        Me.noButton.TabIndex = 9
        Me.noButton.Text = "No"
        Me.noButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 441)
        Me.Controls.Add(Me.noButton)
        Me.Controls.Add(Me.l1)
        Me.Controls.Add(Me.yesButton)
        Me.Controls.Add(Me.l2)
        Me.Controls.Add(Me.l3)
        Me.Controls.Add(Me.l4)
        Me.Controls.Add(Me.l6)
        Me.Controls.Add(Me.l5)
        Me.Controls.Add(Me.l7)
        Me.Controls.Add(Me.blackBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "EngineVisual"
        CType(Me.blackBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents blackBackground As PictureBox
    Friend WithEvents l7 As Label
    Friend WithEvents l5 As Label
    Friend WithEvents l6 As Label
    Friend WithEvents l4 As Label
    Friend WithEvents l3 As Label
    Friend WithEvents l2 As Label
    Friend WithEvents yesButton As Button
    Friend WithEvents l1 As Label
    Friend WithEvents noButton As Button
End Class
