//-----------------------------------------------------------------------
// <copyright file="ICommentaireRepository.cs" company="WebZinc">
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
    public interface ICommentaireRepository
    {
        /// <summary>
        /// Méthode pour ajouter un nouveau commentaire.
        /// </summary>
        /// <param name="commentaire">Le commentaire à ajouter.</param>
        void Add(Commentaire commentaire);

        /// <summary>
        /// Méthode pour supprimer un commentaire.
        /// </summary>
        /// <param name="commentaire">Le commentaire à supprimer.</param>
        void Delete(Commentaire commentaire);

        /// <summary>
        /// Méthode pour récupérer tous les commentaires.
        /// </summary>
        /// <returns>La liste de tous les commentaires.</returns>
        IEnumerable<Commentaire> FindAll();

        /// <summary>
        /// Méthode pour rechercher un commentaire par son index.
        /// </summary>
        /// <param name="id">L'index à chercher.</param>
        /// <returns>Le commentaire ayant l'index envoyé.</returns>
        Commentaire Find(int id);
    }
}
