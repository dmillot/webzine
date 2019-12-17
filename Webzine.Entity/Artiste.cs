using System;
using System.Collections.Generic;

namespace Webzine.Entity
{
    /// <summary>
    /// Classe représentant un artiste ( musicien / chanteur )
    /// </summary>
    public class Artiste
    {
        private string _nomArtiste;
        private string _biographieArtiste;
        private List<Titre> _tracks;

        public string NomArtiste { get => _nomArtiste; set => _nomArtiste = value; }
        public string BiographieArtiste { get => _biographieArtiste; set => _biographieArtiste = value; }
        public List<Titre> Tracks { get => _tracks; set => _tracks = value; }

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
            NomArtiste = nomArtiste;
            BiographieArtiste = biographieArtiste;
        }
    }
}
