using System;

namespace CalculatedFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Circle(5);
            Console.WriteLine(figure.Area());

            figure = new Triangle(3, 4, 5);
            Console.WriteLine(figure.Area());
            if (((Triangle)figure).IsRectangular()) Console.WriteLine("Треугольник прямоугольный");
            else Console.WriteLine("Треугольник не прямоугольный");
        }
    }
}