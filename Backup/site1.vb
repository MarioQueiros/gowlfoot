Public Class site1

    Private Sub site_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("www.gowlfoot.pt.la")
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        principal.Show()
        Me.Close()
    End Sub
End Class