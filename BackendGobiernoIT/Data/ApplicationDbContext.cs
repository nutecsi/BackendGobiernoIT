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
    public DbSet<Case> Cases { get; set; }
    public DbSet<FollowUp> FollowUps { get; set; }

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

        modelBuilder.Entity<Case>()
           .HasOne(cu => cu.DependantTask)
           .WithMany()
           .HasForeignKey(cu => cu.DependantTaskId)
           .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Case>()
            .Property(b => b.CreationDate)
            .HasDefaultValueSql("GETUTCDATE()");


        modelBuilder.Entity<TableData>().HasData(
            new TableData { Id = "Companies", Name = "Companies", Create = "Create", Read = "Read", Update = "Update", Delete = "Delete", Export = "Export" },
            new TableData { Id = "EmailDomains", Name = "EmailDomains", Create = "Create", Read = "Read", Update = "Update", Delete = "Delete", Export = "Export" },
            new TableData { Id = "Phones", Name = "Phones", Create = "Create", Read = "Read", Update = "Update", Delete = "Delete", Export = "Export" },
            new TableData { Id = "WorkCenters", Name = "WorkCenters", Create = "Create", Read = "Read", Update = "Update", Delete = "Delete", Export = "Export" },
            new TableData { Id = "CompanyUsers", Name = "CompanyUsers", Create = "Create", Read = "Read", Update = "Update", Delete = "Delete", Export = "Export" },
            new TableData { Id = "EmailsInfo", Name = "EmailsInfo", Create = "Create", Read = "Read", Update = "Update", Delete = "Delete", Export = "Export" },
            new TableData { Id = "Devices", Name = "Devices", Create = "Create", Read = "Read", Update = "Update", Delete = "Delete", Export = "Export" },
            new TableData { Id = "FollowUps", Name = "FollowUps", Create = "Create", Read = "Read", Update = "Update", Delete = "Delete", Export = "Export" },
            new TableData { Id = "Cases", Name = "Cases", Create = "Create", Read = "Read", Update = "Update", Delete = "Delete", Export = "Export" }
            );

        modelBuilder.Entity<TableDataPrimaryKey>().HasData(
            new TableDataPrimaryKey { TableId = "Companies", ColumnName = "Id" },
            new TableDataPrimaryKey { TableId = "EmailDomains", ColumnName = "Id" },
            new TableDataPrimaryKey { TableId = "Phones", ColumnName = "Id" },
            new TableDataPrimaryKey { TableId = "WorkCenters", ColumnName = "Id" },
            new TableDataPrimaryKey { TableId = "CompanyUsers", ColumnName = "Id" },
            new TableDataPrimaryKey { TableId = "EmailsInfo", ColumnName = "Id" },
            new TableDataPrimaryKey { TableId = "Devices", ColumnName = "Id" },
            new TableDataPrimaryKey { TableId = "FollowUps", ColumnName = "Id" },
            new TableDataPrimaryKey { TableId = "Cases", ColumnName = "Id" }
            );

        modelBuilder.Entity<TableDataAttributes>().HasData(
            new TableDataAttributes { Id = -1001, TableId = "Companies", Condition = null, ColumnsAffected = "*", AttributeType = "onClick:splitScreenOverlay?CompaniesScreen" },
            new TableDataAttributes { Id = -1002, TableId = "EmailDomains", Condition = null, ColumnsAffected = "*", AttributeType = "onClick:splitScreenOverlay?EmailDomainsScreen" },
            new TableDataAttributes { Id = -1003, TableId = "Phones", Condition = null, ColumnsAffected = "*", AttributeType = "onClick:splitScreenOverlay?PhonesScreen" },
            new TableDataAttributes { Id = -1004, TableId = "WorkCenters", Condition = null, ColumnsAffected = "*", AttributeType = "onClick:splitScreenOverlay?WorkCentersScreen" },
            new TableDataAttributes { Id = -1005, TableId = "CompanyUsers", Condition = null, ColumnsAffected = "*", AttributeType = "onClick:splitScreenOverlay?CompanyUsersScreen" },
            new TableDataAttributes { Id = -1006, TableId = "EmailsInfo", Condition = null, ColumnsAffected = "*", AttributeType = "onClick:splitScreenOverlay?EmailsInfoScreen" },
            new TableDataAttributes { Id = -1007, TableId = "Devices", Condition = null, ColumnsAffected = "*", AttributeType = "onClick:splitScreenOverlay?DevicesScreen" },
            new TableDataAttributes { Id = -1008, TableId = "FollowUps", Condition = null, ColumnsAffected = "*", AttributeType = "onClick:splitScreenOverlay?FollowUpsScreen" },
            new TableDataAttributes { Id = -1009, TableId = "Cases", Condition = null, ColumnsAffected = "*", AttributeType = "onClick:splitScreenOverlay?CasesScreen" }

            );

        modelBuilder.Entity<TableDataButtons>().HasData(
            new TableDataButtons { TableId = "Companies", ButtonName = "new", Image = "punta.png", OnClick = "splitScreenOverlay?CompaniesScreen" },
            new TableDataButtons { TableId = "EmailDomains", ButtonName = "new", Image = "punta.png", OnClick = "splitScreenOverlay?EmailDomainsScreen" },
            new TableDataButtons { TableId = "Phones", ButtonName = "new", Image = "punta.png", OnClick = "splitScreenOverlay?PhonesScreen" },
            new TableDataButtons { TableId = "WorkCenters", ButtonName = "new", Image = "punta.png", OnClick = "splitScreenOverlay?WorkCentersScreen" },
            new TableDataButtons { TableId = "CompanyUsers", ButtonName = "new", Image = "punta.png", OnClick = "splitScreenOverlay?CompanyUsersScreen" },
            new TableDataButtons { TableId = "EmailsInfo", ButtonName = "new", Image = "punta.png", OnClick = "splitScreenOverlay?EmailsInfoScreen" },
            new TableDataButtons { TableId = "Devices", ButtonName = "new", Image = "punta.png", OnClick = "splitScreenOverlay?DevicesScreen" },
            new TableDataButtons { TableId = "FollowUps", ButtonName = "new", Image = "punta.png", OnClick = "splitScreenOverlay?FollowUpsScreen" },
            new TableDataButtons { TableId = "Cases", ButtonName = "new", Image = "punta.png", OnClick = "splitScreenOverlay?CasesScreen" }
            );

        modelBuilder.Entity<Template>().HasData(
            new Template { Name = "FOLLOWUP_TECHNICIAN", Type = TemplateType.EMAIL, Subject="{SUBJECT}", Contents = "<$--ESCRIBE ARRIBA--$> {PREV_CONTENT}", ParametersInfo = "{PREV_CONTENT}, {SUBJECT}", ConnectorName = "NOTIFICATION_EMAIL", Deletable = false },
            new Template { Name = "FOLLOWUP_CLIENT", Type = TemplateType.EMAIL, Subject = "{SUBJECT}", Contents = "{PREV_CONTENT}", ParametersInfo = "{PREV_CONTENT}, {SUBJECT}", ConnectorName = "NOTIFICATION_EMAIL", Deletable = false },
            new Template { Name = "NEW_CASE_CLIENT", Type = TemplateType.EMAIL, Subject = "Nuevo caso {CASE_ID}", Contents = "Se ha creado un nuevo caso {CASE_ID}", ParametersInfo = "{CASE_ID}", ConnectorName = "NOTIFICATION_EMAIL", Deletable = false }

            );

        modelBuilder.Entity<GenericListRecord>().HasData(
            new GenericListRecord { Id = "DepartmentsCompras", Type = GenericListRecordType.SYSTEM, Text = "Compras", Category = "Departments" },
            new GenericListRecord { Id = "DepartmentsContabilidad", Type = GenericListRecordType.SYSTEM, Text = "Contabilidad", Category = "Departments" },
            new GenericListRecord { Id = "DepartmentsDireccion", Type = GenericListRecordType.SYSTEM, Text = "Direccion", Category = "Departments" },
            new GenericListRecord { Id = "DepartmentsRRHH", Type = GenericListRecordType.SYSTEM, Text = "RRHH", Category = "Departments" },

            // CaseStatus
            new GenericListRecord { Id = "CaseStatusNew", Type = GenericListRecordType.SYSTEM, Text = "Nuevo", Category = "CaseStatus" },
            new GenericListRecord { Id = "CaseStatusInProgress", Type = GenericListRecordType.SYSTEM, Text = "En curso", Category = "CaseStatus" },
            new GenericListRecord { Id = "CaseStatusPendingClient", Type = GenericListRecordType.SYSTEM, Text = "Pendiente cliente", Category = "CaseStatus" },
            new GenericListRecord { Id = "CaseStatusPaused", Type = GenericListRecordType.SYSTEM, Text = "Pausada", Category = "CaseStatus" },
            new GenericListRecord { Id = "CaseStatusClosed", Type = GenericListRecordType.SYSTEM, Text = "Cerrado", Category = "CaseStatus" },

            // CaseCategory
            new GenericListRecord { Id = "CaseCategoryConsulta", Type = GenericListRecordType.SYSTEM, Text = "Consulta", Category = "CaseCategory" },
            new GenericListRecord { Id = "CaseCategoryRequest", Type = GenericListRecordType.SYSTEM, Text = "Petición", Category = "CaseCategory" },
            new GenericListRecord { Id = "CaseCategorySecurity", Type = GenericListRecordType.SYSTEM, Text = "Seguridad", Category = "CaseCategory" },
            new GenericListRecord { Id = "CaseCategoryIncidence", Type = GenericListRecordType.SYSTEM, Text = "Incidencia", Category = "CaseCategory" },

            // CasePriority
            new GenericListRecord { Id = "CasePriorityHigh", Type = GenericListRecordType.SYSTEM, Text = "High", Category = "CasePriority" },
            new GenericListRecord { Id = "CasePriorityMid", Type = GenericListRecordType.SYSTEM, Text = "Mid", Category = "CasePriority" },
            new GenericListRecord { Id = "CasePriorityLow", Type = GenericListRecordType.SYSTEM, Text = "Low", Category = "CasePriority" },

            // CaseClassificationTags
            new GenericListRecord { Id = "CaseClassificationTag0", Type = GenericListRecordType.SYSTEM, Text = "0", Category = "CaseClassificationTag" },
            new GenericListRecord { Id = "CaseClassificationTag1", Type = GenericListRecordType.SYSTEM, Text = "1", Category = "CaseClassificationTag" },
            new GenericListRecord { Id = "CaseClassificationTag2", Type = GenericListRecordType.SYSTEM, Text = "2", Category = "CaseClassificationTag" },

            // CaseEntryChannels
            new GenericListRecord { Id = "CaseEntryChannelCall", Type = GenericListRecordType.SYSTEM, Text = "Llamada", Category = "CaseEntryChannel" },
            new GenericListRecord { Id = "CaseEntryChannelWhatsapp", Type = GenericListRecordType.SYSTEM, Text = "Whatsapp", Category = "CaseEntryChannel" },
            new GenericListRecord { Id = "CaseEntryChannelWeb", Type = GenericListRecordType.SYSTEM, Text = "Web", Category = "CaseEntryChannel" },
            new GenericListRecord { Id = "CaseEntryChannelChatBot", Type = GenericListRecordType.SYSTEM, Text = "Chatbot", Category = "CaseEntryChannel" },
            new GenericListRecord { Id = "CaseEntryChannelClientArea", Type = GenericListRecordType.SYSTEM, Text = "Área cliente", Category = "CaseEntryChannel" },
            new GenericListRecord { Id = "CaseEntryChannelEmail", Type = GenericListRecordType.SYSTEM, Text = "Correo electrónico", Category = "CaseEntryChannel" },

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
