<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits Telerik.WinControls.UI.RadForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.sfd_DBExport = New System.Windows.Forms.SaveFileDialog()
        Me.btnExport = New Telerik.WinControls.UI.RadButton()
        Me.btnRestore = New Telerik.WinControls.UI.RadButton()
        Me.lblServer = New Telerik.WinControls.UI.RadLabel()
        Me.lblDatabase = New Telerik.WinControls.UI.RadLabel()
        Me.VisualStudio2012DarkTheme1 = New Telerik.WinControls.Themes.VisualStudio2012DarkTheme()
        Me.btnConfigure = New Telerik.WinControls.UI.RadButton()
        CType(Me.btnExport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRestore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblServer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblDatabase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnConfigure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sfd_DBExport
        '
        Me.sfd_DBExport.DefaultExt = "JPCS|*.jpcs"
        Me.sfd_DBExport.Filter = "JPCS|*.jpcs"
        '
        'btnExport
        '
        Me.btnExport.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnExport.Location = New System.Drawing.Point(25, 167)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(153, 51)
        Me.btnExport.TabIndex = 0
        Me.btnExport.Text = "Export"
        Me.btnExport.ThemeName = "VisualStudio2012Dark"
        '
        'btnRestore
        '
        Me.btnRestore.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnRestore.Location = New System.Drawing.Point(25, 248)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(153, 51)
        Me.btnRestore.TabIndex = 1
        Me.btnRestore.Text = "Restore"
        Me.btnRestore.ThemeName = "VisualStudio2012Dark"
        '
        'lblServer
        '
        Me.lblServer.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblServer.Location = New System.Drawing.Point(12, 12)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(88, 31)
        Me.lblServer.TabIndex = 1
        Me.lblServer.Text = "lblServer"
        Me.lblServer.ThemeName = "VisualStudio2012Dark"
        '
        'lblDatabase
        '
        Me.lblDatabase.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lblDatabase.Location = New System.Drawing.Point(11, 49)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(116, 31)
        Me.lblDatabase.TabIndex = 1
        Me.lblDatabase.Text = "lblDatabase"
        Me.lblDatabase.ThemeName = "VisualStudio2012Dark"
        '
        'btnConfigure
        '
        Me.btnConfigure.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnConfigure.Location = New System.Drawing.Point(388, 326)
        Me.btnConfigure.Name = "btnConfigure"
        Me.btnConfigure.Size = New System.Drawing.Size(153, 51)
        Me.btnConfigure.TabIndex = 0
        Me.btnConfigure.Text = "Configure"
        Me.btnConfigure.ThemeName = "VisualStudio2012Dark"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 389)
        Me.Controls.Add(Me.lblDatabase)
        Me.Controls.Add(Me.lblServer)
        Me.Controls.Add(Me.btnRestore)
        Me.Controls.Add(Me.btnConfigure)
        Me.Controls.Add(Me.btnExport)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.ThemeName = "VisualStudio2012Dark"
        CType(Me.btnExport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRestore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblServer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblDatabase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnConfigure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sfd_DBExport As SaveFileDialog
    Friend WithEvents btnExport As Telerik.WinControls.UI.RadButton
    Friend WithEvents btnRestore As Telerik.WinControls.UI.RadButton
    Friend WithEvents lblServer As Telerik.WinControls.UI.RadLabel
    Friend WithEvents lblDatabase As Telerik.WinControls.UI.RadLabel
    Friend WithEvents VisualStudio2012DarkTheme1 As Telerik.WinControls.Themes.VisualStudio2012DarkTheme
    Friend WithEvents btnConfigure As Telerik.WinControls.UI.RadButton
End Class

