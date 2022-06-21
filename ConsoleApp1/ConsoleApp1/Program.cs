using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1

            Console.WriteLine("Enter the value of the side of the square:");

            string inputTheValueOfTheSide = Console.ReadLine();
            double valueOfSideOfTheSquare = Convert.ToDouble(inputTheValueOfTheSide);

            if (valueOfSideOfTheSquare < 0)
            {
                Console.WriteLine("The area cannot be negative");
            }
            else
            {
                Console.WriteLine("The perimeter of the square: {0} \t" +
                    "Square area: {1}", valueOfSideOfTheSquare * 4, valueOfSideOfTheSquare * valueOfSideOfTheSquare);
            }

            Console.WriteLine();

            // Task 2

            Console.WriteLine("What is your name?");

            string InputNameOfUser = Console.ReadLine();

            Console.WriteLine("How old are you?");

            string InputAgeOfUser = Console.ReadLine();
            int AgeOfUser = Convert.ToInt32(InputAgeOfUser);

            Console.WriteLine("Name: {0} \t" +
                "Age: {1}", InputNameOfUser, AgeOfUser);

            Console.WriteLine();

            // Task 3

            Console.WriteLine("Enter the radius of the circle:");

            string InputRadiusOfTheCircle = Console.ReadLine();
            double radiusOfTheCircle = Convert.ToDouble(InputRadiusOfTheCircle);

            Console.WriteLine("Length: {0:F2} \t" +
                "Area: {1:F2} \t" +
                "Volume: {2:F2}", 2 * radiusOfTheCircle * Math.PI, Math.PI * radiusOfTheCircle * radiusOfTheCircle, (4 / 3) * Math.PI * radiusOfTheCircle * radiusOfTheCircle * radiusOfTheCircle);

            Console.ReadKey();
        }

    }
}
