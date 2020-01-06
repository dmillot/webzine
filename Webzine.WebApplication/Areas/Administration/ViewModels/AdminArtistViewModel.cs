using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webzine.Entity;

namespace Webzine.WebApplication.Areas.Administration.ViewModels
{
    public class AdminArtistViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
        public List<Artiste> Artists { get; set; }
    }
}
