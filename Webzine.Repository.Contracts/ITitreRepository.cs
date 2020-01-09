using System;
using System.Collections.Generic;
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
        IEnumerable<Titre> FindTitres(int offset, int limit);
        void IncrementNbLectures(Titre titre);
        void IncrementNbLikes(Titre titre);
        IEnumerable<Titre> Search(string mot);
        IEnumerable<Titre> SearchByStyle(string libelle);
        IEnumerable<Titre> GetPopular(DateTime dateRecherche);
        void Update(Titre titre);
    }
}
