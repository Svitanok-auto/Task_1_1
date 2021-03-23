using System;

namespace ConsoleApp_Task1
{
        public class Program
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("What is the radius of the circle? Please populate and push Enter key \nNOTE:3 attempts are available otherwise random value will be taken");
                Circle circle = new Circle(Figure.GetValidatedInput());

                Console.WriteLine("\nWhat is the side of the square? Please populate and push Enter key \nNOTE:3 attempts are available otherwise random value will be taken");
                Square square = new Square(Figure.GetValidatedInput());
               
                PrintFiguresArea(circle, square);
                GetIfCircleFitsIntoSquareOrSquareFitsIntoCircle(circle, square);

                Console.ReadKey();
            }

            private static void GetIfCircleFitsIntoSquareOrSquareFitsIntoCircle(Circle circle, Square square)             
            {
                bool circleFitsIntoSquare = Figure.GetIfCircleFitsIntoSquare(circle, square);
                bool squareFitsIntoCircle = Figure.GetIfSquareFitsIntoCircle(square, circle);

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

            private static void PrintFiguresArea(Circle circle, Square square)
            {
                Console.WriteLine("\n\rThe area of the circle is " + circle.GetFigureArea());
                Console.WriteLine("\n\rThe area of the square is " + square.GetFigureArea());
            }
        }
}