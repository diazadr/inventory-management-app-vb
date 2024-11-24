Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class FormRegisterAdmin

    Private Sub FormRegisterAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dbconn() Then
            KondisiAwal()
            config1()
        Else
            MsgBox("Gagal terhubung ke server. Aplikasi akan keluar.", MsgBoxStyle.Critical)
            Application.Exit()
        End If
    End Sub

    Sub clear()
        txtUsername.Clear()
        txtPassword.Clear()
        cmbRole.SelectedIndex = -1
    End Sub

    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        If txtUsername.Text = "" Or txtPassword.Text = "" Or cmbRole.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            Try
                Koneksi()
                Dim username, password, role As String
                username = txtUsername.Text
                password = txtPassword.Text
                role = cmbRole.Text
                Dim queryInputData As String = $"CALL InsertUser('{username}','{password}','{role}')"
                Cmd = New MySqlCommand(queryInputData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Input data berhasil")
                KondisiAwal()
                clear()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                Conn.Close()
            End Try
        End If
    End Sub




    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "Update" Then
            If txtUsername.Text = "" Or txtPassword.Text = "" Or cmbRole.Text = "" Then
                MsgBox("Pastikan semua field terisi")
            Else
                Dim id_user As Integer
                If Integer.TryParse(txtID.Text, id_user) Then
                    Try
                        Koneksi()
                        Dim username, password, role As String
                        username = txtUsername.Text
                        password = txtPassword.Text
                        role = cmbRole.Text
                        Dim queryUpdateData As String = $"CALL UpdateUser({id_user}, '{username}', '{password}', '{role}')"
                        Cmd = New MySqlCommand(queryUpdateData, Conn)
                        Cmd.ExecuteNonQuery()
                        MsgBox("Edit data berhasil")
                        clear()
                        KondisiAwal()
                        config1()
                    Catch ex As Exception
                        MsgBox("Error: " & ex.Message)
                    Finally
                        Conn.Close()
                    End Try
                Else
                    MsgBox("ID tidak valid")
                End If
            End If
        Else
            config2()
            btnEdit.Text = "Update"
        End If
    End Sub




    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        If Not String.IsNullOrEmpty(txtID.Text) Then
            Try
                Koneksi()
                If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                    dr.Close()
                End If

                Dim id As Integer
                If Integer.TryParse(txtID.Text, id) Then
                    Cmd = New MySqlCommand($"SELECT * FROM `user` WHERE `id_user`='{id}'", Conn)
                    dr = Cmd.ExecuteReader
                    dr.Read()
                    If dr.HasRows Then
                        txtUsername.Text = dr.Item("username")
                        txtPassword.Text = dr.Item("password")
                        cmbRole.Text = dr.Item("role")
                    Else
                        MsgBox("Data Tidak Ada")
                    End If
                Else
                    MsgBox("ID tidak valid")
                End If
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                If Conn.State = ConnectionState.Open Then
                    Conn.Close()
                End If
            End Try
        Else
            MsgBox("Masukkan ID terlebih dahulu")
        End If
    End Sub


    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If Not String.IsNullOrEmpty(txtID.Text) Then
            Koneksi()

            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If

            Dim id As Integer
            If Integer.TryParse(txtID.Text, id) Then
                Dim cekData As String = $"SELECT COUNT(*) FROM `user` WHERE `id_user`= '{id}'"
                Cmd = New MySqlCommand(cekData, Conn)
                Dim jumlahData As Integer = Convert.ToInt32(Cmd.ExecuteScalar())
                If jumlahData > 0 Then
                    Dim hapusdata As String = $"DELETE FROM `user` WHERE `id_user`= '{id}'"
                    Cmd = New MySqlCommand(hapusdata, Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Hapus data berhasil")
                    KondisiAwal()
                Else
                    MsgBox("ID tidak ditemukan")
                End If
            Else
                MsgBox("ID tidak valid")
            End If
        Else
            MsgBox("Masukkan ID terlebih dahulu")
        End If
    End Sub


    Private Sub config1()
        lblID.Visible = False
        txtID.Visible = False
        btnCheck.Visible = False
        btnEdit.Text = "Edit"
        btnHapus.Visible = False
    End Sub

    Private Sub config2()
        lblID.Visible = True
        txtID.Visible = True
        btnCheck.Visible = True
        btnEdit.Text = "Update"
        btnHapus.Visible = True
    End Sub

    Private Sub KondisiAwal()
        Try
            Koneksi()

            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If

            Da = New MySqlDataAdapter("SELECT * FROM `user`", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "user")
            DataGridView1.DataSource = Ds.Tables("user")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally

            If Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
