using Google.Cloud.Firestore;

namespace VertexWeb.Data.Models;

[FirestoreData]
public class Order
{
    [FirestoreDocumentId]
    public string Id { get; set; }

    [FirestoreProperty]
    public string UserId { get; set; }

    [FirestoreProperty]
    public string InstitutionId { get; set; }

    [FirestoreProperty]
    public double Total { get; set; }

    [FirestoreDocumentCreateTimestamp]
    public DateTime CreatedAt { get; set; }

    [FirestoreProperty]
    public string? NIT { get; set; }

    [FirestoreProperty]
    // 1: PickUp
    // 2: ForHere
    public int OrderType { get; set; }

    [FirestoreProperty]
    public string? OrderDetail { get; set; }

    [FirestoreProperty]
    public List<OrderDetail> Detail { get; set; }


    [FirestoreProperty]
    // 1: Placed
    // 2: Approved
    // 3: Ready
    // 4: Delivered
    // 5: Cancelled

    public int Status { get; set; }
}