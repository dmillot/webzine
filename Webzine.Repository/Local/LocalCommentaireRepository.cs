using System;
using System.Collections.Generic;
using System.Text;
using Webzine.Entity;
using Webzine.Repository.Contracts;

namespace Webzine.Repository.Local
{
    public class LocalCommentaireRepository : ICommentaireRepository
    {
        public void Add(Commentaire commentaire)
        {
            FactoryCommentaire.Commentaires.Add(commentaire);
        }

        public void Delete(Commentaire commentaire)
        {
            FactoryCommentaire.Commentaires.Remove(commentaire);
        }

        public IEnumerable<Commentaire> FindAll()
        {
            return FactoryCommentaire.Commentaires;
        }
    }
}
