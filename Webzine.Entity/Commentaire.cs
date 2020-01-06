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
        public int Id { get; set; }

        public string Username { get; set; }

        public string Message { get; set; }

        public DateTime CreatedAt { get; set; }

        [ForeignKey("Titre")]
        public int TitleId { get; set; }

        public Titre Title { get; set; }
    }
}
