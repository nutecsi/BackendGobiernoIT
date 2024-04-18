using BackendCore.Lib.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendGobiernoIT.Models;

public class Case
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int? CompanyId { get; set; }
    public string CreatorUserId { get; set; }
    public int? RequesterClientId { get; set; } 
    public string? ResponsibleUserId { get; set; } 
    public int? HardwareInventoryId { get; set; } 
    public bool Checklist { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public DateTime? ClosureDate { get; set; }
    public string? ClosingUserId { get; set; } // Usuario que cierra el caso
    public string StatusId { get; set; } // Estado del caso
    public string? CategoryId { get; set; } // Categoria del caso
    public string PriorityId { get; set; } // Prioridad del caso
    public string? ClassificationId { get; set; } // Clasificación (tags)
    public string EntryChannelId { get; set; } // Canal de entrada
    public int? GroupId { get; set; } // Canal de entrada

    [MaxLength(500)]
    public string? CaseDescription { get; set; } // Descripción breve

    public string? Notes { get; set; } // Descripción larga

    public int? ParentId { get; set; } // Para subtareas, el ID del caso padre
    public int? DependantTaskId { get; set; } // Para subtareas, el ID del caso padre
    public virtual ICollection<FollowUp> FollowUps { get; set; }
    public virtual ICollection<Case> Subtasks { get; set; }
    public int? CompanyUserId { get; set; }

    [ForeignKey("CompanyUserId"), DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual CompanyUser? CompanyUser { get; set; }

    [ForeignKey("StatusId"), DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual GenericListRecord Status { get; set; }
    [ForeignKey("CategoryId"), DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual GenericListRecord? Category { get; set; }
    [ForeignKey("PriorityId"), DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual GenericListRecord Priority { get; set; }
    [ForeignKey("EntryChannelId"), DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual GenericListRecord EntryChannel { get; set; }

    [ForeignKey("ParentId"), DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual Case? Parent { get; set; }

    [ForeignKey("DependantTaskId"), DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual Case? DependantTask { get; set; }

    [ForeignKey("CompanyId"), DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual Company? Company { get; set; }
    [ForeignKey("CreatorUserId"), DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual CoreUser CreatorUser { get; set; }
    [ForeignKey("RequesterClientId"), DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual CompanyUser? RequesterClient { get; set; }
    [ForeignKey("ResponsibleUserId"), DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual CoreUser? ResponsibleUser { get; set; }
    [ForeignKey("ClosingUserId"), DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual CoreUser? ClosingUser { get; set; }
    [ForeignKey("HardwareInventoryId"), DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual Device? HardwareInventory { get; set; }
    [ForeignKey("GroupId"), DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual Group? Group { get; set; }
}
