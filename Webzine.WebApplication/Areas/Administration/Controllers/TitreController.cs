using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webzine.Entity;
using Webzine.Repository;
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
            return View();
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

        [HttpGet]   
        public IActionResult Delete(int id)
        {
            Titre titre = _titreRepository.Find(id);
            return View(titre);
        }

        [HttpPost]
        [Route("administration/titre/delete/{IdTitre}")]
        public IActionResult DeleteTitre(int IdTitre)
        {
            throw new NotImplementedException();
            //return Redirect("administration/titre");
        }
    }
}