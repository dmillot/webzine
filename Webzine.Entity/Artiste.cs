using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Webzine.Entity
{
    /// <summary>
    /// Classe représentant un artiste ( musicien / chanteur )
    /// </summary>
    public class Artiste
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Biography { get; set; }

        public List<Titre> Titles { get; set; }
    }
}
