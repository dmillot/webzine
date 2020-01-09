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
    /// Classe représentant un titre musical appartenant à un artiste.
    /// </summary>
    public class Titre
    {
        /// <summary>
        /// Obtient ou définit l'index du titre.
        /// </summary>
        [Key]
        public int IdTitre { get; set; }

        /// <summary>
        /// Obtient ou définit le nom du titre.
        /// </summary>
        [Required]
        [MaxLength(200)]
        [MinLength(1)]
        [Display(Name = "Titre")]
        public string Libelle { get; set; }

        /// <summary>
        /// Obtient ou définit la description du titre.
        /// </summary>
        [Required]
        [MaxLength(4000)]
        [MinLength(10)]
        public string Chronique { get; set; }

        /// <summary>
        /// Obtient ou définit la durée du titre.
        /// </summary>
        [Display(Name = "Durée en secondes")]
        public int Duree { get; set; }

        /// <summary>
        /// Obtient ou définit le lien URL de la couverture d'album du titre.
        /// </summary>
        [Required]
        [Display(Name = "Jaquette de l'album")]
        [MaxLength(250)]
        public string UrlJaquette { get; set; }

        /// <summary>
        /// Obtient ou définit le nom de l'album du titre.
        /// </summary>
        [Required]
        public string Album { get; set; }

        /// <summary>
        /// Obtient ou définit le lien URL d'écoute du titre.
        /// </summary>
        [Display(Name = "URL d'écoute")]
        [MaxLength(250)]
        [MinLength(13)]
        public string UrlEcoute { get; set; }

        /// <summary>
        /// Obtient ou définit la date de création de la chronique du titre.
        /// </summary>
        [Required]
        [Display(Name = "Date de création")]
        public DateTime DateCreation { get; set; }

        /// <summary>
        /// Obtient ou définit la date de sortie du titre.
        /// </summary>
        [Required]
        [Display(Name = "Date de sortie")]
        public DateTime DateSortie { get; set; }

        /// <summary>
        /// Obtient ou définit le nombre de lectures du titre.
        /// </summary>
        [Required]
        [Display(Name = "Nombre de lectures")]
        public int NbLectures { get; set; }

        /// <summary>
        /// Obtient ou définit le nombre de likes du titre.
        /// </summary>
        [Required]
        [Display(Name = "Nombre de likes")]
        public int NbLikes { get; set; }

        /// <summary>
        /// Obtient ou définit l'index de l'artiste du titre.
        /// </summary>
        [ForeignKey(nameof(Titre.Artiste))]
        [Column("id_artiste")]
        public int IdArtiste { get; set; }

        /// <summary>
        /// Obtient ou définit l'artiste du titre.
        /// </summary>
        public Artiste Artiste { get; set; }

        /// <summary>
        /// Obtient ou définit la liste des commentaires du titre.
        /// </summary>
        public List<Commentaire> Commentaires { get; set; }

        /// <summary>
        /// Obtient ou définit la liste des styles du titre.
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
