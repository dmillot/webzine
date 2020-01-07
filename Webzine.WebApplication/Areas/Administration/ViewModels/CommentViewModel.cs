using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webzine.Entity;
using Webzine.Repository;

namespace Webzine.WebApplication.Areas.Administration.ViewModels
{
    public class CommentViewModel
    {
        public List<Commentaire> Comments { get; set; }

        public CommentViewModel()
        {
        }
    }
}
