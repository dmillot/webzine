using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webzine.WebApplication.Areas.Administration.ViewModels;
using Webzine.Entity;
using Webzine.Repository.Contracts;
using Microsoft.AspNetCore.Http;

namespace Webzine.WebApplication.Areas.Administration.Controllers
{
    [Area("Administration")]
    public class StyleController : Controller
    {
        private readonly IStyleRepository _styleRepository;
        public StyleController(IStyleRepository styleRepository)
        {
            _styleRepository = styleRepository;
        }
   
        public IActionResult Index()
        {
            this.ViewData.Model = _styleRepository.FindAll() ;
            return View();
        }
        
        public IActionResult Edit(int Id)
        {
            this.ViewData.Model = _styleRepository.Find(Id);
            return View();
        }
        public IActionResult Delete(int Id)
        {
           
            this.ViewData.Model = _styleRepository.Find(Id);
            return View();
        }
        [HttpPost , ActionName("Edit")]
        public IActionResult EditPost(Style style)
        {
            _styleRepository.Update(style);
            this.ViewData.Model = _styleRepository.FindAll();
            return View("Index");
        }

    }
}