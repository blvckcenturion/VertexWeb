using Google.Cloud.Firestore;

namespace VertexWeb.Data.Models;

public class Category
{
    [FirestoreProperty]
    public string Name { get; set; }

    [FirestoreProperty]
    public List<string> ProductIds { get; set; }

}