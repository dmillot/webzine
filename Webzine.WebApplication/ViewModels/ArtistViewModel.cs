using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webzine.Entity;

namespace Webzine.WebApplication.ViewModels
{
    /// <summary>
    /// model for artist view
    /// </summary>
    public class ArtistViewModel
    {
        /// <summary>
        /// artist to see on the page
        /// </summary>
        public Artiste Artist { get; set; }
        /// <summary>
        /// album name and his jaquette url to display albums and titles
        /// </summary>
        public Dictionary<string, string> Albums { get; set; }

    }
}
