Imports MySql.Data.MySqlClient

Module dbconnetion
    Public Conn As New MySqlConnection
    Public Cmd As New MySqlCommand
    Public Ds As DataSet
    Public Da As MySqlDataAdapter
    Public dr As MySqlDataReader
    Public MyDB As String
    Public i As Integer
    Public result As Boolean
    Public pro_title As String = "SMS"

    Public Function dbconn() As Boolean
        Try
            If Conn.State = ConnectionState.Closed Then
                Conn.ConnectionString = "server=localhost;userid=root;password='';database=db_inventaris"
                result = True
            End If
        Catch ex As Exception
            result = False
            MsgBox("Peringatan: Server tidak terhubung!", vbExclamation)
        End Try
        Return result
    End Function

    Public Sub Koneksi()
        Try
            If Conn.State = ConnectionState.Closed Then
                Conn.Open()
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
End Module
