Imports MySql.Data.MySqlClient

Public Class FormStatus
    Private Sub FormStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            Dim cmd As New MySqlCommand("GetStatus", Conn)
            cmd.CommandType = CommandType.StoredProcedure

            Da = New MySqlDataAdapter(cmd)
            Ds = New DataSet
            Da.Fill(Ds, "view_status")
            DataGridView1.DataSource = Ds.Tables("view_status")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        End Try
    End Sub

End Class
