Imports System.Runtime.InteropServices
Imports MySql.Data.MySqlClient

Public Class FormRegister
    Private Sub FormRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbconn()
    End Sub

    Sub clear()
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            Try
                Conn.Open()
                Dim username, password, role As String
                username = txtUsername.Text
                password = txtPassword.Text
                role = "Mahasiswa"
                Dim queryInputData As String = $"CALL InsertUser('{username}','{password}','{role}')"
                Cmd = New MySqlCommand(queryInputData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Registrasi berhasil")
                clear()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                Conn.Close()
            End Try
        End If
    End Sub

    Private Sub lblLogin_Click(sender As Object, e As EventArgs) Handles lblLogin.Click
        FormLogin.Show()
        Me.Hide()
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
End Class
