using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeBox.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        [DataRow(3d, 4d, 5d, true)]
        [DataRow(161d, 240d, 289d, true)]
        [DataRow(3d, 4d, 7d, false)]
        public void IsRectangularTest(double side1, double side2, double side3, bool expected)
        {
            var rect = new Triangle(side1, side2, side3);
            var result = rect.IsRectangular();
            Assert.AreEqual(expected, result);
        }

        [TestMethod()]

        public void InvalidTriangleTest()
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(1, 1, 7));
        }

        [TestMethod()]
        [DataRow(3d,4d,5d, 6d)]
        [DataRow(5d,5d,6d, 12d)]
        public void GetSquareTest(double side1, double side2, double side3, double expected)
        {
            var triangle = new Triangle(side1, side2, side3);
            var result = triangle.GetSquare();
            Assert.AreEqual(expected, result);
        }
    }
}