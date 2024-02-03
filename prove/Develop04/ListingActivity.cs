public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt: ");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        DateTime futureTime = DateTime.Now.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;

        while (currentTime < futureTime)
        {
            Console.Write("\n> ");
            Console.ReadLine();
            _count++;
            currentTime= DateTime.Now;
        }
        Console.WriteLine($"You listed {_count} items!\n");
        Activity.SetCount();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random prompt = new Random();
        int index = prompt.Next(0, _prompts.Count);
        return _prompts[index];

    }

}