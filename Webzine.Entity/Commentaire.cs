using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Webzine.Entity
{
    /// <summary>
    /// Une réaction à une chronique sur un titre
    /// </summary>
    public class Commentaire
    {
       

        [Key]
        public int IdCommentaire { get; set; }

        [Display(Name = "Nom")]
        [MinLength(2)]
        [MaxLength(30)]
        [Required]
        public string Auteur { get; set; }

        [Required]
        [MinLength(10)]
        [MaxLength(1000)]
        [Display(Name = "Commentaire")]
        public string Contenu { get; set; }

        [Required]
        [Display(Name = "Date de création")]
        public DateTime DateCreation { get; set; }

        [ForeignKey("Titre")]
        public int IdTitre { get; set; }

        public Titre Title { get; set; }
     
    }
}
