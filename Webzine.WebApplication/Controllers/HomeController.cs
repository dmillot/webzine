using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webzine.Entity;
using Webzine.Repository;
using Webzine.WebApplication.ViewModels;

namespace Webzine.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Return the index page to be displayed
        /// </summary>
        /// 
        /// <returns>Return the index page</returns>
        /// 

        public IActionResult Index(int id)
        {
            HomeViewModel titre = new HomeViewModel()
            {
                MaxPage = FactoryTitre.GetCountPages(),
                Page = id,
                Titres_chroniques = FactoryTitre.GetTitresFromPage(id-1),
                Titres_populaires = FactoryTitre.GetTitresFromPage()
            };
            this.ViewData.Model = titre;
            return this.View();
        }



    }
}
