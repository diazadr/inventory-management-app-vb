Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class FormNotifikasi
    Private Sub FormNotifikasi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If dbconn() Then
            KondisiAwal()
        Else
            MsgBox("Gagal terhubung ke server. Aplikasi akan keluar.", MsgBoxStyle.Critical)
            Application.Exit()
        End If
    End Sub

    Private Sub KondisiAwal()
        Try
            Koneksi()

            If dr IsNot Nothing AndAlso Not dr.IsClosed Then
                dr.Close()
            End If

            Da = New MySqlDataAdapter("SELECT * FROM `view_notifikasi`", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "view_notifikasi")
            DataGridView1.DataSource = Ds.Tables("view_notifikasi")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        End Try
    End Sub

End Class
