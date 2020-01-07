using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Webzine.Entity;

namespace Webzine.WebApplication.ViewModels
{
    public class StyleController : Controller
    {
        public IActionResult Index(string libelle)
        {
            
            StyleViewModel style = new StyleViewModel
            {
                Titres = new List<Titre>()
                {
                    new Titre()
                    {
                        Libelle = "Tata",
                        Duree = 200,
                        UrlJaquette = "https://d2tml28x3t0b85.cloudfront.net/tracks/artworks/000/013/066/original/7e7f95.jpeg"
                    },
                    new Titre
                    {
                        Libelle = "Fifou",
                        Duree = 200,
                        UrlJaquette = "https://d2tml28x3t0b85.cloudfront.net/tracks/artworks/000/013/066/original/7e7f95.jpeg"
                    }
                }
            };
            this.ViewData.Model = style;
            return View();
        }
    }
}