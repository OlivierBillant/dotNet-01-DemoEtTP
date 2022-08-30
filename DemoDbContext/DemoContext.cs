namespace DemoDbContext;

using DemoDbContext.Entities;
using Microsoft.EntityFrameworkCore;

internal class DemoContext : DbContext
{
    public DbSet<Personne> Personnes => this.Set<Personne>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=170SE3-9Q365M2;Database=DemoDbContext;User Id=sa;Password=Pa$$w0rd;");

        base.OnConfiguring(optionsBuilder);
    }
}
