﻿using System.Collections.Generic;
using Webzine.Entity;

namespace Webzine.Repository.Contracts
{
    public interface ICommentaireRepository
    {
        void Add(Commentaire commentaire);
        void Delete(Commentaire commentaire);
        IEnumerable<Commentaire> FindAll();
        Commentaire Find(int id);
    }
}
