using System;
using System.Collections.Generic;
using System.Text;

namespace Webzine.Entity
{
    /// <summary>
    /// Une réaction à une chronique sur un titre
    /// </summary>
    public class Commentaire
    {
        public string Message { get; set; }
        public Titre Title { get; set; }
        public string Username { get; set; }
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Constructeur vide
        /// </summary>
        public Commentaire()
        {

        }
        /// <summary>
        /// Constructeur paramétré pour la création d'un commentaire
        /// </summary>
        /// <param name="nomUtilisateur">Le nom de l'utilisateur ayant posté le commentaire</param>
        /// <param name="message">Le commentaire en lui même</param>
        /// <param name="titre">Le titre sur lequel le commentaire a été publié</param>
        public Commentaire(string nomUtilisateur, string message, Titre titre)
        {
            Username = nomUtilisateur;
            Message = message;
            Title = titre;
        }
    }
}
