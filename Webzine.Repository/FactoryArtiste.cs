using System;
using System.Collections.Generic;
using System.Text;
using Webzine.Entity;

namespace Webzine.Repository
{
    public class FactoryArtiste
    {
        public List<Artiste> Artistes;

        public FactoryArtiste()
        {
            this.Artistes = new List<Artiste>()
            {
                new Artiste(){ IdArtiste = 1, Nom = "PNL", Biographie = "Lorem", Titres = new List<Titre>() },
                new Artiste(){ IdArtiste = 2, Nom = "Damso", Biographie = "Lorem", Titres = new List<Titre>() }
            };
        }
    }
}
