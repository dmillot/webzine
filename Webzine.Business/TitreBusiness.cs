using System;
using Webzine.Business.Contracts;
using Webzine.Entity;
using Webzine.Repository.Contracts;

namespace Webzine.Business
{
    public class TitreBusiness : ITitreBusiness
    {
        ITitreRepository _titreRepository;
        public TitreBusiness(ITitreRepository titreRepository)
        {
            _titreRepository = titreRepository;
        }
        void ITitreBusiness.LikeTitre(Titre titre)
        {
            _titreRepository.IncrementNbLikes(titre);
        }
    }
}
