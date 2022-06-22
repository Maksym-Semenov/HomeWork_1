using System;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            Console.WriteLine("\t\tHomeWork 1");
            Console.WriteLine();
            Console.WriteLine("\tPart 1");
            Console.WriteLine();
            int a = -1;
            while ( a <= 0 )
            {
                Console.Write("Enter lehgth of square:\t");
                bool success1 = int.TryParse(Console.ReadLine(), out a);
                if ( a <= 0 )
                {
                    Console.WriteLine("Value must be positive number!");
                    continue;
                }
                Console.WriteLine($"Area = { a * a }");
                Console.WriteLine($"Perimeter = { a * 4 }");
                Console.WriteLine("For next step type Enter");
                Console.ReadKey();
                Console.WriteLine();
            }
            //Part 2
            Console.WriteLine("\tPart 2");
            Console.WriteLine();
            Console.Write("What is your name?\t");
            string name = Console.ReadLine();
            int age = 0;
            while ( age <= 0 | age >= 160 )
            {
                Console.Write($"How old are you, {name}?\t");
                bool success2 = int.TryParse(Console.ReadLine(), out age);
                if ( age <= 0 | age >= 160 )
                {
                    Console.WriteLine("Your age is wrong!");
                }
            }
            Console.WriteLine($"{name}, you are {age} years old!");
            Console.WriteLine("For next step type Enter");
            Console.ReadKey();
            Console.WriteLine();
            //Part 3
            Console.WriteLine("\tPart 3");
            Console.WriteLine();
            double r = -1;
            while ( r <= 0 )
            {
                Console.Write("Enter radius of circle:\t");
                bool success3 = double.TryParse(Console.ReadLine(), out r);
                if ( r <= 0 )
                {
                    Console.WriteLine("Value must be positive number!");
                    continue;
                }
            }
            Console.WriteLine($"Length = {Math.PI * 2 * r }");
            Console.WriteLine($"Area = {Math.PI * r * r }");
            Console.WriteLine($"Volume = { Math.PI * r * r * r * ( 4.0 / 3.0 ) }");
            Console.WriteLine();
            Console.WriteLine("Thank you for your work!");
            Console.ReadKey();
        }
    }
}
