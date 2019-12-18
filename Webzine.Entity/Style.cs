using System;
using System.Collections.Generic;
using System.Text;

namespace Webzine.Entity
{
    /// <summary>
    /// Classe définissant le style d'une musique 
    /// </summary>
    public class Style
    {
        private int _id;
        private string _nomStyle;
        private string _descriptionStyle;
        private List<Titre> _titres;

        public string NomStyle { get => _nomStyle; set => _nomStyle = value; }
        public string DescriptionStyle { get => _descriptionStyle; set => _descriptionStyle = value; }
        public List<Titre> Titres { get => _titres; set => _titres = value; }
        public int Id { get => _id; set => _id = value; }

        /// <summary>
        /// Constructeur vide
        /// </summary>
        public Style() => Titres = new List<Titre>();
        /// <summary>
        /// Constructeur définissant le nom du style 
        /// </summary>
        /// <param name="nomStyle">Définit le nom qui identifiera un style</param>
        public Style(string nomStyle) : base() => NomStyle = nomStyle;
        /// <summary>
        /// Constructeur qui permet de définir le nom du style et une description si nécessaire
        /// </summary>
        /// <param name="nomStyle">Définit le nom qui identifiera un styl</param>
        /// <param name="descriptionStyle">Elements permetant de décrire un style</param>
        public Style(string nomStyle, string descriptionStyle) : this(nomStyle) => DescriptionStyle = descriptionStyle;
    }
}
