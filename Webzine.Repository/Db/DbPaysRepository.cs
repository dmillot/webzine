//-----------------------------------------------------------------------
// <copyright file="DbPaysRepository.cs" company="WebZinc">
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

    public class DbPaysRepository : IPaysRepository
    {
        private WebzineDbContext context;

        public DbPaysRepository(WebzineDbContext webzineDbContext)
        {
            this.context = webzineDbContext;
        }

        /// <summary>
        /// Méthode pour ajouter un nouveau pays.
        /// </summary>
        /// <param name="pays">Le pays à ajouter.</param>
        public void Add(Pays pays)
        {
            this.context.Pays.Add(pays);
            this.context.SaveChanges();
        }

        /// <summary>
        /// Méthode pour supprimer un pays.
        /// </summary>
        /// <param name="artiste">Le pays à supprimer.</param>
        public void Delete(Pays pays)
        {
            this.context.Pays.Remove(pays);
            this.context.SaveChanges();
        }

        /// <summary>
        /// Méthode pour rechercher un pays par son index.
        /// </summary>
        /// <param name="id">L'index à chercher.</param>
        /// <returns>Le pays ayant l'index envoyé.</returns>
        public Pays Find(int id)
        {
            return this.context.Pays.Where(p => p.IdPays == id).Include(r => r.Artistes).FirstOrDefault();
        }

        /// <summary>
        /// Méthode pour récupérer tous les pays.
        /// </summary>
        /// <returns>La liste de tous les pays.</returns>
        public IEnumerable<Pays> FindAll()
        {
            return this.context.Pays.Include(r => r.Artistes).ToList();
        }

        /// <summary>
        /// Méthode pour modifier un pays.
        /// </summary>
        /// <param name="pays">Le pays à modifier.</param>
        public void Update(Pays pays)
        {
            this.context.Pays.Update(pays);
            this.context.SaveChanges();
        }
    }
}
