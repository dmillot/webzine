using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webzine.Entity;
using Webzine.Repository;

namespace Webzine.WebApplication.Components
{
    [ViewComponent(Name = "ArtistsList")]
    public class ArtistsList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Artiste> artistes = FactoryArtiste.Artistes;

            return this.View(artistes);
        }
    }
}
