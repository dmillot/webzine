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
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Titre> Titles { get; set; }
        

        /// <summary>
        /// Constructeur vide
        /// </summary>
        public Style() => Titles = new List<Titre>();
        /// <summary>
        /// Constructeur définissant le nom du style 
        /// </summary>
        /// <param name="nomStyle">Définit le nom qui identifiera un style</param>
        public Style(string nomStyle) : base() => Name = nomStyle;
        /// <summary>
        /// Constructeur qui permet de définir le nom du style et une description si nécessaire
        /// </summary>
        /// <param name="nomStyle">Définit le nom qui identifiera un styl</param>
        /// <param name="descriptionStyle">Elements permetant de décrire un style</param>
        public Style(string nomStyle, string descriptionStyle) : this(nomStyle) => Description = descriptionStyle;
    }
}
