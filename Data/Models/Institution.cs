using Google.Cloud.Firestore;
using System.ComponentModel.DataAnnotations;

namespace VertexWeb.Data.Models;

[FirestoreData]
public class Institution
{
    [FirestoreDocumentId]
    public string Id { get; set; }

    [FirestoreProperty]
    [Required]
    [StringLength(50, ErrorMessage = "Nombre demasiado largo."), MinLength(3, ErrorMessage = "Nombre demasiado corto.")]
    public string Name { get; set; }

    [FirestoreProperty]
    [Required]
    // 1 : Cochabamba
    // 2 : Santa Cruz
    // 3 : La Paz 
    public int City { get; set; }

    [FirestoreProperty]
    [Required]
    public string Photo { get; set; }

    [FirestoreProperty]
    [Required]
    [StringLength(50, ErrorMessage = "Direccion demasiado larga."), MinLength(3, ErrorMessage = "Direccion demasiado corta.")]
    public string Address { get; set; }

    [FirestoreProperty]
    [Required]
    [StringLength(50, ErrorMessage = "Categoria demasiado larga."), MinLength(3, ErrorMessage = "Categoria demasiado corta.")]
    public string Category { get; set; }

    [FirestoreProperty]
    [Required]
    [StringLength(13, ErrorMessage = "Telefono demasiado largo."), MinLength(8, ErrorMessage = "Telefono demasiado corto.")]
    public string PhoneNumber { get; set; }

    [FirestoreProperty]
    public List<Category>? Categories { get; set; }

    [FirestoreDocumentCreateTimestamp]
    public DateTime CreatedAt { get; set; }

    [FirestoreProperty]
    // 1 : Active
    // 2 : Deleted
    public int Status { get; set; }

    public Institution()
    {
        Categories = new List<Category>();
        Status = 1;
    }
}