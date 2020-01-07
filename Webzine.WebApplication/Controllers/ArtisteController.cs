namespace Webzine.WebApplication.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Webzine.Entity;
    using Webzine.Repository;
    using Webzine.WebApplication.ViewModels;

    public class ArtisteController : Controller
    {
       
        public IActionResult Index(string name)
        {
            Artiste artist = FactoryArtiste.Artistes[0];
            artist.Titres.OrderBy(t => t.Album);

            //get all albulms names by distinct names
            var albums = new Dictionary<string, string>();
            foreach (var titre in artist.Titres)
            {
                if (!albums.ContainsKey(titre.Album))
                {
                    albums.Add(titre.Album, titre.UrlJaquette);
                }
            }

            ArtistViewModel model = new ArtistViewModel()
            {
                Artist = artist,
                Albums = albums
            };
            return View(model);
        }
    }
}