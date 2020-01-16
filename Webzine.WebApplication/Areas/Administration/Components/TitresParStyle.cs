using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webzine.Repository.Contracts;

namespace Webzine.WebApplication.Areas.Administration.Components
{
    public class TitresParStyle
    {
        [ViewComponent(Name = "TitresParStyle")]
        public class StylesList : ViewComponent
        {
            private readonly IStyleRepository _styleRepository;

            public StylesList(IStyleRepository styleRepository)
            {
                _styleRepository = styleRepository;
            }
            public IViewComponentResult Invoke()
            {
                var style = _styleRepository.FindAll();
                Dictionary<string, int> dictionary = null;

                return this.View(dictionary);
            }
        }
    }
}
