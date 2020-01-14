//-----------------------------------------------------------------------
// <copyright file="TitreStyle.cs" company="WebZinc">
//     Copyright (c) WebZinc. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Webzine.Entity
{
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Classe représentant le style musical d'un titre.
    /// </summary>
    public class TitreStyle
    {
        /// <summary>
        /// Obtient ou définit l'index du titre.
        /// </summary>
        public int IdTitre { get; set; }

        /// <summary>
        /// Obtient ou définit l'index du style.
        /// </summary>
        public int IdStyle { get; set; }

        /// <summary>
        /// Obtient ou définit le titre appartenant à ce style.
        /// </summary>
        [NotMapped]
        public Titre Titre { get; set; }

        /// <summary>
        /// Obtient ou définit le style appartenant à ce titre.
        /// </summary>
        [NotMapped]
        public Style Style { get; set; }
    }
}
