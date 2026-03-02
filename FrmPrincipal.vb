Imports System.Drawing

Public Class FrmPrincipal
    Private _usuarioActual As Usuario

    Public Sub New(user As Usuario)
        InitializeComponent()
        _usuarioActual = user
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Actualizar bienvenida con nombre y rol del usuario
        lblBienvenida.Text = _usuarioActual.Username & vbCrLf & "[" & _usuarioActual.Role & "]"

        ' Colorear el MDI client area
        For Each ctl As Control In Me.Controls
            If TypeOf ctl Is MdiClient Then
                ctl.BackColor = Color.FromArgb(18, 18, 18)
            End If
        Next

        ' Solo el Admin ve Gestión e Historial
        If _usuarioActual.Role <> "ADMIN" Then
            btnNavUsuarios.Visible = False
            btnNavHistorial.Visible = False
        End If
    End Sub

    Private Sub btnNavUsuarios_Click(sender As Object, e As EventArgs) Handles btnNavUsuarios.Click
        ' Evitar duplicados
        For Each child As Form In Me.MdiChildren
            If TypeOf child Is FrmGestionUsuarios Then
                child.Activate()
                Return
            End If
        Next

        Dim frm As New FrmGestionUsuarios(_usuarioActual)
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub btnNavHistorial_Click(sender As Object, e As EventArgs) Handles btnNavHistorial.Click
        ' Evitar duplicados
        For Each child As Form In Me.MdiChildren
            If TypeOf child Is FrmHistorial Then
                child.Activate()
                Return
            End If
        Next

        Dim frm As New FrmHistorial(_usuarioActual)
        frm.MdiParent = Me
        frm.WindowState = FormWindowState.Maximized
        frm.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim respuesta = MsgBox("¿Deseas cerrar sesión?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Cerrar Sesión")
        If respuesta = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub
End Class