Public Class Form2
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Reebot the browser to save the settings", MsgBoxStyle.Exclamation)
        My.Settings.DeveloperMode = 1
        My.Settings.Save()
        Button2.Show()
        Button1.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.DeveloperMode = 0
        MsgBox("Please reboot BlueBat Browser exit DEVELOPER MODE", MsgBoxStyle.Exclamation)
        My.Settings.Save()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.DeveloperMode = 0 Then
            Button1.Show()
            Button2.Hide()
        Else
            Button1.Hide()
            Button2.Show()

        End If
    End Sub

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed

    End Sub

    Private Sub Form2_DockChanged(sender As Object, e As EventArgs) Handles Me.DockChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class