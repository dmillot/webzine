using System;
using System.Collections.Generic;
using System.Text;
using Webzine.Entity;

namespace Webzine.EntitiesContext
{
    public static class FactoryPays
    {
        public static List<Pays> Pays = new List<Pays>()
            {
                new Pays() { IdPays = 1, Nom = "Allemagne", Artistes = new List<Artiste>() },
                new Pays() { IdPays = 2, Nom = "Angleterre", Artistes = new List<Artiste>() },
                new Pays() { IdPays = 3, Nom = "Etats-Unis", Artistes = new List<Artiste>() },
                new Pays() { IdPays = 4, Nom = "Japon", Artistes = new List<Artiste>() },
                new Pays() { IdPays = 5, Nom = "Russie", Artistes = new List<Artiste>() },
            };
    }
}
