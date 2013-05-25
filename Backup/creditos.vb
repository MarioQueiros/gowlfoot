Imports System.Drawing.Size
Public Class creditos
    Private WM_NCHITTEST As Integer = &H84
    Private HTCLIENT As Integer = &H1          ' arrastar
    Private HTCAPTION As Integer = &H2
    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)
        Select Case m.Msg
            Case WM_NCHITTEST
                If m.Result = New IntPtr(HTCLIENT) Then
                    m.Result = New IntPtr(HTCAPTION)
                End If
        End Select
    End Sub

    Private Sub creditos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AxWebBrowser1.Visible = True
        AxWebBrowser1.Width = 595
        AxWebBrowser1.Height = 383
        AxWebBrowser1.Navigate(Application.StartupPath & "\gowl.swf")
        Timer1.Enabled = True
    End Sub
    Dim sec As Integer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        sec = sec + 1
        If sec = 31 Then
            AxWebBrowser1.Enabled = False
            AxWebBrowser1.Visible = False
            principal.Show()
            Me.Close()
        End If
    End Sub
End Class