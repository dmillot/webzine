using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Webzine.Entity;
using Webzine.Repository.Contracts;

namespace Webzine.WebApplication
{
    [ViewComponent(Name = "StylesList")]
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
