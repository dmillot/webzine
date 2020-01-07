﻿using System.Collections.Generic;
using Webzine.Entity;

namespace Webzine.Repository.Contracts
{
    public interface ITitreRepository
    {
        void Add(Titre titre);
        int Count();
        void Delete(Titre titre);
        Titre Find(int id);
        IEnumerable<Titre> FindAll();
        void IncrementNbLectures(Titre titre);
        void IncrementNbLikes(Titre titre);
        IEnumerable<Titre> Search(string mot);
        IEnumerable<Titre> SearchByStyle(string libelle);
        void Update(Titre titre);
    }
}
