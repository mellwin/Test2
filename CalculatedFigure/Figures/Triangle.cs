using System;

namespace CalculatedFigure
{
    public class Triangle : Figure
    {
        double a;
        double b;
        double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Area()
        {
            double p = CalculateSemiPerimeter();

            if (IsPossible()) return Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            throw new ArgumentException($"Треугольник со сторонами {a}, {b}, {c} невозможно построить");
        }

        private double CalculateSemiPerimeter()
        {
            return (a + b + c) / 2;
        }

        private bool IsPossible()
        {
            if (a + b > c && a + c > b && b + c > a) return true;

            return false;
        }
        public bool IsRectangular()
        {
            if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2)) return true;
            if (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2)) return true;
            if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2)) return true;
            return false;
        }
    }
}