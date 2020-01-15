using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webzine.Entity;

namespace Webzine.WebApplication.Areas.Administration.ViewModels
{
    public class TitleViewModel
    {
        public IEnumerable<Titre> Titres { get; set; }
        public Titre Titre { get; set; }
        public IEnumerable<Style> Styles { get; set; }
        public IEnumerable<Artiste> Artistes { get; set; }
        public List<int> StylesChecked { get; set; }

    }
}
