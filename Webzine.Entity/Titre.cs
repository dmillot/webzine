using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Webzine.Entity
{
    /// <summary>
    /// Title représente un titre musical appartenant à un artiste
    /// </summary>
    public class Titre
    {
        [Key]
        public int IdTitre { get; set; }

        [Required]
        [MaxLength(200)]
        [MinLength(1)]
        [Display(Name = "Titre")]
        public string Libelle { get; set; }

        [Required]
        [MaxLength(4000)]
        [MinLength(10)]
        public string Chronique { get; set; }

        [Display(Name = "Durée en secondes")]
        public int Duree { get; set; }

        [Required]
        [Display(Name = "Jaquette de l'album")]
        [MaxLength(250)]
        public string UrlJaquette { get; set; }

        /// <summary>
        /// Album Title
        /// </summary>
        [Required]
        public string Album { get; set; }

        [Display(Name = "URL d'écoute")]
        [MaxLength(250)]
        [MinLength(13)]
        public string UrlEcoute { get; set; }

        /// <summary>
        /// Date à laquelle l'article du titre à été crée.
        /// </summary>
        [Required]
        [Display(Name = "Date de création")]
        public DateTime DateCreation { get; set; }

        [Required]
        [Display(Name = "Date de sortie")]
        public DateTime DateSortie { get; set; }

        [Required]
        [Display(Name = "Nombre de lectures")]
        public int NbLectures { get; set; }

        [Required]
        [Display(Name = "Nombre de likes")]
        public int NbLikes { get; set; }

        [ForeignKey("Artiste")]
        public int IdArtiste { get; set; }

        public Artiste Artiste { get; set; }

        public List<Commentaire> Commentaires { get; set; }

        public List<Style> TitresStyles { get; set; }

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
