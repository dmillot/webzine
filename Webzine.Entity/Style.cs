using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Webzine.Entity
{
    /// <summary>
    /// Classe définissant le style d'une musique 
    /// </summary>
    public class Style
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Titre> Titles { get; set; }
    }
}
