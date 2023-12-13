using Microsoft.EntityFrameworkCore;
using TEAChallenge.Data.DataContexts;
using TEAChallenge.Host.ServiceExtensions;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add sql server support
builder.Services.AddDbContext<SchoolContext>(opts => opts.UseSqlServer(
    connectionString, sqlServer => sqlServer.MigrationsAssembly("cbbapi.Data")));

// Add dependency injection from custom extension method
builder.Services.AddDependencyInjection();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();