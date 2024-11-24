Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle
Imports Org.BouncyCastle.Crypto.Parameters

Public Class FormLogin
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        Panel2.BackColor = Color.FromArgb(100, 23, 55, 94)
    End Sub

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal IParam As Integer)
    End Sub

    Private Sub TitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles TitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub


    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        If String.IsNullOrEmpty(txtUsername.Text) Or String.IsNullOrEmpty(txtPassword.Text) Then
            MessageBox.Show("Apakah semua data telah diisi ?", pro_title, MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Return
        End If

        Try
            Conn.Open()
            Cmd = New MySqlCommand("SELECT * FROM `user` WHERE username=@username", Conn)
            Cmd.Parameters.Clear()
            Cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            Dim da As New MySqlDataAdapter
            Dim dt As New DataTable
            da.SelectCommand = Cmd
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                Cmd = New MySqlCommand("SELECT * FROM `user` WHERE username=@username AND password=@password", Conn)
                Cmd.Parameters.Clear()
                Cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                Cmd.Parameters.AddWithValue("@password", txtPassword.Text)
                dr = Cmd.ExecuteReader

                If dr.Read Then
                    Dim username As String = dr.Item("username").ToString
                    Dim password As String = dr.Item("password").ToString
                    Dim role As String = dr.Item("role").ToString
                    Conn.Close()
                    txtUsername.Clear()
                    txtPassword.Clear()

                    If UCase(role) = "ADMIN" Then
                        Form1.Show()
                        Me.Hide()
                    ElseIf UCase(role) = "MAHASISWA" Then
                        FormMahasiswa.Show()
                        Me.Hide()
                    End If
                Else
                    MessageBox.Show("Warning : Password Incorrect !", pro_title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("Warning : User Not Found !", pro_title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Close()
        End Try
    End Sub


    Private Sub lblDaftar_Click(sender As Object, e As EventArgs) Handles lblDaftar.Click
        FormRegister.Show()
        Me.Hide()
    End Sub

End Class