using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webzine.Entity;
using Webzine.Repository.Contracts;
using Webzine.WebApplication.Areas.Administration.ViewModels;

namespace Webzine.WebApplication.Areas.Administration.Controllers
{
    [Area("Administration")]
    public class ArtisteController : Controller
    {
        private readonly IArtisteRepository _artisteRepository;
        private readonly IPaysRepository _paysRepository;

        public ArtisteController(IArtisteRepository artisteRepository, IPaysRepository paysRepository)
        {
            _artisteRepository = artisteRepository;
            _paysRepository = paysRepository;
        }

        /// <summary>
        ///  Permet de récupérer tout les artistes dans notre jeu de données
        /// </summary>
        /// <returns> Retourne ula vue index </returns>
        public ActionResult Index()
        {
            var test = _artisteRepository.FindAll().ToList();
           this.ViewData.Model = test;
            return View();
        }

        /// <summary>
        ///  Permet d'afficher la view Create
        /// </summary>
        /// <returns> Retourne la vue create </returns>
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        ///  Permet de créer un nouvel artiste
        /// </summary>
        /// <param name="artiste"></param>
        /// <returns> En cas de réussite retourne sur la page index artiste, en cas d'échecs retourne sur la page create artiste </returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Artiste artiste)
        {
            try
            {
                _artisteRepository.Add(artiste);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        /// <summary>
        ///  Permet d'afficher la page edit d'un artiste grâce à son id
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Retourne la vue edit </returns>
        public ActionResult Edit(int id)
        {
            var artist = _artisteRepository.Find(id);
            var vm = new AdminArtistViewModel()
            {
                Id = artist.IdArtiste,
                Name = artist.Nom,
                DateNaissance = artist.DateNaissance,
                Pays = artist.Pays,
                Biography = artist.Biographie,
                ListPays = _paysRepository.FindAll().ToList()
            };

            return this.View(vm);
        }

        /// <summary>
        /// Permet d'editer un artiste
        /// </summary>
        /// <param name="artiste"></param>
        /// <returns> En cas de réussite retourne sur la page index artiste, en cas d'échecs retourne sur la page edit artiste </returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Artiste artiste)
        {
            try
            {
                _artisteRepository.Update(artiste);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        /// <summary>
        ///  Permet d'afficher la vue delete artiste grâce à son id
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Retourne la vue delete artiste </returns>
        public ActionResult Delete(int id)
        {
            this.ViewData.Model = _artisteRepository.Find(id);
            return View();
        }

        /// <summary>
        /// Permet de supprimer un artiste
        /// </summary>
        /// <param name="artiste"></ param >
        /// <returns> En cas de réussite retourne sur la page index artiste, en cas d'échecs retourne sur la page delete artiste</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Artiste artiste)
        {
            try
            {
                _artisteRepository.Delete(artiste);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}