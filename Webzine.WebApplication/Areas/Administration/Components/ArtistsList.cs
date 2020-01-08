using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webzine.Entity;
using Webzine.Repository;
using Webzine.Repository.Contracts;

namespace Webzine.WebApplication.Components
{
    [ViewComponent(Name = "ArtistsList")]
    public class ArtistsList : ViewComponent
    {
        private readonly IArtisteRepository _artistRepository;
        public ArtistsList(IArtisteRepository artisteRepository)
        {
            _artistRepository = artisteRepository;
        }
        public IViewComponentResult Invoke()
        {
            List<Artiste> artistes = (List<Artiste>)_artistRepository.FindAll();
            return this.View(artistes);
        }
    }
}
