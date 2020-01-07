using System;
using System.Collections.Generic;
using System.Text;
using Webzine.Entity;

namespace Webzine.Repository
{
    public class FactoryStyle
    {
        public List<Style> Styles;

        public FactoryStyle()
        {
            this.Styles = new List<Style>()
            {
                new Style(){ IdStyle = 1, Libelle = "Rap", TitresStyles = new List<Titre>() },
                new Style(){ IdStyle = 2, Libelle = "RNB", TitresStyles = new List<Titre>() },
                new Style(){ IdStyle = 3, Libelle = "Rock", TitresStyles = new List<Titre>() },
            };
        }
    }
}
