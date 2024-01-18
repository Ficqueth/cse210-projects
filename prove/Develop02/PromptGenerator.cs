public class PromptGenerator
{
    public List<string> _prompts;
    public PromptGenerator()
    {

        _prompts = new List<string>
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
    }
    public string GetRandomPrompt()
{
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}