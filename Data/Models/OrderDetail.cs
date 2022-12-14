using Google.Cloud.Firestore;

namespace VertexWeb.Data.Models;

[FirestoreData]
public class OrderDetail
{
    [FirestoreProperty]
    public string ProductId { get; set; }

    [FirestoreProperty]
    public int Quantity { get; set; }
}

