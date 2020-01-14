﻿//-----------------------------------------------------------------------
// <copyright file="DbArtisteRepository.cs" company="WebZinc">
//     Copyright (c) WebZinc. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Webzine.Repository.Db
{
    using System.Collections.Generic;
    using System.Linq;
    using Webzine.EntitiesContext;
    using Webzine.Entity;
    using Webzine.Repository.Contracts;

    /// <summary>
    /// TO DO.
    /// </summary>
    public class DbArtisteRepository : IArtisteRepository
    {
        private WebzineDbContext context;

        public DbArtisteRepository(WebzineDbContext webzineDbContext)
        {
            this.context = webzineDbContext;
        }

        /// <summary>
        /// Méthode pour ajouter un nouvel artiste.
        /// </summary>
        /// <param name="artiste">L'artiste à ajouter.</param>
        public void Add(Artiste artiste)
        {
            this.context.Artistes.Add(artiste);
            this.context.SaveChanges();
        }

        /// <summary>
        /// Méthode pour supprimer un nouvel artiste.
        /// </summary>
        /// <param name="artiste">L'artiste à supprimer.</param>
        public void Delete(Artiste artiste)
        {
            this.context.Artistes.Remove(artiste);
            this.context.SaveChanges();
        }

        /// <summary>
        /// Méthode pour rechercher un artiste par son index.
        /// </summary>
        /// <param name="id">L'index à chercher.</param>
        /// <returns>L'artiste ayant l'index envoyé.</returns>
        public Artiste Find(int id)
        {
            return this.context.Artistes.Find(id);
        }

        /// <summary>
        /// Méthode pour récupérer tous les artistes.
        /// </summary>
        /// <returns>La liste de tous les artistes.</returns>
        public IEnumerable<Artiste> FindAll() => this.context.Artistes.AsEnumerable();

        /// <summary>
        /// Méthode pour chercher les artistes dont le nom contient le mot envoyé.
        /// </summary>
        /// <param name="mot">Le mot à rechercher.</param>
        /// <returns>La liste des artistes dont le nom contient le mot.</returns>
        public IEnumerable<Artiste> Search(string mot)
        {
            return this.FindAll().Where(a => a.Nom.Contains(mot, System.StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Méthode pour modifier un artiste.
        /// </summary>
        /// <param name="artiste">L'artiste à modifier.</param>
        public void Update(Artiste artiste)
        {
            this.context.Update(artiste);
            this.context.SaveChanges();
        }
    }
}
