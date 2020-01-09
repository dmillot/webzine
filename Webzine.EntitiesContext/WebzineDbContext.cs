using Microsoft.EntityFrameworkCore;
using System;
using Webzine.Entity;

namespace Webzine.EntitiesContext
{
    public class WebzineDbContext : DbContext
    {
       DbSet<Artiste> Artistes { get; set; }
       DbSet<Titre> Titres { get; set; }
       DbSet<Commentaire> Commentaires { get; set; }
       DbSet<Style> Styles { get; set; }


    }
}
