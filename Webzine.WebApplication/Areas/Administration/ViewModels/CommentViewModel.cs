using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webzine.Entity;

namespace Webzine.WebApplication.Areas.Administration.ViewModels
{
    public class CommentViewModel
    {
        public List<Commentaire> Comments { get; set; }

        public CommentViewModel()
        {
            Titre titre = new Titre()
            {
                Title = "la bonne zic",
                Id = 1
            };

            Comments = new List<Commentaire>()
            {
                new Commentaire()
                {
                    Title = titre,
                    IdTitre = titre.Id,
                    DateCreation = DateTime.Now,
                    Contenu = "JUUUUUUUULLLLLLL",
                    Auteur = "JEFFFFFF"
                },
                new Commentaire()
                {
                     Title = titre,
                    IdTitre = titre.Id,
                    DateCreation = DateTime.Now,
                    Contenu = "DJU DJU DJUUUUULLLL",
                    Auteur = "JEFFFFFF"
                },
                new Commentaire()
                {
                     Title = titre,
                    IdTitre = titre.Id,
                    DateCreation = DateTime.Now,
                    Contenu = "cette musique me fais saigner des orzeilles",
                    Auteur = "JEFFFFFF"
                },
                new Commentaire()
                {
                     Title = titre,
                    IdTitre = titre.Id,
                    DateCreation = DateTime.Now,
                    Contenu = "cette musique me fais saigner des orzeilles",
                    Auteur = "JEFFFFFF"
                },
            };
        }
    }
}
