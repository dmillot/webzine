//-----------------------------------------------------------------------
// <copyright file="DbStyleRepository.cs" company="WebZinc">
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

    public class DbStyleRepository : IStyleRepository
    {
        WebzineDbContext context;
        public DbStyleRepository (WebzineDbContext webzineDbContext)
        {
            this.context = webzineDbContext;
        }
        /// <summary>
        /// Méthode pour ajouter un nouveau style.
        /// </summary>
        /// <param name="style">Le style à ajouter.</param>
        public void Add(Style style)
        {

            this.context.Styles.Add(style);
            this.context.SaveChanges();
        }

        /// <summary>
        /// Méthode pour supprimer un style.
        /// </summary>
        /// <param name="style">Le style à supprimer.</param>
        public void Delete(Style style)
        {
            this.context.Styles.Remove(style);
            this.context.SaveChanges();
        }

        /// <summary>
        /// Méthode pour rechercher un style par son index.
        /// </summary>
        /// <param name="id">L'index à chercher.</param>
        /// <returns>Le style ayant l'index envoyé.</returns>
        public Style Find(int id)
        {
            return this.context.Styles.Where(s => s.IdStyle == id).FirstOrDefault();
        }

        /// <summary>
        /// Méthode pour rechercher un style par son nom.
        /// </summary>
        /// <param name="libelle">Le nom à chercher.</param>
        /// <returns>Le style ayant le nom envoyé.</returns>
        public Style Find(string libelle)
        {
            return this.context.Styles.Where(s => s.Libelle == libelle).FirstOrDefault();
        }

        /// <summary>
        /// Méthode pour récupérer tous les styles.
        /// </summary>
        /// <returns>La liste de tous les styles.</returns>
        public IEnumerable<Style> FindAll()
        {
            return this.context.Styles
                .Include(r => r.TitresStyles)
                .ToList();
        }

        /// <summary>
        /// Méthode pour modifier un style.
        /// </summary>
        /// <param name="style">Le style à modifier.</param>
        public void Update(Style style)
        {
            this.context.Update(style);
            this.context.SaveChanges();

        }
    }
}
