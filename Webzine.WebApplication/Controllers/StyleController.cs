using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webzine.Entity;

namespace Webzine.WebApplication.ViewModels
{
    public class StyleController : Controller
    {
        public IActionResult Index()
        {
            StyleViewModel style = new StyleViewModel
            {
                Titres = new List<Titre>()
                {
                    new Titre()
                    {
                        Title = "Tata",
                        Duration = 200,
                        AlbumPicture = "https://d2tml28x3t0b85.cloudfront.net/tracks/artworks/000/013/066/original/7e7f95.jpeg"
                    },
                    new Titre
                    {
                        Title = "Fifou",
                        Duration = 200,
                        AlbumPicture = "https://d2tml28x3t0b85.cloudfront.net/tracks/artworks/000/013/066/original/7e7f95.jpeg"
                    }
                }
            };
            this.ViewData.Model = style;
            return View();
        }
    }
}