using Microsoft.EntityFrameworkCore;
using BackendCore.Lib.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using BackendCore.Lib.Data;
using BackendGobiernoIT.Models;


namespace BackendGobiernoIT.Data;

public partial class ApplicationDbContext : CoreDbContext<CoreUser> 
{
    public ApplicationDbContext(DbContextOptions options) 
        : base(options)
    {}

    public DbSet<Company> Companies { get; set; }
    public DbSet<EmailDomain> EmailDomains { get; set; }
    public DbSet<Phone> Phones { get; set; }
    public DbSet<WorkCenter> WorkCenters { get; set; }
    public DbSet<CompanyUser> CompanyUsers { get; set; }
    public DbSet<EmailInfo> EmailsInfo { get; set; }
    public DbSet<Device> Devices { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<CompanyUser>()
            .HasOne(cu => cu.WorkCenter)
            .WithMany()
            .HasForeignKey(cu => cu.WorkCenterId)
            .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Device>()
           .HasOne(cu => cu.WorkCenter)
           .WithMany()
           .HasForeignKey(cu => cu.WorkCenterId)
           .OnDelete(DeleteBehavior.NoAction);


        modelBuilder.Entity<TableData>().HasData(
            new TableData { Id = "Companies", Name = "Companies", Create = "Create", Read = "Read", Update = "Update", Delete = "Delete", Export = "Export" },
            new TableData { Id = "EmailDomains", Name = "EmailDomains", Create = "Create", Read = "Read", Update = "Update", Delete = "Delete", Export = "Export" },
            new TableData { Id = "Phones", Name = "Phones", Create = "Create", Read = "Read", Update = "Update", Delete = "Delete", Export = "Export" },
            new TableData { Id = "WorkCenters", Name = "WorkCenters", Create = "Create", Read = "Read", Update = "Update", Delete = "Delete", Export = "Export" },
            new TableData { Id = "CompanyUsers", Name = "CompanyUsers", Create = "Create", Read = "Read", Update = "Update", Delete = "Delete", Export = "Export" },
            new TableData { Id = "EmailsInfo", Name = "EmailsInfo", Create = "Create", Read = "Read", Update = "Update", Delete = "Delete", Export = "Export" },
            new TableData { Id = "Devices", Name = "Devices", Create = "Create", Read = "Read", Update = "Update", Delete = "Delete", Export = "Export" }

            );

        modelBuilder.Entity<TableDataPrimaryKey>().HasData(
            new TableDataPrimaryKey { TableId = "Companies", ColumnName = "Id" },
            new TableDataPrimaryKey { TableId = "EmailDomains", ColumnName = "Id" },
            new TableDataPrimaryKey { TableId = "Phones", ColumnName = "Id" },
            new TableDataPrimaryKey { TableId = "WorkCenters", ColumnName = "Id" },
            new TableDataPrimaryKey { TableId = "CompanyUsers", ColumnName = "Id" },
            new TableDataPrimaryKey { TableId = "EmailsInfo", ColumnName = "Id" },
            new TableDataPrimaryKey { TableId = "Devices", ColumnName = "Id" }

            );

        modelBuilder.Entity<TableDataAttributes>().HasData(
            new TableDataAttributes { Id = -1001, TableId = "Companies", Condition = null, ColumnsAffected = "*", AttributeType = "onClick:splitScreenOverlay?CompaniesScreen" },
            new TableDataAttributes { Id = -1002, TableId = "EmailDomains", Condition = null, ColumnsAffected = "*", AttributeType = "onClick:splitScreenOverlay?EmailDomainsScreen" },
            new TableDataAttributes { Id = -1003, TableId = "Phones", Condition = null, ColumnsAffected = "*", AttributeType = "onClick:splitScreenOverlay?PhonesScreen" },
            new TableDataAttributes { Id = -1004, TableId = "WorkCenters", Condition = null, ColumnsAffected = "*", AttributeType = "onClick:splitScreenOverlay?WorkCentersScreen" },
            new TableDataAttributes { Id = -1005, TableId = "CompanyUsers", Condition = null, ColumnsAffected = "*", AttributeType = "onClick:splitScreenOverlay?CompanyUsersScreen" },
            new TableDataAttributes { Id = -1006, TableId = "EmailsInfo", Condition = null, ColumnsAffected = "*", AttributeType = "onClick:splitScreenOverlay?EmailsInfoScreen" },
            new TableDataAttributes { Id = -1007, TableId = "Devices", Condition = null, ColumnsAffected = "*", AttributeType = "onClick:splitScreenOverlay?DevicesScreen" }

            );

        modelBuilder.Entity<TableDataButtons>().HasData(
            new TableDataButtons { TableId = "Companies", ButtonName = "new", Image = "punta.png", OnClick = "splitScreenOverlay?CompaniesScreen" },
            new TableDataButtons { TableId = "EmailDomains", ButtonName = "new", Image = "punta.png", OnClick = "splitScreenOverlay?EmailDomainsScreen" },
            new TableDataButtons { TableId = "Phones", ButtonName = "new", Image = "punta.png", OnClick = "splitScreenOverlay?PhonesScreen" },
            new TableDataButtons { TableId = "WorkCenters", ButtonName = "new", Image = "punta.png", OnClick = "splitScreenOverlay?WorkCentersScreen" },
            new TableDataButtons { TableId = "CompanyUsers", ButtonName = "new", Image = "punta.png", OnClick = "splitScreenOverlay?CompanyUsersScreen" },
            new TableDataButtons { TableId = "EmailsInfo", ButtonName = "new", Image = "punta.png", OnClick = "splitScreenOverlay?EmailsInfoScreen" },
            new TableDataButtons { TableId = "Devices", ButtonName = "new", Image = "punta.png", OnClick = "splitScreenOverlay?DevicesScreen" }
            );

        modelBuilder.Entity<GenericListRecord>().HasData(
            new GenericListRecord { Id = "DepartmentsCompras", Type = GenericListRecordType.SYSTEM, Text = "Compras", Category = "Departments" },
            new GenericListRecord { Id = "DepartmentsContabilidad", Type = GenericListRecordType.SYSTEM, Text = "Contabilidad", Category = "Departments" },
            new GenericListRecord { Id = "DepartmentsDireccion", Type = GenericListRecordType.SYSTEM, Text = "Direccion", Category = "Departments" },
            new GenericListRecord { Id = "DepartmentsRRHH", Type = GenericListRecordType.SYSTEM, Text = "RRHH", Category = "Departments" },

            // Device Types
            new GenericListRecord { Id = "DeviceTypeOrdenador", Type = GenericListRecordType.SYSTEM, Text = "Ordenador", Category = "DeviceType" },
            new GenericListRecord { Id = "DeviceTypePortatil", Type = GenericListRecordType.SYSTEM, Text = "Portatil", Category = "DeviceType" },
            new GenericListRecord { Id = "DeviceTypeNAS", Type = GenericListRecordType.SYSTEM, Text = "NAS", Category = "DeviceType" },

            // Manufacturers
            new GenericListRecord { Id = "ManufacturerHP", Type = GenericListRecordType.SYSTEM, Text = "HP", Category = "Manufacturer" },
            new GenericListRecord { Id = "ManufacturerMicrosoft", Type = GenericListRecordType.SYSTEM, Text = "Microsoft", Category = "Manufacturer" },

            // Operating Systems
            new GenericListRecord { Id = "OperatingSystemLinux", Type = GenericListRecordType.SYSTEM, Text = "Linux", Category = "OperatingSystem" },
            new GenericListRecord { Id = "OperatingSystemWindows7", Type = GenericListRecordType.SYSTEM, Text = "Windows 7", Category = "OperatingSystem" },
            new GenericListRecord { Id = "OperatingSystemWindows10", Type = GenericListRecordType.SYSTEM, Text = "Windows 10", Category = "OperatingSystem" },
            new GenericListRecord { Id = "OperatingSystemWindowsServer2019", Type = GenericListRecordType.SYSTEM, Text = "Windows Server 2019", Category = "OperatingSystem" },
            new GenericListRecord { Id = "OperatingSystemUbuntu", Type = GenericListRecordType.SYSTEM, Text = "Ubuntu", Category = "OperatingSystem" },
            new GenericListRecord { Id = "OperatingSystemMacOS", Type = GenericListRecordType.SYSTEM, Text = "macOS", Category = "OperatingSystem" },
            new GenericListRecord { Id = "OperatingSystemAndroid", Type = GenericListRecordType.SYSTEM, Text = "Android", Category = "OperatingSystem" },
            new GenericListRecord { Id = "OperatingSystemIOS", Type = GenericListRecordType.SYSTEM, Text = "iOS", Category = "OperatingSystem" },

            // Processors
            new GenericListRecord { Id = "ProcessorXeon", Type = GenericListRecordType.SYSTEM, Text = "Xeon", Category = "Processor" },
            new GenericListRecord { Id = "ProcessorIntelI5", Type = GenericListRecordType.SYSTEM, Text = "Intel i5", Category = "Processor" },
            new GenericListRecord { Id = "ProcessorARMv7", Type = GenericListRecordType.SYSTEM, Text = "ARMv7", Category = "Processor" },
            new GenericListRecord { Id = "ProcessorARMv8", Type = GenericListRecordType.SYSTEM, Text = "ARMv8", Category = "Processor" },
            new GenericListRecord { Id = "ProcessorARMv8_2", Type = GenericListRecordType.SYSTEM, Text = "ARMv8.2", Category = "Processor" },
            new GenericListRecord { Id = "ProcessorARMv9", Type = GenericListRecordType.SYSTEM, Text = "ARMv9", Category = "Processor" },

            // RAM Options
            new GenericListRecord { Id = "RAM2GB", Type = GenericListRecordType.SYSTEM, Text = "2 GB", Category = "RAM" },
            new GenericListRecord { Id = "RAM4GB", Type = GenericListRecordType.SYSTEM, Text = "4 GB", Category = "RAM" },
            new GenericListRecord { Id = "RAM8GB", Type = GenericListRecordType.SYSTEM, Text = "8 GB", Category = "RAM" },
            new GenericListRecord { Id = "RAM16GB", Type = GenericListRecordType.SYSTEM, Text = "16 GB", Category = "RAM" },
            new GenericListRecord { Id = "RAM32GB", Type = GenericListRecordType.SYSTEM, Text = "32 GB", Category = "RAM" },
            new GenericListRecord { Id = "RAM64GB", Type = GenericListRecordType.SYSTEM, Text = "64 GB", Category = "RAM" },
            new GenericListRecord { Id = "RAM128GB", Type = GenericListRecordType.SYSTEM, Text = "128 GB", Category = "RAM" },
            new GenericListRecord { Id = "RAM256GB", Type = GenericListRecordType.SYSTEM, Text = "256 GB", Category = "RAM" },
            new GenericListRecord { Id = "RAM512GB", Type = GenericListRecordType.SYSTEM, Text = "512 GB", Category = "RAM" },
            new GenericListRecord { Id = "RAM1TB", Type = GenericListRecordType.SYSTEM, Text = "1 TB", Category = "RAM" },

            // Hard Drive Types
            new GenericListRecord { Id = "HardDriveTypeSSD", Type = GenericListRecordType.SYSTEM, Text = "SSD", Category = "HardDriveType" },
            new GenericListRecord { Id = "HardDriveTypeNVMe", Type = GenericListRecordType.SYSTEM, Text = "NVMe", Category = "HardDriveType" },

            // Suppliers
            new GenericListRecord { Id = "SupplierNutec", Type = GenericListRecordType.SYSTEM, Text = "Nutec", Category = "Supplier" },

            // IP Masks
            new GenericListRecord { Id = "IPMask8", Type = GenericListRecordType.SYSTEM, Text = "8", Category = "IPMask" },
            new GenericListRecord { Id = "IPMask16", Type = GenericListRecordType.SYSTEM, Text = "16", Category = "IPMask" },
            new GenericListRecord { Id = "IPMask24", Type = GenericListRecordType.SYSTEM, Text = "24", Category = "IPMask" },
            new GenericListRecord { Id = "IPMask28", Type = GenericListRecordType.SYSTEM, Text = "28", Category = "IPMask" },
            new GenericListRecord { Id = "IPMask32", Type = GenericListRecordType.SYSTEM, Text = "32", Category = "IPMask" }
            );
    }
}
