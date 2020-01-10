﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Webzine.Entity
{
    public class TitreStyle
    {
        public int IdTitre { get; set; }
        public int IdStyle { get; set; }
        [NotMapped]
        public Titre Titre { get; set; }
        [NotMapped]
        public Style Style { get; set; }
    }
}