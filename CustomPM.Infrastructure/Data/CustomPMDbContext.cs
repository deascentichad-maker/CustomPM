using Microsoft.EntityFrameworkCore;
using CustomPM.Domain.Entities;

namespace CustomPM.Infrastructure.Data;

public class CustomPmDbContext : DbContext
{
    public CustomPmDbContext(DbContextOptions<CustomPmDbContext> options)
        : base(options)
    {
    }

    public DbSet<Project> Projects => Set<Project>();
}