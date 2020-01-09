﻿using System.Collections.Generic;
using System.Linq;
using Webzine.Entity;
using Webzine.Repository.Contracts;

namespace Webzine.Repository.Local
{
    public class LocalArtisteRepository : IArtisteRepository
    {
        /// <summary>
        /// Permet la d'ajouter un artiste à notre jeu de données
        /// </summary>
        /// <param name="artiste">L'artiste à ajouter</param>
        public void Add(Artiste artiste)
        {
            FactoryArtiste.Artistes.Add(artiste);
        }
        /// <summary>
        /// Permet la suppression d'un artiste de notre jeu de données si ce dernier existe
        /// </summary>
        /// <param name="artiste">L'artiste concerné par la modification</param>
        public void Delete(Artiste artiste)
        {
            FactoryArtiste.Artistes.Remove(FactoryArtiste.Artistes.Where(a => a.IdArtiste == artiste.IdArtiste).FirstOrDefault());
        }
        /// <summary>
        /// Permet de trouver un artiste parmis un jeu de données à partir de son id
        /// </summary>
        /// <param name="id">Identifiant de l'artiste à retrouver</param>
        /// <returns>Retourne un artiste</returns>
        public Artiste Find(int id) => FactoryArtiste.Artistes.Where(a => a.IdArtiste == id).FirstOrDefault();

        /// <summary>
        /// Retourne les artistes présents dans notre jeu de données
        /// </summary>
        /// <returns>Retourne une liste d'Artistes</returns>
        public IEnumerable<Artiste> FindAll() => FactoryArtiste.Artistes;

        /// <summary>
        ///  Permet de rechercher un artiste dans notre jeu de données
        /// </summary>
        /// <param name="mot"></param>
        /// <returns> Retourne une liste d'Artistes </returns>
        public IEnumerable<Artiste> Search(string mot)
        {
            return FactoryArtiste.Artistes.FindAll(a => a.Nom.Contains(mot, System.StringComparison.OrdinalIgnoreCase));
        }
       
        /// <summary>
        /// Permet de mettre à jour un artiste dans notre jeu de données
        /// </summary>
        /// <param name="artiste">L'artiste concerné par la modification</param>
        public void Update(Artiste artiste)
        {

            var rank = 0;
            foreach (var item in FactoryArtiste.Artistes)
            {
                if (item.IdArtiste == artiste.IdArtiste)
                {
                    artiste.Titres = item.Titres;
                    FactoryArtiste.Artistes[rank] = artiste;
                    break;
                }
                rank++;
            }
        }
    }
}
