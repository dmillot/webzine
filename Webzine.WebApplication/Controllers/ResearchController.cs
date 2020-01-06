﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webzine.Entity;
using Webzine.WebApplication.ViewModels;

namespace Webzine.WebApplication.Controllers
{
    public class ResearchController : Controller
    {

        public IActionResult Index(string mot)
        {
            ResearchViewModel recherche = new ResearchViewModel()
            {
                Artistes = new List<Artiste>()
                {
                    new Artiste()
                    {
                        Name = "Toto"
                    },
                     new Artiste()
                    {
                        Name = "Angèle"
                    }
                },
                Titres = new List<Titre>()
                {
                    new Titre()
                    {
                        Libelle = "Tata",
                        Duree = 200,
                        UrlJaquette = "https://d2tml28x3t0b85.cloudfront.net/tracks/artworks/000/013/066/original/7e7f95.jpeg"
                    },
                     new Titre()
                    {
                        Libelle = "Lolilop",
                        Duree = 200,
                        UrlJaquette = "https://d2tml28x3t0b85.cloudfront.net/tracks/artworks/000/013/066/original/7e7f95.jpeg"
                    },
                      new Titre()
                    {
                        Libelle = "Fifi",
                        Duree = 200,
                        UrlJaquette = "https://d2tml28x3t0b85.cloudfront.net/tracks/artworks/000/013/066/original/7e7f95.jpeg"
                    }
                }
            };
            this.ViewData.Model = recherche;
            return View();
        }
    }
}