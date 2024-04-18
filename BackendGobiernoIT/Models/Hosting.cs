using BackendCore.Lib.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendGobiernoIT.Models;

public class Hosting
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string ServerName { get; set; }
    public string PublicIP { get; set; }
    public string ManagementURL { get; set; }
    public string HostingSystemId { get; set; }
    public string ProviderId { get; set;}
    public DateTime? DeactivationDate { get; set; }

    public DateTime? RenovationDate { get; set; }
    public string? Description { get; set; }


    [DeleteBehavior(DeleteBehavior.NoAction)] public virtual GenericListRecord HostingSystem { get; set; }
    [DeleteBehavior(DeleteBehavior.NoAction)] public virtual GenericListRecord Provider { get; set; }
}
