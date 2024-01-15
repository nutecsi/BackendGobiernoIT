using BackendCore.Lib.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendGobiernoIT.Models;

public class Software
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [ForeignKey("SoftwareFK")]  public string SoftwareId { get; set; }
    public string CategoryId { get; set; }
    public string ManufacturerId { get; set; }

    [DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual GenericListRecord SoftwareFK { get; set; }

    [DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual GenericListRecord Category { get; set; }

    [DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual GenericListRecord Manufacturer { get; set; }
}
