//-----------------------------------------------------------------------
// <copyright file="IStyleRepository.cs" company="WebZinc">
//     Copyright (c) WebZinc. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Webzine.Repository.Contracts
{
    using System.Collections.Generic;
    using Webzine.Entity;

    /// <summary>
    /// TO DO.
    /// </summary>
    public interface IStyleRepository 
    {
        /// <summary>
        /// Méthode pour ajouter un nouveau style.
        /// </summary>
        /// <param name="style">Le style à ajouter.</param>
        void Add(Style style);

        /// <summary>
        /// Méthode pour supprimer un style.
        /// </summary>
        /// <param name="style">Le style à supprimer.</param>
        void Delete(Style style);

        /// <summary>
        /// Méthode pour rechercher un style par son index.
        /// </summary>
        /// <param name="id">L'index à chercher.</param>
        /// <returns>Le style ayant l'index envoyé.</returns>
        Style Find(int id);

        /// <summary>
        /// Méthode pour rechercher un style par son nom.
        /// </summary>
        /// <param name="libelle">Le nom à chercher.</param>
        /// <returns>Le style ayant le nom envoyé.</returns>
        Style Find(string libelle);

        /// <summary>
        /// Méthode pour récupérer tous les styles.
        /// </summary>
        /// <returns>La liste de tous les styles.</returns>
        IEnumerable<Style> FindAll();

        /// <summary>
        /// Méthode pour modifier un style.
        /// </summary>
        /// <param name="style">Le style à modifier.</param>
        void Update(Style style);
    }
}
