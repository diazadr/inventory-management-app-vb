Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class FormLokasi

    Private Sub FormLokasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dbconn() Then
            KondisiAwal()
            config1()
        Else
            MsgBox("Gagal terhubung ke server. Aplikasi akan keluar.", MsgBoxStyle.Critical)
            Application.Exit()
        End If
    End Sub

    Sub clear()
        txtNamaLokasi.Clear()
        txtRuangPenyimpanan.Clear()
    End Sub

    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNamaLokasi.Text = "" Or txtRuangPenyimpanan.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            Try
                Koneksi()
                Dim nama_lokasi, ruang_penyimpanan As String
                nama_lokasi = txtNamaLokasi.Text
                ruang_penyimpanan = txtRuangPenyimpanan.Text
                Dim queryInputData As String = $"CALL InsertLokasi('{nama_lokasi}','{ruang_penyimpanan}')"
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
            If txtNamaLokasi.Text = "" Or txtRuangPenyimpanan.Text = "" Then
                MsgBox("Pastikan semua field terisi")
            Else
                Dim id_lokasi As Integer
                If Integer.TryParse(txtID.Text, id_lokasi) Then
                    Try
                        Koneksi()
                        Dim nama_lokasi, ruang_penyimpanan As String
                        nama_lokasi = txtNamaLokasi.Text
                        ruang_penyimpanan = txtRuangPenyimpanan.Text
                        Dim queryUpdateData As String = $"CALL UpdateLokasi({id_lokasi}, '{nama_lokasi}', '{ruang_penyimpanan}')"
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
                    Cmd = New MySqlCommand($"SELECT * FROM `lokasi` WHERE `id_lokasi`='{id}'", Conn)
                    dr = Cmd.ExecuteReader
                    dr.Read()
                    If dr.HasRows Then
                        txtNamaLokasi.Text = dr.Item("nama_lokasi")
                        txtRuangPenyimpanan.Text = dr.Item("ruang_penyimpanan")
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
                Try
                    ' Panggil stored procedure DeleteLokasi
                    Dim queryDeleteData As String = $"CALL DeleteLokasi({id})"
                    Cmd = New MySqlCommand(queryDeleteData, Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Hapus data berhasil")
                    KondisiAwal()
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                Finally
                    Conn.Close()
                End Try
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

            Da = New MySqlDataAdapter("SELECT * FROM `lokasi`", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "lokasi")
            DataGridView1.DataSource = Ds.Tables("lokasi")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally

            If Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        End Try
    End Sub
End Class
