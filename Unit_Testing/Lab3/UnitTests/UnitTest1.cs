using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FirstUnitTest()
        {
            double firstSide = 1, secondSide = 2, thirdSide = 3;
            bool expectedResult = false;
            TestedClass myTestedClass = new TestedClass();
            Assert.AreEqual(expectedResult, myTestedClass.TriangleCheck(firstSide, secondSide, thirdSide));
        }
        [TestMethod]
        public void SecondUnitTest()
        {

            double firstSide = 3, secondSide = 3, thirdSide = 3;
            bool expectedResult = true;
            TestedClass myTestedClass = new TestedClass();
            Assert.AreEqual(expectedResult, myTestedClass.TriangleCheck(firstSide, secondSide, thirdSide));
        }
        [TestMethod]
        public void ThirdUnitTest()
        {

            double firstSide = 3, secondSide = 4, thirdSide = 5;
            bool expectedResult = true;
            TestedClass myTestedClass = new TestedClass();
            Assert.AreEqual(expectedResult, myTestedClass.TriangleCheck(firstSide, secondSide, thirdSide));
        }
        [TestMethod]
        public void FourthUnitTest()
        {

            double firstSide = 10, secondSide = 90, thirdSide = 6;
            bool expectedResult = false;
            TestedClass myTestedClass = new TestedClass();
            Assert.AreEqual(expectedResult, myTestedClass.TriangleCheck(firstSide, secondSide, thirdSide));
        }
        [TestMethod]
        public void FifthUnitTest()
        {

            double firstSide = 1567, secondSide = 2347, thirdSide = 2642;
            bool expectedResult = true;
            TestedClass myTestedClass = new TestedClass();
            Assert.AreEqual(expectedResult, myTestedClass.TriangleCheck(firstSide, secondSide, thirdSide));
        }
        [TestMethod]
        public void SixthUnitTest()
        {

            double firstSide = 181135, secondSide = 164835, thirdSide = 410450;
            bool expectedResult = false;
            TestedClass myTestedClass = new TestedClass();
            Assert.AreEqual(expectedResult, myTestedClass.TriangleCheck(firstSide, secondSide, thirdSide));
        }
        [TestMethod]
        public void SevenshUnitTest()
        {

            double firstSide = 3, secondSide = 2, thirdSide = 1;
            bool expectedResult = false;
            TestedClass myTestedClass = new TestedClass();
            Assert.AreEqual(expectedResult, myTestedClass.TriangleCheck(firstSide, secondSide, thirdSide));
        }
        [TestMethod]
        public void EghtsUnitTest()
        {

            double firstSide = 3, secondSide = 3, thirdSide = 6;
            bool expectedResult = false;
            TestedClass myTestedClass = new TestedClass();
            Assert.AreEqual(expectedResult, myTestedClass.TriangleCheck(firstSide, secondSide, thirdSide));
        }
        [TestMethod]
        public void NinesUnitTest()
        {
            double firstSide = 30, secondSide = 60, thirdSide = 90.001;
            bool expectedResult = false;
            TestedClass myTestedClass = new TestedClass();
            Assert.AreEqual(expectedResult, myTestedClass.TriangleCheck(firstSide, secondSide, thirdSide));
        }
        [TestMethod]
        public void TensUnitTest()
        {
            double firstSide = 2, secondSide = 20, thirdSide = 18.00001;
            bool expectedResult = true;
            TestedClass myTestedClass = new TestedClass();
            Assert.AreEqual(expectedResult, myTestedClass.TriangleCheck(firstSide, secondSide, thirdSide));
        }

    }
}
