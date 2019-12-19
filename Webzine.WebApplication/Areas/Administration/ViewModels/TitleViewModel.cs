using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webzine.Entity;

namespace Webzine.WebApplication.Areas.Administration.ViewModels
{
    public class TitleViewModel
    {
        public List<Artiste> Artistes { get; set; }
        public List<Style> Styles { get; set; }
        public List<Titre> Titles { get; set; }

        /// <summary>
        /// Contient les artistes pour selectionner un artiste sur un titre
        /// contient les styles pour assigner des styles a un titre
        /// </summary>
        public TitleViewModel()
        {

            // création du jeu d'essaie
            Artistes = new List<Artiste>()
            {
                new Artiste()
                {
                    Biography = "cest un ouf",
                    Name = "jean jakc",
                    Id = 1
                },
                new Artiste()
                {
                    Biography = "cest un ouf",
                    Name = "jean jakc",
                    Id = 2
                },
                new Artiste()
                {
                    Biography = "cest un ouf",
                    Name = "jean jakc",
                    Id = 3
                },
            };

            Styles = new List<Style>()
            {
                new Style()
                {
                    Name = "Hard Rock",
                    Id = 1
                },
                new Style()
                {
                    Name = "Hard Rock",
                    Id = 2
                },
                new Style()
                {
                    Name = "Hard Rock",
                    Id = 3
                },
                new Style()
                {
                    Name = "Hard Rock",
                    Id = 4
                },
                new Style()
                {
                    Name = "Hard Rock",
                    Id = 5
                },
            };

            Titles = new List<Titre>()
            {
                new Titre()
                {
                    Id = 1,
                    Author = Artistes[1],
                    Title = "A Quiet Grass",
                    Description = "blablablablalbalalblallalblbablablbalblalbalblbalbalabbalabl",
                    ReleaseDate = DateTime.Now,
                    Duration = 185,
                    AlbumPicture = "http://dergrtevcgctrgvr.png",
                    VideoLink = "http://edfreyvgcrvre.com",
                    Styles = new List<Style>(){Styles[1], Styles[3]},
                    ReadingCounter = 1,
                    LikeCounter = 6
                },
                new Titre()
                {
                    Id = 2,
                    Author = Artistes[0],
                    Title = "ziiiiik",
                    Description = "blablablablalbalalblallalblbablablbalblalbalblbalbalabbalabl",
                    ReleaseDate = DateTime.Now,
                    Duration = 15,
                    AlbumPicture = "http://dergrtevcgctrgvr.png",
                    VideoLink = "http://edfreyvgcrvre.com",
                    Styles = new List<Style>(){Styles[0], Styles[2]},
                    ReadingCounter = 10,
                    LikeCounter = 60
                }
            };
        }
    }
}
