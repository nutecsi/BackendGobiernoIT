using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendGobiernoIT.Models;

public class Backup
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public int CompanyId { get; set; }
    public int SoftwareId { get; set; }

    public int SizeGB { get; set; }
    public bool InCloud { get; set; }
    public bool InLocal { get; set; }
    public string? Description { get; set; }

    [DeleteBehavior(DeleteBehavior.NoAction)] public virtual Company Company { get; set; }
    [DeleteBehavior(DeleteBehavior.NoAction)] public virtual Software Software { get; set; }
}
