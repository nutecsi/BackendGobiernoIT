using System.ComponentModel.DataAnnotations;

namespace BackendGobiernoIT.Models;

public class EmailInfo
{
    [Key]
    public int Id { get; set; }

    public int CompanyUserId { get; set; }

    [Required]
    public string Email { get; set; }

    public string? Password { get; set; } // Considerar almacenamiento seguro

    // Relación con ClientUser
    public virtual CompanyUser CompanyUser { get; set; }
}