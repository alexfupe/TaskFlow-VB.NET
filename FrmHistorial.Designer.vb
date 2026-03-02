<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHistorial
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
        Me.dgvHistorial = New System.Windows.Forms.DataGridView()
        Me.pnlFooter = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.lblInfoRestaurar = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        ' pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(13, 17, 23)
        Me.pnlHeader.Controls.Add(Me.lblTitulo)
        Me.pnlHeader.Controls.Add(Me.lblSubtitulo)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Height = 66
        Me.pnlHeader.Name = "pnlHeader"
        '
        ' lblTitulo
        '
        Me.lblTitulo.Text = "Historial de Bajas"
        Me.lblTitulo.Font = New System.Drawing.Font("Segoe UI", 15, System.Drawing.FontStyle.Bold)
        Me.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(201, 209, 217)
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(20, 10)
        Me.lblTitulo.Name = "lblTitulo"
        '
        ' lblSubtitulo
        '
        Me.lblSubtitulo.Text = "Usuarios eliminados · puedes restaurarlos"
        Me.lblSubtitulo.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(125, 133, 144)
        Me.lblSubtitulo.AutoSize = True
        Me.lblSubtitulo.Location = New System.Drawing.Point(22, 42)
        Me.lblSubtitulo.Name = "lblSubtitulo"
        '
        ' dgvHistorial
        '
        Me.dgvHistorial.AllowUserToAddRows = False
        Me.dgvHistorial.AllowUserToDeleteRows = False
        Me.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHistorial.BackgroundColor = System.Drawing.Color.FromArgb(13, 17, 23)
        Me.dgvHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvHistorial.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvHistorial.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 27, 34)
        Me.dgvHistorial.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(125, 133, 144)
        Me.dgvHistorial.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Bold)
        Me.dgvHistorial.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(22, 27, 34)
        Me.dgvHistorial.ColumnHeadersHeight = 36
        Me.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvHistorial.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(13, 17, 23)
        Me.dgvHistorial.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(180, 155, 155)
        Me.dgvHistorial.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.dgvHistorial.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(22, 27, 34)
        Me.dgvHistorial.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(248, 81, 73)
        Me.dgvHistorial.EnableHeadersVisualStyles = False
        Me.dgvHistorial.GridColor = System.Drawing.Color.FromArgb(33, 38, 45)
        Me.dgvHistorial.ReadOnly = True
        Me.dgvHistorial.RowHeadersVisible = False
        Me.dgvHistorial.RowTemplate.Height = 30
        Me.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHistorial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHistorial.Name = "dgvHistorial"
        Me.dgvHistorial.TabIndex = 0
        '
        ' pnlFooter
        '
        Me.pnlFooter.BackColor = System.Drawing.Color.FromArgb(22, 27, 34)
        Me.pnlFooter.Controls.Add(Me.btnRestaurar)
        Me.pnlFooter.Controls.Add(Me.lblInfoRestaurar)
        Me.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlFooter.Height = 58
        Me.pnlFooter.Name = "pnlFooter"
        '
        ' btnRestaurar
        '
        Me.btnRestaurar.Text = "Restaurar usuario"
        Me.btnRestaurar.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.btnRestaurar.BackColor = System.Drawing.Color.FromArgb(33, 38, 45)
        Me.btnRestaurar.ForeColor = System.Drawing.Color.FromArgb(0, 217, 163)
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 217, 163)
        Me.btnRestaurar.FlatAppearance.BorderSize = 1
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.Location = New System.Drawing.Point(16, 14)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(160, 30)
        Me.btnRestaurar.TabIndex = 0
        '
        ' lblInfoRestaurar
        '
        Me.lblInfoRestaurar.Text = "Selecciona una fila y pulsa Restaurar"
        Me.lblInfoRestaurar.Font = New System.Drawing.Font("Segoe UI", 8)
        Me.lblInfoRestaurar.ForeColor = System.Drawing.Color.FromArgb(60, 70, 85)
        Me.lblInfoRestaurar.AutoSize = True
        Me.lblInfoRestaurar.Location = New System.Drawing.Point(190, 22)
        Me.lblInfoRestaurar.Name = "lblInfoRestaurar"
        '
        ' FrmHistorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(13, 17, 23)
        Me.ClientSize = New System.Drawing.Size(1100, 680)
        Me.Controls.Add(Me.dgvHistorial)
        Me.Controls.Add(Me.pnlFooter)
        Me.Controls.Add(Me.pnlHeader)
        Me.MinimumSize = New System.Drawing.Size(900, 500)
        Me.Name = "FrmHistorial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Historial de Bajas"
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.dgvHistorial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFooter.ResumeLayout(False)
        Me.pnlFooter.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents lblSubtitulo As System.Windows.Forms.Label
    Friend WithEvents dgvHistorial As System.Windows.Forms.DataGridView
    Friend WithEvents pnlFooter As System.Windows.Forms.Panel
    Friend WithEvents btnRestaurar As System.Windows.Forms.Button
    Friend WithEvents lblInfoRestaurar As System.Windows.Forms.Label
End Class
