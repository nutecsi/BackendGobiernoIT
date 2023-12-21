using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendGobiernoIT.Models;

public class EmailDomain
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public int CompanyId { get; set; }

    [Required]
    public string DomainName { get; set; }

    // Relationship with Company
    public virtual Company Company { get; set; }
}
