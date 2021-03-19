using System;

namespace ConsoleApp_Task1
{
    public class Square : Figure
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }
        public override double GetFigureArea()
        {
            return Math.Round(Side * Side, 2);
        }
    }
}
