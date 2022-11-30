using Google.Cloud.Firestore;

namespace VertexWeb.Data.Models;

[FirestoreData]
public class Institution
{
    [FirestoreDocumentId]
    public string Id { get; set; }

    [FirestoreProperty]
    public string Name { get; set; }

    [FirestoreProperty]
    public string City { get; set; }

    [FirestoreProperty]
    public string Photo { get; set; }

    [FirestoreProperty]
    public string Address { get; set; }

    // [FirestoreProperty]
    // public List<Category>

    [FirestoreProperty]
    public int Status { get; set; }
}