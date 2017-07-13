<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PseudoMain
    Inherits System.Windows.Forms.Form

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
        Me.sfd_DBExport = New System.Windows.Forms.SaveFileDialog()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'sfd_DBExport
        '
        Me.sfd_DBExport.DefaultExt = "JPCS|*.jpcs"
        Me.sfd_DBExport.Filter = "JPCS|*.jpcs"
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(13, 161)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(100, 41)
        Me.btnExport.TabIndex = 0
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnRestore
        '
        Me.btnRestore.Location = New System.Drawing.Point(245, 161)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(100, 41)
        Me.btnRestore.TabIndex = 0
        Me.btnRestore.Text = "Restore"
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'PseudoMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 361)
        Me.Controls.Add(Me.btnRestore)
        Me.Controls.Add(Me.btnExport)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "PseudoMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PseudoMain"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents sfd_DBExport As SaveFileDialog
    Friend WithEvents btnExport As Button
    Friend WithEvents btnRestore As Button
End Class
