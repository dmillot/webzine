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
        private string _nomCommentaire;
        private string _messageCommentaire;
        private Titre _titre;

        public string NomCommentaire { get => _nomCommentaire; set => _nomCommentaire = value; }
        public string MessageCommentaire { get => _messageCommentaire; set => _messageCommentaire = value; }
        public Titre Titre { get => _titre; set => _titre = value; }
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
            NomCommentaire = nomUtilisateur;
            MessageCommentaire = message;
            Titre = titre;
        }
    }
}
