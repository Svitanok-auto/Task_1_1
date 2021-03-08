using System;

namespace ConsoleApp_Task1
{
    public class Square : Figure
    {
        private static double _Side { get; set; }

        public Square(double b)
        {
            _Side = b;
        }
        public override double GetFigureArea()
        {
            double result = Math.Round(_Side * _Side, 2);
            return result;
        }
    }
}
