﻿using System;
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
                IdCommentaire = 2,
                IdTitre = 2
            },
            new Commentaire()
            {
                Auteur = "Jean louis",
                Contenu = "c gergegergertrop bi1",
                DateCreation = DateTime.Now,
                IdCommentaire = 2,
                IdTitre = 3
            },
            new Commentaire()
            {
                Auteur = "Jean louis",
                Contenu = "c tropgtrgegrege bi1",
                DateCreation = DateTime.Now,
                IdCommentaire = 2,
                IdTitre = 4
            },
        };
    }
}
