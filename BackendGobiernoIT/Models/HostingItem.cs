using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendGobiernoIT.Models;

public class HostingItem
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int CompanyId { get; set; }
    public int DomainId { get; set; }
    public int HostingId { get; set; }
    public bool Redirect301 { get; set; }
    public bool IncludesSSL { get; set; }

    public int? SSLCertId { get; set; }

    public bool DnsServicesActive { get; set; }
    public bool MailServicesActive { get; set; }

    public string? Description { get; set; }

    [DeleteBehavior(DeleteBehavior.NoAction)] public virtual Company Company { get; set; }
    [DeleteBehavior(DeleteBehavior.NoAction)] public virtual Domain Domain { get; set; }
    [DeleteBehavior(DeleteBehavior.NoAction)] public virtual Hosting Hosting { get; set; }
    [DeleteBehavior(DeleteBehavior.NoAction)] public virtual SSLCertificate? SSLCert { get; set; }
}
