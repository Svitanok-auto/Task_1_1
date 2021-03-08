using System;


namespace ConsoleApp_Task1
{
    public class Figure
    {
        private double _input { get; set; }
        public virtual double GetFigureArea()
        {
            return 0;
        }
        public Figure() { }
        public double GetValidatedInput()
        {
            int e = 0;
            while (e < 3)
            {
                string InputString = Console.ReadLine();
                if (InputString.ToString() != string.Empty) // the Convert fails when ""
                {
                    try
                    {
                        if ((InputString.IndexOf('0') != -1) && (InputString.Length == 1))
                        {
                            Console.WriteLine("Incorrect Input: Zero is not allowed");
                            e++;
                            continue;
                        }
                        else
                        {
                            char coma = ',';
                            if (InputString.IndexOf(coma) != -1)
                            {
                                InputString = InputString.Replace(",", ".");
                            }
                            _input = Convert.ToDouble(InputString);
                            Console.WriteLine("Input Value is " + _input);
                            return _input;
                        }
                    }
                    catch (SystemException sex)
                    {
                        // this class's error string
                        string LastError = sex.Message;
                        Console.WriteLine("Incorrect Input: value is not parsed correctly");
                        e++;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect Input: Empty value is not allowed");
                    e++;
                }
            }
            if (e == 3)
            {
                double minNumber = 0.5;
                double maxNumber = 5.0;
                _input = new Random().NextDouble() * (maxNumber - minNumber) + minNumber;
                Console.WriteLine("\nRandom value is " + Math.Round((_input), 2));
                return _input;
            }
            return 0;
        }
        public class Program
        {
            public static void Main(string[] args)
            {
                Figure figure = new Figure();

                // To get the Area of the Circle
                Console.WriteLine("What is the radius of the circle? Please populate and push Enter key \nNOTE:3 attempts are available otherwise random value will be taken");
                double Radius = figure.GetValidatedInput();
                Figure circle = new Circle(Radius);
                double MainResultCircle = circle.GetFigureArea();
                Console.WriteLine("\n\rThe area of the circle is " + MainResultCircle);

                // To get the Area of the Square
                Console.WriteLine("\nWhat is the side of the square? Please populate and push Enter key \nNOTE:3 attempts are available otherwise random value will be taken");
                double Side = figure.GetValidatedInput();
                Figure square = new Square(Side);
                double MainResultSquare = square.GetFigureArea();
                Console.WriteLine("\n\rThe area of the square is " + MainResultSquare);

                // does square fit into the circle/circle fit into the square?
                string result = "";
                if (Radius < (Side / 2))
                {
                    result = "\r\nThe Circle fits into the Square";
                }
                if (Math.Pow(2 * Math.Pow(Side, 2), 1 / 2) < (2 * Radius))
                {
                    result = "\r\nThe Square fits into the Circle";
                }
                Console.WriteLine(result);
                Console.ReadKey();
            }
        }
    }
}