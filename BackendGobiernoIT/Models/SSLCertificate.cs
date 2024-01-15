using BackendCore.Lib.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendGobiernoIT.Models;

public class SSLCertificate
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int CompanyId { get; set; }
    public string URL { get; set; }
    public string CertTypeId { get; set; }
    public DateTime? RenovationDate { get; set; }

    [DeleteBehavior(DeleteBehavior.NoAction)] public virtual GenericListRecord CertType { get; set; }
}
