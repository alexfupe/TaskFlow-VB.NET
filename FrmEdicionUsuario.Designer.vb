<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEdicionUsuario
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblSubtitulo = New System.Windows.Forms.Label()
        Me.pnlCuerpo = New System.Windows.Forms.Panel()
        Me.pnlColumnaIzq = New System.Windows.Forms.Panel()
        Me.lblNombreTag = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblEmailTag = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblPasswordTag = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblRolTag = New System.Windows.Forms.Label()
        Me.cmbRol = New System.Windows.Forms.ComboBox()
        Me.lblPagoTag = New System.Windows.Forms.Label()
        Me.dtpUltimoPago = New System.Windows.Forms.DateTimePicker()
        Me.pnlColumnaDer = New System.Windows.Forms.Panel()
        Me.grpEstado = New System.Windows.Forms.GroupBox()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.chkRecuperacion = New System.Windows.Forms.CheckBox()
        Me.grpPermisos = New System.Windows.Forms.GroupBox()
        Me.chkPermisoLectura = New System.Windows.Forms.CheckBox()
        Me.chkPermisoEscritura = New System.Windows.Forms.CheckBox()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.pnlHeader.SuspendLayout()
        Me.pnlCuerpo.SuspendLayout()
        Me.pnlColumnaIzq.SuspendLayout()
        Me.pnlColumnaDer.SuspendLayout()
        Me.grpEstado.SuspendLayout()
        Me.grpPermisos.SuspendLayout()
        Me.pnlFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        ' pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(13, 17, 23)
        Me.pnlHeader.Controls.Add(Me.lblTitulo)
        Me.pnlHeader.Controls.Add(Me.lblSubtitulo)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 64
        Me.pnlHeader.Name = "pnlHeader"
        '
        ' lblTitulo
        '
        Me.lblTitulo.Text = "Nuevo Usuario"
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(201, 209, 217)
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(20, 10)
        Me.lblTitulo.Name = "lblTitulo"
        '
        ' lblSubtitulo
        '
        Me.lblSubtitulo.Text = "Completa los datos del usuario"
        Me.lblSubtitulo.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(125, 133, 144)
        Me.lblSubtitulo.AutoSize = True
        Me.lblSubtitulo.Location = New System.Drawing.Point(22, 40)
        Me.lblSubtitulo.Name = "lblSubtitulo"
        '
        ' pnlCuerpo
        '
        Me.pnlCuerpo.BackColor = System.Drawing.Color.FromArgb(13, 17, 23)
        Me.pnlCuerpo.Controls.Add(Me.pnlColumnaIzq)
        Me.pnlCuerpo.Controls.Add(Me.pnlColumnaDer)
        Me.pnlCuerpo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCuerpo.Name = "pnlCuerpo"
        '
        ' pnlColumnaIzq
        '
        Me.pnlColumnaIzq.BackColor = System.Drawing.Color.FromArgb(13, 17, 23)
        Me.pnlColumnaIzq.Controls.Add(Me.lblNombreTag)
        Me.pnlColumnaIzq.Controls.Add(Me.txtNombre)
        Me.pnlColumnaIzq.Controls.Add(Me.lblEmailTag)
        Me.pnlColumnaIzq.Controls.Add(Me.txtEmail)
        Me.pnlColumnaIzq.Controls.Add(Me.lblPasswordTag)
        Me.pnlColumnaIzq.Controls.Add(Me.txtPassword)
        Me.pnlColumnaIzq.Controls.Add(Me.lblRolTag)
        Me.pnlColumnaIzq.Controls.Add(Me.cmbRol)
        Me.pnlColumnaIzq.Controls.Add(Me.lblPagoTag)
        Me.pnlColumnaIzq.Controls.Add(Me.dtpUltimoPago)
        Me.pnlColumnaIzq.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlColumnaIzq.Width = 310
        Me.pnlColumnaIzq.Name = "pnlColumnaIzq"
        '
        ' lblNombreTag
        '
        Me.lblNombreTag.Text = "Nombre de usuario"
        Me.lblNombreTag.Font = New System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold)
        Me.lblNombreTag.ForeColor = System.Drawing.Color.FromArgb(125, 133, 144)
        Me.lblNombreTag.AutoSize = True
        Me.lblNombreTag.Location = New System.Drawing.Point(24, 20)
        Me.lblNombreTag.Name = "lblNombreTag"
        '
        ' txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(22, 27, 34)
        Me.txtNombre.ForeColor = System.Drawing.Color.FromArgb(201, 209, 217)
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.txtNombre.Location = New System.Drawing.Point(24, 40)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(264, 28)
        Me.txtNombre.TabIndex = 0
        '
        ' lblEmailTag
        '
        Me.lblEmailTag.Text = "Correo electrónico"
        Me.lblEmailTag.Font = New System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold)
        Me.lblEmailTag.ForeColor = System.Drawing.Color.FromArgb(125, 133, 144)
        Me.lblEmailTag.AutoSize = True
        Me.lblEmailTag.Location = New System.Drawing.Point(24, 86)
        Me.lblEmailTag.Name = "lblEmailTag"
        '
        ' txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(22, 27, 34)
        Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(201, 209, 217)
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.txtEmail.Location = New System.Drawing.Point(24, 106)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(264, 28)
        Me.txtEmail.TabIndex = 1
        '
        ' lblPasswordTag
        '
        Me.lblPasswordTag.Text = "Contraseña"
        Me.lblPasswordTag.Font = New System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold)
        Me.lblPasswordTag.ForeColor = System.Drawing.Color.FromArgb(125, 133, 144)
        Me.lblPasswordTag.AutoSize = True
        Me.lblPasswordTag.Location = New System.Drawing.Point(24, 152)
        Me.lblPasswordTag.Name = "lblPasswordTag"
        '
        ' txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(22, 27, 34)
        Me.txtPassword.ForeColor = System.Drawing.Color.FromArgb(201, 209, 217)
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.txtPassword.UseSystemPasswordChar = True
        Me.txtPassword.Location = New System.Drawing.Point(24, 172)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(264, 28)
        Me.txtPassword.TabIndex = 2
        '
        ' lblRolTag
        '
        Me.lblRolTag.Text = "Rol"
        Me.lblRolTag.Font = New System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold)
        Me.lblRolTag.ForeColor = System.Drawing.Color.FromArgb(125, 133, 144)
        Me.lblRolTag.AutoSize = True
        Me.lblRolTag.Location = New System.Drawing.Point(24, 218)
        Me.lblRolTag.Name = "lblRolTag"
        '
        ' cmbRol
        '
        Me.cmbRol.BackColor = System.Drawing.Color.FromArgb(33, 38, 45)
        Me.cmbRol.ForeColor = System.Drawing.Color.FromArgb(201, 209, 217)
        Me.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbRol.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.cmbRol.Location = New System.Drawing.Point(24, 238)
        Me.cmbRol.Name = "cmbRol"
        Me.cmbRol.Size = New System.Drawing.Size(264, 27)
        Me.cmbRol.TabIndex = 3
        '
        ' lblPagoTag
        '
        Me.lblPagoTag.Text = "Último pago"
        Me.lblPagoTag.Font = New System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold)
        Me.lblPagoTag.ForeColor = System.Drawing.Color.FromArgb(125, 133, 144)
        Me.lblPagoTag.AutoSize = True
        Me.lblPagoTag.Location = New System.Drawing.Point(24, 284)
        Me.lblPagoTag.Name = "lblPagoTag"
        '
        ' dtpUltimoPago
        '
        Me.dtpUltimoPago.BackColor = System.Drawing.Color.FromArgb(33, 38, 45)
        Me.dtpUltimoPago.ForeColor = System.Drawing.Color.FromArgb(201, 209, 217)
        Me.dtpUltimoPago.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.dtpUltimoPago.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpUltimoPago.Location = New System.Drawing.Point(24, 304)
        Me.dtpUltimoPago.Name = "dtpUltimoPago"
        Me.dtpUltimoPago.Size = New System.Drawing.Size(264, 27)
        Me.dtpUltimoPago.TabIndex = 4
        '
        ' pnlColumnaDer
        '
        Me.pnlColumnaDer.BackColor = System.Drawing.Color.FromArgb(13, 17, 23)
        Me.pnlColumnaDer.Controls.Add(Me.grpEstado)
        Me.pnlColumnaDer.Controls.Add(Me.grpPermisos)
        Me.pnlColumnaDer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlColumnaDer.Padding = New System.Windows.Forms.Padding(16, 16, 24, 0)
        Me.pnlColumnaDer.Name = "pnlColumnaDer"
        '
        ' grpEstado
        '
        Me.grpEstado.Text = "Estado"
        Me.grpEstado.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.grpEstado.ForeColor = System.Drawing.Color.FromArgb(125, 133, 144)
        Me.grpEstado.BackColor = System.Drawing.Color.FromArgb(22, 27, 34)
        Me.grpEstado.Controls.Add(Me.chkActivo)
        Me.grpEstado.Controls.Add(Me.chkRecuperacion)
        Me.grpEstado.Location = New System.Drawing.Point(16, 16)
        Me.grpEstado.Size = New System.Drawing.Size(220, 116)
        Me.grpEstado.Name = "grpEstado"
        '
        ' chkActivo
        '
        Me.chkActivo.Text = "Cuenta activa"
        Me.chkActivo.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.chkActivo.ForeColor = System.Drawing.Color.FromArgb(201, 209, 217)
        Me.chkActivo.BackColor = System.Drawing.Color.Transparent
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(14, 32)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.TabIndex = 5
        '
        ' chkRecuperacion
        '
        Me.chkRecuperacion.Text = "Forzar cambio de clave"
        Me.chkRecuperacion.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.chkRecuperacion.ForeColor = System.Drawing.Color.FromArgb(139, 148, 158)
        Me.chkRecuperacion.BackColor = System.Drawing.Color.Transparent
        Me.chkRecuperacion.AutoSize = True
        Me.chkRecuperacion.Location = New System.Drawing.Point(14, 62)
        Me.chkRecuperacion.Name = "chkRecuperacion"
        Me.chkRecuperacion.TabIndex = 6
        '
        ' grpPermisos
        '
        Me.grpPermisos.Text = "Permisos"
        Me.grpPermisos.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.grpPermisos.ForeColor = System.Drawing.Color.FromArgb(125, 133, 144)
        Me.grpPermisos.BackColor = System.Drawing.Color.FromArgb(22, 27, 34)
        Me.grpPermisos.Controls.Add(Me.chkPermisoLectura)
        Me.grpPermisos.Controls.Add(Me.chkPermisoEscritura)
        Me.grpPermisos.Location = New System.Drawing.Point(16, 148)
        Me.grpPermisos.Size = New System.Drawing.Size(220, 110)
        Me.grpPermisos.Name = "grpPermisos"
        '
        ' chkPermisoLectura
        '
        Me.chkPermisoLectura.Text = "Lectura (LEER)"
        Me.chkPermisoLectura.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.chkPermisoLectura.ForeColor = System.Drawing.Color.FromArgb(201, 209, 217)
        Me.chkPermisoLectura.BackColor = System.Drawing.Color.Transparent
        Me.chkPermisoLectura.AutoSize = True
        Me.chkPermisoLectura.Location = New System.Drawing.Point(14, 30)
        Me.chkPermisoLectura.Name = "chkPermisoLectura"
        Me.chkPermisoLectura.TabIndex = 7
        '
        ' chkPermisoEscritura
        '
        Me.chkPermisoEscritura.Text = "Escritura (ESCRIBIR)"
        Me.chkPermisoEscritura.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.chkPermisoEscritura.ForeColor = System.Drawing.Color.FromArgb(201, 209, 217)
        Me.chkPermisoEscritura.BackColor = System.Drawing.Color.Transparent
        Me.chkPermisoEscritura.AutoSize = True
        Me.chkPermisoEscritura.Location = New System.Drawing.Point(14, 62)
        Me.chkPermisoEscritura.Name = "chkPermisoEscritura"
        Me.chkPermisoEscritura.TabIndex = 8
        '
        ' pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(22, 27, 34)
        Me.pnlFooter.Controls.Add(Me.btnGuardar)
        Me.pnlFooter.Controls.Add(Me.btnCancelar)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Height = 58
        Me.pnlFooter.Name = "pnlFooter"
        '
        ' btnGuardar
        '
        Me.btnGuardar.Text = "Guardar cambios"
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(0, 217, 163)
        Me.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(13, 17, 23)
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Location = New System.Drawing.Point(16, 14)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(150, 32)
        Me.btnGuardar.TabIndex = 9
        '
        ' btnCancelar
        '
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.btnCancelar.BackColor = System.Drawing.Color.FromArgb(33, 38, 45)
        Me.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(139, 148, 158)
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(48, 54, 61)
        Me.btnCancelar.FlatAppearance.BorderSize = 1
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.Location = New System.Drawing.Point(178, 14)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(110, 32)
        Me.btnCancelar.TabIndex = 10
        '
        ' FrmEdicionUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(13, 17, 23)
        Me.ClientSize = New System.Drawing.Size(580, 490)
        Me.Controls.Add(Me.pnlCuerpo)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEdicionUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Usuario"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlCuerpo.ResumeLayout(False)
        Me.pnlColumnaIzq.ResumeLayout(False)
        Me.pnlColumnaIzq.PerformLayout()
        Me.pnlColumnaDer.ResumeLayout(False)
        Me.grpEstado.ResumeLayout(False)
        Me.grpEstado.PerformLayout()
        Me.grpPermisos.ResumeLayout(False)
        Me.grpPermisos.PerformLayout()
        Me.pnlFooter.ResumeLayout(False)
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblSubtitulo As System.Windows.Forms.Label
    Friend WithEvents pnlCuerpo As System.Windows.Forms.Panel
    Friend WithEvents pnlColumnaIzq As System.Windows.Forms.Panel
    Friend WithEvents lblNombreTag As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblEmailTag As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblPasswordTag As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblRolTag As System.Windows.Forms.Label
    Friend WithEvents cmbRol As System.Windows.Forms.ComboBox
    Friend WithEvents lblPagoTag As System.Windows.Forms.Label
    Friend WithEvents dtpUltimoPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents pnlColumnaDer As System.Windows.Forms.Panel
    Friend WithEvents grpEstado As System.Windows.Forms.GroupBox
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents chkRecuperacion As System.Windows.Forms.CheckBox
    Friend WithEvents grpPermisos As System.Windows.Forms.GroupBox
    Friend WithEvents chkPermisoLectura As System.Windows.Forms.CheckBox
    Friend WithEvents chkPermisoEscritura As System.Windows.Forms.CheckBox
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
