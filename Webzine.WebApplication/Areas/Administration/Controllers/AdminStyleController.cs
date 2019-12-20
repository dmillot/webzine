using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webzine.WebApplication.Areas.Administration.ViewModels;
using System.Linq;
using Webzine.Entity;

namespace Webzine.WebApplication.Areas.Administration.Controllers
{
    public class AdminStyleController : Controller
    {
        AdminStyleViewModel _adminStyleViewModel = new AdminStyleViewModel();
        public IActionResult Index()
        {
            this.ViewData.Model = _adminStyleViewModel;
            return View();
        }
        public IActionResult EditStyle(int Id)
        {
            var result = _adminStyleViewModel.Styles.Where(s => s.Id == Id).FirstOrDefault();
            this.ViewData.Model = result;
            return View("EditStylePage");
        }
        public IActionResult DeleteStyle(int Id)
        {
            var result = _adminStyleViewModel.Styles.Where(s => s.Id == Id).FirstOrDefault();
            this.ViewData.Model = result;
            return View("DeleteStylePage");
        }
    
    }
}