public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity() : base("Reflecting Activity.", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        Activity.SetCount();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random prompt = new Random();
        int index = prompt.Next(0, _prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random question = new Random();
        int index = question.Next(0, _questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt: \n");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue. ");
        Console.ReadLine();
        
    }

    public void DisplayQuestions()
    {
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may being in: ");
        ShowCountDown(3);
        Console.Clear();
        string question1 = GetRandomQuestion();
        int timing = _duration/2; // Splitting the _duration in half so we can get 2 questions within that time
        Console.Write($"> {question1} ");
        ShowSpinner(timing); 
        string question2 = GetRandomQuestion();
        Console.Write($"\n> {question2} ");
        ShowSpinner(timing);
    }
}