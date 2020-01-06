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
        public int IdStyle { get; set; }
        [Display(Name = "Libellé")]
        [MaxLength(50)]
        [MinLength(2)]
        [Required]
        public string Libelle { get; set; }

        public List<Titre> TitresStyles { get; set; }
    }
}
