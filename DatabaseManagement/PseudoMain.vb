Imports MySql.Data.MySqlClient
Imports Microsoft.Win32
Public Class PseudoMain
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        MySQLConn = New MySqlConnection
        Dim DBBackup As New MySqlBackup
        MySQLConn.ConnectionString = connstring

        If sfd_DBExport.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Try
                MySQLConn.Open()
                comm = New MySqlCommand
                comm.Connection = MySQLConn
                DBBackup = New MySqlBackup(comm)
                With DBBackup
                    With .ExportInfo
                        .AddCreateDatabase = True
                        .EnableEncryption = True
                        .EncryptionPassword = "ee26b0dd4af7e749aa1a8ee3c10ae9923f618980772e473f8819a5d4940e0db27ac185f8a0e1d5f84f88bc887fd67b143732c304cc5fa9ad8e6f57f50028a8ff"

                    End With
                End With
            Catch ex As Exception

            End Try
        End If

    End Sub
End Class