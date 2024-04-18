using BackendCore.Lib.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace BackendGobiernoIT.Models;

public class Company
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; }
    public string LegalName { get; set; }
    public string TypeId { get; set; }
    public int? GroupId { get; set; }
    public bool HasItSupport { get; set; }

    // Relationship with the EmailDomain table
    public virtual ICollection<EmailDomain> EmailDomains { get; set; }

    // Relationship with the Phone table
    public virtual ICollection<Phone> Phones { get; set; }

    public virtual ICollection<CompanyUser> CompanyUsers { get; set; }

    // Relationship with the WorkCenter table
    public virtual ICollection<WorkCenter> WorkCenters { get; set; }

    [DeleteBehavior(DeleteBehavior.NoAction)] public virtual GenericListRecord Type { get; set; }

    public virtual Group? Group { get; set; }
}
