using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webzine.WebApplication.Areas.Administration.ViewModels;
using Webzine.Entity;

namespace Webzine.WebApplication.Areas.Administration.Controllers
{
    [Area("Administration")]
    public class StyleController : Controller
    {
        AdminStyleViewModel _adminStyleViewModel = new AdminStyleViewModel();
        public IActionResult Index()
        {
            this.ViewData.Model = _adminStyleViewModel;
            return View();
        }
        public IActionResult Edit(int Id)
        {
            var result = _adminStyleViewModel.Styles.Where(s => s.IdStyle == Id).FirstOrDefault();
            this.ViewData.Model = result;
            return View();
        }
        public IActionResult Delete(int Id)
        {
            var result = _adminStyleViewModel.Styles.Where(s => s.IdStyle == Id).FirstOrDefault();
            this.ViewData.Model = result;
            return View();
        }
    
    }
}