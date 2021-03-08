using System;

namespace ConsoleApp_Task1
{
    public class Circle : Figure
    {
        private static double _Radius { get; set; }

        public Circle(double b)
        {
           _Radius = b;
        }
        public override double GetFigureArea()
        {
            double Pi = Math.PI;
            double result = Math.Round((_Radius * _Radius * Pi), 2);
            return result;
        }
    }
}
