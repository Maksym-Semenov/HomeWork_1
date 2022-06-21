using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            Console.WriteLine("\t\tTask 1");
            Console.WriteLine();
            Console.WriteLine("\tPart 1");
            Console.WriteLine();
            Console.Write("Enter variable a:\t");
            bool success1 = int.TryParse(Console.ReadLine(), out int a);
            Console.Write("Enter variable b:\t");
            bool success2 = int.TryParse(Console.ReadLine(), out int b);
            Console.WriteLine($"Sum = {a + b}");
            Console.WriteLine($"Diff = {a - b}");
            Console.WriteLine($"Mult = {a * b}");
            if (b != 0)
            {
                Console.WriteLine($"Div = {a / b}");
            }
            else
                Console.WriteLine("Divide by 0 is not allowed!");
            Console.WriteLine("For next step type Enter");
            Console.ReadKey();
            Console.WriteLine();
            //Part 2
            Console.WriteLine("\tPart 2");
            Console.WriteLine();
            Console.Write("How old are your?\t");
            bool success3 = int.TryParse(Console.ReadLine(), out int age);
            Console.WriteLine($"You are {age}");
            Console.WriteLine("For next step type Enter");
            Console.ReadKey();
            Console.WriteLine();
            //Part 3
            Console.WriteLine("\tPart 3");
            Console.WriteLine();
            Console.Write("Enter first char:\t");
            bool success4 = char.TryParse(Console.ReadLine(), out char firstChar);
            Console.Write("Enter second char:\t");
            bool success5 = char.TryParse(Console.ReadLine(), out char secondChar);
            Console.Write("Enter third char:\t");
            bool success6 = char.TryParse(Console.ReadLine(), out char thirdChar);
            Console.WriteLine($"You enter next chars: {firstChar}, {secondChar}, {thirdChar}");
            Console.WriteLine();
            //Part 4
            Console.WriteLine("\tPart 4");
            Console.WriteLine();
            Console.Write("Enter first number:\t");
            bool success7 = int.TryParse(Console.ReadLine(), out int firstNumber);
            Console.Write("Enter second number:\t");
            bool success8 = int.TryParse(Console.ReadLine(), out int secondNumber);
            if (firstNumber > 0 && secondNumber > 0)
            {
                Console.WriteLine("They are both positive!");
            }
            else
                Console.WriteLine("They aren't both positive!");
            Console.WriteLine("Good job!");
            Console.ReadKey();
        }
    }
}
