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

            TitleViewModel titles = new TitleViewModel();
            return View(titles);
        }

        public IActionResult CreateTitle()
        {
            TitleViewModel titles = new TitleViewModel();
            return View("CreateTitle", titles);
        }

        public IActionResult EditTitle(int id)
        {
            TitleViewModel titles = new TitleViewModel();
            return View("EditTitle", titles);
        }

        public IActionResult DeleteTitle(int id)
        {
            TitleViewModel titles = new TitleViewModel();
            return View("DeleteTitle", titles);
        }
    }
}