Public Class Form1

    Private Sub HomeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeButton.Click
        WebBrowser1.Navigate("http://roblox.com/")
    End Sub

    Private Sub GoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GoButton.Click
        If InStr(1, LCase(UrlBox.Text), "http://") <> 0 Then
            WebBrowser1.Navigate(UrlBox.Text)
        Else
            WebBrowser1.Navigate("http://" & UrlBox.Text)
        End If
    End Sub

    Private Sub WebBrowser1_Navigating(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        UrlBox.Text = WebBrowser1.Url.ToString
    End Sub
End Class
