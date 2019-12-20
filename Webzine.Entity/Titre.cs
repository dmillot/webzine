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
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Artiste Author { get; set; }
        public List<Commentaire> Comments { get; set; }
        public List<Style> Styles { get; set; }
        public int Duration { get; set; }
        public string AlbumPicture { get; set; }
        public string AlbumTitle { get; set; }
        public string VideoLink { get; set; }
        /// <summary>
        /// Date à laquelle l'article du titre à été crée.
        /// </summary>
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ReadingCounter { get; set; }
        public int LikeCounter { get; set; }

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
            Title = title;
            Description = description;
            Author = artist;
        }

        /// <summary>
        /// return the duration in string to format minutes: secondes (4:30)
        /// </summary>
        /// <returns></returns>
        public string DurationToString()
        {
            TimeSpan time = TimeSpan.FromSeconds(Duration);

            string str = time.ToString(@"mm\:ss");

            return str;
        }

    }
}
