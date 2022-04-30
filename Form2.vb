Public Class Form2

    'EngineVisual Build Variables
    Dim buildDate As String = "4/30/22"
    Dim buildVersion As String = "PR-A143022"




    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Set the versionOut as current buildVersion
        Me.vnOUT.Text = buildVersion

    End Sub

    Private Sub exitGame_Click(sender As Object, e As EventArgs) Handles exitGame.Click
        Application.Exit()
    End Sub

    Private Sub settingsButton_Click(sender As Object, e As EventArgs) Handles settingsButton.Click
        Me.Hide()
        form3.show()
    End Sub
End Class