using BackendCore.Lib.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendGobiernoIT.Models;


public class FollowUp
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public int CaseId { get; set; } // ID del caso asociado

    public string InternalUserId { get; set; } // Usuario interno que hace seguimiento

    public int? ClientUserId { get; set; } // Usuario cliente (opcional)

    public DateTime DateTime { get; set; }

    public bool IsPrivate { get; set; }

    [MaxLength(2000)]
    public string Description { get; set; } // Descripción del seguimiento

    public bool NotifyByEmail { get; set; } // Si se notifica por email

    // Relación con Case
    public virtual Case Case { get; set; }

    // Lista de adjuntos si es necesario

    [ForeignKey("ClientUserId"), DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual CompanyUser? ClientUser { get; set; }
    [ForeignKey("InternalUserId"), DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual CoreUser InternalUser { get; set; } // Usuario interno que hace seguimiento
}