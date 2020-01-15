using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Webzine.Entity;
using Webzine.Repository.Contracts;
using Webzine.WebApplication.ViewModels;

namespace Webzine.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITitreRepository _titreRepository;
        public HomeController(ITitreRepository titreRepository)
        {
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
            var test = DateTime.Now.Month - 2 ;
            id = id == 0 ? 1 : id;
            var data = (List<Titre>)_titreRepository.FindTitres(id*3, 3);
            var countitres = _titreRepository.Count();
            HomeViewModel titre = new HomeViewModel() // model for the view
            {
                Titres_chroniques = data,
                Titres_populaires = (List<Titre>)_titreRepository.GetPopular(new DateTime(2019,10,1)),
                Page = id,
                MaxPage = _titreRepository.Count()/3

            };

            return this.View(titre);
        }



    }
}
