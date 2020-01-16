//-----------------------------------------------------------------------
// <copyright file="IPaysRepository.cs" company="WebZinc">
//     Copyright (c) WebZinc. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Webzine.Repository.Contracts
{
    using System.Collections.Generic;
    using Webzine.Entity;

    public interface IPaysRepository
    {
        /// <summary>
        /// Méthode pour ajouter un nouveau pays.
        /// </summary>
        /// <param name="pays">Le pays à ajouter.</param>
        void Add(Pays pays);

        /// <summary>
        /// Méthode pour supprimer un pays.
        /// </summary>
        /// <param name="pays">Le pays à supprimer.</param>
        void Delete(Pays pays);

        /// <summary>
        /// Méthode pour rechercher un pays par son index.
        /// </summary>
        /// <param name="id">L'index à chercher.</param>
        /// <returns>Le pays ayant l'index envoyé.</returns>
        Pays Find(int id);

        /// <summary>
        /// Méthode pour récupérer tous les pays.
        /// </summary>
        /// <returns>La liste de tous les pays.</returns>
        IEnumerable<Pays> FindAll();

        /// <summary>
        /// Méthode pour modifier un pays.
        /// </summary>
        /// <param name="pays">Le pays à modifier.</param>
        void Update(Pays pays);
    }
}
