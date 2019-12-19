using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Webzine.Entity;
using Webzine.WebApplication.ViewModels;

namespace Webzine.WebApplication.Controllers
{
    public class ArtistController : Controller
    {
       
        public IActionResult Index(string name)
        {
            ArtistViewModel artist = new ArtistViewModel()
            {
                Name = name,
                Biography = @"Vangelis (Βαγγέλης, diminutif d’Evángelos, à prononcer Vanguélis), Evángelos Odysséas Papathanassíou (en grec : Ευάγγελος Οδυσσέας Παπαθανασίου), né le 29 mars 1943 à Vólos en Grèce1, est un musicien et compositeur, connu dans les domaines de la musique new age et électronique, et auteur de musiques de films.
                Ses compositions les plus connues sont la musique du film Les Chariots de feu(qui a reçu l'oscar de la meilleure musique en 1981), la bande originale du film Antarctica, ainsi que la totalité de la bande originale du film Blade Runner et de 1492 : Christophe Colomb.
                Il a également composé l'hymne de la Coupe du monde de football de 20022.
                Au même titre que le Français Jean - Michel Jarre, que les Belges de Telex et que les Allemands Klaus Schulze, Kraftwerk et Tangerine Dream, Vangelis est reconnu pour avoir été l'un des pionniers de la musique électronique au cours des années 1970. ",
                Titles = new List<Titre>()
                {
                    new Titre()
                    {
                        Id = 1,
                        Title = "blade runner - end titles",
                        Duration = "4:39",
                       AlbumPicture = "https://d2tml28x3t0b85.cloudfront.net/tracks/artworks/000/013/066/original/7e7f95.jpeg"
                    },
                }
            };
            return View(artist);
        }
    }
}