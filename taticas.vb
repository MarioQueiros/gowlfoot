Imports system.drawing.region
Imports System.Drawing.Size
Imports System.Drawing.Drawing2D

Public Class taticas
    Public tat1Alterada, tat2Alterada As Boolean
    Dim tatEscolhida1, tatEscolhida2 As Integer
    Public tat As String
    Public tat2 As String
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

    Private Sub taticas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tatEscolhida1 = -1
        tatEscolhida2 = -1
        If My.Computer.FileSystem.DirectoryExists("C:\jogo") Then
            If My.Computer.FileSystem.FileExists("C:\jogo\tatica") Then
                Dim tat As IO.StreamReader = New IO.StreamReader("C:\jogo\tatica")
                ComboBox1.SelectedIndex = ComboBox1.FindString(tat.ReadLine)
                tat.Close()
            End If
            If My.Computer.FileSystem.FileExists("C:\jogo\tatica2") Then
                Dim tat As IO.StreamReader = New IO.StreamReader("C:\jogo\tatica2")
                ComboBox2.SelectedIndex = ComboBox2.FindString(tat.ReadLine)
                tat.Close()
            End If
        End If
        tatEscolhida1 = ComboBox1.SelectedIndex
        tatEscolhida2 = ComboBox2.SelectedIndex
    End Sub
    'verifica se a táctica introduzida for igual a uma anterior para activar o botão do carregador automático de equipas.
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged, ComboBox2.SelectedIndexChanged
        If (tatEscolhida1 >= 0) Then
            If (tatEscolhida1 <> ComboBox1.SelectedIndex) Then tat1Alterada = True
            If (tatEscolhida1 = ComboBox1.SelectedIndex) Then tat1Alterada = False
        End If
        If (tatEscolhida2 >= 0) Then
            If (tatEscolhida2 <> ComboBox2.SelectedIndex) Then tat2Alterada = True
            If (tatEscolhida2 = ComboBox2.SelectedIndex) Then tat2Alterada = False
        End If
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If My.Computer.FileSystem.DirectoryExists("C:\jogo") Then
            Dim tatica As IO.StreamWriter
            tatica = New IO.StreamWriter("C:\jogo\tatica")
            Dim tatica2 As IO.StreamWriter
            tatica2 = New IO.StreamWriter("C:\jogo\tatica2")
            Dim erro As Boolean
            erro = False
            If (ComboBox1.SelectedIndex > -1) Then
                tat = ComboBox1.SelectedItem.ToString()
                tatica.Write(tat)
            Else
                erro = True
            End If
            If (ComboBox2.SelectedIndex > -1) Then
                tat2 = ComboBox2.SelectedItem.ToString()
                tatica2.Write(tat2)
            Else
                erro = True
            End If
            If erro Then
                MsgBox("Falta escolher uma tática.", MsgBoxStyle.Information, "Erro")
                If (ComboBox1.SelectedIndex > -1) Then
                    ComboBox2.Focus()
                Else
                    ComboBox1.Focus()
                End If
            Else
                tatica.Close()
                tatica2.Close()
                equipas.Show()
            End If
        Else
            MkDir("C:\jogo")
            SetAttr("C:\jogo", vbHidden)
        End If
        Me.Close()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        If My.Computer.FileSystem.DirectoryExists("C:\jogo") Then
            Dim tatica As IO.StreamWriter
            tatica = New IO.StreamWriter("C:\jogo\tatica")
            Dim tatica2 As IO.StreamWriter
            tatica2 = New IO.StreamWriter("C:\jogo\tatica2")
            Dim erro As Boolean
            erro = False
            If (ComboBox1.SelectedIndex > -1) Then
                tat = ComboBox1.SelectedItem.ToString()
                tatica.Write(tat)
            Else
                erro = True
            End If
            If (ComboBox2.SelectedIndex > -1) Then
                tat2 = ComboBox2.SelectedItem.ToString()
                tatica2.Write(tat2)
            Else
                erro = True
            End If
            If erro Then
                MsgBox("Falta escolher uma tática.", MsgBoxStyle.Information, "Erro")
                If (ComboBox1.SelectedIndex > -1) Then
                    ComboBox2.Focus()
                Else
                    ComboBox1.Focus()
                End If
            Else
                tatica.Close()
                tatica2.Close()
                equipas.Show()
            End If
        Else
            MkDir("C:\jogo")
            SetAttr("C:\jogo", vbHidden)
        End If
        Me.Close()
    End Sub
End Class