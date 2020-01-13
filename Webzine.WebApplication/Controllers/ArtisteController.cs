//-----------------------------------------------------------------------
// <copyright file="ArtisteController.cs" company="WebZinc">
//     Copyright (c) WebZinc. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Webzine.WebApplication.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Webzine.Entity;
    using Webzine.Repository.Contracts;
    using Webzine.WebApplication.ViewModels;

    /// <summary>
    /// Classe représentant le controller pour les artistes.
    /// </summary>
    public class ArtisteController : Controller
    {
        /// <summary>
        /// Instance de <see cref="IArtisteRepository" />.
        /// </summary>
        private readonly IArtisteRepository artisteRepository;

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="ArtisteController" />.
        /// </summary>
        /// <param name="artistRepository">To do.</param>
        public ArtisteController(IArtisteRepository artistRepository)
        {
            this.artisteRepository = artistRepository;
        }

        /// <summary>
        /// TO DO.
        /// </summary>
        /// <param name="name">TO DO.</param>
        /// <returns>TO DO.</returns>
        public IActionResult Index(string name)
        {
            Artiste artist = this.artisteRepository.Find(1);
            artist.Titres.OrderBy(t => t.Album);

            // Get all albums names by distinct names
            var albums = new Dictionary<string, string>();
            foreach (var titre in artist.Titres)
            {
                if (!albums.ContainsKey(titre.Album))
                {
                    albums.Add(titre.Album, titre.UrlJaquette); // Set album name as key and url image as value
                }
            }

            ArtistViewModel model = new ArtistViewModel() // model for the view
            {
                Artist = artist,
                Albums = albums
            };

            return this.View(model);
        }
    }
}