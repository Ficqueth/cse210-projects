public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    public void Run()
    {
        // Display starting message
        DisplayStartingMessage();

        // Guide the user through breathing cycles
        for (int i = 0; i< _duration; i+=8)
        {
            Console.Write("\n\nBreathe in...");
            ShowCountDown(4);
            Console.Write("\nNow breathe out...");
            ShowCountDown(4);
        }

        // Display ending message
        DisplayEndingMessage();
    }
}