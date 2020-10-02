using System;

namespace class1studio
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 0;
            double area;
            double circumference;
            double diameter;
            string input;
            string inputMpg;
            double mpg;
            double gallons;

            Console.WriteLine("Enter a radius: ");
            input = Console.ReadLine();
            try
            {
                radius = double.Parse(input);
            }
            catch(FormatException notNum)
            {
                Console.WriteLine("That is not a number.");
                Environment.Exit(-1);
            }
            
            while (radius <= 0)
            {
                Console.WriteLine("Can not calculate with number less than or equal to zero. Try again. ");
                input = Console.ReadLine();
                try
                {
                    radius = double.Parse(input);
                }
                catch (FormatException notNum)
                {
                    Console.WriteLine("That is not a number.");
                    Environment.Exit(-1);
                }
            }


            //area = Math.PI * Math.Pow(radius, 2);
            //circumference = 2 * Math.PI * radius;
            //diameter = 2 * radius;

            area = Circle.CalculateArea(radius);
            circumference = Circle.CalculateCircumference(radius);
            diameter = Circle.CalculateDiameter(radius);

            Console.WriteLine("The area of a circle of radius " + radius + " is: " + area);
            Console.WriteLine("The circumference of a circle of radius " + radius + " is: " + circumference);
            Console.WriteLine("The diameter of a circle of radius " + radius + " is: " + diameter);

            Console.WriteLine("Enter the miles per gallon of a car: ");
            inputMpg = Console.ReadLine();
            mpg = Double.Parse(inputMpg);
            gallons = circumference / mpg;
            Console.WriteLine("The car would use " + gallons + " gallons of gas to travel a circle with circumference " + circumference + " miles.");
        }
    }

    public class Circle
    {
        public static double CalculateArea(double rad)
        {
            return Math.PI * Math.Pow(rad, 2);
        }

        public static double CalculateCircumference(double rad)
        {
            return 2 * Math.PI * rad;
        }

        public static double CalculateDiameter(double rad)
        {
            return 2 * rad;
        }
    }

}
