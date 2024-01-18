using System;

namespace DailyJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal theJournal = new Journal();

            List<string> prompts = new List<string>
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?",
                "What is a small victory or achievement that made you happy today?",
                "Describe a moment when you felt grateful or appreciative.",
                "If you could give advice to your future self, what would it be?",
        };

            bool quit = false;
            while (!quit)
            {
                Console.WriteLine("Please Select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");

                Console.Write("\nWhat would you like to do? ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            string prompt = GetRandomPrompt(prompts);
                            theJournal.AddEntry(prompt);
                            break;
                        case 2:
                            theJournal.DisplayAll();
                            break;
                        case 3:
                            theJournal.LoadFromFile();
                            break;
                        case 4:
                            theJournal.SaveToFile();
                            break;
                        case 5:
                            quit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again");
                            break;
                    }
                }
            }
            Console.WriteLine("Exiting program.");
        }

        static string GetRandomPrompt(List<string> prompts)
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}