using System;
using System.Collections.Generic;
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
                IdTitre = 1
            },
            new Commentaire()
            {
                Auteur = "Jean louis",
                Contenu = "c trop bigergergerger1",
                DateCreation = DateTime.Now,
                IdCommentaire = 2,
                IdTitre = 1
            },
            new Commentaire()
            {
                Auteur = "Jean louis",
                Contenu = "gergergegerc trop bi1",
                DateCreation = DateTime.Now,
                IdCommentaire = 3,
                IdTitre = 5
            },
            new Commentaire()
            {
                Auteur = "Jean louis",
                Contenu = "c gergegergertrop bi1",
                DateCreation = DateTime.Now,
                IdCommentaire = 4,
                IdTitre = 3
            },
            new Commentaire()
            {
                Auteur = "Jean louis",
                Contenu = "c tropgtrgegrege bi1",
                DateCreation = DateTime.Now,
                IdCommentaire = 5,
                IdTitre = 4
            },
        };
    }
}
