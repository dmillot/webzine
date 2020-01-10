using System;
using System.Collections.Generic;
using System.Text;

namespace Webzine.Entity
{
    public class TitreStyle
    {
        public int IdTitre { get; set; }
        public int IdStyle { get; set; }

        public Titre Titre { get; set; }
        public Style Style { get; set; }
    }
}
