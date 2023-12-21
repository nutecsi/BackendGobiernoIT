using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendGobiernoIT.Models;

public class WorkCenter
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public string Description { get; set; }

    public string Address { get; set; }

    // Relationship with Company
    public virtual Company Company { get; set; }
}