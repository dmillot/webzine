using Microsoft.AspNetCore.Mvc.Rendering;
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
        public Titre Title { get; set; }

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
                    Name = "jean ja",
                    Id = 2
                },
                new Artiste()
                {
                    Biography = "cest un ouf",
                    Name = "jean",
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
                    IdTitre = 1,
                    Artiste = Artistes[1],
                    Libelle = "A Quiet Grass",
                    Chronique = "blablablablalbalalblallalblbablablbalblalbalblbalbalabbalabl",
                    DateSortie = DateTime.Now,
                    Duree = 185,
                    UrlJaquette = "http://dergrtevcgctrgvr.png",
                    UrlEcoute = "http://edfreyvgcrvre.com",
                    TitresStyles = new List<Style>(){Styles[1], Styles[3]},
                    NbLectures = 1,
                    NbLikes = 6
                },
                new Titre()
                {
                    IdTitre = 2,
                    Artiste = Artistes[0],
                    Libelle = "ziiiiik",
                    Chronique = "blablablablalbalalblallalblbablablbalblalbalblbalbalabbalabl",
                    DateSortie = DateTime.Now,
                    Duree = 15,
                    UrlJaquette = "http://dergrtevcgctrgvr.png",
                    UrlEcoute = "http://edfreyvgcrvre.com",
                    TitresStyles = new List<Style>(){Styles[0], Styles[2]},
                    NbLectures = 10,
                    NbLikes = 60
                }
            };

            Title = Titles[0];
        }
    }
}
