//-----------------------------------------------------------------------
// <copyright file="LocalArtisteRepository.cs" company="WebZinc">
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
    public class LocalArtisteRepository : IArtisteRepository
    {
        /// <summary>
        /// Méthode pour ajouter un nouvel artiste.
        /// </summary>
        /// <param name="artiste">L'artiste à ajouter.</param>
        public void Add(Artiste artiste)
        {
            FactoryArtiste.Artistes.Add(artiste);
        }

        /// <summary>
        /// Méthode pour supprimer un nouvel artiste.
        /// </summary>
        /// <param name="artiste">L'artiste à supprimer.</param>
        public void Delete(Artiste artiste)
        {
            FactoryArtiste.Artistes.Remove(FactoryArtiste.Artistes.Where(a => a.IdArtiste == artiste.IdArtiste).FirstOrDefault());
        }

        /// <summary>
        /// Méthode pour rechercher un artiste par son index.
        /// </summary>
        /// <param name="id">L'index à chercher.</param>
        /// <returns>L'artiste ayant l'index envoyé.</returns>
        public Artiste Find(int id) => FactoryArtiste.Artistes.Where(a => a.IdArtiste == id).FirstOrDefault();

        /// <summary>
        /// Méthode pour rechercher un artiste par son nom.
        /// </summary>
        /// <param name="name">Le nom à chercher.</param>
        /// <returns>L'artiste ayant le nom envoyé.</returns>
        public Artiste Find(string name)
        {
            return FactoryArtiste.Artistes.FirstOrDefault(a => a.Nom == name);
        }

        /// <summary>
        /// Méthode pour récupérer tous les artistes.
        /// </summary>
        /// <returns>La liste de tous les artistes.</returns>
        public IEnumerable<Artiste> FindAll() => FactoryArtiste.Artistes;

        /// <summary>
        /// Méthode pour chercher les artistes dont le nom contient le mot envoyé.
        /// </summary>
        /// <param name="mot">Le mot à rechercher.</param>
        /// <returns>La liste des artistes dont le nom contient le mot.</returns>
        public IEnumerable<Artiste> Search(string mot)
        {
            return FactoryArtiste.Artistes.FindAll(a => a.Nom.Contains(mot, System.StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Méthode pour modifier un artiste.
        /// </summary>
        /// <param name="artiste">L'artiste à modifier.</param>
        public void Update(Artiste artiste)
        {
            var rank = 0;
            foreach (var item in FactoryArtiste.Artistes)
            {
                if (item.IdArtiste == artiste.IdArtiste)
                {
                    artiste.Titres = item.Titres;
                    FactoryArtiste.Artistes[rank] = artiste;
                    break;
                }

                rank++;
            }
        }
    }
}
