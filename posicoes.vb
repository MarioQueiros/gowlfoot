Imports System.Data
Imports System.Data.SqlClient
Public Class posicoes
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

    Dim tatica As String
    Dim e1j1 As String
    Dim e1j2 As String
    Dim e1j3 As String
    Dim e1j4 As String
    Dim e1j5 As String
    Dim e1j6 As String
    Dim e1j7 As String
    Dim e1j8 As String
    Dim e1j9 As String
    Dim e1j10 As String
    Dim e1j11 As String
    'procedimento para carregar os jogadores para a sua respectiva área do campo
    Private Sub posicoes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists("C:\jogo\tatica") Then
            Dim tat As IO.StreamReader
            Dim e1jog1 As IO.StreamReader
            Dim e1jog2 As IO.StreamReader
            Dim e1jog3 As IO.StreamReader
            Dim e1jog4 As IO.StreamReader
            Dim e1jog5 As IO.StreamReader
            Dim e1jog6 As IO.StreamReader
            Dim e1jog7 As IO.StreamReader
            Dim e1jog8 As IO.StreamReader
            Dim e1jog9 As IO.StreamReader
            Dim e1jog10 As IO.StreamReader
            Dim e1jog11 As IO.StreamReader
            If Dir$("C:\jogo\tatica") <> "" Then
                tat = New IO.StreamReader("C:\jogo\tatica")
                tatica = tat.ReadLine
                Try
                    e1jog1 = New IO.StreamReader("C:\jogo\e1jog1")
                    e1jog2 = New IO.StreamReader("C:\jogo\e1jog2")
                    e1jog3 = New IO.StreamReader("C:\jogo\e1jog3")
                    e1jog4 = New IO.StreamReader("C:\jogo\e1jog4")
                    e1jog5 = New IO.StreamReader("C:\jogo\e1jog5")
                    e1jog6 = New IO.StreamReader("C:\jogo\e1jog6")
                    e1jog7 = New IO.StreamReader("C:\jogo\e1jog7")
                    e1jog8 = New IO.StreamReader("C:\jogo\e1jog8")
                    e1jog9 = New IO.StreamReader("C:\jogo\e1jog9")
                    e1jog10 = New IO.StreamReader("C:\jogo\e1jog10")
                    e1jog11 = New IO.StreamReader("C:\jogo\e1jog11")
                    e1j1 = e1jog1.ReadLine
                    e1j2 = e1jog2.ReadLine
                    e1j3 = e1jog3.ReadLine
                    e1j4 = e1jog4.ReadLine
                    e1j5 = e1jog5.ReadLine
                    e1j6 = e1jog6.ReadLine
                    e1j7 = e1jog7.ReadLine
                    e1j8 = e1jog8.ReadLine
                    e1j9 = e1jog9.ReadLine
                    e1j10 = e1jog10.ReadLine
                    e1j11 = e1jog11.ReadLine
                    If tatica = "5-4-1" Then
                        ComboBox1.Visible = True
                        ComboBox2.Visible = True
                        ComboBox3.Visible = True
                        ComboBox19.Visible = False
                        ComboBox4.Visible = True
                        ComboBox20.Visible = False
                        ComboBox5.Visible = True
                        ComboBox6.Visible = True
                        ComboBox7.Visible = True
                        ComboBox8.Visible = False
                        ComboBox18.Visible = True
                        ComboBox9.Visible = False
                        ComboBox17.Visible = True
                        ComboBox10.Visible = False
                        ComboBox11.Visible = True
                        ComboBox12.Visible = False
                        ComboBox13.Visible = False
                        ComboBox14.Visible = True
                        ComboBox15.Visible = False
                        ComboBox16.Visible = False
                        ComboItemsAdd(ComboBox1)
                        ComboItemsAdd(ComboBox2)
                        ComboItemsAdd(ComboBox3)
                        ComboItemsAdd(ComboBox4)
                        ComboItemsAdd(ComboBox5)
                        ComboItemsAdd(ComboBox6)
                        ComboItemsAdd(ComboBox7)
                        ComboItemsAdd(ComboBox11)
                        ComboItemsAdd(ComboBox14)
                        ComboItemsAdd(ComboBox17)
                        ComboItemsAdd(ComboBox18)
                    ElseIf tatica = "5-3-2" Then
                        ComboBox1.Visible = True
                        ComboBox2.Visible = True
                        ComboBox3.Visible = True
                        ComboBox19.Visible = False
                        ComboBox4.Visible = True
                        ComboBox20.Visible = False
                        ComboBox5.Visible = True
                        ComboBox6.Visible = True
                        ComboBox7.Visible = False
                        ComboBox8.Visible = True
                        ComboBox18.Visible = False
                        ComboBox9.Visible = True
                        ComboBox17.Visible = False
                        ComboBox10.Visible = True
                        ComboBox11.Visible = False
                        ComboBox12.Visible = False
                        ComboBox13.Visible = True
                        ComboBox14.Visible = False
                        ComboBox15.Visible = True
                        ComboBox16.Visible = False
                        ComboItemsAdd(ComboBox1)
                        ComboItemsAdd(ComboBox2)
                        ComboItemsAdd(ComboBox3)
                        ComboItemsAdd(ComboBox4)
                        ComboItemsAdd(ComboBox5)
                        ComboItemsAdd(ComboBox6)
                        ComboItemsAdd(ComboBox8)
                        ComboItemsAdd(ComboBox9)
                        ComboItemsAdd(ComboBox10)
                        ComboItemsAdd(ComboBox13)
                        ComboItemsAdd(ComboBox15)
                    ElseIf tatica = "4-3-3" Then
                        ComboBox1.Visible = True
                        ComboBox2.Visible = True
                        ComboBox3.Visible = False
                        ComboBox19.Visible = True
                        ComboBox4.Visible = False
                        ComboBox20.Visible = True
                        ComboBox5.Visible = False
                        ComboBox6.Visible = True
                        ComboBox7.Visible = False
                        ComboBox8.Visible = True
                        ComboBox18.Visible = False
                        ComboBox9.Visible = True
                        ComboBox17.Visible = False
                        ComboBox10.Visible = True
                        ComboBox11.Visible = False
                        ComboBox12.Visible = True
                        ComboBox13.Visible = False
                        ComboBox14.Visible = True
                        ComboBox15.Visible = False
                        ComboBox16.Visible = True
                        ComboItemsAdd(ComboBox1)
                        ComboItemsAdd(ComboBox2)
                        ComboItemsAdd(ComboBox6)
                        ComboItemsAdd(ComboBox8)
                        ComboItemsAdd(ComboBox9)
                        ComboItemsAdd(ComboBox10)
                        ComboItemsAdd(ComboBox12)
                        ComboItemsAdd(ComboBox14)
                        ComboItemsAdd(ComboBox16)
                        ComboItemsAdd(ComboBox19)
                        ComboItemsAdd(ComboBox20)
                    ElseIf tatica = "4-4-2" Then
                        ComboBox1.Visible = True
                        ComboBox2.Visible = True
                        ComboBox3.Visible = False
                        ComboBox19.Visible = True
                        ComboBox4.Visible = False
                        ComboBox20.Visible = True
                        ComboBox5.Visible = False
                        ComboBox6.Visible = True
                        ComboBox7.Visible = True
                        ComboBox8.Visible = False
                        ComboBox18.Visible = True
                        ComboBox9.Visible = False
                        ComboBox17.Visible = True
                        ComboBox10.Visible = False
                        ComboBox11.Visible = True
                        ComboBox12.Visible = False
                        ComboBox13.Visible = True
                        ComboBox14.Visible = False
                        ComboBox15.Visible = True
                        ComboBox16.Visible = False
                        ComboItemsAdd(ComboBox1)
                        ComboItemsAdd(ComboBox2)
                        ComboItemsAdd(ComboBox6)
                        ComboItemsAdd(ComboBox7)
                        ComboItemsAdd(ComboBox11)
                        ComboItemsAdd(ComboBox13)
                        ComboItemsAdd(ComboBox15)
                        ComboItemsAdd(ComboBox17)
                        ComboItemsAdd(ComboBox18)
                        ComboItemsAdd(ComboBox19)
                        ComboItemsAdd(ComboBox20)
                    ElseIf tatica = "4-5-1" Then
                        ComboBox1.Visible = True
                        ComboBox2.Visible = True
                        ComboBox3.Visible = False
                        ComboBox19.Visible = True
                        ComboBox4.Visible = False
                        ComboBox20.Visible = True
                        ComboBox5.Visible = False
                        ComboBox6.Visible = True
                        ComboBox7.Visible = True
                        ComboBox8.Visible = True
                        ComboBox18.Visible = False
                        ComboBox9.Visible = True
                        ComboBox17.Visible = False
                        ComboBox10.Visible = True
                        ComboBox11.Visible = True
                        ComboBox12.Visible = False
                        ComboBox13.Visible = False
                        ComboBox14.Visible = True
                        ComboBox15.Visible = False
                        ComboBox16.Visible = False
                        ComboItemsAdd(ComboBox1)
                        ComboItemsAdd(ComboBox2)
                        ComboItemsAdd(ComboBox6)
                        ComboItemsAdd(ComboBox7)
                        ComboItemsAdd(ComboBox8)
                        ComboItemsAdd(ComboBox9)
                        ComboItemsAdd(ComboBox10)
                        ComboItemsAdd(ComboBox11)
                        ComboItemsAdd(ComboBox14)
                        ComboItemsAdd(ComboBox19)
                        ComboItemsAdd(ComboBox20)
                    ElseIf tatica = "3-4-3" Then
                        ComboBox1.Visible = True
                        ComboBox2.Visible = False
                        ComboBox3.Visible = True
                        ComboBox19.Visible = False
                        ComboBox4.Visible = True
                        ComboBox20.Visible = False
                        ComboBox5.Visible = True
                        ComboBox6.Visible = False
                        ComboBox7.Visible = True
                        ComboBox8.Visible = False
                        ComboBox18.Visible = True
                        ComboBox9.Visible = False
                        ComboBox17.Visible = True
                        ComboBox10.Visible = False
                        ComboBox11.Visible = True
                        ComboBox12.Visible = True
                        ComboBox13.Visible = False
                        ComboBox14.Visible = True
                        ComboBox15.Visible = False
                        ComboBox16.Visible = True
                        ComboItemsAdd(ComboBox1)
                        ComboItemsAdd(ComboBox3)
                        ComboItemsAdd(ComboBox4)
                        ComboItemsAdd(ComboBox5)
                        ComboItemsAdd(ComboBox7)
                        ComboItemsAdd(ComboBox11)
                        ComboItemsAdd(ComboBox12)
                        ComboItemsAdd(ComboBox14)
                        ComboItemsAdd(ComboBox16)
                        ComboItemsAdd(ComboBox17)
                        ComboItemsAdd(ComboBox18)
                    ElseIf tatica = "3-5-2" Then
                        ComboBox1.Visible = True
                        ComboBox2.Visible = False
                        ComboBox3.Visible = True
                        ComboBox19.Visible = False
                        ComboBox4.Visible = True
                        ComboBox20.Visible = False
                        ComboBox5.Visible = True
                        ComboBox6.Visible = False
                        ComboBox7.Visible = True
                        ComboBox8.Visible = True
                        ComboBox18.Visible = False
                        ComboBox9.Visible = True
                        ComboBox17.Visible = False
                        ComboBox10.Visible = True
                        ComboBox11.Visible = True
                        ComboBox12.Visible = False
                        ComboBox13.Visible = True
                        ComboBox14.Visible = False
                        ComboBox15.Visible = True
                        ComboBox16.Visible = False
                        ComboItemsAdd(ComboBox1)
                        ComboItemsAdd(ComboBox3)
                        ComboItemsAdd(ComboBox4)
                        ComboItemsAdd(ComboBox5)
                        ComboItemsAdd(ComboBox7)
                        ComboItemsAdd(ComboBox8)
                        ComboItemsAdd(ComboBox9)
                        ComboItemsAdd(ComboBox10)
                        ComboItemsAdd(ComboBox11)
                        ComboItemsAdd(ComboBox13)
                        ComboItemsAdd(ComboBox15)
                    End If
                    tat.Close()
                Catch ex As Exception
                    MsgBox("Aconteceu um erro na execução.", MsgBoxStyle.Information, "Erro")
                End Try
            End If
        Else
            MkDir("C:\jogo")
            SetAttr("C:\jogo", vbHidden)
        End If
    End Sub
    Private Function DoSQLCommand(ByVal sql As String, ByVal item As String)
        Dim result As String = ""
        Const constr As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=|datadirectory|jogadores.mdf;Integrated Security=True;User Instance=True"
        Dim db As New SqlConnection(constr)
        db.Open()
        Dim cmd As New SqlCommand(sql, db)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        While dr.Read()
            result = dr.Item(item)
        End While
        dr.Close()
        Return result
    End Function
    'procedimento para recolher os valores da base de dados das características dos jogadores
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim jog1, jog2, jog3, jog4, jog5, jog6, jog7, jog8, jog9, jog10, jog11 As String
            Dim totdef, totmeio, totavan, totredes As String
            Dim con1, con2, con3, con4, con5, con6, con7, con8, con9, con10, con11 As Integer
            Dim tot1, tot2, tot3, tot4 As Integer
            If tatica = "5-4-1" Then
                jog1 = ComboBox1.SelectedItem
                jog2 = ComboBox2.SelectedItem
                jog3 = ComboBox3.SelectedItem
                jog4 = ComboBox4.SelectedItem
                jog5 = ComboBox5.SelectedItem
                jog6 = ComboBox6.SelectedItem
                jog7 = ComboBox7.SelectedItem
                jog8 = ComboBox18.SelectedItem
                jog9 = ComboBox17.SelectedItem
                jog10 = ComboBox11.SelectedItem
                jog11 = ComboBox14.SelectedItem
                Dim red1 As String = DoSQLCommand("SELECT guardaredes  FROM jogadores where nome = '" & jog1 & "'", "guardaredes")
                Dim def2 As String = DoSQLCommand("SELECT defesa FROM jogadores where nome = '" & jog2 & "'", "defesa")
                Dim def3 As String = DoSQLCommand("SELECT defesa FROM jogadores where nome = '" & jog3 & "'", "defesa")
                Dim def4 As String = DoSQLCommand("SELECT defesa FROM jogadores where nome = '" & jog4 & "'", "defesa")
                Dim def5 As String = DoSQLCommand("SELECT defesa FROM jogadores where nome = '" & jog5 & "'", "defesa")
                Dim def6 As String = DoSQLCommand("SELECT defesa FROM jogadores where nome = '" & jog6 & "'", "defesa")
                Dim meio7 As String = DoSQLCommand("SELECT meiocampo FROM jogadores where nome = '" & jog7 & "'", "meiocampo")
                Dim meio8 As String = DoSQLCommand("SELECT meiocampo FROM jogadores where nome = '" & jog8 & "'", "meiocampo")
                Dim meio9 As String = DoSQLCommand("SELECT  meiocampo FROM jogadores where nome = '" & jog9 & "'", "meiocampo")
                Dim meio10 As String = DoSQLCommand("SELECT  meiocampo FROM jogadores where nome = '" & jog10 & "'", "meiocampo")
                Dim avan11 As String = DoSQLCommand("SELECT avancado FROM jogadores where nome = '" & jog11 & "'", "avancado")
                con1 = CInt(red1)
                con2 = CInt(def2)
                con3 = CInt(def3)
                con4 = CInt(def4)
                con5 = CInt(def5)
                con6 = CInt(def6)
                con7 = CInt(meio7)
                con8 = CInt(meio8)
                con9 = CInt(meio9)
                con10 = CInt(meio10)
                con11 = CInt(avan11)
                tot1 = con1
                tot2 = (con2 + con3 + con4 + con5 + con6)
                tot3 = (con7 + con8 + con9 + con10)
                tot4 = (con11)
            ElseIf tatica = "5-3-2" Then
                jog1 = ComboBox1.SelectedItem
                jog2 = ComboBox2.SelectedItem
                jog3 = ComboBox3.SelectedItem
                jog4 = ComboBox4.SelectedItem
                jog5 = ComboBox5.SelectedItem
                jog6 = ComboBox6.SelectedItem
                jog7 = ComboBox8.SelectedItem
                jog8 = ComboBox9.SelectedItem
                jog9 = ComboBox10.SelectedItem
                jog10 = ComboBox13.SelectedItem
                jog11 = ComboBox15.SelectedItem
                Dim red1 As String = DoSQLCommand("SELECT guardaredes  FROM jogadores where nome = '" & jog1 & "'", "guardaredes")
                Dim def2 As String = DoSQLCommand("SELECT defesa FROM jogadores where nome = '" & jog2 & "'", "defesa")
                Dim def3 As String = DoSQLCommand("SELECT defesa FROM jogadores where nome = '" & jog3 & "'", "defesa")
                Dim def4 As String = DoSQLCommand("SELECT defesa FROM jogadores where nome = '" & jog4 & "'", "defesa")
                Dim def5 As String = DoSQLCommand("SELECT defesa FROM jogadores where nome = '" & jog5 & "'", "defesa")
                Dim def6 As String = DoSQLCommand("SELECT defesa FROM jogadores where nome = '" & jog6 & "'", "defesa")
                Dim meio7 As String = DoSQLCommand("SELECT meiocampo FROM jogadores where nome = '" & jog7 & "'", "meiocampo")
                Dim meio8 As String = DoSQLCommand("SELECT meiocampo FROM jogadores where nome = '" & jog8 & "'", "meiocampo")
                Dim meio9 As String = DoSQLCommand("SELECT  meiocampo FROM jogadores where nome = '" & jog9 & "'", "meiocampo")
                Dim avan10 As String = DoSQLCommand("SELECT  avancado FROM jogadores where nome = '" & jog10 & "'", "avancado")
                Dim avan11 As String = DoSQLCommand("SELECT avancado FROM jogadores where nome = '" & jog11 & "'", "avancado")
                con1 = CInt(red1)
                con2 = CInt(def2)
                con3 = CInt(def3)
                con4 = CInt(def4)
                con5 = CInt(def5)
                con6 = CInt(def6)
                con7 = CInt(meio7)
                con8 = CInt(meio8)
                con9 = CInt(meio9)
                con10 = CInt(avan10)
                con11 = CInt(avan11)
                tot1 = con1
                tot2 = (con2 + con3 + con4 + con5 + con6)
                tot3 = (con7 + con8 + con9)
                tot4 = (con10 + con11)
            ElseIf tatica = "4-3-3" Then
                jog1 = ComboBox1.SelectedItem
                jog2 = ComboBox2.SelectedItem
                jog3 = ComboBox19.SelectedItem
                jog4 = ComboBox20.SelectedItem
                jog5 = ComboBox6.SelectedItem
                jog6 = ComboBox8.SelectedItem
                jog7 = ComboBox9.SelectedItem
                jog8 = ComboBox10.SelectedItem
                jog9 = ComboBox12.SelectedItem
                jog10 = ComboBox14.SelectedItem
                jog11 = ComboBox16.SelectedItem
                Dim red1 As String = DoSQLCommand("SELECT guardaredes  FROM jogadores where nome = '" & jog1 & "'", "guardaredes")
                Dim def2 As String = DoSQLCommand("SELECT defesa FROM jogadores where nome = '" & jog2 & "'", "defesa")
                Dim def3 As String = DoSQLCommand("SELECT defesa FROM jogadores where nome = '" & jog3 & "'", "defesa")
                Dim def4 As String = DoSQLCommand("SELECT defesa FROM jogadores where nome = '" & jog4 & "'", "defesa")
                Dim def5 As String = DoSQLCommand("SELECT defesa FROM jogadores where nome = '" & jog5 & "'", "defesa")
                Dim meio6 As String = DoSQLCommand("SELECT meiocampo FROM jogadores where nome = '" & jog6 & "'", "meiocampo")
                Dim meio7 As String = DoSQLCommand("SELECT meiocampo FROM jogadores where nome = '" & jog7 & "'", "meiocampo")
                Dim meio8 As String = DoSQLCommand("SELECT meiocampo FROM jogadores where nome = '" & jog8 & "'", "meiocampo")
                Dim avan9 As String = DoSQLCommand("SELECT  avancado FROM jogadores where nome = '" & jog9 & "'", "avancado")
                Dim avan10 As String = DoSQLCommand("SELECT  avancado FROM jogadores where nome = '" & jog10 & "'", "avancado")
                Dim avan11 As String = DoSQLCommand("SELECT avancado FROM jogadores where nome = '" & jog11 & "'", "avancado")
                con1 = CInt(red1)
                con2 = CInt(def2)
                con3 = CInt(def3)
                con4 = CInt(def4)
                con5 = CInt(def5)
                con6 = CInt(meio6)
                con7 = CInt(meio7)
                con8 = CInt(meio8)
                con9 = CInt(avan9)
                con10 = CInt(avan10)
                con11 = CInt(avan11)
                tot1 = con1
                tot2 = (con2 + con3 + con4 + con5)
                tot3 = (con6 + con7 + con8 + con9)
                tot4 = (con10 + con11)
            ElseIf tatica = "4-4-2" Then
                jog1 = ComboBox1.SelectedItem
                jog2 = ComboBox2.SelectedItem
                jog3 = ComboBox19.SelectedItem
                jog4 = ComboBox20.SelectedItem
                jog5 = ComboBox6.SelectedItem
                jog6 = ComboBox7.SelectedItem
                jog7 = ComboBox18.SelectedItem
                jog8 = ComboBox17.SelectedItem
                jog9 = ComboBox11.SelectedItem
                jog10 = ComboBox13.SelectedItem
                jog11 = ComboBox15.SelectedItem
                Dim red1 As String = DoSQLCommand("SELECT guardaredes  FROM jogadores where nome = '" & jog1 & "'", "guardaredes")
                Dim def2 As String = DoSQLCommand("SELECT defesa FROM jogadores where nome = '" & jog2 & "'", "defesa")
                Dim def3 As String = DoSQLCommand("SELECT defesa FROM jogadores where nome = '" & jog3 & "'", "defesa")
                Dim def4 As String = DoSQLCommand("SELECT defesa FROM jogadores where nome = '" & jog4 & "'", "defesa")
                Dim def5 As String = DoSQLCommand("SELECT defesa FROM jogadores where nome = '" & jog5 & "'", "defesa")
                Dim meio6 As String = DoSQLCommand("SELECT meiocampo FROM jogadores where nome = '" & jog6 & "'", "meiocampo")
                Dim meio7 As String = DoSQLCommand("SELECT meiocampo FROM jogadores where nome = '" & jog7 & "'", "meiocampo")
                Dim meio8 As String = DoSQLCommand("SELECT meiocampo FROM jogadores where nome = '" & jog8 & "'", "meiocampo")
                Dim meio9 As String = DoSQLCommand("SELECT meiocampo FROM jogadores where nome = '" & jog9 & "'", "meiocampo")
                Dim avan10 As String = DoSQLCommand("SELECT avancado FROM jogadores where nome = '" & jog10 & "'", "avancado")
                Dim avan11 As String = DoSQLCommand("SELECT avancado FROM jogadores where nome = '" & jog11 & "'", "avancado")
                con1 = CInt(red1)
                con2 = CInt(def2)
                con3 = CInt(def3)
                con4 = CInt(def4)
                con5 = CInt(def5)
                con6 = CInt(meio6)
                con7 = CInt(meio7)
                con8 = CInt(meio8)
                con9 = CInt(meio9)
                con10 = CInt(avan10)
                con11 = CInt(avan11)
                tot1 = con1
                tot2 = (con2 + con3 + con4 + con5)
                tot3 = (con6 + con7 + con8 + con9)
                tot4 = (con10 + con11)
            ElseIf tatica = "4-5-1" Then
                jog1 = ComboBox1.SelectedItem
                jog2 = ComboBox2.SelectedItem
                jog3 = ComboBox19.SelectedItem
                jog4 = ComboBox20.SelectedItem
                jog5 = ComboBox6.SelectedItem
                jog6 = ComboBox7.SelectedItem
                jog7 = ComboBox8.SelectedItem
                jog8 = ComboBox9.SelectedItem
                jog9 = ComboBox10.SelectedItem
                jog10 = ComboBox11.SelectedItem
                jog11 = ComboBox14.SelectedItem
                Dim red1 As String = DoSQLCommand("SELECT guardaredes  FROM jogadores where nome = '" & jog1 & "'", "guardaredes")
                Dim def2 As String = DoSQLCommand("SELECT defesa FROM jogadores where nome = '" & jog2 & "'", "defesa")
                Dim def3 As String = DoSQLCommand("SELECT defesa FROM jogadores where nome = '" & jog3 & "'", "defesa")
                Dim def4 As String = DoSQLCommand("SELECT defesa FROM jogadores where nome = '" & jog4 & "'", "defesa")
                Dim def5 As String = DoSQLCommand("SELECT defesa FROM jogadores where nome = '" & jog5 & "'", "defesa")
                Dim meio6 As String = DoSQLCommand("SELECT meiocampo FROM jogadores where nome = '" & jog6 & "'", "meiocampo")
                Dim meio7 As String = DoSQLCommand("SELECT meiocampo FROM jogadores where nome = '" & jog7 & "'", "meiocampo")
                Dim meio8 As String = DoSQLCommand("SELECT meiocampo FROM jogadores where nome = '" & jog8 & "'", "meiocampo")
                Dim meio9 As String = DoSQLCommand("SELECT meiocampo FROM jogadores where nome = '" & jog9 & "'", "meiocampo")
                Dim meio10 As String = DoSQLCommand("SELECT meiocampo FROM jogadores where nome = '" & jog10 & "'", "meiocampo")
                Dim avan11 As String = DoSQLCommand("SELECT avancado FROM jogadores where nome = '" & jog11 & "'", "avancado")
                con1 = CInt(red1)
                con2 = CInt(def2)
                con3 = CInt(def3)
                con4 = CInt(def4)
                con5 = CInt(def5)
                con6 = CInt(meio6)
                con7 = CInt(meio7)
                con8 = CInt(meio8)
                con9 = CInt(meio9)
                con10 = CInt(meio10)
                con11 = CInt(avan11)
                tot1 = con1
                tot2 = (con2 + con3 + con4 + con5)
                tot3 = (con6 + con7 + con8 + con9 + con10)
                tot4 = (con11)
            ElseIf tatica = "3-4-3" Then
                jog1 = ComboBox1.SelectedItem
                jog2 = ComboBox3.SelectedItem
                jog3 = ComboBox4.SelectedItem
                jog4 = ComboBox5.SelectedItem
                jog5 = ComboBox7.SelectedItem
                jog6 = ComboBox18.SelectedItem
                jog7 = ComboBox17.SelectedItem
                jog8 = ComboBox11.SelectedItem
                jog9 = ComboBox12.SelectedItem
                jog10 = ComboBox14.SelectedItem
                jog11 = ComboBox16.SelectedItem
                Dim red1 As String = DoSQLCommand("SELECT guardaredes  FROM jogadores where nome = '" & jog1 & "'", "guardaredes")
                Dim def2 As String = DoSQLCommand("SELECT defesa FROM jogadores where nome = '" & jog2 & "'", "defesa")
                Dim def3 As String = DoSQLCommand("SELECT defesa FROM jogadores where nome = '" & jog3 & "'", "defesa")
                Dim def4 As String = DoSQLCommand("SELECT defesa FROM jogadores where nome = '" & jog4 & "'", "defesa")
                Dim meio5 As String = DoSQLCommand("SELECT meiocampo FROM jogadores where nome = '" & jog5 & "'", "meiocampo")
                Dim meio6 As String = DoSQLCommand("SELECT meiocampo FROM jogadores where nome = '" & jog6 & "'", "meiocampo")
                Dim meio7 As String = DoSQLCommand("SELECT meiocampo FROM jogadores where nome = '" & jog7 & "'", "meiocampo")
                Dim meio8 As String = DoSQLCommand("SELECT meiocampo FROM jogadores where nome = '" & jog8 & "'", "meiocampo")
                Dim avan9 As String = DoSQLCommand("SELECT avancado FROM jogadores where nome = '" & jog9 & "'", "avancado")
                Dim avan10 As String = DoSQLCommand("SELECT avancado FROM jogadores where nome = '" & jog10 & "'", "avancado")
                Dim avan11 As String = DoSQLCommand("SELECT avancado FROM jogadores where nome = '" & jog11 & "'", "avancado")
                con1 = CInt(red1)
                con2 = CInt(def2)
                con3 = CInt(def3)
                con4 = CInt(def4)
                con5 = CInt(meio5)
                con6 = CInt(meio6)
                con7 = CInt(meio7)
                con8 = CInt(meio8)
                con9 = CInt(avan9)
                con10 = CInt(avan10)
                con11 = CInt(avan11)
                tot1 = con1
                tot2 = (con2 + con3 + con4)
                tot3 = (con5 + con6 + con7 + con8)
                tot4 = (con9 + con10 + con11)
            ElseIf tatica = "3-5-2" Then
                jog1 = ComboBox1.SelectedItem
                jog2 = ComboBox3.SelectedItem
                jog3 = ComboBox4.SelectedItem
                jog4 = ComboBox5.SelectedItem
                jog5 = ComboBox7.SelectedItem
                jog6 = ComboBox8.SelectedItem
                jog7 = ComboBox9.SelectedItem
                jog8 = ComboBox10.SelectedItem
                jog9 = ComboBox11.SelectedItem
                jog10 = ComboBox13.SelectedItem
                jog11 = ComboBox15.SelectedItem
                Dim red1 As String = DoSQLCommand("SELECT guardaredes  FROM jogadores where nome = '" & jog1 & "'", "guardaredes")
                Dim def2 As String = DoSQLCommand("SELECT defesa FROM jogadores where nome = '" & jog2 & "'", "defesa")
                Dim def3 As String = DoSQLCommand("SELECT defesa FROM jogadores where nome = '" & jog3 & "'", "defesa")
                Dim def4 As String = DoSQLCommand("SELECT defesa FROM jogadores where nome = '" & jog4 & "'", "defesa")
                Dim meio5 As String = DoSQLCommand("SELECT meiocampo FROM jogadores where nome = '" & jog5 & "'", "meiocampo")
                Dim meio6 As String = DoSQLCommand("SELECT meiocampo FROM jogadores where nome = '" & jog6 & "'", "meiocampo")
                Dim meio7 As String = DoSQLCommand("SELECT meiocampo FROM jogadores where nome = '" & jog7 & "'", "meiocampo")
                Dim meio8 As String = DoSQLCommand("SELECT meiocampo FROM jogadores where nome = '" & jog8 & "'", "meiocampo")
                Dim meio9 As String = DoSQLCommand("SELECT meiocampo FROM jogadores where nome = '" & jog9 & "'", "meiocampo")
                Dim avan10 As String = DoSQLCommand("SELECT avancado FROM jogadores where nome = '" & jog10 & "'", "avancado")
                Dim avan11 As String = DoSQLCommand("SELECT avancado FROM jogadores where nome = '" & jog11 & "'", "avancado")
                con1 = CInt(red1)
                con2 = CInt(def2)
                con3 = CInt(def3)
                con4 = CInt(def4)
                con5 = CInt(meio5)
                con6 = CInt(meio6)
                con7 = CInt(meio7)
                con8 = CInt(meio8)
                con9 = CInt(meio9)
                con10 = CInt(avan10)
                con11 = CInt(avan11)
                tot1 = con1
                tot2 = (con2 + con3 + con4)
                tot3 = (con5 + con6 + con7 + con8 + con9)
                tot4 = (con10 + con11)
            End If
            totredes = tot1 + (tot2 * 0.5) + (tot3 * 0.25) + (tot4 * 0.1)
            totdef = tot2 + tot1
            totmeio = tot3
            totavan = tot4
            If My.Computer.FileSystem.DirectoryExists("C:\jogo") Then
                Dim up1 As IO.StreamWriter
                Dim up2 As IO.StreamWriter
                Dim up3 As IO.StreamWriter
                Dim up4 As IO.StreamWriter
                up1 = New IO.StreamWriter("C:\jogo\totredese1")
                up2 = New IO.StreamWriter("C:\jogo\totdefe1")
                up3 = New IO.StreamWriter("C:\jogo\totmeioe1")
                up4 = New IO.StreamWriter("C:\jogo\totavane1")
                up1.Write(totredes)
                up1.Close()
                up2.Write(totdef)
                up2.Close()
                up3.Write(totmeio)
                up3.Close()
                up4.Write(totavan)
                up4.Close()
            End If
            equipas.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Por favor escolha jogadores para as posições.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        equipas.Show()
        Me.Close()
    End Sub
    Private Sub ComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles ComboBox1.SelectedIndexChanged, ComboBox2.SelectedIndexChanged, ComboBox3.SelectedIndexChanged, ComboBox4.SelectedIndexChanged, _
    ComboBox5.SelectedIndexChanged, ComboBox6.SelectedIndexChanged, ComboBox7.SelectedIndexChanged, ComboBox8.SelectedIndexChanged, _
    ComboBox9.SelectedIndexChanged, ComboBox10.SelectedIndexChanged, ComboBox11.SelectedIndexChanged, ComboBox12.SelectedIndexChanged, _
    ComboBox13.SelectedIndexChanged, ComboBox14.SelectedIndexChanged, ComboBox15.SelectedIndexChanged, ComboBox16.SelectedIndexChanged, _
    ComboBox17.SelectedIndexChanged, ComboBox18.SelectedIndexChanged, ComboBox19.SelectedIndexChanged, ComboBox20.SelectedIndexChanged
        Dim cbox As ComboBox = sender
        If (cbox.SelectedIndex > -1) Then
            Dim items As ComboBox.ObjectCollection = cbox.Items
            Dim txt As String = cbox.SelectedItem.ToString()
        End If
    End Sub
    Private Function GetCombosTexts(ByVal cbox As ComboBox)
        Dim texts(20) As String
        Dim i As Integer = 0
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is ComboBox Then
                Dim tmp As ComboBox = ctrl
                If ((tmp.Name <> cbox.Name) And (tmp.SelectedIndex > -1)) Then
                    texts(i) = tmp.SelectedItem.ToString()
                Else
                    texts(i) = ""
                End If
                i = i + 1
            End If
        Next
        Return texts
    End Function
    'verifica a posição di jogador para colocar nas combobox respectiva da área de jogo
    Private Sub ComboItemsAdd(ByVal cbo As ComboBox)
        With cbo
            If (cbo.Tag = e1j1.Substring(e1j1.IndexOf("|") + 1).Trim()) Then .Items.Add(e1j1.Substring(0, e1j1.IndexOf("|")))
            If (cbo.Tag = e1j2.Substring(e1j2.IndexOf("|") + 1).Trim()) Then .Items.Add(e1j2.Substring(0, e1j2.IndexOf("|")))
            If (cbo.Tag = e1j3.Substring(e1j3.IndexOf("|") + 1).Trim()) Then .Items.Add(e1j3.Substring(0, e1j3.IndexOf("|")))
            If (cbo.Tag = e1j4.Substring(e1j4.IndexOf("|") + 1).Trim()) Then .Items.Add(e1j4.Substring(0, e1j4.IndexOf("|")))
            If (cbo.Tag = e1j5.Substring(e1j5.IndexOf("|") + 1).Trim()) Then .Items.Add(e1j5.Substring(0, e1j5.IndexOf("|")))
            If (cbo.Tag = e1j6.Substring(e1j6.IndexOf("|") + 1).Trim()) Then .Items.Add(e1j6.Substring(0, e1j6.IndexOf("|")))
            If (cbo.Tag = e1j7.Substring(e1j7.IndexOf("|") + 1).Trim()) Then .Items.Add(e1j7.Substring(0, e1j7.IndexOf("|")))
            If (cbo.Tag = e1j8.Substring(e1j8.IndexOf("|") + 1).Trim()) Then .Items.Add(e1j8.Substring(0, e1j8.IndexOf("|")))
            If (cbo.Tag = e1j9.Substring(e1j9.IndexOf("|") + 1).Trim()) Then .Items.Add(e1j9.Substring(0, e1j9.IndexOf("|")))
            If (cbo.Tag = e1j10.Substring(e1j10.IndexOf("|") + 1).Trim()) Then .Items.Add(e1j10.Substring(0, e1j10.IndexOf("|")))
            If (cbo.Tag = e1j11.Substring(e1j11.IndexOf("|") + 1).Trim()) Then .Items.Add(e1j11.Substring(0, e1j11.IndexOf("|")))
            'caso não tenha encontrado nada para adicionar
            If (cbo.Items.Count = 0) Then
                .Items.Add(e1j1)
                .Items.Add(e1j2)
                .Items.Add(e1j3)
                .Items.Add(e1j4)
                .Items.Add(e1j5)
                .Items.Add(e1j6)
                .Items.Add(e1j7)
                .Items.Add(e1j8)
                .Items.Add(e1j9)
                .Items.Add(e1j10)
                .Items.Add(e1j11)
            End If
        End With
    End Sub
    Private Sub ComboBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) _
    Handles ComboBox1.Click, ComboBox2.Click, ComboBox3.Click, ComboBox4.Click, _
    ComboBox5.Click, ComboBox6.Click, ComboBox7.Click, ComboBox8.Click, _
    ComboBox9.Click, ComboBox10.Click, ComboBox11.Click, ComboBox12.Click, _
    ComboBox13.Click, ComboBox14.Click, ComboBox15.Click, ComboBox16.Click, _
    ComboBox17.Click, ComboBox18.Click, ComboBox19.Click, ComboBox20.Click
        Dim cbox As ComboBox = sender
        Dim i As Integer
        Dim selects() As String = GetCombosTexts(cbox)
        For i = 0 To selects.Length - 1
            If (selects(i) <> "") Then
                Dim index As Integer = cbox.FindString(selects(i), -1)
                If (index > -1) Then
                    cbox.Items.RemoveAt(index)
                End If
            End If
        Next
        If (cbox.Items.Count = 0) Then
            Label1.Visible = True
        Else
            Label1.Visible = False
        End If
    End Sub
End Class