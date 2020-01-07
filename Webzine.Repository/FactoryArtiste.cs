using System.Collections.Generic;
using Webzine.Entity;

namespace Webzine.Repository
{
    public static class FactoryArtiste
    {
        public static List<Artiste> Artistes = new List<Artiste>()
            {
                new Artiste(){ IdArtiste = 1, Nom = "PNL", Biographie = "Lorem", Titres = FactoryTitre.Titres },
                new Artiste(){ IdArtiste = 2, Nom = "Damso", Biographie = "Lorem", Titres = FactoryTitre.Titres }
            };
    }
}
