using System;
using System.Collections.Generic;
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
                Styles = t.TitresStyles,
                AlbumPicture = t.UrlJaquette,
                AlbumTitle = "Right On!",
                VideoLink = t.UrlEcoute,
                UpdatedAt = DateTime.Now,
                LikeCounter = t.NbLikes,
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
