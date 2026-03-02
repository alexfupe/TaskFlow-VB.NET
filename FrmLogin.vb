Imports MongoDB.Driver
Imports System.Drawing

Public Class FrmLogin
    Private logica As New LogicaUsuarios()

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Agregar LinkLabel de recuperación de clave dinámicamente
        Dim lnkRecuperar As New LinkLabel()
        lnkRecuperar.Text = "¿Olvidaste tu contraseña?"
        lnkRecuperar.Font = New Font("Segoe UI", 9)
        lnkRecuperar.LinkColor = Color.FromArgb(208, 188, 255)
        lnkRecuperar.ActiveLinkColor = Color.FromArgb(245, 245, 245)
        lnkRecuperar.AutoSize = True
        lnkRecuperar.BackColor = Color.Transparent
        lnkRecuperar.Location = New Point(txtPass.Left, btnLogin.Bottom + 14)
        AddHandler lnkRecuperar.LinkClicked, AddressOf LnkRecuperar_LinkClicked
        pnlCard.Controls.Add(lnkRecuperar)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(txtUser.Text) OrElse String.IsNullOrWhiteSpace(txtPass.Text) Then
            MsgBox("Por favor, ingrese usuario y contraseña.", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            Dim usuario = logica.ValidarUsuario(txtUser.Text, txtPass.Text)

            If usuario Is Nothing Then
                MsgBox("Usuario o contraseña incorrectos, o cuenta inactiva.", MsgBoxStyle.Critical)
                Return
            End If

            If usuario.ForcePasswordChange Then
                MsgBox("Por seguridad, debes cambiar tu contraseña antes de continuar.", MsgBoxStyle.Information)
                Dim frmCambio As New FrmCambioClave(usuario)

                If frmCambio.ShowDialog() <> DialogResult.OK Then
                    Return
                End If
            End If

            Dim frm As New FrmPrincipal(usuario)
            frm.Show()
            Me.Hide()

        Catch ex As Exception
            MsgBox("Error de sistema: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub LnkRecuperar_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim email As String = InputBox("Ingrese su correo electrónico para recuperar la contraseña:", "Recuperación de Clave")

        If Not String.IsNullOrWhiteSpace(email) Then
            Try
                Dim nuevaClave = logica.RecuperarClave(email)
                MsgBox("¡Éxito! Se ha generado una nueva clave temporal (simulando envío por correo)." & vbCrLf & "Tu clave temporal es: " & nuevaClave, MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
End Class