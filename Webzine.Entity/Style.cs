//-----------------------------------------------------------------------
// <copyright file="Style.cs" company="WebZinc">
//     Copyright (c) WebZinc. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Webzine.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Classe représentant un style musical.
    /// </summary>
    public class Style
    {
        /// <summary>
        /// Obtient ou définit l'index d'un style.
        /// </summary>
        [Key]
        public int IdStyle { get; set; }
        
        /// <summary>
        /// Obtient ou définit le nom d'un style.
        /// </summary>
        [Display(Name = "Libellé")]
        [MaxLength(50)]
        [MinLength(2)]
        [Required]
        public string Libelle { get; set; }

        /// <summary>
        /// Obtient ou définit la liste des titres appartenant à ce style.
        /// </summary>
        public List<Titre> TitresStyles { get; set; }
    }
}
