Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient
Imports excel = Microsoft.Office.Interop.Excel

Public Class FormLaporan
    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            Da = New MySqlDataAdapter("SELECT * FROM `view_laporan`", Conn)
            Ds = New DataSet
            Da.Fill(Ds, "view_laporan")
            DataGridView1.DataSource = Ds.Tables("view_laporan")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        End Try
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        SaveFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx"

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim xlaapp As Microsoft.Office.Interop.Excel.Application
            Dim xlworkbook As Microsoft.Office.Interop.Excel.Workbook
            Dim xlworksheet As Microsoft.Office.Interop.Excel.Worksheet
            Dim misvalue As Object = System.Reflection.Missing.Value
            Dim i As Integer
            Dim j As Integer

            xlaapp = New Microsoft.Office.Interop.Excel.Application
            xlworkbook = xlaapp.Workbooks.Add(misvalue)
            xlworksheet = xlworkbook.Sheets("Sheet1")

            For i = 0 To DataGridView1.RowCount - 2
                For j = 0 To DataGridView1.ColumnCount - 1
                    For k As Integer = 1 To DataGridView1.Columns.Count
                        xlworksheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                        xlworksheet.Cells(i + 2, j + 2) = DataGridView1(j, i).Value.ToString()
                    Next
                Next
            Next
            xlworksheet.SaveAs(SaveFileDialog1.FileName)
            xlworkbook.Close()
            xlaapp.Quit()

            releaseobject(xlaapp)
            releaseobject(xlworkbook)
            releaseobject(xlworksheet)

            MessageBox.Show("Proses Export Berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub releaseobject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

End Class
