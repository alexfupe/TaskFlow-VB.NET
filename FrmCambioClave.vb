Imports MongoDB.Driver
Imports System.Drawing

Public Class FrmCambioClave
    Private _usuario As Usuario
    Private logica As New LogicaUsuarios()

    Public Sub New(u As Usuario)
        InitializeComponent()
        _usuario = u
    End Sub

    Private Sub FrmCambioClave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Styling ya aplicado en el Designer
    End Sub

    Private Sub btnCambiar_Click(sender As Object, e As EventArgs) Handles btnCambiar.Click
        If String.IsNullOrWhiteSpace(txtNueva.Text) Then
            MsgBox("La contraseña no puede estar vacía.", MsgBoxStyle.Exclamation)
            Return
        End If

        If txtNueva.Text <> txtRepetir.Text Then
            MsgBox("Las claves no coinciden.", MsgBoxStyle.Exclamation)
            Return
        End If

        Try
            logica.CambiarClaveObligatorio(_usuario.Id, txtNueva.Text)

            MsgBox("Clave cambiada con éxito. Accediendo al sistema...", MsgBoxStyle.Information)

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MsgBox("Error al cambiar la clave: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class