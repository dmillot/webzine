using System.Collections.Generic;
using Webzine.Entity;

namespace Webzine.WebApplication.ViewModels
{
    public class ArtistViewModel
    {
        public Artiste Artist { get; set; }
        public Dictionary<string, string> Albums { get; set; }

    }
}
