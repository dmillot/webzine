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
        private readonly ICommentaireRepository _commentaireRepository;
        private readonly ITitreRepository _titreRepository;

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
                Libelle = t.Libelle,
                Chronique = t.Chronique,
                Artiste = t.Artiste,
                Commentaires = t.Commentaires,
                TitresStyles = t.TitresStyles,
                UrlJaquette = t.UrlJaquette,
                Album = "Right On!",
                UrlEcoute = t.UrlEcoute,
                DateCreation = DateTime.Now,
                NbLikes = t.NbLikes,
                IdTitre = id
            };
            this.ViewData.Model = titre;
            return View();

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
