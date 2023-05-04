using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatedFigure
{
    public class Circle : Figure
    {
        double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            if (IsPossible()) return Math.PI * Math.Pow(radius, 2);

            throw new ArgumentException("Отрицательного радиуса не существует");
        }

        private bool IsPossible()
        {
            if (radius >= 0) return true;
            return false;
        }
    }
}
