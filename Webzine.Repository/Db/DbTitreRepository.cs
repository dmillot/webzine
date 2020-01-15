
namespace Webzine.Repository.Db
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Webzine.EntitiesContext;
    using Webzine.Entity;
    using Webzine.Repository.Contracts;

    public class DbTitreRepository : ITitreRepository
    {

        WebzineDbContext context;
        public DbTitreRepository(WebzineDbContext webzineDbContext)
        {
            context = webzineDbContext;
        }

        /// <summary>
        /// Méthode pour ajouter un nouveau titre.
        /// </summary>
        /// <param name="titre">Le titre à ajouter.</param>
        public void Add(Titre titre)
        {
            var idStyles = titre.TitresStyles.Select(s => s.IdStyle);
            titre.TitresStyles = null;
            this.context.Titres.Add(titre);
            titre.TitresStyles = new List<TitreStyle>();
            try
            {
                this.context.SaveChanges();
                foreach (int idSyle in idStyles)
                {
                    titre.TitresStyles.Add(new TitreStyle()
                    {
                        IdStyle = idSyle,
                        IdTitre = titre.IdTitre
                    });
                }

                try
                {
                    this.context.SaveChanges();
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
                
            } catch (Exception e)
            {
                Console.WriteLine(e);
            }


            
        }

        /// <summary>
        /// Méthode pour compter le nombre total de titres.
        /// </summary>
        /// <returns>Le nombre total de titres.</returns>
        public int Count() => context.Titres.Count();

        /// <summary>
        /// Méthode pour supprimer un titre.
        /// </summary>
        /// <param name="titre">Le titre à supprimer.</param>
        public void Delete(Titre titre)
        {
            context.Titres.Remove(titre);
            context.SaveChanges();
        }

        /// <summary>
        /// Méthode pour rechercher un titre par son index.
        /// </summary>
        /// <param name="id">L'index à chercher.</param>
        /// <returns>Le titre ayant l'index envoyé.</returns>
        public Titre Find(int id)
        {
          return context.Titres
                .Include(n => n.TitresStyles).ThenInclude(n => n.Style)
                .Include(n => n.Artiste)
                .Include(n => n.Commentaires)
                .FirstOrDefault(t => t.IdTitre == id);
        }

        /// <summary>
        /// Méthode pour récupérer les titres demandés (pour la pagination) triés selon la date de création (du plus récent à ancien).
        /// </summary>
        /// <param name="offset">Nombre de titres à ignorer.</param>
        /// <param name="limit">Nombre de titres à récuperer.</param>
        /// <returns>La liste des titres demandés triés selon la date de création.</returns>
        public IEnumerable<Titre> FindTitres(int offset, int limit)
        {
            return Context.Titres.OrderBy(t => t.DateCreation.Date)
                  .Skip(offset)
                  .Take(limit)
                  .Include(r => r.Commentaires)
                  .Include(r => r.TitresStyles)
                  .ThenInclude(r => r.Style)
                  .Include(r => r.Artiste)
                  .ToList();
        }

        /// <summary>
        /// Méthode pour récupérer tous les titres.
        /// </summary>
        /// <returns>La liste de tous les titres.</returns>
        public IEnumerable<Titre> FindAll()
        {
            return context.Titres
                .Include(r => r.Commentaires)
                .Include(r => r.TitresStyles).ThenInclude(r=>r.Style)
                .Include(r => r.Artiste)
                .ToList();
        }

        /// <summary>
        /// Méthode pour ajouter une vue à un titre.
        /// </summary>
        /// <param name="titre">Le titre qui gagne une lecture.</param>
        public void IncrementNbLectures(Titre titre)
        {
            titre.NbLectures++;
            this.context.Update(titre);
            this.context.SaveChanges();
        }

        /// <summary>
        /// Méthode pour ajouter un like à un titre.
        /// </summary>
        /// <param name="titre">Le titre qui gagne un like.</param>
        public void IncrementNbLikes(Titre titre)
        {
            titre.NbLikes++;
            this.context.Update(titre);
            this.context.SaveChanges();

        }

        /// <summary>
        /// Méthode pour chercher les titres dont le nom contient le mot envoyé.
        /// </summary>
        /// <param name="mot">Le mot à rechercher.</param>
        /// <returns>La liste des titres dont le nom contient le mot.</returns>
        public IEnumerable<Titre> Search(string mot)
        {

            return context.Titres.Where(t => t.Libelle.Contains(mot))
                .Include(r => r.Commentaires)
                .Include(r => r.TitresStyles)
                .ToList();
        }

        /// <summary>
        /// Méthode pour chercher les titres rattachés au style envoyé.
        /// </summary>
        /// <param name="libelle">Le nom du style à rechercher.</param>
        /// <returns>La liste des titres qui correspondent au style envoyé.</returns>
        public IEnumerable<Titre> SearchByStyle(string libelle)
        {
            return this.FindAll().Where(t => t.TitresStyles.Any(s => s.Style.Libelle == libelle)).ToList();
        }

        /// <summary>
        /// Méthode pour modifier un titre.
        /// </summary>
        /// <param name="titre">Le titre à modifier.</param>
        public void Update(Titre titre)
        {
            this.Context.Titres.Update(titre);
            this.Context.SaveChanges();
        }

        /// <summary>
        /// Méthode pour récupérer les titres les plus populaires qui ont été crée entre la date envoyée et maintenant.
        /// </summary>
        /// <param name="dateRecherche">La date à ne pas dépasser dans la recherche.</param>
        /// <returns>La liste des titres les plus populaires.</returns>
        public IEnumerable<Titre> GetPopular(DateTime dateRecherche)
        {
            return context.Titres
            .OrderByDescending(t => t.NbLikes)
            .Where(r => r.DateCreation > dateRecherche)
            .Take(3)
            .Include(r => r.Commentaires)
            .Include(r => r.TitresStyles)
            .Include(r => r.Artiste)
            .ToList();
        }
    }
}