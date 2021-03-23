using System;

namespace ConsoleApp_Task1
{
    public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
           Radius = radius;
        }

        public override double GetFigureArea()
        {
            return Math.Round((Radius * Radius * Math.PI), 2);
        }
    }
}
