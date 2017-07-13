Imports MySql.Data.MySqlClient
Module Variables
    Public _host As String
    Public _port As String
    Public _uname As String
    Public _pwd As String
    Public MySQLConn As MySqlConnection
    Public comm As New MySqlCommand

    Public connstring = "server=" & _host & ";username=" & _uname & ";password=" & _pwd & ";database=jpcsregistration;"
End Module
