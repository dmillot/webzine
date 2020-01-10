using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Webzine.Entity;
using Webzine.Repository;
using Webzine.Repository.Contracts;
using Webzine.WebApplication.ViewModels;

namespace Webzine.WebApplication.Controllers
{

    public class ArtisteController : Controller
    {
        private readonly IArtisteRepository _artisteRepository;
        public ArtisteController(IArtisteRepository artistRepository)
        {
            _artisteRepository = artistRepository;
        }
        public IActionResult Index(string name)
        {
            Artiste artist = _artisteRepository.Find(1);
            artist.Titres.OrderBy(t => t.Album);

            //get all albulms names by distinct names
            var albums = new Dictionary<string, string>();
            foreach (var titre in artist.Titres)
            {
                if (!albums.ContainsKey(titre.Album))
                {
                    albums.Add(titre.Album, titre.UrlJaquette); //set ulbum name as key and url image as value
                }
            }

            ArtistViewModel model = new ArtistViewModel() // model for the view
            {
                Artist = artist,
                Albums = albums
            };
            return View(model);
        }
    }
}