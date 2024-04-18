using BackendCore.Lib.Data;
using BackendCore.Lib.Extensions;
using BackendCore.Lib.Libraries.ApplicationDomain;
using BackendCore.Lib.Models;
using BackendCore.Lib.Services;
using BackendGobiernoIT.Data;
using BackendGobiernoIT.Hangfire;
using Hangfire;

var builder = WebApplication.CreateBuilder(args);
builder.AddBackendCore<ApplicationDbContext, CoreUser, CoreUserManager>(o =>
{
});
var app = builder.Build();
app.ConfigBackendCore();
RecurringJob.AddOrUpdate<InboxService>("InboxService", service => service.CheckInbox(), "*/1 * * * *");
app.Run();