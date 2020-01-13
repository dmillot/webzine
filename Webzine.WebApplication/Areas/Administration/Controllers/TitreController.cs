using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Webzine.Entity;
using Webzine.Repository.Contracts;
using Webzine.WebApplication.Areas.Administration.ViewModels;

namespace Webzine.WebApplication.Areas.Administration.Controllers
{
    [Area("Administration")]
    public class TitreController : Controller
    {
        private readonly ITitreRepository _titreRepository;
        private readonly IStyleRepository _styleRepository;
        private readonly IArtisteRepository _artisteRepository;

        public TitreController(ITitreRepository titreRepository , IStyleRepository styleRepository , IArtisteRepository artisteRepository)
        {
            _titreRepository = titreRepository;
            _styleRepository = styleRepository;
            _artisteRepository = artisteRepository;
        }
        public IActionResult Index()
        {
            List<Titre> titles = (List<Titre>)_titreRepository.FindAll();
            return View(titles);
        }

        public IActionResult Create()
        {
            TitleViewModel titleViewModel = new TitleViewModel { Artistes = _artisteRepository.FindAll(), Styles = _styleRepository.FindAll() };
            this.ViewData.Model = titleViewModel;
            return View();
        }

        /// <summary>
        /// Permet de créer un titre
        /// </summary>
        /// <param name="titre"></param>
        /// <returns> En cas de réussite retourne sur la page index titre, en cas d'échecs retourne sur la page create titre </returns>
        [HttpPost]
        public IActionResult Create(Titre titre)
        {
            try
            {
                _titreRepository.Add(titre);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Edit(int id)
        {
            TitleViewModel titleViewModel = new TitleViewModel()
            {
                Artistes = _artisteRepository.FindAll(),
                Titre = _titreRepository.Find(id),
                Styles = _styleRepository.FindAll()

            };
            this.ViewData.Model = titleViewModel;
            return View();
        }

        /// <summary>
        /// Permet d'editer un tire
        /// </summary>
        /// <param name="titre"></param>
        /// <returns> En cas de réussite retourne sur la page index titre, en cas d'échecs retourne sur la page edit titre </returns>
        [HttpPost]
        public IActionResult Edit(Titre titre)
        {
            try
            {
                _titreRepository.Update(titre);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]   
        public IActionResult Delete(int id)
        {
            Titre titre = _titreRepository.Find(id);
            return View(titre);
        }

        /// <summary>
        /// Permet de supprimer un titre
        /// </summary>
        /// <param name="titre"></param>
        /// <returns> En cas de réussite retourne sur la page index titre, en cas d'échecs retourne sur la page delete titre </returns>
        [HttpPost]
        [Route("administration/titre/delete/{IdTitre}")]
        public IActionResult DeleteTitre(Titre titre)
        {
            try
            {
                _titreRepository.Delete(titre);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}