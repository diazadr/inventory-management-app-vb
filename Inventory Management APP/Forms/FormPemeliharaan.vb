Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class FormPemeliharaan
    Private Sub FormPemeliharaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        cmbBarang.SelectedIndex = -1
        dateJadwal.Value = DateTime.Now
        txtPerbaikan.Clear()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If cmbBarang.SelectedIndex = -1 Then
            MsgBox("Pilih barang terlebih dahulu")
        Else
            Try
                Koneksi()
                Dim id_barang As Integer
                Dim jadwal_pemeliharaan As String = dateJadwal.Value.ToString("yyyy-MM-dd")
                Dim perbaikan_barang As String = txtPerbaikan.Text

                id_barang = DirectCast(cmbBarang.SelectedItem, KeyValuePair(Of Integer, String)).Key

                Dim queryInputData As String = $"CALL InsertPemeliharaan({id_barang}, '{jadwal_pemeliharaan}', '{perbaikan_barang}')"
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
            If cmbBarang.SelectedIndex = -1 Then
                MsgBox("Pilih barang terlebih dahulu")
            Else
                Dim id_pemeliharaan As Integer
                If Integer.TryParse(txtID.Text, id_pemeliharaan) Then
                    Try
                        Koneksi()
                        Dim id_barang As Integer
                        Dim jadwal_pemeliharaan As String = dateJadwal.Value.ToString("yyyy-MM-dd")
                        Dim perbaikan_barang As String = txtPerbaikan.Text

                        id_barang = DirectCast(cmbBarang.SelectedItem, KeyValuePair(Of Integer, String)).Key

                        Dim queryUpdateData As String = $"CALL UpdatePemeliharaan({id_pemeliharaan}, {id_barang}, '{jadwal_pemeliharaan}', '{perbaikan_barang}')"
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
                    Cmd = New MySqlCommand($"SELECT * FROM `pemeliharaan` WHERE `id_pemeliharaan`='{id}'", Conn)
                    dr = Cmd.ExecuteReader
                    dr.Read()
                    If dr.HasRows Then
                        cmbBarang.SelectedValue = dr.Item("id_barang")
                        dateJadwal.Value = DateTime.Parse(dr.Item("jadwal_pemeliharaan").ToString())
                        txtPerbaikan.Text = dr.Item("perbaikan_barang").ToString()
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
                    Dim queryDeleteData As String = $"CALL DeletePemeliharaan({id})"
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

            Da = New MySqlDataAdapter("SELECT * FROM `pemeliharaan`", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "pemeliharaan")
            DataGridView1.DataSource = Ds.Tables("pemeliharaan")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        End Try
    End Sub
End Class
