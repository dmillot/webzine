//-----------------------------------------------------------------------
// <copyright file="Titre.cs" company="WebZinc">
//     Copyright (c) WebZinc. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Webzine.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Title représente un titre musical appartenant à un artiste
    /// </summary>
    public class Titre
    {
        /// <summary>
        /// Obtient ou définit l'index d'un titre.
        /// </summary>
        [Key]
        public int IdTitre { get; set; }

        /// <summary>
        /// Obtient ou définit le nom d'un titre.
        /// </summary>
        [Required]
        [MaxLength(200)]
        [MinLength(1)]
        [Display(Name = "Titre")]
        public string Libelle { get; set; }

        /// <summary>
        /// Obtient ou définit la description d'un titre.
        /// </summary>
        [Required]
        [MaxLength(4000)]
        [MinLength(10)]
        public string Chronique { get; set; }

        /// <summary>
        /// Obtient ou définit la durée d'un titre.
        /// </summary>
        [Display(Name = "Durée en secondes")]
        public int Duree { get; set; }

        /// <summary>
        /// Obtient ou définit le lien URL de la couverture d'album d'un titre.
        /// </summary>
        [Required]
        [Display(Name = "Jaquette de l'album")]
        [MaxLength(250)]
        public string UrlJaquette { get; set; }

        /// <summary>
        /// Obtient ou définit le nom de l'album d'un titre.
        /// </summary>
        [Required]
        public string Album { get; set; }

        /// <summary>
        /// Obtient ou définit le lien URL d'écoute d'un titre.
        /// </summary>
        [Display(Name = "URL d'écoute")]
        [MaxLength(250)]
        [MinLength(13)]
        public string UrlEcoute { get; set; }

        /// <summary>
        /// Obtient ou définit la date de création de la chronique d'un titre.
        /// </summary>
        [Required]
        [Display(Name = "Date de création")]
        public DateTime DateCreation { get; set; }

        /// <summary>
        /// Obtient ou définit la date de sortie d'un titre.
        /// </summary>
        [Required]
        [Display(Name = "Date de sortie")]
        public DateTime DateSortie { get; set; }

        /// <summary>
        /// Obtient ou définit le nombre de lectures d'un titre.
        /// </summary>
        [Required]
        [Display(Name = "Nombre de lectures")]
        public int NbLectures { get; set; }

        /// <summary>
        /// Obtient ou définit le nombre de likes d'un titre.
        /// </summary>
        [Required]
        [Display(Name = "Nombre de likes")]
        public int NbLikes { get; set; }

        /// <summary>
        /// Obtient ou définit l'index de l'artiste d'un titre.
        /// </summary>
        [ForeignKey(nameof(Titre.Artiste))]
        [Column("id_artiste")]
        public int IdArtiste { get; set; }

        /// <summary>
        /// Obtient ou définit l'artiste d'un titre.
        /// </summary>
        public Artiste Artiste { get; set; }

        /// <summary>
        /// Obtient ou définit la liste des commentaires d'un titre.
        /// </summary>
        public List<Commentaire> Commentaires { get; set; }

        /// <summary>
        /// Obtient ou définit la liste des styles d'un titre.
        /// </summary>
        public List<Style> TitresStyles { get; set; }

        /// <summary>
        /// Formate la durée du titre en minutes secondes.
        /// </summary>
        /// <returns>La durée au format minutes:secondes (ex : 04:30).</returns>
        public string DurationToString()
        {
            TimeSpan time = TimeSpan.FromSeconds(this.Duree);
            string str = time.ToString(@"mm\:ss");
            return str;
        }
    }
}
