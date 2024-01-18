    using System;
    
    class Program
    {
        static void Main(string[] args)
        {
            Journal theJournal = new Journal();
            PromptGenerator promptGenerator = new PromptGenerator();

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
                            string prompt = promptGenerator.GetRandomPrompt();
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

    }