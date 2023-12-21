using BackendCore.Lib.Data;
using BackendCore.Lib.Extensions;
using BackendCore.Lib.Models;
using BackendCore.Lib.Services;
using BackendGobiernoIT.Data;

var builder = WebApplication.CreateBuilder(args);
builder.AddBackendCore<ApplicationDbContext, CoreUser, CoreUserManager>(o =>
{
});
var app = builder.Build();
app.ConfigBackendCore();
app.Run();