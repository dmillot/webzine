using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Webzine.Entity;
using Webzine.Repository.Contracts;

namespace Webzine.WebApplication.ViewModels
{
    public class StyleController : Controller
    {
        private readonly IStyleRepository _styleRepository;
        private readonly ITitreRepository _titreRepository;

        public StyleController(IStyleRepository styleRepository, ITitreRepository titreRepository)
        {
            _styleRepository = styleRepository;
            _titreRepository = titreRepository;
        }

        public IActionResult Index(string libelle)
        {

            this.ViewData.Model = new StyleViewModel
            {
                Titres = (List<Titre>)_titreRepository.SearchByStyle(libelle)
            };
            return View();
        }
    }
}