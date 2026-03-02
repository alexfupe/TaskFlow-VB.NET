<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGestionUsuarios
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
        Me.lblSubtituloGrid = New System.Windows.Forms.Label()
        Me.pnlFiltros = New System.Windows.Forms.Panel()
        Me.lblFiltroLabel = New System.Windows.Forms.Label()
        Me.cbxFiltro = New System.Windows.Forms.ComboBox()
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        Me.btnRefrescarFiltro = New System.Windows.Forms.Button()
        Me.btnPurgar = New System.Windows.Forms.Button()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.pnlAcciones = New System.Windows.Forms.Panel()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.lblInfoAcciones = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.pnlFiltros.SuspendLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAcciones.SuspendLayout()
        Me.SuspendLayout()
        '
        ' pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(13, 17, 23)
        Me.pnlHeader.Controls.Add(Me.lblTitulo)
        Me.pnlHeader.Controls.Add(Me.lblSubtituloGrid)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 66
        Me.pnlHeader.Name = "pnlHeader"
        '
        ' lblTitulo
        '
        Me.lblTitulo.Text = "Gestión de Usuarios"
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 15, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(201, 209, 217)
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(20, 10)
        Me.lblTitulo.Name = "lblTitulo"
        '
        ' lblSubtituloGrid
        '
        Me.lblSubtituloGrid.Text = "Administra altas, bajas y permisos"
        Me.lblSubtituloGrid.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblSubtituloGrid.ForeColor = System.Drawing.Color.FromArgb(125, 133, 144)
        Me.lblSubtituloGrid.AutoSize = True
        Me.lblSubtituloGrid.Location = New System.Drawing.Point(22, 42)
        Me.lblSubtituloGrid.Name = "lblSubtituloGrid"
        '
        ' pnlFiltros
        '
        Me.pnlFiltros.BackColor = System.Drawing.Color.FromArgb(22, 27, 34)
        Me.pnlFiltros.Controls.Add(Me.lblFiltroLabel)
        Me.pnlFiltros.Controls.Add(Me.cbxFiltro)
        Me.pnlFiltros.Controls.Add(Me.lblDesde)
        Me.pnlFiltros.Controls.Add(Me.dtpInicio)
        Me.pnlFiltros.Controls.Add(Me.lblHasta)
        Me.pnlFiltros.Controls.Add(Me.dtpFin)
        Me.pnlFiltros.Controls.Add(Me.btnFiltrar)
        Me.pnlFiltros.Controls.Add(Me.btnRefrescarFiltro)
        Me.pnlFiltros.Controls.Add(Me.btnPurgar)
        Me.pnlFiltros.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlFiltros.Height = 56
        Me.pnlFiltros.Name = "pnlFiltros"
        '
        ' lblFiltroLabel
        '
        Me.lblFiltroLabel.Text = "Filtrar:"
        Me.lblFiltroLabel.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblFiltroLabel.ForeColor = System.Drawing.Color.FromArgb(125, 133, 144)
        Me.lblFiltroLabel.AutoSize = True
        Me.lblFiltroLabel.Location = New System.Drawing.Point(16, 18)
        Me.lblFiltroLabel.Name = "lblFiltroLabel"
        '
        ' cbxFiltro
        '
        Me.cbxFiltro.BackColor = System.Drawing.Color.FromArgb(33, 38, 45)
        Me.cbxFiltro.ForeColor = System.Drawing.Color.FromArgb(201, 209, 217)
        Me.cbxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFiltro.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.cbxFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxFiltro.Location = New System.Drawing.Point(62, 14)
        Me.cbxFiltro.Name = "cbxFiltro"
        Me.cbxFiltro.Size = New System.Drawing.Size(180, 23)
        Me.cbxFiltro.TabIndex = 0
        '
        ' lblDesde
        '
        Me.lblDesde.Text = "Desde:"
        Me.lblDesde.Font = New System.Drawing.Font("Segoe UI", 8)
        Me.lblDesde.ForeColor = System.Drawing.Color.FromArgb(125, 133, 144)
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Location = New System.Drawing.Point(256, 18)
        Me.lblDesde.Visible = False
        Me.lblDesde.Name = "lblDesde"
        '
        ' dtpInicio
        '
        Me.dtpInicio.BackColor = System.Drawing.Color.FromArgb(33, 38, 45)
        Me.dtpInicio.ForeColor = System.Drawing.Color.FromArgb(201, 209, 217)
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpInicio.Location = New System.Drawing.Point(305, 14)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(108, 23)
        Me.dtpInicio.Visible = False
        Me.dtpInicio.TabIndex = 1
        '
        ' lblHasta
        '
        Me.lblHasta.Text = "Hasta:"
        Me.lblHasta.Font = New System.Drawing.Font("Segoe UI", 8)
        Me.lblHasta.ForeColor = System.Drawing.Color.FromArgb(125, 133, 144)
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(424, 18)
        Me.lblHasta.Visible = False
        Me.lblHasta.Name = "lblHasta"
        '
        ' dtpFin
        '
        Me.dtpFin.BackColor = System.Drawing.Color.FromArgb(33, 38, 45)
        Me.dtpFin.ForeColor = System.Drawing.Color.FromArgb(201, 209, 217)
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFin.Location = New System.Drawing.Point(470, 14)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(108, 23)
        Me.dtpFin.Visible = False
        Me.dtpFin.TabIndex = 2
        '
        ' btnFiltrar
        '
        Me.btnFiltrar.Text = "Aplicar filtro"
        Me.btnFiltrar.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(33, 38, 45)
        Me.btnFiltrar.ForeColor = System.Drawing.Color.FromArgb(0, 217, 163)
        Me.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 217, 163)
        Me.btnFiltrar.FlatAppearance.BorderSize = 1
        Me.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiltrar.Location = New System.Drawing.Point(590, 12)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(110, 28)
        Me.btnFiltrar.TabIndex = 3
        '
        ' btnRefrescarFiltro
        '
        Me.btnRefrescarFiltro.Text = "↺ Refrescar"
        Me.btnRefrescarFiltro.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.btnRefrescarFiltro.BackColor = System.Drawing.Color.FromArgb(33, 38, 45)
        Me.btnRefrescarFiltro.ForeColor = System.Drawing.Color.FromArgb(139, 148, 158)
        Me.btnRefrescarFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefrescarFiltro.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(48, 54, 61)
        Me.btnRefrescarFiltro.FlatAppearance.BorderSize = 1
        Me.btnRefrescarFiltro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefrescarFiltro.Location = New System.Drawing.Point(710, 12)
        Me.btnRefrescarFiltro.Name = "btnRefrescarFiltro"
        Me.btnRefrescarFiltro.Size = New System.Drawing.Size(110, 28)
        Me.btnRefrescarFiltro.TabIndex = 4
        '
        ' btnPurgar
        '
        Me.btnPurgar.Text = "Purgar morosos"
        Me.btnPurgar.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.btnPurgar.BackColor = System.Drawing.Color.FromArgb(33, 18, 18)
        Me.btnPurgar.ForeColor = System.Drawing.Color.FromArgb(248, 81, 73)
        Me.btnPurgar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPurgar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(248, 81, 73)
        Me.btnPurgar.FlatAppearance.BorderSize = 1
        Me.btnPurgar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPurgar.Location = New System.Drawing.Point(830, 12)
        Me.btnPurgar.Name = "btnPurgar"
        Me.btnPurgar.Size = New System.Drawing.Size(140, 28)
        Me.btnPurgar.TabIndex = 5
        '
        ' dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(13, 17, 23)
        Me.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 27, 34)
        Me.dgvUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(125, 133, 144)
        Me.dgvUsuarios.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold)
        Me.dgvUsuarios.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(22, 27, 34)
        Me.dgvUsuarios.ColumnHeadersHeight = 36
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvUsuarios.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(13, 17, 23)
        Me.dgvUsuarios.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(201, 209, 217)
        Me.dgvUsuarios.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.dgvUsuarios.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(22, 27, 34)
        Me.dgvUsuarios.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(0, 217, 163)
        Me.dgvUsuarios.EnableHeadersVisualStyles = False
        Me.dgvUsuarios.GridColor = System.Drawing.Color.FromArgb(33, 38, 45)
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.RowHeadersVisible = False
        Me.dgvUsuarios.RowTemplate.Height = 30
        Me.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.TabIndex = 0
        '
        ' pnlAcciones
        '
        Me.pnlAcciones.BackColor = System.Drawing.Color.FromArgb(22, 27, 34)
        Me.pnlAcciones.Controls.Add(Me.btnNuevo)
        Me.pnlAcciones.Controls.Add(Me.btnEditar)
        Me.pnlAcciones.Controls.Add(Me.btnBorrar)
        Me.pnlAcciones.Controls.Add(Me.lblInfoAcciones)
        Me.pnlAcciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlAcciones.Height = 58
        Me.pnlAcciones.Name = "pnlAcciones"
        '
        ' btnNuevo
        '
        Me.btnNuevo.Text = "+ Nuevo usuario"
        Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.BackColor = System.Drawing.Color.FromArgb(0, 217, 163)
        Me.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(13, 17, 23)
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNuevo.Location = New System.Drawing.Point(16, 13)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(140, 32)
        Me.btnNuevo.TabIndex = 0
        '
        ' btnEditar
        '
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.btnEditar.BackColor = System.Drawing.Color.FromArgb(33, 38, 45)
        Me.btnEditar.ForeColor = System.Drawing.Color.FromArgb(201, 209, 217)
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(48, 54, 61)
        Me.btnEditar.FlatAppearance.BorderSize = 1
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.Location = New System.Drawing.Point(168, 13)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(100, 32)
        Me.btnEditar.TabIndex = 1
        '
        ' btnBorrar
        '
        Me.btnBorrar.Text = "Eliminar"
        Me.btnBorrar.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.btnBorrar.BackColor = System.Drawing.Color.FromArgb(33, 18, 18)
        Me.btnBorrar.ForeColor = System.Drawing.Color.FromArgb(248, 81, 73)
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 50, 50)
        Me.btnBorrar.FlatAppearance.BorderSize = 1
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.Location = New System.Drawing.Point(280, 13)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(100, 32)
        Me.btnBorrar.TabIndex = 2
        '
        ' lblInfoAcciones
        '
        Me.lblInfoAcciones.Text = "Doble clic en una fila para editar"
        Me.lblInfoAcciones.Font = New System.Drawing.Font("Segoe UI", 8)
        Me.lblInfoAcciones.ForeColor = System.Drawing.Color.FromArgb(60, 70, 85)
        Me.lblInfoAcciones.AutoSize = True
        Me.lblInfoAcciones.Location = New System.Drawing.Point(396, 22)
        Me.lblInfoAcciones.Name = "lblInfoAcciones"
        '
        ' FrmGestionUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(13, 17, 23)
        Me.ClientSize = New System.Drawing.Size(1100, 680)
        Me.Controls.Add(Me.dgvUsuarios)
        Me.Controls.Add(Me.pnlAcciones)
        Me.Controls.Add(Me.pnlFiltros)
        Me.Controls.Add(Me.pnlHeader)
        Me.MinimumSize = New System.Drawing.Size(900, 500)
        Me.Name = "FrmGestionUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Gestión de Usuarios"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.pnlFiltros.ResumeLayout(False)
        Me.pnlFiltros.PerformLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAcciones.ResumeLayout(False)
        Me.pnlAcciones.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblSubtituloGrid As System.Windows.Forms.Label
    Friend WithEvents pnlFiltros As System.Windows.Forms.Panel
    Friend WithEvents lblFiltroLabel As System.Windows.Forms.Label
    Friend WithEvents cbxFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents lblDesde As System.Windows.Forms.Label
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents btnRefrescarFiltro As System.Windows.Forms.Button
    Friend WithEvents btnPurgar As System.Windows.Forms.Button
    Friend WithEvents dgvUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents pnlAcciones As System.Windows.Forms.Panel
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents lblInfoAcciones As System.Windows.Forms.Label
End Class
