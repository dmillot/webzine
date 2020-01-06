using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webzine.Entity;
using Webzine.WebApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Webzine.WebApplication.Controllers
{
    public class TitreController : Controller
    {
        /// <summary>
        /// Return the index page to be displayed
        /// </summary>
        /// 
        /// <returns>Return the index page</returns>
        /// 
        public IActionResult Index(int id)
        {
            TitreViewModel titre = new TitreViewModel()
            {
                Title = "Right On",
                Description = @"
Lorem ipsum dolor sit amet,
                consectetur adipiscing elit.Praesent commodo consequat sem eu malesuada.Quisque ullamcorper vestibulum ipsum eget ornare.Cras rutrum nunc vel ipsum sollicitudin tristique gravida sit amet elit.In ipsum nisl,
                euismod sed lacinia eget,
                laoreet ut lacus.Etiam ac ornare enim.Proin nec risus diam.Mauris rutrum lacinia sapien,
                et dictum mauris mattis quis.Aliquam quis tellus quam.Vivamus vulputate libero sit amet tortor sodales,
                vel fringilla velit gravida.Curabitur ac tincidunt dolor.Phasellus a hendrerit lectus.Aliquam aliquam at enim lacinia pulvinar.Aenean aliquam elementum venenatis.
Nulla bibendum ligula at justo faucibus convallis.Vestibulum at nulla condimentum,
                mollis dui id,
                convallis massa.Quisque volutpat accumsan nunc ac tincidunt.Nam maximus,
                lectus eu fermentum sodales,
                ipsum felis placerat massa,
                eget vestibulum neque velit a velit.Integer pellentesque ultrices luctus.Ut lorem ligula,
                consectetur vel lorem eget,
                feugiat malesuada ipsum.Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas.Vestibulum tristique,
                ex quis rutrum ornare,
                orci justo convallis risus,
                sollicitudin convallis mauris eros sed lorem.Etiam non bibendum lectus.Donec vitae tincidunt neque.Praesent quis convallis odio.Quisque mattis condimentum leo,
                eget laoreet nulla finibus sit amet.Donec at dolor convallis,
                volutpat felis suscipit,
                pulvinar sem.Nam vel placerat eros,
                eget pulvinar eros.Donec vitae nisi iaculis,
                cursus justo dapibus,
                maximus orci.Donec at felis interdum,
                scelerisque lacus sit amet,
                dignissim massa.
Curabitur tincidunt ipsum id congue dictum.Mauris vitae porttitor leo.Mauris eget magna ipsum.Vestibulum eros arcu,
                iaculis sit amet eros consequat,
                ultrices efficitur erat.Mauris ligula tortor,
                interdum ut nisl nec,
                hendrerit semper tortor.Fusce laoreet,
                nulla vel aliquam pulvinar,
                sem enim placerat tortor,
                eu pharetra mauris ante sed orci.Orci varius natoque penatibus et magnis dis parturient montes,
                nascetur ridiculus mus.Phasellus hendrerit massa purus,
                quis accumsan nibh tincidunt a.Duis maximus,
                nibh a congue luctus,
                erat velit auctor felis,
                eget tincidunt nisi justo non justo.",
                Author = new Artiste()
                {
                    Name = "Silicone Soul",
                    Biography = "Lorem"
                },
                Comments = new List<Commentaire>()
                {
                    new Commentaire() { Username = "Damien", Message = "Trop bien" },
                    new Commentaire() { Username = "Kim", Message = "Excellent" },
                    new Commentaire() { Username = "Nicolas", Message = "Mhh.. j'ai vu mieux" }
                },
                Styles = new List<Style>()
                {
                    new Style() { Libelle = "Funk" },
                    new Style() { Libelle = "Electro" }
                },
                AlbumPicture = "https://images-na.ssl-images-amazon.com/images/I/51%2B1xjXXesL._SX355_.jpg",
                AlbumTitle = "Right On!",
                VideoLink = "https://www.youtube.com/embed/bV2Bm7kj3cM",
                UpdatedAt = DateTime.Now,
                LikeCounter = 6
            };
            return View(titre);
        }
    }
}
