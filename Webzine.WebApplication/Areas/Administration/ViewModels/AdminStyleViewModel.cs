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
                new Style { Description = "Une musique rythmée" , Name ="EroticoDisco" , Id= 1 },
                new Style { Description = "Une musique rythmée" , Name ="JazzCountry" , Id= 2 },
                new Style { Description = "Une musique rythmée" , Name ="CrabRave" , Id= 3 },
                new Style { Description = "Une musique rythmée" , Name ="HeavyDisco" , Id= 4 },
                new Style { Description = "Une musique rythmée" , Name ="NeoCyber" , Id= 5 },
                new Style { Description = "Une musique rythmée" , Name ="Cyberpunk" , Id= 6 },
            };
        }
    }
}
