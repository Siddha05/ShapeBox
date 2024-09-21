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
    public class CircleTests
    {
        [TestMethod()]
        [DataRow(1d, Math.PI)]
        [DataRow(2d, 4 * Math.PI)]
        public void GetSquareTest(double radius, double expected)
        {
            var circle = new Circle(radius);
            var square = circle.GetSquare();
            Assert.AreEqual(expected, square);
        }
    }
}