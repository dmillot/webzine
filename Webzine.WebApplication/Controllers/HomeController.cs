using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webzine.Entity;
using Webzine.Factory;
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
        public IActionResult Index()
        {
            HomeViewModel titre = new HomeViewModel()
            {
                MaxPage = TitreFactory.GetCountPages(),
                Page = 1,
                Titres_chroniques = TitreFactory.GetTitresFromPage(),
                Titres_populaires = TitreFactory.GetTitresFromPage()
            };
            this.ViewData.Model = titre;
            return this.View();
        }


        public IActionResult Page(int page)
        {
            HomeViewModel titre = new HomeViewModel()
            {
                MaxPage = TitreFactory.GetCountPages(),
                Page = page,
                Titres_chroniques = TitreFactory.GetTitresFromPage(page),
                Titres_populaires = TitreFactory.GetTitresFromPage()
            };
            this.ViewData.Model = titre;
            return this.View("../Home/Index");
        }
    }
}
