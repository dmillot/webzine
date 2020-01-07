using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webzine.Entity;
using Webzine.Repository;

namespace Webzine.WebApplication.Components
{
    [ViewComponent(Name = "StylesList")]
    public class StylesList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            FactoryStyle factory = new FactoryStyle();
            List<Style> styles = factory.Styles;

            return this.View(styles);
        }
    }
}
