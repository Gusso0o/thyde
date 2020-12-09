Public Class Form1
    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        WebBrowser1.GoForward()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Refresh()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        If My.Settings.DeveloperMode = True Then
            Form2.Button1.Hide()
            Form2.Button2.Show()
            Me.WebBrowser1.ScriptErrorsSuppressed = False
            Me.Text = "Thyde - DEVELOPER MODE"
        End If
        If My.Settings.DeveloperMode = True Then
            ComboBox1.Show()
        Else
            ComboBox1.Hide()

        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        WebBrowser1.GoBack()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        WebBrowser1.GoForward()
    End Sub
End Class
