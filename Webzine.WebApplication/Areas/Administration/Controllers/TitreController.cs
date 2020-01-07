using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webzine.Entity;
using Webzine.Repository;
using Webzine.WebApplication.Areas.Administration.ViewModels;

namespace Webzine.WebApplication.Areas.Administration.Controllers
{
    [Area("Administration")]
    public class TitreController : Controller
    {
        public IActionResult Index()
        {
            List<Titre> titles = FactoryTitre.Titres;

            return View(titles);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            TitleViewModel model = new TitleViewModel();
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            TitleViewModel model = new TitleViewModel();
            return View(model);
        }
    }
}