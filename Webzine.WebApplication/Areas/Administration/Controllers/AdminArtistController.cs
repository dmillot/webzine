using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webzine.Entity;
using Webzine.WebApplication.Areas.Administration.ViewModels;

namespace Webzine.WebApplication.Areas.Administration.Controllers
{
    public class AdminArtistController : Controller
    {
        // GET: Artist
        public ActionResult Index()
        {
            AdminArtistViewModel artists = new AdminArtistViewModel()
            {
                artists = new List<Artiste>(){
                    new Artiste(){ Id = 1, Name = "Queen" },
                    new Artiste(){ Id = 2, Name = "Stromae" },
                    new Artiste(){ Id = 3, Name = "Damso" },
                }
            };
            this.ViewData.Model = artists;
            return View(artists);
        }

        // GET: Artist/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Artist/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Artist/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Artist/Edit/5
        public ActionResult Edit(int id)
        {
            AdminArtistViewModel artist = new AdminArtistViewModel()
            {
                Id = id,
                Name = "Queen",
                Biography = @"Vangelis (Βαγγέλης, diminutif d’Evángelos, à prononcer Vanguélis), Evángelos Odysséas Papathanassíou (en grec : Ευάγγελος Οδυσσέας Παπαθανασίου), né le 29 mars 1943 à Vólos en Grèce1, est un musicien et compositeur, connu dans les domaines de la musique new age et électronique, et auteur de musiques de films.
                Ses compositions les plus connues sont la musique du film Les Chariots de feu(qui a reçu l'oscar de la meilleure musique en 1981), la bande originale du film Antarctica, ainsi que la totalité de la bande originale du film Blade Runner et de 1492 : Christophe Colomb.
                Il a également composé l'hymne de la Coupe du monde de football de 20022.
                Au même titre que le Français Jean - Michel Jarre, que les Belges de Telex et que les Allemands Klaus Schulze, Kraftwerk et Tangerine Dream, Vangelis est reconnu pour avoir été l'un des pionniers de la musique électronique au cours des années 1970. ",
            };

            return View(artist);
        }

        // POST: Artist/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Artist/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Artist/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}