Imports System.Windows.Forms.VisualStyles
Imports MySql.Data.MySqlClient

Public Class FormInventaris
    Private Sub FormInventaris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dbconn() Then
            KondisiAwal()
            IsiComboBoxBarang()
            config1()
        Else
            MsgBox("Gagal terhubung ke server. Aplikasi akan keluar.", MsgBoxStyle.Critical)
            Application.Exit()
        End If
    End Sub

    Sub IsiComboBoxBarang()
        Try
            Koneksi()

            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If

            Dim query As String = "SELECT id_barang, CONCAT(nama_barang, ' - ', merk) AS InfoBarang FROM barang"
            Cmd = New MySqlCommand(query, Conn)
            dr = Cmd.ExecuteReader

            cmbBarang.Items.Clear()

            While dr.Read()
                cmbBarang.Items.Add(New KeyValuePair(Of Integer, String)(CInt(dr("id_barang")), dr("InfoBarang").ToString()))
            End While

            If cmbBarang.Items.Count > 0 Then
                cmbBarang.SelectedIndex = 0
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        End Try
    End Sub

    Sub Bersihkan()
        txtKeterangan.Text = ""
        txtKondisi.Text = ""
        cmbBarang.SelectedIndex = -1
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If cmbBarang.SelectedIndex = -1 Then
            MsgBox("Pilih barang terlebih dahulu")
        Else
            Try
                Koneksi()
                Dim id_barang As Integer
                Dim keterangan_inventaris As String = txtKeterangan.Text
                Dim kondisi_barang As String = txtKondisi.Text
                id_barang = DirectCast(cmbBarang.SelectedItem, KeyValuePair(Of Integer, String)).Key

                Dim queryInputData As String = $"CALL InsertInventaris('{keterangan_inventaris}', '{kondisi_barang}', {id_barang})"
                Cmd = New MySqlCommand(queryInputData, Conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Input data berhasil")
                KondisiAwal()
                Bersihkan()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                Conn.Close()
            End Try
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "Update" Then
            Dim id_peminjaman As Integer
            If Integer.TryParse(txtID.Text, id_peminjaman) Then
                Try
                    Koneksi()
                    Dim id_barang As Integer
                    Dim keterangan_inventaris As String = txtKeterangan.Text
                    Dim kondisi_barang As String = txtKondisi.Text

                    id_barang = DirectCast(cmbBarang.SelectedItem, KeyValuePair(Of Integer, String)).Key

                    Dim queryUpdateData As String = $"CALL UpdateInventaris('{keterangan_inventaris}', '{kondisi_barang}', {id_barang})"
                    Cmd = New MySqlCommand(queryUpdateData, Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Edit data berhasil")
                    Bersihkan()
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
                    Cmd = New MySqlCommand($"SELECT * FROM `inventaris` WHERE `id_inventaris`='{id}'", Conn)
                    dr = Cmd.ExecuteReader
                    dr.Read()
                    If dr.HasRows Then
                        txtKeterangan.Text = dr.Item("keterangan_inventaris").ToString()
                        txtKondisi.Text = dr.Item("kondisi_barang").ToString()
                        cmbBarang.SelectedValue = dr.Item("id_barang")
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
            Dim id_inventaris As Integer

            If Integer.TryParse(txtID.Text, id_inventaris) Then
                Try
                    Koneksi()

                    If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                        dr.Close()
                    End If

                    Dim cekData As String = $"SELECT COUNT(*) FROM `inventaris` WHERE `id_inventaris`= '{id_inventaris}'"
                    Cmd = New MySqlCommand(cekData, Conn)
                    Dim jumlahData As Integer = Convert.ToInt32(Cmd.ExecuteScalar())

                    If jumlahData > 0 Then
                        Dim hapusdata As String = $"CALL DeleteInventaris('{id_inventaris}')"
                        Cmd = New MySqlCommand(hapusdata, Conn)
                        Cmd.ExecuteNonQuery()

                        MsgBox("Hapus data berhasil")
                        KondisiAwal()
                    Else
                        MsgBox("ID tidak ditemukan")
                    End If
                Catch ex As Exception
                    MsgBox("Error: " & ex.Message)
                Finally
                    If Conn.State = ConnectionState.Open Then
                        Conn.Close()
                    End If
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

            Da = New MySqlDataAdapter("SELECT * FROM `inventaris`", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "inventaris")
            DataGridView1.DataSource = Ds.Tables("inventaris")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        End Try
    End Sub
End Class
