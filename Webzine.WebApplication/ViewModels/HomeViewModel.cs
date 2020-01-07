using System.Collections.Generic;
using Webzine.Entity;

namespace Webzine.WebApplication.ViewModels
{
    public class HomeViewModel
    {
        public List<Titre> Titres_chroniques { get; set; }
        public List<Titre> Titres_populaires { get; set; }
        public int Page { get; set; }
        public int MaxPage { get; set; }
    }
}
