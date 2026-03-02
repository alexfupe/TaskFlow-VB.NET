Imports MongoDB.Driver
Imports System.Drawing

Public Class FrmGestionUsuarios
    Private logica As New LogicaUsuarios()
    Private _admin As Usuario

    Public Sub New(admin As Usuario)
        InitializeComponent()
        _admin = admin
    End Sub

    Private Sub FrmGestionUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Poblar el filtro
        cbxFiltro.Items.Clear()
        cbxFiltro.Items.AddRange({"Todos", "Activos", "Borrados", "Conectados Este Mes", "Por Fecha de Creación"})
        cbxFiltro.SelectedIndex = 0

        ' Ocultar date pickers y sus labels al inicio
        lblDesde.Visible = False
        dtpInicio.Visible = False
        lblHasta.Visible = False
        dtpFin.Visible = False

        CargarGrid("Todos")
    End Sub

    Private Sub cbxFiltro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxFiltro.SelectedIndexChanged
        Dim mostrarFechas = (cbxFiltro.SelectedItem.ToString() = "Por Fecha de Creación")
        lblDesde.Visible = mostrarFechas
        dtpInicio.Visible = mostrarFechas
        lblHasta.Visible = mostrarFechas
        dtpFin.Visible = mostrarFechas
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        CargarGrid(cbxFiltro.SelectedItem.ToString())
    End Sub

    Private Sub btnRefrescarFiltro_Click(sender As Object, e As EventArgs) Handles btnRefrescarFiltro.Click
        cbxFiltro.SelectedIndex = 0
        dtpInicio.Value = DateTime.Now
        dtpFin.Value = DateTime.Now
        CargarGrid("Todos")
    End Sub

    Private Sub btnPurgar_Click(sender As Object, e As EventArgs) Handles btnPurgar.Click
        If MsgBox("¿Estás seguro de purgar a los usuarios con más de 2 meses sin pagar?" & vbCrLf & "Esta acción moverá esos usuarios al historial.", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Purgar Morosos") = MsgBoxResult.Yes Then
            Try
                logica.ProcesarBajasPorImpago(_admin)
                MsgBox("Morosos movidos al historial correctamente.", MsgBoxStyle.Information)
                CargarGrid(cbxFiltro.SelectedItem.ToString())
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Sub CargarGrid(filtro As String)
        Try
            Dim datos As List(Of Usuario) = Nothing
            Select Case filtro
                Case "Todos"
                    datos = logica.ListarTodos(_admin)
                Case "Activos"
                    datos = logica.ListarActivos(_admin)
                Case "Borrados"
                    datos = logica.ListarHistorial(_admin)
                Case "Conectados Este Mes"
                    datos = logica.ListarConexionMesActual(_admin)
                Case "Por Fecha de Creación"
                    datos = logica.ListarPorFecha(_admin, dtpInicio.Value, dtpFin.Value)
            End Select
            dgvUsuarios.DataSource = datos
        Catch ex As Exception
            MsgBox("Error al cargar usuarios: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim frm As New FrmEdicionUsuario(_admin, Nothing)
        frm.ShowDialog()
        CargarGrid(cbxFiltro.SelectedItem.ToString())
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If dgvUsuarios.SelectedRows.Count > 0 Then
            Dim id = dgvUsuarios.SelectedRows(0).Cells("Id").Value.ToString()
            Dim usuarioSeleccionado = logica.ListarTodos(_admin).Find(Function(u) u.Id = id)
            If usuarioSeleccionado IsNot Nothing Then
                Dim frm As New FrmEdicionUsuario(_admin, usuarioSeleccionado)
                frm.ShowDialog()
                CargarGrid(cbxFiltro.SelectedItem.ToString())
            End If
        Else
            MsgBox("Selecciona una fila primero.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        If dgvUsuarios.SelectedRows.Count > 0 Then
            Dim id = dgvUsuarios.SelectedRows(0).Cells("Id").Value.ToString()
            Dim nombre = dgvUsuarios.SelectedRows(0).Cells("Username").Value.ToString()

            If MsgBox("¿Estás seguro de eliminar al usuario '" & nombre & "'?" & vbCrLf & "Recuerda que solo puedes borrar usuarios inactivos por más de 3 días.", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Confirmar Eliminación") = MsgBoxResult.Yes Then
                Try
                    logica.BorrarUsuario(_admin, id)
                    MsgBox("Usuario borrado y enviado al historial.", MsgBoxStyle.Information)
                    CargarGrid(cbxFiltro.SelectedItem.ToString())
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If
        Else
            MsgBox("Selecciona una fila primero.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub dgvUsuarios_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellDoubleClick
        ' Doble clic también abre el editor
        If e.RowIndex >= 0 Then
            btnEditar_Click(Nothing, EventArgs.Empty)
        End If
    End Sub
End Class