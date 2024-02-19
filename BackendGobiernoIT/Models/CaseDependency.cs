using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendGobiernoIT.Models;

public class CaseDependency
{
    public int SourceId { get; set; }
    public int DependsOnId { get; set; }

    [ForeignKey("SourceId"), DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual Case Source { get; set; }

    [ForeignKey("DependsOnId"), DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual Case DependsOn { get; set; }
}
