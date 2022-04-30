'License Welcome Page

'Class form1
Public Class Form1

    'If rejected, then close software
    Private Sub noButton_Click(sender As Object, e As EventArgs) Handles noButton.Click
        Application.Exit()
    End Sub

    'If accepted, then move on
    Private Sub yesButton_Click(sender As Object, e As EventArgs) Handles yesButton.Click
        Me.Hide()
        Form2.Show()
    End Sub

    'Debug resolution changer
    Function setResolution(ByVal width As UInt16, ByVal height As UInt16)
        Me.Size = New Size(width, height)
    End Function

End Class
