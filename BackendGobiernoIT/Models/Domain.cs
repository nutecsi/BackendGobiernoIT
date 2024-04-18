using BackendCore.Lib.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendGobiernoIT.Models;

public class Domain
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int CompanyId { get; set; }
    public string DomainName {  get; set; }
    public string DomainExtensionId { get; set; }
    public string? ProviderId { get; set; }
    public string? RegistradorId { get; set; } 

    public DateTime? ExpirationDate { get; set; }

    public bool Active { get; set; } = true;
    public bool IncludesDNS { get; set; }

    public string? DnsProviderId { get; set; }

    [DeleteBehavior(DeleteBehavior.NoAction)] public virtual Company Company {  get; set; }
    [DeleteBehavior(DeleteBehavior.NoAction)] public virtual GenericListRecord DomainExtension {  get; set; }
    [DeleteBehavior(DeleteBehavior.NoAction)] public virtual GenericListRecord Provider { get; set; }
    [DeleteBehavior(DeleteBehavior.NoAction)] public virtual GenericListRecord Registrador { get; set; }
    [DeleteBehavior(DeleteBehavior.NoAction)] public virtual GenericListRecord DnsProvider { get; set; }
}
