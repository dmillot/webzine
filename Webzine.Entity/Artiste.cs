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
        public int IdArtiste { get; set; }

        [MinLength(1)]
        [MaxLength(50)]
        [Display(Name = "Nom de l'artiste")]

        public string Nom { get; set; }

        public string Biographie { get; set; }

        public List<Titre> Titres { get; set; }
    }
}
