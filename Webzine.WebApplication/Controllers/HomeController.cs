using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


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
            return this.View();
        }
    }
}
