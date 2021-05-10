using System;


namespace ConsoleApp_Task1
{
    public class Figure
    {
        public const double MIN_NUMBER = 0.5;
        public const double MAX_NUMBER = 5.0;
        public const int MAX_ATTEMPTS = 3;
        private static Random _random = new Random();
        public static double Input { get; set; }
        public virtual double GetFigureArea()
        {
            return 0;
        }

        public static double GetValidatedInput()
        {
            int attempt = 0;
            while (attempt < MAX_ATTEMPTS)
            {
                string inputString = Console.ReadLine();
                if (inputString.ToString() != string.Empty) 
                {
                    try
                    {
                        if ((inputString.IndexOf('0') != -1) && (inputString.Length == 1))
                        {
                            Console.WriteLine("Incorrect Input: Zero is not allowed");
                            attempt++;
                            continue;
                        }
                        else
                        {
                            Input = Convert.ToDouble(inputString, System.Globalization.CultureInfo.InvariantCulture);
                            Console.WriteLine("Input Value is " + Math.Round((Input), 2));
                            return Math.Round((Input), 2);
                        }
                    }
                    catch (SystemException se)
                    {
                        string lastError = se.Message;
                        Console.WriteLine("Incorrect Input: value is not parsed correctly");
                        attempt++;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect Input: Empty value is not allowed");
                    attempt++;
                }
            }
            if (attempt == MAX_ATTEMPTS)
            {
                return GetRandomValue();
            }
            return 0;
        }

        public static double GetRandomValue()
        {
            Input = _random.NextDouble() * (MAX_NUMBER - MIN_NUMBER) + MIN_NUMBER;
            Console.WriteLine("\nRandom value is " + Math.Round((Input), 2));
            return Math.Round((Input), 2);
        }

        public static bool DoesCircleFitIntoSquare(Circle circle, Square square)
        {
            return (circle.Radius < (square.Side / 2));
        }

        public static bool DoesSquareFitIntoCircle(Square square, Circle circle)
        {
            return (Math.Sqrt(2 * Math.Pow(square.Side, 2)) < (2 * circle.Radius));
        }
    }
}