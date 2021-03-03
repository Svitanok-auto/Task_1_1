using System;


namespace ConsoleApp1_1
{
    public class Figure
    {
        public double input;

        public Figure(double RadiusOrSide)
        {
            input = RadiusOrSide;
        }

        static double CalcCircle(double a)
        {
            const double Pi = Math.PI;
            double result = Math.Round((a * a * Pi), 2);
            return result;
        }

        static double CalcArea(double b)
        {
            double result = Math.Round(b * b, 2);
            return result;
        }

        public static void Main(string[] args)
        {
            EnterFigure(Shape.Circle);
            EnterFigure(Shape.Area);
            Console.WriteLine("The end");
            Console.ReadKey();
        }

        enum Shape
        {
            Circle,
            Area
        }

        static void EnterFigure(Shape shape)
        {
            switch (shape)
            {
                case Shape.Circle:

                    Console.WriteLine("What is the radius of the circle? Please populate and push Enter key \nNOTE:3 attempts are available otherwise random value will be taken");
                    double MainResultCircle = CalcCircle(ReturnRadiusOrSide());
                    Console.WriteLine("\n\rThe square of the circle is " + MainResultCircle);
                    break;

                case Shape.Area:

                    Console.WriteLine("\nWhat is the side of the square? Please populate and push Enter key \nNOTE:3 attempts are available otherwise random value will be taken");
                    double MainResultArea = CalcArea(ReturnRadiusOrSide());
                    Console.WriteLine("\n\rThe square of the area is " + MainResultArea);
                    break;
            }
        }

        public static double ReturnRadiusOrSide()
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
                            Console.WriteLine("\nIncorrect Input: Zero is not allowed");
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
                            else
                            {

                            }
                            double RadiusOrSideTest = Convert.ToDouble(InputString);
                            var CircleOrArea = new Figure(RadiusOrSideTest) { };
                            Console.WriteLine("\nInput Value is " + CircleOrArea.input);
                            return CircleOrArea.input;
                        }
                    }

                    catch (SystemException sex)
                    {
                        // this class's error string
                        string LastError = sex.Message;
                        Console.WriteLine("\nIncorrect Input: value is not parsed correctly");
                        e++;
                    }
                }
                else
                {
                    Console.WriteLine("\nIncorrect Input: Empty value is not allowed");
                    e++;
                }
            }

            if (e == 3)
            {
                double minNumber = 0.5;
                double maxNumber = 5.0;
                double RadiusOrSide = new Random().NextDouble() * (maxNumber - minNumber) + minNumber;
                Figure OtherCircleOrArea = new Figure(RadiusOrSide) { };
                Console.WriteLine("\nRandom value is " + Math.Round((OtherCircleOrArea.input),2));
                return OtherCircleOrArea.input;

            }
            return 0;
        }

    }
}
