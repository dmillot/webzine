using System.Collections.Generic;
using Webzine.Entity;

namespace Webzine.Repository.Contracts
{
    public interface IStyleRepository 
    {
        void Add(Style style);
        void Delete(Style style);
        Style Find(int id);
        Style Find(string libelle);
        IEnumerable<Style> FindAll();
        void Update(Style style);
    }
}
