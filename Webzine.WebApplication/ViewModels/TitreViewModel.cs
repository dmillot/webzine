using System;
using System.Collections.Generic;
using Webzine.Entity;

namespace Webzine.WebApplication.ViewModels
{
    public class TitreViewModel
    {
        public string Libelle { get; set; }
        public string Chronique { get; set; }
        public Artiste Artiste { get; set; }
        public List<Commentaire> Commentaires { get; set; }
        public List<TitreStyle> TitresStyles { get; set; }
        public string UrlJaquette { get; set; }
        public int Duree { get; set; }
        public string Album { get; set; }
        public string UrlEcoute { get; set; }
        public DateTime DateCreation { get; set; }
        public int NbLikes { get; set; }
        public string GetDate
        {
            get
            {
                return DateCreation.ToString("dd/MM/yyyy");
            }
        }
        public string GetTime
        {
            get
            {
                return DateCreation.ToString("hh:mm");
            }
        }

        public Commentaire Commentaire { get; set; }
        public int IdTitre { get; set; }

        /// <summary>
        /// return the duration in string to format minutes: secondes (4:30)
        /// </summary>
        /// <returns></returns>
        public string DurationToString()
        {
            TimeSpan time = TimeSpan.FromSeconds(Duree);
            string str = time.ToString(@"mm\:ss");
            return str;
        }
    }
}

