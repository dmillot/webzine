using System;
using System.Collections.Generic;
using Webzine.Entity;

namespace Webzine.EntitiesContext
{
    public static class FactoryArtiste
    {
        public static List<Artiste> Artistes = new List<Artiste>()
            {
                new Artiste(){ IdArtiste = 1, DateNaissance = DateTime.Now, Nom = "PNL", Biographie = "Lorem", IdPays = 1, Pays = new Pays(){ Nom = "France" }, Titres = FactoryTitre.Titres },
                new Artiste(){ IdArtiste = 2, DateNaissance = DateTime.Now, Nom = "Damso", Biographie = "Lorem", IdPays = 2, Pays = new Pays(){ Nom = "Bruxelles" }, Titres = FactoryTitre.Titres }
            };
    }
}
