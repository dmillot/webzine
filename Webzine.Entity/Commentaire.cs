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
        /// <summary>
        /// Nom de l'individu ayant rédigé le commentaire
        /// Exemple : Kim Dole
        /// </summary>
        [Display(Name = "Nom")]
        [MinLength(2)]
        [MaxLength(30)]
        [Required]
        public string Auteur { get; set; }

        /// <summary>
        /// Contenu du commentaire
        /// </summary>
        [Required]
        [MinLength(10)]
        [MaxLength(1000)]
        [Display(Name = "Commentaire")]
        public string Contenu { get; set; }

        /// <summary>
        /// Date à de création du commentaire
        /// </summary>
        [Required]
        [Display(Name = "Date de création")]
        public DateTime DateCreation { get; set; }

        /// <summary>
        /// Identifiant du titre musical auquel le commentaire est destiné
        /// </summary>
        [ForeignKey(nameof(Commentaire.Titre))]
        public int IdTitre { get; set; }

        /// <summary>
        /// Obtien ou définit le titre concerné par le commentaire
        /// </summary>
        public Titre Titre { get; set; }
     
    }
}
