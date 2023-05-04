using CalculatedFigure;
using NUnit.Framework;
using System;

namespace TestUnit
{
    public class Tests
    {
        double expectedArea;
        double actualArea;

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CircleAreaWhenRadiusIsPositiveReturnsCorrectArea()
        {
            double radius = 5;
            expectedArea = Math.PI * Math.Pow(radius, 2);

            Circle circle = new Circle(radius);

            actualArea = circle.Area();

            Assert.AreEqual(expectedArea, actualArea, 0.0001);
        }

        [Test]
        public void CircleAreaWhenRadiusIsNegativeThrowsArgumentException()
        {
            double negativeRadius = -1;

            Circle circle = new Circle(negativeRadius);

            Assert.Throws<ArgumentException>(() => circle.Area());
        }

        [Test]
        public void TriangleAreaValidReturnCorrectArea()
        {
            double a = 3;
            double b = 4;
            double c = 5;
            expectedArea = 6;

            Triangle triangle = new Triangle(a, b, c);

            actualArea = triangle.Area();

            Assert.AreEqual(expectedArea, actualArea, 0.0001);
        }

        [Test]
        public void TriangleAreaInvalidThrowsArgumentException()
        {
            double a = 1;
            double b = 1;
            double c = 3;

            Triangle triangle = new Triangle(a, b, c);

            Assert.Throws<ArgumentException>(() => triangle.Area());
        }
    }
}