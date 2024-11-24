Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class FormBarang

    Private Sub FormBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dbconn() Then
            KondisiAwal()
            FillLokasiComboBox()
            config1()
        Else
            MsgBox("Gagal terhubung ke server. Aplikasi akan keluar.", MsgBoxStyle.Critical)
            Application.Exit()
        End If
    End Sub

    Sub FillLokasiComboBox()
        Try
            Koneksi()

            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If

            Dim query As String = "SELECT id_lokasi, CONCAT(nama_lokasi, ' - ', ruang_penyimpanan) AS LokasiInfo FROM lokasi"
            Cmd = New MySqlCommand(query, Conn)
            dr = Cmd.ExecuteReader

            cmbLokasi.Items.Clear()

            While dr.Read()
                cmbLokasi.Items.Add(New KeyValuePair(Of Integer, String)(CInt(dr("id_lokasi")), dr("LokasiInfo").ToString()))
            End While

            If cmbLokasi.Items.Count > 0 Then
                cmbLokasi.SelectedIndex = 0
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        End Try
    End Sub

    Sub clear()
        txtNamaBarang.Clear()
        txtJumlahBarang.Clear()
        txtMerk.Clear()
        cmbLokasi.SelectedIndex = -1
    End Sub

    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNamaBarang.Text = "" Or txtJumlahBarang.Text = "" Or txtMerk.Text = "" Or cmbLokasi.Text = "" Then
            MsgBox("Pastikan semua field terisi")
        Else
            Try
                Koneksi()
                Dim nama_barang, merk As String
                Dim jumlah_barang, id_lokasi As Integer

                nama_barang = txtNamaBarang.Text
                jumlah_barang = Convert.ToInt32(txtJumlahBarang.Text)
                merk = txtMerk.Text
                id_lokasi = DirectCast(cmbLokasi.SelectedItem, KeyValuePair(Of Integer, String)).Key

                Dim queryInputData As String = $"CALL InsertBarang('{nama_barang}', {jumlah_barang}, '{merk}', {id_lokasi})"
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
            If txtNamaBarang.Text = "" Or txtJumlahBarang.Text = "" Or txtMerk.Text = "" Or cmbLokasi.Text = "" Then
                MsgBox("Pastikan semua field terisi")
            Else
                Dim id_barang As Integer
                If Integer.TryParse(txtID.Text, id_barang) Then
                    Try
                        Koneksi()
                        Dim nama_barang, merk As String
                        Dim jumlah_barang, id_lokasi As Integer

                        nama_barang = txtNamaBarang.Text
                        jumlah_barang = Convert.ToInt32(txtJumlahBarang.Text)
                        merk = txtMerk.Text
                        id_lokasi = DirectCast(cmbLokasi.SelectedItem, KeyValuePair(Of Integer, String)).Key

                        Dim queryUpdateData As String = $"CALL UpdateBarang({id_barang}, '{nama_barang}', {jumlah_barang}, '{merk}', {id_lokasi})"
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
                    Cmd = New MySqlCommand($"SELECT * FROM `barang` WHERE `id_barang`='{id}'", Conn)
                    dr = Cmd.ExecuteReader
                    dr.Read()
                    If dr.HasRows Then
                        txtNamaBarang.Text = dr.Item("nama_barang")
                        txtJumlahBarang.Text = dr.Item("jumlah_barang").ToString()
                        txtMerk.Text = dr.Item("merk")
                        cmbLokasi.SelectedValue = dr.Item("id_lokasi")
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
                    Dim queryDeleteData As String = $"CALL DeleteBarang({id})"
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

            Da = New MySqlDataAdapter("SELECT * FROM `barang`", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "barang")
            DataGridView1.DataSource = Ds.Tables("barang")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally

            If Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        End Try
    End Sub

End Class
