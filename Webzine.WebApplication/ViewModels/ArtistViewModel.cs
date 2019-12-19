using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webzine.Entity;

namespace Webzine.WebApplication.ViewModels
{
    public class ArtistViewModel
    {
        public string Name { get; set; }
        public string Biography { get; set; }
        public List<Titre> Titles { get; set; }


    }
}
