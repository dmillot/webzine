//-----------------------------------------------------------------------
// <copyright file="DbCommentaireRepository.cs" company="WebZinc">
//     Copyright (c) WebZinc. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Webzine.Repository.Db
{
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using Webzine.EntitiesContext;
    using Webzine.Entity;
    using Webzine.Repository.Contracts;

    public class DbCommentaireRepository : ICommentaireRepository
    {
        private WebzineDbContext context;

        public DbCommentaireRepository(WebzineDbContext webzineDbContext)
        {
            this.context = webzineDbContext;
        }

        /// <summary>
        /// Méthode pour ajouter un nouveau commentaire.
        /// </summary>
        /// <param name="commentaire">Le commentaire à ajouter.</param>
        public void Add(Commentaire commentaire)
        {
            context.Commentaires.Add(commentaire);
            context.SaveChanges();
        }

        /// <summary>
        /// Méthode pour supprimer un commentaire.
        /// </summary>
        /// <param name="commentaire">Le commentaire à supprimer.</param>
        public void Delete(Commentaire commentaire)
        {
            this.context.Commentaires.Remove(commentaire);
            this.context.SaveChanges();
        }

        /// <summary>
        /// Méthode pour rechercher un commentaire par son index.
        /// </summary>
        /// <param name="id">L'index à chercher.</param>
        /// <returns>Le commentaire ayant l'index envoyé.</returns>
        public Commentaire Find(int id)
        {
           return this.context.Commentaires.Where(c => c.IdCommentaire == id).Include(r => r.Titre).FirstOrDefault();
        }

        /// <summary>
        /// Méthode pour récupérer tous les commentaires.
        /// </summary>
        /// <returns>La liste de tous les commentaires.</returns>
        public IEnumerable<Commentaire> FindAll()
        {
            return this.context.Commentaires.Include(t => t.Titre);        
        }
    }
}
