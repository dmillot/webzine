using System.Collections.Generic;
using Webzine.Entity;

namespace Webzine.EntitiesContext
{
    public static class FactoryStyle
    {
        public static List<Style> Styles = new List<Style>()
            {
                new Style(){ IdStyle = 1, Libelle = "Rap", TitresStyles = new List<TitreStyle>() },
                new Style(){ IdStyle = 2, Libelle = "RNB", TitresStyles = new List<TitreStyle>() },
                new Style(){ IdStyle = 3, Libelle = "Rock", TitresStyles = new List<TitreStyle>() },
            };
    }
}
