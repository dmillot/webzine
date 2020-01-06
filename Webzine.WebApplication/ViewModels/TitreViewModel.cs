using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webzine.Entity;

namespace Webzine.WebApplication.ViewModels
{
    public class TitreViewModel
    {
        public string Title { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public Artiste Author { get; set; }
        public List<Commentaire> Comments { get; set; }
        public List<Style> Styles { get; set; }
        public string AlbumPicture { get; set; }
        public string AlbumTitle { get; set; }
        public string VideoLink { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int LikeCounter { get; set; }
        public string GetDate
        {
            get
            {
                return UpdatedAt.ToString("dd/MM/yyyy");
            }
        }
        public string GetTime
        {
            get
            {
                return UpdatedAt.ToString("hh:mm");
            }
        }

        /// <summary>
        /// return the duration in string to format minutes: secondes (4:30)
        /// </summary>
        /// <returns></returns>
        public string DurationToString()
        {
            TimeSpan time = TimeSpan.FromSeconds(Duration);
            string str = time.ToString(@"mm\:ss");
            return str;
        }
    }
}

