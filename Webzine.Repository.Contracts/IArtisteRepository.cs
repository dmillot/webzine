using System.Collections.Generic;
using Webzine.Entity;

namespace Webzine.Repository.Contracts
{
    public interface IArtisteRepository
    {
        void Add(Artiste artiste);
        void Delete(Artiste artiste);
        Artiste Find(int id);  
        IEnumerable<Artiste> FindAll();
        IEnumerable<Artiste> Search(string mot);
        void Update(Artiste artiste);
    }
}
