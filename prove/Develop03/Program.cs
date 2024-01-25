using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();
        scriptures.Add(new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."));
        scriptures.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."));
        scriptures.Add(new Scripture(new Reference("Joshua", 24, 15), "But if serving the Lord seems undesirable to you, then choose for yourselves this day whom you will serve, whether the gods your ancestors served beyond the Euphrates, or the gods of the Amorites, in whose land you are living. But as for me and my household, we will serve the Lord."));
        scriptures.Add(new Scripture(new Reference("Ether", 12, 12), "For if there be no faith among the children of men God can do no miracle among them; wherefore, he showed not himself until after their faith."));
        scriptures.Add(new Scripture(new Reference("Proverbs", 28, 20), "A faithful man shall abound with blessings: but he that maketh haste to be rich shall not be innocent."));
        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

       do
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit:");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        } while (!scripture.IsCompletelyHidden());
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}