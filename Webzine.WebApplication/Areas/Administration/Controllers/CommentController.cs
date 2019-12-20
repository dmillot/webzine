﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webzine.WebApplication.Areas.Administration.ViewModels;

namespace Webzine.WebApplication.Areas.Administration.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            CommentViewModel model = new CommentViewModel();
            return View(model);
        }
    }
}