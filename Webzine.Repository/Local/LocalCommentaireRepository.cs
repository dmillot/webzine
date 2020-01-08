using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Webzine.Entity;
using Webzine.Repository.Contracts;

namespace Webzine.Repository.Local
{
    public class LocalCommentaireRepository : ICommentaireRepository
    {
        public void Add(Commentaire commentaire)
        {
            commentaire.Titre = FactoryTitre.Titres.FirstOrDefault(t => t.IdTitre == commentaire.IdTitre);
            FactoryTitre.Titres.First(t => t.IdTitre == commentaire.IdTitre).Commentaires.Add(commentaire);
        }

        public void Delete(Commentaire commentaire)
        {
            FactoryTitre.Titres.First(t => t.IdTitre == commentaire.IdTitre).Commentaires.RemoveAll(c=>c.IdCommentaire == commentaire.IdCommentaire);
        }

        public Commentaire Find(int id)
        {
            Commentaire commentaire = FactoryCommentaire.Commentaires.FirstOrDefault(c => c.IdCommentaire == id);
            commentaire.Titre = FactoryTitre.Titres.FirstOrDefault(t => t.IdTitre == commentaire.IdTitre);
            return commentaire;
        }

        public IEnumerable<Commentaire> FindAll()
        {
            FactoryCommentaire.Commentaires.ForEach(c => c.Titre = FactoryTitre.Titres.First(t => t.IdTitre == c.IdTitre));
            return FactoryTitre.Commentaires;
        }
    }
}
