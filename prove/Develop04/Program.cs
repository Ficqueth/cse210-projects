using System;

class Program
{
    static void Main(string[] args)
    {

        bool quit = false;
        while (!quit)
        {
            Console.Clear();
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
                        BreathingActivity breathing = new BreathingActivity();
                        breathing.Run();
                        break;
                    case 2:
                        Console.Clear();
                        Activity reflecting = new Activity("Reflecting Activity.", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                        reflecting.DisplayStartingMessage();
                        Console.WriteLine("\nHow long, in seconds, would you like for your session? ");

                        break;
                    case 3:
                        Console.Clear();
                        Activity listing = new Activity("Listing Activity.", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                        listing.DisplayStartingMessage();
                        Console.WriteLine("\nHow long, in seconds, would you like for your session? ");

                        break;
                    case 4:
                        quit=true;
                        break;
                }
            }
        }
        Console.WriteLine("Exiting program.");
    }
}