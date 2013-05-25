Imports System.Data
Imports System.Data.SqlClient
Public Class equipas
    Inherits System.Windows.Forms.Form
    Public tatica, tatica2 As String
    Dim i As Integer
    Private lvItem As ListViewItem
    Public pontosequipa1, pontosequipa2 As Integer
    Public gsequipa1, gsequipa2 As Integer
    Public gmequipa1, gmequipa2 As Integer
    Public vitoriasequipa1, vitoriasequipa2 As Integer
    Public empatesequipa1, empatesequipa2 As Integer
    Public derrotasequipa1, derrotasequipa2 As Integer
    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)
        Select Case m.Msg
            Case WM_NCHITTEST
                If m.Result = New IntPtr(HTCLIENT) Then
                    m.Result = New IntPtr(HTCAPTION)
                End If
        End Select
    End Sub
    Private WM_NCHITTEST As Integer = &H84
    Private HTCLIENT As Integer = &H1          ' arrastar
    Private HTCAPTION As Integer = &H2


    Private Sub equipas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If (taticas.tat1Alterada) Then
            Label8.Enabled = False
        Else
            CarregaEquipa1()
        End If

        If (taticas.tat2Alterada) Then
            Label10.Enabled = False
        Else
            CarregaEquipa2()
        End If

        Me.Label9.Enabled = False
        Me.Label9.Visible = False
        Const constr As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=|datadirectory|jogadores.mdf;Integrated Security=True;User Instance=True"
        Dim db As New SqlConnection(constr)
        db.Open()
        Dim varsql As String
        varsql = "SELECT nome, guardaredes, defesa, meiocampo, avancado, idclube, posicao  FROM jogadores"
        Dim cmd As New SqlCommand(varsql, db)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader
        While dr.Read()
            If My.Computer.FileSystem.FileExists("C:\jogo\tatica") Then
                Dim t As IO.StreamReader
                If Dir$("C:\jogo\tatica") <> "" Then
                    t = New IO.StreamReader("C:\jogo\tatica")
                    tatica = t.ReadLine
                    If tatica = "4-4-2" Then
                        Dim new_item As New ListViewItem(dr.Item("nome").ToString)
                        new_item.SubItems.Add(dr.Item("idclube").ToString)
                        new_item.SubItems.Add(dr.Item("posicao").ToString)
                        new_item.SubItems.Add(dr.Item("guardaredes").ToString)
                        new_item.SubItems.Add(dr.Item("defesa").ToString)
                        new_item.SubItems.Add(dr.Item("meiocampo").ToString)
                        new_item.SubItems.Add(dr.Item("avancado").ToString)
                        ListView1.Items.Add(new_item)
                    ElseIf tatica = "5-4-1" Then
                        Dim new_item As New ListViewItem(dr.Item("nome").ToString)
                        new_item.SubItems.Add(dr.Item("idclube").ToString)
                        new_item.SubItems.Add(dr.Item("posicao").ToString)
                        new_item.SubItems.Add(dr.Item("guardaredes").ToString)
                        new_item.SubItems.Add(dr.Item("defesa").ToString)
                        new_item.SubItems.Add(dr.Item("meiocampo").ToString)
                        new_item.SubItems.Add(dr.Item("avancado").ToString)
                        ListView1.Items.Add(new_item)
                    ElseIf tatica = "5-3-2" Then
                        Dim new_item As New ListViewItem(dr.Item("nome").ToString)
                        new_item.SubItems.Add(dr.Item("idclube").ToString)
                        new_item.SubItems.Add(dr.Item("posicao").ToString)
                        new_item.SubItems.Add(dr.Item("guardaredes").ToString)
                        new_item.SubItems.Add(dr.Item("defesa").ToString)
                        new_item.SubItems.Add(dr.Item("meiocampo").ToString)
                        new_item.SubItems.Add(dr.Item("avancado").ToString)
                        ListView1.Items.Add(new_item)
                    ElseIf tatica = "4-3-3" Then
                        Dim new_item As New ListViewItem(dr.Item("nome").ToString)
                        new_item.SubItems.Add(dr.Item("idclube").ToString)
                        new_item.SubItems.Add(dr.Item("posicao").ToString)
                        new_item.SubItems.Add(dr.Item("guardaredes").ToString)
                        new_item.SubItems.Add(dr.Item("defesa").ToString)
                        new_item.SubItems.Add(dr.Item("meiocampo").ToString)
                        new_item.SubItems.Add(dr.Item("avancado").ToString)
                        ListView1.Items.Add(new_item)
                    ElseIf tatica = "4-5-1" Then
                        Dim new_item As New ListViewItem(dr.Item("nome").ToString)
                        new_item.SubItems.Add(dr.Item("idclube").ToString)
                        new_item.SubItems.Add(dr.Item("posicao").ToString)
                        new_item.SubItems.Add(dr.Item("guardaredes").ToString)
                        new_item.SubItems.Add(dr.Item("defesa").ToString)
                        new_item.SubItems.Add(dr.Item("meiocampo").ToString)
                        new_item.SubItems.Add(dr.Item("avancado").ToString)
                        ListView1.Items.Add(new_item)
                    ElseIf tatica = "3-4-3" Then
                        Dim new_item As New ListViewItem(dr.Item("nome").ToString)
                        new_item.SubItems.Add(dr.Item("idclube").ToString)
                        new_item.SubItems.Add(dr.Item("posicao").ToString)
                        new_item.SubItems.Add(dr.Item("guardaredes").ToString)
                        new_item.SubItems.Add(dr.Item("defesa").ToString)
                        new_item.SubItems.Add(dr.Item("meiocampo").ToString)
                        new_item.SubItems.Add(dr.Item("avancado").ToString)
                        ListView1.Items.Add(new_item)
                    ElseIf tatica = "3-5-2" Then
                        Dim new_item As New ListViewItem(dr.Item("nome").ToString)
                        new_item.SubItems.Add(dr.Item("idclube").ToString)
                        new_item.SubItems.Add(dr.Item("posicao").ToString)
                        new_item.SubItems.Add(dr.Item("guardaredes").ToString)
                        new_item.SubItems.Add(dr.Item("defesa").ToString)
                        new_item.SubItems.Add(dr.Item("meiocampo").ToString)
                        new_item.SubItems.Add(dr.Item("avancado").ToString)
                        ListView1.Items.Add(new_item)
                    End If
                    t.Close()
                End If
            Else
                MkDir("C:\jogo")
                SetAttr("C:\jogo", vbHidden)
            End If
            'ListViewMakeRow(ListView3, dr.Item("avancado"), dr.Item("idclube"))
        End While
        db.Close()
        ListView1.Columns.Add("Nome", 120, HorizontalAlignment.Center)
        ListView1.Columns.Add("Clube", 95, HorizontalAlignment.Center)
        ListView1.Columns.Add("Posição", 95, HorizontalAlignment.Center)
        ListView1.Columns.Add("Guarda-Redes", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Defesa", 80, HorizontalAlignment.Center)
        ListView1.Columns.Add("Meio-Campo", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Avancado", 80, HorizontalAlignment.Center)
        ListView2.Columns.Add("Nome", 120, HorizontalAlignment.Center)
        ListView2.Columns.Add("Clube", 95, HorizontalAlignment.Center)
        ListView2.Columns.Add("Posição", 95, HorizontalAlignment.Center)
        ListView2.Columns.Add("Guarda-Redes", 100, HorizontalAlignment.Center)
        ListView2.Columns.Add("Defesa", 80, HorizontalAlignment.Center)
        ListView2.Columns.Add("Meio-Campo", 100, HorizontalAlignment.Center)
        ListView2.Columns.Add("Avancado", 80, HorizontalAlignment.Center)
        ListView3.Columns.Add("Nome", 120, HorizontalAlignment.Center)
        ListView3.Columns.Add("Clube", 95, HorizontalAlignment.Center)
        ListView3.Columns.Add("Posição", 95, HorizontalAlignment.Center)
        ListView3.Columns.Add("Guarda-Redes", 100, HorizontalAlignment.Center)
        ListView3.Columns.Add("Defesa", 80, HorizontalAlignment.Center)
        ListView3.Columns.Add("Meio-Campo", 100, HorizontalAlignment.Center)
        ListView3.Columns.Add("Avancado", 80, HorizontalAlignment.Center)
    End Sub
    Private Sub ListView_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView2.DoubleClick, ListView3.DoubleClick
        ' caso o utilizador seleccione algum jogador da lista e faça duplo-clique, este jogador volta à lista inicial
        Dim list As ListView
        list = sender

        If (list.SelectedItems.Count > 0) Then
            For i = 0 To list.SelectedItems.Count - 1
                Dim lvi2 As New ListViewItem
                lvi2 = CType(list.SelectedItems(i).Clone, ListViewItem)
                ListView1.Items.Add(lvi2)
                list.Items.Remove(list.SelectedItems(i))
            Next
        End If


        If (ListView2.Items.Count < 11) Then
            Label12.Text = "Faltam escolher " & (11 - ListView2.Items.Count) & " jogadores."
            Label15.Enabled = True
        End If

        If (ListView3.Items.Count < 11) Then
            Label13.Text = "Faltam escolher " & (11 - ListView3.Items.Count) & " jogadores."
            Label7.Enabled = True
        End If

    End Sub

    Private Sub CarregaEquipa1()
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
        Try
            Dim tat As IO.StreamReader = New IO.StreamReader("C:\jogo\tatica")
            tatica = tat.ReadLine
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

            AdicionaItem(e1jog1.ReadLine, ListView2)
            AdicionaItem(e1jog2.ReadLine, ListView2)
            AdicionaItem(e1jog3.ReadLine, ListView2)
            AdicionaItem(e1jog4.ReadLine, ListView2)
            AdicionaItem(e1jog5.ReadLine, ListView2)
            AdicionaItem(e1jog6.ReadLine, ListView2)
            AdicionaItem(e1jog7.ReadLine, ListView2)
            AdicionaItem(e1jog8.ReadLine, ListView2)
            AdicionaItem(e1jog9.ReadLine, ListView2)
            AdicionaItem(e1jog10.ReadLine, ListView2)
            AdicionaItem(e1jog11.ReadLine, ListView2)

            e1jog1.Close()
            e1jog2.Close()
            e1jog3.Close()
            e1jog4.Close()
            e1jog5.Close()
            e1jog6.Close()
            e1jog7.Close()
            e1jog8.Close()
            e1jog9.Close()
            e1jog10.Close()
            e1jog11.Close()

        Catch ex As Exception
            MsgBox("Aconteceu um erro no carregamento. Escolha jogadores para as equipas.", MsgBoxStyle.Information, "Erro")
        End Try
    End Sub

    Private Sub CarregaEquipa2()
        Dim e2jog1 As IO.StreamReader
        Dim e2jog2 As IO.StreamReader
        Dim e2jog3 As IO.StreamReader
        Dim e2jog4 As IO.StreamReader
        Dim e2jog5 As IO.StreamReader
        Dim e2jog6 As IO.StreamReader
        Dim e2jog7 As IO.StreamReader
        Dim e2jog8 As IO.StreamReader
        Dim e2jog9 As IO.StreamReader
        Dim e2jog10 As IO.StreamReader
        Dim e2jog11 As IO.StreamReader

        Try
            Dim tat As IO.StreamReader = New IO.StreamReader("C:\jogo\tatica2")
            tatica2 = tat.ReadLine


            e2jog1 = New IO.StreamReader("C:\jogo\e2jog1")
            e2jog2 = New IO.StreamReader("C:\jogo\e2jog2")
            e2jog3 = New IO.StreamReader("C:\jogo\e2jog3")
            e2jog4 = New IO.StreamReader("C:\jogo\e2jog4")
            e2jog5 = New IO.StreamReader("C:\jogo\e2jog5")
            e2jog6 = New IO.StreamReader("C:\jogo\e2jog6")
            e2jog7 = New IO.StreamReader("C:\jogo\e2jog7")
            e2jog8 = New IO.StreamReader("C:\jogo\e2jog8")
            e2jog9 = New IO.StreamReader("C:\jogo\e2jog9")
            e2jog10 = New IO.StreamReader("C:\jogo\e2jog10")
            e2jog11 = New IO.StreamReader("C:\jogo\e2jog11")


            AdicionaItem(e2jog1.ReadLine, ListView3)
            AdicionaItem(e2jog2.ReadLine, ListView3)
            AdicionaItem(e2jog3.ReadLine, ListView3)
            AdicionaItem(e2jog4.ReadLine, ListView3)
            AdicionaItem(e2jog5.ReadLine, ListView3)
            AdicionaItem(e2jog6.ReadLine, ListView3)
            AdicionaItem(e2jog7.ReadLine, ListView3)
            AdicionaItem(e2jog8.ReadLine, ListView3)
            AdicionaItem(e2jog9.ReadLine, ListView3)
            AdicionaItem(e2jog10.ReadLine, ListView3)
            AdicionaItem(e2jog11.ReadLine, ListView3)
            e2jog1.Close()
            e2jog2.Close()
            e2jog3.Close()
            e2jog4.Close()
            e2jog5.Close()
            e2jog6.Close()
            e2jog7.Close()
            e2jog8.Close()
            e2jog9.Close()
            e2jog10.Close()
            e2jog11.Close()
        Catch ex As Exception
            MsgBox("Aconteceu um erro no carregamento. Escolha jogadores para as equipas.", MsgBoxStyle.Information, "Erro")
        End Try
    End Sub


    Private Sub AdicionaItem(ByVal texto As String, ByVal list As ListView)
        Dim str = texto
        Dim ix = str.ToString().IndexOf("|")
        str = str.ToString().Substring(0, ix)
        Dim match As ListViewItem = ListView1.FindItemWithText(str)
        If Not (IsNothing(match)) Then
            list.Items.Add(match.Clone)
            ListView1.Items.Remove(match)
        End If
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim lvi As New ListViewItem
            lvi = ListView1.SelectedItems(0)
            Dim lvi3 As New ListViewItem
            lvi3 = CType(lvi.Clone, ListViewItem)
            If (ListView3.Items.Count < 11) Then
                ListView3.Items.Add(lvi3)
            End If
        End If
        For i As Integer = 0 To ListView1.SelectedIndices.Count - 1
            Dim lvi As ListViewItem = ListView1.Items(ListView1.SelectedIndices(i)).Clone
            Dim match As ListViewItem = ListView3.FindItemWithText(lvi.Text)
            If (IsNothing(match) And (ListView3.Items.Count < 11)) Then
                ListView3.Items.Add(lvi)
            End If
        Next
        'ListView2.Items.Add(ListView1.SelectedItems(0))
        For Each lvItem As ListViewItem In ListView1.SelectedItems
            If Not (IsNothing(ListView3.FindItemWithText(lvItem.Text))) Then
                lvItem.Remove()
            End If
        Next

        Dim pla1 As Integer
        If (ListView3.Items.Count < 11) Then
            pla1 = 11 - ListView3.Items.Count
            Label13.Text = "Faltam escolher " & pla1 & " jogadores."
        Else
            Label7.Enabled = False
            Label13.Text = "11 Jogadores escolhidos!"
        End If
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        totais.Show()
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        If ((ListView2.Items.Count <> 11) Or (ListView3.Items.Count <> 11)) Then
            MsgBox("Escolha jogadores para as equipas.", MsgBoxStyle.Information, "Erro")
        Else

            If MessageBox.Show("Quer confirmar os jogadores escolhidos e a tatica? Se escolher Sim não terá a hipótese de escolher novamente.", "Confirmar", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Label15.Visible = False
                Label7.Visible = False
                Label11.Visible = False
                Label6.Visible = False
                Label8.Visible = False
                Label10.Visible = False
                Label5.Visible = False
                Label9.Visible = True
                Label9.Enabled = True

            End If
        End If
    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click
        End
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        If ListView2.Items.Count = 11 Then
            If My.Computer.FileSystem.DirectoryExists("C:\jogo") Then
                For i = 0 To ListView2.Items.Count - 1
                    Dim e1jog1 As IO.StreamWriter
                    Dim e1jog2 As IO.StreamWriter
                    Dim e1jog3 As IO.StreamWriter
                    Dim e1jog4 As IO.StreamWriter
                    Dim e1jog5 As IO.StreamWriter
                    Dim e1jog6 As IO.StreamWriter
                    Dim e1jog7 As IO.StreamWriter
                    Dim e1jog8 As IO.StreamWriter
                    Dim e1jog9 As IO.StreamWriter
                    Dim e1jog10 As IO.StreamWriter
                    Dim e1jog11 As IO.StreamWriter
                    e1jog1 = New IO.StreamWriter("C:\jogo\e1jog1")
                    e1jog2 = New IO.StreamWriter("C:\jogo\e1jog2")
                    e1jog3 = New IO.StreamWriter("C:\jogo\e1jog3")
                    e1jog4 = New IO.StreamWriter("C:\jogo\e1jog4")
                    e1jog5 = New IO.StreamWriter("C:\jogo\e1jog5")
                    e1jog6 = New IO.StreamWriter("C:\jogo\e1jog6")
                    e1jog7 = New IO.StreamWriter("C:\jogo\e1jog7")
                    e1jog8 = New IO.StreamWriter("C:\jogo\e1jog8")
                    e1jog9 = New IO.StreamWriter("C:\jogo\e1jog9")
                    e1jog10 = New IO.StreamWriter("C:\jogo\e1jog10")
                    e1jog11 = New IO.StreamWriter("C:\jogo\e1jog11")
                    e1jog1.Write(CStr(ListView2.Items.Item(0).SubItems(0).Text) & "|" & CStr(ListView2.Items.Item(0).SubItems(2).Text))
                    e1jog2.Write(CStr(ListView2.Items.Item(1).SubItems(0).Text) & "|" & CStr(ListView2.Items.Item(1).SubItems(2).Text))
                    e1jog3.Write(CStr(ListView2.Items.Item(2).SubItems(0).Text) & "|" & CStr(ListView2.Items.Item(2).SubItems(2).Text))
                    e1jog4.Write(CStr(ListView2.Items.Item(3).SubItems(0).Text) & "|" & CStr(ListView2.Items.Item(3).SubItems(2).Text))
                    e1jog5.Write(CStr(ListView2.Items.Item(4).SubItems(0).Text) & "|" & CStr(ListView2.Items.Item(4).SubItems(2).Text))
                    e1jog6.Write(CStr(ListView2.Items.Item(5).SubItems(0).Text) & "|" & CStr(ListView2.Items.Item(5).SubItems(2).Text))
                    e1jog7.Write(CStr(ListView2.Items.Item(6).SubItems(0).Text) & "|" & CStr(ListView2.Items.Item(6).SubItems(2).Text))
                    e1jog8.Write(CStr(ListView2.Items.Item(7).SubItems(0).Text) & "|" & CStr(ListView2.Items.Item(7).SubItems(2).Text))
                    e1jog9.Write(CStr(ListView2.Items.Item(8).SubItems(0).Text) & "|" & CStr(ListView2.Items.Item(8).SubItems(2).Text))
                    e1jog10.Write(CStr(ListView2.Items.Item(9).SubItems(0).Text) & "|" & CStr(ListView2.Items.Item(9).SubItems(2).Text))
                    e1jog11.Write(CStr(ListView2.Items.Item(10).SubItems(0).Text) & "|" & CStr(ListView2.Items.Item(10).SubItems(2).Text))
                    e1jog1.Close()
                    e1jog2.Close()
                    e1jog3.Close()
                    e1jog4.Close()
                    e1jog5.Close()
                    e1jog6.Close()
                    e1jog7.Close()
                    e1jog8.Close()
                    e1jog9.Close()
                    e1jog10.Close()
                    e1jog11.Close()
                Next

            Else
                MkDir("C:\jogo")
                SetAttr("C:\jogo", vbHidden)
                MsgBox("Escolha jogadores para as equipas.", MsgBoxStyle.Information, "Erro")
            End If
        End If
        posicoes.Show()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        If ListView3.Items.Count = 11 Then
            If My.Computer.FileSystem.DirectoryExists("C:\jogo") Then
                For i = 0 To ListView3.Items.Count - 1

                    Dim e2jog1 As IO.StreamWriter
                    Dim e2jog2 As IO.StreamWriter
                    Dim e2jog3 As IO.StreamWriter
                    Dim e2jog4 As IO.StreamWriter
                    Dim e2jog5 As IO.StreamWriter
                    Dim e2jog6 As IO.StreamWriter
                    Dim e2jog7 As IO.StreamWriter
                    Dim e2jog8 As IO.StreamWriter
                    Dim e2jog9 As IO.StreamWriter
                    Dim e2jog10 As IO.StreamWriter
                    Dim e2jog11 As IO.StreamWriter
                    e2jog1 = New IO.StreamWriter("C:\jogo\e2jog1")
                    e2jog2 = New IO.StreamWriter("C:\jogo\e2jog2")
                    e2jog3 = New IO.StreamWriter("C:\jogo\e2jog3")
                    e2jog4 = New IO.StreamWriter("C:\jogo\e2jog4")
                    e2jog5 = New IO.StreamWriter("C:\jogo\e2jog5")
                    e2jog6 = New IO.StreamWriter("C:\jogo\e2jog6")
                    e2jog7 = New IO.StreamWriter("C:\jogo\e2jog7")
                    e2jog8 = New IO.StreamWriter("C:\jogo\e2jog8")
                    e2jog9 = New IO.StreamWriter("C:\jogo\e2jog9")
                    e2jog10 = New IO.StreamWriter("C:\jogo\e2jog10")
                    e2jog11 = New IO.StreamWriter("C:\jogo\e2jog11")

                    e2jog1.Write(CStr(ListView3.Items.Item(0).SubItems(0).Text) & "|" & CStr(ListView3.Items.Item(0).SubItems(2).Text))
                    e2jog2.Write(CStr(ListView3.Items.Item(1).SubItems(0).Text) & "|" & CStr(ListView3.Items.Item(1).SubItems(2).Text))
                    e2jog3.Write(CStr(ListView3.Items.Item(2).SubItems(0).Text) & "|" & CStr(ListView3.Items.Item(2).SubItems(2).Text))
                    e2jog4.Write(CStr(ListView3.Items.Item(3).SubItems(0).Text) & "|" & CStr(ListView3.Items.Item(3).SubItems(2).Text))
                    e2jog5.Write(CStr(ListView3.Items.Item(4).SubItems(0).Text) & "|" & CStr(ListView3.Items.Item(4).SubItems(2).Text))
                    e2jog6.Write(CStr(ListView3.Items.Item(5).SubItems(0).Text) & "|" & CStr(ListView3.Items.Item(5).SubItems(2).Text))
                    e2jog7.Write(CStr(ListView3.Items.Item(6).SubItems(0).Text) & "|" & CStr(ListView3.Items.Item(6).SubItems(2).Text))
                    e2jog8.Write(CStr(ListView3.Items.Item(7).SubItems(0).Text) & "|" & CStr(ListView3.Items.Item(7).SubItems(2).Text))
                    e2jog9.Write(CStr(ListView3.Items.Item(8).SubItems(0).Text) & "|" & CStr(ListView3.Items.Item(8).SubItems(2).Text))
                    e2jog10.Write(CStr(ListView3.Items.Item(9).SubItems(0).Text) & "|" & CStr(ListView3.Items.Item(9).SubItems(2).Text))
                    e2jog11.Write(CStr(ListView3.Items.Item(10).SubItems(0).Text) & "|" & CStr(ListView3.Items.Item(10).SubItems(2).Text))
                    e2jog1.Close()
                    e2jog2.Close()
                    e2jog3.Close()
                    e2jog4.Close()
                    e2jog5.Close()
                    e2jog6.Close()
                    e2jog7.Close()
                    e2jog8.Close()
                    e2jog9.Close()
                    e2jog10.Close()
                    e2jog11.Close()
                Next

            Else
                MkDir("C:\jogo")
                SetAttr("C:\jogo", vbHidden)
                MsgBox("Escolha jogadores para as equipas.", MsgBoxStyle.Information, "Erro")
            End If
        End If
        posicoes1.Show()
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        If Dir$("C:\jogo\tatica") <> "" Then
            CarregaEquipa1()
        Else
            MkDir("C:\jogo")
            SetAttr("C:\jogo", vbHidden)
            MsgBox("Escolha jogadores para as equipas.", MsgBoxStyle.Information, "Erro")
        End If
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        If Dir$("C:\jogo\tatica2") <> "" Then
            CarregaEquipa2()
        Else
            MkDir("C:\jogo")
            SetAttr("C:\jogo", vbHidden)
            MsgBox("Escolha jogadores para as equipas.", MsgBoxStyle.Information, "Erro")
        End If
    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim lvi As New ListViewItem
            lvi = ListView1.SelectedItems(0)
            Dim lvi2 As New ListViewItem
            lvi2 = CType(lvi.Clone, ListViewItem)
            ListView2.Items.Add(lvi2)
        End If
        For i As Integer = 0 To ListView1.SelectedIndices.Count - 1
            Dim lvi As ListViewItem = ListView1.Items(ListView1.SelectedIndices(i)).Clone
            Dim match As ListViewItem = ListView2.FindItemWithText(lvi.Text, True, 0, False)
            If (IsNothing(match) And (ListView2.Items.Count < 11)) Then
                ListView2.Items.Add(lvi)
            End If
        Next

        For Each lvItem As ListViewItem In ListView1.SelectedItems
            If Not (IsNothing(ListView2.FindItemWithText(lvItem.Text))) Then
                lvItem.Remove()
            End If
        Next

        Dim pla As Integer
        If (ListView2.Items.Count < 11) Then
            pla = 11 - ListView2.Items.Count
            Label12.Text = "Faltam escolher " & pla & " jogadores."
        Else
            Label15.Enabled = False
            Label12.Text = "11 Jogadores escolhidos!"
        End If
    End Sub
End Class