using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendGobiernoIT.Models;

public class Phone
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public int CompanyId { get; set; }

    [Required]
    public string Number { get; set; } // Format: "country code + number"

    public string Description { get; set; }

    // Relationship with Company
    public virtual Company Company { get; set; }
}
