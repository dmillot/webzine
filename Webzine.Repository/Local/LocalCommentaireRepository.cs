//-----------------------------------------------------------------------
// <copyright file="LocalCommentaireRepository.cs" company="WebZinc">
//     Copyright (c) WebZinc. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Webzine.Repository.Local
{
    using System.Collections.Generic;
    using System.Linq;
    using Webzine.EntitiesContext;
    using Webzine.Entity;
    using Webzine.Repository.Contracts;

    /// <summary>
    /// TO DO.
    /// </summary>
    public class LocalCommentaireRepository : ICommentaireRepository
    {
        /// <summary>
        /// Méthode pour ajouter un nouveau commentaire.
        /// </summary>
        /// <param name="commentaire">Le commentaire à ajouter.</param>
        public void Add(Commentaire commentaire)
        {
            commentaire.IdCommentaire = FactoryCommentaire.Commentaires.Max(c => c.IdCommentaire) + 1;
            commentaire.Titre = FactoryTitre.Titres.FirstOrDefault(t => t.IdTitre == commentaire.IdTitre);
            FactoryTitre.Titres.First(t => t.IdTitre == commentaire.IdTitre).Commentaires.Add(commentaire);
            FactoryCommentaire.Commentaires.Add(commentaire);
        }

        /// <summary>
        /// Méthode pour supprimer un commentaire.
        /// </summary>
        /// <param name="commentaire">Le commentaire à supprimer.</param>
        public void Delete(Commentaire commentaire)
        {
            FactoryTitre.Titres.First(t => t.IdTitre == commentaire.IdTitre).Commentaires.RemoveAll(c => c.IdCommentaire == commentaire.IdCommentaire);
        }

        /// <summary>
        /// Méthode pour rechercher un commentaire par son index.
        /// </summary>
        /// <param name="id">L'index à chercher.</param>
        /// <returns>Le commentaire ayant l'index envoyé.</returns>
        public Commentaire Find(int id)
        {
            Commentaire commentaire = FactoryCommentaire.Commentaires.FirstOrDefault(c => c.IdCommentaire == id);
            commentaire.Titre = FactoryTitre.Titres.FirstOrDefault(t => t.IdTitre == commentaire.IdTitre);
            return commentaire;
        }

        /// <summary>
        /// Méthode pour récupérer tous les commentaires.
        /// </summary>
        /// <returns>La liste de tous les commentaires.</returns>
        public IEnumerable<Commentaire> FindAll()
        {
            FactoryCommentaire.Commentaires.ForEach(c => c.Titre = FactoryTitre.Titres.First(t => t.IdTitre == c.IdTitre));
            return FactoryTitre.Commentaires;
        }
    }
}
