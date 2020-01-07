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
            FactoryTitre.Titres.Remove(titre);
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
            int nblikes = FactoryTitre.Titres.Where(t => t == titre).Select(r => r.NbLikes).FirstOrDefault();
            nblikes++;
        }

        /// <summary>
        /// Permet de rechercher un titre dans notre jeu de données
        /// </summary>
        /// <param name="mot"></param>
        /// <returns> Retourne une liste de Titres </returns>
        public IEnumerable<Titre> Search(string mot)
        {
            return FactoryTitre.Titres.FindAll(t => t.Libelle.Contains(mot));
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
            this.Delete(titre);
            this.Add(titre);
        }
    }
}
