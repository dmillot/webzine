﻿using System;
using System.Collections.Generic;
using System.Linq;
using Webzine.Entity;

namespace Webzine.EntitiesContext
{
    public static class FactoryTitre
    {
        public static List<Titre> Titres = new List<Titre>()
        {
                new Titre(){ IdTitre = 1, Libelle = "Plus aimé", Chronique = "Ma chronique", Duree = 270, UrlJaquette = "https://images-na.ssl-images-amazon.com/images/I/91eRlPIUEZL._SX466_.jpg", Album = "Titre Album", UrlEcoute = "https://www.youtube.com/embed/bV2Bm7kj3cM", DateCreation = new DateTime(2019,11,1), DateSortie = DateTime.Now, NbLectures = 5, NbLikes = 6, IdArtiste = 1, Artiste = new Artiste(){Nom = "Silicone Soul"}, Commentaires = FactoryCommentaire.Commentaires.Where(c=>c.IdTitre==1).ToList(), TitresStyles = FactoryTitreStyle.TitreStyles.Where(ts=>ts.IdTitre == 1).ToList() },
                new Titre(){ IdTitre = 2, Libelle = "Titre", Chronique = "Ma chronique", Duree = 270, UrlJaquette = "https://images-na.ssl-images-amazon.com/images/I/91eRlPIUEZL._SX466_.jpg", Album = "Titre Album", UrlEcoute = "https://www.youtube.com/embed/bV2Bm7kj3cM", DateCreation = new DateTime(2019,11,2), DateSortie = DateTime.Now, NbLectures = 5, NbLikes = 5, IdArtiste = 1, Artiste = new Artiste(){Nom = "Silicone Soul"}, Commentaires = FactoryCommentaire.Commentaires.Where(c=>c.IdTitre==2).ToList(),     TitresStyles = FactoryTitreStyle.TitreStyles.Where(ts => ts.IdTitre == 2).ToList() },
                new Titre(){ IdTitre = 3, Libelle = "Titre", Chronique = "Ma chronique", Duree = 270, UrlJaquette = "https://images-na.ssl-images-amazon.com/images/I/91eRlPIUEZL._SX466_.jpg", Album = "Titre Album", UrlEcoute = "https://www.youtube.com/embed/bV2Bm7kj3cM", DateCreation = new DateTime(2019,11,3), DateSortie = DateTime.Now, NbLectures = 5, NbLikes = 4, IdArtiste = 1, Artiste = new Artiste(){Nom = "Silicone Soul"}, Commentaires =  FactoryCommentaire.Commentaires.Where(c=>c.IdTitre==3).ToList() ,   TitresStyles = FactoryTitreStyle.TitreStyles.Where(ts => ts.IdTitre == 3).ToList()  },
                new Titre(){ IdTitre = 4, Libelle = "Titre", Chronique = "Ma chronique", Duree = 270, UrlJaquette = "https://images-na.ssl-images-amazon.com/images/I/91eRlPIUEZL._SX466_.jpg", Album = "Titre Album2", UrlEcoute = "https://www.youtube.com/embed/bV2Bm7kj3cM", DateCreation = new DateTime(2019,11,4), DateSortie = DateTime.Now, NbLectures = 5, NbLikes = 2, IdArtiste = 1, Artiste = new Artiste(){Nom = "Silicone Soul"}, Commentaires = FactoryCommentaire.Commentaires.Where(c=>c.IdTitre==4).ToList() ,   TitresStyles = FactoryTitreStyle.TitreStyles.Where(ts => ts.IdTitre == 4).ToList() },
                new Titre(){ IdTitre = 5, Libelle = "Dernier", Chronique = "Ma chronique", Duree = 270, UrlJaquette = "https://images-na.ssl-images-amazon.com/images/I/91eRlPIUEZL._SX466_.jpg", Album = "Titre Album2", UrlEcoute = "https://www.youtube.com/embed/bV2Bm7kj3cM", DateCreation = new DateTime(2019,12,5), DateSortie = DateTime.Now, NbLectures = 5, NbLikes = 2, IdArtiste = 1, Artiste = new Artiste(){Nom = "Silicone Soul"}, Commentaires = FactoryCommentaire.Commentaires.Where(c=>c.IdTitre==5).ToList() , TitresStyles = FactoryTitreStyle.TitreStyles.Where(ts=>ts.IdTitre == 5).ToList() },
                new Titre(){ IdTitre = 6, Libelle = "Titre", Chronique = "Ma chronique", Duree = 270, UrlJaquette = "https://images-na.ssl-images-amazon.com/images/I/91eRlPIUEZL._SX466_.jpg", Album = "Titre Album3", UrlEcoute = "https://www.youtube.com/embed/bV2Bm7kj3cM", DateCreation = new DateTime(2019,11,6), DateSortie = DateTime.Now, NbLectures = 5, NbLikes = 2, IdArtiste = 1, Artiste = new Artiste(){Nom = "Silicone Soul"}, Commentaires = FactoryCommentaire.Commentaires.Where(c=>c.IdTitre==6).ToList() ,   TitresStyles = FactoryTitreStyle.TitreStyles.Where(ts=>ts.IdTitre == 6).ToList()},
                new Titre(){ IdTitre = 7, Libelle = "Titre", Chronique = "Ma chronique", Duree = 270, UrlJaquette = "https://images-na.ssl-images-amazon.com/images/I/91eRlPIUEZL._SX466_.jpg", Album = "Titre Album4", UrlEcoute = "https://www.youtube.com/embed/bV2Bm7kj3cM", DateCreation = new DateTime(2019,11,7), DateSortie = DateTime.Now, NbLectures = 5, NbLikes = 2, IdArtiste = 1, Artiste = new Artiste(){Nom = "Silicone Soul"}, Commentaires = FactoryCommentaire.Commentaires.Where(c=>c.IdTitre==7).ToList() ,   TitresStyles = FactoryTitreStyle.TitreStyles.Where(ts=>ts.IdTitre == 7).ToList() },
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
