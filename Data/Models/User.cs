using Google.Cloud.Firestore;

namespace VertexWeb.Data.Models;

[FirestoreData]
public class User
{
    [FirestoreDocumentId]
    public string Id { get; set; }

    [FirestoreProperty]
    public string Names { get; set; }

    [FirestoreProperty]
    public string LastNames { get; set; }

    [FirestoreProperty]
    public string PhoneNumber { get; set; }

    [FirestoreProperty]
    public int Role { get; set; }

    [FirestoreProperty]
    public string Email { get; set; }

    [FirestoreProperty]
    public string Password { get; set; }

    [FirestoreProperty]
    public string InstitutionId { get; set; }

    [FirestoreProperty]
    public int Status { get; set; }
}