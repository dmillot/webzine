﻿using Microsoft.EntityFrameworkCore;
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
            modelBuilder.Entity<Artiste>().ToTable("Artiste");
            modelBuilder.Entity<Titre>().ToTable("Titre");
            modelBuilder.Entity<Commentaire>().ToTable("Commentaire");
            modelBuilder.Entity<Style>().ToTable("Style");

            modelBuilder.Entity<TitreStyle>()
                        .HasKey(x => new { x.IdTitre, x.IdStyle });

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
