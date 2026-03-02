<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCambioClave
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlWarningBar = New System.Windows.Forms.Panel()
        Me.lblWarningIcon = New System.Windows.Forms.Label()
        Me.lblWarningText = New System.Windows.Forms.Label()
        Me.pnlCuerpo = New System.Windows.Forms.Panel()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblNueva = New System.Windows.Forms.Label()
        Me.txtNueva = New System.Windows.Forms.TextBox()
        Me.lblRepetir = New System.Windows.Forms.Label()
        Me.txtRepetir = New System.Windows.Forms.TextBox()
        Me.btnCambiar = New System.Windows.Forms.Button()
        Me.pnlWarningBar.SuspendLayout()
        Me.pnlCuerpo.SuspendLayout()
        Me.SuspendLayout()
        '
        ' pnlWarningBar — franja de aviso superior color ámbar oscuro
        '
        Me.pnlWarningBar.BackColor = System.Drawing.Color.FromArgb(35, 28, 0)
        Me.pnlWarningBar.Controls.Add(Me.lblWarningIcon)
        Me.pnlWarningBar.Controls.Add(Me.lblWarningText)
        Me.pnlWarningBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlWarningBar.Height = 60
        Me.pnlWarningBar.Name = "pnlWarningBar"
        '
        ' lblWarningIcon
        '
        Me.lblWarningIcon.Text = "⚠"
        Me.lblWarningIcon.Font = New System.Drawing.Font("Segoe UI Emoji", 20)
        Me.lblWarningIcon.ForeColor = System.Drawing.Color.FromArgb(255, 189, 46)
        Me.lblWarningIcon.AutoSize = True
        Me.lblWarningIcon.Location = New System.Drawing.Point(16, 12)
        Me.lblWarningIcon.Name = "lblWarningIcon"
        '
        ' lblWarningText
        '
        Me.lblWarningText.Text = "Debes cambiar tu contraseña para continuar"
        Me.lblWarningText.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        Me.lblWarningText.ForeColor = System.Drawing.Color.FromArgb(255, 189, 46)
        Me.lblWarningText.AutoSize = True
        Me.lblWarningText.Location = New System.Drawing.Point(58, 20)
        Me.lblWarningText.Name = "lblWarningText"
        '
        ' pnlCuerpo
        '
        Me.pnlCuerpo.BackColor = System.Drawing.Color.FromArgb(13, 17, 23)
        Me.pnlCuerpo.Controls.Add(Me.lblDescripcion)
        Me.pnlCuerpo.Controls.Add(Me.lblNueva)
        Me.pnlCuerpo.Controls.Add(Me.txtNueva)
        Me.pnlCuerpo.Controls.Add(Me.lblRepetir)
        Me.pnlCuerpo.Controls.Add(Me.txtRepetir)
        Me.pnlCuerpo.Controls.Add(Me.btnCambiar)
        Me.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCuerpo.Name = "pnlCuerpo"
        '
        ' lblDescripcion
        '
        Me.lblDescripcion.Text = "Por política de seguridad, el sistema ha generado una contraseña temporal." & vbCrLf & "Elige una nueva ahora."
        Me.lblDescripcion.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(125, 133, 144)
        Me.lblDescripcion.AutoSize = False
        Me.lblDescripcion.Size = New System.Drawing.Size(360, 44)
        Me.lblDescripcion.Location = New System.Drawing.Point(40, 18)
        Me.lblDescripcion.Name = "lblDescripcion"
        '
        ' lblNueva
        '
        Me.lblNueva.Text = "Nueva contraseña"
        Me.lblNueva.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.lblNueva.ForeColor = System.Drawing.Color.FromArgb(201, 209, 217)
        Me.lblNueva.AutoSize = True
        Me.lblNueva.Location = New System.Drawing.Point(40, 76)
        Me.lblNueva.Name = "lblNueva"
        '
        ' txtNueva
        '
        Me.txtNueva.BackColor = System.Drawing.Color.FromArgb(22, 27, 34)
        Me.txtNueva.ForeColor = System.Drawing.Color.FromArgb(201, 209, 217)
        Me.txtNueva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNueva.Font = New System.Drawing.Font("Segoe UI", 11)
        Me.txtNueva.UseSystemPasswordChar = True
        Me.txtNueva.Location = New System.Drawing.Point(40, 98)
        Me.txtNueva.Name = "txtNueva"
        Me.txtNueva.Size = New System.Drawing.Size(350, 32)
        Me.txtNueva.TabIndex = 0
        '
        ' lblRepetir
        '
        Me.lblRepetir.Text = "Confirmar contraseña"
        Me.lblRepetir.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.lblRepetir.ForeColor = System.Drawing.Color.FromArgb(201, 209, 217)
        Me.lblRepetir.AutoSize = True
        Me.lblRepetir.Location = New System.Drawing.Point(40, 152)
        Me.lblRepetir.Name = "lblRepetir"
        '
        ' txtRepetir
        '
        Me.txtRepetir.BackColor = System.Drawing.Color.FromArgb(22, 27, 34)
        Me.txtRepetir.ForeColor = System.Drawing.Color.FromArgb(201, 209, 217)
        Me.txtRepetir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRepetir.Font = New System.Drawing.Font("Segoe UI", 11)
        Me.txtRepetir.UseSystemPasswordChar = True
        Me.txtRepetir.Location = New System.Drawing.Point(40, 174)
        Me.txtRepetir.Name = "txtRepetir"
        Me.txtRepetir.Size = New System.Drawing.Size(350, 32)
        Me.txtRepetir.TabIndex = 1
        '
        ' btnCambiar
        '
        Me.btnCambiar.Text = "Confirmar y acceder"
        Me.btnCambiar.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        Me.btnCambiar.BackColor = System.Drawing.Color.FromArgb(0, 217, 163)
        Me.btnCambiar.ForeColor = System.Drawing.Color.FromArgb(13, 17, 23)
        Me.btnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambiar.FlatAppearance.BorderSize = 0
        Me.btnCambiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCambiar.Location = New System.Drawing.Point(40, 232)
        Me.btnCambiar.Name = "btnCambiar"
        Me.btnCambiar.Size = New System.Drawing.Size(350, 40)
        Me.btnCambiar.TabIndex = 2
        '
        ' FrmCambioClave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(13, 17, 23)
        Me.ClientSize = New System.Drawing.Size(440, 360)
        Me.Controls.Add(Me.pnlCuerpo)
        Me.Controls.Add(Me.pnlWarningBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCambioClave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de Contraseña"
        Me.pnlWarningBar.ResumeLayout(False)
        Me.pnlWarningBar.PerformLayout()
        Me.pnlCuerpo.ResumeLayout(False)
        Me.pnlCuerpo.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlWarningBar As System.Windows.Forms.Panel
    Friend WithEvents lblWarningIcon As System.Windows.Forms.Label
    Friend WithEvents lblWarningText As System.Windows.Forms.Label
    Friend WithEvents pnlCuerpo As System.Windows.Forms.Panel
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblNueva As System.Windows.Forms.Label
    Friend WithEvents txtNueva As System.Windows.Forms.TextBox
    Friend WithEvents lblRepetir As System.Windows.Forms.Label
    Friend WithEvents txtRepetir As System.Windows.Forms.TextBox
    Friend WithEvents btnCambiar As System.Windows.Forms.Button
End Class
