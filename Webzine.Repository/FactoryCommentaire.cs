using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Webzine.Entity;

namespace Webzine.Repository
{
    public static class FactoryCommentaire
    {
        public static List<Commentaire> Commentaires = new List<Commentaire>()
        {
            new Commentaire()
            {
                Auteur = "Jean louis",
                Contenu = "c trop bi1",
                DateCreation = DateTime.Now,
                IdCommentaire = 1,
                IdTitre = 1,
                Titre = FactoryTitre.Titres.First(t=>t.IdTitre == 1)
            },
            new Commentaire()
            {
                Auteur = "Jean louis",
                Contenu = "c trop bi1",
                DateCreation = DateTime.Now,
                IdCommentaire = 2,
                IdTitre = 1,
                Titre = FactoryTitre.Titres.First(t=>t.IdTitre == 1)
            },
        };
    }
}
