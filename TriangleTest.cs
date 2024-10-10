using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TriangleTests
{
    [TestFixture]
    public class TriangleTests
    {
        // 1. Equilateral Triangle Test (All sides are equal)
        [Test]
        public void Testing_Triangle_As_Equilateral()
        {
            string result = TriangleSolver.DetermineTriangleType(3, 3, 3);
            Assert.AreEqual("Equilateral", result);
        }


    }
}