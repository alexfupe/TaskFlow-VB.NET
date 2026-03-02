Imports MongoDB.Driver

Public Class GestorDatos
    Private Const CONNECTION_STRING As String = "mongodb+srv://admin:admin@taskflowcluster.rvncuc6.mongodb.net/"
    Private Const DB_NAME As String = "taskflow_db"

    Private client As MongoClient
    Private database As IMongoDatabase

    Public usuarios As IMongoCollection(Of Usuario)
    Public historial As IMongoCollection(Of Usuario)

    Public Sub New()
        Try
            Dim settings = MongoClientSettings.FromConnectionString(CONNECTION_STRING)
            settings.ServerApi = New ServerApi(ServerApiVersion.V1)
            client = New MongoClient(settings)
            database = client.GetDatabase(DB_NAME)

            usuarios = database.GetCollection(Of Usuario)("taskflowVB_users")
            historial = database.GetCollection(Of Usuario)("taskflowVB_history")
        Catch ex As Exception
            Throw New Exception("Error conectando a MongoDB: " & ex.Message)
        End Try
    End Sub

    Public Shared Function HashPassword(password As String) As String
        Return BCrypt.Net.BCrypt.HashPassword(password)
    End Function

    Public Shared Function VerifyPassword(password As String, hash As String) As Boolean
        Try
            If hash.StartsWith("$2a$") OrElse hash.StartsWith("$2b$") OrElse hash.StartsWith("$2y$") Then
                Return BCrypt.Net.BCrypt.Verify(password, hash)
            End If
            Return password = hash
        Catch
            Return False
        End Try
    End Function
End Class