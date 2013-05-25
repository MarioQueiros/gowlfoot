Public Class relatório_de_jogo
    Public res1, res2 As Integer
    Public vencedor As String
    Public tatica1, tatica2 As String
    Public faltas As String
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

    Public Sub CarregaValores(ByVal r1 As String, ByVal r2 As String, ByVal v As String, ByVal t1 As String, ByVal t2 As String, ByVal f As String)
        Me.Label5.Text = r1
        Me.Label6.Text = r2
        Me.Label8.Text = v
        Me.Label12.Text = t1
        Me.Label13.Text = t2
        Me.Label11.Text = f
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Dim mensagem As String
        mensagem = "Equipa 1: Pontos = " + equipas.pontosequipa1.ToString() + Environment.NewLine + _
                   "Golos sofridos = " + equipas.gsequipa1.ToString() + Environment.NewLine + _
                   "Golos marcados = " + equipas.gmequipa1.ToString() + Environment.NewLine + _
                   "Vitórias = " + equipas.vitoriasequipa1.ToString() + Environment.NewLine + _
                   "Empates = " + equipas.empatesequipa1.ToString() + Environment.NewLine + _
                   "Derrotas = " + equipas.derrotasequipa1.ToString() + Environment.NewLine + _
                   "Equipa 2: Pontos = " + equipas.pontosequipa2.ToString() + Environment.NewLine + _
                   "Golos sofridos = " + equipas.gsequipa2.ToString() + Environment.NewLine + _
                   "Golos marcados = " + equipas.gmequipa2.ToString() + Environment.NewLine + _
                   "Vitórias = " + equipas.vitoriasequipa2.ToString() + Environment.NewLine + _
                   "Empates = " + equipas.empatesequipa2.ToString() + Environment.NewLine + _
                   "Derrotas = " + equipas.derrotasequipa2.ToString()
        campeonato.Show()
        totais.Close()
        Me.Close()
    End Sub

End Class