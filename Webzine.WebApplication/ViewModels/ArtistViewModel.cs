using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webzine.Entity;

namespace Webzine.WebApplication.ViewModels
{
    public class ArtistViewModel
    {
        public string NomArtiste { get; set; }
        public string BiographieArtiste { get; set; }
        public List<Titre> Tracks { get; set; }


    }
}
