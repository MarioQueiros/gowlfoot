Imports System.Data.SqlClient
Imports System.Math
Imports System.Threading
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Imports System.Random

Public Class campeonato
    Private WM_NCHITTEST As Integer = &H84
    Private HTCLIENT As Integer = &H1          ' arrastar
    Private HTCAPTION As Integer = &H2
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
    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)
        Select Case m.Msg
            Case WM_NCHITTEST
                If m.Result = New IntPtr(HTCLIENT) Then
                    m.Result = New IntPtr(HTCAPTION)
                End If
        End Select
    End Sub


    Private Sub campeonato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim constr As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=|datadirectory|jogadores.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
            Dim db As New SqlConnection(constr)
            db.Open()
            eq1 = "select p1 from classificacao"
            eq2 = "select p2 from classificacao"
            Dim cd As New SqlCommand(eq1, db)
            Dim cd2 As New SqlCommand(eq2, db)
            Dim dr As SqlDataReader
            Dim dr2 As SqlDataReader
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
            db.Close()
            If a > b Then
                Me.Label3.Text = "S. L. Benfica"
                Me.Label1.Text = "F. C. Porto"
                db.Open()
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

                Dim cdm1 As New SqlCommand(eq1, db)
                Dim cdm2 As New SqlCommand(eq2, db)
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

                Dim drr1 As SqlDataReader
                Dim drr2 As SqlDataReader
                Dim dr3 As SqlDataReader
                Dim dr4 As SqlDataReader
                Dim drr5 As SqlDataReader
                Dim dr6 As SqlDataReader
                Dim dr7 As SqlDataReader
                Dim dr8 As SqlDataReader
                Dim dr9 As SqlDataReader
                Dim dr10 As SqlDataReader
                Dim dr11 As SqlDataReader
                Dim dr12 As SqlDataReader
                Dim dr13 As SqlDataReader
                Dim dr14 As SqlDataReader


                drr1 = cdm1.ExecuteReader
                While drr1.Read()
                    a = CInt(drr1.Item("p1"))
                End While
                drr1.Close()
                drr2 = cdm2.ExecuteReader
                While drr2.Read()
                    b = CInt(drr2.Item("p2"))
                End While
                drr2.Close()
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
                drr5 = cdd5.ExecuteReader
                While drr5.Read()
                    ee = CInt(drr5.Item("gs1"))
                End While
                drr5.Close()
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
                db.Close()

                Label11.Text = g
                Label12.Text = h
                Label14.Text = l
                Label13.Text = m
                Label16.Text = j
                Label15.Text = k
                Label18.Text = a
                Label17.Text = b
                Label23.Text = c
                Label22.Text = d
                Label24.Text = ee
                Label25.Text = f
                Me.Label9.Text = n
                Me.Label4.Text = o
            Else
                Me.Label1.Text = "S. L. Benfica"
                Me.Label3.Text = "F. C. Porto"
                db.Open()
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

                Dim cdm1 As New SqlCommand(eq1, db)
                Dim cdm2 As New SqlCommand(eq2, db)
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

                Dim drr1 As SqlDataReader
                Dim drr2 As SqlDataReader
                Dim dr3 As SqlDataReader
                Dim dr4 As SqlDataReader
                Dim drr5 As SqlDataReader
                Dim dr6 As SqlDataReader
                Dim dr7 As SqlDataReader
                Dim dr8 As SqlDataReader
                Dim dr9 As SqlDataReader
                Dim dr10 As SqlDataReader
                Dim dr11 As SqlDataReader
                Dim dr12 As SqlDataReader
                Dim dr13 As SqlDataReader
                Dim dr14 As SqlDataReader


                drr1 = cdm1.ExecuteReader
                While drr1.Read()
                    a = CInt(drr1.Item("p1"))
                End While
                drr1.Close()
                drr2 = cdm2.ExecuteReader
                While drr2.Read()
                    b = CInt(drr2.Item("p2"))
                End While
                drr2.Close()
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
                drr5 = cdd5.ExecuteReader
                While drr5.Read()
                    ee = CInt(drr5.Item("gs1"))
                End While
                drr5.Close()
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
                db.Close()

                Label11.Text = h
                Label12.Text = g
                Label14.Text = m
                Label13.Text = l
                Label16.Text = k
                Label15.Text = j
                Label18.Text = b
                Label17.Text = a
                Label23.Text = d
                Label22.Text = c
                Label24.Text = f
                Label25.Text = ee
                Me.Label9.Text = o
                Me.Label4.Text = n

            End If
        Catch ex As Exception
            MessageBox.Show("Problemas de conexão á Base de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Try
            Dim constr As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=|datadirectory|jogadores.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"
            Dim db As New SqlConnection(constr)
            db.Open()
            jogos1 = "select jo1 from classificacao"
            Dim cd13 As New SqlCommand(jogos1, db)
            Dim dr13 As SqlDataReader
            Dim n As Integer
            dr13 = cd13.ExecuteReader
            While dr13.Read()
                n = CInt(dr13.Item("jo1"))
            End While
            dr13.Close()
            If n = 10 Then
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

                va3 = "update classificacao set gm1=0 where gm1=" & c & ""
                Dim cmd3 As New SqlCommand(va3, db)
                cmd3.ExecuteScalar()
                va4 = "update classificacao set gm2=0 where gm2=" & d & ""
                Dim cmd4 As New SqlCommand(va4, db)
                cmd4.ExecuteScalar()
                va5 = "update classificacao set gs1=0 where gs1=" & ee & ""
                Dim cmd5 As New SqlCommand(va5, db)
                cmd5.ExecuteScalar()
                va6 = "update classificacao set gs2=0 where gs2=" & f & ""
                Dim cmd6 As New SqlCommand(va6, db)
                cmd6.ExecuteScalar()
                va13 = "update classificacao set jo1=0 where jo1=" & n & ""
                Dim cmd13 As New SqlCommand(va13, db)
                cmd13.ExecuteScalar()
                va14 = "update classificacao set jo2=0 where jo2=" & o & ""
                Dim cmd14 As New SqlCommand(va14, db)
                cmd14.ExecuteScalar()
                va1 = "update classificacao set p1=0 where p1=" & a & ""
                Dim cmd As New SqlCommand(va1, db)
                cmd.ExecuteScalar()
                va7 = "update classificacao set vit1=0 where vit1=" & g & ""
                Dim cmd7 As New SqlCommand(va7, db)
                cmd7.ExecuteScalar()
                va10 = "update classificacao set de2=0 where de2=" & k & ""
                Dim cmd10 As New SqlCommand(va10, db)
                cmd10.ExecuteScalar()
                va2 = "update classificacao set p2=0 where p2=" & b & ""
                Dim cmd2 As New SqlCommand(va2, db)
                cmd2.ExecuteScalar()
                va8 = "update classificacao set vit2=0 where vit2=" & h & ""
                Dim cmd8 As New SqlCommand(va8, db)
                cmd8.ExecuteScalar()
                va9 = "update classificacao set de1=0 where de1=" & j & ""
                Dim cmd9 As New SqlCommand(va9, db)
                cmd9.ExecuteScalar()
                va11 = "update classificacao set em1=0 where em1=" & l & ""
                Dim cmd11 As New SqlCommand(va11, db)
                cmd11.ExecuteScalar()
                va12 = "update classificacao set em2=0 where em2=" & m & ""
                Dim cmd12 As New SqlCommand(va12, db)
                cmd12.ExecuteScalar()
            End If
            db.Close()
            principal.Show()
            Me.Close()
            equipas.Close()
            totais.Close()
            relatório_de_jogo.Close()
        Catch ex As Exception
            MessageBox.Show("Erro de conexão á Base de Dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class