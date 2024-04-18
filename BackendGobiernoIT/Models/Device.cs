using BackendCore.Lib.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackendGobiernoIT.Models;

public class Device
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public int CompanyId { get; set; }

    public DateTime? TerminationDate { get; set; } // Opcional

    [Required]
    public string DeviceName { get; set; }

    public string? DeviceTypeId { get; set; } // Clave foránea opcional para GenericListRecord

    public string? ManufacturerId { get; set; } // Clave foránea opcional para GenericListRecord

    public string? ManufacturerSerialNumber { get; set; }

    public string? InternalSerialNumber { get; set; }

    public bool? IsInMaintenance { get; set; } // Opcional

    public bool? IsInCloud { get; set; }

    public int WorkCenterId { get; set; } // Clave foránea opcional para WorkCenter

    public string? OperatingSystemId { get; set; } // Clave foránea opcional para GenericListRecord

    public string? InternalIP { get; set; } // Opcional

    public string? InternalIPMaskId { get; set; } // Clave foránea opcional para GenericListRecord

    public string? InternalPort { get; set; } // Opcional

    public string? ExternalIP { get; set; } // Opcional

    public string? ExternalIPMaskId { get; set; } // Clave foránea opcional para GenericListRecord

    public string? ExternalPort { get; set; } // Opcional

    public string? ProcessorId { get; set; } // Clave foránea opcional para GenericListRecord

    public string? RAMId { get; set; } // Clave foránea opcional para GenericListRecord

    public string? HD1 { get; set; } // Opcional

    public string? TypeHD1Id { get; set; } // Clave foránea opcional para GenericListRecord

    public string? HD2 { get; set; } // Opcional

    public string? TypeHD2Id { get; set; } // Clave foránea opcional para GenericListRecord

    public string? HD3 { get; set; } // Opcional

    public string? TypeHD3Id { get; set; } // Clave foránea opcional para GenericListRecord

    [MaxLength(500)]
    public string? Description { get; set; } // Opcional

    [MaxLength(1000)]
    public string? Notes { get; set; } // Opcional

    public string? SupplierId { get; set; } // Clave foránea opcional para GenericListRecord

    public DateTime? AcquisitionDate { get; set; } // Opcional

    public DateTime? WarrantyExpiration { get; set; } // Opcional

    public DateTime? DeactivationDate { get; set; }

    public int? MainUserId { get; set; }

    [ForeignKey("MainUserId"), DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual CompanyUser? MainUser { get; set; }

    [ForeignKey("DeviceTypeId"), DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual GenericListRecord? DeviceType { get; set; }

    [ForeignKey("ManufacturerId"), DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual GenericListRecord? Manufacturer { get; set; }

    [ForeignKey("OperatingSystemId"), DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual GenericListRecord? OperatingSystem { get; set; }

    [ForeignKey("InternalIPMaskId"), DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual GenericListRecord? InternalIPMask { get; set; }

    [ForeignKey("ExternalIPMaskId"), DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual GenericListRecord? ExternalIPMask { get; set; }

    [ForeignKey("ProcessorId"), DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual GenericListRecord? Processor { get; set; }

    [ForeignKey("RAMId"), DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual GenericListRecord? RAM { get; set; }

    [ForeignKey("TypeHD1Id"), DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual GenericListRecord? TypeHD1 { get; set; }

    [ForeignKey("TypeHD2Id"), DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual GenericListRecord? TypeHD2 { get; set; }

    [ForeignKey("TypeHD3Id"), DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual GenericListRecord? TypeHD3 { get; set; }

    [ForeignKey("SupplierId"), DeleteBehavior(DeleteBehavior.NoAction)]
    public virtual GenericListRecord? Supplier { get; set; }

    // Relación con la empresa y centro de trabajo
    [ForeignKey("WorkCenterId")]
    public virtual WorkCenter WorkCenter { get; set; }
    public virtual Company Company { get; set; }
}