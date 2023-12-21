using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BackendGobiernoIT.Migrations
{
    /// <inheritdoc />
    public partial class ProjectSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "__AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK___AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_ApplicationDomains",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ApplicationDomains", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "_Connectors",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Endpoint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatabaseConnectionString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmtpServer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmtpPort = table.Column<int>(type: "int", nullable: true),
                    SmtpUsername = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmtpPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deletable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Connectors", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "_LanguageTranslations",
                columns: table => new
                {
                    key = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    esES = table.Column<string>(name: "es-ES", type: "nvarchar(max)", nullable: true),
                    enUS = table.Column<string>(name: "en-US", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LanguageTranslations", x => x.key);
                });

            migrationBuilder.CreateTable(
                name: "_PermissionsList",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PermissionsList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_SecurityRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false),
                    PwdMinLength = table.Column<int>(type: "int", nullable: false),
                    PwdRequireUppercaseAndLowercase = table.Column<bool>(type: "bit", nullable: false),
                    PwdRequireNumbers = table.Column<bool>(type: "bit", nullable: false),
                    PwdRequireNonAlphanumeric = table.Column<bool>(type: "bit", nullable: false),
                    PwdCaducityDays = table.Column<int>(type: "int", nullable: false),
                    PwdHistorialLength = table.Column<int>(type: "int", nullable: false),
                    LoginBlock = table.Column<int>(type: "int", nullable: false),
                    CanUsePersistentSession = table.Column<bool>(type: "bit", nullable: false),
                    AccessTokenDuration = table.Column<int>(type: "int", nullable: false),
                    RefreshTokenDuration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SecurityRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "_UControlsProperties",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Readonly = table.Column<bool>(type: "bit", nullable: true),
                    Visible = table.Column<bool>(type: "bit", nullable: true),
                    Args = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UControlsProperties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "__AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK___AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK___AspNetRoleClaims___AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "__AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_PermissionTree",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Permission = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ParentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PermissionTree", x => x.Id);
                    table.ForeignKey(
                        name: "FK__PermissionTree__PermissionTree_ParentId",
                        column: x => x.ParentId,
                        principalTable: "_PermissionTree",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__PermissionTree__PermissionsList_Permission",
                        column: x => x.Permission,
                        principalTable: "_PermissionsList",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "_TableData",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultColumns = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Create = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Read = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Update = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Delete = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Export = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TableData", x => x.Id);
                    table.ForeignKey(
                        name: "FK__TableData__PermissionsList_Create",
                        column: x => x.Create,
                        principalTable: "_PermissionsList",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__TableData__PermissionsList_Delete",
                        column: x => x.Delete,
                        principalTable: "_PermissionsList",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__TableData__PermissionsList_Export",
                        column: x => x.Export,
                        principalTable: "_PermissionsList",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__TableData__PermissionsList_Read",
                        column: x => x.Read,
                        principalTable: "_PermissionsList",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__TableData__PermissionsList_Update",
                        column: x => x.Update,
                        principalTable: "_PermissionsList",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "_Groups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkedTableId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Groups", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Groups__TableData_LinkedTableId",
                        column: x => x.LinkedTableId,
                        principalTable: "_TableData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_TableDataAlias",
                columns: table => new
                {
                    TableId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ColumnName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ColumnAlias = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TableDataAlias", x => new { x.TableId, x.ColumnName });
                    table.ForeignKey(
                        name: "FK__TableDataAlias__TableData_TableId",
                        column: x => x.TableId,
                        principalTable: "_TableData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_TableDataAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Condition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColumnsAffected = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttributeType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TableDataAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK__TableDataAttributes__TableData_TableId",
                        column: x => x.TableId,
                        principalTable: "_TableData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_TableDataButtons",
                columns: table => new
                {
                    TableId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ButtonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OnClick = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TableDataButtons", x => x.TableId);
                    table.ForeignKey(
                        name: "FK__TableDataButtons__TableData_TableId",
                        column: x => x.TableId,
                        principalTable: "_TableData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_TableDataPersistentFilters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    TableId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ColumnName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TableDataPersistentFilters", x => new { x.Id, x.TableId });
                    table.ForeignKey(
                        name: "FK__TableDataPersistentFilters__TableData_TableId",
                        column: x => x.TableId,
                        principalTable: "_TableData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_TableDataPrimaryKeys",
                columns: table => new
                {
                    TableId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ColumnName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TableDataPrimaryKeys", x => new { x.TableId, x.ColumnName });
                    table.ForeignKey(
                        name: "FK__TableDataPrimaryKeys__TableData_TableId",
                        column: x => x.TableId,
                        principalTable: "_TableData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_TableDataValidations",
                columns: table => new
                {
                    TableId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConditionName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OnFalseMessage = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ExecutableExpression = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TableDataValidations", x => new { x.TableId, x.ConditionName });
                    table.ForeignKey(
                        name: "FK__TableDataValidations__LanguageTranslations_OnFalseMessage",
                        column: x => x.OnFalseMessage,
                        principalTable: "_LanguageTranslations",
                        principalColumn: "key",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__TableDataValidations__TableData_TableId",
                        column: x => x.TableId,
                        principalTable: "_TableData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "__AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK___AspNetUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "__AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK___AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "__AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK___AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK___AspNetUserRoles___AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "__AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "__AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsExternal = table.Column<bool>(type: "bit", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DisableDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PwdCaducityDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SecurityRole = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surnames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsResource = table.Column<bool>(type: "bit", nullable: false),
                    ResourceTypeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK___AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK___AspNetUsers__SecurityRoles_SecurityRole",
                        column: x => x.SecurityRole,
                        principalTable: "_SecurityRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "__AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK___AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK___AspNetUserTokens___AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "__AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_ActivityLog",
                columns: table => new
                {
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    uuid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SourceIp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Request = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReturnRequestCode = table.Column<int>(type: "int", nullable: true),
                    ReturnRequestDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ActivityLog", x => new { x.Date, x.uuid });
                    table.ForeignKey(
                        name: "FK__ActivityLog___AspNetUsers_uuid",
                        column: x => x.uuid,
                        principalTable: "__AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_FileDescriptors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatorUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CaducityDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpectedDeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Views = table.Column<long>(type: "bigint", nullable: false),
                    LastViewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastViewUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__FileDescriptors", x => x.Id);
                    table.ForeignKey(
                        name: "FK__FileDescriptors__Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "_Groups",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__FileDescriptors___AspNetUsers_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "__AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__FileDescriptors___AspNetUsers_LastViewUserId",
                        column: x => x.LastViewUserId,
                        principalTable: "__AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "_PasswordRecoveryCodes",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PasswordRecoveryCodes", x => new { x.Code, x.UserId });
                    table.ForeignKey(
                        name: "FK__PasswordRecoveryCodes___AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "__AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_TableDataUsersConfig",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TableId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ViewName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ColumnOptions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SortOptions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FilterOptions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComplexFilters = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TableDataUsersConfig", x => new { x.UserId, x.TableId, x.ViewName });
                    table.ForeignKey(
                        name: "FK__TableDataUsersConfig__TableData_TableId",
                        column: x => x.TableId,
                        principalTable: "_TableData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__TableDataUsersConfig___AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "__AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_UserApplicationDomains",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ApplicationDomainId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserApplicationDomains", x => new { x.UserId, x.ApplicationDomainId });
                    table.ForeignKey(
                        name: "FK__UserApplicationDomains__ApplicationDomains_ApplicationDomainId",
                        column: x => x.ApplicationDomainId,
                        principalTable: "_ApplicationDomains",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__UserApplicationDomains___AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "__AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_UserDevices",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DeviceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    refreshToken = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserDevices", x => x.Id);
                    table.ForeignKey(
                        name: "FK__UserDevices___AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "__AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_UserPasswordHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserPasswordHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK__UserPasswordHistory___AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "__AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_Files",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<int>(type: "int", nullable: false),
                    Route = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsHistorical = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Files", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Files__FileDescriptors_DescriptorId",
                        column: x => x.DescriptorId,
                        principalTable: "_FileDescriptors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_GenericLists",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<int>(type: "int", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TerminationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AttachedFileDescriptorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__GenericLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK__GenericLists__FileDescriptors_AttachedFileDescriptorId",
                        column: x => x.AttachedFileDescriptorId,
                        principalTable: "_FileDescriptors",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "_NavbarNodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    to = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Permission = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    parent = table.Column<int>(type: "int", nullable: true),
                    VTableId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    args = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeleteClaimId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NavbarNodes", x => x.Id);
                    table.ForeignKey(
                        name: "FK__NavbarNodes__GenericLists_Position",
                        column: x => x.Position,
                        principalTable: "_GenericLists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__NavbarNodes__GenericLists_Type",
                        column: x => x.Type,
                        principalTable: "_GenericLists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__NavbarNodes__NavbarNodes_parent",
                        column: x => x.parent,
                        principalTable: "_NavbarNodes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__NavbarNodes__PermissionsList_DeleteClaimId",
                        column: x => x.DeleteClaimId,
                        principalTable: "_PermissionsList",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__NavbarNodes__TableData_VTableId",
                        column: x => x.VTableId,
                        principalTable: "_TableData",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "_Templates",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DeactivationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Observations = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParametersInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConnectorName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Deletable = table.Column<bool>(type: "bit", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Templates", x => x.Name);
                    table.ForeignKey(
                        name: "FK__Templates__Connectors_ConnectorName",
                        column: x => x.ConnectorName,
                        principalTable: "_Connectors",
                        principalColumn: "Name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__Templates__GenericLists_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "_GenericLists",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Templates__Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "_Groups",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "_Connectors",
                columns: new[] { "Name", "DatabaseConnectionString", "Deletable", "Endpoint", "SmtpPassword", "SmtpPort", "SmtpServer", "SmtpUsername", "Type" },
                values: new object[] { "NOTIFICATION_EMAIL", null, false, null, "Fer2023$", 587, "smtp.office365.com", "hola@nutec.cloud", 1 });

            migrationBuilder.InsertData(
                table: "_GenericLists",
                columns: new[] { "Id", "AttachedFileDescriptorId", "Category", "Color", "Description", "Position", "TerminationDate", "Text", "Type" },
                values: new object[,]
                {
                    { "Alquiler", null, "PropertyModality", null, null, null, null, "Alquiler", 0 },
                    { "API1", null, "APIs", null, null, null, null, "Ejemplo API1", 0 },
                    { "API2", null, "APIs", null, null, null, null, "Ejemplo API2", 0 },
                    { "API3", null, "APIs", null, null, null, null, "Ejemplo API3", 0 },
                    { "BusinessC", null, "BusinessType", null, null, null, null, "Empresa Colectiva", 0 },
                    { "BusinessL", null, "BusinessType", null, null, null, null, "Empresa Limitada", 0 },
                    { "BusinessU", null, "BusinessType", null, null, null, null, "Empresa Unipersonal", 0 },
                    { "Caracteristicas1", null, "ClientFeatures", null, null, null, null, "Caracteristicas1", 0 },
                    { "Caracteristicas2", null, "ClientFeatures", null, null, null, null, "Caracteristicas2", 0 },
                    { "ClientD", null, "ClientsType", null, null, null, null, "Cliente de Descuentos", 0 },
                    { "ClientI", null, "ClientsType", null, null, null, null, "Cliente Impulsivo", 0 },
                    { "ClientN", null, "ClientsType", null, null, null, null, "Cliente Nuevo", 0 },
                    { "ClientOriginFacebook", null, "ClientOriginType", null, null, null, null, "Facebook", 0 },
                    { "ClientOriginInstagram", null, "ClientOriginType", null, null, null, null, "Instagram", 0 },
                    { "ClientOriginLinkedIn", null, "ClientOriginType", null, null, null, null, "LinkedIn", 0 },
                    { "ClientP", null, "ClientsType", null, null, null, null, "Cliente Potencial", 0 },
                    { "ClientS", null, "ClientsType", null, null, null, null, "Cliente Satisfecho", 0 },
                    { "CountryPhoneNumberCodeBR", null, "CountryPhoneNumberCode", null, null, null, null, "+55", 0 },
                    { "CountryPhoneNumberCodeCN", null, "CountryPhoneNumberCode", null, null, null, null, "+86", 0 },
                    { "CountryPhoneNumberCodeDE", null, "CountryPhoneNumberCode", null, null, null, null, "+49", 0 },
                    { "CountryPhoneNumberCodeES", null, "CountryPhoneNumberCode", null, null, null, null, "+34", 0 },
                    { "CountryPhoneNumberCodeFR", null, "CountryPhoneNumberCode", null, null, null, null, "+33", 0 },
                    { "CountryPhoneNumberCodeIT", null, "CountryPhoneNumberCode", null, null, null, null, "+39", 0 },
                    { "CountryPhoneNumberCodeUK", null, "CountryPhoneNumberCode", null, null, null, null, "+44", 0 },
                    { "DocumentTypeDNI", null, "DocumentType", null, null, null, null, "DNI", 0 },
                    { "DocumentTypeNIE", null, "DocumentType", null, null, null, null, "NIE", 0 },
                    { "DocumentTypeNIF", null, "DocumentType", null, null, null, null, "NIF", 0 },
                    { "ElementL0", null, "NavbarNodeType", null, null, null, null, "ElementL0", 0 },
                    { "ElementL1", null, "NavbarNodeType", null, null, null, null, "ElementL1", 0 },
                    { "ElementT0", null, "NavbarNodeType", null, null, null, null, "ElementT0", 0 },
                    { "EmissEffA", null, "EmissionEfficiency", null, null, null, null, "EmissionA", 0 },
                    { "EmissEffB", null, "EmissionEfficiency", null, null, null, null, "EmissionB", 0 },
                    { "EnergEffA+", null, "EnergeticEfficiency", null, null, null, null, "A+", 0 },
                    { "EnergEffA++", null, "EnergeticEfficiency", null, null, null, null, "A++", 0 },
                    { "EnergEffB", null, "EnergeticEfficiency", null, null, null, null, "B", 0 },
                    { "EnergEffC", null, "EnergeticEfficiency", null, null, null, null, "C", 0 },
                    { "EnergEffD", null, "EnergeticEfficiency", null, null, null, null, "D", 0 },
                    { "EnergEffE", null, "EnergeticEfficiency", null, null, null, null, "E", 0 },
                    { "EnergEffF", null, "EnergeticEfficiency", null, null, null, null, "F", 0 },
                    { "EnergEffG", null, "EnergeticEfficiency", null, null, null, null, "G", 0 },
                    { "EstadoA", null, "PropertyCondition", null, null, null, null, "Alquilado", 0 },
                    { "EstadoB", null, "EstadoType", null, null, null, null, "Bueno", 0 },
                    { "EstadoC", null, "PropertyCondition", null, null, null, null, "Cesión", 0 },
                    { "EstadoD", null, "PropertyCondition", null, null, null, null, "Disponible", 0 },
                    { "EstadoEC", null, "PropertyCondition", null, null, null, null, "Exento de contrato", 0 },
                    { "EstadoEN", null, "PropertyCondition", null, null, null, null, "En captación", 0 },
                    { "EstadoM", null, "EstadoType", null, null, null, null, "Malo", 0 },
                    { "EstadoMB", null, "EstadoType", null, null, null, null, "Muy bueno", 0 },
                    { "EstadoMM", null, "EstadoType", null, null, null, null, "Muy malo", 0 },
                    { "EstadoND", null, "PropertyCondition", null, null, null, null, "No disponible", 0 },
                    { "EstadoR", null, "PropertyCondition", null, null, null, null, "Reservado", 0 },
                    { "FeatureN", null, "PropertyFeatures", null, null, null, null, "Nublado", 0 },
                    { "FeatureS", null, "PropertyFeatures", null, null, null, null, "Soleado", 0 },
                    { "IconA", null, "PropertyIcon", null, null, null, null, "IconoA", 0 },
                    { "IconB", null, "PropertyIcon", null, null, null, null, "IconoB", 0 },
                    { "L0", null, "NavbarNodeType", null, null, null, null, "L0", 0 },
                    { "L0Position", null, "NavbarNodePosition", null, null, null, null, "L0", 0 },
                    { "L1", null, "NavbarNodeType", null, null, null, null, "L1", 0 },
                    { "L1Position", null, "NavbarNodePosition", null, null, null, null, "L1", 0 },
                    { "Label1", null, "ClientLabel", null, null, null, null, "Etiqueta1", 0 },
                    { "Label2", null, "ClientLabel", null, null, null, null, "Etiqueta2", 0 },
                    { "LangCAT", null, "ISO639-2", null, null, null, null, "Catalan", 0 },
                    { "LangSPA", null, "ISO639-2", null, null, null, null, "Spanish", 0 },
                    { "LBottom", null, "NavbarNodePosition", null, null, null, null, "LBottom", 0 },
                    { "Legal", null, "PropertyLegalRenta", null, null, null, null, "LIB - Renta Libre", 0 },
                    { "LegalClassifEU", null, "LegalClassifType", null, null, null, null, "Empresa Unipersonal", 0 },
                    { "LegalClassifSA", null, "LegalClassifType", null, null, null, null, "Sociedad Anonimas", 0 },
                    { "LegalClassifSC", null, "LegalClassifType", null, null, null, null, "Sociedad Colectiva", 0 },
                    { "LegalClassifSL", null, "LegalClassifType", null, null, null, null, "Sociedad de responsabilidad limitada", 0 },
                    { "Local", null, "PropertyType", null, null, null, null, "Local", 0 },
                    { "LTop", null, "NavbarNodePosition", null, null, null, null, "LTop", 0 },
                    { "Me", null, "NavbarNodeType", null, null, null, null, "Me", 0 },
                    { "MePosition", null, "NavbarNodePosition", null, null, null, null, "Me", 0 },
                    { "Oficina", null, "PropertyType", null, null, null, null, "Oficina", 0 },
                    { "Others", null, "DirectionCategory", null, null, null, null, "Otros", 0 },
                    { "Otros", null, "PropertyType", null, null, null, null, "Otro", 0 },
                    { "PaisA", null, "Country", null, null, null, null, "España", 0 },
                    { "PaisB", null, "Country", null, null, null, null, "Francia", 0 },
                    { "Parking", null, "PropertyType", null, null, null, null, "Parking", 0 },
                    { "Parking+Trastero", null, "PropertyType", null, null, null, null, "Parking + trastero", 0 },
                    { "ParkingPequeño", null, "PropertyType", null, null, null, null, "Parking pequeño", 0 },
                    { "PeriodoA", null, "PeriodoIBI", null, null, null, null, "Anual", 0 },
                    { "PeriodoM", null, "PeriodoIBI", null, null, null, null, "Mensual", 0 },
                    { "PeriodoS", null, "PeriodoIBI", null, null, null, null, "Semanal", 0 },
                    { "PeriodoT", null, "PeriodoIBI", null, null, null, null, "Trimestral", 0 },
                    { "Pers", null, "DirectionCategory", null, null, null, null, "Personal", 0 },
                    { "Piso", null, "PropertyType", null, null, null, null, "Piso compartido", 0 },
                    { "PobA", null, "DirectionPoblacion", null, null, null, null, "PoblaciónA", 0 },
                    { "PobB", null, "DirectionPoblacion", null, null, null, null, "PoblaciónB", 0 },
                    { "Prof", null, "DirectionCategory", null, null, null, null, "Profesional", 0 },
                    { "PromotionA", null, "Promotions", null, null, null, null, "PromotionA", 0 },
                    { "PromotionB", null, "Promotions", null, null, null, null, "PromotionB", 0 },
                    { "ProvA", null, "DirectionProvincia", null, null, null, null, "ProvinceA", 0 },
                    { "ProvB", null, "DirectionProvincia", null, null, null, null, "ProvinceB", 0 },
                    { "Renta", null, "PropertyLegalRenta", null, null, null, null, "VPO - Plan anterior a 1992", 0 },
                    { "RolCoordinador", null, "ContactRole", null, null, null, null, "Coordinador", 0 },
                    { "RolEspecialista", null, "ContactRole", null, null, null, null, "Especialista", 0 },
                    { "RolInvestigador", null, "ContactRole", null, null, null, null, "Investigador", 0 },
                    { "Rotulo", null, "PropertyType", null, null, null, null, "Rótulo", 0 },
                    { "Sotano", null, "PropertyType", null, null, null, null, "Sótano", 0 },
                    { "TGroup", null, "NavbarNodePosition", null, null, null, null, "TGroup", 0 },
                    { "TipoA", null, "DirectionVia", null, null, null, null, "ViaA", 0 },
                    { "TipoB", null, "DirectionVia", null, null, null, null, "ViaB", 0 },
                    { "TopologyFinC", null, "FincaTopology", null, null, null, null, "Casa", 0 },
                    { "TopologyFinP", null, "FincaTopology", null, null, null, null, "Piso", 0 },
                    { "Traspaso", null, "PropertyModality", null, null, null, null, "Traspaso", 0 },
                    { "Trastero", null, "PropertyType", null, null, null, null, "Trastero", 0 },
                    { "UsageU", null, "PropertyUsage", null, null, null, null, "General", 0 },
                    { "Venta", null, "PropertyModality", null, null, null, null, "Venta", 0 },
                    { "VentaAlquiler", null, "PropertyModality", null, null, null, null, "Venta y alquiler", 0 },
                    { "Vivienda", null, "PropertyType", null, null, null, null, "Vivienda", 0 },
                    { "ZonaA", null, "PropertyZone", null, null, null, null, "Alta", 0 },
                    { "ZonaB", null, "PropertyZone", null, null, null, null, "Baja", 0 },
                    { "ZonaM", null, "PropertyZone", null, null, null, null, "Media", 0 }
                });

            migrationBuilder.InsertData(
                table: "_PermissionsList",
                column: "Id",
                values: new object[]
                {
                    "Create",
                    "Delete",
                    "Export",
                    "Read",
                    "Update"
                });

            migrationBuilder.InsertData(
                table: "_SecurityRoles",
                columns: new[] { "Id", "AccessTokenDuration", "CanUsePersistentSession", "IsDefault", "LoginBlock", "Name", "PwdCaducityDays", "PwdHistorialLength", "PwdMinLength", "PwdRequireNonAlphanumeric", "PwdRequireNumbers", "PwdRequireUppercaseAndLowercase", "RefreshTokenDuration" },
                values: new object[] { -1, 360, true, true, 5, "Default", 365, 5, 5, false, false, false, 99999 });

            migrationBuilder.InsertData(
                table: "__AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0", null, "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "_TableData",
                columns: new[] { "Id", "Create", "DefaultColumns", "Delete", "Export", "Name", "Read", "Update" },
                values: new object[,]
                {
                    { "ActivityLog", "Create", null, "Delete", "Export", "_ActivityLog", "Read", "Update" },
                    { "Connectors", "Create", null, "Delete", "Export", "_Connectors", "Read", "Update" },
                    { "FileDescriptors", "Create", null, "Delete", "Export", "_FileDescriptors", "Read", "Update" },
                    { "Files", "Create", null, "Delete", "Export", "_Files", "Read", "Update" },
                    { "GenericLists", "Create", null, "Delete", "Export", "_GenericLists", "Read", "Update" },
                    { "Groups", "Create", null, "Delete", "Export", "_Groups", "Read", "Update" },
                    { "NavbarNodes", "Create", null, "Delete", "Export", "_NavbarNodes", "Read", "Update" },
                    { "Roles", "Create", null, "Delete", "Export", "__AspNetRoles", "Read", "Update" },
                    { "SecurityRoles", "Create", null, "Delete", "Export", "_SecurityRoles", "Read", "Update" },
                    { "TableData", "Create", null, "Delete", "Export", "_TableData", "Read", "Update" },
                    { "TableDataAlias", "Create", null, "Delete", "Export", "_TableDataAlias", "Read", "Update" },
                    { "TableDataAttributes", "Create", null, "Delete", "Export", "_TableDataAttributes", "Read", "Update" },
                    { "TableDataButtons", "Create", null, "Delete", "Export", "_TableDataButtons", "Read", "Update" },
                    { "TableDataPrimaryKeys", "Create", null, "Delete", "Export", "_TableDataPrimaryKeys", "Read", "Update" },
                    { "Templates", "Create", null, "Delete", "Export", "_Templates", "Read", "Update" },
                    { "UserRoles", "Create", null, "Delete", "Export", "__AspNetUserRoles", "Read", "Update" },
                    { "Users", "Create", null, "Delete", "Export", "__AspNetUsers", "Read", "Update" },
                    { "UserTokens", "Create", null, "Delete", "Export", "__AspNetUserTokens", "Read", "Update" }
                });

            migrationBuilder.InsertData(
                table: "_Templates",
                columns: new[] { "Name", "CategoryId", "ConnectorName", "Contents", "DeactivationDate", "Deletable", "GroupId", "Observations", "ParametersInfo", "Subject", "Type" },
                values: new object[,]
                {
                    { "PASSWORD_CHANGE_CONFIRMATION", null, "NOTIFICATION_EMAIL", "", null, false, null, null, "", null, 1 },
                    { "PASSWORD_RECOVERY", null, "NOTIFICATION_EMAIL", "{RECOVERY_CODE}", null, false, null, null, "{RECOVERY_CODE}", null, 1 }
                });

            migrationBuilder.InsertData(
                table: "_TableDataAttributes",
                columns: new[] { "Id", "AttributeType", "ColumnsAffected", "Condition", "TableId" },
                values: new object[,]
                {
                    { -7, "onClick:splitScreenOverlay?ConnectorsScreen", "*", null, "Connectors" },
                    { -6, "onClick:splitScreenOverlay?TemplatesScreen", "*", null, "Templates" },
                    { -5, "onClick:splitScreenOverlay?SecurityRolesScreen", "*", null, "SecurityRoles" },
                    { -4, "onClick:splitScreenOverlay?RolesScreen", "*", null, "Roles" },
                    { -3, "onClick:splitScreenOverlay?UserScreen", "*", null, "Users" },
                    { -2, "onClick:splitScreenOverlay?GenericListsScreen", "*", null, "GenericLists" },
                    { -1, "onClick:splitScreenOverlay?NavbarEditorScreen", "*", null, "NavbarNodes" }
                });

            migrationBuilder.InsertData(
                table: "_TableDataButtons",
                columns: new[] { "TableId", "ButtonName", "Image", "OnClick" },
                values: new object[,]
                {
                    { "Connectors", "new", "punta.png", "splitScreenOverlay?ConnectorsScreen" },
                    { "GenericLists", "new", "punta.png", "splitScreenOverlay?GenericListsScreen" },
                    { "NavbarNodes", "new", "punta.png", "splitScreenOverlay?NavbarEditorScreen" },
                    { "Roles", "new", "punta.png", "splitScreenOverlay?RolesScreen" },
                    { "SecurityRoles", "new", "punta.png", "splitScreenOverlay?SecurityRolesScreen" },
                    { "Templates", "new", "punta.png", "splitScreenOverlay?TemplatesScreen" },
                    { "Users", "new", "punta.png", "splitScreenOverlay?UserScreen" }
                });

            migrationBuilder.InsertData(
                table: "_TableDataPrimaryKeys",
                columns: new[] { "ColumnName", "TableId" },
                values: new object[,]
                {
                    { "Date", "ActivityLog" },
                    { "uuid", "ActivityLog" },
                    { "Name", "Connectors" },
                    { "Id", "FileDescriptors" },
                    { "Id", "Files" },
                    { "Id", "GenericLists" },
                    { "Id", "Groups" },
                    { "Id", "NavbarNodes" },
                    { "Id", "Roles" },
                    { "Id", "SecurityRoles" },
                    { "Id", "TableData" },
                    { "ColumnName", "TableDataAlias" },
                    { "Id", "TableDataAlias" },
                    { "Id", "TableDataAttributes" },
                    { "Id", "TableDataButtons" },
                    { "ColumnName", "TableDataPrimaryKeys" },
                    { "Id", "TableDataPrimaryKeys" },
                    { "Name", "Templates" },
                    { "UserId", "UserRoles" },
                    { "Id", "Users" },
                    { "LoginProvider", "UserTokens" },
                    { "Name", "UserTokens" },
                    { "UserId", "UserTokens" }
                });

            migrationBuilder.CreateIndex(
                name: "IX___AspNetRoleClaims_RoleId",
                table: "__AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "__AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX___AspNetUserClaims_UserId",
                table: "__AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX___AspNetUserLogins_UserId",
                table: "__AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX___AspNetUserRoles_RoleId",
                table: "__AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "__AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX___AspNetUsers_ResourceTypeId",
                table: "__AspNetUsers",
                column: "ResourceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX___AspNetUsers_SecurityRole",
                table: "__AspNetUsers",
                column: "SecurityRole");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "__AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX__ActivityLog_uuid",
                table: "_ActivityLog",
                column: "uuid");

            migrationBuilder.CreateIndex(
                name: "IX__FileDescriptors_CreatorUserId",
                table: "_FileDescriptors",
                column: "CreatorUserId");

            migrationBuilder.CreateIndex(
                name: "IX__FileDescriptors_GroupId",
                table: "_FileDescriptors",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX__FileDescriptors_LastViewUserId",
                table: "_FileDescriptors",
                column: "LastViewUserId");

            migrationBuilder.CreateIndex(
                name: "IX__Files_DescriptorId",
                table: "_Files",
                column: "DescriptorId");

            migrationBuilder.CreateIndex(
                name: "IX__GenericLists_AttachedFileDescriptorId",
                table: "_GenericLists",
                column: "AttachedFileDescriptorId");

            migrationBuilder.CreateIndex(
                name: "IX__Groups_LinkedTableId",
                table: "_Groups",
                column: "LinkedTableId");

            migrationBuilder.CreateIndex(
                name: "IX__NavbarNodes_DeleteClaimId",
                table: "_NavbarNodes",
                column: "DeleteClaimId");

            migrationBuilder.CreateIndex(
                name: "IX__NavbarNodes_parent",
                table: "_NavbarNodes",
                column: "parent");

            migrationBuilder.CreateIndex(
                name: "IX__NavbarNodes_Position",
                table: "_NavbarNodes",
                column: "Position");

            migrationBuilder.CreateIndex(
                name: "IX__NavbarNodes_Type",
                table: "_NavbarNodes",
                column: "Type");

            migrationBuilder.CreateIndex(
                name: "IX__NavbarNodes_VTableId",
                table: "_NavbarNodes",
                column: "VTableId");

            migrationBuilder.CreateIndex(
                name: "IX__PasswordRecoveryCodes_UserId",
                table: "_PasswordRecoveryCodes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX__PermissionTree_ParentId",
                table: "_PermissionTree",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX__PermissionTree_Permission",
                table: "_PermissionTree",
                column: "Permission");

            migrationBuilder.CreateIndex(
                name: "IX__TableData_Create",
                table: "_TableData",
                column: "Create");

            migrationBuilder.CreateIndex(
                name: "IX__TableData_Delete",
                table: "_TableData",
                column: "Delete");

            migrationBuilder.CreateIndex(
                name: "IX__TableData_Export",
                table: "_TableData",
                column: "Export");

            migrationBuilder.CreateIndex(
                name: "IX__TableData_Read",
                table: "_TableData",
                column: "Read");

            migrationBuilder.CreateIndex(
                name: "IX__TableData_Update",
                table: "_TableData",
                column: "Update");

            migrationBuilder.CreateIndex(
                name: "IX__TableDataAlias_ColumnAlias",
                table: "_TableDataAlias",
                column: "ColumnAlias",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__TableDataAttributes_TableId",
                table: "_TableDataAttributes",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX__TableDataPersistentFilters_TableId",
                table: "_TableDataPersistentFilters",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX__TableDataUsersConfig_TableId",
                table: "_TableDataUsersConfig",
                column: "TableId");

            migrationBuilder.CreateIndex(
                name: "IX__TableDataValidations_OnFalseMessage",
                table: "_TableDataValidations",
                column: "OnFalseMessage");

            migrationBuilder.CreateIndex(
                name: "IX__Templates_CategoryId",
                table: "_Templates",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX__Templates_ConnectorName",
                table: "_Templates",
                column: "ConnectorName");

            migrationBuilder.CreateIndex(
                name: "IX__Templates_GroupId",
                table: "_Templates",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX__UserApplicationDomains_ApplicationDomainId",
                table: "_UserApplicationDomains",
                column: "ApplicationDomainId");

            migrationBuilder.CreateIndex(
                name: "IX__UserPasswordHistory_UserId",
                table: "_UserPasswordHistory",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK___AspNetUserClaims___AspNetUsers_UserId",
                table: "__AspNetUserClaims",
                column: "UserId",
                principalTable: "__AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK___AspNetUserLogins___AspNetUsers_UserId",
                table: "__AspNetUserLogins",
                column: "UserId",
                principalTable: "__AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK___AspNetUserRoles___AspNetUsers_UserId",
                table: "__AspNetUserRoles",
                column: "UserId",
                principalTable: "__AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK___AspNetUsers__GenericLists_ResourceTypeId",
                table: "__AspNetUsers",
                column: "ResourceTypeId",
                principalTable: "_GenericLists",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__FileDescriptors___AspNetUsers_CreatorUserId",
                table: "_FileDescriptors");

            migrationBuilder.DropForeignKey(
                name: "FK__FileDescriptors___AspNetUsers_LastViewUserId",
                table: "_FileDescriptors");

            migrationBuilder.DropTable(
                name: "__AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "__AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "__AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "__AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "__AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "_ActivityLog");

            migrationBuilder.DropTable(
                name: "_Files");

            migrationBuilder.DropTable(
                name: "_NavbarNodes");

            migrationBuilder.DropTable(
                name: "_PasswordRecoveryCodes");

            migrationBuilder.DropTable(
                name: "_PermissionTree");

            migrationBuilder.DropTable(
                name: "_TableDataAlias");

            migrationBuilder.DropTable(
                name: "_TableDataAttributes");

            migrationBuilder.DropTable(
                name: "_TableDataButtons");

            migrationBuilder.DropTable(
                name: "_TableDataPersistentFilters");

            migrationBuilder.DropTable(
                name: "_TableDataPrimaryKeys");

            migrationBuilder.DropTable(
                name: "_TableDataUsersConfig");

            migrationBuilder.DropTable(
                name: "_TableDataValidations");

            migrationBuilder.DropTable(
                name: "_Templates");

            migrationBuilder.DropTable(
                name: "_UControlsProperties");

            migrationBuilder.DropTable(
                name: "_UserApplicationDomains");

            migrationBuilder.DropTable(
                name: "_UserDevices");

            migrationBuilder.DropTable(
                name: "_UserPasswordHistory");

            migrationBuilder.DropTable(
                name: "__AspNetRoles");

            migrationBuilder.DropTable(
                name: "_LanguageTranslations");

            migrationBuilder.DropTable(
                name: "_Connectors");

            migrationBuilder.DropTable(
                name: "_ApplicationDomains");

            migrationBuilder.DropTable(
                name: "__AspNetUsers");

            migrationBuilder.DropTable(
                name: "_GenericLists");

            migrationBuilder.DropTable(
                name: "_SecurityRoles");

            migrationBuilder.DropTable(
                name: "_FileDescriptors");

            migrationBuilder.DropTable(
                name: "_Groups");

            migrationBuilder.DropTable(
                name: "_TableData");

            migrationBuilder.DropTable(
                name: "_PermissionsList");
        }
    }
}
