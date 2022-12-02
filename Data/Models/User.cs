using Google.Cloud.Firestore;
using System.ComponentModel.DataAnnotations;

namespace VertexWeb.Data.Models;

[FirestoreData]
public class User
{
    [FirestoreDocumentId]
    public string Id { get; set; }

    [FirestoreProperty]
    [Required]
    [StringLength(50, ErrorMessage = "Nombre demasiado largo."), MinLength(3, ErrorMessage = "Nombre demasiado corto.")]
    public string FirstName { get; set; }

    [FirestoreProperty]
    [Required]
    [StringLength(50, ErrorMessage = "Apellido demasiado largo."), MinLength(3, ErrorMessage = "Apellido demasiado corto.")]
    public string LastName { get; set; }

    [FirestoreProperty]
    [Required]
    [StringLength(13, ErrorMessage = "Telefono demasiado largo."), MinLength(8, ErrorMessage = "Telefono demasiado corto.")]
    public string PhoneNumber { get; set; }

    [FirestoreProperty]
    [Required]
    // 1 : Admin
    // 2 : Cook
    // 3 : Waiter
    // 4 : Customer
    public int Role { get; set; }

    [FirestoreProperty]
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [FirestoreProperty]
    [Required]
    public string Password { get; set; }

    [FirestoreProperty]
    [Required]
    // 1 : Cochabamba
    // 2 : Santa Cruz
    // 3 : La Paz 

    public int City { get; set; }

    [FirestoreProperty]
    public string? InstitutionId { get; set; }

    [FirestoreDocumentCreateTimestamp]
    public DateTime CreatedAt { get; set; }

    [FirestoreProperty]
    public int Status { get; set; }

}