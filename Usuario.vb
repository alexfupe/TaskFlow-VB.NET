Imports MongoDB.Bson
Imports MongoDB.Bson.Serialization.Attributes

<BsonIgnoreExtraElements>
Public Class Usuario
    <BsonId>
    <BsonRepresentation(BsonType.ObjectId)>
    Public Property Id As String

    <BsonElement("Username")>
    Public Property Username As String

    <BsonElement("Email")>
    Public Property Email As String

    <BsonElement("Password")>
    Public Property Password As String

    <BsonElement("Role")>
    Public Property Role As String

    <BsonElement("Active")>
    Public Property Active As Boolean

    <BsonElement("Created_at")>
    Public Property CreatedAt As DateTime

    <BsonElement("Last_login")>
    Public Property LastLogin As Nullable(Of DateTime)

    <BsonElement("Deleted_at")>
    Public Property DeletedAt As Nullable(Of DateTime)

    <BsonElement("Force_password_change")>
    Public Property ForcePasswordChange As Boolean

    <BsonElement("Permissions")>
    Public Property Permissions As List(Of String)

    <BsonElement("Last_payment_date")>
    Public Property LastPaymentDate As Nullable(Of DateTime)

End Class