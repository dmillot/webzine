namespace Webzine.UnitTests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Webzine.Entity;

    /// <summary>
    /// Tests de l'entit� <see cref="Artiste"/>.
    /// V�rifie que les contraintes impos�es (nom du champ, longueur max du champ,
    /// champ obligatoire, libell� du champ, cl� primaire...) sont bien respect�es.
    /// </summary>
    [TestClass]
    public class ArtisteTests
    {
        [TestMethod]
        public void ArtisteHasIdArtiste()
        {
            Common.HasProperty(typeof(Artiste), nameof(Artiste.IdArtiste));
        }

        [TestMethod]
        public void ArtisteHasNom()
        {
            Common.HasProperty(typeof(Artiste), nameof(Artiste.Nom));
        }

        [TestMethod]
        public void ArtisteHasNomTailleMin1()
        {
            Common.AttributLongueurMin(typeof(Artiste), nameof(Artiste.Nom), 1);
        }

        [TestMethod]
        public void ArtisteHasNomTailleMax50()
        {
            Common.AttributLongueurMax(typeof(Artiste), nameof(Artiste.Nom), 50);
        }

        [TestMethod]
        public void ArtisteHasNomDisplayValid()
        {
            Common.AttributDisplay(typeof(Artiste), nameof(Artiste.Nom), "Nom de l'artiste");
        }

        [TestMethod]
        public void ArtisteHasBiographie()
        {
            Common.HasProperty(typeof(Artiste), nameof(Artiste.Biographie));
        }

        [TestMethod]
        public void ArtisteHasTitres()
        {
            Common.HasProperty(typeof(Artiste), nameof(Artiste.Titres));
        }
    }
}
