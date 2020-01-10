using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Webzine.Entity;
using Webzine.Repository;

namespace Webzine.EntitiesContext
{
    public class LocalDataSeeder : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artiste>().HasData(
                FactoryArtiste.Artistes
            );
            modelBuilder.Entity<Style>().HasData(
                FactoryStyle.Styles
            );
            modelBuilder.Entity<Titre>().HasData(
                FactoryTitre.Titres
            );
            modelBuilder.Entity<Commentaire>().HasData(
                FactoryCommentaire.Commentaires
            );

            
        }
    }
}
