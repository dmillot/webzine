using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Webzine.Entity;
using Webzine.Repository.Contracts;
using Webzine.WebApplication.ViewModels;

namespace Webzine.WebApplication.Controllers
{
    public class ResearchController : Controller
    {
        public readonly ITitreRepository _titreRepository;
        public readonly IArtisteRepository _artisteRepository;

        public ResearchController(ITitreRepository titreRepository, IArtisteRepository artisteRepository)
        {
            _titreRepository = titreRepository;
            _artisteRepository = artisteRepository;
        }

        public IActionResult Index(string mot)
        {
            List<Artiste> a = new List<Artiste>();
            List<Titre> t = new List<Titre>();
            if(mot != null && mot != "")
            {
                a = (List<Artiste>)_artisteRepository.Search(mot);
                t = (List<Titre>)_titreRepository.Search(mot);
            }
            
            ResearchViewModel recherche = new ResearchViewModel()
            {
                Titres = t,
                Artistes = a,
                Recherche = mot
            };
            this.ViewData.Model = recherche;
            return View();
        }
    }
}