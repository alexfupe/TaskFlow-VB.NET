Imports System.Drawing

Public Class FrmEdicionUsuario
    Private _admin As Usuario
    Private _usuarioEditar As Usuario
    Private logica As New LogicaUsuarios()

    Public Sub New(admin As Usuario, usuario As Usuario)
        InitializeComponent()
        _admin = admin
        _usuarioEditar = usuario
    End Sub

    Private Sub FrmEdicionUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Poblar roles
        cmbRol.Items.Clear()
        cmbRol.Items.AddRange({"ADMIN", "EDITOR", "USER"})

        If _usuarioEditar IsNot Nothing Then
            ' Modo edición
            lblTitulo.Text = "Editar: " & _usuarioEditar.Username
            Me.Text = "Editar Usuario – " & _usuarioEditar.Username

            txtNombre.Text = _usuarioEditar.Username
            txtNombre.Enabled = False  ' El nombre de usuario NO se puede modificar
            txtNombre.ForeColor = Color.FromArgb(100, 100, 100)

            txtEmail.Text = _usuarioEditar.Email
            txtPassword.Text = ""
            lblPasswordTag.Text = "NUEVA CONTRASEÑA (dejar vacío = no cambiar)"

            cmbRol.SelectedItem = _usuarioEditar.Role
            chkActivo.Checked = _usuarioEditar.Active

            If _usuarioEditar.Permissions IsNot Nothing Then
                chkPermisoLectura.Checked = _usuarioEditar.Permissions.Contains("LEER")
                chkPermisoEscritura.Checked = _usuarioEditar.Permissions.Contains("ESCRIBIR")
            End If

            If _usuarioEditar.LastPaymentDate.HasValue Then
                dtpUltimoPago.Value = _usuarioEditar.LastPaymentDate.Value
            End If

            chkRecuperacion.Checked = _usuarioEditar.ForcePasswordChange
        Else
            ' Modo creación
            lblTitulo.Text = "Nuevo Usuario"
            Me.Text = "Crear Nuevo Usuario"
            cmbRol.SelectedIndex = 2  ' USER por defecto
            chkActivo.Checked = True
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If String.IsNullOrWhiteSpace(txtNombre.Text) OrElse cmbRol.SelectedItem Is Nothing Then
            MsgBox("Todos los campos básicos son obligatorios.", MsgBoxStyle.Exclamation)
            Return
        End If

        If _usuarioEditar Is Nothing AndAlso String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MsgBox("La contraseña es obligatoria para nuevos usuarios.", MsgBoxStyle.Exclamation)
            Return
        End If

        Dim idGuardar = If(_usuarioEditar IsNot Nothing, _usuarioEditar.Id, "")
        Dim passwordGuardar = txtPassword.Text

        If _usuarioEditar IsNot Nothing AndAlso String.IsNullOrWhiteSpace(passwordGuardar) Then
            passwordGuardar = _usuarioEditar.Password
        End If

        Dim usuarioTemp As New Usuario With {
            .Id = idGuardar,
            .Username = txtNombre.Text.Trim(),
            .Email = txtEmail.Text.Trim(),
            .Password = passwordGuardar,
            .Role = cmbRol.SelectedItem.ToString(),
            .Active = chkActivo.Checked,
            .ForcePasswordChange = chkRecuperacion.Checked,
            .LastPaymentDate = dtpUltimoPago.Value,
            .Permissions = New List(Of String)()
        }

        If chkPermisoLectura.Checked Then usuarioTemp.Permissions.Add("LEER")
        If chkPermisoEscritura.Checked Then usuarioTemp.Permissions.Add("ESCRIBIR")

        Try
            If _usuarioEditar Is Nothing Then
                logica.CrearUsuario(_admin, usuarioTemp)
                MsgBox("Usuario creado con éxito.", MsgBoxStyle.Information)
            Else
                logica.ModificarUsuario(_admin, usuarioTemp)
                MsgBox("Usuario actualizado con éxito.", MsgBoxStyle.Information)
            End If

            Me.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class