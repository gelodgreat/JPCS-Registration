Public Class Credentials
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        My.Settings.server = txtServer.Text
        My.Settings.port = txtPort.Text
        My.Settings.username = Actions.Actions.EncryptString(Actions.Actions.ToSecureString(txtUsername.Text))
        My.Settings.password = Actions.Actions.EncryptString(Actions.Actions.ToSecureString(txtPassword.Text))
        My.Settings.Save()

        _host = My.Settings.server
        _port = My.Settings.port
        _uname = Actions.Actions.ToInsecureString(Actions.Actions.DecryptString(My.Settings.username))
        _pwd = Actions.Actions.ToInsecureString(Actions.Actions.DecryptString(My.Settings.password))

        connstring = "server=" & _host & ";port=" & _port & ";username=" & _uname & ";password=" & _pwd & ";"
        Me.Dispose()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()

    End Sub
End Class
