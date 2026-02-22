using Microsoft.EntityFrameworkCore;
using CustomPM.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CustomPmDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")
    ));

var app = builder.Build();

app.MapGet("/projects", async (CustomPmDbContext db) =>
    await db.Projects.ToListAsync());

app.Run();
