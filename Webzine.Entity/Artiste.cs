﻿//-----------------------------------------------------------------------
// <copyright file="Artiste.cs" company="WebZinc">
//     Copyright (c) WebZinc. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Webzine.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Classe représentant un artiste ( musicien / chanteur ).
    /// </summary>
    public class Artiste
    {
        /// <summary>
        /// Obtient ou définit l'index de l'artiste.
        /// </summary>
        [Key]
        public int IdArtiste { get; set; }

        /// <summary>
        /// Obtient ou définit le nom de l'artiste.
        /// </summary>
        [MinLength(1)]
        [MaxLength(50)]
        [Display(Name = "Nom de l'artiste")]
        [Required]
        public string Nom { get; set; }

        /// <summary>
        /// Obtient ou définit la biographie de l'artiste.
        /// </summary>
        [Required]
        [MinLength(1)]
        public string Biographie { get; set; }

        /// <summary>
        /// Obtient ou définit la liste des titres de l'artiste.
        /// </summary>
        [NotMapped]
        
        public List<Titre> Titres { get; set; }
    }
}
