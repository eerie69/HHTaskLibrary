using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHTaskLibrary.UnitTestsV1
{
    [TestClass]
    public static class TriangleTests
    {
        [TestMethod]
        public static void isStraightTriangle_NotStraight_ReturnFalse()
        {
            //Arrange
            var triangle = new Triangle("Треугольник", 2, 3, 4);

            //Act
            var result = triangle.isStraightTriangle();

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public static void Square_3and4and5_Return6()
        {
            //Arrange
            var triangle = new Triangle("Треугольник", 3, 4, 5);
            double expected = 6;

            //Act
            var result = triangle.Square();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }

    [TestClass]
    public static class CircleTest
    {
        [TestMethod]
        public static void Square_5_Return78_5()
        {
            //Arrange
            var circle = new Circle("Круг", 5);
            double expected = 78.5;

            //Act
            var result = circle.Square();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
