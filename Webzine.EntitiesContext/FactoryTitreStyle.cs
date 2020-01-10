using System;
using System.Collections.Generic;
using System.Text;
using Webzine.Entity;

namespace Webzine.EntitiesContext
{
    public static class FactoryTitreStyle
    {
        public static List<TitreStyle> TitreStyles = new List<TitreStyle>()
        {
            new TitreStyle() {IdStyle = 1 , IdTitre = 1},
            new TitreStyle() {IdStyle = 2 , IdTitre = 2},
            new TitreStyle() {IdStyle = 3 , IdTitre = 3},
            new TitreStyle() {IdStyle = 1 , IdTitre = 4},
            new TitreStyle() {IdStyle = 2 , IdTitre = 5},
            new TitreStyle() {IdStyle = 3 , IdTitre = 6},
            new TitreStyle() {IdStyle = 1 , IdTitre = 7}
        };
    }
}
