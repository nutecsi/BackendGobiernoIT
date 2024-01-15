using BackendCore.Lib.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendGobiernoIT.Models;

public class CompanyUser
{
    [Key]
    public int Id { get; set; }
    public int CompanyId { get; set; }
    public DateTime? TerminationDate { get; set; }

    [Required]
    public string FullName { get; set; }

    public string? EntraIdUser { get; set; }

    public string? EntraIdPassword { get; set; } // Considerar almacenamiento seguro

    public bool HasRemoteAccess { get; set; }

    public int WorkCenterId { get; set; }

    public string? JobPositionId { get; set; }

    [ForeignKey("GenericList")]
    public string? Department { get; set; }
    
    public string? Description { get; set; }

    public string? Phone { get; set; } // Format: "country code + number"

    public string? Extension { get; set; }

    public int GroupId { get; set; }

    // Relación con EmailInfo
    public virtual ICollection<EmailInfo> Emails { get; set; }
    public virtual Company Company { get; set; }
    public virtual WorkCenter WorkCenter { get; set; }
    public virtual GenericListRecord? GenericList { get; set; }
    public virtual GenericListRecord? JobPosition { get; set; }
    public virtual Group Group { get; set; }
}
