Imports System.Data.SqlClient
Imports System.Math
Imports System.Threading
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports System.Random


Public Class totais
 
    Dim varsql1e1 As String
    Dim varsql2e1 As String
    Dim varsql3e1 As String
    Dim varsql4e1 As String
    Dim varsql1e2 As String
    Dim varsql2e2 As String
    Dim varsql3e2 As String
    Dim varsql4e2 As String
    Dim varelatogol1 As String
    Dim varelatogol2 As String
    Dim varelatogol3 As String
    Dim varelatogol4 As String
    Dim varelatogol5 As String
    Dim varelatogol6 As String
    Dim totdefe1, totdefesae1, totmeioe1, totavane1, totredese1 As Integer
    Dim totdefe2, totdefesae2, totmeioe2, totavane2, totredese2 As Integer
    Dim up1e1 As String
    Dim up2e1 As String
    Dim up3e1 As String
    Dim up4e1 As String
    Dim up1e2 As String
    Dim up2e2 As String
    Dim up3e2 As String
    Dim up4e2 As String
    Dim totdef As Integer
    Dim totdef2 As Integer
    Dim varfixa As Double = 0.16
    Dim amarelos, vermelhos As Integer
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
 


    Private Sub totais_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        amarelos = 0
        vermelhos = 0
        equipas.Enabled = False

        Try
            ProgressBar1.Step = 2
            Dim totredese1 As IO.StreamReader
            Dim totdefe1 As IO.StreamReader
            Dim totmeioe1 As IO.StreamReader
            Dim totavane1 As IO.StreamReader
            Dim totredese2 As IO.StreamReader
            Dim totdefe2 As IO.StreamReader
            Dim totmeioe2 As IO.StreamReader
            Dim totavane2 As IO.StreamReader

            totredese1 = New IO.StreamReader("c:/jogo/totredese1")
            totdefe1 = New IO.StreamReader("c:/jogo/totdefe1")
            totmeioe1 = New IO.StreamReader("c:/jogo/totmeioe1")
            totavane1 = New IO.StreamReader("c:/jogo/totavane1")
            totredese2 = New IO.StreamReader("c:/jogo/totredese2")
            totdefe2 = New IO.StreamReader("c:/jogo/totdefe2")
            totmeioe2 = New IO.StreamReader("c:/jogo/totmeioe2")
            totavane2 = New IO.StreamReader("c:/jogo/totavane2")
            up1e1 = totredese1.ReadLine
            up2e1 = totdefe1.ReadLine
            up3e1 = totmeioe1.ReadLine
            up4e1 = totavane1.ReadLine
            up1e2 = totredese2.ReadLine
            up2e2 = totdefe2.ReadLine
            up3e2 = totmeioe2.ReadLine
            up4e2 = totavane2.ReadLine
            totdef = CInt(up1e1) + CInt(up2e1)
            totdef2 = CInt(up1e2) + CInt(up2e2)
        Catch ex As Exception
            MessageBox.Show("Erro: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Dim numero As Double
    Dim numero2 As Double
    Dim numero3 As Double
    Dim numero4 As Double
    Dim numero5 As Double
    Dim numero6 As Double
    Dim num As Double
    Dim defe1 As Double
    Dim defe2 As Double
    Dim meioe1 As Double
    Dim meioe2 As Double
    Dim avane1 As Double
    Dim avane2 As Double
    Dim gerador As New Random(Now.Millisecond)
    Dim gerarrelatos As New Random(Now.Millisecond)
    Dim gereljogo As New Random(Now.Millisecond)
    Dim numrelato As Integer
    Dim numrelato2 As Integer
    Dim ifgolo1 As Integer
    Dim ifnogolo2 As Integer
    Private alarmTime As Date
    Dim i As Integer = 0
    Dim MyProgress As Integer
    Dim falta As Random = New Random()
    Dim tipofalta As Random = New Random()
    Dim gtipofalta As Integer
    Dim viu As Random = New Random()
    Dim gviu As Integer
    Dim marca As Random = New Random()
    Dim gmarca As Integer
    Dim cartao As Random = New Random()
    Dim gcartao As Integer
    Dim tipocartao As Random = New Random()
    Dim gtipocartao As Integer
    Dim numfalta As Integer
    Dim numfalta1 As Random = New Random()
    Dim faltasleves As Integer
    Function geradornumeros() As Double
        Dim RandomClass As New Random()
        num = Round(gerador.NextDouble(), 2)
        num = num * RandomClass.Next(1, 5)
        If num = 0 Then
            geradornumeros()
        End If
        Return (num)
    End Function

    Function ifgolo() As Integer
        If avane2 > defe1 Then
            i = i + 1
            Me.TextBox19.Text = i
            Me.Timer3.Enabled = True
        Else
            relato2 = gereljogos()
            Me.Timer2.Enabled = True
        End If
        If avane1 > defe2 Then
            i = i + 1
            Me.TextBox20.Text = i
            Me.Timer3.Enabled = True
        Else
            relato2 = gereljogos()
            Me.Timer2.Enabled = True
        End If
    End Function
    Dim tempo As Integer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If alarmTime < Date.Now Then
            Me.Timer1.Stop()
        Else
            If MyProgress < 100 Then
                MyProgress = MyProgress + 1
                tempo = MyProgress / 93
                tempo = Round(MyProgress)
                ProgressBar1.Value = MyProgress
                If MyProgress = 46 Then
                    Me.Timer1.Enabled = False
                    If MessageBox.Show("Deseja começar a segunda parte?", "Confirmar", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                        Me.Timer1.Enabled = True
                    Else
                        Me.PictureBox6.Visible = True
                        Me.PictureBox5.Visible = False
                    End If
                End If
            End If
            If MyProgress > 90 Then
                Label7.Text = "Descontos"
                Me.ProgressBar1.Value = 100
                Me.PictureBox5.Visible = False
            Else
                Label7.Text = tempo
            End If
            If ProgressBar1.Value = 100 Then
                Me.Timer1.Enabled = False
                Me.Timer2.Enabled = False
                Me.Timer3.Enabled = False
                Me.Timer4.Enabled = False
                PictureBox7.Visible = True

            End If
            'If MyProgress = 100 Then
            '    ProgressBar1.Visible = False
            'End If
            numero = geradornumeros()
            numero2 = geradornumeros()
            numero3 = geradornumeros()
            numero4 = geradornumeros()
            numero5 = geradornumeros()
            numero6 = geradornumeros()
            defe1 = totdef * numero
            avane2 = up4e2 * numero2 * varfixa
            meioe1 = up3e1 * numero3
            meioe2 = up3e2 * numero4
            defe2 = totdef * numero5
            avane1 = up4e1 * numero6 * varfixa
            ifgolo1 = ifgolo()
        End If
    End Sub
    Dim relato As Integer
    Dim relato2 As Integer
    Function gerarnumrelatos() As Integer
        numrelato = gerarrelatos.Next(0, 7)
        Return (numrelato)
    End Function
    Function gereljogos() As Integer
        numrelato2 = gerarrelatos.Next(0, 11)
        Return (numrelato2)
    End Function

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        relato2 = gerarnumrelatos()
        Me.Timer4.Enabled = True
        If relato2 = 8 Then
            Me.Label10.Text = "Um adepto pediu a bola e o avançado desperdiçou o remate e fez-lhe o jeitinho!"
        ElseIf relato2 = 3 Then
            Me.Label10.Text = "Mas que remate fraco!!! Devem-se ter esquecido de dar jantar a este homem!"
        ElseIf relato2 = 12 Then
            Me.Label10.Text = "Que falhanço incrivel, até a minha avózinha marcava isto!"
        ElseIf relato2 = 5 Then
            Me.Label10.Text = "Como foi possível falhar desta maneira? Era como roubar um doce a uma criança."
        ElseIf relato2 = 2 Then
            Me.Label10.Text = "Entre este guarda-redes e uma muralha de ferro, não vejo grande diferença. Os avançados estão a desesperar."
        ElseIf relato2 = 10 Then
            Me.Label10.Text = "O guarda-redes com certeza comprou luvas com imans! Grandes defesas!"
        ElseIf relato2 = 1 Then
            Me.Label10.Text = "Quando vinha para este jogo passei ao lado de uma escola e vi crianças a rematarem melhor!"
        ElseIf relato2 = 11 Then
            Me.Label10.Text = "O treinador acaba de perder o único cabelo que lhe restava após mais um falhanço épico da sua equipa."
        ElseIf relato2 = 4 Then
            Me.Label10.Text = "Ainda bem que estou a assistir a este jogo. Após este falhanço, de certeza que se me contassem eu não iria acreditar!"
        ElseIf relato2 = 9 Then
            Me.Label10.Text = "Sem dúvida! Um kilómetro ao lado e era golo!"
        ElseIf relato2 = 7 Then
            Me.Label10.Text = "O guarda-redes defende um magnifico remate... Que ia fora."
        ElseIf relato2 = 6 Then
            Me.Label10.Text = "Não é de dúvidar que a bola não entre. O guarda-redes é o super-homem."
        Else
            Me.Label10.Text = ""
        End If
        Me.Timer2.Enabled = False
    End Sub
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        relato = gerarnumrelatos()
        If relato = 1 Then
            Me.Label10.Text = "O guarda-redes foi ao café e o avançado marcou GOLO!"
            My.Computer.Audio.Play(Application.StartupPath & "\applause.wav")
        ElseIf relato = 2 Then
            Me.Label10.Text = "O avançado disparou de canhão e o guarda-redes entrou pela baliza dentro! GOLO!"
            My.Computer.Audio.Play(Application.StartupPath & "\applause.wav")
        ElseIf relato = 3 Then
            Me.Label10.Text = "A sofrer golos destes não me admira que o guarda-redes seja promovido a desempregado. Um bom trabalho do avançado."
            My.Computer.Audio.Play(Application.StartupPath & "\applause.wav")
        ElseIf relato = 4 Then
            Me.Label10.Text = "O avançado chuta com o pé que está mais à mão - É GOLO!"
            My.Computer.Audio.Play(Application.StartupPath & "\applause.wav")
        ElseIf relato = 5 Then
            Me.Label10.Text = "O jogador domina, passa, chuta, enquanto a bola chega à baliza todos aproveitam para uma suecada e...  GOLO!"
            My.Computer.Audio.Play(Application.StartupPath & "\applause.wav")
        ElseIf relato = 6 Then
            Me.Label10.Text = "Até sem pés ele tinha marcado. Golo fácil."
            My.Computer.Audio.Play(Application.StartupPath & "\applause.wav")
        End If
        Me.Timer3.Enabled = False
        ' Me.Timer1.Enabled = True
    End Sub
    'Private trd As Thread
    'Private Sub falta1()
    '    tipfalta()
    '    'trd = New Thread(AddressOf tipfalta)
    '    'trd.IsBackground = True
    '    'trd.Start()
    'End Sub


    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        faltas()
    End Sub
    Dim car1 As Integer
    Dim car As Integer
    Dim contfaltas As Integer
    Sub faltas()
        Label12.Text = "Pareceu haver falta no jogo."
        gviu = viu.Next(0, 3)
        If gviu = 1 Then
            gmarca = marca.Next(0, 3)
            If gmarca = 1 Then
                Label12.Text = "Houve mesmo falta no jogo."
                contfaltas = contfaltas + 1
            End If
            gtipofalta = tipofalta.Next(0, 3)
            If gtipofalta = 1 Then
                Label12.Text = "Uma falta bastante dura! Um cartão deve ser dado!"
                car = cartao.Next(0, 3)
                If car = 1 Then
                    car1 = tipocartao.Next(0, 3)
                    If car1 = 1 Then
                        Label12.Text = "O jogador levou cartão amarelo."
                        amarelos = amarelos + 1
                    ElseIf car1 = 2 Then
                        Label12.Text = "O jogador levou cartão vermelho e foi expulso!"
                        vermelhos = vermelhos + 1
                    End If
                ElseIf car = 2 Then
                    Label12.Text = "Jogador não levou nenhum cartão. A falta foi marcada e o jogo seguiu."
                End If
            ElseIf gtipofalta = 2 Then
                Label12.Text = "A falta foi marcada e o jogo seguiu."
            End If
        ElseIf gviu = 2 Then
            Label12.Text = "O árbitro não viu qualquer tipo de falta. O jogo não foi interrompido e segue sem problemas."
        End If
        Me.Timer4.Enabled = False
    End Sub
    Dim eq1 As String
    Dim eq2 As String
    Dim goma1 As String
    Dim goma2 As String
    Dim goso1 As String
    Dim goso2 As String
    Dim vie1 As String
    Dim vie2 As String
    Dim der1 As String
    Dim der2 As String
    Dim empe1 As String
    Dim empe2 As String
    Dim jogos1 As String
    Dim jogos2 As String

    Dim a As Integer
    Dim b As Integer
    Dim c As Integer
    Dim d As Integer
    Dim ee As Integer
    Dim f As Integer
    Dim g As Integer
    Dim h As Integer
    Dim j As Integer
    Dim k As Integer
    Dim l As Integer
    Dim m As Integer
    Dim n As Integer
    Dim o As Integer


    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Me.Timer1.Enabled = True
        Me.TextBox19.Enabled = False
        Me.TextBox20.Enabled = False
        Me.TextBox19.Text = "0"
        Me.TextBox20.Text = "0"
        Me.Label10.Visible = True
        Me.Label10.Text = ""
        Me.alarmTime = Date.Now.AddSeconds(90)


        PictureBox3.Visible = False
        PictureBox5.Visible = True
        PictureBox6.Visible = False
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Me.Timer1.Enabled = False
        Me.Timer2.Enabled = False
        Me.Timer3.Enabled = False
        PictureBox5.Visible = False
        PictureBox6.Visible = True
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Me.Timer1.Enabled = True
        Me.Timer2.Enabled = True
        Me.Timer3.Enabled = True
        PictureBox6.Visible = False
        PictureBox5.Visible = True
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        Const constr As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=|datadirectory|jogadores.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
        Dim db As New SqlConnection(constr)
        db.Open()
        Dim va1 As String
        Dim va2 As String
        Dim va3 As String
        Dim va4 As String
        Dim va5 As String
        Dim va6 As String
        Dim va7 As String
        Dim va8 As String
        Dim va9 As String
        Dim va10 As String
        Dim va11 As String
        Dim va12 As String
        Dim va13 As String
        Dim va14 As String



        eq1 = "select p1 from classificacao"
        eq2 = "select p2 from classificacao"
        goma1 = "select gm1 from classificacao"
        goma2 = "select gm2 from classificacao"
        goso1 = "select gs1 from classificacao"
        goso2 = "select gs2 from classificacao"
        vie1 = "select vit1 from classificacao"
        vie2 = "select vit2 from classificacao"
        der1 = "select de1 from classificacao"
        der2 = "select de2 from classificacao"
        empe1 = "select em1 from classificacao"
        empe2 = "select em2 from classificacao"
        jogos1 = "select jo1 from classificacao"
        jogos2 = "select jo2 from classificacao"







        Dim cd As New SqlCommand(eq1, db)
        Dim cd2 As New SqlCommand(eq2, db)
        Dim cd3 As New SqlCommand(goma1, db)
        Dim cd4 As New SqlCommand(goma2, db)
        Dim cdd5 As New SqlCommand(goso1, db)
        Dim cd6 As New SqlCommand(goso2, db)
        Dim cd7 As New SqlCommand(vie1, db)
        Dim cd8 As New SqlCommand(vie2, db)
        Dim cd9 As New SqlCommand(der1, db)
        Dim cd10 As New SqlCommand(der2, db)
        Dim cd11 As New SqlCommand(empe1, db)
        Dim cd12 As New SqlCommand(empe2, db)
        Dim cd13 As New SqlCommand(jogos1, db)
        Dim cd14 As New SqlCommand(jogos2, db)


        Dim dr As SqlDataReader
        Dim dr2 As SqlDataReader
        Dim dr3 As SqlDataReader
        Dim dr4 As SqlDataReader
        Dim drr1 As SqlDataReader
        Dim dr6 As SqlDataReader
        Dim dr7 As SqlDataReader
        Dim dr8 As SqlDataReader
        Dim dr9 As SqlDataReader
        Dim dr10 As SqlDataReader
        Dim dr11 As SqlDataReader
        Dim dr12 As SqlDataReader
        Dim dr13 As SqlDataReader
        Dim dr14 As SqlDataReader

        Dim res1 As Integer = Convert.ToInt16(TextBox19.Text)
        Dim res2 As Integer = Convert.ToInt16(TextBox20.Text)
        'Dim equipa1 As IO.StreamWriter = New IO.StreamWriter("C:\jogo\equipa1")
        'Dim equipa2 As IO.StreamWriter = New IO.StreamWriter("C:\jogo\equipa2")
        'Dim gome1 As IO.StreamWriter = New IO.StreamWriter("C:\jogo\gm1")

        dr = cd.ExecuteReader
        While dr.Read()
            a = CInt(dr.Item("p1"))
        End While
        dr.Close()
        dr2 = cd2.ExecuteReader
        While dr2.Read()
            b = CInt(dr2.Item("p2"))
        End While
        dr2.Close()
        dr3 = cd3.ExecuteReader
        While dr3.Read()
            c = CInt(dr3.Item("gm1"))
        End While
        dr3.Close()
        dr4 = cd4.ExecuteReader
        While dr4.Read()
            d = CInt(dr4.Item("gm2"))
        End While
        dr4.Close()
        drr1 = cdd5.ExecuteReader
        While drr1.Read()
            ee = CInt(drr1.Item("gs1"))
        End While
        drr1.Close()
        dr6 = cd6.ExecuteReader
        While dr6.Read()
            f = CInt(dr6.Item("gs2"))
        End While
        dr6.Close()
        dr7 = cd7.ExecuteReader
        While dr7.Read()
            g = CInt(dr7.Item("vit1"))
        End While
        dr7.Close()
        dr8 = cd8.ExecuteReader
        While dr8.Read()
            h = CInt(dr8.Item("vit2"))
        End While
        dr8.Close()
        dr9 = cd9.ExecuteReader
        While dr9.Read()
            j = CInt(dr9.Item("de1"))
        End While
        dr9.Close()
        dr10 = cd10.ExecuteReader
        While dr10.Read()
            k = CInt(dr10.Item("de2"))
        End While
        dr10.Close()
        dr11 = cd11.ExecuteReader
        While dr11.Read()
            l = CInt(dr11.Item("em1"))
        End While
        dr11.Close()
        dr12 = cd12.ExecuteReader
        While dr12.Read()
            m = CInt(dr12.Item("em2"))
        End While
        dr12.Close()
        dr13 = cd13.ExecuteReader
        While dr13.Read()
            n = CInt(dr13.Item("jo1"))
        End While
        dr13.Close()
        dr14 = cd14.ExecuteReader
        While dr14.Read()
            o = CInt(dr14.Item("jo2"))
        End While
        dr14.Close()
        Dim a1 As Integer
        Dim a2 As Integer
        Dim a3 As Integer
        Dim a4 As Integer
        Dim a5 As Integer
        Dim a6 As Integer
        Dim a7 As Integer
        Dim a8 As Integer
        Dim a9 As Integer
        Dim a10 As Integer
        Dim a11 As Integer
        Dim a12 As Integer
        Dim a13 As Integer
        Dim a14 As Integer

        a3 = c + res1
        va3 = "update classificacao set gm1=" & a3 & " where gm1=" & c & ""
        Dim cmd3 As New SqlCommand(va3, db)
        cmd3.ExecuteScalar()


        'gome1.Write(goma1)
        'gome1.Close()
        'Dim gome2 As IO.StreamWriter = New IO.StreamWriter("C:\jogo\gm2")
        a4 = d + res2
        va4 = "update classificacao set gm2=" & a4 & " where gm2=" & d & ""
        Dim cmd4 As New SqlCommand(va4, db)
        cmd4.ExecuteScalar()

        'gome2.Write(goma2)
        'gome2.Close()
        'Dim gose1 As IO.StreamWriter = New IO.StreamWriter("C:\jogo\gs1")
        a5 = ee + res2
        va5 = "update classificacao set gs1=" & a5 & " where gs1=" & ee & ""
        Dim cmd5 As New SqlCommand(va5, db)
        cmd5.ExecuteScalar()

        'gose1.Write(goso1)
        'gose1.Close()
        'Dim gose2 As IO.StreamWriter = New IO.StreamWriter("C:\jogo\gs2")
        a6 = f + res1
        va6 = "update classificacao set gs2=" & a6 & " where gs2=" & f & ""
        Dim cmd6 As New SqlCommand(va6, db)
        cmd6.ExecuteScalar()

        'gose2.Write(goso2)
        'gose2.Close()
        'Dim v1 As IO.StreamWriter = New IO.StreamWriter("C:\jogo\vit1")
        'Dim v2 As IO.StreamWriter = New IO.StreamWriter("C:\jogo\vit2")
        'Dim d1 As IO.StreamWriter = New IO.StreamWriter("C:\jogo\de1")
        'Dim d2 As IO.StreamWriter = New IO.StreamWriter("C:\jogo\de2")
        'Dim e1 As IO.StreamWriter = New IO.StreamWriter("C:\jogo\emp1")
        'Dim e2 As IO.StreamWriter = New IO.StreamWriter("C:\jogo\emp2")
        'Dim j1 As IO.StreamWriter = New IO.StreamWriter("C:\jogo\jo1")
        a13 = n + 1
        va13 = "update classificacao set jo1=" & a13 & " where jo1=" & n & ""
        Dim cmd13 As New SqlCommand(va13, db)
        cmd13.ExecuteScalar()

        'j1.Write(jogos1)
        'j1.Close()
        'Dim j2 As IO.StreamWriter = New IO.StreamWriter("C:\jogo\jo2")
        a14 = o + 1
        va14 = "update classificacao set jo2=" & a14 & " where jo2=" & o & ""
        Dim cmd14 As New SqlCommand(va14, db)
        cmd14.ExecuteScalar()

        'j2.Write(jogos2)
        'j2.Close()

        Dim tat1 As String = ""
        Dim tat2 As String = ""
        Dim vencedor As String = ""
        Dim faltasCometidas As String = "Faltas: " + contfaltas.ToString() + Environment.NewLine + _
                        amarelos.ToString() + " cartões amarelos, " + vermelhos.ToString() + " cartões vermelhos " + Environment.NewLine

        If (res1 > res2) Then

            a1 = a + 3
            va1 = "update classificacao set p1=" & a1 & " where p1=" & a & ""
            Dim cmd As New SqlCommand(va1, db)
            cmd.ExecuteScalar()

            'equipa1.Write(eq1)
            'equipa1.Close()
            a7 = g + 1
            va7 = "update classificacao set vit1=" & a7 & " where vit1=" & g & ""
            Dim cmd7 As New SqlCommand(va7, db)
            cmd7.ExecuteScalar()

            'v1.Write(vie1)
            'v1.Close()
            a10 = k + 1
            va10 = "update classificacao set de2=" & a10 & " where de2=" & k & ""
            Dim cmd10 As New SqlCommand(va10, db)
            cmd10.ExecuteScalar()

            'd2.Write(der2)
            'd2.Close()
            vencedor = "F. C. Porto"
        ElseIf (res2 > res1) Then
            a2 = b + 3
            va2 = "update classificacao set p2=" & a2 & " where p2=" & b & ""
            Dim cmd2 As New SqlCommand(va2, db)
            cmd2.ExecuteScalar()

            'equipa2.Write(eq2)
            'equipa2.Close()
            a8 = h + 1
            va8 = "update classificacao set vit2=" & a8 & " where vit2=" & h & ""
            Dim cmd8 As New SqlCommand(va8, db)
            cmd8.ExecuteScalar()

            'v2.Write(vie2)
            'v2.Close()
            a9 = j + 1
            va9 = "update classificacao set de1=" & a9 & " where de1=" & j & ""
            Dim cmd9 As New SqlCommand(va9, db)
            cmd9.ExecuteScalar()

            'd1.Write(der1)
            'd1.Close()
            vencedor = "S. L. Benfica"
        ElseIf (res1 = res2) Then
            a1 = a + 1
            va1 = "update classificacao set p1=" & a1 & " where p1=" & a & ""
            Dim cmd As New SqlCommand(va1, db)
            cmd.ExecuteScalar()

            'equipa1.Write(eq1)
            'equipa1.Close()
            a2 = b + 1
            va2 = "update classificacao set p2=" & a2 & " where p2=" & b & ""
            Dim cmd2 As New SqlCommand(va2, db)
            cmd2.ExecuteScalar()

            'equipa2.Write(eq2)
            'equipa2.Close()
            a11 = l + 1
            va11 = "update classificacao set em1=" & a11 & " where em1=" & l & ""
            Dim cmd11 As New SqlCommand(va11, db)
            cmd11.ExecuteScalar()

            'e1.Write(empe1)
            'e1.Close()
            a12 = m + 1
            va12 = "update classificacao set em2=" & a12 & " where em2=" & m & ""
            Dim cmd12 As New SqlCommand(va12, db)
            cmd12.ExecuteScalar()

            'e2.Write(empe2)
            'e2.Close()
            vencedor = "Empate"
        End If

        If My.Computer.FileSystem.DirectoryExists("C:\jogo") Then
            If My.Computer.FileSystem.FileExists("C:\jogo\tatica") Then
                Dim tat As IO.StreamReader = New IO.StreamReader("C:\jogo\tatica")
                tat1 = tat.ReadLine
                tat.Close()
            End If
            If My.Computer.FileSystem.FileExists("C:\jogo\tatica2") Then
                Dim tat As IO.StreamReader = New IO.StreamReader("C:\jogo\tatica2")
                tat2 = tat.ReadLine
                tat.Close()
            End If
        End If
        relatório_de_jogo.CarregaValores(TextBox19.Text.Trim(), TextBox20.Text.Trim(), vencedor, tat1, tat2, faltasCometidas)
        relatório_de_jogo.Show()
        db.Close()
        equipas.Close()
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        equipas.Enabled = True
        equipas.Show()
        Me.Close()
    End Sub
End Class