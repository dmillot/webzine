//-----------------------------------------------------------------------
// <copyright file="IArtisteRepository.cs" company="WebZinc">
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
    public interface IArtisteRepository
    {
        /// <summary>
        /// Méthode pour ajouter un nouvel artiste.
        /// </summary>
        /// <param name="artiste">L'artiste à ajouter.</param>
        void Add(Artiste artiste);

        /// <summary>
        /// Méthode pour supprimer un nouvel artiste.
        /// </summary>
        /// <param name="artiste">L'artiste à supprimer.</param>
        void Delete(Artiste artiste);

        /// <summary>
        /// Méthode pour rechercher un artiste par son index.
        /// </summary>
        /// <param name="id">L'index à chercher.</param>
        /// <returns>L'artiste ayant l'index envoyé.</returns>
        Artiste Find(int id);

        /// <summary>
        /// Méthode pour rechercher un artiste par son nom.
        /// </summary>
        /// <param name="id">L'index à chercher.</param>
        /// <returns>L'artiste ayant l'index envoyé.</returns>
        Artiste Find(string name);

        /// <summary>
        /// Méthode pour récupérer tous les artistes.
        /// </summary>
        /// <returns>La liste de tous les artistes.</returns>
        IEnumerable<Artiste> FindAll();

        /// <summary>
        /// Méthode pour chercher les artistes dont le nom contient le mot envoyé.
        /// </summary>
        /// <param name="mot">Le mot à rechercher.</param>
        /// <returns>La liste des artistes dont le nom contient le mot.</returns>
        IEnumerable<Artiste> Search(string mot);

        /// <summary>
        /// Méthode pour modifier un artiste.
        /// </summary>
        /// <param name="artiste">L'artiste à modifier.</param>
        void Update(Artiste artiste);
    }
}
