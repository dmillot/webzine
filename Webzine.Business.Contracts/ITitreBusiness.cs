using System;
using System.Collections.Generic;
using System.Text;
using Webzine.Entity;

namespace Webzine.Business.Contracts
{
    public interface ITitreBusiness
    {
        /// <summary>
        /// Methode servant à ajouter un like à un titre.
        /// </summary>
        void LikeTitre(Titre titre);
    }
}
