using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webzine.Entity;

namespace Webzine.WebApplication.Areas.Administration.ViewModels
{
    public class CommentViewModel
    {
        public List<Commentaire> Comments { get; set; }

        public CommentViewModel()
        {
            Titre titre = new Titre()
            {
                Title = "la bonne zic",
                Id = 1
            };

            Comments = new List<Commentaire>()
            {
                new Commentaire()
                {
                    Title = titre,
                    CreatedAt = DateTime.Now,
                    Message = "JUUUUUUUULLLLLLL",
                    Username = "JEFFFFFF"
                },
                new Commentaire()
                {
                    Title = titre,
                    CreatedAt = DateTime.Now,
                    Message = "DJU DJU DJUUUUULLLL",
                    Username = "JEFFFFFF"
                },
                new Commentaire()
                {
                    Title = titre,
                    CreatedAt = DateTime.Now,
                    Message = "cette musique me fais saigner des orzeilles",
                    Username = "JEFFFFFF"
                },
                new Commentaire()
                {
                    Title = titre,
                    CreatedAt = DateTime.Now,
                    Message = "cette musique me fais saigner des orzeilles",
                    Username = "JEFFFFFF"
                },
            };
        }
    }
}
