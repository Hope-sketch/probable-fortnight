using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Interactive C# Program!");

            
            Console.Write("Enter your name: ");//Asking for user input
            string name = Console.ReadLine();

            
            Console.Write("Enter your age: ");//Asking for user input
            int age = Convert.ToInt32(Console.ReadLine());

            // Calculate the year when the user will turn 100
            int yearTurn100 = DateTime.Now.Year + (100 - age);

            // Display personalized message
            Console.WriteLine($"\nHello, {name}!");
            Console.WriteLine($"You will turn 100 years old in the year {yearTurn100}.");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
