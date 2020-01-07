using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webzine.Entity;

namespace Webzine.WebApplication.ViewModels
{
    /// <summary>
    /// contain data for home view
    /// </summary>
    public class HomeViewModel
    {
        /// <summary>
        /// contains 3 latests titles chronicles to display
        /// </summary>
        public List<Titre> Titres_chroniques { get; set; }
        /// <summary>
        /// contains the 3 titles the most populars
        /// </summary>
        public List<Titre> Titres_populaires { get; set; }
        /// <summary>
        /// the actual page
        /// </summary>
        public int Page { get; set; }
        /// <summary>
        /// the count of titles pages
        /// </summary>
        public int MaxPage { get; set; }
    }
}
