using System.Collections.Generic;
using System.Linq;
using Webzine.EntitiesContext;
using Webzine.Entity;
using Webzine.Repository.Contracts;

namespace Webzine.Repository.Db
{
    public class DbCommentaireRepository : ICommentaireRepository
    {

        WebzineDbContext Context;
        public DbCommentaireRepository(WebzineDbContext webzineDbContext)
        {
            Context = webzineDbContext;
        }
        /// <summary>
        /// Méthode pour ajouter un nouveau commentaire.
        /// </summary>
        /// <param name="commentaire">Le commentaire à ajouter.</param>
        public void Add(Commentaire commentaire)
        {
            commentaire.IdCommentaire = Context.Commentaires.Max(c => c.IdCommentaire) + 1;
            commentaire.Titre = Context.Titres.FirstOrDefault(t => t.IdTitre == commentaire.IdTitre);
            Context.Titres.First(t => t.IdTitre == commentaire.IdTitre).Commentaires.Add(commentaire);
            Context.Commentaires.Add(commentaire);
            Context.SaveChanges();
        }

        /// <summary>
        /// Méthode pour supprimer un commentaire.
        /// </summary>
        /// <param name="commentaire">Le commentaire à supprimer.</param>
        public void Delete(Commentaire commentaire)
        {
            Context.Commentaires.Remove(commentaire);
            Context.SaveChanges();
        }

        /// <summary>
        /// Méthode pour rechercher un commentaire par son index.
        /// </summary>
        /// <param name="id">L'index à chercher.</param>
        /// <returns>Le commentaire ayant l'index envoyé.</returns>
        public Commentaire Find(int id)
        {
            Commentaire commentaire = Context.Commentaires.FirstOrDefault(c => c.IdCommentaire == id);
            commentaire.Titre = Context.Titres.FirstOrDefault(t => t.IdTitre == commentaire.IdTitre);
            return commentaire;
        }

        /// <summary>
        /// Méthode pour récupérer tous les commentaires.
        /// </summary>
        /// <returns>La liste de tous les commentaires.</returns>
        public IEnumerable<Commentaire> FindAll()
        {
            var commentaires = Context.Commentaires;
            foreach(var commentaire in commentaires)
            {
                commentaire.Titre = Context.Titres.Single(t => t.IdTitre == commentaire.IdTitre);
            }
            return commentaires;
        }
    }
}
