using System;
using System.Collections.Generic;
using Webzine.Entity;
using Webzine.WebApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Webzine.Repository.Contracts;
using Webzine.Business.Contracts;

namespace Webzine.WebApplication.Controllers
{
    public class TitreController : Controller
    {
        private readonly ICommentaireRepository _commentaireRepository;
        private readonly ITitreRepository _titreRepository;
        private readonly ITitreBusiness _titreBussiness;

        public TitreController(ICommentaireRepository commentaireRepository, ITitreRepository titreRepository, ITitreBusiness titreBussiness)
        {
            _commentaireRepository = commentaireRepository;
            _titreRepository = titreRepository;
            _titreBussiness = titreBussiness;
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
                Album = t.Album,
                UrlEcoute = t.UrlEcoute,
                DateCreation = t.DateSortie,
                NbLikes = t.NbLikes,
                IdTitre = id
            };
            this.ViewData.Model = titre;
            _titreRepository.IncrementNbLectures(t); //PAGE COUNTER
            return View();

        }

        [HttpPost]
        public IActionResult Commenter([Bind("Auteur,Contenu,IdTitre")] Commentaire commentaire)
        {
            commentaire.DateCreation = DateTime.Now;
            _commentaireRepository.Add(commentaire);
            return Redirect("/titre/" + commentaire.IdTitre);
        }

        [HttpPost]
        public IActionResult Liker(int idTitre)
        {
            Titre titre = _titreRepository.Find(idTitre);
            _titreBussiness.LikeTitre(titre);
            return Redirect("/titre/" + idTitre);
        }
    }
}
