using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webzine.Entity;

namespace Webzine.WebApplication.ViewModels
{
    public class HomeViewModel
    {
        public List<Titre> Titres_chroniques { get; set; }
        public List<Titre> Titres_populaires { get; set; }

    }
}
