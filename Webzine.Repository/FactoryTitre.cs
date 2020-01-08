using System;
using System.Collections.Generic;
using System.Linq;
using Webzine.Entity;

namespace Webzine.Repository
{
    public static class FactoryTitre
    {
        public static List<Titre> Titres = new List<Titre>()
        {
                new Titre(){ IdTitre = 1, Libelle = "Titre", Chronique = "Ma chronique", Duree = 270, UrlJaquette = "https://images-na.ssl-images-amazon.com/images/I/91eRlPIUEZL._SX466_.jpg", Album = "Titre Album", UrlEcoute = "", DateCreation = DateTime.Now, DateSortie = DateTime.Now, NbLectures = 5, NbLikes = 2, IdArtiste = 1, Artiste = new Artiste(){Nom = "Silicone Soul"}, Commentaires = FactoryCommentaire.Commentaires.Where(c=>c.IdTitre==1).ToList(), TitresStyles = new List<Style>(){new Style{Libelle = "Electro"}} },
                new Titre(){ IdTitre = 2, Libelle = "Titre", Chronique = "Ma chronique", Duree = 270, UrlJaquette = "https://images-na.ssl-images-amazon.com/images/I/91eRlPIUEZL._SX466_.jpg", Album = "Titre Album", UrlEcoute = "", DateCreation = DateTime.Now, DateSortie = DateTime.Now, NbLectures = 5, NbLikes = 2, IdArtiste = 1, Artiste = new Artiste(){Nom = "Silicone Soul"}, Commentaires = FactoryCommentaire.Commentaires.Where(c=>c.IdTitre==2).ToList(), TitresStyles = new List<Style>(){new Style{Libelle = "Electro"}} },
                new Titre(){ IdTitre = 3, Libelle = "Titre", Chronique = "Ma chronique", Duree = 270, UrlJaquette = "https://images-na.ssl-images-amazon.com/images/I/91eRlPIUEZL._SX466_.jpg", Album = "Titre Album", UrlEcoute = "", DateCreation = DateTime.Now, DateSortie = DateTime.Now, NbLectures = 5, NbLikes = 2, IdArtiste = 1, Artiste = new Artiste(){Nom = "Silicone Soul"}, Commentaires =  FactoryCommentaire.Commentaires.Where(c=>c.IdTitre==3).ToList() ,TitresStyles = new List<Style>(){new Style{Libelle = "Electro"}} },
                new Titre(){ IdTitre = 4, Libelle = "Titre", Chronique = "Ma chronique", Duree = 270, UrlJaquette = "https://images-na.ssl-images-amazon.com/images/I/91eRlPIUEZL._SX466_.jpg", Album = "Titre Album2", UrlEcoute = "", DateCreation = DateTime.Now, DateSortie = DateTime.Now, NbLectures = 5, NbLikes = 2, IdArtiste = 1, Artiste = new Artiste(){Nom = "Silicone Soul"}, Commentaires = FactoryCommentaire.Commentaires.Where(c=>c.IdTitre==4).ToList() , TitresStyles = new List<Style>(){new Style{Libelle = "Electro"}} },
                new Titre(){ IdTitre = 5, Libelle = "Titre", Chronique = "Ma chronique", Duree = 270, UrlJaquette = "https://images-na.ssl-images-amazon.com/images/I/91eRlPIUEZL._SX466_.jpg", Album = "Titre Album2", UrlEcoute = "", DateCreation = DateTime.Now, DateSortie = DateTime.Now, NbLectures = 5, NbLikes = 2, IdArtiste = 1, Artiste = new Artiste(){Nom = "Silicone Soul"}, Commentaires = FactoryCommentaire.Commentaires.Where(c=>c.IdTitre==5).ToList() , TitresStyles = new List<Style>(){new Style{Libelle = "Electro"}} },
                new Titre(){ IdTitre = 6, Libelle = "Titre", Chronique = "Ma chronique", Duree = 270, UrlJaquette = "https://images-na.ssl-images-amazon.com/images/I/91eRlPIUEZL._SX466_.jpg", Album = "Titre Album3", UrlEcoute = "", DateCreation = DateTime.Now, DateSortie = DateTime.Now, NbLectures = 5, NbLikes = 2, IdArtiste = 1, Artiste = new Artiste(){Nom = "Silicone Soul"}, Commentaires = FactoryCommentaire.Commentaires.Where(c=>c.IdTitre==6).ToList() , TitresStyles = new List<Style>(){new Style{Libelle = "Electro"}} },
                new Titre(){ IdTitre = 7, Libelle = "Titre", Chronique = "Ma chronique", Duree = 270, UrlJaquette = "https://images-na.ssl-images-amazon.com/images/I/91eRlPIUEZL._SX466_.jpg", Album = "Titre Album4", UrlEcoute = "", DateCreation = DateTime.Now, DateSortie = DateTime.Now, NbLectures = 5, NbLikes = 2, IdArtiste = 1, Artiste = new Artiste(){Nom = "Silicone Soul"}, Commentaires = FactoryCommentaire.Commentaires.Where(c=>c.IdTitre==7).ToList() , TitresStyles = new List<Style>(){new Style{Libelle = "Electro"}} },
        };

        public static List<Commentaire> Commentaires
        {
            get => Titres.SelectMany(t => t.Commentaires).ToList();
        }

        /// <summary>
        /// retourne les 3 titres de la page demandé
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public static List<Titre> GetTitresFromPage(int page = 0)
        {
            List<Titre> results = new List<Titre>();
            // get 3 titles by 3 titles
            int startNextElements = page * 3;
            int count = 3;
            if (startNextElements + 3 > Titres.Count)
            {
                count = Titres.Count - startNextElements;
            }
            if (count > 0)
            {
                results = Titres.OrderBy(t => t.DateCreation).ToList().GetRange(startNextElements, count);
            }

            return results;
        }

        /// <summary>
        /// retourne le nombre de page quil est possible d'afficher
        /// </summary>
        /// <returns>int</returns>
        public static int GetCountPages()
        {
            return Titres.Count % 3 > 0 ? Titres.Count / 3 + 1 : Titres.Count / 3;
        }

    }
}
