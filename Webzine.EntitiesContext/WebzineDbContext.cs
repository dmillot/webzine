using Microsoft.EntityFrameworkCore;
using System;
using Webzine.Entity;


namespace Webzine.EntitiesContext
{
    public class WebzineDbContext : DbContext
    {
       public DbSet<Artiste> Artistes { get; set; }
       public DbSet<Titre> Titres { get; set; }
       public DbSet<Commentaire> Commentaires { get; set; }
       public DbSet<Style> Styles { get; set; }
        public DbSet<TitreStyle> TitresStyles { get; set; }

        public WebzineDbContext(DbContextOptions<WebzineDbContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artiste>().ToTable("Artiste")
                .HasMany<Titre>(a => a.Titres)
                .WithOne(a => a.Artiste)
                .HasForeignKey(a => a.IdArtiste);

            modelBuilder.Entity<Titre>().ToTable("Titre")
                .HasMany<Commentaire>(t => t.Commentaires)
                .WithOne(c => c.Titre)
                .HasForeignKey(r => r.IdTitre);

            modelBuilder.Entity<Titre>()
                .HasOne<Artiste>(t => t.Artiste)
                .WithMany(a => a.Titres)
                .HasForeignKey(t => t.IdArtiste);

            modelBuilder.Entity<Titre>()
                .HasMany(t => t.TitresStyles)
                .WithOne(t=>t.Titre)
                .HasForeignKey(t => t.IdTitre);

            modelBuilder.Entity<Commentaire>().ToTable("Commentaire")
                .HasOne<Titre>(c => c.Titre)
                .WithMany(c => c.Commentaires)
                .HasForeignKey(c => c.IdTitre);

            modelBuilder.Entity<Style>().ToTable("Style")
                .HasMany(s => s.TitresStyles)
                .WithOne(s => s.Style)
                .HasForeignKey(s => s.IdStyle);
                

            modelBuilder.Entity<TitreStyle>()
                        .HasKey(x => new { x.IdTitre, x.IdStyle });

            modelBuilder.Entity<TitreStyle>()
                .HasOne<Style>(s => s.Style)
                .WithMany(s => s.TitresStyles)
                .HasForeignKey(s => s.IdStyle);

            modelBuilder.Entity<TitreStyle>()
                .HasOne<Titre>(t => t.Titre)
                .WithMany(t => t.TitresStyles)
                .HasForeignKey(t => t.IdTitre);

            modelBuilder.Entity<TitreStyle>()
            .HasOne<Titre>(ts => ts.Titre)
            .WithMany(t => t.TitresStyles)
            .HasForeignKey(ts => ts.IdTitre);

            modelBuilder.Entity<TitreStyle>()
                .HasOne<Style>(ts => ts.Style)
                .WithMany(s => s.TitresStyles)
                .HasForeignKey(ts => ts.IdStyle);
        }

    }
}
