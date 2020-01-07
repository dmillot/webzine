﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Webzine.Entity;
using Webzine.Repository.Contracts;

namespace Webzine.Repository.Local
{
    public class LocalStyleRepository : IStyleRepository
    {

        /// <summary>
        /// Permet d'ajouter un style dans notre jeu données
        /// </summary>
        /// <param name="style"></param>
        public void Add(Style style)
        {
            FactoryStyle.Styles.Add(style);
        }

        /// <summary>
        /// Permet de supprimer un style dans notre jeu de données
        /// </summary>
        /// <param name="style"></param>
        public void Delete(Style style)
        {
            FactoryStyle.Styles.Remove(style);
        }

        /// <summary>
        /// Permet de trouver un style précis dans notre jeu de données 
        /// </summary>
        /// <param name="id"></param>
        /// <returns> Retourne un Style </returns>
        public Style Find(int id)
        {
            return FactoryStyle.Styles.Where(s => s.IdStyle == id).FirstOrDefault();
        }

        /// <summary>
        /// Retourne les styles présents dans notre jeu de données
        /// </summary>
        /// <returns> Retourne une liste de Style </returns>
        public IEnumerable<Style> FindAll()
        {
            return FactoryStyle.Styles; 
        }

        /// <summary>
        /// Permet de mettre à jour un style dans notre jeu de données
        /// </summary>
        /// <param name="style"></param>
        public void Update(Style style)
        {
            this.Delete(style);
            this.Add(style);
        }
    }
}
