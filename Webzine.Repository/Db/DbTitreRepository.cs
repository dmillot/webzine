using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Webzine.EntitiesContext;
using Webzine.Entity;
using Webzine.Repository.Contracts;

namespace Webzine.Repository.Db
{
    public class DbTitreRepository : ITitreRepository
    {

        WebzineDbContext Context;
        public DbTitreRepository(WebzineDbContext webzineDbContext)
        {
            Context = webzineDbContext;
        }
        /// <summary>
        /// Méthode pour ajouter un nouveau titre.
        /// </summary>
        /// <param name="titre">Le titre à ajouter.</param>
        public void Add(Titre titre)
        {
            Context.Titres.Add(titre);
        }

        /// <summary>
        /// Méthode pour compter le nombre total de titres.
        /// </summary>
        /// <returns>Le nombre total de titres.</returns>
        public int Count() => Context.Titres.Count();

        /// <summary>
        /// Méthode pour supprimer un titre.
        /// </summary>
        /// <param name="titre">Le titre à supprimer.</param>
        public void Delete(Titre titre)
        {
            Context.Titres.Remove(Context.Titres.Where(t => t.IdTitre == titre.IdTitre).FirstOrDefault());
        }

        /// <summary>
        /// Méthode pour rechercher un titre par son index.
        /// </summary>
        /// <param name="id">L'index à chercher.</param>
        /// <returns>Le titre ayant l'index envoyé.</returns>
        public Titre Find(int id)
        {
            var titre = Context.Titres
                .Include(n => n.TitresStyles).ThenInclude(n => n.Style)
                .Include(n => n.Artiste)
                .Include(n => n.Commentaires)
                .FirstOrDefault(t => t.IdTitre == id);


            /*var titre = Context.Titres.Where(t => t.IdTitre == id).FirstOrDefault();
            titre.TitresStyles = Context.TitresStyles.Where(t => t.IdTitre == titre.IdTitre).ToList();
            titre.Artiste = Context.Find<Artiste>(titre.IdArtiste);
            titre.Commentaires = Context.Commentaires.Where(c => c.IdTitre == titre.IdTitre).ToList();*/
            return titre;
        }

        /// <summary>
        /// Méthode pour récupérer les titres demandés (pour la pagination) triés selon la date de création (du plus récent à ancien).
        /// </summary>
        /// <param name="offset">Nombre de titres à ignorer.</param>
        /// <param name="limit">Nombre de titres à récuperer.</param>
        /// <returns>La liste des titres demandés triés selon la date de création.</returns>
        public IEnumerable<Titre> FindTitres(int offset, int limit)
        {
          return MakeLink(Context.Titres.OrderByDescending(t => t.DateCreation.Date).Skip(offset).Take(limit).ToList());
        }

        /// <summary>
        /// Méthode pour récupérer tous les titres.
        /// </summary>
        /// <returns>La liste de tous les titres.</returns>
        public IEnumerable<Titre> FindAll()
        {
            return MakeLink(Context.Titres).ToList();
        }

        /// <summary>
        /// Méthode pour ajouter une vue à un titre.
        /// </summary>
        /// <param name="titre">Le titre qui gagne une lecture.</param>
        public void IncrementNbLectures(Titre titre)
        {
            int nblectures = Context.Titres.Where(t => t == titre).Select(r => r.NbLectures).FirstOrDefault();
            nblectures++;
        }

        /// <summary>
        /// Méthode pour ajouter un like à un titre.
        /// </summary>
        /// <param name="titre">Le titre qui gagne un like.</param>
        public void IncrementNbLikes(Titre titre)
        {
            var nblikes = Context.Titres.Where(t => t == titre).Select(r => r.NbLikes).FirstOrDefault();
            nblikes++;
        }

        /// <summary>
        /// Méthode pour chercher les titres dont le nom contient le mot envoyé.
        /// </summary>
        /// <param name="mot">Le mot à rechercher.</param>
        /// <returns>La liste des titres dont le nom contient le mot.</returns>
        public IEnumerable<Titre> Search(string mot)
        {
            return MakeLink( Context.Titres.Where(t => t.Libelle.Contains(mot, StringComparison.OrdinalIgnoreCase)));
        }

        /// <summary>
        /// Méthode pour chercher les titres rattachés au style envoyé.
        /// </summary>
        /// <param name="libelle">Le nom du style à rechercher.</param>
        /// <returns>La liste des titres qui correspondent au style envoyé.</returns>
        public IEnumerable<Titre> SearchByStyle(string libelle)
        {
            return this.FindAll().Where(t => t.TitresStyles.Select(s => s.Style.Libelle).ToString() == libelle).ToList();
        }

        /// <summary>
        /// Méthode pour modifier un titre.
        /// </summary>
        /// <param name="titre">Le titre à modifier.</param>
        public void Update(Titre titre)
        {
            var rank = 0;
            foreach (var item in FactoryTitre.Titres)
            {
                if (item.IdTitre == titre.IdTitre)
                {
                    if (titre.Libelle == null)
                    {
                        titre.Libelle = item.Libelle;
                    }
                    if (titre.Chronique == null)
                    {
                        titre.Chronique = item.Chronique;
                    }
                    if (titre.Duree == 0)
                    {
                        titre.Duree = item.Duree;
                    }
                    if (titre.Artiste == null)
                    {
                        titre.Artiste = item.Artiste;
                    }
                    if (titre.DateSortie == null)
                    {
                        titre.DateSortie = item.DateSortie;
                    }
                    if (titre.UrlJaquette == null)
                    {
                        titre.UrlJaquette = item.UrlJaquette;
                    }
                    if (titre.UrlEcoute == null)
                    {
                        titre.UrlEcoute = item.UrlEcoute;
                    }

                    titre.TitresStyles = item.TitresStyles;
                    titre.Commentaires = item.Commentaires;
                    FactoryTitre.Titres[rank] = titre;
                    break;
                }

                rank++;
            }
        }

        /// <summary>
        /// Méthode pour récupérer les titres les plus populaires qui ont été crée entre la date envoyée et maintenant.
        /// </summary>
        /// <param name="dateRecherche">La date à ne pas dépasser dans la recherche.</param>
        /// <returns>La liste des titres les plus populaires.</returns>
        public IEnumerable<Titre> GetPopular(DateTime dateRecherche)
        {
            var titres =  Context.Titres.OrderByDescending(t => t.NbLikes).Where(r => r.DateCreation > dateRecherche).Take(3).ToList();
            
            return MakeLink(titres);
        }

        private IEnumerable<Titre> MakeLink( IEnumerable<Titre> titres)
        {
            foreach (var titre in titres)
            {
                titre.Artiste = Context.Find<Artiste>(titre.IdArtiste);
                titre.TitresStyles = Context.TitresStyles.Where(t => t.IdTitre == titre.IdTitre).ToList();
                titre.TitresStyles.ForEach(n => { n.Style = Context.Styles.Find(n.IdStyle); });
                titre.Commentaires = Context.Commentaires.Where(c => c.IdTitre == titre.IdTitre).ToList();
            }
            return titres;
        }
    }
}
