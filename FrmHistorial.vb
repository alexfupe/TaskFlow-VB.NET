Imports MongoDB.Driver
Imports System.Drawing

Public Class FrmHistorial
    Private logica As New LogicaUsuarios()
    Private _admin As Usuario

    Public Sub New(admin As Usuario)
        InitializeComponent()
        _admin = admin
    End Sub

    Private Sub FrmHistorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarHistorial()
    End Sub

    Private Sub CargarHistorial()
        Try
            dgvHistorial.DataSource = logica.ListarHistorial(_admin)
        Catch ex As Exception
            MsgBox("Error al cargar datos: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        If dgvHistorial.SelectedRows.Count > 0 Then

            Dim idUsuario = dgvHistorial.SelectedRows(0).Cells("Id").Value.ToString()
            Dim nombreUsuario = dgvHistorial.SelectedRows(0).Cells("Username").Value.ToString()

            If MsgBox("¿Deseas restaurar al usuario '" & nombreUsuario & "'?" & vbCrLf & "El usuario volverá a estar activo en el sistema.", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Restaurar Usuario") = MsgBoxResult.Yes Then
                Try
                    logica.RestaurarUsuario(_admin, idUsuario)
                    MsgBox("Usuario '" & nombreUsuario & "' restaurado con éxito.", MsgBoxStyle.Information)
                    CargarHistorial()
                Catch ex As Exception
                    MsgBox("Error al restaurar: " & ex.Message, MsgBoxStyle.Critical)
                End Try
            End If
        Else
            MsgBox("Por favor, selecciona un usuario del historial primero.", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class