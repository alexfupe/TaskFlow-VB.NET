<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.pnlBg = New System.Windows.Forms.Panel()
        Me.pnlCard = New System.Windows.Forms.Panel()
        Me.lblDot1 = New System.Windows.Forms.Label()
        Me.lblDot2 = New System.Windows.Forms.Label()
        Me.lblDot3 = New System.Windows.Forms.Label()
        Me.lblAppName = New System.Windows.Forms.Label()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.pnlBg.SuspendLayout()
        Me.pnlCard.SuspendLayout()
        Me.SuspendLayout()
        '
        ' pnlBg
        '
        Me.pnlBg.BackColor = System.Drawing.Color.FromArgb(13, 17, 23)
        Me.pnlBg.Controls.Add(Me.pnlCard)
        Me.pnlBg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBg.Name = "pnlBg"
        '
        ' pnlCard — tarjeta central elevada
        '
        Me.pnlCard.BackColor = System.Drawing.Color.FromArgb(22, 27, 34)
        Me.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCard.Controls.Add(Me.lblDot1)
        Me.pnlCard.Controls.Add(Me.lblDot2)
        Me.pnlCard.Controls.Add(Me.lblDot3)
        Me.pnlCard.Controls.Add(Me.lblAppName)
        Me.pnlCard.Controls.Add(Me.lblWelcome)
        Me.pnlCard.Controls.Add(Me.lblUser)
        Me.pnlCard.Controls.Add(Me.txtUser)
        Me.pnlCard.Controls.Add(Me.lblPass)
        Me.pnlCard.Controls.Add(Me.txtPass)
        Me.pnlCard.Controls.Add(Me.btnLogin)
        Me.pnlCard.Location = New System.Drawing.Point(70, 60)
        Me.pnlCard.Size = New System.Drawing.Size(360, 400)
        Me.pnlCard.Name = "pnlCard"
        '
        ' Decoración tipo "semáforo" OS (puntos de color en esquina)
        '
        Me.lblDot1.Text = "●"
        Me.lblDot1.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblDot1.ForeColor = System.Drawing.Color.FromArgb(248, 81, 73)
        Me.lblDot1.AutoSize = True
        Me.lblDot1.Location = New System.Drawing.Point(14, 10)
        Me.lblDot1.Name = "lblDot1"
        '
        Me.lblDot2.Text = "●"
        Me.lblDot2.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblDot2.ForeColor = System.Drawing.Color.FromArgb(255, 189, 46)
        Me.lblDot2.AutoSize = True
        Me.lblDot2.Location = New System.Drawing.Point(34, 10)
        Me.lblDot2.Name = "lblDot2"
        '
        Me.lblDot3.Text = "●"
        Me.lblDot3.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblDot3.ForeColor = System.Drawing.Color.FromArgb(0, 217, 163)
        Me.lblDot3.AutoSize = True
        Me.lblDot3.Location = New System.Drawing.Point(54, 10)
        Me.lblDot3.Name = "lblDot3"
        '
        ' lblAppName
        '
        Me.lblAppName.Text = "TaskFlow"
        Me.lblAppName.Font = New System.Drawing.Font("Segoe UI", 20, System.Drawing.FontStyle.Bold)
        Me.lblAppName.ForeColor = System.Drawing.Color.FromArgb(0, 217, 163)
        Me.lblAppName.AutoSize = True
        Me.lblAppName.Location = New System.Drawing.Point(26, 42)
        Me.lblAppName.Name = "lblAppName"
        '
        ' lblWelcome
        '
        Me.lblWelcome.Text = "Accede a tu cuenta"
        Me.lblWelcome.Font = New System.Drawing.Font("Segoe UI", 9)
        Me.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(125, 133, 144)
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Location = New System.Drawing.Point(28, 88)
        Me.lblWelcome.Name = "lblWelcome"
        '
        ' lblUser
        '
        Me.lblUser.Text = "Usuario"
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.lblUser.ForeColor = System.Drawing.Color.FromArgb(201, 209, 217)
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(26, 126)
        Me.lblUser.Name = "lblUser"
        '
        ' txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.FromArgb(13, 17, 23)
        Me.txtUser.ForeColor = System.Drawing.Color.FromArgb(201, 209, 217)
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUser.Font = New System.Drawing.Font("Segoe UI", 11)
        Me.txtUser.Location = New System.Drawing.Point(26, 148)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(308, 32)
        Me.txtUser.TabIndex = 0
        '
        ' lblPass
        '
        Me.lblPass.Text = "Contraseña"
        Me.lblPass.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
        Me.lblPass.ForeColor = System.Drawing.Color.FromArgb(201, 209, 217)
        Me.lblPass.AutoSize = True
        Me.lblPass.Location = New System.Drawing.Point(26, 200)
        Me.lblPass.Name = "lblPass"
        '
        ' txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.FromArgb(13, 17, 23)
        Me.txtPass.ForeColor = System.Drawing.Color.FromArgb(201, 209, 217)
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPass.Font = New System.Drawing.Font("Segoe UI", 11)
        Me.txtPass.Location = New System.Drawing.Point(26, 222)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(308, 32)
        Me.txtPass.TabIndex = 1
        Me.txtPass.UseSystemPasswordChar = True
        '
        ' btnLogin
        '
        Me.btnLogin.Text = "Iniciar Sesión"
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold)
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(0, 217, 163)
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(13, 17, 23)
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.Location = New System.Drawing.Point(26, 288)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(308, 40)
        Me.btnLogin.TabIndex = 2
        '
        ' FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(13, 17, 23)
        Me.ClientSize = New System.Drawing.Size(500, 520)
        Me.Controls.Add(Me.pnlBg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TaskFlow"
        Me.pnlBg.ResumeLayout(False)
        Me.pnlCard.ResumeLayout(False)
        Me.pnlCard.PerformLayout()
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents pnlBg As System.Windows.Forms.Panel
    Friend WithEvents pnlCard As System.Windows.Forms.Panel
    Friend WithEvents lblDot1 As System.Windows.Forms.Label
    Friend WithEvents lblDot2 As System.Windows.Forms.Label
    Friend WithEvents lblDot3 As System.Windows.Forms.Label
    Friend WithEvents lblAppName As System.Windows.Forms.Label
    Friend WithEvents lblWelcome As System.Windows.Forms.Label
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
End Class
