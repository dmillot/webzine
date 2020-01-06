using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webzine.Entity;
using Webzine.WebApplication.ViewModels;

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
            HomeViewModel titre = new HomeViewModel()
            {
                Titres_chroniques = new List<Titre>()
                {
                    new Titre()
                    {
                        Artiste = new Artiste
                        {
                            Nom = "Silicone Soul"
                        },
                        Libelle = "Right on, Right on",
                        UrlJaquette = "https://d2tml28x3t0b85.cloudfront.net/tracks/artworks/000/013/066/original/7e7f95.jpeg",
                        Chronique = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum",
                        DateSortie = new DateTime(2019, 03, 18, 14,56,56),
                        TitresStyles = new List<Style>()
                        {
                            new Style
                            {
                                Libelle = "Electro"
                            }
                        }
                    },
                    new Titre()
                    {
                        Artiste = new Artiste
                        {
                            Nom = "Kraftwerk"
                        },
                        Libelle = "The Robots",
                        UrlJaquette = "https://d2tml28x3t0b85.cloudfront.net/tracks/artworks/000/013/066/original/7e7f95.jpeg",
                        Chronique = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum",
                        DateSortie = new DateTime(2019, 03, 18, 14,56,56),
                        TitresStyles = new List<Style>()
                        {
                            new Style
                            {
                                Libelle = "Electro"
                            }
                        }
                    },
                    new Titre()
                    {
                        Artiste = new Artiste
                        {
                            Nom = "Miles Davis"
                        },
                        Libelle = "Shhh / Paceful",
                        UrlJaquette = "https://d2tml28x3t0b85.cloudfront.net/tracks/artworks/000/013/066/original/7e7f95.jpeg",
                        Chronique = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum",
                        DateSortie = new DateTime(2019, 03, 18, 14,56,56),
                        TitresStyles = new List<Style>()
                        {
                            new Style
                            {
                                Libelle = "Electro"
                            }
                        }
                    }
                },
                Titres_populaires = new List<Titre>()
                {
                    new Titre()
                    {
                        Artiste = new Artiste
                        {
                            Nom = "Kraftwerk"
                        },
                        Libelle = "The Robots",
                        UrlJaquette = "https://d2tml28x3t0b85.cloudfront.net/tracks/artworks/000/013/066/original/7e7f95.jpeg",

                    },
                    new Titre()
                    {
                        Artiste = new Artiste
                        {
                            Nom = "Silicone Soul"
                        },
                        Libelle = "Right on, Right on",
                        UrlJaquette = "https://d2tml28x3t0b85.cloudfront.net/tracks/artworks/000/013/066/original/7e7f95.jpeg",
                    },
                    new Titre()
                    {
                        Artiste = new Artiste
                        {
                            Nom = "Miles Davis"
                        },
                        Libelle = "Shhh / Paceful",
                        UrlJaquette = "https://d2tml28x3t0b85.cloudfront.net/tracks/artworks/000/013/066/original/7e7f95.jpeg",
                    }
                }
            };
            this.ViewData.Model = titre;
            return this.View();
        }
    }
}
