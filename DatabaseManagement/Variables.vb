Imports MySql.Data.MySqlClient
Imports Actions.Actions
Module Variables
    Public _host As String = My.Settings.server
    Public _port As String = My.Settings.port
    Public _uname As String = Actions.Actions.ToInsecureString(Actions.Actions.DecryptString(My.Settings.username))
    Public _pwd As String = Actions.Actions.ToInsecureString(Actions.Actions.DecryptString(My.Settings.password))
    Public _db As String = "database=jpcsregistration;"
    Public MySQLConn As MySqlConnection
    Public comm As New MySqlCommand

    Public connstring = "server=" & _host & ";port=" & _port & ";username=" & _uname & ";password=" & _pwd & ";"
End Module
