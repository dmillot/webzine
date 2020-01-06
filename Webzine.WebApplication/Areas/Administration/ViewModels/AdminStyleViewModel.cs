using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webzine.Entity;

namespace Webzine.WebApplication.Areas.Administration.ViewModels
{
    public class AdminStyleViewModel
    {
        public List<Style> Styles { get; set; }



        public AdminStyleViewModel()
        {
            Styles = new List<Style>
            {
                new Style { Libelle ="JazzCountry" , IdStyle= 2 },
                new Style { Libelle ="EroticoDisco" , IdStyle= 1 },
                new Style { Libelle ="CrabRave" , IdStyle= 3 },
                new Style { Libelle ="HeavyDisco" , IdStyle= 4 },
                new Style { Libelle ="NeoCyber" , IdStyle= 5 },
                new Style { Libelle ="Cyberpunk" , IdStyle= 6 },
            };
        }
    }
}
