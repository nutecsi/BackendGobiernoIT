using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendGobiernoIT.Models;

public class CompanyManager
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public int CompanyId { get; set; }

    [Required]
    public int CompanyUserId { get; set; }

    public string? Notes { get; set; }

    public virtual Company Company { get; set; }
    public virtual CompanyUser CompanyUser { get; set; }
}
