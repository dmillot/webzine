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
        public IActionResult Index(int id)
        {

            TitleViewModel titles = new TitleViewModel();
            return View(titles);
        }
    }
}