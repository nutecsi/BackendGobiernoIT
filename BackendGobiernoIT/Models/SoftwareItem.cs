using BackendCore.Lib.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendGobiernoIT.Models;

public class SoftwareItem
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int CompanyId { get; set; }
    public int SoftwareId { get; set; }
    public string Version { get; set; }
    public int NumberOfLicences { get; set; }
    public bool Active { get; set; } = true;

    public string? Notes { get; set; }
    public int? GroupId { get; set; }
    public string? ProviderId { get; set; }

    [DeleteBehavior(DeleteBehavior.NoAction)] public virtual Group Group { get; set; }

    [DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual GenericListRecord? Provider { get; set; }

    [DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual Company Company { get; set; }

    [DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual Software Software { get; set; }
}
