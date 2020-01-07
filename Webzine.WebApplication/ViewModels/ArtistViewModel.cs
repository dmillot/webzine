using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webzine.Entity;

namespace Webzine.WebApplication.ViewModels
{
    public class ArtistViewModel
    {
        public Artiste Artist { get; set; }
        public Dictionary<string, string> Albums { get; set; }

    }
}
