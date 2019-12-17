using System;
using System.Collections.Generic;
using System.Text;

namespace Webzine.Entity
{
    /// <summary>
    /// Title représente un titre musical appartenant à un artiste
    /// </summary>
    public class Titre
    {
        private string _trackTitle;
        private string _trackDescription;
        private Artiste _author;
        private List<Commentaire> _comments;
        private List<Style> _styles;

        public string TrackTitle { get => _trackTitle; set => _trackTitle = value; }
        public string TrackDescription { get => _trackDescription; set => _trackDescription = value; }
        public Artiste Author { get => _author; set => _author = value; }
        public List<Commentaire> Comments { get => _comments; set => _comments = value; }
        public List<Style> Styles { get => _styles; set => _styles = value; }

        /// <summary>
        /// Constructeur vide
        /// </summary>
        public Titre()
        {
            Comments = new List<Commentaire>();
            Styles = new List<Style>();
        }
        /// <summary>
        /// Constructeur paramétré
        /// </summary>
        /// <param name="title">Définit le titre d'une musique</param>
        /// <param name="description">La description d'un titre</param>
        /// <param name="artist">L'artite ayant réalisé la musique</param>
        public Titre(string title, string description, Artiste artist) : base()
        {
            TrackTitle = title;
            TrackDescription = description;
            Author = artist;
        }

    }
}
