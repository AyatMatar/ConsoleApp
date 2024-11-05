using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            //****1****
            Console.Write("Enter the diameter of the circle: ");
            double diameter = Convert.ToDouble(Console.ReadLine());
            double circumference = Math.PI * diameter;
            Console.WriteLine("Circumference of the circle is: " + circumference);

            //******2******
            Console.Write("Enter the time in hours: ");
            double time = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the distance in meters: ");
            double distance = Convert.ToDouble(Console.ReadLine());

            double speedMetersPerHour = distance / time;
            double speedKilometersPerHour = (distance / 1000) / time;

            Console.WriteLine("Speed in meters per hour: " + speedMetersPerHour);
            Console.WriteLine("Speed in kilometers per hour: " + speedKilometersPerHour);


            //*****3****
            int a = 5;
            Console.WriteLine(++a); // Outputs 6 (pre-increment)
            Console.WriteLine(a++); // Outputs 6, then a becomes 7 (post-increment)

            //******4*****
            double number = 3.7;
            Console.WriteLine("Rounded number: " + Math.Round(number)); // Rounds to nearest integer

            double baseNumber = 2;
            double exponent = 3;
            Console.WriteLine("Power result: " + Math.Pow(baseNumber, exponent));

            //*****5*****
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            bool isLeap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

            //****6****
            Console.Write("Enter an alphabet: ");
            char ch = Convert.ToChar(Console.ReadLine());

            if (char.IsLower(ch))
                Console.WriteLine("Lowercase");
            else if (char.IsUpper(ch))
                Console.WriteLine("Uppercase");
            else
                Console.WriteLine("Not an alphabet");

            //****7****
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter an operator (+, -, *, /): ");
            char op = Console.ReadLine()[0];
            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            switch (op)
            {
                case '+':
                    Console.WriteLine("Result: " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("Result: " + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("Result: " + (num1 * num2));
                    break;
                case '/':
                    if (num2 != 0)
                        Console.WriteLine("Result: " + (num1 / num2));
                    else
                        Console.WriteLine("Cannot divide by zero.");
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }

            //*****8****
            Console.Write("Enter first number: ");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int max = (e > b) ? ((e > c) ? e : c) : ((b > c) ? b : c);
            Console.WriteLine("The maximum number is: " + max);

            //****9****
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num % 2 == 0 ? "Even" : "Odd");
        }






    }
}

