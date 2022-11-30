using Google.Cloud.Firestore;

namespace VertexWeb.Data.Models;

[FirestoreData]
public class Product
{
    [FirestoreDocumentId]
    public string Id { get; set; }

    [FirestoreProperty]
    public string Name { get; set; }

    [FirestoreProperty]
    public double Price { get; set; }

    [FirestoreProperty]
    public string Description { get; set; }

    [FirestoreProperty]
    public string Photo { get; set; }

    [FirestoreProperty]
    public int Status { get; set; }

}