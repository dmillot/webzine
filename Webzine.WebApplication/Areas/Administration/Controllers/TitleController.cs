using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webzine.Entity;
using Webzine.WebApplication.Areas.Administration.ViewModels;

namespace Webzine.WebApplication.Areas.Administration.Controllers
{
    public class TitleController : Controller
    {
        public IActionResult Index()
        {
            TitleViewModel model = new TitleViewModel();
            return View(model);
        }

        public IActionResult CreateTitle()
        {
            TitleViewModel model = new TitleViewModel();
            return View("CreateTitle", model);
        }

        public IActionResult EditTitle(int id)
        {
            TitleViewModel model = new TitleViewModel();
            return View("EditTitle", model);
        }

        public IActionResult DeleteTitle(int id)
        {
            TitleViewModel model = new TitleViewModel();
            return View("DeleteTitle", model);
        }
    }
}