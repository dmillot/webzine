using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Webzine.Entity
{
    /// <summary>
    /// Title représente un titre musical appartenant à un artiste
    /// </summary>
    public class Titre
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

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

        [ForeignKey("Artiste")]
        public int ArtistId { get; set; }

        public Artiste Artist { get; set; }

        public List<Commentaire> Comments { get; set; }

        public List<Style> Styles { get; set; }

    }
}
