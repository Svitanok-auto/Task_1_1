using System;


namespace ConsoleApp_Task1
{
        public class Program
        {
        public static void GetFitFigureDetails(Circle circle, Square square, Figure figureCircle, Figure figureSquare)             
        {
            bool circleFitsIntoSquare = figureCircle.GetFitFigure((Circle)circle, (Square)square);
            bool squareFitsIntoCircle = figureSquare.GetFitFigure((Square)square, (Circle)circle);

            if ((circleFitsIntoSquare == true) && (squareFitsIntoCircle == false))
            {
                Console.WriteLine("\nCircle fits into Square");
            }
            if ((circleFitsIntoSquare == false) && (squareFitsIntoCircle == true))
            {
                Console.WriteLine("\nSquare fits into Circle");
            }
            if ((circleFitsIntoSquare == false) && (squareFitsIntoCircle == false))
            {
                Console.WriteLine("\nCircle dosn't fit into Square; Square dosn't fit into Circle");
            }
        }
        public static void OutputCircleAndSquareAreaAndFitDetails(Figure figureCircle, Figure figureSquare)
        {
            // To get the Area of the Circle.
            Console.WriteLine("What is the radius of the circle? Please populate and push Enter key \nNOTE:3 attempts are available otherwise random value will be taken");
            Figure circle = new Circle(figureCircle.GetValidatedInput());
            Console.WriteLine("\n\rThe area of the circle is " + circle.GetFigureArea());

            // To get the Area of the Square.
            Console.WriteLine("\nWhat is the side of the square? Please populate and push Enter key \nNOTE:3 attempts are available otherwise random value will be taken");
            Figure square = new Square(figureSquare.GetValidatedInput());
            Console.WriteLine("\n\rThe area of the square is " + square.GetFigureArea());

            // To get if Circle fits into Square or Square fits into Circle.
            GetFitFigureDetails((Circle)circle, (Square)square, (Figure)figureCircle, (Figure)figureSquare);
        }
        public static void Main(string[] args)
        {
            Figure figureCircle = new Figure();
            Figure figureSquare = new Figure();
            OutputCircleAndSquareAreaAndFitDetails((Figure) figureCircle, (Figure) figureSquare);
            Console.ReadKey();
        }
        }
}