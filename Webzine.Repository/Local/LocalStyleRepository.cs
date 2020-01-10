//-----------------------------------------------------------------------
// <copyright file="LocalStyleRepository.cs" company="WebZinc">
//     Copyright (c) WebZinc. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace Webzine.Repository.Local
{
    using System.Collections.Generic;
    using System.Linq;
    using Webzine.Entity;
    using Webzine.Repository.Contracts;

    /// <summary>
    /// TO DO.
    /// </summary>
    public class LocalStyleRepository : IStyleRepository
    {
        /// <summary>
        /// Méthode pour ajouter un nouveau style.
        /// </summary>
        /// <param name="style">Le style à ajouter.</param>
        public void Add(Style style)
        {
            style.IdStyle = FactoryStyle.Styles.Count() + 1;
            FactoryStyle.Styles.Add(style);
        }

        /// <summary>
        /// Méthode pour supprimer un style.
        /// </summary>
        /// <param name="style">Le style à supprimer.</param>
        public void Delete(Style style)
        {
            FactoryStyle.Styles.Remove(this.Find(style.IdStyle));
        }

        /// <summary>
        /// Méthode pour rechercher un style par son index.
        /// </summary>
        /// <param name="id">L'index à chercher.</param>
        /// <returns>Le style ayant l'index envoyé.</returns>
        public Style Find(int id)
        {
            return FactoryStyle.Styles.Where(s => s.IdStyle == id).FirstOrDefault();
        }

        /// <summary>
        /// Méthode pour rechercher un style par son nom.
        /// </summary>
        /// <param name="libelle">Le nom à chercher.</param>
        /// <returns>Le style ayant le nom envoyé.</returns>
        public Style Find(string libelle)
        {
            return FactoryStyle.Styles.Where(s => s.Libelle == libelle).FirstOrDefault();
        }

        /// <summary>
        /// Méthode pour récupérer tous les styles.
        /// </summary>
        /// <returns>La liste de tous les styles.</returns>
        public IEnumerable<Style> FindAll()
        {
            return FactoryStyle.Styles;
        }

        /// <summary>
        /// Méthode pour modifier un style.
        /// </summary>
        /// <param name="style">Le style à modifier.</param>
        public void Update(Style style)
        {
            var pos = 0;
            foreach (var item in FactoryStyle.Styles)
            {
                if (item.IdStyle == style.IdStyle)
                {
                    style.TitresStyles = item.TitresStyles;
                    FactoryStyle.Styles[pos] = style;
                    break;
                }

                pos++;
            }
        }
    }
}
