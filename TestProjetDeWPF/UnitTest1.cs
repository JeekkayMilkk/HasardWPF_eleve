using Microsoft.VisualStudio.TestTools.UnitTesting;
using DeWPF;

namespace TestProjetDeWPF
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDe6()
        {
        }

        [TestMethod]
        public void TestFace()
        {
            int v = 2;
            string nom = "Mary";

            Assert.AreEqual(v, 2);
            Assert.AreEqual(nom, "Mary");
        }

        [TestMethod]
        public void TestLancer()
        {
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
        public void TestCreerFaces()
        {
        }

        [TestMethod]
        public void TestPiece()
        {
        }
    }
}
