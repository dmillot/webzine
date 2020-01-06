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
                    Biographie = "cest un ouf",
                    Nom = "jean jakc",
                    IdArtiste = 1
                },
                new Artiste()
                {
                    Biographie = "cest un ouf",
                    Nom = "jean ja",
                    IdArtiste = 2
                },
                new Artiste()
                {
                    Biographie = "cest un ouf",
                    Nom = "jean",
                    IdArtiste = 3
                },
            };

            Styles = new List<Style>()
            {
                new Style()
                {
                    Libelle = "Hard Rock",
                    IdStyle = 1
                },
                new Style()
                {
                    Libelle = "Hard Rock",
                    IdStyle = 2
                },
                new Style()
                {
                    Libelle = "Hard Rock",
                    IdStyle = 3
                },
                new Style()
                {
                    Libelle = "Hard Rock",
                    IdStyle = 4
                },
                new Style()
                {
                    Libelle = "Hard Rock",
                    IdStyle = 5
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
