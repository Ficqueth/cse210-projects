using System;
using System.Diagnostics.Metrics;

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
                        ReflectingActivity reflecting = new ReflectingActivity();
                        reflecting.Run();
                        break;
                    case 3:
                        Console.Clear();
                        ListingActivity listing = new ListingActivity();
                        listing.Run();
                        break;
                    case 4:
                        Console.Clear();
                        Activity activity = new Activity();
                        Console.WriteLine($"You have done {Activity.GetCount()} activities.");
                        activity.ShowSpinner(10);
                        break;
                    case 5:
                        quit=true;
                        break;
                }
            }
        }
        Console.WriteLine("Exiting program.");
    }
}

// I added option 4 that keep track and can display a counter of how many activities were done.
// Because of that I had to create 2 more methods ( SetCount and Getcount in the Activity class)