Imports MongoDB.Driver

Public Class LogicaUsuarios
    Private db As New GestorDatos()


    Public Function ValidarUsuario(user As String, pass As String) As Usuario
        Dim filtroUser = Builders(Of Usuario).Filter.Eq(Function(u) u.Username, user)

        Dim usuarioEncontrado = db.usuarios.Find(filtroUser).FirstOrDefault()

        If usuarioEncontrado Is Nothing OrElse Not usuarioEncontrado.Active Then Return Nothing

        If GestorDatos.VerifyPassword(pass.Trim(), usuarioEncontrado.Password.Trim()) Then
            Dim update = Builders(Of Usuario).Update.Set(Function(u) u.LastLogin, DateTime.Now)
            db.usuarios.UpdateOne(filtroUser, update)
            Return usuarioEncontrado
        End If

        Return Nothing
    End Function

    Public Function RecuperarClave(email As String) As String
        Dim filtro = Builders(Of Usuario).Filter.Eq(Function(u) u.Email, email)
        Dim user = db.usuarios.Find(filtro).FirstOrDefault()

        If user Is Nothing Then Throw New Exception("Correo no encontrado.")

        Dim nuevaClavePlana = "Recov_" & DateTime.Now.ToString("ddMMyyHHmm") & "_" & Guid.NewGuid().ToString().Substring(0, 4)
        Dim hash = GestorDatos.HashPassword(nuevaClavePlana)

        Dim update = Builders(Of Usuario).Update _
            .Set(Function(u) u.Password, hash) _
            .Set(Function(u) u.ForcePasswordChange, True)

        db.usuarios.UpdateOne(filtro, update)
        Return nuevaClavePlana
    End Function

    Public Sub CambiarClaveObligatorio(idUsuario As String, nuevaClave As String)
        Dim filtro = Builders(Of Usuario).Filter.Eq(Function(u) u.Id, idUsuario)
        Dim hash = GestorDatos.HashPassword(nuevaClave)

        Dim update = Builders(Of Usuario).Update _
            .Set(Function(u) u.Password, hash) _
            .Set(Function(u) u.ForcePasswordChange, False)

        db.usuarios.UpdateOne(filtro, update)
    End Sub


    Private Sub ValidarAdmin(admin As Usuario)
        If admin Is Nothing OrElse admin.Role <> "ADMIN" Then
            Throw New Exception("Acceso denegado: Solo el Administrador puede realizar esta acción.")
        End If
    End Sub

    Public Sub CrearUsuario(admin As Usuario, nuevo As Usuario)
        ValidarAdmin(admin)
        nuevo.CreatedAt = DateTime.Now
        nuevo.Password = GestorDatos.HashPassword(nuevo.Password)
        If nuevo.Permissions Is Nothing Then nuevo.Permissions = New List(Of String)()

        db.usuarios.InsertOne(nuevo)
    End Sub

    Public Sub ModificarUsuario(admin As Usuario, modificado As Usuario)
        ValidarAdmin(admin)
        Dim filtro = Builders(Of Usuario).Filter.Eq(Function(u) u.Id, modificado.Id)

        Dim update = Builders(Of Usuario).Update _
            .Set(Function(u) u.Email, modificado.Email) _
            .Set(Function(u) u.Role, modificado.Role) _
            .Set(Function(u) u.Active, modificado.Active) _
            .Set(Function(u) u.Permissions, modificado.Permissions) _
            .Set(Function(u) u.LastPaymentDate, modificado.LastPaymentDate)

        If Not String.IsNullOrEmpty(modificado.Password) AndAlso Not modificado.Password.StartsWith("$2") Then
            update = update.Set(Function(u) u.Password, GestorDatos.HashPassword(modificado.Password))
        End If

        db.usuarios.UpdateOne(filtro, update)
    End Sub

    Public Sub BorrarUsuario(admin As Usuario, id As String)
        ValidarAdmin(admin)
        Dim filtro = Builders(Of Usuario).Filter.Eq(Function(u) u.Id, id)
        Dim user = db.usuarios.Find(filtro).FirstOrDefault()

        If user Is Nothing Then Throw New Exception("Usuario no encontrado.")

        Dim diasInactivo = If(user.LastLogin.HasValue, (DateTime.Now - user.LastLogin.Value).TotalDays, (DateTime.Now - user.CreatedAt).TotalDays)

        If diasInactivo < 3 Then
            Throw New Exception("No se puede borrar el usuario: Se ha conectado en los últimos 3 días.")
        End If

        user.DeletedAt = DateTime.Now
        db.historial.InsertOne(user)
        db.usuarios.DeleteOne(filtro)
    End Sub

    Public Sub RestaurarUsuario(admin As Usuario, id As String)
        ValidarAdmin(admin)
        Dim filtro = Builders(Of Usuario).Filter.Eq(Function(u) u.Id, id)
        Dim user = db.historial.Find(filtro).FirstOrDefault()

        If user Is Nothing Then Throw New Exception("Usuario no encontrado en el historial.")

        user.DeletedAt = Nothing
        db.usuarios.InsertOne(user)
        db.historial.DeleteOne(filtro)
    End Sub

    Public Sub ProcesarBajasPorImpago(admin As Usuario)
        ValidarAdmin(admin)
        Dim limiteFecha = DateTime.Now.AddMonths(-2)

        Dim filtroMorosos = Builders(Of Usuario).Filter.Or(
            Builders(Of Usuario).Filter.Lt(Function(u) u.LastPaymentDate, limiteFecha),
            Builders(Of Usuario).Filter.Eq(Function(u) u.LastPaymentDate, DirectCast(Nothing, Nullable(Of DateTime)))
        )

        Dim morosos = db.usuarios.Find(filtroMorosos).ToList()

        For Each m In morosos
            m.DeletedAt = DateTime.Now
            db.historial.InsertOne(m)
            db.usuarios.DeleteOne(Builders(Of Usuario).Filter.Eq(Function(u) u.Id, m.Id))
        Next
    End Sub


    Public Function ListarTodos(admin As Usuario) As List(Of Usuario)
        ValidarAdmin(admin)
        Return db.usuarios.Find(Builders(Of Usuario).Filter.Empty).ToList()
    End Function

    Public Function ListarHistorial(admin As Usuario) As List(Of Usuario)
        ValidarAdmin(admin)
        Return db.historial.Find(Builders(Of Usuario).Filter.Empty).ToList()
    End Function

    Public Function ListarPorFecha(admin As Usuario, inicio As DateTime, fin As DateTime) As List(Of Usuario)
        ValidarAdmin(admin)
        Dim filtro = Builders(Of Usuario).Filter.And(
            Builders(Of Usuario).Filter.Gte(Function(u) u.CreatedAt, inicio),
            Builders(Of Usuario).Filter.Lte(Function(u) u.CreatedAt, fin.AddDays(1).AddSeconds(-1))
        )
        Return db.usuarios.Find(filtro).ToList()
    End Function

    Public Function ListarActivos(admin As Usuario) As List(Of Usuario)
        ValidarAdmin(admin)
        Return db.usuarios.Find(Builders(Of Usuario).Filter.Eq(Function(u) u.Active, True)).ToList()
    End Function

    Public Function ListarConexionMesActual(admin As Usuario) As List(Of Usuario)
        ValidarAdmin(admin)
        Dim inicioMes = New DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
        Dim filtro = Builders(Of Usuario).Filter.Gte(Function(u) u.LastLogin, inicioMes)
        Return db.usuarios.Find(filtro).ToList()
    End Function
End Class