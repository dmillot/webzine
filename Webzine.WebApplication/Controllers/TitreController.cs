using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webzine.Entity;
using Webzine.WebApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Webzine.Repository.Contracts;

namespace Webzine.WebApplication.Controllers
{
    public class TitreController : Controller
    {
        private ICommentaireRepository _commentaireRepository;
        ITitreRepository _titreRepository;
        public TitreController(ICommentaireRepository commentaireRepository, ITitreRepository titreRepository)
        {
            _commentaireRepository = commentaireRepository;
            _titreRepository = titreRepository;
        }

        /// <summary>
        /// Return the index page to be displayed
        /// </summary>
        /// 
        /// <returns>Return the index page</returns>
        /// 
        public IActionResult Index(int id)
        {
            Titre t = _titreRepository.Find(id);
            TitreViewModel titre = new TitreViewModel()
            {
                Title = t.Libelle,
                Description = t.Chronique,
                Author = t.Artiste,
                Comments = t.Commentaires,
                Styles = new List<Style>()
                {
                    new Style() { Libelle = "Funk" },
                    new Style() { Libelle = "Electro" }
                },
                AlbumPicture = "https://images-na.ssl-images-amazon.com/images/I/51%2B1xjXXesL._SX355_.jpg",
                AlbumTitle = "Right On!",
                VideoLink = "https://www.youtube.com/embed/bV2Bm7kj3cM",
                UpdatedAt = DateTime.Now,
                LikeCounter = 6,
                IdTitre = id
            };
            return View(titre);
        }

        [HttpPost]
        public IActionResult Commenter([Bind("Auteur,Contenu,IdTitre")] Commentaire commentaire)
        {
            commentaire.DateCreation = DateTime.Now;
            _commentaireRepository.Add(commentaire);
            return Redirect("/titre/" + commentaire.IdTitre);
        }
    }
}
