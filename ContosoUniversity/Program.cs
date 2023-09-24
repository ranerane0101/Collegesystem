using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data;
using Microsoft.Extensions.DependencyInjection;


var builder = WebApplication.CreateBuilder(args);

var connectionString = "server=localhost;user=user;password=mysql;database=dotnetdb";

var serverVersion = new MySqlServerVersion(new Version(8, 0, 27));
// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<SchoolContext>(
            dbContextOptions => dbContextOptions
                .UseMySql(connectionString, serverVersion)
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors()
        );


var app = builder.Build();

// Configure the HTTP request pipeline

app.UseAuthorization();

app.MapControllers();

app.Run();