using System;
using System.Collections.Generic;

namespace Webzine.Entity
{
    /// <summary>
    /// Classe représentant un artiste ( musicien / chanteur )
    /// </summary>
    public class Artiste
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
        public List<Titre> Tracks { get; set; }
        public int Id { get; set; }
        /// <summary>
        /// Nouvel artiste instancié sans paramètres
        /// </summary>
        public Artiste() => Tracks = new List<Titre>();
        /// <summary>
        /// Constructeur de la classe artiste permettant l'attribution de valeurs dès la création
        /// </summary>
        /// <param name="nomArtiste">Nom explicite, un nom est demandé pour identifier l'artiste</param>
        /// <param name="biographieArtiste">Elements décrivant le parcours d'un artiste</param>
        public Artiste(string nomArtiste, string biographieArtiste) : base()
        {
            Name = nomArtiste;
            Biography = biographieArtiste;
        }
    }
}
