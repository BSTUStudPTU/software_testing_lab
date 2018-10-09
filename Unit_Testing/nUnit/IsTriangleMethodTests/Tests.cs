using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using nUnit;

namespace IsTriangleMethodTests
{
    public class Tests
    {
        Triangle triangle = new Triangle();
        [Test]
        public void Side1_Is_1_Side2_Is_2_Side3_Is_3_resultIs_False()
        {
            Assert.AreEqual(false, triangle.IsTriangle(1, 2, 3));
        }
        [Test]
        public void Side1_Is_3_Side2_Is_3_Side3_Is_3_resultIs_True()
        {
            Assert.AreEqual(true, triangle.IsTriangle(3, 3, 3));
        }
        [Test]
        public void Side1_Is_3_Side2_Is_4_Side3_Is_5_resultIs_True()
        {
            Assert.AreEqual(true, triangle.IsTriangle(3, 4, 5));
        }
        [Test]
        public void Side1_Is_10_Side2_Is_90_Side3_Is_6_resultIs_False()
        {
            Assert.AreEqual(false, triangle.IsTriangle(10, 90, 6));
        }
        [Test]
        public void Side1_Is_1567_Side2_Is_2347_Side3_Is_2642_resultIs_True()
        {
            Assert.AreEqual(true, triangle.IsTriangle(1567, 2347, 2642));
        }
        [Test]
        public void Side1_Is_181135_Side2_Is_164835_Side3_Is_410450_resultIs_False()
        {
            Assert.AreEqual(false, triangle.IsTriangle(181135, 164835, 410450));
        }
        [Test]
        public void Side1_Is_3_Side2_Is_2_Side3_Is_1_resultIs_False()
        {
            Assert.AreEqual(false, triangle.IsTriangle(3, 2, 1));
        }
        [Test]
        public void Side1_Is_3_Side2_Is_3_Side3_Is_6_resultIs_False()
        {
            Assert.AreEqual(false, triangle.IsTriangle(3, 3, 6));
        }
        [Test]
        public void Side1_Is_30_Side2_Is_60_Side3_Is_90_001_resultIs_False()
        {
            Assert.AreEqual(false, triangle.IsTriangle(30, 60, 90.001));
        }
        [Test]
        public void Side1_Is_2_Side2_Is_20_Side3_Is_18_00001_resultIs_False()
        {
            Assert.AreEqual(false, triangle.IsTriangle(2, 20, 2642));
        }
    }
}