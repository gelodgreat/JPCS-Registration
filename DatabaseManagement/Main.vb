Imports MySql.Data.MySqlClient
Imports Microsoft.Win32
Imports Telerik.WinControls
Imports System.IO

Public Class Main

    Public dbstatus As Boolean = False
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If Environment.GetCommandLineArgs.Count <= 1 Then
            RadMessageBox.Show(Me, "This Module can only be launched using JPCS Registration")
            End
        End If
        If (Environment.GetCommandLineArgs(1) <> "-TestArg") Then
            RadMessageBox.Show(Me, "Invalid Argument Detected. Pleast launch this module using the JPCS Registration.")
            End
        End If
        _host = My.Settings.server
        _port = My.Settings.port
        _uname = Actions.Actions.ToInsecureString(Actions.Actions.DecryptString(My.Settings.username))
        _pwd = Actions.Actions.ToInsecureString(Actions.Actions.DecryptString(My.Settings.password))

        With lblServer
            If checkservercreds() Then

                .Text = "Connected to Server"
                btnRestore.Enabled = True
            Else
                .Text = "Failed to establish a Connection to the MySQL Server"
                btnExport.Enabled = False
                btnRestore.Enabled = False
            End If
        End With

        With lblDatabase
            If checkdbstatus() Then
                .Text = "Database exists"
            Else
                .Text = "Database does not exist in the specified MySQL Server. You may need to restore it first."
                btnExport.Enabled = False
            End If
        End With

    End Sub

#Region "CheckServerCreds"
    Public Function checkservercreds() As Boolean
        MySQLConn = New MySqlConnection
        MySQLConn.ConnectionString = connstring
        Dim check As Boolean = False


        Try
            MySQLConn.Open()
            check = True
            MySQLConn.Close()
        Catch ex As Exception

        Finally
            MySQLConn.Dispose()
        End Try
        Return check


    End Function
#End Region

#Region "CheckDBStatus"
    Public Function checkdbstatus() As Boolean

        MySQLConn = New MySqlConnection
        MySQLConn.ConnectionString = connstring & _db
        Dim check As Boolean = False


        Try
            MySQLConn.Open()
            check = True
            MySQLConn.Close()
        Catch ex As Exception
        Finally
            MySQLConn.Dispose()
        End Try
        Return check

    End Function

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        If sfd_DBExport.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Dim filename As String = sfd_DBExport.FileName
            MySQLConn.ConnectionString = connstring & _db
            comm = New MySqlCommand
            Dim backup As New MySqlBackup
            comm.Connection = MySQLConn
            Try
                MySQLConn.Open()
                backup = New MySqlBackup(comm)
                With backup
                    With .ExportInfo
                        .AddCreateDatabase = True
                        .EnableEncryption = True
                        .EncryptionPassword = "ee26b0dd4af7e749aa1a8ee3c10ae9923f618980772e473f8819a5d4940e0db27ac185f8a0e1d5f84f88bc887fd67b143732c304cc5fa9ad8e6f57f50028a8ff"
                        .ExportProcedures = True
                    End With
                    .ExportToFile("db.sql")
                End With
                MySQLConn.Close()
                Dim Archive As New Process
                With Archive
                    With .StartInfo
                        .WindowStyle = ProcessWindowStyle.Hidden
                        .CreateNoWindow = True
                        .FileName = "7z.exe"
                        .Arguments = "a backup.7z db.sql -p123 -mhe"
                    End With
                    .Start()
                    .WaitForExit()
                End With

                Dim backupArchive As New FileInfo("backup.7z")
                If File.Exists(filename) Then
                    File.Delete(filename)
                End If
                backupArchive.MoveTo(filename)
                Dim dbfile As New FileInfo("db.sql")
                dbfile.Delete()
                MsgBox("Backup succesful!", MsgBoxStyle.Information, "JPCS Registration Database Tool")

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MySQLConn.Dispose()
            End Try
        End If
    End Sub

    Private Sub Main_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        With lblServer
            If checkservercreds() Then

                .Text = "Connected to Server"
                btnRestore.Enabled = True
            Else
                .Text = "Failed to establish a Connection to the MySQL Server"
                btnExport.Enabled = False
                btnRestore.Enabled = False
            End If
        End With

        With lblDatabase
            If checkdbstatus() Then
                .Text = "Database exists"
                btnExport.Enabled = True
            Else
                .Text = "Database does not exist in the specified MySQL Server"
                btnExport.Enabled = False
            End If
        End With
    End Sub

    Private Sub btnConfigure_Click(sender As Object, e As EventArgs) Handles btnConfigure.Click
        Credentials.ShowDialog()
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        If ofd_DBRestore.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Dim filename As String = ofd_DBRestore.FileName
            MySQLConn.ConnectionString = connstring
            comm = New MySqlCommand
            Dim DBRestore As New MySqlBackup
            comm.Connection = MySQLConn

            Dim Archive As New Process
            With Archive
                With .StartInfo
                    '.WindowStyle = ProcessWindowStyle.Hidden
                    '.CreateNoWindow = True
                    .FileName = "7z.exe"
                    .Arguments = "e " & filename & " -aoa -p123"
                End With
                .Start()
                .WaitForExit()
            End With

            Try
                MySQLConn.Open()
                comm.Connection = MySQLConn
                DBRestore = New MySqlBackup(comm)
                With DBRestore
                    With .ImportInfo
                        .EnableEncryption = True
                        .EncryptionPassword = "ee26b0dd4af7e749aa1a8ee3c10ae9923f618980772e473f8819a5d4940e0db27ac185f8a0e1d5f84f88bc887fd67b143732c304cc5fa9ad8e6f57f50028a8ff"
                    End With
                    .ImportFromFile("db.sql")
                End With
                MySQLConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MySQLConn.Dispose()
            End Try
            Dim file As New FileInfo("db.sql")
            file.Delete()
            MySQLConn.Close()
            MessageBox.Show(Me, "Restore successful.", "JPCS Database Manager", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
#End Region

End Class
