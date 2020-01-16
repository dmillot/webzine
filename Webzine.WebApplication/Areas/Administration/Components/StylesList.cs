using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webzine.Entity;
using Webzine.Repository;
using Webzine.Repository.Contracts;

namespace Webzine.WebApplication.Components
{
    //[ViewComponent(Name = "StylesList")]
    public class StylesList : ViewComponent
    {
        private readonly IStyleRepository _styleRepository;
        public StylesList(IStyleRepository styleRepository)
        {
            _styleRepository = styleRepository;
        }
        public IViewComponentResult Invoke()
        {
            List<Style> styles = (List<Style>)_styleRepository.FindAll();

            return this.View(styles);
        }
    }
}
