//-----------------------------------------------------------------------
// <copyright file="Pays.cs" company="WebZinc">
//     Copyright (c) WebZinc. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Webzine.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Pays
    {
        /// <summary>
        /// Obtient ou définit l'index du pays.
        /// </summary>
        [Key]
        public int IdPays { get; set; }

        /// <summary>
        /// Obtient ou définit le nom du pays.
        /// </summary
        [Required]
        public string Nom { get; set; }

        /// <summary>
        /// Obtient ou définit la liste des artistes de ce pays.
        /// </summary>
        [NotMapped]
        public List<Artiste> Artistes { get; set; }
    }
}
