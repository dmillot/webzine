//-----------------------------------------------------------------------
// <copyright file="Commentaire.cs" company="WebZinc">
//     Copyright (c) WebZinc. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Webzine.Entity
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Classe représentant une réaction (commentaire) à une chronique d'un titre.
    /// </summary>
    public class Commentaire
    {
        /// <summary>
        /// Obtient ou définit l'index du commentaire.
        /// </summary>
        [Key]
        public int IdCommentaire { get; set; }

        /// <summary>
        /// Obtient ou définit l'auteur du commentaire.
        /// </summary>
        [Display(Name = "Nom")]
        [MinLength(2)]
        [MaxLength(30)]
        [Required]
        public string Auteur { get; set; }

        /// <summary>
        /// Obtient ou définit le contenu du commentaire.
        /// </summary>
        [Required]
        [MinLength(10)]
        [MaxLength(1000)]
        [Display(Name = "Commentaire")]
        public string Contenu { get; set; }

        /// <summary>
        /// Obtient ou définit la date de publication du commentaire.
        /// </summary>
        [Required]
        [Display(Name = "Date de création")]
        public DateTime DateCreation { get; set; }

        /// <summary>
        /// Obtient ou définit l'index du titre musical auquel le commentaire est rattaché.
        /// </summary>
        [ForeignKey(nameof(Commentaire.Titre))]
        public int IdTitre { get; set; }

        /// <summary>
        /// Obtient ou définit le titre rattaché au commentaire.
        /// </summary>
        [NotMapped]
        public Titre Titre { get; set; }
    }
}
