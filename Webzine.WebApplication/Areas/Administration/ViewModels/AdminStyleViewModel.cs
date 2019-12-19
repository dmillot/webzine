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
                new Style { Description = "Une musique rythmée" , Name ="EroticoDisco" , Id= 1 },
                new Style { Description = "Une musique rythmée" , Name ="EroticoDisco" , Id= 1 },
                new Style { Description = "Une musique rythmée" , Name ="EroticoDisco" , Id= 1 },
                new Style { Description = "Une musique rythmée" , Name ="EroticoDisco" , Id= 1 },
                new Style { Description = "Une musique rythmée" , Name ="EroticoDisco" , Id= 1 },
            };
        }
    }
}
