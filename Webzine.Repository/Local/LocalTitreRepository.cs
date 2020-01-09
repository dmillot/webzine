using System;
using System.Collections.Generic;
using System.Linq;
using Webzine.Entity;
using Webzine.Repository.Contracts;

namespace Webzine.Repository.Local
{
    public class LocalTitreRepository : ITitreRepository
    {
        /// <summary>
        /// Permet d'ajouter un style dans notre jeu données
        /// </summary>
        /// <param name="titre"></param>
        public void Add(Titre titre)
        {
            FactoryTitre.Titres.Add(titre);
        }

        /// <summary>
        /// Permet de récupérer le nombre de titre dans notre jeu de données
        /// </summary>
        /// <returns> Retourne le nombre total de Titres</returns>
        public int Count() => FactoryTitre.Titres.Count;
        
        /// <summary>
        /// Permet de supprimer un titre de notre jeu de données
        /// </summary>
        /// <param name="titre"></param>
        public void Delete(Titre titre)
        {
            FactoryTitre.Titres.Remove(FactoryTitre.Titres.Where(t=>t.IdTitre == titre.IdTitre).FirstOrDefault());
        }

        /// <summary>
        /// Permet de trouver un titre précis dans notre jeu de données
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Retourne un Titre </returns>
        public Titre Find(int id)
        {
            return FactoryTitre.Titres.Where(t => t.IdTitre == id).FirstOrDefault();
        }
        /// <summary>
        /// Permet de récuperer une séquence de titre limitée à partir à partir 
        /// </summary>
        /// <param name="offset">Nombre d'éléments à ignorer</param>
        /// <param name="limit">Nombre d'éléments à récupérer</param>
        /// <returns>Renvoie un nombre de titre définit par la limite</returns>
        public IEnumerable<Titre> FindTitres(int offset, int limit)
        {
            return FactoryTitre.Titres.OrderByDescending(t => t.DateCreation.Date).Skip(offset).Take(limit).ToList();
        }
        /// <summary>
        /// Retourne les titres présents dans notre jeu de données
        /// </summary>
        /// <returns> Retourne une liste de Titres </returns>
        public IEnumerable<Titre> FindAll()
        {
            return FactoryTitre.Titres;
        }

        /// <summary>
        /// Permet d'incrémenter le nombre de lecture d'un titre dans notre jeu de données
        /// </summary>
        /// <param name="titre"></param>
        public void IncrementNbLectures(Titre titre)
        {
            int nblectures = FactoryTitre.Titres.Where(t => t == titre).Select(r => r.NbLectures).FirstOrDefault();
            nblectures++;
        }

        /// <summary>
        /// Permet d'incrémenter le nombre de likes d'un titre dans notre jeu de données
        /// </summary>
        /// <param name="titre"></param>
        public void IncrementNbLikes(Titre titre)
        {
            var nblikes = FactoryTitre.Titres.Where(t => t == titre).Select(r => r.NbLikes).FirstOrDefault();
            nblikes++;
        }

        /// <summary>
        /// Permet de rechercher un titre dans notre jeu de données
        /// </summary>
        /// <param name="mot"></param>
        /// <returns> Retourne une liste de Titres </returns>
        public IEnumerable<Titre> Search(string mot)
        {
            return FactoryTitre.Titres.FindAll(t => t.Libelle.Contains(mot, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Permet de rechercher un style dans notre jeu de données
        /// </summary>
        /// <param name="libelle"></param>
        /// <returns>c Retourne une liste de Titres </returns>
        public IEnumerable<Titre> SearchByStyle(string libelle)
        {
            return this.FindAll().Where(t => t.TitresStyles.Select(s => s.Libelle).ToString() == libelle).ToList();
        }

        /// <summary>
        /// Permet de de mettre à jour un titre dans notre jeu de données
        /// </summary>
        /// <param name="titre"></param>
        public void Update(Titre titre)
        {
            var rank = 0;
            foreach (var item in FactoryTitre.Titres)
            {
                if (item.IdTitre == titre.IdTitre)
                {
                    titre.TitresStyles = item.TitresStyles;
                    titre.Commentaires = item.Commentaires;
                    FactoryTitre.Titres[rank] = titre;
                    break;
                }
                rank++;
            }
        }
        /// <summary>
        /// Permet de récupérer les 3 titres les plus aimés à partir d'une certaine date
        /// </summary>
        /// <param name="dateRecherche">La date après laquelle on souhaite récuperer nos titres</param>
        /// <returns>Retourne une liste de 3 titres classé du plus aimé au moins aimé</returns>
        public IEnumerable<Titre> GetPopular(DateTime dateRecherche)
        {
            return FactoryTitre.Titres.OrderByDescending(t => t.NbLikes).Where(r => r.DateCreation > dateRecherche).Take(3).ToList();
        }
    }
}
