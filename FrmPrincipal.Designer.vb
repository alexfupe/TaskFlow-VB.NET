<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.pnlSidebarTop = New System.Windows.Forms.Panel()
        Me.lblSidebarLogo = New System.Windows.Forms.Label()
        Me.lblSidebarTitle = New System.Windows.Forms.Label()
        Me.lblNavLabel = New System.Windows.Forms.Label()
        Me.btnNavUsuarios = New System.Windows.Forms.Button()
        Me.btnNavHistorial = New System.Windows.Forms.Button()
        Me.pnlSidebarBottom = New System.Windows.Forms.Panel()
        Me.lblBienvenida = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.pnlTopbar = New System.Windows.Forms.Panel()
        Me.pnlTopbarAccentLine = New System.Windows.Forms.Panel()
        Me.lblTopbarTitle = New System.Windows.Forms.Label()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlSidebarTop.SuspendLayout()
        Me.pnlSidebarBottom.SuspendLayout()
        Me.pnlTopbar.SuspendLayout()
        Me.SuspendLayout()
        '
        ' pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(22, 27, 34)
        Me.pnlSidebar.Controls.Add(Me.pnlSidebarTop)
        Me.pnlSidebar.Controls.Add(Me.lblNavLabel)
        Me.pnlSidebar.Controls.Add(Me.btnNavUsuarios)
        Me.pnlSidebar.Controls.Add(Me.btnNavHistorial)
        Me.pnlSidebar.Controls.Add(Me.pnlSidebarBottom)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(220, 680)
        Me.pnlSidebar.TabIndex = 1
        '
        ' pnlSidebarTop
        '
        Me.pnlSidebarTop.BackColor = System.Drawing.Color.FromArgb(13, 17, 23)
        Me.pnlSidebarTop.Controls.Add(Me.lblSidebarLogo)
        Me.pnlSidebarTop.Controls.Add(Me.lblSidebarTitle)
        Me.pnlSidebarTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSidebarTop.Height = 64
        Me.pnlSidebarTop.Name = "pnlSidebarTop"
        '
        ' lblSidebarLogo
        '
        Me.lblSidebarLogo.Text = "◈"
        Me.lblSidebarLogo.Font = New System.Drawing.Font("Segoe UI", 18, System.Drawing.FontStyle.Bold)
        Me.lblSidebarLogo.ForeColor = System.Drawing.Color.FromArgb(0, 217, 163)
        Me.lblSidebarLogo.AutoSize = True
        Me.lblSidebarLogo.Location = New System.Drawing.Point(16, 14)
        Me.lblSidebarLogo.Name = "lblSidebarLogo"
        '
        ' lblSidebarTitle
        '
        Me.lblSidebarTitle.Text = "TaskFlow"
        Me.lblSidebarTitle.Font = New System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold)
        Me.lblSidebarTitle.ForeColor = System.Drawing.Color.FromArgb(201, 209, 217)
        Me.lblSidebarTitle.AutoSize = True
        Me.lblSidebarTitle.Location = New System.Drawing.Point(50, 20)
        Me.lblSidebarTitle.Name = "lblSidebarTitle"
        '
        ' lblNavLabel
        '
        Me.lblNavLabel.Text = "NAVEGACIÓN"
        Me.lblNavLabel.Font = New System.Drawing.Font("Segoe UI", 7, System.Drawing.FontStyle.Bold)
        Me.lblNavLabel.ForeColor = System.Drawing.Color.FromArgb(60, 70, 85)
        Me.lblNavLabel.AutoSize = True
        Me.lblNavLabel.Location = New System.Drawing.Point(16, 80)
        Me.lblNavLabel.Name = "lblNavLabel"
        '
        ' btnNavUsuarios
        '
        Me.btnNavUsuarios.Text = "  Gestión de Usuarios"
        Me.btnNavUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavUsuarios.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.btnNavUsuarios.ForeColor = System.Drawing.Color.FromArgb(139, 148, 158)
        Me.btnNavUsuarios.BackColor = System.Drawing.Color.Transparent
        Me.btnNavUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavUsuarios.FlatAppearance.BorderSize = 0
        Me.btnNavUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(33, 38, 45)
        Me.btnNavUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(0, 217, 163, 30)
        Me.btnNavUsuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavUsuarios.Location = New System.Drawing.Point(0, 102)
        Me.btnNavUsuarios.Size = New System.Drawing.Size(220, 42)
        Me.btnNavUsuarios.TabIndex = 0
        Me.btnNavUsuarios.Name = "btnNavUsuarios"
        Me.btnNavUsuarios.UseVisualStyleBackColor = False
        '
        ' btnNavHistorial
        '
        Me.btnNavHistorial.Text = "  Historial de Bajas"
        Me.btnNavHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavHistorial.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.btnNavHistorial.ForeColor = System.Drawing.Color.FromArgb(139, 148, 158)
        Me.btnNavHistorial.BackColor = System.Drawing.Color.Transparent
        Me.btnNavHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavHistorial.FlatAppearance.BorderSize = 0
        Me.btnNavHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(33, 38, 45)
        Me.btnNavHistorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(33, 38, 45)
        Me.btnNavHistorial.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavHistorial.Location = New System.Drawing.Point(0, 146)
        Me.btnNavHistorial.Size = New System.Drawing.Size(220, 42)
        Me.btnNavHistorial.TabIndex = 1
        Me.btnNavHistorial.Name = "btnNavHistorial"
        Me.btnNavHistorial.UseVisualStyleBackColor = False
        '
        ' pnlSidebarBottom
        '
        Me.pnlSidebarBottom.BackColor = System.Drawing.Color.FromArgb(13, 17, 23)
        Me.pnlSidebarBottom.Controls.Add(Me.lblBienvenida)
        Me.pnlSidebarBottom.Controls.Add(Me.btnSalir)
        Me.pnlSidebarBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlSidebarBottom.Location = New System.Drawing.Point(0, 574)
        Me.pnlSidebarBottom.Name = "pnlSidebarBottom"
        Me.pnlSidebarBottom.Size = New System.Drawing.Size(220, 106)
        Me.pnlSidebarBottom.TabIndex = 3
        '
        ' lblBienvenida
        '
        Me.lblBienvenida.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.lblBienvenida.ForeColor = System.Drawing.Color.FromArgb(0, 217, 163)
        Me.lblBienvenida.Location = New System.Drawing.Point(16, 14)
        Me.lblBienvenida.Name = "lblBienvenida"
        Me.lblBienvenida.Size = New System.Drawing.Size(188, 36)
        Me.lblBienvenida.TabIndex = 0
        Me.lblBienvenida.Text = "..."
        '
        ' btnSalir
        '
        Me.btnSalir.Text = "Cerrar sesión"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI", 10)
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(248, 81, 73)
        Me.btnSalir.BackColor = System.Drawing.Color.Transparent
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 20, 20)
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.Location = New System.Drawing.Point(0, 60)
        Me.btnSalir.Size = New System.Drawing.Size(220, 38)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        ' pnlTopbar
        '
        Me.pnlTopbar.BackColor = System.Drawing.Color.FromArgb(22, 27, 34)
        Me.pnlTopbar.Controls.Add(Me.pnlTopbarAccentLine)
        Me.pnlTopbar.Controls.Add(Me.lblTopbarTitle)
        Me.pnlTopbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTopbar.Location = New System.Drawing.Point(220, 0)
        Me.pnlTopbar.Name = "pnlTopbar"
        Me.pnlTopbar.Size = New System.Drawing.Size(880, 46)
        Me.pnlTopbar.TabIndex = 0
        '
        ' pnlTopbarAccentLine
        '
        Me.pnlTopbarAccentLine.BackColor = System.Drawing.Color.FromArgb(0, 217, 163)
        Me.pnlTopbarAccentLine.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlTopbarAccentLine.Height = 2
        Me.pnlTopbarAccentLine.Name = "pnlTopbarAccentLine"
        '
        ' lblTopbarTitle
        '
        Me.lblTopbarTitle.Text = "Panel Principal"
        Me.lblTopbarTitle.Font = New System.Drawing.Font("Segoe UI", 12, System.Drawing.FontStyle.Bold)
        Me.lblTopbarTitle.ForeColor = System.Drawing.Color.FromArgb(201, 209, 217)
        Me.lblTopbarTitle.AutoSize = True
        Me.lblTopbarTitle.Location = New System.Drawing.Point(16, 10)
        Me.lblTopbarTitle.Name = "lblTopbarTitle"
        Me.lblTopbarTitle.TabIndex = 0
        '
        ' FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(13, 17, 23)
        Me.ClientSize = New System.Drawing.Size(1100, 680)
        Me.Controls.Add(Me.pnlTopbar)
        Me.Controls.Add(Me.pnlSidebar)
        Me.IsMdiContainer = True
        Me.MinimumSize = New System.Drawing.Size(900, 550)
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TaskFlow"
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlSidebar.PerformLayout()
        Me.pnlSidebarTop.ResumeLayout(False)
        Me.pnlSidebarTop.PerformLayout()
        Me.pnlSidebarBottom.ResumeLayout(False)
        Me.pnlTopbar.ResumeLayout(False)
        Me.pnlTopbar.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents pnlSidebarTop As System.Windows.Forms.Panel
    Friend WithEvents lblSidebarLogo As System.Windows.Forms.Label
    Friend WithEvents lblSidebarTitle As System.Windows.Forms.Label
    Friend WithEvents lblNavLabel As System.Windows.Forms.Label
    Friend WithEvents btnNavUsuarios As System.Windows.Forms.Button
    Friend WithEvents btnNavHistorial As System.Windows.Forms.Button
    Friend WithEvents pnlSidebarBottom As System.Windows.Forms.Panel
    Friend WithEvents lblBienvenida As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents pnlTopbar As System.Windows.Forms.Panel
    Friend WithEvents pnlTopbarAccentLine As System.Windows.Forms.Panel
    Friend WithEvents lblTopbarTitle As System.Windows.Forms.Label
End Class
