using SLib;
using System;

namespace SLibTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCircleArea()
        {
            Circle circle = new Circle(10);
            Assert.AreEqual(Math.PI * 100, circle.Area(), 1e-10);
        }

        [TestMethod]
        public void TestTriangleArea()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.Area(), 1e-10);
        }

        [TestMethod]
        public void TestRightAngleTriangle()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRightAngle());

            triangle = new Triangle(6, 8, 10);
            Assert.IsTrue(triangle.IsRightAngle());

            triangle = new Triangle(5, 12, 13);
            Assert.IsTrue(triangle.IsRightAngle());

            triangle = new Triangle(3, 3, 3);
            Assert.IsFalse(triangle.IsRightAngle());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidTriangle()
        {
            Triangle triangle = new Triangle(1, 2, 3);
        }

        [TestMethod]
        public void TestCalculateAreaCircle()
        {
            Circle circle = new Circle(5);
            Assert.AreEqual(Math.PI * 25, ShapeCalculator.CalculateArea(circle), 1e-10);
        }

        [TestMethod]
        public void TestCalculateAreaTriangle()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, ShapeCalculator.CalculateArea(triangle), 1e-10);
        }
    }
}