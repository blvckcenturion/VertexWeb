using Google.Cloud.Firestore;

namespace VertexWeb.Data.Models;

[FirestoreData]
public class Category
{
    [FirestoreProperty]
    public string Name { get; set; }

    [FirestoreProperty]
    public List<string> Products { get; set; }

}