using System;
using System.Configuration.Assemblies;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int number = PromptUserNumber();

        int squaredNumber = SquareNumber(number);

        DisplayResult(userName, squaredNumber);
    }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());

            return number;
        }
        static int SquareNumber(int number)
        {
            int squared = number * number;
            return squared;
        }
        static void DisplayResult(string userName, int squared)
        {
            Console.WriteLine($"{userName}, the square of your number is {squared}");
        }

}
