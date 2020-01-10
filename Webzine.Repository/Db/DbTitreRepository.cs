using System;
using System.Collections.Generic;
using Webzine.Entity;
using Webzine.Repository.Contracts;

namespace Webzine.Repository.Db
{
    public class DbTitreRepository : ITitreRepository
    {
        public void Add(Titre titre)
        {
            throw new NotImplementedException();
        }

        public int Count()
        {
            throw new NotImplementedException();
        }

        public void Delete(Titre titre)
        {
            throw new NotImplementedException();
        }

        public Titre Find(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Titre> FindAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Titre> FindTitres(int offset, int limit)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Titre> GetPopular(DateTime dateRecherche)
        {
            throw new NotImplementedException();
        }

        public void IncrementNbLectures(Titre titre)
        {
            throw new NotImplementedException();
        }

        public void IncrementNbLikes(Titre titre)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Titre> Search(string mot)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Titre> SearchByStyle(string libelle)
        {
            throw new NotImplementedException();
        }

        public void Update(Titre titre)
        {
            throw new NotImplementedException();
        }
    }
}
