using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeWPF;

namespace TestProjetDeWPF
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFace()
        {
            int v = 2;
            string nom = "Mary";

            Assert.AreEqual(v, 2);
            Assert.AreEqual(nom, "Mary");
        }

        [TestMethod]
        public void TestObjetHasard()
        {
            string nom = "MP";
            int nbFaces = 6;

            Assert.AreEqual(nom, "MP");
            Assert.AreEqual(nbFaces, 6);
        }

        [TestMethod]
        public void TestLancer()
        {
            int nbMin = 0;
            int nbMax = 0;
            int min = 1;
            int max = 6;
            double tolerance = 1e-3;
            int nbIterations = 100000;

            for (int i = 0; i < nbIterations; i++)
            {
                Face rnd = ObjetHasard.Lancer(min, max);

                // On teste qu'on est dans les limites attendues
                Assert.IsTrue(rnd >= min && rnd <= max, "rnd hors plage");

                // On teste si vaut min
                if (rnd - min <= tolerance)
                {
                    nbMin++;
                }

                // On teste si vaut max
                if (max - rnd <= tolerance)
                {
                    nbMax++;
                }
            }

            // On vérifie si on a obtenu les deux limites
            Assert.IsTrue(nbMin > 0, "nbMin = 0");
            Assert.IsTrue(nbMax > 0, "nbMax = 0");
        }
    }
}
