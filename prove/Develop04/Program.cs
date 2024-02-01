using System;

class Program
{
    static void Main(string[] args)
    {

        Activity breathing = new Activity();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");

        Console.Write("\nSelect a choice from the menu: ");

        int choice;
        if (int.TryParse(Console.ReadLine(), out choice))
        {
            switch(choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Welcome to the Breathing Activity.\n");
                    Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    Console.WriteLine("\nHow long, in seconds, would you like for your session? ");
                    int.TryParse(Console.ReadLine(), out int seconds);
                    breathing.ShowSpinner(seconds);

                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }
        Console.WriteLine("Exiting program.");
    }
}