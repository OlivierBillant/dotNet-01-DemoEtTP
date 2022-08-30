namespace DemoLoading;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class LoadingContext : DbContext
{
    public DbSet<Personne> Personnes => this.Set<Personne>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=170SE3-9Q365M2;Database=DemoLoading;User Id=sa;Password=Pa$$w0rd;");

        base.OnConfiguring(optionsBuilder);
    }

}
