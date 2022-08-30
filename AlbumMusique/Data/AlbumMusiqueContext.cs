using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AlbumMusique.BO;

namespace AlbumMusique.Data
{
    public class AlbumMusiqueContext : DbContext
    {
        public AlbumMusiqueContext (DbContextOptions<AlbumMusiqueContext> options)
            : base(options)
        {
        }

        public DbSet<AlbumMusique.BO.Album> Album { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().Ignore(a => a.NombreDePistes);
            
            modelBuilder.Entity<Album>().HasMany(a => a.Pistes).WithOne();

            modelBuilder.Entity<Album>().HasMany(a => a.Artistes).WithMany(ar => ar.Albums);

            base.OnModelCreating(modelBuilder);
        }
    }
}
