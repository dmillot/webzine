using System;
using System.Collections.Generic;
using System.Text;
using Webzine.Entity;

namespace Webzine.Repository
{
    public class FactoryTitre
    {
        public List<Titre> Titres;
        public FactoryTitre()
        {
            this.Titres = new List<Titre>()
            {
                new Titre(){ IdTitre = 1, Libelle = "Titre", Chronique = "Ma chronique", Duree = 270, UrlJaquette = "https://images-na.ssl-images-amazon.com/images/I/91eRlPIUEZL._SX466_.jpg", Album = "Titre Album", UrlEcoute = "", DateCreation = DateTime.Now, DateSortie = DateTime.Now, NbLectures = 5, NbLikes = 2, IdArtiste = 1, Artiste = new Artiste(), Commentaires = new List<Commentaire>(), TitresStyles = new List<Style>() },
                new Titre(){ IdTitre = 2, Libelle = "Titre", Chronique = "Ma chronique", Duree = 270, UrlJaquette = "https://images-na.ssl-images-amazon.com/images/I/91eRlPIUEZL._SX466_.jpg", Album = "Titre Album", UrlEcoute = "", DateCreation = DateTime.Now, DateSortie = DateTime.Now, NbLectures = 5, NbLikes = 2, IdArtiste = 1, Artiste = new Artiste(), Commentaires = new List<Commentaire>(), TitresStyles = new List<Style>() },
                new Titre(){ IdTitre = 3, Libelle = "Titre", Chronique = "Ma chronique", Duree = 270, UrlJaquette = "https://images-na.ssl-images-amazon.com/images/I/91eRlPIUEZL._SX466_.jpg", Album = "Titre Album", UrlEcoute = "", DateCreation = DateTime.Now, DateSortie = DateTime.Now, NbLectures = 5, NbLikes = 2, IdArtiste = 1, Artiste = new Artiste(), Commentaires = new List<Commentaire>(), TitresStyles = new List<Style>() },
                new Titre(){ IdTitre = 4, Libelle = "Titre", Chronique = "Ma chronique", Duree = 270, UrlJaquette = "https://images-na.ssl-images-amazon.com/images/I/91eRlPIUEZL._SX466_.jpg", Album = "Titre Album", UrlEcoute = "", DateCreation = DateTime.Now, DateSortie = DateTime.Now, NbLectures = 5, NbLikes = 2, IdArtiste = 1, Artiste = new Artiste(), Commentaires = new List<Commentaire>(), TitresStyles = new List<Style>() },
                new Titre(){ IdTitre = 5, Libelle = "Titre", Chronique = "Ma chronique", Duree = 270, UrlJaquette = "https://images-na.ssl-images-amazon.com/images/I/91eRlPIUEZL._SX466_.jpg", Album = "Titre Album", UrlEcoute = "", DateCreation = DateTime.Now, DateSortie = DateTime.Now, NbLectures = 5, NbLikes = 2, IdArtiste = 1, Artiste = new Artiste(), Commentaires = new List<Commentaire>(), TitresStyles = new List<Style>() },
                new Titre(){ IdTitre = 6, Libelle = "Titre", Chronique = "Ma chronique", Duree = 270, UrlJaquette = "https://images-na.ssl-images-amazon.com/images/I/91eRlPIUEZL._SX466_.jpg", Album = "Titre Album", UrlEcoute = "", DateCreation = DateTime.Now, DateSortie = DateTime.Now, NbLectures = 5, NbLikes = 2, IdArtiste = 1, Artiste = new Artiste(), Commentaires = new List<Commentaire>(), TitresStyles = new List<Style>() },
                new Titre(){ IdTitre = 7, Libelle = "Titre", Chronique = "Ma chronique", Duree = 270, UrlJaquette = "https://images-na.ssl-images-amazon.com/images/I/91eRlPIUEZL._SX466_.jpg", Album = "Titre Album", UrlEcoute = "", DateCreation = DateTime.Now, DateSortie = DateTime.Now, NbLectures = 5, NbLikes = 2, IdArtiste = 1, Artiste = new Artiste(), Commentaires = new List<Commentaire>(), TitresStyles = new List<Style>() },
            };
        }
    }
}
